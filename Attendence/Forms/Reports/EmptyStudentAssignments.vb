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
Imports DocumentFormat.OpenXml.Drawing.Diagrams

Public Class EmptyStudentAssignments
    Private Class AssignmentReportDataNormal
        Public Property Student As Student
        Public Property Assignment As StudentAssignment
#Region " Properties "
        Public ReadOnly Property StudentID As String
            Get
                Return Student.StudentID
            End Get
        End Property
        Public ReadOnly Property ExtStudentID As String
            Get
                Return Student.ExtStudentID
            End Get
        End Property
        Public ReadOnly Property LocalName As String
            Get
                Return Student.LocalNameLatinLetters
            End Get
        End Property
        Public ReadOnly Property Nickname As String
            Get
                Return Student.Nickname
            End Get
        End Property
        Public ReadOnly Property AssignmentName As String
            Get
                Return Assignment.BaseAssignment.Name
            End Get
        End Property
        Public ReadOnly Property Overall1 As String
            Get
                Return Assignment.OverallComments
            End Get
        End Property
        Public ReadOnly Property Overall2 As String
            Get
                Return Assignment.OverallCommentsRework
            End Get
        End Property
        Public ReadOnly Property Improvement1 As String
            Get
                Return Assignment.ImprovementComments
            End Get
        End Property
        Public ReadOnly Property Improvement2 As String
            Get
                Return Assignment.ImprovementCommentsRework
            End Get
        End Property
        Public ReadOnly Property Grade1 As Integer
            Get
                Return Assignment.FirstTryPoints
            End Get
        End Property
        Public ReadOnly Property Grade2 As Integer
            Get
                Return Assignment.SecondTryPoints
            End Get
        End Property
#End Region
    End Class
    Private Class AssignmentReportDataBTEC
        Public Property Student As Student
        Public Property Assignment As StudentAssignmentBTEC

#Region " Properties "
        Public ReadOnly Property StudentID As String
            Get
                Return Student.StudentID
            End Get
        End Property
        Public ReadOnly Property ExtStudentID As String
            Get
                Return Student.ExtStudentID
            End Get
        End Property
        Public ReadOnly Property LocalName As String
            Get
                Return Student.LocalNameLatinLetters
            End Get
        End Property
        Public ReadOnly Property Nickname As String
            Get
                Return Student.Nickname
            End Get
        End Property
        Public ReadOnly Property AssignmentName As String
            Get
                Return Assignment.BaseAssignment.Name
            End Get
        End Property
        Public ReadOnly Property Overall1 As String
            Get
                Return Assignment.OverallComments
            End Get
        End Property
        Public ReadOnly Property Overall2 As String
            Get
                Return Assignment.OverallCommentsRework
            End Get
        End Property
        Public ReadOnly Property Improvement1 As String
            Get
                Return Assignment.ImprovementComments
            End Get
        End Property
        Public ReadOnly Property Improvement2 As String
            Get
                Return Assignment.ImprovementCommentsRework
            End Get
        End Property
        Public ReadOnly Property PercentOCWithUnknown As String
            Get
                Return "25%"
            End Get
        End Property
        Public ReadOnly Property PercentOCWithoutFeedback As String
            Get
                Return "29%"
            End Get
        End Property
#End Region
    End Class

    Private m_lstAssignmentReportDataNormal As New List(Of AssignmentReportDataNormal)
    Private m_lstAssignmentReportDataBTEC As New List(Of AssignmentReportDataBTEC)

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ReloadData()
        Dim objNormal As AssignmentReportDataNormal
        Dim objBTEC As AssignmentReportDataBTEC
        Dim intCounter As Integer

        m_lstAssignmentReportDataNormal.Clear()
        m_lstAssignmentReportDataBTEC.Clear()

        dgvNormal.DataSource = Nothing
        dgvBTEC.DataSource = Nothing

        For Each grp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In grp.Classes
                For Each stud As Student In cls.Students
                    For Each asmt As StudentAssignment In stud.Assignments
                        intCounter += 1
                        lblAssignmentsProcessed.Text = "Processing assignment: " & intCounter.ToString("#,##0")
                        Application.DoEvents()

                        If asmt.OverallComments.Trim().Length > 0 Then
                            Continue For
                        End If
                        If asmt.OverallCommentsRework.Trim().Length > 0 Then
                            Continue For
                        End If
                        If asmt.ImprovementComments.Trim().Length > 0 Then
                            Continue For
                        End If
                        If asmt.ImprovementCommentsRework.Trim().Length > 0 Then
                            Continue For
                        End If

                        '-- If we get here, then there is a good chance this is an empty assignment
                        objNormal = New AssignmentReportDataNormal
                        objNormal.Student = stud
                        objNormal.Assignment = asmt
                        m_lstAssignmentReportDataNormal.Add(objNormal)
                    Next

                    For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                        If asmt.OverallComments.Trim().Length > 0 Then
                            Continue For
                        End If
                        If asmt.OverallCommentsRework.Trim().Length > 0 Then
                            Continue For
                        End If
                        If asmt.ImprovementComments.Trim().Length > 0 Then
                            Continue For
                        End If
                        If asmt.ImprovementCommentsRework.Trim().Length > 0 Then
                            Continue For
                        End If

                        '-- If we get here, then there is a good chance this is an empty assignment
                        objBTEC = New AssignmentReportDataBTEC
                        objBTEC.Student = stud
                        objBTEC.Assignment = asmt
                        m_lstAssignmentReportDataBTEC.Add(objBTEC)
                    Next
                Next
            Next
        Next

        lblAssignmentsProcessed.Text = String.Empty

        dgvNormal.DataSource = m_lstAssignmentReportDataNormal
        dgvBTEC.DataSource = m_lstAssignmentReportDataBTEC

    End Sub
    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        Try
            ReloadData()

        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message)
        End Try
    End Sub

    Private Sub EmptyStudentAssignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvNormal.AutoGenerateColumns = False
        dgvBTEC.AutoGenerateColumns = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case TabControl1.SelectedIndex
            Case 0 '-- BTEC
                DeleteSelectedBTECAssignment()
            Case 1 '-- Normal
                DeleteSelectedNormalAssignment()
        End Select
    End Sub
    Private Sub DeleteSelectedBTECAssignment()
        Dim lst As List(Of AssignmentReportDataBTEC) = GetSelectedBTECAssignmentsFromGrid()
        For Each obj As AssignmentReportDataBTEC In lst
            obj.Student.AddToActivityLog("Manually deleted empty BTEC assignment: " & obj.Assignment.BaseAssignment.Name & ".")
            obj.Student.AssignmentsBTEC.Remove(obj.Assignment) '-- This should not cause a problem because we are delete deep down the tree, so iterator should not change
        Next
        AddApplicationHistory("Manually deleted " & lst.Count().ToString("#,##0") & " empty BTEC assignments.")
        ReloadData()
    End Sub
    Private Sub DeleteSelectedNormalAssignment()
        Dim lst As List(Of AssignmentReportDataNormal) = GetSelectedNormalAssignmentsFromGrid()
        For Each obj As AssignmentReportDataNormal In lst
            obj.Student.AddToActivityLog("Manually deleted empty normal assignment: " & obj.Assignment.BaseAssignment.Name & ".")
            obj.Student.Assignments.Remove(obj.Assignment) '-- This should not cause a problem because we are delete deep down the tree, so iterator should not change
        Next
        AddApplicationHistory("Manually deleted " & lst.Count().ToString("#,##0") & " empty normal assignments.")
        ReloadData()
    End Sub
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Select Case TabControl1.SelectedIndex
            Case 0 '-- BTEC
                EditSelectedBTECAssignment()
            Case 1 '-- Normal
                EditSelectedNormalAssignment()
        End Select
    End Sub
    Private Sub EditSelectedBTECAssignment()
        Dim lst As List(Of AssignmentReportDataBTEC) = GetSelectedBTECAssignmentsFromGrid()

        If lst.Count = 0 Then
            MessageBox.Show("Please select an assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim data As AssignmentReportDataBTEC = lst(0)

            AddApplicationHistory("Editing Assignment: " & data.Assignment.BaseAssignment.Name & "; Student: " & data.Student.ToString())
            Dim frm As New StudentAssignmentDetails(data.Student, data.Assignment, Semester.MarkingTry.FirstTry)
            frm.Show()
        End If
    End Sub
    Private Function GetSelectedBTECAssignmentsFromGrid() As List(Of AssignmentReportDataBTEC)
        Dim lstReturn As New List(Of AssignmentReportDataBTEC)

        Dim cells As DataGridViewSelectedCellCollection

        cells = dgvBTEC.SelectedCells

        Dim row As DataGridViewRow
        Dim obj As AssignmentReportDataBTEC

        Dim dict As New Dictionary(Of Integer, Object)
        For Each cell As DataGridViewCell In cells
            If Not dict.ContainsKey(cell.RowIndex) Then
                dict.Add(cell.RowIndex, Nothing)

                row = dgvBTEC.Rows(cell.RowIndex)
                obj = row.DataBoundItem
                If obj IsNot Nothing Then
                    lstReturn.Add(obj)
                End If
            End If
        Next
        Return lstReturn
    End Function

    Private Sub EditSelectedNormalAssignment()
        Dim lst As List(Of AssignmentReportDataNormal) = GetSelectedNormalAssignmentsFromGrid()

        If lst.Count = 0 Then
            MessageBox.Show("Please select an assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim data As AssignmentReportDataNormal = lst(0)

            AddApplicationHistory("Editing Assignment: " & data.Assignment.BaseAssignment.Name & "; Student: " & data.Student.ToString())
            Dim frm As New StudentAssignmentNormalDetails(data.Student, data.Assignment, Semester.MarkingTry.FirstTry)
            frm.Show()
        End If
    End Sub
    Private Function GetSelectedNormalAssignmentsFromGrid() As List(Of AssignmentReportDataNormal)
        Dim lstReturn As New List(Of AssignmentReportDataNormal)

        Dim cells As DataGridViewSelectedCellCollection

        cells = dgvNormal.SelectedCells

        Dim row As DataGridViewRow
        Dim obj As AssignmentReportDataNormal

        Dim dict As New Dictionary(Of Integer, Object)
        For Each cell As DataGridViewCell In cells
            If Not dict.ContainsKey(cell.RowIndex) Then
                dict.Add(cell.RowIndex, Nothing)

                row = dgvNormal.Rows(cell.RowIndex)
                obj = row.DataBoundItem
                If obj IsNot Nothing Then
                    lstReturn.Add(obj)
                End If
            End If
        Next
        Return lstReturn
    End Function
End Class