Public Class GroupPresentationQuickFeedback

    Private Sub dgvQuickFeedback_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuickFeedback.CellClick
        If e.ColumnIndex = 0 Then
            Dim obj As QuickFeedback = GetSelectedItemFromGrid()
            Clipboard.SetText(obj.Text)
            Me.Hide()
        End If
    End Sub
    Private Sub ReloadData()
        dgvQuickFeedback.DataSource = Nothing
        dgvQuickFeedback.DataSource = AppSettings.QuickFeedbacks
        dgvQuickFeedback.AutoResizeColumns()
    End Sub

    Private Sub GroupPresentationQuickFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvQuickFeedback.AutoGenerateColumns = False
        ReloadData()
    End Sub

    Private Sub GroupPresentationQuickFeedback_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            dgvQuickFeedback.AutoResizeColumns()
        End If
    End Sub

    Private Sub AddNewQuickTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewQuickTextToolStripMenuItem.Click
        Dim txt As New QuickFeedback()
        AppSettings.QuickFeedbacks.Add(txt)
        ReloadData()
    End Sub
    Private Function GetSelectedItemFromGrid() As QuickFeedback
        Dim obj As QuickFeedback = CType(dgvQuickFeedback.CurrentRow.DataBoundItem, QuickFeedback)
        Return obj
    End Function

    Private Sub DeleteQuickTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteQuickTextToolStripMenuItem.Click
        Dim obj As QuickFeedback = GetSelectedItemFromGrid()
        AppSettings.QuickFeedbacks.Remove(obj)
        ReloadData()
    End Sub
End Class