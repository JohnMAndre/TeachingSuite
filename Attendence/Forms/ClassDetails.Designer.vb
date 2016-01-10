<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassDetails))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNotes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblCalculateTotalTime = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.nudEmailAccountToUse = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.lblEmailAccountCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmailAddress = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblEmailCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblCopyTopics = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblPasteTopics = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnCopySessionsFromOtherClass = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnRegenerateActualSchedule = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtClassName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDownToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveupToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.btnShowNormalSchedule = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnShowSkips = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnShowActualSessions = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.olvPlannedSchedule = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn15 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ctxmnuPlannedSchedule = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddScheduleItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveScheduleItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.olvSessionsToSkip = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn16 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ctxmnuSkipSessions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSkipSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.olvActualSessions = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn17 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn18 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ctxmnuActualSessions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SkipActualSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertSessionBeforeSelectedSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MovedownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrResetDuration = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.olvPlannedSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmnuPlannedSchedule.SuspendLayout()
        CType(Me.olvSessionsToSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmnuSkipSessions.SuspendLayout()
        CType(Me.olvActualSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmnuActualSessions.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.txtNotes)
        Me.KryptonPanel.Controls.Add(Me.llblCalculateTotalTime)
        Me.KryptonPanel.Controls.Add(Me.nudEmailAccountToUse)
        Me.KryptonPanel.Controls.Add(Me.lblEmailAccountCaption)
        Me.KryptonPanel.Controls.Add(Me.txtEmailAddress)
        Me.KryptonPanel.Controls.Add(Me.lblEmailCaption)
        Me.KryptonPanel.Controls.Add(Me.llblCopyTopics)
        Me.KryptonPanel.Controls.Add(Me.llblPasteTopics)
        Me.KryptonPanel.Controls.Add(Me.btnCopySessionsFromOtherClass)
        Me.KryptonPanel.Controls.Add(Me.btnRegenerateActualSchedule)
        Me.KryptonPanel.Controls.Add(Me.txtClassName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(885, 442)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(411, 28)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel3.TabIndex = 140
        Me.KryptonLabel3.Values.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.Location = New System.Drawing.Point(461, 27)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(412, 47)
        Me.txtNotes.TabIndex = 139
        '
        'llblCalculateTotalTime
        '
        Me.llblCalculateTotalTime.Location = New System.Drawing.Point(279, 101)
        Me.llblCalculateTotalTime.Name = "llblCalculateTotalTime"
        Me.llblCalculateTotalTime.Size = New System.Drawing.Size(148, 19)
        Me.llblCalculateTotalTime.TabIndex = 138
        Me.ToolTip1.SetToolTip(Me.llblCalculateTotalTime, "Click to see the total class time scheduled")
        Me.llblCalculateTotalTime.Values.Text = "Calculate total duration"
        '
        'nudEmailAccountToUse
        '
        Me.nudEmailAccountToUse.Location = New System.Drawing.Point(130, 80)
        Me.nudEmailAccountToUse.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudEmailAccountToUse.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEmailAccountToUse.Name = "nudEmailAccountToUse"
        Me.nudEmailAccountToUse.Size = New System.Drawing.Size(66, 21)
        Me.nudEmailAccountToUse.TabIndex = 136
        Me.nudEmailAccountToUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudEmailAccountToUse.ThousandsSeparator = True
        Me.nudEmailAccountToUse.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'lblEmailAccountCaption
        '
        Me.lblEmailAccountCaption.Location = New System.Drawing.Point(12, 80)
        Me.lblEmailAccountCaption.Name = "lblEmailAccountCaption"
        Me.lblEmailAccountCaption.Size = New System.Drawing.Size(99, 19)
        Me.lblEmailAccountCaption.TabIndex = 135
        Me.lblEmailAccountCaption.Values.Text = "Email account:"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(130, 54)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(275, 19)
        Me.txtEmailAddress.TabIndex = 85
        '
        'lblEmailCaption
        '
        Me.lblEmailCaption.Location = New System.Drawing.Point(12, 54)
        Me.lblEmailCaption.Name = "lblEmailCaption"
        Me.lblEmailCaption.Size = New System.Drawing.Size(48, 19)
        Me.lblEmailCaption.TabIndex = 84
        Me.lblEmailCaption.Values.Text = "Email:"
        '
        'llblCopyTopics
        '
        Me.llblCopyTopics.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblCopyTopics.Location = New System.Drawing.Point(663, 85)
        Me.llblCopyTopics.Name = "llblCopyTopics"
        Me.llblCopyTopics.Size = New System.Drawing.Size(38, 34)
        Me.llblCopyTopics.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.llblCopyTopics, "Copy selected topics to other class")
        Me.llblCopyTopics.Values.Image = Global.Teaching.My.Resources.Resources.cut_32
        Me.llblCopyTopics.Values.Text = ""
        '
        'llblPasteTopics
        '
        Me.llblPasteTopics.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblPasteTopics.Location = New System.Drawing.Point(707, 85)
        Me.llblPasteTopics.Name = "llblPasteTopics"
        Me.llblPasteTopics.Size = New System.Drawing.Size(38, 34)
        Me.llblPasteTopics.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.llblPasteTopics, "Paste copied topics")
        Me.llblPasteTopics.Values.Image = Global.Teaching.My.Resources.Resources.paste_32
        Me.llblPasteTopics.Values.Text = ""
        '
        'btnCopySessionsFromOtherClass
        '
        Me.btnCopySessionsFromOtherClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopySessionsFromOtherClass.Location = New System.Drawing.Point(781, 85)
        Me.btnCopySessionsFromOtherClass.Name = "btnCopySessionsFromOtherClass"
        Me.btnCopySessionsFromOtherClass.Size = New System.Drawing.Size(38, 34)
        Me.btnCopySessionsFromOtherClass.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.btnCopySessionsFromOtherClass, "Copy session attributes from other class")
        Me.btnCopySessionsFromOtherClass.Values.Image = Global.Teaching.My.Resources.Resources.Copy_32
        Me.btnCopySessionsFromOtherClass.Values.Text = ""
        '
        'btnRegenerateActualSchedule
        '
        Me.btnRegenerateActualSchedule.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegenerateActualSchedule.Location = New System.Drawing.Point(840, 86)
        Me.btnRegenerateActualSchedule.Name = "btnRegenerateActualSchedule"
        Me.btnRegenerateActualSchedule.Size = New System.Drawing.Size(38, 34)
        Me.btnRegenerateActualSchedule.TabIndex = 80
        Me.btnRegenerateActualSchedule.Values.Image = Global.Teaching.My.Resources.Resources.backup_32
        Me.btnRegenerateActualSchedule.Values.Text = ""
        '
        'txtClassName
        '
        Me.txtClassName.Location = New System.Drawing.Point(130, 27)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(275, 19)
        Me.txtClassName.TabIndex = 64
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 28)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel1.TabIndex = 42
        Me.KryptonLabel1.Values.Text = "Class name:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ScheduleItemToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(885, 24)
        Me.MenuStrip1.TabIndex = 83
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ScheduleItemToolStripMenuItem
        '
        Me.ScheduleItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveDownToolStripMenuItem1, Me.MoveupToolStripMenuItem1})
        Me.ScheduleItemToolStripMenuItem.Name = "ScheduleItemToolStripMenuItem"
        Me.ScheduleItemToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ScheduleItemToolStripMenuItem.Text = "Schedule item"
        '
        'MoveDownToolStripMenuItem1
        '
        Me.MoveDownToolStripMenuItem1.Name = "MoveDownToolStripMenuItem1"
        Me.MoveDownToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.MoveDownToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.MoveDownToolStripMenuItem1.Text = "Move &down"
        '
        'MoveupToolStripMenuItem1
        '
        Me.MoveupToolStripMenuItem1.Name = "MoveupToolStripMenuItem1"
        Me.MoveupToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.MoveupToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.MoveupToolStripMenuItem1.Text = "Move &up"
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
        'btnShowNormalSchedule
        '
        Me.btnShowNormalSchedule.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowNormalSchedule.Location = New System.Drawing.Point(533, 85)
        Me.btnShowNormalSchedule.Name = "btnShowNormalSchedule"
        Me.btnShowNormalSchedule.Size = New System.Drawing.Size(38, 34)
        Me.btnShowNormalSchedule.TabIndex = 79
        Me.btnShowNormalSchedule.Values.Image = Global.Teaching.My.Resources.Resources.calendar_P_32
        Me.btnShowNormalSchedule.Values.Text = ""
        '
        'btnShowSkips
        '
        Me.btnShowSkips.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowSkips.Location = New System.Drawing.Point(489, 85)
        Me.btnShowSkips.Name = "btnShowSkips"
        Me.btnShowSkips.Size = New System.Drawing.Size(38, 34)
        Me.btnShowSkips.TabIndex = 78
        Me.btnShowSkips.Values.Image = Global.Teaching.My.Resources.Resources.calendar_X_32
        Me.btnShowSkips.Values.Text = ""
        '
        'btnShowActualSessions
        '
        Me.btnShowActualSessions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowActualSessions.Location = New System.Drawing.Point(577, 85)
        Me.btnShowActualSessions.Name = "btnShowActualSessions"
        Me.btnShowActualSessions.Size = New System.Drawing.Size(38, 34)
        Me.btnShowActualSessions.TabIndex = 77
        Me.btnShowActualSessions.Values.Image = Global.Teaching.My.Resources.Resources.calendar_A_32
        Me.btnShowActualSessions.Values.Text = ""
        '
        'olvPlannedSchedule
        '
        Me.olvPlannedSchedule.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvPlannedSchedule.AllColumns.Add(Me.OlvColumn2)
        Me.olvPlannedSchedule.AllColumns.Add(Me.OlvColumn7)
        Me.olvPlannedSchedule.AllColumns.Add(Me.OlvColumn13)
        Me.olvPlannedSchedule.AllColumns.Add(Me.OlvColumn14)
        Me.olvPlannedSchedule.AllColumns.Add(Me.OlvColumn15)
        Me.olvPlannedSchedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvPlannedSchedule.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvPlannedSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn2, Me.OlvColumn7, Me.OlvColumn13, Me.OlvColumn14, Me.OlvColumn15})
        Me.olvPlannedSchedule.ContextMenuStrip = Me.ctxmnuPlannedSchedule
        Me.olvPlannedSchedule.FullRowSelect = True
        Me.olvPlannedSchedule.Location = New System.Drawing.Point(3, 126)
        Me.olvPlannedSchedule.Name = "olvPlannedSchedule"
        Me.olvPlannedSchedule.ShowGroups = False
        Me.olvPlannedSchedule.Size = New System.Drawing.Size(881, 273)
        Me.olvPlannedSchedule.TabIndex = 75
        Me.olvPlannedSchedule.UseCompatibleStateImageBehavior = False
        Me.olvPlannedSchedule.UseFiltering = True
        Me.olvPlannedSchedule.View = System.Windows.Forms.View.Details
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "DayOfWeek"
        Me.OlvColumn2.Text = "Day of Week"
        Me.OlvColumn2.Width = 150
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "StartTime"
        Me.OlvColumn7.AspectToStringFormat = "{0:t}"
        Me.OlvColumn7.Text = "Start Time"
        Me.OlvColumn7.Width = 150
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "Location"
        Me.OlvColumn13.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.Text = "Location"
        Me.OlvColumn13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.Width = 74
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "DurationInMinutes"
        Me.OlvColumn14.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.Text = "Minutes"
        Me.OlvColumn14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.Width = 80
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "StudentGroup"
        Me.OlvColumn15.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn15.Text = "Group"
        Me.OlvColumn15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn15.Width = 75
        '
        'ctxmnuPlannedSchedule
        '
        Me.ctxmnuPlannedSchedule.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuPlannedSchedule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddScheduleItemToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveScheduleItemToolStripMenuItem})
        Me.ctxmnuPlannedSchedule.Name = "ctxmnuPlannedSchedule"
        Me.ctxmnuPlannedSchedule.Size = New System.Drawing.Size(195, 54)
        '
        'AddScheduleItemToolStripMenuItem
        '
        Me.AddScheduleItemToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.AddScheduleItemToolStripMenuItem.Name = "AddScheduleItemToolStripMenuItem"
        Me.AddScheduleItemToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddScheduleItemToolStripMenuItem.Text = "&Add schedule item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'RemoveScheduleItemToolStripMenuItem
        '
        Me.RemoveScheduleItemToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.RemoveScheduleItemToolStripMenuItem.Name = "RemoveScheduleItemToolStripMenuItem"
        Me.RemoveScheduleItemToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RemoveScheduleItemToolStripMenuItem.Text = "&Remove schedule item"
        '
        'olvSessionsToSkip
        '
        Me.olvSessionsToSkip.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvSessionsToSkip.AllColumns.Add(Me.OlvColumn1)
        Me.olvSessionsToSkip.AllColumns.Add(Me.OlvColumn16)
        Me.olvSessionsToSkip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvSessionsToSkip.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvSessionsToSkip.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn16})
        Me.olvSessionsToSkip.ContextMenuStrip = Me.ctxmnuSkipSessions
        Me.olvSessionsToSkip.FullRowSelect = True
        Me.olvSessionsToSkip.Location = New System.Drawing.Point(3, 126)
        Me.olvSessionsToSkip.Name = "olvSessionsToSkip"
        Me.olvSessionsToSkip.ShowGroups = False
        Me.olvSessionsToSkip.Size = New System.Drawing.Size(881, 273)
        Me.olvSessionsToSkip.TabIndex = 62
        Me.olvSessionsToSkip.UseCompatibleStateImageBehavior = False
        Me.olvSessionsToSkip.UseFiltering = True
        Me.olvSessionsToSkip.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "StartDateTime"
        Me.OlvColumn1.AspectToStringFormat = ""
        Me.OlvColumn1.Text = "Date"
        Me.OlvColumn1.Width = 168
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "Reason"
        Me.OlvColumn16.Text = "Reason"
        Me.OlvColumn16.Width = 282
        '
        'ctxmnuSkipSessions
        '
        Me.ctxmnuSkipSessions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuSkipSessions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSkipSessionToolStripMenuItem})
        Me.ctxmnuSkipSessions.Name = "ctxmnuPlannedSchedule"
        Me.ctxmnuSkipSessions.Size = New System.Drawing.Size(183, 26)
        '
        'RemoveSkipSessionToolStripMenuItem
        '
        Me.RemoveSkipSessionToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.RemoveSkipSessionToolStripMenuItem.Name = "RemoveSkipSessionToolStripMenuItem"
        Me.RemoveSkipSessionToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RemoveSkipSessionToolStripMenuItem.Text = "Remove skip session"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(461, 405)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 66
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(334, 405)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'olvActualSessions
        '
        Me.olvActualSessions.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn5)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn6)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn3)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn4)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn8)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn9)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn11)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn12)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn10)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn17)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn18)
        Me.olvActualSessions.AllowColumnReorder = True
        Me.olvActualSessions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvActualSessions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvActualSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn11, Me.OlvColumn12, Me.OlvColumn10, Me.OlvColumn17, Me.OlvColumn18})
        Me.olvActualSessions.ContextMenuStrip = Me.ctxmnuActualSessions
        Me.olvActualSessions.FullRowSelect = True
        Me.olvActualSessions.Location = New System.Drawing.Point(3, 126)
        Me.olvActualSessions.Name = "olvActualSessions"
        Me.olvActualSessions.OwnerDraw = True
        Me.olvActualSessions.ShowGroups = False
        Me.olvActualSessions.ShowImagesOnSubItems = True
        Me.olvActualSessions.Size = New System.Drawing.Size(881, 273)
        Me.olvActualSessions.TabIndex = 76
        Me.olvActualSessions.UseAlternatingBackColors = True
        Me.olvActualSessions.UseCompatibleStateImageBehavior = False
        Me.olvActualSessions.UseFiltering = True
        Me.olvActualSessions.UseSubItemCheckBoxes = True
        Me.olvActualSessions.View = System.Windows.Forms.View.Details
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "SessionNumber"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "#"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "WeekNumber"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Text = "Week"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StartDateTime"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Start"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 147
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Topic"
        Me.OlvColumn4.Text = "Topic"
        Me.OlvColumn4.Width = 174
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "Prepped"
        Me.OlvColumn8.CheckBoxes = True
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "Prepped"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "StudentsEmailed"
        Me.OlvColumn9.CheckBoxes = True
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Text = "Sent"
        Me.OlvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "ScheduleType"
        Me.OlvColumn11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.Text = "Type"
        Me.OlvColumn11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.Width = 116
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "Location"
        Me.OlvColumn12.Text = "Location"
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "Notes"
        Me.OlvColumn10.Text = "Notes"
        Me.OlvColumn10.Width = 162
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "StudentGroup"
        Me.OlvColumn17.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Text = "Group"
        Me.OlvColumn17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn18
        '
        Me.OlvColumn18.AspectName = "DurationInMinutes"
        Me.OlvColumn18.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn18.Text = "Minutes"
        Me.OlvColumn18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn18.ToolTipText = "Duration of this session in minutes (impacts iCalendar export)"
        '
        'ctxmnuActualSessions
        '
        Me.ctxmnuActualSessions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuActualSessions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SkipActualSessionToolStripMenuItem, Me.SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem, Me.InsertSessionBeforeSelectedSessionToolStripMenuItem, Me.ToolStripSeparator2, Me.MovedownToolStripMenuItem, Me.MoveupToolStripMenuItem})
        Me.ctxmnuActualSessions.Name = "ctxmnuPlannedSchedule"
        Me.ctxmnuActualSessions.Size = New System.Drawing.Size(328, 120)
        '
        'SkipActualSessionToolStripMenuItem
        '
        Me.SkipActualSessionToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.SkipActualSessionToolStripMenuItem.Name = "SkipActualSessionToolStripMenuItem"
        Me.SkipActualSessionToolStripMenuItem.Size = New System.Drawing.Size(327, 22)
        Me.SkipActualSessionToolStripMenuItem.Text = "Skip selected session (remove topic completely)"
        '
        'SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem
        '
        Me.SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem.Name = "SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem"
        Me.SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem.Size = New System.Drawing.Size(327, 22)
        Me.SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem.Text = "Skip selected session and recalculate all sessions"
        '
        'InsertSessionBeforeSelectedSessionToolStripMenuItem
        '
        Me.InsertSessionBeforeSelectedSessionToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.InsertSessionBeforeSelectedSessionToolStripMenuItem.Name = "InsertSessionBeforeSelectedSessionToolStripMenuItem"
        Me.InsertSessionBeforeSelectedSessionToolStripMenuItem.Size = New System.Drawing.Size(327, 22)
        Me.InsertSessionBeforeSelectedSessionToolStripMenuItem.Text = "&Insert session before selected session"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(324, 6)
        '
        'MovedownToolStripMenuItem
        '
        Me.MovedownToolStripMenuItem.Name = "MovedownToolStripMenuItem"
        Me.MovedownToolStripMenuItem.Size = New System.Drawing.Size(327, 22)
        Me.MovedownToolStripMenuItem.Text = "Move &down"
        '
        'MoveupToolStripMenuItem
        '
        Me.MoveupToolStripMenuItem.Name = "MoveupToolStripMenuItem"
        Me.MoveupToolStripMenuItem.Size = New System.Drawing.Size(327, 22)
        Me.MoveupToolStripMenuItem.Text = "Move &up"
        '
        'tmrResetDuration
        '
        Me.tmrResetDuration.Interval = 5000
        '
        'ClassDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 442)
        Me.Controls.Add(Me.btnShowNormalSchedule)
        Me.Controls.Add(Me.btnShowSkips)
        Me.Controls.Add(Me.btnShowActualSessions)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.olvActualSessions)
        Me.Controls.Add(Me.olvPlannedSchedule)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.olvSessionsToSkip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ClassDetails"
        Me.Text = "Class Details"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.olvPlannedSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmnuPlannedSchedule.ResumeLayout(False)
        CType(Me.olvSessionsToSkip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmnuSkipSessions.ResumeLayout(False)
        CType(Me.olvActualSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmnuActualSessions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnShowNormalSchedule As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnShowSkips As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnShowActualSessions As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents olvPlannedSchedule As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvSessionsToSkip As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtClassName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents olvActualSessions As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ctxmnuPlannedSchedule As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddScheduleItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveScheduleItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctxmnuSkipSessions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveSkipSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxmnuActualSessions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SkipActualSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRegenerateActualSchedule As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents btnCopySessionsFromOtherClass As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents llblCopyTopics As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblPasteTopics As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertSessionBeforeSelectedSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn18 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents MovedownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MoveupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScheduleItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveDownToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveupToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtEmailAddress As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblEmailCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudEmailAccountToUse As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents lblEmailAccountCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblCalculateTotalTime As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents tmrResetDuration As System.Windows.Forms.Timer
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNotes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
