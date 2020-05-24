<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceReport
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
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReloadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgcDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Present = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Absent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentAttend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadDataToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReloadDataToolStripMenuItem
        '
        Me.ReloadDataToolStripMenuItem.Name = "ReloadDataToolStripMenuItem"
        Me.ReloadDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadDataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReloadDataToolStripMenuItem.Text = "&Reload data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcDay, Me.SessionDate, Me.Present, Me.Absent, Me.PercentAttend})
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.Location = New System.Drawing.Point(0, 24)
        Me.dgvReport.MultiSelect = False
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.ShowCellToolTips = False
        Me.dgvReport.Size = New System.Drawing.Size(800, 404)
        Me.dgvReport.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'dgcDay
        '
        Me.dgcDay.DataPropertyName = "Day"
        Me.dgcDay.HeaderText = "Day"
        Me.dgcDay.Name = "dgcDay"
        Me.dgcDay.ReadOnly = True
        Me.dgcDay.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'SessionDate
        '
        Me.SessionDate.DataPropertyName = "EventDate"
        Me.SessionDate.HeaderText = "Date"
        Me.SessionDate.Name = "SessionDate"
        Me.SessionDate.ReadOnly = True
        '
        'Present
        '
        Me.Present.DataPropertyName = "Present"
        Me.Present.HeaderText = "Present"
        Me.Present.Name = "Present"
        Me.Present.ReadOnly = True
        '
        'Absent
        '
        Me.Absent.DataPropertyName = "Absent"
        Me.Absent.HeaderText = "Absent"
        Me.Absent.Name = "Absent"
        Me.Absent.ReadOnly = True
        '
        'PercentAttend
        '
        Me.PercentAttend.DataPropertyName = "PercentAttend"
        Me.PercentAttend.HeaderText = "% Attend"
        Me.PercentAttend.Name = "PercentAttend"
        Me.PercentAttend.ReadOnly = True
        '
        'AttendanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "AttendanceReport"
        Me.Text = "AttendanceReport"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents dgcDay As DataGridViewTextBoxColumn
    Friend WithEvents SessionDate As DataGridViewTextBoxColumn
    Friend WithEvents Present As DataGridViewTextBoxColumn
    Friend WithEvents Absent As DataGridViewTextBoxColumn
    Friend WithEvents PercentAttend As DataGridViewTextBoxColumn
End Class
