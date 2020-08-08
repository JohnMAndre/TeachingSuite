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
Friend Class ExamClockForm

    Private m_tsCurrent As TimeSpan
    Private m_tsBase As TimeSpan
    Private m_dtStart As Date
    Private m_boolCounting As Boolean
    Private m_font As Font
    Private m_intCurrentLine As Integer
    Private m_class As SchoolClass
    Private m_baseAssignment As ClassAssignmentBTEC
    Private m_studentAssignment As StudentAssignmentBTEC
    Private m_student As Student
    Private m_currentOutcome As AssignmentOutcome
    Private m_examNumber As Semester.MarkingTry
    Private m_intPassed As Integer
    Private m_intFailed As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '-- Use this for public form (new in 2013)

    End Sub
    Public Sub New(schoolClass As SchoolClass, assignment As ClassAssignmentBTEC, attempt As Semester.MarkingTry)
        InitializeComponent()

        m_tsBase = New TimeSpan(0, 0, AppSettings.ExamClockDuration)
        m_class = schoolClass
        m_examNumber = attempt
        m_baseAssignment = assignment

    End Sub
    Public WriteOnly Property OutcomeBackColor As Color
        Set(value As Color)
            txtOutcomeText.TextBox.BackColor = value
        End Set
    End Property
    Public WriteOnly Property OutcomeText As String
        Set(value As String)
            txtOutcomeText.Text = value
            txtOutcomeText.TextBox.BackColor = Color.White
        End Set
    End Property
    Public WriteOnly Property StudentName As String
        Set(value As String)
            lblStudentName.Text = value
        End Set
    End Property
    Public WriteOnly Property ClockTime As TimeSpan
        Set(value As TimeSpan)
            m_tsCurrent = value
            Me.pbTimer.Invalidate()
        End Set
    End Property
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
        End If
    End Sub
    Private Sub pbTimer_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles pbTimer.Paint
        DrawTime(e.Graphics)
    End Sub
    Private Sub ToggleCounter()
        If m_boolCounting Then
            m_boolCounting = False
        Else
            m_dtStart = Date.Now
            m_boolCounting = True
        End If
    End Sub
    Private Sub ResetCounter()
        m_dtStart = Date.Now
        m_tsCurrent = m_tsBase.Subtract(Date.Now - m_dtStart)
        pbTimer.Invalidate()
    End Sub

    Private Sub ExamClockForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If m_baseAssignment IsNot Nothing Then
            'chkM1.Enabled = m_baseAssignment.M1Available
            'chkM2.Enabled = m_baseAssignment.M2Available
            'chkM3.Enabled = m_baseAssignment.M3Available

            'chkD1.Enabled = m_baseAssignment.D1Available
            'chkD2.Enabled = m_baseAssignment.D2Available
            'chkD3.Enabled = m_baseAssignment.D3Available
        End If
    End Sub
    Private Sub RunningForm_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Maximized
        SetFontSize()
        ResetCounter()
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
    ''' <summary>
    ''' Gives new outcome for existing student
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SelectNewOutcome()
        Select Case m_examNumber
            Case Semester.MarkingTry.FirstTry
                '-- Any outcome should be fine
                Dim rnd As New Random()
                Randomize()
                Dim intOutcome As Integer = rnd.Next Mod m_baseAssignment.Outcomes.Count
                m_currentOutcome = m_baseAssignment.Outcomes(intOutcome)
                txtOutcomeText.Text = m_currentOutcome.Name & " - " & m_currentOutcome.Description
                txtOutcomeText.TextBox.BackColor = Color.White
            Case Semester.MarkingTry.SecondTry
                '-- Any outcome from any assignment which was failed or unknown for first try
                Dim x As Boolean = True
                Do While x
                    Dim rnd As New Random()
                    Randomize()
                    Dim intOutcome As Integer = rnd.Next Mod m_student.SchoolClass.ClassGroup.AssignmentOutcomeCount
                    For intAssignmentCounter As Integer = 0 To m_student.SchoolClass.ClassGroup.AssignmentsBTEC.Count - 1
                        If intOutcome > m_student.SchoolClass.ClassGroup.AssignmentsBTEC(intAssignmentCounter).Outcomes.Count - 1 Then
                            intOutcome -= m_student.SchoolClass.ClassGroup.AssignmentsBTEC(intAssignmentCounter).Outcomes.Count
                        Else
                            '-- Now, we can get the assignment and the outcome
                            m_baseAssignment = m_student.SchoolClass.ClassGroup.AssignmentsBTEC(intAssignmentCounter)
                            m_currentOutcome = m_baseAssignment.Outcomes(intOutcome)

                            '-- Now, test to make sure this outcome has not been passed already

                            If Not StudentPassedOutcomeAlready(m_student, m_currentOutcome, Semester.MarkingTry.FirstTry) Then
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
            Case Semester.MarkingTry.ThirdTry

        End Select
    End Sub
    Private Function StudentPassedOutcomeAlready(student As Student, outcome As AssignmentOutcome, markingTry As Semester.MarkingTry) As Boolean
        For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
            For Each oc As OutcomeResult In asmt.Outcomes

                If oc.BaseOutcome Is outcome Then
                    Select Case markingTry
                        Case Semester.MarkingTry.FirstTry
                            '-- done, get out
                            Return oc.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                        Case Semester.MarkingTry.SecondTry
                            '-- done, get out
                            Return oc.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                    End Select
                End If
            Next
        Next

        '-- if we get here, the student didn't submit
        Return False
    End Function
    Private Function StudentReadyForProcessing(student As Student) As Boolean
        Select Case m_examNumber
            Case Semester.MarkingTry.FirstTry '-- normal submission
                For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
                    If asmt.BaseAssignment Is m_baseAssignment Then
                        '-- rule for first is, any outcome marked with oral exam comments means skip this student.
                        For Each outcome As OutcomeResult In asmt.Outcomes
                            If outcome.FirstTryComments = AppSettings.ExamPassDefaultFeedback OrElse outcome.FirstTryComments = AppSettings.ExamFailDefaultFeedback OrElse outcome.FirstTryComments = AppSettings.ExamPassWeakDefaultFeedback Then
                                '-- this student has already been processed this time
                                Return False
                            End If
                        Next
                    End If
                Next
            Case Semester.MarkingTry.SecondTry '-- redo
                '-- rule for secondtry is, must have at least one fail/unknown in firsttry and all unknowns for secondtry
                '   HOWEVER, must consider both assignments together, not just one (randomly select outcome from combined)
                Dim rslt As Student.QuickAssignmentResults = student.GetQuickAssignmentResults(Semester.MarkingTry.FirstTry)
                If rslt.OutcomesPassed < student.SchoolClass.ClassGroup.AssignmentOutcomeCount Then
                    For Each asmt As StudentAssignmentBTEC In student.AssignmentsBTEC
                        '-- rule for second is, any outcome marked (secondtry) with oral exam comments means skip this student.
                        For Each outcome As OutcomeResult In asmt.Outcomes
                            If outcome.SecondTryComments = AppSettings.ExamPassDefaultFeedback OrElse outcome.SecondTryComments = AppSettings.ExamFailDefaultFeedback OrElse outcome.SecondTryComments = AppSettings.ExamPassWeakDefaultFeedback Then
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
            Case Semester.MarkingTry.ThirdTry '-- second redo
                '-- rule for third is, must have at least one fail in second and all unknowns for third
        End Select

        Return True '-- never processed at all
    End Function
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

                        lblStudentName.Text = m_student.Nickname & " - " & m_student.LocalName & " - " & m_student.StudentID
                        SelectNewOutcome()
                        ResetCounter()
                        LoadCurrentAssignmentData() '-- to show M/D on ? label
                        intRecursionCounter = 0
                        Exit Try
                    End If
                Next
                '-- If we get here, we have checked all the students and we're done
                lblStudentName.Text = "Class Complete"
            Else
                Dim rnd As New Random()
                Randomize()
                intStudent = rnd.Next Mod m_class.Students.Count
                If StudentReadyForProcessing(m_class.Students(intStudent)) Then
                    m_student = m_class.Students(intStudent)

                    m_studentAssignment = Nothing
                    lblStudentName.Text = m_student.Nickname & " - " & m_student.LocalName & " - " & m_student.StudentID
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
    End Sub
    Private Sub llblNewStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblNewStudent.LinkClicked
        Try
            SelectNewStudent()
            lblStudentGivenOverall.Text = "?"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub llblNewOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblNewOutcome.LinkClicked
        Try
            SelectNewOutcome()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub llblStartClock_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblStartClock.LinkClicked
        ToggleCounter()
    End Sub
    Private Sub MarkCurrentOutcomePassed(weak As Boolean)


        m_intPassed += 1
        UpdatePassFailTotals()

        If m_examNumber = Semester.MarkingTry.FirstTry Then
            SetStudentAssignment()
        End If

        Dim boolMDAwardedInOral As Boolean
        Dim strMDAwardText As String = "Student awarded "
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
            m_studentAssignment.ImprovementComments &= strMDAwardText
        End If

        For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
            For Each result In asmt.Outcomes
                If result.BaseOutcome Is m_currentOutcome Then
                    '-- just need to match on the name of the outcome (therefore must be unique)
                    Select Case m_examNumber
                        Case Semester.MarkingTry.FirstTry
                            result.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                            If weak Then
                                result.FirstTryComments = AppSettings.ExamPassWeakDefaultFeedback
                            Else
                                result.FirstTryComments = AppSettings.ExamPassDefaultFeedback
                            End If
                        Case Semester.MarkingTry.SecondTry
                            result.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                            If weak Then
                                result.SecondTryComments = AppSettings.ExamPassWeakDefaultFeedback
                            Else
                                result.SecondTryComments = AppSettings.ExamPassDefaultFeedback
                            End If
                        Case Semester.MarkingTry.ThirdTry
                            result.ThirdTryStatus = OutcomeResultStatusEnum.Achieved
                            If weak Then
                                result.ThirdTryComments = AppSettings.ExamPassWeakDefaultFeedback
                            Else
                                result.ThirdTryComments = AppSettings.ExamPassDefaultFeedback
                            End If
                    End Select

                    txtOutcomeText.TextBox.BackColor = Color.Green
                    If weak Then
                        Log("Student ID: " & m_student.StudentID & " passed (weak) outcome " & m_currentOutcome.Name, 5)
                    Else
                        Log("Student ID: " & m_student.StudentID & " passed outcome " & m_currentOutcome.Name, 5)
                    End If

                    Exit Sub
                End If
            Next
        Next
    End Sub
    Private Sub llblPassOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblPassOutcome.LinkClicked
        MarkCurrentOutcomePassed(False)
    End Sub
    Private Sub UpdatePassFailTotals()
        lblFailed.Text = m_intFailed.ToString()
        lblPassed.Text = m_intPassed.ToString()
    End Sub
    Private Sub LoadCurrentAssignmentData()
        For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
            If asmt.BaseAssignment Is m_baseAssignment Then
                m_studentAssignment = asmt
                Exit For
            End If
        Next

        If m_studentAssignment IsNot Nothing Then
            Dim strAwarded As String = String.Empty
            'If m_studentAssignment.M1Achieved Then
            '    strAwarded &= " M1"
            'End If
            'If m_studentAssignment.M2Achieved Then
            '    strAwarded &= " M2"
            'End If
            'If m_studentAssignment.M3Achieved Then
            '    strAwarded &= " M3"
            'End If
            'If m_studentAssignment.D1Achieved Then
            '    strAwarded &= " D1"
            'End If
            'If m_studentAssignment.D2Achieved Then
            '    strAwarded &= " D2"
            'End If
            'If m_studentAssignment.D3Achieved Then
            '    strAwarded &= " D3"
            'End If
            Me.ToolTip1.SetToolTip(lblStudentGivenOverall, strAwarded)
        Else
            Me.ToolTip1.SetToolTip(lblStudentGivenOverall, String.Empty)
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
    Private Sub llblFailOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblFailOutcome.LinkClicked
        m_intFailed += 1
        UpdatePassFailTotals()

        If m_examNumber = Semester.MarkingTry.FirstTry Then
            SetStudentAssignment()
        End If

        For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
            For Each result In asmt.Outcomes
                If result.BaseOutcome Is m_currentOutcome Then
                    '-- need to match on the base outcome 
                    Select Case m_examNumber
                        Case Semester.MarkingTry.FirstTry
                            result.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                            result.FirstTryComments = AppSettings.ExamFailDefaultFeedback
                        Case Semester.MarkingTry.SecondTry
                            result.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved
                            result.SecondTryComments = AppSettings.ExamFailDefaultFeedback
                        Case Semester.MarkingTry.ThirdTry
                            result.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved
                            result.ThirdTryComments = AppSettings.ExamFailDefaultFeedback
                    End Select
                    txtOutcomeText.TextBox.BackColor = Color.Red

                    If chkAbsent.Checked Then
                        Log("Student ID: " & m_student.StudentID & " was absent and failed outcome " & m_currentOutcome.Name, 5)
                        m_studentAssignment.ImprovementComments &= " Student was absent for oral exam on " & Date.Today.ToString("dd MMM yyyy")
                    Else
                        Log("Student ID: " & m_student.StudentID & " failed outcome " & m_currentOutcome.Name, 5)
                    End If

                    Exit Sub '-- just mark one, and get out
                End If
            Next
        Next
    End Sub

    Private Sub txtOutcomeText_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If m_student IsNot Nothing Then
            Select Case e.KeyCode
                Case Keys.F1
                    m_student.PresentationQuality = 1
                Case Keys.F2
                    m_student.PresentationQuality = 2
                Case Keys.F3
                    m_student.PresentationQuality = 3
                Case Keys.F4
                    m_student.PresentationQuality = 4
                Case Keys.F5
                    m_student.PresentationQuality = 5
                Case Keys.F6
                    m_student.PresentationQuality = 6
                Case Keys.F7
                    m_student.PresentationQuality = 7
                Case Keys.F8
                    m_student.PresentationQuality = 8
                Case Keys.F9
                    m_student.PresentationQuality = 9
                Case Keys.F10
                    m_student.PresentationQuality = 10
                Case Keys.F11
                    m_student.PresentationQuality = 11
                Case Keys.F12
                    m_student.PresentationQuality = 12
            End Select

            If e.KeyCode >= Keys.F1 AndAlso e.KeyCode <= Keys.F12 Then
                lblStudentGivenOverall.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub lblStudentGivenOverall_Click(sender As System.Object, e As System.EventArgs) Handles lblStudentGivenOverall.Click
        splitOutcomeNotes.Panel2Collapsed = False
    End Sub

    Private Sub llblSaveNotes_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblSaveNotes.LinkClicked
        SetStudentAssignment()
        m_studentAssignment.ImprovementComments &= " From oral exam: " & txtNotes.Text
        splitOutcomeNotes.Panel2Collapsed = True
    End Sub

    Private Sub llblPassWeakOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblPassWeakOutcome.LinkClicked
        MarkCurrentOutcomePassed(True)
    End Sub
End Class