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
        Dim item As ImprovementItem = olvImprovementItems.GetSelectedObject()

        If item Is Nothing Then
            MessageBox.Show("Please select an item to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            olvImprovementItems.RemoveObject(item)
            ThisSemester.ImprovementItems.Remove(item)
        End If

    End Sub
End Class