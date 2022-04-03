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
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtLastUserFullName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtFirstUserFullName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtGroup = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudResearchQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudWritingQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.txtTags = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearImprovementItem = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
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
        Me.llblAutoGenOverallFirst = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.spltOveralFirstReworkText = New System.Windows.Forms.SplitContainer()
        Me.rtbImprovementComments = New System.Windows.Forms.RichTextBox()
        Me.rtbOverallComments = New System.Windows.Forms.RichTextBox()
        Me.llblFirstAttemptText = New System.Windows.Forms.LinkLabel()
        Me.rtbImprovementCommentsRework = New System.Windows.Forms.RichTextBox()
        Me.rtbOverallCommentsRework = New System.Windows.Forms.RichTextBox()
        Me.llblReworkText = New System.Windows.Forms.LinkLabel()
        Me.rtbObservationComments = New System.Windows.Forms.RichTextBox()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnGenerateOverallComments = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnGenerateImprovementComments = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lblImprovementCharCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblAutoGenImprovementsRework = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAutoGenImprovementsFirst = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAutoGenOverallRework = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
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
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
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
        Me.txtTeam = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtSchoolClass = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudAltNumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudPresentationQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.llblEditStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAchieveAllMerit = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAchieveAllPass = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblFailAll = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAchieveAllDistinction = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAssignmentName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtStudentID = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNickName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkShowFeedback = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowImprovement = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.llblOpenStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrFilterFeedback = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SpellCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.FocusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FocusOntagsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FocusOnoverallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FocusOnfeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FocusOnoutcomesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
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
        CType(Me.spltOveralFirstReworkText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltOveralFirstReworkText.Panel1.SuspendLayout()
        Me.spltOveralFirstReworkText.Panel2.SuspendLayout()
        Me.spltOveralFirstReworkText.SuspendLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel2.SuspendLayout()
        Me.KryptonSplitContainer3.SuspendLayout()
        CType(Me.olvAutoFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmnuExistingAssignment.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel18)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel16)
        Me.KryptonPanel.Controls.Add(Me.txtLastUserFullName)
        Me.KryptonPanel.Controls.Add(Me.txtFirstUserFullName)
        Me.KryptonPanel.Controls.Add(Me.txtGroup)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel17)
        Me.KryptonPanel.Controls.Add(Me.nudResearchQuality)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonPanel.Controls.Add(Me.nudWritingQuality)
        Me.KryptonPanel.Controls.Add(Me.txtTags)
        Me.KryptonPanel.Controls.Add(Me.llblClearImprovementItem)
        Me.KryptonPanel.Controls.Add(Me.llblAddImprovementItem)
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonPanel.Controls.Add(Me.llblStudentPic)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel.Controls.Add(Me.nudPlagiarismSeverity)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.txtTeam)
        Me.KryptonPanel.Controls.Add(Me.txtSchoolClass)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel.Controls.Add(Me.nudAltNumber)
        Me.KryptonPanel.Controls.Add(Me.nudPresentationQuality)
        Me.KryptonPanel.Controls.Add(Me.llblEditStudent)
        Me.KryptonPanel.Controls.Add(Me.llblAchieveAllMerit)
        Me.KryptonPanel.Controls.Add(Me.llblAchieveAllPass)
        Me.KryptonPanel.Controls.Add(Me.llblFailAll)
        Me.KryptonPanel.Controls.Add(Me.llblAchieveAllDistinction)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.txtAssignmentName)
        Me.KryptonPanel.Controls.Add(Me.txtStudentID)
        Me.KryptonPanel.Controls.Add(Me.txtNickName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.chkShowFeedback)
        Me.KryptonPanel.Controls.Add(Me.chkShowImprovement)
        Me.KryptonPanel.Controls.Add(Me.llblOpenStudent)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel15)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1169, 596)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(348, 49)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel18.TabIndex = 133
        Me.KryptonLabel18.Values.Text = "Last editor:"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(3, 49)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel16.TabIndex = 133
        Me.KryptonLabel16.Values.Text = "First editor:"
        '
        'txtLastUserFullName
        '
        Me.txtLastUserFullName.Location = New System.Drawing.Point(435, 49)
        Me.txtLastUserFullName.Name = "txtLastUserFullName"
        Me.txtLastUserFullName.ReadOnly = True
        Me.txtLastUserFullName.Size = New System.Drawing.Size(147, 23)
        Me.txtLastUserFullName.TabIndex = 132
        '
        'txtFirstUserFullName
        '
        Me.txtFirstUserFullName.Location = New System.Drawing.Point(90, 49)
        Me.txtFirstUserFullName.Name = "txtFirstUserFullName"
        Me.txtFirstUserFullName.ReadOnly = True
        Me.txtFirstUserFullName.Size = New System.Drawing.Size(147, 23)
        Me.txtFirstUserFullName.TabIndex = 132
        '
        'txtGroup
        '
        Me.txtGroup.Location = New System.Drawing.Point(662, 24)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.ReadOnly = True
        Me.txtGroup.Size = New System.Drawing.Size(60, 23)
        Me.txtGroup.TabIndex = 131
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(609, 24)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(47, 20)
        Me.KryptonLabel17.TabIndex = 130
        Me.KryptonLabel17.Values.Text = "Group:"
        '
        'nudResearchQuality
        '
        Me.nudResearchQuality.Location = New System.Drawing.Point(344, 25)
        Me.nudResearchQuality.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudResearchQuality.Name = "nudResearchQuality"
        Me.nudResearchQuality.Size = New System.Drawing.Size(55, 22)
        Me.nudResearchQuality.TabIndex = 129
        Me.nudResearchQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudResearchQuality.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudResearchQuality, "Writing quality of student")
        Me.nudResearchQuality.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(293, 26)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(49, 20)
        Me.KryptonLabel14.TabIndex = 128
        Me.KryptonLabel14.Values.Text = "Resrch:"
        '
        'nudWritingQuality
        '
        Me.nudWritingQuality.Location = New System.Drawing.Point(219, 25)
        Me.nudWritingQuality.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudWritingQuality.Name = "nudWritingQuality"
        Me.nudWritingQuality.Size = New System.Drawing.Size(68, 22)
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
        Me.txtTags.Location = New System.Drawing.Point(922, 26)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(243, 23)
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
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.llblAutoGenOverallFirst)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.spltOveralFirstReworkText)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.rtbObservationComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.KryptonLabel13)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.KryptonLabel4)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.btnGenerateOverallComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.btnGenerateImprovementComments)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.lblImprovementCharCount)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.llblAutoGenImprovementsRework)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.llblAutoGenImprovementsFirst)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.llblAutoGenOverallRework)
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
        Me.olvOutcomes.EmptyListMsg = "No learning outcomes for this assessment"
        Me.olvOutcomes.FullRowSelect = True
        Me.olvOutcomes.HideSelection = False
        Me.olvOutcomes.Location = New System.Drawing.Point(2, 0)
        Me.olvOutcomes.Name = "olvOutcomes"
        Me.olvOutcomes.ShowGroups = False
        Me.olvOutcomes.Size = New System.Drawing.Size(616, 221)
        Me.olvOutcomes.TabIndex = 42
        Me.olvOutcomes.TriggerCellOverEventsWhenOverHeader = False
        Me.olvOutcomes.UseCompatibleStateImageBehavior = False
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
        Me.OlvColumn8.AutoCompleteEditor = False
        Me.OlvColumn8.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
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
        Me.OlvColumn10.AutoCompleteEditor = False
        Me.OlvColumn10.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
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
        Me.OlvColumn12.AutoCompleteEditor = False
        Me.OlvColumn12.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
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
        Me.llblModuleResults.Location = New System.Drawing.Point(638, 4)
        Me.llblModuleResults.Name = "llblModuleResults"
        Me.llblModuleResults.Size = New System.Drawing.Size(91, 20)
        Me.llblModuleResults.TabIndex = 124
        Me.ToolTip1.SetToolTip(Me.llblModuleResults, "Click to refresh module results")
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
        Me.olvModuleResults.Location = New System.Drawing.Point(624, 25)
        Me.olvModuleResults.Name = "olvModuleResults"
        Me.olvModuleResults.ShowGroups = False
        Me.olvModuleResults.ShowImagesOnSubItems = True
        Me.olvModuleResults.Size = New System.Drawing.Size(111, 197)
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
        'llblAutoGenOverallFirst
        '
        Me.llblAutoGenOverallFirst.Location = New System.Drawing.Point(6, 29)
        Me.llblAutoGenOverallFirst.Name = "llblAutoGenOverallFirst"
        Me.llblAutoGenOverallFirst.Size = New System.Drawing.Size(52, 20)
        Me.llblAutoGenOverallFirst.TabIndex = 147
        Me.ToolTip1.SetToolTip(Me.llblAutoGenOverallFirst, "Automatically generate improvement comments based on checked improvement items (w" &
        "ith performance level)")
        Me.llblAutoGenOverallFirst.Values.Text = "Gen 1st"
        '
        'spltOveralFirstReworkText
        '
        Me.spltOveralFirstReworkText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spltOveralFirstReworkText.Location = New System.Drawing.Point(93, 3)
        Me.spltOveralFirstReworkText.Name = "spltOveralFirstReworkText"
        '
        'spltOveralFirstReworkText.Panel1
        '
        Me.spltOveralFirstReworkText.Panel1.Controls.Add(Me.rtbImprovementComments)
        Me.spltOveralFirstReworkText.Panel1.Controls.Add(Me.rtbOverallComments)
        Me.spltOveralFirstReworkText.Panel1.Controls.Add(Me.llblFirstAttemptText)
        '
        'spltOveralFirstReworkText.Panel2
        '
        Me.spltOveralFirstReworkText.Panel2.Controls.Add(Me.rtbImprovementCommentsRework)
        Me.spltOveralFirstReworkText.Panel2.Controls.Add(Me.rtbOverallCommentsRework)
        Me.spltOveralFirstReworkText.Panel2.Controls.Add(Me.llblReworkText)
        Me.spltOveralFirstReworkText.Size = New System.Drawing.Size(574, 138)
        Me.spltOveralFirstReworkText.SplitterDistance = 269
        Me.spltOveralFirstReworkText.TabIndex = 144
        '
        'rtbImprovementComments
        '
        Me.rtbImprovementComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rtbImprovementComments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbImprovementComments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbImprovementComments.Location = New System.Drawing.Point(0, 64)
        Me.rtbImprovementComments.Name = "rtbImprovementComments"
        Me.rtbImprovementComments.Size = New System.Drawing.Size(269, 74)
        Me.rtbImprovementComments.TabIndex = 107
        Me.rtbImprovementComments.Text = ""
        '
        'rtbOverallComments
        '
        Me.rtbOverallComments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbOverallComments.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbOverallComments.Location = New System.Drawing.Point(0, 16)
        Me.rtbOverallComments.Name = "rtbOverallComments"
        Me.rtbOverallComments.Size = New System.Drawing.Size(269, 48)
        Me.rtbOverallComments.TabIndex = 106
        Me.rtbOverallComments.Text = ""
        '
        'llblFirstAttemptText
        '
        Me.llblFirstAttemptText.AutoSize = True
        Me.llblFirstAttemptText.Dock = System.Windows.Forms.DockStyle.Top
        Me.llblFirstAttemptText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblFirstAttemptText.Location = New System.Drawing.Point(0, 0)
        Me.llblFirstAttemptText.Name = "llblFirstAttemptText"
        Me.llblFirstAttemptText.Size = New System.Drawing.Size(82, 16)
        Me.llblFirstAttemptText.TabIndex = 143
        Me.llblFirstAttemptText.TabStop = True
        Me.llblFirstAttemptText.Text = "First attempt"
        '
        'rtbImprovementCommentsRework
        '
        Me.rtbImprovementCommentsRework.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rtbImprovementCommentsRework.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbImprovementCommentsRework.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbImprovementCommentsRework.Location = New System.Drawing.Point(0, 64)
        Me.rtbImprovementCommentsRework.Name = "rtbImprovementCommentsRework"
        Me.rtbImprovementCommentsRework.Size = New System.Drawing.Size(301, 74)
        Me.rtbImprovementCommentsRework.TabIndex = 144
        Me.rtbImprovementCommentsRework.Text = ""
        '
        'rtbOverallCommentsRework
        '
        Me.rtbOverallCommentsRework.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbOverallCommentsRework.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbOverallCommentsRework.Location = New System.Drawing.Point(0, 16)
        Me.rtbOverallCommentsRework.Name = "rtbOverallCommentsRework"
        Me.rtbOverallCommentsRework.Size = New System.Drawing.Size(301, 48)
        Me.rtbOverallCommentsRework.TabIndex = 143
        Me.rtbOverallCommentsRework.Text = ""
        '
        'llblReworkText
        '
        Me.llblReworkText.AutoSize = True
        Me.llblReworkText.Dock = System.Windows.Forms.DockStyle.Top
        Me.llblReworkText.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.llblReworkText.Location = New System.Drawing.Point(0, 0)
        Me.llblReworkText.Name = "llblReworkText"
        Me.llblReworkText.Size = New System.Drawing.Size(51, 16)
        Me.llblReworkText.TabIndex = 0
        Me.llblReworkText.TabStop = True
        Me.llblReworkText.Text = "Rework"
        '
        'rtbObservationComments
        '
        Me.rtbObservationComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbObservationComments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbObservationComments.Location = New System.Drawing.Point(93, 147)
        Me.rtbObservationComments.Name = "rtbObservationComments"
        Me.rtbObservationComments.Size = New System.Drawing.Size(574, 50)
        Me.rtbObservationComments.TabIndex = 106
        Me.rtbObservationComments.Text = ""
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel13.Location = New System.Drawing.Point(6, 147)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel13.TabIndex = 104
        Me.KryptonLabel13.Values.Text = "Observation:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 3)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel3.TabIndex = 60
        Me.KryptonLabel3.Values.Text = "Overall:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 60)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(87, 20)
        Me.KryptonLabel4.TabIndex = 61
        Me.KryptonLabel4.Values.Text = "Improvement:"
        '
        'btnGenerateOverallComments
        '
        Me.btnGenerateOverallComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateOverallComments.Location = New System.Drawing.Point(695, 3)
        Me.btnGenerateOverallComments.Name = "btnGenerateOverallComments"
        Me.btnGenerateOverallComments.Size = New System.Drawing.Size(38, 34)
        Me.btnGenerateOverallComments.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.btnGenerateOverallComments, "Generate overall comments")
        Me.btnGenerateOverallComments.Values.Image = Global.Teaching.My.Resources.Resources.notes_32
        Me.btnGenerateOverallComments.Values.Text = ""
        Me.btnGenerateOverallComments.Visible = False
        '
        'btnGenerateImprovementComments
        '
        Me.btnGenerateImprovementComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateImprovementComments.Location = New System.Drawing.Point(695, 61)
        Me.btnGenerateImprovementComments.Name = "btnGenerateImprovementComments"
        Me.btnGenerateImprovementComments.Size = New System.Drawing.Size(38, 34)
        Me.btnGenerateImprovementComments.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.btnGenerateImprovementComments, "Generate improvement comments")
        Me.btnGenerateImprovementComments.Values.Image = Global.Teaching.My.Resources.Resources.notes_32
        Me.btnGenerateImprovementComments.Values.Text = ""
        Me.btnGenerateImprovementComments.Visible = False
        '
        'lblImprovementCharCount
        '
        Me.lblImprovementCharCount.Location = New System.Drawing.Point(6, 77)
        Me.lblImprovementCharCount.Name = "lblImprovementCharCount"
        Me.lblImprovementCharCount.Size = New System.Drawing.Size(68, 20)
        Me.lblImprovementCharCount.TabIndex = 101
        Me.ToolTip1.SetToolTip(Me.lblImprovementCharCount, "Characters")
        Me.lblImprovementCharCount.Values.Text = "Characters"
        '
        'llblAutoGenImprovementsRework
        '
        Me.llblAutoGenImprovementsRework.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAutoGenImprovementsRework.Location = New System.Drawing.Point(682, 103)
        Me.llblAutoGenImprovementsRework.Name = "llblAutoGenImprovementsRework"
        Me.llblAutoGenImprovementsRework.Size = New System.Drawing.Size(55, 20)
        Me.llblAutoGenImprovementsRework.TabIndex = 146
        Me.ToolTip1.SetToolTip(Me.llblAutoGenImprovementsRework, "Automatically generate improvement comments based on checked improvement items (w" &
        "ith performance level)")
        Me.llblAutoGenImprovementsRework.Values.Text = "Gen RW"
        '
        'llblAutoGenImprovementsFirst
        '
        Me.llblAutoGenImprovementsFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblAutoGenImprovementsFirst.Location = New System.Drawing.Point(6, 103)
        Me.llblAutoGenImprovementsFirst.Name = "llblAutoGenImprovementsFirst"
        Me.llblAutoGenImprovementsFirst.Size = New System.Drawing.Size(52, 20)
        Me.llblAutoGenImprovementsFirst.TabIndex = 145
        Me.ToolTip1.SetToolTip(Me.llblAutoGenImprovementsFirst, "Automatically generate improvement comments based on checked improvement items (w" &
        "ith performance level)")
        Me.llblAutoGenImprovementsFirst.Values.Text = "Gen 1st"
        '
        'llblAutoGenOverallRework
        '
        Me.llblAutoGenOverallRework.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAutoGenOverallRework.Location = New System.Drawing.Point(682, 35)
        Me.llblAutoGenOverallRework.Name = "llblAutoGenOverallRework"
        Me.llblAutoGenOverallRework.Size = New System.Drawing.Size(55, 20)
        Me.llblAutoGenOverallRework.TabIndex = 146
        Me.llblAutoGenOverallRework.Values.Text = "Gen RW"
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
        Me.KryptonSplitContainer3.SplitterDistance = 230
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
        Me.olvAutoFeedback.HideSelection = False
        Me.olvAutoFeedback.Location = New System.Drawing.Point(0, 24)
        Me.olvAutoFeedback.MultiSelect = False
        Me.olvAutoFeedback.Name = "olvAutoFeedback"
        Me.olvAutoFeedback.ShowGroups = False
        Me.olvAutoFeedback.ShowImagesOnSubItems = True
        Me.olvAutoFeedback.ShowItemToolTips = True
        Me.olvAutoFeedback.Size = New System.Drawing.Size(230, 409)
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
        Me.txtFeedbackFilter.Location = New System.Drawing.Point(55, 2)
        Me.txtFeedbackFilter.Name = "txtFeedbackFilter"
        Me.txtFeedbackFilter.Size = New System.Drawing.Size(150, 23)
        Me.txtFeedbackFilter.TabIndex = 92
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 1)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(40, 20)
        Me.KryptonLabel5.TabIndex = 68
        Me.KryptonLabel5.Values.Text = "Filter:"
        '
        'llblClearFilter
        '
        Me.llblClearFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblClearFilter.Location = New System.Drawing.Point(205, 2)
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
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn3)
        Me.olvImprovementItems.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvImprovementItems.CellEditUseWholeCell = False
        Me.olvImprovementItems.CheckBoxes = True
        Me.olvImprovementItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.olvcolDateAdded, Me.olvcolDateRemoved, Me.OlvColumn5, Me.olvcolPerformanceLevel, Me.OlvColumn3})
        Me.olvImprovementItems.CopySelectionOnControlC = False
        Me.olvImprovementItems.CopySelectionOnControlCUsesDragSource = False
        Me.olvImprovementItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvImprovementItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvImprovementItems.EmptyListMsg = "No improvement items"
        Me.olvImprovementItems.FullRowSelect = True
        Me.olvImprovementItems.HideSelection = False
        Me.olvImprovementItems.Location = New System.Drawing.Point(0, 0)
        Me.olvImprovementItems.MultiSelect = False
        Me.olvImprovementItems.Name = "olvImprovementItems"
        Me.olvImprovementItems.ShowGroups = False
        Me.olvImprovementItems.ShowImagesOnSubItems = True
        Me.olvImprovementItems.ShowItemToolTips = True
        Me.olvImprovementItems.Size = New System.Drawing.Size(193, 433)
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
        Me.olvcolDateAdded.DisplayIndex = 3
        Me.olvcolDateAdded.Text = "Added"
        Me.olvcolDateAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'olvcolDateRemoved
        '
        Me.olvcolDateRemoved.AspectName = "DateLastIncluded"
        Me.olvcolDateRemoved.AspectToStringFormat = "{0:d}"
        Me.olvcolDateRemoved.DisplayIndex = 4
        Me.olvcolDateRemoved.Text = "Last time"
        Me.olvcolDateRemoved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolDateRemoved.ToolTipText = "Date this was last included in student feedback"
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "BaseImprovementItem.Description"
        Me.OlvColumn5.DisplayIndex = 5
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
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "PreviousPerformanceLevel "
        Me.OlvColumn3.DisplayIndex = 2
        Me.OlvColumn3.Text = "Prev"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'llblOpenSavedMarkingPage
        '
        Me.llblOpenSavedMarkingPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblOpenSavedMarkingPage.Location = New System.Drawing.Point(1073, 3)
        Me.llblOpenSavedMarkingPage.Name = "llblOpenSavedMarkingPage"
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
        Me.chkProcessed.Location = New System.Drawing.Point(963, 34)
        Me.chkProcessed.Name = "chkProcessed"
        Me.chkProcessed.Size = New System.Drawing.Size(81, 20)
        Me.chkProcessed.TabIndex = 48
        Me.chkProcessed.Text = "&Processed:"
        Me.chkProcessed.Values.Text = "&Processed:"
        '
        'btnPrintMarkingSheet
        '
        Me.btnPrintMarkingSheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintMarkingSheet.Location = New System.Drawing.Point(1127, 26)
        Me.btnPrintMarkingSheet.Name = "btnPrintMarkingSheet"
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
        Me.KryptonLabel9.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel9.TabIndex = 97
        Me.KryptonLabel9.Values.Text = "Timer:"
        '
        'llblEjectCD
        '
        Me.llblEjectCD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblEjectCD.Location = New System.Drawing.Point(352, 17)
        Me.llblEjectCD.Name = "llblEjectCD"
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
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(71, 23)
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
        Me.llblStudentPic.Location = New System.Drawing.Point(290, 54)
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
        Me.KryptonLabel12.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel12.TabIndex = 114
        Me.KryptonLabel12.Values.Text = "Writing:"
        '
        'nudPlagiarismSeverity
        '
        Me.nudPlagiarismSeverity.Location = New System.Drawing.Point(435, 27)
        Me.nudPlagiarismSeverity.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPlagiarismSeverity.Name = "nudPlagiarismSeverity"
        Me.nudPlagiarismSeverity.Size = New System.Drawing.Size(57, 22)
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
        Me.KryptonLabel10.Size = New System.Drawing.Size(37, 20)
        Me.KryptonLabel10.TabIndex = 113
        Me.KryptonLabel10.Values.Text = "Plag:"
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(781, 26)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.ReadOnly = True
        Me.txtTeam.Size = New System.Drawing.Size(91, 23)
        Me.txtTeam.TabIndex = 111
        '
        'txtSchoolClass
        '
        Me.txtSchoolClass.Location = New System.Drawing.Point(544, 3)
        Me.txtSchoolClass.Name = "txtSchoolClass"
        Me.txtSchoolClass.ReadOnly = True
        Me.txtSchoolClass.Size = New System.Drawing.Size(84, 23)
        Me.txtSchoolClass.TabIndex = 111
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(497, 3)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel11.TabIndex = 110
        Me.KryptonLabel11.Values.Text = "Class:"
        '
        'nudAltNumber
        '
        Me.nudAltNumber.Location = New System.Drawing.Point(536, 27)
        Me.nudAltNumber.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudAltNumber.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.nudAltNumber.Name = "nudAltNumber"
        Me.nudAltNumber.Size = New System.Drawing.Size(67, 22)
        Me.nudAltNumber.TabIndex = 100
        Me.nudAltNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAltNumber.ThousandsSeparator = True
        Me.nudAltNumber.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudPresentationQuality
        '
        Me.nudPresentationQuality.Location = New System.Drawing.Point(90, 25)
        Me.nudPresentationQuality.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPresentationQuality.Name = "nudPresentationQuality"
        Me.nudPresentationQuality.Size = New System.Drawing.Size(68, 22)
        Me.nudPresentationQuality.TabIndex = 99
        Me.nudPresentationQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPresentationQuality.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudPresentationQuality, "Presentation quality of student")
        Me.nudPresentationQuality.Value = New Decimal(New Integer() {2, 0, 0, 0})
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
        'llblAchieveAllMerit
        '
        Me.llblAchieveAllMerit.Location = New System.Drawing.Point(94, 72)
        Me.llblAchieveAllMerit.Name = "llblAchieveAllMerit"
        Me.llblAchieveAllMerit.Size = New System.Drawing.Size(39, 20)
        Me.llblAchieveAllMerit.TabIndex = 87
        Me.ToolTip1.SetToolTip(Me.llblAchieveAllMerit, "Achieve all Merit")
        Me.llblAchieveAllMerit.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAchieveAllMerit.Values.Text = "M"
        '
        'llblAchieveAllPass
        '
        Me.llblAchieveAllPass.Location = New System.Drawing.Point(33, 71)
        Me.llblAchieveAllPass.Name = "llblAchieveAllPass"
        Me.llblAchieveAllPass.Size = New System.Drawing.Size(34, 20)
        Me.llblAchieveAllPass.TabIndex = 86
        Me.ToolTip1.SetToolTip(Me.llblAchieveAllPass, "Achieve all Pass")
        Me.llblAchieveAllPass.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAchieveAllPass.Values.Text = "P"
        '
        'llblFailAll
        '
        Me.llblFailAll.Location = New System.Drawing.Point(227, 72)
        Me.llblFailAll.Name = "llblFailAll"
        Me.llblFailAll.Size = New System.Drawing.Size(22, 18)
        Me.llblFailAll.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.llblFailAll, "Fail all")
        Me.llblFailAll.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.llblFailAll.Values.Text = ""
        '
        'llblAchieveAllDistinction
        '
        Me.llblAchieveAllDistinction.Location = New System.Drawing.Point(158, 72)
        Me.llblAchieveAllDistinction.Name = "llblAchieveAllDistinction"
        Me.llblAchieveAllDistinction.Size = New System.Drawing.Size(36, 20)
        Me.llblAchieveAllDistinction.TabIndex = 75
        Me.ToolTip1.SetToolTip(Me.llblAchieveAllDistinction, "Achieve all Distinction")
        Me.llblAchieveAllDistinction.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblAchieveAllDistinction.Values.Text = "D"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 26)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel7.TabIndex = 74
        Me.KryptonLabel7.Values.Text = "Presentation:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(646, 3)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel6.TabIndex = 71
        Me.KryptonLabel6.Values.Text = "Assignment:"
        '
        'txtAssignmentName
        '
        Me.txtAssignmentName.Location = New System.Drawing.Point(729, 3)
        Me.txtAssignmentName.Name = "txtAssignmentName"
        Me.txtAssignmentName.ReadOnly = True
        Me.txtAssignmentName.Size = New System.Drawing.Size(147, 23)
        Me.txtAssignmentName.TabIndex = 70
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(344, 3)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(147, 23)
        Me.txtStudentID.TabIndex = 58
        '
        'txtNickName
        '
        Me.txtNickName.Location = New System.Drawing.Point(90, 3)
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.ReadOnly = True
        Me.txtNickName.Size = New System.Drawing.Size(138, 23)
        Me.txtNickName.TabIndex = 57
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel1.TabIndex = 56
        Me.KryptonLabel1.Values.Text = "NickName:"
        '
        'chkShowFeedback
        '
        Me.chkShowFeedback.Checked = True
        Me.chkShowFeedback.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkShowFeedback.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowFeedback.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkShowFeedback.Location = New System.Drawing.Point(404, 73)
        Me.chkShowFeedback.Name = "chkShowFeedback"
        Me.chkShowFeedback.Size = New System.Drawing.Size(78, 20)
        Me.chkShowFeedback.TabIndex = 53
        Me.chkShowFeedback.Text = "Fee&dback:"
        Me.chkShowFeedback.Values.Text = "Fee&dback:"
        '
        'chkShowImprovement
        '
        Me.chkShowImprovement.Checked = True
        Me.chkShowImprovement.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkShowImprovement.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowImprovement.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkShowImprovement.Location = New System.Drawing.Point(503, 73)
        Me.chkShowImprovement.Name = "chkShowImprovement"
        Me.chkShowImprovement.Size = New System.Drawing.Size(100, 20)
        Me.chkShowImprovement.TabIndex = 52
        Me.chkShowImprovement.Text = "&Improvement:"
        Me.chkShowImprovement.Values.Text = "&Improvement:"
        '
        'llblOpenStudent
        '
        Me.llblOpenStudent.Location = New System.Drawing.Point(273, 3)
        Me.llblOpenStudent.Name = "llblOpenStudent"
        Me.llblOpenStudent.Size = New System.Drawing.Size(71, 20)
        Me.llblOpenStudent.TabIndex = 120
        Me.ToolTip1.SetToolTip(Me.llblOpenStudent, "Open student")
        Me.llblOpenStudent.Values.Text = "Student ID:"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(732, 27)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(43, 20)
        Me.KryptonLabel15.TabIndex = 110
        Me.KryptonLabel15.Values.Text = "Team:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(878, 26)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(38, 20)
        Me.KryptonLabel2.TabIndex = 71
        Me.KryptonLabel2.Values.Text = "Tags:"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(494, 29)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel8.TabIndex = 78
        Me.KryptonLabel8.Values.Text = "Alt #:"
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ActionsToolStripMenuItem, Me.FocusToolStripMenuItem})
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
        'FocusToolStripMenuItem
        '
        Me.FocusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FocusOntagsToolStripMenuItem, Me.FocusOnoverallToolStripMenuItem, Me.FocusOnfeedbackToolStripMenuItem, Me.FocusOnoutcomesToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.FocusToolStripMenuItem.Name = "FocusToolStripMenuItem"
        Me.FocusToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FocusToolStripMenuItem.Text = "Fo&cus"
        '
        'FocusOntagsToolStripMenuItem
        '
        Me.FocusOntagsToolStripMenuItem.Name = "FocusOntagsToolStripMenuItem"
        Me.FocusOntagsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.FocusOntagsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FocusOntagsToolStripMenuItem.Text = "Focus on &tags"
        '
        'FocusOnoverallToolStripMenuItem
        '
        Me.FocusOnoverallToolStripMenuItem.Name = "FocusOnoverallToolStripMenuItem"
        Me.FocusOnoverallToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FocusOnoverallToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FocusOnoverallToolStripMenuItem.Text = "Focus on &overall"
        '
        'FocusOnfeedbackToolStripMenuItem
        '
        Me.FocusOnfeedbackToolStripMenuItem.Name = "FocusOnfeedbackToolStripMenuItem"
        Me.FocusOnfeedbackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FocusOnfeedbackToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FocusOnfeedbackToolStripMenuItem.Text = "Focus on &feedback"
        '
        'FocusOnoutcomesToolStripMenuItem
        '
        Me.FocusOnoutcomesToolStripMenuItem.Name = "FocusOnoutcomesToolStripMenuItem"
        Me.FocusOnoutcomesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.FocusOnoutcomesToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FocusOnoutcomesToolStripMenuItem.Text = "Focus on o&utcomes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(220, 22)
        Me.ToolStripMenuItem2.Text = "`"
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
        Me.spltOveralFirstReworkText.Panel1.ResumeLayout(False)
        Me.spltOveralFirstReworkText.Panel1.PerformLayout()
        Me.spltOveralFirstReworkText.Panel2.ResumeLayout(False)
        Me.spltOveralFirstReworkText.Panel2.PerformLayout()
        CType(Me.spltOveralFirstReworkText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltOveralFirstReworkText.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.ResumeLayout(False)
        CType(Me.olvAutoFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents chkShowFeedback As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkShowImprovement As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents txtStudentID As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtNickName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtAssignmentName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblFailAll As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAchieveAllDistinction As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblAchieveAllMerit As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAchieveAllPass As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblEditStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents nudAltNumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents nudPresentationQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents txtSchoolClass As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents nudPlagiarismSeverity As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents nudWritingQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents llblStudentPic As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblOpenStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblAddImprovementItem As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents llblClearImprovementItem As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents KryptonSplitContainer4 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents llblModuleResults As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents btnGenerateOverallComments As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Private WithEvents btnGenerateImprovementComments As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
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
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Private WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents olvcolPerformanceLevel As BrightIdeasSoftware.OLVColumn
    Private WithEvents txtTeam As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents olvOutcomes As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumnOutcomeName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Private WithEvents nudResearchQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents txtGroup As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents FocusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FocusOntagsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FocusOnoverallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FocusOnfeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FocusOnoutcomesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtLastUserFullName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtFirstUserFullName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtbImprovementComments As RichTextBox
    Friend WithEvents rtbOverallComments As RichTextBox
    Friend WithEvents rtbObservationComments As RichTextBox
    Friend WithEvents spltOveralFirstReworkText As SplitContainer
    Friend WithEvents llblFirstAttemptText As LinkLabel
    Friend WithEvents rtbImprovementCommentsRework As RichTextBox
    Friend WithEvents rtbOverallCommentsRework As RichTextBox
    Friend WithEvents llblReworkText As LinkLabel
    Friend WithEvents llblAutoGenImprovementsRework As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblAutoGenImprovementsFirst As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblAutoGenOverallFirst As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblAutoGenOverallRework As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
End Class
