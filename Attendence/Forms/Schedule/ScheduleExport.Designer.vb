<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleExport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleExport))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lstClassGroups = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.chkCreateRollbackFile = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkExportAllSessions = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudAlarmMinutes = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.llblBrowseForExportFilename = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFilename = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkSetAlarm = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtFilename)
        Me.KryptonPanel.Controls.Add(Me.lstClassGroups)
        Me.KryptonPanel.Controls.Add(Me.chkCreateRollbackFile)
        Me.KryptonPanel.Controls.Add(Me.chkExportAllSessions)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.nudAlarmMinutes)
        Me.KryptonPanel.Controls.Add(Me.llblBrowseForExportFilename)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.chkSetAlarm)
        Me.KryptonPanel.Controls.Add(Me.btnOK)
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(709, 246)
        Me.KryptonPanel.TabIndex = 0
        '
        'lstClassGroups
        '
        Me.lstClassGroups.Location = New System.Drawing.Point(0, 38)
        Me.lstClassGroups.Name = "lstClassGroups"
        Me.lstClassGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstClassGroups.Size = New System.Drawing.Size(131, 205)
        Me.lstClassGroups.TabIndex = 139
        '
        'chkCreateRollbackFile
        '
        Me.chkCreateRollbackFile.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkCreateRollbackFile.Location = New System.Drawing.Point(137, 136)
        Me.chkCreateRollbackFile.Name = "chkCreateRollbackFile"
        Me.chkCreateRollbackFile.Size = New System.Drawing.Size(304, 19)
        Me.chkCreateRollbackFile.TabIndex = 137
        Me.chkCreateRollbackFile.Text = "Create rollback file (import to remove sessions)"
        Me.chkCreateRollbackFile.Values.Text = "Create rollback file (import to remove sessions)"
        '
        'chkExportAllSessions
        '
        Me.chkExportAllSessions.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkExportAllSessions.Location = New System.Drawing.Point(137, 103)
        Me.chkExportAllSessions.Name = "chkExportAllSessions"
        Me.chkExportAllSessions.Size = New System.Drawing.Size(494, 19)
        Me.chkExportAllSessions.TabIndex = 136
        Me.chkExportAllSessions.Text = "Include teaching sessions already past (uncheck to export only future sessions)"
        Me.chkExportAllSessions.Values.Text = "Include teaching sessions already past (uncheck to export only future sessions)"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(313, 64)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(181, 19)
        Me.KryptonLabel1.TabIndex = 135
        Me.KryptonLabel1.Values.Text = "minutes before each session"
        '
        'nudAlarmMinutes
        '
        Me.nudAlarmMinutes.Location = New System.Drawing.Point(236, 64)
        Me.nudAlarmMinutes.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudAlarmMinutes.Name = "nudAlarmMinutes"
        Me.nudAlarmMinutes.Size = New System.Drawing.Size(71, 21)
        Me.nudAlarmMinutes.TabIndex = 134
        Me.nudAlarmMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAlarmMinutes.ThousandsSeparator = True
        Me.nudAlarmMinutes.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'llblBrowseForExportFilename
        '
        Me.llblBrowseForExportFilename.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblBrowseForExportFilename.Location = New System.Drawing.Point(674, 21)
        Me.llblBrowseForExportFilename.Name = "llblBrowseForExportFilename"
        Me.llblBrowseForExportFilename.Size = New System.Drawing.Size(22, 19)
        Me.llblBrowseForExportFilename.TabIndex = 133
        Me.llblBrowseForExportFilename.Values.Text = "..."
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(137, 21)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(130, 19)
        Me.KryptonLabel7.TabIndex = 132
        Me.KryptonLabel7.Values.Text = "Filename for export:"
        '
        'txtFilename
        '
        Me.txtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilename.Location = New System.Drawing.Point(265, 21)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(406, 19)
        Me.txtFilename.TabIndex = 131
        '
        'chkSetAlarm
        '
        Me.chkSetAlarm.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkSetAlarm.Location = New System.Drawing.Point(137, 64)
        Me.chkSetAlarm.Name = "chkSetAlarm"
        Me.chkSetAlarm.Size = New System.Drawing.Size(100, 19)
        Me.chkSetAlarm.TabIndex = 128
        Me.chkSetAlarm.Text = "Set alarm for"
        Me.chkSetAlarm.Values.Text = "Set alarm for"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(372, 209)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 130
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(245, 209)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 129
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(0, 19)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(117, 19)
        Me.KryptonLabel11.TabIndex = 138
        Me.KryptonLabel11.Values.Text = "Modules to export"
        '
        'KryptonManager
        '
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonManager.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'ScheduleExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 246)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ScheduleExport"
        Me.Text = "Teaching Schedule Export"
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
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudAlarmMinutes As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents llblBrowseForExportFilename As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFilename As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkSetAlarm As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents chkExportAllSessions As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkCreateRollbackFile As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lstClassGroups As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
