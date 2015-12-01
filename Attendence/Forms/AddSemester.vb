Public Class AddSemester


    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        '-- Add new semester
        Dim strNewSemester As String = txtSemesterName.Text

        If strNewSemester.Length = 0 Then
            MessageBox.Show("Semester must have a name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim strFilename As String = System.IO.Path.Combine(GetDataFolder(), strNewSemester & DATA_FILE_EXTENSION)
            Dim boolOverwriteOK As Boolean
            If System.IO.File.Exists(strFilename) Then
                If MessageBox.Show("Are you sure you want to overwrite the existing semester with this name?", "Overwrite Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    boolOverwriteOK = True
                Else
                    boolOverwriteOK = False
                End If
            Else
                boolOverwriteOK = True '-- nothing to overwrite
            End If

            If boolOverwriteOK Then
                Dim newSemester As New Semester(strNewSemester)
                newSemester.StartDateOverall = dtpSemesterStart.Value.ToString("yyyy-MM-dd")
                newSemester.EndDateOverall = dtpSemesterEnd.Value.ToString("yyyy-MM-dd")
                newSemester.Save()
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class
