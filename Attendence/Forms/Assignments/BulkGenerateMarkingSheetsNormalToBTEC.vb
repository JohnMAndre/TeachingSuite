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


            Dim boolOKToProcessStudent As Boolean
            Dim intCounterMax As Integer = m_ClassToProcess.Students.Count - 1

            Dim asmtBTEC As StudentAssignmentBTEC

            For intCounter As Integer = 0 To intCounterMax '-- See if this stops MoveNextRare error
                Dim stud As Student = m_ClassToProcess.Students(intCounter)
                boolOKToProcessStudent = False '-- reset for each student
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

                If asmtBTEC IsNot Nothing Then '-- It's possible there was no ClassAssignmentBTEC so test to be sure
                    For Each studasmt As StudentAssignment In stud.Assignments
                        '-- In this situation, there should be only one
                        '   to map overall outcome status
                        '   In case there are multiple, we just take the first one we find
                        asmtBTEC.ImprovementComments &= "Improvement for " & studasmt.BaseAssignment.Name & Environment.NewLine
                        asmtBTEC.ImprovementComments &= studasmt.ImprovementComments & Environment.NewLine
                        asmtBTEC.ImprovementComments &= Environment.NewLine & Environment.NewLine & Environment.NewLine
                    Next



                    '-- Next, open assessment form for BTEC and print it out
                    Using frm As New StudentAssignmentDetails(stud, asmtBTEC, m_try)
                        frm.Show()
                        Application.DoEvents()
                        frm.PrepareMarkingPage(True)
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


End Class