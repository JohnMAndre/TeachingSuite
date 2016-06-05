<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassGroupDetails
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OlvColumn4 As BrightIdeasSoftware.OLVColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassGroupDetails))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.llblCopyEndDateToCurrent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblCopyStartDateToCurrent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.chkUseNickname = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.dtpEndDateCurrent = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpStartDateCurrent = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpEndDate = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpStartDate = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudModuleLength = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtClassGroupName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.pnlOutcomes = New System.Windows.Forms.Panel()
        Me.cboFramework = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.olvClassGroupOutcomes = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.llblSaveOutcomes = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblRemoveOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblLoadOutcomes = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAddOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.pnlOutcomes.SuspendLayout()
        CType(Me.cboFramework, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvClassGroupOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OlvColumn4
        '
        OlvColumn4.AspectName = "Description"
        OlvColumn4.Text = "Description"
        OlvColumn4.Width = 350
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.llblCopyEndDateToCurrent)
        Me.KryptonPanel.Controls.Add(Me.llblCopyStartDateToCurrent)
        Me.KryptonPanel.Controls.Add(Me.chkUseNickname)
        Me.KryptonPanel.Controls.Add(Me.dtpEndDateCurrent)
        Me.KryptonPanel.Controls.Add(Me.dtpStartDateCurrent)
        Me.KryptonPanel.Controls.Add(Me.dtpEndDate)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.dtpStartDate)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.nudModuleLength)
        Me.KryptonPanel.Controls.Add(Me.btnOK)
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Controls.Add(Me.txtClassGroupName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.pnlOutcomes)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(596, 415)
        Me.KryptonPanel.TabIndex = 0
        '
        'llblCopyEndDateToCurrent
        '
        Me.llblCopyEndDateToCurrent.Location = New System.Drawing.Point(317, 112)
        Me.llblCopyEndDateToCurrent.Name = "llblCopyEndDateToCurrent"
        Me.llblCopyEndDateToCurrent.Size = New System.Drawing.Size(26, 19)
        Me.llblCopyEndDateToCurrent.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.llblCopyEndDateToCurrent, "Copy end date to current")
        Me.llblCopyEndDateToCurrent.Values.Text = ">>"
        '
        'llblCopyStartDateToCurrent
        '
        Me.llblCopyStartDateToCurrent.Location = New System.Drawing.Point(317, 87)
        Me.llblCopyStartDateToCurrent.Name = "llblCopyStartDateToCurrent"
        Me.llblCopyStartDateToCurrent.Size = New System.Drawing.Size(26, 19)
        Me.llblCopyStartDateToCurrent.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.llblCopyStartDateToCurrent, "Copy start date to current")
        Me.llblCopyStartDateToCurrent.Values.Text = ">>"
        '
        'chkUseNickname
        '
        Me.chkUseNickname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUseNickname.AutoSize = False
        Me.chkUseNickname.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkUseNickname.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkUseNickname.Location = New System.Drawing.Point(470, 12)
        Me.chkUseNickname.Name = "chkUseNickname"
        Me.chkUseNickname.Size = New System.Drawing.Size(114, 20)
        Me.chkUseNickname.TabIndex = 65
        Me.chkUseNickname.Text = "Use nickname"
        Me.chkUseNickname.Values.Text = "Use nickname"
        '
        'dtpEndDateCurrent
        '
        Me.dtpEndDateCurrent.CalendarTodayDate = New Date(2013, 2, 25, 0, 0, 0, 0)
        Me.dtpEndDateCurrent.Location = New System.Drawing.Point(344, 112)
        Me.dtpEndDateCurrent.Name = "dtpEndDateCurrent"
        Me.dtpEndDateCurrent.Size = New System.Drawing.Size(220, 21)
        Me.dtpEndDateCurrent.TabIndex = 62
        '
        'dtpStartDateCurrent
        '
        Me.dtpStartDateCurrent.CalendarTodayDate = New Date(2013, 2, 25, 0, 0, 0, 0)
        Me.dtpStartDateCurrent.Location = New System.Drawing.Point(344, 85)
        Me.dtpStartDateCurrent.Name = "dtpStartDateCurrent"
        Me.dtpStartDateCurrent.Size = New System.Drawing.Size(220, 21)
        Me.dtpStartDateCurrent.TabIndex = 60
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CalendarTodayDate = New Date(2013, 2, 25, 0, 0, 0, 0)
        Me.dtpEndDate.Location = New System.Drawing.Point(98, 112)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(220, 21)
        Me.dtpEndDate.TabIndex = 58
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 112)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel7.TabIndex = 57
        Me.KryptonLabel7.Values.Text = "End date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarTodayDate = New Date(2013, 2, 25, 0, 0, 0, 0)
        Me.dtpStartDate.Location = New System.Drawing.Point(98, 85)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(220, 21)
        Me.dtpStartDate.TabIndex = 56
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 85)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(73, 19)
        Me.KryptonLabel1.TabIndex = 55
        Me.KryptonLabel1.Values.Text = "Start date:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(172, 40)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel5.TabIndex = 53
        Me.KryptonLabel5.Values.Text = "Sessions"
        '
        'nudModuleLength
        '
        Me.nudModuleLength.Location = New System.Drawing.Point(98, 38)
        Me.nudModuleLength.Name = "nudModuleLength"
        Me.nudModuleLength.Size = New System.Drawing.Size(68, 21)
        Me.nudModuleLength.TabIndex = 47
        Me.nudModuleLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudModuleLength.ThousandsSeparator = True
        Me.nudModuleLength.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(317, 378)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 44
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(190, 378)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'txtClassGroupName
        '
        Me.txtClassGroupName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClassGroupName.Location = New System.Drawing.Point(98, 12)
        Me.txtClassGroupName.Name = "txtClassGroupName"
        Me.txtClassGroupName.Size = New System.Drawing.Size(380, 19)
        Me.txtClassGroupName.TabIndex = 42
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(96, 19)
        Me.KryptonLabel3.TabIndex = 41
        Me.KryptonLabel3.Values.Text = "Module name:"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(413, 66)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel11.TabIndex = 64
        Me.KryptonLabel11.Values.Text = "Current"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(172, 66)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(53, 19)
        Me.KryptonLabel10.TabIndex = 63
        Me.KryptonLabel10.Values.Text = "Overall"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 40)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(99, 19)
        Me.KryptonLabel2.TabIndex = 51
        Me.KryptonLabel2.Values.Text = "Module length:"
        '
        'pnlOutcomes
        '
        Me.pnlOutcomes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOutcomes.BackColor = System.Drawing.Color.Transparent
        Me.pnlOutcomes.Controls.Add(Me.cboFramework)
        Me.pnlOutcomes.Controls.Add(Me.olvClassGroupOutcomes)
        Me.pnlOutcomes.Controls.Add(Me.llblSaveOutcomes)
        Me.pnlOutcomes.Controls.Add(Me.KryptonLabel8)
        Me.pnlOutcomes.Controls.Add(Me.llblRemoveOutcome)
        Me.pnlOutcomes.Controls.Add(Me.llblLoadOutcomes)
        Me.pnlOutcomes.Controls.Add(Me.llblAddOutcome)
        Me.pnlOutcomes.Location = New System.Drawing.Point(3, 139)
        Me.pnlOutcomes.Name = "pnlOutcomes"
        Me.pnlOutcomes.Size = New System.Drawing.Size(590, 233)
        Me.pnlOutcomes.TabIndex = 71
        '
        'cboFramework
        '
        Me.cboFramework.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFramework.DropDownWidth = 121
        Me.cboFramework.Items.AddRange(New Object() {"QCF", "RQF"})
        Me.cboFramework.Location = New System.Drawing.Point(314, 7)
        Me.cboFramework.Name = "cboFramework"
        Me.cboFramework.Size = New System.Drawing.Size(211, 20)
        Me.cboFramework.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.cboFramework, "Which framework (for BTEC modules)")
        '
        'olvClassGroupOutcomes
        '
        Me.olvClassGroupOutcomes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvClassGroupOutcomes.AllColumns.Add(Me.OlvColumn3)
        Me.olvClassGroupOutcomes.AllColumns.Add(Me.OlvColumn1)
        Me.olvClassGroupOutcomes.AllColumns.Add(OlvColumn4)
        Me.olvClassGroupOutcomes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvClassGroupOutcomes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvClassGroupOutcomes.CellEditUseWholeCell = False
        Me.olvClassGroupOutcomes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn3, Me.OlvColumn1, OlvColumn4})
        Me.olvClassGroupOutcomes.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvClassGroupOutcomes.FullRowSelect = True
        Me.olvClassGroupOutcomes.HighlightBackgroundColor = System.Drawing.Color.Empty
        Me.olvClassGroupOutcomes.HighlightForegroundColor = System.Drawing.Color.Empty
        Me.olvClassGroupOutcomes.IncludeColumnHeadersInCopy = True
        Me.olvClassGroupOutcomes.Location = New System.Drawing.Point(0, 33)
        Me.olvClassGroupOutcomes.Name = "olvClassGroupOutcomes"
        Me.olvClassGroupOutcomes.ShowGroups = False
        Me.olvClassGroupOutcomes.Size = New System.Drawing.Size(590, 200)
        Me.olvClassGroupOutcomes.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.olvClassGroupOutcomes.TabIndex = 64
        Me.olvClassGroupOutcomes.UseCompatibleStateImageBehavior = False
        Me.olvClassGroupOutcomes.UseFiltering = True
        Me.olvClassGroupOutcomes.View = System.Windows.Forms.View.Details
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Name"
        Me.OlvColumn3.AspectToStringFormat = ""
        Me.OlvColumn3.Text = "Name"
        Me.OlvColumn3.Width = 75
        '
        'llblSaveOutcomes
        '
        Me.llblSaveOutcomes.Location = New System.Drawing.Point(255, 8)
        Me.llblSaveOutcomes.Name = "llblSaveOutcomes"
        Me.llblSaveOutcomes.Size = New System.Drawing.Size(22, 18)
        Me.llblSaveOutcomes.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.llblSaveOutcomes, "Save grading criteria as module file")
        Me.llblSaveOutcomes.Values.Image = Global.Teaching.My.Resources.Resources.save_16
        Me.llblSaveOutcomes.Values.Text = ""
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(0, 8)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(172, 19)
        Me.KryptonLabel8.TabIndex = 65
        Me.KryptonLabel8.Values.Text = "Outcomes / grading criteria"
        '
        'llblRemoveOutcome
        '
        Me.llblRemoveOutcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRemoveOutcome.Location = New System.Drawing.Point(568, 8)
        Me.llblRemoveOutcome.Name = "llblRemoveOutcome"
        Me.llblRemoveOutcome.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveOutcome.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.llblRemoveOutcome, "Remove selected grading criteria from module")
        Me.llblRemoveOutcome.Values.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.llblRemoveOutcome.Values.Text = ""
        '
        'llblLoadOutcomes
        '
        Me.llblLoadOutcomes.Location = New System.Drawing.Point(212, 8)
        Me.llblLoadOutcomes.Name = "llblLoadOutcomes"
        Me.llblLoadOutcomes.Size = New System.Drawing.Size(22, 18)
        Me.llblLoadOutcomes.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.llblLoadOutcomes, "Load grading criteria from module file")
        Me.llblLoadOutcomes.Values.Image = Global.Teaching.My.Resources.Resources.upload_16
        Me.llblLoadOutcomes.Values.Text = ""
        '
        'llblAddOutcome
        '
        Me.llblAddOutcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddOutcome.Location = New System.Drawing.Point(536, 8)
        Me.llblAddOutcome.Name = "llblAddOutcome"
        Me.llblAddOutcome.Size = New System.Drawing.Size(22, 18)
        Me.llblAddOutcome.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.llblAddOutcome, "Add grading criteria to module")
        Me.llblAddOutcome.Values.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.llblAddOutcome.Values.Text = ""
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "GradeGroup"
        Me.OlvColumn1.Text = "Group"
        Me.OlvColumn1.Width = 106
        '
        'ClassGroupDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 415)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClassGroupDetails"
        Me.Text = "Module Details"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.pnlOutcomes.ResumeLayout(False)
        Me.pnlOutcomes.PerformLayout()
        CType(Me.cboFramework, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvClassGroupOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudModuleLength As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtClassGroupName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpStartDate As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpEndDateCurrent As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpStartDateCurrent As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpEndDate As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkUseNickname As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents olvClassGroupOutcomes As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblAddOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblRemoveOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblSaveOutcomes As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblLoadOutcomes As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblCopyEndDateToCurrent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblCopyStartDateToCurrent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents pnlOutcomes As System.Windows.Forms.Panel
    Friend WithEvents cboFramework As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
End Class
