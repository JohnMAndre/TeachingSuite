Public Class ClassGroupDetails
    Private m_grp As ClassGroup
    Public Sub New(grp As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_grp = grp
        txtClassGroupName.Text = grp.Name
        nudModuleLength.Value = grp.NumberOfSessions
        nudSessionLength.Value = grp.SessionLength

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
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        m_grp.Name = txtClassGroupName.Text
        m_grp.NumberOfSessions = nudModuleLength.Value
        m_grp.SessionLength = nudSessionLength.Value
        m_grp.StartDate = dtpStartDate.Value
        m_grp.EndDateOverall = dtpEndDate.Value
        m_grp.StartDateCurrent = dtpStartDateCurrent.Value
        m_grp.EndDateCurrent = dtpEndDateCurrent.Value
        m_grp.UseNickname = chkUseNickname.Checked

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub RefreshOutcomeList()
        olvClassGroupOutcomes.ClearObjects()
        olvClassGroupOutcomes.SetObjects(m_grp.Outcomes)
        olvClassGroupOutcomes.Sort(olvClassGroupOutcomes.Columns(0), SortOrder.Ascending)
    End Sub

    Private Sub ClassGroupDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AutoSizeColumns(olvClassGroupOutcomes)
        RefreshOutcomeList()
    End Sub

    Private Sub llblAddOutcome_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddOutcome.LinkClicked
        Dim oc As New AssignmentOutcome()
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
        Dim sfd As New SaveFileDialog
        sfd.InitialDirectory = GetModuleDataFolder()
        sfd.DefaultExt = ".moduledata"
        sfd.Filter = "Module data files|*.tmd"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strFilename As String = sfd.FileName

            Dim xDoc As New Xml.XmlDocument()
            Dim xRoot As Xml.XmlElement = xDoc.AppendChild(xDoc.CreateElement("Outcomes"))
            Dim xElement As Xml.XmlElement
            For Each oc As AssignmentOutcome In m_grp.Outcomes
                xElement = xDoc.CreateElement("Outcome")
                xElement.SetAttribute("ID", oc.ID)
                xElement.SetAttribute("Name", oc.Name)
                xElement.InnerText = oc.Description
                xRoot.AppendChild(xElement)
            Next


            xDoc.Save(strFilename)
        End If
    End Sub

    Private Sub llblLoadOutcomes_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblLoadOutcomes.LinkClicked
        Dim ofd As New OpenFileDialog()
        ofd.InitialDirectory = GetModuleDataFolder()
        ofd.DefaultExt = ".moduledata"
        ofd.Filter = "Module data files|*.tmd"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim xDoc As New Xml.XmlDocument
            xDoc.Load(ofd.FileName)

            '-- Clear existing outcomes
            m_grp.Outcomes.Clear()

            Dim oc As AssignmentOutcome
            For Each xElement As Xml.XmlElement In xDoc.DocumentElement.ChildNodes
                oc = New AssignmentOutcome()
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
End Class
