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
Imports System.Runtime.InteropServices

Public Class AttendanceReport

    Private m_class As SchoolClass
    Public Class AttendanceReportData
        Public Property Present As Integer
        Public Property Absent As Integer
        Public Property EventDate As Date
        Public ReadOnly Property Day As DayOfWeek
            Get
                Return EventDate.DayOfWeek
            End Get
        End Property
        Public ReadOnly Property PercentAttend As String
            Get
                Dim dbl As Double = Present / (Present + Absent)
                Return dbl.ToString("0%")
            End Get
        End Property

    End Class

    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = clas

        Me.Text &= " " & m_class.ClassGroup.ToString() & " - " & m_class.ToString()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ReloadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadDataToolStripMenuItem.Click
        dgvReport.DataSource = Nothing
        Application.DoEvents()

        Dim dict As New Dictionary(Of Date, AttendanceReportData)
        Dim objCurrent As AttendanceReportData

        Dim intCounter As Integer
        For Each stud As Student In m_class.Students
            intCounter += 1
            lblStatus.Text = "Updating student " & intCounter.ToString("#,##0") & " of " & m_class.Students.Count.ToString("#,##0")
            Application.DoEvents()
            For Each attend As TeachingSession In stud.TeachingSessions
                If dict.ContainsKey(attend.StartDate) Then
                    objCurrent = dict(attend.StartDate)
                Else
                    objCurrent = New AttendanceReportData
                    objCurrent.EventDate = attend.StartDate
                    dict.Add(objCurrent.EventDate, objCurrent)
                End If

                Select Case attend.AttendenceStatus
                    Case AttendanceStatusEnum.Present, AttendanceStatusEnum.Excused
                        objCurrent.Present += 1
                    Case AttendanceStatusEnum.Absent
                        objCurrent.Absent += 1
                    Case Else '-- all else are absent
                        objCurrent.Absent += 1
                End Select
            Next
        Next

        lblStatus.Text = String.Empty


        '-- Now, populate the grid

        Dim lst As List(Of AttendanceReportData) = dict.Values.ToList()
        dgvReport.AutoGenerateColumns = False
        dgvReport.DataSource = lst

    End Sub
End Class