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
Public Class ImportTeachingAppExportFile

    Private Const FILE_EXTENSION_FOR_IMPORT = ".taex"

    Private Sub btnBrowseForExportFile_Click(sender As Object, e As EventArgs) Handles btnBrowseForExportFile.Click
        Try

            Dim ofd As New System.Windows.Forms.OpenFileDialog()
            ofd.Filter = "Export-Import files (*" & FILE_EXTENSION_FOR_IMPORT & ")|*" & FILE_EXTENSION_FOR_IMPORT
            ofd.Multiselect = False
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim strContents As String
                If System.IO.File.Exists(ofd.FileName) Then
                    Using zip As New Ionic.Zip.ZipFile(ofd.FileName)
                        Using ms As New System.IO.MemoryStream()
                            zip.Entries(0).Extract(ms)
                            ms.Position = 0
                            Using sr As New System.IO.StreamReader(ms, System.Text.Encoding.Unicode)
                                strContents = sr.ReadToEnd
                                sr.Close()
                            End Using
                            ms.Close()
                        End Using
                    End Using

                    Dim xDoc As New Xml.XmlDocument()
                    xDoc.LoadXml(strContents)

                    Dim strSample As String = String.Empty
                    For Each attrib As Xml.XmlAttribute In xDoc.DocumentElement.Attributes
                        strSample &= attrib.Name & " = " & attrib.Value & Environment.NewLine
                    Next
                    lblDataSample.Text = strSample

                Else
                    MessageBox.Show(ofd.FileName & " could not be found.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                '-- nothing to do
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        MessageBox.Show("This feature is not implemented, yet.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class