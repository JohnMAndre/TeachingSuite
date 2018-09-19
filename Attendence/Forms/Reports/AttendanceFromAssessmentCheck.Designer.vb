<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceFromAssessmentCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceFromAssessmentCheck))
        Me.pbClearFilter = New System.Windows.Forms.PictureBox()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.LocalNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceStatusColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssessmentScoreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadAllItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadUnsentItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstAssignments = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAttendance = New System.Windows.Forms.DateTimePicker()
        CType(Me.pbClearFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbClearFilter
        '
        Me.pbClearFilter.BackColor = System.Drawing.Color.Transparent
        Me.pbClearFilter.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.pbClearFilter.Location = New System.Drawing.Point(548, 6)
        Me.pbClearFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.pbClearFilter.Name = "pbClearFilter"
        Me.pbClearFilter.Size = New System.Drawing.Size(22, 19)
        Me.pbClearFilter.TabIndex = 9
        Me.pbClearFilter.TabStop = False
        Me.pbClearFilter.Visible = False
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocalNameColumn, Me.NicknameColumn, Me.AttendanceStatusColumn, Me.AssessmentScoreColumn})
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.Location = New System.Drawing.Point(180, 25)
        Me.dgvReport.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReport.Size = New System.Drawing.Size(692, 422)
        Me.dgvReport.TabIndex = 8
        '
        'LocalNameColumn
        '
        Me.LocalNameColumn.DataPropertyName = "StudentLocalName"
        Me.LocalNameColumn.HeaderText = "Name"
        Me.LocalNameColumn.Name = "LocalNameColumn"
        Me.LocalNameColumn.ReadOnly = True
        '
        'NicknameColumn
        '
        Me.NicknameColumn.DataPropertyName = "StudentNickname"
        Me.NicknameColumn.HeaderText = "Nickname"
        Me.NicknameColumn.Name = "NicknameColumn"
        Me.NicknameColumn.ReadOnly = True
        '
        'AttendanceStatusColumn
        '
        Me.AttendanceStatusColumn.DataPropertyName = "AttendanceStatus"
        Me.AttendanceStatusColumn.HeaderText = "Attendance"
        Me.AttendanceStatusColumn.Name = "AttendanceStatusColumn"
        '
        'AssessmentScoreColumn
        '
        Me.AssessmentScoreColumn.DataPropertyName = "AssessmentStatus"
        Me.AssessmentScoreColumn.HeaderText = "Assessment"
        Me.AssessmentScoreColumn.Name = "AssessmentScoreColumn"
        Me.AssessmentScoreColumn.ReadOnly = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(338, 4)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(206, 26)
        Me.txtFilter.TabIndex = 7
        Me.txtFilter.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(266, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter:"
        Me.Label1.Visible = False
        '
        'ClearFilterToolStripMenuItem
        '
        Me.ClearFilterToolStripMenuItem.Name = "ClearFilterToolStripMenuItem"
        Me.ClearFilterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ClearFilterToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ClearFilterToolStripMenuItem.Text = "Clear filter"
        '
        'ReloadAllItemsToolStripMenuItem
        '
        Me.ReloadAllItemsToolStripMenuItem.Name = "ReloadAllItemsToolStripMenuItem"
        Me.ReloadAllItemsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ReloadAllItemsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ReloadAllItemsToolStripMenuItem.Text = "Reload all items"
        '
        'ReloadUnsentItemsToolStripMenuItem
        '
        Me.ReloadUnsentItemsToolStripMenuItem.Name = "ReloadUnsentItemsToolStripMenuItem"
        Me.ReloadUnsentItemsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadUnsentItemsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ReloadUnsentItemsToolStripMenuItem.Text = "Reload unsent items"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadUnsentItemsToolStripMenuItem, Me.ReloadAllItemsToolStripMenuItem, Me.ClearFilterToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 19)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 19)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(872, 25)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRun)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lstAssignments)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpAttendance)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 422)
        Me.Panel1.TabIndex = 10
        '
        'btnRun
        '
        Me.btnRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRun.Location = New System.Drawing.Point(16, 382)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(72, 28)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "&Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Assessment:"
        '
        'lstAssignments
        '
        Me.lstAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAssignments.FormattingEnabled = True
        Me.lstAssignments.ItemHeight = 18
        Me.lstAssignments.Location = New System.Drawing.Point(12, 154)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.Size = New System.Drawing.Size(152, 202)
        Me.lstAssignments.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attendance date:"
        '
        'dtpAttendance
        '
        Me.dtpAttendance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpAttendance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAttendance.Location = New System.Drawing.Point(12, 55)
        Me.dtpAttendance.Name = "dtpAttendance"
        Me.dtpAttendance.Size = New System.Drawing.Size(152, 26)
        Me.dtpAttendance.TabIndex = 0
        '
        'AttendanceFromAssessmentCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 447)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbClearFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AttendanceFromAssessmentCheck"
        Me.Text = "Attendance from Assessment Check"
        CType(Me.pbClearFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbClearFilter As System.Windows.Forms.PictureBox
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClearFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadAllItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadUnsentItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpAttendance As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstAssignments As System.Windows.Forms.ListBox
    Friend WithEvents LocalNameColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NicknameColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttendanceStatusColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssessmentScoreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
