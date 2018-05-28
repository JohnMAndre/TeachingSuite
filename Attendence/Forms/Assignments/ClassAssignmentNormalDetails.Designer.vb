<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassAssignmentNormalDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassAssignmentNormalDetails))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstAssessmentCategories = New System.Windows.Forms.ListBox()
        Me.llblDeleteCategory = New System.Windows.Forms.LinkLabel()
        Me.llblAddCategory = New System.Windows.Forms.LinkLabel()
        Me.cboAssessmentCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOverallDefaultText = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.nudMaxPoints = New System.Windows.Forms.NumericUpDown()
        Me.nudWeighting = New System.Windows.Forms.NumericUpDown()
        Me.dtpSubmitDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReleaseDate = New System.Windows.Forms.DateTimePicker()
        Me.chkIncludesAttachment = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.nudMaxPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWeighting, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lstAssessmentCategories
        '
        Me.lstAssessmentCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAssessmentCategories.FormattingEnabled = True
        Me.lstAssessmentCategories.ItemHeight = 16
        Me.lstAssessmentCategories.Location = New System.Drawing.Point(92, 358)
        Me.lstAssessmentCategories.Name = "lstAssessmentCategories"
        Me.lstAssessmentCategories.Size = New System.Drawing.Size(356, 132)
        Me.lstAssessmentCategories.TabIndex = 68
        '
        'llblDeleteCategory
        '
        Me.llblDeleteCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblDeleteCategory.AutoSize = True
        Me.llblDeleteCategory.Location = New System.Drawing.Point(454, 429)
        Me.llblDeleteCategory.Name = "llblDeleteCategory"
        Me.llblDeleteCategory.Size = New System.Drawing.Size(98, 16)
        Me.llblDeleteCategory.TabIndex = 67
        Me.llblDeleteCategory.TabStop = True
        Me.llblDeleteCategory.Text = "Delete selected"
        '
        'llblAddCategory
        '
        Me.llblAddCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddCategory.AutoSize = True
        Me.llblAddCategory.Location = New System.Drawing.Point(454, 399)
        Me.llblAddCategory.Name = "llblAddCategory"
        Me.llblAddCategory.Size = New System.Drawing.Size(85, 16)
        Me.llblAddCategory.TabIndex = 66
        Me.llblAddCategory.TabStop = True
        Me.llblAddCategory.Text = "Add category"
        '
        'cboAssessmentCategory
        '
        Me.cboAssessmentCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAssessmentCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssessmentCategory.FormattingEnabled = True
        Me.cboAssessmentCategory.Location = New System.Drawing.Point(457, 358)
        Me.cboAssessmentCategory.Name = "cboAssessmentCategory"
        Me.cboAssessmentCategory.Size = New System.Drawing.Size(146, 24)
        Me.cboAssessmentCategory.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Categories:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Max points:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Weighting:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Release date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Due date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Overall:"
        '
        'txtOverallDefaultText
        '
        Me.txtOverallDefaultText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOverallDefaultText.Location = New System.Drawing.Point(92, 103)
        Me.txtOverallDefaultText.Multiline = True
        Me.txtOverallDefaultText.Name = "txtOverallDefaultText"
        Me.txtOverallDefaultText.Size = New System.Drawing.Size(511, 249)
        Me.txtOverallDefaultText.TabIndex = 71
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(92, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(326, 22)
        Me.txtName.TabIndex = 72
        '
        'nudMaxPoints
        '
        Me.nudMaxPoints.Location = New System.Drawing.Point(92, 37)
        Me.nudMaxPoints.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMaxPoints.Name = "nudMaxPoints"
        Me.nudMaxPoints.Size = New System.Drawing.Size(86, 22)
        Me.nudMaxPoints.TabIndex = 73
        Me.nudMaxPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxPoints.ThousandsSeparator = True
        Me.nudMaxPoints.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudWeighting
        '
        Me.nudWeighting.DecimalPlaces = 2
        Me.nudWeighting.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWeighting.Location = New System.Drawing.Point(331, 39)
        Me.nudWeighting.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWeighting.Name = "nudWeighting"
        Me.nudWeighting.Size = New System.Drawing.Size(86, 22)
        Me.nudWeighting.TabIndex = 73
        Me.nudWeighting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudWeighting.ThousandsSeparator = True
        Me.nudWeighting.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpSubmitDate
        '
        Me.dtpSubmitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSubmitDate.Location = New System.Drawing.Point(92, 68)
        Me.dtpSubmitDate.Name = "dtpSubmitDate"
        Me.dtpSubmitDate.Size = New System.Drawing.Size(123, 22)
        Me.dtpSubmitDate.TabIndex = 74
        '
        'dtpReleaseDate
        '
        Me.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReleaseDate.Location = New System.Drawing.Point(331, 68)
        Me.dtpReleaseDate.Name = "dtpReleaseDate"
        Me.dtpReleaseDate.Size = New System.Drawing.Size(123, 22)
        Me.dtpReleaseDate.TabIndex = 74
        '
        'chkIncludesAttachment
        '
        Me.chkIncludesAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncludesAttachment.AutoSize = True
        Me.chkIncludesAttachment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIncludesAttachment.Location = New System.Drawing.Point(450, 10)
        Me.chkIncludesAttachment.Name = "chkIncludesAttachment"
        Me.chkIncludesAttachment.Size = New System.Drawing.Size(148, 20)
        Me.chkIncludesAttachment.TabIndex = 75
        Me.chkIncludesAttachment.Text = "Includes attachment:"
        Me.chkIncludesAttachment.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(173, 507)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 35)
        Me.btnCancel.TabIndex = 76
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(325, 507)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(105, 35)
        Me.btnOK.TabIndex = 77
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'ClassAssignmentNormalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 553)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chkIncludesAttachment)
        Me.Controls.Add(Me.dtpReleaseDate)
        Me.Controls.Add(Me.dtpSubmitDate)
        Me.Controls.Add(Me.nudWeighting)
        Me.Controls.Add(Me.nudMaxPoints)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtOverallDefaultText)
        Me.Controls.Add(Me.lstAssessmentCategories)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.llblDeleteCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.llblAddCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboAssessmentCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClassAssignmentNormalDetails"
        Me.Text = "Normal Assignment Details"
        CType(Me.nudMaxPoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWeighting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents lstAssessmentCategories As System.Windows.Forms.ListBox
    Friend WithEvents llblDeleteCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents llblAddCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents cboAssessmentCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOverallDefaultText As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents nudMaxPoints As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudWeighting As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpSubmitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReleaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkIncludesAttachment As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
