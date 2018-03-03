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




        '-- Load improvement items
        '-- Load all the improvement items and include date added/removed for those that apply to this student
        '   But we need to filter only for assignment categories on this assessment
        Dim boolItemAdded, boolHasMatchingCategory As Boolean

        For Each item As ImprovementItem In ThisSemester.ImprovementItems
            boolHasMatchingCategory = False '-- default to false

            For Each catItem As Semester.AssessmentCategory In item.AssessmentCategories
                For Each catAssess As Semester.AssessmentCategory In m_studentAssignment.BaseAssignment.AssessmentCategories
                    If catItem = catAssess Then
                        boolHasMatchingCategory = True
                        Exit For
                    End If
                Next
                If boolHasMatchingCategory Then
                    Exit For
                End If
            Next

            '-- We only include matching improvement items. If no matching category, we completely ignore it on this assessment
            If boolHasMatchingCategory Then
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
            End If
        Next
        dgvImprovementItems.AutoGenerateColumns = False
        dgvImprovementItems.DataSource = m_improvementItems


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

        AddSelectedImprovementItemsToStudent()

        If chkNominate.Checked Then
            MainFormReference.Notes = m_student.LocalNameLatinLetters & " (" & m_student.StudentID & "-" & m_student.StudentTeam & ") nominated @ " & Date.Now.ToString(DATE_TIME_FORMAT_DETAIL) & Environment.NewLine & MainFormReference.Notes
        End If

    End Sub
    Private Sub picContentMark_MouseDown(sender As Object, e As MouseEventArgs) Handles picContentMark.MouseDown, picPresentationMark.MouseDown, picLanguageMark.MouseDown
        Dim pic As PictureBox = CType(sender, PictureBox)

        Dim dblPosition As Double = (e.X / pic.Width)
        Dim intGrade As Integer
        Dim intPerformanceLevel As Integer '-- for tracking research and presentation skills
        Select Case dblPosition
            Case 0 To 0.05
                intPerformanceLevel = 0
                intGrade = 0
                pic.Image = My.Resources.MarkingGridForPresentations0_0
            Case 0.05 To 0.15
                intPerformanceLevel = 20
                intGrade = 0.1 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations0_5
            Case 0.15 To 0.25
                intPerformanceLevel = 30
                intGrade = 0.2 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations1_0
            Case 0.25 To 0.35
                intPerformanceLevel = 35
                intGrade = 0.3 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations1_5
            Case 0.35 To 0.45
                intPerformanceLevel = 40 '-- just pass
                intGrade = 0.4 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations2_0
            Case 0.45 To 0.55
                intPerformanceLevel = 50
                intGrade = 0.5 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations2_5
            Case 0.55 To 0.65
                intPerformanceLevel = 60
                intGrade = 0.6 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations3_0
            Case 0.65 To 0.75
                intPerformanceLevel = 65
                intGrade = 0.7 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations3_5
            Case 0.75 To 0.85
                intPerformanceLevel = 70 '-- first class
                intGrade = 0.8 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations4_0
            Case 0.85 To 0.95
                intPerformanceLevel = 80
                intGrade = 0.9 * m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations4_5
            Case 0.95 To 1
                intPerformanceLevel = 90 '-- nobody gets above 90% in UK
                intGrade = m_studentAssignment.BaseAssignment.MaxPoints
                pic.Image = My.Resources.MarkingGridForPresentations5_0
            Case Else
                pic.Image = My.Resources.MarkingGridForPresentations
        End Select

        Select Case pic.Name
            Case "picContentMark"
                m_intContentGrade = intGrade
                If AppSettings.GroupPresentationUpdatesPresentationAndResearchPerformanceLevel Then
                    nudResearchQuality.Value = intPerformanceLevel
                End If
            Case "picPresentationMark"
                m_intPresentationGrade = intGrade
                If AppSettings.GroupPresentationUpdatesPresentationAndResearchPerformanceLevel Then
                    nudPresentationQuality.Value = intPerformanceLevel
                End If
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
        AutoGenImprovementComments(True)
    End Sub
    Private Sub AutoGenImprovementComments(includePerformanceLevel As Boolean)
        txtImprovement.AppendText(GetImprovementNotes(includePerformanceLevel))
    End Sub
    Private Function GetImprovementNotes(includePerformanceLevel As Boolean) As String
        Try
            '-- Generate based on checked items in DGV
            Dim strReturn As String = String.Empty
            For Each item As StudentImprovementItem In m_improvementItems
                If item.Included Then
                    strReturn &= "* " & item.BaseImprovementItem.Description
                    If includePerformanceLevel Then
                        strReturn &= " (your performance level: " & item.PerformanceLevel & " out of 5 -- "
                        Select Case item.PerformanceLevel
                            Case 1
                                strReturn &= "unacceptable"
                            Case 2
                                strReturn &= "very weak, often incorrect"
                            Case 3
                                strReturn &= "OK, but inconsistent"
                            Case 4
                                strReturn &= "Good, but can improve more"
                            Case 5
                                strReturn &= "Already great"
                        End Select
                        strReturn &= ")" & Environment.NewLine & Environment.NewLine
                    End If
                End If
            Next

            Return strReturn.Trim()
        Catch ex As Exception
            MessageBox.Show("There was an error with the improvement note list: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub AddSelectedImprovementItemsToStudent()

        For Each item As StudentImprovementItem In m_improvementItems
            If item.Included Then
                If item.DateAdded > DATE_NO_DATE Then
                    '-- This improvement item already exists for this student
                Else
                    '-- add item to student
                    m_student.ImprovementItems.Add(item)
                    item.DateAdded = Date.Now
                    If item.PerformanceLevel = 0 Then
                        item.PerformanceLevel = 3 '-- default to 3
                    End If
                End If
            End If
        Next
    End Sub
    Private Function GetSelectedImprovementItem() As StudentImprovementItem
        Dim objReturn As StudentImprovementItem

        If dgvImprovementItems.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = dgvImprovementItems.CurrentRow
            objReturn = row.DataBoundItem
            Return objReturn
        Else
            Return Nothing
        End If
    End Function

    Private Sub dgvImprovementItems_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvImprovementItems.KeyDown
        Dim item As StudentImprovementItem = GetSelectedImprovementItem()
        If item IsNot Nothing Then
            Select Case e.KeyCode
                Case Keys.Add
                    item.PerformanceLevel += 1
                    e.SuppressKeyPress = True
                Case Keys.Subtract
                    item.PerformanceLevel -= 1
                    e.SuppressKeyPress = True
                Case Keys.Enter
                    item.Included = True
                    e.SuppressKeyPress = True
                Case Keys.Delete
                    item.Included = False
                    e.SuppressKeyPress = True
            End Select
        End If
        dgvImprovementItems.Refresh()
    End Sub

    Private Sub llblAbsent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAbsent.LinkClicked
        txtOverall.Text = "Student was absent."
        txtImprovement.Text &= "Please attend presentations in the future."
    End Sub

    Private Sub txtImprovement_TextChanged(sender As Object, e As EventArgs) Handles txtImprovement.TextChanged
        lblImprovementCharCount.Text = txtImprovement.Text.Length
    End Sub

    Private Sub dgvImprovementItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImprovementItems.CellValueChanged
        Try
            If e.RowIndex >= 0 Then
                Dim item As StudentImprovementItem = CType(dgvImprovementItems.Rows(e.RowIndex).DataBoundItem, StudentImprovementItem)
                item.Included = True
                dgvImprovementItems.Refresh()
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub picLanguageMark_Click(sender As Object, e As EventArgs) Handles picLanguageMark.Click

    End Sub

    Private Sub picContentMark_Click(sender As Object, e As EventArgs) Handles picContentMark.Click

    End Sub

    Private Sub picPresentationMark_Click(sender As Object, e As EventArgs) Handles picPresentationMark.Click

    End Sub
End Class
