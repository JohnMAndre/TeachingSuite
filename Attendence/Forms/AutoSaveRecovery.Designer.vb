<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoSaveRecovery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoSaveRecovery))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnUseAutoSave = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDeleteAutoSave = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblAutoSaveFileSize = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMainFileSize = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAutoSaveFileDate = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMainFileDate = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.llblMainFileName = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAutoSaveFileName = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(803, 282)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(690, 29)
        Me.KryptonLabel1.TabIndex = 44
        Me.KryptonLabel1.Values.Text = "There is an AutoSave (recovery) file for the selected semester.  Use which file?"
        '
        'btnUseAutoSave
        '
        Me.btnUseAutoSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUseAutoSave.Location = New System.Drawing.Point(536, 55)
        Me.btnUseAutoSave.Name = "btnUseAutoSave"
        Me.btnUseAutoSave.Size = New System.Drawing.Size(240, 25)
        Me.btnUseAutoSave.TabIndex = 43
        Me.btnUseAutoSave.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnUseAutoSave.Values.Text = "Use &AutoSave, delete main data file"
        '
        'btnDeleteAutoSave
        '
        Me.btnDeleteAutoSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteAutoSave.Location = New System.Drawing.Point(536, 55)
        Me.btnDeleteAutoSave.Name = "btnDeleteAutoSave"
        Me.btnDeleteAutoSave.Size = New System.Drawing.Size(240, 25)
        Me.btnDeleteAutoSave.TabIndex = 42
        Me.btnDeleteAutoSave.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnDeleteAutoSave.Values.Text = "Use &main file, delete AutoSave"
        '
        'lblAutoSaveFileSize
        '
        Me.lblAutoSaveFileSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAutoSaveFileSize.Location = New System.Drawing.Point(347, 55)
        Me.lblAutoSaveFileSize.Name = "lblAutoSaveFileSize"
        Me.lblAutoSaveFileSize.Size = New System.Drawing.Size(55, 20)
        Me.lblAutoSaveFileSize.TabIndex = 41
        Me.lblAutoSaveFileSize.Values.Text = "00.0 MB"
        '
        'lblMainFileSize
        '
        Me.lblMainFileSize.Location = New System.Drawing.Point(347, 55)
        Me.lblMainFileSize.Name = "lblMainFileSize"
        Me.lblMainFileSize.Size = New System.Drawing.Size(55, 20)
        Me.lblMainFileSize.TabIndex = 40
        Me.lblMainFileSize.Values.Text = "00.0 MB"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel
        Me.KryptonLabel9.Location = New System.Drawing.Point(285, 55)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel9.TabIndex = 39
        Me.KryptonLabel9.Values.Text = "File size"
        '
        'lblAutoSaveFileDate
        '
        Me.lblAutoSaveFileDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAutoSaveFileDate.Location = New System.Drawing.Point(85, 55)
        Me.lblAutoSaveFileDate.Name = "lblAutoSaveFileDate"
        Me.lblAutoSaveFileDate.Size = New System.Drawing.Size(122, 20)
        Me.lblAutoSaveFileDate.TabIndex = 38
        Me.lblAutoSaveFileDate.Values.Text = "9999-99-99 21:21:21"
        '
        'lblMainFileDate
        '
        Me.lblMainFileDate.Location = New System.Drawing.Point(85, 55)
        Me.lblMainFileDate.Name = "lblMainFileDate"
        Me.lblMainFileDate.Size = New System.Drawing.Size(122, 20)
        Me.lblMainFileDate.TabIndex = 37
        Me.lblMainFileDate.Values.Text = "9999-99-99 21:21:21"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel
        Me.KryptonLabel6.Location = New System.Drawing.Point(6, 55)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel6.TabIndex = 36
        Me.KryptonLabel6.Values.Text = "Last saved"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel3.TabIndex = 33
        Me.KryptonLabel3.Values.Text = "Main data file"
        '
        'llblMainFileName
        '
        Me.llblMainFileName.Location = New System.Drawing.Point(3, 29)
        Me.llblMainFileName.Name = "llblMainFileName"
        Me.llblMainFileName.Size = New System.Drawing.Size(76, 20)
        Me.llblMainFileName.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.llblMainFileName, "Click to show file in its folder")
        Me.llblMainFileName.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblMainFileName.Values.Text = "Most recent"
        '
        'llblAutoSaveFileName
        '
        Me.llblAutoSaveFileName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblAutoSaveFileName.Location = New System.Drawing.Point(6, 29)
        Me.llblAutoSaveFileName.Name = "llblAutoSaveFileName"
        Me.llblAutoSaveFileName.Size = New System.Drawing.Size(76, 20)
        Me.llblAutoSaveFileName.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.llblAutoSaveFileName, "Click to show file in its folder")
        Me.llblAutoSaveFileName.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblAutoSaveFileName.Values.Text = "Most recent"
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel2.Controls.Add(Me.llblMainFileName)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel2.Controls.Add(Me.lblMainFileDate)
        Me.KryptonPanel2.Controls.Add(Me.btnDeleteAutoSave)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel2.Controls.Add(Me.lblMainFileSize)
        Me.KryptonPanel2.Location = New System.Drawing.Point(12, 48)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(779, 96)
        Me.KryptonPanel2.TabIndex = 47
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.llblAutoSaveFileName)
        Me.KryptonPanel1.Controls.Add(Me.btnUseAutoSave)
        Me.KryptonPanel1.Controls.Add(Me.lblAutoSaveFileSize)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.lblAutoSaveFileDate)
        Me.KryptonPanel1.Location = New System.Drawing.Point(12, 174)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(779, 96)
        Me.KryptonPanel1.TabIndex = 48
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel2.TabIndex = 33
        Me.KryptonLabel2.Values.Text = "AutoSave file"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel
        Me.KryptonLabel4.Location = New System.Drawing.Point(6, 55)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel4.TabIndex = 36
        Me.KryptonLabel4.Values.Text = "Last saved"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel
        Me.KryptonLabel7.Location = New System.Drawing.Point(285, 55)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel7.TabIndex = 39
        Me.KryptonLabel7.Values.Text = "File size"
        '
        'AutoSaveRecovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 282)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AutoSaveRecovery"
        Me.Text = "AutoSave Recovery"
        Me.TopMost = True
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAutoSaveFileSize As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMainFileSize As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAutoSaveFileDate As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMainFileDate As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnUseAutoSave As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnDeleteAutoSave As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblMainFileName As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblAutoSaveFileName As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
End Class
