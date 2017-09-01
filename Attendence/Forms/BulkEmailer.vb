Public Class BulkEmailer

    Private m_clas As SchoolClass
    Private m_lst As New List(Of BulkEmailData)
    Private m_boolCancel As Boolean

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
        'Dim lstErrors As New List(Of BulkEmailData)

        For Each dataItem As BulkEmailData In m_lst
            intCounter += 1
            ProgressBar1.Value = intCounter
            Application.DoEvents()
            If m_boolCancel Then
                Exit For
            End If

            If dataItem.Selected Then
                lblSendingStatus.Text = "Sending " & intCounter.ToString() & " of " & m_lst.Count.ToString()
                If dataItem.Student.EmailedData Is Nothing OrElse dataItem.Student.EmailedData.Trim.Length = 0 Then
                    dataItem.Student.EmailedData = Date.Now.ToString("yyyy MMM dd")
                Else
                    dataItem.Student.EmailedData &= ", " & Date.Now.ToString("yyyy MMM dd")
                End If
                olvStudents.RefreshObject(dataItem)
                tm = obj.CreateNewMessage()

                If m_clas.ClassGroup.UseNickname Then
                    If dataItem.Student.Nickname.Trim.Length = 0 Then
                        tm.AddRecipient(dataItem.Student.LocalNameLatinLetters, dataItem.Student.EmailAddress)
                    Else
                        tm.AddRecipient(dataItem.Student.Nickname, dataItem.Student.EmailAddress)
                    End If
                Else
                    tm.AddRecipient(dataItem.Student.LocalNameLatinLetters, dataItem.Student.EmailAddress)
                End If

                tm.show() '-- don't show, doesn't load all the smtp accounts
                Application.DoEvents()
                tm.UseSendingAccount(nudEmailSendingAccount.Value)
                tm.Subject = txtSubject.Text
                tm.Body = GenerateEmailBodyForStudent(dataItem)
                tm.SendAsPlainText = False
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

        'If MessageBox.Show(lstErrors.ToString() & " items had errors sending. Do you want to see a list of those items?", Application.ProductName, MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '    For Each item As BulkEmailData In lstErrors
        '        item.Student
        '    Next
        'End If

        lblSendingStatus.Text = "Finished."
        ProgressBar1.Hide()
        btnCancel.Hide()

    End Sub

    Private Function GenerateEmailBodyForStudent(item As BulkEmailData)
        Dim str As New System.Text.StringBuilder()
        If m_clas.ClassGroup.UseNickname AndAlso item.Student.Nickname.Trim.Length > 0 Then
            str.Append("Dear " & item.Student.Nickname & ":<br><br>") '-- use nickname if we are suppsed to and if it exists
        Else
            str.Append("Dear " & item.Student.LocalNameLatinLetters & ":<br><br>")
        End If

        str.Append(txtEmailTrailingText.Text.Replace(Environment.NewLine, "<br>"))

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
            For Each obj As EmailResultData In olvStudents.SelectedObjects
                obj.Selected = Not obj.Selected
            Next

            olvStudents.RefreshSelectedObjects()
        End If
    End Sub
End Class

Public Class BulkEmailData
    Public Property Selected As Boolean
    Public Property Student As Student
    Public Property ProcessStatus As String
End Class