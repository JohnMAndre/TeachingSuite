Public Class ImportSyncResolverBTEC

    Private m_lstSyncResolverBTEC As New List(Of ImportMarkingFromOtherSemesterFile.SyncResolverBTECData)

    Public Sub New(listToResolve As List(Of ImportMarkingFromOtherSemesterFile.SyncResolverBTECData))

        ' This call is required by the designer.
        InitializeComponent()

        m_lstSyncResolverBTEC = listToResolve
    End Sub

    Private Sub ImportSyncResolverBTEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-- Populate students
        For Each obj As ImportMarkingFromOtherSemesterFile.SyncResolverBTECData In m_lstSyncResolverBTEC
            lstStudentID.Items.Add(obj)
        Next

        Me.olvOutcomes.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf MainRowFormatter)
        Me.ObjectListView1.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf MainRowFormatter)

    End Sub
    Private Function MainRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim ocrslt As OutcomeResult = CType(olvi.RowObject, OutcomeResult)

        Dim PASS_COLOR As System.Drawing.Color = System.Drawing.Color.LightGreen
        Dim FAIL_COLOR As System.Drawing.Color = System.Drawing.Color.LightSalmon
        Dim UNKNOWN_COLOR As System.Drawing.Color = System.Drawing.Color.White
        Dim newColor As System.Drawing.Color

        If ocrslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse
            ocrslt.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse
            ocrslt.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
            newColor = PASS_COLOR
        ElseIf ocrslt.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
            newColor = UNKNOWN_COLOR
        Else
            newColor = FAIL_COLOR
        End If

        If ocrslt IsNot Nothing AndAlso AppSettings.DisableColorsInAssignmentDetail = False Then
            olvi.BackColor = newColor
            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).BackColor = newColor
            Next
        End If
    End Function
    Private Sub lstStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudentID.SelectedIndexChanged
        Dim obj As ImportMarkingFromOtherSemesterFile.SyncResolverBTECData = lstStudentID.SelectedItem
        If obj IsNot Nothing Then
            '-- Populate everything
            lblStudentName.Text = obj.Student.LocalNameLatinLetters

            lblExistingOverall.Text = obj.PermExistingAssignment.OverallCommentsRework
            lblExistingImprovement.Text = obj.PermExistingAssignment.ImprovementCommentsRework
            olvOutcomes.SetObjects(obj.PermExistingAssignment.Outcomes)

            lblImportOverall.Text = obj.TempAssignment.OverallCommentsRework
            lblImportImprovement.Text = obj.TempAssignment.ImprovementCommentsRework
            ObjectListView1.SetObjects(obj.TempAssignment.Outcomes)

        Else
            '-- clear everything
            lblStudentName.Text = String.Empty

            lblExistingOverall.Text = String.Empty
            lblExistingImprovement.Text = String.Empty
            olvOutcomes.SetObjects(Nothing)

            lblImportOverall.Text = String.Empty
            lblImportOverall.Text = String.Empty
            lblImportOverall.Text = String.Empty
            ObjectListView1.SetObjects(Nothing)

        End If
    End Sub

    Private Sub btnUseExisting_Click(sender As Object, e As EventArgs) Handles btnUseExisting.Click
        '-- just remove from the list and change nothing
        lstStudentID.Items.Remove(lstStudentID.SelectedItem)
    End Sub

    Private Sub btnUseImport_Click(sender As Object, e As EventArgs) Handles btnUseImport.Click
        Dim obj As ImportMarkingFromOtherSemesterFile.SyncResolverBTECData = lstStudentID.SelectedItem
        If obj IsNot Nothing Then
            obj.PermExistingAssignment.OverallCommentsRework = obj.TempAssignment.OverallCommentsRework
            obj.PermExistingAssignment.ImprovementCommentsRework = obj.TempAssignment.ImprovementCommentsRework

            Dim intOutcomesUpdated As Integer
            For Each tempOC As OutcomeResult In obj.TempAssignment.Outcomes
                If tempOC.SecondTryStatus <> OutcomeResultStatusEnum.Unknown Then
                    '-- Now finding the matching outcome on the permExisting assignment and update it
                    For Each permOC As OutcomeResult In obj.PermExistingAssignment.Outcomes
                        If permOC.BaseOutcome.ID = tempOC.BaseOutcome.ID Then
                            '-- We found the matching learning outcome on the permAssignment
                            permOC.SecondTryStatus = tempOC.SecondTryStatus
                            permOC.SecondTryComments = tempOC.SecondTryComments
                            intOutcomesUpdated += 1
                            Exit For
                        End If
                    Next
                End If
            Next


            obj.Student.AddToActivityLog("Updated existing assignment (" & obj.PermExistingAssignment.BaseAssignment.Name & ")  with imported rework data (including " & intOutcomesUpdated.ToString() & " outcomes) after manual sync resolution.")
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