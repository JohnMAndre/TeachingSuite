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
Public Class AssignChoicesToStudents

#Region " module-level stuff "
    Public Class Choice
        Implements IComparer(Of Choice)

        Public Property ChoiceID As Integer
        Public Property ShortName As String
        Public Property LongName As String

        Public Function Compare(x As Choice, y As Choice) As Integer Implements IComparer(Of Choice).Compare
            Return x.ChoiceID.CompareTo(y.ChoiceID)
        End Function
    End Class

    Public Class StudentPreference
        'Implements IComparer(Of StudentPreference)

        Public Property StudentID As String
        Public Property PreferenceOrder As Integer
        Public Property ChoiceID As Integer
        Public Property StudentGrade As Integer

        'Public Function Compare(x As StudentPreference, y As StudentPreference) As Integer Implements IComparer(Of StudentPreference).Compare
        '    Dim strX As String = x.StudentID & x.PreferenceOrder.ToString("000")
        '    Dim strY As String = y.StudentID & y.PreferenceOrder.ToString("000")
        '    Return strX.CompareTo(strY)
        'End Function
    End Class
    Public Class AssignedChoice
        Public Property StudentID As String
        Public Property PreferenceOrder As Integer
        Public Property ChoiceID As Integer
        Public Property ShortName As String
        Public Property LongName As String
    End Class

    Private m_strOutputFilename As String
    Private m_lstChoices As List(Of Choice)
    Private m_lstPreferences As New List(Of StudentPreference)
    Private m_lstAllStudents As List(Of Student)
#End Region

    Public Sub New(students As List(Of Student))

        ' This call is required by the designer.
        InitializeComponent()

        m_lstAllStudents = students

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If m_lstChoices Is Nothing Then
            MessageBox.Show("Please load some choices first.", "Missing choices", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If m_lstChoices.Count = 0 Then
                MessageBox.Show("Please load some choices first.", "Missing choices", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If m_lstPreferences Is Nothing Then
            If MessageBox.Show("Do you want to just randomly assign choices to students?.", "Missing preferences", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Else
            If m_lstPreferences.Count = 0 Then
                If MessageBox.Show("Do you want to just randomly assign choices to students?.", "Missing preferences", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV files|*.csv"
        sfd.OverwritePrompt = True
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            m_strOutputFilename = sfd.FileName

            GenerateOutputFile()
        End If
    End Sub

    Private Sub GenerateOutputFile()
        Try
            '-- First, check if we have enough choices
            '   count the students
            Dim intStudents As Integer
            Dim dicStudents As New Dictionary(Of String, Object)
            For Each pref As StudentPreference In m_lstPreferences
                If Not dicStudents.ContainsKey(pref.StudentID) Then
                    intStudents += 1
                    dicStudents.Add(pref.StudentID, Nothing)
                End If
            Next

            Dim intChoicesNeeded As Integer = intStudents * nudChoicesPerStudent.Value

            If intChoicesNeeded > m_lstChoices.Count Then
                MessageBox.Show("Choices needed:   " & intChoicesNeeded.ToString("#,##0") & Environment.NewLine &
                                "Choices available: " & m_lstChoices.Count.ToString("#,##0") & Environment.NewLine &
                                "You need more choices or fewer choices per student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim dicStudentsFullyProcessed As New Dictionary(Of String, Object)
            Dim dicChoicesToProcess As New Dictionary(Of Integer, Object)

            Dim intMaxChoices As Integer = nudChoicesPerStudent.Value

            '-- Convert choices list into dictionary so we can more quickly search
            For Each choi As Choice In m_lstChoices
                dicChoicesToProcess.Add(choi.ChoiceID, choi)
            Next

            Dim intChoicesAssignedToCurrentStudent As Integer
            Dim strCurrentStudentID As String = String.Empty
            Dim objChoice As Choice
            Dim objAssigned As AssignedChoice
            Dim lstAssigned As New List(Of AssignedChoice)

            '-- We have to process all the preference records before randomly assigning any choices
            '   because we don't want a student to lose their preference simply due to random assignment

            '-- Output file will be written: StudentID, CompanyID, Short, Long, StudentPreference

            '-- Process students with preference records
            For Each pref As StudentPreference In m_lstPreferences
                '-- Should be walking through in order (highest grade, lowest preference first)
                If strCurrentStudentID = pref.StudentID And intChoicesAssignedToCurrentStudent = intMaxChoices Then
                    '-- We have fully processed this student, skip to next record
                    Continue For
                End If

                If strCurrentStudentID.Length > 0 Then
                    If strCurrentStudentID <> pref.StudentID Then
                        '-- Reset for next student
                        strCurrentStudentID = pref.StudentID
                        intChoicesAssignedToCurrentStudent = 0
                    End If
                Else
                    strCurrentStudentID = pref.StudentID
                End If

                If dicChoicesToProcess.ContainsKey(pref.ChoiceID) Then
                    '-- The choice is there, assign it
                    objChoice = dicChoicesToProcess(pref.ChoiceID)

                    intChoicesAssignedToCurrentStudent += 1
                    objAssigned = New AssignedChoice
                    objAssigned.StudentID = strCurrentStudentID
                    objAssigned.PreferenceOrder = pref.PreferenceOrder
                    objAssigned.ChoiceID = pref.ChoiceID
                    objAssigned.ShortName = objChoice.ShortName
                    objAssigned.LongName = objChoice.LongName
                    lstAssigned.Add(objAssigned)

                    dicChoicesToProcess.Remove(pref.ChoiceID)
                    m_lstChoices.Remove(objChoice)
                Else
                    '-- The choice does not exist, so we ignore this record and continue to next pref record
                End If

            Next

            strCurrentStudentID = String.Empty

            Using sw As System.IO.StreamWriter = System.IO.File.CreateText(m_strOutputFilename)
                sw.WriteLine("StudentID,CompanyID,Preference,ShortName,LongName")
                For Each objAssigned In lstAssigned
                    '-- Did we fully process the previous student? If not, add random records
                    '-- need to randomly assign choices to fill student
                    '   If fully processed, this will be skipped over
                    If strCurrentStudentID.Length > 0 Then
                        If strCurrentStudentID <> objAssigned.StudentID Then
                            If intChoicesAssignedToCurrentStudent < intMaxChoices Then
                                '-- Need to fully process student
                                Do Until intChoicesAssignedToCurrentStudent = intMaxChoices
                                    Dim rnd As New Random()
                                    Dim int As Integer = rnd.NextDouble * (m_lstChoices.Count - 1)
                                    objChoice = m_lstChoices(int)

                                    intChoicesAssignedToCurrentStudent += 1
                                    sw.WriteLine("""" & strCurrentStudentID & """," & objChoice.ChoiceID.ToString() & ",0,""" & objChoice.ShortName & """,""" & objChoice.LongName & """")

                                    m_lstChoices.Remove(objChoice)

                                    Application.DoEvents()
                                Loop
                            End If

                            '-- Flag this student as done
                            dicStudentsFullyProcessed.Add(strCurrentStudentID, Nothing)

                            '-- Reset for next student
                            strCurrentStudentID = objAssigned.StudentID
                            intChoicesAssignedToCurrentStudent = 0
                        End If
                    Else
                        strCurrentStudentID = objAssigned.StudentID
                    End If

                    intChoicesAssignedToCurrentStudent += 1
                    sw.WriteLine("""" & objAssigned.StudentID & """," & objAssigned.ChoiceID & "," & objAssigned.PreferenceOrder.ToString() & ",""" & objAssigned.ShortName & """,""" & objAssigned.LongName & """")
                Next

                '-- Next, process students in overall list but without preference records
                For Each stud As Student In m_lstAllStudents
                    If Not dicStudentsFullyProcessed.ContainsKey(stud.StudentID) Then
                        intChoicesAssignedToCurrentStudent = 0
                        '-- Need to fully process student
                        Do Until intChoicesAssignedToCurrentStudent = intMaxChoices
                            Dim rnd As New Random()
                            Dim int As Integer = rnd.NextDouble * (m_lstChoices.Count - 1)
                            objChoice = m_lstChoices(int)

                            intChoicesAssignedToCurrentStudent += 1
                            sw.WriteLine("""" & stud.StudentID & """," & objChoice.ChoiceID.ToString() & ",0,""" & objChoice.ShortName & """,""" & objChoice.LongName & """")

                            'dicChoicesToProcess.Remove(objChoice.ChoiceID)
                            m_lstChoices.Remove(objChoice)

                            Application.DoEvents()
                        Loop

                        '-- Flag this student as done
                        dicStudentsFullyProcessed.Add(stud.StudentID, Nothing)
                    End If
                Next

            End Using

            Me.Text = "Done: " & Date.Now.ToString()
            btnOK.Enabled = False

            Application.DoEvents()
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error processing: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-- This is to sort is descending order by grade so far
    Private Function CompareStudentsByGrade(student1 As StudentPreference, student2 As StudentPreference) As Integer
        '-- Sort by grade & studentID & prefOrder
        If student2.StudentGrade = student1.StudentGrade Then
            If student2.StudentID = student1.StudentID Then
                If student1.PreferenceOrder = student2.PreferenceOrder Then
                    Return 0 '-- equal in every way we care about
                Else
                    Return student1.PreferenceOrder.CompareTo(student2.PreferenceOrder) '-- ascending
                End If
            Else
                Return student2.StudentID.CompareTo(student1.StudentID) '-- desc
            End If
        Else
            Return student2.StudentGrade.CompareTo(student1.StudentGrade) '-- desc
        End If
    End Function

    Private Sub llblLoadChoices_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoadChoices.LinkClicked
        Try
            m_lstChoices = New List(Of Choice)
            Dim objChoice As Choice
            Dim strRows() As String

            Dim strClipboard As String = Clipboard.GetText()
            If strClipboard Is Nothing Then
                MessageBox.Show("The clipboard is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf Not strClipboard.Contains(vbTab) Then
                If Not strClipboard.Contains(Environment.NewLine) Then
                    MessageBox.Show("The clipboard does not contain multiple lines but it needs to.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            ElseIf Not strClipboard.Contains(Environment.NewLine) Then
                MessageBox.Show("The clipboard does not contain multiple lines but it needs to.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            strRows = strClipboard.Split(Environment.NewLine)

            Dim row() As String
            For intCounter As Integer = 0 To strRows.Count - 1
                If strRows(intCounter).Trim.Length = 0 Then
                    Continue For '-- skip this row, it has no data
                End If
                row = strRows(intCounter).Split(vbTab)
                objChoice = New Choice()
                If IsNumeric(row(0)) Then
                    objChoice.ChoiceID = row(0)
                Else
                    objChoice.ChoiceID = 0
                End If
                objChoice.ShortName = row(1).Trim()
                objChoice.LongName = row(2).Trim()

                m_lstChoices.Add(objChoice)
            Next

            m_lstChoices.Sort(AddressOf SortChoices)

            '-- Add to DGV
            dgvChoices.AutoGenerateColumns = False
            dgvChoices.DataSource = m_lstChoices

            Try
                dgvChoices.AutoResizeColumns()
            Catch ex As Exception
                Log(ex) '-- Log and continue
            End Try

            btnOK.Enabled = True

        Catch ex As Exception
            MessageBox.Show("There was a problem pasting (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function SortChoices(choice1 As Choice, choice2 As Choice) As Integer
        Return choice1.ChoiceID.CompareTo(choice2.ChoiceID)
    End Function

    Private Sub llblLoadPreferences_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoadPreferences.LinkClicked

        Dim strErrorZone As String = String.Empty

        Try
            m_lstPreferences.Clear()
            Dim objPref As StudentPreference
            Dim strRows() As String

            Dim strClipboard As String = Clipboard.GetText()
            If strClipboard Is Nothing Then
                MessageBox.Show("The clipboard is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf Not strClipboard.Contains(vbTab) Then
                If Not strClipboard.Contains(Environment.NewLine) Then
                    MessageBox.Show("The clipboard does not contain multiple lines but it needs to.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            ElseIf Not strClipboard.Contains(Environment.NewLine) Then
                MessageBox.Show("The clipboard does not contain multiple lines but it needs to.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            strRows = strClipboard.Split(Environment.NewLine)

            Dim row() As String
            For intCounter As Integer = 0 To strRows.Count - 1
                If strRows(intCounter).Trim.Length = 0 Then
                    Continue For '-- skip this row, it has no data
                End If
                row = strRows(intCounter).Split(vbTab)
                objPref = New StudentPreference()
                objPref.StudentID = row(0).Trim()
                If IsNumeric(row(1)) Then
                    If row.Length >= 2 Then
                        objPref.PreferenceOrder = row(1).Trim()
                    Else
                        objPref.PreferenceOrder = 1
                    End If
                Else
                    objPref.PreferenceOrder = 1
                End If
                strErrorZone = "a"
                If IsNumeric(row(2)) Then
                    strErrorZone = "b"
                    If row.Length >= 3 AndAlso row(2).Length > 0 Then '-- Under wine, zero length string shows as numeric, but on assignment: crash
                        strErrorZone = "c"
                        objPref.ChoiceID = row(2).Trim()
                        strErrorZone = "d"
                    Else
                        strErrorZone = "e"
                        Continue For
                    End If
                Else
                    '-- no choice, so skip this record
                    Continue For
                End If

                strErrorZone = "f"
                m_lstPreferences.Add(objPref)
            Next
            strErrorZone = "g"


            '-- add in grade data
            Dim stud As Student
            For Each pref As StudentPreference In m_lstPreferences
                stud = Student.GetByStudentID(pref.StudentID)
                If stud IsNot Nothing Then '-- if invalid student ID, then ignore it
                    pref.StudentGrade = stud.AssessmentResultsOverallNumeric * 100
                End If
            Next


            '-- Sort students by grade
            m_lstPreferences.Sort(AddressOf CompareStudentsByGrade)

            strErrorZone = "h"

            '-- Add to DGV
            dgvPreferences.AutoGenerateColumns = False
            dgvPreferences.DataSource = m_lstPreferences

            Try
                dgvPreferences.AutoResizeColumns()
            Catch ex As Exception
                Log(ex) '-- Log and continue
            End Try

        Catch ex As Exception
            MessageBox.Show("There was a problem pasting (" & ex.Message & "; Zone: " & strErrorZone & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class