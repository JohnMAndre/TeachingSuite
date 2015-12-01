Public Class StudentDetail

    Private m_student As Student
    Private m_class As SchoolClass

    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
        rtbLog.AppendText("Student added: " & Date.Now.ToString(DATE_TIME_FORMAT_DETAIL))
    End Sub
    Public Sub New(student As Student)

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

        m_student = student

        LoadSessionList()
    End Sub
    Private Sub StudentDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.olvOutcomes.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf MainRowFormatter)

        LoadSessionList()
        LoadOutcomes()
        LoadAssignments()
        ShowSessions()

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

    End Sub
    Private Function MainRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim ocrslt As OutcomeResult = CType(olvi.RowObject, OutcomeResult)

        Dim PASS_COLOR As Color = Color.LightGreen
        Dim FAIL_COLOR As Color = Color.LightSalmon
        Dim UNKNOWN_COLOR As Color = Color.White
        Dim newColor As Color

        If ocrslt.FirstTryStatus = OutcomeResultStatusEnum.Pass OrElse _
            ocrslt.SecondTryStatus = OutcomeResultStatusEnum.Pass OrElse _
            ocrslt.ThirdTryStatus = OutcomeResultStatusEnum.Pass Then
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
    Private Sub LoadSessionList()
        If m_student IsNot Nothing Then
            olvTeachingSessions.SetObjects(m_student.TeachingSessions)
        End If
    End Sub
    Private Sub LoadAssignments()
        If m_student IsNot Nothing Then
            olvAssignments.SetObjects(m_student.AssignmentsBTEC)
        End If
    End Sub
    Private Sub LoadOutcomes()
        If m_student IsNot Nothing Then
            '-- First load outcomes
            Dim lst As New List(Of OutcomeResult)
            'Dim boolM1, boolM2, boolM3, boolD1, boolD2, boolD3 As Boolean

            For Each asmt As StudentAssignmentBTEC In m_student.AssignmentsBTEC
                If asmt.M1Achieved Then
                    chkM1.Checked = True
                End If
                If asmt.M2Achieved Then
                    chkM2.Checked = True
                End If
                If asmt.M3Achieved Then
                    chkM3.Checked = True
                End If
                llblMeritAwarded.Visible = chkM1.Checked AndAlso chkM2.Checked AndAlso chkM3.Checked

                If asmt.D1Achieved Then
                    chkD1.Checked = True
                End If
                If asmt.D2Achieved Then
                    chkD2.Checked = True
                End If
                If asmt.D3Achieved Then
                    chkD3.Checked = True
                End If
                llblDistinctionAwarded.Visible = chkD1.Checked AndAlso chkD2.Checked AndAlso chkD3.Checked

                For Each rslt As OutcomeResult In asmt.Outcomes
                    lst.Add(rslt)
                Next
            Next

            '-- Now load M/D

            olvOutcomes.SetObjects(lst)
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
    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If m_student Is Nothing Then
            AddNewStudent()
        End If

        m_student.LocalName = txtLocalName.Text
        m_student.Nickname = txtNickName.Text
        m_student.StudentID = txtStudentID.Text
        m_student.ExtStudentID = txtExtStudentID.Text
        m_student.AdminNumber = nudAdminNumber.Value
        m_student.AltNumber = nudAltNumber.Value
        m_student.Notes = rtbNotes.Text
        m_student.Hidden = chkHidden.Checked
        m_student.PresentationQuality = nudPresentationQuality.Value
        m_student.EmailAddress = txtEmail.Text.Trim()
        m_student.PlagiarismSeverity = nudPlagiarismSeverity.Value
        m_student.WritingQuality = nudWritingQuality.Value
        'm_student.ActivityLog = rtbLog.Text

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub llblAddSession_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddSession.LinkClicked
        If m_student Is Nothing Then
            AddNewStudent()
        End If

        Dim session As New TeachingSession()
        session.StartDate = Date.Today
        session.AttendenceStatus = AttendenceStatusEnum.Present
        m_student.TeachingSessions.Add(session)
        LoadSessionList()
    End Sub

    Private Sub llblRemoveSession_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveSession.LinkClicked
        If olvTeachingSessions.SelectedObject Is Nothing Then
            MessageBox.Show("Please select a sesson entry to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            m_student.TeachingSessions.Remove(olvTeachingSessions.SelectedObject)
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

                If m_student.TeachingSessions(intCounter).AttendenceStatus = AttendenceStatusEnum.Absent Then
                    m_student.TeachingSessions(intCounter).AttendenceStatus = AttendenceStatusEnum.Excused
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
        rtbNotes.BringToFront()
        pbButtonHighlight.Location = New Point(99, 127)
    End Sub
    Private Sub ShowLog()
        pnlAttendance.Hide()
        pnlAssignments.Hide()
        rtbLog.Show()
        rtbLog.BringToFront()
        pbButtonHighlight.Location = New Point(149, 127)
    End Sub
    Private Sub ShowOutcomes()
        pnlAttendance.Hide()
        pnlAssignments.Hide()
        pnlOutcomes.Show()
        pnlOutcomes.BringToFront()
        pbButtonHighlight.Location = New Point(5, 127)
    End Sub
    Private Sub ShowAssignments()
        pnlAttendance.Hide()
        pnlAssignments.Show()
        olvAssignments.Show()
        olvAssignments.BringToFront()
        pbButtonHighlight.Location = New Point(200, 127)
    End Sub
    Private Sub ShowSessions()
        pnlAttendance.Show()
        pnlAssignments.Hide()
        pnlAttendance.BringToFront()
        olvTeachingSessions.Show()
        olvTeachingSessions.BringToFront()
        pbButtonHighlight.Location = New Point(51, 127)
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
            MessageBox.Show("Please select an assignment to move.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
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
End Class
