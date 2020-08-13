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
Public Class EmailQuizResults
    Private m_boolSentAlready As Boolean
    Public Enum QuizDetailRecordType
        Questions
        Answers
        Responses
    End Enum
    Private Class QuizDetails
        Public Property Identifier As String
        Public Property RecordType As QuizDetailRecordType
        Public Property Question1 As String
        Public Property Question2 As String
        Public Property Question3 As String
        Public Property Question4 As String
        Public Property Question5 As String
        Public Property Question6 As String
        Public Property Question7 As String
        Public Property Question8 As String
        Public Property Question9 As String
        Public Property Question10 As String
        Public Property Question11 As String
        Public Property Question12 As String
        Public Property Question13 As String
        Public Property Question14 As String
        Public Property Question15 As String
        Public Property Student As Student
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

            If lblDuplicatesExist.Visible Then
                If MessageBox.Show("Send even with the duplicates?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
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
                        txtOutput.Text &= obj.Identifier & " -- email address missing" & Environment.NewLine
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
            tm = obj.CreateNewMessage(Not AppSettings.EmailAsHTML) '-- true= force plaintext

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
                strMessage &= "Dear " & student.Nickname & ":"
            Else
                strMessage &= "Dear " & student.LocalNameLatinLetters & ":"
            End If
        Else
            strMessage &= "Dear " & student.LocalNameLatinLetters & ":"
        End If

        If AppSettings.EmailAsHTML Then
            strMessage &= "<br />" & Environment.NewLine
            strMessage &= "<br />" & Environment.NewLine
        Else
            strMessage &= Environment.NewLine
            strMessage &= Environment.NewLine
        End If

        strMessage &= "Here are your results from this online quiz."

        If AppSettings.EmailAsHTML Then
            strMessage &= "<br />" & Environment.NewLine
            strMessage &= "<br />" & Environment.NewLine
        Else
            strMessage &= Environment.NewLine
            strMessage &= Environment.NewLine
        End If

        '=========================================================
        '=========================================================
        Dim typQuestions As Type = questions.GetType()
        Dim typCorrectAnswers As Type = correctAnswers.GetType()
        Dim typStudentAnswers As Type = studentAnswers.GetType()

        For intCounter As Integer = 1 To 15

            Dim propQuestions As System.Reflection.PropertyInfo = typQuestions.GetProperty("Question" & intCounter.ToString())
            Dim strQuestion As String = propQuestions.GetValue(questions)


            If strQuestion IsNot Nothing AndAlso strQuestion.Length > 0 Then
                Dim propCorrectAnswers As System.Reflection.PropertyInfo = typCorrectAnswers.GetProperty("Question" & intCounter.ToString())
                Dim strCorrectAnswer As String = propQuestions.GetValue(correctAnswers)

                Dim propStudentAnswers As System.Reflection.PropertyInfo = typStudentAnswers.GetProperty("Question" & intCounter.ToString())
                Dim strStudentAnswer As String = propQuestions.GetValue(studentAnswers)

                If strStudentAnswer.Trim.Length = 0 Then
                    strStudentAnswer = "<no answer given>"
                End If


                If strCorrectAnswer.ToUpper() = "STORE" Then
                    strInfoToStore &= "Q" & intCounter.ToString() & ": " & strStudentAnswer & "; "
                Else
                    intQuestions += 1
                    If AppSettings.EmailAsHTML Then
                        strMessage &= "<b>Question " & intCounter.ToString() & "</b>: " & strQuestion & "<br />" & Environment.NewLine
                        strMessage &= "<b>Your answer</b>: " & strStudentAnswer & "<br />" & Environment.NewLine
                    Else
                        strMessage &= "Question " & intCounter.ToString() & ": " & strQuestion & Environment.NewLine
                        strMessage &= "Your answer: " & strStudentAnswer & Environment.NewLine
                    End If


                    If strStudentAnswer = strCorrectAnswer Then
                        strMessage &= "Your answer is correct!" & Environment.NewLine
                        If AppSettings.EmailAsHTML Then
                            strMessage &= "<br />" & Environment.NewLine
                        End If

                        intCorrectAnswers += 1
                    Else
                        If AppSettings.EmailAsHTML Then
                            strMessage &= "<b>Correct answer</b>: " & strCorrectAnswer & "<br />" & Environment.NewLine
                        Else
                            strMessage &= "Correct answer: " & strCorrectAnswer & Environment.NewLine
                        End If

                        strMessage &= AppSettings.EmailQuizResultsIncorrectComments
                        If AppSettings.EmailAsHTML Then
                            strMessage &= "<br />" & Environment.NewLine
                        Else
                            strMessage &= Environment.NewLine
                        End If

                    End If
                    If AppSettings.EmailAsHTML Then
                        strMessage &= "<br>" & Environment.NewLine
                    Else
                        strMessage &= Environment.NewLine
                    End If

                End If
            End If
        Next
        '=========================================================
        '=========================================================



        Dim dblScore As Double = intCorrectAnswers / intQuestions

        If AppSettings.EmailAsHTML Then
            strMessage &= "There were " & intQuestions & " questions and you got " & intCorrectAnswers & " of them correct. Your score is " & dblScore.ToString("##0%")
        Else
            strMessage &= "There were " & intQuestions & " questions and you got " & intCorrectAnswers & " of them correct. Your score is " & dblScore.ToString("##0%") & "%" '-- running under wine drops % from .ToString call
        End If

        If AppSettings.EmailAsHTML Then
            strMessage &= "<br />" & Environment.NewLine
        Else
            strMessage &= Environment.NewLine
        End If

        txtOutput.Text &= student.StudentID & " (" & student.Nickname & ") " & dblScore.ToString("##0%") & Environment.NewLine


        If intCorrectAnswers = intQuestions Then
            strMessage &= "Keep up the good work!"
        Else
            strMessage &= "If you want to improve your score, you should read more about this subject."
        End If

        If AppSettings.EmailAsHTML Then
            strMessage &= "<br /><br />" & Environment.NewLine
        Else
            strMessage &= Environment.NewLine
            strMessage &= Environment.NewLine
        End If

        If AppSettings.EmailAsHTML Then
            strMessage &= txtEmailTrailingText.Text.Replace(Environment.NewLine, "<br />")
        Else
            strMessage &= txtEmailTrailingText.Text
        End If


        '-- Update the student record
        student.AddToActivityLog(txtQuizName.Text & ": " & dblScore.ToString("##0%") & strInfoToStore)
        student.PerformanceLastOnlineQuiz = dblScore * 100 '-- convert to base 100

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
        m_schoolClass.ClassGroup.LastQuizName = txtQuizName.Text
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

            If Me.ActiveControl Is txtEmailTrailingText Then
                txtEmailTrailingText.SelectedText = Clipboard.GetText()
            Else
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

                    strRows = GetRowsFromSpreadsheetClipboardData(strClipboard)
                    m_lstQuizResults = New List(Of QuizDetails)

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

                            For Each stud In m_students
                                If stud.StudentID = objResults.Identifier Then
                                    objResults.Student = stud '-- use first match (user must keep them unique)
                                    Exit For
                                End If
                                Application.DoEvents()
                            Next

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
                            If row.Length > 11 Then
                                objResults.Question11 = row(11).Trim()
                            End If
                            If row.Length > 12 Then
                                objResults.Question12 = row(12).Trim()
                            End If
                            If row.Length > 13 Then
                                objResults.Question12 = row(13).Trim()
                            End If
                            If row.Length > 14 Then
                                objResults.Question14 = row(14).Trim()
                            End If
                            If row.Length > 15 Then
                                objResults.Question15 = row(15).Trim()
                            End If

                            m_lstQuizResults.Add(objResults)
                        End If
                    Next
                    olvQuizDetails.SetObjects(m_lstQuizResults)
                    AutoSizeColumns(olvQuizDetails)
                    olvQuizDetails.Sort(olvcolRecordType, SortOrder.Ascending)
                End If

                CheckForDuplicates()
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

        CheckForDuplicates()
    End Sub

    Private Sub llblReplaceStudentID_LinkClicked(sender As Object, e As EventArgs) Handles llblReplaceStudentID.LinkClicked
        ReplaceSelectedStudentID()
    End Sub

    Private Sub ReplaceSelectedStudentIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceSelectedStudentIDToolStripMenuItem.Click
        ReplaceSelectedStudentID()
    End Sub
    Private Sub ReplaceSelectedStudentID()
        If txtNewStudentID.Text.Trim.Length = 0 Then
            MessageBox.Show("Please enter a new StudentID.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim qd As QuizDetails = CType(olvQuizDetails.SelectedObject, QuizDetails)
        If qd Is Nothing Then
            MessageBox.Show("Please select an entry to change.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        qd.Identifier = txtNewStudentID.Text.Trim()

        '-- Update student ref
        For Each stud In m_students
            If stud.StudentID = qd.Identifier Then
                qd.Student = stud '-- use first match (user must keep them unique)
                Exit For
            End If
            Application.DoEvents()
        Next

        Me.olvQuizDetails.RefreshSelectedObjects()

        CheckForDuplicates()
    End Sub

    Private Sub CheckForDuplicates()
        lblDuplicatesExist.Hide()

        Dim dict As New Dictionary(Of String, String)

        For Each qd As QuizDetails In m_lstQuizResults
            If dict.ContainsKey(qd.Identifier) Then
                lblDuplicatesExist.Show()
                Exit For
            Else
                dict.Add(qd.Identifier, Nothing)
            End If
        Next
    End Sub

    Private Sub olvQuizDetails_ItemActivate(sender As Object, e As EventArgs) Handles olvQuizDetails.ItemActivate
        Dim qd As QuizDetails = CType(olvQuizDetails.SelectedObject, QuizDetails)
        If qd Is Nothing Then
            Exit Sub
        End If

        txtNewStudentID.Text = qd.Identifier
    End Sub

    Private Sub CheckAllRowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAllRowsToolStripMenuItem.Click
        Dim intCounter As Integer = 1

        MessageBox.Show("There are " & m_lstQuizResults.Count().ToString("#,##0") & " records.")

        For Each row As QuizDetails In m_lstQuizResults
            If MessageBox.Show("Row " + intCounter.ToString("#,##0") & " is type " & row.RecordType.ToString(), Application.ProductName, MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
                Exit For
            End If
            intCounter += 1
        Next
        MessageBox.Show("Done.")
    End Sub
End Class
