Public Class ClassAssignmentDetails

    Private m_classGroup As ClassGroup
    Private m_assignment As ClassAssignmentBTEC
    Private m_boolDeleteAssignmentOnCancel As Boolean
    Private m_boolCopyAssignmentBrief As Boolean

    Public Sub New(cls As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = cls
        Me.Text &= " - " & m_classGroup.Name

        m_boolDeleteAssignmentOnCancel = True

        '-- create new assignment
        m_assignment = New ClassAssignmentBTEC(m_classGroup)
        m_classGroup.AssignmentsBTEC.Add(m_assignment)

        LoadClassGroupOutcomes()
    End Sub
    Public Sub New(cls As ClassGroup, assignment As ClassAssignmentBTEC)

        ' This call is required by the designer.
        InitializeComponent()

        m_assignment = assignment
        m_classGroup = cls
        Me.Text &= " - " & m_classGroup.Name

        txtName.Text = m_assignment.Name
        chkM1Available.Checked = m_assignment.M1Available
        chkM2Available.Checked = m_assignment.M2Available
        chkM3Available.Checked = m_assignment.M3Available
        chkD1Available.Checked = m_assignment.D1Available
        chkD2Available.Checked = m_assignment.D2Available
        chkD3Available.Checked = m_assignment.D3Available

        txtM1Description.Text = m_assignment.M1Description
        txtM2Description.Text = m_assignment.M2Description
        txtM3Description.Text = m_assignment.M3Description
        txtD1Description.Text = m_assignment.D1Description
        txtD2Description.Text = m_assignment.D2Description
        txtD3Description.Text = m_assignment.D3Description

        olvAssignmentOutcomes.SetObjects(m_assignment.Outcomes)
        olvAssignmentOutcomes.Sort(olvAssignmentOutcomes.Columns(0), SortOrder.Ascending)

        LoadClassGroupOutcomes()

        If m_assignment.AssignmentBriefFilename.Trim.Length > 0 Then
            txtAssignmentBriefFilename.Text = System.IO.Path.Combine(GetMarkingFolder(), m_assignment.AssignmentBriefFilename)
        End If
        m_boolCopyAssignmentBrief = False

        txtSavedAssignmentsPath.Text = m_assignment.SavedAssignmentsFolder
        chkIncludesAttachment.Checked = m_assignment.IncludesAttachment

    End Sub
    Private Sub LoadClassGroupOutcomes()
        olvClassGroupOutcomes.SetObjects(m_classGroup.Outcomes)
        olvClassGroupOutcomes.Sort(olvClassGroupOutcomes.Columns(0), SortOrder.Ascending)
    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        'If m_assignment Is Nothing Then


        '    'm_assignment.Outcomes.Clear()
        '    If olvAssignmentOutcomes.Objects IsNot Nothing Then
        '        For Each outcome As AssignmentOutcome In olvAssignmentOutcomes.Objects
        '            m_assignment.Outcomes.Add(outcome)
        '        Next
        '    End If

        'End If

        m_assignment.Name = txtName.Text
        m_assignment.M1Available = chkM1Available.Checked
        m_assignment.M2Available = chkM2Available.Checked
        m_assignment.M3Available = chkM3Available.Checked
        m_assignment.D1Available = chkD1Available.Checked
        m_assignment.D2Available = chkD2Available.Checked
        m_assignment.D3Available = chkD3Available.Checked
        m_assignment.AssignmentBriefFilename = System.IO.Path.GetFileName(txtAssignmentBriefFilename.Text)
        m_assignment.SavedAssignmentsFolder = txtSavedAssignmentsPath.Text
        m_assignment.M1Description = txtM1Description.Text
        m_assignment.M2Description = txtM2Description.Text
        m_assignment.M3Description = txtM3Description.Text
        m_assignment.D1Description = txtD1Description.Text
        m_assignment.D2Description = txtD2Description.Text
        m_assignment.D3Description = txtD3Description.Text
        m_assignment.IncludesAttachment = chkIncludesAttachment.Checked


        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub llblAddOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddOutcome.LinkClicked
        '-- make sure outcome is not already on this assignment
        Dim lstClassGroupOutcomes As IList = olvClassGroupOutcomes.SelectedObjects

        If lstClassGroupOutcomes.Count = 0 Then
            MessageBox.Show("Please select an outcome from the module to add to this assignment.", Application.ProductName)
            Exit Sub
        End If

        For Each newAsmtOutcome As AssignmentOutcome In lstClassGroupOutcomes
            If m_assignment IsNot Nothing AndAlso m_assignment.Outcomes.Contains(newAsmtOutcome) Then
                MessageBox.Show("One of the selected module outcomes is already on this assignment. You cannot add it twice.", Application.ProductName)
            Else
                '-- If it's ok then add to the assignment
                m_assignment.Outcomes.Add(newAsmtOutcome)
            End If
        Next


        '-- Update the UI
        olvAssignmentOutcomes.ClearObjects()
        olvAssignmentOutcomes.SetObjects(m_assignment.Outcomes)

        'Dim outcome As New AssignmentOutcome()
        'outcome.Name = "1.0"
        'outcome.Description = "description"
        'olvAssignmentOutcomes.AddObject(outcome)
    End Sub

    Private Sub llblRemoveOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveOutcome.LinkClicked
        If olvAssignmentOutcomes.SelectedObject Is Nothing Then
            MessageBox.Show("Please select an outcome to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '-- Remove from assignment and from OLV
            Try
                m_assignment.RemoveOutcome(olvAssignmentOutcomes.SelectedObject)
                olvAssignmentOutcomes.RemoveObject(olvAssignmentOutcomes.SelectedObject)
            Catch ex As Exception
                Log(ex)
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub llblBrowseForAssignmentBrief_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblBrowseForAssignmentBrief.LinkClicked
        Try
            Dim ofd As New OpenFileDialog()

            If ofd.ShowDialog = DialogResult.OK Then
                txtAssignmentBriefFilename.Text = ofd.FileName
                m_boolCopyAssignmentBrief = True
            End If
        Catch ex As Exception
            MessageBox.Show("There was en error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClassAssignmentDetails_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If m_boolCopyAssignmentBrief Then
                '-- copy over to data folder
                If Not txtAssignmentBriefFilename.Text.Contains(GetMarkingFolder()) Then
                    Dim strDestination As String = System.IO.Path.Combine(GetMarkingFolder(), System.IO.Path.GetFileName(txtAssignmentBriefFilename.Text))
                    If System.IO.File.Exists(strDestination) Then
                        If MessageBox.Show(strDestination & " already exists. Overwrite?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                            System.IO.File.Delete(strDestination)
                        End If
                    End If
                    System.IO.File.Copy(txtAssignmentBriefFilename.Text, strDestination)
                End If
                m_assignment.AssignmentBriefFilename = System.IO.Path.GetFileName(txtAssignmentBriefFilename.Text)
            End If


        Catch ex As Exception
            MessageBox.Show("There was en error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        m_boolCopyAssignmentBrief = False

        If m_boolDeleteAssignmentOnCancel Then
            m_classGroup.AssignmentsBTEC.Remove(m_assignment)
        End If

        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtAssignmentBriefFilename_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAssignmentBriefFilename.TextChanged
        m_boolCopyAssignmentBrief = True
    End Sub

    Private Sub llblBrowseForAssignmentsPath_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblBrowseForAssignmentsPath.LinkClicked
        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Select folder to save assignment copies."
            fbd.ShowNewFolderButton =
            fbd.SelectedPath = txtSavedAssignmentsPath.Text
            If fbd.ShowDialog = DialogResult.OK Then
                txtSavedAssignmentsPath.Text = fbd.SelectedPath
            End If
        End Using
    End Sub

    Private Sub ClassAssignmentDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClassAssignmentDetails_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        AutoSizeColumns(olvAssignmentOutcomes)
        AutoSizeColumns(olvClassGroupOutcomes)
    End Sub

End Class
