Public Class BulkGenerateMarkingSheetsNormalToBTEC

    Private m_group As ClassGroup
    Private m_class As SchoolClass
    Private m_try As Semester.MarkingTry
    Private m_cancel As Boolean
    Private m_ClassToProcess As SchoolClass

    Public Sub New(clsGroup As ClassGroup, cls As SchoolClass, markTry As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_group = clsGroup
        m_class = cls
        m_try = markTry

        lblClassName.Text = m_class.Name
        lblModuleName.Text = m_group.Name
        lblOutputPath.Text = AppSettings.MarkingPageSaveFolder
        lblMarkingTry.Text = m_try.ToString


    End Sub

    Private Sub BulkGenerateMarkingSheetsNormalToBTEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ClassIsCombinedView(m_class) Then
            Dim boolSetAlready As Boolean
            For Each objCls As SchoolClass In m_group.Classes
                If Not boolSetAlready Then
                    Dim grp As New ClassGroup(Nothing)
                    grp.UseNickname = m_group.UseNickname
                    m_ClassToProcess = New SchoolClass(grp)
                    m_ClassToProcess.Students.AddRange(objCls.Students)
                    boolSetAlready = True
                Else
                    m_ClassToProcess.Students.AddRange(objCls.Students)
                End If
            Next
        Else
            m_ClassToProcess = m_class
        End If

        lblNumberOfStudents.Text = m_ClassToProcess.Students.Count.ToString("#,##0")

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            Dim intGenerated, intSkipped As Integer
            m_cancel = False
            btnCancel.Enabled = True
            Application.DoEvents()

            Dim boolManualProcessing As Boolean = rbtnManualProcessOutcomes.Checked
            Dim boolOKToProcessStudent As Boolean
            Dim intCounterMax As Integer = m_ClassToProcess.Students.Count - 1

            Dim asmtBTEC As StudentAssignmentBTEC

            Dim dblMinPercentPass, dblMinPercentMerit, dblMinPercentDistinction As Double

            '-- set minimums
            dblMinPercentPass = ConvertToDouble(txtMinScorePass.Text, 40) / 100
            dblMinPercentMerit = ConvertToDouble(txtMinScoreMerit.Text, 50) / 100
            dblMinPercentDistinction = ConvertToDouble(txtMinScoreDistinction.Text, 60) / 100


            For intCounter As Integer = 0 To intCounterMax '-- this stops MoveNextRare error
                Dim stud As Student = m_ClassToProcess.Students(intCounter)

                '-- If student is flagged as hidden, then assume this student does not need to be processed
                '   perhaps it was processed in an earlier run and we don't want to reprocess it
                If stud.Hidden Then
                    Continue For

                End If
                '-- reset for each student
                boolOKToProcessStudent = False
                asmtBTEC = Nothing

                For Each studasmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                    '-- In this situation, there should be only one
                    '   to map overall outcome status
                    '   In case there are multiple, we just take the first one we find
                    asmtBTEC = studasmt

                    If asmtBTEC.BaseAssignment.AssignmentBriefFilename.Trim.Length = 0 Then
                        '-- Need to prompt user to set marking form
                        lblAssessmentName.Text = "Please set the Marking Form for the BTEC assessment (" & asmtBTEC.BaseAssignment.Name & ")."
                        Exit Sub
                    End If
                    Exit For
                Next


                If asmtBTEC Is Nothing Then
                    '-- BTEC master assignment not found, so create it and add to student
                    For Each clsasmt As ClassAssignmentBTEC In m_class.ClassGroup.AssignmentsBTEC
                        asmtBTEC = New StudentAssignmentBTEC(clsasmt)
                        stud.AssignmentsBTEC.Add(asmtBTEC)

                        '-- Need to prompt user to set marking form
                        If asmtBTEC.BaseAssignment.AssignmentBriefFilename.Trim.Length = 0 Then
                            lblAssessmentName.Text = "Please set the Marking Form for the BTEC assessment (" & asmtBTEC.BaseAssignment.Name & ")."
                            Exit Sub
                        End If
                    Next
                End If

                '-- Now we walk through all the normal asmts
                '   collect up improvement feedback to be used as formative
                '-- Tack the improvement data into BTEC improvement
                '   So the BTEC assessment will be the overall assessment
                '   The Normal assessments will only be used as the details 
                '   which get aggregated into BTEC for final reporting
                Dim strScores As String
                Dim dblIndividualPercent As Double
                Dim intTotalScore, intTotalMax As Integer


                If asmtBTEC IsNot Nothing Then '-- It's possible there was no ClassAssignmentBTEC so test to be sure
                    '-- Reset
                    strScores = String.Empty
                    intTotalMax = 0
                    intTotalScore = 0
                    asmtBTEC.ImprovementComments = String.Empty
                    asmtBTEC.OverallComments = String.Empty

                    For Each studasmt As StudentAssignment In stud.Assignments
                        '-- In this situation, there should be only one
                        '   to map overall outcome status
                        '   In case there are multiple, we just take the first one we find
                        asmtBTEC.ImprovementComments &= "Improvement for " & studasmt.BaseAssignment.Name & Environment.NewLine
                        asmtBTEC.ImprovementComments &= studasmt.ImprovementComments & Environment.NewLine
                        asmtBTEC.ImprovementComments &= Environment.NewLine & Environment.NewLine


                        asmtBTEC.OverallComments &= "Overall for " & studasmt.BaseAssignment.Name & Environment.NewLine
                        asmtBTEC.OverallComments &= studasmt.OverallComments & Environment.NewLine
                        asmtBTEC.OverallComments &= Environment.NewLine & Environment.NewLine


                        intTotalMax += studasmt.BaseAssignment.MaxPoints
                        intTotalScore += studasmt.FirstTryPoints

                        If boolManualProcessing Then
                            '-- in case of manual processing, put all the individual scores in the 
                            '  observation field so user can make an informed decisions
                            dblIndividualPercent = studasmt.FirstTryPoints / studasmt.BaseAssignment.MaxPoints
                            strScores &= studasmt.BaseAssignment.Name & ": " & studasmt.FirstTryPoints & "/" & studasmt.BaseAssignment.MaxPoints & " (" & dblIndividualPercent.ToString("0%") & ")" & Environment.NewLine
                        End If
                    Next

                    dblIndividualPercent = intTotalScore / intTotalMax

                    If boolManualProcessing Then
                        '-- Prepend average score
                        strScores = "Total: " & intTotalScore & " / " & intTotalMax & " = " & dblIndividualPercent.ToString("0%") & Environment.NewLine & "----------" & Environment.NewLine & strScores

                        asmtBTEC.ObservationComments = strScores
                    End If


                    '-- Next, open assessment form for BTEC and print it out
                    Using frm As New StudentAssignmentDetails(stud, asmtBTEC, m_try)


                        If boolManualProcessing Then
                            '-- Manual means user will set the outcomes and save/print
                            '   Clicking OK closes the form and then control passes back here
                            If frm.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                                m_cancel = True
                            End If
                        Else
                            '-- This is set for auto-processing
                            '   so we must set the outcomes and overall
                            If dblIndividualPercent >= dblMinPercentDistinction Then
                                '-- Distinction
                                For Each rslt As OutcomeResult In asmtBTEC.Outcomes
                                    rslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                                Next

                                If chkAddAutoCalcOverall.Checked Then
                                    asmtBTEC.OverallComments = "Achieved requirements for DISTINCTION. Great work!" & Environment.NewLine & Environment.NewLine & asmtBTEC.OverallComments
                                End If
                            ElseIf dblIndividualPercent >= dblMinPercentMerit Then
                                '-- Merit
                                For Each rslt As OutcomeResult In asmtBTEC.Outcomes
                                    If rslt.BaseOutcome.GradeGroup = BTECGradeGroup.Distinction Then
                                        rslt.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                                    Else
                                        rslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                                    End If
                                Next
                                If chkAddAutoCalcOverall.Checked Then
                                    asmtBTEC.OverallComments = "Achieved requirements for MERIT" & Environment.NewLine & Environment.NewLine & asmtBTEC.OverallComments
                                End If
                            ElseIf dblIndividualPercent >= dblMinPercentPass Then
                                '-- Pass
                                For Each rslt As OutcomeResult In asmtBTEC.Outcomes
                                    If rslt.BaseOutcome.GradeGroup = BTECGradeGroup.Pass Then
                                        rslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                                    Else
                                        rslt.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                                    End If
                                Next
                                If chkAddAutoCalcOverall.Checked Then
                                    asmtBTEC.OverallComments = "Achieved minimum requirements to pass" & Environment.NewLine & Environment.NewLine & asmtBTEC.OverallComments
                                End If
                            Else
                                '-- Fail
                                For Each rslt As OutcomeResult In asmtBTEC.Outcomes
                                    rslt.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                                Next
                                If chkAddAutoCalcOverall.Checked Then
                                    asmtBTEC.OverallComments = "Failed to achieve minimum requirements" & Environment.NewLine & Environment.NewLine & asmtBTEC.OverallComments
                                End If

                            End If


                            frm.Show()
                            Application.DoEvents()
                            frm.PrepareMarkingPageSimple()
                        End If
                        frm.Close()
                    End Using

                    intGenerated += 1
                Else
                    intSkipped += 1
                    lblAssessmentName.Text = "Please ensure there is a BTEC assessment."
                End If


                lblStudentsGenerated.Text = intGenerated.ToString("#,##0")
                lblStudentsSkipped.Text = intSkipped.ToString("#,##0")
                Application.DoEvents() '-- let it paint
                If m_cancel Then
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("There was an error with the batch: " & ex.Message & Environment.NewLine & Environment.NewLine & ex.StackTrace)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        m_cancel = True
        btnCancel.Enabled = False
    End Sub


    Private Sub rbtnManualProcessOutcomes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnManualProcessOutcomes.CheckedChanged
        lblMinPass.Enabled = rbtnAutoProcessOutcomes.Checked
        lblMinMerit.Enabled = rbtnAutoProcessOutcomes.Checked
        lblMinDistinction.Enabled = rbtnAutoProcessOutcomes.Checked
        txtMinScorePass.Enabled = rbtnAutoProcessOutcomes.Checked
        txtMinScoreMerit.Enabled = rbtnAutoProcessOutcomes.Checked
        txtMinScoreDistinction.Enabled = rbtnAutoProcessOutcomes.Checked
    End Sub
End Class