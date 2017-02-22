<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAssignmentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentAssignmentDetails))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.nudResearchQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudWritingQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.txtTags = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearImprovementItem = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblRemoveImprovementItem = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAddImprovementItem = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer4 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvOutcomes = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumnOutcomeName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.llblModuleResults = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.olvModuleResults = New BrightIdeasSoftware.ObjectListView()
        Me.olv1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvModuleResultsPassFail = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.imglstFeedback = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGenerateImprovementCommentsNoGradeHint = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.rtbObservationComments = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.rtbImprovementComments = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.rtbOverallComments = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnGenerateOverallComments = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnGenerateImprovementComments = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnGenerateImprovementCommentsLate = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lblImprovementCharCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonSplitContainer3 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvAutoFeedback = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvPassFailFeedback = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.txtFeedbackFilter = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblClearFilter = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.olvImprovementItems = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolDateAdded = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolDateRemoved = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolPerformanceLevel = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.llblOpenSavedMarkingPage = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblWarningNotice = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.chkProcessed = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.btnPrintMarkingSheet = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblSaveFeedbackSheet = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.llblExistingAssignment = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.llblDeleteAssignment = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblCopyAssignmentFromCD = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblEjectCD = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtTimer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblToggleTimer = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblResetTimer = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblStudentPic = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudPlagiarismSeverity = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSchoolClass = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblRefreshOutcomeCount = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.nudAltNumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudPresentationQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.lblOutcomesPassed = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblEditStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAlreadyD3 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAlreadyD2 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAlreadyD1 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAlreadyM3 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAlreadyM2 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAlreadyM1 = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblFailAll = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblPassAll = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAssignmentName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtStudentID = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNickName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkD3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkD2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkD1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkM3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkM2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkM1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.llblOpenStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrFilterFeedback = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SpellCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1SpellChecker1 = New C1.Win.C1SpellChecker.C1SpellChecker(Me.components)
        Me.ctxmnuExistingAssignment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyLocalFilenameToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLocalFileInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyAllOutcomeFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplySelectedFeedbackToAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFeedbackFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveFeedbackFrom1stTo2ndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveFeedbackFrom2ndTo3rdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkStudentDidNotSubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonSplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer4.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer4.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer4.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer4.Panel2.SuspendLayout()
        Me.KryptonSplitContainer4.SuspendLayout()
        CType(Me.olvOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvModuleResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel2.SuspendLayout()
        Me.KryptonSplitContainer3.SuspendLayout()
        CType(Me.olvAutoFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SpellChecker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmnuExistingAssignment.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.nudResearchQuality)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonPanel.Controls.Add(Me.nudWritingQuality)
        Me.KryptonPanel.Controls.Add(Me.txtTags)
        Me.KryptonPanel.Controls.Add(Me.llblClearImprovementItem)
        Me.KryptonPanel.Controls.Add(Me.llblRemoveImprovementItem)
        Me.KryptonPanel.Controls.Add(Me.llblAddImprovementItem)
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonPanel.Controls.Add(Me.llblStudentPic)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel.Controls.Add(Me.nudPlagiarismSeverity)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.txtSchoolClass)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel.Controls.Add(Me.llblRefreshOutcomeCount)
        Me.KryptonPanel.Controls.Add(Me.nudAltNumber)
        Me.KryptonPanel.Controls.Add(Me.nudPresentationQuality)
        Me.KryptonPanel.Controls.Add(Me.lblOutcomesPassed)
        Me.KryptonPanel.Controls.Add(Me.llblEditStudent)
        Me.KryptonPanel.Controls.Add(Me.llblAlreadyD3)
        Me.KryptonPanel.Controls.Add(Me.llblAlreadyD2)
        Me.KryptonPanel.Controls.Add(Me.llblAlreadyD1)
        Me.KryptonPanel.Controls.Add(Me.llblAlreadyM3)
        Me.KryptonPanel.Controls.Add(Me.llblAlreadyM2)
        Me.KryptonPanel.Controls.Add(Me.llblAlreadyM1)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Controls.Add(Me.llblFailAll)
        Me.KryptonPanel.Controls.Add(Me.llblPassAll)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.txtAssignmentName)
        Me.KryptonPanel.Controls.Add(Me.txtStudentID)
        Me.KryptonPanel.Controls.Add(Me.txtNickName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.chkD3)
        Me.KryptonPanel.Controls.Add(Me.chkD2)
        Me.KryptonPanel.Controls.Add(Me.chkD1)
        Me.KryptonPanel.Controls.Add(Me.chkM3)
        Me.KryptonPanel.Controls.Add(Me.chkM2)
        Me.KryptonPanel.Controls.Add(Me.chkM1)
        Me.KryptonPanel.Controls.Add(Me.llblOpenStudent)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Palette = Me.KryptonPalette1
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel.Size = New System.Drawing.Size(1169, 596)
        Me.KryptonPanel.TabIndex = 0
        '
        'nudResearchQuality
        '
        Me.nudResearchQuality.Location = New System.Drawing.Point(339, 24)
        Me.nudResearchQuality.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudResearchQuality.Name = "nudResearchQuality"
        Me.nudResearchQuality.Palette = Me.KryptonPalette1
        Me.nudResearchQuality.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.nudResearchQuality.Size = New System.Drawing.Size(44, 22)
        Me.nudResearchQuality.TabIndex = 127
        Me.nudResearchQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudResearchQuality.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudResearchQuality, "0=not concerned, 5=watch 5 next asmts for plagiarism")
        Me.nudResearchQuality.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(293, 26)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Palette = Me.KryptonPalette1
        Me.KryptonLabel14.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel14.Size = New System.Drawing.Size(49, 20)
        Me.KryptonLabel14.TabIndex = 128
        Me.KryptonLabel14.Values.Text = "Resrch:"
        '
        'nudWritingQuality
        '
        Me.nudWritingQuality.Location = New System.Drawing.Point(219, 25)
        Me.nudWritingQuality.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudWritingQuality.Name = "nudWritingQuality"
        Me.nudWritingQuality.Size = New System.Drawing.Size(68, 21)
        Me.nudWritingQuality.TabIndex = 115
        Me.nudWritingQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudWritingQuality.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudWritingQuality, "Writing quality of student")
        Me.nudWritingQuality.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'txtTags
        '
        Me.txtTags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTags.Location = New System.Drawing.Point(633, 26)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(532, 19)
        Me.txtTags.TabIndex = 70
        '
        'llblClearImprovementItem
        '
        Me.llblClearImprovementItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblClearImprovementItem.Location = New System.Drawing.Point(1137, 72)
        Me.llblClearImprovementItem.Name = "llblClearImprovementItem"
        Me.llblClearImprovementItem.Size = New System.Drawing.Size(22, 18)
        Me.llblClearImprovementItem.TabIndex = 126
        Me.ToolTip1.SetToolTip(Me.llblClearImprovementItem, "Clear improvement item from student")
        Me.llblClearImprovementItem.Values.Image = Global.Teaching.My.Resources.Resources.no_16
        Me.llblClearImprovementItem.Values.Text = ""
        '
        'llblRemoveImprovementItem
        '
        Me.llblRemoveImprovementItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRemoveImprovementItem.Location = New System.Drawing.Point(1109, 72)
        Me.llblRemoveImprovementItem.Name = "llblRemoveImprovementItem"
        Me.llblRemoveImprovementItem.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveImprovementItem.TabIndex = 125
        Me.ToolTip1.SetToolTip(Me.llblRemoveImprovementItem, "Remove improvement item from student")
        Me.llblRemoveImprovementItem.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.llblRemoveImprovementItem.Values.Text = ""
        '
        'llblAddImprovementItem
        '
        Me.llblAddImprovementItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddImprovementItem.Location = New System.Drawing.Point(1081, 72)
        Me.llblAddImprovementItem.Name = "llblAddImprovementItem"
        Me.llblAddImprovementItem.Size = New System.Drawing.Size(22, 18)
        Me.llblAddImprovementItem.TabIndex = 124
        Me.ToolTip1.SetToolTip(Me.llblAddImprovementItem, "Add improvement items for student")
        Me.llblAddImprovementItem.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAddImprovementItem.Values.Text = ""
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 92)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.KryptonSplitContainer1)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblOpenSavedMarkingPage)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblWarningNotice)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.chkProcessed)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.btnPrintMarkingSheet)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblSaveFeedbackSheet)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.btnCancel)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblExistingAssignment)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.btnOK)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblDeleteAssignment)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblCopyAssignmentFromCD)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblEjectCD)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.txtTimer)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblToggleTimer)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.llblResetTimer)
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(1169, 504)
        Me.KryptonSplitContainer2.SplitterDistance = 433
        Me.KryptonSplitContainer2.TabIndex = 123
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonSplitContainer4)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonSplitContainer3)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1169, 433)
        Me.KryptonSplitContainer1.SplitterDistance = 736
        Me.KryptonSplitContainer1.TabIndex = 91
        '
        'KryptonSplitContainer4
        '
        Me.KryptonSplitContainer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer4.Name = "KryptonSplitContainer4"
        Me.KryptonSplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer4.Panel1
        '
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.olvOutcomes)
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.llblModuleResults)
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.olvModuleResults)
        '
        'KryptonSplitContainer4.Panel2
        '
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.btnGenerateImprovementCommentsNoGradeHint)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.KryptonLabel13)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.rtbObservationComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.rtbImprovementComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.rtbOverallComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.KryptonLabel4)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.btnGenerateOverallComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.btnGenerateImprovementComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.btnGenerateImprovementCommentsLate)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.lblImprovementCharCount)
        Me.KryptonSplitContainer4.Size = New System.Drawing.Size(736, 433)
        Me.KryptonSplitContainer4.SplitterDistance = 224
        Me.KryptonSplitContainer4.TabIndex = 125
        '
        'olvOutcomes
        '
        Me.olvOutcomes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumnOutcomeName)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn6)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn7)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn8)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn9)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn10)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn11)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn12)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn2)
        Me.olvOutcomes.AllowColumnReorder = True
        Me.olvOutcomes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvOutcomes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvOutcomes.CellEditUseWholeCell = False
        Me.olvOutcomes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumnOutcomeName, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn11, Me.OlvColumn12, Me.OlvColumn2})
        Me.olvOutcomes.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvOutcomes.FullRowSelect = True
        Me.olvOutcomes.HideSelection = False
        Me.olvOutcomes.Location = New System.Drawing.Point(2, 0)
        Me.olvOutcomes.Name = "olvOutcomes"
        Me.olvOutcomes.ShowGroups = False
        Me.olvOutcomes.Size = New System.Drawing.Size(636, 221)
        Me.olvOutcomes.TabIndex = 42
        Me.olvOutcomes.UseCompatibleStateImageBehavior = False
        Me.olvOutcomes.UseFiltering = True
        Me.olvOutcomes.View = System.Windows.Forms.View.Details
        '
        'OlvColumnOutcomeName
        '
        Me.OlvColumnOutcomeName.AspectName = "Name"
        Me.OlvColumnOutcomeName.DisplayIndex = 1
        Me.OlvColumnOutcomeName.IsEditable = False
        Me.OlvColumnOutcomeName.Text = "Name"
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "Description"
        Me.OlvColumn6.DisplayIndex = 0
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Description"
        Me.OlvColumn6.Width = 288
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "FirstTryStatus"
        Me.OlvColumn7.DisplayIndex = 3
        Me.OlvColumn7.Text = "First"
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "FirstTryComments"
        Me.OlvColumn8.DisplayIndex = 4
        Me.OlvColumn8.Text = "Feedback"
        Me.OlvColumn8.Width = 299
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "SecondTryStatus"
        Me.OlvColumn9.DisplayIndex = 5
        Me.OlvColumn9.Text = "Rework"
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "SecondTryComments"
        Me.OlvColumn10.DisplayIndex = 6
        Me.OlvColumn10.Text = "Feedback"
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "ThirdTryStatus"
        Me.OlvColumn11.DisplayIndex = 7
        Me.OlvColumn11.Text = "2nd Rework"
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "ThirdTryComments"
        Me.OlvColumn12.DisplayIndex = 8
        Me.OlvColumn12.Text = "Feedback"
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "BaseOutcome.GradeGroup"
        Me.OlvColumn2.DisplayIndex = 2
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.Text = "Grade"
        Me.OlvColumn2.Width = 77
        '
        'llblModuleResults
        '
        Me.llblModuleResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblModuleResults.Location = New System.Drawing.Point(644, 4)
        Me.llblModuleResults.Name = "llblModuleResults"
        Me.llblModuleResults.Palette = Me.KryptonPalette1
        Me.llblModuleResults.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblModuleResults.Size = New System.Drawing.Size(91, 20)
        Me.llblModuleResults.TabIndex = 124
        Me.ToolTip1.SetToolTip(Me.llblModuleResults, "Refresh module results")
        Me.llblModuleResults.Values.Text = "Module results"
        '
        'olvModuleResults
        '
        Me.olvModuleResults.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvModuleResults.AllColumns.Add(Me.olv1)
        Me.olvModuleResults.AllColumns.Add(Me.olvModuleResultsPassFail)
        Me.olvModuleResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvModuleResults.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvModuleResults.CellEditUseWholeCell = False
        Me.olvModuleResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.olv1, Me.olvModuleResultsPassFail})
        Me.olvModuleResults.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvModuleResults.FullRowSelect = True
        Me.olvModuleResults.HideSelection = False
        Me.olvModuleResults.Location = New System.Drawing.Point(642, 25)
        Me.olvModuleResults.Name = "olvModuleResults"
        Me.olvModuleResults.ShowGroups = False
        Me.olvModuleResults.ShowImagesOnSubItems = True
        Me.olvModuleResults.Size = New System.Drawing.Size(93, 197)
        Me.olvModuleResults.SmallImageList = Me.imglstFeedback
        Me.olvModuleResults.TabIndex = 44
        Me.olvModuleResults.UseCompatibleStateImageBehavior = False
        Me.olvModuleResults.UseFiltering = True
        Me.olvModuleResults.View = System.Windows.Forms.View.Details
        '
        'olv1
        '
        Me.olv1.AspectName = "Outcome.Name"
        Me.olv1.IsEditable = False
        Me.olv1.Text = "Name"
        '
        'olvModuleResultsPassFail
        '
        Me.olvModuleResultsPassFail.AspectName = "Status"
        Me.olvModuleResultsPassFail.AutoCompleteEditor = False
        Me.olvModuleResultsPassFail.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.olvModuleResultsPassFail.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvModuleResultsPassFail.IsEditable = False
        Me.olvModuleResultsPassFail.MaximumWidth = 17
        Me.olvModuleResultsPassFail.MinimumWidth = 17
        Me.olvModuleResultsPassFail.Text = "P"
        Me.olvModuleResultsPassFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvModuleResultsPassFail.Width = 17
        '
        'imglstFeedback
        '
        Me.imglstFeedback.ImageStream = CType(resources.GetObject("imglstFeedback.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstFeedback.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstFeedback.Images.SetKeyName(0, "erase_16.png")
        Me.imglstFeedback.Images.SetKeyName(1, "checkmark_16.png")
        Me.imglstFeedback.Images.SetKeyName(2, "no.png")
        '
        'btnGenerateImprovementCommentsNoGradeHint
        '
        Me.btnGenerateImprovementCommentsNoGradeHint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateImprovementCommentsNoGradeHint.Location = New System.Drawing.Point(695, 32)
        Me.btnGenerateImprovementCommentsNoGradeHint.Name = "btnGenerateImprovementCommentsNoGradeHint"
        Me.btnGenerateImprovementCommentsNoGradeHint.Palette = Me.KryptonPalette1
        Me.btnGenerateImprovementCommentsNoGradeHint.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnGenerateImprovementCommentsNoGradeHint.Size = New System.Drawing.Size(38, 34)
        Me.btnGenerateImprovementCommentsNoGradeHint.TabIndex = 105
        Me.ToolTip1.SetToolTip(Me.btnGenerateImprovementCommentsNoGradeHint, "Generate improvement comments within a grade hint")
        Me.btnGenerateImprovementCommentsNoGradeHint.Values.Image = Global.Teaching.My.Resources.Resources.notes_32
        Me.btnGenerateImprovementCommentsNoGradeHint.Values.Text = ""
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel13.Location = New System.Drawing.Point(6, 133)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Palette = Me.KryptonPalette1
        Me.KryptonLabel13.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel13.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel13.TabIndex = 104
        Me.KryptonLabel13.Values.Text = "Observation:"
        '
        'rtbObservationComments
        '
        Me.rtbObservationComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbObservationComments.Location = New System.Drawing.Point(90, 129)
        Me.rtbObservationComments.Name = "rtbObservationComments"
        Me.rtbObservationComments.Palette = Me.KryptonPalette1
        Me.rtbObservationComments.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.rtbObservationComments.Size = New System.Drawing.Size(602, 68)
        Me.rtbObservationComments.TabIndex = 103
        Me.rtbObservationComments.Text = ""
        '
        'rtbImprovementComments
        '
        Me.rtbImprovementComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbImprovementComments.Location = New System.Drawing.Point(90, 56)
        Me.rtbImprovementComments.Name = "rtbImprovementComments"
        Me.rtbImprovementComments.Palette = Me.KryptonPalette1
        Me.rtbImprovementComments.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.rtbImprovementComments.Size = New System.Drawing.Size(602, 67)
        Me.rtbImprovementComments.TabIndex = 55
        Me.rtbImprovementComments.Text = ""
        '
        'rtbOverallComments
        '
        Me.rtbOverallComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbOverallComments.Location = New System.Drawing.Point(90, 0)
        Me.rtbOverallComments.Name = "rtbOverallComments"
        Me.rtbOverallComments.Palette = Me.KryptonPalette1
        Me.rtbOverallComments.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.rtbOverallComments.Size = New System.Drawing.Size(602, 50)
        Me.rtbOverallComments.TabIndex = 54
        Me.rtbOverallComments.Text = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 3)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Palette = Me.KryptonPalette1
        Me.KryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel3.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel3.TabIndex = 60
        Me.KryptonLabel3.Values.Text = "Overall:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 60)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Palette = Me.KryptonPalette1
        Me.KryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel4.Size = New System.Drawing.Size(87, 20)
        Me.KryptonLabel4.TabIndex = 61
        Me.KryptonLabel4.Values.Text = "Improvement:"
        '
        'btnGenerateOverallComments
        '
        Me.btnGenerateOverallComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateOverallComments.Location = New System.Drawing.Point(695, 3)
        Me.btnGenerateOverallComments.Name = "btnGenerateOverallComments"
        Me.btnGenerateOverallComments.Palette = Me.KryptonPalette1
        Me.btnGenerateOverallComments.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnGenerateOverallComments.Size = New System.Drawing.Size(38, 34)
        Me.btnGenerateOverallComments.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.btnGenerateOverallComments, "Generate overall comments")
        Me.btnGenerateOverallComments.Values.Image = Global.Teaching.My.Resources.Resources.notes_32
        Me.btnGenerateOverallComments.Values.Text = ""
        '
        'btnGenerateImprovementComments
        '
        Me.btnGenerateImprovementComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateImprovementComments.Location = New System.Drawing.Point(695, 60)
        Me.btnGenerateImprovementComments.Name = "btnGenerateImprovementComments"
        Me.btnGenerateImprovementComments.Palette = Me.KryptonPalette1
        Me.btnGenerateImprovementComments.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnGenerateImprovementComments.Size = New System.Drawing.Size(38, 34)
        Me.btnGenerateImprovementComments.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.btnGenerateImprovementComments, "Generate improvement comments")
        Me.btnGenerateImprovementComments.Values.Image = Global.Teaching.My.Resources.Resources.notes_32
        Me.btnGenerateImprovementComments.Values.Text = ""
        '
        'btnGenerateImprovementCommentsLate
        '
        Me.btnGenerateImprovementCommentsLate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateImprovementCommentsLate.Location = New System.Drawing.Point(695, 91)
        Me.btnGenerateImprovementCommentsLate.Name = "btnGenerateImprovementCommentsLate"
        Me.btnGenerateImprovementCommentsLate.Palette = Me.KryptonPalette1
        Me.btnGenerateImprovementCommentsLate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnGenerateImprovementCommentsLate.Size = New System.Drawing.Size(38, 34)
        Me.btnGenerateImprovementCommentsLate.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.btnGenerateImprovementCommentsLate, "Generate improvement comments (late)")
        Me.btnGenerateImprovementCommentsLate.Values.Image = Global.Teaching.My.Resources.Resources.notes_L_32
        Me.btnGenerateImprovementCommentsLate.Values.Text = ""
        '
        'lblImprovementCharCount
        '
        Me.lblImprovementCharCount.Location = New System.Drawing.Point(6, 77)
        Me.lblImprovementCharCount.Name = "lblImprovementCharCount"
        Me.lblImprovementCharCount.Palette = Me.KryptonPalette1
        Me.lblImprovementCharCount.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblImprovementCharCount.Size = New System.Drawing.Size(68, 20)
        Me.lblImprovementCharCount.TabIndex = 101
        Me.ToolTip1.SetToolTip(Me.lblImprovementCharCount, "Characters")
        Me.lblImprovementCharCount.Values.Text = "Characters"
        '
        'KryptonSplitContainer3
        '
        Me.KryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer3.Name = "KryptonSplitContainer3"
        '
        'KryptonSplitContainer3.Panel1
        '
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.olvAutoFeedback)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.txtFeedbackFilter)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.llblClearFilter)
        '
        'KryptonSplitContainer3.Panel2
        '
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.olvImprovementItems)
        Me.KryptonSplitContainer3.Size = New System.Drawing.Size(428, 433)
        Me.KryptonSplitContainer3.SplitterDistance = 237
        Me.KryptonSplitContainer3.TabIndex = 92
        '
        'olvAutoFeedback
        '
        Me.olvAutoFeedback.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvAutoFeedback.AllColumns.Add(Me.OlvColumn4)
        Me.olvAutoFeedback.AllColumns.Add(Me.olvPassFailFeedback)
        Me.olvAutoFeedback.AllColumns.Add(Me.OlvColumn13)
        Me.olvAutoFeedback.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvAutoFeedback.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvAutoFeedback.CellEditUseWholeCell = False
        Me.olvAutoFeedback.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn4, Me.olvPassFailFeedback, Me.OlvColumn13})
        Me.olvAutoFeedback.CopySelectionOnControlC = False
        Me.olvAutoFeedback.CopySelectionOnControlCUsesDragSource = False
        Me.olvAutoFeedback.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvAutoFeedback.EmptyListMsg = "No stored feedback"
        Me.olvAutoFeedback.FullRowSelect = True
        Me.olvAutoFeedback.Location = New System.Drawing.Point(0, 24)
        Me.olvAutoFeedback.MultiSelect = False
        Me.olvAutoFeedback.Name = "olvAutoFeedback"
        Me.olvAutoFeedback.ShowGroups = False
        Me.olvAutoFeedback.ShowImagesOnSubItems = True
        Me.olvAutoFeedback.ShowItemToolTips = True
        Me.olvAutoFeedback.Size = New System.Drawing.Size(237, 409)
        Me.olvAutoFeedback.SmallImageList = Me.imglstFeedback
        Me.olvAutoFeedback.TabIndex = 90
        Me.olvAutoFeedback.UseCompatibleStateImageBehavior = False
        Me.olvAutoFeedback.UseFiltering = True
        Me.olvAutoFeedback.View = System.Windows.Forms.View.Details
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Text"
        Me.OlvColumn4.AutoCompleteEditor = False
        Me.OlvColumn4.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn4.IsEditable = False
        Me.OlvColumn4.Text = "Feedback"
        Me.OlvColumn4.Width = 299
        '
        'olvPassFailFeedback
        '
        Me.olvPassFailFeedback.AspectName = "Status"
        Me.olvPassFailFeedback.AutoCompleteEditor = False
        Me.olvPassFailFeedback.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.olvPassFailFeedback.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvPassFailFeedback.IsEditable = False
        Me.olvPassFailFeedback.MaximumWidth = 17
        Me.olvPassFailFeedback.MinimumWidth = 17
        Me.olvPassFailFeedback.Text = "P"
        Me.olvPassFailFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvPassFailFeedback.Width = 17
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "ItemCount"
        Me.OlvColumn13.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.Text = "#"
        Me.OlvColumn13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.ToolTipText = "Number of times this feedback has been used"
        '
        'txtFeedbackFilter
        '
        Me.txtFeedbackFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFeedbackFilter.Location = New System.Drawing.Point(62, 2)
        Me.txtFeedbackFilter.Name = "txtFeedbackFilter"
        Me.txtFeedbackFilter.Palette = Me.KryptonPalette1
        Me.txtFeedbackFilter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtFeedbackFilter.Size = New System.Drawing.Size(150, 20)
        Me.txtFeedbackFilter.TabIndex = 92
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 1)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Palette = Me.KryptonPalette1
        Me.KryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel5.Size = New System.Drawing.Size(40, 20)
        Me.KryptonLabel5.TabIndex = 68
        Me.KryptonLabel5.Values.Text = "Filter:"
        '
        'llblClearFilter
        '
        Me.llblClearFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblClearFilter.Location = New System.Drawing.Point(212, 2)
        Me.llblClearFilter.Name = "llblClearFilter"
        Me.llblClearFilter.Size = New System.Drawing.Size(22, 18)
        Me.llblClearFilter.TabIndex = 93
        Me.ToolTip1.SetToolTip(Me.llblClearFilter, "Clear filter")
        Me.llblClearFilter.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblClearFilter.Values.Text = ""
        '
        'olvImprovementItems
        '
        Me.olvImprovementItems.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn1)
        Me.olvImprovementItems.AllColumns.Add(Me.olvcolDateAdded)
        Me.olvImprovementItems.AllColumns.Add(Me.olvcolDateRemoved)
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn5)
        Me.olvImprovementItems.AllColumns.Add(Me.olvcolPerformanceLevel)
        Me.olvImprovementItems.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvImprovementItems.CellEditUseWholeCell = False
        Me.olvImprovementItems.CheckBoxes = True
        Me.olvImprovementItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.olvcolDateAdded, Me.olvcolDateRemoved, Me.OlvColumn5, Me.olvcolPerformanceLevel})
        Me.olvImprovementItems.CopySelectionOnControlC = False
        Me.olvImprovementItems.CopySelectionOnControlCUsesDragSource = False
        Me.olvImprovementItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvImprovementItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvImprovementItems.EmptyListMsg = "No improvement items"
        Me.olvImprovementItems.FullRowSelect = True
        Me.olvImprovementItems.Location = New System.Drawing.Point(0, 0)
        Me.olvImprovementItems.MultiSelect = False
        Me.olvImprovementItems.Name = "olvImprovementItems"
        Me.olvImprovementItems.ShowGroups = False
        Me.olvImprovementItems.ShowImagesOnSubItems = True
        Me.olvImprovementItems.ShowItemToolTips = True
        Me.olvImprovementItems.Size = New System.Drawing.Size(186, 433)
        Me.olvImprovementItems.SmallImageList = Me.imglstFeedback
        Me.olvImprovementItems.TabIndex = 91
        Me.olvImprovementItems.UseCompatibleStateImageBehavior = False
        Me.olvImprovementItems.UseFiltering = True
        Me.olvImprovementItems.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "BaseImprovementItem.Name"
        Me.OlvColumn1.AspectToStringFormat = ""
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Name"
        '
        'olvcolDateAdded
        '
        Me.olvcolDateAdded.AspectName = "DateAdded"
        Me.olvcolDateAdded.AspectToStringFormat = "{0:d}"
        Me.olvcolDateAdded.DisplayIndex = 2
        Me.olvcolDateAdded.Text = "Added"
        Me.olvcolDateAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'olvcolDateRemoved
        '
        Me.olvcolDateRemoved.AspectName = "DateLastIncluded"
        Me.olvcolDateRemoved.AspectToStringFormat = "{0:d}"
        Me.olvcolDateRemoved.DisplayIndex = 3
        Me.olvcolDateRemoved.Text = "Last time"
        Me.olvcolDateRemoved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolDateRemoved.ToolTipText = "Date this was last included in student feedback"
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "BaseImprovementItem.Description"
        Me.OlvColumn5.DisplayIndex = 4
        Me.OlvColumn5.IsEditable = False
        Me.OlvColumn5.Text = "Description"
        '
        'olvcolPerformanceLevel
        '
        Me.olvcolPerformanceLevel.AspectName = "PerformanceLevel"
        Me.olvcolPerformanceLevel.DisplayIndex = 1
        Me.olvcolPerformanceLevel.MaximumWidth = 100
        Me.olvcolPerformanceLevel.MinimumWidth = 50
        Me.olvcolPerformanceLevel.Text = "Perf"
        Me.olvcolPerformanceLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolPerformanceLevel.Width = 50
        '
        'llblOpenSavedMarkingPage
        '
        Me.llblOpenSavedMarkingPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblOpenSavedMarkingPage.Location = New System.Drawing.Point(1073, 3)
        Me.llblOpenSavedMarkingPage.Name = "llblOpenSavedMarkingPage"
        Me.llblOpenSavedMarkingPage.Palette = Me.KryptonPalette1
        Me.llblOpenSavedMarkingPage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblOpenSavedMarkingPage.Size = New System.Drawing.Size(22, 18)
        Me.llblOpenSavedMarkingPage.TabIndex = 124
        Me.ToolTip1.SetToolTip(Me.llblOpenSavedMarkingPage, "Open saved marking page")
        Me.llblOpenSavedMarkingPage.Values.Image = Global.Teaching.My.Resources.Resources.notes_16
        Me.llblOpenSavedMarkingPage.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblOpenSavedMarkingPage.Values.Text = ""
        '
        'llblWarningNotice
        '
        Me.llblWarningNotice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblWarningNotice.Location = New System.Drawing.Point(164, 64)
        Me.llblWarningNotice.Name = "llblWarningNotice"
        Me.llblWarningNotice.Size = New System.Drawing.Size(6, 2)
        Me.llblWarningNotice.TabIndex = 123
        Me.ToolTip1.SetToolTip(Me.llblWarningNotice, "Play / pause")
        Me.llblWarningNotice.Values.Text = ""
        '
        'chkProcessed
        '
        Me.chkProcessed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkProcessed.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkProcessed.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkProcessed.Location = New System.Drawing.Point(953, 35)
        Me.chkProcessed.Name = "chkProcessed"
        Me.chkProcessed.Size = New System.Drawing.Size(91, 19)
        Me.chkProcessed.TabIndex = 48
        Me.chkProcessed.Text = "&Processed:"
        Me.chkProcessed.Values.Text = "&Processed:"
        '
        'btnPrintMarkingSheet
        '
        Me.btnPrintMarkingSheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintMarkingSheet.Location = New System.Drawing.Point(1127, 26)
        Me.btnPrintMarkingSheet.Name = "btnPrintMarkingSheet"
        Me.btnPrintMarkingSheet.Palette = Me.KryptonPalette1
        Me.btnPrintMarkingSheet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnPrintMarkingSheet.Size = New System.Drawing.Size(38, 34)
        Me.btnPrintMarkingSheet.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.btnPrintMarkingSheet, "Print marking sheet")
        Me.btnPrintMarkingSheet.Values.Image = Global.Teaching.My.Resources.Resources.print_32
        Me.btnPrintMarkingSheet.Values.Text = ""
        '
        'llblSaveFeedbackSheet
        '
        Me.llblSaveFeedbackSheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblSaveFeedbackSheet.Location = New System.Drawing.Point(1067, 26)
        Me.llblSaveFeedbackSheet.Name = "llblSaveFeedbackSheet"
        Me.llblSaveFeedbackSheet.Palette = Me.KryptonPalette1
        Me.llblSaveFeedbackSheet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblSaveFeedbackSheet.Size = New System.Drawing.Size(38, 34)
        Me.llblSaveFeedbackSheet.TabIndex = 122
        Me.ToolTip1.SetToolTip(Me.llblSaveFeedbackSheet, "Save marking sheet")
        Me.llblSaveFeedbackSheet.Values.Image = Global.Teaching.My.Resources.Resources.save_32
        Me.llblSaveFeedbackSheet.Values.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(464, 26)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Palette = Me.KryptonPalette1
        Me.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 62
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'llblExistingAssignment
        '
        Me.llblExistingAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblExistingAssignment.Location = New System.Drawing.Point(396, 26)
        Me.llblExistingAssignment.Name = "llblExistingAssignment"
        Me.llblExistingAssignment.Palette = Me.KryptonPalette1
        Me.llblExistingAssignment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblExistingAssignment.Size = New System.Drawing.Size(38, 34)
        Me.llblExistingAssignment.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.llblExistingAssignment, "Open saved assignment")
        Me.llblExistingAssignment.Values.Image = Global.Teaching.My.Resources.Resources.favorite_add_32
        Me.llblExistingAssignment.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblExistingAssignment.Values.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(591, 26)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Palette = Me.KryptonPalette1
        Me.btnOK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 63
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'llblDeleteAssignment
        '
        Me.llblDeleteAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblDeleteAssignment.Location = New System.Drawing.Point(1, 28)
        Me.llblDeleteAssignment.Name = "llblDeleteAssignment"
        Me.llblDeleteAssignment.Palette = Me.KryptonPalette1
        Me.llblDeleteAssignment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblDeleteAssignment.Size = New System.Drawing.Size(38, 34)
        Me.llblDeleteAssignment.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.llblDeleteAssignment, "Delete this student's assignment")
        Me.llblDeleteAssignment.Values.Image = Global.Teaching.My.Resources.Resources.erase_32
        Me.llblDeleteAssignment.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblDeleteAssignment.Values.Text = ""
        '
        'llblCopyAssignmentFromCD
        '
        Me.llblCopyAssignmentFromCD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblCopyAssignmentFromCD.Location = New System.Drawing.Point(313, 20)
        Me.llblCopyAssignmentFromCD.Name = "llblCopyAssignmentFromCD"
        Me.llblCopyAssignmentFromCD.Palette = Me.KryptonPalette1
        Me.llblCopyAssignmentFromCD.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblCopyAssignmentFromCD.Size = New System.Drawing.Size(38, 34)
        Me.llblCopyAssignmentFromCD.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.llblCopyAssignmentFromCD, "Copy assignment from CD")
        Me.llblCopyAssignmentFromCD.Values.Image = Global.Teaching.My.Resources.Resources.download_32
        Me.llblCopyAssignmentFromCD.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblCopyAssignmentFromCD.Values.Text = ""
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel9.Location = New System.Drawing.Point(96, 14)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Palette = Me.KryptonPalette1
        Me.KryptonLabel9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel9.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel9.TabIndex = 97
        Me.KryptonLabel9.Values.Text = "Timer:"
        '
        'llblEjectCD
        '
        Me.llblEjectCD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblEjectCD.Location = New System.Drawing.Point(352, 17)
        Me.llblEjectCD.Name = "llblEjectCD"
        Me.llblEjectCD.Palette = Me.KryptonPalette1
        Me.llblEjectCD.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblEjectCD.Size = New System.Drawing.Size(38, 34)
        Me.llblEjectCD.TabIndex = 88
        Me.ToolTip1.SetToolTip(Me.llblEjectCD, "Eject CD")
        Me.llblEjectCD.Values.Image = Global.Teaching.My.Resources.Resources.eject_32
        Me.llblEjectCD.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblEjectCD.Values.Text = ""
        '
        'txtTimer
        '
        Me.txtTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTimer.Location = New System.Drawing.Point(146, 12)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Palette = Me.KryptonPalette1
        Me.txtTimer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(71, 20)
        Me.txtTimer.StateNormal.Content.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimer.TabIndex = 95
        Me.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'llblToggleTimer
        '
        Me.llblToggleTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblToggleTimer.Location = New System.Drawing.Point(216, 4)
        Me.llblToggleTimer.Name = "llblToggleTimer"
        Me.llblToggleTimer.Size = New System.Drawing.Size(38, 34)
        Me.llblToggleTimer.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.llblToggleTimer, "Play / pause")
        Me.llblToggleTimer.Values.Image = Global.Teaching.My.Resources.Resources.Pause_32
        Me.llblToggleTimer.Values.Text = ""
        '
        'llblResetTimer
        '
        Me.llblResetTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblResetTimer.Location = New System.Drawing.Point(260, 4)
        Me.llblResetTimer.Name = "llblResetTimer"
        Me.llblResetTimer.Size = New System.Drawing.Size(38, 34)
        Me.llblResetTimer.TabIndex = 98
        Me.ToolTip1.SetToolTip(Me.llblResetTimer, "Reset timer")
        Me.llblResetTimer.Values.Image = Global.Teaching.My.Resources.Resources.backup_32
        Me.llblResetTimer.Values.Text = ""
        '
        'llblStudentPic
        '
        Me.llblStudentPic.Location = New System.Drawing.Point(420, 54)
        Me.llblStudentPic.Name = "llblStudentPic"
        Me.llblStudentPic.Size = New System.Drawing.Size(38, 34)
        Me.llblStudentPic.TabIndex = 119
        Me.ToolTip1.SetToolTip(Me.llblStudentPic, "Fail all")
        Me.llblStudentPic.Values.Image = Global.Teaching.My.Resources.Resources.detective_32
        Me.llblStudentPic.Values.Text = ""
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(164, 26)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Palette = Me.KryptonPalette1
        Me.KryptonLabel12.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel12.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel12.TabIndex = 114
        Me.KryptonLabel12.Values.Text = "Writing:"
        '
        'nudPlagiarismSeverity
        '
        Me.nudPlagiarismSeverity.Location = New System.Drawing.Point(435, 24)
        Me.nudPlagiarismSeverity.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudPlagiarismSeverity.Name = "nudPlagiarismSeverity"
        Me.nudPlagiarismSeverity.Palette = Me.KryptonPalette1
        Me.nudPlagiarismSeverity.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.nudPlagiarismSeverity.Size = New System.Drawing.Size(44, 22)
        Me.nudPlagiarismSeverity.TabIndex = 112
        Me.nudPlagiarismSeverity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPlagiarismSeverity.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudPlagiarismSeverity, "0=not concerned, 5=watch 5 next asmts for plagiarism")
        Me.nudPlagiarismSeverity.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(397, 25)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Palette = Me.KryptonPalette1
        Me.KryptonLabel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel10.Size = New System.Drawing.Size(37, 20)
        Me.KryptonLabel10.TabIndex = 113
        Me.KryptonLabel10.Values.Text = "Plag:"
        '
        'txtSchoolClass
        '
        Me.txtSchoolClass.Location = New System.Drawing.Point(544, 3)
        Me.txtSchoolClass.Name = "txtSchoolClass"
        Me.txtSchoolClass.Palette = Me.KryptonPalette1
        Me.txtSchoolClass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtSchoolClass.ReadOnly = True
        Me.txtSchoolClass.Size = New System.Drawing.Size(84, 20)
        Me.txtSchoolClass.TabIndex = 111
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(497, 3)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Palette = Me.KryptonPalette1
        Me.KryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel11.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel11.TabIndex = 110
        Me.KryptonLabel11.Values.Text = "Class:"
        '
        'llblRefreshOutcomeCount
        '
        Me.llblRefreshOutcomeCount.Location = New System.Drawing.Point(389, 54)
        Me.llblRefreshOutcomeCount.Name = "llblRefreshOutcomeCount"
        Me.llblRefreshOutcomeCount.Size = New System.Drawing.Size(22, 18)
        Me.llblRefreshOutcomeCount.TabIndex = 102
        Me.ToolTip1.SetToolTip(Me.llblRefreshOutcomeCount, "Pass all")
        Me.llblRefreshOutcomeCount.Values.Image = Global.Teaching.My.Resources.Resources.refresh_16
        Me.llblRefreshOutcomeCount.Values.Text = ""
        '
        'nudAltNumber
        '
        Me.nudAltNumber.Location = New System.Drawing.Point(521, 24)
        Me.nudAltNumber.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudAltNumber.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nudAltNumber.Name = "nudAltNumber"
        Me.nudAltNumber.Size = New System.Drawing.Size(68, 21)
        Me.nudAltNumber.TabIndex = 100
        Me.nudAltNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAltNumber.ThousandsSeparator = True
        Me.nudAltNumber.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudPresentationQuality
        '
        Me.nudPresentationQuality.Location = New System.Drawing.Point(90, 25)
        Me.nudPresentationQuality.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPresentationQuality.Name = "nudPresentationQuality"
        Me.nudPresentationQuality.Size = New System.Drawing.Size(68, 21)
        Me.nudPresentationQuality.TabIndex = 99
        Me.nudPresentationQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPresentationQuality.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudPresentationQuality, "Presentation quality of student")
        Me.nudPresentationQuality.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblOutcomesPassed
        '
        Me.lblOutcomesPassed.Location = New System.Drawing.Point(318, 52)
        Me.lblOutcomesPassed.Name = "lblOutcomesPassed"
        Me.lblOutcomesPassed.Palette = Me.KryptonPalette1
        Me.lblOutcomesPassed.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblOutcomesPassed.Size = New System.Drawing.Size(17, 20)
        Me.lblOutcomesPassed.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.lblOutcomesPassed, "Total outcomes passed")
        Me.lblOutcomesPassed.Values.Text = "0"
        '
        'llblEditStudent
        '
        Me.llblEditStudent.Location = New System.Drawing.Point(234, 3)
        Me.llblEditStudent.Name = "llblEditStudent"
        Me.llblEditStudent.Size = New System.Drawing.Size(22, 18)
        Me.llblEditStudent.TabIndex = 89
        Me.ToolTip1.SetToolTip(Me.llblEditStudent, "Edit student")
        Me.llblEditStudent.Values.Image = Global.Teaching.My.Resources.Resources.AutoText_16
        Me.llblEditStudent.Values.Text = ""
        '
        'llblAlreadyD3
        '
        Me.llblAlreadyD3.Location = New System.Drawing.Point(279, 54)
        Me.llblAlreadyD3.Name = "llblAlreadyD3"
        Me.llblAlreadyD3.Size = New System.Drawing.Size(22, 18)
        Me.llblAlreadyD3.TabIndex = 87
        Me.ToolTip1.SetToolTip(Me.llblAlreadyD3, "Already has it!")
        Me.llblAlreadyD3.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAlreadyD3.Values.Text = ""
        Me.llblAlreadyD3.Visible = False
        '
        'llblAlreadyD2
        '
        Me.llblAlreadyD2.Location = New System.Drawing.Point(229, 54)
        Me.llblAlreadyD2.Name = "llblAlreadyD2"
        Me.llblAlreadyD2.Size = New System.Drawing.Size(22, 18)
        Me.llblAlreadyD2.TabIndex = 86
        Me.ToolTip1.SetToolTip(Me.llblAlreadyD2, "Already has it!")
        Me.llblAlreadyD2.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAlreadyD2.Values.Text = ""
        Me.llblAlreadyD2.Visible = False
        '
        'llblAlreadyD1
        '
        Me.llblAlreadyD1.Location = New System.Drawing.Point(183, 54)
        Me.llblAlreadyD1.Name = "llblAlreadyD1"
        Me.llblAlreadyD1.Size = New System.Drawing.Size(22, 18)
        Me.llblAlreadyD1.TabIndex = 85
        Me.ToolTip1.SetToolTip(Me.llblAlreadyD1, "Already has it!")
        Me.llblAlreadyD1.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAlreadyD1.Values.Text = ""
        Me.llblAlreadyD1.Visible = False
        '
        'llblAlreadyM3
        '
        Me.llblAlreadyM3.Location = New System.Drawing.Point(119, 54)
        Me.llblAlreadyM3.Name = "llblAlreadyM3"
        Me.llblAlreadyM3.Size = New System.Drawing.Size(22, 18)
        Me.llblAlreadyM3.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.llblAlreadyM3, "Already has it!")
        Me.llblAlreadyM3.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAlreadyM3.Values.Text = ""
        Me.llblAlreadyM3.Visible = False
        '
        'llblAlreadyM2
        '
        Me.llblAlreadyM2.Location = New System.Drawing.Point(73, 54)
        Me.llblAlreadyM2.Name = "llblAlreadyM2"
        Me.llblAlreadyM2.Size = New System.Drawing.Size(22, 18)
        Me.llblAlreadyM2.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.llblAlreadyM2, "Already has it!")
        Me.llblAlreadyM2.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAlreadyM2.Values.Text = ""
        Me.llblAlreadyM2.Visible = False
        '
        'llblAlreadyM1
        '
        Me.llblAlreadyM1.Location = New System.Drawing.Point(24, 54)
        Me.llblAlreadyM1.Name = "llblAlreadyM1"
        Me.llblAlreadyM1.Size = New System.Drawing.Size(22, 18)
        Me.llblAlreadyM1.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.llblAlreadyM1, "Already has it!")
        Me.llblAlreadyM1.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAlreadyM1.Values.Text = ""
        Me.llblAlreadyM1.Visible = False
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(476, 26)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Palette = Me.KryptonPalette1
        Me.KryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel8.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel8.TabIndex = 78
        Me.KryptonLabel8.Values.Text = "Alt #:"
        '
        'llblFailAll
        '
        Me.llblFailAll.Location = New System.Drawing.Point(357, 72)
        Me.llblFailAll.Name = "llblFailAll"
        Me.llblFailAll.Size = New System.Drawing.Size(22, 18)
        Me.llblFailAll.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.llblFailAll, "Fail all")
        Me.llblFailAll.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.llblFailAll.Values.Text = ""
        '
        'llblPassAll
        '
        Me.llblPassAll.Location = New System.Drawing.Point(329, 72)
        Me.llblPassAll.Name = "llblPassAll"
        Me.llblPassAll.Size = New System.Drawing.Size(22, 18)
        Me.llblPassAll.TabIndex = 75
        Me.ToolTip1.SetToolTip(Me.llblPassAll, "Pass all")
        Me.llblPassAll.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblPassAll.Values.Text = ""
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 26)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Palette = Me.KryptonPalette1
        Me.KryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel7.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel7.TabIndex = 74
        Me.KryptonLabel7.Values.Text = "Presentation:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(591, 26)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel2.TabIndex = 71
        Me.KryptonLabel2.Values.Text = "Tags:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(646, 3)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Palette = Me.KryptonPalette1
        Me.KryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel6.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel6.TabIndex = 71
        Me.KryptonLabel6.Values.Text = "Assignment:"
        '
        'txtAssignmentName
        '
        Me.txtAssignmentName.Location = New System.Drawing.Point(729, 3)
        Me.txtAssignmentName.Name = "txtAssignmentName"
        Me.txtAssignmentName.Palette = Me.KryptonPalette1
        Me.txtAssignmentName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAssignmentName.ReadOnly = True
        Me.txtAssignmentName.Size = New System.Drawing.Size(147, 20)
        Me.txtAssignmentName.TabIndex = 70
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(344, 3)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Palette = Me.KryptonPalette1
        Me.txtStudentID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(147, 20)
        Me.txtStudentID.TabIndex = 58
        '
        'txtNickName
        '
        Me.txtNickName.Location = New System.Drawing.Point(90, 3)
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.Palette = Me.KryptonPalette1
        Me.txtNickName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtNickName.ReadOnly = True
        Me.txtNickName.Size = New System.Drawing.Size(138, 20)
        Me.txtNickName.TabIndex = 57
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Palette = Me.KryptonPalette1
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel1.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel1.TabIndex = 56
        Me.KryptonLabel1.Values.Text = "NickName:"
        '
        'chkD3
        '
        Me.chkD3.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkD3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkD3.Location = New System.Drawing.Point(270, 69)
        Me.chkD3.Name = "chkD3"
        Me.chkD3.Palette = Me.KryptonPalette1
        Me.chkD3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkD3.Size = New System.Drawing.Size(42, 20)
        Me.chkD3.TabIndex = 53
        Me.chkD3.Text = "D3:"
        Me.chkD3.Values.Text = "D3:"
        Me.chkD3.Visible = False
        '
        'chkD2
        '
        Me.chkD2.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkD2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkD2.Location = New System.Drawing.Point(217, 69)
        Me.chkD2.Name = "chkD2"
        Me.chkD2.Palette = Me.KryptonPalette1
        Me.chkD2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkD2.Size = New System.Drawing.Size(42, 20)
        Me.chkD2.TabIndex = 52
        Me.chkD2.Text = "D2:"
        Me.chkD2.Values.Text = "D2:"
        Me.chkD2.Visible = False
        '
        'chkD1
        '
        Me.chkD1.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkD1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkD1.Location = New System.Drawing.Point(169, 69)
        Me.chkD1.Name = "chkD1"
        Me.chkD1.Palette = Me.KryptonPalette1
        Me.chkD1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkD1.Size = New System.Drawing.Size(42, 20)
        Me.chkD1.TabIndex = 51
        Me.chkD1.Text = "D1:"
        Me.chkD1.Values.Text = "D1:"
        Me.chkD1.Visible = False
        '
        'chkM3
        '
        Me.chkM3.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkM3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkM3.Location = New System.Drawing.Point(106, 69)
        Me.chkM3.Name = "chkM3"
        Me.chkM3.Palette = Me.KryptonPalette1
        Me.chkM3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkM3.Size = New System.Drawing.Size(44, 20)
        Me.chkM3.TabIndex = 50
        Me.chkM3.Text = "M3:"
        Me.chkM3.Values.Text = "M3:"
        Me.chkM3.Visible = False
        '
        'chkM2
        '
        Me.chkM2.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkM2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkM2.Location = New System.Drawing.Point(56, 69)
        Me.chkM2.Name = "chkM2"
        Me.chkM2.Palette = Me.KryptonPalette1
        Me.chkM2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkM2.Size = New System.Drawing.Size(44, 20)
        Me.chkM2.TabIndex = 49
        Me.chkM2.Text = "M2:"
        Me.chkM2.Values.Text = "M2:"
        Me.chkM2.Visible = False
        '
        'chkM1
        '
        Me.chkM1.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkM1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkM1.Location = New System.Drawing.Point(6, 69)
        Me.chkM1.Name = "chkM1"
        Me.chkM1.Palette = Me.KryptonPalette1
        Me.chkM1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkM1.Size = New System.Drawing.Size(44, 20)
        Me.chkM1.TabIndex = 48
        Me.chkM1.Text = "M1:"
        Me.chkM1.Values.Text = "M1:"
        Me.chkM1.Visible = False
        '
        'llblOpenStudent
        '
        Me.llblOpenStudent.Location = New System.Drawing.Point(273, 3)
        Me.llblOpenStudent.Name = "llblOpenStudent"
        Me.llblOpenStudent.Palette = Me.KryptonPalette1
        Me.llblOpenStudent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.llblOpenStudent.Size = New System.Drawing.Size(71, 20)
        Me.llblOpenStudent.TabIndex = 120
        Me.ToolTip1.SetToolTip(Me.llblOpenStudent, "Open student")
        Me.llblOpenStudent.Values.Text = "Student ID:"
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
        'tmrFilterFeedback
        '
        Me.tmrFilterFeedback.Interval = 200
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 200
        '
        'SpellCheckToolStripMenuItem
        '
        Me.SpellCheckToolStripMenuItem.Name = "SpellCheckToolStripMenuItem"
        Me.SpellCheckToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'ctxmnuExistingAssignment
        '
        Me.ctxmnuExistingAssignment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuExistingAssignment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenAssignmentToolStripMenuItem, Me.CopyLocalFilenameToClipboardToolStripMenuItem, Me.ShowLocalFileInExplorerToolStripMenuItem})
        Me.ctxmnuExistingAssignment.Name = "ctxmnuExistingAssignment"
        Me.ctxmnuExistingAssignment.Size = New System.Drawing.Size(247, 70)
        '
        'OpenAssignmentToolStripMenuItem
        '
        Me.OpenAssignmentToolStripMenuItem.Name = "OpenAssignmentToolStripMenuItem"
        Me.OpenAssignmentToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.OpenAssignmentToolStripMenuItem.Text = "&Open assignment"
        '
        'CopyLocalFilenameToClipboardToolStripMenuItem
        '
        Me.CopyLocalFilenameToClipboardToolStripMenuItem.Name = "CopyLocalFilenameToClipboardToolStripMenuItem"
        Me.CopyLocalFilenameToClipboardToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.CopyLocalFilenameToClipboardToolStripMenuItem.Text = "&Copy local filename to clipboard"
        '
        'ShowLocalFileInExplorerToolStripMenuItem
        '
        Me.ShowLocalFileInExplorerToolStripMenuItem.Name = "ShowLocalFileInExplorerToolStripMenuItem"
        Me.ShowLocalFileInExplorerToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ShowLocalFileInExplorerToolStripMenuItem.Text = "&Show local file in Explorer"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1169, 24)
        Me.MenuStrip1.TabIndex = 124
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyAllOutcomeFeedbackToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CopyAllOutcomeFeedbackToolStripMenuItem
        '
        Me.CopyAllOutcomeFeedbackToolStripMenuItem.Name = "CopyAllOutcomeFeedbackToolStripMenuItem"
        Me.CopyAllOutcomeFeedbackToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyAllOutcomeFeedbackToolStripMenuItem.Size = New System.Drawing.Size(293, 22)
        Me.CopyAllOutcomeFeedbackToolStripMenuItem.Text = "Copy all outcome feedback"
        Me.CopyAllOutcomeFeedbackToolStripMenuItem.ToolTipText = "Combine all outcome feedback and copy to clipboard"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplySelectedFeedbackToAllToolStripMenuItem, Me.ClearFeedbackFilterToolStripMenuItem, Me.MoveFeedbackFrom1stTo2ndToolStripMenuItem, Me.MoveFeedbackFrom2ndTo3rdToolStripMenuItem, Me.MarkStudentDidNotSubmitToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ActionsToolStripMenuItem.Text = "&Actions"
        '
        'ApplySelectedFeedbackToAllToolStripMenuItem
        '
        Me.ApplySelectedFeedbackToAllToolStripMenuItem.Name = "ApplySelectedFeedbackToAllToolStripMenuItem"
        Me.ApplySelectedFeedbackToAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ApplySelectedFeedbackToAllToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ApplySelectedFeedbackToAllToolStripMenuItem.Text = "Apply selected fee&dback to all"
        '
        'ClearFeedbackFilterToolStripMenuItem
        '
        Me.ClearFeedbackFilterToolStripMenuItem.Name = "ClearFeedbackFilterToolStripMenuItem"
        Me.ClearFeedbackFilterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ClearFeedbackFilterToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ClearFeedbackFilterToolStripMenuItem.Text = "&Clear feedback filter"
        '
        'MoveFeedbackFrom1stTo2ndToolStripMenuItem
        '
        Me.MoveFeedbackFrom1stTo2ndToolStripMenuItem.Name = "MoveFeedbackFrom1stTo2ndToolStripMenuItem"
        Me.MoveFeedbackFrom1stTo2ndToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.MoveFeedbackFrom1stTo2ndToolStripMenuItem.Text = "Move feedback from 1st to 2nd"
        '
        'MoveFeedbackFrom2ndTo3rdToolStripMenuItem
        '
        Me.MoveFeedbackFrom2ndTo3rdToolStripMenuItem.Name = "MoveFeedbackFrom2ndTo3rdToolStripMenuItem"
        Me.MoveFeedbackFrom2ndTo3rdToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.MoveFeedbackFrom2ndTo3rdToolStripMenuItem.Text = "Move feedback from 2nd to 3rd"
        '
        'MarkStudentDidNotSubmitToolStripMenuItem
        '
        Me.MarkStudentDidNotSubmitToolStripMenuItem.Name = "MarkStudentDidNotSubmitToolStripMenuItem"
        Me.MarkStudentDidNotSubmitToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.MarkStudentDidNotSubmitToolStripMenuItem.Text = "Mark student ""Did not submit"""
        '
        'StudentAssignmentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 620)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentAssignmentDetails"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Student Assignment Details"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer4.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer4.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer4.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer4.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer4.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer4.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer4.ResumeLayout(False)
        CType(Me.olvOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvModuleResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.ResumeLayout(False)
        CType(Me.olvAutoFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SpellChecker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmnuExistingAssignment.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tmrFilterFeedback As System.Windows.Forms.Timer
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents SpellCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1SpellChecker1 As C1.Win.C1SpellChecker.C1SpellChecker
    Friend WithEvents ctxmnuExistingAssignment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyLocalFilenameToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLocalFileInExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imglstFeedback As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplySelectedFeedbackToAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearFeedbackFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveFeedbackFrom1stTo2ndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveFeedbackFrom2ndTo3rdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents olvOutcomes As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumnOutcomeName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvModuleResults As BrightIdeasSoftware.ObjectListView
    Friend WithEvents olv1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvModuleResultsPassFail As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvAutoFeedback As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvPassFailFeedback As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvImprovementItems As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolDateAdded As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolDateRemoved As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents MarkStudentDidNotSubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Private WithEvents chkD3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkD2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkD1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkM3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkM2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkM1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents txtStudentID As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtNickName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtAssignmentName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblFailAll As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblPassAll As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblAlreadyD3 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAlreadyD2 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAlreadyD1 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAlreadyM3 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAlreadyM2 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAlreadyM1 As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblEditStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents lblOutcomesPassed As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents nudAltNumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents nudPresentationQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents llblRefreshOutcomeCount As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents txtSchoolClass As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents nudPlagiarismSeverity As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents nudWritingQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblStudentPic As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblOpenStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblRemoveImprovementItem As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAddImprovementItem As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblClearImprovementItem As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents KryptonSplitContainer4 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents llblModuleResults As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents rtbImprovementComments As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Private WithEvents rtbOverallComments As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents btnGenerateOverallComments As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents btnGenerateImprovementComments As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents btnGenerateImprovementCommentsLate As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents lblImprovementCharCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonSplitContainer3 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents txtFeedbackFilter As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblClearFilter As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblWarningNotice As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents chkProcessed As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents btnPrintMarkingSheet As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblSaveFeedbackSheet As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents llblExistingAssignment As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents llblDeleteAssignment As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblCopyAssignmentFromCD As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblEjectCD As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents txtTimer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents llblToggleTimer As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblResetTimer As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblOpenSavedMarkingPage As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyAllOutcomeFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents txtTags As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Private WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents rtbObservationComments As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Private WithEvents nudResearchQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents olvcolPerformanceLevel As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Private WithEvents btnGenerateImprovementCommentsNoGradeHint As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
End Class
