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
        AddApplicationHistory("User chose to remove autosave file: " & m_strSemesterName)
        Semester.DiscardAutoSaveFile(m_strSemesterName)
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnUseAutoSave_Click(sender As System.Object, e As System.EventArgs) Handles btnUseAutoSave.Click
        AddApplicationHistory("User chose to use autosave file: " & m_strSemesterName)
        Semester.UseAutoSaveFile(m_strSemesterName)
        Me.DialogResult = DialogResult.OK
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
