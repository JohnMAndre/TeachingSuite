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


Imports Microsoft.Office.Interop

Imports System.IO
Imports System.Text.RegularExpressions
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing

Friend Class StudentAssignmentDetails

    Private m_student As Student
    Private m_studentAssignment As StudentAssignmentBTEC
    Private m_studentModuleResults As Student.StudentModuleResult
    Private m_boolAssignmentCreated As Boolean
    Private m_try As Semester.MarkingTry
    Private m_dtTimerStart As Date = Date.Now
    Private m_boolTimerRunning As Boolean = True
    Private m_tsTimer As TimeSpan
    Private m_improvementItems As New List(Of StudentImprovementItem) '-- include those assigned to the student and those not
    Private m_strStudentTagsOriginal As String '-- to track if tags changed while form is open (we don't want to overwrite other changes)
    Private m_lstAutoFeedbackToRemove As New List(Of AutoFeedbackToRemove)

    Private Class AutoFeedbackToRemove
        Public Property BaseOutcome As AssignmentOutcome
        Public Property Text As String

    End Class
    Public Sub New(student As Student, assignment As StudentAssignmentBTEC, attempt As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_student = student
        m_studentAssignment = assignment
        m_try = attempt
    End Sub

    Public Sub New(student As Student, assignment As ClassAssignmentBTEC, attempt As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_student = student
        m_try = attempt '-- could be redo because didn't submit...so second try, first failed all

        '-- find student assignment
        For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
            If asmt.BaseAssignment Is assignment Then
                m_studentAssignment = asmt
                Exit For
            End If
        Next

        If m_studentAssignment Is Nothing Then
            '-- create assignment for student
            m_studentAssignment = m_student.AddAssignment(assignment)
            m_boolAssignmentCreated = True
        End If

        If m_try <> Semester.MarkingTry.FirstTry Then
            '-- mark first as fail, no submit
            For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
                If outcome.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                    outcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                    outcome.FirstTryComments = AppSettings.NoSubmitFeedback
                End If
            Next
        End If

        olvOutcomes.PrimarySortColumn = Me.OlvColumnOutcomeName
        olvOutcomes.PrimarySortOrder = SortOrder.Ascending

    End Sub

    Private Sub StudentAssignmentDetails_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AppSettings.OpenAssignmentDetailMaximized = (Me.WindowState = FormWindowState.Maximized)
    End Sub

    Private Sub StudentAssignmentDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.olvOutcomes.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf MainRowFormatter)
        Me.olvImprovementItems.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf ImprovementItemRowFormatter)
        olvcolPerformanceLevel.ToolTipText = "Performance level (0-5)" & Environment.NewLine & "0=Not evaluated" & Environment.NewLine & "1=Unacceptable" & Environment.NewLine & "2=Very weak, incorrect very often" & Environment.NewLine & "3=Sometimes OK but inconsistent" & Environment.NewLine & "4=Good but still room for improvement" & Environment.NewLine & "5=Completely correct"

        chkProcessed.Checked = m_studentAssignment.Processed

        '-- set the outcomes
        olvOutcomes.SetObjects(m_studentAssignment.Outcomes)

        rtbOverallComments.Text = m_studentAssignment.OverallComments
        rtbImprovementComments.Text = m_studentAssignment.ImprovementComments
        rtbOverallCommentsRework.Text = m_studentAssignment.OverallCommentsRework
        rtbImprovementCommentsRework.Text = m_studentAssignment.ImprovementCommentsRework
        rtbObservationComments.Text = m_studentAssignment.ObservationComments

        txtNickName.Text = m_student.Nickname
        txtStudentID.Text = m_student.StudentID
        nudPresentationQuality.Text = m_student.PresentationQuality
        nudWritingQuality.Value = m_student.WritingQuality
        nudResearchQuality.Value = m_student.ResearchQuality
        txtAssignmentName.Text = m_studentAssignment.BaseAssignment.Name
        nudAltNumber.Text = m_student.AltNumber
        txtSchoolClass.Text = m_student.SchoolClass.Name
        txtTeam.Text = m_student.StudentTeam
        txtGroup.Text = m_student.StudentGroup
        Me.Text &= " - " & m_student.LocalName
        txtTags.Text = m_student.Tags
        m_strStudentTagsOriginal = m_student.Tags

        Me.olvPassFailFeedback.ImageGetter = New BrightIdeasSoftware.ImageGetterDelegate(AddressOf PassFailImageGetter)
        Me.olvModuleResultsPassFail.ImageGetter = New BrightIdeasSoftware.ImageGetterDelegate(AddressOf PassFailTextImageGetter)

        nudPlagiarismSeverity.Value = m_student.PlagiarismSeverity

        'llblStudentPic.Visible = m_student.Photo IsNot Nothing

        AutoSizeColumns(olvAutoFeedback)

        LoadModuleResults()

        '-- Load improvement items
        '-- Load all the improvement items and include date added/removed for those that apply to this student
        '   But we need to filter only for assignment categories on this assessment
        Dim boolItemAdded, boolHasMatchingCategory As Boolean

        For Each item As ImprovementItem In ThisSemester.ImprovementItems
            boolHasMatchingCategory = False '-- default to false

            For Each catItem As Semester.AssessmentCategory In item.AssessmentCategories
                For Each catAssess As Semester.AssessmentCategory In m_studentAssignment.BaseAssignment.AssessmentCategories
                    If catItem = catAssess Then
                        boolHasMatchingCategory = True
                        Exit For
                    End If
                Next
                If boolHasMatchingCategory Then
                    Exit For
                End If
            Next

            '-- We only include matching improvement items. If no matching category, we completely ignore it on this assessment
            If boolHasMatchingCategory Then

                boolItemAdded = False
                For Each studItem As StudentImprovementItem In m_student.ImprovementItems
                    If studItem.BaseImprovementItem Is item Then
                        m_improvementItems.Add(studItem)
                        boolItemAdded = True
                        Exit For
                    End If
                Next
                If Not boolItemAdded Then
                    Dim studItem As New StudentImprovementItem(m_student)
                    studItem.BaseImprovementItem = item
                    studItem.DateAdded = DATE_NO_DATE
                    m_improvementItems.Add(studItem)
                End If
            End If
        Next
        olvImprovementItems.SetObjects(m_improvementItems)
        AutoSizeColumns(olvImprovementItems)

        '-- Load up the list of m_lstAutoFeedbackToRemove so we can remove on OK_Click to keep our counts in sync
        Dim objRemoveItem As AutoFeedbackToRemove
        For Each rslt As OutcomeResult In m_studentAssignment.Outcomes
            '-- Only add to the remove list if there is actually some comments
            If rslt.FirstTryComments.Trim().Length > 0 Then
                objRemoveItem = New AutoFeedbackToRemove()
                objRemoveItem.BaseOutcome = rslt.BaseOutcome
                objRemoveItem.Text = rslt.FirstTryComments
                m_lstAutoFeedbackToRemove.Add(objRemoveItem)
            End If

            If rslt.SecondTryComments.Trim().Length > 0 Then
                objRemoveItem = New AutoFeedbackToRemove()
                objRemoveItem.BaseOutcome = rslt.BaseOutcome
                objRemoveItem.Text = rslt.SecondTryComments
                m_lstAutoFeedbackToRemove.Add(objRemoveItem)
            End If

            If rslt.ThirdTryComments.Trim().Length > 0 Then
                objRemoveItem = New AutoFeedbackToRemove()
                objRemoveItem.BaseOutcome = rslt.BaseOutcome
                objRemoveItem.Text = rslt.ThirdTryComments
                m_lstAutoFeedbackToRemove.Add(objRemoveItem)
            End If
        Next

        '-- Load UserFullNames
        txtFirstUserFullName.Text = Me.m_studentAssignment.FirstUserFullName
        txtLastUserFullName.Text = Me.m_studentAssignment.LastUserFullName

        If AppSettings.OpenAssignmentDetailMaximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub


    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        '-- If we created it and canceled then we must remove it
        If m_boolAssignmentCreated Then
            m_student.AssignmentsBTEC.Remove(m_studentAssignment)
        End If

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub
    Private Function SaveChanges() As Boolean
        If AppSettings.PromptWhenMarkingAssignmentProcessedWithoutOverallAndImprovements AndAlso chkProcessed.Checked AndAlso (rtbOverallComments.Text.Trim.Length = 0 OrElse rtbImprovementComments.Text.Trim.Length = 0) Then
            If MessageBox.Show("Are you sure you want to mark this processed without complete Overall and Improvement notes?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then
                Return False
            End If
        End If

        Dim intPassedOutcomes As Integer = PassedOutcomes()

        If m_studentAssignment.FirstUserFullName.Trim.Length = 0 Then
            m_studentAssignment.FirstUserFullName = AppSettings.UserFullName
        End If
        m_studentAssignment.LastUserFullName = AppSettings.UserFullName

        m_studentAssignment.OverallComments = rtbOverallComments.Text
        m_studentAssignment.ImprovementComments = rtbImprovementComments.Text
        m_studentAssignment.OverallCommentsRework = rtbOverallCommentsRework.Text
        m_studentAssignment.ImprovementCommentsRework = rtbImprovementCommentsRework.Text
        m_studentAssignment.ObservationComments = rtbObservationComments.Text

        '-- Before we save the StoredResults, we must remove any existing StoredResults
        For Each objRemoveItem As AutoFeedbackToRemove In m_lstAutoFeedbackToRemove
            objRemoveItem.BaseOutcome.RemoveStoredResults(objRemoveItem.Text)
        Next


        '-- Now, save feedbacks to recent collection
        For Each outcom As OutcomeResult In m_studentAssignment.Outcomes
            '-- Before we only processed this m_try but now that we've added the AutoFeedbackToRemove we should process all
            '   which is better because any could be changed (m_try=Second but First gets changed too)
            outcom.BaseOutcome.AddStoredResults(outcom.FirstTryStatus, outcom.FirstTryComments)
            outcom.BaseOutcome.AddStoredResults(outcom.SecondTryStatus, outcom.SecondTryComments)
            outcom.BaseOutcome.AddStoredResults(outcom.ThirdTryStatus, outcom.ThirdTryComments)
        Next

        m_student.AltNumber = nudAltNumber.Value
        If m_student.PresentationQuality <> nudPresentationQuality.Value Then
            m_student.AddToActivityLog("Changed presentation quality from " & m_student.PresentationQuality.ToString() & " to " & nudPresentationQuality.Value.ToString() & " on " & m_studentAssignment.BaseAssignment.Name)
            m_student.PresentationQuality = nudPresentationQuality.Value
        End If
        If m_student.WritingQuality <> nudWritingQuality.Value Then
            m_student.AddToActivityLog("Changed writing quality from " & m_student.WritingQuality.ToString() & " to " & nudWritingQuality.Value.ToString() & " on " & m_studentAssignment.BaseAssignment.Name)
            m_student.WritingQuality = nudWritingQuality.Value
        End If

        If m_student.ResearchQuality <> nudResearchQuality.Value Then
            m_student.AddToActivityLog("Changed research quality from " & m_student.ResearchQuality.ToString() & " to " & nudResearchQuality.Value.ToString() & " on " & m_studentAssignment.BaseAssignment.Name)
            m_student.ResearchQuality = nudResearchQuality.Value
        End If


        m_studentAssignment.Processed = chkProcessed.Checked
        If m_student.PlagiarismSeverity <> nudPlagiarismSeverity.Value Then
            m_student.AddToActivityLog("Changed plagiarism severity from " & m_student.PlagiarismSeverity.ToString() & " to " & nudPlagiarismSeverity.Value.ToString() & " on " & m_studentAssignment.BaseAssignment.Name)
            m_student.PlagiarismSeverity = nudPlagiarismSeverity.Value
        End If

        '-- If the tags changed here but the not elsewhere
        '   then update tags from here. If they changed elsewhere, notify user
        If m_strStudentTagsOriginal <> txtTags.Text Then
            If m_strStudentTagsOriginal = m_student.Tags Then
                m_student.Tags = txtTags.Text
            Else
                MessageBox.Show("Tags changed on this form but also somewhere else. Unclear which tags should be used so tags on this form ignored.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        For Each item As StudentImprovementItem In olvImprovementItems.CheckedObjects
            item.IncludeToday()
        Next

        AddApplicationHistory("Finished marking student (" & m_student.ToString() & ") on assignment (" & m_studentAssignment.BaseAssignment.Name & ").")

        Return True
    End Function
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If SaveChanges() Then
            MainFormReference.AutoSave()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Close()
        End If
    End Sub
    Private Function PassedOutcomes() As Integer
        Dim intPassedOutcomes As Integer
        For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
            If m_try = Semester.MarkingTry.FirstTry AndAlso outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                intPassedOutcomes += 1
            ElseIf m_try = Semester.MarkingTry.SecondTry AndAlso (outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved) Then
                intPassedOutcomes += 1
            ElseIf m_try = Semester.MarkingTry.ThirdTry AndAlso (outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.ThirdTryStatus = OutcomeResultStatusEnum.Achieved) Then
                intPassedOutcomes += 1
                '== Remove this little block to support same outcome on multiple assignments
                '   so some can be unknown and it's still ok
                'ElseIf outcome.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                '    intPassedOutcomes = -1
                '    Exit For
            End If
        Next

        Return intPassedOutcomes
    End Function
    Private Function FailedOutcomes() As Integer
        Dim intFailedOutcomes As Integer
        For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
            If m_try = Semester.MarkingTry.FirstTry AndAlso outcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                intFailedOutcomes += 1
            ElseIf m_try = Semester.MarkingTry.SecondTry AndAlso outcome.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                intFailedOutcomes += 1
            ElseIf m_try = Semester.MarkingTry.ThirdTry AndAlso outcome.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                intFailedOutcomes += 1
                '== Remove this little block to support same outcome on multiple assignments
                '   so some can be unknown and it's still ok
                'ElseIf outcome.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                '    intPassedOutcomes = -1
                '    Exit For
            End If
        Next

        Return intFailedOutcomes
    End Function
    Private Function StudentPlagiarized() As Boolean
        For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
            Select Case m_try
                Case Semester.MarkingTry.FirstTry
                    If outcome.FirstTryComments.ToLower().Contains("plagiari") Then
                        Return True
                    End If
                Case Semester.MarkingTry.SecondTry
                    If outcome.SecondTryComments.ToLower().Contains("plagiari") Then
                        Return True
                    End If
                Case Semester.MarkingTry.ThirdTry
                    If outcome.ThirdTryComments.ToLower().Contains("plagiari") Then
                        Return True
                    End If
            End Select
        Next

        Return False
    End Function
    Private Sub btnGenerateOverallComments_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnGenerateOverallComments.LinkClicked
        ''   The new rules are:
        ''   "Achieved Pass" requires all outcomes with gradegroup of pass to be achieved, and number of outcomes @ pass > 0
        ''   "Achieved Merit" requires "Achieve Pass" and all outcomes with gradegroup of merit to be achieved, and number of outcomes @ merit > 0
        ''   "Achieved Distinction" requires "Achieve Pass" and "Achieve Merit" and all outcomes with gradegroup of distinction to be achieved, and number of outcomes @ distinction > 0
        'If AchievedAllAtGrade(BTECGradeGroup.Pass) Then
        '    If AchievedAllAtGrade(BTECGradeGroup.Merit) Then
        '        If AchievedAllAtGrade(BTECGradeGroup.Distinction) Then
        '            '- Distinction
        '            rtbOverallComments.Text = "Achieved all PASS and MERIT and DISTINCTION outcomes."
        '        Else
        '            '-- Just merit
        '            rtbOverallComments.Text = "Achieved all PASS and MERIT outcomes."
        '        End If
        '    Else
        '        '-- Just pass
        '        rtbOverallComments.Text = "Achieved all PASS outcomes"
        '    End If
        'Else
        '    '-- Not passed yet
        '    Dim intAvailable As Integer = OutcomesAtGrade(BTECGradeGroup.Pass)
        '    Dim intAchieved As Integer = AchievedOutcomesAtGrade(BTECGradeGroup.Pass)
        '    Dim intReferral As Integer = intAvailable - intAchieved
        '    rtbOverallComments.Text = "Achieved " & intAchieved.ToString() & " of " & intAvailable.ToString() & " PASS outcomes (referral outcomes: "
        '    rtbOverallComments.Text &= ListReferralOutcomes(BTECGradeGroup.Pass)
        '    rtbOverallComments.Text &= ")."
        'End If

        rtbOverallComments.Text = GenerateOverallComments(False)
    End Sub
    Private Function GenerateOverallComments(rework As Boolean) As String
        '   The new rules are:
        '   "Achieved Pass" requires all outcomes with gradegroup of pass to be achieved, and number of outcomes @ pass > 0
        '   "Achieved Merit" requires "Achieve Pass" and all outcomes with gradegroup of merit to be achieved, and number of outcomes @ merit > 0
        '   "Achieved Distinction" requires "Achieve Pass" and "Achieve Merit" and all outcomes with gradegroup of distinction to be achieved, and number of outcomes @ distinction > 0
        Dim strReturn As String

        If AchievedAllAtGrade(BTECGradeGroup.Pass) Then
            If AchievedAllAtGrade(BTECGradeGroup.Merit) Then
                If AchievedAllAtGrade(BTECGradeGroup.Distinction) Then
                    '- Distinction
                    strReturn = "Achieved all PASS and MERIT and DISTINCTION outcomes."
                Else
                    '-- Just merit
                    strReturn = "Achieved all PASS and MERIT outcomes."
                End If
            Else
                '-- Just pass
                strReturn = "Achieved all PASS outcomes"
            End If
        Else
            '-- Not passed yet
            Dim intAvailable As Integer = OutcomesAtGrade(BTECGradeGroup.Pass)
            Dim intAchieved As Integer = AchievedOutcomesAtGrade(BTECGradeGroup.Pass)
            Dim intReferral As Integer = intAvailable - intAchieved
            strReturn = "Achieved " & intAchieved.ToString() & " of " & intAvailable.ToString() & " PASS outcomes (referral outcomes: "
            strReturn &= ListReferralOutcomes(BTECGradeGroup.Pass)
            strReturn &= ")."
        End If

        Return strReturn
    End Function
    Private Function AchievedAllAtGrade(grade As BTECGradeGroup) As Boolean
        Dim intAvailable As Integer = OutcomesAtGrade(grade)
        Dim intAchieved As Integer = AchievedOutcomesAtGrade(grade)
        If intAvailable > 0 Then
            Return intAchieved = intAvailable
        Else
            Return False '-- No outcomes at this grade, so did not achieve anything
        End If
    End Function
    Private Function OutcomesAtGrade(grade As BTECGradeGroup) As Integer
        Dim intReturn As Integer
        For Each asmtOC As AssignmentOutcome In m_studentAssignment.BaseAssignment.Outcomes
            If asmtOC.GradeGroup = grade Then
                intReturn += 1
            End If
        Next

        Return intReturn
    End Function
    Private Function AchievedOutcomesAtGrade(grade As BTECGradeGroup) As Integer
        Dim intReturn As Integer
        Select Case m_try
            Case Semester.MarkingTry.FirstTry
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    '-- only first try counts
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                    End If
                Next
            Case Semester.MarkingTry.SecondTry
                '-- first or second try count
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                    End If
                Next
            Case Semester.MarkingTry.ThirdTry
                '-- First, second, or third try count
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                    End If
                Next
        End Select

        Return intReturn
    End Function
    Private Function ListReferralOutcomes(grade As BTECGradeGroup) As String
        Dim strReturn As String = String.Empty
        Select Case m_try
            Case Semester.MarkingTry.FirstTry
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    '-- only first try counts
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            strReturn &= ocResult.BaseOutcome.Name & "; "
                        End If
                    End If
                Next
            Case Semester.MarkingTry.SecondTry
                '-- first or second try count
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso _
                            ocResult.SecondTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            strReturn &= ocResult.BaseOutcome.Name & "; "
                        End If
                    End If
                Next
            Case Semester.MarkingTry.ThirdTry
                '-- First, second, or third try count
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso _
                            ocResult.SecondTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso _
                            ocResult.ThirdTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            strReturn &= ocResult.BaseOutcome.Name & "; "
                        End If
                    End If
                Next
        End Select

        Return strReturn.Substring(0, strReturn.Length - 2)
    End Function
    Private Function GetFailedOutcomes() As List(Of OutcomeResult)
        Dim rslts As Student.StudentModuleResult = m_student.ModuleResults(True)
        Dim lstReturn As New List(Of OutcomeResult)

        '-- check each outcome on this assignment, anything failed gets returned
        For Each ocAssignment As OutcomeResult In m_studentAssignment.Outcomes
            For Each ocRslt As Student.StudentModuleOutcomeResult In rslts.Outcomes
                If ocRslt.Outcome.Name = ocAssignment.BaseOutcome.Name Then
                    If ocRslt.Status <> OutcomeResultStatusEnum.Achieved Then
                        lstReturn.Add(ocAssignment)
                        Exit For
                    End If
                End If
            Next
        Next

        Return lstReturn
    End Function
    Private Function GetModuleResultForSingleOutcome(outcome As AssignmentOutcome) As OutcomeResultStatusEnum
        Dim boolOutcomeMatch As Boolean

        '-- only refresh if data was never populated (leave up to caller to keep it refreshed)
        If m_studentModuleResults Is Nothing Then
            m_studentModuleResults = m_student.ModuleResults(True)
        End If

        boolOutcomeMatch = False
        For Each outcom As Student.StudentModuleOutcomeResult In m_studentModuleResults.Outcomes
            If outcom.Outcome Is outcome Then
                '-- it is here
                boolOutcomeMatch = True
                Return outcom.Status
            End If
        Next

        '-- never found the outcome, so return unknown
        Return OutcomeResultStatusEnum.Unknown
    End Function
    Public Sub PrepareMarkingPageSimple()
        Try
            If Not SaveChanges() Then
                Exit Sub
            End If


            If m_studentAssignment.BaseAssignment.AssignmentBriefFilename.Trim.Length = 0 Then
                MessageBox.Show("There is no document related to this assignment. Please fix this problem and try again.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If rtbImprovementComments.Text.Trim.Length = 0 Then
                MessageBox.Show("You must fill out overall and improvement comments.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            '-- copy template over to new file, in case user accidentally saves it
            Dim strTemplateFilename As String = System.IO.Path.Combine(GetMarkingFolder(), m_studentAssignment.BaseAssignment.AssignmentBriefFilename)
            Dim strWorkingFilename As String = System.IO.Path.Combine(GetMarkingFolder(), "~temp1.docx")
            If System.IO.File.Exists(strWorkingFilename) Then
                System.IO.File.Delete(strWorkingFilename)
            End If

            System.IO.File.Copy(strTemplateFilename, strWorkingFilename, True)

            Const CHECKMARK As String = "V"
            Const XMARK As String = "X"
            Const BLANK As String = " "

            '-- refresh module results (may use many times)
            m_studentModuleResults = m_student.ModuleResults(True)

            Dim firstColumnMark As OutcomeResultStatusEnum '-- Pass=check; fail=X; unknown=blank
            Dim secondColumnMark As OutcomeResultStatusEnum

            Dim strDestination As String
            Dim replacementText As String
            Dim originalText As String
            Using docMarking As Xceed.Words.NET.DocX = Xceed.Words.NET.DocX.Load(strWorkingFilename)
                docMarking.ReplaceText("OOStudentIDOO", m_student.StudentID)
                docMarking.ReplaceText("OONickNameOO", m_student.Nickname)
                docMarking.ReplaceText("OOStudentNameOO", m_student.LocalName)
                docMarking.ReplaceText("OOExtStudentIDOO", m_student.ExtStudentID)
                docMarking.ReplaceText("OOAltNumberOO", m_student.AltNumber.ToString())
                docMarking.ReplaceText("OOOVERALLOO", rtbOverallComments.Text)
                docMarking.ReplaceText("OOIMPROVEMENTSOO", rtbImprovementComments.Text)
                docMarking.ReplaceText("OODATEOO", Date.Today.ToString("dd / MMM / yyyy"))

                strDestination = GetMarkingPageFilename()
                If System.IO.File.Exists(strDestination) Then
                    System.IO.File.Delete(strDestination)
                End If

                For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
                    '-- reset varliables
                    firstColumnMark = OutcomeResultStatusEnum.Unknown
                    secondColumnMark = OutcomeResultStatusEnum.Unknown

                    originalText = "OOOUTCOME" & outcome.BaseOutcome.Name & "COMMENTSOO"

                    '-- Feedback comments for each outcome
                    Select Case m_try
                        Case Semester.MarkingTry.FirstTry
                            Select Case outcome.FirstTryStatus
                                Case OutcomeResultStatusEnum.Achieved
                                    firstColumnMark = OutcomeResultStatusEnum.Achieved
                                    secondColumnMark = OutcomeResultStatusEnum.Unknown
                                    replacementText = outcome.FirstTryComments
                                Case OutcomeResultStatusEnum.NotAchieved
                                    firstColumnMark = OutcomeResultStatusEnum.NotAchieved
                                    secondColumnMark = OutcomeResultStatusEnum.Unknown
                                    replacementText = outcome.FirstTryComments
                                Case Else
                                    '-- Unknown
                                    firstColumnMark = OutcomeResultStatusEnum.NotAchieved
                                    secondColumnMark = OutcomeResultStatusEnum.Unknown
                                    replacementText = AppSettings.NoSubmitFeedback
                            End Select
                        Case Semester.MarkingTry.SecondTry
                            Select Case outcome.SecondTryStatus
                                Case OutcomeResultStatusEnum.Achieved
                                    '-- passing on rework does not mean fail before
                                    '   could mean passed before and now improving for higher mark
                                    '   Although in 2017 Peason forbids that behavior, we don't know the future
                                    replacementText = outcome.SecondTryComments
                                    secondColumnMark = OutcomeResultStatusEnum.Achieved
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        firstColumnMark = OutcomeResultStatusEnum.Achieved
                                    Else
                                        '-- Changing this for 2015 BTEC forms so first column will be blank if passed in second submission (so there are not 2 symbols in same box)
                                        'firstColumnMark = OutcomeResultStatusEnum.Fail
                                        firstColumnMark = OutcomeResultStatusEnum.Unknown
                                    End If
                                Case OutcomeResultStatusEnum.NotAchieved
                                    secondColumnMark = OutcomeResultStatusEnum.NotAchieved
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        firstColumnMark = OutcomeResultStatusEnum.Achieved
                                        replacementText = AppSettings.FeedbackTextPreviouslyPassed
                                    Else
                                        firstColumnMark = OutcomeResultStatusEnum.Unknown
                                        replacementText = outcome.SecondTryComments
                                    End If
                                Case Else
                                    '-- unknown = non-submit
                                    secondColumnMark = OutcomeResultStatusEnum.Unknown
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        firstColumnMark = OutcomeResultStatusEnum.Achieved
                                        replacementText = AppSettings.FeedbackTextPreviouslyPassed
                                    ElseIf outcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                        firstColumnMark = OutcomeResultStatusEnum.NotAchieved
                                        replacementText = outcome.FirstTryComments
                                    Else
                                        firstColumnMark = OutcomeResultStatusEnum.Unknown
                                        replacementText = AppSettings.NoSubmitFeedback
                                    End If
                            End Select
                    End Select

                    '--Now do the replacements
                    docMarking.ReplaceText(originalText, replacementText)

                    '-- Now the checkmark
                    originalText = "OO" & outcome.BaseOutcome.Name & "OO"

                    Select Case firstColumnMark
                        Case OutcomeResultStatusEnum.Achieved
                            '-- check mark
                            replacementText = CHECKMARK
                        Case OutcomeResultStatusEnum.NotAchieved
                            '-- X mark
                            replacementText = XMARK
                        Case OutcomeResultStatusEnum.Unknown
                            replacementText = BLANK
                    End Select
                    docMarking.ReplaceText(originalText, replacementText)



                    '-- Redo submit in second column
                    originalText = "OO" & outcome.BaseOutcome.Name & "ROO"
                    Select Case secondColumnMark
                        Case OutcomeResultStatusEnum.Achieved
                            '-- check mark
                            replacementText = CHECKMARK
                        Case OutcomeResultStatusEnum.NotAchieved
                            '-- X mark
                            replacementText = XMARK
                        Case OutcomeResultStatusEnum.Unknown
                            replacementText = BLANK
                    End Select
                    docMarking.ReplaceText(originalText, replacementText)

                Next

                docMarking.SaveAs(strDestination)

            End Using




            chkProcessed.Checked = True
            Select Case m_try
                Case Semester.MarkingTry.FirstTry
                    m_studentAssignment.FirstTryPrintDate = Date.Now
                Case (Semester.MarkingTry.SecondTry)
                    m_studentAssignment.SecondTryPrintDate = Date.Now
                Case Semester.MarkingTry.ThirdTry
                    m_studentAssignment.ThirdTryPrintDate = Date.Now
            End Select
        Catch ex As Exception
            Application.DoEvents()
        End Try

    End Sub

    Public Sub PrepareMarkingPage(save As Boolean)
        Try
            'If Not SaveChanges() Then
            '    Exit Sub
            'End If


            'If m_studentAssignment.BaseAssignment.AssignmentBriefFilename.Trim.Length = 0 Then
            '    MessageBox.Show("There is no document related to this assignment. Please fix this problem and try again.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If

            'If rtbImprovementComments.Text.Trim.Length = 0 Then
            '    MessageBox.Show("You must fill out overall and improvement comments.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If



            'Dim oWord As Word.Application
            'Dim oDoc As Word.Document

            'oWord = CreateObject("Word.Application")
            'oWord.Visible = True

            ''-- copy template over to new file, in case user accidentally saves it
            'Dim strTemplateFilename As String = System.IO.Path.Combine(GetMarkingFolder(), m_studentAssignment.BaseAssignment.AssignmentBriefFilename)
            'Dim strWorkingFilename As String = System.IO.Path.Combine(GetMarkingFolder(), "~temp1.docx")
            'If System.IO.File.Exists(strWorkingFilename) Then
            '    System.IO.File.Delete(strWorkingFilename)
            'End If
            'System.IO.File.Copy(strTemplateFilename, strWorkingFilename)
            'oDoc = oWord.Documents.Open(strWorkingFilename)

            'Const CHECKMARK_FONT_NAME As String = "Wingdings"
            'Const CHECKMARK As String = "ü"
            'Const XMARK As String = "û"
            'Const BLANK_FONT_NAME As String = "Ariel"
            'Const BLANK As String = " "

            ''-- refresh module results (may use many times)
            'm_studentModuleResults = m_student.ModuleResults(True)

            'Dim objFirstColumnMark As OutcomeResultStatusEnum '-- Pass=check; fail=X; unknown=blank
            'Dim objSecondColumnMark As OutcomeResultStatusEnum


            'For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
            '    '-- reset varliables
            '    objFirstColumnMark = OutcomeResultStatusEnum.Unknown
            '    objSecondColumnMark = OutcomeResultStatusEnum.Unknown

            '    '-- Feedback comments for each outcome
            '    With oWord.Selection.Find
            '        .Text = "[[[OUTCOME" & outcome.BaseOutcome.Name & "COMMENTS]]]"
            '        Select Case m_try
            '            Case Semester.MarkingTry.FirstTry
            '                Select Case outcome.FirstTryStatus
            '                    '-- Changed in 2.0. Now we will show results for this assignment only
            '                    '   Potential issue: If one outcome is on multiple assignments (P1 or M1, does not matter)
            '                    '   We will only show the results for this assignment on this assignment
            '                    '   Previously, if this assignment failed 1.1 but previous assignment passed 1.1 we would 
            '                    '   say that it Passed Previously but now we will say Fail (exactly the results for this assignment)
            '                    '   This seems reasonable because the assignment marking sheet is not designed to convey module
            '                    '   results, it is designed to convey assignment results (that's why we say MERIT when only M1 
            '                    '   was achieved and M2 was not because M2 was not on this assignment). This is more consistent
            '                    Case OutcomeResultStatusEnum.Achieved
            '                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved
            '                        objSecondColumnMark = OutcomeResultStatusEnum.Unknown
            '                        .Replacement.Text = outcome.FirstTryComments
            '                    Case OutcomeResultStatusEnum.NotAchieved
            '                        objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
            '                        objSecondColumnMark = OutcomeResultStatusEnum.Unknown
            '                        .Replacement.Text = outcome.FirstTryComments
            '                    Case Else
            '                        '-- Unknown
            '                        objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
            '                        objSecondColumnMark = OutcomeResultStatusEnum.Unknown
            '                        .Replacement.Text = AppSettings.NoSubmitFeedback
            '                End Select
            '            Case Semester.MarkingTry.SecondTry
            '                Select Case outcome.SecondTryStatus
            '                    Case OutcomeResultStatusEnum.Achieved
            '                        '-- passing on rework does not mean fail before
            '                        '   could mean passed before and now improving for higher mark
            '                        '   Although in 2017 Peason forbids that behavior, we don't know the future
            '                        .Replacement.Text = outcome.SecondTryComments
            '                        objSecondColumnMark = OutcomeResultStatusEnum.Achieved
            '                        If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Achieved
            '                        Else
            '                            '-- Changing this for 2015 BTEC forms so first column will be blank if passed in second submission (so there are not 2 symbols in same box)
            '                            'objFirstColumnMark = OutcomeResultStatusEnum.Fail
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Unknown
            '                        End If
            '                    Case OutcomeResultStatusEnum.NotAchieved
            '                        objSecondColumnMark = OutcomeResultStatusEnum.NotAchieved
            '                        If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Achieved
            '                            .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
            '                        Else
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Unknown
            '                            .Replacement.Text = outcome.SecondTryComments
            '                        End If
            '                    Case Else
            '                        '-- unknown = non-submit
            '                        objSecondColumnMark = OutcomeResultStatusEnum.Unknown
            '                        If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Achieved
            '                            .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
            '                        ElseIf outcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
            '                            .Replacement.Text = outcome.FirstTryComments
            '                        Else
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Unknown
            '                            .Replacement.Text = AppSettings.NoSubmitFeedback
            '                        End If
            '                End Select
            '            Case Semester.MarkingTry.ThirdTry
            '                Select Case outcome.ThirdTryStatus
            '                    Case OutcomeResultStatusEnum.Achieved
            '                        '-- passing on rework does not mean fail before
            '                        '   could mean passed before and now improving for higher mark
            '                        '   Although in 2017 Peason forbids that behavior, we don't know the future
            '                        .Replacement.Text = outcome.ThirdTryComments
            '                        objSecondColumnMark = OutcomeResultStatusEnum.Achieved
            '                        If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Achieved '-- achieved previously, could be 1st or 2nd submit
            '                        Else
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Unknown
            '                        End If
            '                    Case OutcomeResultStatusEnum.NotAchieved
            '                        objSecondColumnMark = OutcomeResultStatusEnum.NotAchieved
            '                        If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Achieved
            '                            .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
            '                        ElseIf outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
            '                        Else
            '                            objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
            '                            .Replacement.Text = outcome.ThirdTryComments
            '                        End If
            '                    Case OutcomeResultStatusEnum.Unknown
            '                        '-- unknown = non-submit
            '                        objSecondColumnMark = OutcomeResultStatusEnum.Unknown
            '                        If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Achieved
            '                            .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
            '                        ElseIf outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Achieved
            '                            .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
            '                        Else
            '                            objFirstColumnMark = OutcomeResultStatusEnum.Unknown
            '                            .Replacement.Text = AppSettings.NoSubmitFeedback
            '                        End If
            '                End Select
            '        End Select
            '        .Forward = True
            '        .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '        .Format = False
            '        .MatchCase = False
            '        .MatchWholeWord = False
            '        .MatchWildcards = False
            '        .MatchSoundsLike = False
            '        .MatchAllWordForms = False
            '    End With
            '    oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            '    '-- First submit in first column
            '    With oWord.Selection.Find
            '        .Text = "[" & outcome.BaseOutcome.Name & "]"
            '        Select Case objFirstColumnMark
            '            Case OutcomeResultStatusEnum.Achieved
            '                '-- check mark
            '                .Replacement.ClearFormatting()
            '                .Replacement.Text = CHECKMARK
            '                .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '            Case OutcomeResultStatusEnum.NotAchieved
            '                '-- X mark
            '                .Replacement.ClearFormatting()
            '                .Replacement.Text = XMARK
            '                .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '            Case OutcomeResultStatusEnum.Unknown
            '                .Replacement.ClearFormatting()
            '                .Replacement.Text = BLANK
            '                .Replacement.Font.Name = BLANK_FONT_NAME
            '        End Select


            '        .Forward = True
            '        .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '        .Format = True
            '        .MatchCase = False
            '        .MatchWholeWord = False
            '        .MatchKashida = False
            '        .MatchDiacritics = False
            '        .MatchAlefHamza = False
            '        .MatchControl = False
            '        .MatchByte = False
            '        .MatchWildcards = False
            '        .MatchSoundsLike = False
            '        .MatchAllWordForms = False
            '    End With
            '    oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)



            '    '-- Redo submit in second column
            '    With oWord.Selection.Find
            '        .Text = "[" & outcome.BaseOutcome.Name & "R]"
            '        Select Case objSecondColumnMark
            '            Case OutcomeResultStatusEnum.Achieved
            '                '-- check mark
            '                .Replacement.ClearFormatting()
            '                .Replacement.Text = CHECKMARK
            '                .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '            Case OutcomeResultStatusEnum.NotAchieved
            '                '-- X mark
            '                .Replacement.ClearFormatting()
            '                .Replacement.Text = XMARK
            '                .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '            Case OutcomeResultStatusEnum.Unknown
            '                .Replacement.ClearFormatting()
            '                .Replacement.Text = BLANK
            '                .Replacement.Font.Name = BLANK_FONT_NAME
            '        End Select


            '        .Forward = True
            '        .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '        .Format = True
            '        .MatchCase = False
            '        .MatchWholeWord = False
            '        .MatchKashida = False
            '        .MatchDiacritics = False
            '        .MatchAlefHamza = False
            '        .MatchControl = False
            '        .MatchByte = False
            '        .MatchWildcards = False
            '        .MatchSoundsLike = False
            '        .MatchAllWordForms = False
            '    End With
            '    oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            'Next


            'With oWord.Selection.Find
            '    .Text = "[[StudentID]]"
            '    .Replacement.Text = m_student.StudentID
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            'With oWord.Selection.Find
            '    .Text = "[[NickName]]"
            '    .Replacement.Text = m_student.Nickname
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            'With oWord.Selection.Find
            '    .Text = "[[StudentName]]"
            '    .Replacement.Text = m_student.LocalName
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            'With oWord.Selection.Find
            '    .Text = "[[ExtStudentID]]"
            '    .Replacement.Text = m_student.ExtStudentID
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            'With oWord.Selection.Find
            '    .Text = "[[AltNumber]]"
            '    .Replacement.Text = m_student.AltNumber
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            'With oWord.Selection.Find
            '    .Text = "[[[OVERALL]]]"

            '    '-- Change this in 2018 because Overall CAN get quite long (in some tests)
            '    '.Replacement.Text = rtbOverallComments.Text
            '    Clipboard.SetText(rtbOverallComments.Text)
            '    .Replacement.Text = "^c"

            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            'With oWord.Selection.Find
            '    .Text = "[[[IMPROVEMENTS]]]"
            '    Clipboard.SetText(rtbImprovementComments.Text)
            '    .Replacement.Text = "^c"
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            'With oWord.Selection.Find
            '    .Text = "[[[DATE]]]"
            '    Clipboard.SetText(rtbImprovementComments.Text)
            '    .Replacement.Text = Date.Today.ToString("dd / MMM / yyyy")
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = False
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            'If save Then
            '    '-- Save in print folder but sub-folder for each module
            '    Dim strDestination As String = GetMarkingPageFilename()
            '    oDoc.SaveAs2(strDestination)
            '    oDoc.Close()
            '    oWord.Quit()
            'Else
            '    oDoc.Save() '-- to prevent future prompt

            '    'oDoc.PrintOut(ManualDuplexPrint:=True)
            '    'oDoc.PrintOut(False, False, Nothing, Nothing,   1, 5, Nothing, 1, Nothing, Nothing, False, False, Nothing, True)
            'End If

            'chkProcessed.Checked = True
            'Select Case m_try
            '    Case Semester.MarkingTry.FirstTry
            '        m_studentAssignment.FirstTryPrintDate = Date.Now
            '    Case (Semester.MarkingTry.SecondTry)
            '        m_studentAssignment.SecondTryPrintDate = Date.Now
            '    Case Semester.MarkingTry.ThirdTry
            '        m_studentAssignment.ThirdTryPrintDate = Date.Now
            'End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Function GetMarkingPageFilename() As String
        Dim strDestination As String = System.IO.Path.Combine(AppSettings.MarkingPageSaveFolder, Me.m_student.SchoolClass.ClassGroup.Name)
        If Not System.IO.Directory.Exists(strDestination) Then
            System.IO.Directory.CreateDirectory(strDestination)
        End If
        strDestination = System.IO.Path.Combine(strDestination, nudAltNumber.Value.ToString("#,000")) & " - " & txtStudentID.Text & " - " & m_studentAssignment.BaseAssignment.Name & ".docx"
        Return strDestination
    End Function
    Private Sub btnPrintMarkingSheet_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnPrintMarkingSheet.LinkClicked
        PrepareMarkingPageSimple()
    End Sub

    Private Sub btnGenerateImprovementComments_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnGenerateImprovementComments.LinkClicked
        GenerateImprovementFeedback(False, True)
    End Sub
    Private Function GenerateImprovementFeedback(late As Boolean, includeGradeHint As Boolean) As String
        Dim strImprovement As String = String.Empty
        Dim strErrorLocation As String = "A"
        Try
            strErrorLocation = "B"
            If includeGradeHint Then
                If AchievedAllAtGrade(BTECGradeGroup.Pass) Then
                    strErrorLocation = "C"
                    If AchievedAllAtGrade(BTECGradeGroup.Merit) Then
                        If AchievedAllAtGrade(BTECGradeGroup.Distinction) Then
                            '- Distinction
                            strErrorLocation = "D"
                            strImprovement = AppSettings.ImprovementFeedbackForDistinction
                        Else
                            '-- Just merit
                            strErrorLocation = "E"
                            strImprovement = AppSettings.ImprovementFeedbackForMerit
                        End If
                    Else
                        '-- Just pass
                        If m_try = Semester.MarkingTry.FirstTry Then
                            If late Then
                                strErrorLocation = "F"
                                strImprovement = AppSettings.LateSubmitDefaultComment
                            Else
                                strErrorLocation = "G"
                                strImprovement = AppSettings.ImprovementFeedbackForPassAll
                            End If
                        Else
                            strErrorLocation = "H"
                            strImprovement = AppSettings.RedoPassAllDefaultComment
                        End If
                    End If
                Else
                    '-- Not passed yet
                    strErrorLocation = "I"
                    Dim intAchieved As Integer = AchievedOutcomesAtGrade(BTECGradeGroup.Pass)
                    If intAchieved > 0 Then
                        strErrorLocation = "J"
                        strImprovement = AppSettings.ImprovementFeedbackForFailSome
                    Else
                        strErrorLocation = "K"
                        strImprovement = AppSettings.ImprovementFeedbackForFailAll
                    End If
                End If
            End If

            strErrorLocation = "K"
            Dim strReturn As String = strImprovement
            'rtbImprovementComments.Text = strImprovement

            strErrorLocation = "L"
            If strImprovement.Trim.Length > 0 Then
                strReturn &= Environment.NewLine '-- add a break between grade hint, if there is a grade hint
                'rtbImprovementComments.Text &= Environment.NewLine '-- add a break between grade hint, if there is a grade hint
            End If

            strErrorLocation = "M"
            strReturn &= Environment.NewLine()
            strErrorLocation = "N"
            strReturn &= GetImprovementNotes(True)
            strErrorLocation = "O"
            strReturn = strReturn.Trim()

            'rtbImprovementComments.Text &= GetImprovementNotes()
            'rtbImprovementComments.Text = rtbImprovementComments.Text.Trim()

            Return strReturn
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error (loc=" & strErrorLocation & ": " & ex.Message)
        End Try
    End Function
    'Private Function GetImprovementNotes() As String
    '    '-- original version
    '    Try
    '        Dim strReturn As String = String.Empty

    '        For Each item As StudentImprovementItem In olvImprovementItems.CheckedObjects
    '            strReturn &= "* " & item.BaseImprovementItem.Description & " (your performance level: " & item.PerformanceLevel & " out of 5 -- "
    '            Select Case item.PerformanceLevel
    '                Case 1
    '                    strReturn &= "unacceptable"
    '                Case 2
    '                    strReturn &= "very weak, often incorrect"
    '                Case 3
    '                    strReturn &= "OK, but inconsistent"
    '                Case 4
    '                    strReturn &= "Good, but can improve more"
    '                Case 5
    '                    strReturn &= "Already great"
    '            End Select
    '            strReturn &= ")" & Environment.NewLine & Environment.NewLine
    '        Next

    '        Return strReturn.Trim()
    '    Catch ex As Exception
    '        Log(ex)
    '        MessageBox.Show("There was an error with the improvement note list: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Function
    Private Function GetImprovementNotes(includePerformanceLevel As Boolean) As String
        Try
            '-- Generate based on checked items in DGV
            Dim strReturnGood As String = String.Empty
            Dim strReturnBad As String = String.Empty
            Dim boolIncludeGood, boolIncludeBad As Boolean
            For Each item As StudentImprovementItem In olvImprovementItems.CheckedObjects
                item.IncludeToday() '-- for tracking
                If includePerformanceLevel Then
                    Select Case item.PerformanceLevel
                        Case 1
                            strReturnBad &= "* " & item.BaseImprovementItem.Description
                            strReturnBad &= " (your performance level: " & item.PerformanceLevel & " out of 5 -- "
                            strReturnBad &= "unacceptable"
                            strReturnBad &= ")" & Environment.NewLine & Environment.NewLine
                            boolIncludeBad = True
                        Case 2
                            strReturnBad &= "* " & item.BaseImprovementItem.Description
                            strReturnBad &= " (your performance level: " & item.PerformanceLevel & " out of 5 -- "
                            strReturnBad &= "very weak, often incorrect"
                            strReturnBad &= ")" & Environment.NewLine & Environment.NewLine
                            boolIncludeBad = True
                        Case 3
                            strReturnBad &= "* " & item.BaseImprovementItem.Description
                            strReturnBad &= " (your performance level: " & item.PerformanceLevel & " out of 5 -- "
                            strReturnBad &= "OK, but inconsistent"
                            strReturnBad &= ")" & Environment.NewLine & Environment.NewLine
                            boolIncludeBad = True
                        Case 4
                            strReturnGood &= "* " & item.BaseImprovementItem.Description
                            strReturnGood &= " (your performance level: " & item.PerformanceLevel & " out of 5 -- "
                            strReturnGood &= "Good, but can improve more"
                            strReturnGood &= ")" & Environment.NewLine & Environment.NewLine
                            boolIncludeGood = True
                        Case 5
                            strReturnGood &= "* " & item.BaseImprovementItem.Description
                            strReturnGood &= " (your performance level: " & item.PerformanceLevel & " out of 5 -- "
                            strReturnGood &= "Already great"
                            strReturnGood &= ")" & Environment.NewLine & Environment.NewLine
                            boolIncludeGood = True
                    End Select
                End If
            Next
                Dim strReturn As String = String.Empty
            If boolIncludeGood Then
                strReturn &= "Some points where you were strong:"
                strReturn &= Environment.NewLine
                strReturn &= strReturnGood
            End If

            If boolIncludeGood AndAlso boolIncludeBad Then
                strReturn &= Environment.NewLine
            End If

            If boolIncludeBad Then
                strReturn &= "Some points where you can improve:"
                strReturn &= Environment.NewLine
                strReturn &= strReturnBad
            End If

            Return strReturn.Trim()
        Catch ex As Exception
            MessageBox.Show("There was an error with the improvement item list: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub olvOutcomes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles olvOutcomes.SelectedIndexChanged
        olvAutoFeedback.ClearObjects()
        Dim outcome As OutcomeResult = olvOutcomes.SelectedObject
        If outcome Is Nothing Then
            Exit Sub
        End If

        olvAutoFeedback.SetObjects(outcome.BaseOutcome.StoredResults)

        txtFeedbackFilter.Text = String.Empty

        AutoSizeColumns(olvAutoFeedback)
    End Sub

    Private Sub llblDeleteAssignment_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblDeleteAssignment.LinkClicked
        If MessageBox.Show("Are you sure you want to delete this student's assignment?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            m_student.AssignmentsBTEC.Remove(m_studentAssignment)
            MessageBox.Show("Assignment was removed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        End If
    End Sub

    Private Sub llblAchieveAllDistinction_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAchieveAllDistinction.LinkClicked
        Try
            For Each item As OutcomeResult In m_studentAssignment.Outcomes
                Select Case m_try
                    Case Semester.MarkingTry.FirstTry
                        item.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                    Case Semester.MarkingTry.SecondTry
                        If item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                            item.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                        End If
                    Case Semester.MarkingTry.ThirdTry
                        If item.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                            item.ThirdTryStatus = OutcomeResultStatusEnum.Achieved
                        End If
                End Select
                olvOutcomes.RefreshObject(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub llblFailAll_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblFailAll.LinkClicked
        Try
            For Each item As OutcomeResult In m_studentAssignment.Outcomes
                Select Case m_try
                    Case Semester.MarkingTry.FirstTry
                        item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                    Case Semester.MarkingTry.SecondTry
                        '-- only mark those failed on first submission
                        If item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                            item.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved
                        End If
                    Case Semester.MarkingTry.ThirdTry
                        If item.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                            item.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved
                        End If
                End Select
                olvOutcomes.RefreshObject(item)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function GetSavedAssignmentFilename() As String
        Dim strLocalDirectory As String = m_studentAssignment.BaseAssignment.SavedAssignmentsFolder '"C:\Teaching\Teaching Business\Mine\Assignments\OB Assignment\2012 Fall\A1"
        Dim strLocalFilePrefix As String = m_studentAssignment.BaseAssignment.Name & " "
        Dim strDestination As String = System.IO.Path.Combine(strLocalDirectory, strLocalFilePrefix & m_student.StudentID)
        Dim strDestination2 As String = System.IO.Path.Combine(strLocalDirectory, strLocalFilePrefix.Replace(" ", "_") & m_student.StudentID)
        Select Case m_try
            Case Semester.MarkingTry.FirstTry
                '-- nothing
            Case Semester.MarkingTry.SecondTry
                strDestination &= "_redo"
            Case Semester.MarkingTry.ThirdTry
                strDestination &= "_redo2"
        End Select

        strDestination &= ".docx"
        strDestination2 &= ".docx"

        '-- Check for 2 versions: with space and with _
        If System.IO.File.Exists(strDestination) Then
            Return strDestination
        Else
            If System.IO.File.Exists(strDestination2) Then
                Return strDestination2
            Else
                Return strDestination
            End If
        End If


    End Function

    Private Sub ApplyFeedback()
        If olvAutoFeedback.SelectedIndex = -1 Then
            MessageBox.Show("Please select feedback to apply.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim outcome As OutcomeResult = olvOutcomes.SelectedObject
            Select Case m_try
                Case Semester.MarkingTry.FirstTry
                    outcome.FirstTryComments = CType(olvAutoFeedback.SelectedObject, Result).Text
                    outcome.FirstTryStatus = CType(olvAutoFeedback.SelectedObject, Result).Status
                Case Semester.MarkingTry.SecondTry
                    outcome.SecondTryComments = CType(olvAutoFeedback.SelectedObject, Result).Text
                    outcome.SecondTryStatus = CType(olvAutoFeedback.SelectedObject, Result).Status
                Case Semester.MarkingTry.ThirdTry
                    outcome.ThirdTryComments = CType(olvAutoFeedback.SelectedObject, Result).Text
                    outcome.ThirdTryStatus = CType(olvAutoFeedback.SelectedObject, Result).Status
            End Select
            olvOutcomes.RefreshObject(outcome)
        End If
    End Sub
    Private Sub ApplyFeedbackPass()
        If olvAutoFeedback.SelectedIndex = -1 Then
            MessageBox.Show("Please select feedback to apply.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim outcome As OutcomeResult = olvOutcomes.SelectedObject
            Select Case m_try
                Case Semester.MarkingTry.FirstTry
                    outcome.FirstTryComments = olvAutoFeedback.SelectedItem.Text
                    outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                Case Semester.MarkingTry.SecondTry
                    outcome.SecondTryComments = olvAutoFeedback.SelectedItem.Text
                    outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                Case Semester.MarkingTry.ThirdTry
                    outcome.ThirdTryComments = olvAutoFeedback.SelectedItem.Text
                    outcome.ThirdTryStatus = OutcomeResultStatusEnum.Achieved
            End Select
            olvOutcomes.RefreshObject(outcome)
        End If
    End Sub

    Declare Function mciSendString Lib "winmm.dll" _
    Alias "mciSendStringA" (
        ByVal lpstrCommand As String,
        ByVal lpstrReturnString As String,
        ByVal uReturnLength As Integer,
        ByVal hwndCallback As Integer) _
    As Integer

    Private Sub llblEditStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblEditStudent.LinkClicked
        Using frm As New StudentDetail(m_student)
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub txtFeedbackFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFeedbackFilter.TextChanged
        tmrFilterFeedback.Stop()
        tmrFilterFeedback.Start()
    End Sub

    Private Sub tmrFilterFeedback_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFilterFeedback.Tick
        FilterFeedback()
    End Sub
    Private Sub FilterFeedback()
        Try
            tmrFilterFeedback.Stop()

            olvAutoFeedback.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(olvAutoFeedback, txtFeedbackFilter.Text)

            If txtFeedbackFilter.Text.Length = 0 Then
                olvAutoFeedback.EmptyListMsg = "No feedback yet"
            Else
                olvAutoFeedback.EmptyListMsg = "No feedback matches your filter"
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error filtering feedback: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub llblClearFilter_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearFilter.LinkClicked
        txtFeedbackFilter.Text = String.Empty
        txtFeedbackFilter.Focus()
    End Sub

    Private Sub olvAutoFeedback_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvAutoFeedback.ItemActivate
        Try
            ApplyFeedback()

            '-- move to next outcome
            If olvOutcomes.SelectedIndex < olvOutcomes.Items.Count - 1 Then
                olvOutcomes.SelectedIndex += 1
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error applying feedback: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub llblToggleTimer_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblToggleTimer.LinkClicked
        m_boolTimerRunning = Not m_boolTimerRunning
        Me.tmrTimer.Enabled = m_boolTimerRunning
        If m_boolTimerRunning Then
            '-- Just switched to running, so need to update the base time
            m_dtTimerStart = Date.Now - m_tsTimer
            llblToggleTimer.Values.Image = My.Resources.Pause_32
        Else
            llblToggleTimer.Values.Image = My.Resources.play_32
        End If
        DrawTimer()
    End Sub

    Private Sub llblResetTimer_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblResetTimer.LinkClicked
        m_dtTimerStart = Date.Now
        DrawTimer()
    End Sub

    Private Sub tmrTimer_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTimer.Tick
        DrawTimer()
        Dim strFilename As String = GetSavedAssignmentFilename()
        If System.IO.File.Exists(strFilename) Then
            llblExistingAssignment.Values.Image = My.Resources.favorite_32
        Else
            llblExistingAssignment.Values.Image = Nothing
        End If
    End Sub
    Private Sub DrawTimer()
        m_tsTimer = Date.Now - m_dtTimerStart
        txtTimer.Text = m_tsTimer.Hours.ToString("00") & ":" & m_tsTimer.Minutes.ToString("00") & ":" & m_tsTimer.Seconds.ToString("00")

        If m_tsTimer.TotalMinutes >= AppSettings.AssignmentMarkingWarning2 Then
            llblWarningNotice.Values.Image = My.Resources.redball_32
        ElseIf m_tsTimer.TotalMinutes >= AppSettings.AssignmentMarkingWarning1 Then
            llblWarningNotice.Values.Image = My.Resources.yellowball_32
        Else
            llblWarningNotice.Values.Image = Nothing
        End If
    End Sub

    Private Sub rtbImprovementComments_TextChanged(sender As System.Object, e As System.EventArgs) Handles rtbImprovementComments.TextChanged
        lblImprovementCharCount.Text = rtbImprovementComments.TextLength.ToString("#,##0")
    End Sub

    Private Sub llblExistingAssignment_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblExistingAssignment.LinkClicked
        Dim pt As New System.Drawing.Point(MousePosition.X, MousePosition.Y)
        ctxmnuExistingAssignment.Show(pt)

    End Sub

    Private Sub OpenAssignmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenAssignmentToolStripMenuItem.Click
        '-- if file exists, open it
        '   If not, show error
        Dim strFilename As String = GetSavedAssignmentFilename()
        If System.IO.File.Exists(strFilename) Then
            '-- open
            System.Diagnostics.Process.Start(strFilename)
        Else
            MessageBox.Show(strFilename & " cannot be found.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CopyLocalFilenameToClipboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyLocalFilenameToClipboardToolStripMenuItem.Click
        Try
            Dim strDestination As String = GetSavedAssignmentFilename()
            Clipboard.SetText(strDestination)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowLocalFileInExplorerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowLocalFileInExplorerToolStripMenuItem.Click
        Try
            Dim strDestination As String = GetSavedAssignmentFilename()

            Dim psi As New System.Diagnostics.ProcessStartInfo("explorer.exe", "/select, """ & strDestination & """")
            System.Diagnostics.Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function PassFailImageGetter(ByVal row As Object) As Object
        Dim rslt As Result = CType(row, Result)
        Select Case rslt.Status
            Case OutcomeResultStatusEnum.NotAchieved
                Return 0
            Case OutcomeResultStatusEnum.Achieved
                Return 1
            Case Else
                '-- unknown
                Return 2 '-- unknown
        End Select
    End Function
    Private Function PassFailTextImageGetter(ByVal row As Object) As Object
        Dim rslt As Student.StudentModuleOutcomeResult = CType(row, Student.StudentModuleOutcomeResult)
        Select Case rslt.Status
            Case OutcomeResultStatusEnum.NotAchieved
                Return 0
            Case OutcomeResultStatusEnum.Achieved
                Return 1
            Case Else
                '-- unknown
                Return 2 '-- unknown
        End Select
    End Function
    'Private Sub llblStudentPic_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblStudentPic.LinkClicked
    '    If picStudent.Visible Then
    '        picStudent.Hide()
    '    Else
    '        picStudent.Show()
    '        picStudent.Image = m_student.Photo
    '    End If
    'End Sub

    Private Sub llblOpenStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblOpenStudent.LinkClicked
        Using frm As New StudentDetail(m_student)
            frm.ShowDialog()
        End Using
    End Sub

    Private Function ImprovementItemRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim item As StudentImprovementItem = CType(olvi.RowObject, StudentImprovementItem)

        Dim RESOLVED_ISSUE_COLOR As System.Drawing.Color = System.Drawing.Color.LightGreen
        Dim CURRENT_ISSUE_COLOR As System.Drawing.Color = System.Drawing.Color.Yellow
        Dim NON_ISSUE_COLOR As System.Drawing.Color = System.Drawing.Color.White
        Dim newColor As System.Drawing.Color

        If item.DateAdded = DATE_NO_DATE Then
            newColor = NON_ISSUE_COLOR
            olvi.SubItems(olvcolDateAdded.Index).Text = String.Empty
        Else
            '-- so it was added before
            newColor = CURRENT_ISSUE_COLOR
        End If

        If item.DateLastIncluded = DATE_NO_DATE Then
            olvi.SubItems(olvcolDateRemoved.Index).Text = String.Empty
        End If

        If item IsNot Nothing Then
            olvi.BackColor = newColor
            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).BackColor = newColor
            Next
        End If
    End Function

    Private Function MainRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim ocrslt As OutcomeResult = CType(olvi.RowObject, OutcomeResult)

        Dim PASS_COLOR As System.Drawing.Color = System.Drawing.Color.LightGreen
        Dim FAIL_COLOR As System.Drawing.Color = System.Drawing.Color.LightSalmon
        Dim UNKNOWN_COLOR As System.Drawing.Color = System.Drawing.Color.White
        Dim newColor As System.Drawing.Color

        If ocrslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
            ocrslt.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
            ocrslt.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
            newColor = PASS_COLOR
        ElseIf ocrslt.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
            newColor = UNKNOWN_COLOR
        Else
            newColor = FAIL_COLOR
        End If

        If ocrslt IsNot Nothing AndAlso AppSettings.DisableColorsInAssignmentDetail = False Then
            olvi.BackColor = newColor
            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).BackColor = newColor
            Next
        End If
    End Function

    Private Sub llblSaveFeedbackSheet_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblSaveFeedbackSheet.LinkClicked
        PrepareMarkingPageSimple()
        '======PrepareMarkingPageIndependent()


        'chkProcessed.Checked = False
        'llblSaveFeedbackSheet.Hide()
        'Application.DoEvents()
        'PrepareMarkingPage(True)
        'llblSaveFeedbackSheet.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ClearFeedbackFilterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearFeedbackFilterToolStripMenuItem.Click
        txtFeedbackFilter.Text = String.Empty
        txtFeedbackFilter.Focus()
    End Sub

    Private Sub ApplySelectedFeedbackToAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApplySelectedFeedbackToAllToolStripMenuItem.Click
        MsgBox("Not implemented yet")
    End Sub

    Private Sub MoveFeedbackFrom1stTo2ndToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MoveFeedbackFrom1stTo2ndToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to move feedback from 1st to 2nd submission?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            For Each oc As OutcomeResult In m_studentAssignment.Outcomes
                oc.SecondTryStatus = oc.FirstTryStatus
                oc.SecondTryComments = oc.FirstTryComments
                oc.FirstTryComments = String.Empty
                oc.FirstTryStatus = OutcomeResultStatusEnum.Unknown
                olvOutcomes.RefreshObject(oc)
            Next
        End If
    End Sub

    Private Sub MoveFeedbackFrom2ndTo3rdToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MoveFeedbackFrom2ndTo3rdToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to move feedback from 2nd to 3rd submission?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            For Each oc As OutcomeResult In m_studentAssignment.Outcomes
                oc.ThirdTryStatus = oc.SecondTryStatus
                oc.ThirdTryComments = oc.SecondTryComments
                oc.SecondTryComments = String.Empty
                oc.SecondTryStatus = OutcomeResultStatusEnum.Unknown
                olvOutcomes.RefreshObject(oc)
            Next
        End If
    End Sub
    Private Function LoadModuleResults() As Student.StudentModuleResult
        '-- Load up the module results
        olvModuleResults.ClearObjects()
        Dim rslts As Student.StudentModuleResult = m_student.ModuleResults(True)
        olvModuleResults.SetObjects(rslts.Outcomes)

        Return rslts
    End Function
    Private Sub llblModuleResults_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblModuleResults.LinkClicked
        LoadModuleResults()
    End Sub

    Private Sub llblAddImprovementItem_LinkClicked(sender As Object, e As EventArgs) Handles llblAddImprovementItem.LinkClicked
        AddSelectedImprovementItem()
    End Sub
    Private Sub AddSelectedImprovementItem()
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem Is Nothing Then
            MessageBox.Show("Please select an improvement item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If selItem.DateAdded > DATE_NO_DATE Then
                'MessageBox.Show("This improvement item already exists for this student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- add item to student
                m_student.ImprovementItems.Add(selItem)
                selItem.DateAdded = Date.Now
                selItem.PerformanceLevel = 3 '-- default to 3
            End If
            olvImprovementItems.ModelToItem(selItem).Checked = True
            olvImprovementItems.RefreshObject(selItem)
            AutoSizeColumns(olvImprovementItems)
        End If
    End Sub

    Private Sub llblClearImprovementItem_LinkClicked(sender As Object, e As EventArgs) Handles llblClearImprovementItem.LinkClicked
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem Is Nothing Then
            MessageBox.Show("Please select an improvement item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '-- add item to student
            m_student.ImprovementItems.Remove(selItem)
            selItem.DateAdded = DATE_NO_DATE
            olvImprovementItems.RefreshObject(selItem)
            olvImprovementItems.ModelToItem(selItem).Checked = False
            AutoSizeColumns(olvImprovementItems)
        End If
    End Sub

    Private Sub olvImprovementItems_ItemActivate(sender As Object, e As EventArgs) Handles olvImprovementItems.ItemActivate
        AddSelectedImprovementItem()
    End Sub

    Private Sub llblStudentPic_LinkClicked(sender As Object, e As EventArgs) Handles llblStudentPic.LinkClicked
        KryptonSplitContainer1.Panel2Collapsed = Not KryptonSplitContainer1.Panel2Collapsed
    End Sub

    Private Sub llblOpenSavedMarkingPage_LinkClicked(sender As Object, e As EventArgs) Handles llblOpenSavedMarkingPage.LinkClicked
        Try
            Dim strDestination As String = GetMarkingPageFilename()
            If System.IO.File.Exists(strDestination) Then
                System.Diagnostics.Process.Start(strDestination)
            Else
                MessageBox.Show("There is no marking page to open.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("There was an error opening the marking page: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MarkStudentDidNotSubmitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkStudentDidNotSubmitToolStripMenuItem.Click
        Try
            '-- for every outcome on this assignment, mark as "did not submit" for the Semester.MarkingTry that we are in
            For Each oc As OutcomeResult In m_studentAssignment.Outcomes
                Select Case m_try
                    Case Semester.MarkingTry.FirstTry
                        oc.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                        oc.FirstTryComments = AppSettings.NoSubmitFeedback
                    Case Semester.MarkingTry.SecondTry
                        oc.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved
                        oc.SecondTryComments = AppSettings.NoSubmitFeedback
                    Case Semester.MarkingTry.ThirdTry
                        oc.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved
                        oc.ThirdTryComments = AppSettings.NoSubmitFeedback
                End Select
                olvOutcomes.RefreshObject(oc)
            Next

            rtbOverallComments.Text = "Failed all outcomes because the assignment was not submitted."
            rtbImprovementComments.Text = "To pass, student needs to submit the assignment."
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was a problem: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KryptonPanel_Paint(sender As Object, e As PaintEventArgs) Handles KryptonPanel.Paint

    End Sub

    Private Sub CopyAllOutcomeFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyAllOutcomeFeedbackToolStripMenuItem.Click
        Dim sb As New System.Text.StringBuilder()
        For Each oc As OutcomeResult In m_studentAssignment.Outcomes
            sb.Append(oc.Name)
            sb.Append(" ")

            Select Case m_try
                Case Semester.MarkingTry.FirstTry
                    sb.Append(oc.FirstTryComments)
                Case Semester.MarkingTry.SecondTry
                    sb.Append(oc.SecondTryComments)
                Case Semester.MarkingTry.ThirdTry
                    sb.Append(oc.ThirdTryComments)
            End Select
            sb.Append("  ")
        Next

        Clipboard.SetText(sb.ToString())
    End Sub

    Private Sub olvImprovementItems_KeyDown(sender As Object, e As KeyEventArgs) Handles olvImprovementItems.KeyDown
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem IsNot Nothing Then
            If e.KeyCode = Keys.Add Then
                selItem.PerformanceLevel += 1
            ElseIf e.KeyCode = Keys.Subtract Then
                selItem.PerformanceLevel -= 1
            End If
        End If
        olvImprovementItems.RefreshObject(selItem)
    End Sub

    Private Sub llblAchieveAllPass_LinkClicked(sender As Object, e As EventArgs) Handles llblAchieveAllPass.LinkClicked
        Try
            For Each item As OutcomeResult In m_studentAssignment.Outcomes
                If item.BaseOutcome.GradeGroup = BTECGradeGroup.Pass Then
                    Select Case m_try
                        Case Semester.MarkingTry.FirstTry
                            item.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                        Case Semester.MarkingTry.SecondTry
                            If item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                item.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                            End If
                        Case Semester.MarkingTry.ThirdTry
                            If item.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                item.ThirdTryStatus = OutcomeResultStatusEnum.Achieved
                            End If
                    End Select
                    olvOutcomes.RefreshObject(item)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub llblAchieveAllMerit_LinkClicked(sender As Object, e As EventArgs) Handles llblAchieveAllMerit.LinkClicked
        Try
            For Each item As OutcomeResult In m_studentAssignment.Outcomes
                If item.BaseOutcome.GradeGroup = BTECGradeGroup.Pass OrElse item.BaseOutcome.GradeGroup = BTECGradeGroup.Merit Then
                    Select Case m_try
                        Case Semester.MarkingTry.FirstTry
                            item.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                        Case Semester.MarkingTry.SecondTry
                            If item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                item.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                            End If
                        Case Semester.MarkingTry.ThirdTry
                            If item.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                item.ThirdTryStatus = OutcomeResultStatusEnum.Achieved
                            End If
                    End Select
                    olvOutcomes.RefreshObject(item)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub chkShowImprovement_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowImprovement.CheckedChanged, chkShowFeedback.CheckedChanged
        If chkShowImprovement.Checked = False AndAlso chkShowFeedback.Checked = False Then
            KryptonSplitContainer1.Panel2Collapsed = True
        Else
            KryptonSplitContainer1.Panel2Collapsed = False
            KryptonSplitContainer3.Panel1Collapsed = Not chkShowFeedback.Checked
            KryptonSplitContainer3.Panel2Collapsed = Not chkShowImprovement.Checked
        End If
    End Sub

    Private Sub FocusOntagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FocusOntagsToolStripMenuItem.Click
        txtTags.Focus()
    End Sub

    Private Sub FocusOnoverallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FocusOnoverallToolStripMenuItem.Click
        rtbOverallComments.Focus()
    End Sub

    Private Sub FocusOnoutcomesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FocusOnoutcomesToolStripMenuItem.Click
        olvOutcomes.Focus()
    End Sub

    Private Sub FocusOnfeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FocusOnfeedbackToolStripMenuItem.Click
        olvAutoFeedback.Focus()
    End Sub

    Private Sub llblFirstAttemptText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblFirstAttemptText.LinkClicked
        spltOveralFirstReworkText.SplitterDistance = spltOveralFirstReworkText.Width - 20
    End Sub

    Private Sub llblReworkText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblReworkText.LinkClicked
        spltOveralFirstReworkText.SplitterDistance = 20
    End Sub

    Private Sub llblAutoGenImprovementsFirst_LinkClicked(sender As Object, e As EventArgs) Handles llblAutoGenImprovementsFirst.LinkClicked
        rtbImprovementComments.Text = GenerateImprovementFeedback(False, True)
    End Sub

    Private Sub llblAutoGenOverallFirst_LinkClicked(sender As Object, e As EventArgs) Handles llblAutoGenOverallFirst.LinkClicked
        m_try = Semester.MarkingTry.FirstTry
        rtbOverallComments.Text = GenerateOverallComments(False)
    End Sub

    Private Sub llblAutoGenOverallRework_LinkClicked(sender As Object, e As EventArgs) Handles llblAutoGenOverallRework.LinkClicked
        m_try = Semester.MarkingTry.SecondTry
        rtbOverallCommentsRework.Text = GenerateOverallComments(True)
    End Sub

    Private Sub llblAutoGenImprovementsRework_LinkClicked(sender As Object, e As EventArgs) Handles llblAutoGenImprovementsRework.LinkClicked
        rtbImprovementCommentsRework.Text = GenerateImprovementFeedback(False, False)
    End Sub

    Private Sub KryptonSplitContainer4_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles KryptonSplitContainer4.Panel2.Paint

    End Sub
End Class
