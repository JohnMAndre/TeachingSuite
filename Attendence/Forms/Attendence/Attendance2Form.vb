Public Class Attendance2Form

    Private Class StudentAttendanceData
        Public Sub New(student As Student)
            Me.Student = student
        End Sub
        Public Property Student As Student
        Public Property AttendanceStatus As AttendanceStatusEnum
        Public Property SeatedInRow As Integer
        Public ReadOnly Property AdminNumber As Integer
            Get
                Return Student.AdminNumber
            End Get
        End Property
        Public ReadOnly Property LocalName As String
            Get
                Return Student.LocalName
            End Get
        End Property
        Public Property Nickname As String
            Get
                Return Student.Nickname
            End Get
            Set(value As String)
                Student.Nickname = value
            End Set
        End Property
        Public ReadOnly Property StudentID As String
            Get
                Return Student.StudentID
            End Get
        End Property
        Public ReadOnly Property CurrentAbsences As Integer
            Get
                Return Student.CurrentAbsences
            End Get
        End Property
        Public Property Hidden As Boolean
            Get
                Return Student.Hidden
            End Get
            Set(value As Boolean)
                Student.Hidden = value
            End Set
        End Property
    End Class
    Private Class StudentComparerByTempTag
        Implements IComparer(Of StudentAttendanceData)

        Public Function Compare(x As StudentAttendanceData, y As StudentAttendanceData) As Integer Implements IComparer(Of StudentAttendanceData).Compare
            Return x.Student.TempTag.CompareTo(y.Student.TempTag)
        End Function
    End Class


    Private m_class As SchoolClass
    Private m_boolDirty As Boolean
    Private m_intStudentGroup As Integer
    Private m_lstStudents As List(Of StudentAttendanceData)

    Private m_dtStartTime As Date
    Private m_font As Font
    Private m_tsCurrent As TimeSpan


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
        m_dtStartTime = item.StartDateTime

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
            For Each stu As StudentAttendanceData In m_lstStudents
                If stu.AttendanceStatus <> AttendanceStatusEnum.Unknown Then
                    Dim session As New TeachingSession(stu.Student)
                    session.StartDate = dtSessionDate
                    session.AttendenceStatus = stu.AttendanceStatus
                    session.SeatedInRow = stu.SeatedInRow
                    stu.Student.TeachingSessions.Add(session)
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
        LoadStudents(True)
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
        dgvStudents.RowTemplate.Height += 8
    End Sub

    Private Sub DecreaseFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseFontToolStripMenuItem.Click
        Dim newFont As Font = New Font(dgvStudents.Font.FontFamily, dgvStudents.Font.Size - 4)
        dgvStudents.Font = newFont
        dgvStudents.RowTemplate.Height -= 8
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
    Private Function GetCurrentlySelectedStudent() As StudentAttendanceData
        Return CType(dgvStudents.CurrentRow.DataBoundItem, StudentAttendanceData)
    End Function

    Private Sub SetStudentStatus(status As AttendanceStatusEnum, Optional SeatedInRow As Integer = 0)
        If dgvStudents.SelectedRows.Count = 0 Then
            'dgvStudents.SelectedIndex = 0
            Exit Sub
        End If

        Dim obj As StudentAttendanceData = GetCurrentlySelectedStudent() 'CType(dgvStudents.CurrentRow.DataBoundItem, Student)
        obj.AttendanceStatus = status
        obj.SeatedInRow = SeatedInRow '-- Added 2018-11-16
        dgvStudents.UpdateCellValue(4, dgvStudents.CurrentRow.Index)

        Dim row As DataGridViewRow
        Dim intIndex As Integer = dgvStudents.CurrentRow.Index
        If intIndex > 2 Then
            dgvStudents.FirstDisplayedScrollingRowIndex = intIndex - 2 '-- last three processed are on top
        End If

        If dgvStudents.CurrentRow.Index <= m_lstStudents.Count - 1 Then
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

            Dim intCurrentIndex As Integer
            If dgvStudents.CurrentRow.Index = m_lstStudents.Count - 1 Then
                '-- Last row
                intCurrentIndex = intIndex - 1
            Else
                intCurrentIndex = intIndex + 1
            End If
            row = dgvStudents.Rows(intCurrentIndex)

            row.Selected = True
            dgvStudents.CurrentCell = dgvStudents.Rows(intCurrentIndex).Cells(0)
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
            For Each stud As StudentAttendanceData In m_lstStudents
                stud.AttendanceStatus = status

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
    Private Sub SetCurrentStudentGender(gender As Student.GenderEnum)
        Dim stud As StudentAttendanceData = GetCurrentlySelectedStudent() '
        stud.Student.Gender = gender
    End Sub
    Private Sub SetGendermaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGendermaleToolStripMenuItem.Click
        Try
            SetCurrentStudentGender(Student.GenderEnum.Male)
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub SetGenderfemaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGenderfemaleToolStripMenuItem.Click
        Try
            SetCurrentStudentGender(Student.GenderEnum.Female)
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub SetGenderUnknownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGenderUnknownToolStripMenuItem.Click
        Try
            SetCurrentStudentGender(Student.GenderEnum.Unknown)
        Catch ex As Exception
            Log(ex)
        End Try

    End Sub

    Private Sub EditCurrentStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCurrentStudentToolStripMenuItem.Click
        dgvStudents.CurrentCell = dgvStudents.Rows(dgvStudents.CurrentRow.Index).Cells(2)
        dgvStudents.BeginEdit(True)
    End Sub

    Private Sub dgvStudents_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvStudents.CellPainting
        If e.ColumnIndex = 4 Then
            If e.Value IsNot Nothing Then
                If e.Value.ToString() = AttendanceStatusEnum.Unknown.ToString() Then
                    e.CellStyle.ForeColor = e.CellStyle.BackColor
                    e.CellStyle.SelectionForeColor = e.CellStyle.SelectionBackColor
                End If
            End If
        End If
    End Sub

    Private Sub dgvStudents_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvStudents.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.Handled = True '-- do not let enter go down a row
        End Select
    End Sub
    Private Sub txtStudentGroup_TextChanged(sender As Object, e As EventArgs) Handles txtStudentGroup.TextChanged
        m_intStudentGroup = ConvertToInt32(txtStudentGroup.Text, 0)
    End Sub

    Private Sub OverlayClockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverlayClockToolStripMenuItem.Click
        '-- Show countdown timer until class begins (per schedule)
        '   After class begins, timer hides and cannot be shown again
        If m_dtStartTime <> DATE_NO_DATE Then
            Dim ts As TimeSpan = m_dtStartTime - Date.Now
            If ts.TotalSeconds > 0 Then
                '-- Toggle visible
                If pbTimer.Visible Then
                    HideTimer()
                Else
                    ShowTimer()
                End If
            Else
                If IsNumeric(txtFilter.Text) Then
                    '-- Allow user to put in number of minutes in txtFilter
                    m_dtStartTime = Date.Now.AddMinutes(ConvertToInt32(txtFilter.Text, 5))
                    ShowTimer()
                Else
                    HideTimer()
                End If
            End If
        Else
            If IsNumeric(txtFilter.Text) Then
                '-- Allow user to put in number of minutes in txtFilter
                m_dtStartTime = Date.Now.AddMinutes(ConvertToInt32(txtFilter.Text, 5))
                ShowTimer()
            Else
                HideTimer()
            End If
        End If
    End Sub

    Private Sub HideTimer()
        pbTimer.Visible = False
        tmrClock.Stop()
    End Sub
    Private Sub ShowTimer()
        pbTimer.Visible = True
        tmrClock.Start()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        If m_dtStartTime > Date.Now Then
            If pbTimer.Visible Then
                m_tsCurrent = m_dtStartTime - Date.Now
                Me.pbTimer.Invalidate()
            End If
        Else
            '-- Auto-hide at zero
            HideTimer()
        End If
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

    Private Sub LoadStudentsInTraditionalOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadStudentsInTraditionalOrderToolStripMenuItem.Click
        LoadStudents(False)
    End Sub
    Private Sub LoadStudents(random As Boolean)
        Try

            m_lstStudents = New List(Of StudentAttendanceData)
            Dim rnd As New Random()

            For Each stud As Student In m_class.Students
                If m_intStudentGroup = 0 OrElse stud.StudentGroup = m_intStudentGroup Then
                    m_lstStudents.Add(New StudentAttendanceData(stud))
                End If
                stud.TempTag = rnd.Next
            Next

            If random Then
                m_lstStudents.Sort(New StudentComparerByTempTag())
            End If

            dgvStudents.AutoGenerateColumns = False
            dgvStudents.DataSource = m_lstStudents
            PublicToolStripMenuItem.Enabled = True
            SetStudentCountLabel()
            Application.DoEvents()
            dgvStudents.AutoResizeColumns()
        Catch ex As Exception
            '-- ignore (likely just reloading too many times too quickly)
        End Try

    End Sub

    Private Sub PresentFrontRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentFrontRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 1)
    End Sub

    Private Sub PresentSecondRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentSecondRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 2)
    End Sub

    Private Sub PresentThirdRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentThirdRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 3)
    End Sub

    Private Sub PresentFourthRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentFourthRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 4)
    End Sub

    Private Sub PresentFifthRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentFifthRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 5)
    End Sub

    Private Sub PresentSixthRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentSixthRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 6)
    End Sub

    Private Sub PresentSeventhRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentSeventhRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 7)
    End Sub

    Private Sub PresentEighthRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentEighthRowToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 8)
    End Sub

    Private Sub PresentWayBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentWayBackToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Present, 9)
    End Sub

    Private Sub dgvStudents_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvStudents.RowPrePaint

    End Sub
End Class