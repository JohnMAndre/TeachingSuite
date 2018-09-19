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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IndividualMarkInGroupPresentation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.chkNominate = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLocalName = New System.Windows.Forms.TextBox()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtExtID = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
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
        Me.picLanguageMark = New System.Windows.Forms.PictureBox()
        Me.picPresentationMark = New System.Windows.Forms.PictureBox()
        Me.picContentMark = New System.Windows.Forms.PictureBox()
        Me.llblClearChecks = New System.Windows.Forms.LinkLabel()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Content:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lang:"
        '
        'txtOverall
        '
        Me.txtOverall.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOverall.Location = New System.Drawing.Point(96, 182)
        Me.txtOverall.Multiline = True
        Me.txtOverall.Name = "txtOverall"
        Me.txtOverall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOverall.Size = New System.Drawing.Size(211, 54)
        Me.txtOverall.TabIndex = 6
        '
        'txtImprovement
        '
        Me.txtImprovement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImprovement.Location = New System.Drawing.Point(96, 235)
        Me.txtImprovement.Multiline = True
        Me.txtImprovement.Name = "txtImprovement"
        Me.txtImprovement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImprovement.Size = New System.Drawing.Size(211, 68)
        Me.txtImprovement.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Overall:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Improve:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(87, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "F"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(134, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "R"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(180, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "P"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.GreenYellow
        Me.Label9.Location = New System.Drawing.Point(228, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "M"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LimeGreen
        Me.Label10.Location = New System.Drawing.Point(277, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "D"
        '
        'lblContentGrade
        '
        Me.lblContentGrade.AutoSize = True
        Me.lblContentGrade.Location = New System.Drawing.Point(312, 113)
        Me.lblContentGrade.Name = "lblContentGrade"
        Me.lblContentGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblContentGrade.TabIndex = 21
        Me.lblContentGrade.Text = "--"
        '
        'lblPresentationGrade
        '
        Me.lblPresentationGrade.AutoSize = True
        Me.lblPresentationGrade.Location = New System.Drawing.Point(312, 137)
        Me.lblPresentationGrade.Name = "lblPresentationGrade"
        Me.lblPresentationGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblPresentationGrade.TabIndex = 22
        Me.lblPresentationGrade.Text = "--"
        '
        'lblLanguageGrade
        '
        Me.lblLanguageGrade.AutoSize = True
        Me.lblLanguageGrade.Location = New System.Drawing.Point(312, 161)
        Me.lblLanguageGrade.Name = "lblLanguageGrade"
        Me.lblLanguageGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblLanguageGrade.TabIndex = 23
        Me.lblLanguageGrade.Text = "--"
        '
        'lblAverageGrade
        '
        Me.lblAverageGrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAverageGrade.AutoSize = True
        Me.lblAverageGrade.Location = New System.Drawing.Point(312, 185)
        Me.lblAverageGrade.Name = "lblAverageGrade"
        Me.lblAverageGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblAverageGrade.TabIndex = 24
        Me.lblAverageGrade.Text = "--"
        '
        'lblLanguageWeight
        '
        Me.lblLanguageWeight.AutoSize = True
        Me.lblLanguageWeight.Location = New System.Drawing.Point(334, 161)
        Me.lblLanguageWeight.Name = "lblLanguageWeight"
        Me.lblLanguageWeight.Size = New System.Drawing.Size(16, 16)
        Me.lblLanguageWeight.TabIndex = 27
        Me.lblLanguageWeight.Text = "--"
        '
        'lblPresentationWeight
        '
        Me.lblPresentationWeight.AutoSize = True
        Me.lblPresentationWeight.Location = New System.Drawing.Point(334, 137)
        Me.lblPresentationWeight.Name = "lblPresentationWeight"
        Me.lblPresentationWeight.Size = New System.Drawing.Size(16, 16)
        Me.lblPresentationWeight.TabIndex = 26
        Me.lblPresentationWeight.Text = "--"
        '
        'lblContentWeight
        '
        Me.lblContentWeight.AutoSize = True
        Me.lblContentWeight.Location = New System.Drawing.Point(334, 113)
        Me.lblContentWeight.Name = "lblContentWeight"
        Me.lblContentWeight.Size = New System.Drawing.Size(16, 16)
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
        'chkNominate
        '
        Me.chkNominate.AutoSize = True
        Me.chkNominate.Location = New System.Drawing.Point(4, 209)
        Me.chkNominate.Name = "chkNominate"
        Me.chkNominate.Size = New System.Drawing.Size(82, 20)
        Me.chkNominate.TabIndex = 29
        Me.chkNominate.Text = "Nominate"
        Me.chkNominate.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Name:"
        '
        'txtLocalName
        '
        Me.txtLocalName.Location = New System.Drawing.Point(54, 0)
        Me.txtLocalName.Name = "txtLocalName"
        Me.txtLocalName.ReadOnly = True
        Me.txtLocalName.Size = New System.Drawing.Size(161, 22)
        Me.txtLocalName.TabIndex = 32
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(263, 0)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(103, 22)
        Me.txtNickname.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(219, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 16)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Nick:"
        '
        'txtTags
        '
        Me.txtTags.Location = New System.Drawing.Point(54, 42)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(312, 22)
        Me.txtTags.TabIndex = 40
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 16)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Tags:"
        '
        'txtExtID
        '
        Me.txtExtID.Location = New System.Drawing.Point(263, 21)
        Me.txtExtID.Name = "txtExtID"
        Me.txtExtID.ReadOnly = True
        Me.txtExtID.Size = New System.Drawing.Size(103, 22)
        Me.txtExtID.TabIndex = 43
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(54, 21)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(161, 22)
        Me.txtStudentID.TabIndex = 42
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 16)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "ID:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(219, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 16)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "ExtID:"
        '
        'nudFirstGrade
        '
        Me.nudFirstGrade.Location = New System.Drawing.Point(35, 62)
        Me.nudFirstGrade.Name = "nudFirstGrade"
        Me.nudFirstGrade.Size = New System.Drawing.Size(47, 22)
        Me.nudFirstGrade.TabIndex = 45
        Me.nudFirstGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(2, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 16)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "1st:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(88, 66)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 16)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "2nd:"
        '
        'nudSecondGrade
        '
        Me.nudSecondGrade.Location = New System.Drawing.Point(121, 64)
        Me.nudSecondGrade.Name = "nudSecondGrade"
        Me.nudSecondGrade.Size = New System.Drawing.Size(47, 22)
        Me.nudSecondGrade.TabIndex = 47
        Me.nudSecondGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(270, 66)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 16)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Rsrch:"
        '
        'nudResearchQuality
        '
        Me.nudResearchQuality.Location = New System.Drawing.Point(319, 64)
        Me.nudResearchQuality.Name = "nudResearchQuality"
        Me.nudResearchQuality.Size = New System.Drawing.Size(47, 22)
        Me.nudResearchQuality.TabIndex = 51
        Me.nudResearchQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudResearchQuality.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(176, 66)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 16)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Pres:"
        '
        'nudPresentationQuality
        '
        Me.nudPresentationQuality.Location = New System.Drawing.Point(216, 64)
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
        Me.llblGenerateImprovements.Location = New System.Drawing.Point(313, 247)
        Me.llblGenerateImprovements.Name = "llblGenerateImprovements"
        Me.llblGenerateImprovements.Size = New System.Drawing.Size(52, 16)
        Me.llblGenerateImprovements.TabIndex = 53
        Me.llblGenerateImprovements.TabStop = True
        Me.llblGenerateImprovements.Text = "<< Gen"
        '
        'llblAbsent
        '
        Me.llblAbsent.AutoSize = True
        Me.llblAbsent.Location = New System.Drawing.Point(2, 90)
        Me.llblAbsent.Name = "llblAbsent"
        Me.llblAbsent.Size = New System.Drawing.Size(49, 16)
        Me.llblAbsent.TabIndex = 54
        Me.llblAbsent.TabStop = True
        Me.llblAbsent.Text = "Absent"
        '
        'lblImprovementCharCount
        '
        Me.lblImprovementCharCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImprovementCharCount.AutoSize = True
        Me.lblImprovementCharCount.Location = New System.Drawing.Point(310, 268)
        Me.lblImprovementCharCount.Name = "lblImprovementCharCount"
        Me.lblImprovementCharCount.Size = New System.Drawing.Size(15, 16)
        Me.lblImprovementCharCount.TabIndex = 55
        Me.lblImprovementCharCount.Text = "0"
        '
        'picLanguageMark
        '
        Me.picLanguageMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLanguageMark.Image = CType(resources.GetObject("picLanguageMark.Image"), System.Drawing.Image)
        Me.picLanguageMark.Location = New System.Drawing.Point(68, 158)
        Me.picLanguageMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLanguageMark.Name = "picLanguageMark"
        Me.picLanguageMark.Size = New System.Drawing.Size(239, 24)
        Me.picLanguageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLanguageMark.TabIndex = 4
        Me.picLanguageMark.TabStop = False
        '
        'picPresentationMark
        '
        Me.picPresentationMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPresentationMark.Image = CType(resources.GetObject("picPresentationMark.Image"), System.Drawing.Image)
        Me.picPresentationMark.Location = New System.Drawing.Point(68, 134)
        Me.picPresentationMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPresentationMark.Name = "picPresentationMark"
        Me.picPresentationMark.Size = New System.Drawing.Size(239, 24)
        Me.picPresentationMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPresentationMark.TabIndex = 2
        Me.picPresentationMark.TabStop = False
        '
        'picContentMark
        '
        Me.picContentMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picContentMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picContentMark.Image = Global.Teaching.My.Resources.Resources.MarkingGridForPresentationsInverse
        Me.picContentMark.Location = New System.Drawing.Point(68, 110)
        Me.picContentMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picContentMark.Name = "picContentMark"
        Me.picContentMark.Size = New System.Drawing.Size(239, 24)
        Me.picContentMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContentMark.TabIndex = 0
        Me.picContentMark.TabStop = False
        '
        'llblClearChecks
        '
        Me.llblClearChecks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblClearChecks.AutoSize = True
        Me.llblClearChecks.Location = New System.Drawing.Point(317, 284)
        Me.llblClearChecks.Name = "llblClearChecks"
        Me.llblClearChecks.Size = New System.Drawing.Size(49, 16)
        Me.llblClearChecks.TabIndex = 56
        Me.llblClearChecks.TabStop = True
        Me.llblClearChecks.Text = "Clear X"
        '
        'IndividualMarkInGroupPresentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.llblClearChecks)
        Me.Controls.Add(Me.lblImprovementCharCount)
        Me.Controls.Add(Me.llblAbsent)
        Me.Controls.Add(Me.llblGenerateImprovements)
        Me.Controls.Add(Me.nudPresentationQuality)
        Me.Controls.Add(Me.nudResearchQuality)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.nudSecondGrade)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.nudFirstGrade)
        Me.Controls.Add(Me.txtExtID)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtTags)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtNickname)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtLocalName)
        Me.Controls.Add(Me.Label17)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picLanguageMark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picPresentationMark)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picContentMark)
        Me.Controls.Add(Me.chkNominate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picPresentationMark As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents chkNominate As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLocalName As System.Windows.Forms.TextBox
    Friend WithEvents txtNickname As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTags As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtExtID As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
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

End Class
