Public Class AttendenceErrors

    Dim m_lstStudents As New List(Of Student)

    Private Sub olvStudents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles olvStudents.SelectedIndexChanged
        If olvStudents.SelectedObject IsNot Nothing Then
            Dim stud As Student = CType(olvStudents.SelectedObject, Student)
            LoadClassSessions(stud.SchoolClass)
            LoadStudentSessions(stud)
        End If
    End Sub
    Private Sub LoadStudentSessions(stud As Student)
        olvStudentSessions.SetObjects(stud.TeachingSessions)
        lblStudentSessions.Text = stud.TeachingSessions.Count.ToString()
    End Sub

    Private Sub AttendenceErrors_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
        Try
            Using frm As New StudentDetail(CType(olvStudents.SelectedObject, Student))
                frm.ShowDialog(Me)
            End Using

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub olvClassSessions_ItemActivate(sender As Object, e As EventArgs) Handles olvClassSessions.ItemActivate
        AddSessionToStudent()
    End Sub
    Private Sub AddSessionToStudent()
        Try
            '-- add this to student
            If olvClassSessions.SelectedObjects.Count = 0 Then
                MessageBox.Show("Please select a session from the class session list.", Application.ProductName)
                Exit Sub
            End If

            For Each classSession As ClassSession In olvClassSessions.SelectedObjects
                'Dim classSession As ClassSession = CType(olvClassSessions.SelectedObject, ClassSession)
                Dim session As New TeachingSession()
                session.StartDate = classSession.StartDate
                session.AttendenceStatus = AttendenceStatusEnum.Excused
                Dim stud As Student = CType(olvStudents.SelectedObject, Student)
                stud.TeachingSessions.Add(session)
                LoadStudentSessions(stud)
                Application.DoEvents()
            Next

        Catch ex As Exception
            MessageBox.Show("Error adding session to student: " & ex.Message)
        End Try
    End Sub

    Private Sub llblAddDateToStudent_LinkClicked(sender As Object, e As EventArgs) Handles llblAddDateToStudent.LinkClicked
        AddSessionToStudent()
    End Sub

    Private Sub LoadClassSessions(cls As SchoolClass)
        olvClassSessions.SetObjects(cls.ClassSessions)
        lblTeachingSessions.Text = cls.ClassSessions.Count.ToString()
    End Sub

    Private Sub llblRemoveDateFromClass_LinkClicked(sender As Object, e As EventArgs) Handles llblRemoveDateFromClass.LinkClicked
        Try
            '-- Remove this session from the class
            If olvClassSessions.SelectedObject Is Nothing Then
                MessageBox.Show("Please select a session from the class session list.", Application.ProductName)
                Exit Sub
            End If
            Dim classSession As ClassSession = CType(olvClassSessions.SelectedObject, ClassSession)

            If olvStudents.SelectedObject Is Nothing Then
                MessageBox.Show("Please select a student from the student list.", Application.ProductName)
                Exit Sub
            Else
                Dim stud As Student = CType(olvStudents.SelectedObject, Student)
                stud.SchoolClass.ClassSessions.Remove(classSession)
                LoadClassSessions(stud.SchoolClass)
            End If

        Catch ex As Exception
            MessageBox.Show("Error adding session to student: " & ex.Message)
        End Try
    End Sub
    Private Sub RemoveDateFromStudent()
        Try
            '-- add this to student
            If olvStudentSessions.SelectedObjects.Count = 0 Then
                MessageBox.Show("Please select a session from the student session list.", Application.ProductName)
                Exit Sub
            End If
            Dim stud As Student = CType(olvStudents.SelectedObject, Student)
            'Dim session As TeachingSession = CType(olvStudentSessions.SelectedObject, TeachingSession)
            For Each session As TeachingSession In olvStudentSessions.SelectedObjects
                stud.TeachingSessions.Remove(session)
            Next

            LoadStudentSessions(stud)
        Catch ex As Exception
            MessageBox.Show("Error removing session from student: " & ex.Message)
        End Try
    End Sub

    Private Sub llblRemoveDateFromStudent_LinkClicked(sender As Object, e As EventArgs) Handles llblRemoveDateFromStudent.LinkClicked
        RemoveDateFromStudent()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        Try
            m_lstStudents.Clear()
            Dim boolProblem As Boolean
            Dim intOverallCounter As Integer
            Dim intStudentSessionCounterOffset As Integer '-- When -2 then clas.ClassSessions(6) = stud.TeachingSessions(4) [this handles getting out of sync because of studentgroups (workshops)
            For Each group As ClassGroup In ThisSemester.ClassGroups
                For Each clas As SchoolClass In group.Classes
                    For Each stud As Student In clas.Students
                        intOverallCounter += 1
                        statusLabel.Text = "Processing student: " & intOverallCounter.ToString("#,##0")
                        Application.DoEvents()
                        '-- see if they are out of sync or not
                        'If clas.ClassSessions.Count <> stud.TeachingSessions.Count Then
                        '    '-- definite problem
                        '    m_lstStudents.Add(stud)
                        'Else
                        boolProblem = False
                        intStudentSessionCounterOffset = 0 '-- make sure we reset for each student
                        For intClassSessionCounter As Integer = 0 To clas.ClassSessions.Count - 1
                            If clas.ClassSessions(intClassSessionCounter).StudentGroup = 0 OrElse clas.ClassSessions(intClassSessionCounter).StudentGroup = stud.StudentGroup Then
                                If stud.TeachingSessions.Count < (intClassSessionCounter + intStudentSessionCounterOffset + 1) OrElse clas.ClassSessions(intClassSessionCounter).StartDate <> stud.TeachingSessions(intClassSessionCounter + intStudentSessionCounterOffset).StartDate Then
                                    m_lstStudents.Add(stud) '-- something is wrong, add this student to the list
                                    Exit For
                                End If
                            Else
                                '-- need to skip this classSession by changing the sync offset
                                intStudentSessionCounterOffset -= 1
                            End If
                        Next
                        'End If
                    Next
                Next
            Next

            statusLabel.Text = "Completed processing of " & intOverallCounter.ToString("#,##0") & " students."
            olvStudents.SetObjects(m_lstStudents)
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RemoveDateFromSelectedStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveDateFromSelectedStudentToolStripMenuItem.Click
        RemoveDateFromStudent()
    End Sub

    Private Sub llblAddSessionToClass_LinkClicked(sender As Object, e As EventArgs) Handles llblAddSessionToClass.LinkClicked
        Try
            If olvStudents.SelectedObject IsNot Nothing Then
                Dim stud As Student = CType(olvStudents.SelectedObject, Student)


                Dim objClassSession As New ClassSession()
                objClassSession.StartDate = Date.Today
                objClassSession.StudentGroup = 0
                stud.SchoolClass.ClassSessions.Add(objClassSession)

                LoadClassSessions(stud.SchoolClass)

            Else
                MessageBox.Show("Please select a student to select the class.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error adding the session to the class: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
