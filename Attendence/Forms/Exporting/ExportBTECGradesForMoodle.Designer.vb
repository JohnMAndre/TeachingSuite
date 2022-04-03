<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportBTECGradesForMoodle
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
        Me.lstAssignments = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.chkIncludeRework = New System.Windows.Forms.CheckBox()
        Me.chkIncludeOverallFeedback = New System.Windows.Forms.CheckBox()
        Me.chkIncludeImprovementFeedback = New System.Windows.Forms.CheckBox()
        Me.chkIncludeOutcomeFeedback = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lstAssignments
        '
        Me.lstAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAssignments.FormattingEnabled = True
        Me.lstAssignments.ItemHeight = 18
        Me.lstAssignments.Location = New System.Drawing.Point(15, 39)
        Me.lstAssignments.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAssignments.Size = New System.Drawing.Size(397, 94)
        Me.lstAssignments.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BTEC Assignments"
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExport.Location = New System.Drawing.Point(174, 260)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(101, 29)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(14, 265)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblStatus.TabIndex = 9
        '
        'chkIncludeRework
        '
        Me.chkIncludeRework.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeRework.AutoSize = True
        Me.chkIncludeRework.Checked = True
        Me.chkIncludeRework.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeRework.Location = New System.Drawing.Point(17, 166)
        Me.chkIncludeRework.Name = "chkIncludeRework"
        Me.chkIncludeRework.Size = New System.Drawing.Size(192, 22)
        Me.chkIncludeRework.TabIndex = 19
        Me.chkIncludeRework.Text = "Include Rework (2nd try)"
        Me.chkIncludeRework.UseVisualStyleBackColor = True
        '
        'chkIncludeOverallFeedback
        '
        Me.chkIncludeOverallFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeOverallFeedback.AutoSize = True
        Me.chkIncludeOverallFeedback.Checked = True
        Me.chkIncludeOverallFeedback.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeOverallFeedback.Location = New System.Drawing.Point(17, 194)
        Me.chkIncludeOverallFeedback.Name = "chkIncludeOverallFeedback"
        Me.chkIncludeOverallFeedback.Size = New System.Drawing.Size(196, 22)
        Me.chkIncludeOverallFeedback.TabIndex = 18
        Me.chkIncludeOverallFeedback.Text = "Include Overall feedback"
        Me.chkIncludeOverallFeedback.UseVisualStyleBackColor = True
        '
        'chkIncludeImprovementFeedback
        '
        Me.chkIncludeImprovementFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeImprovementFeedback.AutoSize = True
        Me.chkIncludeImprovementFeedback.Checked = True
        Me.chkIncludeImprovementFeedback.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeImprovementFeedback.Location = New System.Drawing.Point(17, 222)
        Me.chkIncludeImprovementFeedback.Name = "chkIncludeImprovementFeedback"
        Me.chkIncludeImprovementFeedback.Size = New System.Drawing.Size(237, 22)
        Me.chkIncludeImprovementFeedback.TabIndex = 17
        Me.chkIncludeImprovementFeedback.Text = "Include Improvement feedback"
        Me.chkIncludeImprovementFeedback.UseVisualStyleBackColor = True
        '
        'chkIncludeOutcomeFeedback
        '
        Me.chkIncludeOutcomeFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeOutcomeFeedback.AutoSize = True
        Me.chkIncludeOutcomeFeedback.Checked = True
        Me.chkIncludeOutcomeFeedback.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeOutcomeFeedback.Location = New System.Drawing.Point(17, 138)
        Me.chkIncludeOutcomeFeedback.Name = "chkIncludeOutcomeFeedback"
        Me.chkIncludeOutcomeFeedback.Size = New System.Drawing.Size(268, 22)
        Me.chkIncludeOutcomeFeedback.TabIndex = 20
        Me.chkIncludeOutcomeFeedback.Text = "Include detailed outcome feedback"
        Me.chkIncludeOutcomeFeedback.UseVisualStyleBackColor = True
        '
        'ExportBTECGradesForMoodle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 300)
        Me.Controls.Add(Me.chkIncludeOutcomeFeedback)
        Me.Controls.Add(Me.chkIncludeRework)
        Me.Controls.Add(Me.chkIncludeOverallFeedback)
        Me.Controls.Add(Me.chkIncludeImprovementFeedback)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAssignments)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ExportBTECGradesForMoodle"
        Me.Text = "Export BTEC Grades for Moodle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAssignments As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents chkIncludeRework As CheckBox
    Friend WithEvents chkIncludeOverallFeedback As CheckBox
    Friend WithEvents chkIncludeImprovementFeedback As CheckBox
    Friend WithEvents chkIncludeOutcomeFeedback As CheckBox
End Class
