<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualMarkInGroupPresentation
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IndividualMarkInGroupPresentation))
        Me.lblContentLabel = New System.Windows.Forms.Label()
        Me.lblPresentationLabel = New System.Windows.Forms.Label()
        Me.lblLanguageLabel = New System.Windows.Forms.Label()
        Me.txtOverall = New System.Windows.Forms.TextBox()
        Me.txtImprovement = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblContentGrade = New System.Windows.Forms.Label()
        Me.lblPresentationGrade = New System.Windows.Forms.Label()
        Me.lblLanguageGrade = New System.Windows.Forms.Label()
        Me.lblAverageGrade = New System.Windows.Forms.Label()
        Me.lblLanguageWeight = New System.Windows.Forms.Label()
        Me.lblPresentationWeight = New System.Windows.Forms.Label()
        Me.lblContentWeight = New System.Windows.Forms.Label()
        Me.dgvImprovementItems = New System.Windows.Forms.DataGridView()
        Me.IncludedColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerformanceLevelColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreviousPerformanceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastTimeIncludedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityGivenColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtLocalName = New System.Windows.Forms.TextBox()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.nudFirstGrade = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nudSecondGrade = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.nudResearchQuality = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.nudPresentationQuality = New System.Windows.Forms.NumericUpDown()
        Me.llblGenerateImprovements = New System.Windows.Forms.LinkLabel()
        Me.llblAbsent = New System.Windows.Forms.LinkLabel()
        Me.lblImprovementCharCount = New System.Windows.Forms.Label()
        Me.llblClearChecks = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblActiveTime = New System.Windows.Forms.Label()
        Me.llblStudentName = New System.Windows.Forms.LinkLabel()
        Me.llblSaveClose = New System.Windows.Forms.LinkLabel()
        Me.picLanguageMark = New System.Windows.Forms.PictureBox()
        Me.picPresentationMark = New System.Windows.Forms.PictureBox()
        Me.picContentMark = New System.Windows.Forms.PictureBox()
        CType(Me.dgvImprovementItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFirstGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSecondGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudResearchQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPresentationQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLanguageMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPresentationMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContentMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblContentLabel
        '
        Me.lblContentLabel.AutoSize = True
        Me.lblContentLabel.Location = New System.Drawing.Point(5, 68)
        Me.lblContentLabel.Name = "lblContentLabel"
        Me.lblContentLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblContentLabel.TabIndex = 1
        Me.lblContentLabel.Text = "Content:"
        '
        'lblPresentationLabel
        '
        Me.lblPresentationLabel.AutoSize = True
        Me.lblPresentationLabel.Location = New System.Drawing.Point(5, 87)
        Me.lblPresentationLabel.Name = "lblPresentationLabel"
        Me.lblPresentationLabel.Size = New System.Drawing.Size(38, 16)
        Me.lblPresentationLabel.TabIndex = 3
        Me.lblPresentationLabel.Text = "Pres:"
        '
        'lblLanguageLabel
        '
        Me.lblLanguageLabel.AutoSize = True
        Me.lblLanguageLabel.Location = New System.Drawing.Point(5, 105)
        Me.lblLanguageLabel.Name = "lblLanguageLabel"
        Me.lblLanguageLabel.Size = New System.Drawing.Size(39, 16)
        Me.lblLanguageLabel.TabIndex = 5
        Me.lblLanguageLabel.Text = "Lang:"
        '
        'txtOverall
        '
        Me.txtOverall.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOverall.Location = New System.Drawing.Point(96, 122)
        Me.txtOverall.Multiline = True
        Me.txtOverall.Name = "txtOverall"
        Me.txtOverall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOverall.Size = New System.Drawing.Size(211, 53)
        Me.txtOverall.TabIndex = 6
        '
        'txtImprovement
        '
        Me.txtImprovement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImprovement.Location = New System.Drawing.Point(96, 175)
        Me.txtImprovement.Multiline = True
        Me.txtImprovement.Name = "txtImprovement"
        Me.txtImprovement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImprovement.Size = New System.Drawing.Size(211, 130)
        Me.txtImprovement.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Overall:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Improve:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(87, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "F"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(134, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "R"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(180, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "P"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.GreenYellow
        Me.Label9.Location = New System.Drawing.Point(228, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "M"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LimeGreen
        Me.Label10.Location = New System.Drawing.Point(277, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "D"
        '
        'lblContentGrade
        '
        Me.lblContentGrade.AutoSize = True
        Me.lblContentGrade.Location = New System.Drawing.Point(312, 71)
        Me.lblContentGrade.Name = "lblContentGrade"
        Me.lblContentGrade.Size = New System.Drawing.Size(15, 16)
        Me.lblContentGrade.TabIndex = 21
        Me.lblContentGrade.Text = "--"
        '
        'lblPresentationGrade
        '
        Me.lblPresentationGrade.AutoSize = True
        Me.lblPresentationGrade.Location = New System.Drawing.Point(312, 88)
        Me.lblPresentationGrade.Name = "lblPresentationGrade"
        Me.lblPresentationGrade.Size = New System.Drawing.Size(15, 16)
        Me.lblPresentationGrade.TabIndex = 22
        Me.lblPresentationGrade.Text = "--"
        '
        'lblLanguageGrade
        '
        Me.lblLanguageGrade.AutoSize = True
        Me.lblLanguageGrade.Location = New System.Drawing.Point(312, 106)
        Me.lblLanguageGrade.Name = "lblLanguageGrade"
        Me.lblLanguageGrade.Size = New System.Drawing.Size(15, 16)
        Me.lblLanguageGrade.TabIndex = 23
        Me.lblLanguageGrade.Text = "--"
        '
        'lblAverageGrade
        '
        Me.lblAverageGrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAverageGrade.AutoSize = True
        Me.lblAverageGrade.Location = New System.Drawing.Point(312, 127)
        Me.lblAverageGrade.Name = "lblAverageGrade"
        Me.lblAverageGrade.Size = New System.Drawing.Size(15, 16)
        Me.lblAverageGrade.TabIndex = 24
        Me.lblAverageGrade.Text = "--"
        '
        'lblLanguageWeight
        '
        Me.lblLanguageWeight.AutoSize = True
        Me.lblLanguageWeight.Location = New System.Drawing.Point(334, 106)
        Me.lblLanguageWeight.Name = "lblLanguageWeight"
        Me.lblLanguageWeight.Size = New System.Drawing.Size(15, 16)
        Me.lblLanguageWeight.TabIndex = 27
        Me.lblLanguageWeight.Text = "--"
        '
        'lblPresentationWeight
        '
        Me.lblPresentationWeight.AutoSize = True
        Me.lblPresentationWeight.Location = New System.Drawing.Point(334, 88)
        Me.lblPresentationWeight.Name = "lblPresentationWeight"
        Me.lblPresentationWeight.Size = New System.Drawing.Size(15, 16)
        Me.lblPresentationWeight.TabIndex = 26
        Me.lblPresentationWeight.Text = "--"
        '
        'lblContentWeight
        '
        Me.lblContentWeight.AutoSize = True
        Me.lblContentWeight.Location = New System.Drawing.Point(334, 71)
        Me.lblContentWeight.Name = "lblContentWeight"
        Me.lblContentWeight.Size = New System.Drawing.Size(15, 16)
        Me.lblContentWeight.TabIndex = 25
        Me.lblContentWeight.Text = "--"
        '
        'dgvImprovementItems
        '
        Me.dgvImprovementItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvImprovementItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImprovementItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IncludedColumn, Me.NameColumn, Me.PerformanceLevelColumn, Me.PreviousPerformanceColumn, Me.LastTimeIncludedColumn, Me.QuantityGivenColumn})
        Me.dgvImprovementItems.Location = New System.Drawing.Point(372, 0)
        Me.dgvImprovementItems.Name = "dgvImprovementItems"
        Me.dgvImprovementItems.RowHeadersVisible = False
        Me.dgvImprovementItems.ShowCellToolTips = False
        Me.dgvImprovementItems.Size = New System.Drawing.Size(283, 306)
        Me.dgvImprovementItems.TabIndex = 28
        '
        'IncludedColumn
        '
        Me.IncludedColumn.DataPropertyName = "Included"
        Me.IncludedColumn.FillWeight = 10.0!
        Me.IncludedColumn.HeaderText = "O"
        Me.IncludedColumn.Name = "IncludedColumn"
        Me.IncludedColumn.Width = 20
        '
        'NameColumn
        '
        Me.NameColumn.DataPropertyName = "Name"
        Me.NameColumn.HeaderText = "Name"
        Me.NameColumn.MaxInputLength = 100
        Me.NameColumn.Name = "NameColumn"
        Me.NameColumn.ReadOnly = True
        Me.NameColumn.Width = 140
        '
        'PerformanceLevelColumn
        '
        Me.PerformanceLevelColumn.DataPropertyName = "PerformanceLevel"
        Me.PerformanceLevelColumn.HeaderText = "Pe"
        Me.PerformanceLevelColumn.MaxInputLength = 1
        Me.PerformanceLevelColumn.Name = "PerformanceLevelColumn"
        Me.PerformanceLevelColumn.Width = 25
        '
        'PreviousPerformanceColumn
        '
        Me.PreviousPerformanceColumn.DataPropertyName = "PreviousPerformanceLevel"
        Me.PreviousPerformanceColumn.HeaderText = "Pr"
        Me.PreviousPerformanceColumn.MaxInputLength = 1
        Me.PreviousPerformanceColumn.Name = "PreviousPerformanceColumn"
        Me.PreviousPerformanceColumn.ReadOnly = True
        Me.PreviousPerformanceColumn.Width = 25
        '
        'LastTimeIncludedColumn
        '
        Me.LastTimeIncludedColumn.DataPropertyName = "DaysSinceLastIncluded"
        Me.LastTimeIncludedColumn.HeaderText = "D"
        Me.LastTimeIncludedColumn.MaxInputLength = 5
        Me.LastTimeIncludedColumn.Name = "LastTimeIncludedColumn"
        Me.LastTimeIncludedColumn.ReadOnly = True
        Me.LastTimeIncludedColumn.Width = 24
        '
        'QuantityGivenColumn
        '
        Me.QuantityGivenColumn.DataPropertyName = "QuantityGiven"
        Me.QuantityGivenColumn.HeaderText = "Q"
        Me.QuantityGivenColumn.MaxInputLength = 4
        Me.QuantityGivenColumn.Name = "QuantityGivenColumn"
        Me.QuantityGivenColumn.ReadOnly = True
        Me.QuantityGivenColumn.Width = 24
        '
        'txtLocalName
        '
        Me.txtLocalName.Location = New System.Drawing.Point(44, 0)
        Me.txtLocalName.Name = "txtLocalName"
        Me.txtLocalName.ReadOnly = True
        Me.txtLocalName.Size = New System.Drawing.Size(115, 22)
        Me.txtLocalName.TabIndex = 32
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(160, 0)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(70, 22)
        Me.txtNickname.TabIndex = 34
        '
        'txtTags
        '
        Me.txtTags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTags.Location = New System.Drawing.Point(309, 0)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(60, 22)
        Me.txtTags.TabIndex = 40
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(231, 0)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(76, 22)
        Me.txtStudentID.TabIndex = 42
        '
        'nudFirstGrade
        '
        Me.nudFirstGrade.Location = New System.Drawing.Point(35, 24)
        Me.nudFirstGrade.Name = "nudFirstGrade"
        Me.nudFirstGrade.Size = New System.Drawing.Size(47, 22)
        Me.nudFirstGrade.TabIndex = 45
        Me.nudFirstGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(2, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 16)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "1st:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(88, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 16)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "2nd:"
        '
        'nudSecondGrade
        '
        Me.nudSecondGrade.Location = New System.Drawing.Point(121, 26)
        Me.nudSecondGrade.Name = "nudSecondGrade"
        Me.nudSecondGrade.Size = New System.Drawing.Size(47, 22)
        Me.nudSecondGrade.TabIndex = 47
        Me.nudSecondGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(270, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 16)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Rsrch:"
        '
        'nudResearchQuality
        '
        Me.nudResearchQuality.Location = New System.Drawing.Point(319, 26)
        Me.nudResearchQuality.Name = "nudResearchQuality"
        Me.nudResearchQuality.Size = New System.Drawing.Size(47, 22)
        Me.nudResearchQuality.TabIndex = 51
        Me.nudResearchQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudResearchQuality.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(176, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 16)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Pres:"
        '
        'nudPresentationQuality
        '
        Me.nudPresentationQuality.Location = New System.Drawing.Point(216, 26)
        Me.nudPresentationQuality.Name = "nudPresentationQuality"
        Me.nudPresentationQuality.Size = New System.Drawing.Size(47, 22)
        Me.nudPresentationQuality.TabIndex = 49
        Me.nudPresentationQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPresentationQuality.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'llblGenerateImprovements
        '
        Me.llblGenerateImprovements.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblGenerateImprovements.AutoSize = True
        Me.llblGenerateImprovements.Location = New System.Drawing.Point(313, 186)
        Me.llblGenerateImprovements.Name = "llblGenerateImprovements"
        Me.llblGenerateImprovements.Size = New System.Drawing.Size(51, 16)
        Me.llblGenerateImprovements.TabIndex = 53
        Me.llblGenerateImprovements.TabStop = True
        Me.llblGenerateImprovements.Text = "<< Gen"
        '
        'llblAbsent
        '
        Me.llblAbsent.AutoSize = True
        Me.llblAbsent.Location = New System.Drawing.Point(2, 51)
        Me.llblAbsent.Name = "llblAbsent"
        Me.llblAbsent.Size = New System.Drawing.Size(48, 16)
        Me.llblAbsent.TabIndex = 54
        Me.llblAbsent.TabStop = True
        Me.llblAbsent.Text = "Absent"
        '
        'lblImprovementCharCount
        '
        Me.lblImprovementCharCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImprovementCharCount.AutoSize = True
        Me.lblImprovementCharCount.Location = New System.Drawing.Point(310, 220)
        Me.lblImprovementCharCount.Name = "lblImprovementCharCount"
        Me.lblImprovementCharCount.Size = New System.Drawing.Size(14, 16)
        Me.lblImprovementCharCount.TabIndex = 55
        Me.lblImprovementCharCount.Text = "0"
        '
        'llblClearChecks
        '
        Me.llblClearChecks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblClearChecks.AutoSize = True
        Me.llblClearChecks.Location = New System.Drawing.Point(317, 284)
        Me.llblClearChecks.Name = "llblClearChecks"
        Me.llblClearChecks.Size = New System.Drawing.Size(48, 16)
        Me.llblClearChecks.TabIndex = 56
        Me.llblClearChecks.TabStop = True
        Me.llblClearChecks.Text = "Clear X"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblActiveTime
        '
        Me.lblActiveTime.AutoSize = True
        Me.lblActiveTime.Location = New System.Drawing.Point(12, 284)
        Me.lblActiveTime.Name = "lblActiveTime"
        Me.lblActiveTime.Size = New System.Drawing.Size(0, 16)
        Me.lblActiveTime.TabIndex = 57
        '
        'llblStudentName
        '
        Me.llblStudentName.AutoSize = True
        Me.llblStudentName.Location = New System.Drawing.Point(0, 3)
        Me.llblStudentName.Name = "llblStudentName"
        Me.llblStudentName.Size = New System.Drawing.Size(41, 16)
        Me.llblStudentName.TabIndex = 58
        Me.llblStudentName.TabStop = True
        Me.llblStudentName.Text = "Name"
        '
        'llblSaveClose
        '
        Me.llblSaveClose.AutoSize = True
        Me.llblSaveClose.Location = New System.Drawing.Point(2, 203)
        Me.llblSaveClose.Name = "llblSaveClose"
        Me.llblSaveClose.Size = New System.Drawing.Size(72, 16)
        Me.llblSaveClose.TabIndex = 54
        Me.llblSaveClose.TabStop = True
        Me.llblSaveClose.Text = "Save/Close"
        '
        'picLanguageMark
        '
        Me.picLanguageMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLanguageMark.Image = CType(resources.GetObject("picLanguageMark.Image"), System.Drawing.Image)
        Me.picLanguageMark.Location = New System.Drawing.Point(68, 105)
        Me.picLanguageMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLanguageMark.Name = "picLanguageMark"
        Me.picLanguageMark.Size = New System.Drawing.Size(239, 17)
        Me.picLanguageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLanguageMark.TabIndex = 4
        Me.picLanguageMark.TabStop = False
        '
        'picPresentationMark
        '
        Me.picPresentationMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPresentationMark.Image = CType(resources.GetObject("picPresentationMark.Image"), System.Drawing.Image)
        Me.picPresentationMark.Location = New System.Drawing.Point(68, 88)
        Me.picPresentationMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPresentationMark.Name = "picPresentationMark"
        Me.picPresentationMark.Size = New System.Drawing.Size(239, 17)
        Me.picPresentationMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPresentationMark.TabIndex = 2
        Me.picPresentationMark.TabStop = False
        '
        'picContentMark
        '
        Me.picContentMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picContentMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picContentMark.Image = Global.Teaching.My.Resources.Resources.MarkingGridForPresentationsInverse
        Me.picContentMark.Location = New System.Drawing.Point(68, 71)
        Me.picContentMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picContentMark.Name = "picContentMark"
        Me.picContentMark.Size = New System.Drawing.Size(239, 17)
        Me.picContentMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContentMark.TabIndex = 0
        Me.picContentMark.TabStop = False
        '
        'IndividualMarkInGroupPresentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.llblStudentName)
        Me.Controls.Add(Me.lblActiveTime)
        Me.Controls.Add(Me.llblClearChecks)
        Me.Controls.Add(Me.lblImprovementCharCount)
        Me.Controls.Add(Me.llblSaveClose)
        Me.Controls.Add(Me.llblAbsent)
        Me.Controls.Add(Me.llblGenerateImprovements)
        Me.Controls.Add(Me.nudPresentationQuality)
        Me.Controls.Add(Me.nudResearchQuality)
        Me.Controls.Add(Me.nudSecondGrade)
        Me.Controls.Add(Me.nudFirstGrade)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtTags)
        Me.Controls.Add(Me.txtNickname)
        Me.Controls.Add(Me.txtLocalName)
        Me.Controls.Add(Me.dgvImprovementItems)
        Me.Controls.Add(Me.lblLanguageWeight)
        Me.Controls.Add(Me.lblPresentationWeight)
        Me.Controls.Add(Me.lblContentWeight)
        Me.Controls.Add(Me.lblAverageGrade)
        Me.Controls.Add(Me.lblLanguageGrade)
        Me.Controls.Add(Me.lblPresentationGrade)
        Me.Controls.Add(Me.lblContentGrade)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtImprovement)
        Me.Controls.Add(Me.txtOverall)
        Me.Controls.Add(Me.lblLanguageLabel)
        Me.Controls.Add(Me.picLanguageMark)
        Me.Controls.Add(Me.lblPresentationLabel)
        Me.Controls.Add(Me.picPresentationMark)
        Me.Controls.Add(Me.lblContentLabel)
        Me.Controls.Add(Me.picContentMark)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IndividualMarkInGroupPresentation"
        Me.Size = New System.Drawing.Size(655, 306)
        CType(Me.dgvImprovementItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFirstGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSecondGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudResearchQuality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPresentationQuality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLanguageMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPresentationMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContentMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picContentMark As System.Windows.Forms.PictureBox
    Friend WithEvents lblContentLabel As System.Windows.Forms.Label
    Friend WithEvents lblPresentationLabel As System.Windows.Forms.Label
    Friend WithEvents picPresentationMark As System.Windows.Forms.PictureBox
    Friend WithEvents lblLanguageLabel As System.Windows.Forms.Label
    Friend WithEvents picLanguageMark As System.Windows.Forms.PictureBox
    Friend WithEvents txtOverall As System.Windows.Forms.TextBox
    Friend WithEvents txtImprovement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblContentGrade As System.Windows.Forms.Label
    Friend WithEvents lblPresentationGrade As System.Windows.Forms.Label
    Friend WithEvents lblLanguageGrade As System.Windows.Forms.Label
    Friend WithEvents lblAverageGrade As System.Windows.Forms.Label
    Friend WithEvents lblLanguageWeight As System.Windows.Forms.Label
    Friend WithEvents lblPresentationWeight As System.Windows.Forms.Label
    Friend WithEvents lblContentWeight As System.Windows.Forms.Label
    Friend WithEvents dgvImprovementItems As System.Windows.Forms.DataGridView
    Friend WithEvents txtLocalName As System.Windows.Forms.TextBox
    Friend WithEvents txtNickname As System.Windows.Forms.TextBox
    Friend WithEvents txtTags As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents nudFirstGrade As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents nudSecondGrade As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents nudResearchQuality As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents nudPresentationQuality As System.Windows.Forms.NumericUpDown
    Friend WithEvents llblGenerateImprovements As System.Windows.Forms.LinkLabel
    Friend WithEvents llblAbsent As System.Windows.Forms.LinkLabel
    Friend WithEvents lblImprovementCharCount As System.Windows.Forms.Label
    Friend WithEvents llblClearChecks As System.Windows.Forms.LinkLabel
    Friend WithEvents IncludedColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PerformanceLevelColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousPerformanceColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastTimeIncludedColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityGivenColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblActiveTime As System.Windows.Forms.Label
    Friend WithEvents llblStudentName As System.Windows.Forms.LinkLabel
    Friend WithEvents llblSaveClose As LinkLabel
End Class
