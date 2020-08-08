'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Foobar Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Foobar.  If Not, see < https: //www.gnu.org/licenses/>.

Public Class ApplicationSettings




    Public Sub New()
        '-- Load settings from Data folder
        Try
            If System.IO.File.Exists(GetSettingsFilename()) Then
                Dim xDoc As New Xml.XmlDocument()
                xDoc.Load(GetSettingsFilename())
                Dim xElement As Xml.XmlElement = xDoc.SelectSingleNode("//LastSemester")
                If xElement IsNot Nothing Then
                    LastSemesterFile = xElement.InnerText
                Else
                    LastSemesterFile = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//AttendenceReportMarkPresent")
                If xElement IsNot Nothing Then
                    AttendenceReportMarkPresent = xElement.InnerText
                Else
                    AttendenceReportMarkPresent = String.Empty
                End If
                xElement = xDoc.SelectSingleNode("//AttendenceReportMarkLate")
                If xElement IsNot Nothing Then
                    AttendenceReportMarkLate = xElement.InnerText
                Else
                    AttendenceReportMarkLate = String.Empty
                End If
                xElement = xDoc.SelectSingleNode("//AttendenceReportMarkAbsent")
                If xElement IsNot Nothing Then
                    AttendenceReportMarkAbsent = xElement.InnerText
                Else
                    AttendenceReportMarkAbsent = String.Empty
                End If
                xElement = xDoc.SelectSingleNode("//AttendenceReportMarkRemoved")
                If xElement IsNot Nothing Then
                    AttendenceReportMarkRemoved = xElement.InnerText
                Else
                    AttendenceReportMarkRemoved = String.Empty
                End If
                xElement = xDoc.SelectSingleNode("//AttendenceReportMarkUnknown")
                If xElement IsNot Nothing Then
                    AttendenceReportMarkUnknown = xElement.InnerText
                Else
                    AttendenceReportMarkUnknown = String.Empty
                End If
                xElement = xDoc.SelectSingleNode("//AttendenceReportMarkExcused")
                If xElement IsNot Nothing Then
                    AttendenceReportMarkExcused = xElement.InnerText
                Else
                    AttendenceReportMarkExcused = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//ShowHiddenStudents")
                If xElement IsNot Nothing Then
                    ShowHiddenStudents = ConvertToBool(xElement.InnerText, True)
                Else
                    ShowHiddenStudents = True
                End If

                xElement = xDoc.SelectSingleNode("//ExamClockDuration")
                If xElement IsNot Nothing Then
                    ExamClockDuration = ConvertToInt32(xElement.InnerText, 120)
                Else
                    ExamClockDuration = 120
                End If

                xElement = xDoc.SelectSingleNode("//ExamFailDefaultFeedback")
                If xElement IsNot Nothing Then
                    ExamFailDefaultFeedback = xElement.InnerText
                Else
                    ExamFailDefaultFeedback = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//ExamPassWeakDefaultFeedback")
                If xElement IsNot Nothing Then
                    ExamPassWeakDefaultFeedback = xElement.InnerText
                Else
                    ExamPassWeakDefaultFeedback = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//ExamPassDefaultFeedback")
                If xElement IsNot Nothing Then
                    ExamPassDefaultFeedback = xElement.InnerText
                Else
                    ExamPassDefaultFeedback = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//NoSubmitFeedback")
                If xElement IsNot Nothing Then
                    NoSubmitFeedback = xElement.InnerText
                Else
                    NoSubmitFeedback = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//CDDrive")
                If xElement IsNot Nothing Then
                    CDDrive = xElement.InnerText
                Else
                    CDDrive = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//EmailSendingAccount")
                If xElement IsNot Nothing Then
                    EmailSendingAccount = ConvertToInt32(xElement.InnerText, 0)
                Else
                    EmailSendingAccount = 0
                End If

                xElement = xDoc.SelectSingleNode("//PathToTrulyMailEXE")
                If xElement IsNot Nothing Then
                    PathToTrulyMailEXE = xElement.InnerText
                Else
                    PathToTrulyMailEXE = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//DataBackupsToRetain ")
                If xElement IsNot Nothing Then
                    DataBackupsToRetain = ConvertToInt32(xElement.InnerText, 20)
                Else
                    DataBackupsToRetain = 20
                End If

                xElement = xDoc.SelectSingleNode("//IncludeFeedbackWhenEmailing ")
                If xElement IsNot Nothing Then
                    IncludeFeedbackWhenEmailing = ConvertToBool(xElement.InnerText, False)
                Else
                    IncludeFeedbackWhenEmailing = False
                End If

                xElement = xDoc.SelectSingleNode("//EmailTrailingText")
                If xElement IsNot Nothing Then
                    EmailTrailingText = xElement.InnerText
                Else
                    EmailTrailingText = String.Empty
                End If


                xElement = xDoc.SelectSingleNode("//OutcomeExportMarkPass")
                If xElement IsNot Nothing Then
                    OutcomeExportMarkPass = xElement.InnerText
                Else
                    OutcomeExportMarkPass = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//OutcomeExportMarkFail")
                If xElement IsNot Nothing Then
                    OutcomeExportMarkFail = xElement.InnerText
                Else
                    OutcomeExportMarkFail = String.Empty
                End If
                xElement = xDoc.SelectSingleNode("//OutcomeExportMarkUnknown")
                If xElement IsNot Nothing Then
                    OutcomeExportMarkUnknown = xElement.InnerText
                Else
                    OutcomeExportMarkUnknown = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//AssignmentNotSubmittedDefaultOutcomeComment")
                If xElement IsNot Nothing Then
                    AssignmentNotSubmittedDefaultOutcomeComment = xElement.InnerText
                Else
                    AssignmentNotSubmittedDefaultOutcomeComment = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//LoggingThreshold")
                If xElement IsNot Nothing Then
                    LoggingThreshold = ConvertToInt32(xElement.InnerText, 5)
                Else
                    LoggingThreshold = 5 '-- default
                End If

                xElement = xDoc.SelectSingleNode("//FeedbackTextPreviouslyPassed")
                If xElement IsNot Nothing Then
                    FeedbackTextPreviouslyPassed = xElement.InnerText
                Else
                    FeedbackTextPreviouslyPassed = "Passed previously"
                End If

                xElement = xDoc.SelectSingleNode("//RedoPassAllDefaultComment")
                If xElement IsNot Nothing Then
                    RedoPassAllDefaultComment = xElement.InnerText
                Else
                    RedoPassAllDefaultComment = String.Empty
                End If
                xElement = xDoc.SelectSingleNode("//LateSubmitDefaultComment")
                If xElement IsNot Nothing Then
                    LateSubmitDefaultComment = xElement.InnerText
                Else
                    LateSubmitDefaultComment = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//MarkingPageSaveFolder")
                If xElement IsNot Nothing Then
                    MarkingPageSaveFolder = xElement.InnerText
                Else
                    MarkingPageSaveFolder = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//AutoSaveSeconds")
                If xElement IsNot Nothing Then
                    AutoSaveSeconds = ConvertToInt32(xElement.InnerText, 600)
                Else
                    AutoSaveSeconds = 600
                End If

                xElement = xDoc.SelectSingleNode("//AutoSaveEnabled")
                If xElement IsNot Nothing Then
                    AutoSaveEnabled = ConvertToBool(xElement.InnerText, True)
                Else
                    AutoSaveEnabled = True
                End If

                xElement = xDoc.SelectSingleNode("//AttendanceWindowMaximized")
                If xElement IsNot Nothing Then
                    AttendanceWindowMaximized = ConvertToBool(xElement.InnerText, False)
                Else
                    AttendanceWindowMaximized = False
                End If

                xElement = xDoc.SelectSingleNode("//OpenAssignmentDetailMaximized")
                If xElement IsNot Nothing Then
                    OpenAssignmentDetailMaximized = ConvertToBool(xElement.InnerText, False)
                Else
                    OpenAssignmentDetailMaximized = False
                End If

                xElement = xDoc.SelectSingleNode("//DisableColorsInAssignmentDetail")
                If xElement IsNot Nothing Then
                    DisableColorsInAssignmentDetail = ConvertToBool(xElement.InnerText, False)
                Else
                    DisableColorsInAssignmentDetail = False
                End If

                xElement = xDoc.SelectSingleNode("//AssignmentMarkingWarning1")
                If xElement IsNot Nothing Then
                    AssignmentMarkingWarning1 = ConvertToInt32(xElement.InnerText, 15)
                Else
                    AssignmentMarkingWarning1 = 15
                End If

                xElement = xDoc.SelectSingleNode("//AssignmentMarkingWarning2")
                If xElement IsNot Nothing Then
                    AssignmentMarkingWarning2 = ConvertToInt32(xElement.InnerText, 20)
                Else
                    AssignmentMarkingWarning2 = 20
                End If

                xElement = xDoc.SelectSingleNode("//MainFormStudentListViewState")
                If xElement IsNot Nothing Then
                    _mainFormStudentListViewStatePrivate = xElement.InnerText
                Else
                    _mainFormStudentListViewStatePrivate = String.Empty
                End If

                'xElement = xDoc.SelectSingleNode("//MainFormStudentListViewStateAlt")
                'If xElement IsNot Nothing Then
                '    '-- Does not matter the details of the element, if it is there then 
                '    '   we consider premium enabled
                '    PremiumFeaturesEnabled = True
                'Else
                '    PremiumFeaturesEnabled = False
                'End If

                '-- 3 April 2016: Changed to make it completely free for everyone
                PremiumFeaturesEnabled = True


                xElement = xDoc.SelectSingleNode("//AttendanceFormStudentListViewState")
                If xElement IsNot Nothing Then
                    _attendanceFormStudentListViewStatePrivate = xElement.InnerText
                Else
                    _attendanceFormStudentListViewStatePrivate = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//AttendancePublicFormStudentListViewState")
                If xElement IsNot Nothing Then
                    _attendancePublicFormStudentListViewStatePrivate = xElement.InnerText
                Else
                    _attendancePublicFormStudentListViewStatePrivate = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//PassResultsText")
                If xElement IsNot Nothing Then
                    PassResultsText = xElement.InnerText
                Else
                    PassResultsText = "Already"
                End If
                xElement = xDoc.SelectSingleNode("//FailResultsText")
                If xElement IsNot Nothing Then
                    FailResultsText = xElement.InnerText
                Else
                    FailResultsText = "Not yet"
                End If
                xElement = xDoc.SelectSingleNode("//UnknownResultsText ")
                If xElement IsNot Nothing Then
                    UnknownResultsText = xElement.InnerText
                Else
                    UnknownResultsText = "Did not submit"
                End If

                xElement = xDoc.SelectSingleNode("//HighlightAttendanceBirthday")
                If xElement IsNot Nothing Then
                    HighlightAttendanceBirthday = ConvertToBool(xElement.InnerText, False)
                Else
                    HighlightAttendanceBirthday = False
                End If

                xElement = xDoc.SelectSingleNode("//HighlightAttendanceNoPresentationQuality")
                If xElement IsNot Nothing Then
                    HighlightAttendanceNoPresentationQuality = ConvertToBool(xElement.InnerText, False)
                Else
                    HighlightAttendanceNoPresentationQuality = False
                End If

                xElement = xDoc.SelectSingleNode("//HighlightAttendanceUnknownGender")
                If xElement IsNot Nothing Then
                    HighlightAttendanceUnknownGender = ConvertToBool(xElement.InnerText, False)
                Else
                    HighlightAttendanceUnknownGender = False
                End If

                xElement = xDoc.SelectSingleNode("//EmailQuizResultsIncorrectComments")
                If xElement IsNot Nothing Then
                    EmailQuizResultsIncorrectComments = xElement.InnerText
                Else
                    EmailQuizResultsIncorrectComments = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//EmailQuizTrailingText")
                If xElement IsNot Nothing Then
                    EmailQuizTrailingText = xElement.InnerText
                Else
                    EmailQuizTrailingText = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//StudentAssignmentNormalWindowHeight")
                If xElement IsNot Nothing Then
                    StudentAssignmentNormalWindowHeight = ConvertToInt32(xElement.InnerText, 400)
                Else
                    StudentAssignmentNormalWindowHeight = 400
                End If

                xElement = xDoc.SelectSingleNode("//StudentAssignmentNormalWindowWidth")
                If xElement IsNot Nothing Then
                    StudentAssignmentNormalWindowWidth = ConvertToInt32(xElement.InnerText, 400)
                Else
                    StudentAssignmentNormalWindowWidth = 400
                End If

                xElement = xDoc.SelectSingleNode("//StudentAssignmentNormalWindowX")
                If xElement IsNot Nothing Then
                    StudentAssignmentNormalWindowX = ConvertToInt32(xElement.InnerText, 50)
                Else
                    StudentAssignmentNormalWindowX = 50
                End If

                xElement = xDoc.SelectSingleNode("//StudentAssignmentNormalWindowY")
                If xElement IsNot Nothing Then
                    StudentAssignmentNormalWindowY = ConvertToInt32(xElement.InnerText, 50)
                Else
                    StudentAssignmentNormalWindowY = 50
                End If

                xElement = xDoc.SelectSingleNode("//Notes")
                If xElement IsNot Nothing Then
                    Notes = xElement.InnerText
                Else
                    Notes = String.Empty
                End If

                xElement = xDoc.SelectSingleNode("//DictionaryName")
                If xElement IsNot Nothing Then
                    DictionaryName = xElement.InnerText
                Else
                    DictionaryName = "English (US).dct"
                End If

                xElement = xDoc.SelectSingleNode("//ImprovementFeedbackForDistinction")
                If xElement IsNot Nothing Then
                    ImprovementFeedbackForDistinction = xElement.InnerText
                Else
                    ImprovementFeedbackForDistinction = "Keep up the good work!"
                End If

                xElement = xDoc.SelectSingleNode("//ImprovementFeedbackForMerit")
                If xElement IsNot Nothing Then
                    ImprovementFeedbackForMerit = xElement.InnerText
                Else
                    ImprovementFeedbackForMerit = "To achieve DISTINCTION, student must increase the quality to meet distinction requirements."
                End If

                xElement = xDoc.SelectSingleNode("//ImprovementFeedbackForPassAll")
                If xElement IsNot Nothing Then
                    ImprovementFeedbackForPassAll = xElement.InnerText
                Else
                    ImprovementFeedbackForPassAll = "To achieve MERIT, student must increase the quality to meet merit requirements."
                End If

                xElement = xDoc.SelectSingleNode("//ImprovementFeedbackForFailSome")
                If xElement IsNot Nothing Then
                    ImprovementFeedbackForFailSome = xElement.InnerText
                Else
                    ImprovementFeedbackForFailSome = "To achieve PASS, student must show clear understanding of all pass outcomes."
                End If

                xElement = xDoc.SelectSingleNode("//ImprovementFeedbackForFailAll")
                If xElement IsNot Nothing Then
                    ImprovementFeedbackForFailAll = xElement.InnerText
                Else
                    ImprovementFeedbackForFailAll = "Student should arrange a time to meet their teacher for assistance."
                End If

                xElement = xDoc.SelectSingleNode("//PromptWhenMarkingAssignmentProcessedWithoutOverallAndImprovements")
                If xElement IsNot Nothing Then
                    PromptWhenMarkingAssignmentProcessedWithoutOverallAndImprovements = ConvertToBool(xElement.InnerText, True)
                Else
                    PromptWhenMarkingAssignmentProcessedWithoutOverallAndImprovements = True
                End If

                xElement = xDoc.SelectSingleNode("//ApplicationHistoryMaxFileSize")
                If xElement IsNot Nothing Then
                    ApplicationHistoryMaxFileSize = ConvertToInt32(xElement.InnerText, 12000)
                Else
                    ApplicationHistoryMaxFileSize = 12000
                End If


                xElement = xDoc.SelectSingleNode("//EnableStudentDataHistory")
                If xElement IsNot Nothing Then
                    EnableStudentDataHistory = ConvertToBool(xElement.InnerText, True)
                Else
                    EnableStudentDataHistory = True
                End If

                xElement = xDoc.SelectSingleNode("//EmailAsHTML")
                If xElement IsNot Nothing Then
                    EmailAsHTML = ConvertToBool(xElement.InnerText, True)
                Else
                    EmailAsHTML = True
                End If

                xElement = xDoc.SelectSingleNode("//LoadSemesterCacheOnStartup")
                If xElement IsNot Nothing Then
                    LoadSemesterCacheOnStartup = ConvertToBool(xElement.InnerText, False)
                Else
                    LoadSemesterCacheOnStartup = False
                End If

                xElement = xDoc.SelectSingleNode("//PresentationContentWeight")
                If xElement IsNot Nothing Then
                    PresentationContentWeight = ConvertToInt32(xElement.InnerText, 34)
                Else
                    PresentationContentWeight = 34
                End If

                xElement = xDoc.SelectSingleNode("//PresentationPresentationWeight")
                If xElement IsNot Nothing Then
                    PresentationPresentationWeight = ConvertToInt32(xElement.InnerText, 33)
                Else
                    PresentationPresentationWeight = 33
                End If

                xElement = xDoc.SelectSingleNode("//PresentationLanguageWeight")
                If xElement IsNot Nothing Then
                    PresentationLanguageWeight = ConvertToInt32(xElement.InnerText, 33)
                Else
                    PresentationLanguageWeight = 33
                End If

                xElement = xDoc.SelectSingleNode("//GroupPresentationUpdatesPresentationAndResearchPerformanceLevel")
                If xElement IsNot Nothing Then
                    GroupPresentationUpdatesPresentationAndResearchPerformanceLevel = ConvertToBool(xElement.InnerText, False)
                Else
                    GroupPresentationUpdatesPresentationAndResearchPerformanceLevel = True
                End If

                xElement = xDoc.SelectSingleNode("//UserFullName")
                If xElement IsNot Nothing Then
                    UserFullName = xElement.InnerText
                Else
                    UserFullName = String.Empty '-- not set
                End If

                LoadAutoTexts(xDoc)
            Else
                '-- Load up default values
                LastSemesterFile = String.Empty
                AttendenceReportMarkPresent = "P"
                AttendenceReportMarkLate = "L"
                AttendenceReportMarkAbsent = "A"
                AttendenceReportMarkRemoved = "R"
                AttendenceReportMarkUnknown = "U"
                AttendenceReportMarkExcused = "E"
                ShowHiddenStudents = True
                ExamClockDuration = 120
                ExamFailDefaultFeedback = "Student failed to show proper understanding in oral exam."
                ExamPassWeakDefaultFeedback = "Student showed weak understanding in oral exam."
                ExamPassDefaultFeedback = "Student showed proper understanding in oral exam."
                NoSubmitFeedback = "Not submitted"
                CDDrive = String.Empty
                EmailSendingAccount = 1
                PathToTrulyMailEXE = String.Empty
                DataBackupsToRetain = 20
                IncludeFeedbackWhenEmailing = False
                EmailTrailingText = String.Empty
                OutcomeExportMarkPass = "1"

                OutcomeExportMarkFail = 0
                OutcomeExportMarkUnknown = String.Empty
                AssignmentNotSubmittedDefaultOutcomeComment = "Not submitted"
                LoggingThreshold = 5 '-- default
                FeedbackTextPreviouslyPassed = "Passed previously"
                RedoPassAllDefaultComment = "Passed all remaining outcomes"
                LateSubmitDefaultComment = "Submitted late."
                MarkingPageSaveFolder = String.Empty
                AutoSaveSeconds = 300
                AttendanceWindowMaximized = False
                OpenAssignmentDetailMaximized = False
                DisableColorsInAssignmentDetail = False
                AssignmentMarkingWarning1 = 15
                AssignmentMarkingWarning2 = 20
                _mainFormStudentListViewStatePrivate = String.Empty
                PremiumFeaturesEnabled = True
                PassResultsText = "Already"
                FailResultsText = "Not yet"
                UnknownResultsText = "Did not submit"
                HighlightAttendanceNoPresentationQuality = False
                HighlightAttendanceUnknownGender = False
                EmailQuizResultsIncorrectComments = "If you do not know why your answer is wrong, please ask me in class."
                EmailQuizTrailingText = "If you have any questions, you can always ask in class (or email me)."
                StudentAssignmentNormalWindowHeight = 400
                StudentAssignmentNormalWindowWidth = 400
                StudentAssignmentNormalWindowX = 50
                StudentAssignmentNormalWindowY = 50
                Notes = "You can store notes here."
                DictionaryName = "English (US).dct"

                PresentationContentWeight = 34
                PresentationPresentationWeight = 33
                PresentationLanguageWeight = 33
                GroupPresentationUpdatesPresentationAndResearchPerformanceLevel = True

                LoadAutoTextDefaults()
            End If

            SetLastUpdaterCheck()

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading your settings. Please delete your settings.xml file in your Data folder.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub Save()
        '-- Save back to Data folder
        Try
            Dim xDoc As New Xml.XmlDocument()
            xDoc.AppendChild(xDoc.CreateElement("settings"))
            Dim xElement As Xml.XmlElement
            xElement = xDoc.CreateElement("LastSemester")
            xElement.InnerText = LastSemesterFile
            xDoc.DocumentElement.AppendChild(xElement)

            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendenceReportMarkPresent", AttendenceReportMarkPresent))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendenceReportMarkLate", AttendenceReportMarkLate))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendenceReportMarkAbsent", AttendenceReportMarkAbsent))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendenceReportMarkRemoved", AttendenceReportMarkRemoved))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendenceReportMarkUnknown", AttendenceReportMarkUnknown))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendenceReportMarkExcused", AttendenceReportMarkExcused))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ShowHiddenStudents", ShowHiddenStudents.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ExamClockDuration", ExamClockDuration.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ExamFailDefaultFeedback", ExamFailDefaultFeedback))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ExamPassWeakDefaultFeedback", ExamPassWeakDefaultFeedback))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ExamPassDefaultFeedback", ExamPassDefaultFeedback))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "NoSubmitFeedback", NoSubmitFeedback))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "CDDrive", CDDrive))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "EmailSendingAccount", EmailSendingAccount))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "PathToTrulyMailEXE", PathToTrulyMailEXE))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "DataBackupsToRetain", DataBackupsToRetain))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "IncludeFeedbackWhenEmailing", IncludeFeedbackWhenEmailing))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "EmailTrailingText", EmailTrailingText))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "OutcomeExportMarkPass", OutcomeExportMarkPass))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "OutcomeExportMarkFail", OutcomeExportMarkFail))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "OutcomeExportMarkUnknown", OutcomeExportMarkUnknown))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AssignmentNotSubmittedDefaultOutcomeComment", AssignmentNotSubmittedDefaultOutcomeComment))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "LoggingThreshold", LoggingThreshold))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "FeedbackTextPreviouslyPassed", FeedbackTextPreviouslyPassed))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "RedoPassAllDefaultComment", RedoPassAllDefaultComment))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "LateSubmitDefaultComment", LateSubmitDefaultComment))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "MarkingPageSaveFolder", MarkingPageSaveFolder))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AutoSaveEnabled", AutoSaveEnabled.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AutoSaveSeconds", AutoSaveSeconds.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendanceWindowMaximized", AttendanceWindowMaximized.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "OpenAssignmentDetailMaximized", OpenAssignmentDetailMaximized.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "DisableColorsInAssignmentDetail", DisableColorsInAssignmentDetail.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AssignmentMarkingWarning1", AssignmentMarkingWarning1.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AssignmentMarkingWarning2", AssignmentMarkingWarning2.ToString()))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "MainFormStudentListViewState", _mainFormStudentListViewStatePrivate))
            If PremiumFeaturesEnabled Then
                '-- If this node is present at all we consider premium features enabled
                xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "MainFormStudentListViewStateAlt", _mainFormStudentListViewStatePrivate))
            End If
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendanceFormStudentListViewState", _attendanceFormStudentListViewStatePrivate))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "AttendancePublicFormStudentListViewState", _attendancePublicFormStudentListViewStatePrivate))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "PassResultsText", PassResultsText))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "FailResultsText", FailResultsText))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "UnknownResultsText", UnknownResultsText))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "HighlightAttendanceNoPresentationQuality", HighlightAttendanceNoPresentationQuality))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "HighlightAttendanceBirthday", HighlightAttendanceBirthday))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "HighlightAttendanceUnknownGender", HighlightAttendanceUnknownGender))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "EmailQuizResultsIncorrectComments", EmailQuizResultsIncorrectComments))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "EmailQuizTrailingText", EmailQuizTrailingText))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "StudentAssignmentNormalWindowHeight", StudentAssignmentNormalWindowHeight))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "StudentAssignmentNormalWindowWidth", StudentAssignmentNormalWindowWidth))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "StudentAssignmentNormalWindowX", StudentAssignmentNormalWindowX))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "StudentAssignmentNormalWindowY", StudentAssignmentNormalWindowY))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "Notes", Notes))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "DictionaryName", DictionaryName))

            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ImprovementFeedbackForDistinction", ImprovementFeedbackForDistinction))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ImprovementFeedbackForMerit", ImprovementFeedbackForMerit))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ImprovementFeedbackForPassAll", ImprovementFeedbackForPassAll))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ImprovementFeedbackForFailSome", ImprovementFeedbackForFailSome))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ImprovementFeedbackForFailAll", ImprovementFeedbackForFailAll))

            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "PromptWhenMarkingAssignmentProcessedWithoutOverallAndImprovements", PromptWhenMarkingAssignmentProcessedWithoutOverallAndImprovements))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "ApplicationHistoryMaxFileSize", ApplicationHistoryMaxFileSize))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "EnableStudentDataHistory", EnableStudentDataHistory))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "EmailAsHTML", EmailAsHTML))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "LoadSemesterCacheOnStartup", LoadSemesterCacheOnStartup))

            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "PresentationContentWeight", PresentationContentWeight))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "PresentationPresentationWeight", PresentationPresentationWeight))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "PresentationLanguageWeight", PresentationLanguageWeight))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "GroupPresentationUpdatesPresentationAndResearchPerformanceLevel", GroupPresentationUpdatesPresentationAndResearchPerformanceLevel))
            xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "UserFullName", UserFullName))


            xDoc.DocumentElement.AppendChild(GetAutoTextSettingsNode(xDoc))


            xDoc.Save(GetSettingsFilename())
        Catch ex As Exception
            Log(ex)
            Application.DoEvents()
        End Try
    End Sub
    Private Function GetSettingsNode(xDoc As Xml.XmlDocument, name As String, value As Object) As Xml.XmlElement
        Dim xElement As Xml.XmlElement
        xElement = xDoc.CreateElement(name)
        xElement.InnerText = value

        Select Case TypeName(value)
            Case "FormWindowState"
                xElement.InnerText = Convert.ToInt32(value) '-- otherwise we get the string
            Case "Date"
                xElement.InnerText = CType(value, Date).ToString(DATE_TIME_FORMAT_XML)
            Case Else
                xElement.InnerText = value.ToString
        End Select

        Return xElement
    End Function
    Private Function GetSettingsFilename() As String
        Const SETTINGS_FILENAME As String = "settings.xml"
        Return System.IO.Path.Combine(GetDataFolder(), SETTINGS_FILENAME)
    End Function
    Private Function GetUpdaterSettingsFilename() As String
        Const SETTINGS_FILENAME As String = "UpdaterSettings.xml"
        Return System.IO.Path.Combine(GetDataFolder(), SETTINGS_FILENAME)
    End Function
    Private Sub LoadAutoTexts(xDoc As Xml.XmlDocument)
        Dim xList As Xml.XmlNodeList = xDoc.SelectNodes("//AutoText")
        Dim item As New AutoTextSimple
        For Each xElement As Xml.XmlElement In xList
            item = New AutoTextSimple
            item.Text = xElement.InnerText

            ImprovementAutoTextList.Add(item)
        Next
    End Sub
    Private Sub LoadAutoTextDefaults()
        Dim item As New AutoTextSimple
        item = New AutoTextSimple
        item.Text = "Student must learn about academic argument."
        ImprovementAutoTextList.Add(item)

        item = New AutoTextSimple
        item.Text = "Student should not cite slides of teacher. Read the research and cite the original author."
        ImprovementAutoTextList.Add(item)

        item = New AutoTextSimple
        item.Text = "Student should always include a proper introduction and conclusion."
        ImprovementAutoTextList.Add(item)

    End Sub
    Private Function GetAutoTextSettingsNode(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Dim root As Xml.XmlElement = xDoc.CreateElement("AutoTexts")
        Dim xElement As Xml.XmlElement
        For Each item As AutoTextSimple In ImprovementAutoTextList
            xElement = xDoc.CreateElement("AutoText")
            xElement.InnerText = item.Text

            root.AppendChild(xElement)
        Next

        Return root
    End Function
    Private Sub SetLastUpdaterCheck()
        Try
            Dim xDoc As New Xml.XmlDocument()
            xDoc.Load(GetUpdaterSettingsFilename())
            Dim xElement As Xml.XmlElement = xDoc.SelectSingleNode("//DateLastChecked")
            If xElement IsNot Nothing Then
                m_dtLastUpdateCheck = ConvertToDateFromXML(xElement.InnerText, Date.Now)
            Else
                m_dtLastUpdateCheck = Date.Now.AddYears(-1)
            End If
        Catch ex As Exception
            Log(ex)
            m_dtLastUpdateCheck = Date.Now.AddYears(-1)
        End Try
    End Sub
#Region " Public Properties "
    Public Property UserFullName As String '-- name of person doing marking, to keep track at the assignment-level
    Public Property GroupPresentationUpdatesPresentationAndResearchPerformanceLevel As Boolean
    Public Property PresentationContentWeight As Integer
    Public Property PresentationPresentationWeight As Integer
    Public Property PresentationLanguageWeight As Integer
    Public Property LoadSemesterCacheOnStartup As Boolean
    Public Property EnableStudentDataHistory As Boolean
    Public Property ApplicationHistoryMaxFileSize As PerformanceCounterInstanceLifetime '-- size in bytes

    Private m_dtLastUpdateCheck As Date
    Public Property PromptWhenMarkingAssignmentProcessedWithoutOverallAndImprovements As Boolean
    Public ReadOnly Property LastUpdateCheck As Date
        Get
            Return m_dtLastUpdateCheck
        End Get
    End Property
    Public Property DictionaryName As String
    Public Property Notes As String
    Public Property StudentAssignmentNormalWindowHeight As Integer
    Public Property StudentAssignmentNormalWindowWidth As Integer
    Public Property StudentAssignmentNormalWindowX As Integer
    Public Property StudentAssignmentNormalWindowY As Integer

    Public Property EmailQuizTrailingText As String
    Public Property EmailQuizResultsIncorrectComments As String
    Public Property HighlightAttendanceUnknownGender As Boolean
    Public Property HighlightAttendanceNoPresentationQuality As Boolean
    Public Property HighlightAttendanceBirthday As Boolean
    Public Property PassResultsText As String
    Public Property FailResultsText As String
    Public Property UnknownResultsText As String
    Public Property ImprovementFeedbackForDistinction As String
    Public Property ImprovementFeedbackForMerit As String
    Public Property ImprovementFeedbackForPassAll As String
    Public Property ImprovementFeedbackForFailAll As String
    Public Property ImprovementFeedbackForFailSome As String
    Public Property PremiumFeaturesEnabled As Boolean
    Private Property _mainFormStudentListViewStatePrivate As String
    Public Property MainFormStudentListViewState() As Byte()
        Get
            Return Convert.FromBase64String(_mainFormStudentListViewStatePrivate)
        End Get
        Set(ByVal value As Byte())
            _mainFormStudentListViewStatePrivate = Convert.ToBase64String(value)
        End Set
    End Property
    Private Property _attendanceFormStudentListViewStatePrivate As String
    Public Property AttendanceFormStudentListViewState() As Byte()
        Get
            Return Convert.FromBase64String(_attendanceFormStudentListViewStatePrivate)
        End Get
        Set(ByVal value As Byte())
            _attendanceFormStudentListViewStatePrivate = Convert.ToBase64String(value)
        End Set
    End Property
    Private Property _attendancePublicFormStudentListViewStatePrivate As String
    Public Property AttendancePublicFormStudentListViewState() As Byte()
        Get
            Return Convert.FromBase64String(_attendancePublicFormStudentListViewStatePrivate)
        End Get
        Set(ByVal value As Byte())
            _attendancePublicFormStudentListViewStatePrivate = Convert.ToBase64String(value)
        End Set
    End Property
    Public Property EmailAsHTML As Boolean
    Public Property AssignmentMarkingWarning1 As Integer
    Public Property AssignmentMarkingWarning2 As Integer
    Public Property OpenAssignmentDetailMaximized As Boolean
    Public Property DisableColorsInAssignmentDetail As Boolean
    Public Property AttendanceWindowMaximized As Boolean
    Public Property AutoSaveEnabled As Boolean
    Public Property AutoSaveSeconds As Integer
    Public Property MarkingPageSaveFolder As String
    Public Property RedoPassAllDefaultComment As String
    Public Property LateSubmitDefaultComment As String
    Public Property ImprovementAutoTextList As New List(Of AutoTextSimple)
    Public Property FeedbackTextPreviouslyPassed As String
    Public Property OutcomeExportMarkPass As String
    Public Property OutcomeExportMarkFail As String
    Public Property OutcomeExportMarkUnknown As String
    Public Property LastStudentDetailTab As Integer
    Public Property EmailTrailingText As String
    Public Property IncludeFeedbackWhenEmailing As Boolean
    Public Property DataBackupsToRetain As Integer
    Public Property PathToTrulyMailEXE As String
    Public Property EmailSendingAccount As Integer
    Public Property CDDrive As String
    Public Property LastSemesterFile As String
    Public Property AttendenceReportMarkPresent As String
    Public Property AttendenceReportMarkLate As String
    Public Property AttendenceReportMarkAbsent As String
    Public Property AttendenceReportMarkRemoved As String
    Public Property AttendenceReportMarkUnknown As String
    Public Property AttendenceReportMarkExcused As String
    Public Property ShowHiddenStudents As Boolean
    Public Property ExamClockDuration As Integer '-- in seconds
    Public Property ExamFailDefaultFeedback As String
    Public Property ExamPassWeakDefaultFeedback As String
    Public Property ExamPassDefaultFeedback As String
    Public Property NoSubmitFeedback As String
    Public Property AssignmentNotSubmittedDefaultOutcomeComment As String
    Public Property LoggingThreshold As Integer
#End Region
End Class
