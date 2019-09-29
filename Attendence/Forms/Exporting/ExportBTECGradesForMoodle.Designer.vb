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
        Me.lstAssignments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstAssignments.Size = New System.Drawing.Size(397, 148)
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
        Me.btnExport.Location = New System.Drawing.Point(174, 198)
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
        Me.lblStatus.Location = New System.Drawing.Point(14, 203)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblStatus.TabIndex = 9
        '
        'ExportBTECGradesForMoodle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 238)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAssignments)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ExportBTECGradesForMoodle"
        Me.Text = "Export BTEC Grades for Moodle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAssignments As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents lblStatus As Label
End Class
