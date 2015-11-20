Public Class AssignmentResults

    Private m_classGroup As ClassGroup
    Private m_assignment As ClassAssignmentBTEC
    Private m_lstResults As New List(Of AssignmentReportResult)

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
        Dim boolAssignmentProcessed As Boolean

        For Each clas As SchoolClass In m_classGroup.Classes
            For Each stu As Student In clas.Students
                dataItem = New AssignmentReportResult()
                dataItem.Student = stu
                m_lstResults.Add(dataItem)
                intTotalStudents += 1
                boolPassed = True '-- assume pass
                boolAssignmentProcessed = False
                Do
                    For Each asmt As StudentAssignmentBTEC In stu.AssignmentsBTEC
                        If asmt.BaseAssignment Is m_assignment Then
                            boolAssignmentProcessed = True
                            For Each outcom As OutcomeResult In asmt.Outcomes
                                If FirstTryToolStripMenuItem.Checked Then
                                    If outcom.FirstTryStatus = OutcomeResultStatusEnum.Fail Then
                                        dataItem.FailedOutcomes += 1
                                        boolPassed = False
                                    ElseIf outcom.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                                        dataItem.FailedOutcomes = -1
                                        intNoSubmit += 1
                                        Exit Do '-- This student did not submit (or would not have unknown status)
                                    End If
                                ElseIf RedoToolStripMenuItem.Checked Then
                                    If outcom.SecondTryStatus = OutcomeResultStatusEnum.Fail AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Pass Then
                                        dataItem.FailedOutcomes += 1
                                        boolPassed = False
                                    ElseIf outcom.SecondTryStatus = OutcomeResultStatusEnum.Unknown AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Pass Then
                                        dataItem.FailedOutcomes = -1
                                        intNoSubmit += 1
                                        Exit Do '-- This student did not submit (or would not have unknown status)
                                    End If
                                ElseIf SecondRedoToolStripMenuItem.Checked Then
                                    If outcom.ThirdTryStatus = OutcomeResultStatusEnum.Fail AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Pass AndAlso outcom.SecondTryStatus <> OutcomeResultStatusEnum.Pass Then
                                        dataItem.FailedOutcomes += 1
                                        boolPassed = False
                                    ElseIf outcom.ThirdTryStatus = OutcomeResultStatusEnum.Unknown AndAlso outcom.FirstTryStatus <> OutcomeResultStatusEnum.Pass AndAlso outcom.SecondTryStatus <> OutcomeResultStatusEnum.Pass Then
                                        dataItem.FailedOutcomes = -1
                                        intNoSubmit += 1
                                        Exit Do '-- This student did not submit (or would not have unknown status)
                                    End If
                                Else
                                    '-- should never get here
                                    Application.DoEvents()
                                End If
                            Next

                            dataItem.M1Achieved = asmt.M1Achieved
                            dataItem.M2Achieved = asmt.M2Achieved
                            dataItem.M3Achieved = asmt.M3Achieved
                            dataItem.D1Achieved = asmt.D1Achieved
                            dataItem.D2Achieved = asmt.D2Achieved
                            dataItem.D3Achieved = asmt.D3Achieved

                            If boolPassed Then
                                intPassed += 1
                            Else
                                intFailed += 1
                            End If
                        End If

                    Next

                    '-- finished processing all assignments for student
                    '   if not here, didn't submit
                    If Not boolAssignmentProcessed Then
                        dataItem.FailedOutcomes = m_assignment.Outcomes.Count
                        intNoSubmit += 1
                    End If

                    Exit Do
                Loop
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

    Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
        EditSelectedStudent()
    End Sub
    Private Sub EditSelectedStudent()
        Using frm As New StudentDetail(CType(olvStudents.SelectedObject, AssignmentReportResult).Student)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
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
    Public Property M1Achieved As Boolean
    Public Property M2Achieved As Boolean
    Public Property M3Achieved As Boolean
    Public Property D1Achieved As Boolean
    Public Property D2Achieved As Boolean
    Public Property D3Achieved As Boolean
End Class