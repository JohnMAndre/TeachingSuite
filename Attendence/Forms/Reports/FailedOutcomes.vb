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
Public Class FailedOutcomes

    Private m_classGroup As ClassGroup
    Dim m_try As Semester.MarkingTry
    Private m_lstResults As New List(Of FailedOutcomeReportResult)

    Public Sub New(classGroup As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = classGroup

        Me.Text &= " - " & classGroup.Name
    End Sub

    Private Sub FirstTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FirstTryToolStripMenuItem.Click
        FirstTryToolStripMenuItem.Checked = True
        RedoToolStripMenuItem.Checked = False
        SecondRedoToolStripMenuItem.Checked = False
        m_try = Semester.MarkingTry.FirstTry
        LoadData()
    End Sub

    Private Sub LoadData()
        '-- Logic is: Check each student in group 
        '   for each base assignment for group
        '   check each assignment matching baseassignment for each student and count failed outcomes
        '   if no assignment matching base assignment, then failed all

        m_lstResults.Clear()
        Dim dataItem As FailedOutcomeReportResult
        Dim rslt As Student.QuickAssignmentResults

        Dim intTotalOutcomes As Integer
        For Each asmt As ClassAssignmentBTEC In m_classGroup.AssignmentsBTEC
            intTotalOutcomes += asmt.Outcomes.Count
        Next


        For Each clas As SchoolClass In m_classGroup.Classes
            For Each stu As Student In clas.Students


                If FirstTryToolStripMenuItem.Checked Then
                    rslt = stu.GetQuickAssignmentResults(Semester.MarkingTry.FirstTry)
                ElseIf RedoToolStripMenuItem.Checked Then
                    rslt = stu.GetQuickAssignmentResults(Semester.MarkingTry.SecondTry)
                ElseIf SecondRedoToolStripMenuItem.Checked Then
                    rslt = stu.GetQuickAssignmentResults(Semester.MarkingTry.ThirdTry)
                Else
                    Continue For '-- should never get here
                End If

                Dim details As Student.DetailAssignmentResults = stu.GetDetailedAssignmentResults(m_try)
                Dim boolFailed As Boolean
                Dim strComments As String
                Dim objBaseOutcome As AssignmentOutcome

                For Each outcom As OutcomeResult In details.Outcomes
                    If outcom.BaseOutcome.GradeGroup = BTECGradeGroup.Pass Then
                        boolFailed = False
                        Select Case m_try
                            Case Semester.MarkingTry.FirstTry
                                If outcom.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                                    boolFailed = True
                                    objBaseOutcome = outcom.BaseOutcome
                                    If outcom.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                        strComments = outcom.FirstTryComments
                                    Else
                                        '-- unknown
                                        strComments = "Did not submit"
                                    End If

                                End If
                            Case Semester.MarkingTry.SecondTry
                                If outcom.SecondTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                                    boolFailed = True
                                    objBaseOutcome = outcom.BaseOutcome
                                    If outcom.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                        strComments = outcom.SecondTryComments
                                    Else
                                        '-- unknown
                                        strComments = "Did not submit"
                                    End If
                                End If
                            Case Semester.MarkingTry.ThirdTry
                                If outcom.ThirdTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso outcom.SecondTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                                    boolFailed = True
                                    objBaseOutcome = outcom.BaseOutcome
                                    If outcom.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                        strComments = outcom.ThirdTryComments
                                    Else
                                        '-- unknown
                                        strComments = "Did not submit"
                                    End If
                                End If
                        End Select

                        If boolFailed Then
                            dataItem = New FailedOutcomeReportResult()
                            dataItem.StudentID = stu.StudentID
                            dataItem.Nickname = stu.Nickname
                            dataItem.SchoolClassName = stu.SchoolClass.Name

                            dataItem.Comments = strComments
                            dataItem.BaseOutcome = objBaseOutcome
                            m_lstResults.Add(dataItem)
                        End If
                    End If
                Next
            Next
        Next

        olvStudents.SetObjects(m_lstResults)

    End Sub

    Private Sub TurnOffGroupsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TurnOffGroupsToolStripMenuItem.Click
        olvStudents.ShowGroups = False
    End Sub

    Private Sub TurnOnGroupsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TurnOnGroupsToolStripMenuItem.Click
        olvStudents.ShowGroups = True
    End Sub

    Private Sub CollapseAllGroupsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CollapseAllGroupsToolStripMenuItem.Click
        If olvStudents.OLVGroups IsNot Nothing Then
            For Each grp As BrightIdeasSoftware.OLVGroup In olvStudents.OLVGroups
                grp.Collapsed = True
            Next
        End If
    End Sub

    Private Sub ExpandAllGroupsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExpandAllGroupsToolStripMenuItem.Click
        If olvStudents.OLVGroups IsNot Nothing Then
            For Each grp As BrightIdeasSoftware.OLVGroup In olvStudents.OLVGroups
                grp.Collapsed = False
            Next
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        FirstTryToolStripMenuItem.Checked = False
        RedoToolStripMenuItem.Checked = True
        SecondRedoToolStripMenuItem.Checked = False
        m_try = Semester.MarkingTry.SecondTry
        LoadData()
    End Sub

    Private Sub SecondRedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecondRedoToolStripMenuItem.Click
        FirstTryToolStripMenuItem.Checked = False
        RedoToolStripMenuItem.Checked = False
        SecondRedoToolStripMenuItem.Checked = True
        m_try = Semester.MarkingTry.ThirdTry
        LoadData()
    End Sub
End Class

Public Class FailedOutcomeReportResult
    Public Property StudentID As String
    Public Property Nickname As String
    Public Property SchoolClassName As String
    Public Property BaseOutcome As AssignmentOutcome
    Public Property Comments As String = String.Empty
End Class