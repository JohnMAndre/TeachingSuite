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
Public Class BulkEmailer

    Private m_clas As SchoolClass
    Private m_lst As New List(Of BulkEmailData)
    Private m_boolCancel As Boolean

    Private Const PEER_REVIEWEE_NAME As String = "[[PEER_REVIEWEE_NAME]]"
    Private Const PEER_REVIEWEE_STUDENTID As String = "[[PEER_REVIEWEE_STUDENTID]]"

    Private m_strStudentSpecificAttachmentPath As String
    Private m_lstGeneralAttachments As New List(Of String)

    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_clas = clas

        LoadData()

    End Sub
    Private Sub LoadData()
        For Each stud In m_clas.Students
            If stud.EmailAddress.Trim.Length > 4 Then '-- must have valid email address
                Dim objData As New BulkEmailData()
                objData.Student = stud
                objData.Selected = False
                m_lst.Add(objData)
            End If
        Next

        olvStudents.SetObjects(m_lst)

    End Sub
    Private Sub UpdateRecipientCount()
        Dim intRecips As Integer

        For Each obj As BulkEmailData In olvStudents.Objects
            If obj.Selected Then
                intRecips += 1
            End If
        Next

        lblRecipientCount.Text = "Recipients: " & intRecips.ToString("#,##0")
    End Sub
    Private Sub llblSelectStudents_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblSelectStudents.LinkClicked
        For Each obj As BulkEmailData In olvStudents.SelectedObjects
            obj.Selected = True
        Next

        olvStudents.RefreshSelectedObjects()

        UpdateRecipientCount()
    End Sub

    Private Sub llblUnSelectStudents_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblUnSelectStudents.LinkClicked
        For Each obj As BulkEmailData In olvStudents.SelectedObjects
            obj.Selected = False
        Next

        olvStudents.RefreshSelectedObjects()

        UpdateRecipientCount()
    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        EmailSelectedStudents()
        m_clas.ClassGroup.LastQuizName = txtSubject.Text
    End Sub
    Private Sub EmailSelectedStudents()
        Try
            If AppSettings.PathToTrulyMailEXE.Trim.Length = 0 OrElse Not System.IO.File.Exists(AppSettings.PathToTrulyMailEXE) Then
                MessageBox.Show("Please go to Tools->Options on main form and select the path to TrulyMail. TrulyMail must be used for emailing module results.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            btnCancel.Show()
            m_boolCancel = False

            lblSendingStatus.Text = "Preparing TrulyMail..."
            ProgressBar1.Show()
            ProgressBar1.Maximum = m_lst.Count
            Application.DoEvents()

            Dim tm As Object ' New TrulyMail.NewMessage()
            Dim mainform As System.Runtime.Remoting.ObjectHandle
            Dim obj As Object
            mainform = Activator.CreateInstanceFrom(AppSettings.PathToTrulyMailEXE, "TrulyMail.MainForm") '-- load appsettings, etc.
            obj = mainform.Unwrap()
            Dim intCounter As Integer
            Dim dt As Date = Date.UtcNow.AddHours(nudSendInXHours.Value) '-- must be in UTC

            Application.DoEvents()

            For Each dataItem As BulkEmailData In m_lst
                intCounter += 1
                ProgressBar1.Value = intCounter
                Application.DoEvents()
                If m_boolCancel Then
                    Exit For
                End If

                If dataItem.Selected Then

                    lblSendingStatus.Text = "Sending " & intCounter.ToString() & " of " & m_lst.Count.ToString()

                    '-- Different file(s) for each student
                    '   Need to avoid creating TrulyMail object when we will not sent
                    Dim files() As String
                    If AddstudentspecificAttachmentToolStripMenuItem.Checked Then
                        If Me.UseExtIDuncheckToUseStudentIDToolStripMenuItem.Checked Then
                            files = System.IO.Directory.GetFiles(m_strStudentSpecificAttachmentPath, "*" & dataItem.Student.ExtStudentID & "*.*")
                        Else
                            files = System.IO.Directory.GetFiles(m_strStudentSpecificAttachmentPath, "*" & dataItem.Student.StudentID & "*.*")
                        End If

                        If IgnoreStudentsWithoutStudentspecificAttachmentsToolStripMenuItem.Checked AndAlso files.Count = 0 Then
                            Continue For '-- Do not send this student at all
                        End If
                    End If


                    If dataItem.Student.EmailedData Is Nothing OrElse dataItem.Student.EmailedData.Trim.Length = 0 Then
                        dataItem.Student.EmailedData = Date.Now.ToString("yyyy MMM dd")
                    Else
                        dataItem.Student.EmailedData &= ", " & Date.Now.ToString("yyyy MMM dd")
                    End If
                    olvStudents.RefreshObject(dataItem)
                    tm = obj.CreateNewMessage(Not AppSettings.EmailAsHTML) '-- True to force plaintext

                    Dim strNameForToField As String

                    If m_clas.ClassGroup.UseNickname Then
                        If dataItem.Student.Nickname.Trim.Length = 0 Then
                            strNameForToField = dataItem.Student.LocalNameLatinLetters
                        Else
                            strNameForToField = dataItem.Student.Nickname
                        End If
                    Else
                        strNameForToField = dataItem.Student.LocalNameLatinLetters
                    End If

                    If chkIncludeStudentID.Checked Then
                        strNameForToField &= " (" & dataItem.Student.StudentID & ")"
                    End If

                    tm.AddRecipient(strNameForToField, dataItem.Student.EmailAddress)

                    tm.show() '-- don't show, doesn't load all the smtp accounts
                    Application.DoEvents()
                    tm.UseSendingAccount(nudEmailSendingAccount.Value)
                    tm.Subject = txtSubject.Text
                    tm.Body = GenerateEmailBodyForStudent(dataItem)
                    tm.SendAsPlainText = False

                    '-- Same file(s) for all students
                    If AddfixedAttachmentToolStripMenuItem.Checked Then
                        For Each strFilename As String In m_lstGeneralAttachments
                            tm.AddAttachment(strFilename)
                        Next
                    End If

                    '-- Now actually attach files from above
                    If AddstudentspecificAttachmentToolStripMenuItem.Checked AndAlso files.Length > 0 Then
                        For Each strFilename As String In files
                            tm.AddAttachment(strFilename)
                        Next
                    End If

                    Try
                        tm.SendThisMessage(dt)
                    Catch ex As Exception
                        Log(ex)
                        dataItem.ProcessStatus = ex.Message
                        olvStudents.RefreshObject(dataItem)
                        tm.CloseSaveAsDraft()
                        tm = Nothing
                        Continue For
                    End Try
                    dataItem.ProcessStatus = "Sent: " & Date.Now.ToString(DATE_TIME_FORMAT_DETAIL)
                    olvStudents.RefreshObject(dataItem)
                End If
            Next

            lblSendingStatus.Text = "Finished."
            ProgressBar1.Hide()
            btnCancel.Hide()
        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, PRODUCT_NAME)
        End Try
    End Sub

    Private Function GenerateEmailBodyForStudent(item As BulkEmailData)
        Dim str As New System.Text.StringBuilder()
        If m_clas.ClassGroup.UseNickname AndAlso item.Student.Nickname.Trim.Length > 0 Then
            str.Append("Dear " & item.Student.Nickname & ":") '-- use nickname if we are suppsed to and if it exists
        Else
            str.Append("Dear " & item.Student.LocalNameLatinLetters & ":")
        End If


        If AppSettings.EmailAsHTML Then
            str.Append("<br /><br />")
        Else
            str.Append(Environment.NewLine)
            str.Append(Environment.NewLine)
        End If

        Dim strTrailingMessage As String = txtEmailTrailingText.Text
        If strTrailingMessage.IndexOf(PEER_REVIEWEE_NAME) >= 0 OrElse strTrailingMessage.IndexOf(PEER_REVIEWEE_STUDENTID) >= 0 Then
            Dim student As Student = m_clas.GetStudentByStudentID(item.Student.StudentIDToPeerReview)
            If student IsNot Nothing Then
                strTrailingMessage = strTrailingMessage.Replace(PEER_REVIEWEE_NAME, student.LocalName)
                strTrailingMessage = strTrailingMessage.Replace(PEER_REVIEWEE_STUDENTID, student.StudentID)
            End If
        End If

        If AppSettings.EmailAsHTML Then
            str.Append(strTrailingMessage.Replace(Environment.NewLine, "<br />"))
        Else
            str.Append(strTrailingMessage)
        End If


        Return str.ToString()
    End Function

    Private Sub BulkEmailer_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'AppSettings.EmailSendingAccount = nudEmailSendingAccount.Value
    End Sub

    Private Sub BulkEmailer_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        nudEmailSendingAccount.Value = m_clas.EmailSendingAccount 'AppSettings.EmailSendingAccount
    End Sub

    Private Sub llblClearFilter_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearFilter.LinkClicked
        txtStudentFilter.Text = String.Empty
        txtStudentFilter.Focus()
    End Sub

    Private Sub txtStudentFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStudentFilter.TextChanged
        tmrFilterStudents.Stop()
        tmrFilterStudents.Start()
    End Sub

    Private Sub tmrFilterStudents_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFilterStudents.Tick
        FilterStudents()
    End Sub
    Private Sub FilterStudents()
        Try
            tmrFilterStudents.Stop()

            olvStudents.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(olvStudents, txtStudentFilter.Text)

            If txtStudentFilter.Text.Length = 0 Then
                olvStudents.EmptyListMsg = "This class is empty"
            Else
                olvStudents.EmptyListMsg = "No students match your filter"
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error filtering students: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        btnCancel.Hide()
        m_boolCancel = True
    End Sub


    Private Sub llblCreateLink_LinkClicked(sender As Object, e As EventArgs) Handles llblCreateLink.LinkClicked
        If txtLinkAddress.Text.Trim.Length = 0 Then
            MessageBox.Show("Please enter the link address in the textbox.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtEmailTrailingText.SelectedText.Trim.Length = 0 Then
            MessageBox.Show("Please select the text for the link in the trailing text.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim strAddress As String = txtLinkAddress.Text.Trim
        Dim strText As String = txtEmailTrailingText.SelectedText
        txtEmailTrailingText.SelectedText = String.Empty

        strText = "<a href='" & strAddress & "'>" & strText & "</a>"
        txtEmailTrailingText.SelectedText = strText
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub llblMakeQuiz_LinkClicked(sender As Object, e As EventArgs) Handles llblMakeQuiz.LinkClicked
        txtSubject.Text = m_clas.ClassGroup.LastQuizName
    End Sub

    Private Sub olvStudents_KeyDown(sender As Object, e As KeyEventArgs) Handles olvStudents.KeyDown
        '-- pressing space will toggle send/don't send
        If e.KeyCode = Keys.Space Then
            For Each obj As BulkEmailData In olvStudents.SelectedObjects
                obj.Selected = Not obj.Selected
            Next

            olvStudents.RefreshSelectedObjects()

            UpdateRecipientCount()
        End If
    End Sub

    Private Sub PeerRevieweeStudentIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeerRevieweeStudentIDToolStripMenuItem.Click
        txtEmailTrailingText.SelectedText = PEER_REVIEWEE_STUDENTID
    End Sub

    Private Sub PeerRevieweeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeerRevieweeNameToolStripMenuItem.Click
        txtEmailTrailingText.SelectedText = PEER_REVIEWEE_NAME
    End Sub

    Private Sub AddstudentspecificAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddstudentspecificAttachmentToolStripMenuItem.Click
        If AddstudentspecificAttachmentToolStripMenuItem.Checked Then
            Dim ofd As New OpenFileDialog()
            ofd.Title = "Please select one file from the folder you want to use."
            ofd.Filter = "All files|*.*"
            If m_strStudentSpecificAttachmentPath Is Nothing Then
                ofd.InitialDirectory = "C:\"
            Else
                ofd.InitialDirectory = m_strStudentSpecificAttachmentPath
            End If
            If ofd.ShowDialog = DialogResult.OK Then
                m_strStudentSpecificAttachmentPath = System.IO.Path.GetDirectoryName(ofd.FileName)
            End If
        End If
    End Sub

    Private Sub AddfixedAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddfixedAttachmentToolStripMenuItem.Click
        If AddfixedAttachmentToolStripMenuItem.Checked Then
            Dim ofd As New OpenFileDialog()
            ofd.Title = "Please select one or more file(s) to attach to each email"
            ofd.Filter = "All files|*.*"
            ofd.Multiselect = True
            If m_lstGeneralAttachments.Count = 0 Then
                ofd.InitialDirectory = "C:\"
            Else
                ofd.InitialDirectory = System.IO.Path.GetDirectoryName(m_lstGeneralAttachments(0))
            End If
            If ofd.ShowDialog = DialogResult.OK Then
                '-- Clear and re-add all selected
                m_lstGeneralAttachments.Clear()
                For Each strName As String In ofd.FileNames
                    m_lstGeneralAttachments.Add(strName)
                Next
            End If
        End If
    End Sub

    Private Sub StatusCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusCheckToolStripMenuItem.Click
        Dim strMessage As String = "Send fixed: " & AddfixedAttachmentToolStripMenuItem.Checked & vbNewLine
        If AddfixedAttachmentToolStripMenuItem.Checked Then
            For intCounter As Integer = 0 To m_lstGeneralAttachments.Count - 1
                strMessage &= "    Fixed file (" & intCounter & "): " & m_lstGeneralAttachments(intCounter) & vbNewLine
            Next
        End If

        strMessage &= vbNewLine

        strMessage &= "Send student-specific: " & AddstudentspecificAttachmentToolStripMenuItem.Checked & vbNewLine
        If AddstudentspecificAttachmentToolStripMenuItem.Checked Then
            strMessage &= "    All matching files in folder: " & m_strStudentSpecificAttachmentPath & vbNewLine
        End If

        MessageBox.Show(strMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddstudentspecificAttachmentToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles AddstudentspecificAttachmentToolStripMenuItem.CheckedChanged
        IgnoreStudentsWithoutStudentspecificAttachmentsToolStripMenuItem.Enabled = AddstudentspecificAttachmentToolStripMenuItem.Checked
    End Sub

    Private Sub ToggleStudentsFromIDsOnClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleStudentsFromIDsOnClipboardToolStripMenuItem.Click
        Try
            Dim lines() As String = Clipboard.GetText.Split(Environment.NewLine)
            For Each strLine In lines
                strLine = strLine.Trim()
                For Each obj As BulkEmailData In m_lst
                    If obj.Student.StudentID.ToLower() = strLine.ToLower() Then
                        obj.Selected = Not obj.Selected
                        Exit For '-- assume each student ID is unique
                    End If
                Next
            Next

            olvStudents.RefreshObjects(m_lst)
            UpdateRecipientCount()

        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, PRODUCT_NAME)
        End Try
    End Sub

End Class

Public Class BulkEmailData
    Public Property Selected As Boolean
    Public Property Student As Student
    Public Property ProcessStatus As String
End Class