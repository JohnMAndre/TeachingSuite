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
Public Class HistoricalStudentFinder

    Private m_objSemesterCache As SemesterCache

    Private m_lstFoundStudents As List(Of Student)
    Private m_boolCancel As Boolean
    Private m_boolSearching As Boolean
    Private m_dictMostRecentStudents As New Dictionary(Of String, Student) '-- does not store duplicates (just the most recent incarnation of the student)

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If m_boolSearching Then
            m_boolCancel = True
        Else
            Close()
        End If
    End Sub
    Private Function GetStudentByID(studentID As String) As Student
        If m_dictMostRecentStudents.ContainsKey(studentID.ToUpper()) Then
            Return m_dictMostRecentStudents(studentID.ToUpper())
        Else
            Return Nothing
        End If
    End Function
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try

            Timer1.Stop()
            'Dim ht As New Hashtable() '-- key  = studentID, value = student object
            'm_lstFoundStudents = New List(Of Student)
            'm_boolSearching = True

            'Dim intStudentsAdded, intStudentsSearched As Integer
            'Dim lstSemesters As List(Of String) = Semester.ListExistingSemesters()
            'Dim semCurrent As Semester
            'Dim strFilename As String
            'Do
            '    For intCounter As Integer = lstSemesters.Count - 1 To 0 Step -1 '-- want to use most recent file first
            '        strFilename = lstSemesters(intCounter)
            '        semCurrent = New Semester(strFilename)
            '        For Each clsgrp As ClassGroup In semCurrent.ClassGroups
            '            For Each clas As SchoolClass In clsgrp.Classes
            '                m_lstFoundStudents.AddRange(clas.Students)
            '                For Each stud In clas.Students
            '                    intStudentsSearched += 1
            '                    '-- add to collection, only if there IS a student ID
            '                    If Not m_dictMostRecentStudents.ContainsKey(stud.StudentID.ToUpper()) AndAlso stud.StudentID.Trim.Length > 0 Then
            '                        m_dictMostRecentStudents.Add(stud.StudentID.ToUpper, stud)
            '                        intStudentsAdded += 1
            '                    End If

            '                    lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
            '                    lblStudentsLoaded.Text = intStudentsAdded.ToString("#,##0")
            '                    If m_boolCancel Then
            '                        Exit Do
            '                    End If
            '                    Application.DoEvents()
            '                Next
            '            Next
            '        Next
            '    Next
            '    Exit Do
            'Loop While True

            '-- Trying new semester cache
            m_objSemesterCache = SemesterCache.GetCache()


            btnSearch.Enabled = True
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading historical data: " & ex.Message)
            btnSearch.Enabled = True
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            '-- Search each semester for all possible matches
            m_boolSearching = True
            m_boolCancel = False
            btnSearch.Enabled = False

            If txtExtStudentID.Text.Length = 0 AndAlso
                txtEmail.Text.Length = 0 AndAlso
                txtNickName.Text.Length = 0 AndAlso
                txtStudentID.Text.Length = 0 AndAlso
                txtLocalName.Text.Length = 0 Then

                MessageBox.Show("Please enter some search criteria.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            lblStudentsSearched.Show()
            lblStudentsSearchedCaption.Show()

            olvStudents.ClearObjects()

            Dim intStudentsSearched As Integer
            Dim boolAtLeastOneNonMatch As Boolean
            Dim strLocalName, strLocalNameLatinLetters As String

            'For Each stud In m_lstFoundStudents
            '    intStudentsSearched += 1

            '    '-- Now compare, if match, add to list
            '    If txtStudentID.Text.Length > 0 AndAlso stud.StudentID.ToUpper() = txtStudentID.Text.ToUpper() Then
            '        '-- match
            '        olvStudents.AddObject(stud)
            '    ElseIf txtNickName.Text.Length > 0 AndAlso stud.Nickname.ToUpper() = txtNickName.Text.ToUpper() Then
            '        olvStudents.AddObject(stud)
            '    ElseIf txtExtStudentID.Text.Length > 0 AndAlso stud.ExtStudentID.ToUpper() = txtExtStudentID.Text.ToUpper() Then
            '        olvStudents.AddObject(stud)
            '    ElseIf txtEmail.Text.Length > 0 AndAlso stud.EmailAddress.ToUpper() = txtEmail.Text.ToUpper() Then
            '        olvStudents.AddObject(stud)
            '    ElseIf txtLocalName.Text.Length > 0 Then
            '        '-- Now we need to check for multiple names so we can do an AND compare
            '        If txtLocalName.Text.Contains(" ") Then
            '            Dim strNameForSearch As String
            '            strNameForSearch = txtLocalName.Text.Replace("  ", " ").ToUpper() '-- remove multiple sequential spaces
            '            strNameForSearch = strNameForSearch.Replace("  ", " ") '-- should change this to regex one day
            '            strNameForSearch = strNameForSearch.Replace("  ", " ")
            '            Dim names() As String = strNameForSearch.Split(" ")
            '            strLocalName = stud.LocalName.ToUpper() '-- save some processing for multiple names
            '            strLocalNameLatinLetters = stud.LocalNameLatinLetters.ToUpper()

            '            boolAtLeastOneNonMatch = False '-- reset for this iteration
            '            For Each name As String In names
            '                If Not strLocalNameLatinLetters.Contains(name) AndAlso _
            '                    Not strLocalName.Contains(name) Then
            '                    '-- at least one of the multiple names did not match
            '                    boolAtLeastOneNonMatch = True
            '                    Exit For
            '                End If
            '            Next

            '            If boolAtLeastOneNonMatch Then
            '                Application.DoEvents() '-- we're done, no match on this student
            '            Else
            '                '-- this student contains all of the multiple names
            '                olvStudents.AddObject(stud)
            '            End If
            '        Else
            '            '-- just one name, simple
            '            If stud.LocalNameLatinLetters.ToUpper().Contains(txtLocalName.Text.ToUpper()) OrElse _
            '                stud.LocalName.ToUpper().Contains(txtLocalName.Text.ToUpper()) Then
            '                '-- match on name version with and without diacritics
            '                olvStudents.AddObject(stud)
            '            End If
            '        End If
            '    End If

            '    lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
            '    If m_boolCancel Then
            '        Exit For
            '    End If
            '    Application.DoEvents()
            'Next

            '-- Trying new cache
            For Each sem As CachedSemester In m_objSemesterCache.Semesters
                For Each clsGrp As ClassGroup In sem.ClassGroups
                    For Each cls As SchoolClass In clsGrp.Classes
                        For Each stud As Student In cls.Students
                            intStudentsSearched += 1

                            '-- Now compare, if match, add to list
                            If txtStudentID.Text.Length > 0 AndAlso stud.StudentID.ToUpper() = txtStudentID.Text.ToUpper() Then
                                '-- match
                                olvStudents.AddObject(stud)
                            ElseIf txtNickName.Text.Length > 0 AndAlso stud.Nickname.ToUpper() = txtNickName.Text.ToUpper() Then
                                olvStudents.AddObject(stud)
                            ElseIf txtExtStudentID.Text.Length > 0 AndAlso stud.ExtStudentID.ToUpper() = txtExtStudentID.Text.ToUpper() Then
                                olvStudents.AddObject(stud)
                            ElseIf txtEmail.Text.Length > 0 AndAlso stud.EmailAddress.ToUpper() = txtEmail.Text.ToUpper() Then
                                olvStudents.AddObject(stud)
                            ElseIf txtLocalName.Text.Length > 0 Then
                                '-- Now we need to check for multiple names so we can do an AND compare
                                If txtLocalName.Text.Contains(" ") Then
                                    Dim strNameForSearch As String
                                    strNameForSearch = txtLocalName.Text.Replace("  ", " ").ToUpper() '-- remove multiple sequential spaces
                                    strNameForSearch = strNameForSearch.Replace("  ", " ") '-- should change this to regex one day
                                    strNameForSearch = strNameForSearch.Replace("  ", " ")
                                    Dim names() As String = strNameForSearch.Split(" ")
                                    strLocalName = stud.LocalName.ToUpper() '-- save some processing for multiple names
                                    strLocalNameLatinLetters = stud.LocalNameLatinLetters.ToUpper()

                                    boolAtLeastOneNonMatch = False '-- reset for this iteration
                                    For Each name As String In names
                                        If Not strLocalNameLatinLetters.Contains(name) AndAlso
                                            Not strLocalName.Contains(name) Then
                                            '-- at least one of the multiple names did not match
                                            boolAtLeastOneNonMatch = True
                                            Exit For
                                        End If
                                    Next

                                    If boolAtLeastOneNonMatch Then
                                        Application.DoEvents() '-- we're done, no match on this student
                                    Else
                                        '-- this student contains all of the multiple names
                                        olvStudents.AddObject(stud)
                                    End If
                                Else
                                    '-- just one name, simple
                                    If stud.LocalNameLatinLetters.ToUpper().Contains(txtLocalName.Text.ToUpper()) OrElse
                                        stud.LocalName.ToUpper().Contains(txtLocalName.Text.ToUpper()) Then
                                        '-- match on name version with and without diacritics
                                        olvStudents.AddObject(stud)
                                    End If
                                End If
                            End If

                            lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
                            If m_boolCancel Then
                                Exit For
                            End If
                            Application.DoEvents()
                        Next
                    Next
                Next
            Next


            '-- New cache but only full-match style
            'For Each sem As CachedSemester In m_objSemesterCache.Semesters
            '    For Each clsGrp As ClassGroup In sem.ClassGroups
            '        For Each cls As SchoolClass In clsGrp.Classes
            '            For Each stud As Student In cls.Students
            '                intStudentsSearched += 1

            '                '-- Now compare, if match, add to list
            '                If txtStudentID.Text.Length > 0 AndAlso stud.StudentID.ToUpper() = txtStudentID.Text.ToUpper() Then
            '                    '-- match
            '                    olvStudents.AddObject(stud)
            '                ElseIf txtNickName.Text.Length > 0 AndAlso stud.Nickname.ToUpper() = txtNickName.Text.ToUpper() Then
            '                    olvStudents.AddObject(stud)
            '                ElseIf txtExtStudentID.Text.Length > 0 AndAlso stud.ExtStudentID.ToUpper() = txtExtStudentID.Text.ToUpper() Then
            '                    olvStudents.AddObject(stud)
            '                ElseIf txtEmail.Text.Length > 0 AndAlso stud.EmailAddress.ToUpper() = txtEmail.Text.ToUpper() Then
            '                    olvStudents.AddObject(stud)
            '                ElseIf txtLocalName.Text.Length > 0 Then
            '                    '-- Now we need to check for multiple names so we can do an AND compare
            '                    If txtLocalName.Text.Contains(" ") Then
            '                        Dim strNameForSearch As String
            '                        strNameForSearch = txtLocalName.Text.Replace("  ", " ").ToUpper() '-- remove multiple sequential spaces
            '                        strNameForSearch = strNameForSearch.Replace("  ", " ") '-- should change this to regex one day
            '                        strNameForSearch = strNameForSearch.Replace("  ", " ")
            '                        Dim names() As String = strNameForSearch.Split(" ")
            '                        strLocalName = stud.LocalName.ToUpper() '-- save some processing for multiple names
            '                        strLocalNameLatinLetters = stud.LocalNameLatinLetters.ToUpper()

            '                        boolAtLeastOneNonMatch = False '-- reset for this iteration
            '                        For Each name As String In names
            '                            If Not strLocalNameLatinLetters.Contains(name) AndAlso
            '                                Not strLocalName.Contains(name) Then
            '                                '-- at least one of the multiple names did not match
            '                                boolAtLeastOneNonMatch = True
            '                                Exit For
            '                            End If
            '                        Next

            '                        If boolAtLeastOneNonMatch Then
            '                            Application.DoEvents() '-- we're done, no match on this student
            '                        Else
            '                            '-- this student contains all of the multiple names
            '                            olvStudents.AddObject(stud)
            '                        End If
            '                    Else
            '                        '-- just one name, simple
            '                        If stud.LocalNameLatinLetters.ToUpper().Contains(txtLocalName.Text.ToUpper()) OrElse
            '                            stud.LocalName.ToUpper().Contains(txtLocalName.Text.ToUpper()) Then
            '                            '-- match on name version with and without diacritics
            '                            olvStudents.AddObject(stud)
            '                        End If
            '                    End If
            '                End If

            '                lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
            '                If m_boolCancel Then
            '                    Exit For
            '                End If
            '                Application.DoEvents()
            '            Next
            '        Next
            '    Next
            'Next


            btnSearch.Enabled = True
            m_boolSearching = False
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error searching: " & ex.Message)
        End Try

    End Sub

    Private Sub txtLocalName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLocalName.TextChanged
        Dim boolEnableAll As Boolean = txtLocalName.Text.Length = 0

        txtEmail.Enabled = boolEnableAll
        txtNickName.Enabled = boolEnableAll
        txtExtStudentID.Enabled = boolEnableAll
        txtStudentID.Enabled = boolEnableAll
    End Sub

    Private Sub txtNickName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNickName.TextChanged
        Dim boolEnableAll As Boolean = txtNickName.Text.Length = 0

        txtEmail.Enabled = boolEnableAll
        txtLocalName.Enabled = boolEnableAll
        txtExtStudentID.Enabled = boolEnableAll
        txtStudentID.Enabled = boolEnableAll
    End Sub

    Private Sub txtStudentID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStudentID.TextChanged
        Dim boolEnableAll As Boolean = txtStudentID.Text.Length = 0

        txtEmail.Enabled = boolEnableAll
        txtLocalName.Enabled = boolEnableAll
        txtExtStudentID.Enabled = boolEnableAll
        txtNickName.Enabled = boolEnableAll
    End Sub

    Private Sub txtEmail_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmail.TextChanged
        Dim boolEnableAll As Boolean = txtEmail.Text.Length = 0

        txtStudentID.Enabled = boolEnableAll
        txtLocalName.Enabled = boolEnableAll
        txtExtStudentID.Enabled = boolEnableAll
        txtNickName.Enabled = boolEnableAll
    End Sub

    Private Sub txtExtStudentID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtExtStudentID.TextChanged
        Dim boolEnableAll As Boolean = txtExtStudentID.Text.Length = 0

        txtStudentID.Enabled = boolEnableAll
        txtLocalName.Enabled = boolEnableAll
        txtEmail.Enabled = boolEnableAll
        txtNickName.Enabled = boolEnableAll
    End Sub

    Private Sub btnAddStudentToClass_Click(sender As System.Object, e As System.EventArgs) Handles btnAddStudentToClass.Click
        Try
            Dim cls As SchoolClass = MainFormReference.GetSelectedClass
            If cls Is Nothing Then
                MessageBox.Show("Please select a class on the main form.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim stud As Student = CType(olvStudents.SelectedObject, Student)
                cls.Students.Add(stud)
                stud.SchoolClass = cls '-- need to change this or the data is still tied to the other semester (doesn't update but is confusing for user)

                stud.ClearStudentOfHistoricalData()

                olvStudents.RemoveObject(stud)

                AddApplicationHistory("Added historical student (" & stud.ToString() & ") to class (" & cls.ToString() & ").")

            End If
        Catch ex As Exception
            MessageBox.Show("There was an error adding students to the class (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log(ex)
        End Try
    End Sub

    Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
        EditSelectedStudent()
    End Sub
    Private Sub EditSelectedStudent()
        Using frm As New StudentDetail(CType(olvStudents.SelectedObject, Student), False)
            If frm.ShowDialog = DialogResult.OK Then
                olvStudents.RefreshSelectedObjects()
            End If
        End Using
    End Sub


    Private Sub HistoricalStudentFinder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '-- Save cache
        m_objSemesterCache.SaveCache()
    End Sub
End Class
