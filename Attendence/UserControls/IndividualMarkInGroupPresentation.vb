Public Class IndividualMarkInGroupPresentation

    Private m_intContentGrade As Integer
    Private m_intPresentationGrade As Integer
    Private m_intLanguageGrade As Integer
    Private m_student As Student

    Public Sub LoadStudent(stud As Student)
        m_student = stud
        txtNickname.Text = m_student.Nickname
        txtLocalName.Text = m_student.LocalNameLatinLetters
        txtExtID.Text = m_student.ExtStudentID
        txtStudentID.Text = m_student.StudentID
        txtTeam.Text = m_student.StudentTeam
        txtTags.Text = m_student.Tags
        nudPresentationQuality.Value = m_student.PresentationQuality
        nudResearchQuality.Value = m_student.ResearchQuality

        '-- Load improvement items


    End Sub


    Private Sub picMark_Click(sender As Object, e As EventArgs) Handles picContentMark.Click, picPresentationMark.Click, picLanguageMark.Click
        Dim pic As PictureBox = CType(sender, PictureBox)


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
                intGrade = 5
                pic.Image = My.Resources.MarkingGridForPresentations0_5
            Case 0.15 To 0.25
                intGrade = 10
                pic.Image = My.Resources.MarkingGridForPresentations1_0
            Case 0.25 To 0.35
                intGrade = 15
                pic.Image = My.Resources.MarkingGridForPresentations1_5
            Case 0.35 To 0.45
                intGrade = 20
                pic.Image = My.Resources.MarkingGridForPresentations2_0
            Case 0.45 To 0.55
                intGrade = 25
                pic.Image = My.Resources.MarkingGridForPresentations2_5
            Case 0.55 To 0.65
                intGrade = 30
                pic.Image = My.Resources.MarkingGridForPresentations3_0
            Case 0.65 To 0.75
                intGrade = 35
                pic.Image = My.Resources.MarkingGridForPresentations3_5
            Case 0.75 To 0.85
                intGrade = 40
                pic.Image = My.Resources.MarkingGridForPresentations4_0
            Case 0.85 To 0.95
                intGrade = 45
                pic.Image = My.Resources.MarkingGridForPresentations4_5
            Case 0.95 To 1
                intGrade = 50
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

        Dim intTotalGrade As Integer = (m_intContentGrade * AppSettings.PresentationContentWeight) + (m_intPresentationGrade * AppSettings.PresentationPresentationWeight) + (m_intLanguageGrade * AppSettings.PresentationLanguageWeight)
        intTotalGrade = intTotalGrade / 100
        lblAverageGrade.Text = intTotalGrade.ToString()

        Dim strOverall As String = "Content (" & AppSettings.PresentationContentWeight.ToString() & "%): " & m_intContentGrade.ToString() & "/50" & Environment.NewLine & _
            "Presentation (" & AppSettings.PresentationPresentationWeight.ToString() & "%): " & m_intPresentationGrade.ToString() & "/50" & Environment.NewLine & _
            "Language (" & AppSettings.PresentationLanguageWeight.ToString() & "%): " & m_intLanguageGrade.ToString() & "/50" & Environment.NewLine & _
            "-----------------------" & Environment.NewLine & _
            "Total: " & intTotalGrade.ToString() & "/50"

        txtOverall.Text = strOverall
    End Sub

    Private Sub IndividualMarkInGroupPresentation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not DesignMode Then
            lblContentWeight.Text = AppSettings.PresentationContentWeight.ToString() & "%"
            lblPresentationWeight.Text = AppSettings.PresentationPresentationWeight.ToString() & "%"
            lblLanguageWeight.Text = AppSettings.PresentationLanguageWeight.ToString() & "%"
        End If
    End Sub
End Class
