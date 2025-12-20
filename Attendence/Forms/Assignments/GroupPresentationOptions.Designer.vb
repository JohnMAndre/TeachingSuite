<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupPresentationOptions
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
        Me.txtComponent1Label = New System.Windows.Forms.TextBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudComponent1Weight = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudComponent2Weight = New System.Windows.Forms.NumericUpDown()
        Me.txtComponent2Label = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudComponent3Weight = New System.Windows.Forms.NumericUpDown()
        Me.txtComponent3Label = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.nudComponent1Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudComponent2Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudComponent3Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtComponent1Label
        '
        Me.txtComponent1Label.Location = New System.Drawing.Point(110, 27)
        Me.txtComponent1Label.Name = "txtComponent1Label"
        Me.txtComponent1Label.Size = New System.Drawing.Size(141, 22)
        Me.txtComponent1Label.TabIndex = 4
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.Location = New System.Drawing.Point(118, 8)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(43, 16)
        Me.lblLabel.TabIndex = 45
        Me.lblLabel.Text = "Label"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Component"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(254, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Weighting"
        '
        'nudComponent1Weight
        '
        Me.nudComponent1Weight.Location = New System.Drawing.Point(257, 28)
        Me.nudComponent1Weight.Name = "nudComponent1Weight"
        Me.nudComponent1Weight.Size = New System.Drawing.Size(60, 22)
        Me.nudComponent1Weight.TabIndex = 47
        Me.nudComponent1Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "percent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Component 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Component 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "percent"
        '
        'nudComponent2Weight
        '
        Me.nudComponent2Weight.Location = New System.Drawing.Point(257, 56)
        Me.nudComponent2Weight.Name = "nudComponent2Weight"
        Me.nudComponent2Weight.Size = New System.Drawing.Size(60, 22)
        Me.nudComponent2Weight.TabIndex = 51
        Me.nudComponent2Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComponent2Label
        '
        Me.txtComponent2Label.Location = New System.Drawing.Point(110, 55)
        Me.txtComponent2Label.Name = "txtComponent2Label"
        Me.txtComponent2Label.Size = New System.Drawing.Size(141, 22)
        Me.txtComponent2Label.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Component 3:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "percent"
        '
        'nudComponent3Weight
        '
        Me.nudComponent3Weight.Location = New System.Drawing.Point(257, 84)
        Me.nudComponent3Weight.Name = "nudComponent3Weight"
        Me.nudComponent3Weight.Size = New System.Drawing.Size(60, 22)
        Me.nudComponent3Weight.TabIndex = 55
        Me.nudComponent3Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComponent3Label
        '
        Me.txtComponent3Label.Location = New System.Drawing.Point(110, 83)
        Me.txtComponent3Label.Name = "txtComponent3Label"
        Me.txtComponent3Label.Size = New System.Drawing.Size(141, 22)
        Me.txtComponent3Label.TabIndex = 54
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(158, 111)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 26)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupPresentationOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(404, 139)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nudComponent3Weight)
        Me.Controls.Add(Me.txtComponent3Label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudComponent2Weight)
        Me.Controls.Add(Me.txtComponent2Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudComponent1Weight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.txtComponent1Label)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GroupPresentationOptions"
        Me.Text = "Group Presentation Options"
        CType(Me.nudComponent1Weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudComponent2Weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudComponent3Weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtComponent1Label As TextBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudComponent1Weight As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudComponent2Weight As NumericUpDown
    Friend WithEvents txtComponent2Label As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nudComponent3Weight As NumericUpDown
    Friend WithEvents txtComponent3Label As TextBox
    Friend WithEvents btnSave As Button
End Class
