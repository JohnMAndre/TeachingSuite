Public Class ImportAdditionalStudentData
    Private Class ImportData
        Public Property StudentID As String
        Public Property Nickname As String
        Public Property EmailAddress As String
        Public Property ExtStudentID As String
        Public Property Tags As String
    End Class
    Private m_lstImportData As List(Of ImportData)
    Private m_lstStudents As List(Of Student)
    Private m_dictHistoricalStudents As New Dictionary(Of String, Student)
    Private m_boolCancel As Boolean

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            Dim stud As Student
            txtErrors.Text = String.Empty
            txtErrors.Visible = True
            For Each item As ImportData In m_lstImportData
                stud = GetStudentByID(item.StudentID)
                If stud Is Nothing Then
                    '-- cannot match on student ID - flag for user to deal with
                    txtErrors.Text &= item.StudentID & Environment.NewLine

                Else
                    '-- update this student
                    If ImportnicknameToolStripMenuItem.Checked Then
                        If item.Nickname.Trim.Length > 0 Then
                            stud.Nickname = item.Nickname
                        End If
                    End If

                    If ImportemailToolStripMenuItem.Checked Then
                        If item.EmailAddress.Trim.Length > 0 Then
                            stud.EmailAddress = item.EmailAddress
                        End If
                    End If

                    If ImportExtIDToolStripMenuItem.Checked Then
                        If item.ExtStudentID.Trim.Length > 0 Then
                            stud.ExtStudentID = item.ExtStudentID
                        End If
                    End If

                    If ImporttagsToolStripMenuItem.Checked Then
                        If item.Tags.Trim.Length > 0 Then
                            If stud.Tags.Trim.Length > 0 Then
                                '-- append new tags
                                stud.Tags &= " " & item.Tags
                            Else
                                stud.Tags = item.Tags
                            End If
                        End If
                    End If
                End If
            Next

            AddApplicationHistory("Imported additional student data for " & m_lstImportData.Count.ToString("#,##0") & " students. ")

        Catch ex As Exception
            MessageBox.Show("There was an error importing some of the data (" & ex.Message & ").")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            m_lstImportData = New List(Of ImportData)
            Dim objData As ImportData

            Dim strClipboard As String = Clipboard.GetText()
            If strClipboard Is Nothing Then
                MessageBox.Show("The clipboard is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(vbTab) Then
                MessageBox.Show("The clipboard data does not contain tabs. It must be spreadsheet data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(Environment.NewLine) Then
                MessageBox.Show("The clipboard does not contain multiple lines but it needs to (you can manually enter one student, right?).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim strRows() As String

                strRows = GetRowsFromSpreadsheetClipboardData(strClipboard)

                Dim row() As String
                Dim intIndexStudentID As Integer = 0
                Dim intIndexNickname As Integer
                Dim intIndexEmail As Integer
                Dim intIndexExtID As Integer
                Dim intIndexTags As Integer
                Dim intIndexes As Integer
                Dim intCurrentIndex As Integer

                If ImportnicknameToolStripMenuItem.Checked Then
                    intCurrentIndex += 1
                    intIndexNickname = intCurrentIndex
                    intIndexes += 1
                End If

                If ImportemailToolStripMenuItem.Checked Then
                    intCurrentIndex += 1
                    intIndexEmail = intCurrentIndex
                    intIndexes += 1
                End If

                If ImportExtIDToolStripMenuItem.Checked Then
                    intCurrentIndex += 1
                    intIndexExtID = intCurrentIndex
                    intIndexes += 1
                End If

                If ImporttagsToolStripMenuItem.Checked Then
                    intCurrentIndex += 1
                    intIndexTags = intCurrentIndex
                    intIndexes += 1
                End If

                For intCounter As Integer = 0 To strRows.Count - 1
                    row = strRows(intCounter).Trim.Split(vbTab)
                    If row.Length < intIndexes + 1 Then
                        If m_lstImportData.Count > 0 Then
                            '-- we are done
                            Exit For
                        Else
                            MessageBox.Show("There should be " & intIndexes + 1 & " columns of data (the clipboard has " & row.Length & "). Please check the columns checked under the Data menu.")
                            Exit Sub
                        End If
                    End If

                    objData = New ImportData()
                    objData.StudentID = row(0)
                    If intIndexNickname > 0 Then
                        objData.Nickname = row(intIndexNickname)
                    End If
                    If intIndexEmail > 0 Then
                        objData.EmailAddress = row(intIndexEmail)
                    End If
                    If intIndexExtID > 0 Then
                        objData.ExtStudentID = row(intIndexExtID)
                    End If
                    If intIndexTags > 0 Then
                        objData.Tags = row(intIndexTags)
                    End If

                    m_lstImportData.Add(objData)
                Next
                olvStudents.SetObjects(m_lstImportData)
                olvStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                SetColumnVisibility()
            End If
        Catch ex As Exception
            MessageBox.Show("There was a problem pasting (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImportnicknameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportnicknameToolStripMenuItem.Click
        SetColumnVisibility()
    End Sub

    Private Sub ImportemailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportemailToolStripMenuItem.Click
        SetColumnVisibility()
    End Sub

    Private Sub ImportExtIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportExtIDToolStripMenuItem.Click
        SetColumnVisibility()
    End Sub

    Private Sub ImporttagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporttagsToolStripMenuItem.Click
        SetColumnVisibility()
    End Sub
    Private Sub SetColumnVisibility()
        If ImporttagsToolStripMenuItem.Checked Then
            colTags.Width = 100
        Else
            colTags.Width = 0
        End If

        If ImportExtIDToolStripMenuItem.Checked Then
            colExtID.Width = 100
        Else
            colExtID.Width = 0
        End If

        If ImportemailToolStripMenuItem.Checked Then
            colEmail.Width = 100
        Else
            colEmail.Width = 0
        End If

        If ImportnicknameToolStripMenuItem.Checked Then
            colNickname.Width = 100
        Else
            colNickname.Width = 0
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim ht As New Hashtable() '-- key  = studentID, value = student object

        Dim intStudentsAdded, intStudentsSearched As Integer
        Do
            For Each clsgrp As ClassGroup In ThisSemester.ClassGroups
                For Each clas As SchoolClass In clsgrp.Classes
                    For Each stud In clas.Students
                        intStudentsSearched += 1
                        '-- add to collection, only if there IS a student ID
                        If Not m_dictHistoricalStudents.ContainsKey(stud.StudentID.ToUpper()) AndAlso stud.StudentID.Trim.Length > 0 Then
                            m_dictHistoricalStudents.Add(stud.StudentID.ToUpper, stud)
                            intStudentsAdded += 1
                        Else
                            Application.DoEvents() '-- for breakpoint
                        End If

                        lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
                        lblStudentsLoaded.Text = intStudentsAdded.ToString("#,##0")
                        If m_boolCancel Then
                            Exit Do
                        End If
                        Application.DoEvents()
                    Next
                Next
            Next
            Exit Do
        Loop While True
    End Sub
    Private Function GetStudentByID(studentID As String) As Student
        If m_dictHistoricalStudents.ContainsKey(studentID.ToUpper()) Then
            Return m_dictHistoricalStudents(studentID.ToUpper())
        Else
            Return Nothing
        End If
    End Function
End Class
