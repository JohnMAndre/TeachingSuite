'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Foobar Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Foobar.  If Not, see < https: //www.gnu.org/licenses/>.
Public Class MissingGradeDataReport
    Private m_boolCancel As Boolean = True
    Public Class MissingGradeReportData
        Public Property Semester As String
        Public Property ClassGroup As String
        Public Property SchoolClass As String
        Public Property TotalStudents As Integer
        Public Property StudentsWithoutGrades As Integer
    End Class

    Private m_data As MissingGradeReportData
    Private m_lst As List(Of MissingGradeReportData)

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ReloadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadDataToolStripMenuItem.Click
        Try
            m_boolCancel = False
            btnCancel.Text = "&Cancel"
            lblLoadingHistoricalStudents.Show()

            m_lst = New List(Of MissingGradeReportData)

            Dim strBaseHistoryLable As String = lblLoadingHistoricalStudents.Text
            Dim intClassesSearched, intStudentsSearched As Integer
            Dim lstSemesters As List(Of String) = Semester.ListExistingSemesters()
            Dim semCurrent As Semester
            Dim strFilename As String
            Do
                For intCounter As Integer = lstSemesters.Count - 1 To 0 Step -1 '-- want to use most recent file first
                    strFilename = lstSemesters(intCounter)
                    semCurrent = New Semester(strFilename)

                    lblLoadingHistoricalStudents.Text = strBaseHistoryLable & semCurrent.Name
                    Application.DoEvents()
                    For Each clsgrp As ClassGroup In semCurrent.ClassGroups

                        For Each clas As SchoolClass In clsgrp.Classes
                            intClassesSearched += 1
                            lblClassesSearched.Text = intClassesSearched.ToString("#,##0")
                            m_data = New MissingGradeReportData()
                            m_data.Semester = semCurrent.Name
                            m_data.ClassGroup = clsgrp.Name
                            m_data.SchoolClass = clas.Name
                            m_data.TotalStudents = clas.Students.Count

                            For Each stud In clas.Students
                                intStudentsSearched += 1

                                lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
                                If m_boolCancel Then
                                    Exit Do
                                End If
                                Application.DoEvents()

                                '-- If student does not have any grade, then increment
                                If stud.AssignmentCount = 0 Then
                                    m_data.StudentsWithoutGrades += 1
                                End If
                            Next

                            '-- Did any students not have grades?
                            '   If true, then add to report
                            If m_data.TotalStudents > 0 AndAlso m_data.StudentsWithoutGrades > 0 Then
                                m_lst.Add(m_data)
                            End If
                        Next
                    Next
                Next
                Exit Do
            Loop While True

            lblLoadingHistoricalStudents.Text = "Done"
            olvData.SetObjects(m_lst)

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading historrical data. Contact support for assistance.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblLoadingHistoricalStudents.Visible = False
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "&Close" Then
            Close()
        Else
            btnCancel.Text = "&Close"
            lblLoadingHistoricalStudents.Visible = False
            m_boolCancel = True
        End If
    End Sub
End Class