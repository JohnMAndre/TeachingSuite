Public Class StudentDetail

    Private m_student As Student
    Private m_class As SchoolClass
    Private m_lstRicherTeachingSessionData As New List(Of RicherTeachingSession)

    Public Class RicherTeachingSession
        Private m_objActualClassSession As ActualSessionItem

        Public Property TeachingSession As TeachingSession
        Public ReadOnly Property ActualSessionItem As ActualSessionItem
            Get
                Return m_objActualClassSession
            End Get
        End Property

        Public Sub New(teachingSession As TeachingSession)
            Me.TeachingSession = teachingSession
            m_objActualClassSession = teachingSession.Student.SchoolClass.GetSessionTopic(teachingSession.StartDate, teachingSession.Student.StudentGroup)
        End Sub

    End Class

    ''' <summary>
    ''' For adding a new student
    ''' </summary>
    ''' <param name="schoolClass"></param>
    ''' <remarks></remarks>
    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
        rtbLog.AppendText("Student added: " & Date.Now.ToString(DATE_TIME_FORMAT_DETAIL))
    End Sub
    ''' <summary>
    ''' For editing an existing student
    ''' </summary>
    ''' <param name="student"></param>
    ''' <param name="editable">If false, all fields are readonly</param>
    ''' <remarks></remarks>
    Public Sub New(student As Student, Optional editable As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        txtLocalName.Text = student.LocalName
        txtNickName.Text = student.Nickname
        txtStudentID.Text = student.StudentID
        txtExtStudentID.Text = student.ExtStudentID
        nudAdminNumber.Value = student.AdminNumber
        nudAltNumber.Value = student.AltNumber
        nudPresentationQuality.Value = student.PresentationQuality
        nudWritingQuality.Value = student.WritingQuality
        chkHidden.Checked = student.Hidden
        rtbNotes.Text = student.Notes
        txtEmail.Text = student.EmailAddress.Trim()
        nudMaxAbsences.Value = student.CurrentAbsences
        nudPlagiarismSeverity.Value = student.PlagiarismSeverity
        txtClass.Text = student.SchoolClass.Name
        txtClassGroup.Text = student.SchoolClass.ClassGroup.Name
        rtbLog.Text = student.ActivityLog
        txtTags.Text = student.Tags

        m_student = student

        If Not editable Then
            txtLocalName.ReadOnly = True
            txtNickName.ReadOnly = True
            txtStudentID.ReadOnly = True
            txtExtStudentID.ReadOnly = True

            nudAdminNumber.ReadOnly = True
            nudAdminNumber.Increment = 0
            nudAltNumber.ReadOnly = True
            nudAltNumber.Increment = 0
            nudPresentationQuality.ReadOnly = True
            nudPresentationQuality.Increment = 0
            nudWritingQuality.ReadOnly = True
            nudWritingQuality.Increment = 0
            nudMaxAbsences.ReadOnly = True
            nudMaxAbsences.Increment = 0
            nudPlagiarismSeverity.ReadOnly = True
            nudPlagiarismSeverity.Increment = 0

            chkHidden.Enabled = False
            rtbNotes.ReadOnly = True
            txtEmail.ReadOnly = True
            txtClass.ReadOnly = True
            txtClassGroup.ReadOnly = True
            rtbLog.ReadOnly = True

            olvTeachingSessions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None
            olvOutcomes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None
            olvAssignments.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None
        End If

    End Sub
    Private Sub StudentDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.olvOutcomes.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf MainRowFormatter)
        Me.olvTeachingSessions.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf AttendanceRowFormatter)
        Me.olvImprovementItems.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf ImprovementItemRowFormatter)

        LoadSessionList()
        LoadOutcomes()
        LoadAssignments()
        LoadImprovementItems()
        ShowSessions()
        LoadHistoricalData()

        Select Case AppSettings.LastStudentDetailTab
            Case 0
                ShowNotes()
            Case 1
                ShowSessions()
            Case 2
                ShowOutcomes()
            Case 3
                ShowLog()
            Case 4
                ShowAssignments()
        End Select
        UpdateAbsentPercent()

        '-- have to wire up this way because of krypton limitations
        AddHandler rtbNotes.RichTextBox.DoubleClick, AddressOf rtbNotes_DoubleClick
    End Sub
    Private Function AttendanceRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim item As RicherTeachingSession = CType(olvi.RowObject, RicherTeachingSession)

        Dim PRESENT_COLOR As Color = Color.LightGreen
        Dim EXCUSED_COLOR As Color = Color.Yellow
        Dim ABSENT_COLOR As Color = Color.LightSalmon
        Dim OTHER_COLOR As Color = Color.White
        Dim newColor As Color

        Select Case item.TeachingSession.AttendenceStatus
            Case AttendanceStatusEnum.Absent
                newColor = ABSENT_COLOR
            Case AttendanceStatusEnum.Present
                newColor = PRESENT_COLOR
            Case AttendanceStatusEnum.Excused
                newColor = EXCUSED_COLOR
            Case Else
                newColor = OTHER_COLOR
        End Select

        If item IsNot Nothing Then
            olvi.BackColor = newColor
            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).BackColor = newColor
            Next
        End If
    End Function
    Private Function ImprovementItemRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim item As StudentImprovementItem = CType(olvi.RowObject, StudentImprovementItem)

        Dim RESOLVED_ISSUE_COLOR As Color = Color.LightGreen
        Dim CURRENT_ISSUE_COLOR As Color = Color.Yellow
        Dim NON_ISSUE_COLOR As Color = Color.White
        Dim newColor As Color

        If item.DateAdded = DATE_NO_DATE Then
            newColor = NON_ISSUE_COLOR
            olvi.SubItems(olvcolDataAdded.Index).Text = String.Empty
        Else
            '-- so it was a problem
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
    Private Sub LoadImprovementItems()
        Try
            If m_student IsNot Nothing Then
                olvImprovementItems.SetObjects(m_student.ImprovementItems)
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the improvement items for this student: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadHistoricalData()
        Try
            '-- If turned off in appsettings, will improve performance
            If AppSettings.EnableStudentDataHistory AndAlso m_student IsNot Nothing Then
                olvcolTimeInForce.AspectToStringConverter = New BrightIdeasSoftware.AspectToStringConverterDelegate(AddressOf Me.AspectToStringConverterTimeSpan)

                Dim objHist As New HistoricalStudentData(m_student.StudentID)
                olvHistoricalData.SetObjects(objHist.HistoricalData)

                Dim ht As New Hashtable()
                For Each item As HistoricalStudentData.HistoricalStudentDataItem In objHist.HistoricalData
                    If item.FieldID.Length > 0 Then
                        '-- must be an improvement item, look it up
                        If ht.Contains(item.FieldID) Then
                            '-- already there
                            '   do nothing
                        Else
                            ht.Add(item.FieldID, item.FieldName) ':::: "lookup imp item"
                        End If
                    Else
                        If ht.Contains(item.FieldName) Then
                            '-- do nothing
                        Else
                            ht.Add(item.FieldName, item.FieldName)
                        End If
                    End If
                Next

                For Each obj As Object In ht.Values
                    lstHistoricalFieldsAvailable.Items.Add(obj)
                Next

                'AutoSizeColumns(olvHistoricalData)
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the historical data for this student: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadSessionList()
        Try
            If m_student IsNot Nothing Then
                '-- This was the old way
                'olvTeachingSessions.SetObjects(m_student.TeachingSessions)

                '-- Populate the teaching topics for each session
                Dim objRichSession As RicherTeachingSession
                m_lstRicherTeachingSessionData.Clear()
                For Each session As TeachingSession In m_student.TeachingSessions
                    objRichSession = New RicherTeachingSession(session)
                    m_lstRicherTeachingSessionData.Add(objRichSession)
                Next

                '-- Now load the list
                olvTeachingSessions.SetObjects(m_lstRicherTeachingSessionData)

            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the teaching sessions for this student: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadAssignments()
        If m_student IsNot Nothing Then
            If m_student.AssignmentsBTEC.Count > 0 Then
                olvAssignments.SetObjects(m_student.AssignmentsBTEC)
            Else
                llblShowOutcomes.Hide() '-- If there are no BTEC assignments, then no need to show BTEC outcomes
            End If

            If m_student.Assignments.Count > 0 Then
                olvNormalAssignments.SetObjects(m_student.Assignments)

                '-- Now calculate the overall grade
                lblGradeAsOfTodayPercent.Text = m_student.AssessmentResultOverall
                lblGradeAsOfTodayPoints.Text = m_student.AssessmentTotalPoints.ToString("#,##0")
            End If
        End If
    End Sub
    Private Sub LoadOutcomes()
        If m_student IsNot Nothing Then
            olvOutcomes.SetObjects(m_student.OutcomePerformance())
        End If
    End Sub
    Private Sub AddNewStudent()
        If m_student Is Nothing Then
            m_student = New Student(m_class)
            m_class.Students.Add(m_student)
        End If

        m_student.LocalName = txtLocalName.Text
        m_student.Nickname = txtNickName.Text
        m_student.StudentID = txtStudentID.Text
        m_student.ExtStudentID = txtExtStudentID.Text
        m_student.AdminNumber = nudAdminNumber.Value
        m_student.Hidden = chkHidden.Checked
        m_student.EmailAddress = txtEmail.Text.Trim()
        m_student.Tags = txtTags.Text
    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If txtStudentID.Text.Trim().Length = 0 Then
            MessageBox.Show("Student ID is required (ID connects everything).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If m_student Is Nothing Then
            AddNewStudent()
        End If

        m_student.LocalName = txtLocalName.Text
        m_student.Nickname = txtNickName.Text
        m_student.StudentID = txtStudentID.Text.Trim()
        m_student.ExtStudentID = txtExtStudentID.Text
        m_student.AdminNumber = nudAdminNumber.Value
        m_student.AltNumber = nudAltNumber.Value
        m_student.Notes = rtbNotes.Text
        m_student.Hidden = chkHidden.Checked
        m_student.PresentationQuality = nudPresentationQuality.Value
        m_student.EmailAddress = txtEmail.Text.Trim()
        m_student.PlagiarismSeverity = nudPlagiarismSeverity.Value
        m_student.WritingQuality = nudWritingQuality.Value
        m_student.Tags = txtTags.Text

        'm_student.ActivityLog = rtbLog.Text

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub llblAddSession_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddSession.LinkClicked
        If m_student Is Nothing Then
            AddNewStudent()
        End If

        Dim session As New TeachingSession(m_student)
        session.StartDate = Date.Today
        session.AttendenceStatus = AttendanceStatusEnum.Present
        m_student.TeachingSessions.Add(session)
        LoadSessionList()
    End Sub

    Private Sub llblRemoveSession_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveSession.LinkClicked
        If olvTeachingSessions.SelectedObject Is Nothing Then
            MessageBox.Show("Please select a sesson entry to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim objRicher As RicherTeachingSession = olvTeachingSessions.SelectedObject
            m_student.TeachingSessions.Remove(objRicher.TeachingSession)
            LoadSessionList()
        End If
    End Sub

    Private Sub olvTeachingSessions_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvTeachingSessions.ItemActivate
        olvTeachingSessions.EditSubItem(olvTeachingSessions.SelectedItem, 0)
    End Sub

    Private Sub btnShowStudentNotes_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnShowStudentNotes.LinkClicked
        ShowNotes()
        AppSettings.LastStudentDetailTab = 0
    End Sub

    Private Sub llblAdjustAbsences_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAdjustAbsences.LinkClicked
        Dim intAbsencesExcused As Integer
        If MessageBox.Show("Are you sure you want to adjust current absences down to " & nudMaxAbsences.Value.ToString() & "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            For intCounter = m_student.TeachingSessions.Count - 1 To 0 Step -1
                If m_student.CurrentAbsences <= nudMaxAbsences.Value Then
                    Exit For
                End If

                If m_student.TeachingSessions(intCounter).AttendenceStatus = AttendanceStatusEnum.Absent Then
                    m_student.TeachingSessions(intCounter).AttendenceStatus = AttendanceStatusEnum.Excused
                    intAbsencesExcused += 1
                End If
            Next

            Select Case intAbsencesExcused
                Case 0
                    '-- do nothing
                Case 1
                    m_student.AddToActivityLog("Changed 1 absence to excused.")
                Case Else
                    m_student.AddToActivityLog("Changed " & intAbsencesExcused.ToString() & " absences to excused.")
            End Select

            rtbLog.Text = m_student.ActivityLog

            LoadSessionList()
        End If

        UpdateAbsentPercent()
    End Sub



    Private Sub llblShowOutcomes_LinkClicked_1(sender As System.Object, e As System.EventArgs) Handles llblShowOutcomes.LinkClicked
        ShowOutcomes()
        AppSettings.LastStudentDetailTab = 2
    End Sub

    Private Sub llblShowSessions_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblShowSessions.LinkClicked
        ShowSessions()
        AppSettings.LastStudentDetailTab = 1
    End Sub

    Private Sub ShowNotes()
        pnlAttendance.Hide()
        pnlAssignments.Hide()
        rtbNotes.Show()
        pnlNotes.Show()
        pnlNotes.BringToFront()
        pbButtonHighlight.Location = New Point(btnShowStudentNotes.Left - 7, btnShowStudentNotes.Top - 8)
    End Sub
    Private Sub ShowLog()
        pnlAttendance.Hide()
        pnlAssignments.Hide()
        pnlLog.Show()
        rtbLog.Show()
        pnlLog.BringToFront()
        pbButtonHighlight.Location = New Point(btnShowStudentLog.Left - 7, btnShowStudentLog.Top - 8)
    End Sub
    Private Sub ShowOutcomes()
        pnlAttendance.Hide()
        pnlAssignments.Hide()
        pnlOutcomes.Show()
        pnlOutcomes.BringToFront()
        pbButtonHighlight.Location = New Point(llblShowOutcomes.Left - 7, llblShowOutcomes.Top - 8)
    End Sub
    Private Sub ShowAssignments()
        pnlAttendance.Hide()
        pnlAssignments.Show()

        If m_student.AssignmentsBTEC.Count > 0 Then
            olvAssignments.SetObjects(m_student.AssignmentsBTEC)
            olvAssignments.Visible = True
            olvAssignments.Show()
            olvAssignments.BringToFront()
        Else
            olvAssignments.Visible = False
        End If

        If m_student.Assignments.Count > 0 OrElse olvAssignments.Visible = False Then '-- we need something visible, even if there are no assignments of any kind
            olvNormalAssignments.SetObjects(m_student.Assignments)
            pnlNormalAssignments.Visible = True
            pnlNormalAssignments.Show()
            pnlNormalAssignments.BringToFront()
        Else
            pnlNormalAssignments.Visible = False

        End If


        pbButtonHighlight.Location = New Point(btnShowAssignments.Left - 7, btnShowAssignments.Top - 8)
    End Sub
    Private Sub ShowSessions()
        pnlAttendance.Show()
        pnlAssignments.Hide()
        pnlAttendance.BringToFront()
        olvTeachingSessions.Show()
        olvTeachingSessions.BringToFront()
        pbButtonHighlight.Location = New Point(llblShowSessions.Left - 7, llblShowSessions.Top - 8)
    End Sub
    Private Sub ShowImprovementItems()
        olvImprovementItems.Show()
        olvImprovementItems.BringToFront()
        pnlAttendance.Hide()
        pnlAssignments.Hide()
        olvTeachingSessions.Hide()
        pbButtonHighlight.Location = New Point(btnShowImprovementItems.Left - 7, btnShowImprovementItems.Top - 8)
    End Sub
    Private Sub ShowHistoricalData()
        pnlHistoricalData.Show()
        pnlHistoricalData.BringToFront()
        olvImprovementItems.Hide()
        pnlAttendance.Hide()
        pnlAssignments.Hide()
        olvTeachingSessions.Hide()
        pbButtonHighlight.Location = New Point(btnShowHistoricalData.Left - 7, btnShowHistoricalData.Top - 8)
    End Sub
    Private Sub btnShowStudentLog_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnShowStudentLog.LinkClicked
        ShowLog()
        AppSettings.LastStudentDetailTab = 3
    End Sub

    Private Sub btnShowAssignments_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnShowAssignments.LinkClicked
        ShowAssignments()
        AppSettings.LastStudentDetailTab = 4
    End Sub

    Private Sub llblMoveAssignment_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblMoveAssignment.LinkClicked
        If olvAssignments.SelectedObject Is Nothing Then
            If olvNormalAssignments.SelectedObject Is Nothing Then
                MessageBox.Show("Please select an assignment to move.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- Move normal assignment
                Using frm As New StudentSelector()
                    If frm.ShowDialog = DialogResult.OK Then
                        Application.DoEvents()
                        Dim newStudent As Student = frm.SelectedStudent
                        If newStudent IsNot Nothing Then
                            Dim asmt As StudentAssignment = CType(olvNormalAssignments.SelectedObject, StudentAssignment)
                            asmt.Student = newStudent
                            newStudent.Assignments.Add(asmt)
                            m_student.Assignments.Remove(asmt)
                            olvNormalAssignments.RemoveObject(asmt)
                        End If
                    End If
                End Using
                LoadAssignments()
            End If
        Else
            '-- Move BTEC Assignment
            '-- select new student to transfer to
            Using frm As New StudentSelector()
                If frm.ShowDialog = DialogResult.OK Then
                    Application.DoEvents()
                    Dim newStudent As Student = frm.SelectedStudent
                    If newStudent IsNot Nothing Then
                        Dim asmt As StudentAssignmentBTEC = CType(olvAssignments.SelectedObject, StudentAssignmentBTEC)
                        asmt.Student = newStudent
                        newStudent.AssignmentsBTEC.Add(asmt)
                        m_student.AssignmentsBTEC.Remove(asmt)
                        olvAssignments.RemoveObject(asmt)
                    End If
                End If
            End Using
            LoadAssignments()
        End If
    End Sub
    Private Sub UpdateAbsentPercent()
        Dim dbl As Double
        If nudMaxAbsences.Value = 0 OrElse m_student Is Nothing Then
            lblAbsentPercent.Text = String.Empty
        Else
            dbl = nudMaxAbsences.Value / m_student.TeachingSessions.Count
            lblAbsentPercent.Text = dbl.ToString("##0%")
        End If
    End Sub

    Private Sub nudMaxAbsences_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudMaxAbsences.ValueChanged
        UpdateAbsentPercent()
    End Sub

    Private Sub rtbNotes_DoubleClick(sender As Object, e As EventArgs)
        rtbNotes.Text = rtbNotes.Text & Environment.NewLine & Date.Now.ToString() & "   "
    End Sub

    Private Sub btnShowImprovementItems_LinkClicked(sender As Object, e As EventArgs) Handles btnShowImprovementItems.LinkClicked
        ShowImprovementItems()
        AppSettings.LastStudentDetailTab = 1
    End Sub

    Private Sub llblRefreshGradeAsOfToday_LinkClicked(sender As Object, e As EventArgs) Handles llblRefreshGradeAsOfToday.LinkClicked
        lblGradeAsOfTodayPercent.Text = m_student.AssessmentResultOverall
        lblGradeAsOfTodayPoints.Text = m_student.AssessmentTotalPoints.ToString("#,##0")
    End Sub

    Private Sub btnShowHistoricalData_LinkClicked(sender As Object, e As EventArgs) Handles btnShowHistoricalData.LinkClicked
        ShowHistoricalData()
        AppSettings.LastStudentDetailTab = 5
    End Sub

    Private Sub lstHistoricalFieldsAvailable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHistoricalFieldsAvailable.SelectedIndexChanged
        '-- Load just the data for this field
        'olvHistoricalData.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(olvHistoricalData, lstHistoricalFieldsAvailable.Items(lstHistoricalFieldsAvailable.SelectedIndex))
        olvHistoricalData.ModelFilter = New BrightIdeasSoftware.ModelFilter(Function(x) CType(x, HistoricalStudentData.HistoricalStudentDataItem).FieldName = lstHistoricalFieldsAvailable.Items(lstHistoricalFieldsAvailable.SelectedIndex))
        'AutoSizeColumns(olvHistoricalData)
    End Sub
    Private Function AspectToStringConverterTimeSpan(ByVal ts As TimeSpan) As String
        Dim strReturn As String = String.Empty

        If ts.Days > 0 Then
            strReturn &= ts.Days & "d "
        End If

        If ts.Hours > 0 OrElse strReturn.Length > 0 Then
            strReturn &= ts.Hours & "h "
        End If

        If ts.Minutes > 0 OrElse strReturn.Length > 0 Then
            strReturn &= ts.Minutes & "m "
        End If

        If ts.Seconds > 0 OrElse strReturn.Length = 0 Then '-- "5m 0s" can just be written "5m" but if time is zero, should write "0s"
            strReturn &= ts.Seconds & "s "
        End If

        Return strReturn
    End Function

    Private Sub llblFindInNotes_LinkClicked(sender As Object, e As EventArgs) Handles llblFindInNotes.LinkClicked
        rtbNotes.Find(txtFindInNotes.Text, RichTextBoxFinds.None)
    End Sub
    Private Sub FindInNotes()
        Static intPosition As Integer
        If txtFindInNotes.Text.Length = 0 Then
            Exit Sub
        End If

        intPosition = rtbNotes.Find(txtFindInNotes.Text, intPosition, RichTextBoxFinds.None)
        If intPosition > -1 Then
            rtbNotes.SelectionStart = intPosition
            rtbNotes.SelectionLength = txtFindInNotes.Text.Length
            intPosition += 1
        Else
            intPosition = 0 '-- reset for next time around
        End If
    End Sub

    Private Sub llblFindInHistory_LinkClicked(sender As Object, e As EventArgs) Handles llblFindInHistory.LinkClicked
        FindInLog()
    End Sub
    Private Sub FindInLog()
        Static intPosition As Integer
        If txtFindInHistory.Text.Length = 0 Then
            Exit Sub
        End If

        intPosition = rtbLog.Find(txtFindInHistory.Text, intPosition, RichTextBoxFinds.None)
        If intPosition > -1 Then
            rtbLog.SelectionStart = intPosition
            rtbLog.SelectionLength = txtFindInHistory.Text.Length
            intPosition += 1
        Else
            intPosition = 0 '-- reset for next time around
        End If
    End Sub

    Private Sub txtFindInHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindInHistory.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindInLog()
        End If
    End Sub

    Private Sub txtFindInNotes_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindInNotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindInNotes()
        End If
    End Sub

    Private Sub llblChangeBaseAssignment_LinkClicked(sender As Object, e As EventArgs) Handles llblChangeBaseAssignment.LinkClicked
        Try

            'If olvAssignments.SelectedObject Is Nothing Then
            If olvNormalAssignments.SelectedObject Is Nothing Then
                MessageBox.Show("Please select an assignment to reassign.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- Change normal assignment
                Using frm As New BaseAssignmentSelector(m_student.SchoolClass.ClassGroup)
                    If frm.ShowDialog = DialogResult.OK Then
                        Application.DoEvents()
                        Dim asmt As StudentAssignment = CType(olvNormalAssignments.SelectedObject, StudentAssignment)
                        asmt.BaseAssignment = frm.SelectedAssignment
                    End If
                End Using
                LoadAssignments()
            End If
            'Else
            ''-- Move BTEC Assignment
            ''-- select new student to transfer to
            'Using frm As New StudentSelector()
            '    If frm.ShowDialog = DialogResult.OK Then
            '        Application.DoEvents()
            '        Dim newStudent As Student = frm.SelectedStudent
            '        If newStudent IsNot Nothing Then
            '            Dim asmt As StudentAssignmentBTEC = CType(olvAssignments.SelectedObject, StudentAssignmentBTEC)
            '            asmt.Student = newStudent
            '            newStudent.AssignmentsBTEC.Add(asmt)
            '            m_student.AssignmentsBTEC.Remove(asmt)
            '            olvAssignments.RemoveObject(asmt)
            '        End If
            '    End If
            'End Using
            LoadAssignments()
            'End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
