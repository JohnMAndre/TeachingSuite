<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseAssignmentSelector
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstAssignments = New System.Windows.Forms.ListBox()
        Me.btnChooseAssignment = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnChooseAssignment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnChooseAssignment)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 55)
        Me.Panel1.TabIndex = 0
        '
        'lstAssignments
        '
        Me.lstAssignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAssignments.FormattingEnabled = True
        Me.lstAssignments.Location = New System.Drawing.Point(0, 0)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.Size = New System.Drawing.Size(302, 237)
        Me.lstAssignments.TabIndex = 6
        '
        'btnChooseAssignment
        '
        Me.btnChooseAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChooseAssignment.Image = Global.Teaching.My.Resources.Resources.checkmark_32
        Me.btnChooseAssignment.Location = New System.Drawing.Point(124, 8)
        Me.btnChooseAssignment.Name = "btnChooseAssignment"
        Me.btnChooseAssignment.Size = New System.Drawing.Size(38, 35)
        Me.btnChooseAssignment.TabIndex = 9
        Me.btnChooseAssignment.TabStop = False
        '
        'BaseAssignmentSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 292)
        Me.Controls.Add(Me.lstAssignments)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BaseAssignmentSelector"
        Me.Text = "Base Assignment Selector"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnChooseAssignment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstAssignments As System.Windows.Forms.ListBox
    Friend WithEvents btnChooseAssignment As System.Windows.Forms.PictureBox
End Class
