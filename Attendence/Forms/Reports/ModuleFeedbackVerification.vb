Public Class ModuleFeedbackVerification

    Private m_try As MarkingTry
    Private m_classGroup As ClassGroup
    Private m_lst As New List(Of ReportItem)

    Private Class ReportItem
        Public Property StudentID As String
        Public Property Outcome As String
        Public Property Status As OutcomeResultStatusEnum
        Public Property Feedback As String
    End Class
    Public Sub New(group As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = group
    End Sub
    Private Sub FirstTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FirstTryToolStripMenuItem.Click
        m_try = MarkingTry.FirstTry
        loaddata()
    End Sub
    Private Sub LoadData()
        Dim item As ReportItem
        m_lst.Clear()
        For Each cls As SchoolClass In m_classGroup.Classes
            For Each stu As Student In cls.Students
                For Each asmt In stu.AssignmentsBTEC
                    For Each oc As OutcomeResult In asmt.Outcomes
                        item = New ReportItem
                        item.StudentID = stu.StudentID
                        item.Outcome = oc.BaseOutcome.Name
                        m_lst.Add(item)
                        Select Case m_try
                            Case MarkingTry.FirstTry
                                item.Status = oc.FirstTryStatus
                                item.Feedback = oc.FirstTryComments
                            Case MarkingTry.SecondTry
                                item.Status = oc.FirstTryStatus
                                item.Feedback = oc.SecondTryComments
                            Case MarkingTry.ThirdTry
                                item.Status = oc.ThirdTryStatus
                                item.Feedback = oc.ThirdTryComments
                        End Select
                    Next
                Next
            Next
        Next
        olvFeedback.SetObjects(m_lst)
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        m_try = MarkingTry.SecondTry
        LoadData()
    End Sub

    Private Sub SecondRedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SecondRedoToolStripMenuItem.Click
        m_try = MarkingTry.ThirdTry
        LoadData()
    End Sub
End Class
