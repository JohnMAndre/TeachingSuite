Public Class ImportStudentsFromText

    Private m_class As SchoolClass
    Private m_dictHistoricalStudents As New Dictionary(Of String, Student)
    Private m_boolCancel As Boolean
    Private m_lstStudents As List(Of Student)

    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
        lblTitle.Text &= " " & schoolClass.Name
    End Sub
    Private Function GetStudentByID(studentID As String) As Student
        If m_dictHistoricalStudents.ContainsKey(studentID.ToUpper()) Then
            Return m_dictHistoricalStudents(studentID.ToUpper())
        Else
            Return Nothing
        End If
    End Function
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            Dim intStudentsImported As Integer
            Dim objStud, stud As Student '-- stud is existing, objStud is importing
            For Each objStud In m_lstStudents
                '-- First, do we have this student in the system already
                '   if so, keep nickname, email, notes but dump other things like activityLog
                stud = GetStudentByID(objStud.StudentID)

                If stud Is Nothing Then
                    '-- No existing student with that ID

                    objStud.SchoolClass = m_class
                    m_class.Students.Add(objStud)
                Else
                    '-- Do have existing student
                    '   update existing student with new data, if new data exists
                    stud.SchoolClass = m_class
                    If objStud.AdminNumber <> 0 Then
                        stud.AdminNumber = objStud.AdminNumber
                    End If

                    If objStud.AltNumber <> 0 Then
                        stud.AltNumber = objStud.AltNumber
                    End If

                    If objStud.EmailAddress.Trim.Length > 0 Then
                        stud.EmailAddress = objStud.EmailAddress
                    End If

                    If objStud.ExtStudentID.Trim.Length > 0 Then
                        stud.ExtStudentID = objStud.ExtStudentID
                    End If

                    If stud.DateOfBirth = DATE_NO_DATE Then
                        stud.DateOfBirth = objStud.DateOfBirth
                    End If

                    If stud.Gender = Student.GenderEnum.Unknown Then
                        stud.Gender = objStud.Gender
                    End If

                    stud.ActivityLog = String.Empty
                    m_class.ImportStudent(stud)
                End If

                intStudentsImported += 1
            Next

            If intStudentsImported > 0 Then
                MessageBox.Show(intStudentsImported.ToString("#,##0") & " students imported.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
            Else
                Me.DialogResult = DialogResult.Cancel
            End If

            AddApplicationHistory("Imported students from spreadsheet (Class: " & m_class.ToString() & ", Students: " & intStudentsImported.ToString("#,##0") & ").")


            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Try
            'Dim strReport As String = String.Empty
            'Dim strReportPrevious As String = String.Empty
            'Dim swReport1 As New Stopwatch()
            'Dim swReport2 As New Stopwatch()

            Dim ht As New Hashtable() '-- key  = studentID, value = student object
            Dim strBaseHistoryLable As String = lblLoadingHistoricalStudents.Text
            Dim intStudentsAdded, intStudentsSearched As Integer
            Dim lstSemesters As List(Of String) = Semester.ListExistingSemesters()
            Dim semCurrent As Semester
            Dim strFilename As String
            Do
                For intCounter As Integer = lstSemesters.Count - 1 To 0 Step -1 '-- want to use most recent file first
                    strFilename = lstSemesters(intCounter)
                    'swReport2.Restart()
                    semCurrent = New Semester(strFilename)
                    'strReport &= "Loading " & semCurrent.Name & "  " & swReport1.Elapsed.Seconds.ToString("#,##0") & " seconds" & Environment.NewLine
                    'swReport2.Stop()

                    lblLoadingHistoricalStudents.Text = strBaseHistoryLable & semCurrent.Name
                    Application.DoEvents()
                    For Each clsgrp As ClassGroup In semCurrent.ClassGroups
                        'If strReportPrevious.Length > 0 Then
                        '    strReport &= strReportPrevious & "  " & swReport1.Elapsed.Seconds.ToString("#,##0") & " seconds" & Environment.NewLine
                        'End If
                        'swReport1.Restart()
                        'strReportPrevious = "Sem: " & semCurrent.Name & "; Module: " & clsgrp.Name

                        For Each clas As SchoolClass In clsgrp.Classes
                            For Each stud In clas.Students
                                intStudentsSearched += 1
                                '-- add to collection, only if there IS a student ID
                                If Not m_dictHistoricalStudents.ContainsKey(stud.StudentID.ToUpper()) AndAlso stud.StudentID.Trim.Length > 0 Then
                                    m_dictHistoricalStudents.Add(stud.StudentID.ToUpper, stud)
                                    intStudentsAdded += 1
                                End If

                                lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
                                lblStudentsLoaded.Text = intStudentsAdded.ToString("#,##0")
                                If m_boolCancel Then
                                    Exit Do
                                End If
                                Application.DoEvents()
                            Next
                        Next
                    Next
                Next
                Exit Do
            Loop While True

            'System.IO.File.WriteAllText("C:\Teaching\output.txt", strReport)
            lblLoadingHistoricalStudents.Text = "Done"

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading students from earlier semesters. Importing not may not pickup information known about previous students.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblLoadingHistoricalStudents.Visible = False
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "&Close" Then
            Close()
        Else
            btnCancel.Text = "&Close"
            btnOK.Enabled = True
            lblLoadingHistoricalStudents.Visible = False
            m_boolCancel = True
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            m_lstStudents = New List(Of Student)
            Dim objStud As Student
            Dim strRows() As String

            Dim strClipboard As String = Clipboard.GetText()
            If strClipboard Is Nothing Then
                MessageBox.Show("The clipboard is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf Not strClipboard.Contains(vbTab) Then
                If Not strClipboard.Contains(Environment.NewLine) Then
                    MessageBox.Show("The clipboard does not contain multiple lines but it needs to (you can manually enter one student, right?).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    'MessageBox.Show("The clipboard data does not contain tabs. It must be spreadsheet data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '-- Try to use just student IDs
                    strRows = strClipboard.Split(Environment.NewLine)
                    For intCounter As Integer = 0 To strRows.Count - 1
                        '-- pack in the extra data
                        If strRows(intCounter).Trim().Length > 0 Then
                            strRows(intCounter) = (intCounter + 1).ToString() & vbTab & "0" & vbTab & strRows(intCounter).Trim()
                        Else
                            '-- remove the last row, it is bad
                            If intCounter = strRows.Count - 1 Then
                                ReDim Preserve strRows(strRows.Count - 2)
                            End If
                        End If
                    Next
                End If
            ElseIf Not strClipboard.Contains(Environment.NewLine) Then
                MessageBox.Show("The clipboard does not contain multiple lines but it needs to (you can manually enter one student, right?).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim objClass As New SchoolClass(New ClassGroup(New Semester(DUMMY_SEMESTER_NAME))) '-- just a dummy class
            Dim stud As Student

            If strRows Is Nothing Then
                strRows = strClipboard.Split(Environment.NewLine)
            End If

            Dim row() As String
            For intCounter As Integer = 0 To strRows.Count - 1
                If strRows(intCounter).Trim.Length = 0 Then
                    Continue For '-- skip this row, it has no data
                End If
                row = strRows(intCounter).Split(vbTab)
                'If row.Length < 8 Then
                '    If m_lstStudents.Count > 0 Then
                '        '-- we are done
                '        Exit For
                '    Else
                '        MessageBox.Show("There should be 8 columns of data: Admin, Alt, StudentID, Local name, Nickname, Email, ExtID, and Date of Birth (the clipboard has " & row.Length & ").")
                '    End If
                'End If
                objStud = New Student(objClass)
                If IsNumeric(row(0)) Then
                    objStud.AdminNumber = row(0)
                Else
                    objStud.AdminNumber = 0
                End If
                If IsNumeric(row(1)) Then
                    objStud.AltNumber = row(1)
                Else
                    objStud.AltNumber = 0
                End If
                objStud.StudentID = row(2).Trim()

                stud = GetStudentByID(objStud.StudentID)
                If stud IsNot Nothing Then
                    If row.Count > 3 AndAlso row(3).Trim().Length > 0 Then
                        objStud.LocalName = row(3).Trim()
                    Else
                        objStud.LocalName = stud.LocalName
                    End If
                    If row.Count > 4 AndAlso row(4).Trim().Length > 0 Then
                        objStud.Nickname = row(4).Trim()
                    Else
                        objStud.Nickname = stud.Nickname
                    End If
                    If row.Count > 5 AndAlso row(5).Trim().Length > 0 Then
                        objStud.EmailAddress = row(5).Trim()
                    Else
                        objStud.EmailAddress = stud.EmailAddress
                    End If
                    If row.Count > 6 AndAlso row(6).Trim().Length > 0 Then
                        objStud.ExtStudentID = row(6).Trim()
                    Else
                        objStud.ExtStudentID = stud.ExtStudentID
                    End If
                    If row.Count > 7 AndAlso row(7).Trim().Length > 0 Then
                        If IsDate(row(7)) Then
                            objStud.DateOfBirth = row(7)
                        Else
                            objStud.DateOfBirth = DATE_NO_DATE
                        End If
                    Else
                        objStud.DateOfBirth = stud.DateOfBirth
                    End If
                    If row.Count > 8 AndAlso row(8).Trim().Length > 0 Then
                        If row(8).ToLower() = "m" OrElse row(8).ToLower() = "male" Then
                            objStud.Gender = Student.GenderEnum.Male
                        ElseIf row(8).ToLower() = "f" OrElse row(8).ToLower() = "female" Then
                            objStud.Gender = Student.GenderEnum.Female
                        Else
                            objStud.Gender = stud.Gender
                        End If
                    Else
                        '-- Nothing in the import so just use whatever we knew before (
                        objStud.Gender = stud.Gender
                    End If
                Else
                    '-- New student
                    If row.Count > 3 Then
                        objStud.LocalName = row(3).Trim()
                    End If
                    If row.Count > 4 Then
                        objStud.Nickname = row(4).Trim()
                    End If
                    If row.Count > 5 Then
                        objStud.EmailAddress = row(5).Trim()
                    End If
                    If row.Count > 6 Then
                        objStud.ExtStudentID = row(6).Trim()
                    End If
                    If row.Count > 7 Then
                        If IsDate(row(7)) Then
                            objStud.DateOfBirth = row(7)
                        Else
                            objStud.DateOfBirth = DATE_NO_DATE
                        End If
                    End If
                    If row.Count > 8 Then
                        If row(8).Trim().Length > 0 Then
                            If row(8).ToLower() = "m" OrElse row(8).ToLower() = "male" Then
                                objStud.Gender = Student.GenderEnum.Male
                            ElseIf row(8).ToLower() = "f" OrElse row(8).ToLower() = "female" Then
                                objStud.Gender = Student.GenderEnum.Female
                            End If
                        End If
                    End If
                End If

                m_lstStudents.Add(objStud)
            Next

            '-- Add to DGV
            dgvStudents.AutoGenerateColumns = False
            dgvStudents.DataSource = m_lstStudents

            Try
                dgvStudents.AutoResizeColumns()
            Catch ex As Exception
                Log(ex) '-- Log and continue
            End Try


            btnOK.Enabled = True

        Catch ex As Exception
            MessageBox.Show("There was a problem pasting (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
