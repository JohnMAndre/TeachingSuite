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
Public Class ExportNormalGradesForMoodle

    Private m_group As ClassGroup

    Public Sub New(group As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_group = group
        LoadAssignments()
    End Sub
    Private Sub LoadAssignments()
        lstAssignments.Items.Clear()
        m_group.Assignments.Sort()
        For Each asmt As ClassAssignment In m_group.Assignments
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
        sfd.DefaultExt = ".csv"
        sfd.Filter = "csv files|*.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim strLineToWrite As String
            Dim tw As System.IO.TextWriter = System.IO.File.CreateText(sfd.FileName)

            '-- First, write out the headers
            tw.Write("StudentID" & vbTab & "Email" & vbTab & "Team" & vbTab & "Group")
            For Each item As ClassAssignment In lstAssignments.SelectedItems
                tw.Write(vbTab & "Assignment: " & item.Name & " (Real)")
                If chkIncludeImprovementFeedback.Checked OrElse chkIncludeOverallFeedback.Checked Then
                    tw.Write(vbTab & "Assignment: " & item.Name & " (Feedback)")
                End If
            Next
            tw.WriteLine(String.Empty) '-- just to get the end of line char (I think this will work)

            Dim intAsmtCounter As Integer

            '-- Now write out the per-student data
            For Each cls As SchoolClass In m_group.Classes
                For Each stud As Student In cls.Students
                    intAsmtCounter = 0 '-- reset
                    'tw.WriteLine(String.Empty) '-- just to get the end of line char for the previous row

                    strLineToWrite = stud.StudentID & vbTab & stud.EmailAddress & vbTab & stud.StudentTeam & vbTab & stud.StudentGroup
                    '--  WARNING: It is possible that A2 is created before A1 so need to sort first, otherwise columns will not sync up
                    stud.Assignments.Sort()

                    For Each stAsmt As StudentAssignment In stud.Assignments
                        '-- If the student has the assignment and that assignment is selected, then we write it out.
                        If lstAssignments.SelectedItems.Contains(stAsmt.BaseAssignment) Then

                            '-- It's selected, but we need to see if this student missed any assignments
                            '   If they did not submit A1 but did A2 and A1 and A2 are selected, we don't want A2 data under the A1 columns

                            Do Until intAsmtCounter >= lstAssignments.SelectedItems.Count OrElse (lstAssignments.SelectedItems(intAsmtCounter) Is stAsmt.BaseAssignment)
                                '-- We assume this student is missing at least one assignment, so we skip it, 
                                '   but still need to write something to align the columns
                                strLineToWrite &= vbTab & "-" '-- grade

                                If chkIncludeImprovementFeedback.Checked OrElse chkIncludeOverallFeedback.Checked Then
                                    strLineToWrite &= vbTab & String.Empty '-- feedback
                                End If

                                intAsmtCounter += 1
                            Loop

                            If chkIncludeRework.Checked Then
                                '-- Include the greater of either first try or second try
                                strLineToWrite &= vbTab & Math.Max(stAsmt.FirstTryPoints, stAsmt.SecondTryPoints)
                            Else
                                strLineToWrite &= vbTab & stAsmt.FirstTryPoints
                            End If

                            strLineToWrite &= GetFeedback(stAsmt, chkIncludeOverallFeedback.Checked, chkIncludeImprovementFeedback.Checked, chkIncludeRework.Checked, chkIncludeHTMLBreaks.Checked)

                            intAsmtCounter += 1
                        End If
                    Next

                    '-- If student did not do the assignments at the end, we write "-"
                    Do Until intAsmtCounter = lstAssignments.SelectedItems.Count
                        strLineToWrite &= vbTab & "-" '-- grade
                        If chkIncludeImprovementFeedback.Checked OrElse chkIncludeOverallFeedback.Checked Then
                            strLineToWrite &= vbTab & String.Empty '-- feedback
                        End If
                        intAsmtCounter += 1
                    Loop

                    tw.WriteLine(strLineToWrite)
                Next
            Next

            tw.Close()
            tw.Dispose()
        End If


        lblStatus.Text = "OK!"
    End Sub

    Private Function GetFeedback(studAssignment As StudentAssignment, includeOverall As Boolean, includeImprovement As Boolean, includeRework As Boolean, includeHTMLBreaks As Boolean) As String
        Dim strReturn As String
        Dim strFeedback As String = String.Empty

        If includeOverall Then
            If includeHTMLBreaks Then
                strFeedback &= "First attempt overall: " & studAssignment.OverallComments & "; "
                strFeedback &= " <br> "
            Else
                strFeedback &= "First attempt overall: " & studAssignment.OverallComments & "; "
            End If
            If includeRework Then
                If includeHTMLBreaks Then
                    strFeedback &= "Second attempt overall: " & studAssignment.OverallCommentsRework & "; "
                    strFeedback &= " <br> "
                Else
                    strFeedback &= "Second attempt overall: " & studAssignment.OverallCommentsRework & "; "
                End If
            End If
        End If

        If includeImprovement Then
            '-- Both overall and improvement
            If includeHTMLBreaks Then
                strFeedback &= "First attempt improvement: " & studAssignment.ImprovementComments & "; "
                strFeedback &= " <br> "
            Else
                strFeedback &= "First attempt improvement: " & studAssignment.ImprovementComments & "; "
            End If
            If includeRework Then
                If includeHTMLBreaks Then
                    strFeedback &= "Second attempt improvement: " & studAssignment.ImprovementCommentsRework & "; "
                    strFeedback &= " <br> "
                Else
                    strFeedback &= "Second attempt improvement: " & studAssignment.ImprovementCommentsRework & "; "
                End If
            End If
        End If

        If includeHTMLBreaks Then
            strReturn = vbTab & "" & strFeedback.Replace("""", "'").Replace(vbCrLf, "<br>").Replace(vbLf, "<br>").Replace(vbCr, "<br>") & "" '-- could have quote inside
        Else
            strReturn = vbTab & "" & strFeedback.Replace("""", "'").Replace(vbCrLf, "; ").Replace(vbLf, "; ").Replace(vbCr, "; ") & "" '-- could have quote inside
        End If

        Return strReturn
    End Function
End Class