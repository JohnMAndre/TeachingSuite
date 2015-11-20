Public Class ClassAssignmentNormalDetails

    Private m_classGroup As ClassGroup
    Private m_assignment As ClassAssignment
    Private m_boolDeleteAssignmentOnCancel As Boolean

    Public Sub New(cls As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()


        m_classGroup = cls
        Me.Text &= " - " & m_classGroup.Name

        m_boolDeleteAssignmentOnCancel = True

        '-- create new assignment
        m_assignment = New ClassAssignment(m_classGroup)
        m_classGroup.Assignments.Add(m_assignment)

    End Sub
    Public Sub New(cls As ClassGroup, assignment As ClassAssignment)

        ' This call is required by the designer.
        InitializeComponent()

        m_assignment = assignment
        m_classGroup = cls
        Me.Text &= " - " & m_classGroup.Name
        txtName.Text = m_assignment.Name
        nudMaxPoints.Value = m_assignment.MaxPoints
        txtOverallDefaultText.Text = m_assignment.OverallDefaultText
        chkIncludesAttachment.Checked = m_assignment.IncludesAttachment
        dtpReleaseDate.Value = m_assignment.ReleaseDate
        dtpSubmitDate.Value = m_assignment.SubmitDate

        nudWeighting.Value = ConvertToDecimal(m_assignment.Weighting, 1)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        m_assignment.Name = txtName.Text
        m_assignment.OverallDefaultText = txtOverallDefaultText.Text
        m_assignment.MaxPoints = nudMaxPoints.Value
        m_assignment.IncludesAttachment = chkIncludesAttachment.Checked
        m_assignment.ReleaseDate = dtpReleaseDate.Value
        m_assignment.SubmitDate = dtpSubmitDate.Value
        m_assignment.Weighting = ConvertToDouble(nudWeighting.Value.ToString(), 1)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class