<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportClassFromSemester
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportClassFromSemester))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.splitOverall = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer3 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.lstClassGroups = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.lstClasses = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lstAssignments = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.lblAssignments = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnLoadSemester = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboSemester = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.Panel1.SuspendLayout()
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.SuspendLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel2.SuspendLayout()
        Me.KryptonSplitContainer3.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        CType(Me.cboSemester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.splitOverall)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(557, 450)
        Me.KryptonPanel.TabIndex = 0
        '
        'splitOverall
        '
        Me.splitOverall.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitOverall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitOverall.Location = New System.Drawing.Point(0, 42)
        Me.splitOverall.Name = "splitOverall"
        '
        'splitOverall.Panel1
        '
        Me.splitOverall.Panel1.Controls.Add(Me.KryptonSplitContainer3)
        Me.splitOverall.Panel2Collapsed = True
        Me.splitOverall.Size = New System.Drawing.Size(557, 367)
        Me.splitOverall.SplitterDistance = 94
        Me.splitOverall.TabIndex = 31
        '
        'KryptonSplitContainer3
        '
        Me.KryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer3.Name = "KryptonSplitContainer3"
        Me.KryptonSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer3.Panel1
        '
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.lstClassGroups)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.KryptonLabel11)
        '
        'KryptonSplitContainer3.Panel2
        '
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonSplitContainer3.Size = New System.Drawing.Size(557, 367)
        Me.KryptonSplitContainer3.SplitterDistance = 122
        Me.KryptonSplitContainer3.TabIndex = 28
        '
        'lstClassGroups
        '
        Me.lstClassGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstClassGroups.Location = New System.Drawing.Point(0, 19)
        Me.lstClassGroups.Name = "lstClassGroups"
        Me.lstClassGroups.Size = New System.Drawing.Size(557, 103)
        Me.lstClassGroups.TabIndex = 28
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel11.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(557, 19)
        Me.KryptonLabel11.TabIndex = 3
        Me.KryptonLabel11.Values.Text = "Modules"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lstClasses)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel10)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.lstAssignments)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.lblAssignments)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(557, 240)
        Me.KryptonSplitContainer1.SplitterDistance = 107
        Me.KryptonSplitContainer1.TabIndex = 27
        '
        'lstClasses
        '
        Me.lstClasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstClasses.Location = New System.Drawing.Point(0, 19)
        Me.lstClasses.Name = "lstClasses"
        Me.lstClasses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstClasses.Size = New System.Drawing.Size(557, 88)
        Me.lstClasses.TabIndex = 0
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel10.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(557, 19)
        Me.KryptonLabel10.TabIndex = 2
        Me.KryptonLabel10.Values.Text = "Classes"
        '
        'lstAssignments
        '
        Me.lstAssignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAssignments.Location = New System.Drawing.Point(0, 19)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAssignments.Size = New System.Drawing.Size(557, 109)
        Me.lstAssignments.TabIndex = 4
        '
        'lblAssignments
        '
        Me.lblAssignments.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAssignments.Location = New System.Drawing.Point(0, 0)
        Me.lblAssignments.Name = "lblAssignments"
        Me.lblAssignments.Size = New System.Drawing.Size(557, 19)
        Me.lblAssignments.TabIndex = 3
        Me.lblAssignments.Values.Text = "Assignments"
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.btnLoadSemester)
        Me.KryptonPanel3.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel3.Controls.Add(Me.cboSemester)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(557, 42)
        Me.KryptonPanel3.TabIndex = 30
        '
        'btnLoadSemester
        '
        Me.btnLoadSemester.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadSemester.Enabled = False
        Me.btnLoadSemester.Location = New System.Drawing.Point(523, 12)
        Me.btnLoadSemester.Name = "btnLoadSemester"
        Me.btnLoadSemester.Size = New System.Drawing.Size(22, 18)
        Me.btnLoadSemester.TabIndex = 23
        Me.btnLoadSemester.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnLoadSemester.Values.Text = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(72, 19)
        Me.KryptonLabel3.TabIndex = 7
        Me.KryptonLabel3.Values.Text = "Semester:"
        '
        'cboSemester
        '
        Me.cboSemester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.DropDownWidth = 121
        Me.cboSemester.Location = New System.Drawing.Point(82, 11)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(435, 20)
        Me.cboSemester.TabIndex = 6
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnOK)
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 409)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(557, 41)
        Me.KryptonPanel1.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(297, 10)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 28)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(170, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
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
        'ImportClassFromSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 450)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportClassFromSemester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Class from Semester"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.Panel1.ResumeLayout(False)
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        Me.KryptonPanel3.PerformLayout()
        CType(Me.cboSemester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboSemester As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents splitOverall As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonSplitContainer3 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents lstClassGroups As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents lstClasses As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lstAssignments As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents lblAssignments As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnLoadSemester As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
