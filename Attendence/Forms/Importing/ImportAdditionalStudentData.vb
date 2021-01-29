'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Teaching Suite Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Teaching Suite.  If Not, see < https: //www.gnu.org/licenses/>.
Public Class ImportAdditionalStudentData
    Private Class ImportData
        Public Property StudentID As String
        Public Property Nickname As String
        Public Property EmailAddress As String
        Public Property ExtStudentID As String
        Public Property Tags As String
        Public Property PeerRevieweeStudentID As String
        Public Property StudentGroup As Integer
        Public Property StudentTeam As String
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
                    If chkNickname.Checked Then
                        If item.Nickname.Trim.Length > 0 Then
                            stud.Nickname = item.Nickname
                        End If
                    End If

                    If chkEmail.Checked Then
                        If item.EmailAddress.Trim.Length > 0 Then
                            stud.EmailAddress = item.EmailAddress
                        End If
                    End If

                    If chkExtStudentID.Checked Then
                        If item.ExtStudentID.Trim.Length > 0 Then
                            stud.ExtStudentID = item.ExtStudentID
                        End If
                    End If

                    If chkTags.Checked Then
                        If item.Tags.Trim.Length > 0 Then
                            If stud.Tags.Trim.Length > 0 Then
                                '-- append new tags
                                stud.Tags &= " " & item.Tags
                            Else
                                stud.Tags = item.Tags
                            End If
                        End If
                    End If

                    If chkPeerStudentID.Checked Then
                        If item.PeerRevieweeStudentID.Trim.Length > 0 Then
                            stud.StudentIDToPeerReview = item.PeerRevieweeStudentID
                        End If
                    End If

                    If chkGroup.Checked Then
                        stud.StudentGroup = item.StudentGroup
                    End If

                    If chkTeam.Checked Then
                        stud.StudentTeam = item.StudentTeam
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
                Dim intIndexPeerReviewStudentID As Integer
                Dim intIndexStudentGroup, intIndexStudentTeam As Integer
                Dim intIndexes As Integer
                Dim intCurrentIndex As Integer

                If chkNickname.Checked Then
                    intCurrentIndex += 1
                    intIndexNickname = intCurrentIndex
                    intIndexes += 1
                End If

                If chkEmail.Checked Then
                    intCurrentIndex += 1
                    intIndexEmail = intCurrentIndex
                    intIndexes += 1
                End If

                If chkExtStudentID.Checked Then
                    intCurrentIndex += 1
                    intIndexExtID = intCurrentIndex
                    intIndexes += 1
                End If

                If chkTags.Checked Then
                    intCurrentIndex += 1
                    intIndexTags = intCurrentIndex
                    intIndexes += 1
                End If

                If chkPeerStudentID.Checked Then
                    intCurrentIndex += 1
                    intIndexPeerReviewStudentID = intCurrentIndex
                    intIndexes += 1
                End If

                If chkGroup.Checked Then
                    intCurrentIndex += 1
                    intIndexStudentGroup = intCurrentIndex
                    intIndexes += 1
                End If

                If chkTeam.Checked Then
                    intCurrentIndex += 1
                    intIndexStudentTeam = intCurrentIndex
                    intIndexes += 1
                End If

                For intCounter As Integer = 0 To strRows.Count - 1
                    row = strRows(intCounter).Split(vbTab)
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
                    objData.StudentID = row(0).Trim()
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
                    If intIndexPeerReviewStudentID > 0 Then
                        objData.PeerRevieweeStudentID = row(intIndexPeerReviewStudentID)
                    End If
                    If intIndexStudentGroup > 0 Then
                        objData.StudentGroup = ConvertToInt32(row(intIndexStudentGroup), 0)
                    End If
                    If intIndexStudentTeam > 0 Then
                        objData.StudentTeam = row(intIndexStudentTeam)
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

    Private Sub SetColumnVisibility()
        If chkTags.Checked Then
            colTags.Width = 100
        Else
            colTags.Width = 0
        End If

        If chkExtStudentID.Checked Then
            colExtID.Width = 100
        Else
            colExtID.Width = 0
        End If

        If chkEmail.Checked Then
            colEmail.Width = 100
        Else
            colEmail.Width = 0
        End If

        If chkNickname.Checked Then
            colNickname.Width = 100
        Else
            colNickname.Width = 0
        End If

        If chkPeerStudentID.Checked Then
            colPeerRevieweeID.Width = 100
        Else
            colPeerRevieweeID.Width = 0
        End If

        If chkGroup.Checked Then
            colStudentGroup.Width = 100
        Else
            colStudentGroup.Width = 0
        End If

        If chkTeam.Checked Then
            colTeam.Width = 100
        Else
            colTeam.Width = 0
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

    Private Sub chk_CheckStateChanged(sender As Object, e As EventArgs) Handles chkTags.CheckStateChanged, chkPeerStudentID.CheckStateChanged, chkNickname.CheckStateChanged, chkGroup.CheckStateChanged, chkExtStudentID.CheckStateChanged, chkEmail.CheckStateChanged, chkTeam.CheckStateChanged
        SetColumnVisibility()
    End Sub

    Private Sub UncheckallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UncheckallToolStripMenuItem.Click
        chkNickname.Checked = False
        chkEmail.Checked = False
        chkExtStudentID.Checked = False
        chkTags.Checked = False
        chkPeerStudentID.Checked = False
        chkGroup.Checked = False
        chkTeam.Checked = False
    End Sub

    Private Sub CheckAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAllToolStripMenuItem.Click
        chkNickname.Checked = True
        chkEmail.Checked = True
        chkExtStudentID.Checked = True
        chkTags.Checked = True
        chkPeerStudentID.Checked = True
        chkGroup.Checked = True
        chkTeam.Checked = True
    End Sub


End Class
