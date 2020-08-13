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
Public Class AssignmentResults

    Private m_classGroup As ClassGroup
    Private m_assignment As ClassAssignmentBTEC
    Private m_lstResults As New List(Of AssignmentReportResult)
    Private m_try As Semester.MarkingTry

    Public Sub New(classGroup As ClassGroup, asmt As ClassAssignmentBTEC)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = classGroup
        m_assignment = asmt

        Me.Text &= " - " & asmt.Name
    End Sub
    Private Sub LoadData()
        '-- Logic is: Check each student in group 
        '   check each assignment matching baseassignment for each student and count failed outcomes
        '   if no assignment matching base assignment, then failed all
        Dim intPassed, intFailed, intNoSubmit, intTotalStudents, intTotalSubmits As Integer

        m_lstResults.Clear()
        Dim dataItem As AssignmentReportResult
        Dim boolPassed As Boolean
        Dim boolAssignmentProcessed As Boolean '-- did student submit this assignment?

        For Each clas As SchoolClass In m_classGroup.Classes
            For Each stu As Student In clas.Students
                dataItem = New AssignmentReportResult()
                dataItem.Student = stu
                m_lstResults.Add(dataItem)
                intTotalStudents += 1
                boolPassed = True '-- assume pass
                boolAssignmentProcessed = False
                For Each asmt As StudentAssignmentBTEC In stu.AssignmentsBTEC
                    If asmt.BaseAssignment Is m_assignment Then
                        boolAssignmentProcessed = True

                        dataItem.FailedOutcomes = asmt.AvailableOutcomes - asmt.AchievedOutcomesAtGradeAndTry(BTECGradeGroup.Pass, m_try)
                        dataItem.AchievedMerit = asmt.AchievedMerit
                        dataItem.AchievedDistinction = asmt.AchievedDistinction

                        'For Each outcom As OutcomeResult In asmt.Outcomes
                        '    If FirstTryToolStripMenuItem.Checked Then
                        '        If outcom.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                        '            dataItem.FailedOutcomes += 1
                        '            boolPassed = False
                        '        ElseIf outcom.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                        '            dataItem.FailedOutcomes = -1
                        '            intNoSubmit += 1
                        '            Exit Do '-- This student did not submit (or would not have unknown status)
                        '        End If
                        '    ElseIf RedoToolStripMenuItem.Checked Then
                        '        If outcom.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                        '            dataItem.FailedOutcomes += 1
                        '            boolPassed = False
                        '        ElseIf outcom.SecondTryStatus = OutcomeResultStatusEnum.Unknown AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                        '            dataItem.FailedOutcomes = -1
                        '            intNoSubmit += 1
                        '            Exit Do '-- This student did not submit (or would not have unknown status)
                        '        End If
                        '    ElseIf SecondRedoToolStripMenuItem.Checked Then
                        '        If outcom.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso outcom.SecondTryStatus <> OutcomeResultStatusEnum.Achieved Then
                        '            dataItem.FailedOutcomes += 1
                        '            boolPassed = False
                        '        ElseIf outcom.ThirdTryStatus = OutcomeResultStatusEnum.Unknown AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso outcom.SecondTryStatus <> OutcomeResultStatusEnum.Achieved Then
                        '            dataItem.FailedOutcomes = -1
                        '            intNoSubmit += 1
                        '            Exit Do '-- This student did not submit (or would not have unknown status)
                        '        End If
                        '    Else
                        '        '-- should never get here
                        '        Application.DoEvents()
                        '    End If
                        'Next

                        'dataItem.M1Achieved = asmt.M1Achieved
                        'dataItem.M2Achieved = asmt.M2Achieved
                        'dataItem.M3Achieved = asmt.M3Achieved
                        'dataItem.D1Achieved = asmt.D1Achieved
                        'dataItem.D2Achieved = asmt.D2Achieved
                        'dataItem.D3Achieved = asmt.D3Achieved

                        'If boolPassed Then
                        '    intPassed += 1
                        'Else
                        '    intFailed += 1
                        'End If
                    End If

                Next '-- asmt

                '-- finished processing all assignments for student
                '   if not here, didn't submit
                If Not boolAssignmentProcessed Then
                    dataItem.FailedOutcomes = m_assignment.OutcomesAtGrade(BTECGradeGroup.Pass)
                    intNoSubmit += 1
                Else
                    If dataItem.FailedOutcomes > 0 Then
                        intFailed += 1
                    Else
                        intPassed += 1
                    End If
                End If
            Next
        Next

        olvStudents.SetObjects(m_lstResults)
        For Each grp As BrightIdeasSoftware.OLVGroup In olvStudents.OLVGroups
            grp.Collapsed = True
        Next

        intTotalSubmits = intPassed + intFailed
        lblPass.Text = intPassed.ToString("#,##0")
        lblFail.Text = intFailed.ToString("#,##0")
        lblNoSubmit.Text = intNoSubmit.ToString("#,##0")
        Dim dblResult As Double

        dblResult = intPassed / intTotalStudents
        lblPassPercent.Text = dblResult.ToString("##0%")

        dblResult = intFailed / intTotalStudents
        lblFailPercent.Text = dblResult.ToString("##0%")

        dblResult = intNoSubmit / intTotalStudents
        lblNoSubmitPercent.Text = dblResult.ToString("##0%")

        dblResult = intPassed / intTotalSubmits
        lblPassPercentSubmit.Text = dblResult.ToString("##0%")

        dblResult = intFailed / intTotalSubmits
        lblFailPercentSubmit.Text = dblResult.ToString("##0%")

    End Sub

    Private Sub FirstTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FirstTryToolStripMenuItem.Click
        m_try = Semester.MarkingTry.FirstTry
        lblSubmissionAttempt.Text = "First submission"
        FirstTryToolStripMenuItem.Checked = True
        RedoToolStripMenuItem.Checked = False
        SecondRedoToolStripMenuItem.Checked = False
        LoadData()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        m_try = Semester.MarkingTry.SecondTry
        lblSubmissionAttempt.Text = "First rework"
        FirstTryToolStripMenuItem.Checked = False
        RedoToolStripMenuItem.Checked = True
        SecondRedoToolStripMenuItem.Checked = False
        LoadData()
    End Sub

    Private Sub SecondRedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SecondRedoToolStripMenuItem.Click
        m_try = Semester.MarkingTry.ThirdTry
        lblSubmissionAttempt.Text = "Second rework"
        FirstTryToolStripMenuItem.Checked = False
        RedoToolStripMenuItem.Checked = False
        SecondRedoToolStripMenuItem.Checked = True
        LoadData()
    End Sub

    Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
        EditSelectedStudent()
    End Sub
    Private Sub EditSelectedStudent()
        Using frm As New StudentDetail(CType(olvStudents.SelectedObject, AssignmentReportResult).Student)
            If frm.ShowDialog = DialogResult.OK Then
                olvStudents.RefreshSelectedObjects()
            End If
        End Using
    End Sub
End Class

Public Class AssignmentReportResult
    Public Property Student As Student
    'Public Property StudentID As String
    'Public Property Nickname As String
    Public Property SchoolClassName As String
    Public Property FailedOutcomes As Integer
    Public Property AchievedMerit As Boolean
    Public Property AchievedDistinction As Boolean

    'Public ReadOnly Property PassedOutcomes
    '    Get
    '        Return AchievedAllAtGrade(BTECGradeGroup.Pass)
    '    End Get
    'End Property
    'Public ReadOnly Property AvailableOutcomes
    '    Get
    '        Return OutcomesAtGrade(BTECGradeGroup.Pass)
    '    End Get
    'End Property
    'Private Function AchievedAllAtGrade(grade As BTECGradeGroup) As Boolean
    '    Dim intAvailable As Integer = OutcomesAtGrade(grade)
    '    Dim intAchieved As Integer = AchievedOutcomesAtGrade(grade)
    '    If intAvailable > 0 Then
    '        Return intAchieved = intAvailable
    '    Else
    '        Return False '-- No outcomes at this grade, so did not achieve anything
    '    End If
    'End Function
    'Private Function OutcomesAtGrade(grade As BTECGradeGroup) As Integer
    '    Dim intReturn As Integer
    '    For Each asmtOC As AssignmentOutcome In Me.BaseAssignment.Outcomes
    '        If asmtOC.GradeGroup = grade Then
    '            intReturn += 1
    '        End If
    '    Next

    '    Return intReturn
    'End Function
    'Private Function AchievedOutcomesAtGrade(grade As BTECGradeGroup) As Integer
    '    Dim intReturn As Integer
    '    '-- First, second, or third try all count
    '    For Each ocResult As OutcomeResult In Me.Outcomes
    '        If ocResult.BaseOutcome.GradeGroup = grade Then
    '            If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
    '                ocResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
    '                ocResult.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
    '                intReturn += 1
    '            End If
    '        End If
    '    Next

    '    Return intReturn
    'End Function

    'Public Property M1Achieved As Boolean
    'Public Property M2Achieved As Boolean
    'Public Property M3Achieved As Boolean
    'Public Property D1Achieved As Boolean
    'Public Property D2Achieved As Boolean
    'Public Property D3Achieved As Boolean
End Class