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
End Class