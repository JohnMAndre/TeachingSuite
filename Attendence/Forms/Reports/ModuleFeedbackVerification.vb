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
Public Class ModuleFeedbackVerification

    Private m_try As Semester.MarkingTry
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
        m_try = Semester.MarkingTry.FirstTry
        LoadData()
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
                            Case Semester.MarkingTry.FirstTry
                                item.Status = oc.FirstTryStatus
                                item.Feedback = oc.FirstTryComments
                            Case Semester.MarkingTry.SecondTry
                                item.Status = oc.FirstTryStatus
                                item.Feedback = oc.SecondTryComments
                            Case Semester.MarkingTry.ThirdTry
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
        m_try = Semester.MarkingTry.SecondTry
        LoadData()
    End Sub

    Private Sub SecondRedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SecondRedoToolStripMenuItem.Click
        m_try = Semester.MarkingTry.ThirdTry
        LoadData()
    End Sub
End Class
