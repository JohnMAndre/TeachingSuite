Imports System.IO

Public Class OptionsForm

    Private Sub SetupForLiteVersion()
        Try
            pnlMarking.Visible = False
            pnlEmail.Visible = False

            grpExport.Visible = False
            txtCDDrive.Visible = False
            lblCDDrive.Visible = False
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub


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

        '-- Data
        AppSettings.CDDrive = txtCDDrive.Text
        AppSettings.AutoSaveSeconds = nudAutoSave.Value * 60
        AppSettings.AutoSaveEnabled = chkAutoSaveEnabled.Checked
        If cboDictionary.SelectedIndex >= 0 Then
            AppSettings.DictionaryName = cboDictionary.Items(cboDictionary.SelectedIndex)
        End If

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
        AppSettings.DisableColorsInAssignmentDetail = chkDisableColorsAssignmentDetail.Checked
        AppSettings.AssignmentMarkingWarning1 = nudMarkingWarning1.Value
        AppSettings.AssignmentMarkingWarning2 = nudMarkingWarning2.Value
        AppSettings.PassResultsText = txtPassResultsText.Text
        AppSettings.FailResultsText = txtFailResultsText.Text
        AppSettings.UnknownResultsText = txtUnknownResultsText.Text

        Me.DialogResult = Windows.Forms.DialogResult.OK

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

        '-- Data
        txtCDDrive.Text = AppSettings.CDDrive
        nudDataBackupsToRetain.Value = AppSettings.DataBackupsToRetain
        Dim dictionaries() As String = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath), "*.dct")
        Dim intCounter As Integer = -1
        Dim intDictionaryIndex As Integer
        For Each strFilename In dictionaries
            intCounter += 1
            If Path.GetFileName(strFilename).ToLower() = Path.GetFileName(AppSettings.DictionaryName).ToLower() Then
                intDictionaryIndex = intCounter
            End If
            cboDictionary.Items.Add(Path.GetFileName(strFilename))
        Next
        If cboDictionary.Items.Count > 0 AndAlso intDictionaryIndex >= 0 Then
            cboDictionary.SelectedIndex = intDictionaryIndex
        End If

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

        SetupForLiteVersion()

    End Sub
    Private Sub ReloadImprovementText()
        olvImprovementText.ClearObjects()
        olvImprovementText.SetObjects(AppSettings.ImprovementAutoTextList)
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
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


    Private Sub llblDictionaryInfo_LinkClicked(sender As Object, e As EventArgs) Handles llblDictionaryInfo.LinkClicked
        MessageBox.Show("If you would like more dictionaries, just email John@JohnMAndre.com.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
