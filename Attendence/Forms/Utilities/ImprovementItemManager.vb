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
Public Class ImprovementItemManager

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ImprovementItemManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        olvImprovementItems.SetObjects(ThisSemester.ImprovementItems)
    End Sub

    Private Sub NewImprovementItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewImprovementItemToolStripMenuItem.Click
        Dim item As New ImprovementItem()
        item.Name = "New item"
        ThisSemester.ImprovementItems.Add(item)
        olvImprovementItems.AddObject(item)
    End Sub

    Private Sub DeleteSelectedImprovementItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedImprovementItemToolStripMenuItem.Click
        Dim item As ImprovementItem = CType(olvImprovementItems.SelectedObject, ImprovementItem)

        If item Is Nothing Then
            MessageBox.Show("Please select an item to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            olvImprovementItems.RemoveObject(item)
            ThisSemester.ImprovementItems.Remove(item)
        End If

    End Sub

    Private Sub MoveItemupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveItemupToolStripMenuItem.Click
        Dim item As ImprovementItem = CType(olvImprovementItems.SelectedObject, ImprovementItem)
        Dim intOldID As Integer = item.OrderingID
        Dim intNewID As Integer = intOldID - 1
        item.OrderingID = intNewID
        olvImprovementItems.RefreshObject(item)

        '-- change positions with other
        For Each other As ImprovementItem In ThisSemester.ImprovementItems
            If other.OrderingID = intNewID Then
                other.OrderingID = intOldID
                olvImprovementItems.RefreshObject(other)
                Exit For
            End If
        Next
    End Sub

    Private Sub EditSelectedImprovementItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedImprovementItemToolStripMenuItem.Click
        Dim item As ImprovementItem = CType(olvImprovementItems.SelectedObject, ImprovementItem)
        Dim frm As New ImprovementItemDetails(item)
        frm.Show()
    End Sub

    Private Sub MoveItemdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveItemdownToolStripMenuItem.Click
        Dim item As ImprovementItem = CType(olvImprovementItems.SelectedObject, ImprovementItem)
        Dim intOldID As Integer = item.OrderingID
        Dim intNewID As Integer = intOldID + 1
        item.OrderingID = intNewID
        olvImprovementItems.RefreshObject(item)

        '-- change positions with other
        For Each other As ImprovementItem In ThisSemester.ImprovementItems
            If other.OrderingID = intNewID AndAlso other.ID <> item.ID Then '-- do not get the one we just changed, just the other
                other.OrderingID = intOldID
                olvImprovementItems.RefreshObject(other)
                Exit For
            End If
        Next
    End Sub
End Class