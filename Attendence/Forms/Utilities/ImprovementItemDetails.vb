Friend Class ImprovementItemDetails

    Private m_item As ImprovementItem

    Public Sub New(item As ImprovementItem)

        ' This call is required by the designer.
        InitializeComponent()

        m_item = item
        txtName.Text = m_item.Name
        txtDescription.Text = m_item.Description
        txtID.Text = m_item.ID
        nudOrderingID.Value = m_item.OrderingID

        LoadAssessmentCategories()

    End Sub
    Private Sub ImprovementItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each cat In [Enum].GetValues(GetType(Semester.AssessmentCategory))
            cboAssessmentCategory.Items.Add(cat)
        Next

        cboAssessmentCategory.SelectedIndex = 0 '-- select first one

    End Sub

    Private Sub llblAddCategory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAddCategory.LinkClicked
        m_item.AssessmentCategories.Add(cboAssessmentCategory.SelectedIndex)
        LoadAssessmentCategories()
    End Sub
    Private Sub LoadAssessmentCategories()
        lstAssessmentCategories.Items.Clear()
        For Each cat As Semester.AssessmentCategory In m_item.AssessmentCategories
            lstAssessmentCategories.Items.Add(cat)
        Next
    End Sub

    Private Sub llblDeleteCategory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblDeleteCategory.LinkClicked
        For intCounter As Integer = 0 To m_item.AssessmentCategories.Count - 1
            If m_item.AssessmentCategories(intCounter) = lstAssessmentCategories.SelectedItem Then
                m_item.AssessmentCategories.RemoveAt(intCounter)
                Exit For '-- can just delete one at a time
            End If
        Next

        LoadAssessmentCategories()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        m_item.Name = txtName.Text
        m_item.Description = txtDescription.Text
        m_item.OrderingID = nudOrderingID.Value
        If txtID.Enabled = True Then
            m_item.ID = txtID.Text '-- only save if user left it read-only
        End If
        Close()
    End Sub

    Private Sub llblChangeID_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblChangeID.LinkClicked
        MessageBox.Show("Everything internally is connected to the ID. Changing the ID will impact your data." & Environment.NewLine & Environment.NewLine & "Please be careful.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtID.ReadOnly = False
    End Sub
End Class