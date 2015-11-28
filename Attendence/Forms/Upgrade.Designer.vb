<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Upgrade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Upgrade))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.llblGoToShop = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.pbCancel = New System.Windows.Forms.PictureBox()
        Me.pbActivate = New System.Windows.Forms.PictureBox()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbActivate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtEmail)
        Me.KryptonPanel.Controls.Add(Me.llblGoToShop)
        Me.KryptonPanel.Controls.Add(Me.Label3)
        Me.KryptonPanel.Controls.Add(Me.Label1)
        Me.KryptonPanel.Controls.Add(Me.Label2)
        Me.KryptonPanel.Controls.Add(Me.txtCode)
        Me.KryptonPanel.Controls.Add(Me.pbCancel)
        Me.KryptonPanel.Controls.Add(Me.pbActivate)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Palette = Me.KryptonPalette1
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel.Size = New System.Drawing.Size(568, 400)
        Me.KryptonPanel.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BackColor = System.Drawing.Color.Khaki
        Me.txtEmail.Location = New System.Drawing.Point(189, 113)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(366, 20)
        Me.txtEmail.TabIndex = 34
        '
        'llblGoToShop
        '
        Me.llblGoToShop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblGoToShop.BackColor = System.Drawing.Color.Transparent
        Me.llblGoToShop.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGoToShop.LinkArea = New System.Windows.Forms.LinkArea(6, 19)
        Me.llblGoToShop.Location = New System.Drawing.Point(12, 49)
        Me.llblGoToShop.Name = "llblGoToShop"
        Me.llblGoToShop.Size = New System.Drawing.Size(543, 36)
        Me.llblGoToShop.TabIndex = 41
        Me.llblGoToShop.TabStop = True
        Me.llblGoToShop.Text = "Email John@JohnMAndre.com to get an upgrade code."
        Me.llblGoToShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.llblGoToShop.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(543, 40)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Upgrade to Teaching App Premium"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 27)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Your email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 27)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Upgrade code:"
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.BackColor = System.Drawing.Color.Khaki
        Me.txtCode.Location = New System.Drawing.Point(189, 153)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(366, 20)
        Me.txtCode.TabIndex = 35
        '
        'pbCancel
        '
        Me.pbCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbCancel.BackColor = System.Drawing.Color.Transparent
        Me.pbCancel.Image = Global.Teaching.My.Resources.Resources.cancelButton
        Me.pbCancel.Location = New System.Drawing.Point(104, 227)
        Me.pbCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbCancel.Name = "pbCancel"
        Me.pbCancel.Size = New System.Drawing.Size(150, 150)
        Me.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCancel.TabIndex = 40
        Me.pbCancel.TabStop = False
        '
        'pbActivate
        '
        Me.pbActivate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbActivate.BackColor = System.Drawing.Color.Transparent
        Me.pbActivate.Image = Global.Teaching.My.Resources.Resources.activateButton
        Me.pbActivate.Location = New System.Drawing.Point(320, 227)
        Me.pbActivate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbActivate.Name = "pbActivate"
        Me.pbActivate.Size = New System.Drawing.Size(150, 150)
        Me.pbActivate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbActivate.TabIndex = 39
        Me.pbActivate.TabStop = False
        '
        'Upgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 400)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Upgrade"
        Me.Text = "Upgrade to Premium"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbActivate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents llblGoToShop As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents pbCancel As System.Windows.Forms.PictureBox
    Friend WithEvents pbActivate As System.Windows.Forms.PictureBox
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
