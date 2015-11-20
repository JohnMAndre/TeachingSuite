<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblOutput = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.rtbOutput = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudMaxFilesToPrint = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPath = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearOutput = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPrinted = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.lblPrinted)
        Me.KryptonPanel.Controls.Add(Me.lblOutput)
        Me.KryptonPanel.Controls.Add(Me.rtbOutput)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.nudMaxFilesToPrint)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtPath)
        Me.KryptonPanel.Controls.Add(Me.llblClearOutput)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(716, 343)
        Me.KryptonPanel.TabIndex = 0
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(12, 160)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(52, 20)
        Me.lblOutput.TabIndex = 119
        Me.lblOutput.Values.Text = "Results:"
        '
        'rtbOutput
        '
        Me.rtbOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbOutput.Location = New System.Drawing.Point(184, 160)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.ReadOnly = True
        Me.rtbOutput.Size = New System.Drawing.Size(520, 133)
        Me.rtbOutput.TabIndex = 118
        Me.rtbOutput.Text = ""
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(258, 134)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel4.TabIndex = 117
        Me.KryptonLabel4.Values.Text = "(0 = print all)"
        '
        'nudMaxFilesToPrint
        '
        Me.nudMaxFilesToPrint.Location = New System.Drawing.Point(184, 132)
        Me.nudMaxFilesToPrint.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudMaxFilesToPrint.Name = "nudMaxFilesToPrint"
        Me.nudMaxFilesToPrint.Size = New System.Drawing.Size(68, 22)
        Me.nudMaxFilesToPrint.TabIndex = 116
        Me.nudMaxFilesToPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxFilesToPrint.ThousandsSeparator = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 134)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(166, 20)
        Me.KryptonLabel3.TabIndex = 70
        Me.KryptonLabel3.Values.Text = "Max number of files to print:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(134, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(441, 53)
        Me.KryptonLabel2.TabIndex = 69
        Me.KryptonLabel2.Values.Text = "All Word documents in the folder will be printed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Choose the printer after click" & _
    "ing OK."
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 108)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(155, 20)
        Me.KryptonLabel1.TabIndex = 67
        Me.KryptonLabel1.Values.Text = "Path to Word files to print:"
        '
        'txtPath
        '
        Me.txtPath.AllowDrop = True
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(184, 108)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(520, 20)
        Me.txtPath.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.txtPath, "Drag-and-drop folder here")
        '
        'llblClearOutput
        '
        Me.llblClearOutput.Location = New System.Drawing.Point(134, 160)
        Me.llblClearOutput.Name = "llblClearOutput"
        Me.llblClearOutput.Size = New System.Drawing.Size(44, 20)
        Me.llblClearOutput.TabIndex = 121
        Me.llblClearOutput.Values.Text = "(clear)"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(377, 299)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 70
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(250, 299)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'lblPrinted
        '
        Me.lblPrinted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrinted.Location = New System.Drawing.Point(698, 134)
        Me.lblPrinted.Name = "lblPrinted"
        Me.lblPrinted.Size = New System.Drawing.Size(6, 2)
        Me.lblPrinted.TabIndex = 122
        Me.lblPrinted.Values.Text = ""
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 343)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Batch Printing Utility"
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
    Friend WithEvents txtPath As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudMaxFilesToPrint As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents lblOutput As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rtbOutput As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents llblClearOutput As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPrinted As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
