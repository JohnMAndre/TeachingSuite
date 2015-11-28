Public Class ImportAddDropStudents

    Private m_class As SchoolClass
    Private m_dictHistoricalStudents As New Dictionary(Of String, Student)
    Private m_boolCancel As Boolean
    Private m_lstStudentsToAdd As List(Of Student)
    Private m_lstStudentsToDrop As List(Of Student)


    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
        Me.Text &= " - " & schoolClass.Name
    End Sub
    Private Function GetStudentByID(studentID As String) As Student
        If m_dictHistoricalStudents.ContainsKey(studentID.ToUpper()) Then
            Return m_dictHistoricalStudents(studentID.ToUpper())
        Else
            Return Nothing
        End If
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        m_boolCancel = True
        Close()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            m_lstStudentsToAdd = New List(Of Student)
            m_lstStudentsToDrop = New List(Of Student)

            Dim objStud As Student

            Dim strClipboard As String = Clipboard.GetText()
            If strClipboard Is Nothing Then
                MessageBox.Show("The clipboard is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(vbTab) Then
                MessageBox.Show("The clipboard data does not contain tabs. It must be spreadsheet data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(Environment.NewLine) Then
                MessageBox.Show("The clipboard does not contain multiple lines but it needs to (you can manually process one student, right?).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim objClass As New SchoolClass(New ClassGroup(New Semester("dummy"))) '-- just a dummy class
                Dim stud As Student
                Dim intStudentsProcessed As Integer
                Dim strRows() As String
                strRows = strClipboard.Split(Environment.NewLine)
                Dim row() As String
                For intCounter As Integer = 0 To strRows.Count - 1
                    row = strRows(intCounter).Split(vbTab)
                    If row.Length < 7 Then
                        If intStudentsProcessed > 0 Then
                            '-- we are done
                            Exit For
                        Else
                            MessageBox.Show("There should be 7 columns of data: Admin, Alt, StudentID, Local name, Nickname, Email, and ExtID (the clipboard has " & row.Length & ").")
                        End If
                    End If

                    intStudentsProcessed += 1

                    '-- Create the student from everything known in data file
                    '   Then either put this student in ADD or DROP list

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
                        If row(3).Trim().Length > 0 Then
                            objStud.LocalName = row(3).Trim()
                        Else
                            objStud.LocalName = stud.LocalName
                        End If
                        If row(4).Trim().Length > 0 Then
                            objStud.Nickname = row(4).Trim()
                        Else
                            objStud.Nickname = stud.Nickname
                        End If
                        If row(5).Trim().Length > 0 Then
                            objStud.EmailAddress = row(5).Trim()
                        Else
                            objStud.EmailAddress = stud.EmailAddress
                        End If
                        If row(6).Trim().Length > 0 Then
                            objStud.ExtStudentID = row(6).Trim()
                        Else
                            objStud.ExtStudentID = stud.ExtStudentID
                        End If
                    Else
                        objStud.LocalName = row(3).Trim()
                        objStud.Nickname = row(4).Trim()
                        objStud.EmailAddress = row(5).Trim()
                        objStud.ExtStudentID = row(6).Trim()
                    End If

                    Dim objExistingStudent As Student = StudentIsInClassAlready(objStud.StudentID)
                    If objExistingStudent Is Nothing Then
                        '-- must be an add
                        m_lstStudentsToAdd.Add(objStud)
                        objStud.TempTag = "Stay"
                    Else
                        '-- Flag student to stay when we detect drops, this student was and is in the correct class
                        objExistingStudent.TempTag = "Stay"
                    End If

                    

                Next

                For Each stud In m_class.Students
                    If stud.TempTag = "Stay" Then
                        '-- Do nothing
                    Else
                        '-- must be a drop 
                        m_lstStudentsToDrop.Add(stud)
                    End If
                Next

                olvStudentsToAdd.SetObjects(m_lstStudentsToAdd)
                olvStudentsToDrop.SetObjects(m_lstStudentsToDrop)

            End If
        Catch ex As Exception
            MessageBox.Show("There was a problem pasting (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function StudentIsInClassAlready(studentID As String) As Student
        For Each stud As Student In m_class.Students
            If stud.StudentID = studentID Then
                Return stud '-- return found student for processing / tagging

            End If
        Next

        '-- if we get here, we did not find the student
        Return Nothing
    End Function
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Dim ht As New Hashtable() '-- key  = studentID, value = student object

        Dim intStudentsAdded, intStudentsSearched As Integer
        Dim lstSemesters As List(Of String) = Semester.ListExistingSemesters()
        Dim semCurrent As Semester
        Dim strFilename As String
        Do
            For intCounter As Integer = lstSemesters.Count - 1 To 0 Step -1 '-- want to use most recent file first
                strFilename = lstSemesters(intCounter)
                semCurrent = New Semester(strFilename)
                For Each clsgrp As ClassGroup In semCurrent.ClassGroups
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

        btnProcess.Enabled = True
        PasteToolStripMenuItem.Enabled = True
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Try
            For Each stud In m_lstStudentsToAdd
                '-- Add to the class
                m_class.Students.Add(stud)
                stud.AddToActivityLog("Added from add/drop process.")
            Next

            For Each stud In m_lstStudentsToDrop
                '-- Add the tag "dropped" to the student
                '   Do not delete them just to be safe
                stud.Tags &= " Dropped " & Date.Now.ToString()
            Next

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("There was a problem processing the data (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        m_boolCancel = True
        Close()
    End Sub
End Class