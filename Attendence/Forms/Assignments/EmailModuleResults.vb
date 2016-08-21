Public Class EmailModuleResults

    Private m_clas As SchoolClass
    Private m_lst As New List(Of EmailResultData)
    Private m_try As MarkingTry = -1
    Private m_intModuleOutcomes As Integer
    Private m_intAssignmentsSoFar As Integer
    Private m_boolCancel As Boolean
    Private m_lstAssignments As New List(Of IClassAssignment)
    Private m_strAttachmentPath As String

    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_clas = clas

        CalculateOutcomes()

        m_lstAssignments.AddRange(clas.ClassGroup.AssignmentsBTEC)
        m_lstAssignments.AddRange(clas.ClassGroup.Assignments)
        olvAssignments.SetObjects(m_lstAssignments)

    End Sub
    Private Function ShouldIncludeAssignment(asmt As IClassAssignment)
        If olvAssignments.Objects Is Nothing Then
            Return False
        Else
            For Each a As IClassAssignment In olvAssignments.Objects
                If a Is asmt Then
                    If olvAssignments.ModelToItem(a).Checked Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Next
        End If
    End Function
    Private Sub EmailResults_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        m_clas.EmailSendingAccount = nudEmailSendingAccount.Value
        AppSettings.EmailTrailingText = txtEmailTrailingText.Text
    End Sub


    Private Sub EmailResults_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nudEmailSendingAccount.Value = m_clas.EmailSendingAccount 'AppSettings.EmailSendingAccount
        txtEmailTrailingText.Text = AppSettings.EmailTrailingText
    End Sub

    Private Sub LoadData()
        Dim objData As EmailResultData
        m_lst.Clear()
        Dim intUnknownOutcomes As Integer

        For Each stud In m_clas.Students
            intUnknownOutcomes = 0

            objData = New EmailResultData()
            objData.AdminNumber = stud.AdminNumber
            objData.AltNumber = stud.AltNumber
            objData.Selected = False
            objData.Student = stud
            objData.StudentID = stud.StudentID
            objData.LocalName = stud.LocalName
            objData.Nickname = stud.Nickname
            objData.EmailAddress = stud.EmailAddress

            '-- need both btec and normal assignments
            objData.AssignmentsBTEC = stud.AssignmentsBTEC
            objData.Assignments = stud.Assignments

            If stud.AssignmentsBTEC.Count + stud.Assignments.Count = m_intAssignmentsSoFar Then
                '-- must have all assignments
                objData.AppearsReady = EmailResultData.AppearsReadyState.Ready
            Else
                objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady
            End If

            Dim rslts As Student.StudentModuleResult = stud.ModuleResults
            objData.M1 = rslts.M1Achieved
            objData.M2 = rslts.M2Achieved
            objData.M3 = rslts.M3Achieved
            objData.D1 = rslts.D1Achieved
            objData.D2 = rslts.D2Achieved
            objData.D3 = rslts.D3Achieved

            '-- Make sure there are no unknown outcomes
            For Each oc As Student.StudentModuleOutcomeResult In rslts.Outcomes
                If oc.Status = OutcomeResultStatusEnum.Unknown Then
                    intUnknownOutcomes += 1
                ElseIf oc.Status = OutcomeResultStatusEnum.Pass Then
                    objData.PassedOutcomes += 1
                End If
            Next
            '-- If it looks ready, then we must see if there are any unknown outcomes
            '-- if there are no unknown outcomes, then we're ok, otherwise, they didn't submit
            If objData.AppearsReady = EmailResultData.AppearsReadyState.Ready Then
                If intUnknownOutcomes > 0 Then
                    objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady
                End If
            End If

            '-- make sure there are no unprocessed assignments
            For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                If ShouldIncludeAssignment(asmt.BaseAssignment) Then
                    If Not asmt.Processed Then
                        objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady '-- If all asmts are processed, then student is ready, otherwise, not
                    End If
                End If
            Next

            For Each asmt As StudentAssignment In stud.Assignments
                If ShouldIncludeAssignment(asmt.BaseAssignment) Then
                    If Not asmt.Processed Then
                        objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady '-- If all asmts are processed, then student is ready, otherwise, not
                    End If
                End If
            Next


            m_lst.Add(objData) '-- include everyone

        Next

        olvStudents.SetObjects(m_lst)

        lblLoadedStudents.Text = m_lst.Count.ToString()

        txtSubject.Text = "Module Results for " & m_clas.ClassGroup.Name & " " & m_clas.Name


    End Sub
    'Private Sub LoadDataOld()
    '    Dim objData As EmailResultData
    '    m_lst.Clear()
    '    Dim intUnknownOutcomes As Integer

    '    For Each stud In m_clas.Students
    '        intUnknownOutcomes = 0

    '        objData = New EmailResultData()
    '        objData.AdminNumber = stud.AdminNumber
    '        objData.AltNumber = stud.AltNumber
    '        objData.Selected = False
    '        objData.Student = stud
    '        objData.StudentID = stud.StudentID
    '        objData.LocalName = stud.LocalName
    '        objData.Nickname = stud.Nickname
    '        objData.EmailAddress = stud.EmailAddress
    '        objData.Assignments = stud.AssignmentsBTEC

    '        '-- Use these for filtering later
    '        objData.FirstTryPassAll = stud.AssignmentsBTEC.Count = m_clas.ClassGroup.AssignmentsBTEC.Count
    '        objData.SecondTryPassAll = stud.AssignmentsBTEC.Count = m_clas.ClassGroup.AssignmentsBTEC.Count

    '        If stud.AssignmentsBTEC.Count = m_intAssignmentsSoFar Then
    '            '-- must have all assignments
    '            objData.AppearsReady = EmailResultData.AppearsReadyState.Ready
    '        Else
    '            objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady
    '        End If

    '        For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
    '            If ShouldIncludeAssignment(asmt.BaseAssignment) Then
    '                If Not asmt.Processed Then
    '                    objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady '-- If all asmts are processed, then student is ready, otherwise, not
    '                End If
    '                'If asmt.OverallComments IsNot Nothing AndAlso asmt.OverallComments.Trim.Length = 0 Then
    '                '    objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady '-- there is no overall comments, so this student is not ready to email
    '                'End If

    '                If asmt.M1Achieved Then
    '                    objData.M1 = True
    '                End If
    '                If asmt.M2Achieved Then
    '                    objData.M2 = True
    '                End If
    '                If asmt.M3Achieved Then
    '                    objData.M3 = True
    '                End If
    '                If asmt.D1Achieved Then
    '                    objData.D1 = True
    '                End If
    '                If asmt.D2Achieved Then
    '                    objData.D2 = True
    '                End If
    '                If asmt.D3Achieved Then
    '                    objData.D3 = True
    '                End If

    '                For Each result As OutcomeResult In asmt.Outcomes
    '                    If result.FirstTryStatus <> OutcomeResultStatusEnum.Pass Then
    '                        objData.FirstTryPassAll = False
    '                    End If
    '                    If result.FirstTryStatus <> OutcomeResultStatusEnum.Pass AndAlso result.SecondTryStatus <> OutcomeResultStatusEnum.Pass Then
    '                        objData.SecondTryPassAll = False
    '                    End If

    '                    If result.ThirdTryStatus = OutcomeResultStatusEnum.Unknown Then
    '                        If result.SecondTryStatus = OutcomeResultStatusEnum.Unknown Then
    '                            If result.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
    '                                '-- really unknown
    '                                intUnknownOutcomes += 1
    '                            Else
    '                                If result.FirstTryStatus = OutcomeResultStatusEnum.Pass Then
    '                                    objData.PassedOutcomes += 1
    '                                End If
    '                            End If
    '                        Else
    '                            If result.SecondTryStatus = OutcomeResultStatusEnum.Pass Then
    '                                objData.PassedOutcomes += 1
    '                            End If
    '                        End If
    '                    Else
    '                        If result.ThirdTryStatus = OutcomeResultStatusEnum.Pass Then
    '                            objData.PassedOutcomes += 1
    '                        End If
    '                    End If
    '                Next
    '            End If
    '        Next

    '        '-- If it looks ready, then we must see if there are any unknown outcomes
    '        '-- if there are no unknown outcomes, then we're ok, otherwise, they didn't submit
    '        If objData.AppearsReady = EmailResultData.AppearsReadyState.Ready Then
    '            If intUnknownOutcomes > 0 Then
    '                objData.AppearsReady = EmailResultData.AppearsReadyState.NotReady
    '            End If
    '        End If

    '        m_lst.Add(objData) '-- include everyone not hidden

    '    Next

    '    olvStudents.SetObjects(m_lst)

    '    lblLoadedStudents.Text = m_lst.Count.ToString()

    '    txtSubject.Text = "Module Results for " & m_clas.ClassGroup.Name & " " & m_clas.Name


    'End Sub

    Private Sub FirstTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        m_try = MarkingTry.FirstTry
        LoadData()
    End Sub

    Private Sub SecondTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        m_try = MarkingTry.SecondTry
        LoadData()
    End Sub

    Private Sub ThirdTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        m_try = MarkingTry.ThirdTry
        LoadData()
    End Sub

    Private Sub llblSelectStudents_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblSelectStudents.LinkClicked
        For Each obj As EmailResultData In olvStudents.SelectedObjects
            obj.Selected = True
        Next

        olvStudents.RefreshSelectedObjects()
        CalculateSelectedStudents()
    End Sub

    Private Sub llblUnSelectStudents_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblUnSelectStudents.LinkClicked
        For Each obj As EmailResultData In olvStudents.SelectedObjects
            obj.Selected = False
        Next

        olvStudents.RefreshSelectedObjects()
        CalculateSelectedStudents()
    End Sub

    Private Sub CalculateSelectedStudents()
        Dim intSelected As Integer
        For Each obj As EmailResultData In olvStudents.Objects
            If obj.Selected Then
                intSelected += 1
            End If
        Next

        lblSelectedStudents.Text = intSelected.ToString("#,##0")
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

    Private Sub llblClearFilter_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearFilter.LinkClicked
        txtStudentFilter.Text = String.Empty
        txtStudentFilter.Focus()
    End Sub

    Private Sub txtStudentFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStudentFilter.TextChanged
        tmrFilterStudents.Stop()
        tmrFilterStudents.Start()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub EmailSelectedStudents()
        If AppSettings.PathToTrulyMailEXE.Trim.Length = 0 OrElse Not System.IO.File.Exists(AppSettings.PathToTrulyMailEXE) Then
            MessageBox.Show("Please go to Tools->Options on main form and select the path to TrulyMail. TrulyMail must be used for emailing module results.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        btnCancel.Show()
        m_boolCancel = False

        Dim tm As Object ' New TrulyMail.NewMessage()
        Dim mainform As System.Runtime.Remoting.ObjectHandle
        Dim obj As Object

        Try
            lblSendingStatus.Text = "Preparing TrulyMail..."
            mainform = Activator.CreateInstanceFrom(AppSettings.PathToTrulyMailEXE, "TrulyMail.MainForm") '-- load appsettings, etc.
            obj = mainform.Unwrap()
        Catch ex As Exception
            MessageBox.Show("TrulyMail is not properly setup. Please check your settings in Tools->Options on the main form and try again.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ProgressBar1.Show()
        ProgressBar1.Maximum = m_lst.Count
        Application.DoEvents()

        Dim intCounter As Integer
        Dim dt As Date = Date.UtcNow.AddHours(nudSendInXHours.Value) '-- must be in UTC
        Dim strProblems As String = String.Empty

        Application.DoEvents()
        For Each dataItem As EmailResultData In m_lst
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
                Try
                    tm = obj.CreateNewMessage()
                    tm.show() '-- don't show, doesn't load all the smtp accounts
                    Application.DoEvents()
                Catch ex As Exception
                    Log(ex)
                End Try
                Try
                    If m_clas.ClassGroup.UseNickname Then
                        If dataItem.Nickname.Trim.Length > 0 Then
                            tm.AddRecipient(dataItem.Nickname, dataItem.EmailAddress)
                        Else
                            tm.AddRecipient(dataItem.Student.LocalNameLatinLetters, dataItem.EmailAddress)
                        End If
                    Else
                        tm.AddRecipient(dataItem.Student.LocalNameLatinLetters, dataItem.EmailAddress)
                    End If

                    tm.UseSendingAccount(nudEmailSendingAccount.Value)
                    tm.Subject = txtSubject.Text
                    tm.Body = GenerateEmailBodyForStudent(dataItem)
                    tm.SendAsPlainText = False
                    If Me.IncludeattachmentToolStripMenuItem.Checked Then
                        Dim files() As String
                        If Me.UseExtIDuncheckToUseStudentIDToolStripMenuItem.Checked Then
                            files = System.IO.Directory.GetFiles(m_strAttachmentPath, "*" & dataItem.Student.ExtStudentID & "*.*")
                        Else
                            files = System.IO.Directory.GetFiles(m_strAttachmentPath, "*" & dataItem.Student.StudentID & "*.*")
                        End If
                        For Each strFilename As String In files
                            tm.AddAttachment(strFilename)
                        Next
                    End If

                    Try
                        tm.SendThisMessage(dt)
                        obj.ShowUnreadOnOutBoxNode()
                        dataItem.Student.AddToActivityLog("Modules results sent.")
                        Application.DoEvents()
                    Catch ex As Exception
                        Log(ex)
                        dataItem.ProcessStatus = ex.Message
                        olvStudents.RefreshObject(dataItem)
                        tm.CloseSaveAsDraft()
                        tm = Nothing
                        Continue For
                    End Try
                    dataItem.ProcessStatus = "Sent: " & Date.Now.ToString(DATE_TIME_FORMAT_DETAIL)
                Catch ex As Exception
                    strProblems &= dataItem.StudentID & " - " & ex.Message & Environment.NewLine
                    Log(ex)
                End Try
            End If
        Next

        If strProblems.Length > 0 Then
            MessageBox.Show("The following students had problems: " & Environment.NewLine & Environment.NewLine & strProblems, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        AddHistory("Emailed module results (" & m_clas.ToString() & ") to " & m_lst.Count.ToString("#,##0") & " students.")

        lblSendingStatus.Text = "Finished."
        ProgressBar1.Hide()
        btnCancel.Hide()


    End Sub
    Private Function GenerateEmailBodyForStudent(item As EmailResultData)
        Dim str As New System.Text.StringBuilder()
        If m_clas.ClassGroup.UseNickname Then
            str.Append("Dear " & item.Nickname & " (" & item.LocalName & " - " & item.StudentID & "):<br><br>")
        Else
            str.Append("Dear " & item.LocalName & " (" & item.StudentID & "):<br><br>")
        End If

        str.Append("Below are your module results as of today.<br><br>")
        str.Append("The following assignments have been processed:<br>")

        str.Append("<ul>")

        Dim boolAtLeastOneBTECAssignment As Boolean
        Dim boolAtLeastOneNormalAssignment As Boolean
        Dim strText As String
        For Each asmt As ClassAssignmentBTEC In m_clas.ClassGroup.AssignmentsBTEC
            boolAtLeastOneBTECAssignment = True
            If ShouldIncludeAssignment(asmt) Then
                strText = asmt.Name & " "
                'If asmt.ClosedThirdTry Then
                '    strText &= "(2nd rework)"
                'ElseIf asmt.ClosedSecondTry Then
                '    strText &= "(1st rework)"
                'ElseIf asmt.ClosedFirstTry Then
                '    strText &= "(First submission)"
                'Else
                '    strText &= "(not processed)"
                'End If
                str.Append("<li>" & strText & "</li>")
            End If
        Next

        For Each asmt As ClassAssignment In m_clas.ClassGroup.Assignments
            boolAtLeastOneNormalAssignment = True
            If ShouldIncludeAssignment(asmt) Then
                strText = asmt.Name & " "
                str.Append("<li>" & strText & "</li>")
            End If
        Next
        str.Append("</ul>")

        If boolAtLeastOneBTECAssignment Then
            str.Append("This module has " & m_intModuleOutcomes.ToString() & " outcomes.<br><br>")
            Dim intFailedOutcomes As Integer = m_intModuleOutcomes - item.PassedOutcomes

            '-- If not sending grades, then don't send summary of grades either
            If chkIncludeGrade.Checked Then
                If intFailedOutcomes = 0 Then
                    str.Append("You passed " & item.PassedOutcomes.ToString() & " of them (yes, all of them).<br><br>")
                Else
                    str.Append("You passed " & item.PassedOutcomes.ToString() & " of them (still need the other " & intFailedOutcomes.ToString() & " of them).<br><br>")
                End If
            End If

            str.Append("Outcome details: <br><br>")
            str.Append(GenerateOutcomeDetails(item.Student))
            str.Append("<br>")
        End If

        '-- overall and improvement
        For Each asmt As StudentAssignmentBTEC In item.AssignmentsBTEC
            If ShouldIncludeAssignment(asmt.BaseAssignment) Then
                '-- If not sending grades, then don't send summary of grades either
                If chkIncludeGrade.Checked Then
                    str.Append("<br>")
                    str.Append("<b>Overall comments for " & asmt.BaseAssignment.Name & ": </b>" & asmt.OverallComments.Replace(Environment.NewLine, "<br>"))
                    str.Append("<br>")
                End If
                str.Append("<br>")
                str.Append("<b>Improvement comments for " & asmt.BaseAssignment.Name & ": </b>" & asmt.ImprovementComments.Replace(Environment.NewLine, "<br>"))
                str.Append("<br>")
                str.Append("<br>")
            End If
        Next


        Dim intGrade As Integer
        Dim dblPercent As Double
        For Each asmt As StudentAssignment In item.Assignments
            If ShouldIncludeAssignment(asmt.BaseAssignment) Then
                str.Append("<br>")
                intGrade = asmt.FirstTryPoints
                If asmt.SecondTryPoints > intGrade Then
                    intGrade = asmt.SecondTryPoints
                End If
                If asmt.ThirdTryPoints > intGrade Then
                    intGrade = asmt.ThirdTryPoints
                End If
                dblPercent = intGrade / asmt.BaseAssignment.MaxPoints
                str.Append("<b>Grade for " & asmt.BaseAssignment.Name & ": </b>" & intGrade.ToString("#,##0") & " out of " & asmt.BaseAssignment.MaxPoints.ToString("#,##0") & "  (" & dblPercent.ToString("##0%") & ")")
                str.Append("<br>")
                str.Append("<br>")
                str.Append("<b>Overall comments for " & asmt.BaseAssignment.Name & ": </b>" & asmt.OverallComments.Replace(Environment.NewLine, "<br>"))
                str.Append("<br>")
                str.Append("<br>")
                str.Append("<b>Improvement comments for " & asmt.BaseAssignment.Name & ": </b>" & asmt.ImprovementComments.Replace(Environment.NewLine, "<br>"))
                str.Append("<br>")
                str.Append("<br>")
            End If
        Next

        If boolAtLeastOneNormalAssignment Then
            str.Append("<hr>")
            str.Append("<b>Overall grade for module:</b> " & item.Student.AssessmentResultOverall)
            str.Append("<br>")
            str.Append("<hr>")
            str.Append("<br>")
        End If



        If boolAtLeastOneBTECAssignment Then
            str.Append("<br>")
            str.Append("<br>")


            Const ACHIEVED As String = "Achieved"
            Const NOTACHIEVED As String = "Not achieved"

            '-- No grades means no M's or D's or congratulations
            If chkIncludeGrade.Checked Then
                str.Append("M1: " & IIf(item.M1, ACHIEVED, NOTACHIEVED) & "<br>")
                str.Append("M2: " & IIf(item.M2, ACHIEVED, NOTACHIEVED) & "<br>")
                str.Append("M3: " & IIf(item.M3, ACHIEVED, NOTACHIEVED) & "<br>")
                If item.M1 AndAlso item.M2 AndAlso item.M3 Then
                    str.Append("You achieved MERIT!<br>")
                End If
                str.Append("<br>")
                str.Append("D1: " & IIf(item.D1, ACHIEVED, NOTACHIEVED) & "<br>")
                str.Append("D2: " & IIf(item.D2, ACHIEVED, NOTACHIEVED) & "<br>")
                str.Append("D3: " & IIf(item.D3, ACHIEVED, NOTACHIEVED) & "<br>")
                If item.D1 AndAlso item.D2 AndAlso item.D3 Then
                    str.Append("You achieved DISTINCTION!!!<br>")
                End If
                str.Append("<br>")

                If item.PassedOutcomes >= m_intModuleOutcomes Then
                    str.Append("Congratulations!!!<br><br>")
                Else
                    If m_try = MarkingTry.FirstTry Then
                        str.Append("Don't worry. You can still fix it.<br><br>")
                    Else
                        str.Append("I am sure you will do better next time.<br><br>")
                    End If
                End If
            End If
        End If


        str.Append(txtEmailTrailingText.Text.Replace(Environment.NewLine, "<br>"))


        Return str.ToString()
    End Function
    Private Function GetResultsText(status As OutcomeResultStatusEnum)
        If status = OutcomeResultStatusEnum.Pass Then
            Return AppSettings.PassResultsText
        ElseIf status = OutcomeResultStatusEnum.Fail Then
            Return AppSettings.FailResultsText
        Else '-- unknown
            Return AppSettings.UnknownResultsText
        End If
    End Function
    Private Function GenerateOutcomeDetails(student As Student) As String
        '-- simple logic, we are going to walk all the assignments and each outcome in each assignment and see if the student passed or not
        Dim strResult As String = String.Empty
        Dim strFeedback As String = String.Empty
        Dim sbReturn As New System.Text.StringBuilder()
        sbReturn.Append("<table border='1'>")
        Dim rslts As Student.StudentModuleResult = student.ModuleResults

        sbReturn.Append("<tr><td>Outcome</td><td>Result</td><td>Feedback</td></tr>")


        rslts.Outcomes.Sort()

        For Each oc As Student.StudentModuleOutcomeResult In rslts.Outcomes
            strResult = GetResultsText(oc.Status) & " &nbsp;" '-- make sure tables look ok with no text
            strFeedback = oc.LatestFeedback & " &nbsp;"

            '-- First part of line is the same no matter what (outcome name)
            sbReturn.Append("<tr><td>" & oc.Outcome.Name & "</td>")

            '-- Next is grade, but only include if that is checked
            If chkIncludeGrade.Checked Then
                If oc.Status = OutcomeResultStatusEnum.Pass Then
                    sbReturn.Append("<td bgcolor='LightGreen'>" & strResult & "</td>")
                Else
                    sbReturn.Append("<td bgcolor='Red'>" & strResult & "</td>")
                End If
            Else
                '-- We are not supposed to send the grade
                '   So just send blank, no color coding
                sbReturn.Append("<td>&nbsp;</td>")
            End If

            If Me.chkIncludeFeedback.Checked Then
                sbReturn.Append("<td>" & strFeedback & "</td>")
            Else
                '-- We are not supposed to send the feedback
                '   So just send blank
                sbReturn.Append("<td>&nbsp;</td>")
            End If

            '-- Last part of the line is the same no matter what
            sbReturn.Append("</tr>")

            'If Me.chkIncludeFeedback.Checked Then
            '    If oc.Status = OutcomeResultStatusEnum.Pass Then
            '        sbReturn.Append("<tr><td>" & oc.Outcome.Name & "</td><td bgcolor='LightGreen'>" & strResult & "</td><td>" & strFeedback & "</td></tr>")
            '    Else
            '        sbReturn.Append("<tr><td>" & oc.Outcome.Name & "</td><td bgcolor='Red'>" & strResult & "</td><td>" & strFeedback & "</td></tr>")
            '    End If
            'Else
            '    '-- should never get here
            '    sbReturn.Append("<tr><td>" & oc.Outcome.Name & "</td><td>" & strResult & "</td><td>&nbsp;</td></tr>")
            'End If

        Next

        sbReturn.Append("</table>")


        Return sbReturn.ToString()
    End Function

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim boolSendNow As Boolean = True
        If RecommendAttachment() AndAlso (IncludeattachmentToolStripMenuItem.Checked = False) Then
            If MessageBox.Show("At least one assignment includes an attachment. Would you like to continue, ignoring all attachments?", "Attachment Missing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
                boolSendNow = True
            Else
                boolSendNow = False
            End If
        End If

        If boolSendNow Then
            EmailSelectedStudents()
        End If
    End Sub
    Private Function RecommendAttachment() As Boolean
        For Each asmt As IClassAssignment In olvAssignments.CheckedObjects
            If asmt.IncludesAttachment Then
                Return True
            End If
        Next

        Return False
    End Function
    Private Sub llblRemoveEmailedData_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveEmailedData.LinkClicked
        For Each dataitem As EmailResultData In olvStudents.SelectedObjects
            dataitem.Student.EmailedData = String.Empty
        Next
        olvStudents.RefreshSelectedObjects()
    End Sub

    Private Sub LoadToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem1.Click
        Try
            LoadData()
        Catch ex As Exception
            MessageBox.Show("There was an error loading the students (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetHiddenForSelectedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SethiddenForSelectedToolStripMenuItem.Click
        Try
            For Each dataitem As EmailResultData In olvStudents.SelectedObjects
                dataitem.Student.Hidden = True
            Next
            olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            MessageBox.Show("There was an error setting the students hidden (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearHiddenForSelectedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearHiddenForSelectedToolStripMenuItem.Click
        Try
            For Each dataitem As EmailResultData In olvStudents.SelectedObjects
                dataitem.Student.Hidden = False
            Next
            olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            MessageBox.Show("There was an error setting the students hidden (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        btnCancel.Hide()
        m_boolCancel = True
    End Sub

    Private Sub CalculateOutcomes()
        m_intModuleOutcomes = m_clas.ClassGroup.Outcomes.Count

        m_intAssignmentsSoFar = 0
        For Each asmt As ClassAssignmentBTEC In m_clas.ClassGroup.AssignmentsBTEC
            If ShouldIncludeAssignment(asmt) Then
                '-- We ignore outcomes which have not been submitted and marked
                'm_intModuleOutcomes += asmt.Outcomes.Count
                m_intAssignmentsSoFar += 1
            End If
        Next

        For Each asmt As ClassAssignment In m_clas.ClassGroup.Assignments
            If ShouldIncludeAssignment(asmt) Then
                '-- We ignore outcomes which have not been submitted and marked
                'm_intModuleOutcomes += asmt.Outcomes.Count
                m_intAssignmentsSoFar += 1
            End If
        Next

        lblTotalOutcomes.Text = m_intModuleOutcomes.ToString()

    End Sub
    Private Sub olvAssignments_ItemChecked(sender As System.Object, e As System.Windows.Forms.ItemCheckedEventArgs) Handles olvAssignments.ItemChecked
        CalculateOutcomes()
    End Sub

    Private Sub IncludeattachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncludeattachmentToolStripMenuItem.Click
        If IncludeattachmentToolStripMenuItem.Checked Then
            Dim ofd As New OpenFileDialog()
            ofd.Title = "Please select one file from the folder you want to use."
            ofd.Filter = "All files|*.*"
            If m_strAttachmentPath Is Nothing Then
                ofd.InitialDirectory = "C:\"
            Else
                ofd.InitialDirectory = m_strAttachmentPath
            End If
            If ofd.ShowDialog = DialogResult.OK Then
                m_strAttachmentPath = System.IO.Path.GetDirectoryName(ofd.FileName)
            End If
        End If
    End Sub
End Class

Public Class EmailResultData
    Public Property Selected As Boolean
    Public Property AdminNumber As Integer
    Public Property AltNumber As Int16
    Public Property Student As Student
    Public Property StudentID As String
    Public Property LocalName As String
    Public Property Nickname As String
    Public Property EmailAddress As String
    Public Property PassedOutcomes As Integer
    Public Property M1 As Boolean
    Public Property M2 As Boolean
    Public Property M3 As Boolean
    Public Property D1 As Boolean
    Public Property D2 As Boolean
    Public Property D3 As Boolean
    Public Property FirstTryPassAll As Boolean
    Public Property SecondTryPassAll As Boolean
    Public Property AppearsReady As AppearsReadyState
    Public Property AssignmentsBTEC As List(Of StudentAssignmentBTEC)
    Public Property Assignments As List(Of StudentAssignment)
    Public Property ProcessStatus As String

    Public Enum AppearsReadyState
        NotReady
        Ready
    End Enum
End Class