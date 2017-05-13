Public Class OralExamDetails

    Private m_frmPublic As ExamClockForm
    Private m_class As SchoolClass
    Private m_try As MarkingTry

    Private m_tsCurrent As TimeSpan
    Private m_tsBase As TimeSpan
    Private m_dtStart As Date
    Private m_boolCounting As Boolean
    Private m_font As Font
    Private m_intCurrentLine As Integer
    Private m_baseAssignment As ClassAssignmentBTEC
    Private m_studentAssignment As StudentAssignmentBTEC
    Private m_student As Student
    Private m_currentOutcome As AssignmentOutcome

    Private Const m_strABSENT_TEXT As String = "Student was absent for oral exam on "

    Private m_boolDirty As Boolean

    Friend Sub New(schoolClass As SchoolClass, assignment As ClassAssignmentBTEC, attempt As MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
        m_baseAssignment = assignment
        m_try = attempt
        m_tsBase = New TimeSpan(0, 0, AppSettings.ExamClockDuration)

    End Sub
    Private Sub PublicToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PublicToolStripMenuItem.Click
        If m_frmPublic Is Nothing Then
            m_frmPublic = New ExamClockForm()
            m_frmPublic.Show()
        Else
            ClosePublic()
        End If
    End Sub
    Private Sub ClosePublic()
        If m_frmPublic IsNot Nothing Then
            m_frmPublic.Close()
            m_frmPublic.Dispose()
            m_frmPublic = Nothing
        End If
    End Sub
    ''' <summary>
    ''' Gives new outcome for existing student
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SelectNewOutcome()
        Dim x As Boolean = True
        Dim intOutcome As Integer
        Select Case m_try
            Case MarkingTry.FirstTry
                ''-- Any outcome should be fine
                'Dim rnd As New Random()
                'Randomize()
                'Dim intOutcome As Integer = rnd.Next Mod m_baseAssignment.Outcomes.Count
                'm_currentOutcome = m_baseAssignment.Outcomes(intOutcome)
                'txtOutcomeText.Text = m_currentOutcome.Name & " - " & m_currentOutcome.Description
                'txtOutcomeText.TextBox.BackColor = Color.White
                Do While x
                    Dim rnd As New Random()
                    Randomize()
                    intOutcome = rnd.Next Mod m_baseAssignment.Outcomes.Count
                    m_currentOutcome = m_baseAssignment.Outcomes(intOutcome)

                    'If Not StudentPassedOutcomeAlready(m_student, m_currentOutcome, MarkingTry.FirstTry) Then
                    If StudentCanOralOutcome(m_student, m_currentOutcome) Then
                        x = False
                    Else
                        '-- loop around and find another outcome
                        Continue Do
                    End If
                Loop
                txtOutcomeText.Text = m_currentOutcome.Name & " - " & m_currentOutcome.Description
                txtOutcomeText.TextBox.BackColor = Color.White
            Case MarkingTry.SecondTry
                '-- Any outcome from any assignment which was failed or unknown for first try
                Do While x
                    Dim rnd As New Random()
                    Randomize()
                    intOutcome = rnd.Next Mod m_student.SchoolClass.ClassGroup.AssignmentOutcomeCount
                    For intAssignmentCounter As Integer = 0 To m_student.SchoolClass.ClassGroup.AssignmentsBTEC.Count - 1
                        If intOutcome > m_student.SchoolClass.ClassGroup.AssignmentsBTEC(intAssignmentCounter).Outcomes.Count - 1 Then
                            intOutcome -= m_student.SchoolClass.ClassGroup.AssignmentsBTEC(intAssignmentCounter).Outcomes.Count
                        Else
                            '-- Now, we can get the assignment and the outcome
                            m_baseAssignment = m_student.SchoolClass.ClassGroup.AssignmentsBTEC(intAssignmentCounter)
                            m_currentOutcome = m_baseAssignment.Outcomes(intOutcome)

                            '-- Now, test to make sure this outcome has not been passed already

                            'If Not StudentPassedOutcomeAlready(m_student, m_currentOutcome, MarkingTry.FirstTry) Then
                            If StudentCanOralOutcome(m_student, m_currentOutcome) Then
                                x = False
                            Else
                                '-- loop around and find another outcome
                                Continue Do
                            End If

                            txtOutcomeText.Text = m_currentOutcome.Name & " - " & m_currentOutcome.Description
                            txtOutcomeText.TextBox.BackColor = Color.White
                        End If
                    Next
                Loop
            Case MarkingTry.ThirdTry

        End Select

        txtFeedback.Text = String.Empty
        txtImprovement.Text = String.Empty
        llblRecordFeedback.Values.Image = llblPassOutcome.Values.Image
        llblRecordFeedback.Show()

        If m_frmPublic IsNot Nothing Then
            m_frmPublic.OutcomeBackColor = Color.White
        End If
    End Sub
    Private Function StudentCanOralOutcome(student As Student, outcome As AssignmentOutcome) As Boolean
        Dim modResults As Student.StudentModuleResult = student.ModuleResults(True)
        For Each rslt As Student.StudentModuleOutcomeResult In modResults.Outcomes
            If rslt.Outcome Is outcome Then
                If rslt.Status = OutcomeResultStatusEnum.Unknown Then
                    Return True
                Else
                    '-- Now the logic gets a little trickier
                    '   If we are on firsttry, then return false (it is not open for oral because it is already passed or failed)
                    '   if we are on secondtry, then if oc on firsttry was fail and is unknown on secondtry (must consider all assignments) then is ok
                    If rslt.Status = OutcomeResultStatusEnum.Achieved Then
                        Return False '-- already passed, do not reassess this outcome
                    Else
                        Select Case m_try
                            Case MarkingTry.FirstTry
                                '-- The rule is, can oral anything that is not passed
                                '   so can pass in oral what you failed in report
                                '   but cannot fail in oral unless for authenticity reasons
                                '   If this outcome was failed, could be on this assignment, 
                                '   or on previous (same outcome can be on multiple assignments)
                                Return True
                            Case MarkingTry.SecondTry
                                '-- Must check ALL instances of this outcome (across all assignments) and secondtry status must be unknown
                                '   if unknown, then return true, otherwise it was already passed/failed already, then return false
                                For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
                                    For Each oc As OutcomeResult In asmt.Outcomes
                                        If oc.BaseOutcome Is outcome Then
                                            If oc.SecondTryStatus <> OutcomeResultStatusEnum.Unknown Then
                                                Return False
                                            End If
                                        End If
                                    Next
                                Next
                                Return True '-- if we went through all the outcomes and did not return false, then we can return true
                            Case MarkingTry.ThirdTry
                                For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
                                    For Each oc As OutcomeResult In asmt.Outcomes
                                        If oc.BaseOutcome Is outcome Then
                                            If oc.ThirdTryStatus <> OutcomeResultStatusEnum.Unknown Then
                                                Return False
                                            End If
                                        End If
                                    Next
                                Next
                                Return True
                        End Select
                    End If
                End If
            End If
        Next
    End Function
    Private Function StudentPassedOutcomeAlready(student As Student, outcome As AssignmentOutcome) As Boolean
        Dim modResults As Student.StudentModuleResult = student.ModuleResults(False)
        For Each rslt As Student.StudentModuleOutcomeResult In modResults.Outcomes
            If rslt.Outcome Is outcome Then
                '-- done, get out
                Return rslt.Status = OutcomeResultStatusEnum.Achieved
            End If
        Next

        '-- if we get here, the student didn't submit
        Return False
    End Function
    Private Sub LoadCurrentAssignmentData()
        For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
            If asmt.BaseAssignment Is m_baseAssignment Then
                m_studentAssignment = asmt
                Exit For
            End If
        Next

        If m_studentAssignment IsNot Nothing Then
            Dim strAwarded As String = String.Empty
        End If
    End Sub
    Private Sub SetStudentAssignment()
        If m_studentAssignment Is Nothing Then
            Dim boolCreateAssignment As Boolean = True
            For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
                If asmt.BaseAssignment Is m_baseAssignment Then
                    m_studentAssignment = asmt
                    boolCreateAssignment = False
                    Exit For
                End If
            Next

            If boolCreateAssignment Then
                m_studentAssignment = m_student.AddAssignment(m_baseAssignment)
            End If
        End If
    End Sub
    ''' <summary>
    ''' Gives new student and new outcome
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SelectNewStudent()
        Try
            Static intRecursionCounter As Integer
            Dim intStudent As Integer
            chkM1.Checked = False
            chkM2.Checked = False
            chkM3.Checked = False
            chkD1.Checked = False
            chkD2.Checked = False
            chkD3.Checked = False
            chkAbsent.Checked = False

            If intRecursionCounter > 200 Then
                '-- We are getting too deep, so just walk from the start until we find someone who has not taken exam yet
                For intStudent = 0 To m_class.Students.Count - 1
                    If StudentReadyForProcessing(m_class.Students(intStudent)) Then
                        m_student = m_class.Students(intStudent)
                        m_studentAssignment = Nothing

                        lblStudentName.Text = m_student.Nickname & " - " & m_student.LocalName & " - " & m_student.StudentID & " - " & m_student.LatestAttendenceStatus.ToString()
                        SelectNewOutcome()
                        ResetCounter()
                        LoadCurrentAssignmentData() '-- to show M/D on ? label
                        intRecursionCounter = 0
                        Exit Try
                    End If
                Next
                '-- If we get here, we have checked all the students and we're done
                lblStudentName.Text = "Class Complete"
                m_student = Nothing
            Else
                Dim rnd As New Random()
                Randomize()
                intStudent = rnd.Next Mod m_class.Students.Count
                If StudentReadyForProcessing(m_class.Students(intStudent)) Then
                    m_student = m_class.Students(intStudent)

                    m_studentAssignment = Nothing
                    lblStudentName.Text = m_student.Nickname & " - " & m_student.LocalName & " - " & m_student.StudentID & " - " & m_student.LatestAttendenceStatus.ToString()

                    SelectNewOutcome()
                    ResetCounter()
                    LoadCurrentAssignmentData() '-- to show M/D on ? label
                    intRecursionCounter = 0
                Else
                    '-- skip this student, they have already been processed
                    intRecursionCounter += 1
                    SelectNewStudent()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        '-- at this point we have a new student or class is complete
        If m_student IsNot Nothing Then
            nudPresentationQuality.Value = m_student.PresentationQuality
            nudWritingQuality.Value = m_student.WritingQuality
            picStudent.Image = m_student.Photo
        End If
    End Sub
    Private Function StudentReadyForProcessing(student As Student) As Boolean
        Dim boolAtLeastOneUnknown As Boolean
        Dim boolAssignmentDoesExist As Boolean
        Select Case m_try
            Case MarkingTry.FirstTry '-- normal submission
                For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
                    If asmt.BaseAssignment Is m_baseAssignment Then
                        '-- rule for first is, any outcome marked with oral exam comments means skip this student
                        '   but also skip if there are no outcomes with unknown status
                        boolAssignmentDoesExist = True
                        For Each outcome As OutcomeResult In asmt.Outcomes
                            If outcome.FirstTryComments.StartsWith(AppSettings.ExamPassDefaultFeedback) OrElse outcome.FirstTryComments.StartsWith(AppSettings.ExamFailDefaultFeedback) OrElse _
                                outcome.FirstTryComments.StartsWith(AppSettings.ExamPassWeakDefaultFeedback) OrElse outcome.FirstTryComments.StartsWith(m_strABSENT_TEXT) Then
                                '-- this student has already been processed this time
                                Return False
                            End If
                            If outcome.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                                boolAtLeastOneUnknown = True
                            End If
                        Next
                    End If
                Next

                '-- If we get here, then we did not have any oral exam outcomes yet 
                '   so check for unknown
                If (Not boolAtLeastOneUnknown) AndAlso boolAssignmentDoesExist Then
                    Return False '-- no unknowns so cannot do oral exam on this student
                End If
            Case MarkingTry.SecondTry '-- redo
                '-- rule for secondtry is, must have at least one fail/unknown in firsttry and all unknowns for secondtry
                '   HOWEVER, must consider both assignments together, not just one (randomly select outcome from combined)
                Dim rslt As Student.QuickAssignmentResults = student.GetQuickAssignmentResults(MarkingTry.FirstTry)
                If rslt.OutcomesPassed < student.SchoolClass.ClassGroup.AssignmentOutcomeCount Then
                    For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
                        '-- rule for second is, any outcome marked (secondtry) with oral exam comments means skip this student.
                        For Each outcome As OutcomeResult In asmt.Outcomes
                            If outcome.SecondTryComments.StartsWith(AppSettings.ExamPassDefaultFeedback) OrElse outcome.SecondTryComments.StartsWith(AppSettings.ExamFailDefaultFeedback) OrElse outcome.SecondTryComments.StartsWith(AppSettings.ExamPassWeakDefaultFeedback) OrElse outcome.FirstTryComments.StartsWith(m_strABSENT_TEXT) Then
                                '-- this student has already been processed this time
                                Return False
                            End If
                        Next
                    Next

                    '-- got here means we've not processed this one yet...so return true
                    Return True
                Else
                    Return False
                End If


                'Dim boolAtLeastOneFailBefore As Boolean = True
                'Dim boolAllUnknownNow As Boolean = True
                'For Each outcome As OutcomeResult In asmt.Outcomes
                '    If outcome.FirstTryStatus <> OutcomeResultStatusEnum.Fail Then
                '        boolAtLeastOneFailBefore = False
                '    End If

                '    If outcome.SecondTryStatus <> OutcomeResultStatusEnum.Unknown Then
                '        boolAllUnknownNow = False
                '    End If
                'Next

                'If boolAtLeastOneFailBefore AndAlso boolAllUnknownNow Then

                'End If
            Case MarkingTry.ThirdTry '-- second redo
                '-- rule for third is, must have at least one fail in second and all unknowns for third
        End Select

        Return True '-- never processed at all
    End Function
    Private Sub ResetCounter()
        m_dtStart = Date.Now
        m_tsCurrent = m_tsBase.Subtract(Date.Now - m_dtStart)
        pbTimer.Invalidate()
    End Sub

    Private Sub llblFailOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblFailOutcome.LinkClicked
        FailStudentOutcome()
    End Sub

    Private Sub FailStudentOutcome()
        llblRecordFeedback.Values.Image = llblFailOutcome.Values.Image
        MarkCurrentOutcomeFail()
    End Sub
    Private Sub MarkCurrentOutcomeFail()
        If m_try = MarkingTry.FirstTry Then
            SetStudentAssignment()
        End If

        If chkAbsent.Checked Then
            txtFeedback.Text &= m_strABSENT_TEXT & Date.Today.ToString("dd MMM yyyy") & "."
            m_student.AddToActivityLog("Failed (absent) outcome " & m_currentOutcome.Name)
        Else
            txtFeedback.Text &= AppSettings.ExamFailDefaultFeedback & "."
            'txtFeedback.Text &= " Oral exam quality: " & trkOverall.Value & " out of 10. "
            m_student.AddToActivityLog("Failed outcome " & m_currentOutcome.Name)
        End If

        If m_frmPublic IsNot Nothing Then
            m_frmPublic.OutcomeBackColor = Color.Red
        End If

        m_boolDirty = True

    End Sub

    Private Sub llblNewOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblNewOutcome.LinkClicked
        SelectNewOutcome()
    End Sub

    Private Sub llblStartClock_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblStartClock.LinkClicked
        ToggleCounter()
    End Sub
    Private Sub ToggleCounter()
        If m_boolCounting Then
            m_boolCounting = False
        Else
            m_dtStart = Date.Now
            m_boolCounting = True
        End If
    End Sub
    Private Sub llblPassOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblPassOutcome.LinkClicked
        PassStudent()
    End Sub
    Private Sub PassStudent()
        llblRecordFeedback.Values.Image = llblPassOutcome.Values.Image
        MarkCurrentOutcomePassed(False)
    End Sub
    Private Sub MarkCurrentOutcomePassed(weak As Boolean)
        If m_try = MarkingTry.FirstTry Then
            SetStudentAssignment()
        End If

        Dim strFeedback As String = String.Empty


        If weak Then
            strFeedback &= AppSettings.ExamPassWeakDefaultFeedback
        Else
            strFeedback &= AppSettings.ExamPassDefaultFeedback
        End If


        Dim boolMDAwardedInOral As Boolean
        Dim strMDAwardText As String = ". Student awarded "
        If chkM1.Checked Then
            strMDAwardText &= "M1 "
            boolMDAwardedInOral = True
        End If
        If chkM2.Checked Then
            strMDAwardText &= "M2 "
            boolMDAwardedInOral = True
        End If
        If chkM3.Checked Then
            strMDAwardText &= "M3 "
            boolMDAwardedInOral = True
        End If
        If chkD1.Checked Then
            strMDAwardText &= "D1 "
            boolMDAwardedInOral = True
        End If
        If chkD2.Checked Then
            strMDAwardText &= "D2 "
            boolMDAwardedInOral = True
        End If
        If chkD3.Checked Then
            strMDAwardText &= "D3 "
            boolMDAwardedInOral = True
        End If
        If boolMDAwardedInOral Then
            strMDAwardText &= "based on performance during oral exam on " & Date.Today.ToString("dd-MMM-yyyy") & "."
            strFeedback &= strMDAwardText
        End If

        'strFeedback &= " Oral exam quality: " & trkOverall.Value & " out of 10. "

        txtFeedback.Text &= strFeedback

        If weak Then
            m_student.AddToActivityLog("Passed (weak) outcome " & m_currentOutcome.Name)
        Else
            m_student.AddToActivityLog("Passed outcome " & m_currentOutcome.Name)
        End If

        If m_frmPublic IsNot Nothing Then
            If weak Then
                m_frmPublic.OutcomeBackColor = Color.Yellow
            Else
                m_frmPublic.OutcomeBackColor = Color.Green
            End If

        End If

        m_boolDirty = True

    End Sub

    Private Sub llblNewStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblNewStudent.LinkClicked
        ClickNewStudent()
    End Sub

    Private Sub SelectSpecificStudent()
        Try
            If m_boolDirty Then
                If MessageBox.Show("Change student without recording mark?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
                    m_boolDirty = False
                Else
                    Exit Sub
                End If
            End If

            m_student = lstStudent.SelectedItem
            m_studentAssignment = Nothing
            lblStudentName.Text = m_student.Nickname & " - " & m_student.LocalName & " - " & m_student.StudentID & " - " & m_student.LatestAttendenceStatus.ToString()

            SelectNewOutcome()
            ResetCounter()
            LoadCurrentAssignmentData() '-- to show M/D on ? label


            llblPassOutcome.Enabled = True
            llblWeakPassOutcome.Enabled = True
            llblFailOutcome.Enabled = True
            llblNewOutcome.Enabled = True
            llblRecordFeedback.Enabled = True

            If m_student IsNot Nothing Then
                nudPresentationQuality.Value = m_student.PresentationQuality
                nudWritingQuality.Value = m_student.WritingQuality
                picStudent.Image = m_student.Photo
            End If

            m_boolDirty = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ClickNewStudent()
        Try
            If m_boolDirty Then
                If MessageBox.Show("Change student without recording mark?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
                    m_boolDirty = False
                Else
                    Exit Sub
                End If
            End If
            SelectNewStudent()
            llblPassOutcome.Enabled = True
            llblWeakPassOutcome.Enabled = True
            llblFailOutcome.Enabled = True
            llblNewOutcome.Enabled = True
            llblRecordFeedback.Enabled = True

            m_boolDirty = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub llblRecordFeedback_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRecordFeedback.LinkClicked
        llblRecordFeedback.Hide() '-- indicate to user we're done
        m_student.PresentationQuality = nudPresentationQuality.Value
        m_student.WritingQuality = nudWritingQuality.Value
        If chkAbsent.Checked Then
            m_student.AddToActivityLog("Student was absent for oral exam")
        End If

        '-- improvement text gets written
        m_studentAssignment.ImprovementComments &= txtImprovement.Text

        '-- outcome result gets written
        Dim status As OutcomeResultStatusEnum
        If llblRecordFeedback.Values.Image Is llblPassOutcome.Values.Image Then
            status = OutcomeResultStatusEnum.Achieved
        Else
            status = OutcomeResultStatusEnum.NotAchieved
        End If

        If m_try = MarkingTry.FirstTry Then
            '-- first try means just use this assignment
            For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
                If asmt.BaseAssignment Is m_baseAssignment Then '<-- only consider THIS assignment
                    For Each result In asmt.Outcomes
                        If result.BaseOutcome Is m_currentOutcome Then
                            '-- just need to match on the name of the outcome (therefore must be unique)
                            Select Case m_try
                                Case MarkingTry.FirstTry
                                    result.FirstTryStatus = status
                                    result.FirstTryComments = txtFeedback.Text
                                Case MarkingTry.SecondTry
                                    result.SecondTryStatus = status
                                    result.SecondTryComments = txtFeedback.Text
                                Case MarkingTry.ThirdTry
                                    result.ThirdTryStatus = status
                                    result.ThirdTryComments = txtFeedback.Text
                            End Select

                            m_boolDirty = False
                            Exit Sub
                        End If
                    Next
                End If
            Next
        Else
            '-- rework means check all assignments
            For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
                For Each result In asmt.Outcomes
                    If result.BaseOutcome Is m_currentOutcome Then
                        '-- just need to match on the name of the outcome (therefore must be unique)
                        Select Case m_try
                            Case MarkingTry.FirstTry
                                result.FirstTryStatus = status
                                result.FirstTryComments = txtFeedback.Text
                            Case MarkingTry.SecondTry
                                result.SecondTryStatus = status
                                result.SecondTryComments = txtFeedback.Text
                            Case MarkingTry.ThirdTry
                                result.ThirdTryStatus = status
                                result.ThirdTryComments = txtFeedback.Text
                        End Select

                        m_boolDirty = False
                        Exit Sub
                    End If
                Next
            Next
        End If

        AddApplicationHistory("Oral exam (" & m_student.ToString() & ") on assignment (" & m_studentAssignment.BaseAssignment.Name & ").")

    End Sub
    Private Sub SetFontSize()
        Using g As Graphics = pbTimer.CreateGraphics()

            Dim strText As String = System.Math.Abs(m_tsCurrent.Minutes).ToString("#0") & ":" & System.Math.Abs(m_tsCurrent.Seconds).ToString("00")
            If m_tsCurrent.TotalSeconds < 0 Then
                strText = "-" & strText
            End If

            Dim sz As SizeF
            Dim intFontSize As Integer = 8
            Const INCREMENT As Integer = 4
            Do While True
                m_font = New Font("Arial", intFontSize)
                sz = g.MeasureString(strText, m_font)
                If sz.Width > pbTimer.Width OrElse sz.Height > pbTimer.Height Then
                    '-- just past limit
                    Exit Do
                Else
                    intFontSize += INCREMENT
                End If
            Loop
            intFontSize -= INCREMENT
            m_font = New Font("Arial", intFontSize)
        End Using
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If m_boolCounting Then
            m_tsCurrent = m_tsBase.Subtract(Date.Now - m_dtStart)
        End If
        Me.pbTimer.Invalidate()
    End Sub
    Private Delegate Sub DratTimeCallback(g As Graphics)
    Private Sub DrawTime(g As Graphics)
        If InvokeRequired Then
            Dim deleg As New DratTimeCallback(AddressOf DrawTime)
            Invoke(deleg, g)
        Else
            SetFontSize()
            Dim strText As String = System.Math.Abs(m_tsCurrent.Minutes).ToString("#0") & ":" & System.Math.Abs(m_tsCurrent.Seconds).ToString("00")
            If m_tsCurrent.TotalSeconds < 0 Then
                strText = "-" & strText
            End If
            g.DrawString(strText, m_font, New SolidBrush(Color.White), New PointF(1, 1))

            If m_frmPublic IsNot Nothing Then
                m_frmPublic.ClockTime = m_tsCurrent
            End If
        End If
    End Sub
    Private Sub pbTimer_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles pbTimer.Paint
        DrawTime(e.Graphics)
    End Sub

    Private Sub txtOutcomeText_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOutcomeText.TextChanged
        If m_frmPublic IsNot Nothing Then
            m_frmPublic.OutcomeText = txtOutcomeText.Text
        End If
    End Sub

    Private Sub lblStudentName_TextChanged(sender As System.Object, e As System.EventArgs) Handles lblStudentName.TextChanged
        If m_frmPublic IsNot Nothing Then
            m_frmPublic.StudentName = lblStudentName.Text
        End If
    End Sub

    Private Sub OralExamDetails_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ClosePublic()
    End Sub

    Private Sub OralExamDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Me.ActiveControl IsNot txtFeedback Then
            Select Case e.KeyCode
                Case Keys.Space
                    '-- start/stop clock
                    ToggleCounter()
                    e.Handled = True
                Case Keys.O
                    '-- change outcome
                    SelectNewOutcome()
                    e.Handled = True
                Case Keys.S
                    '-- change student
                    ClickNewStudent()
                    e.Handled = True
                Case Keys.P
                    '-- pass
                    PassStudent()
                    e.Handled = True
                Case Keys.W
                    '-- pass weakly
                    PassWeakStudent()
                    e.Handled = True
                Case Keys.F
                    '-- fail
                    FailStudentOutcome()
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub OralExamDetails_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'chkM1.Enabled = m_baseAssignment.M1Available
        'chkM2.Enabled = m_baseAssignment.M2Available
        'chkM3.Enabled = m_baseAssignment.M3Available
        'chkD1.Enabled = m_baseAssignment.D1Available
        'chkD2.Enabled = m_baseAssignment.D2Available
        'chkD3.Enabled = m_baseAssignment.D3Available
        
        lstOutcomes.Items.Clear()
        If m_baseAssignment IsNot Nothing Then
            For Each oc As AssignmentOutcome In m_baseAssignment.Outcomes
                If oc.GradeGroup = BTECGradeGroup.Pass Then
                    lstOutcomes.Items.Add(oc)
                End If
            Next
        End If

        m_class.Students.Sort(New Student.CompareOnStudentID())
        For Each stud As Student In m_class.Students
            lstStudent.Items.Add(stud)
        Next

    End Sub

    Private Sub lstOutcomes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstOutcomes.SelectedIndexChanged
        Try
            m_currentOutcome = lstOutcomes.SelectedItem
            txtOutcomeText.Text = m_currentOutcome.ToString 'm_currentOutcome.Name & " - " & m_currentOutcome.Description
            txtOutcomeText.TextBox.BackColor = Color.White
        Catch ex As Exception
            MessageBox.Show("Error changing outcome: " & ex.Message, Application.ProductName, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub llblWeakPassOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblWeakPassOutcome.LinkClicked
        PassWeakStudent()
    End Sub

    Private Sub PassWeakStudent()
        llblRecordFeedback.Values.Image = llblPassOutcome.Values.Image
        MarkCurrentOutcomePassed(True)
    End Sub

    Private Sub lstStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudent.SelectedIndexChanged
        '-- activate selected student
        If lstStudent.SelectedIndex > -1 Then
            SelectSpecificStudent()
        End If
    End Sub

End Class
