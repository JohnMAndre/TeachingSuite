Imports Microsoft.Office.Interop

Friend Class StudentAssignmentDetails

    Private m_student As Student
    Private m_studentAssignment As StudentAssignmentBTEC
    Private m_studentModuleResults As Student.StudentModuleResult
    Private m_boolAssignmentCreated As Boolean
    Private m_try As MarkingTry
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
    Public Sub New(student As Student, assignment As StudentAssignmentBTEC, attempt As MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_student = student
        m_studentAssignment = assignment
        m_try = attempt
    End Sub

    Public Sub New(student As Student, assignment As ClassAssignmentBTEC, attempt As MarkingTry)

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

        If m_try <> MarkingTry.FirstTry Then
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

        'chkM1.Enabled = m_studentAssignment.BaseAssignment.M1Available
        'chkM1.Checked = m_studentAssignment.M1Achieved
        'chkM2.Enabled = m_studentAssignment.BaseAssignment.M2Available
        'chkM2.Checked = m_studentAssignment.M2Achieved
        'chkM3.Enabled = m_studentAssignment.BaseAssignment.M3Available
        'chkM3.Checked = m_studentAssignment.M3Achieved

        'chkD1.Enabled = m_studentAssignment.BaseAssignment.D1Available
        'chkD1.Checked = m_studentAssignment.D1Achieved
        'chkD2.Enabled = m_studentAssignment.BaseAssignment.D2Available
        'chkD2.Checked = m_studentAssignment.D2Achieved
        'chkD3.Enabled = m_studentAssignment.BaseAssignment.D3Available
        'chkD3.Checked = m_studentAssignment.D3Achieved

        chkProcessed.Checked = m_studentAssignment.Processed

        '-- set the outcomes
        olvOutcomes.SetObjects(m_studentAssignment.Outcomes)

        rtbOverallComments.Text = m_studentAssignment.OverallComments
        rtbImprovementComments.Text = m_studentAssignment.ImprovementComments
        rtbObservationComments.Text = m_studentAssignment.ObservationComments

        txtNickName.Text = m_student.Nickname
        txtStudentID.Text = m_student.StudentID
        nudPresentationQuality.Text = m_student.PresentationQuality
        nudWritingQuality.Value = m_student.WritingQuality
        nudResearchQuality.Value = m_student.ResearchQuality
        txtAssignmentName.Text = m_studentAssignment.BaseAssignment.Name
        nudAltNumber.Text = m_student.AltNumber
        txtSchoolClass.Text = m_student.SchoolClass.Name
        Me.Text &= " - " & m_student.LocalName
        txtTags.Text = m_student.Tags
        m_strStudentTagsOriginal = m_student.Tags

        RefreshOutcomeResults()

        C1SpellChecker1.MainDictionary.FileName = GetDictionaryFilename()
        C1SpellChecker1.SetActiveSpellChecking(rtbImprovementComments.RichTextBox, True)
        C1SpellChecker1.SetActiveSpellChecking(rtbObservationComments.RichTextBox, True)
        C1SpellChecker1.SetActiveSpellChecking(rtbOverallComments.RichTextBox, True)

        Me.olvPassFailFeedback.ImageGetter = New BrightIdeasSoftware.ImageGetterDelegate(AddressOf PassFailImageGetter)
        Me.olvModuleResultsPassFail.ImageGetter = New BrightIdeasSoftware.ImageGetterDelegate(AddressOf PassFailTextImageGetter)

        nudPlagiarismSeverity.Value = m_student.PlagiarismSeverity

        'llblStudentPic.Visible = m_student.Photo IsNot Nothing

        AutoSizeColumns(olvAutoFeedback)

        'ToolTip1.SetToolTip(chkM1, m_studentAssignment.BaseAssignment.M1Description)
        'ToolTip1.SetToolTip(chkM2, m_studentAssignment.BaseAssignment.M2Description)
        'ToolTip1.SetToolTip(chkM3, m_studentAssignment.BaseAssignment.M3Description)
        'ToolTip1.SetToolTip(chkD1, m_studentAssignment.BaseAssignment.D1Description)
        'ToolTip1.SetToolTip(chkD2, m_studentAssignment.BaseAssignment.D2Description)
        'ToolTip1.SetToolTip(chkD3, m_studentAssignment.BaseAssignment.D3Description)

        LoadModuleResults()

        '-- Load all the improvement items and include date added/removed for those that apply to this student
        Dim boolItemAdded As Boolean
        For Each item As ImprovementItem In ThisSemester.ImprovementItems
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
                studItem.DateRemoved = DATE_NO_DATE
                m_improvementItems.Add(studItem)
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


        If AppSettings.OpenAssignmentDetailMaximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub


    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        '-- If we created it and canceled then we must remove it
        If m_boolAssignmentCreated Then
            m_student.AssignmentsBTEC.Remove(m_studentAssignment)
        End If

        Close()
    End Sub
    Private Function SaveChanges() As Boolean
        Dim intPassedOutcomes As Integer = PassedOutcomes()

        m_studentAssignment.OverallComments = rtbOverallComments.Text
        m_studentAssignment.ImprovementComments = rtbImprovementComments.Text
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

        AddHistory("Finished marking student (" & m_student.ToString() & ") on assignment (" & m_studentAssignment.BaseAssignment.Name & ").")

        Return True
    End Function
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If SaveChanges() Then
            Close()
        End If
    End Sub
    Private Function PassedOutcomes() As Integer
        Dim intPassedOutcomes As Integer
        For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
            If m_try = MarkingTry.FirstTry AndAlso outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                intPassedOutcomes += 1
            ElseIf m_try = MarkingTry.SecondTry AndAlso (outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved) Then
                intPassedOutcomes += 1
            ElseIf m_try = MarkingTry.ThirdTry AndAlso (outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.ThirdTryStatus = OutcomeResultStatusEnum.Achieved) Then
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
            If m_try = MarkingTry.FirstTry AndAlso outcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                intFailedOutcomes += 1
            ElseIf m_try = MarkingTry.SecondTry AndAlso outcome.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                intFailedOutcomes += 1
            ElseIf m_try = MarkingTry.ThirdTry AndAlso outcome.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved Then
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
                Case MarkingTry.FirstTry
                    If outcome.FirstTryComments.ToLower().Contains("plagiari") Then
                        Return True
                    End If
                Case MarkingTry.SecondTry
                    If outcome.SecondTryComments.ToLower().Contains("plagiari") Then
                        Return True
                    End If
                Case MarkingTry.ThirdTry
                    If outcome.ThirdTryComments.ToLower().Contains("plagiari") Then
                        Return True
                    End If
            End Select
        Next

        Return False
    End Function
    Private Sub btnGenerateOverallComments_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnGenerateOverallComments.LinkClicked

        '============================ DELETE BELOW HERE once 2.0 is fully working ================================

        'Dim objResults As Student.StudentModuleResult = LoadModuleResults()
        'Dim boolPassedAll As Boolean = True
        'For Each oc As Student.StudentModuleOutcomeResult In objResults.Outcomes
        '    If oc.Status <> OutcomeResultStatusEnum.Achieved Then
        '        boolPassedAll = False
        '        Exit For
        '    End If
        'Next

        'Dim intPassedOutcomes As Integer = PassedOutcomes()

        'If intPassedOutcomes = -1 Then
        '    MessageBox.Show("You must mark all outcomes before generating text.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'Dim strOverall As String

        'If intPassedOutcomes = m_studentAssignment.Outcomes.Count Then
        '    strOverall = "Passed all outcomes"
        'Dim boolGotMerit As Boolean = True
        'Dim boolMeritPossible As Boolean = chkM1.Enabled OrElse chkM2.Enabled OrElse chkM3.Enabled
        'If chkM1.Enabled AndAlso Not chkM1.Checked Then
        '    boolGotMerit = False
        '    boolMeritPossible = True
        'End If
        'If chkM2.Enabled AndAlso Not chkM2.Checked Then
        '    boolGotMerit = False
        '    boolMeritPossible = True
        'End If
        'If chkM3.Enabled AndAlso Not chkM3.Checked Then
        '    boolGotMerit = False
        '    boolMeritPossible = True
        'End If
        '
        'If boolGotMerit AndAlso boolMeritPossible Then
        ' strOverall &= " and achieved MERIT"
        'End If

        'Dim boolGotDistinction As Boolean = boolGotMerit '-- must get merit to get distinction
        'Dim boolDistinctionPossible As Boolean = boolMeritPossible AndAlso (chkD1.Enabled OrElse chkD2.Enabled OrElse chkD3.Enabled)
        'If chkD1.Enabled AndAlso Not chkD1.Checked Then
        '    boolGotDistinction = False
        '    boolDistinctionPossible = True
        'End If
        'If chkD2.Enabled AndAlso Not chkD2.Checked Then
        '    boolGotDistinction = False
        '    boolDistinctionPossible = True
        'End If
        'If chkD3.Enabled AndAlso Not chkD3.Checked Then
        '    boolGotDistinction = False
        '    boolDistinctionPossible = True
        'End If

        'If boolGotDistinction AndAlso boolDistinctionPossible Then
        '    strOverall &= " and DISTINCTION"
        'End If

        'rtbOverallComments.Text = strOverall & "."

        'Else
        'Select Case intPassedOutcomes
        '    Case 0
        '        rtbOverallComments.Text = "Referred all outcomes."
        '    Case 1
        '        If boolPassedAll Then
        '            rtbOverallComments.Text = "Passed all remaining outcomes."
        '        Else
        '            rtbOverallComments.Text = "Passed " & intPassedOutcomes.ToString() & " outcome."
        '        End If
        '    Case Else
        '        If boolPassedAll Then
        '            rtbOverallComments.Text = "Passed all remaining outcomes."
        '        Else
        '            rtbOverallComments.Text = "Passed " & intPassedOutcomes.ToString() & " outcomes."
        '        End If
        'End Select
        'End If

        'Dim lst As List(Of OutcomeResult) = GetFailedOutcomes()
        'If lst.Count > 0 Then
        '    Dim intCounter As Integer
        '    rtbOverallComments.Text &= Environment.NewLine & "Referral outcomes: "
        '    For Each ocr As OutcomeResult In lst
        '        intCounter += 1
        '        If intCounter > 1 Then
        '            rtbOverallComments.Text &= "; "
        '        End If
        '        rtbOverallComments.Text &= ocr.Name
        '    Next
        'End If
        '============================ DELETE ABOVE HERE once 2.0 is fully working ================================


        '-- For 2.0 in order to support RQF this has been completely changed
        '   Now M's and D's are outcomes and each outcome has a grade group
        '   The new rules are:
        '   "Achieved Pass" requires all outcomes with gradegroup of pass to be achieved, and number of outcomes @ pass > 0
        '   "Achieved Merit" requires "Achieve Pass" and all outcomes with gradegroup of merit to be achieved, and number of outcomes @ merit > 0
        '   "Achieved Distinction" requires "Achieve Pass" and "Achieve Merit" and all outcomes with gradegroup of distinction to be achieved, and number of outcomes @ distinction > 0
        If AchievedAllAtGrade(BTECGradeGroup.Pass) Then
            If AchievedAllAtGrade(BTECGradeGroup.Merit) Then
                If AchievedAllAtGrade(BTECGradeGroup.Distinction) Then
                    '- Distinction
                    rtbOverallComments.Text = "Achieved all PASS and MERIT and DISTINCTION outcomes."
                Else
                    '-- Just merit
                    rtbOverallComments.Text = "Achieved all PASS and MERIT outcomes."
                End If
            Else
                '-- Just pass
                rtbOverallComments.Text = "Achieved all PASS outcomes"
            End If
        Else
            '-- Not passed yet
            Dim intAvailable As Integer = OutcomesAtGrade(BTECGradeGroup.Pass)
            Dim intAchieved As Integer = AchievedOutcomesAtGrade(BTECGradeGroup.Pass)
            Dim intReferral As Integer = intAvailable - intAchieved
            rtbOverallComments.Text = "Achieved " & intAchieved.ToString() & " of " & intAvailable.ToString() & " PASS outcomes (referral outcomes: "
            rtbOverallComments.Text &= ListReferralOutcomes(BTECGradeGroup.Pass)
            rtbOverallComments.Text &= ")."
        End If

    End Sub
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
            Case MarkingTry.FirstTry
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    '-- only first try counts
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                    End If
                Next
            Case MarkingTry.SecondTry
                '-- first or second try count
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                    End If
                Next
            Case MarkingTry.ThirdTry
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
            Case MarkingTry.FirstTry
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    '-- only first try counts
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            strReturn &= ocResult.BaseOutcome.Name & "; "
                        End If
                    End If
                Next
            Case MarkingTry.SecondTry
                '-- first or second try count
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.SecondTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            strReturn &= ocResult.BaseOutcome.Name & "; "
                        End If
                    End If
                Next
            Case MarkingTry.ThirdTry
                '-- First, second, or third try count
                For Each ocResult As OutcomeResult In m_studentAssignment.Outcomes
                    If ocResult.BaseOutcome.GradeGroup = grade Then
                        If ocResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.SecondTryStatus <> OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.ThirdTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            strReturn &= ocResult.BaseOutcome.Name & "; "
                        End If
                    End If
                Next
        End Select

        Return strReturn.Substring(0, strReturn.Length - 2)
    End Function
    Private Function GetFailedOutcomes() As List(Of OutcomeResult)
        Dim rslts As Student.StudentModuleResult = m_student.ModuleResults
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
            m_studentModuleResults = m_student.ModuleResults
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
    Public Sub PrepareMarkingPage(save As Boolean)
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



            Dim oWord As Word.Application
            Dim oDoc As Word.Document

            oWord = CreateObject("Word.Application")
            oWord.Visible = True

            '-- copy template over to new file, in case user accidentally saves it
            Dim strTemplateFilename As String = System.IO.Path.Combine(GetMarkingFolder(), m_studentAssignment.BaseAssignment.AssignmentBriefFilename)
            Dim strWorkingFilename As String = System.IO.Path.Combine(GetMarkingFolder(), "~temp1.docx")
            If System.IO.File.Exists(strWorkingFilename) Then
                System.IO.File.Delete(strWorkingFilename)
            End If
            System.IO.File.Copy(strTemplateFilename, strWorkingFilename)
            oDoc = oWord.Documents.Open(strWorkingFilename)

            Const CHECKMARK_FONT_NAME As String = "Wingdings"
            Const CHECKMARK As String = "ü"
            Const XMARK As String = "û"
            Const BLANK_FONT_NAME As String = "Ariel"
            Const BLANK As String = " "

            '-- refresh module results (may use many times)
            m_studentModuleResults = m_student.ModuleResults

            Dim objFirstColumnMark As OutcomeResultStatusEnum '-- Pass=check; fail=X; unknown=blank
            Dim objSecondColumnMark As OutcomeResultStatusEnum


            For Each outcome As OutcomeResult In m_studentAssignment.Outcomes
                '-- reset varliables
                objFirstColumnMark = OutcomeResultStatusEnum.Unknown
                objSecondColumnMark = OutcomeResultStatusEnum.Unknown

                '-- Feedback comments for each outcome
                With oWord.Selection.Find
                    .Text = "[[[OUTCOME" & outcome.BaseOutcome.Name & "COMMENTS]]]"
                    Select Case m_try
                        Case MarkingTry.FirstTry
                            Select Case outcome.FirstTryStatus
                                '-- Changed in 2.0. Now we will show results for this assignment only
                                '   Potential issue: If one outcome is on multiple assignments (P1 or M1, does not matter)
                                '   We will only show the results for this assignment on this assignment
                                '   Previously, if this assignment failed 1.1 but previous assignment passed 1.1 we would 
                                '   say that it Passed Previously but now we will say Fail (exactly the results for this assignment)
                                '   This seems reasonable because the assignment marking sheet is not designed to convey module
                                '   results, it is designed to convey assignment results (that's why we say MERIT when only M1 
                                '   was achieved and M2 was not because M2 was not on this assignment). This is more consistent
                                Case OutcomeResultStatusEnum.Achieved
                                    objFirstColumnMark = OutcomeResultStatusEnum.Achieved
                                    objSecondColumnMark = OutcomeResultStatusEnum.Unknown
                                    .Replacement.Text = outcome.FirstTryComments
                                Case OutcomeResultStatusEnum.NotAchieved
                                    objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
                                    objSecondColumnMark = OutcomeResultStatusEnum.Unknown
                                    .Replacement.Text = outcome.FirstTryComments
                                Case Else
                                    '-- Unknown
                                    objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
                                    objSecondColumnMark = OutcomeResultStatusEnum.Unknown
                                    .Replacement.Text = AppSettings.NoSubmitFeedback
                            End Select
                        Case MarkingTry.SecondTry
                            Select Case outcome.SecondTryStatus
                                Case OutcomeResultStatusEnum.Achieved
                                    '-- passing on rework does not mean fail before
                                    '   could mean passed before and now improving for higher mark
                                    '   Although in 2017 Peason forbids that behavior, we don't know the future
                                    .Replacement.Text = outcome.SecondTryComments
                                    objSecondColumnMark = OutcomeResultStatusEnum.Achieved
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved
                                    Else
                                        '-- Changing this for 2015 BTEC forms so first column will be blank if passed in second submission (so there are not 2 symbols in same box)
                                        'objFirstColumnMark = OutcomeResultStatusEnum.Fail
                                        objFirstColumnMark = OutcomeResultStatusEnum.Unknown
                                    End If
                                Case OutcomeResultStatusEnum.NotAchieved
                                    objSecondColumnMark = OutcomeResultStatusEnum.NotAchieved
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved
                                        .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
                                    Else
                                        objFirstColumnMark = OutcomeResultStatusEnum.Unknown
                                        .Replacement.Text = outcome.SecondTryComments
                                    End If
                                Case Else
                                    '-- unknown = non-submit
                                    objSecondColumnMark = OutcomeResultStatusEnum.Unknown
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved
                                        .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
                                    ElseIf outcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
                                        .Replacement.Text = outcome.FirstTryComments
                                    Else
                                        objFirstColumnMark = OutcomeResultStatusEnum.Unknown
                                        .Replacement.Text = AppSettings.NoSubmitFeedback
                                    End If
                            End Select
                        Case MarkingTry.ThirdTry
                            Select Case outcome.ThirdTryStatus
                                Case OutcomeResultStatusEnum.Achieved
                                    '-- passing on rework does not mean fail before
                                    '   could mean passed before and now improving for higher mark
                                    '   Although in 2017 Peason forbids that behavior, we don't know the future
                                    .Replacement.Text = outcome.ThirdTryComments
                                    objSecondColumnMark = OutcomeResultStatusEnum.Achieved
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved '-- achieved previously, could be 1st or 2nd submit
                                    Else
                                        objFirstColumnMark = OutcomeResultStatusEnum.Unknown
                                    End If
                                Case OutcomeResultStatusEnum.NotAchieved
                                    objSecondColumnMark = OutcomeResultStatusEnum.NotAchieved
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved
                                        .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
                                    ElseIf outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
                                    Else
                                        objFirstColumnMark = OutcomeResultStatusEnum.NotAchieved
                                        .Replacement.Text = outcome.ThirdTryComments
                                    End If
                                Case OutcomeResultStatusEnum.Unknown
                                    '-- unknown = non-submit
                                    objSecondColumnMark = OutcomeResultStatusEnum.Unknown
                                    If outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved
                                        .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
                                    ElseIf outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                                        objFirstColumnMark = OutcomeResultStatusEnum.Achieved
                                        .Replacement.Text = AppSettings.FeedbackTextPreviouslyPassed
                                    Else
                                        objFirstColumnMark = OutcomeResultStatusEnum.Unknown
                                        .Replacement.Text = AppSettings.NoSubmitFeedback
                                    End If
                            End Select
                    End Select
                    .Forward = True
                    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = False
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


                '-- First submit in first column
                With oWord.Selection.Find
                    .Text = "[" & outcome.BaseOutcome.Name & "]"
                    Select Case objFirstColumnMark
                        Case OutcomeResultStatusEnum.Achieved
                            '-- check mark
                            .Replacement.ClearFormatting()
                            .Replacement.Text = CHECKMARK
                            .Replacement.Font.Name = CHECKMARK_FONT_NAME
                        Case OutcomeResultStatusEnum.NotAchieved
                            '-- X mark
                            .Replacement.ClearFormatting()
                            .Replacement.Text = XMARK
                            .Replacement.Font.Name = CHECKMARK_FONT_NAME
                        Case OutcomeResultStatusEnum.Unknown
                            .Replacement.ClearFormatting()
                            .Replacement.Text = BLANK
                            .Replacement.Font.Name = BLANK_FONT_NAME
                    End Select


                    .Forward = True
                    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                    .Format = True
                    .MatchCase = False
                    .MatchWholeWord = False
                    .MatchKashida = False
                    .MatchDiacritics = False
                    .MatchAlefHamza = False
                    .MatchControl = False
                    .MatchByte = False
                    .MatchWildcards = False
                    .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)



                '-- Redo submit in second column
                With oWord.Selection.Find
                    .Text = "[" & outcome.BaseOutcome.Name & "R]"
                    Select Case objSecondColumnMark
                        Case OutcomeResultStatusEnum.Achieved
                            '-- check mark
                            .Replacement.ClearFormatting()
                            .Replacement.Text = CHECKMARK
                            .Replacement.Font.Name = CHECKMARK_FONT_NAME
                        Case OutcomeResultStatusEnum.NotAchieved
                            '-- X mark
                            .Replacement.ClearFormatting()
                            .Replacement.Text = XMARK
                            .Replacement.Font.Name = CHECKMARK_FONT_NAME
                        Case OutcomeResultStatusEnum.Unknown
                            .Replacement.ClearFormatting()
                            .Replacement.Text = BLANK
                            .Replacement.Font.Name = BLANK_FONT_NAME
                    End Select


                    .Forward = True
                    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                    .Format = True
                    .MatchCase = False
                    .MatchWholeWord = False
                    .MatchKashida = False
                    .MatchDiacritics = False
                    .MatchAlefHamza = False
                    .MatchControl = False
                    .MatchByte = False
                    .MatchWildcards = False
                    .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            Next

            'With oWord.Selection.Find
            '    .Text = "@M1"
            '    .ClearFormatting()
            '    If m_studentAssignment.BaseAssignment.M1Available Then
            '        If chkM1.Checked Then
            '            '-- check mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = CHECKMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        Else
            '            '-- X mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = XMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        End If
            '    Else
            '        .Replacement.Text = String.Empty
            '    End If
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = True
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchKashida = False
            '    .MatchDiacritics = False
            '    .MatchAlefHamza = False
            '    .MatchControl = False
            '    .MatchByte = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            'With oWord.Selection.Find
            '    .Text = "@D1"
            '    If m_studentAssignment.BaseAssignment.D1Available Then
            '        If chkD1.Checked Then
            '            '-- check mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = CHECKMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        Else
            '            '-- X mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = XMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        End If
            '    Else
            '        .Replacement.Text = String.Empty
            '    End If
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = True
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchKashida = False
            '    .MatchDiacritics = False
            '    .MatchAlefHamza = False
            '    .MatchControl = False
            '    .MatchByte = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            'With oWord.Selection.Find
            '    .Text = "@M2"
            '    If m_studentAssignment.BaseAssignment.M2Available Then
            '        If chkM2.Checked Then
            '            '-- check mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = CHECKMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        Else
            '            '-- X mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = XMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        End If
            '    Else
            '        .Replacement.Text = String.Empty
            '    End If
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = True
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchKashida = False
            '    .MatchDiacritics = False
            '    .MatchAlefHamza = False
            '    .MatchControl = False
            '    .MatchByte = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            'With oWord.Selection.Find
            '    .Text = "@D2"
            '    If m_studentAssignment.BaseAssignment.D2Available Then
            '        If chkD2.Checked Then
            '            '-- check mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = CHECKMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        Else
            '            '-- X mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = XMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        End If
            '    Else
            '        .Replacement.Text = String.Empty
            '    End If
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = True
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchKashida = False
            '    .MatchDiacritics = False
            '    .MatchAlefHamza = False
            '    .MatchControl = False
            '    .MatchByte = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)




            'With oWord.Selection.Find
            '    .Text = "@M3"
            '    If m_studentAssignment.BaseAssignment.M3Available Then
            '        If chkM3.Checked Then
            '            '-- check mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = CHECKMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        Else
            '            '-- X mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = XMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        End If
            '    Else
            '        .Replacement.Text = String.Empty
            '    End If
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = True
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchKashida = False
            '    .MatchDiacritics = False
            '    .MatchAlefHamza = False
            '    .MatchControl = False
            '    .MatchByte = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)




            'With oWord.Selection.Find
            '    .Text = "@D3"
            '    If m_studentAssignment.BaseAssignment.D3Available Then
            '        If chkD3.Checked Then
            '            '-- check mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = CHECKMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        Else
            '            '-- X mark
            '            .Replacement.ClearFormatting()
            '            .Replacement.Text = XMARK
            '            .Replacement.Font.Name = CHECKMARK_FONT_NAME
            '        End If
            '    Else
            '        .Replacement.Text = String.Empty
            '    End If
            '    .Forward = True
            '    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
            '    .Format = True
            '    .MatchCase = False
            '    .MatchWholeWord = False
            '    .MatchKashida = False
            '    .MatchDiacritics = False
            '    .MatchAlefHamza = False
            '    .MatchControl = False
            '    .MatchByte = False
            '    .MatchWildcards = False
            '    .MatchSoundsLike = False
            '    .MatchAllWordForms = False
            'End With
            'oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            With oWord.Selection.Find
                .Text = "[[StudentID]]"
                .Replacement.Text = m_student.StudentID
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            With oWord.Selection.Find
                .Text = "[[NickName]]"
                .Replacement.Text = m_student.Nickname
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            With oWord.Selection.Find
                .Text = "[[StudentName]]"
                .Replacement.Text = m_student.LocalName
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            With oWord.Selection.Find
                .Text = "[[ExtStudentID]]"
                .Replacement.Text = m_student.ExtStudentID
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            With oWord.Selection.Find
                .Text = "[[AltNumber]]"
                .Replacement.Text = m_student.AltNumber
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            With oWord.Selection.Find
                .Text = "[[[OVERALL]]]"
                .Replacement.Text = rtbOverallComments.Text
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            With oWord.Selection.Find
                .Text = "[[[IMPROVEMENTS]]]"
                Clipboard.SetText(rtbImprovementComments.Text)
                .Replacement.Text = "^c"
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


            With oWord.Selection.Find
                .Text = "[[[DATE]]]"
                Clipboard.SetText(rtbImprovementComments.Text)
                .Replacement.Text = Date.Today.ToString("dd / MMM / yyyy")
                .Forward = True
                .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
            End With
            oWord.Selection.Find.Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

            If save Then
                '-- Save in print folder but sub-folder for each module
                Dim strDestination As String = GetMarkingPageFilename()
                oDoc.SaveAs2(strDestination)
                oDoc.Close()
                oWord.Quit()
            Else
                oDoc.Save() '-- to prevent future prompt

                'oDoc.PrintOut(ManualDuplexPrint:=True)
                'oDoc.PrintOut(False, False, Nothing, Nothing,   1, 5, Nothing, 1, Nothing, Nothing, False, False, Nothing, True)
            End If

            chkProcessed.Checked = True
            Select Case m_try
                Case MarkingTry.FirstTry
                    m_studentAssignment.FirstTryPrintDate = Date.Now
                Case (MarkingTry.SecondTry)
                    m_studentAssignment.SecondTryPrintDate = Date.Now
                Case MarkingTry.ThirdTry
                    m_studentAssignment.ThirdTryPrintDate = Date.Now
            End Select
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
        PrepareMarkingPage(False)
    End Sub

    Private Sub btnGenerateImprovementComments_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnGenerateImprovementComments.LinkClicked
        GenerateImprovementFeedback(False, True)
    End Sub
    Private Sub GenerateImprovementFeedback(late As Boolean, includeGradeHint As Boolean)
        Dim strImprovement As String = String.Empty

        If includeGradeHint Then
            If AchievedAllAtGrade(BTECGradeGroup.Pass) Then
                If AchievedAllAtGrade(BTECGradeGroup.Merit) Then
                    If AchievedAllAtGrade(BTECGradeGroup.Distinction) Then
                        '- Distinction
                        strImprovement = AppSettings.ImprovementFeedbackForDistinction
                    Else
                        '-- Just merit
                        strImprovement = AppSettings.ImprovementFeedbackForMerit
                    End If
                Else
                    '-- Just pass
                    If m_try = MarkingTry.FirstTry Then
                        If late Then
                            strImprovement = AppSettings.LateSubmitDefaultComment
                        Else
                            strImprovement = AppSettings.ImprovementFeedbackForPassAll
                        End If
                    Else
                        strImprovement = AppSettings.RedoPassAllDefaultComment
                    End If
                End If
            Else
                '-- Not passed yet
                Dim intAchieved As Integer = AchievedOutcomesAtGrade(BTECGradeGroup.Pass)
                If intAchieved > 0 Then
                    strImprovement = AppSettings.ImprovementFeedbackForFailSome
                Else
                    strImprovement = AppSettings.ImprovementFeedbackForFailAll
                End If
            End If
        End If

        rtbImprovementComments.Text = strImprovement & " " & GetImprovementNotes()
        rtbImprovementComments.Text = rtbImprovementComments.Text.Trim()
    End Sub
    Private Function GetImprovementNotes() As String
        Try
            Dim strReturn As String = String.Empty
            For Each item As StudentImprovementItem In olvImprovementItems.CheckedObjects
                strReturn &= " " & item.BaseImprovementItem.Description
            Next

            Return strReturn.Trim()
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error with the improvement note list: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub llblPassAll_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblPassAll.LinkClicked
        Try
            For Each item As OutcomeResult In m_studentAssignment.Outcomes
                Select Case m_try
                    Case MarkingTry.FirstTry
                        item.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                    Case MarkingTry.SecondTry
                        If item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                            item.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                        End If
                    Case MarkingTry.ThirdTry
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
                    Case MarkingTry.FirstTry
                        item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                    Case MarkingTry.SecondTry
                        '-- only mark those failed on first submission
                        If item.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                            item.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved
                        End If
                    Case MarkingTry.ThirdTry
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

    Private Sub btnGenerateImprovementCommentsLate_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnGenerateImprovementCommentsLate.LinkClicked
        
        GenerateImprovementFeedback(True, True)

    End Sub
    Private Function GetSavedAssignmentFilename() As String
        Dim strLocalDirectory As String = m_studentAssignment.BaseAssignment.SavedAssignmentsFolder '"C:\Teaching\Teaching Business\Mine\Assignments\OB Assignment\2012 Fall\A1"
        Dim strLocalFilePrefix As String = m_studentAssignment.BaseAssignment.Name & " "
        Dim strDestination As String = System.IO.Path.Combine(strLocalDirectory, strLocalFilePrefix & m_student.StudentID)
        Dim strDestination2 As String = System.IO.Path.Combine(strLocalDirectory, strLocalFilePrefix.Replace(" ", "_") & m_student.StudentID)
        Select Case m_try
            Case MarkingTry.FirstTry
                '-- nothing
            Case MarkingTry.SecondTry
                strDestination &= "_redo"
            Case MarkingTry.ThirdTry
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
    Private Sub llblCopyAssignmentFromCD_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblCopyAssignmentFromCD.LinkClicked
        Try
            If AppSettings.CDDrive.Length = 0 Then
                MessageBox.Show("Please set the CD-ROM drive.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim strFileToProcess As String = String.Empty
                Dim files() As String = System.IO.Directory.GetFiles(AppSettings.CDDrive, "*.doc*", IO.SearchOption.AllDirectories)
                If files.Length = 1 Then
                    strFileToProcess = files(0)
                ElseIf files.Length = 0 Then
                    MessageBox.Show("There are no .doc or .docx files on the CD (Drive: " & AppSettings.CDDrive & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    '-- choose
                    Using frm As New AssignmentDocumentSelector(files)
                        If frm.ShowDialog(Me) = DialogResult.OK Then
                            strFileToProcess = frm.SelectedFilename
                        Else
                            Exit Sub
                        End If
                    End Using
                End If

                'Dim strLocalDirectory As String = m_studentAssignment.BaseAssignment.SavedAssignmentsFolder '"C:\Teaching\Teaching Business\Mine\Assignments\OB Assignment\2012 Fall\A1"
                'Dim strLocalFilePrefix As String = m_studentAssignment.BaseAssignment.Name & " "

                If strFileToProcess.Length > 0 Then
                    Dim strDestination As String = GetSavedAssignmentFilename() 'System.IO.Path.Combine(strLocalDirectory, strLocalFilePrefix & m_student.StudentID & ".docx")

                    If System.IO.Path.GetExtension(strFileToProcess).ToLower() = ".docx" Then
                        '-- just copy
                        System.IO.File.Copy(strFileToProcess, strDestination)
                    Else
                        '-- Convert, using Word
                        Dim oWord As Word.Application
                        Dim oDoc As Word.Document

                        oWord = CreateObject("Word.Application")
                        oWord.Visible = True
                        oDoc = oWord.Documents.Open(strFileToProcess)

                        oDoc.SaveAs2(strDestination, 16) 'FileFormat:=WdSaveFormat.wdFormatDocumentDefault)
                        'Application.DoEvents()
                        'MessageBox.Show("Please manually check the conversion process.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'MessageBox.Show("Conversion via Word not implemented yet. You must manually convert (filename copied to clipboard already).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'Clipboard.SetText(strDestination)
                        'System.Diagnostics.Process.Start(strFileToProcess)
                        Exit Sub
                    End If

                    '-- remove any readonly (or other) attributes
                    System.IO.File.SetAttributes(strDestination, IO.FileAttributes.Normal)

                    '-- Now open for user to edit, if necessary
                    System.Diagnostics.Process.Start(strDestination)

                    '-- finally, hide the icon
                    llblCopyAssignmentFromCD.Visible = False
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("There was an error copying (drive: " & AppSettings.CDDrive & ") the assignment: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ApplyFeedback()
        If olvAutoFeedback.SelectedIndex = -1 Then
            MessageBox.Show("Please select feedback to apply.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim outcome As OutcomeResult = olvOutcomes.SelectedObject
            Select Case m_try
                Case MarkingTry.FirstTry
                    outcome.FirstTryComments = CType(olvAutoFeedback.SelectedObject, Result).Text
                    outcome.FirstTryStatus = CType(olvAutoFeedback.SelectedObject, Result).Status
                Case MarkingTry.SecondTry
                    outcome.SecondTryComments = CType(olvAutoFeedback.SelectedObject, Result).Text
                    outcome.SecondTryStatus = CType(olvAutoFeedback.SelectedObject, Result).Status
                Case MarkingTry.ThirdTry
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
                Case MarkingTry.FirstTry
                    outcome.FirstTryComments = olvAutoFeedback.SelectedItem.Text
                    outcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                Case MarkingTry.SecondTry
                    outcome.SecondTryComments = olvAutoFeedback.SelectedItem.Text
                    outcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                Case MarkingTry.ThirdTry
                    outcome.ThirdTryComments = olvAutoFeedback.SelectedItem.Text
                    outcome.ThirdTryStatus = OutcomeResultStatusEnum.Achieved
            End Select
            olvOutcomes.RefreshObject(outcome)
        End If
    End Sub

    Declare Function mciSendString Lib "winmm.dll" _
    Alias "mciSendStringA" ( _
        ByVal lpstrCommand As String, _
        ByVal lpstrReturnString As String, _
        ByVal uReturnLength As Integer, _
        ByVal hwndCallback As Integer) _
    As Integer
    Private Sub llblEjectCD_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblEjectCD.LinkClicked
        'Dim ret As String
        'ret = New String(CChar(" "), 255)
        'mciSendString("Set CDAudio Door Open Wait", ret, 0&, 0&)

        mciSendString("open " & AppSettings.CDDrive.Substring(0, 1) & ": type CDAudio alias driveCD", Nothing, 0, IntPtr.Zero)
        mciSendString("set driveCD door open", Nothing, 0, IntPtr.Zero)
        llblEjectCD.Hide()
    End Sub

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
    Private Sub RefreshOutcomeResults()
        Dim rslt As Student.QuickAssignmentResults = m_student.GetQuickAssignmentResults(MarkingTry.ThirdTry)
        llblAlreadyM1.Visible = rslt.M1Achieved
        llblAlreadyM2.Visible = rslt.M2Achieved
        llblAlreadyM3.Visible = rslt.M3Achieved
        llblAlreadyD1.Visible = rslt.D1Achieved
        llblAlreadyD2.Visible = rslt.D2Achieved
        llblAlreadyD3.Visible = rslt.D3Achieved
        lblOutcomesPassed.Text = rslt.OutcomesPassed.ToString() & " of " & rslt.OutcomesIncluded.ToString()
    End Sub
    Private Sub llblRefreshOutcomeCount_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRefreshOutcomeCount.LinkClicked
        RefreshOutcomeResults()
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

        Dim RESOLVED_ISSUE_COLOR As Color = Color.LightGreen
        Dim CURRENT_ISSUE_COLOR As Color = Color.Yellow
        Dim NON_ISSUE_COLOR As Color = Color.White
        Dim newColor As Color

        If item.DateAdded = DATE_NO_DATE Then
            newColor = NON_ISSUE_COLOR
            olvi.SubItems(olvcolDateAdded.Index).Text = String.Empty
        Else
            '-- so it was a problem
            If item.DateRemoved = DATE_NO_DATE Then
                '-- and it is still a problem
                newColor = CURRENT_ISSUE_COLOR
            Else
                '-- the student has fixed this problem
                newColor = RESOLVED_ISSUE_COLOR
            End If
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

        Dim PASS_COLOR As Color = Color.LightGreen
        Dim FAIL_COLOR As Color = Color.LightSalmon
        Dim UNKNOWN_COLOR As Color = Color.White
        Dim newColor As Color

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
        chkProcessed.Checked = False
        llblSaveFeedbackSheet.Hide()
        Application.DoEvents()
        PrepareMarkingPage(True)
        llblSaveFeedbackSheet.Show()
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
        Dim rslts As Student.StudentModuleResult = m_student.ModuleResults()
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
    Private Sub llblRemoveImprovementItem_LinkClicked(sender As Object, e As EventArgs) Handles llblRemoveImprovementItem.LinkClicked
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem Is Nothing Then
            MessageBox.Show("Please select an improvement item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If selItem.DateRemoved > DATE_NO_DATE Then
                MessageBox.Show("This improvement item was already removed from this student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- add item to student
                selItem.DateRemoved = Date.Now
                olvImprovementItems.RefreshObject(selItem)
                olvImprovementItems.ModelToItem(selItem).Checked = False
                AutoSizeColumns(olvImprovementItems)
            End If
        End If
    End Sub

    Private Sub llblClearImprovementItem_LinkClicked(sender As Object, e As EventArgs) Handles llblClearImprovementItem.LinkClicked
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem Is Nothing Then
            MessageBox.Show("Please select an improvement item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If selItem.DateAdded = DATE_NO_DATE AndAlso selItem.DateRemoved = DATE_NO_DATE Then
                MessageBox.Show("This improvement item does not exist for this student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- add item to student
                m_student.ImprovementItems.Remove(selItem)
                selItem.DateAdded = DATE_NO_DATE
                selItem.DateRemoved = DATE_NO_DATE
                olvImprovementItems.RefreshObject(selItem)
                olvImprovementItems.ModelToItem(selItem).Checked = False
                AutoSizeColumns(olvImprovementItems)
            End If
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
            '-- for every outcome on this assignment, mark as "did not submit" for the markingTry that we are in
            For Each oc As OutcomeResult In m_studentAssignment.Outcomes
                Select Case m_try
                    Case MarkingTry.FirstTry
                        oc.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                        oc.FirstTryComments = AppSettings.NoSubmitFeedback
                    Case MarkingTry.SecondTry
                        oc.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved
                        oc.SecondTryComments = AppSettings.NoSubmitFeedback
                    Case MarkingTry.ThirdTry
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
                Case MarkingTry.FirstTry
                    sb.Append(oc.FirstTryComments)
                Case MarkingTry.SecondTry
                    sb.Append(oc.SecondTryComments)
                Case MarkingTry.ThirdTry
                    sb.Append(oc.ThirdTryComments)
            End Select
            sb.Append("  ")
        Next

        Clipboard.SetText(sb.ToString())
    End Sub

    Private Sub btnGenerateImprovementCommentsNoGradeHint_LinkClicked(sender As Object, e As EventArgs) Handles btnGenerateImprovementCommentsNoGradeHint.LinkClicked
        GenerateImprovementFeedback(False, False)
    End Sub
End Class
