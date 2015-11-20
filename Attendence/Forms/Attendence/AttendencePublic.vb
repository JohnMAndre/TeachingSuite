Public Class AttendencePublic

    Private m_boolUseNickname As Boolean
    Private m_lstStudents As List(Of Student)

    Public Sub New(students As List(Of Student), useNickname As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        olvStudents.SetObjects(students)

        m_boolUseNickname = useNickname
        m_lstStudents = students
    End Sub

    Private m_objCurrentStudent As Student
    Public Property CurrentStudentObject As Student
        Get
            Return m_objCurrentStudent
        End Get
        Set(value As Student)
            If value IsNot Nothing Then
                m_objCurrentStudent = value
            Else
                m_objCurrentStudent = Nothing
            End If

            UpdateStudentObject(m_objCurrentStudent)

        End Set
    End Property
    Private m_intCurrentStudent As Integer
    Public Property CurrentStudent As Integer
        Get
            Return m_intCurrentStudent
        End Get
        Set(value As Integer)
            m_intCurrentStudent = value
            If value > -1 Then
                '-- highlight
                Me.Text = m_intCurrentStudent.ToString
                UpdateStudent(m_lstStudents(m_intCurrentStudent))
            End If
        End Set
    End Property
    Public WriteOnly Property SortColumn As Integer
        Set(value As Integer)
            Me.olvStudents.Sort(value)
        End Set
    End Property
    Public WriteOnly Property SortOrder As SortOrder
        Set(value As SortOrder)
            Me.olvStudents.PrimarySortOrder = value
        End Set
    End Property
    Public Sub UpdateStudent(stud As Student)
        olvStudents.RefreshObject(stud)
        'olvStudents.EnsureVisible(CurrentStudent)
        If CurrentStudent > 10 Then
            olvStudents.TopItemIndex = CurrentStudent - (olvStudents.RowsPerPage / 2) '-- put current student in middle of the page
        End If
    End Sub
    Public Sub UpdateStudentObject(stud As Student)
        olvStudents.RefreshObject(stud)
        Dim lvi As ListViewItem = olvStudents.ModelToItem(stud)
        olvStudents.EnsureVisible(lvi.Index)
        If lvi.Index > 10 Then
            olvStudents.TopItemIndex = lvi.Index - (olvStudents.RowsPerPage / 2) '-- put current student in middle of the page
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'AutoSizeColumns(olvStudents)
        lblClock.Text = "Current time: " & Date.Now.ToString("HH:mm")
    End Sub
    Private Function MainRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim student As Student = CType(olvi.RowObject, Student)

        Dim ABSENT_COLOR As Color = Color.Red
        Dim PRESENT_COLOR As Color = Color.Green
        Dim UNKNOWN_COLOR As Color = Color.Black
        Dim OTHER_COLOR As Color = Color.Blue

        Dim intPositionStatus As Integer = Me.olvStudents.Columns.IndexOf(Me.olvColumnStatus)

        Dim newForeColor As Color

        If student IsNot Nothing Then
            Select Case student.CurrentAttendenceStatus
                Case AttendenceStatusEnum.Absent
                    newForeColor = ABSENT_COLOR
                Case AttendenceStatusEnum.Present
                    newForeColor = PRESENT_COLOR
                Case AttendenceStatusEnum.Unknown
                    newForeColor = UNKNOWN_COLOR
                Case Else
                    newForeColor = OTHER_COLOR
            End Select


            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).ForeColor = newForeColor
            Next
        End If

        Dim lvi As ListViewItem = olvStudents.ModelToItem(student)

        'If lvi IsNot Nothing Then
        '    If lvi.Index = m_intCurrentStudent Then
        '        olvi.ForeColor = Color.Black
        '        olvi.BackColor = Color.Yellow
        '    Else
        '        'olvi.ForeColor = Color.Black
        '        olvi.BackColor = Color.White
        '    End If
        'End If
        If lvi IsNot Nothing Then
            If student Is m_objCurrentStudent Then
                olvi.ForeColor = Color.Black
                olvi.BackColor = Color.Yellow
            Else
                'olvi.ForeColor = Color.Black
                olvi.BackColor = Color.White
            End If
        End If

    End Function

    Private Sub AttendencePublic_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.olvStudents.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf MainRowFormatter)
        Catch ex As Exception
            Application.DoEvents()
        End Try
    End Sub

    Private Sub AttendencePublic_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        'AutoSizeColumns(Me.olvStudents)

    End Sub

    Private Sub AttendencePublic_Shown(sender As Object, e As System.EventArgs) Handles MyBase.Shown
        Try
            If m_boolUseNickname Then
                olvcolLocalName.DisplayIndex = olvStudents.Columns.Count - 1
            Else
                olvcolNickname.DisplayIndex = olvStudents.Columns.Count - 1
            End If

            '-- If we have multiple screens, then project public form on 'other' screen
            If Screen.AllScreens.Count > 0 Then
                For Each scrn As Screen In Screen.AllScreens
                    If Not scrn.Primary Then
                        '-- use first non-primary screen
                        Me.Location = scrn.Bounds.Location
                        Me.WindowState = FormWindowState.Maximized
                    End If
                Next
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub
    Public Class OnlyVisibleStudents
        Implements BrightIdeasSoftware.IModelFilter

        Public Function Filter(modelObject As Object) As Boolean Implements BrightIdeasSoftware.IModelFilter.Filter
            Return Not CType(modelObject, Student).Hidden
        End Function
    End Class
    Public Sub SetModelFilter(modelFilter As BrightIdeasSoftware.IModelFilter)
        'olvStudents.ModelFilter = modelFilter
        'olvStudents.RefreshObjects(olvStudents.Objects)
    End Sub

    Private Sub tmrFilterHiddenStudents_Tick(sender As Object, e As EventArgs) Handles tmrFilterHiddenStudents.Tick
        tmrFilterHiddenStudents.Stop()
        If Not AppSettings.ShowHiddenStudents Then
            olvStudents.ModelFilter = New OnlyVisibleStudents()
        End If
    End Sub
End Class
