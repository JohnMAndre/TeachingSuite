Public Class AutoSaveRecovery

    Private m_strSemesterName As String

    Public Sub New(semesterName As String)

        ' This call is required by the designer.
        InitializeComponent()

        Dim fi As System.IO.FileInfo
        fi = Semester.GetAutoSaveFileInfo(semesterName)
        llblAutoSaveFileName.Text = Semester.GetAutoSaveFilename(semesterName)
        lblAutoSaveFileDate.Text = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
        lblAutoSaveFileSize.Text = FormatDataSizeString(fi.Length)


        fi = Semester.GetMainDataFileInfo(semesterName)
        llblMainFileName.Text = Semester.GetMainDataFilename(semesterName)
        lblMainFileDate.Text = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
        lblMainFileSize.Text = FormatDataSizeString(fi.Length)

        m_strSemesterName = semesterName
    End Sub
    Private Sub btnDeleteAutoSave_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteAutoSave.Click
        Semester.DiscardAutoSaveFile(m_strSemesterName)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnUseAutoSave_Click(sender As System.Object, e As System.EventArgs) Handles btnUseAutoSave.Click
        Semester.UseAutoSaveFile(m_strSemesterName)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub SelectInExplorer(filename As String)
        If Not System.IO.File.Exists(filename) Then
            MessageBox.Show("The attachment cannot be found. It might have been deleted manually.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim psi As New System.Diagnostics.ProcessStartInfo("explorer.exe", "/select, """ & filename & """")
            System.Diagnostics.Process.Start(psi)
        End If
    End Sub
    Private Sub llblMainFileName_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblMainFileName.LinkClicked
        SelectInExplorer(llblMainFileName.Text)
    End Sub

    Private Sub llblAutoSaveFileName_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAutoSaveFileName.LinkClicked
        SelectInExplorer(llblAutoSaveFileName.Text)
    End Sub
End Class
