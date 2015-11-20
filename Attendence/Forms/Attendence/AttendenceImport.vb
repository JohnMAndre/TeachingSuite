Public Class AttendenceImport

    Private m_SemesterToImport As Semester

    Public Sub New(filename As String)

        ' This call is required by the designer.
        InitializeComponent()

        m_SemesterToImport = New Semester(filename)
    End Sub

    Private Sub AttendenceImport_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadClassGroups()
    End Sub

    Private Sub LoadClassGroups()
        lstSessions.Items.Clear()
        lstClasses.Items.Clear()
        lstClassGroups.Items.Clear()
        For Each objClassGroup As ClassGroup In m_SemesterToImport.ClassGroups
            lstClassGroups.Items.Add(objClassGroup)
        Next
    End Sub
    Private Sub LoadClasses()
        lstClasses.Items.Clear()
        For Each objClass As SchoolClass In GetSelectedClassGroup.Classes
            lstClasses.Items.Add(objClass)
        Next
    End Sub
    Private Sub LoadSessions()
        lstSessions.Items.Clear()
        For Each objSession As ClassSession In GetSelectedClass.ClassSessions
            lstSessions.Items.Add(objSession)
        Next
    End Sub
    Private Function GetSelectedClassGroup() As ClassGroup
        If lstClassGroups.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstClassGroups.Items(lstClassGroups.SelectedIndex)
        End If
    End Function
    Private Function GetSelectedClass() As SchoolClass
        If lstClasses.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstClasses.Items(lstClasses.SelectedIndex)
        End If
    End Function
    Private Function GetSelectedClassSession() As ClassSession
        If lstSessions.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstSessions.Items(lstSessions.SelectedIndex)
        End If
    End Function

    Private Sub lstClassGroups_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClassGroups.SelectedIndexChanged
        LoadClasses()
    End Sub

    Private Sub lstClasses_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClasses.SelectedIndexChanged
        LoadSessions()
    End Sub

    Private Sub ImportSelectedSessionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportSelectedSessionToolStripMenuItem.Click
        If GetSelectedClassSession() Is Nothing Then
            MessageBox.Show("Please select a session to import first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '-- actually import it
            Dim dt As Date = GetSelectedClassSession.StartDate

            '-- Get the class from ThisSemester to use as target
            Dim objThisClassToUse As SchoolClass
            For Each objThisClassGroup In ThisSemester.ClassGroups
                If objThisClassGroup.Name = GetSelectedClassGroup.Name Then
                    For Each objThisClass As SchoolClass In objThisClassGroup.Classes
                        If objThisClass.Name = GetSelectedClass.Name Then
                            objThisClassToUse = objThisClass
                            Exit For
                        End If
                    Next
                    If objThisClassToUse IsNot Nothing Then
                        Exit For
                    End If
                End If
            Next
            If objThisClassToUse Is Nothing Then
                MessageBox.Show("Cannot find matching class in current semester file as target.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim objTargetStudent As Student = Nothing
                Dim objSession As New ClassSession()
                objSession.StartDate = dt
                GetSelectedClass.ClassSessions.Add(objSession)
                Dim intCounter As Integer
                For Each stu In GetSelectedClass.Students
                   

                    objTargetStudent = GetMatchingStudent(objThisClassToUse, stu.StudentID)
                    If objTargetStudent Is Nothing Then
                        MessageBox.Show("Could not find matching student (ID=" & stu.StudentID, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Continue For '-- process next student
                    Else
                        For Each session As TeachingSession In stu.TeachingSessions
                            If session.StartDate = dt Then
                                objTargetStudent.TeachingSessions.Add(session)
                                If intCounter = 0 Then
                                    '-- Just first time around, add to schoolclass
                                    Dim objClassSession As New ClassSession()
                                    objClassSession.StartDate = session.StartDate
                                    objTargetStudent.SchoolClass.ClassSessions.Add(objClassSession)
                                    objClassSession = Nothing
                                End If
                                intCounter += 1
                            Else
                                Application.DoEvents() '-- ignore
                            End If
                        Next
                    End If
                Next

                lstSessions.Items.Remove(GetSelectedClassSession())
            End If

        End If
    End Sub
    Private Function GetMatchingStudent(clas As SchoolClass, studentID As String) As Student
        For Each stu As Student In clas.Students
            If stu.StudentID = studentID Then
                Return stu
            End If
        Next

        '-- should never get here
        Return Nothing
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
