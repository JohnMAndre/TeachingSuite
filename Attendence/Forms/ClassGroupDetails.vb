Public Class ClassGroupDetails
    Private m_grp As ClassGroup
    Public Sub New(grp As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_grp = grp
        txtClassGroupName.Text = grp.Name
        nudModuleLength.Value = grp.NumberOfSessions

        dtpStartDate.Value = grp.StartDate
        If grp.EndDateOverall = #12:00:00 AM# Then
            dtpEndDate.Value = Date.Today
        Else
            dtpEndDate.Value = grp.EndDateOverall
        End If
        If grp.EndDateOverall = #12:00:00 AM# Then
            dtpStartDateCurrent.Value = Date.Today
        Else
            dtpStartDateCurrent.Value = grp.StartDateCurrent
        End If
        If grp.EndDateOverall = #12:00:00 AM# Then
            dtpEndDateCurrent.Value = Date.Today
        Else
            dtpEndDateCurrent.Value = grp.EndDateCurrent
        End If

        chkUseNickname.Checked = grp.UseNickname


    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        m_grp.Name = txtClassGroupName.Text
        m_grp.NumberOfSessions = nudModuleLength.Value
        m_grp.StartDate = dtpStartDate.Value
        m_grp.EndDateOverall = dtpEndDate.Value
        m_grp.StartDateCurrent = dtpStartDateCurrent.Value
        m_grp.EndDateCurrent = dtpEndDateCurrent.Value
        m_grp.UseNickname = chkUseNickname.Checked

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub RefreshOutcomeList()
        olvClassGroupOutcomes.ClearObjects()
        olvClassGroupOutcomes.SetObjects(m_grp.Outcomes)
        olvClassGroupOutcomes.Sort(olvClassGroupOutcomes.Columns(0), SortOrder.Ascending)
    End Sub
    Private Sub ClassGroupDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RefreshOutcomeList()
        olvClassGroupOutcomes.PrimarySortColumn = OlvColumn1
        olvClassGroupOutcomes.SecondarySortColumn = OlvColumn3
        olvClassGroupOutcomes.Sort()

        AutoSizeColumns(olvClassGroupOutcomes)
    End Sub

    Private Sub llblAddOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddOutcome.LinkClicked
        Dim oc As New AssignmentOutcome(BTECGradeGroup.Pass)
        oc.Name = "1.0"
        oc.Description = String.Empty
        m_grp.Outcomes.Add(oc)
        RefreshOutcomeList()
    End Sub

    Private Sub llblRemoveOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveOutcome.LinkClicked
        If olvClassGroupOutcomes.SelectedObject Is Nothing Then
            MessageBox.Show("Please select an outcome to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '-- Remove from assignment and from OLV
            Try
                m_grp.RemoveOutcome(olvClassGroupOutcomes.SelectedObject)
                RefreshOutcomeList()
            Catch ex As Exception
                Log(ex)
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub llblSaveOutcomes_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblSaveOutcomes.LinkClicked
        If cboFramework.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a framework for this module.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog
        sfd.InitialDirectory = GetModuleDataFolder()
        sfd.DefaultExt = ".tmd"
        sfd.Filter = "Module data files|*.tmd"
        If sfd.ShowDialog = DialogResult.OK Then
            Dim strFilename As String = sfd.FileName

            Dim xDoc As New Xml.XmlDocument()
            Dim xRoot As Xml.XmlElement = xDoc.AppendChild(xDoc.CreateElement("Outcomes"))
            xRoot.SetAttribute("Framework", cboFramework.SelectedItem)
            Dim xElement As Xml.XmlElement
            m_grp.Outcomes.Sort()
            For Each oc As AssignmentOutcome In m_grp.Outcomes
                xElement = xDoc.CreateElement("Outcome")
                xElement.SetAttribute("ID", oc.ID)
                xElement.SetAttribute("GradeGroup", oc.GradeGroup)
                xElement.SetAttribute("Name", oc.Name)
                xElement.InnerText = oc.Description
                xRoot.AppendChild(xElement)
            Next

            xDoc.Save(strFilename)
        End If
    End Sub

    Private Sub llblLoadOutcomes_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblLoadOutcomes.LinkClicked
        '-- Load outcomes and grading criteria
        Dim ofd As New OpenFileDialog()
        ofd.InitialDirectory = GetModuleDataFolder()
        ofd.DefaultExt = ".tamd"
        ofd.Filter = "Module data files|*.tamd"
        If ofd.ShowDialog = DialogResult.OK Then
            Dim xDoc As New Xml.XmlDocument
            xDoc.Load(ofd.FileName)

            '-- Clear existing outcomes
            m_grp.Outcomes.Clear()

            Dim oc As AssignmentOutcome
            Dim xListOutcomes As Xml.XmlNodeList = xDoc.SelectNodes("//Outcome")
            For Each xElement As Xml.XmlElement In xListOutcomes
                Dim group As BTECGradeGroup
                Try
                    group = [Enum].Parse(GetType(BTECGradeGroup), xElement.GetAttribute("GradeGroup"), True)
                Catch ex As Exception
                    '-- If it's not there, then must be old QCF standard
                    group = BTECGradeGroup.Pass
                End Try
                oc = New AssignmentOutcome(group)
                oc.ID = xElement.GetAttribute("ID")
                oc.Name = xElement.GetAttribute("Name")
                oc.Description = xElement.InnerText
                m_grp.Outcomes.Add(oc)
            Next

            RefreshOutcomeList()
        End If
    End Sub

    Private Sub llblCopyStartDateToCurrent_LinkClicked(sender As Object, e As EventArgs) Handles llblCopyStartDateToCurrent.LinkClicked
        dtpStartDateCurrent.Value = dtpStartDate.Value
    End Sub

    Private Sub llblCopyEndDateToCurrent_LinkClicked(sender As Object, e As EventArgs) Handles llblCopyEndDateToCurrent.LinkClicked
        dtpEndDateCurrent.Value = dtpEndDate.Value
    End Sub

    Private Sub llblShowOutcomes_LinkClicked(sender As Object, e As EventArgs)
        pnlOutcomes.BringToFront()
    End Sub

End Class
