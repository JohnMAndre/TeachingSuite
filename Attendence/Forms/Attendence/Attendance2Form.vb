Public Class Attendance2Form

    Private m_class As SchoolClass
    Private m_boolDirty As Boolean
    Private m_intStudentGroup As Integer
    Private m_lstStudents As List(Of Student)

    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
        txtStudentGroup.Text = 0
    End Sub
    ''' <summary>
    ''' Pass in an ActualSessionItem and only take attendence for students in that session (useful for workshop sessions)
    ''' </summary>
    ''' <param name="item"></param>
    ''' <remarks></remarks>
    Public Sub New(item As ActualSessionItem)

        ' This call is required by the designer.
        InitializeComponent()

        m_intStudentGroup = item.StudentGroup
        m_class = item.SchoolClass
        txtStudentGroup.Text = item.StudentGroup

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAndCloseToolStripMenuItem.Click
        SaveSessionStatuses()
        Close()
    End Sub

    Private Sub SaveSessionStatuses()
        Try
            Dim dtSessionDate As Date = Date.Parse(txtSessionDate.Text)

            '-- Create new class session for each student
            'Dim lstStudents As List(Of Student) = olvStudents.Objects
            For Each stu In m_lstStudents
                If stu.CurrentAttendenceStatus <> AttendanceStatusEnum.Unknown Then
                    Dim session As New TeachingSession(stu)
                    session.StartDate = dtSessionDate
                    session.AttendenceStatus = stu.CurrentAttendenceStatus
                    stu.TeachingSessions.Add(session)
                End If
            Next

            Dim objClassSession As New ClassSession()
            objClassSession.StartDate = dtSessionDate
            objClassSession.StudentGroup = ConvertToInt32(txtStudentGroup.Text, 0)
            m_class.ClassSessions.Add(objClassSession)

            m_boolDirty = False

            AddApplicationHistory("Recorded attendance (" & m_class.ToString() & ").")

            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ReloadStudentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReloadStudentsToolStripMenuItem.Click
        m_lstStudents = New List(Of Student)
        For Each stud As Student In m_class.Students
            If m_intStudentGroup = 0 OrElse stud.StudentGroup = m_intStudentGroup Then
                m_lstStudents.Add(stud)
            End If
        Next

        dgvStudents.AutoGenerateColumns = False
        dgvStudents.DataSource = m_lstStudents
        PublicToolStripMenuItem.Enabled = True
        SetStudentCountLabel()
        Application.DoEvents()
        dgvStudents.AutoResizeColumns()
    End Sub
    Private Sub SetStudentCountLabel()
        Dim intStudents As Integer
        For Each Student As Student In m_class.Students
            If Student.CurrentAttendenceStatus = AttendanceStatusEnum.Late OrElse Student.CurrentAttendenceStatus = AttendanceStatusEnum.Present Then
                intStudents += 1
            End If
        Next

        lblStudentsPresent.Text = intStudents.ToString("#,##0") & " of " & m_class.Students.Count.ToString("#,##0")
    End Sub
    Private Sub IncreaseFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseFontToolStripMenuItem.Click
        Dim newFont As Font = New Font(dgvStudents.Font.FontFamily, dgvStudents.Font.Size + 4)
        dgvStudents.Font = newFont
    End Sub

    Private Sub DecreaseFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseFontToolStripMenuItem.Click
        Dim newFont As Font = New Font(dgvStudents.Font.FontFamily, dgvStudents.Font.Size - 4)
        dgvStudents.Font = newFont
    End Sub
    Private Sub PresentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PresentToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present)
    End Sub

    Private Sub LateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LateToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Late)
    End Sub

    Private Sub RemovedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemovedToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Removed)
    End Sub

    Private Sub AbsentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbsentToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Absent)
    End Sub
    Private Sub ExcusedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcusedToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Excused)
    End Sub
    Private Function GetCurrentlySelectedStudent() As Student
        Return CType(dgvStudents.CurrentRow.DataBoundItem, Student)
    End Function

    Private Sub SetStudentStatus(status As AttendanceStatusEnum)
        If dgvStudents.SelectedRows.Count = 0 Then
            'dgvStudents.SelectedIndex = 0
            Exit Sub
        End If

        Dim obj As Student = GetCurrentlySelectedStudent() 'CType(dgvStudents.CurrentRow.DataBoundItem, Student)
        obj.CurrentAttendenceStatus = status
        dgvStudents.UpdateCellValue(4, dgvStudents.CurrentRow.Index)

        Dim row As DataGridViewRow
        Dim intIndex As Integer = dgvStudents.CurrentRow.Index
        dgvStudents.FirstDisplayedScrollingRowIndex = intIndex '-- last one processed is on top

        If dgvStudents.CurrentRow.Index < m_lstStudents.Count - 1 Then
            row = dgvStudents.Rows(intIndex)
            Dim style As New DataGridViewCellStyle(row.Cells(4).Style)
            Select Case status
                Case AttendanceStatusEnum.Present
                    style.BackColor = Color.LightGreen
                Case AttendanceStatusEnum.Absent
                    style.BackColor = Color.Pink
                Case AttendanceStatusEnum.Unknown
                    style.BackColor = Color.White
                Case AttendanceStatusEnum.Excused
                    style.BackColor = Color.Yellow
                Case AttendanceStatusEnum.Late
                    style.BackColor = Color.LightSkyBlue
            End Select
            For intCounter As Integer = 0 To 5
                row.Cells(intCounter).Style = style
            Next
            row.Selected = False
            row = dgvStudents.Rows(intIndex + 1)
            row.Selected = True
            dgvStudents.CurrentCell = dgvStudents.Rows(intIndex + 1).Cells(0)
        End If
        m_boolDirty = True

        'If m_frmPublic IsNot Nothing Then
        '    m_frmPublic.UpdateStudent(obj)
        'End If
    End Sub

    Private Sub Attendance2Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSessionDate.Text = Date.Today

        dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        dgvStudents.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Private Sub AllStudentsPresentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllStudentsPresentToolStripMenuItem.Click
        MarkAllStudents(AttendanceStatusEnum.Present)
    End Sub

    Private Sub AllStuentsAbsentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllStuentsAbsentToolStripMenuItem.Click
        MarkAllStudents(AttendanceStatusEnum.Absent)
    End Sub

    Private Sub AllStudentsExcusedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllStudentsExcusedToolStripMenuItem.Click
        MarkAllStudents(AttendanceStatusEnum.Excused)
    End Sub
    Private Sub MarkAllStudents(status As AttendanceStatusEnum)
        Try
            For Each stud As Student In m_lstStudents
                stud.CurrentAttendenceStatus = status

                'If m_frmPublic IsNot Nothing Then
                '    m_frmPublic.UpdateStudent(stud)
                'End If

                Application.DoEvents()
            Next

            For intCounter As Integer = 0 To m_lstStudents.Count - 1
                dgvStudents.UpdateCellValue(4, intCounter)
            Next
            m_boolDirty = True

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error marking all students: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub AttendenceForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If m_boolDirty Then
                Select Case MessageBox.Show("Do you want to save your changes?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    Case DialogResult.Yes
                        SaveSessionStatuses()
                    Case DialogResult.No
                        '-- just close
                    Case DialogResult.Cancel
                        e.Cancel = True
                End Select
            End If

            AppSettings.AttendanceWindowMaximized = WindowState = FormWindowState.Maximized
            ' ClosePublic()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub tmrStudentCount_Tick(sender As Object, e As EventArgs) Handles tmrStudentCount.Tick
        SetStudentCountLabel()
    End Sub
    Private Sub AttendenceForm_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If AppSettings.AttendanceWindowMaximized Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub SetGendermaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGendermaleToolStripMenuItem.Click
        Try
            Dim stud As Student = GetCurrentlySelectedStudent() '
            stud.Gender = Student.GenderEnum.Male
            'olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub SetGenderfemaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGenderfemaleToolStripMenuItem.Click
        Try
            Dim stud As Student = GetCurrentlySelectedStudent() '
            stud.Gender = Student.GenderEnum.Female
            'olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub SetGenderUnknownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGenderUnknownToolStripMenuItem.Click
        Try
            Dim stud As Student = GetCurrentlySelectedStudent()
            stud.Gender = Student.GenderEnum.Unknown
            'olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            Log(ex)
        End Try

    End Sub

End Class