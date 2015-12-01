Public Class AssignmentDocumentSelector
    Public Sub New(files() As String)

        ' This call is required by the designer.
        InitializeComponent()

        For Each strFilename As String In files
            lstAssignments.Items.Add(strFilename)
        Next
    End Sub

    Public ReadOnly Property SelectedFilename As String
        Get
            Return lstAssignments.Items(lstAssignments.SelectedIndex)
        End Get
    End Property

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnPreview_Click(sender As System.Object, e As System.EventArgs) Handles btnPreview.Click
        System.Diagnostics.Process.Start(lstAssignments.Items(lstAssignments.SelectedIndex))
    End Sub
End Class
