Public Class EmailQuizResults
    Private m_boolSentAlready As Boolean
    Public Enum QuizDetailRecordType
        Questions
        Answers
        Responses
    End Enum
    Private Class QuizDetails
        Public Identifier As String
        Public RecordType As QuizDetailRecordType
        Public Question1 As String
        Public Question2 As String
        Public Question3 As String
        Public Question4 As String
        Public Question5 As String
        Public Question6 As String
        Public Question7 As String
        Public Question8 As String
        Public Question9 As String
        Public Question10 As String
    End Class
    Private m_students As List(Of Student)
    Private m_lstToEmail As List(Of StudentResults)
    Private m_schoolClass As SchoolClass
    Private m_lstQuizResults As List(Of QuizDetails)

    Public Class StudentResults
        Public Property Student As Student
        Public Property EmailBody As String
    End Class
    Public Sub New(students As List(Of Student), schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_students = students
        m_schoolClass = schoolClass
        txtQuizName.Text = m_schoolClass.ClassGroup.LastQuizName
    End Sub


    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    Private Function GetStudentFromStudentID(studentID As String) As Student
        For Each stud As Student In m_students
            If stud.StudentID.ToUpper() = studentID.ToUpper Then
                Return stud
            End If
        Next

        Return Nothing '-- not found
    End Function
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            If m_boolSentAlready Then
                '-- So easy to his OK when you mean to hit close, so prompt to avoid a lot of extra re-work
                If MessageBox.Show("It seems you have already sent this. Are you sure you want to send again?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                    Exit Sub
                End If
            End If
            olvQuizDetails.Sort(olvcolRecordType, SortOrder.Ascending)
            Application.DoEvents()

            Dim sbFileContents As New System.Text.StringBuilder("Date: " & Date.Now & Environment.NewLine)

            If txtQuizName.Text.Trim.Length = 0 Then
                MessageBox.Show("Please enter a quiz name.", ProductName)
                Exit Sub
            End If

            Dim intStudentsEmailed, intStudentsWithErrors As Integer
            txtOutput.Text = ""
            Dim intLineNumber As Integer = 0

            m_lstToEmail = New List(Of StudentResults)

            sbFileContents.Append("Module: " & m_schoolClass.Name & Environment.NewLine)
            sbFileContents.Append("Quiz: " & txtQuizName.Text & Environment.NewLine)

            Dim objQuestions, objAnswers As QuizDetails

            '-- First load up objects for questions and correct answers
            For Each obj As QuizDetails In m_lstQuizResults
                If obj.RecordType = QuizDetailRecordType.Answers Then
                    objAnswers = obj
                ElseIf obj.RecordType = QuizDetailRecordType.Questions Then
                    objQuestions = obj
                End If

                If objAnswers IsNot Nothing AndAlso objQuestions IsNot Nothing Then
                    Exit For
                End If
            Next

            '-- Ensure we have questions and answers
            If objAnswers Is Nothing Then
                MessageBox.Show("There are no answers. Please add a row of correct answers for comparison.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If objQuestions Is Nothing Then
                MessageBox.Show("There are no questions. Please add a row of questions to make the email meaningful.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '-- Now process each student comparing to correct answers
            For Each obj As QuizDetails In m_lstQuizResults
                If obj.RecordType = QuizDetailRecordType.Responses Then
                    '-- Don't process questions or answers again, just response records
                    Dim stud As Student = GetStudentFromStudentID(obj.Identifier)
                    If stud Is Nothing Then
                        txtOutput.Text &= obj.Identifier & " -- student not found" & Environment.NewLine
                        intStudentsWithErrors += 1
                    ElseIf stud.EmailAddress.Trim.Length = 0 Then
                        txtOutput.Text &= obj.Identifier & " -- email addresses missing" & Environment.NewLine
                        intStudentsWithErrors += 1
                    Else
                        '-- Check the answers and prepare the email
                        Dim strBody As String = GenerateEmailOfResults(objQuestions, objAnswers, obj, stud)

                        sbFileContents.Append(obj.Identifier & vbTab)
                        sbFileContents.Append(GenerateReportLine(objQuestions, objAnswers, obj, stud))
                        sbFileContents.Append(Environment.NewLine)

                        '-- Send to the student if we know their address
                        Dim rslts As New StudentResults()
                        rslts.Student = stud
                        rslts.EmailBody = strBody
                        m_lstToEmail.Add(rslts)

                        intStudentsEmailed += 1
                    End If
                End If
            Next


            '-- write to file
            Dim strFilename As String = System.IO.Path.Combine(GetQuizResultsFolder, m_schoolClass.Name & " " & txtQuizName.Text & " " & Date.Now.ToString(DATE_TIME_FORMAT_FILENAME) & ".txt")
            System.IO.File.WriteAllText(strFilename, sbFileContents.ToString())

            EmailStudents()

            MessageBox.Show(intStudentsEmailed.ToString("#,##0") & " students emailed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel
        End Try

    End Sub
    Private Sub EmailStudents()
        If AppSettings.PathToTrulyMailEXE.Trim.Length = 0 OrElse Not System.IO.File.Exists(AppSettings.PathToTrulyMailEXE) Then
            MessageBox.Show("Please go to Tools->Options on main form and select the path to TrulyMail. TrulyMail must be used for emailing module results.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        btnCancel.Show()
        'm_boolCancel = False

        'lblSendingStatus.Text = "Preparing TrulyMail..."
        'ProgressBar1.Show()
        'ProgressBar1.Maximum = m_lst.Count
        Application.DoEvents()

        Dim tm As Object ' New TrulyMail.NewMessage()
        Dim mainform As System.Runtime.Remoting.ObjectHandle
        Dim obj As Object
        mainform = Activator.CreateInstanceFrom(AppSettings.PathToTrulyMailEXE, "TrulyMail.MainForm") '-- load appsettings, etc.
        obj = mainform.Unwrap()
        Dim intCounter As Integer
        Dim dt As Date = Date.UtcNow.AddHours(nudSendInXHours.Value) '-- must be in UTC

        Application.DoEvents()
        For Each dataItem As StudentResults In m_lstToEmail
            intCounter += 1
            'ProgressBar1.Value = intCounter
            Application.DoEvents()
            'If m_boolCancel Then
            '    Exit For
            'End If

            'If dataItem.Selected Then
            '    lblSendingStatus.Text = "Sending " & intCounter.ToString() & " of " & m_lst.Count.ToString()
            '    If dataItem.Student.EmailedData Is Nothing OrElse dataItem.Student.EmailedData.Trim.Length = 0 Then
            '        dataItem.Student.EmailedData = Date.Now.ToString("yyyy MMM dd")
            '    Else
            '        dataItem.Student.EmailedData &= ", " & Date.Now.ToString("yyyy MMM dd")
            '    End If
            '    olvStudents.RefreshObject(dataItem)
            tm = obj.CreateNewMessage()

            If m_schoolClass.ClassGroup.UseNickname Then
                If dataItem.Student.Nickname.Trim.Length > 0 Then
                    tm.AddRecipient(dataItem.Student.Nickname, dataItem.Student.EmailAddress)
                Else
                    tm.AddRecipient(dataItem.Student.LocalNameLatinLetters, dataItem.Student.EmailAddress)
                End If
            Else
                tm.AddRecipient(dataItem.Student.LocalNameLatinLetters, dataItem.Student.EmailAddress)
            End If

            tm.show() '-- don't show, doesn't load all the smtp accounts
            Application.DoEvents()
            tm.UseSendingAccount(nudEmailSendingAccount.Value)
            tm.Subject = "Online Quiz Results: " & txtQuizName.Text
            tm.Body = dataItem.EmailBody
            tm.SendAsPlainText = False
            tm.SendThisMessage(dt)
            'End If
        Next

        m_boolSentAlready = True

        'lblSendingStatus.Text = "Finished."
        'ProgressBar1.Hide()
        'btnCancel.Hide()

    End Sub
    Private Function GenerateReportLine(questions As QuizDetails, correctAnswers As QuizDetails, studentAnswers As QuizDetails, student As Student) As String
        Dim strLine As String = String.Empty

        If questions.Question1 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question1 = correctAnswers.Question1 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question2 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question2 = correctAnswers.Question2 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question3 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question3 = correctAnswers.Question3 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question4 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question4 = correctAnswers.Question4 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question5 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question5 = correctAnswers.Question5 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question6 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question6 = correctAnswers.Question6 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question7 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question7 = correctAnswers.Question7 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question8 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question8 = correctAnswers.Question8 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question9 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question9 = correctAnswers.Question9 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If
        If questions.Question10 IsNot Nothing Then
            '-- add delimiter
            If strLine.Length > 0 Then
                strLine &= vbTab
            End If

            If studentAnswers.Question10 = correctAnswers.Question10 Then
                strLine &= "1"
            Else
                strLine &= "0"
            End If
        End If


        Return strLine
    End Function
    Private Function GenerateEmailOfResults(questions As QuizDetails, correctAnswers As QuizDetails, studentAnswers As QuizDetails, student As Student) As String
        Dim strMessage As String = String.Empty

        Dim intCorrectAnswers As Integer
        Dim intQuestions As Integer
        Dim strInfoToStore As String = "  ~  "

        If m_schoolClass.ClassGroup.UseNickname Then
            If student.Nickname.Trim.Length > 0 Then
                strMessage &= "Dear " & student.Nickname & ",<br>" & Environment.NewLine
            Else
                strMessage &= "Dear " & student.LocalNameLatinLetters & ",<br>" & Environment.NewLine
            End If
        Else
            strMessage &= "Dear " & student.LocalNameLatinLetters & ",<br />" & Environment.NewLine
        End If

        strMessage &= "<br>" & Environment.NewLine
        strMessage &= "Here are your results from this online quiz.<br />" & Environment.NewLine
        strMessage &= "<br>" & Environment.NewLine

        If questions.Question1 IsNot Nothing Then
            If correctAnswers.Question1.ToUpper() = "STORE" Then
                strInfoToStore &= "Q1: " & studentAnswers.Question1 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 1</b>: " & questions.Question1 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question1 & "<br />" & Environment.NewLine

                If studentAnswers.Question1 = correctAnswers.Question1 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question1 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question2 IsNot Nothing Then
            If correctAnswers.Question2.ToUpper() = "STORE" Then
                strInfoToStore &= "Q2: " & studentAnswers.Question2 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 2</b>: " & questions.Question2 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question2 & "<br />" & Environment.NewLine

                If studentAnswers.Question2 = correctAnswers.Question2 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question2 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question3 IsNot Nothing Then
            If correctAnswers.Question3.ToUpper() = "STORE" Then
                strInfoToStore &= "Q3: " & studentAnswers.Question3 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 3</b>: " & questions.Question3 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question3 & "<br />" & Environment.NewLine

                If studentAnswers.Question3 = correctAnswers.Question3 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question3 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question4 IsNot Nothing Then
            If correctAnswers.Question4.ToUpper() = "STORE" Then
                strInfoToStore &= "Q4: " & studentAnswers.Question4 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 4</b>: " & questions.Question4 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question4 & "<br />" & Environment.NewLine

                If studentAnswers.Question4 = correctAnswers.Question4 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question4 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question5 IsNot Nothing Then
            If correctAnswers.Question5.ToUpper() = "STORE" Then
                strInfoToStore &= "Q5: " & studentAnswers.Question5 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 5</b>: " & questions.Question5 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question5 & "<br />" & Environment.NewLine

                If studentAnswers.Question5 = correctAnswers.Question5 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question5 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question6 IsNot Nothing Then
            If correctAnswers.Question6.ToUpper() = "STORE" Then
                strInfoToStore &= "Q6: " & studentAnswers.Question6 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 6</b>: " & questions.Question6 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question6 & "<br />" & Environment.NewLine

                If studentAnswers.Question6 = correctAnswers.Question6 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question6 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question7 IsNot Nothing Then
            If correctAnswers.Question7.ToUpper() = "STORE" Then
                strInfoToStore &= "Q7: " & studentAnswers.Question7 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 7</b>: " & questions.Question7 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question7 & "<br />" & Environment.NewLine

                If studentAnswers.Question7 = correctAnswers.Question7 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question7 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question8 IsNot Nothing Then
            If correctAnswers.Question8.ToUpper() = "STORE" Then
                strInfoToStore &= "Q8: " & studentAnswers.Question8 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 8</b>: " & questions.Question8 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question8 & "<br />" & Environment.NewLine

                If studentAnswers.Question8 = correctAnswers.Question8 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question8 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question9 IsNot Nothing Then
            If correctAnswers.Question9.ToUpper() = "STORE" Then
                strInfoToStore &= "Q9: " & studentAnswers.Question9 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 9</b>: " & questions.Question9 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question9 & "<br />" & Environment.NewLine

                If studentAnswers.Question9 = correctAnswers.Question9 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question9 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If
        If questions.Question10 IsNot Nothing Then
            If correctAnswers.Question10.ToUpper() = "STORE" Then
                strInfoToStore &= "Q10: " & studentAnswers.Question10 & "; "
            Else
                intQuestions += 1
                strMessage &= "<b>Question 10</b>: " & questions.Question10 & "<br />" & Environment.NewLine
                strMessage &= "<b>Your answer</b>: " & studentAnswers.Question10 & "<br />" & Environment.NewLine

                If studentAnswers.Question10 = correctAnswers.Question10 Then
                    strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
                    intCorrectAnswers += 1
                Else
                    strMessage &= "<b>Correct answer</b>: " & correctAnswers.Question10 & "<br />" & Environment.NewLine
                    strMessage &= AppSettings.EmailQuizResultsIncorrectComments & "<br />" & Environment.NewLine
                End If
                strMessage &= "<br>" & Environment.NewLine
            End If
        End If

        Dim dblScore As Double = intCorrectAnswers / intQuestions
        strMessage &= "There were " & intQuestions & " questions and you got " & intCorrectAnswers & " of them correct. Your score is " & dblScore.ToString("##0%") & "<br />" & Environment.NewLine

        txtOutput.Text &= student.StudentID & " (" & student.Nickname & ") " & dblScore.ToString("##0%") & Environment.NewLine


        If intCorrectAnswers = intQuestions Then
            strMessage &= "Keep up the good work!" & "<br /><br />" & Environment.NewLine
        Else
            strMessage &= "If you want to improve your score, you should read more about this subject." & "<br /><br />" & Environment.NewLine
        End If


        strMessage &= txtEmailTrailingText.Text.Replace(Environment.NewLine, "<br />")

        '-- Update the student record
        student.AddToActivityLog(txtQuizName.Text & ": " & dblScore.ToString("##0%") & strInfoToStore)

        Return strMessage

    End Function

    'Private Function GenerateEmailOfResults(questions() As String, correctAnswers() As String, studentAnswers() As String, student As Student) As String
    '    Dim strMessage As String = String.Empty

    '    Dim intCorrectAnswers As Integer

    '    If m_schoolClass.ClassGroup.UseNickname Then
    '        If student.Nickname.Trim.Length > 0 Then
    '            strMessage &= "Dear " & student.Nickname & ",<br>" & Environment.NewLine
    '        Else
    '            strMessage &= "Dear " & student.LocalNameLatinLetters & ",<br>" & Environment.NewLine
    '        End If
    '    Else
    '        strMessage &= "Dear " & student.LocalNameLatinLetters & ",<br>" & Environment.NewLine
    '    End If

    '    strMessage &= "<br>" & Environment.NewLine
    '    strMessage &= "Here are your results from this online quiz.<br>" & Environment.NewLine
    '    strMessage &= "<br>" & Environment.NewLine

    '    For q = 1 To questions.Count - 1
    '        strMessage &= "<b>Question " & q & "</b>: " & questions(q) & "<br>" & Environment.NewLine
    '        strMessage &= "<b>Your answer</b>: " & studentAnswers(q) & "<br>" & Environment.NewLine

    '        If studentAnswers(q) = correctAnswers(q) Then
    '            strMessage &= "Your answer is correct!" & "<br>" & Environment.NewLine
    '            intCorrectAnswers += 1
    '        Else
    '            strMessage &= "<b>Correct answer</b>: " & correctAnswers(q) & "<br>" & Environment.NewLine
    '            strMessage &= "If you do not know why your answer is wrong, please ask me in class." & "<br>" & Environment.NewLine
    '        End If
    '        strMessage &= "<br>" & Environment.NewLine

    '    Next

    '    Dim intQuestions As Integer = questions.Count - 1
    '    Dim dblScore As Double = intCorrectAnswers / intQuestions
    '    strMessage &= "There were " & questions.Count - 1 & " questions and you got " & intCorrectAnswers & " of them correct. Your score is " & dblScore.ToString("##0%") & "<br>" & Environment.NewLine

    '    txtOutput.Text &= student.StudentID & " (" & student.Nickname & ") " & dblScore.ToString("##0%") & Environment.NewLine


    '    If intCorrectAnswers = intQuestions Then
    '        strMessage &= "Keep up the good work!" & "<br><br>" & Environment.NewLine
    '    Else
    '        strMessage &= "If you want to improve your score, you should read more about this subject." & "<br><br>" & Environment.NewLine
    '    End If


    '    strMessage &= txtEmailTrailingText.Text.Replace(Environment.NewLine, "<br>")

    '    '-- Update the student record
    '    student.AddToActivityLog(txtQuizName.Text & ": " & dblScore.ToString("##0%"))

    '    Return strMessage

    'End Function

    Private Sub EmailQuizResults_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AppSettings.EmailSendingAccount = nudEmailSendingAccount.Value
    End Sub

    Private Sub EmailQuizResults_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nudEmailSendingAccount.Value = m_schoolClass.EmailSendingAccount 'AppSettings.EmailSendingAccount
        txtEmailTrailingText.Text = AppSettings.EmailQuizTrailingText
    End Sub

    Private Sub llblViewQuizResultsFolder_LinkClicked(sender As Object, e As EventArgs) Handles llblViewQuizResultsFolder.LinkClicked
        Dim strPath As String = GetQuizResultsFolder()
        System.Diagnostics.Process.Start(strPath)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            m_lstQuizResults = New List(Of QuizDetails)
            Dim objResults As QuizDetails

            Dim strClipboard As String = Clipboard.GetText()
            If strClipboard Is Nothing Then
                MessageBox.Show("The clipboard is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(vbTab) Then
                MessageBox.Show("The clipboard data does not contain tabs. It must be spreadsheet data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(Environment.NewLine) Then
                MessageBox.Show("The clipboard does not contain multiple lines but it needs to.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim strRows() As String
                strRows = strClipboard.Split(Environment.NewLine)
                Dim row() As String
                Dim boolIgnore As Boolean
                For intCounter As Integer = 0 To strRows.Count - 1
                    boolIgnore = False
                    row = strRows(intCounter).Split(vbTab)
                    If row.Length < 2 Then
                        If m_lstQuizResults.Count > 0 Then
                            '-- we are done
                            Exit For
                        Else
                            MessageBox.Show("There should be at least 2 columns of data: ID, Question1 (the clipboard has " & row.Length & " columns).")
                        End If
                    End If
                    objResults = New QuizDetails()
                    If m_lstQuizResults.Count = 0 Then
                        objResults.RecordType = QuizDetailRecordType.Questions
                        objResults.Identifier = "Questions"
                    ElseIf row(0).Trim().ToUpper().StartsWith("ANSWER") Then
                        objResults.RecordType = QuizDetailRecordType.Answers
                        objResults.Identifier = row(0).Trim()
                    ElseIf row(0).Trim().ToUpper().StartsWith("IGNORE") Then
                        boolIgnore = True
                    Else
                        objResults.RecordType = QuizDetailRecordType.Responses
                        objResults.Identifier = row(0).Trim()
                    End If

                    If Not boolIgnore Then
                        objResults.Question1 = row(1).Trim()
                        If row.Length > 2 Then
                            objResults.Question2 = row(2).Trim()
                        End If
                        If row.Length > 3 Then
                            objResults.Question3 = row(3).Trim()
                        End If
                        If row.Length > 4 Then
                            objResults.Question4 = row(4).Trim()
                        End If
                        If row.Length > 5 Then
                            objResults.Question5 = row(5).Trim()
                        End If
                        If row.Length > 6 Then
                            objResults.Question6 = row(6).Trim()
                        End If
                        If row.Length > 7 Then
                            objResults.Question7 = row(7).Trim()
                        End If
                        If row.Length > 8 Then
                            objResults.Question8 = row(8).Trim()
                        End If
                        If row.Length > 9 Then
                            objResults.Question9 = row(9).Trim()
                        End If
                        If row.Length > 10 Then
                            objResults.Question10 = row(10).Trim()
                        End If

                        m_lstQuizResults.Add(objResults)
                    End If
                Next
                olvQuizDetails.SetObjects(m_lstQuizResults)
                AutoSizeColumns(olvQuizDetails)
                olvQuizDetails.Sort(olvcolRecordType, SortOrder.Ascending)
            End If
        Catch ex As Exception
            MessageBox.Show("There was a problem pasting (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        If olvQuizDetails.SelectedObject Is Nothing Then
            MessageBox.Show("Please select a row to delete.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            m_lstQuizResults.Remove(olvQuizDetails.SelectedObject)
            olvQuizDetails.RemoveObject(olvQuizDetails.SelectedObject)
        End If
    End Sub
End Class
