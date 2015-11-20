Imports Microsoft.Office.Interop

Public Class MainForm

    Private m_boolCancel As Boolean

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            btnOK.Enabled = False
            m_boolCancel = False

            Dim files() As String = GetFilesToPrint(txtPath.Text)

            Dim f As New OpenFileDialog
            Dim p As New PrintDialog
            Dim app As Word.Application
            Dim doc As Word.Document

            'Create instance of Word Application
            app = New Word.Application


            'Open file and print dialogs to get desired document and printer
            If p.ShowDialog = Windows.Forms.DialogResult.OK Then

                'Set Printer
                app.WordBasic.FilePrintSetup(Printer:=p.PrinterSettings.PrinterName, DoNotSetAsSysDefault:=1)

                'Set filename to object type
                Dim m As Object = System.Reflection.Missing.Value

                Dim intCounter As Integer
                For Each strFilename In files
                    intCounter += 1
                    If nudMaxFilesToPrint.Value > 0 AndAlso intCounter > nudMaxFilesToPrint.Value Then
                        Exit For
                    ElseIf m_boolCancel Then
                        Exit For
                    End If

                    rtbOutput.AppendText(strFilename & Environment.NewLine())


                    'Open document
                    doc = app.Documents.Open(strFilename, m, m, m, m, m, m, m, m, m, m, m)

                    'Print document
                    app.PrintOut()

                    'Close document
                    app.Documents.Close()

                    lblPrinted.Text = "Printed: " & intCounter.ToString("#,##0")
                    Application.DoEvents()
                Next
            End If

            'Quit word application
            app.Quit()

            'Release 
            app = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        btnOK.Enabled = True
    End Sub
    Private Function GetFilesToPrint(path As String) As String()
        Try
            Dim files() As String = System.IO.Directory.GetFiles(path)

            Return files
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub llblClearOutput_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearOutput.LinkClicked
        rtbOutput.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If btnOK.Enabled Then
            Close()
        Else
            m_boolCancel = True
        End If
    End Sub

    Private Sub txtPath_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles txtPath.DragDrop
        Try
            For Each strFormat As String In e.Data.GetFormats
                If strFormat = "FileDrop" Then
                    Dim strPath As String = e.Data.GetData("FileDrop")(0)
                    If System.IO.File.Exists(strPath) Then
                        '-- get parent folder
                        txtPath.Text = System.IO.Path.GetDirectoryName(strPath)
                    Else
                        '-- use this as-is
                        txtPath.Text = strPath
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPath_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles txtPath.DragEnter
        Application.DoEvents()
        For Each strFormat As String In e.Data.GetFormats
            If strFormat = "FileDrop" Then
                e.Effect = DragDropEffects.Copy
            End If
        Next
    End Sub
End Class
