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
Public Class ScheduledItemListPlain

    Private m_lstCurrentScheduleItems As New List(Of ActualSessionItem)


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ReloadUnsentItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadUnsentItemsToolStripMenuItem.Click
        LoadItems(True)
    End Sub

    Private Sub ReloadAllItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadAllItemsToolStripMenuItem.Click
        LoadItems(False)
    End Sub
    Private Sub LoadItems(unsent As Boolean)
        dgvScheduleItems.DataSource = Nothing
        m_lstCurrentScheduleItems.Clear()
        For Each grp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In grp.Classes
                For Each item As ActualSessionItem In cls.ActualSessions
                    If (Not unsent) OrElse (Not item.StudentsEmailed) Then
                        m_lstCurrentScheduleItems.Add(item)
                    End If
                Next
            Next
        Next
        m_lstCurrentScheduleItems.Sort()

        dgvScheduleItems.AutoGenerateColumns = False
        dgvScheduleItems.DataSource = m_lstCurrentScheduleItems
        dgvScheduleItems.AutoResizeColumns()
    End Sub
    Private Sub LoadUnpreppedItems()
        dgvScheduleItems.DataSource = Nothing
        m_lstCurrentScheduleItems.Clear()
        For Each grp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In grp.Classes
                For Each item As ActualSessionItem In cls.ActualSessions
                    If Not item.Prepped Then
                        m_lstCurrentScheduleItems.Add(item)
                    End If
                Next
            Next
        Next
        m_lstCurrentScheduleItems.Sort()

        dgvScheduleItems.AutoGenerateColumns = False
        dgvScheduleItems.DataSource = m_lstCurrentScheduleItems
        dgvScheduleItems.AutoResizeColumns()
    End Sub
    Private Sub FindItemsFromSearchText()

        Dim strSearchFor As String
        If txtFilter.Text.Length = 0 Then
            dgvScheduleItems.DataSource = m_lstCurrentScheduleItems
            'ShowStudentCount()
        Else
            strSearchFor = txtFilter.Text.ToLower
            Dim lstFiltered As List(Of ActualSessionItem) = m_lstCurrentScheduleItems.Where(Function(x) x.SchoolClass.Name.ToLower.Contains(strSearchFor) OrElse
                                                                                 x.SchoolClass.ClassGroup.Name.ToLower.Contains(strSearchFor) OrElse
                                                                                 x.Topic.ToLower.Contains(strSearchFor) OrElse
                                                                                 x.Location.ToLower.Contains(strSearchFor)).ToList()

            dgvScheduleItems.DataSource = lstFiltered
            'ShowStudentCount(lstFiltered)
        End If
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindItemsFromSearchText()
        End If
    End Sub

    Private Sub pbClearFilter_Click(sender As Object, e As EventArgs) Handles pbClearFilter.Click
        txtFilter.Text = String.Empty
        FindItemsFromSearchText()
    End Sub

    Private Sub ClearFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFilterToolStripMenuItem.Click
        txtFilter.Text = String.Empty
        FindItemsFromSearchText()
        txtFilter.Focus()
    End Sub

    Private Sub ReloadUnpreppedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadUnpreppedItemsToolStripMenuItem.Click
        LoadUnpreppedItems()
    End Sub
End Class