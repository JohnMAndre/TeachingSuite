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
Public Class StudentsWithAssignment
    Public Class StudentAssignmentData
        Private m_objAssignment As IStudentAssignment

        Public Sub New(Assignment As IStudentAssignment)
            m_objAssignment = Assignment
        End Sub
        Public Property StudentAssignment As StudentAssignment
            Get
                Return m_objAssignment
            End Get
            Set(value As StudentAssignment)
                m_objAssignment = value
            End Set
        End Property
        Public ReadOnly Property Student As Student
            Get
                Return m_objAssignment.Student
            End Get
        End Property
        Public ReadOnly Property StudentName As String
            Get
                Return m_objAssignment.Student.LocalName
            End Get
        End Property
        Public ReadOnly Property StudentID As String
            Get
                Return m_objAssignment.Student.StudentID
            End Get
        End Property
        Public ReadOnly Property StudentNickname As String
            Get
                Return m_objAssignment.Student.Nickname
            End Get
        End Property
        Public ReadOnly Property StudentExtStudentID As String
            Get
                Return m_objAssignment.Student.ExtStudentID
            End Get
        End Property
        Public ReadOnly Property StudentTags As String
            Get
                Return m_objAssignment.Student.Tags
            End Get
        End Property
        Public ReadOnly Property StudentGroup As String
            Get
                Return m_objAssignment.Student.StudentGroup
            End Get
        End Property
        Public ReadOnly Property StudentTeam As String
            Get
                Return m_objAssignment.Student.StudentTeam
            End Get
        End Property
        Public ReadOnly Property StudentClass As String
            Get
                Return m_objAssignment.Student.SchoolClass.Name
            End Get
        End Property

        Public ReadOnly Property OverallComments As String
            Get
                Return m_objAssignment.OverallComments
            End Get
        End Property
        Public ReadOnly Property ImprovementComments As String
            Get
                Return m_objAssignment.ImprovementComments
            End Get
        End Property
        Public ReadOnly Property FirstUsername As String
            Get
                If m_objAssignment.AssignmentType = AssignmentType.Normal Then
                    Return CType(m_objAssignment, StudentAssignment).FirstUserFullName
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property LastUsername As String
            Get
                If m_objAssignment.AssignmentType = AssignmentType.Normal Then
                    Return CType(m_objAssignment, StudentAssignment).LastUserFullName
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property FirstTry As String
            Get
                If m_objAssignment.AssignmentType = AssignmentType.Normal Then
                    Return CType(m_objAssignment, StudentAssignment).FirstTryPoints
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property SecondTry As String
            Get
                If m_objAssignment.AssignmentType = AssignmentType.Normal Then
                    Return CType(m_objAssignment, StudentAssignment).SecondTryPoints
                Else
                    Return String.Empty
                End If
            End Get
        End Property

    End Class

    Private m_class As SchoolClass
    Private m_asmt As IClassAssignment
    Private m_lst As New List(Of StudentAssignmentData)

    Public Sub New(clas As SchoolClass, assignment As IClassAssignment)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = clas
        m_asmt = assignment
    End Sub

    Private Sub StudentsWithAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        lstAssignments.Items.Clear()

        '-- add both BTEC and normal assignments
        'For Each objClassAssignment As ClassAssignmentBTEC In GetSelectedClassGroup().AssignmentsBTEC
        '    lstAssignments.Items.Add(objClassAssignment)
        'Next
        For Each objClassAssignment As ClassAssignment In m_class.ClassGroup.Assignments
            lstAssignments.Items.Add(objClassAssignment)
        Next

    End Sub
    Private Sub LoadData()
        Try
            Dim obj As StudentAssignmentData
            Dim intStudentCount As Integer
            Dim boolStudentAdded As Boolean

            dgvStudents.DataSource = Nothing
            m_lst.Clear()

            For Each stud As Student In m_class.Students
                boolStudentAdded = False '-- reset
                If m_asmt.AssignmentType = AssignmentType.Normal Then
                    For Each asmt As StudentAssignment In stud.Assignments
                        If asmt.BaseAssignment Is m_asmt Then
                            obj = New StudentAssignmentData(asmt)
                            m_lst.Add(obj)
                            boolStudentAdded = True
                        End If
                    Next
                    If boolStudentAdded Then
                        intStudentCount += 1
                    End If
                Else
                    MessageBox.Show("BTEC not implemented, yet.", Application.ProductName)
                    Exit For
                    'For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                    'Next
                End If
            Next

            dgvStudents.AutoGenerateColumns = False
            dgvStudents.DataSource = m_lst

            lblAssignmentCount.Text = m_lst.Count.ToString("#,##0")
            lblStudentCount.Text = intStudentCount.ToString("#,##0")

        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message)
        End Try
    End Sub

    Private Sub ChangeBaseAssignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBaseAssignmentToolStripMenuItem.Click
        Dim objNewBase As IClassAssignment = GetSelectedClassAssignment()
        If objNewBase Is Nothing Then
            MessageBox.Show("Please select a new base assignment to receive this student's assignment.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim strText As String

            Dim lst As List(Of StudentAssignmentData) = GetSelectedStudentAssignmentsFromGrid()
            Select Case lst.Count
                Case 0
                    MessageBox.Show("Please select at least one assignment to change.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Case 1
                    strText = "Are you sure you want to change this one assignment?"
                Case Else
                    strText = "Are you sure you want to change these " & lst.Count.ToString("#,##0") & " assignments?"
            End Select

            If MessageBox.Show(strText & Environment.NewLine & Environment.NewLine _
                               & "Old base assignment: " & m_asmt.Name & Environment.NewLine & Environment.NewLine _
                               & "New base assignment: " & objNewBase.Name, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For Each obj As StudentAssignmentData In lst
                    '-- Change it
                    obj.StudentAssignment.BaseAssignment = objNewBase

                    '-- Remove it from the list
                    m_lst.Remove(obj)
                Next

                '-- Rebind grid
                dgvStudents.DataSource = Nothing
                dgvStudents.DataSource = m_lst

            Else
                '-- do nothing
                MessageBox.Show("Nothing was changed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Function GetSelectedClassAssignment() As IClassAssignment
        If lstAssignments.SelectedIndex = -1 Then
            Return Nothing
        Else
            Dim asmt As IClassAssignment = lstAssignments.Items(lstAssignments.SelectedIndex)
            Return asmt
        End If
    End Function
    Private Function GetSelectedStudentAssignmentsFromGrid() As List(Of StudentAssignmentData)
        Dim lstReturn As New List(Of StudentAssignmentData)

        Dim cells As DataGridViewSelectedCellCollection

        cells = dgvStudents.SelectedCells

        Dim row As DataGridViewRow
        Dim asmt As StudentAssignmentData

        Dim dict As New Dictionary(Of Integer, Object)
        For Each cell As DataGridViewCell In cells
            If Not dict.ContainsKey(cell.RowIndex) Then
                dict.Add(cell.RowIndex, Nothing)

                row = dgvStudents.Rows(cell.RowIndex)
                asmt = row.DataBoundItem
                If asmt IsNot Nothing Then
                    lstReturn.Add(asmt)
                End If
            End If
        Next
        Return lstReturn
    End Function

    Private Sub DeleteSelectedAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedAssignmentsToolStripMenuItem.Click
        Dim strText As String

        Dim lst As List(Of StudentAssignmentData) = GetSelectedStudentAssignmentsFromGrid()
        Select Case lst.Count
            Case 0
                MessageBox.Show("Please select at least one assignment to delete.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Case 1
                strText = "Are you sure you want to delete this one assignment?"
            Case Else
                strText = "Are you sure you want to delete these " & lst.Count.ToString("#,##0") & " assignments?"
        End Select

        If MessageBox.Show(strText, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each obj As StudentAssignmentData In lst
                '-- Delete it
                obj.Student.Assignments.Remove(obj.StudentAssignment)

                '-- Remove it from the list
                m_lst.Remove(obj)
            Next

            '-- Rebind grid
            dgvStudents.DataSource = Nothing
            dgvStudents.DataSource = m_lst

        Else
            '-- do nothing
            MessageBox.Show("Nothing was changed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgvStudents_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellDoubleClick
        Dim lst As List(Of StudentAssignmentData) = GetSelectedStudentAssignmentsFromGrid()
        Select Case lst.Count
            Case 0
                MessageBox.Show("Please select at least one student to edit.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Case 1
                Application.DoEvents() '-- do nothing
            Case Else
                MessageBox.Show("Please select only one stduent to edit", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
        End Select

        Dim obj As StudentAssignmentData = lst(0) '-- Only considering one

        EditSelectedStudent()
        '-- Delete it
        obj.Student.Assignments.Remove(obj.StudentAssignment)


        '-- Rebind grid
        dgvStudents.DataSource = Nothing
        dgvStudents.DataSource = m_lst

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
        Dim obj As StudentAssignmentData = GetSelectedStudentAssignmentsFromGrid(0)
        If obj Is Nothing Then
            Exit Sub
        Else
            Using frm As New StudentDetail(obj.Student)
                frm.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub ReloadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadDataToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub dgvStudents_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvStudents.DataError
        If MessageBox.Show("There was an error with the underlying data (Row:" & e.RowIndex.ToString() & "; Column:" & e.ColumnIndex.ToString() & "). Would you like to close this form?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = True
            Close()
        End If
    End Sub
End Class