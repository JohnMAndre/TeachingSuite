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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupPresentationAssessment))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSaveAllKeepOpen = New System.Windows.Forms.Button()
        Me.picMoreInfo = New System.Windows.Forms.PictureBox()
        Me.btnReloadMissing = New System.Windows.Forms.Button()
        Me.btnQuickFeedback = New System.Windows.Forms.Button()
        CType(Me.picMoreInfo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(694, 365)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Location = New System.Drawing.Point(235, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 26)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "&Save all"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(12, 376)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(39, 16)
        Me.lblTimer.TabIndex = 44
        Me.lblTimer.Text = "00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnSaveAllKeepOpen
        '
        Me.btnSaveAllKeepOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSaveAllKeepOpen.Location = New System.Drawing.Point(425, 368)
        Me.btnSaveAllKeepOpen.Name = "btnSaveAllKeepOpen"
        Me.btnSaveAllKeepOpen.Size = New System.Drawing.Size(167, 26)
        Me.btnSaveAllKeepOpen.TabIndex = 45
        Me.btnSaveAllKeepOpen.Text = "Sa&ve (keep marking)"
        Me.btnSaveAllKeepOpen.UseVisualStyleBackColor = True
        '
        'picMoreInfo
        '
        Me.picMoreInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMoreInfo.Image = Global.Teaching.My.Resources.Resources.info_32
        Me.picMoreInfo.Location = New System.Drawing.Point(664, 369)
        Me.picMoreInfo.Name = "picMoreInfo"
        Me.picMoreInfo.Size = New System.Drawing.Size(30, 25)
        Me.picMoreInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMoreInfo.TabIndex = 46
        Me.picMoreInfo.TabStop = False
        '
        'btnReloadMissing
        '
        Me.btnReloadMissing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReloadMissing.Location = New System.Drawing.Point(82, 368)
        Me.btnReloadMissing.Name = "btnReloadMissing"
        Me.btnReloadMissing.Size = New System.Drawing.Size(75, 26)
        Me.btnReloadMissing.TabIndex = 43
        Me.btnReloadMissing.Text = "&Reload"
        Me.btnReloadMissing.UseVisualStyleBackColor = True
        '
        'btnQuickFeedback
        '
        Me.btnQuickFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickFeedback.Location = New System.Drawing.Point(616, 368)
        Me.btnQuickFeedback.Name = "btnQuickFeedback"
        Me.btnQuickFeedback.Size = New System.Drawing.Size(42, 26)
        Me.btnQuickFeedback.TabIndex = 48
        Me.btnQuickFeedback.Text = "Q&F"
        Me.btnQuickFeedback.UseVisualStyleBackColor = True
        '
        'GroupPresentationAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 396)
        Me.Controls.Add(Me.btnQuickFeedback)
        Me.Controls.Add(Me.picMoreInfo)
        Me.Controls.Add(Me.btnSaveAllKeepOpen)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnReloadMissing)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GroupPresentationAssessment"
        Me.Text = "Group Presentation Assessment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picMoreInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSaveAllKeepOpen As System.Windows.Forms.Button
    Friend WithEvents picMoreInfo As PictureBox
    Friend WithEvents btnReloadMissing As Button
    Friend WithEvents btnQuickFeedback As Button
End Class
