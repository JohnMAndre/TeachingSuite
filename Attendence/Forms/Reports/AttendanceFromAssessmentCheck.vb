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
Public Class AttendanceFromAssessmentCheck

    Private Class StudentForReport
        Public Property StudentLocalName As String
        Public Property StudentNickname As String
        Public Property AttendanceStatus As AttendanceStatusEnum
        Public Property AssessmentStatus As String
    End Class

    Private m_objSchoolClass As SchoolClass
    Private m_lst As List(Of StudentForReport)


    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_objSchoolClass = schoolClass

    End Sub
    Private Sub LoadClassAssignments()
        lstAssignments.Items.Clear()

        '-- add both BTEC and normal assignments
        For Each objClassAssignment As ClassAssignmentBTEC In m_objSchoolClass.ClassGroup.AssignmentsBTEC
            lstAssignments.Items.Add(objClassAssignment)
        Next
        For Each objClassAssignment As ClassAssignment In m_objSchoolClass.ClassGroup.Assignments
            lstAssignments.Items.Add(objClassAssignment)
        Next
    End Sub
    Private Function GetSelectedAssignment() As IClassAssignment
        If lstAssignments.SelectedIndex = -1 Then
            MessageBox.Show("Please select an assessment to use.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        Else
            Dim asmt As IClassAssignment = lstAssignments.Items(lstAssignments.SelectedIndex)
            Return asmt
        End If
    End Function


    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Try
            Dim objBaseAsmt As IClassAssignment = GetSelectedAssignment()
            Dim dt As Date = dtpAttendance.Value
            dgvReport.DataSource = Nothing

            m_lst = New List(Of StudentForReport)
            Dim objStud As StudentForReport
            For Each stud As Student In m_objSchoolClass.Students
                objStud = New StudentForReport()
                objStud.StudentLocalName = stud.LocalNameLatinLetters
                objStud.StudentNickname = stud.Nickname
                objStud.AssessmentStatus = "Missing"

                For Each session As TeachingSession In stud.TeachingSessions
                    If session.StartDate = dt.Date Then
                        objStud.AttendanceStatus = session.AttendenceStatus
                        Exit For
                    End If
                Next

                Select Case objBaseAsmt.AssignmentType
                    Case AssignmentType.Normal
                        For Each asmt As StudentAssignment In stud.Assignments
                            If asmt.BaseAssignment Is objBaseAsmt Then
                                objStud.AssessmentStatus = "1st: " & asmt.FirstTryPoints.ToString()
                                Exit For
                            End If
                        Next
                    Case AssignmentType.BTEC
                        MessageBox.Show("BTEC assignments not implemented yet.")
                        'For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                        '    If asmt Is objBaseAsmt Then
                        '        objStud.AssessmentStatus = "1st: " & asmt.FirstTryPoints.ToString()
                        '        Exit For
                        '    End If
                        'Next
                End Select
                m_lst.Add(objStud)
                Application.DoEvents()
            Next

            dgvReport.AutoGenerateColumns = False
            dgvReport.DataSource = m_lst

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error with the report: " & ex.Message)
        End Try
    End Sub

    Private Sub AttendanceFromAssessmentCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassAssignments()
    End Sub
End Class