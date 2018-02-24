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
        Me.chkIncludesAttachment = New System.Windows.Forms.CheckBox()
        Me.dtpReleaseDate = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpSubmitDate = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.nudMaxPoints = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudWeighting = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtOverallDefaultText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lstAssessmentCategories = New System.Windows.Forms.ListBox()
        Me.llblDeleteCategory = New System.Windows.Forms.LinkLabel()
        Me.llblAddCategory = New System.Windows.Forms.LinkLabel()
        Me.cboAssessmentCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
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
        'chkIncludesAttachment
        '
        Me.chkIncludesAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncludesAttachment.AutoSize = True
        Me.chkIncludesAttachment.BackColor = System.Drawing.Color.Transparent
        Me.chkIncludesAttachment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIncludesAttachment.Location = New System.Drawing.Point(542, 18)
        Me.chkIncludesAttachment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIncludesAttachment.Name = "chkIncludesAttachment"
        Me.chkIncludesAttachment.Size = New System.Drawing.Size(148, 20)
        Me.chkIncludesAttachment.TabIndex = 57
        Me.chkIncludesAttachment.Text = "Includes attachment:"
        Me.ToolTip1.SetToolTip(Me.chkIncludesAttachment, "If checked, when emailing module results, user will be prompted for attachment")
        Me.chkIncludesAttachment.UseVisualStyleBackColor = False
        '
        'dtpReleaseDate
        '
        Me.dtpReleaseDate.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReleaseDate.Location = New System.Drawing.Point(421, 81)
        Me.dtpReleaseDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpReleaseDate.Name = "dtpReleaseDate"
        Me.dtpReleaseDate.Size = New System.Drawing.Size(148, 21)
        Me.dtpReleaseDate.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.dtpReleaseDate, "The date that this assignment is given to students")
        '
        'dtpSubmitDate
        '
        Me.dtpSubmitDate.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpSubmitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSubmitDate.Location = New System.Drawing.Point(120, 80)
        Me.dtpSubmitDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSubmitDate.Name = "dtpSubmitDate"
        Me.dtpSubmitDate.Size = New System.Drawing.Size(148, 21)
        Me.dtpSubmitDate.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.dtpSubmitDate, "The date that this assignment should be submitted by students")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(228, 535)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 31)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'nudMaxPoints
        '
        Me.nudMaxPoints.Location = New System.Drawing.Point(120, 46)
        Me.nudMaxPoints.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudMaxPoints.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMaxPoints.Name = "nudMaxPoints"
        Me.nudMaxPoints.Size = New System.Drawing.Size(86, 21)
        Me.nudMaxPoints.TabIndex = 53
        Me.nudMaxPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxPoints.ThousandsSeparator = True
        Me.nudMaxPoints.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(13, 47)
        Me.KryptonLabel9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(79, 19)
        Me.KryptonLabel9.TabIndex = 54
        Me.KryptonLabel9.Values.Text = "Max points:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(239, 49)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel2.TabIndex = 59
        Me.KryptonLabel2.Values.Text = "Weighting:"
        '
        'nudWeighting
        '
        Me.nudWeighting.DecimalPlaces = 2
        Me.nudWeighting.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWeighting.Location = New System.Drawing.Point(328, 47)
        Me.nudWeighting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudWeighting.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWeighting.Name = "nudWeighting"
        Me.nudWeighting.Size = New System.Drawing.Size(86, 21)
        Me.nudWeighting.TabIndex = 58
        Me.nudWeighting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudWeighting.ThousandsSeparator = True
        Me.nudWeighting.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 110)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel1.TabIndex = 25
        Me.KryptonLabel1.Values.Text = "Overall:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(318, 82)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(93, 19)
        Me.KryptonLabel4.TabIndex = 60
        Me.KryptonLabel4.Values.Text = "Release date:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(13, 82)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(86, 19)
        Me.KryptonLabel5.TabIndex = 61
        Me.KryptonLabel5.Values.Text = "Submit date:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 15)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel3.TabIndex = 25
        Me.KryptonLabel3.Values.Text = "Name:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(376, 535)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(105, 31)
        Me.btnOK.TabIndex = 56
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.lstAssessmentCategories)
        Me.KryptonPanel.Controls.Add(Me.llblDeleteCategory)
        Me.KryptonPanel.Controls.Add(Me.llblAddCategory)
        Me.KryptonPanel.Controls.Add(Me.cboAssessmentCategory)
        Me.KryptonPanel.Controls.Add(Me.Label3)
        Me.KryptonPanel.Controls.Add(Me.dtpSubmitDate)
        Me.KryptonPanel.Controls.Add(Me.dtpReleaseDate)
        Me.KryptonPanel.Controls.Add(Me.btnOK)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.txtName)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.nudWeighting)
        Me.KryptonPanel.Controls.Add(Me.txtOverallDefaultText)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.chkIncludesAttachment)
        Me.KryptonPanel.Controls.Add(Me.nudMaxPoints)
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(705, 581)
        Me.KryptonPanel.TabIndex = 64
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(120, 15)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(417, 19)
        Me.txtName.TabIndex = 26
        '
        'txtOverallDefaultText
        '
        Me.txtOverallDefaultText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOverallDefaultText.Location = New System.Drawing.Point(120, 114)
        Me.txtOverallDefaultText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOverallDefaultText.Multiline = True
        Me.txtOverallDefaultText.Name = "txtOverallDefaultText"
        Me.txtOverallDefaultText.Size = New System.Drawing.Size(570, 186)
        Me.txtOverallDefaultText.TabIndex = 26
        '
        'lstAssessmentCategories
        '
        Me.lstAssessmentCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAssessmentCategories.FormattingEnabled = True
        Me.lstAssessmentCategories.ItemHeight = 16
        Me.lstAssessmentCategories.Location = New System.Drawing.Point(120, 313)
        Me.lstAssessmentCategories.Name = "lstAssessmentCategories"
        Me.lstAssessmentCategories.Size = New System.Drawing.Size(282, 196)
        Me.lstAssessmentCategories.TabIndex = 68
        '
        'llblDeleteCategory
        '
        Me.llblDeleteCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblDeleteCategory.AutoSize = True
        Me.llblDeleteCategory.Location = New System.Drawing.Point(408, 395)
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
        Me.llblAddCategory.Location = New System.Drawing.Point(408, 365)
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
        Me.cboAssessmentCategory.Location = New System.Drawing.Point(408, 313)
        Me.cboAssessmentCategory.Name = "cboAssessmentCategory"
        Me.cboAssessmentCategory.Size = New System.Drawing.Size(146, 24)
        Me.cboAssessmentCategory.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Categories:"
        '
        'ClassAssignmentNormalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 581)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClassAssignmentNormalDetails"
        Me.Text = "Class Assignment Details"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents nudMaxPoints As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents chkIncludesAttachment As System.Windows.Forms.CheckBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudWeighting As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtpReleaseDate As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpSubmitDate As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtOverallDefaultText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lstAssessmentCategories As System.Windows.Forms.ListBox
    Friend WithEvents llblDeleteCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents llblAddCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents cboAssessmentCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
