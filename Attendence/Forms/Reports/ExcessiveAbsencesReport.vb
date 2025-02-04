﻿'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

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
Public Class ExcessiveAbsencesReport

    Private Class StudentWithRecentAbsences
        Public Property Student As Student
        Public Property RecentAbsences As Integer
    End Class
    Private m_lstStudents As New List(Of StudentWithRecentAbsences)

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        Try
            ReloadData(nudMinimumRecentAbsences.Value)
        Catch ex As Exception
            MessageBox.Show("There was an error loading the data: " & ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Loads all students in current semester who have been marked absent at least minAbsences times, starting with most recent session and going back in time
    ''' </summary>
    ''' <param name="minAbsences">Any student with this number or more recent absences will be included in the list</param>
    ''' <remarks></remarks>
    Private Sub ReloadData(minAbsences As Integer)
        m_lstStudents.Clear()
        Application.DoEvents()
        Dim intCurrentAbsences As Integer
        Dim objStudent As StudentWithRecentAbsences

        For Each clsGroup As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In clsGroup.Classes
                For Each stud As Student In cls.Students
                    intCurrentAbsences = 0 '-- reset
                    For intCounter As Integer = stud.TeachingSessions.Count - 1 To 0 Step -1
                        Dim session As TeachingSession = stud.TeachingSessions(intCounter)
                        If session.AttendenceStatus = AttendanceStatusEnum.Absent Then
                            intCurrentAbsences += 1
                        Else
                            '-- not absent, so process student
                            Exit For
                        End If
                    Next

                    If intCurrentAbsences >= minAbsences Then
                        objStudent = New StudentWithRecentAbsences
                        objStudent.Student = stud
                        objStudent.RecentAbsences = intCurrentAbsences
                        m_lstStudents.Add(objStudent)
                    End If
                Next
            Next
        Next

        olvStudents.SetObjects(m_lstStudents)
        lblMatchedStudents.Text = m_lstStudents.Count.ToString("#,##0")
    End Sub

    Private Sub olvStudents_ItemActivate(sender As Object, e As EventArgs) Handles olvStudents.ItemActivate
        Try
            Using frm As New StudentDetail(CType(olvStudents.SelectedObject, StudentWithRecentAbsences).Student)
                frm.ShowDialog(Me)
            End Using

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK)
        End Try
    End Sub
End Class