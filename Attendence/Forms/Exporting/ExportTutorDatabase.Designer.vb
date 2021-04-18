<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportTutorDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportTutorDatabase))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstClassGroups = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblExporting = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkClearTags = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lstClassGroups)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 42)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(274, 227)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modules"
        '
        'lstClassGroups
        '
        Me.lstClassGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstClassGroups.FormattingEnabled = True
        Me.lstClassGroups.ItemHeight = 16
        Me.lstClassGroups.Location = New System.Drawing.Point(3, 19)
        Me.lstClassGroups.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstClassGroups.Name = "lstClassGroups"
        Me.lstClassGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstClassGroups.Size = New System.Drawing.Size(268, 204)
        Me.lstClassGroups.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select the Module(s) to include in the exported database. Then click ""Export."""
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(172, 276)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 27)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Tag = "Click to browse to the file to use"
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(290, 276)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(77, 27)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Tag = "Click to browse to the file to use"
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblExporting
        '
        Me.lblExporting.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblExporting.AutoSize = True
        Me.lblExporting.Location = New System.Drawing.Point(294, 281)
        Me.lblExporting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExporting.Name = "lblExporting"
        Me.lblExporting.Size = New System.Drawing.Size(63, 16)
        Me.lblExporting.TabIndex = 14
        Me.lblExporting.Text = "Exporting"
        Me.lblExporting.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chkClearTags)
        Me.GroupBox2.Location = New System.Drawing.Point(297, 42)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(232, 227)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkClearTags
        '
        Me.chkClearTags.AutoSize = True
        Me.chkClearTags.Location = New System.Drawing.Point(17, 36)
        Me.chkClearTags.Name = "chkClearTags"
        Me.chkClearTags.Size = New System.Drawing.Size(86, 20)
        Me.chkClearTags.TabIndex = 0
        Me.chkClearTags.Text = "Clear &tags"
        Me.chkClearTags.UseVisualStyleBackColor = True
        '
        'ExportTutorDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 315)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblExporting)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ExportTutorDatabase"
        Me.Text = "Export Tutor Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstClassGroups As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblExporting As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkClearTags As CheckBox
End Class
