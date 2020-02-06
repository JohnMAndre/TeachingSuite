<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduledItemListPlain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduledItemListPlain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadUnsentItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadAllItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.dgvScheduleItems = New System.Windows.Forms.DataGridView()
        Me.DayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartsColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopicColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreppedColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SentColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pbClearFilter = New System.Windows.Forms.PictureBox()
        Me.ReloadUnpreppedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvScheduleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClearFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1268, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadUnsentItemsToolStripMenuItem, Me.ReloadUnpreppedItemsToolStripMenuItem, Me.ReloadAllItemsToolStripMenuItem, Me.ClearFilterToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'ReloadUnsentItemsToolStripMenuItem
        '
        Me.ReloadUnsentItemsToolStripMenuItem.Name = "ReloadUnsentItemsToolStripMenuItem"
        Me.ReloadUnsentItemsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadUnsentItemsToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ReloadUnsentItemsToolStripMenuItem.Text = "Reload unsent items"
        '
        'ReloadAllItemsToolStripMenuItem
        '
        Me.ReloadAllItemsToolStripMenuItem.Name = "ReloadAllItemsToolStripMenuItem"
        Me.ReloadAllItemsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ReloadAllItemsToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ReloadAllItemsToolStripMenuItem.Text = "Reload all items"
        '
        'ClearFilterToolStripMenuItem
        '
        Me.ClearFilterToolStripMenuItem.Name = "ClearFilterToolStripMenuItem"
        Me.ClearFilterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ClearFilterToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ClearFilterToolStripMenuItem.Text = "Clear filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(177, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filter:"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(225, 3)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(139, 22)
        Me.txtFilter.TabIndex = 2
        '
        'dgvScheduleItems
        '
        Me.dgvScheduleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScheduleItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DayColumn, Me.DaysColumn, Me.StartsColumn, Me.ModuleColumn, Me.ClassColumn, Me.StudentsColumn, Me.SessionColumn, Me.TopicColumn, Me.LocationColumn, Me.NotesColumn, Me.PreppedColumn, Me.SentColumn})
        Me.dgvScheduleItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvScheduleItems.Location = New System.Drawing.Point(0, 24)
        Me.dgvScheduleItems.Name = "dgvScheduleItems"
        Me.dgvScheduleItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvScheduleItems.Size = New System.Drawing.Size(1268, 396)
        Me.dgvScheduleItems.TabIndex = 3
        '
        'DayColumn
        '
        Me.DayColumn.DataPropertyName = "DayOfWeek"
        Me.DayColumn.HeaderText = "Day"
        Me.DayColumn.Name = "DayColumn"
        Me.DayColumn.ReadOnly = True
        '
        'DaysColumn
        '
        Me.DaysColumn.DataPropertyName = "DaysInFuture"
        Me.DaysColumn.HeaderText = "Days"
        Me.DaysColumn.Name = "DaysColumn"
        Me.DaysColumn.ReadOnly = True
        '
        'StartsColumn
        '
        Me.StartsColumn.DataPropertyName = "TimeOfDay"
        Me.StartsColumn.HeaderText = "Starts"
        Me.StartsColumn.Name = "StartsColumn"
        Me.StartsColumn.ReadOnly = True
        '
        'ModuleColumn
        '
        Me.ModuleColumn.DataPropertyName = "ClassGroupName"
        Me.ModuleColumn.HeaderText = "Module"
        Me.ModuleColumn.Name = "ModuleColumn"
        Me.ModuleColumn.ReadOnly = True
        '
        'ClassColumn
        '
        Me.ClassColumn.DataPropertyName = "SchoolClassName"
        Me.ClassColumn.HeaderText = "Class"
        Me.ClassColumn.Name = "ClassColumn"
        Me.ClassColumn.ReadOnly = True
        '
        'StudentsColumn
        '
        Me.StudentsColumn.DataPropertyName = "NumberOfStudents"
        Me.StudentsColumn.HeaderText = "Students"
        Me.StudentsColumn.Name = "StudentsColumn"
        Me.StudentsColumn.ReadOnly = True
        '
        'SessionColumn
        '
        Me.SessionColumn.DataPropertyName = "SessionNumber"
        Me.SessionColumn.HeaderText = "Session"
        Me.SessionColumn.Name = "SessionColumn"
        Me.SessionColumn.ReadOnly = True
        '
        'TopicColumn
        '
        Me.TopicColumn.DataPropertyName = "Topic"
        Me.TopicColumn.HeaderText = "Topic"
        Me.TopicColumn.Name = "TopicColumn"
        Me.TopicColumn.ReadOnly = True
        '
        'LocationColumn
        '
        Me.LocationColumn.DataPropertyName = "Location"
        Me.LocationColumn.HeaderText = "Location"
        Me.LocationColumn.Name = "LocationColumn"
        '
        'NotesColumn
        '
        Me.NotesColumn.DataPropertyName = "Notes"
        Me.NotesColumn.HeaderText = "Notes"
        Me.NotesColumn.Name = "NotesColumn"
        '
        'PreppedColumn
        '
        Me.PreppedColumn.DataPropertyName = "Prepped"
        Me.PreppedColumn.HeaderText = "Prepped"
        Me.PreppedColumn.Name = "PreppedColumn"
        '
        'SentColumn
        '
        Me.SentColumn.DataPropertyName = "StudentsEmailed"
        Me.SentColumn.HeaderText = "Sent"
        Me.SentColumn.Name = "SentColumn"
        '
        'pbClearFilter
        '
        Me.pbClearFilter.BackColor = System.Drawing.Color.Transparent
        Me.pbClearFilter.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.pbClearFilter.Location = New System.Drawing.Point(365, 4)
        Me.pbClearFilter.Name = "pbClearFilter"
        Me.pbClearFilter.Size = New System.Drawing.Size(19, 18)
        Me.pbClearFilter.TabIndex = 4
        Me.pbClearFilter.TabStop = False
        '
        'ReloadUnpreppedItemsToolStripMenuItem
        '
        Me.ReloadUnpreppedItemsToolStripMenuItem.Name = "ReloadUnpreppedItemsToolStripMenuItem"
        Me.ReloadUnpreppedItemsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.ReloadUnpreppedItemsToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ReloadUnpreppedItemsToolStripMenuItem.Text = "Reload unprepped items"
        '
        'ScheduledItemListPlain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 420)
        Me.Controls.Add(Me.pbClearFilter)
        Me.Controls.Add(Me.dgvScheduleItems)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScheduledItemListPlain"
        Me.Text = "Scheduled Sessions"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvScheduleItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClearFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadUnsentItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadAllItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents dgvScheduleItems As System.Windows.Forms.DataGridView
    Friend WithEvents DayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DaysColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartsColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModuleColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentsColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TopicColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreppedColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SentColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pbClearFilter As System.Windows.Forms.PictureBox
    Friend WithEvents ClearFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadUnpreppedItemsToolStripMenuItem As ToolStripMenuItem
End Class
