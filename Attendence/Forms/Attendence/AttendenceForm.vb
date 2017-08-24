Public Class AttendenceForm

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
            AppSettings.AttendanceFormStudentListViewState = olvStudents.SaveState()
            ClosePublic()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub
   
    Private Sub AttendenceForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtSessionDate.Text = Date.Today

        Me.olvStudents.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf MainRowFormatter)

        olvStudents.RestoreState(AppSettings.AttendanceFormStudentListViewState)

        SetupForLiteVersion()
    End Sub
    ''' <summary>
    ''' Removes some features for Lite (free) version
    ''' </summary>
    Private Sub SetupForLiteVersion()
        Try
            If Not AppSettings.PremiumFeaturesEnabled Then
                AllStudentsExcusedToolStripMenuItem.Visible = False
                AllStudentsPresentToolStripMenuItem.Visible = False
                AllStuentsAbsentToolStripMenuItem.Visible = False
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub
    Private Function MainRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim stud As Student = CType(olvi.RowObject, Student)

        Dim HIGHLIGHT_COLOR_1 As Color = Color.LightGreen
        Dim HIGHLIGHT_COLOR_2 As Color = Color.LightSalmon
        Dim NORMAL_COLOR As Color = Color.White
        Dim newColor As Color

        If AppSettings.HighlightAttendanceUnknownGender Then
            Select Case stud.Gender
                Case Student.GenderEnum.Unknown
                    newColor = NORMAL_COLOR
                Case Student.GenderEnum.Male
                    newColor = HIGHLIGHT_COLOR_1
                Case Student.GenderEnum.Female
                    newColor = HIGHLIGHT_COLOR_2
            End Select
        ElseIf AppSettings.HighlightAttendanceNoPresentationQuality Then
            If stud.PresentationQuality >= 4 Then
                newColor = HIGHLIGHT_COLOR_1 '-- passable students
            ElseIf stud.PresentationQuality > 0 Then
                newColor = HIGHLIGHT_COLOR_2 '-- very weak students
            Else
                newColor = NORMAL_COLOR '-- unknown
            End If
        End If

        If stud IsNot Nothing AndAlso (AppSettings.HighlightAttendanceUnknownGender OrElse AppSettings.HighlightAttendanceNoPresentationQuality) Then
            olvi.BackColor = newColor
            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).BackColor = newColor
            Next
        End If
    End Function
    Private Sub SetStudentCountLabel()
        Dim intStudents As Integer
        For Each Student As Student In m_class.Students
            If Student.CurrentAttendenceStatus = AttendanceStatusEnum.Late OrElse Student.CurrentAttendenceStatus = AttendanceStatusEnum.Present Then
                intStudents += 1
            End If
        Next

        lblStudentsPresent.Text = intStudents.ToString("#,##0") & " of " & olvStudents.Items.Count.ToString("#,##0")
    End Sub
    Private Sub BackupOneStudent()
        If olvStudents.SelectedIndex < 1 Then
            olvStudents.SelectedIndex = 1
        End If

        Dim obj As Student = CType(olvStudents.SelectedObject, Student)
        olvStudents.RefreshObject(obj)
        If olvStudents.SelectedIndex > 0 Then
            olvStudents.SelectedIndex -= 1
        End If
        m_boolDirty = True

        If m_frmPublic IsNot Nothing Then
            m_frmPublic.UpdateStudent(obj)
        End If
    End Sub
    Private Sub SetStudentStatus(status As AttendanceStatusEnum)
        If olvStudents.SelectedIndex = -1 Then
            olvStudents.SelectedIndex = 0
        End If

        Dim obj As Student = CType(olvStudents.SelectedObject, Student)
        obj.CurrentAttendenceStatus = status
        olvStudents.RefreshObject(obj)
        If olvStudents.SelectedIndex < olvStudents.Items.Count - 1 Then
            olvStudents.SelectedIndex += 1
        End If
        m_boolDirty = True

        If m_frmPublic IsNot Nothing Then
            m_frmPublic.UpdateStudent(obj)
        End If
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
    Private Sub SaveSessionStatuses()
        Try
            Dim dtSessionDate As Date = Date.Parse(txtSessionDate.Text)

            '-- Create new class session for each student
            Dim lstStudents As List(Of Student) = olvStudents.Objects
            For Each stu In lstStudents
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

    Private Sub SaveAndCloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAndCloseToolStripMenuItem.Click
        SaveSessionStatuses()
        Close()
    End Sub

    Private Sub tmrStudentCount_Tick(sender As System.Object, e As System.EventArgs) Handles tmrStudentCount.Tick
        SetStudentCountLabel()
    End Sub

    Private Sub olvStudents_CellEditValidating(sender As Object, e As BrightIdeasSoftware.CellEditEventArgs) Handles olvStudents.CellEditValidating
        m_boolDirty = True
    End Sub

    Private Sub olvStudents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles olvStudents.SelectedIndexChanged
        If olvStudents.SelectedIndex >= 0 Then
            'olvStudents.EnsureVisible(olvStudents.SelectedIndex)
            olvStudents.TopItemIndex = olvStudents.SelectedIndex
            If m_frmPublic IsNot Nothing Then
                'm_frmPublic.CurrentStudent = olvStudents.SelectedIndex
                m_frmPublic.CurrentStudentObject = CType(olvStudents.SelectedObject, Student)
            End If
        End If
    End Sub

    Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged
        tmrFilterStudents.Stop()
        tmrFilterStudents.Start()
    End Sub

    Private Sub tmrFilterStudents_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFilterStudents.Tick
        FilterStudents()
    End Sub
    Private Sub FilterStudents()
        Try
            tmrFilterStudents.Stop()

            olvStudents.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(olvStudents, txtFilter.Text)

            If txtFilter.Text.Length = 0 Then
                olvStudents.EmptyListMsg = "This class is empty"
            Else
                olvStudents.EmptyListMsg = "No students match your filter"
            End If

            If m_frmPublic IsNot Nothing Then
                m_frmPublic.SetModelFilter(olvStudents.ModelFilter)
            End If

        Catch ex As Exception
            MessageBox.Show("There was an error filtering students: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        txtFilter.Text = String.Empty
        olvStudents.ModelFilter = Nothing
    End Sub

    Private Sub olvStudents_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles olvStudents.KeyDown
        If e.KeyCode = Keys.Up Then
            olvStudents.SelectedIndex -= 1
            e.Handled = True
        ElseIf e.KeyCode = Keys.Down Then
            olvStudents.SelectedIndex += 1
            e.Handled = True
        End If
    End Sub

    Public Class OnlyVisibleStudents
        Implements BrightIdeasSoftware.IModelFilter

        Public Function Filter(modelObject As Object) As Boolean Implements BrightIdeasSoftware.IModelFilter.Filter
            Return Not CType(modelObject, Student).Hidden
        End Function
    End Class
    Private Sub tmrFilterHiddenStudents_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFilterHiddenStudents.Tick
        tmrFilterHiddenStudents.Stop()
        If Not AppSettings.ShowHiddenStudents Then
            olvStudents.ModelFilter = New OnlyVisibleStudents()
            If olvStudents.Objects IsNot Nothing Then
                For Each stud As Student In olvStudents.Objects
                    If stud.Hidden Then
                        stud.CurrentAttendenceStatus = AttendanceStatusEnum.Absent
                    End If
                Next
            End If
        End If
    End Sub

    Private m_frmPublic As AttendencePublic
    Private Sub PublicToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PublicToolStripMenuItem.Click
        If m_frmPublic Is Nothing Then
            m_frmPublic = New AttendencePublic(m_lstStudents)
            m_frmPublic.Show()
            tmrPublicFilter.Start()
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

    Private Sub olvStudents_AfterSorting(sender As System.Object, e As BrightIdeasSoftware.AfterSortingEventArgs) Handles olvStudents.AfterSorting
        If m_frmPublic IsNot Nothing Then
            m_frmPublic.SortOrder = Me.olvStudents.PrimarySortOrder
            If Me.olvStudents.PrimarySortColumn IsNot Nothing Then
                m_frmPublic.SortColumn = Me.olvStudents.PrimarySortColumn.Index
            End If
        End If
    End Sub

    Private Sub ReloadStudentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReloadStudentsToolStripMenuItem.Click
        m_lstStudents = New List(Of Student)
        For Each stud As Student In m_class.Students
            If m_intStudentGroup = 0 OrElse stud.StudentGroup = m_intStudentGroup Then
                m_lstStudents.Add(stud)
            End If
        Next
        olvStudents.SetObjects(m_lstStudents)
        PublicToolStripMenuItem.Enabled = True
        SetStudentCountLabel()
        Application.DoEvents()
        AutoSizeColumns(olvStudents)
    End Sub

    Private Sub AttendenceForm_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If AppSettings.AttendanceWindowMaximized Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AttendenceForm_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '-- These keycodes support PowerPoint remote 'clickers'
        Select Case e.KeyCode
            Case Keys.Next
                '-- present
                SetStudentStatus(AttendanceStatusEnum.Present)
                e.Handled = True
            Case Keys.OemPeriod
                '-- absent
                SetStudentStatus(AttendanceStatusEnum.Absent)
                e.Handled = True
            Case Keys.F5
                '-- late
                SetStudentStatus(AttendanceStatusEnum.Late)
                e.Handled = True
            Case Keys.PageUp
                '-- Go up / back one student
                BackupOneStudent()
                e.Handled = True
        End Select
    End Sub

    Private Sub PresentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Presentation1ToolStripMenuItem.Click, Presentation9ToolStripMenuItem.Click, Presentation8ToolStripMenuItem.Click, Presentation7ToolStripMenuItem.Click, Presentation6ToolStripMenuItem.Click, Presentation5ToolStripMenuItem.Click, Presentation4ToolStripMenuItem.Click, Presentation3ToolStripMenuItem.Click, Presentation2ToolStripMenuItem.Click
        Try
            Dim item As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim intNewQuality As Integer = ConvertToInt32(item.Text.Substring(item.Text.Length - 1), 0)

            Dim stud As Student = olvStudents.SelectedObject()
            stud.PresentationQuality = intNewQuality
            olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            Log(ex)
        End Try

    End Sub

    Private Sub SetGendermaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGendermaleToolStripMenuItem.Click
        Try
            Dim stud As Student = olvStudents.SelectedObject()
            stud.Gender = Student.GenderEnum.Male
            olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub SetGenderfemaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGenderfemaleToolStripMenuItem.Click
        Try
            Dim stud As Student = olvStudents.SelectedObject()
            stud.Gender = Student.GenderEnum.Female
            olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub SetGenderUnknownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGenderUnknownToolStripMenuItem.Click
        Try
            Dim stud As Student = olvStudents.SelectedObject()
            stud.Gender = Student.GenderEnum.Unknown
            olvStudents.RefreshSelectedObjects()
        Catch ex As Exception
            Log(ex)
        End Try

    End Sub


    Private Sub tmrPublicFilter_Tick(sender As Object, e As EventArgs) Handles tmrPublicFilter.Tick
        tmrPublicFilter.Stop()
        If m_frmPublic IsNot Nothing Then
            m_frmPublic.SetModelFilter(olvStudents.ModelFilter)
        End If

    End Sub

    Private Sub txtStudentGroup_TextChanged(sender As Object, e As EventArgs) Handles txtStudentGroup.TextChanged
        m_intStudentGroup = ConvertToInt32(txtStudentGroup.Text, 0)
    End Sub

    Private Sub ExcusedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcusedToolStripMenuItem.Click
        SetStudentStatus(AttendanceStatusEnum.Excused)
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
            For Each stud As Student In olvStudents.Objects
                stud.CurrentAttendenceStatus = status
                olvStudents.RefreshObject(stud)

                If m_frmPublic IsNot Nothing Then
                    m_frmPublic.UpdateStudent(stud)
                End If

                Application.DoEvents()
            Next
            m_boolDirty = True

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error marking all students: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub olvStudents_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles olvStudents.ColumnClick
        '-- When changing the sort, change public form's sorder too
        If m_frmPublic IsNot Nothing Then
            m_frmPublic.SortColumn = e.Column
        End If
    End Sub

    Private Sub IncreaseFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseFontToolStripMenuItem.Click
        Dim newFont As Font = New Font(olvStudents.Font.FontFamily, olvStudents.Font.Size + 4)
        olvStudents.Font = newFont
    End Sub

    Private Sub DecreaseFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseFontToolStripMenuItem.Click
        Dim newFont As Font = New Font(olvStudents.Font.FontFamily, olvStudents.Font.Size - 4)
        olvStudents.Font = newFont
    End Sub

End Class
