Public Class GroupPresentationAssessment

    Private sw As Stopwatch
    Private m_lstStudents As List(Of Student)
    Private m_asmt As ClassAssignment
    Private m_try As Semester.MarkingTry

    Public Sub New(studentList As List(Of Student), asmt As ClassAssignment, attempt As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_lstStudents = studentList
        m_asmt = asmt
        m_try = attempt

    End Sub
    Public Sub LoadStudent(stud As Student, asmt As ClassAssignment, attempt As Semester.MarkingTry, controlSize As Size)
        Dim ctl As New IndividualMarkInGroupPresentation()
        ctl.Size = controlSize
        Me.FlowLayoutPanel1.Controls.Add(ctl)
        ctl.LoadStudent(stud, asmt, attempt)
        ctl.BackColor = Color.White
        AddHandler ctl.RequestRemoval, AddressOf Student_RequestRemoval
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For Each ctl As IndividualMarkInGroupPresentation In Me.FlowLayoutPanel1.Controls
                ctl.Save()
            Next

            MainFormReference.AutoSave()

            Close()
        Catch ex As Exception
            MessageBox.Show("There was an error saving: " & ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = sw.Elapsed.ToString("m\:ss")
    End Sub

    Private Sub GroupPresentationAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        sw = Stopwatch.StartNew()
    End Sub

    Private Sub GroupPresentationAssessment_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd
        ReArrangeControls()
    End Sub

    Private Sub GroupPresentationAssessment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            'Dim intBoarderSpace As Integer = 8
            'Dim intHeight As Integer
            'Dim intWidth As Integer

            '-- 
            'Me.HorizontalScroll.Visible = False
            'Me.VerticalScroll.Value = False
            'Select Case m_lstStudents.Count
            '    Case 0
            '        '-- nobody in this group? This should never happen
            '        Me.Text = "Group is empty"
            '    Case 1
            '        intHeight = (Me.FlowLayoutPanel1.ClientSize.Height - (intBoarderSpace * 5))  '-- full verticle
            '        intWidth = (Me.FlowLayoutPanel1.ClientSize.Width - (intBoarderSpace * 5)) '-- full horizontal
            '    Case 2
            '        '-- special case for just two. Here take up full vertical and 1/2 horizontal
            '        intHeight = (Me.FlowLayoutPanel1.ClientSize.Height - (intBoarderSpace * 3))   '-- full verticle
            '        intWidth = (Me.FlowLayoutPanel1.ClientSize.Width / 2) - (intBoarderSpace * 3) '-- not more than 2 wide
            '    Case 3, 4
            '        '-- this should be the norm - either 3 or 4 team members
            '        '   for 4, the controls should exactly take up all the space of the flowcontrol's client area
            '        intHeight = (Me.FlowLayoutPanel1.ClientSize.Height / 2) - (intBoarderSpace * 3) '-- do not worry about more than 2 high
            '        intWidth = (Me.FlowLayoutPanel1.ClientSize.Width / 2) - (intBoarderSpace * 3) '-- not more than 2 wide
            '    Case Else
            '        '-- Need to shrink the height of each control a bit
            '        '   so user can easily see that there are more than 4 controls
            '        Me.VerticalScroll.Value = True
            '        intHeight = (Me.FlowLayoutPanel1.ClientSize.Height - (intBoarderSpace * 2)) / 2 '-- slightly less high so user can see they need to scroll
            '        intWidth = (Me.FlowLayoutPanel1.ClientSize.Width - intBoarderSpace) / 2 '-- not more than 2 wide

            'End Select

            'Dim sz As New Size(intWidth, intHeight)
            Dim sz As New Size(100, 100)


            For Each stud In m_lstStudents
                LoadStudent(stud, m_asmt, m_try, sz)
            Next

            ReArrangeControls()

            If m_lstStudents.Count > 0 Then
                Me.Text &= " - " & m_lstStudents(0).StudentTeam & " - " & m_asmt.Name
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error resizing: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btnSaveAllKeepOpen_Click(sender As Object, e As EventArgs) Handles btnSaveAllKeepOpen.Click
        Try
            For Each ctl As IndividualMarkInGroupPresentation In Me.FlowLayoutPanel1.Controls
                ctl.Save()
            Next

            MainFormReference.AutoSave()
        Catch ex As Exception
            MessageBox.Show("There was an error saving: " & ex.Message)
        End Try
    End Sub
    Private Sub Student_RequestRemoval(sender As IndividualMarkInGroupPresentation)
        '-- remove and re-arrange
        For Each ctl As IndividualMarkInGroupPresentation In Me.FlowLayoutPanel1.Controls
            If ctl Is sender Then
                Me.FlowLayoutPanel1.Controls.Remove(ctl)
                Exit For
            End If
        Next

        ReArrangeControls()
    End Sub
    Private Sub ReArrangeControls()
        Dim intBoarderSpace As Integer = 8
        Dim intHeight As Integer
        Dim intWidth As Integer

        Select Case Me.FlowLayoutPanel1.Controls.Count
            Case 0
                '-- nobody in this group? This should never happen
                Me.Text = "Group is empty"
            Case 1
                intHeight = (Me.FlowLayoutPanel1.ClientSize.Height - (intBoarderSpace * 5))  '-- full verticle
                intWidth = (Me.FlowLayoutPanel1.ClientSize.Width - (intBoarderSpace * 5)) '-- full horizontal
            Case 2
                '-- special case for just two. Here take up full vertical and 1/2 horizontal
                intHeight = (Me.FlowLayoutPanel1.ClientSize.Height - (intBoarderSpace * 3))   '-- full verticle
                intWidth = (Me.FlowLayoutPanel1.ClientSize.Width / 2) - (intBoarderSpace * 3) '-- not more than 2 wide
            Case 3, 4
                '-- this should be the norm - either 3 or 4 team members
                '   for 4, the controls should exactly take up all the space of the flowcontrol's client area
                intHeight = (Me.FlowLayoutPanel1.ClientSize.Height / 2) - (intBoarderSpace * 2) '-- do not worry about more than 2 high
                intWidth = (Me.FlowLayoutPanel1.ClientSize.Width / 2) - (intBoarderSpace * 2) '-- not more than 2 wide
            Case Else
                '-- Need to shrink the height of each control a bit
                '   so user can easily see that there are more than 4 controls
                intHeight = (Me.FlowLayoutPanel1.ClientSize.Height - (intBoarderSpace * 2)) / 2 '-- slightly less high so user can see they need to scroll
                intWidth = (Me.FlowLayoutPanel1.ClientSize.Width - intBoarderSpace) / 2 '-- not more than 2 wide
        End Select

        Dim sz As New Size(intWidth, intHeight)

        For Each ctl As IndividualMarkInGroupPresentation In Me.FlowLayoutPanel1.Controls
            ctl.Size = sz
        Next


    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click
        ReArrangeControls()
    End Sub
End Class