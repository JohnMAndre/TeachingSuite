<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassAssignmentDetails
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
        Dim OlvColumn2 As BrightIdeasSoftware.OLVColumn
        Dim OlvColumn4 As BrightIdeasSoftware.OLVColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassAssignmentDetails))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llblDeleteCategory = New System.Windows.Forms.LinkLabel()
        Me.llblAddCategory = New System.Windows.Forms.LinkLabel()
        Me.cboAssessmentCategory = New System.Windows.Forms.ComboBox()
        Me.lstAssessmentCategories = New System.Windows.Forms.ListBox()
        Me.chkIncludesAttachment = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvClassGroupOutcomes = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.olvAssignmentOutcomes = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.llblAddOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblRemoveOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblBrowseForAssignmentsPath = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtSavedAssignmentsPath = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblBrowseForAssignmentBrief = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtAssignmentBriefFilename = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.olvClassGroupOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvAssignmentOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OlvColumn2
        '
        OlvColumn2.AspectName = "Description"
        OlvColumn2.IsEditable = False
        OlvColumn2.Text = "Description"
        OlvColumn2.Width = 400
        '
        'OlvColumn4
        '
        OlvColumn4.AspectName = "Description"
        OlvColumn4.Text = "Description"
        OlvColumn4.Width = 400
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Label3)
        Me.KryptonPanel.Controls.Add(Me.llblDeleteCategory)
        Me.KryptonPanel.Controls.Add(Me.llblAddCategory)
        Me.KryptonPanel.Controls.Add(Me.cboAssessmentCategory)
        Me.KryptonPanel.Controls.Add(Me.lstAssessmentCategories)
        Me.KryptonPanel.Controls.Add(Me.chkIncludesAttachment)
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.llblBrowseForAssignmentsPath)
        Me.KryptonPanel.Controls.Add(Me.txtSavedAssignmentsPath)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.llblBrowseForAssignmentBrief)
        Me.KryptonPanel.Controls.Add(Me.txtAssignmentBriefFilename)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.btnOK)
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Controls.Add(Me.txtName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel.Size = New System.Drawing.Size(921, 563)
        Me.KryptonPanel.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Categories:"
        '
        'llblDeleteCategory
        '
        Me.llblDeleteCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblDeleteCategory.AutoSize = True
        Me.llblDeleteCategory.Location = New System.Drawing.Point(628, 471)
        Me.llblDeleteCategory.Name = "llblDeleteCategory"
        Me.llblDeleteCategory.Size = New System.Drawing.Size(98, 16)
        Me.llblDeleteCategory.TabIndex = 72
        Me.llblDeleteCategory.TabStop = True
        Me.llblDeleteCategory.Text = "Delete selected"
        '
        'llblAddCategory
        '
        Me.llblAddCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddCategory.AutoSize = True
        Me.llblAddCategory.Location = New System.Drawing.Point(628, 434)
        Me.llblAddCategory.Name = "llblAddCategory"
        Me.llblAddCategory.Size = New System.Drawing.Size(85, 16)
        Me.llblAddCategory.TabIndex = 71
        Me.llblAddCategory.TabStop = True
        Me.llblAddCategory.Text = "Add category"
        '
        'cboAssessmentCategory
        '
        Me.cboAssessmentCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAssessmentCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssessmentCategory.FormattingEnabled = True
        Me.cboAssessmentCategory.Location = New System.Drawing.Point(628, 389)
        Me.cboAssessmentCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAssessmentCategory.Name = "cboAssessmentCategory"
        Me.cboAssessmentCategory.Size = New System.Drawing.Size(170, 24)
        Me.cboAssessmentCategory.TabIndex = 70
        '
        'lstAssessmentCategories
        '
        Me.lstAssessmentCategories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAssessmentCategories.FormattingEnabled = True
        Me.lstAssessmentCategories.ItemHeight = 16
        Me.lstAssessmentCategories.Location = New System.Drawing.Point(599, 137)
        Me.lstAssessmentCategories.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstAssessmentCategories.Name = "lstAssessmentCategories"
        Me.lstAssessmentCategories.Size = New System.Drawing.Size(318, 244)
        Me.lstAssessmentCategories.TabIndex = 69
        '
        'chkIncludesAttachment
        '
        Me.chkIncludesAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncludesAttachment.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkIncludesAttachment.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkIncludesAttachment.Location = New System.Drawing.Point(742, 15)
        Me.chkIncludesAttachment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIncludesAttachment.Name = "chkIncludesAttachment"
        Me.chkIncludesAttachment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkIncludesAttachment.Size = New System.Drawing.Size(136, 20)
        Me.chkIncludesAttachment.TabIndex = 67
        Me.chkIncludesAttachment.Text = "Includes attachment:"
        Me.ToolTip1.SetToolTip(Me.chkIncludesAttachment, "If checked, when emailing module results, user will be prompted for attachment")
        Me.chkIncludesAttachment.Values.Text = "Includes attachment:"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(-1, 111)
        Me.KryptonSplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.olvClassGroupOutcomes)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel10)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.olvAssignmentOutcomes)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblAddOutcome)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblRemoveOutcome)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonLabel11)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(597, 409)
        Me.KryptonSplitContainer1.SplitterDistance = 289
        Me.KryptonSplitContainer1.TabIndex = 65
        '
        'olvClassGroupOutcomes
        '
        Me.olvClassGroupOutcomes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvClassGroupOutcomes.AllColumns.Add(Me.OlvColumn3)
        Me.olvClassGroupOutcomes.AllColumns.Add(OlvColumn4)
        Me.olvClassGroupOutcomes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvClassGroupOutcomes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvClassGroupOutcomes.CellEditUseWholeCell = False
        Me.olvClassGroupOutcomes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn3, OlvColumn4})
        Me.olvClassGroupOutcomes.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvClassGroupOutcomes.FullRowSelect = True
        Me.olvClassGroupOutcomes.Location = New System.Drawing.Point(3, 26)
        Me.olvClassGroupOutcomes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.olvClassGroupOutcomes.Name = "olvClassGroupOutcomes"
        Me.olvClassGroupOutcomes.ShowGroups = False
        Me.olvClassGroupOutcomes.Size = New System.Drawing.Size(281, 376)
        Me.olvClassGroupOutcomes.TabIndex = 62
        Me.olvClassGroupOutcomes.UseCompatibleStateImageBehavior = False
        Me.olvClassGroupOutcomes.UseFiltering = True
        Me.olvClassGroupOutcomes.View = System.Windows.Forms.View.Details
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Name"
        Me.OlvColumn3.AspectToStringFormat = ""
        Me.OlvColumn3.Text = "Name"
        Me.OlvColumn3.Width = 146
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(3, 4)
        Me.KryptonLabel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel10.Size = New System.Drawing.Size(110, 20)
        Me.KryptonLabel10.TabIndex = 63
        Me.KryptonLabel10.Values.Text = "Module outcomes"
        '
        'olvAssignmentOutcomes
        '
        Me.olvAssignmentOutcomes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvAssignmentOutcomes.AllColumns.Add(Me.OlvColumn1)
        Me.olvAssignmentOutcomes.AllColumns.Add(OlvColumn2)
        Me.olvAssignmentOutcomes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvAssignmentOutcomes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvAssignmentOutcomes.CellEditUseWholeCell = False
        Me.olvAssignmentOutcomes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, OlvColumn2})
        Me.olvAssignmentOutcomes.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvAssignmentOutcomes.FullRowSelect = True
        Me.olvAssignmentOutcomes.Location = New System.Drawing.Point(33, 26)
        Me.olvAssignmentOutcomes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.olvAssignmentOutcomes.Name = "olvAssignmentOutcomes"
        Me.olvAssignmentOutcomes.ShowGroups = False
        Me.olvAssignmentOutcomes.Size = New System.Drawing.Size(266, 376)
        Me.olvAssignmentOutcomes.TabIndex = 4
        Me.olvAssignmentOutcomes.UseCompatibleStateImageBehavior = False
        Me.olvAssignmentOutcomes.UseFiltering = True
        Me.olvAssignmentOutcomes.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Name"
        Me.OlvColumn1.AspectToStringFormat = ""
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.Width = 146
        '
        'llblAddOutcome
        '
        Me.llblAddOutcome.Location = New System.Drawing.Point(3, 62)
        Me.llblAddOutcome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.llblAddOutcome.Name = "llblAddOutcome"
        Me.llblAddOutcome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblAddOutcome.Size = New System.Drawing.Size(22, 18)
        Me.llblAddOutcome.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.llblAddOutcome, "Add selected module outcome to assignment")
        Me.llblAddOutcome.Values.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.llblAddOutcome.Values.Text = ""
        '
        'llblRemoveOutcome
        '
        Me.llblRemoveOutcome.Location = New System.Drawing.Point(3, 102)
        Me.llblRemoveOutcome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.llblRemoveOutcome.Name = "llblRemoveOutcome"
        Me.llblRemoveOutcome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblRemoveOutcome.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveOutcome.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.llblRemoveOutcome, "Remove selected outcome from assignment")
        Me.llblRemoveOutcome.Values.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.llblRemoveOutcome.Values.Text = ""
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel11.Location = New System.Drawing.Point(163, 4)
        Me.KryptonLabel11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel11.Size = New System.Drawing.Size(132, 20)
        Me.KryptonLabel11.TabIndex = 64
        Me.KryptonLabel11.Values.Text = "Assignment outcomes"
        '
        'llblBrowseForAssignmentsPath
        '
        Me.llblBrowseForAssignmentsPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblBrowseForAssignmentsPath.Location = New System.Drawing.Point(888, 79)
        Me.llblBrowseForAssignmentsPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.llblBrowseForAssignmentsPath.Name = "llblBrowseForAssignmentsPath"
        Me.llblBrowseForAssignmentsPath.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblBrowseForAssignmentsPath.Size = New System.Drawing.Size(19, 20)
        Me.llblBrowseForAssignmentsPath.TabIndex = 49
        Me.llblBrowseForAssignmentsPath.Values.Text = "..."
        '
        'txtSavedAssignmentsPath
        '
        Me.txtSavedAssignmentsPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSavedAssignmentsPath.Location = New System.Drawing.Point(149, 79)
        Me.txtSavedAssignmentsPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSavedAssignmentsPath.Name = "txtSavedAssignmentsPath"
        Me.txtSavedAssignmentsPath.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtSavedAssignmentsPath.Size = New System.Drawing.Size(729, 20)
        Me.txtSavedAssignmentsPath.TabIndex = 48
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(14, 79)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel2.Size = New System.Drawing.Size(117, 20)
        Me.KryptonLabel2.TabIndex = 47
        Me.KryptonLabel2.Values.Text = "Saved assignments:"
        '
        'llblBrowseForAssignmentBrief
        '
        Me.llblBrowseForAssignmentBrief.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblBrowseForAssignmentBrief.Location = New System.Drawing.Point(888, 47)
        Me.llblBrowseForAssignmentBrief.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.llblBrowseForAssignmentBrief.Name = "llblBrowseForAssignmentBrief"
        Me.llblBrowseForAssignmentBrief.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblBrowseForAssignmentBrief.Size = New System.Drawing.Size(19, 20)
        Me.llblBrowseForAssignmentBrief.TabIndex = 46
        Me.llblBrowseForAssignmentBrief.Values.Text = "..."
        '
        'txtAssignmentBriefFilename
        '
        Me.txtAssignmentBriefFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAssignmentBriefFilename.Location = New System.Drawing.Point(108, 47)
        Me.txtAssignmentBriefFilename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAssignmentBriefFilename.Name = "txtAssignmentBriefFilename"
        Me.txtAssignmentBriefFilename.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAssignmentBriefFilename.Size = New System.Drawing.Size(770, 20)
        Me.txtAssignmentBriefFilename.TabIndex = 45
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(14, 47)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel1.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel1.TabIndex = 43
        Me.KryptonLabel1.Values.Text = "Marking:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(490, 528)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnOK.Size = New System.Drawing.Size(105, 31)
        Me.btnOK.TabIndex = 26
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(342, 528)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnCancel.Size = New System.Drawing.Size(105, 31)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(108, 15)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtName.Size = New System.Drawing.Size(487, 20)
        Me.txtName.TabIndex = 24
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(14, 15)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel3.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel3.TabIndex = 23
        Me.KryptonLabel3.Values.Text = "Name:"
        '
        'ClassAssignmentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(921, 563)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClassAssignmentDetails"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Class Assignment Details"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.olvClassGroupOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvAssignmentOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents llblAddOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblRemoveOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents olvAssignmentOutcomes As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblBrowseForAssignmentBrief As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents txtAssignmentBriefFilename As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblBrowseForAssignmentsPath As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents txtSavedAssignmentsPath As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents olvClassGroupOutcomes As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents chkIncludesAttachment As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lstAssessmentCategories As System.Windows.Forms.ListBox
    Friend WithEvents llblDeleteCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents llblAddCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents cboAssessmentCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
