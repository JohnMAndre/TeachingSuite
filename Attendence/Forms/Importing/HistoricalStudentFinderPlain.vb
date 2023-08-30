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
Public Class HistoricalStudentFinderPlain

    Private m_objSemesterCache As SemesterCache

    Private m_lstFoundStudents As List(Of Student)
    Private m_boolCancel As Boolean
    Private m_boolSearching As Boolean
    Private m_dictMostRecentStudents As New Dictionary(Of String, Student) '-- does not store duplicates (just the most recent incarnation of the student)



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If m_boolSearching Then
            m_boolCancel = True
        Else
            Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            '-- Search each semester for all possible matches
            m_boolSearching = True
            m_boolCancel = False
            btnSearch.Enabled = False

            If txtExtStudentID.Text.Length = 0 AndAlso
                txtEmail.Text.Length = 0 AndAlso
                txtNickname.Text.Length = 0 AndAlso
                txtStudentID.Text.Length = 0 AndAlso
                txtTags.Text.Length = 0 AndAlso
                txtLocalName.Text.Length = 0 Then

                MessageBox.Show("Please enter some search criteria.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            dgvStudents.DataSource = Nothing
            dgvStudents.AutoGenerateColumns = False
            m_lstFoundStudents = New List(Of Student)


            Dim intStudentsSearched As Integer
            Dim boolAtLeastOneNonMatch As Boolean
            Dim strLocalName, strLocalNameLatinLetters As String

            '-- Trying new cache
            For Each sem As CachedSemester In m_objSemesterCache.Semesters
                For Each clsGrp As ClassGroup In sem.ClassGroups
                    For Each cls As SchoolClass In clsGrp.Classes
                        For Each stud As Student In cls.Students
                            intStudentsSearched += 1

                            '-- Now compare, if match, add to list
                            If txtStudentID.Text.Length > 0 AndAlso ((stud.StudentID.ToUpper() = txtStudentID.Text.ToUpper()) OrElse (chkPartials.Checked AndAlso stud.StudentID.ToUpper.Contains(txtStudentID.Text.ToUpper()))) Then
                                '-- match
                                m_lstFoundStudents.Add(stud)
                            ElseIf txtNickname.Text.Length > 0 AndAlso ((stud.Nickname.ToUpper() = txtNickname.Text.ToUpper()) OrElse (chkPartials.Checked AndAlso stud.Nickname.ToUpper.Contains(txtNickname.Text.ToUpper()))) Then
                                m_lstFoundStudents.Add(stud)
                            ElseIf txtExtStudentID.Text.Length > 0 AndAlso ((stud.ExtStudentID.ToUpper() = txtExtStudentID.Text.ToUpper()) OrElse (chkPartials.Checked AndAlso stud.ExtStudentID.ToUpper.Contains(txtExtStudentID.Text.ToUpper()))) Then
                                m_lstFoundStudents.Add(stud)
                            ElseIf txtEmail.Text.Length > 0 AndAlso ((stud.EmailAddress.ToUpper() = txtEmail.Text.ToUpper()) OrElse (chkPartials.Checked AndAlso stud.EmailAddress.ToUpper.Contains(txtEmail.Text.Trim().ToUpper()))) Then
                                m_lstFoundStudents.Add(stud)
                            ElseIf txtTags.Text.Length > 0 AndAlso ((stud.Tags.ToUpper() = txtTags.Text.ToUpper()) OrElse (chkPartials.Checked AndAlso stud.Tags.ToUpper.Contains(txtTags.Text.Trim().ToUpper()))) Then
                                m_lstFoundStudents.Add(stud)
                            ElseIf txtLocalName.Text.Length > 0 Then
                                '-- Now we need to check for multiple names so we can do an AND compare
                                If chkPartials.Checked Then
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
                                            m_lstFoundStudents.Add(stud)
                                        End If
                                    Else
                                        '-- just one name, simple
                                        If stud.LocalNameLatinLetters.ToUpper().Contains(txtLocalName.Text.ToUpper()) OrElse
                                        stud.LocalName.ToUpper().Contains(txtLocalName.Text.ToUpper()) Then
                                            '-- match on name version with and without diacritics
                                            m_lstFoundStudents.Add(stud)
                                        End If
                                    End If
                                Else
                                    If (stud.LocalNameLatinLetters.ToUpper() = txtLocalName.Text.ToUpper()) OrElse
                                        (stud.LocalName.ToUpper() = txtLocalName.Text.ToUpper()) Then
                                        '-- match on name version with and without diacritics
                                        m_lstFoundStudents.Add(stud)
                                    End If

                                End If

                            End If

                            lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
                            lblStudentsFound.Text = m_lstFoundStudents.Count.ToString("#,##0")
                            If m_boolCancel Then
                                Exit For
                            End If
                            Application.DoEvents()
                        Next
                    Next
                Next
            Next

            dgvStudents.DataSource = m_lstFoundStudents

            Try
                dgvStudents.AutoResizeColumns()
            Catch ex As Exception
                Log(ex) '-- Log and continue
            End Try



            btnSearch.Enabled = True
            m_boolSearching = False
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            Timer1.Stop()

            btnSearch.Enabled = False

            '-- Using new semester cache
            m_objSemesterCache = SemesterCache.GetCache()


            btnSearch.Enabled = True
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading cache data: " & ex.Message)
            btnSearch.Enabled = True
        End Try
    End Sub

    Private Sub btnAddToClass_Click(sender As Object, e As EventArgs) Handles btnAddToClass.Click
        Try
            Dim cls As SchoolClass = MainFormReference.GetSelectedClass
            If cls Is Nothing Then
                MessageBox.Show("Please select a class on the main form.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim lstToAdd As List(Of Student) = GetSelectedStudentsFromGrid()
                For Each stud As Student In lstToAdd
                    cls.Students.Add(stud)
                    stud.SchoolClass = cls '-- need to change this or the data is still tied to the other semester (doesn't update but is confusing for user)

                    stud.ClearStudentOfHistoricalData()

                    MessageBox.Show("Added: " & stud.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    AddApplicationHistory("Added historical student (" & stud.ToString() & ") to class (" & cls.ToString() & ").")
                Next

            End If
        Catch ex As Exception
            MessageBox.Show("There was an error adding students to the class (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log(ex)
        End Try
    End Sub
    Private Function GetSelectedStudentsFromGrid() As List(Of Student)
        Dim lstReturn As New List(Of Student)

        Dim cells As DataGridViewSelectedCellCollection

        cells = dgvStudents.SelectedCells

        Dim row As DataGridViewRow
        Dim stud As Student

        Dim dict As New Dictionary(Of Integer, Object)
        For Each cell As DataGridViewCell In cells
            If Not dict.ContainsKey(cell.RowIndex) Then
                dict.Add(cell.RowIndex, Nothing)

                row = dgvStudents.Rows(cell.RowIndex)
                stud = row.DataBoundItem
                If stud IsNot Nothing Then
                    lstReturn.Add(stud)
                End If
            End If
        Next
        Return lstReturn
    End Function

    Private Sub dgvStudents_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStudents.ColumnHeaderMouseClick
        '-- Manually sort
        Try
            Dim col As DataGridViewColumn = dgvStudents.Columns(e.ColumnIndex)
            Dim lst As List(Of Student) = dgvStudents.DataSource
            Dim cmp As IComparer(Of Student)
            Dim boolSort As Boolean = True

            If col IsNot Nothing Then
                Select Case col.DataPropertyName
                    Case "ExtStudentID"
                        cmp = New StudentComparerByExtStudentID
                    Case "StudentID"
                        cmp = New StudentComparerByStudentID
                    Case "StudentTeam"
                        cmp = New StudentComparerByStudentTeam
                    Case "StudentGroup"
                        cmp = New StudentComparerByStudentGroup
                    Case "DateOfBirth"
                        cmp = New StudentComparerByDateOfBirth
                    Case "Gender"
                        cmp = New StudentComparerByGender
                    Case "Tags"
                        cmp = New StudentComparerByTags
                    Case "LatestAttendenceStatus"
                        cmp = New StudentComparerByLatestAttendenceStatus
                    Case "Nickname"
                        cmp = New StudentComparerByNickname
                    Case "LocalName"
                        cmp = New StudentComparerByLocalName
                    Case "AltNumber"
                        cmp = New StudentComparerByAltNumber
                    Case "AdminNumber"
                        cmp = New StudentComparerByAdminNumber
                    Case "TotalAbsences"
                        cmp = New StudentComparerByTotalAbsences
                    Case "CurrentAbsences"
                        cmp = New StudentComparerByCurrentAbsences
                    Case "PresentationQuality"
                        cmp = New StudentComparerByPresentationQuality
                    Case "WritingQuality"
                        cmp = New StudentComparerByWritingQuality
                    Case "AssignmentCount"
                        cmp = New StudentComparerByAssignmentCount
                    Case "ProcessedAssignments"
                        cmp = New StudentComparerByProcessedAssignments
                    Case "Hidden"
                        cmp = New StudentComparerByHidden
                    Case "MeritPoints"
                        cmp = New StudentComparerByMeritPoints
                    Case "PlagiarismSeverity"
                        cmp = New StudentComparerByPlagiarismSeverity
                    Case "DraftsChecked"
                        cmp = New StudentComparerByDraftsChecked
                    Case "OfficeHoursVisited"
                        cmp = New StudentComparerByOfficeHoursVisited
                    Case "ResearchQuality"
                        cmp = New StudentComparerByResearchQuality
                    Case "PerformanceLastOnlineQuiz"
                        cmp = New StudentComparerByPerformanceLastOnlineQuiz
                    Case "LocalNameLatinLetters"
                        cmp = New StudentComparerByLocalNameLatinLetters
                    Case Else
                        boolSort = False
                End Select

                If boolSort Then
                    lst.Sort(cmp)
                    dgvStudents.DataSource = Nothing
                    dgvStudents.Refresh()
                    dgvStudents.DataSource = lst
                    dgvStudents.Refresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error sorting: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvStudents_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvStudents.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                EditSelectedStudent()
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("Error: " + ex.Message, Application.ProductName)
        End Try
    End Sub
    Private Sub EditSelectedStudent()
        Dim lst As List(Of Student) = GetSelectedStudentsFromGrid()

        If lst.Count = 0 Then
            MessageBox.Show("Please select a student first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '-- just take the first one
            Using frm As New StudentDetail(lst(0), False)
                frm.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub HistoricalStudentFinderPlain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-- Do nothing here, do on timer_tick for lazy cross threading
    End Sub

    Private Sub HistoricalStudentFinderPlain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'disabled this because we are not (yet) using the cache file
        ''m_objSemesterCache.SaveCache()
    End Sub
End Class