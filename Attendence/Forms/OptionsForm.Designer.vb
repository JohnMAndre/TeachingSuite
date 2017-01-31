<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.llblDictionaryInfo = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.pnlOuter = New System.Windows.Forms.TabControl()
        Me.tabData = New System.Windows.Forms.TabPage()
        Me.pnlData = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.cboDictionary = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.chkAutoSaveEnabled = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudAutoSave = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.nudLoggingThreshold = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudDataBackupsToRetain = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCDDrive = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCDDrive = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.tabAttendance = New System.Windows.Forms.TabPage()
        Me.KryptonPanel4 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.chkShowHiddenStudents = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkHighlightAttendanceUnknownPresentationQuality = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkHighlightAttendanceUnknownGender = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.tabExport = New System.Windows.Forms.TabPage()
        Me.pnlExport = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.grpExport = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOutcomeMarkPass = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOutcomeMarkFail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOutcomeMarkUnknown = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.txtAttendenceMarkExcused = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAttendenceMarkUnknown = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAttendenceMarkPresent = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAttendenceMarkRemoved = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAttendenceMarkLate = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAttendenceMarkAbsent = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.tabEmail = New System.Windows.Forms.TabPage()
        Me.pnlEmail = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel34 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmailQuizTrailingText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmailQuizResultsIncorrectFeedback = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.nudEmailAccountToUse = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkIncludeFeedbackWhenEmailing = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.llblBrowseForTrulyMail = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPathToTrulyMail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.tabMarking = New System.Windows.Forms.TabPage()
        Me.pnlMarking = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtImprovementWithPassAll = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtImprovementWithMerit = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtImprovementWithFailAll = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtImprovementWithFailSome = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtImprovementWithDistinction = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnknownResultsText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel38 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFailResultsText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPassResultsText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudMarkingWarning2 = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudMarkingWarning1 = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkDisableColorsAssignmentDetail = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.llblBrowseForFeedbackSaveFolder = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPathToFeedbackSaveFolder = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtStudentDidNotSubmitDefaultOutcomeComment = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtExamPassWeakDefaultFeedback = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel35 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNoSubmitFeedback = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtExamPassDefaultFeedback = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtExamFailDefaultFeedback = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.nudExamClockDuration = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel5 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel39 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtLateSubmitDefaultComment = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel40 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtReworkPassAllDefaultComment = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.pnlOuter.SuspendLayout()
        Me.tabData.SuspendLayout()
        CType(Me.pnlData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlData.SuspendLayout()
        CType(Me.cboDictionary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAttendance.SuspendLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel4.SuspendLayout()
        Me.tabExport.SuspendLayout()
        CType(Me.pnlExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExport.SuspendLayout()
        CType(Me.grpExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpExport.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExport.Panel.SuspendLayout()
        Me.grpExport.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        Me.tabEmail.SuspendLayout()
        CType(Me.pnlEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmail.SuspendLayout()
        Me.tabMarking.SuspendLayout()
        CType(Me.pnlMarking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMarking.SuspendLayout()
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel5.SuspendLayout()
        Me.SuspendLayout()
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
        'llblDictionaryInfo
        '
        Me.llblDictionaryInfo.Location = New System.Drawing.Point(420, 109)
        Me.llblDictionaryInfo.Name = "llblDictionaryInfo"
        Me.llblDictionaryInfo.Size = New System.Drawing.Size(38, 34)
        Me.llblDictionaryInfo.TabIndex = 140
        Me.ToolTip1.SetToolTip(Me.llblDictionaryInfo, "Click for more information")
        Me.llblDictionaryInfo.Values.Image = Global.Teaching.My.Resources.Resources.info_32
        Me.llblDictionaryInfo.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblDictionaryInfo.Values.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(300, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Palette = Me.KryptonPalette1
        Me.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(427, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Palette = Me.KryptonPalette1
        Me.btnOK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 38
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'pnlOuter
        '
        Me.pnlOuter.Controls.Add(Me.tabData)
        Me.pnlOuter.Controls.Add(Me.tabAttendance)
        Me.pnlOuter.Controls.Add(Me.tabExport)
        Me.pnlOuter.Controls.Add(Me.tabEmail)
        Me.pnlOuter.Controls.Add(Me.tabMarking)
        Me.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOuter.Location = New System.Drawing.Point(0, 0)
        Me.pnlOuter.Name = "pnlOuter"
        Me.pnlOuter.SelectedIndex = 0
        Me.pnlOuter.Size = New System.Drawing.Size(829, 580)
        Me.pnlOuter.TabIndex = 131
        '
        'tabData
        '
        Me.tabData.Controls.Add(Me.pnlData)
        Me.tabData.Location = New System.Drawing.Point(4, 22)
        Me.tabData.Name = "tabData"
        Me.tabData.Padding = New System.Windows.Forms.Padding(3)
        Me.tabData.Size = New System.Drawing.Size(821, 554)
        Me.tabData.TabIndex = 2
        Me.tabData.Text = "Data"
        Me.tabData.UseVisualStyleBackColor = True
        '
        'pnlData
        '
        Me.pnlData.Controls.Add(Me.llblDictionaryInfo)
        Me.pnlData.Controls.Add(Me.cboDictionary)
        Me.pnlData.Controls.Add(Me.chkAutoSaveEnabled)
        Me.pnlData.Controls.Add(Me.KryptonLabel22)
        Me.pnlData.Controls.Add(Me.nudAutoSave)
        Me.pnlData.Controls.Add(Me.nudLoggingThreshold)
        Me.pnlData.Controls.Add(Me.KryptonLabel18)
        Me.pnlData.Controls.Add(Me.nudDataBackupsToRetain)
        Me.pnlData.Controls.Add(Me.KryptonLabel11)
        Me.pnlData.Controls.Add(Me.KryptonLabel13)
        Me.pnlData.Controls.Add(Me.lblCDDrive)
        Me.pnlData.Controls.Add(Me.txtCDDrive)
        Me.pnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlData.Location = New System.Drawing.Point(3, 3)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(815, 548)
        Me.pnlData.TabIndex = 1
        '
        'cboDictionary
        '
        Me.cboDictionary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDictionary.DropDownWidth = 121
        Me.cboDictionary.Location = New System.Drawing.Point(191, 117)
        Me.cboDictionary.Name = "cboDictionary"
        Me.cboDictionary.Palette = Me.KryptonPalette1
        Me.cboDictionary.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.cboDictionary.Size = New System.Drawing.Size(222, 21)
        Me.cboDictionary.TabIndex = 139
        '
        'chkAutoSaveEnabled
        '
        Me.chkAutoSaveEnabled.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkAutoSaveEnabled.Location = New System.Drawing.Point(73, 41)
        Me.chkAutoSaveEnabled.Name = "chkAutoSaveEnabled"
        Me.chkAutoSaveEnabled.Palette = Me.KryptonPalette1
        Me.chkAutoSaveEnabled.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkAutoSaveEnabled.Size = New System.Drawing.Size(112, 20)
        Me.chkAutoSaveEnabled.TabIndex = 138
        Me.chkAutoSaveEnabled.Text = "Auto save every:"
        Me.chkAutoSaveEnabled.Values.Text = "Auto save every:"
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(268, 41)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Palette = Me.KryptonPalette1
        Me.KryptonLabel22.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel22.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel22.TabIndex = 137
        Me.KryptonLabel22.Values.Text = "minutes"
        '
        'nudAutoSave
        '
        Me.nudAutoSave.Location = New System.Drawing.Point(191, 39)
        Me.nudAutoSave.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudAutoSave.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudAutoSave.Name = "nudAutoSave"
        Me.nudAutoSave.Size = New System.Drawing.Size(71, 21)
        Me.nudAutoSave.TabIndex = 136
        Me.nudAutoSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAutoSave.ThousandsSeparator = True
        Me.nudAutoSave.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'nudLoggingThreshold
        '
        Me.nudLoggingThreshold.Location = New System.Drawing.Point(191, 90)
        Me.nudLoggingThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLoggingThreshold.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLoggingThreshold.Name = "nudLoggingThreshold"
        Me.nudLoggingThreshold.Size = New System.Drawing.Size(71, 21)
        Me.nudLoggingThreshold.TabIndex = 135
        Me.nudLoggingThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudLoggingThreshold.ThousandsSeparator = True
        Me.nudLoggingThreshold.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(72, 92)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Palette = Me.KryptonPalette1
        Me.KryptonLabel18.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel18.Size = New System.Drawing.Size(113, 20)
        Me.KryptonLabel18.TabIndex = 134
        Me.KryptonLabel18.Values.Text = "Logging threshold:"
        '
        'nudDataBackupsToRetain
        '
        Me.nudDataBackupsToRetain.Location = New System.Drawing.Point(191, 11)
        Me.nudDataBackupsToRetain.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudDataBackupsToRetain.Name = "nudDataBackupsToRetain"
        Me.nudDataBackupsToRetain.Size = New System.Drawing.Size(71, 21)
        Me.nudDataBackupsToRetain.TabIndex = 133
        Me.nudDataBackupsToRetain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudDataBackupsToRetain.ThousandsSeparator = True
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(71, 117)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Palette = Me.KryptonPalette1
        Me.KryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel11.Size = New System.Drawing.Size(105, 20)
        Me.KryptonLabel11.TabIndex = 132
        Me.KryptonLabel11.Values.Text = "Dictionary to use:"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(49, 13)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Palette = Me.KryptonPalette1
        Me.KryptonLabel13.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel13.Size = New System.Drawing.Size(136, 20)
        Me.KryptonLabel13.TabIndex = 132
        Me.KryptonLabel13.Values.Text = "Data backups to retain:"
        '
        'lblCDDrive
        '
        Me.lblCDDrive.Location = New System.Drawing.Point(124, 66)
        Me.lblCDDrive.Name = "lblCDDrive"
        Me.lblCDDrive.Palette = Me.KryptonPalette1
        Me.lblCDDrive.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblCDDrive.Size = New System.Drawing.Size(61, 20)
        Me.lblCDDrive.TabIndex = 131
        Me.lblCDDrive.Values.Text = "CD Drive:"
        '
        'txtCDDrive
        '
        Me.txtCDDrive.Location = New System.Drawing.Point(191, 66)
        Me.txtCDDrive.Name = "txtCDDrive"
        Me.txtCDDrive.Size = New System.Drawing.Size(53, 19)
        Me.txtCDDrive.TabIndex = 130
        '
        'tabAttendance
        '
        Me.tabAttendance.Controls.Add(Me.KryptonPanel4)
        Me.tabAttendance.Location = New System.Drawing.Point(4, 22)
        Me.tabAttendance.Name = "tabAttendance"
        Me.tabAttendance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAttendance.Size = New System.Drawing.Size(821, 554)
        Me.tabAttendance.TabIndex = 4
        Me.tabAttendance.Text = "Attendance"
        Me.tabAttendance.UseVisualStyleBackColor = True
        '
        'KryptonPanel4
        '
        Me.KryptonPanel4.Controls.Add(Me.chkShowHiddenStudents)
        Me.KryptonPanel4.Controls.Add(Me.chkHighlightAttendanceUnknownPresentationQuality)
        Me.KryptonPanel4.Controls.Add(Me.chkHighlightAttendanceUnknownGender)
        Me.KryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel4.Location = New System.Drawing.Point(3, 3)
        Me.KryptonPanel4.Name = "KryptonPanel4"
        Me.KryptonPanel4.Size = New System.Drawing.Size(815, 548)
        Me.KryptonPanel4.TabIndex = 3
        '
        'chkShowHiddenStudents
        '
        Me.chkShowHiddenStudents.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkShowHiddenStudents.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkShowHiddenStudents.Location = New System.Drawing.Point(5, 125)
        Me.chkShowHiddenStudents.Name = "chkShowHiddenStudents"
        Me.chkShowHiddenStudents.Palette = Me.KryptonPalette1
        Me.chkShowHiddenStudents.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkShowHiddenStudents.Size = New System.Drawing.Size(228, 20)
        Me.chkShowHiddenStudents.TabIndex = 57
        Me.chkShowHiddenStudents.Text = "Show hidden students on Attendence"
        Me.chkShowHiddenStudents.Values.Text = "Show hidden students on Attendence"
        '
        'chkHighlightAttendanceUnknownPresentationQuality
        '
        Me.chkHighlightAttendanceUnknownPresentationQuality.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkHighlightAttendanceUnknownPresentationQuality.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkHighlightAttendanceUnknownPresentationQuality.Location = New System.Drawing.Point(5, 84)
        Me.chkHighlightAttendanceUnknownPresentationQuality.Name = "chkHighlightAttendanceUnknownPresentationQuality"
        Me.chkHighlightAttendanceUnknownPresentationQuality.Palette = Me.KryptonPalette1
        Me.chkHighlightAttendanceUnknownPresentationQuality.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkHighlightAttendanceUnknownPresentationQuality.Size = New System.Drawing.Size(283, 20)
        Me.chkHighlightAttendanceUnknownPresentationQuality.TabIndex = 56
        Me.chkHighlightAttendanceUnknownPresentationQuality.Text = "Highlight students with no presentation quality:"
        Me.chkHighlightAttendanceUnknownPresentationQuality.Values.Text = "Highlight students with no presentation quality:"
        '
        'chkHighlightAttendanceUnknownGender
        '
        Me.chkHighlightAttendanceUnknownGender.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkHighlightAttendanceUnknownGender.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkHighlightAttendanceUnknownGender.Location = New System.Drawing.Point(5, 38)
        Me.chkHighlightAttendanceUnknownGender.Name = "chkHighlightAttendanceUnknownGender"
        Me.chkHighlightAttendanceUnknownGender.Palette = Me.KryptonPalette1
        Me.chkHighlightAttendanceUnknownGender.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkHighlightAttendanceUnknownGender.Size = New System.Drawing.Size(249, 20)
        Me.chkHighlightAttendanceUnknownGender.TabIndex = 55
        Me.chkHighlightAttendanceUnknownGender.Text = "Highlight students with unknown gender:"
        Me.chkHighlightAttendanceUnknownGender.Values.Text = "Highlight students with unknown gender:"
        '
        'tabExport
        '
        Me.tabExport.Controls.Add(Me.pnlExport)
        Me.tabExport.Location = New System.Drawing.Point(4, 22)
        Me.tabExport.Name = "tabExport"
        Me.tabExport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExport.Size = New System.Drawing.Size(821, 554)
        Me.tabExport.TabIndex = 1
        Me.tabExport.Text = "Export"
        Me.tabExport.UseVisualStyleBackColor = True
        '
        'pnlExport
        '
        Me.pnlExport.Controls.Add(Me.grpExport)
        Me.pnlExport.Controls.Add(Me.KryptonGroupBox1)
        Me.pnlExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlExport.Location = New System.Drawing.Point(3, 3)
        Me.pnlExport.Name = "pnlExport"
        Me.pnlExport.Size = New System.Drawing.Size(815, 548)
        Me.pnlExport.TabIndex = 0
        '
        'grpExport
        '
        Me.grpExport.Location = New System.Drawing.Point(173, 3)
        Me.grpExport.Name = "grpExport"
        Me.grpExport.Palette = Me.KryptonPalette1
        Me.grpExport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        '
        'grpExport.Panel
        '
        Me.grpExport.Panel.Controls.Add(Me.KryptonLabel15)
        Me.grpExport.Panel.Controls.Add(Me.txtOutcomeMarkPass)
        Me.grpExport.Panel.Controls.Add(Me.KryptonLabel17)
        Me.grpExport.Panel.Controls.Add(Me.txtOutcomeMarkFail)
        Me.grpExport.Panel.Controls.Add(Me.KryptonLabel19)
        Me.grpExport.Panel.Controls.Add(Me.txtOutcomeMarkUnknown)
        Me.grpExport.Size = New System.Drawing.Size(162, 117)
        Me.grpExport.TabIndex = 53
        Me.grpExport.Text = "Module Results"
        Me.grpExport.Values.Heading = "Module Results"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(3, 12)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Palette = Me.KryptonPalette1
        Me.KryptonLabel15.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel15.Size = New System.Drawing.Size(37, 20)
        Me.KryptonLabel15.TabIndex = 26
        Me.KryptonLabel15.Values.Text = "Pass:"
        '
        'txtOutcomeMarkPass
        '
        Me.txtOutcomeMarkPass.Location = New System.Drawing.Point(74, 12)
        Me.txtOutcomeMarkPass.Name = "txtOutcomeMarkPass"
        Me.txtOutcomeMarkPass.Palette = Me.KryptonPalette1
        Me.txtOutcomeMarkPass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtOutcomeMarkPass.Size = New System.Drawing.Size(63, 20)
        Me.txtOutcomeMarkPass.TabIndex = 27
        Me.txtOutcomeMarkPass.Text = "P"
        Me.txtOutcomeMarkPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(3, 38)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Palette = Me.KryptonPalette1
        Me.KryptonLabel17.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel17.Size = New System.Drawing.Size(31, 20)
        Me.KryptonLabel17.TabIndex = 28
        Me.KryptonLabel17.Values.Text = "Fail:"
        '
        'txtOutcomeMarkFail
        '
        Me.txtOutcomeMarkFail.Location = New System.Drawing.Point(74, 38)
        Me.txtOutcomeMarkFail.Name = "txtOutcomeMarkFail"
        Me.txtOutcomeMarkFail.Palette = Me.KryptonPalette1
        Me.txtOutcomeMarkFail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtOutcomeMarkFail.Size = New System.Drawing.Size(63, 20)
        Me.txtOutcomeMarkFail.TabIndex = 29
        Me.txtOutcomeMarkFail.Text = "L"
        Me.txtOutcomeMarkFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(3, 64)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Palette = Me.KryptonPalette1
        Me.KryptonLabel19.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel19.Size = New System.Drawing.Size(65, 20)
        Me.KryptonLabel19.TabIndex = 30
        Me.KryptonLabel19.Values.Text = "Unknown:"
        '
        'txtOutcomeMarkUnknown
        '
        Me.txtOutcomeMarkUnknown.Location = New System.Drawing.Point(74, 64)
        Me.txtOutcomeMarkUnknown.Name = "txtOutcomeMarkUnknown"
        Me.txtOutcomeMarkUnknown.Palette = Me.KryptonPalette1
        Me.txtOutcomeMarkUnknown.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtOutcomeMarkUnknown.Size = New System.Drawing.Size(63, 20)
        Me.txtOutcomeMarkUnknown.TabIndex = 31
        Me.txtOutcomeMarkUnknown.Text = "U"
        Me.txtOutcomeMarkUnknown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        Me.KryptonGroupBox1.Palette = Me.KryptonPalette1
        Me.KryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtAttendenceMarkExcused)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtAttendenceMarkUnknown)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtAttendenceMarkPresent)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtAttendenceMarkRemoved)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtAttendenceMarkLate)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtAttendenceMarkAbsent)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(162, 203)
        Me.KryptonGroupBox1.TabIndex = 37
        Me.KryptonGroupBox1.Text = "Attendance Report"
        Me.KryptonGroupBox1.Values.Heading = "Attendance Report"
        '
        'txtAttendenceMarkExcused
        '
        Me.txtAttendenceMarkExcused.Location = New System.Drawing.Point(74, 142)
        Me.txtAttendenceMarkExcused.Name = "txtAttendenceMarkExcused"
        Me.txtAttendenceMarkExcused.Palette = Me.KryptonPalette1
        Me.txtAttendenceMarkExcused.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAttendenceMarkExcused.Size = New System.Drawing.Size(63, 20)
        Me.txtAttendenceMarkExcused.TabIndex = 37
        Me.txtAttendenceMarkExcused.Text = "E"
        Me.txtAttendenceMarkExcused.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(3, 142)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Palette = Me.KryptonPalette1
        Me.KryptonLabel9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel9.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel9.TabIndex = 36
        Me.KryptonLabel9.Values.Text = "Excused:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Palette = Me.KryptonPalette1
        Me.KryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel2.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel2.TabIndex = 26
        Me.KryptonLabel2.Values.Text = "Present:"
        '
        'txtAttendenceMarkUnknown
        '
        Me.txtAttendenceMarkUnknown.Location = New System.Drawing.Point(74, 116)
        Me.txtAttendenceMarkUnknown.Name = "txtAttendenceMarkUnknown"
        Me.txtAttendenceMarkUnknown.Palette = Me.KryptonPalette1
        Me.txtAttendenceMarkUnknown.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAttendenceMarkUnknown.Size = New System.Drawing.Size(63, 20)
        Me.txtAttendenceMarkUnknown.TabIndex = 35
        Me.txtAttendenceMarkUnknown.Text = "U"
        Me.txtAttendenceMarkUnknown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAttendenceMarkPresent
        '
        Me.txtAttendenceMarkPresent.Location = New System.Drawing.Point(74, 12)
        Me.txtAttendenceMarkPresent.Name = "txtAttendenceMarkPresent"
        Me.txtAttendenceMarkPresent.Palette = Me.KryptonPalette1
        Me.txtAttendenceMarkPresent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAttendenceMarkPresent.Size = New System.Drawing.Size(63, 20)
        Me.txtAttendenceMarkPresent.TabIndex = 27
        Me.txtAttendenceMarkPresent.Text = "P"
        Me.txtAttendenceMarkPresent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(3, 116)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Palette = Me.KryptonPalette1
        Me.KryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel5.Size = New System.Drawing.Size(65, 20)
        Me.KryptonLabel5.TabIndex = 34
        Me.KryptonLabel5.Values.Text = "Unknown:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 38)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Palette = Me.KryptonPalette1
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel1.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel1.TabIndex = 28
        Me.KryptonLabel1.Values.Text = "Late:"
        '
        'txtAttendenceMarkRemoved
        '
        Me.txtAttendenceMarkRemoved.Location = New System.Drawing.Point(74, 90)
        Me.txtAttendenceMarkRemoved.Name = "txtAttendenceMarkRemoved"
        Me.txtAttendenceMarkRemoved.Palette = Me.KryptonPalette1
        Me.txtAttendenceMarkRemoved.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAttendenceMarkRemoved.Size = New System.Drawing.Size(63, 20)
        Me.txtAttendenceMarkRemoved.TabIndex = 33
        Me.txtAttendenceMarkRemoved.Text = "R"
        Me.txtAttendenceMarkRemoved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAttendenceMarkLate
        '
        Me.txtAttendenceMarkLate.Location = New System.Drawing.Point(74, 38)
        Me.txtAttendenceMarkLate.Name = "txtAttendenceMarkLate"
        Me.txtAttendenceMarkLate.Palette = Me.KryptonPalette1
        Me.txtAttendenceMarkLate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAttendenceMarkLate.Size = New System.Drawing.Size(63, 20)
        Me.txtAttendenceMarkLate.TabIndex = 29
        Me.txtAttendenceMarkLate.Text = "L"
        Me.txtAttendenceMarkLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 90)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Palette = Me.KryptonPalette1
        Me.KryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel4.Size = New System.Drawing.Size(65, 20)
        Me.KryptonLabel4.TabIndex = 32
        Me.KryptonLabel4.Values.Text = "Removed:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 64)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Palette = Me.KryptonPalette1
        Me.KryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel3.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel3.TabIndex = 30
        Me.KryptonLabel3.Values.Text = "Absent:"
        '
        'txtAttendenceMarkAbsent
        '
        Me.txtAttendenceMarkAbsent.Location = New System.Drawing.Point(74, 64)
        Me.txtAttendenceMarkAbsent.Name = "txtAttendenceMarkAbsent"
        Me.txtAttendenceMarkAbsent.Palette = Me.KryptonPalette1
        Me.txtAttendenceMarkAbsent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtAttendenceMarkAbsent.Size = New System.Drawing.Size(63, 20)
        Me.txtAttendenceMarkAbsent.TabIndex = 31
        Me.txtAttendenceMarkAbsent.Text = "A"
        Me.txtAttendenceMarkAbsent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabEmail
        '
        Me.tabEmail.Controls.Add(Me.pnlEmail)
        Me.tabEmail.Location = New System.Drawing.Point(4, 22)
        Me.tabEmail.Name = "tabEmail"
        Me.tabEmail.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmail.Size = New System.Drawing.Size(821, 554)
        Me.tabEmail.TabIndex = 3
        Me.tabEmail.Text = "Email"
        Me.tabEmail.UseVisualStyleBackColor = True
        '
        'pnlEmail
        '
        Me.pnlEmail.Controls.Add(Me.KryptonLabel34)
        Me.pnlEmail.Controls.Add(Me.txtEmailQuizTrailingText)
        Me.pnlEmail.Controls.Add(Me.KryptonLabel33)
        Me.pnlEmail.Controls.Add(Me.txtEmailQuizResultsIncorrectFeedback)
        Me.pnlEmail.Controls.Add(Me.nudEmailAccountToUse)
        Me.pnlEmail.Controls.Add(Me.KryptonLabel32)
        Me.pnlEmail.Controls.Add(Me.chkIncludeFeedbackWhenEmailing)
        Me.pnlEmail.Controls.Add(Me.llblBrowseForTrulyMail)
        Me.pnlEmail.Controls.Add(Me.KryptonLabel12)
        Me.pnlEmail.Controls.Add(Me.txtPathToTrulyMail)
        Me.pnlEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEmail.Location = New System.Drawing.Point(3, 3)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(815, 548)
        Me.pnlEmail.TabIndex = 2
        '
        'KryptonLabel34
        '
        Me.KryptonLabel34.Location = New System.Drawing.Point(5, 147)
        Me.KryptonLabel34.Name = "KryptonLabel34"
        Me.KryptonLabel34.Palette = Me.KryptonPalette1
        Me.KryptonLabel34.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel34.Size = New System.Drawing.Size(134, 20)
        Me.KryptonLabel34.TabIndex = 138
        Me.KryptonLabel34.Values.Text = "Email quiz trailing text:"
        '
        'txtEmailQuizTrailingText
        '
        Me.txtEmailQuizTrailingText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailQuizTrailingText.Location = New System.Drawing.Point(244, 147)
        Me.txtEmailQuizTrailingText.Multiline = True
        Me.txtEmailQuizTrailingText.Name = "txtEmailQuizTrailingText"
        Me.txtEmailQuizTrailingText.Size = New System.Drawing.Size(541, 102)
        Me.txtEmailQuizTrailingText.TabIndex = 137
        '
        'KryptonLabel33
        '
        Me.KryptonLabel33.Location = New System.Drawing.Point(5, 121)
        Me.KryptonLabel33.Name = "KryptonLabel33"
        Me.KryptonLabel33.Palette = Me.KryptonPalette1
        Me.KryptonLabel33.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel33.Size = New System.Drawing.Size(212, 20)
        Me.KryptonLabel33.TabIndex = 136
        Me.KryptonLabel33.Values.Text = "Email quiz results incorrect feedback:"
        '
        'txtEmailQuizResultsIncorrectFeedback
        '
        Me.txtEmailQuizResultsIncorrectFeedback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailQuizResultsIncorrectFeedback.Location = New System.Drawing.Point(244, 121)
        Me.txtEmailQuizResultsIncorrectFeedback.Name = "txtEmailQuizResultsIncorrectFeedback"
        Me.txtEmailQuizResultsIncorrectFeedback.Size = New System.Drawing.Size(541, 19)
        Me.txtEmailQuizResultsIncorrectFeedback.TabIndex = 135
        '
        'nudEmailAccountToUse
        '
        Me.nudEmailAccountToUse.Location = New System.Drawing.Point(244, 63)
        Me.nudEmailAccountToUse.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudEmailAccountToUse.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEmailAccountToUse.Name = "nudEmailAccountToUse"
        Me.nudEmailAccountToUse.Size = New System.Drawing.Size(66, 21)
        Me.nudEmailAccountToUse.TabIndex = 134
        Me.nudEmailAccountToUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudEmailAccountToUse.ThousandsSeparator = True
        Me.nudEmailAccountToUse.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(5, 64)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Palette = Me.KryptonPalette1
        Me.KryptonLabel32.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel32.Size = New System.Drawing.Size(89, 20)
        Me.KryptonLabel32.TabIndex = 133
        Me.KryptonLabel32.Values.Text = "Email account:"
        '
        'chkIncludeFeedbackWhenEmailing
        '
        Me.chkIncludeFeedbackWhenEmailing.AutoSize = False
        Me.chkIncludeFeedbackWhenEmailing.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkIncludeFeedbackWhenEmailing.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkIncludeFeedbackWhenEmailing.Location = New System.Drawing.Point(5, 38)
        Me.chkIncludeFeedbackWhenEmailing.Name = "chkIncludeFeedbackWhenEmailing"
        Me.chkIncludeFeedbackWhenEmailing.Palette = Me.KryptonPalette1
        Me.chkIncludeFeedbackWhenEmailing.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkIncludeFeedbackWhenEmailing.Size = New System.Drawing.Size(251, 20)
        Me.chkIncludeFeedbackWhenEmailing.TabIndex = 55
        Me.chkIncludeFeedbackWhenEmailing.Text = "Include feedback when emailing"
        Me.chkIncludeFeedbackWhenEmailing.Values.Text = "Include feedback when emailing"
        '
        'llblBrowseForTrulyMail
        '
        Me.llblBrowseForTrulyMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblBrowseForTrulyMail.Location = New System.Drawing.Point(788, 12)
        Me.llblBrowseForTrulyMail.Name = "llblBrowseForTrulyMail"
        Me.llblBrowseForTrulyMail.Size = New System.Drawing.Size(22, 19)
        Me.llblBrowseForTrulyMail.TabIndex = 54
        Me.llblBrowseForTrulyMail.Values.Text = "..."
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(5, 12)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Palette = Me.KryptonPalette1
        Me.KryptonLabel12.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel12.Size = New System.Drawing.Size(106, 20)
        Me.KryptonLabel12.TabIndex = 53
        Me.KryptonLabel12.Values.Text = "Path to TrulyMail:"
        '
        'txtPathToTrulyMail
        '
        Me.txtPathToTrulyMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathToTrulyMail.Location = New System.Drawing.Point(244, 12)
        Me.txtPathToTrulyMail.Name = "txtPathToTrulyMail"
        Me.txtPathToTrulyMail.Size = New System.Drawing.Size(541, 19)
        Me.txtPathToTrulyMail.TabIndex = 52
        '
        'tabMarking
        '
        Me.tabMarking.Controls.Add(Me.pnlMarking)
        Me.tabMarking.Location = New System.Drawing.Point(4, 22)
        Me.tabMarking.Name = "tabMarking"
        Me.tabMarking.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMarking.Size = New System.Drawing.Size(821, 554)
        Me.tabMarking.TabIndex = 0
        Me.tabMarking.Text = "Marking"
        Me.tabMarking.UseVisualStyleBackColor = True
        '
        'pnlMarking
        '
        Me.pnlMarking.Controls.Add(Me.txtImprovementWithPassAll)
        Me.pnlMarking.Controls.Add(Me.txtImprovementWithMerit)
        Me.pnlMarking.Controls.Add(Me.txtReworkPassAllDefaultComment)
        Me.pnlMarking.Controls.Add(Me.txtLateSubmitDefaultComment)
        Me.pnlMarking.Controls.Add(Me.txtImprovementWithFailAll)
        Me.pnlMarking.Controls.Add(Me.txtImprovementWithFailSome)
        Me.pnlMarking.Controls.Add(Me.txtImprovementWithDistinction)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel31)
        Me.pnlMarking.Controls.Add(Me.txtUnknownResultsText)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel38)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel30)
        Me.pnlMarking.Controls.Add(Me.txtFailResultsText)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel37)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel29)
        Me.pnlMarking.Controls.Add(Me.txtPassResultsText)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel27)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel26)
        Me.pnlMarking.Controls.Add(Me.nudMarkingWarning2)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel25)
        Me.pnlMarking.Controls.Add(Me.nudMarkingWarning1)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel21)
        Me.pnlMarking.Controls.Add(Me.chkDisableColorsAssignmentDetail)
        Me.pnlMarking.Controls.Add(Me.llblBrowseForFeedbackSaveFolder)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel28)
        Me.pnlMarking.Controls.Add(Me.txtPathToFeedbackSaveFolder)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel40)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel39)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel36)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel16)
        Me.pnlMarking.Controls.Add(Me.txtStudentDidNotSubmitDefaultOutcomeComment)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel14)
        Me.pnlMarking.Controls.Add(Me.txtExamPassWeakDefaultFeedback)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel35)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel10)
        Me.pnlMarking.Controls.Add(Me.txtNoSubmitFeedback)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel8)
        Me.pnlMarking.Controls.Add(Me.txtExamPassDefaultFeedback)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel20)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel7)
        Me.pnlMarking.Controls.Add(Me.txtExamFailDefaultFeedback)
        Me.pnlMarking.Controls.Add(Me.nudExamClockDuration)
        Me.pnlMarking.Controls.Add(Me.KryptonLabel6)
        Me.pnlMarking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMarking.Location = New System.Drawing.Point(3, 3)
        Me.pnlMarking.Name = "pnlMarking"
        Me.pnlMarking.Palette = Me.KryptonPalette1
        Me.pnlMarking.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.pnlMarking.Size = New System.Drawing.Size(815, 548)
        Me.pnlMarking.TabIndex = 0
        '
        'txtImprovementWithPassAll
        '
        Me.txtImprovementWithPassAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImprovementWithPassAll.Location = New System.Drawing.Point(206, 317)
        Me.txtImprovementWithPassAll.Name = "txtImprovementWithPassAll"
        Me.txtImprovementWithPassAll.Size = New System.Drawing.Size(597, 19)
        Me.txtImprovementWithPassAll.TabIndex = 141
        '
        'txtImprovementWithMerit
        '
        Me.txtImprovementWithMerit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImprovementWithMerit.Location = New System.Drawing.Point(206, 291)
        Me.txtImprovementWithMerit.Name = "txtImprovementWithMerit"
        Me.txtImprovementWithMerit.Size = New System.Drawing.Size(597, 19)
        Me.txtImprovementWithMerit.TabIndex = 139
        '
        'txtImprovementWithFailAll
        '
        Me.txtImprovementWithFailAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImprovementWithFailAll.Location = New System.Drawing.Point(206, 369)
        Me.txtImprovementWithFailAll.Name = "txtImprovementWithFailAll"
        Me.txtImprovementWithFailAll.Size = New System.Drawing.Size(597, 19)
        Me.txtImprovementWithFailAll.TabIndex = 63
        '
        'txtImprovementWithFailSome
        '
        Me.txtImprovementWithFailSome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImprovementWithFailSome.Location = New System.Drawing.Point(206, 343)
        Me.txtImprovementWithFailSome.Name = "txtImprovementWithFailSome"
        Me.txtImprovementWithFailSome.Size = New System.Drawing.Size(597, 19)
        Me.txtImprovementWithFailSome.TabIndex = 44
        '
        'txtImprovementWithDistinction
        '
        Me.txtImprovementWithDistinction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImprovementWithDistinction.Location = New System.Drawing.Point(206, 265)
        Me.txtImprovementWithDistinction.Name = "txtImprovementWithDistinction"
        Me.txtImprovementWithDistinction.Size = New System.Drawing.Size(597, 19)
        Me.txtImprovementWithDistinction.TabIndex = 40
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(403, 117)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Palette = Me.KryptonPalette1
        Me.KryptonLabel31.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel31.Size = New System.Drawing.Size(128, 20)
        Me.KryptonLabel31.TabIndex = 144
        Me.KryptonLabel31.Values.Text = "Unknown results text:"
        '
        'txtUnknownResultsText
        '
        Me.txtUnknownResultsText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnknownResultsText.Location = New System.Drawing.Point(581, 117)
        Me.txtUnknownResultsText.Name = "txtUnknownResultsText"
        Me.txtUnknownResultsText.Size = New System.Drawing.Size(222, 19)
        Me.txtUnknownResultsText.TabIndex = 143
        '
        'KryptonLabel38
        '
        Me.KryptonLabel38.Location = New System.Drawing.Point(9, 317)
        Me.KryptonLabel38.Name = "KryptonLabel38"
        Me.KryptonLabel38.Size = New System.Drawing.Size(169, 19)
        Me.KryptonLabel38.TabIndex = 142
        Me.KryptonLabel38.Values.Text = "Improvement with pass all:"
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(9, 117)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Palette = Me.KryptonPalette1
        Me.KryptonLabel30.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel30.Size = New System.Drawing.Size(94, 20)
        Me.KryptonLabel30.TabIndex = 142
        Me.KryptonLabel30.Values.Text = "Fail results text:"
        '
        'txtFailResultsText
        '
        Me.txtFailResultsText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFailResultsText.Location = New System.Drawing.Point(206, 117)
        Me.txtFailResultsText.Name = "txtFailResultsText"
        Me.txtFailResultsText.Size = New System.Drawing.Size(191, 19)
        Me.txtFailResultsText.TabIndex = 141
        '
        'KryptonLabel37
        '
        Me.KryptonLabel37.Location = New System.Drawing.Point(9, 291)
        Me.KryptonLabel37.Name = "KryptonLabel37"
        Me.KryptonLabel37.Size = New System.Drawing.Size(154, 19)
        Me.KryptonLabel37.TabIndex = 140
        Me.KryptonLabel37.Values.Text = "Improvement with merit:"
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(9, 91)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Palette = Me.KryptonPalette1
        Me.KryptonLabel29.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel29.Size = New System.Drawing.Size(100, 20)
        Me.KryptonLabel29.TabIndex = 140
        Me.KryptonLabel29.Values.Text = "Pass results text:"
        '
        'txtPassResultsText
        '
        Me.txtPassResultsText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassResultsText.Location = New System.Drawing.Point(206, 91)
        Me.txtPassResultsText.Name = "txtPassResultsText"
        Me.txtPassResultsText.Size = New System.Drawing.Size(191, 19)
        Me.txtPassResultsText.TabIndex = 139
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel27.Location = New System.Drawing.Point(749, 37)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Palette = Me.KryptonPalette1
        Me.KryptonLabel27.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel27.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel27.TabIndex = 136
        Me.KryptonLabel27.Values.Text = "minutes"
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(483, 37)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Palette = Me.KryptonPalette1
        Me.KryptonLabel26.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel26.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel26.TabIndex = 135
        Me.KryptonLabel26.Values.Text = "minutes"
        '
        'nudMarkingWarning2
        '
        Me.nudMarkingWarning2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudMarkingWarning2.Location = New System.Drawing.Point(668, 35)
        Me.nudMarkingWarning2.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudMarkingWarning2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMarkingWarning2.Name = "nudMarkingWarning2"
        Me.nudMarkingWarning2.Size = New System.Drawing.Size(75, 21)
        Me.nudMarkingWarning2.TabIndex = 134
        Me.nudMarkingWarning2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMarkingWarning2.ThousandsSeparator = True
        Me.nudMarkingWarning2.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel25.Location = New System.Drawing.Point(547, 37)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Palette = Me.KryptonPalette1
        Me.KryptonLabel25.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel25.Size = New System.Drawing.Size(115, 20)
        Me.KryptonLabel25.TabIndex = 133
        Me.KryptonLabel25.Values.Text = "Marking warning 2:"
        '
        'nudMarkingWarning1
        '
        Me.nudMarkingWarning1.Location = New System.Drawing.Point(411, 35)
        Me.nudMarkingWarning1.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudMarkingWarning1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMarkingWarning1.Name = "nudMarkingWarning1"
        Me.nudMarkingWarning1.Size = New System.Drawing.Size(66, 21)
        Me.nudMarkingWarning1.TabIndex = 132
        Me.nudMarkingWarning1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMarkingWarning1.ThousandsSeparator = True
        Me.nudMarkingWarning1.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(290, 37)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Palette = Me.KryptonPalette1
        Me.KryptonLabel21.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel21.Size = New System.Drawing.Size(115, 20)
        Me.KryptonLabel21.TabIndex = 131
        Me.KryptonLabel21.Values.Text = "Marking warning 1:"
        '
        'chkDisableColorsAssignmentDetail
        '
        Me.chkDisableColorsAssignmentDetail.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkDisableColorsAssignmentDetail.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkDisableColorsAssignmentDetail.Location = New System.Drawing.Point(9, 221)
        Me.chkDisableColorsAssignmentDetail.Name = "chkDisableColorsAssignmentDetail"
        Me.chkDisableColorsAssignmentDetail.Palette = Me.KryptonPalette1
        Me.chkDisableColorsAssignmentDetail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.chkDisableColorsAssignmentDetail.Size = New System.Drawing.Size(220, 20)
        Me.chkDisableColorsAssignmentDetail.TabIndex = 130
        Me.chkDisableColorsAssignmentDetail.Text = "Disable colors in assignment details:"
        Me.chkDisableColorsAssignmentDetail.Values.Text = "Disable colors in assignment details:"
        '
        'llblBrowseForFeedbackSaveFolder
        '
        Me.llblBrowseForFeedbackSaveFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblBrowseForFeedbackSaveFolder.Location = New System.Drawing.Point(781, 194)
        Me.llblBrowseForFeedbackSaveFolder.Name = "llblBrowseForFeedbackSaveFolder"
        Me.llblBrowseForFeedbackSaveFolder.Size = New System.Drawing.Size(22, 19)
        Me.llblBrowseForFeedbackSaveFolder.TabIndex = 75
        Me.llblBrowseForFeedbackSaveFolder.Values.Text = "..."
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(9, 194)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Palette = Me.KryptonPalette1
        Me.KryptonLabel28.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel28.Size = New System.Drawing.Size(120, 20)
        Me.KryptonLabel28.TabIndex = 74
        Me.KryptonLabel28.Values.Text = "Feedback save path:"
        '
        'txtPathToFeedbackSaveFolder
        '
        Me.txtPathToFeedbackSaveFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathToFeedbackSaveFolder.Location = New System.Drawing.Point(206, 194)
        Me.txtPathToFeedbackSaveFolder.Name = "txtPathToFeedbackSaveFolder"
        Me.txtPathToFeedbackSaveFolder.Size = New System.Drawing.Size(572, 19)
        Me.txtPathToFeedbackSaveFolder.TabIndex = 73
        '
        'KryptonLabel36
        '
        Me.KryptonLabel36.Location = New System.Drawing.Point(9, 369)
        Me.KryptonLabel36.Name = "KryptonLabel36"
        Me.KryptonLabel36.Size = New System.Drawing.Size(158, 19)
        Me.KryptonLabel36.TabIndex = 64
        Me.KryptonLabel36.Values.Text = "Improvement with fail all:"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(403, 143)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Palette = Me.KryptonPalette1
        Me.KryptonLabel16.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel16.Size = New System.Drawing.Size(178, 20)
        Me.KryptonLabel16.TabIndex = 56
        Me.KryptonLabel16.Values.Text = "No submit outcome comment:"
        '
        'txtStudentDidNotSubmitDefaultOutcomeComment
        '
        Me.txtStudentDidNotSubmitDefaultOutcomeComment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStudentDidNotSubmitDefaultOutcomeComment.Location = New System.Drawing.Point(581, 143)
        Me.txtStudentDidNotSubmitDefaultOutcomeComment.Name = "txtStudentDidNotSubmitDefaultOutcomeComment"
        Me.txtStudentDidNotSubmitDefaultOutcomeComment.Size = New System.Drawing.Size(222, 19)
        Me.txtStudentDidNotSubmitDefaultOutcomeComment.TabIndex = 55
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(403, 91)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Palette = Me.KryptonPalette1
        Me.KryptonLabel14.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel14.Size = New System.Drawing.Size(154, 20)
        Me.KryptonLabel14.TabIndex = 54
        Me.KryptonLabel14.Values.Text = "Exam pass weak feedback:"
        '
        'txtExamPassWeakDefaultFeedback
        '
        Me.txtExamPassWeakDefaultFeedback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExamPassWeakDefaultFeedback.Location = New System.Drawing.Point(581, 91)
        Me.txtExamPassWeakDefaultFeedback.Name = "txtExamPassWeakDefaultFeedback"
        Me.txtExamPassWeakDefaultFeedback.Size = New System.Drawing.Size(222, 19)
        Me.txtExamPassWeakDefaultFeedback.TabIndex = 53
        '
        'KryptonLabel35
        '
        Me.KryptonLabel35.Location = New System.Drawing.Point(9, 343)
        Me.KryptonLabel35.Name = "KryptonLabel35"
        Me.KryptonLabel35.Size = New System.Drawing.Size(178, 19)
        Me.KryptonLabel35.TabIndex = 45
        Me.KryptonLabel35.Values.Text = "Improvement with fail some:"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(9, 143)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Palette = Me.KryptonPalette1
        Me.KryptonLabel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel10.Size = New System.Drawing.Size(123, 20)
        Me.KryptonLabel10.TabIndex = 45
        Me.KryptonLabel10.Values.Text = "No submit feedback:"
        '
        'txtNoSubmitFeedback
        '
        Me.txtNoSubmitFeedback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoSubmitFeedback.Location = New System.Drawing.Point(206, 143)
        Me.txtNoSubmitFeedback.Name = "txtNoSubmitFeedback"
        Me.txtNoSubmitFeedback.Size = New System.Drawing.Size(191, 19)
        Me.txtNoSubmitFeedback.TabIndex = 44
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(403, 65)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Palette = Me.KryptonPalette1
        Me.KryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel8.Size = New System.Drawing.Size(164, 20)
        Me.KryptonLabel8.TabIndex = 43
        Me.KryptonLabel8.Values.Text = "Exam pass default feedback:"
        '
        'txtExamPassDefaultFeedback
        '
        Me.txtExamPassDefaultFeedback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExamPassDefaultFeedback.Location = New System.Drawing.Point(581, 65)
        Me.txtExamPassDefaultFeedback.Name = "txtExamPassDefaultFeedback"
        Me.txtExamPassDefaultFeedback.Size = New System.Drawing.Size(222, 19)
        Me.txtExamPassDefaultFeedback.TabIndex = 42
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(9, 265)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(183, 19)
        Me.KryptonLabel20.TabIndex = 41
        Me.KryptonLabel20.Values.Text = "Improvement with distinction:"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(9, 65)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Palette = Me.KryptonPalette1
        Me.KryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel7.Size = New System.Drawing.Size(156, 20)
        Me.KryptonLabel7.TabIndex = 41
        Me.KryptonLabel7.Values.Text = "Exam fail default feedback:"
        '
        'txtExamFailDefaultFeedback
        '
        Me.txtExamFailDefaultFeedback.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExamFailDefaultFeedback.Location = New System.Drawing.Point(206, 65)
        Me.txtExamFailDefaultFeedback.Name = "txtExamFailDefaultFeedback"
        Me.txtExamFailDefaultFeedback.Size = New System.Drawing.Size(191, 19)
        Me.txtExamFailDefaultFeedback.TabIndex = 40
        '
        'nudExamClockDuration
        '
        Me.nudExamClockDuration.Location = New System.Drawing.Point(193, 37)
        Me.nudExamClockDuration.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudExamClockDuration.Name = "nudExamClockDuration"
        Me.nudExamClockDuration.Size = New System.Drawing.Size(75, 21)
        Me.nudExamClockDuration.TabIndex = 39
        Me.nudExamClockDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudExamClockDuration.ThousandsSeparator = True
        Me.nudExamClockDuration.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(9, 39)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Palette = Me.KryptonPalette1
        Me.KryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel6.Size = New System.Drawing.Size(178, 20)
        Me.KryptonLabel6.TabIndex = 36
        Me.KryptonLabel6.Values.Text = "Exam clock duration (seconds):"
        '
        'KryptonPanel5
        '
        Me.KryptonPanel5.Controls.Add(Me.btnOK)
        Me.KryptonPanel5.Controls.Add(Me.btnCancel)
        Me.KryptonPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel5.Location = New System.Drawing.Point(0, 580)
        Me.KryptonPanel5.Name = "KryptonPanel5"
        Me.KryptonPanel5.Size = New System.Drawing.Size(829, 45)
        Me.KryptonPanel5.TabIndex = 132
        '
        'KryptonLabel39
        '
        Me.KryptonLabel39.Location = New System.Drawing.Point(9, 394)
        Me.KryptonLabel39.Name = "KryptonLabel39"
        Me.KryptonLabel39.Size = New System.Drawing.Size(146, 19)
        Me.KryptonLabel39.TabIndex = 64
        Me.KryptonLabel39.Values.Text = "Improvement with late:"
        '
        'txtLateSubmitDefaultComment
        '
        Me.txtLateSubmitDefaultComment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLateSubmitDefaultComment.Location = New System.Drawing.Point(206, 394)
        Me.txtLateSubmitDefaultComment.Name = "txtLateSubmitDefaultComment"
        Me.txtLateSubmitDefaultComment.Size = New System.Drawing.Size(597, 19)
        Me.txtLateSubmitDefaultComment.TabIndex = 63
        '
        'KryptonLabel40
        '
        Me.KryptonLabel40.Location = New System.Drawing.Point(9, 419)
        Me.KryptonLabel40.Name = "KryptonLabel40"
        Me.KryptonLabel40.Size = New System.Drawing.Size(193, 19)
        Me.KryptonLabel40.TabIndex = 64
        Me.KryptonLabel40.Values.Text = "Improvement, rework, pass all:"
        '
        'txtReworkPassAllDefaultComment
        '
        Me.txtReworkPassAllDefaultComment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReworkPassAllDefaultComment.Location = New System.Drawing.Point(206, 419)
        Me.txtReworkPassAllDefaultComment.Name = "txtReworkPassAllDefaultComment"
        Me.txtReworkPassAllDefaultComment.Size = New System.Drawing.Size(597, 19)
        Me.txtReworkPassAllDefaultComment.TabIndex = 63
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 625)
        Me.Controls.Add(Me.pnlOuter)
        Me.Controls.Add(Me.KryptonPanel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsForm"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.Text = "Settings"
        Me.pnlOuter.ResumeLayout(False)
        Me.tabData.ResumeLayout(False)
        CType(Me.pnlData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        CType(Me.cboDictionary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAttendance.ResumeLayout(False)
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel4.ResumeLayout(False)
        Me.KryptonPanel4.PerformLayout()
        Me.tabExport.ResumeLayout(False)
        CType(Me.pnlExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExport.ResumeLayout(False)
        CType(Me.grpExport.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExport.Panel.ResumeLayout(False)
        Me.grpExport.Panel.PerformLayout()
        CType(Me.grpExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExport.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        Me.tabEmail.ResumeLayout(False)
        CType(Me.pnlEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmail.ResumeLayout(False)
        Me.pnlEmail.PerformLayout()
        Me.tabMarking.ResumeLayout(False)
        CType(Me.pnlMarking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMarking.ResumeLayout(False)
        Me.pnlMarking.PerformLayout()
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents pnlOuter As System.Windows.Forms.TabControl
    Friend WithEvents tabMarking As System.Windows.Forms.TabPage
    Friend WithEvents tabExport As System.Windows.Forms.TabPage
    Friend WithEvents pnlExport As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents grpExport As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOutcomeMarkPass As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOutcomeMarkFail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOutcomeMarkUnknown As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents txtAttendenceMarkExcused As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAttendenceMarkUnknown As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAttendenceMarkPresent As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAttendenceMarkRemoved As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAttendenceMarkLate As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAttendenceMarkAbsent As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tabData As System.Windows.Forms.TabPage
    Friend WithEvents pnlData As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkAutoSaveEnabled As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudAutoSave As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nudLoggingThreshold As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudDataBackupsToRetain As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCDDrive As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCDDrive As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tabEmail As System.Windows.Forms.TabPage
    Friend WithEvents pnlEmail As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkIncludeFeedbackWhenEmailing As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents llblBrowseForTrulyMail As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPathToTrulyMail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents nudEmailAccountToUse As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tabAttendance As System.Windows.Forms.TabPage
    Friend WithEvents KryptonPanel4 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkHighlightAttendanceUnknownPresentationQuality As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkHighlightAttendanceUnknownGender As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonPanel5 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmailQuizResultsIncorrectFeedback As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel34 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmailQuizTrailingText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkShowHiddenStudents As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents pnlMarking As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnknownResultsText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFailResultsText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPassResultsText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudMarkingWarning2 As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudMarkingWarning1 As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkDisableColorsAssignmentDetail As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents llblBrowseForFeedbackSaveFolder As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPathToFeedbackSaveFolder As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtStudentDidNotSubmitDefaultOutcomeComment As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtExamPassWeakDefaultFeedback As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNoSubmitFeedback As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtExamPassDefaultFeedback As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtExamFailDefaultFeedback As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents nudExamClockDuration As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents cboDictionary As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents llblDictionaryInfo As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents txtImprovementWithPassAll As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtImprovementWithMerit As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtImprovementWithFailAll As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtImprovementWithFailSome As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtImprovementWithDistinction As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel38 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel35 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtReworkPassAllDefaultComment As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLateSubmitDefaultComment As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel40 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel39 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
