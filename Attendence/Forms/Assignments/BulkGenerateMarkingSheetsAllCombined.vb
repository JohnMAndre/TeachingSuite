'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Teaching Suite Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Teaching Suite.  If Not, see < https: //www.gnu.org/licenses/>.

Public Class BulkGenerateMarkingSheetsAllCombined
    Private m_group As ClassGroup
    Private m_class As SchoolClass
    Private m_classAsmt As ClassAssignment
    Private m_studentAsmt As StudentAssignment
    Private m_try As Semester.MarkingTry
    Private m_cancel As Boolean
    Private m_ClassToProcess As SchoolClass

    Public Sub New(clsGroup As ClassGroup, cls As SchoolClass, markTry As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_group = clsGroup
        m_class = cls
        m_try = markTry


        lblAssessmentName.Text = "Combine all BTEC & normal"
        lblClassName.Text = m_class.Name
        lblModuleName.Text = m_group.Name
        lblOutputPath.Text = AppSettings.MarkingPageSaveFolder
        lblMarkingTry.Text = m_try.ToString


    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            Dim intGenerated, intSkipped As Integer

            Dim ofd As New OpenFileDialog()
            ofd.Title = "Select assignment brief to combined into"
            Dim dlrst As DialogResult = ofd.ShowDialog

            If dlrst = DialogResult.OK Then
                lblAssessmentBriefFilename.Text = ofd.FileName
            ElseIf dlrst = DialogResult.Cancel Then
                Exit Sub
            End If

            btnGenerate.Enabled = False
            m_cancel = False
            btnCancel.Enabled = True
            Application.DoEvents()


            'Dim intTotalAssignments As Integer = m_group.Assignments.Count + m_group.AssignmentsBTEC.Count

            '-- Different logic from other bulk forms
            '   We will create our own classassignment and studentassignment just to generate the output
            '   but we will not persist it. It will only be for this run.
            m_classAsmt = New ClassAssignment(m_group)
            m_classAsmt.Name = "HRM-A1.1"
            m_classAsmt.AssignmentBriefFilename = ofd.FileName
            Dim studAssignment As StudentAssignment


            Dim intCounterMax As Integer = m_ClassToProcess.Students.Count - 1
            For intCounter As Integer = 0 To intCounterMax '-- this stops MoveNextRare error
                Dim stud As Student = m_ClassToProcess.Students(intCounter)
                '-- New logic from other bulk forms
                '   We do not care if assignment is ready to process, we just process all

                studAssignment = New StudentAssignment(m_classAsmt)
                stud.Assignments.Add(studAssignment)

                studAssignment.OverallComments = String.Empty
                studAssignment.ImprovementComments = String.Empty

                '-- loop through normal assignments
                For intCounterAssignment As Integer = 0 To stud.Assignments.Count - 1
                    '-- skip the temp assignment
                    If stud.Assignments(intCounterAssignment) IsNot studAssignment Then
                        studAssignment.OverallComments &= Environment.NewLine & Environment.NewLine & "Overall feedback for " & stud.Assignments(intCounterAssignment).BaseAssignment.Name & ": " & Environment.NewLine & Environment.NewLine & stud.Assignments(intCounterAssignment).OverallComments
                        studAssignment.ImprovementComments &= Environment.NewLine & Environment.NewLine & "Improvement feedback for " & stud.Assignments(intCounterAssignment).BaseAssignment.Name & ": " & Environment.NewLine & Environment.NewLine & stud.Assignments(intCounterAssignment).ImprovementComments
                    End If
                Next

                '-- loop through btec assignments
                For intCounterAssignment As Integer = 0 To stud.AssignmentsBTEC.Count - 1
                    studAssignment.OverallComments &= Environment.NewLine & Environment.NewLine & "Overall feedback for " & stud.AssignmentsBTEC(intCounterAssignment).BaseAssignment.Name & ": " & Environment.NewLine & Environment.NewLine & stud.AssignmentsBTEC(intCounterAssignment).OverallComments
                    studAssignment.ImprovementComments &= Environment.NewLine & Environment.NewLine & "Improvement feedback for " & stud.AssignmentsBTEC(intCounterAssignment).BaseAssignment.Name & ": " & Environment.NewLine & Environment.NewLine & stud.AssignmentsBTEC(intCounterAssignment).ImprovementComments
                Next

                '-- We only process students who have an assignment which has been marked
                Using frm As New StudentAssignmentNormalDetails(stud, m_classAsmt, m_try)
                    frm.Show()
                    Application.DoEvents()
                    frm.PrepareMarkingPageSimple()
                    frm.Close()
                End Using
                intGenerated += 1
                'intSkipped += 1


                '-- remove the temp student assignment
                stud.Assignments.Remove(studAssignment)

                lblStudentsGenerated.Text = intGenerated.ToString("#,##0")
                lblStudentsSkipped.Text = intSkipped.ToString("#,##0")
                Application.DoEvents() '-- let it paint
                If m_cancel Then
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("There was an error with the batch: " & ex.Message & Environment.NewLine & Environment.NewLine & ex.StackTrace)
        Finally
            btnGenerate.Enabled = True
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        m_cancel = True
        btnCancel.Enabled = False
    End Sub

    Private Sub BulkGenerateMarkingSheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ClassIsCombinedView(m_class) Then
            Dim boolSetAlready As Boolean
            For Each objCls As SchoolClass In m_group.Classes
                If Not boolSetAlready Then
                    Dim grp As New ClassGroup(Nothing)
                    grp.UseNickname = m_group.UseNickname
                    m_ClassToProcess = New SchoolClass(grp)
                    m_ClassToProcess.Students.AddRange(objCls.Students)
                    boolSetAlready = True
                Else
                    m_ClassToProcess.Students.AddRange(objCls.Students)
                End If
            Next
        Else
            m_ClassToProcess = m_class
        End If

        lblNumberOfStudents.Text = m_ClassToProcess.Students.Count.ToString("#,##0")

    End Sub
End Class