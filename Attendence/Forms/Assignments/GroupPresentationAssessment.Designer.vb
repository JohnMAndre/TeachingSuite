<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupPresentationAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupPresentationAssessment))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(717, 370)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Location = New System.Drawing.Point(320, 373)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "&Save all"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupPresentationAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 396)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GroupPresentationAssessment"
        Me.Text = "Group Presentation Assessment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
