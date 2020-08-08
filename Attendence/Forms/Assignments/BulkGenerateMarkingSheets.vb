'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Foobar Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Foobar.  If Not, see < https: //www.gnu.org/licenses/>.
Friend Class BulkGenerateMarkingSheets

    Private m_group As ClassGroup
    Private m_class As SchoolClass
    Private m_asmt As ClassAssignmentBTEC
    Private m_try As Semester.MarkingTry
    Private m_cancel As Boolean
    Private m_ClassToProcess As SchoolClass

    Public Sub New(clsGroup As ClassGroup, cls As SchoolClass, asmt As ClassAssignmentBTEC, markTry As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_group = clsGroup
        m_class = cls
        m_asmt = asmt
        m_try = markTry

        lblAssessmentName.Text = m_asmt.Name
        lblClassName.Text = m_class.Name
        lblModuleName.Text = m_group.Name
        lblOutputPath.Text = AppSettings.MarkingPageSaveFolder
        lblMarkingTry.Text = m_try.ToString


    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            Dim intGenerated, intSkipped As Integer

            btnGenerate.Enabled = False
            m_cancel = False
            btnCancel.Enabled = True
            Application.DoEvents()


            Dim boolOKToProcessStudent As Boolean
            Dim intCounterMax As Integer = m_ClassToProcess.Students.Count - 1
            'For Each stud As Student In objClassToProcess.Students
            For intCounter As Integer = 0 To intCounterMax '-- See if this stops MoveNextRare error
                Dim stud As Student = m_ClassToProcess.Students(intCounter)
                boolOKToProcessStudent = False '-- reset for each student
                For Each studasmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                    If studasmt.BaseAssignment Is m_asmt Then
                        If studasmt.Processed Then
                            boolOKToProcessStudent = True
                            Exit For
                        End If
                    End If
                Next

                '-- We only process students who have an assignment which has been marked
                If boolOKToProcessStudent Then
                    Using frm As New StudentAssignmentDetails(stud, m_asmt, m_try)
                        frm.Show()
                        Application.DoEvents()
                        frm.PrepareMarkingPageSimple()
                        frm.Close()
                    End Using
                    intGenerated += 1
                Else
                    intSkipped += 1
                End If


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