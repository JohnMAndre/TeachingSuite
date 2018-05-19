<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentDetail))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtExtStudentID = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnShowHistoricalData = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnShowImprovementItems = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAbsentPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblAdjustAbsences = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtClassGroup = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnShowAssignments = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnShowStudentLog = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtClass = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTags = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.nudWritingQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudPlagiarismSeverity = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudMaxAbsences = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.nudAltNumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudPresentationQuality = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblShowSessions = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblShowOutcomes = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkHidden = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.btnShowStudentNotes = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.nudAdminNumber = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtStudentID = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNickName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtLocalName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.pbButtonHighlight = New System.Windows.Forms.PictureBox()
        Me.pnlAssignments = New System.Windows.Forms.Panel()
        Me.llblChangeBaseAssignment = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblMoveAssignment = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.pnlLog = New System.Windows.Forms.Panel()
        Me.llblFindInHistory = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFindInHistory = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.rtbLog = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.olvImprovementItems = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn18 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolDataAdded = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolDateRemoved = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn19 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolPerformanceLevel = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvTeachingSessions = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn26 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn25 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn27 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvAssignments = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn20 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn21 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn34 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn35 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn36 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn37 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn38 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.pnlAttendance = New System.Windows.Forms.Panel()
        Me.llblAddSession = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblRemoveSession = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.pnlNormalAssignments = New System.Windows.Forms.Panel()
        Me.olvNormalAssignments = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn28 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn29 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn33 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn30 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn31 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn32 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGradeAsOfTodayPoints = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblRefreshGradeAsOfToday = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lblGradeAsOfTodayPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.pnlHistoricalData = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lstHistoricalFieldsAvailable = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.olvHistoricalData = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn47 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn48 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn49 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolTimeInForce = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn40 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.pnlOutcomes = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvOutcomes = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.pnlNotes = New System.Windows.Forms.Panel()
        Me.llblFindInNotes = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFindInNotes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.rtbNotes = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn15 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn16 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn17 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn22 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn23 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn24 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OlvColumn39 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn41 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.pbButtonHighlight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAssignments.SuspendLayout()
        Me.pnlLog.SuspendLayout()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvTeachingSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAttendance.SuspendLayout()
        Me.pnlNormalAssignments.SuspendLayout()
        CType(Me.olvNormalAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pnlHistoricalData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHistoricalData.SuspendLayout()
        CType(Me.olvHistoricalData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOutcomes.SuspendLayout()
        CType(Me.olvOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotes.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtExtStudentID)
        Me.KryptonPanel.Controls.Add(Me.btnShowHistoricalData)
        Me.KryptonPanel.Controls.Add(Me.btnShowImprovementItems)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonPanel.Controls.Add(Me.lblAbsentPercent)
        Me.KryptonPanel.Controls.Add(Me.llblAdjustAbsences)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonPanel.Controls.Add(Me.txtClassGroup)
        Me.KryptonPanel.Controls.Add(Me.btnShowAssignments)
        Me.KryptonPanel.Controls.Add(Me.btnShowStudentLog)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel.Controls.Add(Me.txtClass)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel.Controls.Add(Me.txtTags)
        Me.KryptonPanel.Controls.Add(Me.nudWritingQuality)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel.Controls.Add(Me.nudPlagiarismSeverity)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.nudMaxAbsences)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Controls.Add(Me.txtEmail)
        Me.KryptonPanel.Controls.Add(Me.nudAltNumber)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.nudPresentationQuality)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.llblShowSessions)
        Me.KryptonPanel.Controls.Add(Me.llblShowOutcomes)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.chkHidden)
        Me.KryptonPanel.Controls.Add(Me.btnShowStudentNotes)
        Me.KryptonPanel.Controls.Add(Me.nudAdminNumber)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.txtStudentID)
        Me.KryptonPanel.Controls.Add(Me.txtNickName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.btnOK)
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Controls.Add(Me.txtLocalName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.pbButtonHighlight)
        Me.KryptonPanel.Controls.Add(Me.pnlAssignments)
        Me.KryptonPanel.Controls.Add(Me.pnlAttendance)
        Me.KryptonPanel.Controls.Add(Me.pnlNormalAssignments)
        Me.KryptonPanel.Controls.Add(Me.pnlHistoricalData)
        Me.KryptonPanel.Controls.Add(Me.pnlOutcomes)
        Me.KryptonPanel.Controls.Add(Me.pnlNotes)
        Me.KryptonPanel.Controls.Add(Me.pnlLog)
        Me.KryptonPanel.Controls.Add(Me.olvImprovementItems)
        Me.KryptonPanel.Controls.Add(Me.olvTeachingSessions)
        Me.KryptonPanel.Controls.Add(Me.olvAssignments)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(849, 480)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtExtStudentID
        '
        Me.txtExtStudentID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExtStudentID.Location = New System.Drawing.Point(399, 64)
        Me.txtExtStudentID.Name = "txtExtStudentID"
        Me.txtExtStudentID.Size = New System.Drawing.Size(235, 20)
        Me.txtExtStudentID.TabIndex = 11
        '
        'btnShowHistoricalData
        '
        Me.btnShowHistoricalData.Location = New System.Drawing.Point(303, 134)
        Me.btnShowHistoricalData.Name = "btnShowHistoricalData"
        Me.btnShowHistoricalData.Size = New System.Drawing.Size(38, 34)
        Me.btnShowHistoricalData.TabIndex = 95
        Me.ToolTip1.SetToolTip(Me.btnShowHistoricalData, "Show historical data")
        Me.btnShowHistoricalData.Values.Image = Global.Teaching.My.Resources.Resources.info_32
        Me.btnShowHistoricalData.Values.Text = ""
        '
        'btnShowImprovementItems
        '
        Me.btnShowImprovementItems.Location = New System.Drawing.Point(248, 135)
        Me.btnShowImprovementItems.Name = "btnShowImprovementItems"
        Me.btnShowImprovementItems.Size = New System.Drawing.Size(38, 34)
        Me.btnShowImprovementItems.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.btnShowImprovementItems, "Show improvement items")
        Me.btnShowImprovementItems.Values.Image = Global.Teaching.My.Resources.Resources.info_32
        Me.btnShowImprovementItems.Values.Text = ""
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(356, 37)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(38, 20)
        Me.KryptonLabel14.TabIndex = 69
        Me.KryptonLabel14.Values.Text = "Tags:"
        '
        'lblAbsentPercent
        '
        Me.lblAbsentPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAbsentPercent.Location = New System.Drawing.Point(563, 91)
        Me.lblAbsentPercent.Name = "lblAbsentPercent"
        Me.lblAbsentPercent.Size = New System.Drawing.Size(21, 20)
        Me.lblAbsentPercent.TabIndex = 68
        Me.lblAbsentPercent.Values.Text = "%"
        '
        'llblAdjustAbsences
        '
        Me.llblAdjustAbsences.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAdjustAbsences.Location = New System.Drawing.Point(516, 84)
        Me.llblAdjustAbsences.Name = "llblAdjustAbsences"
        Me.llblAdjustAbsences.Size = New System.Drawing.Size(38, 34)
        Me.llblAdjustAbsences.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.llblAdjustAbsences, "Excuse absences")
        Me.llblAdjustAbsences.Values.Image = Global.Teaching.My.Resources.Resources.backup_32
        Me.llblAdjustAbsences.Values.Text = ""
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(339, 12)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(55, 20)
        Me.KryptonLabel13.TabIndex = 67
        Me.KryptonLabel13.Values.Text = "Module:"
        '
        'txtClassGroup
        '
        Me.txtClassGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClassGroup.Location = New System.Drawing.Point(400, 12)
        Me.txtClassGroup.Name = "txtClassGroup"
        Me.txtClassGroup.ReadOnly = True
        Me.txtClassGroup.Size = New System.Drawing.Size(184, 20)
        Me.txtClassGroup.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.txtClassGroup, "Email address (User@Domain.com)")
        '
        'btnShowAssignments
        '
        Me.btnShowAssignments.Location = New System.Drawing.Point(196, 135)
        Me.btnShowAssignments.Name = "btnShowAssignments"
        Me.btnShowAssignments.Size = New System.Drawing.Size(38, 34)
        Me.btnShowAssignments.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.btnShowAssignments, "Show assignments")
        Me.btnShowAssignments.Values.Image = Global.Teaching.My.Resources.Resources.address_book_32
        Me.btnShowAssignments.Values.Text = ""
        '
        'btnShowStudentLog
        '
        Me.btnShowStudentLog.Location = New System.Drawing.Point(144, 135)
        Me.btnShowStudentLog.Name = "btnShowStudentLog"
        Me.btnShowStudentLog.Size = New System.Drawing.Size(38, 34)
        Me.btnShowStudentLog.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.btnShowStudentLog, "Show student log")
        Me.btnShowStudentLog.Values.Image = Global.Teaching.My.Resources.Resources.Log_32
        Me.btnShowStudentLog.Values.Text = ""
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel12.Location = New System.Drawing.Point(590, 12)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel12.TabIndex = 58
        Me.KryptonLabel12.Values.Text = "Class:"
        '
        'txtClass
        '
        Me.txtClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClass.Location = New System.Drawing.Point(637, 12)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.ReadOnly = True
        Me.txtClass.Size = New System.Drawing.Size(200, 20)
        Me.txtClass.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.txtClass, "Email address (User@Domain.com)")
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(299, 64)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel11.TabIndex = 10
        Me.KryptonLabel11.Values.Text = "Ext Student ID:"
        '
        'txtTags
        '
        Me.txtTags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTags.Location = New System.Drawing.Point(399, 38)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(343, 20)
        Me.txtTags.TabIndex = 8
        '
        'nudWritingQuality
        '
        Me.nudWritingQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudWritingQuality.Location = New System.Drawing.Point(590, 118)
        Me.nudWritingQuality.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudWritingQuality.Name = "nudWritingQuality"
        Me.nudWritingQuality.Size = New System.Drawing.Size(44, 22)
        Me.nudWritingQuality.TabIndex = 54
        Me.nudWritingQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudWritingQuality.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudWritingQuality, "The writing quality of this student")
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel10.Location = New System.Drawing.Point(531, 118)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel10.TabIndex = 53
        Me.KryptonLabel10.Values.Text = "Writing:"
        '
        'nudPlagiarismSeverity
        '
        Me.nudPlagiarismSeverity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPlagiarismSeverity.Location = New System.Drawing.Point(463, 116)
        Me.nudPlagiarismSeverity.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudPlagiarismSeverity.Name = "nudPlagiarismSeverity"
        Me.nudPlagiarismSeverity.Size = New System.Drawing.Size(44, 22)
        Me.nudPlagiarismSeverity.TabIndex = 51
        Me.nudPlagiarismSeverity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPlagiarismSeverity.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudPlagiarismSeverity, "0=not concerned, 5=watch 5 next asmts for plagiarism")
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel9.Location = New System.Drawing.Point(420, 116)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(37, 20)
        Me.KryptonLabel9.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.KryptonLabel9, "Plagiarism severity")
        Me.KryptonLabel9.Values.Text = "Plag:"
        '
        'nudMaxAbsences
        '
        Me.nudMaxAbsences.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudMaxAbsences.Location = New System.Drawing.Point(590, 90)
        Me.nudMaxAbsences.Name = "nudMaxAbsences"
        Me.nudMaxAbsences.Size = New System.Drawing.Size(44, 22)
        Me.nudMaxAbsences.TabIndex = 38
        Me.nudMaxAbsences.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxAbsences.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudMaxAbsences, "Current absences (for current period)")
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(12, 90)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(42, 20)
        Me.KryptonLabel8.TabIndex = 6
        Me.KryptonLabel8.Values.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(93, 90)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(245, 20)
        Me.txtEmail.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtEmail, "Email address (User@Domain.com)")
        '
        'nudAltNumber
        '
        Me.nudAltNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudAltNumber.Location = New System.Drawing.Point(748, 90)
        Me.nudAltNumber.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudAltNumber.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nudAltNumber.Name = "nudAltNumber"
        Me.nudAltNumber.Size = New System.Drawing.Size(89, 22)
        Me.nudAltNumber.TabIndex = 48
        Me.nudAltNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAltNumber.ThousandsSeparator = True
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel7.Location = New System.Drawing.Point(703, 90)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel7.TabIndex = 47
        Me.KryptonLabel7.Values.Text = "Alt #:"
        '
        'nudPresentationQuality
        '
        Me.nudPresentationQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPresentationQuality.Location = New System.Drawing.Point(748, 118)
        Me.nudPresentationQuality.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPresentationQuality.Name = "nudPresentationQuality"
        Me.nudPresentationQuality.Size = New System.Drawing.Size(89, 22)
        Me.nudPresentationQuality.TabIndex = 46
        Me.nudPresentationQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPresentationQuality.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.nudPresentationQuality, "The presentation quality of this student.")
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel6.Location = New System.Drawing.Point(655, 118)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(87, 20)
        Me.KryptonLabel6.TabIndex = 45
        Me.KryptonLabel6.Values.Text = "Presentations:"
        '
        'llblShowSessions
        '
        Me.llblShowSessions.Location = New System.Drawing.Point(50, 135)
        Me.llblShowSessions.Name = "llblShowSessions"
        Me.llblShowSessions.Size = New System.Drawing.Size(38, 34)
        Me.llblShowSessions.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.llblShowSessions, "Show attendance")
        Me.llblShowSessions.Values.Image = Global.Teaching.My.Resources.Resources.smileystar_32
        Me.llblShowSessions.Values.Text = ""
        '
        'llblShowOutcomes
        '
        Me.llblShowOutcomes.Location = New System.Drawing.Point(4, 135)
        Me.llblShowOutcomes.Name = "llblShowOutcomes"
        Me.llblShowOutcomes.Size = New System.Drawing.Size(38, 34)
        Me.llblShowOutcomes.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.llblShowOutcomes, "Show outcomes (BTEC only)")
        Me.llblShowOutcomes.Values.Image = Global.Teaching.My.Resources.Resources.network_32
        Me.llblShowOutcomes.Values.Text = ""
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel5.Location = New System.Drawing.Point(420, 90)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(108, 20)
        Me.KryptonLabel5.TabIndex = 40
        Me.KryptonLabel5.Values.Text = "Current Absenses:"
        '
        'chkHidden
        '
        Me.chkHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkHidden.AutoSize = False
        Me.chkHidden.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkHidden.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkHidden.Location = New System.Drawing.Point(748, 38)
        Me.chkHidden.Name = "chkHidden"
        Me.chkHidden.Size = New System.Drawing.Size(82, 20)
        Me.chkHidden.TabIndex = 9
        Me.chkHidden.Text = "Hidden:"
        Me.ToolTip1.SetToolTip(Me.chkHidden, "Check to hide student, based on your settings")
        Me.chkHidden.Values.Text = "Hidden:"
        '
        'btnShowStudentNotes
        '
        Me.btnShowStudentNotes.Location = New System.Drawing.Point(98, 135)
        Me.btnShowStudentNotes.Name = "btnShowStudentNotes"
        Me.btnShowStudentNotes.Size = New System.Drawing.Size(38, 34)
        Me.btnShowStudentNotes.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.btnShowStudentNotes, "Show notes")
        Me.btnShowStudentNotes.Values.Image = Global.Teaching.My.Resources.Resources.notes_32
        Me.btnShowStudentNotes.Values.Text = ""
        '
        'nudAdminNumber
        '
        Me.nudAdminNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudAdminNumber.Location = New System.Drawing.Point(748, 64)
        Me.nudAdminNumber.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudAdminNumber.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nudAdminNumber.Name = "nudAdminNumber"
        Me.nudAdminNumber.Size = New System.Drawing.Size(89, 22)
        Me.nudAdminNumber.TabIndex = 33
        Me.nudAdminNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAdminNumber.ThousandsSeparator = True
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel4.Location = New System.Drawing.Point(682, 64)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel4.TabIndex = 32
        Me.KryptonLabel4.Values.Text = "Admin #:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 64)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Values.Text = "Student ID:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(93, 64)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(184, 20)
        Me.txtStudentID.TabIndex = 5
        '
        'txtNickName
        '
        Me.txtNickName.Location = New System.Drawing.Point(93, 38)
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.Size = New System.Drawing.Size(245, 20)
        Me.txtNickName.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 38)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Values.Text = "NickName:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOK.Location = New System.Drawing.Point(551, 144)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(424, 144)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'txtLocalName
        '
        Me.txtLocalName.Location = New System.Drawing.Point(93, 12)
        Me.txtLocalName.Name = "txtLocalName"
        Me.txtLocalName.Size = New System.Drawing.Size(245, 20)
        Me.txtLocalName.TabIndex = 1
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(75, 20)
        Me.KryptonLabel3.TabIndex = 0
        Me.KryptonLabel3.Values.Text = "Local name:"
        '
        'pbButtonHighlight
        '
        Me.pbButtonHighlight.BackColor = System.Drawing.Color.Blue
        Me.pbButtonHighlight.Location = New System.Drawing.Point(189, 127)
        Me.pbButtonHighlight.Name = "pbButtonHighlight"
        Me.pbButtonHighlight.Size = New System.Drawing.Size(53, 50)
        Me.pbButtonHighlight.TabIndex = 61
        Me.pbButtonHighlight.TabStop = False
        '
        'pnlAssignments
        '
        Me.pnlAssignments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAssignments.BackColor = System.Drawing.Color.Transparent
        Me.pnlAssignments.Controls.Add(Me.llblChangeBaseAssignment)
        Me.pnlAssignments.Controls.Add(Me.llblMoveAssignment)
        Me.pnlAssignments.Location = New System.Drawing.Point(768, 150)
        Me.pnlAssignments.Name = "pnlAssignments"
        Me.pnlAssignments.Size = New System.Drawing.Size(76, 24)
        Me.pnlAssignments.TabIndex = 65
        '
        'llblChangeBaseAssignment
        '
        Me.llblChangeBaseAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblChangeBaseAssignment.Location = New System.Drawing.Point(47, 3)
        Me.llblChangeBaseAssignment.Name = "llblChangeBaseAssignment"
        Me.llblChangeBaseAssignment.Size = New System.Drawing.Size(22, 18)
        Me.llblChangeBaseAssignment.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.llblChangeBaseAssignment, "Change base assignment")
        Me.llblChangeBaseAssignment.Values.Image = Global.Teaching.My.Resources.Resources.Import_16
        Me.llblChangeBaseAssignment.Values.Text = ""
        '
        'llblMoveAssignment
        '
        Me.llblMoveAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblMoveAssignment.Location = New System.Drawing.Point(5, 3)
        Me.llblMoveAssignment.Name = "llblMoveAssignment"
        Me.llblMoveAssignment.Size = New System.Drawing.Size(22, 18)
        Me.llblMoveAssignment.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.llblMoveAssignment, "Move selected assignment to another student")
        Me.llblMoveAssignment.Values.Image = Global.Teaching.My.Resources.Resources.Arrow_left_16
        Me.llblMoveAssignment.Values.Text = ""
        '
        'pnlLog
        '
        Me.pnlLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLog.BackColor = System.Drawing.Color.Transparent
        Me.pnlLog.Controls.Add(Me.llblFindInHistory)
        Me.pnlLog.Controls.Add(Me.KryptonLabel16)
        Me.pnlLog.Controls.Add(Me.txtFindInHistory)
        Me.pnlLog.Controls.Add(Me.rtbLog)
        Me.pnlLog.Location = New System.Drawing.Point(0, 174)
        Me.pnlLog.Name = "pnlLog"
        Me.pnlLog.Size = New System.Drawing.Size(849, 306)
        Me.pnlLog.TabIndex = 97
        '
        'llblFindInHistory
        '
        Me.llblFindInHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblFindInHistory.Location = New System.Drawing.Point(332, 282)
        Me.llblFindInHistory.Name = "llblFindInHistory"
        Me.llblFindInHistory.Size = New System.Drawing.Size(22, 18)
        Me.llblFindInHistory.TabIndex = 38
        Me.llblFindInHistory.Values.Image = Global.Teaching.My.Resources.Resources.detective_16
        Me.llblFindInHistory.Values.Text = ""
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel16.Location = New System.Drawing.Point(12, 282)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel16.TabIndex = 36
        Me.KryptonLabel16.Values.Text = "Find:"
        '
        'txtFindInHistory
        '
        Me.txtFindInHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFindInHistory.Location = New System.Drawing.Point(55, 282)
        Me.txtFindInHistory.Name = "txtFindInHistory"
        Me.txtFindInHistory.Size = New System.Drawing.Size(245, 20)
        Me.txtFindInHistory.TabIndex = 37
        '
        'rtbLog
        '
        Me.rtbLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbLog.HideSelection = False
        Me.rtbLog.Location = New System.Drawing.Point(1, 1)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.ReadOnly = True
        Me.rtbLog.Size = New System.Drawing.Size(847, 282)
        Me.rtbLog.TabIndex = 60
        Me.rtbLog.Text = ""
        Me.rtbLog.Visible = False
        '
        'olvImprovementItems
        '
        Me.olvImprovementItems.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn18)
        Me.olvImprovementItems.AllColumns.Add(Me.olvcolDataAdded)
        Me.olvImprovementItems.AllColumns.Add(Me.olvcolDateRemoved)
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn19)
        Me.olvImprovementItems.AllColumns.Add(Me.olvcolPerformanceLevel)
        Me.olvImprovementItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvImprovementItems.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvImprovementItems.CellEditUseWholeCell = False
        Me.olvImprovementItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn18, Me.olvcolDataAdded, Me.olvcolDateRemoved, Me.OlvColumn19, Me.olvcolPerformanceLevel})
        Me.olvImprovementItems.CopySelectionOnControlC = False
        Me.olvImprovementItems.CopySelectionOnControlCUsesDragSource = False
        Me.olvImprovementItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvImprovementItems.EmptyListMsg = "No improvement items"
        Me.olvImprovementItems.FullRowSelect = True
        Me.olvImprovementItems.Location = New System.Drawing.Point(0, 174)
        Me.olvImprovementItems.MultiSelect = False
        Me.olvImprovementItems.Name = "olvImprovementItems"
        Me.olvImprovementItems.ShowGroups = False
        Me.olvImprovementItems.ShowImagesOnSubItems = True
        Me.olvImprovementItems.ShowItemToolTips = True
        Me.olvImprovementItems.Size = New System.Drawing.Size(847, 305)
        Me.olvImprovementItems.TabIndex = 93
        Me.olvImprovementItems.UseCompatibleStateImageBehavior = False
        Me.olvImprovementItems.UseFiltering = True
        Me.olvImprovementItems.View = System.Windows.Forms.View.Details
        '
        'OlvColumn18
        '
        Me.OlvColumn18.AspectName = "BaseImprovementItem.Name"
        Me.OlvColumn18.AspectToStringFormat = ""
        Me.OlvColumn18.AutoCompleteEditor = False
        Me.OlvColumn18.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn18.IsEditable = False
        Me.OlvColumn18.Text = "Name"
        Me.OlvColumn18.Width = 124
        '
        'olvcolDataAdded
        '
        Me.olvcolDataAdded.AspectName = "DateAdded"
        Me.olvcolDataAdded.AspectToStringFormat = "{0:d}"
        Me.olvcolDataAdded.AutoCompleteEditor = False
        Me.olvcolDataAdded.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.olvcolDataAdded.DisplayIndex = 2
        Me.olvcolDataAdded.Text = "Added"
        Me.olvcolDataAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolDataAdded.Width = 94
        '
        'olvcolDateRemoved
        '
        Me.olvcolDateRemoved.AspectName = "DateLastIncluded"
        Me.olvcolDateRemoved.AspectToStringFormat = "{0:d}"
        Me.olvcolDateRemoved.AutoCompleteEditor = False
        Me.olvcolDateRemoved.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.olvcolDateRemoved.DisplayIndex = 3
        Me.olvcolDateRemoved.Text = "Last time"
        Me.olvcolDateRemoved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolDateRemoved.ToolTipText = "Date this was last included in student feedback"
        Me.olvcolDateRemoved.Width = 95
        '
        'OlvColumn19
        '
        Me.OlvColumn19.AspectName = "BaseImprovementItem.Description"
        Me.OlvColumn19.AutoCompleteEditor = False
        Me.OlvColumn19.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn19.DisplayIndex = 4
        Me.OlvColumn19.IsEditable = False
        Me.OlvColumn19.Text = "Description"
        Me.OlvColumn19.Width = 270
        '
        'olvcolPerformanceLevel
        '
        Me.olvcolPerformanceLevel.AspectName = "PerformanceLevel"
        Me.olvcolPerformanceLevel.AutoCompleteEditor = False
        Me.olvcolPerformanceLevel.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.olvcolPerformanceLevel.DisplayIndex = 1
        Me.olvcolPerformanceLevel.MaximumWidth = 100
        Me.olvcolPerformanceLevel.MinimumWidth = 50
        Me.olvcolPerformanceLevel.Text = "Perf"
        Me.olvcolPerformanceLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolPerformanceLevel.ToolTipText = "Performance level (0-5)"
        Me.olvcolPerformanceLevel.Width = 65
        '
        'olvTeachingSessions
        '
        Me.olvTeachingSessions.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvTeachingSessions.AllColumns.Add(Me.OlvColumn26)
        Me.olvTeachingSessions.AllColumns.Add(Me.OlvColumn1)
        Me.olvTeachingSessions.AllColumns.Add(Me.OlvColumn2)
        Me.olvTeachingSessions.AllColumns.Add(Me.OlvColumn25)
        Me.olvTeachingSessions.AllColumns.Add(Me.OlvColumn27)
        Me.olvTeachingSessions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvTeachingSessions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvTeachingSessions.CellEditUseWholeCell = False
        Me.olvTeachingSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn26, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn25, Me.OlvColumn27})
        Me.olvTeachingSessions.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvTeachingSessions.FullRowSelect = True
        Me.olvTeachingSessions.Location = New System.Drawing.Point(2, 175)
        Me.olvTeachingSessions.Name = "olvTeachingSessions"
        Me.olvTeachingSessions.ShowGroups = False
        Me.olvTeachingSessions.Size = New System.Drawing.Size(846, 305)
        Me.olvTeachingSessions.TabIndex = 4
        Me.olvTeachingSessions.UseCompatibleStateImageBehavior = False
        Me.olvTeachingSessions.UseFiltering = True
        Me.olvTeachingSessions.View = System.Windows.Forms.View.Details
        '
        'OlvColumn26
        '
        Me.OlvColumn26.AspectName = "TeachingSession.StartDate.DayOfWeek"
        Me.OlvColumn26.AutoCompleteEditor = False
        Me.OlvColumn26.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn26.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn26.IsEditable = False
        Me.OlvColumn26.Text = "Day"
        Me.OlvColumn26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn26.Width = 90
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "TeachingSession.StartDate"
        Me.OlvColumn1.AspectToStringFormat = "{0:d}"
        Me.OlvColumn1.AutoCompleteEditor = False
        Me.OlvColumn1.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Text = "Date"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Width = 201
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "TeachingSession.AttendenceStatus"
        Me.OlvColumn2.AutoCompleteEditor = False
        Me.OlvColumn2.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn2.Text = "Status"
        Me.OlvColumn2.Width = 100
        '
        'OlvColumn25
        '
        Me.OlvColumn25.AspectName = "TeachingSession.Notes"
        Me.OlvColumn25.AutoCompleteEditor = False
        Me.OlvColumn25.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn25.Text = "Notes"
        Me.OlvColumn25.Width = 79
        '
        'OlvColumn27
        '
        Me.OlvColumn27.AspectName = "ActualSessionItem.Topic"
        Me.OlvColumn27.AutoCompleteEditor = False
        Me.OlvColumn27.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn27.IsEditable = False
        Me.OlvColumn27.Text = "Topic"
        Me.OlvColumn27.Width = 234
        '
        'olvAssignments
        '
        Me.olvAssignments.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn13)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn20)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn21)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn34)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn35)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn36)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn37)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn38)
        Me.olvAssignments.AllColumns.Add(Me.OlvColumn39)
        Me.olvAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvAssignments.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvAssignments.CellEditUseWholeCell = False
        Me.olvAssignments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn13, Me.OlvColumn20, Me.OlvColumn21, Me.OlvColumn34, Me.OlvColumn35, Me.OlvColumn36, Me.OlvColumn37, Me.OlvColumn38, Me.OlvColumn39})
        Me.olvAssignments.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvAssignments.FullRowSelect = True
        Me.olvAssignments.Location = New System.Drawing.Point(0, 175)
        Me.olvAssignments.Name = "olvAssignments"
        Me.olvAssignments.ShowGroups = False
        Me.olvAssignments.ShowImagesOnSubItems = True
        Me.olvAssignments.Size = New System.Drawing.Size(848, 304)
        Me.olvAssignments.TabIndex = 63
        Me.olvAssignments.UseCompatibleStateImageBehavior = False
        Me.olvAssignments.UseFiltering = True
        Me.olvAssignments.UseSubItemCheckBoxes = True
        Me.olvAssignments.View = System.Windows.Forms.View.Details
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "BaseAssignment.Name"
        Me.OlvColumn13.AutoCompleteEditor = False
        Me.OlvColumn13.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn13.IsEditable = False
        Me.OlvColumn13.Text = "Name"
        Me.OlvColumn13.Width = 157
        '
        'OlvColumn20
        '
        Me.OlvColumn20.AspectName = "AvailableOutcomes"
        Me.OlvColumn20.AutoCompleteEditor = False
        Me.OlvColumn20.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn20.Text = "Outcomes"
        Me.OlvColumn20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn21
        '
        Me.OlvColumn21.AspectName = "PassedOutcomesAtPass"
        Me.OlvColumn21.AutoCompleteEditor = False
        Me.OlvColumn21.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn21.Text = "Passed"
        Me.OlvColumn21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn34
        '
        Me.OlvColumn34.AspectName = "AchievedMerit"
        Me.OlvColumn34.AutoCompleteEditor = False
        Me.OlvColumn34.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn34.CheckBoxes = True
        Me.OlvColumn34.Text = "Merit"
        Me.OlvColumn34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn35
        '
        Me.OlvColumn35.AspectName = "AchievedDistinction"
        Me.OlvColumn35.AutoCompleteEditor = False
        Me.OlvColumn35.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn35.CheckBoxes = True
        Me.OlvColumn35.Text = "Distinction"
        Me.OlvColumn35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn35.Width = 74
        '
        'OlvColumn36
        '
        Me.OlvColumn36.AspectName = "FirstTryPrint"
        Me.OlvColumn36.AutoCompleteEditor = False
        Me.OlvColumn36.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn36.Text = "1st"
        Me.OlvColumn36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn36.Width = 83
        '
        'OlvColumn37
        '
        Me.OlvColumn37.AspectName = "SecondTryPrint"
        Me.OlvColumn37.AutoCompleteEditor = False
        Me.OlvColumn37.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn37.Text = "2nd"
        Me.OlvColumn37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn37.Width = 84
        '
        'OlvColumn38
        '
        Me.OlvColumn38.AspectName = "ThirdTryPrint"
        Me.OlvColumn38.AutoCompleteEditor = False
        Me.OlvColumn38.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn38.Text = "3rd"
        Me.OlvColumn38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn38.Width = 86
        '
        'pnlAttendance
        '
        Me.pnlAttendance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAttendance.BackColor = System.Drawing.Color.Transparent
        Me.pnlAttendance.Controls.Add(Me.llblAddSession)
        Me.pnlAttendance.Controls.Add(Me.llblRemoveSession)
        Me.pnlAttendance.Location = New System.Drawing.Point(768, 150)
        Me.pnlAttendance.Name = "pnlAttendance"
        Me.pnlAttendance.Size = New System.Drawing.Size(76, 24)
        Me.pnlAttendance.TabIndex = 64
        '
        'llblAddSession
        '
        Me.llblAddSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddSession.Location = New System.Drawing.Point(21, 3)
        Me.llblAddSession.Name = "llblAddSession"
        Me.llblAddSession.Size = New System.Drawing.Size(22, 18)
        Me.llblAddSession.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.llblAddSession, "Add session")
        Me.llblAddSession.Values.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.llblAddSession.Values.Text = ""
        '
        'llblRemoveSession
        '
        Me.llblRemoveSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRemoveSession.Location = New System.Drawing.Point(49, 3)
        Me.llblRemoveSession.Name = "llblRemoveSession"
        Me.llblRemoveSession.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveSession.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.llblRemoveSession, "Delete session")
        Me.llblRemoveSession.Values.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.llblRemoveSession.Values.Text = ""
        '
        'pnlNormalAssignments
        '
        Me.pnlNormalAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNormalAssignments.BackColor = System.Drawing.Color.Transparent
        Me.pnlNormalAssignments.Controls.Add(Me.olvNormalAssignments)
        Me.pnlNormalAssignments.Controls.Add(Me.Panel2)
        Me.pnlNormalAssignments.Location = New System.Drawing.Point(0, 175)
        Me.pnlNormalAssignments.Name = "pnlNormalAssignments"
        Me.pnlNormalAssignments.Size = New System.Drawing.Size(849, 305)
        Me.pnlNormalAssignments.TabIndex = 65
        '
        'olvNormalAssignments
        '
        Me.olvNormalAssignments.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvNormalAssignments.AllColumns.Add(Me.OlvColumn28)
        Me.olvNormalAssignments.AllColumns.Add(Me.OlvColumn29)
        Me.olvNormalAssignments.AllColumns.Add(Me.OlvColumn33)
        Me.olvNormalAssignments.AllColumns.Add(Me.OlvColumn30)
        Me.olvNormalAssignments.AllColumns.Add(Me.OlvColumn31)
        Me.olvNormalAssignments.AllColumns.Add(Me.OlvColumn32)
        Me.olvNormalAssignments.AllColumns.Add(Me.OlvColumn41)
        Me.olvNormalAssignments.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvNormalAssignments.CellEditUseWholeCell = False
        Me.olvNormalAssignments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn28, Me.OlvColumn29, Me.OlvColumn33, Me.OlvColumn30, Me.OlvColumn31, Me.OlvColumn32, Me.OlvColumn41})
        Me.olvNormalAssignments.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvNormalAssignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvNormalAssignments.FullRowSelect = True
        Me.olvNormalAssignments.Location = New System.Drawing.Point(0, 0)
        Me.olvNormalAssignments.Name = "olvNormalAssignments"
        Me.olvNormalAssignments.ShowGroups = False
        Me.olvNormalAssignments.ShowImagesOnSubItems = True
        Me.olvNormalAssignments.Size = New System.Drawing.Size(849, 261)
        Me.olvNormalAssignments.TabIndex = 71
        Me.olvNormalAssignments.UseCompatibleStateImageBehavior = False
        Me.olvNormalAssignments.UseFiltering = True
        Me.olvNormalAssignments.UseSubItemCheckBoxes = True
        Me.olvNormalAssignments.View = System.Windows.Forms.View.Details
        '
        'OlvColumn28
        '
        Me.OlvColumn28.AspectName = "BaseAssignment.Name"
        Me.OlvColumn28.AutoCompleteEditor = False
        Me.OlvColumn28.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn28.IsEditable = False
        Me.OlvColumn28.Text = "Name"
        Me.OlvColumn28.Width = 122
        '
        'OlvColumn29
        '
        Me.OlvColumn29.AspectName = "BaseAssignment.MaxPoints"
        Me.OlvColumn29.AutoCompleteEditor = False
        Me.OlvColumn29.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn29.Text = "Max"
        Me.OlvColumn29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn29.Width = 91
        '
        'OlvColumn33
        '
        Me.OlvColumn33.AspectName = "BaseAssignment.Weighting"
        Me.OlvColumn33.AspectToStringFormat = "{0:0%}"
        Me.OlvColumn33.AutoCompleteEditor = False
        Me.OlvColumn33.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn33.Text = "Weight"
        Me.OlvColumn33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn33.Width = 74
        '
        'OlvColumn30
        '
        Me.OlvColumn30.AspectName = "FirstTryPoints"
        Me.OlvColumn30.AutoCompleteEditor = False
        Me.OlvColumn30.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn30.Text = "1st Try"
        Me.OlvColumn30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn30.Width = 86
        '
        'OlvColumn31
        '
        Me.OlvColumn31.AspectName = "SecondTryPoints"
        Me.OlvColumn31.AutoCompleteEditor = False
        Me.OlvColumn31.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn31.Text = "2nd Try"
        Me.OlvColumn31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn31.Width = 94
        '
        'OlvColumn32
        '
        Me.OlvColumn32.AspectName = "ThirdTryPoints"
        Me.OlvColumn32.AutoCompleteEditor = False
        Me.OlvColumn32.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn32.Text = "3rd Try"
        Me.OlvColumn32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn32.Width = 82
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblGradeAsOfTodayPoints)
        Me.Panel2.Controls.Add(Me.llblRefreshGradeAsOfToday)
        Me.Panel2.Controls.Add(Me.lblGradeAsOfTodayPercent)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 261)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(849, 44)
        Me.Panel2.TabIndex = 66
        '
        'lblGradeAsOfTodayPoints
        '
        Me.lblGradeAsOfTodayPoints.Location = New System.Drawing.Point(248, 4)
        Me.lblGradeAsOfTodayPoints.Name = "lblGradeAsOfTodayPoints"
        Me.lblGradeAsOfTodayPoints.Size = New System.Drawing.Size(17, 20)
        Me.lblGradeAsOfTodayPoints.TabIndex = 140
        Me.lblGradeAsOfTodayPoints.Values.Text = "0"
        '
        'llblRefreshGradeAsOfToday
        '
        Me.llblRefreshGradeAsOfToday.Location = New System.Drawing.Point(9, 4)
        Me.llblRefreshGradeAsOfToday.Name = "llblRefreshGradeAsOfToday"
        Me.llblRefreshGradeAsOfToday.Size = New System.Drawing.Size(88, 20)
        Me.llblRefreshGradeAsOfToday.TabIndex = 139
        Me.ToolTip1.SetToolTip(Me.llblRefreshGradeAsOfToday, "Click to refresh")
        Me.llblRefreshGradeAsOfToday.Values.Text = "Grade (today):"
        '
        'lblGradeAsOfTodayPercent
        '
        Me.lblGradeAsOfTodayPercent.Location = New System.Drawing.Point(112, 3)
        Me.lblGradeAsOfTodayPercent.Name = "lblGradeAsOfTodayPercent"
        Me.lblGradeAsOfTodayPercent.Size = New System.Drawing.Size(17, 20)
        Me.lblGradeAsOfTodayPercent.TabIndex = 49
        Me.lblGradeAsOfTodayPercent.Values.Text = "0"
        '
        'pnlHistoricalData
        '
        Me.pnlHistoricalData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHistoricalData.Controls.Add(Me.lstHistoricalFieldsAvailable)
        Me.pnlHistoricalData.Controls.Add(Me.olvHistoricalData)
        Me.pnlHistoricalData.Location = New System.Drawing.Point(2, 174)
        Me.pnlHistoricalData.Name = "pnlHistoricalData"
        Me.pnlHistoricalData.Size = New System.Drawing.Size(848, 305)
        Me.pnlHistoricalData.TabIndex = 45
        '
        'lstHistoricalFieldsAvailable
        '
        Me.lstHistoricalFieldsAvailable.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstHistoricalFieldsAvailable.Location = New System.Drawing.Point(0, 0)
        Me.lstHistoricalFieldsAvailable.Name = "lstHistoricalFieldsAvailable"
        Me.lstHistoricalFieldsAvailable.Size = New System.Drawing.Size(171, 305)
        Me.lstHistoricalFieldsAvailable.TabIndex = 42
        '
        'olvHistoricalData
        '
        Me.olvHistoricalData.AllColumns.Add(Me.OlvColumn47)
        Me.olvHistoricalData.AllColumns.Add(Me.OlvColumn48)
        Me.olvHistoricalData.AllColumns.Add(Me.OlvColumn49)
        Me.olvHistoricalData.AllColumns.Add(Me.olvcolTimeInForce)
        Me.olvHistoricalData.AllColumns.Add(Me.OlvColumn40)
        Me.olvHistoricalData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvHistoricalData.CellEditUseWholeCell = False
        Me.olvHistoricalData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn47, Me.OlvColumn48, Me.OlvColumn49, Me.olvcolTimeInForce, Me.OlvColumn40})
        Me.olvHistoricalData.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvHistoricalData.FullRowSelect = True
        Me.olvHistoricalData.Location = New System.Drawing.Point(177, 0)
        Me.olvHistoricalData.Name = "olvHistoricalData"
        Me.olvHistoricalData.ShowGroups = False
        Me.olvHistoricalData.Size = New System.Drawing.Size(672, 305)
        Me.olvHistoricalData.TabIndex = 41
        Me.olvHistoricalData.UseCompatibleStateImageBehavior = False
        Me.olvHistoricalData.UseFiltering = True
        Me.olvHistoricalData.View = System.Windows.Forms.View.Details
        '
        'OlvColumn47
        '
        Me.OlvColumn47.AspectName = "FieldName"
        Me.OlvColumn47.Text = "Attribute"
        Me.OlvColumn47.Width = 133
        '
        'OlvColumn48
        '
        Me.OlvColumn48.AspectName = "FromOldValue"
        Me.OlvColumn48.Text = "Old"
        Me.OlvColumn48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn48.Width = 132
        '
        'OlvColumn49
        '
        Me.OlvColumn49.AspectName = "ToNewValue"
        Me.OlvColumn49.Text = "New"
        Me.OlvColumn49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn49.Width = 117
        '
        'olvcolTimeInForce
        '
        Me.olvcolTimeInForce.AspectName = "TimeInForce"
        Me.olvcolTimeInForce.AspectToStringFormat = "{0:d'd 'h'h 'm'm 's's'}"
        Me.olvcolTimeInForce.Text = "In force"
        Me.olvcolTimeInForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolTimeInForce.Width = 107
        '
        'OlvColumn40
        '
        Me.OlvColumn40.AspectName = "ChangeDate"
        Me.OlvColumn40.Text = "Changed"
        Me.OlvColumn40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn40.Width = 124
        '
        'pnlOutcomes
        '
        Me.pnlOutcomes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOutcomes.Controls.Add(Me.olvOutcomes)
        Me.pnlOutcomes.Location = New System.Drawing.Point(0, 175)
        Me.pnlOutcomes.Name = "pnlOutcomes"
        Me.pnlOutcomes.Size = New System.Drawing.Size(848, 305)
        Me.pnlOutcomes.TabIndex = 44
        '
        'olvOutcomes
        '
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn5)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn6)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn7)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn8)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn9)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn10)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn11)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn12)
        Me.olvOutcomes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvOutcomes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvOutcomes.CellEditUseWholeCell = False
        Me.olvOutcomes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn11, Me.OlvColumn12})
        Me.olvOutcomes.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvOutcomes.FullRowSelect = True
        Me.olvOutcomes.Location = New System.Drawing.Point(0, 0)
        Me.olvOutcomes.Name = "olvOutcomes"
        Me.olvOutcomes.ShowGroups = False
        Me.olvOutcomes.Size = New System.Drawing.Size(849, 305)
        Me.olvOutcomes.TabIndex = 41
        Me.olvOutcomes.UseCompatibleStateImageBehavior = False
        Me.olvOutcomes.UseFiltering = True
        Me.olvOutcomes.View = System.Windows.Forms.View.Details
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "Name"
        Me.OlvColumn5.AutoCompleteEditor = False
        Me.OlvColumn5.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn5.IsEditable = False
        Me.OlvColumn5.Text = "Name"
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "Description"
        Me.OlvColumn6.AutoCompleteEditor = False
        Me.OlvColumn6.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Description"
        Me.OlvColumn6.Width = 157
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "FirstTryStatus"
        Me.OlvColumn7.AutoCompleteEditor = False
        Me.OlvColumn7.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn7.Text = "First"
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "FirstTryComments"
        Me.OlvColumn8.AutoCompleteEditor = False
        Me.OlvColumn8.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn8.Text = "Feedback"
        Me.OlvColumn8.Width = 130
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "SecondTryStatus"
        Me.OlvColumn9.AutoCompleteEditor = False
        Me.OlvColumn9.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn9.Text = "Rework"
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "SecondTryComments"
        Me.OlvColumn10.AutoCompleteEditor = False
        Me.OlvColumn10.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn10.Text = "Feedback"
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "ThirdTryStatus"
        Me.OlvColumn11.AutoCompleteEditor = False
        Me.OlvColumn11.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn11.Text = "2nd Rework"
        Me.OlvColumn11.Width = 100
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "ThirdTryComments"
        Me.OlvColumn12.AutoCompleteEditor = False
        Me.OlvColumn12.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn12.Text = "Feedback"
        '
        'pnlNotes
        '
        Me.pnlNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNotes.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotes.Controls.Add(Me.llblFindInNotes)
        Me.pnlNotes.Controls.Add(Me.KryptonLabel15)
        Me.pnlNotes.Controls.Add(Me.txtFindInNotes)
        Me.pnlNotes.Controls.Add(Me.rtbNotes)
        Me.pnlNotes.Location = New System.Drawing.Point(1, 173)
        Me.pnlNotes.Name = "pnlNotes"
        Me.pnlNotes.Size = New System.Drawing.Size(847, 308)
        Me.pnlNotes.TabIndex = 96
        '
        'llblFindInNotes
        '
        Me.llblFindInNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblFindInNotes.Location = New System.Drawing.Point(298, 287)
        Me.llblFindInNotes.Name = "llblFindInNotes"
        Me.llblFindInNotes.Size = New System.Drawing.Size(22, 18)
        Me.llblFindInNotes.TabIndex = 38
        Me.llblFindInNotes.Values.Image = Global.Teaching.My.Resources.Resources.detective_16
        Me.llblFindInNotes.Values.Text = ""
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel15.Location = New System.Drawing.Point(8, 286)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel15.TabIndex = 36
        Me.KryptonLabel15.Values.Text = "Find:"
        '
        'txtFindInNotes
        '
        Me.txtFindInNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFindInNotes.Location = New System.Drawing.Point(51, 288)
        Me.txtFindInNotes.Name = "txtFindInNotes"
        Me.txtFindInNotes.Size = New System.Drawing.Size(245, 20)
        Me.txtFindInNotes.TabIndex = 37
        '
        'rtbNotes
        '
        Me.rtbNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbNotes.HideSelection = False
        Me.rtbNotes.Location = New System.Drawing.Point(-1, 1)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(846, 285)
        Me.rtbNotes.TabIndex = 35
        Me.rtbNotes.Text = ""
        Me.rtbNotes.Visible = False
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "AvailableOutcomes"
        Me.OlvColumn14.DisplayIndex = 1
        Me.OlvColumn14.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.IsEditable = False
        Me.OlvColumn14.Text = "Outcomes"
        Me.OlvColumn14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "PassedOutcomes"
        Me.OlvColumn15.DisplayIndex = 2
        Me.OlvColumn15.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn15.IsEditable = False
        Me.OlvColumn15.Text = "Passed"
        Me.OlvColumn15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "AchievedMerit"
        Me.OlvColumn16.CheckBoxes = True
        Me.OlvColumn16.DisplayIndex = 3
        Me.OlvColumn16.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn16.Text = "Merit"
        Me.OlvColumn16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "AchievedDistinction"
        Me.OlvColumn17.CheckBoxes = True
        Me.OlvColumn17.DisplayIndex = 4
        Me.OlvColumn17.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Text = "Distinction"
        Me.OlvColumn17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Width = 80
        '
        'OlvColumn22
        '
        Me.OlvColumn22.AspectName = "FirstTryPrint"
        Me.OlvColumn22.DisplayIndex = 5
        Me.OlvColumn22.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn22.IsEditable = False
        Me.OlvColumn22.Text = "1st"
        Me.OlvColumn22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn22.Width = 80
        '
        'OlvColumn23
        '
        Me.OlvColumn23.AspectName = "SecondTryPrint"
        Me.OlvColumn23.DisplayIndex = 6
        Me.OlvColumn23.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn23.IsEditable = False
        Me.OlvColumn23.Text = "2nd"
        Me.OlvColumn23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn23.Width = 80
        '
        'OlvColumn24
        '
        Me.OlvColumn24.AspectName = "ThirdTryPrint"
        Me.OlvColumn24.DisplayIndex = 7
        Me.OlvColumn24.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn24.IsEditable = False
        Me.OlvColumn24.Text = "3rd"
        Me.OlvColumn24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn24.Width = 80
        '
        'OlvColumn39
        '
        Me.OlvColumn39.AspectName = "Processed"
        Me.OlvColumn39.AutoCompleteEditor = False
        Me.OlvColumn39.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn39.CheckBoxes = True
        Me.OlvColumn39.Text = "Processed"
        Me.OlvColumn39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn39.Width = 68
        '
        'OlvColumn41
        '
        Me.OlvColumn41.AspectName = "Processed"
        Me.OlvColumn41.CheckBoxes = True
        Me.OlvColumn41.Text = "Processed"
        Me.OlvColumn41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn41.Width = 90
        '
        'StudentDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(849, 480)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentDetail"
        Me.Text = "Student Details"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.pbButtonHighlight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAssignments.ResumeLayout(False)
        Me.pnlAssignments.PerformLayout()
        Me.pnlLog.ResumeLayout(False)
        Me.pnlLog.PerformLayout()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvTeachingSessions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAttendance.ResumeLayout(False)
        Me.pnlAttendance.PerformLayout()
        Me.pnlNormalAssignments.ResumeLayout(False)
        CType(Me.olvNormalAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pnlHistoricalData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHistoricalData.ResumeLayout(False)
        CType(Me.olvHistoricalData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOutcomes.ResumeLayout(False)
        CType(Me.olvOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotes.ResumeLayout(False)
        Me.pnlNotes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents olvTeachingSessions As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtStudentID As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNickName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtLocalName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblAddSession As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblRemoveSession As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents nudAdminNumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnShowStudentNotes As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents rtbNotes As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkHidden As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblAdjustAbsences As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents nudMaxAbsences As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents olvOutcomes As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents llblShowOutcomes As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblShowSessions As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents pnlOutcomes As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents nudPresentationQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudAltNumber As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents nudPlagiarismSeverity As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudWritingQuality As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtExtStudentID As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtClass As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnShowStudentLog As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents rtbLog As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents pbButtonHighlight As System.Windows.Forms.PictureBox
    Friend WithEvents btnShowAssignments As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents olvAssignments As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents pnlAttendance As System.Windows.Forms.Panel
    Friend WithEvents pnlAssignments As System.Windows.Forms.Panel
    Friend WithEvents llblMoveAssignment As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtClassGroup As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblAbsentPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OlvColumn25 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn26 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn27 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTags As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents olvNormalAssignments As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn28 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn22 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn23 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn24 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn29 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn33 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn30 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn31 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn32 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvImprovementItems As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn18 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolDataAdded As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolDateRemoved As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn19 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolPerformanceLevel As BrightIdeasSoftware.OLVColumn
    Friend WithEvents btnShowImprovementItems As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents OlvColumn20 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn21 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn34 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn35 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn36 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn37 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn38 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents pnlNormalAssignments As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblGradeAsOfTodayPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblRefreshGradeAsOfToday As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnShowHistoricalData As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents pnlHistoricalData As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents olvHistoricalData As BrightIdeasSoftware.ObjectListView
    Friend WithEvents lstHistoricalFieldsAvailable As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents OlvColumn47 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn48 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn49 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolTimeInForce As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn40 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents lblGradeAsOfTodayPoints As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pnlNotes As System.Windows.Forms.Panel
    Friend WithEvents llblFindInNotes As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFindInNotes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents pnlLog As System.Windows.Forms.Panel
    Friend WithEvents llblFindInHistory As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFindInHistory As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblChangeBaseAssignment As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents OlvColumn39 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn41 As BrightIdeasSoftware.OLVColumn
End Class
