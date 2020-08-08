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
        'chkM1Available.Checked = m_assignment.M1Available
        'chkM2Available.Checked = m_assignment.M2Available
        'chkM3Available.Checked = m_assignment.M3Available
        'chkD1Available.Checked = m_assignment.D1Available
        'chkD2Available.Checked = m_assignment.D2Available
        'chkD3Available.Checked = m_assignment.D3Available

        'txtM1Description.Text = m_assignment.M1Description
        'txtM2Description.Text = m_assignment.M2Description
        'txtM3Description.Text = m_assignment.M3Description
        'txtD1Description.Text = m_assignment.D1Description
        'txtD2Description.Text = m_assignment.D2Description
        'txtD3Description.Text = m_assignment.D3Description

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
        'm_assignment.M1Available = chkM1Available.Checked
        'm_assignment.M2Available = chkM2Available.Checked
        'm_assignment.M3Available = chkM3Available.Checked
        'm_assignment.D1Available = chkD1Available.Checked
        'm_assignment.D2Available = chkD2Available.Checked
        'm_assignment.D3Available = chkD3Available.Checked
        m_assignment.AssignmentBriefFilename = System.IO.Path.GetFileName(txtAssignmentBriefFilename.Text)
        m_assignment.SavedAssignmentsFolder = txtSavedAssignmentsPath.Text
        'm_assignment.M1Description = txtM1Description.Text
        'm_assignment.M2Description = txtM2Description.Text
        'm_assignment.M3Description = txtM3Description.Text
        'm_assignment.D1Description = txtD1Description.Text
        'm_assignment.D2Description = txtD2Description.Text
        'm_assignment.D3Description = txtD3Description.Text
        m_assignment.IncludesAttachment = chkIncludesAttachment.Checked

        AddApplicationHistory("Modified module assignment (Module: " & m_classGroup.Name & ", Assignment: " & m_assignment.Name & ").")


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
                If Not txtAssignmentBriefFilename.Text.ToLower().Contains(GetMarkingFolder().ToLower()) Then
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
        For Each cat In [Enum].GetValues(GetType(Semester.AssessmentCategory))
            cboAssessmentCategory.Items.Add(cat)
        Next

        cboAssessmentCategory.SelectedIndex = 0 '-- select first one

        LoadAssessmentCategories()
    End Sub

    Private Sub ClassAssignmentDetails_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        AutoSizeColumns(olvAssignmentOutcomes)
        AutoSizeColumns(olvClassGroupOutcomes)
    End Sub
    Private Sub llblAddCategory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblAddCategory.LinkClicked
        m_assignment.AssessmentCategories.Add(cboAssessmentCategory.SelectedIndex)
        LoadAssessmentCategories()
    End Sub

    Private Sub llblDeleteCategory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblDeleteCategory.LinkClicked
        For intCounter As Integer = 0 To m_assignment.AssessmentCategories.Count - 1
            If m_assignment.AssessmentCategories(intCounter) = lstAssessmentCategories.SelectedItem Then
                m_assignment.AssessmentCategories.RemoveAt(intCounter)
                Exit For '-- can just delete one at a time
            End If
        Next

        LoadAssessmentCategories()
    End Sub
    Private Sub LoadAssessmentCategories()
        lstAssessmentCategories.Items.Clear()
        For Each cat As Semester.AssessmentCategory In m_assignment.AssessmentCategories
            lstAssessmentCategories.Items.Add(cat)
        Next
    End Sub
End Class
