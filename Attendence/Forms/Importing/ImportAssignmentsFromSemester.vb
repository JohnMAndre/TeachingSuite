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

Public Class ImportAssignmentsFromSemester
    Private m_TargetClassGroup As ClassGroup
    Private m_sourceSemester As Semester

    Public Sub New(group As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_TargetClassGroup = group

    End Sub
    Private Sub ImportAssignmentsFromSemester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSemesters()
    End Sub
    Private Sub LoadSemesters()
        Dim files() As String = System.IO.Directory.GetFiles(GetDataFolder(), "*" & DATA_FILE_EXTENSION)
        cboSemester.Items.Clear()
        For Each strFilename As String In files
            cboSemester.Items.Add(System.IO.Path.GetFileNameWithoutExtension(strFilename))
        Next
    End Sub

    Private Sub cboSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSemester.SelectedIndexChanged
        LoadSemester()
    End Sub

    Private Sub LoadSemester()
        Try
            '-- Load the selected semester from data file
            m_sourceSemester = New Semester(CType(cboSemester.Items(cboSemester.SelectedIndex), String))
            Me.Text = "Import From - " & m_sourceSemester.Name

            LoadClassGroups()
        Catch ex As Exception
            MessageBox.Show("There was an error loading the selected semester: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadClassGroups()
        lstAssignments.Items.Clear()
        lstClassGroups.Items.Clear()
        For Each objClassGroup As ClassGroup In m_sourceSemester.ClassGroups
            lstClassGroups.Items.Add(objClassGroup)
        Next
    End Sub

    Private Sub lstClassGroups_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClassGroups.SelectedIndexChanged
        LoadAssignments()
    End Sub
    Private Sub LoadAssignments()
        lstAssignments.Items.Clear()
        '-- Load normal
        For Each asmt As ClassAssignment In GetSelectedClassGroup().Assignments
            lstAssignments.Items.Add(asmt)
        Next

        '-- Load BTEC
        For Each asmt As ClassAssignmentBTEC In GetSelectedClassGroup().AssignmentsBTEC
            lstAssignments.Items.Add(asmt)
        Next

    End Sub

    Private Function GetSelectedClassGroup() As ClassGroup
        If lstClassGroups.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstClassGroups.Items(lstClassGroups.SelectedIndex)
        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim intCounter As Integer
        For Each asmt As IClassAssignment In lstAssignments.Items
            asmt.ID = Guid.NewGuid().ToString() '-- replace the ID to keep it unique

            If asmt.AssignmentType = AssignmentType.Normal Then
                m_TargetClassGroup.Assignments.Add(asmt)
            Else
                '-- BTEC
                m_TargetClassGroup.AssignmentsBTEC.Add(asmt)
            End If
            intCounter += 1
        Next
        MessageBox.Show("Imported " & intCounter.ToString() & " assignments.", PRODUCT_NAME, MessageBoxButtons.OK)
        Me.DialogResult = DialogResult.OK
    End Sub
End Class