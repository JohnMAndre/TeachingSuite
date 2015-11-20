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
        Me.txtName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.nudMaxPoints = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOverallDefaultText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkIncludesAttachment = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.nudWeighting = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpSubmitDate = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpReleaseDate = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(87, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(315, 20)
        Me.txtName.TabIndex = 26
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel3.TabIndex = 25
        Me.KryptonLabel3.Values.Text = "Name:"
        '
        'nudMaxPoints
        '
        Me.nudMaxPoints.Location = New System.Drawing.Point(87, 38)
        Me.nudMaxPoints.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMaxPoints.Name = "nudMaxPoints"
        Me.nudMaxPoints.Size = New System.Drawing.Size(74, 22)
        Me.nudMaxPoints.TabIndex = 53
        Me.nudMaxPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxPoints.ThousandsSeparator = True
        Me.nudMaxPoints.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(12, 38)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel9.TabIndex = 54
        Me.KryptonLabel9.Values.Text = "Max points:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(294, 250)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 56
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(167, 250)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 89)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel1.TabIndex = 25
        Me.KryptonLabel1.Values.Text = "Overall:"
        '
        'txtOverallDefaultText
        '
        Me.txtOverallDefaultText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOverallDefaultText.Location = New System.Drawing.Point(87, 93)
        Me.txtOverallDefaultText.Multiline = True
        Me.txtOverallDefaultText.Name = "txtOverallDefaultText"
        Me.txtOverallDefaultText.Size = New System.Drawing.Size(446, 151)
        Me.txtOverallDefaultText.TabIndex = 26
        '
        'chkIncludesAttachment
        '
        Me.chkIncludesAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncludesAttachment.AutoSize = True
        Me.chkIncludesAttachment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIncludesAttachment.Location = New System.Drawing.Point(408, 15)
        Me.chkIncludesAttachment.Name = "chkIncludesAttachment"
        Me.chkIncludesAttachment.Size = New System.Drawing.Size(125, 17)
        Me.chkIncludesAttachment.TabIndex = 57
        Me.chkIncludesAttachment.Text = "Includes attachment:"
        Me.ToolTip1.SetToolTip(Me.chkIncludesAttachment, "If checked, when emailing module results, user will be prompted for attachment")
        Me.chkIncludesAttachment.UseVisualStyleBackColor = True
        '
        'nudWeighting
        '
        Me.nudWeighting.DecimalPlaces = 2
        Me.nudWeighting.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWeighting.Location = New System.Drawing.Point(282, 38)
        Me.nudWeighting.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWeighting.Name = "nudWeighting"
        Me.nudWeighting.Size = New System.Drawing.Size(74, 22)
        Me.nudWeighting.TabIndex = 58
        Me.nudWeighting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudWeighting.ThousandsSeparator = True
        Me.nudWeighting.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(206, 40)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel2.TabIndex = 59
        Me.KryptonLabel2.Values.Text = "Weighting:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(274, 67)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(82, 20)
        Me.KryptonLabel4.TabIndex = 60
        Me.KryptonLabel4.Values.Text = "Release date:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 67)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel5.TabIndex = 61
        Me.KryptonLabel5.Values.Text = "Submit date:"
        '
        'dtpSubmitDate
        '
        Me.dtpSubmitDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSubmitDate.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpSubmitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSubmitDate.Location = New System.Drawing.Point(87, 66)
        Me.dtpSubmitDate.Name = "dtpSubmitDate"
        Me.dtpSubmitDate.Size = New System.Drawing.Size(127, 21)
        Me.dtpSubmitDate.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.dtpSubmitDate, "The date that this assignment should be submitted by students")
        '
        'dtpReleaseDate
        '
        Me.dtpReleaseDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpReleaseDate.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReleaseDate.Location = New System.Drawing.Point(362, 66)
        Me.dtpReleaseDate.Name = "dtpReleaseDate"
        Me.dtpReleaseDate.Size = New System.Drawing.Size(127, 21)
        Me.dtpReleaseDate.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.dtpReleaseDate, "The date that this assignment is given to students")
        '
        'ClassAssignmentNormalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 287)
        Me.Controls.Add(Me.dtpReleaseDate)
        Me.Controls.Add(Me.dtpSubmitDate)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.KryptonLabel4)
        Me.Controls.Add(Me.nudWeighting)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.chkIncludesAttachment)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.nudMaxPoints)
        Me.Controls.Add(Me.KryptonLabel9)
        Me.Controls.Add(Me.txtOverallDefaultText)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.KryptonLabel3)
        Me.Name = "ClassAssignmentNormalDetails"
        Me.Text = "Class Assignment Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents nudMaxPoints As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOverallDefaultText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkIncludesAttachment As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents nudWeighting As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpSubmitDate As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpReleaseDate As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
End Class
