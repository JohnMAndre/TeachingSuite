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
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(17, 208)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblStatus.TabIndex = 13
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExport.Location = New System.Drawing.Point(177, 203)
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
        Me.lstAssignments.Location = New System.Drawing.Point(18, 44)
        Me.lstAssignments.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAssignments.Size = New System.Drawing.Size(397, 148)
        Me.lstAssignments.TabIndex = 10
        '
        'ExportNormalGradesForMoodle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 243)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAssignments)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ExportNormalGradesForMoodle"
        Me.Text = "Export Normal Grades for Moodle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstAssignments As ListBox
End Class
