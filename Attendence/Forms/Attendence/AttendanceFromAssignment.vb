Public Class AttendanceFromAssignment

    Private m_clas As SchoolClass
    Private m_dtDefaultDate As Date = New Date(2010, 1, 1)
    Private m_assignment As IClassAssignment

    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_clas = clas

    End Sub
    Private Sub AttendanceFromAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strStatuses() As String = System.Enum.GetNames(GetType(AttendanceStatusEnum))
        For Each item As String In strStatuses
            cboPositiveStatus.Items.Add(item)
            cboNegativeStatus.Items.Add(item)
        Next

        '-- Add all assignments
        For Each item As IClassAssignment In m_clas.ClassGroup.Assignments
            cboAssignments.Items.Add(item)
        Next
        For Each item As IClassAssignment In m_clas.ClassGroup.AssignmentsBTEC
            cboAssignments.Items.Add(item)
        Next

        dtpSessionDate.Value = m_dtDefaultDate
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboAssignments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAssignments.SelectedIndexChanged
        Dim item As IClassAssignment
        If cboAssignments.SelectedIndex >= 0 Then
            item = cboAssignments.Items(cboAssignments.SelectedIndex)
            m_assignment = item
            Select Case item.AssignmentType
                Case AssignmentType.BTEC
                    pnlNormalAssignment.Hide()
                    pnlBTECAssignment.Show()
                    LoadLearningOutcomes(item)
                Case AssignmentType.Normal
                    Dim intMaxPoints As Integer = CType(item, ClassAssignment).MaxPoints
                    pnlNormalAssignment.Show()
                    pnlBTECAssignment.Hide()
                    lblNormalAssignmentMaxScore.Text = "(max score: " & intMaxPoints & ")"
                    If nudNormalAssignmentScore.Value > intMaxPoints Then
                        nudNormalAssignmentScore.Value = intMaxPoints
                    End If
                    nudNormalAssignmentScore.Maximum = intMaxPoints
            End Select
        End If
    End Sub
    Private Sub LoadLearningOutcomes(assignment As ClassAssignmentBTEC)
        cboLearningOutcome.Items.Clear()
        cboLearningOutcome.Items.Add("Any - consider only assignment")
        For Each item As AssignmentOutcome In assignment.Outcomes
            cboLearningOutcome.Items.Add(item)
        Next
    End Sub
    Private Function Validated() As Boolean
        If cboAssignments.SelectedIndex < 0 Then
            MessageBox.Show("Please select an assignment to use.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If dtpSessionDate.Value = m_dtDefaultDate Then
            MessageBox.Show("Please choose a date for the new attendance records.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If cboNegativeStatus.SelectedIndex < 0 Then
            MessageBox.Show("Please select an attendance status for students who do not match the criteria.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If cboPositiveStatus.SelectedIndex < 0 Then
            MessageBox.Show("Please select an attendance status for students who do match the criteria.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If m_assignment.AssignmentType = AssignmentType.BTEC AndAlso cboLearningOutcome.SelectedIndex < 0 Then
            MessageBox.Show("Please select a learning outcome (or ALL) for the matching criteria.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True '-- must be ok after all
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Validated() Then
            Dim positiveStatus As AttendanceStatusEnum = cboPositiveStatus.SelectedIndex
            Dim negativeStatus As AttendanceStatusEnum = cboNegativeStatus.SelectedIndex
            Dim outcome As AssignmentOutcome
            If m_assignment.AssignmentType = AssignmentType.BTEC Then
                outcome = cboLearningOutcome.Items(cboLearningOutcome.SelectedIndex)
            End If

            Dim clas As SchoolClass
            Dim status As AttendanceStatusEnum
            '-- get all the students
            If ClassIsCombinedView(m_clas) Then
                clas = New SchoolClass(m_clas.ClassGroup)
                For Each cls As SchoolClass In m_clas.ClassGroup.Classes
                    clas.Students.AddRange(cls.Students)
                Next
            Else
                clas = m_clas
            End If

            For Each stud As Student In clas.Students
                status = negativeStatus '-- default to negative match, unless positive match is found

                '-- find out if they are a positive or negative match
                Select Case m_assignment.AssignmentType
                    Case AssignmentType.BTEC
                        For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                            If asmt.BaseAssignment Is m_assignment Then
                                If cboLearningOutcome.SelectedIndex = 0 Then
                                    '-- Do not consider outcomes, assignment is enough
                                    status = positiveStatus
                                Else
                                    '-- Achieved specified outcome?
                                    For Each result As OutcomeResult In asmt.Outcomes
                                        If result.BaseOutcome Is outcome Then
                                            If result.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                                status = positiveStatus
                                                Exit For
                                            End If
                                        End If
                                    Next
                                End If
                                Exit For '-- just consider first instance (should never be multiple)
                            End If
                        Next
                    Case AssignmentType.Normal
                        For Each asmt As StudentAssignment In stud.Assignments
                            If asmt.BaseAssignment Is m_assignment Then
                                If asmt.FirstTryPoints >= nudNormalAssignmentScore.Value Then
                                    status = positiveStatus
                                End If
                                Exit For '-- just consider first instance (should never be multiple)
                            End If
                        Next
                End Select
                '-- Now, did the student match?
                Dim session As New TeachingSession(stud)
                session.Notes = "from assignment"
                session.StartDate = dtpSessionDate.Value.Date
                session.AttendenceStatus = status

                stud.TeachingSessions.Add(session)
            Next

            Dim objNewSession As New ClassSession()
            objNewSession.StartDate = dtpSessionDate.Value.Date
            objNewSession.StudentGroup = 0 '-- for all students

            clas.ClassSessions.Add(objNewSession)

            MessageBox.Show(clas.Students.Count.ToString("#,##0") & " students processed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddApplicationHistory(clas.Students.Count.ToString("#,##0") & " students processed in Attendance from Assignment.")
            Close()
        Else
            MessageBox.Show("Please complete all options before clicking OK.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class