Public Class OptionsForm

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        AppSettings.AttendenceReportMarkPresent = txtAttendenceMarkPresent.Text
        AppSettings.AttendenceReportMarkLate = txtAttendenceMarkLate.Text
        AppSettings.AttendenceReportMarkAbsent = txtAttendenceMarkAbsent.Text
        AppSettings.AttendenceReportMarkRemoved = txtAttendenceMarkRemoved.Text
        AppSettings.AttendenceReportMarkUnknown = txtAttendenceMarkUnknown.Text
        AppSettings.AttendenceReportMarkExcused = txtAttendenceMarkExcused.Text
        AppSettings.ShowHiddenStudents = chkShowHiddenStudents.Checked
        AppSettings.ExamClockDuration = nudExamClockDuration.Value
        AppSettings.ExamFailDefaultFeedback = txtExamFailDefaultFeedback.Text
        AppSettings.ExamPassWeakDefaultFeedback = txtExamPassWeakDefaultFeedback.Text
        AppSettings.ExamPassDefaultFeedback = txtExamPassDefaultFeedback.Text
        AppSettings.NoSubmitFeedback = txtNoSubmitFeedback.Text
        AppSettings.CDDrive = txtCDDrive.Text

        '-- Email
        AppSettings.PathToTrulyMailEXE = txtPathToTrulyMail.Text
        AppSettings.IncludeFeedbackWhenEmailing = chkIncludeFeedbackWhenEmailing.Checked
        AppSettings.EmailSendingAccount = nudEmailAccountToUse.Value
        AppSettings.EmailQuizResultsIncorrectComments = txtEmailQuizResultsIncorrectFeedback.Text
        AppSettings.EmailQuizTrailingText = txtEmailQuizTrailingText.Text

        '-- Attendance
        AppSettings.HighlightAttendanceNoPresentationQuality = chkHighlightAttendanceUnknownPresentationQuality.Checked
        AppSettings.HighlightAttendanceUnknownGender = chkHighlightAttendanceUnknownGender.Checked

        AppSettings.DataBackupsToRetain = nudDataBackupsToRetain.Value
        AppSettings.OutcomeExportMarkPass = txtOutcomeMarkPass.Text
        AppSettings.OutcomeExportMarkFail = txtOutcomeMarkFail.Text
        AppSettings.OutcomeExportMarkUnknown = txtOutcomeMarkUnknown.Text
        AppSettings.AssignmentNotSubmittedDefaultOutcomeComment = txtStudentDidNotSubmitDefaultOutcomeComment.Text
        AppSettings.LoggingThreshold = nudLoggingThreshold.Value
        AppSettings.RedoPassAllDefaultComment = txtRedoPassAllDefaultComment.Text
        AppSettings.LateSubmitDefaultComment = txtLateSubmitDefaultComment.Text
        AppSettings.MarkingPageSaveFolder = txtPathToFeedbackSaveFolder.Text
        AppSettings.AutoSaveSeconds = nudAutoSave.Value * 60
        AppSettings.AutoSaveEnabled = chkAutoSaveEnabled.Checked
        AppSettings.DisableColorsInAssignmentDetail = chkDisableColorsAssignmentDetail.Checked
        AppSettings.AssignmentMarkingWarning1 = nudMarkingWarning1.Value
        AppSettings.AssignmentMarkingWarning2 = nudMarkingWarning2.Value
        AppSettings.PassResultsText = txtPassResultsText.Text
        AppSettings.FailResultsText = txtFailResultsText.Text
        AppSettings.UnknownResultsText = txtUnknownResultsText.Text

        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtAttendenceMarkPresent.Text = AppSettings.AttendenceReportMarkPresent
        txtAttendenceMarkLate.Text = AppSettings.AttendenceReportMarkLate
        txtAttendenceMarkAbsent.Text = AppSettings.AttendenceReportMarkAbsent
        txtAttendenceMarkRemoved.Text = AppSettings.AttendenceReportMarkRemoved
        txtAttendenceMarkUnknown.Text = AppSettings.AttendenceReportMarkUnknown
        txtAttendenceMarkExcused.Text = AppSettings.AttendenceReportMarkExcused

        nudExamClockDuration.Value = AppSettings.ExamClockDuration
        txtExamFailDefaultFeedback.Text = AppSettings.ExamFailDefaultFeedback
        txtExamPassWeakDefaultFeedback.Text = AppSettings.ExamPassWeakDefaultFeedback
        txtExamPassDefaultFeedback.Text = AppSettings.ExamPassDefaultFeedback
        chkShowHiddenStudents.Checked = AppSettings.ShowHiddenStudents
        txtNoSubmitFeedback.Text = AppSettings.NoSubmitFeedback
        txtCDDrive.Text = AppSettings.CDDrive
        nudDataBackupsToRetain.Value = AppSettings.DataBackupsToRetain

        '-- Email
        txtPathToTrulyMail.Text = AppSettings.PathToTrulyMailEXE
        chkIncludeFeedbackWhenEmailing.Checked = AppSettings.IncludeFeedbackWhenEmailing
        nudEmailAccountToUse.Value = AppSettings.EmailSendingAccount
        txtEmailQuizResultsIncorrectFeedback.Text = AppSettings.EmailQuizResultsIncorrectComments
        txtEmailQuizTrailingText.Text = AppSettings.EmailQuizTrailingText

        '-- Attendance
        chkHighlightAttendanceUnknownPresentationQuality.Checked = AppSettings.HighlightAttendanceNoPresentationQuality
        chkHighlightAttendanceUnknownGender.Checked = AppSettings.HighlightAttendanceUnknownGender


        txtPassResultsText.Text = AppSettings.PassResultsText
        txtFailResultsText.Text = AppSettings.FailResultsText
        txtUnknownResultsText.Text = AppSettings.UnknownResultsText

        txtOutcomeMarkPass.Text = AppSettings.OutcomeExportMarkPass
        txtOutcomeMarkFail.Text = AppSettings.OutcomeExportMarkFail
        txtOutcomeMarkUnknown.Text = AppSettings.OutcomeExportMarkUnknown

        txtStudentDidNotSubmitDefaultOutcomeComment.Text = AppSettings.AssignmentNotSubmittedDefaultOutcomeComment

        txtAutoText.Text = String.Empty
        

        txtRedoPassAllDefaultComment.Text = AppSettings.RedoPassAllDefaultComment
        txtLateSubmitDefaultComment.Text = AppSettings.LateSubmitDefaultComment
        txtPathToFeedbackSaveFolder.Text = AppSettings.MarkingPageSaveFolder

        nudLoggingThreshold.Value = AppSettings.LoggingThreshold
        nudAutoSave.Value = AppSettings.AutoSaveSeconds \ 60
        chkAutoSaveEnabled.Checked = AppSettings.AutoSaveEnabled
        chkDisableColorsAssignmentDetail.Checked = AppSettings.DisableColorsInAssignmentDetail

        nudMarkingWarning1.Value = AppSettings.AssignmentMarkingWarning1
        nudMarkingWarning2.Value = AppSettings.AssignmentMarkingWarning2


        ReloadImprovementText()
        AutoSizeColumns(olvImprovementText)
    End Sub
    Private Sub ReloadImprovementText()
        olvImprovementText.ClearObjects()
        olvImprovementText.SetObjects(AppSettings.ImprovementAutoTextList)
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub llblBrowseForTrulyMail_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblBrowseForTrulyMail.LinkClicked
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "TrulyMail.exe|TrulyMail.exe"
        ofd.Title = "Select TrulyMail.exe main file"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPathToTrulyMail.Text = ofd.FileName
        End If
    End Sub

    Private Sub llblBrowseForFeedbackSaveFolder_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblBrowseForFeedbackSaveFolder.LinkClicked
        Dim fbd As New FolderBrowserDialog()
        fbd.Description = "Select folder for marking pages"
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPathToFeedbackSaveFolder.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub llblRemoveAutoText_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveAutoText.LinkClicked
        If olvImprovementText.SelectedObject Is Nothing Then
            MessageBox.Show("Please select an improvement text to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Are you sure you want to remove this improvement text?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                AppSettings.ImprovementAutoTextList.Remove(olvImprovementText.SelectedObject)
                ReloadImprovementText()
            End If
        End If
    End Sub

    Private Sub llblMoveAutoTextBack_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblMoveAutoTextBack.LinkClicked
        If olvImprovementText.SelectedObject Is Nothing Then
            MessageBox.Show("Please select an improvement text to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txtAutoText.Text = CType(olvImprovementText.SelectedObject, AutoTextSimple).Text
        End If
    End Sub

    Private Sub llblAddAutoText_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddAutoText.LinkClicked
        Dim obj As New AutoTextSimple
        obj.Text = txtAutoText.Text
        AppSettings.ImprovementAutoTextList.Add(obj)
        txtAutoText.Text = String.Empty
        ReloadImprovementText()
    End Sub

    Private Sub llblAutoTextUp_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAutoTextUp.LinkClicked
        Dim objMovingAutoText As AutoTextSimple = CType(olvImprovementText.SelectedObject, AutoTextSimple)
        If objMovingAutoText IsNot Nothing Then
            Dim intPosition As Integer = AppSettings.ImprovementAutoTextList.IndexOf(objMovingAutoText)
            If intPosition = 0 Then
                Exit Sub '-- do nothing
            Else
                '-- Move up one in the list
                AppSettings.ImprovementAutoTextList.Remove(objMovingAutoText)
                AppSettings.ImprovementAutoTextList.Insert(intPosition - 1, objMovingAutoText)
                ReloadImprovementText()

                olvImprovementText.SelectedObject = objMovingAutoText
            End If
        End If
    End Sub

    Private Sub llblAutoTextDown_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAutoTextDown.LinkClicked
        Dim objMovingAutoText As AutoTextSimple = CType(olvImprovementText.SelectedObject, AutoTextSimple)
        If objMovingAutoText IsNot Nothing Then
            Dim intPosition As Integer = AppSettings.ImprovementAutoTextList.IndexOf(objMovingAutoText)
            If intPosition = AppSettings.ImprovementAutoTextList.Count - 1 Then
                Exit Sub '-- do nothing
            Else
                '-- Move up one in the list
                AppSettings.ImprovementAutoTextList.Remove(objMovingAutoText)
                AppSettings.ImprovementAutoTextList.Insert(intPosition + 1, objMovingAutoText)
                ReloadImprovementText()

                olvImprovementText.SelectedObject = objMovingAutoText
            End If
        End If
    End Sub


End Class
