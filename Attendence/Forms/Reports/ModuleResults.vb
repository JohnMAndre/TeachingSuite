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
Public Class ModuleResults

    Private m_classGroup As ClassGroup
    Private m_lstResults As New List(Of AssignmentReportResult)

    Public Sub New(classGroup As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = classGroup

        Me.Text &= " - " & classGroup.Name
    End Sub

    Private Sub LoadData()
        '-- Logic is: Check each student in group 
        '   for each base assignment for group
        '   check each assignment matching baseassignment for each student and count failed outcomes
        '   if no assignment matching base assignment, then failed all

        Dim intPassed, intFailed, intTotalStudents As Integer
        Dim intMerit, intDistinction As Integer

        m_lstResults.Clear()
        Dim dataItem As AssignmentReportResult
        Dim rslt As Student.StudentModuleResult

        Dim intTotalPassOutcomes As Integer '-- total pass outcomes available
        For Each oc As AssignmentOutcome In m_classGroup.Outcomes
            If oc.GradeGroup = BTECGradeGroup.Pass Then
                intTotalPassOutcomes += 1
            End If
        Next

        For Each clas As SchoolClass In m_classGroup.Classes
            For Each stu As Student In clas.Students
                dataItem = New AssignmentReportResult()
                dataItem.Student = stu
                m_lstResults.Add(dataItem)

                rslt = stu.ModuleResults(chkIncludeUnprocessed.Checked)

                dataItem.FailedOutcomes = intTotalPassOutcomes - rslt.PassOutcomesPassed

                intTotalStudents += 1

                If rslt.AchievedMerit AndAlso Not rslt.AchievedDistinction Then
                    dataItem.AchievedMerit = True '-- Merit = only merit
                    intMerit += 1
                Else
                    dataItem.AchievedMerit = False
                End If

                If rslt.AchievedDistinction Then
                    dataItem.AchievedDistinction = True
                    intDistinction += 1
                Else
                    dataItem.AchievedDistinction = False
                End If

                If dataItem.FailedOutcomes = 0 Then
                    intPassed += 1
                Else
                    intFailed += 1
                End If
            Next
        Next

        olvStudents.SetObjects(m_lstResults)
        For Each grp As BrightIdeasSoftware.OLVGroup In olvStudents.OLVGroups
            grp.Collapsed = True
        Next

        lblPass.Text = intPassed.ToString("#,##0")
        lblFail.Text = intFailed.ToString("#,##0")
        lblTotalStudents.Text = intTotalStudents.ToString("#,##0")
        lblNumberMerit.Text = intMerit.ToString("#,##0")
        lblNumberDistinction.Text = intDistinction.ToString("#,##0")

        Dim dblResult As Double

        dblResult = intPassed / intTotalStudents
        lblPassPercent.Text = dblResult.ToString("##0%")

        dblResult = intFailed / intTotalStudents
        lblFailPercent.Text = dblResult.ToString("##0%")

        dblResult = intMerit / intTotalStudents
        lblMeritPercent.Text = dblResult.ToString("##0%")

        dblResult = intDistinction / intTotalStudents
        lblDistinctionPercent.Text = dblResult.ToString("##0%")

    End Sub

    Private Sub FirstTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FirstTryToolStripMenuItem.Click
        FirstTryToolStripMenuItem.Checked = True
        RedoToolStripMenuItem.Checked = False
        SecondRedoToolStripMenuItem.Checked = False
        LoadData()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        FirstTryToolStripMenuItem.Checked = False
        RedoToolStripMenuItem.Checked = True
        SecondRedoToolStripMenuItem.Checked = False
        LoadData()
    End Sub

    Private Sub SecondRedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SecondRedoToolStripMenuItem.Click
        FirstTryToolStripMenuItem.Checked = False
        RedoToolStripMenuItem.Checked = False
        SecondRedoToolStripMenuItem.Checked = True
        LoadData()
    End Sub

    Private Sub llblClearFilter_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearFilter.LinkClicked
        txtFilter.Text = String.Empty
        txtFilter.Focus()
    End Sub

    Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged
        tmrFilter.Stop()
        tmrFilter.Start()
    End Sub
    Private Sub tmrFilterStudents_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFilter.Tick
        FilterStudents()
    End Sub
    Private Sub FilterStudents()
        Try
            tmrFilter.Stop()

            olvStudents.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(olvStudents, txtFilter.Text)

            If txtFilter.Text.Length = 0 Then
                olvStudents.EmptyListMsg = "This list is empty"
            Else
                olvStudents.EmptyListMsg = "No students match your filter"
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error filtering students: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
        Try
            Dim obj As AssignmentReportResult = CType(olvStudents.SelectedObject, AssignmentReportResult)
            Using frm As New StudentDetail(obj.Student)
                frm.ShowDialog(Me)
            End Using
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        LoadData()
    End Sub
End Class

'Public Class ModuleReportResult
'    Public Property Student As Student
'    Public Property Nickname As String
'    Public Property SchoolClassName As String
'    Public Property FailedOutcomes As Integer
'    Public Property M1Achieved As Boolean
'    Public Property M2Achieved As Boolean
'    Public Property M3Achieved As Boolean
'    Public Property D1Achieved As Boolean
'    Public Property D2Achieved As Boolean
'    Public Property D3Achieved As Boolean
'End Class