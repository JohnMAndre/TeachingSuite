'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

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
Public Class StudentAssessmentCompletionReport

    Private m_clas As SchoolClass
    Private m_assignment As IClassAssignment
    Private m_lstStudentsMatching As New List(Of Student)

    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_clas = clas

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

    Private Sub StudentAssessmentCompletionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-- Add all assignments
        For Each item As IClassAssignment In m_clas.ClassGroup.Assignments
            cboAssignments.Items.Add(item)
        Next
        For Each item As IClassAssignment In m_clas.ClassGroup.AssignmentsBTEC
            cboAssignments.Items.Add(item)
        Next


        '-- Setup dgvStudents stuff
        Dim typEnum As System.Type
        typEnum = GetType(AttendanceStatusEnum)
        dcolAttendanceStatus.DataSource = [Enum].GetValues(typEnum)
        dcolAttendanceStatus.ValueType = typEnum

        typEnum = GetType(Student.GenderEnum)
        dcolGender.DataSource = [Enum].GetValues(typEnum)
        dcolGender.ValueType = typEnum

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If SeemsOK() Then
            m_lstStudentsMatching.Clear()
            dgvStudents.DataSource = Nothing
            Dim outcome As AssignmentOutcome
            If m_assignment.AssignmentType = AssignmentType.BTEC Then
                outcome = cboLearningOutcome.Items(cboLearningOutcome.SelectedIndex)
            End If

            Dim clas As SchoolClass
            Dim boolMatch As Boolean

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
                boolMatch = False '-- default to negative match, unless positive match is found

                '-- find out if they are a positive or negative match
                Select Case m_assignment.AssignmentType
                    Case AssignmentType.BTEC
                        For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                            If asmt.BaseAssignment Is m_assignment Then
                                If cboLearningOutcome.SelectedIndex = 0 Then
                                    '-- Do not consider outcomes, assignment is enough
                                    boolMatch = True
                                Else
                                    '-- Achieved specified outcome?
                                    For Each result As OutcomeResult In asmt.Outcomes
                                        If result.BaseOutcome Is outcome Then
                                            If result.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                                boolMatch = True
                                            End If
                                            Exit For '-- Assuming one outcome is only on one assignment one time
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
                                    boolMatch = True
                                End If
                                Exit For '-- just consider first instance (should never be multiple)
                            End If
                        Next
                End Select

                If boolMatch = chkFindOnlyMatching.Checked Then
                    m_lstStudentsMatching.Add(stud)
                End If
            Next

            dgvStudents.DataSource = m_lstStudentsMatching
            Dim dblShowing As Double = ConvertToDouble(m_lstStudentsMatching.Count, 0) / ConvertToDouble(clas.Students.Count, 1)
            lblStudentCount.Text = "Showing " & m_lstStudentsMatching.Count.ToString("#,##0") & " of " & clas.Students.Count.ToString("#,##0") & " students (" & dblShowing.ToString("##0%") & ")"
        Else
            MessageBox.Show("Please complete all options before running the report.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function SeemsOK() As Boolean
        If cboAssignments.SelectedIndex < 0 Then
            MessageBox.Show("Please select an assignment to use.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If m_assignment.AssignmentType = AssignmentType.BTEC AndAlso cboLearningOutcome.SelectedIndex < 0 Then
            MessageBox.Show("Please select a learning outcome (or ALL) for the matching criteria.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True '-- must be ok after all
    End Function
End Class