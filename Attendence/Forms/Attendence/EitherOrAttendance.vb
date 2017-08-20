Public Class EitherOrAttendance

    Private m_class As SchoolClass
    Private m_result As New List(Of EitherOrAttendanceResults)

    Public Sub New(cls As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = cls
        txtClassName.Text = cls.Name

        olvStudents.SetObjects(m_result)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK2.Click
        Try
            Dim dt1, dt2 As Date
            Dim bool1, bool2 As Boolean
            Dim session1, session2 As TeachingSession
            Dim result As EitherOrAttendanceResults

            If olvActualSessions.SelectedObjects.Count <> 2 Then
                MessageBox.Show("Please select exactly 2 sessions.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                dt1 = CType(olvActualSessions.SelectedObjects(0), ActualSessionItem).StartDateTime
                dt2 = CType(olvActualSessions.SelectedObjects(1), ActualSessionItem).StartDateTime

                For Each stud As Student In m_class.Students
                    result = New EitherOrAttendanceResults
                    bool1 = False
                    bool2 = False
                    result.Student = stud

                    For Each session As TeachingSession In stud.TeachingSessions
                        If session.StartDate = dt1.Date Then
                            session1 = session
                            bool1 = True
                        ElseIf session.StartDate = dt2.Date Then
                            session2 = session
                            bool2 = True
                        End If
                        If bool1 AndAlso bool2 Then
                            Exit For
                        End If
                    Next
                    If bool1 AndAlso bool2 Then
                        '-- have data for both sessions, now process
                        If session1.AttendenceStatus = AttendanceStatusEnum.Present AndAlso session2.AttendenceStatus = AttendanceStatusEnum.Absent Then
                            session2.AttendenceStatus = AttendanceStatusEnum.Excused
                            stud.AddToActivityLog("Changing status to excused for Either Or process (" & session2.StartDate & ").")
                            result.Results = "Session 2 excused"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Absent AndAlso session2.AttendenceStatus = AttendanceStatusEnum.Present Then
                            session1.AttendenceStatus = AttendanceStatusEnum.Excused
                            stud.AddToActivityLog("Changing status to excused for Either Or process (" & session1.StartDate & ").")
                            result.Results = "Session 1 excused"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Present AndAlso session2.AttendenceStatus = AttendanceStatusEnum.Present Then
                            result.Results = "Present both sessions"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Absent AndAlso session2.AttendenceStatus = AttendanceStatusEnum.Absent Then
                            result.Results = "Absent both sessions"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Removed OrElse session2.AttendenceStatus = AttendanceStatusEnum.Removed Then
                            result.Results = "At least one removed"
                        Else
                            result.Results = "Special: Session1=" & session1.AttendenceStatus.ToString() & "; Session2=" & session2.AttendenceStatus.ToString()
                        End If
                        m_result.Add(result)
                        olvStudents.AddObject(result)
                    Else
                        result = New EitherOrAttendanceResults
                        result.Student = stud
                        result.Results = "Student missing attendance data."
                        m_result.Add(result)
                        olvStudents.AddObject(result)
                    End If

                Next

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Class EitherOrAttendanceResults
        Public Student As Student
        Public Results As String
    End Class

    Private Sub EitherOrAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        olvActualSessions.SetObjects(m_class.ActualSessions)
    End Sub

    Private Sub btnOK4_Click(sender As Object, e As EventArgs) Handles btnOK4.Click
        Try
            Dim dt1, dt2, dt3, dt4 As Date
            Dim bool1, bool2, bool3, bool4 As Boolean
            Dim session1, session2, session3, session4 As TeachingSession
            Dim result As EitherOrAttendanceResults

            If olvActualSessions.SelectedObjects.Count <> 2 Then
                MessageBox.Show("Please select exactly 2 sessions.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                dt1 = CType(olvActualSessions.SelectedObjects(0), ActualSessionItem).StartDateTime
                dt2 = CType(olvActualSessions.SelectedObjects(0), ActualSessionItem).StartDateTime
                dt3 = CType(olvActualSessions.SelectedObjects(1), ActualSessionItem).StartDateTime
                dt4 = CType(olvActualSessions.SelectedObjects(1), ActualSessionItem).StartDateTime

                For Each stud As Student In m_class.Students
                    bool1 = False
                    bool2 = False
                    bool3 = False
                    bool4 = False

                    For Each session As TeachingSession In stud.TeachingSessions
                        If session.StartDate = dt1.Date AndAlso Not bool1 Then
                            session1 = session
                            bool1 = True
                        ElseIf session.StartDate = dt2.Date AndAlso Not bool2 Then
                            session2 = session
                            bool2 = True
                        ElseIf session.StartDate = dt3.Date AndAlso Not bool3 Then
                            session3 = session
                            bool3 = True
                        ElseIf session.StartDate = dt4.Date AndAlso Not bool4 Then
                            session4 = session
                            bool4 = True
                        End If
                        If bool1 AndAlso bool2 AndAlso bool3 AndAlso bool4 Then
                            Exit For
                        End If
                    Next
                    If bool1 AndAlso bool2 AndAlso bool3 AndAlso bool4 Then
                        '-- have data for all sessions, now process
                        '   We are going to treat this as 2 separate either or transactions.
                        '   Session 1 and 3 will be phase 1
                        '   Session 2 and 4 will be phase 2
                        result = New EitherOrAttendanceResults
                        result.Student = stud

                        If session1.AttendenceStatus = AttendanceStatusEnum.Present AndAlso session3.AttendenceStatus = AttendanceStatusEnum.Absent Then
                            session3.AttendenceStatus = AttendanceStatusEnum.Excused
                            stud.AddToActivityLog("Changing status to excused for either or process (" & session3.StartDate & ").")
                            result.Results = "Session 3 excused"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Absent AndAlso session3.AttendenceStatus = AttendanceStatusEnum.Present Then
                            session1.AttendenceStatus = AttendanceStatusEnum.Excused
                            stud.AddToActivityLog("Changing status to excused for either or process (" & session1.StartDate & ").")
                            result.Results = "Session 1 excused"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Present AndAlso session3.AttendenceStatus = AttendanceStatusEnum.Present Then
                            result.Results = "Present both sessions 1 and 3"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Absent AndAlso session3.AttendenceStatus = AttendanceStatusEnum.Absent Then
                            result.Results = "Absent both sessions 1 and 3"
                        ElseIf session1.AttendenceStatus = AttendanceStatusEnum.Removed OrElse session3.AttendenceStatus = AttendanceStatusEnum.Removed Then
                            result.Results = "At least one removed (1 or 3)"
                        Else
                            result.Results = "Special: Session1=" & session1.AttendenceStatus.ToString() & "; Session3=" & session3.AttendenceStatus.ToString()
                        End If
                        m_result.Add(result)
                        olvStudents.AddObject(result)

                        '-- Now phase 2
                        result = New EitherOrAttendanceResults
                        result.Student = stud

                        If session2.AttendenceStatus = AttendanceStatusEnum.Present AndAlso session4.AttendenceStatus = AttendanceStatusEnum.Absent Then
                            session4.AttendenceStatus = AttendanceStatusEnum.Excused
                            stud.AddToActivityLog("Changing status to excused for either or process (" & session4.StartDate & ").")
                            result.Results = "Session 4 excused"
                        ElseIf session2.AttendenceStatus = AttendanceStatusEnum.Absent AndAlso session4.AttendenceStatus = AttendanceStatusEnum.Present Then
                            session2.AttendenceStatus = AttendanceStatusEnum.Excused
                            stud.AddToActivityLog("Changing status to excused for either or process (" & session2.StartDate & ").")
                            result.Results = "Session 2 excused"
                        ElseIf session2.AttendenceStatus = AttendanceStatusEnum.Present AndAlso session4.AttendenceStatus = AttendanceStatusEnum.Present Then
                            result.Results = "Present both sessions 2 and 4"
                        ElseIf session2.AttendenceStatus = AttendanceStatusEnum.Absent AndAlso session4.AttendenceStatus = AttendanceStatusEnum.Absent Then
                            result.Results = "Absent both sessions 2 and 4"
                        ElseIf session2.AttendenceStatus = AttendanceStatusEnum.Removed OrElse session4.AttendenceStatus = AttendanceStatusEnum.Removed Then
                            result.Results = "At least one removed (2 or 4)"
                        Else
                            result.Results = "Special: Session2=" & session2.AttendenceStatus.ToString() & "; Session4=" & session4.AttendenceStatus.ToString()
                        End If
                        m_result.Add(result)
                        olvStudents.AddObject(result)
                    Else
                        result = New EitherOrAttendanceResults
                        result.Student = stud
                        result.Results = "Student missing attendance data."
                        m_result.Add(result)
                        olvStudents.AddObject(result)
                    End If

                Next

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class