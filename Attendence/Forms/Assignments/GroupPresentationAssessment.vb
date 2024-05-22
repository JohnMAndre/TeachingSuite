'Copyright 2011-2022 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Teaching Suite Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Teaching Suite.  If Not, see < https: //www.gnu.org/licenses/>.
Public Class GroupPresentationAssessment

    Private sw As Stopwatch
    Private m_lstStudents As List(Of Student)
    Private m_asmt As ClassAssignment
    Private m_try As Semester.MarkingTry
    Private m_frmQuickFeedback As GroupPresentationQuickFeedback

    Public Sub New(studentList As List(Of Student), asmt As ClassAssignment, attempt As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_lstStudents = studentList
        m_asmt = asmt
        m_try = attempt

        m_frmQuickFeedback = New GroupPresentationQuickFeedback With {
            .Location = Me.Location,
            .Height = Me.Height * 0.9,
            .Width = Me.Width * 0.9
        }
        Application.DoEvents()
    End Sub
    Public Sub LoadStudent(stud As Student, asmt As ClassAssignment, attempt As Semester.MarkingTry, controlSize As Size)
        Dim ctl As New IndividualMarkInGroupPresentation()
        ctl.Size = controlSize
        FlowLayoutPanel1.Controls.Add(ctl)
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
    Private Sub ReloadClosedStudents()
        Dim sz As New Size(100, 100)
        Dim boolLoadedAlready As Boolean
        For Each stud In m_lstStudents
            boolLoadedAlready = False
            For Each ctl As IndividualMarkInGroupPresentation In Me.FlowLayoutPanel1.Controls
                If ctl.txtStudentID.Text = stud.StudentID Then
                    boolLoadedAlready = True
                    Exit For
                End If
            Next

            '-- Load if not there already
            If Not boolLoadedAlready Then
                LoadStudent(stud, m_asmt, m_try, sz)
            End If
        Next



        ReArrangeControls()
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

    Private Sub picMoreInfo_Click(sender As Object, e As EventArgs) Handles picMoreInfo.Click
        Dim strMessage As String
        strMessage = "Pe = Performance level (current)" & Environment.NewLine
        strMessage &= "Pr = Performance level (previous)" & Environment.NewLine
        strMessage &= "D = Days since last included for this student" & Environment.NewLine
        strMessage &= "Q = Quantity, number of times given to this student" & Environment.NewLine
        strMessage &= "O = Checkbox to include when generating feedback."

        MessageBox.Show(strMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnReloadMissing_Click(sender As Object, e As EventArgs) Handles btnReloadMissing.Click
        ReloadClosedStudents()
    End Sub

    Private Sub GroupPresentationAssessment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        m_frmQuickFeedback.Close()
    End Sub

    Private Sub btnQuickFeedback_Click(sender As Object, e As EventArgs) Handles btnQuickFeedback.Click
        If m_frmQuickFeedback.Visible Then
            m_frmQuickFeedback.Hide()
        Else
            m_frmQuickFeedback.Location = Me.Location
            m_frmQuickFeedback.Height = Me.Height * 0.9
            m_frmQuickFeedback.Width = Me.Width * 0.9
            Application.DoEvents()
            m_frmQuickFeedback.Show()
        End If
    End Sub
End Class