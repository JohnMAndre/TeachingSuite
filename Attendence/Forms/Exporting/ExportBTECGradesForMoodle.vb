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
Public Class ExportBTECGradesForMoodle

    Private m_group As ClassGroup

    Public Sub New(group As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_group = group
        LoadAssignments()
    End Sub
    Private Sub LoadAssignments()
        lstAssignments.Items.Clear()
        m_group.AssignmentsBTEC.Sort()
        For Each asmt As ClassAssignmentBTEC In m_group.AssignmentsBTEC
            lstAssignments.Items.Add(asmt)
        Next
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If lstAssignments.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select at least one assignment to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.OverwritePrompt = True
        sfd.DefaultExt = ".tab"
        sfd.Filter = "Tab-delimited files|*.tab"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim strLineToWrite As String
            Dim tw As System.IO.TextWriter = System.IO.File.CreateText(sfd.FileName)

            '-- First, write out the headers
            tw.Write("StudentID" & vbTab & "Email" & vbTab & "Group")
            For Each item As ClassAssignmentBTEC In lstAssignments.SelectedItems
                tw.Write(vbTab & "Assignment: " & item.Name & " (Real)" & vbTab & "Assignment: " & item.Name & " (Feedback)")
            Next
            'tw.WriteLine(String.Empty) '-- just to get the end of line char (I think this will work)

            Dim intAsmtCounter As Integer

            '-- Now write out the per-student data
            For Each cls As SchoolClass In m_group.Classes
                For Each stud As Student In cls.Students
                    intAsmtCounter = 0 '-- reset
                    tw.WriteLine(String.Empty) '-- just to get the end of line char for the previous line (I think this will work) 

                    strLineToWrite = stud.StudentID & vbTab & stud.EmailAddress & vbTab & stud.StudentGroup

                    '--  WARNING: It is possible that A2 is created before A1 so need to sort first, otherwise columns will not sync up
                    stud.AssignmentsBTEC.Sort()

                    For Each stAsmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                        '-- If the student has the assignment and that assignment is selected, then we write it out.
                        If lstAssignments.SelectedItems.Contains(stAsmt.BaseAssignment) Then
                            '-- It's selected, but we need to see if this student missed any assignments
                            '   If they did not submit A1 but did A2 and A1 and A2 are selected, we don't want A2 data under the A1 columns

                            Do Until lstAssignments.SelectedItems(intAsmtCounter) Is stAsmt.BaseAssignment OrElse intAsmtCounter >= lstAssignments.SelectedItems.Count
                                '-- We assume this student is missing at least one assignment, so we skip it, 
                                '   but still need to write something to align the columns
                                strLineToWrite &= vbTab & "-" & vbTab & String.Empty
                                intAsmtCounter += 1
                            Loop

                            '-- This is the one it should be
                            If stAsmt.AchievedDistinction Then
                                strLineToWrite &= vbTab & "Distinction"
                            ElseIf stAsmt.AchievedMerit Then
                                strLineToWrite &= vbTab & "Merit"
                            ElseIf stAsmt.AchievedPass Then
                                strLineToWrite &= vbTab & "Pass"
                            Else
                                strLineToWrite &= vbTab & "Fail"
                            End If

                            '-- Need to remove end of line chars
                            strLineToWrite &= vbTab & "" & stAsmt.ImprovementComments.Replace("""", "'").Replace(vbCrLf, "; ").Replace(vbCr, "; ").Replace(vbLf, "; ") & "" '-- could have quote inside

                            intAsmtCounter += 1
                        End If
                    Next
                    tw.Write(strLineToWrite)
                Next
            Next

            tw.Close()
            tw.Dispose()
            '= lstAssignments.Items(2)

            'If lstAssignments.SelectedItems.Contains(asmt) Then
            '    MessageBox.Show("It is selected")
            'Else
            '    MessageBox.Show("It is not selected")
            'End If

        End If


        lblStatus.Text = "OK!"


    End Sub

End Class