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
Public Class EmailModuleResults

    Private m_clas As SchoolClass
    Private m_lst As New List(Of EmailResultData)
    Private m_try As Semester.MarkingTry = -1
    Private m_intModuleOutcomes As Integer
    Private m_intAssignmentsSoFar As Integer
    Private m_boolCancel As Boolean
    Private m_lstAssignments As New List(Of IClassAssignment)
    Private m_strAttachmentPath As String
    Private m_boolAssignmentSelectionDirty As Boolean

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
        If olvAssignments.CheckedObjects.Count = 0 Then
            MessageBox.Show("You should select at least one assignment before loading the data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        m_lst.Clear()
        m_boolAssignmentSelectionDirty = False
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

            Dim rslts As Student.StudentModuleResult = stud.ModuleResults(chkIncludeUnprocessed.Checked)

            '-- We must remove outcomes which are not on selected assignments
            Dim lstToRemove As New List(Of Student.StudentModuleOutcomeResult)()
            For Each oc As Student.StudentModuleOutcomeResult In rslts.Outcomes
                If Not OutcomeShouldBeSent(oc.Outcome) Then
                    lstToRemove.Add(oc)
                End If
            Next

            '-- Now actually remove them
            For Each oc As Student.StudentModuleOutcomeResult In lstToRemove
                rslts.Outcomes.Remove(oc)
            Next

            '-- Make sure there are no unknown outcomes
            For Each oc As Student.StudentModuleOutcomeResult In rslts.Outcomes
                If oc.Status = OutcomeResultStatusEnum.Unknown Then
                    intUnknownOutcomes += 1
                ElseIf oc.Status = OutcomeResultStatusEnum.Achieved AndAlso oc.Outcome.GradeGroup = BTECGradeGroup.Pass AndAlso OutcomeShouldBeSent(oc.Outcome) Then
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
        m_try = Semester.MarkingTry.FirstTry
        LoadData()
    End Sub

    Private Sub SecondTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        m_try = Semester.MarkingTry.SecondTry
        LoadData()
    End Sub

    Private Sub ThirdTryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        m_try = Semester.MarkingTry.ThirdTry
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
                    tm = obj.CreateNewMessage(Not AppSettings.EmailAsHTML) '-- True = force plaintext
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


        AddApplicationHistory("Emailed module results (" & m_clas.Name.ToString() & ") to " & m_lst.Count.ToString("#,##0") & " students.")

        lblSendingStatus.Text = "Finished."
        ProgressBar1.Hide()
        btnCancel.Hide()


    End Sub
    Private Function GenerateEmailBodyForStudent(item As EmailResultData)
        Dim str As New System.Text.StringBuilder()
        If m_clas.ClassGroup.UseNickname Then
            str.Append("Dear " & item.Nickname & " (" & item.LocalName & " - " & item.StudentID & "):")
        Else
            str.Append("Dear " & item.LocalName & " (" & item.StudentID & "):")
        End If

        If AppSettings.EmailAsHTML Then
            str.Append("<br>")
            str.Append("<br>")
        Else
            str.Append(Environment.NewLine)
            str.Append(Environment.NewLine)
        End If

        If chkIncludeGrade.Checked Then
            str.Append("Below are your module results as of today.")
        End If

        If AppSettings.EmailAsHTML Then
            str.Append("<br>")
            str.Append("<br>")
        Else
            str.Append(Environment.NewLine)
            str.Append(Environment.NewLine)
        End If


        str.Append("The following assignments have been processed:")

        If AppSettings.EmailAsHTML Then
            str.Append("<br>")
        Else
            str.Append(Environment.NewLine)
        End If

        If AppSettings.EmailAsHTML Then
            str.Append("<ul>")
        Else
            str.Append(Environment.NewLine)
        End If

        Dim boolAtLeastOneBTECAssignment As Boolean
        Dim boolAtLeastOneNormalAssignment As Boolean
        Dim strText As String
        For Each asmt As ClassAssignmentBTEC In m_clas.ClassGroup.AssignmentsBTEC
            If ShouldIncludeAssignment(asmt) Then
                boolAtLeastOneBTECAssignment = True
                strText = asmt.Name & " "
                If AppSettings.EmailAsHTML Then
                    str.Append("<li>" & strText & "</li>")
                Else
                    str.Append("  * " & strText & Environment.NewLine)
                End If
            End If
        Next

        For Each asmt As ClassAssignment In m_clas.ClassGroup.Assignments
            If ShouldIncludeAssignment(asmt) Then
                boolAtLeastOneNormalAssignment = True
                strText = asmt.Name & " "
                If AppSettings.EmailAsHTML Then
                    str.Append("<li>" & strText & "</li>")
                Else
                    str.Append("  * " & strText & Environment.NewLine)
                End If
            End If
        Next
        If AppSettings.EmailAsHTML Then
            str.Append("</ul>")
        Else
            str.Append(Environment.NewLine)
        End If

        If boolAtLeastOneBTECAssignment Then
            If olvAssignments.CheckedItems.Count = 1 Then
                str.Append("This assessment has " & m_intModuleOutcomes.ToString() & " pass-level outcome")
            Else
                str.Append("These assessments have " & m_intModuleOutcomes.ToString() & " pass-level outcome")
            End If

            '-- Plural "outcomes" as needed
            If m_intModuleOutcomes = 1 Then
                str.Append(".")
            Else
                str.Append("s.")
            End If

            If AppSettings.EmailAsHTML Then
                str.Append("<br>")
                str.Append("<br>")
            Else
                str.Append(Environment.NewLine)
                str.Append(Environment.NewLine)
            End If

            Dim intFailedOutcomes As Integer = m_intModuleOutcomes - item.PassedOutcomes

            '-- If not sending grades, then don't send summary of grades either
            If chkIncludeGrade.Checked Then
                If intFailedOutcomes = 0 Then
                    str.Append("You passed " & item.PassedOutcomes.ToString() & " of them (yes, all of them).")
                Else
                    str.Append("You passed " & item.PassedOutcomes.ToString() & " of them (still need the other " & intFailedOutcomes.ToString() & " of them).")
                End If
            End If

            If AppSettings.EmailAsHTML Then
                str.Append("<br>")
                str.Append("<br>")
            Else
                str.Append(Environment.NewLine)
                str.Append(Environment.NewLine)
            End If

            str.Append("Outcome details:")

            If AppSettings.EmailAsHTML Then
                str.Append("<br>")
                str.Append("<br>")
            Else
                str.Append(Environment.NewLine)
                str.Append(Environment.NewLine)
            End If

            str.Append(GenerateOutcomeDetails(item.Student))
            If AppSettings.EmailAsHTML Then
                str.Append("<br>")
            Else
                str.Append(Environment.NewLine)
            End If
        End If

        '-- overall and improvement
        For Each asmt As StudentAssignmentBTEC In item.AssignmentsBTEC
            If ShouldIncludeAssignment(asmt.BaseAssignment) Then
                If AppSettings.EmailAsHTML Then
                    str.Append("<hr />")
                Else
                    str.Append(Environment.NewLine)
                    str.Append("===============================================")
                    str.Append(Environment.NewLine)
                End If

                '-- If not sending grades, then don't send summary of grades either
                If chkIncludeGrade.Checked Then
                    '-- Grade is normally in overall, so for BTEC there is nothing to do here

                End If

                If chkIncludeOverall.Checked AndAlso asmt.OverallComments.Length > 0 Then
                    If AppSettings.EmailAsHTML Then
                        str.Append("<br>")
                        str.Append("<b>Overall comments for " & asmt.BaseAssignment.Name & ": </b>" & asmt.OverallComments.Replace(vbLf, "<br>"))
                        str.Append("<br>")
                        If asmt.OverallCommentsRework.Length > 0 Then
                            str.Append("<br>")
                            str.Append("<b>Overall comments for rework of " & asmt.BaseAssignment.Name & ": </b>" & asmt.OverallCommentsRework.Replace(vbLf, "<br>"))
                            str.Append("<br>")
                            str.Append("<br>")
                        End If
                    Else
                        str.Append(Environment.NewLine)
                        str.Append("Overall comments for " & asmt.BaseAssignment.Name & ": " & Environment.NewLine & asmt.OverallComments)
                        str.Append(Environment.NewLine)
                        If asmt.OverallCommentsRework.Length > 0 Then
                            str.Append(Environment.NewLine)
                            str.Append("Overall comments for rework of " & asmt.BaseAssignment.Name & ": " & Environment.NewLine & asmt.OverallCommentsRework)
                            str.Append(Environment.NewLine)
                            str.Append(Environment.NewLine)
                        End If
                    End If
                End If

                If chkIncludeImprovement.Checked AndAlso asmt.ImprovementComments.Length > 0 Then
                    If AppSettings.EmailAsHTML Then
                        str.Append("<br>")
                        str.Append("<b>Improvement comments for " & asmt.BaseAssignment.Name & ": </b>" & asmt.ImprovementComments.Replace(vbLf, "<br>")) '-- Not sure wby newline does not work but only LF char is there
                        str.Append("<br>")
                        str.Append("<br>")
                        If asmt.ImprovementCommentsRework.Length > 0 Then
                            str.Append("<br>")
                            str.Append("<b>Improvement comments for rework of " & asmt.BaseAssignment.Name & ": </b>" & asmt.ImprovementCommentsRework.Replace(vbLf, "<br>")) '-- Not sure wby newline does not work but only LF char is there
                            str.Append("<br>")
                            str.Append("<br>")
                        End If
                    Else
                        str.Append(Environment.NewLine)
                        str.Append("Improvement comments for " & asmt.BaseAssignment.Name & ": " & Environment.NewLine & asmt.ImprovementComments)
                        str.Append(Environment.NewLine)
                        str.Append(Environment.NewLine)
                        If asmt.ImprovementCommentsRework.Length > 0 Then
                            str.Append(Environment.NewLine)
                            str.Append("Improvement comments for rework of " & asmt.BaseAssignment.Name & ": " & Environment.NewLine & asmt.ImprovementCommentsRework)
                            str.Append(Environment.NewLine)
                            str.Append(Environment.NewLine)
                        End If
                    End If
                End If
            End If
        Next


        '-- This is for Normal assignments
        Dim intGrade As Integer
        Dim dblPercent As Double
        Dim intAssignmentSent As Integer
        Dim thisAsmt As StudentAssignment

        '-- We want the order to be based on the order in the UI's list (which can be re-ordered in the UI)
        For Each baseAsmt As ClassAssignment In item.Student.SchoolClass.ClassGroup.Assignments
            thisAsmt = Nothing
            For Each sAsmt As StudentAssignment In item.Assignments
                If sAsmt.BaseAssignment Is baseAsmt Then
                    thisAsmt = sAsmt
                    Exit For
                End If
            Next

            If thisAsmt Is Nothing Then
                '-- We did not match, so skip this classassignment
                Continue For
            End If

            If ShouldIncludeAssignment(thisAsmt.BaseAssignment) Then
                intAssignmentSent += 1
                If AppSettings.EmailAsHTML Then
                    str.Append("<br>")
                Else
                    str.Append(Environment.NewLine)
                End If

                intGrade = thisAsmt.FirstTryPoints
                If thisAsmt.SecondTryPoints > intGrade Then
                    intGrade = thisAsmt.SecondTryPoints
                End If
                If thisAsmt.ThirdTryPoints > intGrade Then
                    intGrade = thisAsmt.ThirdTryPoints
                End If
                dblPercent = intGrade / thisAsmt.BaseAssignment.MaxPoints

                If AppSettings.EmailAsHTML Then
                    str.Append("<hr />")
                Else
                    str.Append(Environment.NewLine)
                    str.Append("===============================================")
                    str.Append(Environment.NewLine)
                End If


                If chkIncludeGrade.Checked AndAlso thisAsmt.BaseAssignment.MaxPoints > 0 Then
                    If AppSettings.EmailAsHTML Then
                        str.Append("<b>Grade for " & thisAsmt.BaseAssignment.Name & ": </b>" & intGrade.ToString("#,##0") & " out of " & thisAsmt.BaseAssignment.MaxPoints.ToString("#,##0") & "  (" & dblPercent.ToString("##0%") & ")")
                        str.Append("<br>")
                        str.Append("<br>")
                    Else
                        str.Append("Grade for " & thisAsmt.BaseAssignment.Name & ": " & intGrade.ToString("#,##0") & " out of " & thisAsmt.BaseAssignment.MaxPoints.ToString("#,##0") & "  (" & dblPercent.ToString("##0%") & "%)") '-- % sign does not show but needs to be there for .Net calc (so need both)
                        str.Append(Environment.NewLine)
                        str.Append(Environment.NewLine)
                    End If

                End If

                If chkIncludeOverall.Checked AndAlso thisAsmt.OverallComments.Length > 0 Then
                    If AppSettings.EmailAsHTML Then
                        str.Append("<b>Overall comments for " & thisAsmt.BaseAssignment.Name & ": </b>" & thisAsmt.OverallComments.Replace(vbLf, "<br>"))
                        str.Append("<br>")
                        str.Append("<br>")
                    Else
                        str.Append("Overall comments for " & thisAsmt.BaseAssignment.Name & ": " & Environment.NewLine & thisAsmt.OverallComments)
                        str.Append(Environment.NewLine)
                        str.Append(Environment.NewLine)
                    End If
                End If

                If chkIncludeImprovement.Checked AndAlso thisAsmt.ImprovementComments.Length > 0 Then
                    If AppSettings.EmailAsHTML Then
                        str.Append("<b>Improvement comments for " & thisAsmt.BaseAssignment.Name & ": </b>" & thisAsmt.ImprovementComments.Replace(vbLf, "<br>"))
                        str.Append("<br>")
                        str.Append("<br>")
                    Else
                        str.Append("Improvement comments for " & thisAsmt.BaseAssignment.Name & ": " & Environment.NewLine & thisAsmt.ImprovementComments)
                        str.Append(Environment.NewLine)
                        str.Append(Environment.NewLine)
                    End If
                End If
            End If
        Next

        If AppSettings.EmailAsHTML Then
            str.Append("<hr />")
        Else
            str.Append(Environment.NewLine)
            str.Append("===============================================")
            str.Append(Environment.NewLine)
        End If


        'If intAssignmentSent < olvAssignments.CheckedItems.Count Then
        '    '-- This students seems to be missing at least one of the checked assignments
        '    '   Notify student about this
        '    '== RECONSIDER - for some assignments, like news reports, not all students might do them at the same time
        '    '               Since teachers might handle this differently, it needs to be highly configurable...which means we do this later
        '    str.Append("It seems you are missing at least one assignment. If you believe you did all of the assignments, please come to see me in class.")
        '    str.Append("<br>")
        '    str.Append("<br>")
        'End If


        If chkIncludeOverallGrade.Checked Then
            If boolAtLeastOneNormalAssignment Then
                If AppSettings.EmailAsHTML Then
                    str.Append("<hr>")
                    str.Append("<b>Overall grade for module:</b> " & item.Student.AssessmentResultOverall)
                    str.Append("<br>")
                    str.Append("<hr>")
                    str.Append("<br>")
                Else
                    str.Append("------------------------------------------")
                    str.Append(Environment.NewLine)
                    str.Append("Overall grade for module: " & item.Student.AssessmentResultOverall)
                    str.Append(Environment.NewLine)
                    str.Append("------------------------------------------")
                    str.Append(Environment.NewLine)
                End If
            End If
        End If



        If boolAtLeastOneBTECAssignment Then
            If AppSettings.EmailAsHTML Then
                str.Append("<br>")
                str.Append("<br>")
            Else
                str.Append(Environment.NewLine)
                str.Append(Environment.NewLine)
            End If


            Const ACHIEVED As String = "Achieved"
            Const NOTACHIEVED As String = "Not achieved"

            '-- No grades means no M's or D's or congratulations
            If chkIncludeGrade.Checked Then
                If chkFinalFeedback.Checked Then
                    If item.PassedOutcomes >= m_intModuleOutcomes Then
                        str.Append("Congratulations!!!")
                        If AppSettings.EmailAsHTML Then
                            str.Append("<br>")
                            str.Append("<br>")
                        Else
                            str.Append(Environment.NewLine)
                            str.Append(Environment.NewLine)
                        End If

                    Else
                        If m_try = Semester.MarkingTry.FirstTry Then
                            str.Append("Don't worry. There is still time to do better.")
                        Else
                            str.Append("I am sure you will do better next time.")
                        End If

                        If AppSettings.EmailAsHTML Then
                            str.Append("<br>")
                            str.Append("<br>")
                        Else
                            str.Append(Environment.NewLine)
                            str.Append(Environment.NewLine)
                        End If
                    End If
                End If
            End If
        End If


        If AppSettings.EmailAsHTML Then
            str.Append(txtEmailTrailingText.Text.Replace(Environment.NewLine, "<br>"))
        Else
            str.Append(txtEmailTrailingText.Text)
        End If


        Return str.ToString()
    End Function
    Private Function GetResultsText(status As OutcomeResultStatusEnum)
        If status = OutcomeResultStatusEnum.Achieved Then
            Return AppSettings.PassResultsText
        ElseIf status = OutcomeResultStatusEnum.NotAchieved Then
            Return AppSettings.FailResultsText
        Else '-- unknown
            Return AppSettings.UnknownResultsText
        End If
    End Function
    Private Function OutcomeShouldBeSent(outcome As AssignmentOutcome) As Boolean
        '-- Simple, if outcome passed in is on an assignment which is checked, then send, otherwise do not send
        If olvAssignments.Objects Is Nothing Then
            Return False
        Else
            For Each a As IClassAssignment In olvAssignments.Objects
                If ShouldIncludeAssignment(a) Then
                    If a.AssignmentType = AssignmentType.BTEC Then
                        Dim asmt As ClassAssignmentBTEC = CType(a, ClassAssignmentBTEC)
                        For Each oc As AssignmentOutcome In asmt.Outcomes
                            If oc.ID = outcome.ID Then
                                Return True '-- match, get out
                            End If
                        Next
                    End If
                End If
            Next
        End If
    End Function
    Private Function GenerateOutcomeDetails(student As Student) As String
        '-- simple logic, we are going to walk all the assignments and each outcome in each assignment and see if the student passed or not
        Dim strResult As String = String.Empty
        Dim strFeedback As String = String.Empty
        Dim sbReturn As New System.Text.StringBuilder()

        Dim rslts As Student.StudentModuleResult = student.ModuleResults(chkIncludeUnprocessed.Checked)

        If AppSettings.EmailAsHTML Then
            sbReturn.Append("<table border='1'>")
            sbReturn.Append("<tr><td align=center>Outcome</td><td align=center>Result</td><td>Feedback</td></tr>")
        Else
            '-- First column 10
            '   Second column 9
            '   Third column whatever is left
            sbReturn.Append("Outcome   Result   Feedback")
            sbReturn.Append(Environment.NewLine)
        End If

        Const FIRST_COLUMN_LENGTH As Integer = 10
        Const SECOND_COLUMN_LENGTH As Integer = 9

        rslts.Outcomes.Sort()

        For Each oc As Student.StudentModuleOutcomeResult In rslts.Outcomes
            If OutcomeShouldBeSent(oc.Outcome) Then

                strResult = GetResultsText(oc.Status)
                strFeedback = oc.LatestFeedback


                '-- First part of line is the same no matter what (outcome name)
                If AppSettings.EmailAsHTML Then
                    sbReturn.Append("<tr><td align='center'>" & oc.Outcome.Name & "</td>")
                Else
                    sbReturn.Append(GetSpacePaddedString(oc.Outcome.Name, FIRST_COLUMN_LENGTH))
                End If


                '-- Next is grade, but only include if that is checked
                If chkIncludeGrade.Checked Then
                    Dim boolOKToInclude As Boolean
                    If oc.Outcome.GradeGroup = BTECGradeGroup.Merit OrElse oc.Outcome.GradeGroup = BTECGradeGroup.Distinction Then
                        If chkIncludeMeritDistinctionResults.Checked Then
                            boolOKToInclude = True
                        Else
                            boolOKToInclude = False
                        End If
                    Else
                        boolOKToInclude = True
                    End If


                    If boolOKToInclude Then
                        If AppSettings.EmailAsHTML Then
                            If oc.Status = OutcomeResultStatusEnum.Achieved Then
                                sbReturn.Append("<td bgcolor='LightGreen' align='center'>" & strResult & " &nbsp;" & "</td>") '-- make sure tables look ok with no text
                            Else
                                sbReturn.Append("<td bgcolor='Red' align='center'>" & strResult & " &nbsp;" & "</td>")
                            End If
                        Else
                            sbReturn.Append(GetSpacePaddedString(strResult, SECOND_COLUMN_LENGTH))
                        End If

                        If Me.chkIncludeFeedback.Checked Then
                            If AppSettings.EmailAsHTML Then
                                sbReturn.Append("<td>" & strFeedback & "&nbsp;</td>")
                            Else
                                sbReturn.Append(strFeedback)
                            End If

                        Else
                            '-- We are not supposed to send the feedback
                            '   So just send blank
                            If AppSettings.EmailAsHTML Then
                                sbReturn.Append("<td>&nbsp;</td>")
                            Else
                                '-- nothing needed here
                            End If
                        End If
                    Else
                        '-- Do not include merit or distinction means
                        '   do not include the feedback for merit or distinction
                        '   also do not include the grade
                        If AppSettings.EmailAsHTML Then
                            sbReturn.Append("<td align='center'>&nbsp;</td>")
                            sbReturn.Append("<td>&nbsp;</td>")
                        Else
                            sbReturn.Append(GetSpacePaddedString(String.Empty, SECOND_COLUMN_LENGTH))
                        End If
                    End If
                Else
                    '-- We are not supposed to send the grade
                    '   So just send blank, no color coding

                    If oc.Outcome.GradeGroup = BTECGradeGroup.Merit OrElse oc.Outcome.GradeGroup = BTECGradeGroup.Distinction Then
                        '-- Do not include grade means
                        '   do not include the feedback for merit or distinction
                        '   also do not include the grade
                        If AppSettings.EmailAsHTML Then
                            sbReturn.Append("<td align='center'>&nbsp;</td>")
                            sbReturn.Append("<td>&nbsp;</td>")
                        Else
                            sbReturn.Append(GetSpacePaddedString(String.Empty, SECOND_COLUMN_LENGTH))
                        End If
                    Else
                        '-- pass-level outcome
                        If AppSettings.EmailAsHTML Then
                            sbReturn.Append("<td align='center'>&nbsp;</td>")
                        Else
                            sbReturn.Append(GetSpacePaddedString(String.Empty, SECOND_COLUMN_LENGTH))
                        End If

                        If Me.chkIncludeFeedback.Checked Then
                            If AppSettings.EmailAsHTML Then
                                sbReturn.Append("<td>" & strFeedback & "&nbsp;</td>")
                            Else
                                '-- nothing needed here
                            End If
                        Else
                            '-- We are not supposed to send the feedback
                            '   So just send blank
                            If AppSettings.EmailAsHTML Then
                                sbReturn.Append("<td>&nbsp;</td>")
                            Else
                                '-- nothing needed here
                            End If
                        End If
                    End If
                End If



                '-- Last part of the line is the same no matter what
                If AppSettings.EmailAsHTML Then
                    sbReturn.Append("</tr>")
                Else
                    sbReturn.Append(Environment.NewLine)
                End If

            End If
        Next
        If AppSettings.EmailAsHTML Then
            sbReturn.Append("</table>")
        End If



        Return sbReturn.ToString()
    End Function

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If m_boolAssignmentSelectionDirty Then
            '-- changing assignment selection will change many things
            '   user really should reload the data, but we will allow them to override
            If MessageBox.Show("You should reload the data after you change which assessments will be sent. Override and send anyway?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If
        End If

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
        m_intModuleOutcomes = 0 '-- reset and only count pass outcomes
        For Each oc As AssignmentOutcome In m_clas.ClassGroup.Outcomes
            If oc.GradeGroup = BTECGradeGroup.Pass Then
                If OutcomeShouldBeSent(oc) Then
                    m_intModuleOutcomes += 1
                End If
            End If
        Next

        m_intAssignmentsSoFar = 0
        For Each asmt As ClassAssignmentBTEC In m_clas.ClassGroup.AssignmentsBTEC
            If ShouldIncludeAssignment(asmt) Then
                m_intAssignmentsSoFar += 1
            End If
        Next

        For Each asmt As ClassAssignment In m_clas.ClassGroup.Assignments
            If ShouldIncludeAssignment(asmt) Then
                m_intAssignmentsSoFar += 1
            End If
        Next

        lblTotalOutcomes.Text = m_intModuleOutcomes.ToString()

    End Sub
    Private Sub olvAssignments_ItemChecked(sender As System.Object, e As System.Windows.Forms.ItemCheckedEventArgs) Handles olvAssignments.ItemChecked
        m_boolAssignmentSelectionDirty = True
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

    Private Sub olvStudents_KeyDown(sender As Object, e As KeyEventArgs) Handles olvStudents.KeyDown
        '-- pressing space will toggle send/don't send
        If e.KeyCode = Keys.Space Then
            For Each obj As EmailResultData In olvStudents.SelectedObjects
                obj.Selected = Not obj.Selected
            Next

            olvStudents.RefreshSelectedObjects()
            CalculateSelectedStudents()
        End If
    End Sub

    Private Sub chkSelectAllAssessments_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAllAssessments.CheckedChanged
        If chkSelectAllAssessments.Checked Then
            olvAssignments.CheckAll()
        Else
            olvAssignments.UncheckAll()
        End If
    End Sub

    Private Sub llblWorkshopFeedback_LinkClicked(sender As Object, e As EventArgs) Handles llblWorkshopFeedback.LinkClicked
        chkIncludeGrade.Checked = False '-- grade for normal
        chkIncludeMeritDistinctionResults.Checked = False '-- has grade for btec
        chkIncludeFeedback.Checked = True '-- btec feedback
        chkFinalFeedback.Checked = False
        chkIncludeImprovement.Checked = True '-- for btec
        chkIncludeOverall.Checked = False '-- has grade for presentations
        chkIncludeOverallGrade.Checked = False '-- has grade
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
    'Public Property M1 As Boolean
    'Public Property M2 As Boolean
    'Public Property M3 As Boolean
    'Public Property D1 As Boolean
    'Public Property D2 As Boolean
    'Public Property D3 As Boolean
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