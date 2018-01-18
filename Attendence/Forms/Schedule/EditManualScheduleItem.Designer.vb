<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditManualScheduleItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditManualScheduleItem))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.nudDurationInMinutes = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.dudType = New ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtLocation = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNotes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkSent = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkPrepped = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtTopic = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.nudDurationInMinutes)
        Me.KryptonPanel.Controls.Add(Me.dudType)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.txtLocation)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.btnOK)
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtNotes)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.chkSent)
        Me.KryptonPanel.Controls.Add(Me.chkPrepped)
        Me.KryptonPanel.Controls.Add(Me.txtTopic)
        Me.KryptonPanel.Controls.Add(Me.dtpTime)
        Me.KryptonPanel.Controls.Add(Me.dtpDate)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(437, 198)
        Me.KryptonPanel.TabIndex = 0
        '
        'nudDurationInMinutes
        '
        Me.nudDurationInMinutes.Location = New System.Drawing.Point(367, 39)
        Me.nudDurationInMinutes.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDurationInMinutes.Name = "nudDurationInMinutes"
        Me.nudDurationInMinutes.Size = New System.Drawing.Size(58, 22)
        Me.nudDurationInMinutes.TabIndex = 137
        Me.nudDurationInMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudDurationInMinutes.ThousandsSeparator = True
        Me.nudDurationInMinutes.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'dudType
        '
        Me.dudType.Items.Add("Automatic")
        Me.dudType.Items.Add("Manual")
        Me.dudType.Location = New System.Drawing.Point(62, 64)
        Me.dudType.Name = "dudType"
        Me.dudType.Size = New System.Drawing.Size(156, 22)
        Me.dudType.TabIndex = 73
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(4, 65)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel4.TabIndex = 72
        Me.KryptonLabel4.Values.Text = "Type:"
        '
        'txtLocation
        '
        Me.txtLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocation.Location = New System.Drawing.Point(62, 91)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(363, 20)
        Me.txtLocation.TabIndex = 70
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 91)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel2.TabIndex = 71
        Me.KryptonLabel2.Values.Text = "Location:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(235, 161)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 69
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(108, 161)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 68
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 126)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel1.TabIndex = 67
        Me.KryptonLabel1.Values.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.Location = New System.Drawing.Point(62, 126)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(363, 20)
        Me.txtNotes.TabIndex = 66
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(274, 41)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel5.TabIndex = 65
        Me.KryptonLabel5.Values.Text = "Duration (min):"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 39)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(43, 20)
        Me.KryptonLabel3.TabIndex = 65
        Me.KryptonLabel3.Values.Text = "Topic:"
        '
        'chkSent
        '
        Me.chkSent.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkSent.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkSent.Location = New System.Drawing.Point(367, 65)
        Me.chkSent.Name = "chkSent"
        Me.chkSent.Size = New System.Drawing.Size(50, 20)
        Me.chkSent.TabIndex = 64
        Me.chkSent.Text = "Sent:"
        Me.chkSent.Values.Text = "Sent:"
        '
        'chkPrepped
        '
        Me.chkPrepped.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkPrepped.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkPrepped.Location = New System.Drawing.Point(241, 65)
        Me.chkPrepped.Name = "chkPrepped"
        Me.chkPrepped.Size = New System.Drawing.Size(72, 20)
        Me.chkPrepped.TabIndex = 63
        Me.chkPrepped.Text = "Prepped:"
        Me.chkPrepped.Values.Text = "Prepped:"
        '
        'txtTopic
        '
        Me.txtTopic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTopic.Location = New System.Drawing.Point(62, 39)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(206, 20)
        Me.txtTopic.TabIndex = 28
        '
        'dtpTime
        '
        Me.dtpTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(274, 13)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(151, 20)
        Me.dtpTime.TabIndex = 1
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.Location = New System.Drawing.Point(13, 13)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(255, 20)
        Me.dtpDate.TabIndex = 0
        '
        'EditManualScheduleItem
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(437, 198)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditManualScheduleItem"
        Me.Text = "Edit Schedule Item"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTopic As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkSent As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkPrepped As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNotes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtLocation As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dudType As ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown
    Friend WithEvents nudDurationInMinutes As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
