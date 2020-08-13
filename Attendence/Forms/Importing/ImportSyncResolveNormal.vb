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
Public Class ImportSyncResolveNormal

    Private m_lstSyncResolverNormal As New List(Of ImportMarkingFromOtherSemesterFile.SyncResolverNormalData)

    Public Sub New(listToResolve As List(Of ImportMarkingFromOtherSemesterFile.SyncResolverNormalData))

        ' This call is required by the designer.
        InitializeComponent()

        m_lstSyncResolverNormal = listToResolve

    End Sub

    Private Sub ImportSyncResolveNormal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-- Populate students
        For Each obj As ImportMarkingFromOtherSemesterFile.SyncResolverNormalData In m_lstSyncResolverNormal
            lstStudentID.Items.Add(obj)
        Next
    End Sub

    Private Sub lstStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudentID.SelectedIndexChanged
        Dim obj As ImportMarkingFromOtherSemesterFile.SyncResolverNormalData = lstStudentID.SelectedItem
        If obj IsNot Nothing Then
            '-- Populate everything
            lblStudentName.Text = obj.Student.LocalNameLatinLetters

            lblExistingOverall.Text = obj.PermExistingAssignment.OverallCommentsRework
            lblExistingImprovement.Text = obj.PermExistingAssignment.ImprovementCommentsRework
            lblExistingPoints.Text = obj.PermExistingAssignment.SecondTryPoints.ToString()

            lblImportOverall.Text = obj.TempAssignment.OverallCommentsRework
            lblImportImprovement.Text = obj.TempAssignment.ImprovementCommentsRework
            lblImportPoints.Text = obj.TempAssignment.SecondTryPoints.ToString()

        Else
            '-- clear everything
            lblStudentName.Text = String.Empty

            lblExistingOverall.Text = String.Empty
            lblExistingImprovement.Text = String.Empty
            lblExistingPoints.Text = String.Empty

            lblImportOverall.Text = String.Empty
            lblImportImprovement.Text = String.Empty
            lblImportPoints.Text = String.Empty

        End If
    End Sub

    Private Sub btnUseExisting_Click(sender As Object, e As EventArgs) Handles btnUseExisting.Click
        '-- just remove from the list and change nothing
        lstStudentID.Items.Remove(lstStudentID.SelectedItem)
    End Sub

    Private Sub btnUseImport_Click(sender As Object, e As EventArgs) Handles btnUseImport.Click
        Dim obj As ImportMarkingFromOtherSemesterFile.SyncResolverNormalData = lstStudentID.SelectedItem
        If obj IsNot Nothing Then
            obj.PermExistingAssignment.OverallCommentsRework = obj.TempAssignment.OverallCommentsRework
            obj.PermExistingAssignment.ImprovementCommentsRework = obj.TempAssignment.ImprovementCommentsRework
            obj.PermExistingAssignment.SecondTryPoints = obj.TempAssignment.SecondTryPoints
            obj.Student.AddToActivityLog("Updated existing assignment (" & obj.PermExistingAssignment.BaseAssignment.Name & ")  with imported rework data after manual sync resolution.")
            lstStudentID.Items.Remove(lstStudentID.SelectedItem)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If lstStudentID.Items.Count > 0 Then
            If MessageBox.Show("Are you sure you want to close and ignore the remaining assignments?", PRODUCT_NAME, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class