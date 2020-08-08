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
                newSemester.StartDateCurrent = dtpSemesterStart.Value.ToString("yyyy-MM-dd")
                newSemester.EndDateOverall = dtpSemesterEnd.Value.ToString("yyyy-MM-dd")
                newSemester.EndDateCurrent = dtpSemesterEnd.Value.ToString("yyyy-MM-dd")
                newSemester.Save()
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class
