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
            lblImportOverall.Text = obj.TempAssignment.ImprovementCommentsRework
            lblImportOverall.Text = obj.TempAssignment.SecondTryPoints.ToString()

        Else
            '-- clear everything
            lblStudentName.Text = String.Empty

            lblExistingOverall.Text = String.Empty
            lblExistingImprovement.Text = String.Empty
            lblExistingPoints.Text = String.Empty

            lblImportOverall.Text = String.Empty
            lblImportOverall.Text = String.Empty
            lblImportOverall.Text = String.Empty

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
        End If
    End Sub
End Class