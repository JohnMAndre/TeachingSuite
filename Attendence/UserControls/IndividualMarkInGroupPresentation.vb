Public Class IndividualMarkInGroupPresentation

    Private m_intContentGrade As Integer
    Private m_intPresentationGrade As Integer
    Private m_intLanguageGrade As Integer
    Private m_student As Student
    Private m_improvementItems As New List(Of StudentImprovementItem) '-- include those assigned to the student and those not
    Private m_studentAssignment As StudentAssignment
    Private m_markTry As Semester.MarkingTry
    Private m_intTotalGrade As Integer

    Public Sub LoadStudent(stud As Student, assignment As ClassAssignment, attempt As Semester.MarkingTry)
        m_student = stud
        txtNickname.Text = m_student.Nickname
        txtLocalName.Text = m_student.LocalNameLatinLetters
        txtExtID.Text = m_student.ExtStudentID
        txtStudentID.Text = m_student.StudentID
        txtTags.Text = m_student.Tags
        nudPresentationQuality.Value = m_student.PresentationQuality
        nudResearchQuality.Value = m_student.ResearchQuality

        '-- Load improvement items
        '-- Load all the improvement items and include date added/removed for those that apply to this student
        Dim boolItemAdded As Boolean
        For Each item As ImprovementItem In ThisSemester.ImprovementItems
            boolItemAdded = False
            For Each studItem As StudentImprovementItem In m_student.ImprovementItems
                If studItem.BaseImprovementItem Is item Then
                    m_improvementItems.Add(studItem)
                    boolItemAdded = True
                    Exit For
                End If
            Next
            If Not boolItemAdded Then
                Dim studItem As New StudentImprovementItem(m_student)
                studItem.BaseImprovementItem = item
                studItem.DateAdded = DATE_NO_DATE
                m_improvementItems.Add(studItem)
            End If
        Next
        dgvImprovementItems.AutoGenerateColumns = False
        dgvImprovementItems.DataSource = m_improvementItems

        nudFirstGrade.Maximum = assignment.MaxPoints
        nudSecondGrade.Maximum = assignment.MaxPoints


        '-- find student assignment
        For Each asmt As StudentAssignment In m_student.Assignments
            If asmt.BaseAssignment Is assignment Then
                m_studentAssignment = asmt
                nudFirstGrade.Value = m_studentAssignment.FirstTryPoints
                nudSecondGrade.Value = m_studentAssignment.SecondTryPoints
                txtOverall.Text = m_studentAssignment.OverallComments
                txtImprovement.Text = m_studentAssignment.ImprovementComments
                Exit For
            End If
        Next

        If m_studentAssignment Is Nothing Then
            '-- create assignment for student
            m_studentAssignment = m_student.AddAssignment(assignment)
            m_studentAssignment.OverallComments = assignment.OverallDefaultText
        End If

        m_markTry = attempt

    End Sub
    ''' <summary>
    ''' Save all marking data for this student's assignment
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save()
        Select Case m_markTry
            Case Semester.MarkingTry.FirstTry
                m_studentAssignment.FirstTryPoints = m_intTotalGrade
            Case Semester.MarkingTry.SecondTry
                m_studentAssignment.SecondTryPoints = m_intTotalGrade
            Case Semester.MarkingTry.ThirdTry
                m_studentAssignment.ThirdTryPoints = m_intTotalGrade
        End Select

        m_studentAssignment.Processed = True

        m_studentAssignment.OverallComments = txtOverall.Text
        m_studentAssignment.ImprovementComments = txtImprovement.Text
        m_student.PresentationQuality = nudPresentationQuality.Value
        m_student.ResearchQuality = nudResearchQuality.Value
        m_student.Nickname = txtNickname.Text
        m_student.Tags = txtTags.Text

    End Sub
    Private Sub picContentMark_MouseDown(sender As Object, e As MouseEventArgs) Handles picContentMark.MouseDown, picPresentationMark.MouseDown, picLanguageMark.MouseDown
        Dim pic As PictureBox = CType(sender, PictureBox)

        Dim dblPosition As Double = (e.X / pic.Width)
        Dim intGrade As Integer
        Select Case dblPosition
            Case 0 To 0.05
                intGrade = 0
                pic.Image = My.Resources.MarkingGridForPresentations0_0
            Case 0.05 To 0.15
                intGrade = 0.1 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations0_5
            Case 0.15 To 0.25
                intGrade = 0.2 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations1_0
            Case 0.25 To 0.35
                intGrade = 0.3 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations1_5
            Case 0.35 To 0.45
                intGrade = 0.4 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations2_0
            Case 0.45 To 0.55
                intGrade = 0.5 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations2_5
            Case 0.55 To 0.65
                intGrade = 0.6 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations3_0
            Case 0.65 To 0.75
                intGrade = 0.7 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations3_5
            Case 0.75 To 0.85
                intGrade = 0.8 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations4_0
            Case 0.85 To 0.95
                intGrade = 0.9 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations4_5
            Case 0.95 To 1
                intGrade = m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations5_0
            Case Else
                pic.Image = My.Resources.MarkingGridForPresentations
        End Select

        Select Case pic.Name
            Case "picContentMark"
                m_intContentGrade = intGrade
            Case "picPresentationMark"
                m_intPresentationGrade = intGrade
            Case "picLanguageMark"
                m_intLanguageGrade = intGrade
        End Select

        UpdateGrades()

    End Sub
    Private Sub UpdateGrades()
        lblContentGrade.Text = m_intContentGrade.ToString
        lblPresentationGrade.Text = m_intPresentationGrade.ToString
        lblLanguageGrade.Text = m_intLanguageGrade.ToString

        m_intTotalGrade = (m_intContentGrade * AppSettings.PresentationContentWeight) + (m_intPresentationGrade * AppSettings.PresentationPresentationWeight) + (m_intLanguageGrade * AppSettings.PresentationLanguageWeight)
        m_intTotalGrade = m_intTotalGrade / 100
        lblAverageGrade.Text = m_intTotalGrade.ToString()
        Select Case m_markTry
            Case Semester.MarkingTry.FirstTry
                nudFirstGrade.Value = m_intTotalGrade
            Case Semester.MarkingTry.SecondTry
                nudSecondGrade.Value = m_intTotalGrade
            Case Semester.MarkingTry.ThirdTry
                '-- ignore for now
        End Select

        Dim strOverall As String = "Content (" & AppSettings.PresentationContentWeight.ToString() & "%): " & m_intContentGrade.ToString() & "/" & m_studentAssignment.BaseAssignment.MaxPoints & Environment.NewLine & _
            "Presentation (" & AppSettings.PresentationPresentationWeight.ToString() & "%): " & m_intPresentationGrade.ToString() & "/" & m_studentAssignment.BaseAssignment.MaxPoints & Environment.NewLine & _
            "Language (" & AppSettings.PresentationLanguageWeight.ToString() & "%): " & m_intLanguageGrade.ToString() & "/" & m_studentAssignment.BaseAssignment.MaxPoints & Environment.NewLine & _
            "-----------------------" & Environment.NewLine & _
            "Total: " & m_intTotalGrade.ToString() & "/" & m_studentAssignment.BaseAssignment.MaxPoints

        txtOverall.Text = strOverall
    End Sub

    Private Sub IndividualMarkInGroupPresentation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not DesignMode Then
            lblContentWeight.Text = AppSettings.PresentationContentWeight.ToString() & "%"
            lblPresentationWeight.Text = AppSettings.PresentationPresentationWeight.ToString() & "%"
            lblLanguageWeight.Text = AppSettings.PresentationLanguageWeight.ToString() & "%"
        End If
    End Sub

    Private Sub llblGenerateImprovements_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblGenerateImprovements.LinkClicked
        '-- Generate based on checked items in DGV

    End Sub

End Class
