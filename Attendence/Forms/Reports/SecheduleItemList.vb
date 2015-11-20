Public Class SecheduleItemList

    Private m_lstCurrentScheduleItems As New List(Of ActualSessionItem)

    Private Sub LoadScheduleUnsent()
        m_lstCurrentScheduleItems.Clear()
        For Each grp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In grp.Classes
                For Each item As ActualSessionItem In cls.ActualSessions
                    If Not item.StudentsEmailed Then
                    m_lstCurrentScheduleItems.Add(item)
                    End If
                Next
            Next
        Next
        m_lstCurrentScheduleItems.Sort()
        olvSchedule.SetObjects(m_lstCurrentScheduleItems)
    End Sub
    Private Sub LoadSchedule()
        m_lstCurrentScheduleItems.Clear()
        For Each grp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In grp.Classes
                For Each item As ActualSessionItem In cls.ActualSessions
                    m_lstCurrentScheduleItems.Add(item)
                Next
            Next
        Next
        m_lstCurrentScheduleItems.Sort()
        olvSchedule.SetObjects(m_lstCurrentScheduleItems)
    End Sub

    Private Sub llblLoadAllSessions_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblLoadAllSessions.LinkClicked
        LoadSchedule()
    End Sub

    Private Sub llblLoadUnsentSessions_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblLoadUnsentSessions.LinkClicked
        LoadScheduleUnsent
    End Sub

    Private Sub txtStudentFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged
        tmrFilterSessions.Stop()
        tmrFilterSessions.Start()
    End Sub

    Private Sub tmrFilterSessions_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFilterSessions.Tick
        Try
            tmrFilterSessions.Stop()

            olvSchedule.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(olvSchedule, txtFilter.Text)

            If txtFilter.Text.Length = 0 Then
                olvSchedule.EmptyListMsg = "There are no sessions"
            Else
                olvSchedule.EmptyListMsg = "No sessions match your filter"
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error filtering scheduled sessions: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub llblClearFilter_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearFilter.LinkClicked
        txtFilter.Text = String.Empty
        txtFilter.Focus()
    End Sub
End Class
