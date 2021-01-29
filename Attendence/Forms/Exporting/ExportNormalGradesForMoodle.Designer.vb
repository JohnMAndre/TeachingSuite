<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportNormalGradesForMoodle
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAssignments = New System.Windows.Forms.ListBox()
        Me.chkIncludeImprovementFeedback = New System.Windows.Forms.CheckBox()
        Me.chkIncludeOverallFeedback = New System.Windows.Forms.CheckBox()
        Me.chkIncludeRework = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(17, 271)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblStatus.TabIndex = 13
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExport.Location = New System.Drawing.Point(177, 266)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(101, 29)
        Me.btnExport.TabIndex = 12
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Normal Assignments"
        '
        'lstAssignments
        '
        Me.lstAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAssignments.FormattingEnabled = True
        Me.lstAssignments.ItemHeight = 18
        Me.lstAssignments.Location = New System.Drawing.Point(18, 34)
        Me.lstAssignments.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAssignments.Size = New System.Drawing.Size(397, 130)
        Me.lstAssignments.TabIndex = 10
        '
        'chkIncludeImprovementFeedback
        '
        Me.chkIncludeImprovementFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeImprovementFeedback.AutoSize = True
        Me.chkIncludeImprovementFeedback.Checked = True
        Me.chkIncludeImprovementFeedback.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeImprovementFeedback.Location = New System.Drawing.Point(20, 238)
        Me.chkIncludeImprovementFeedback.Name = "chkIncludeImprovementFeedback"
        Me.chkIncludeImprovementFeedback.Size = New System.Drawing.Size(237, 22)
        Me.chkIncludeImprovementFeedback.TabIndex = 14
        Me.chkIncludeImprovementFeedback.Text = "Include Improvement feedback"
        Me.chkIncludeImprovementFeedback.UseVisualStyleBackColor = True
        '
        'chkIncludeOverallFeedback
        '
        Me.chkIncludeOverallFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeOverallFeedback.AutoSize = True
        Me.chkIncludeOverallFeedback.Checked = True
        Me.chkIncludeOverallFeedback.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeOverallFeedback.Location = New System.Drawing.Point(20, 210)
        Me.chkIncludeOverallFeedback.Name = "chkIncludeOverallFeedback"
        Me.chkIncludeOverallFeedback.Size = New System.Drawing.Size(196, 22)
        Me.chkIncludeOverallFeedback.TabIndex = 15
        Me.chkIncludeOverallFeedback.Text = "Include Overall feedback"
        Me.chkIncludeOverallFeedback.UseVisualStyleBackColor = True
        '
        'chkIncludeRework
        '
        Me.chkIncludeRework.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeRework.AutoSize = True
        Me.chkIncludeRework.Checked = True
        Me.chkIncludeRework.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeRework.Location = New System.Drawing.Point(20, 182)
        Me.chkIncludeRework.Name = "chkIncludeRework"
        Me.chkIncludeRework.Size = New System.Drawing.Size(192, 22)
        Me.chkIncludeRework.TabIndex = 16
        Me.chkIncludeRework.Text = "Include Rework (2nd try)"
        Me.chkIncludeRework.UseVisualStyleBackColor = True
        '
        'ExportNormalGradesForMoodle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 306)
        Me.Controls.Add(Me.chkIncludeRework)
        Me.Controls.Add(Me.chkIncludeOverallFeedback)
        Me.Controls.Add(Me.chkIncludeImprovementFeedback)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAssignments)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ExportNormalGradesForMoodle"
        Me.Text = "Export Normal Grades for Moodle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstAssignments As ListBox
    Friend WithEvents chkIncludeImprovementFeedback As CheckBox
    Friend WithEvents chkIncludeOverallFeedback As CheckBox
    Friend WithEvents chkIncludeRework As CheckBox
End Class
