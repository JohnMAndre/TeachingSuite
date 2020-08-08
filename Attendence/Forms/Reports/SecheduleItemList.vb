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
        LoadScheduleUnsent()
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

    Private Sub EmailClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailClassToolStripMenuItem.Click
        Try
            If Not Emailer.SetupProperly Then
                MessageBox.Show("Please go to Tools->Options on main form and select the path to TrulyMail. TrulyMail must be used for emailing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If olvSchedule.SelectedObjects.Count = 0 Then
                    MessageBox.Show("Please select at least one item for sending.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim objEmail As New Emailer()
                    Dim intAccount As Integer
                    Dim strSubject As String
                    For Each item As ActualSessionItem In olvSchedule.SelectedObjects
                        objEmail.Recipients.Add(New EmailRecipient(item.SchoolClass.Name, item.SchoolClass.EmailAddress))
                        intAccount = item.SchoolClass.EmailSendingAccount '-- so we will use the last one
                        strSubject = item.Topic
                    Next
                    objEmail.Subject = strSubject
                    objEmail.Send(intAccount, False, 0)
                End If
            End If

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error emailing: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SecheduleItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
