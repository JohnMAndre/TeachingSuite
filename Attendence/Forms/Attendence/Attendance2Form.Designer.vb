<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance2Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance2Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAndCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncreaseFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcusedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AllStudentsPresentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllStuentsAbsentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllStudentsExcusedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetQualityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Presentation9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetGendermaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGenderfemaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGenderUnknownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSessionDate = New System.Windows.Forms.ToolStripTextBox()
        Me.txtFilter = New System.Windows.Forms.ToolStripTextBox()
        Me.txtStudentGroup = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStudentsPresent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrStudentCount = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditCurrentStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.MarkToolStripMenuItem, Me.SetQualityToolStripMenuItem, Me.HelpToolStripMenuItem, Me.txtSessionDate, Me.txtFilter, Me.txtStudentGroup, Me.ToolStripMenuItem1, Me.PublicToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadStudentsToolStripMenuItem, Me.ToolStripSeparator2, Me.SaveAndCloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ReloadStudentsToolStripMenuItem
        '
        Me.ReloadStudentsToolStripMenuItem.Name = "ReloadStudentsToolStripMenuItem"
        Me.ReloadStudentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadStudentsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ReloadStudentsToolStripMenuItem.Text = "&Reload students"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'SaveAndCloseToolStripMenuItem
        '
        Me.SaveAndCloseToolStripMenuItem.Name = "SaveAndCloseToolStripMenuItem"
        Me.SaveAndCloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAndCloseToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SaveAndCloseToolStripMenuItem.Text = "&Save and close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseFontToolStripMenuItem, Me.DecreaseFontToolStripMenuItem, Me.ToolStripSeparator4, Me.EditCurrentStudentToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'IncreaseFontToolStripMenuItem
        '
        Me.IncreaseFontToolStripMenuItem.Name = "IncreaseFontToolStripMenuItem"
        Me.IncreaseFontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.IncreaseFontToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.IncreaseFontToolStripMenuItem.Text = "Increase font"
        '
        'DecreaseFontToolStripMenuItem
        '
        Me.DecreaseFontToolStripMenuItem.Name = "DecreaseFontToolStripMenuItem"
        Me.DecreaseFontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DecreaseFontToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DecreaseFontToolStripMenuItem.Text = "Decrease font"
        '
        'MarkToolStripMenuItem
        '
        Me.MarkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentToolStripMenuItem, Me.LateToolStripMenuItem, Me.RemovedToolStripMenuItem, Me.AbsentToolStripMenuItem, Me.ExcusedToolStripMenuItem, Me.ToolStripSeparator3, Me.AllStudentsPresentToolStripMenuItem, Me.AllStuentsAbsentToolStripMenuItem, Me.AllStudentsExcusedToolStripMenuItem})
        Me.MarkToolStripMenuItem.Name = "MarkToolStripMenuItem"
        Me.MarkToolStripMenuItem.Size = New System.Drawing.Size(46, 23)
        Me.MarkToolStripMenuItem.Text = "&Mark"
        '
        'PresentToolStripMenuItem
        '
        Me.PresentToolStripMenuItem.Name = "PresentToolStripMenuItem"
        Me.PresentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PresentToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PresentToolStripMenuItem.Text = "&Present"
        '
        'LateToolStripMenuItem
        '
        Me.LateToolStripMenuItem.Name = "LateToolStripMenuItem"
        Me.LateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LateToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.LateToolStripMenuItem.Text = "&Late"
        '
        'RemovedToolStripMenuItem
        '
        Me.RemovedToolStripMenuItem.Name = "RemovedToolStripMenuItem"
        Me.RemovedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RemovedToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RemovedToolStripMenuItem.Text = "&Removed"
        '
        'AbsentToolStripMenuItem
        '
        Me.AbsentToolStripMenuItem.Name = "AbsentToolStripMenuItem"
        Me.AbsentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbsentToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AbsentToolStripMenuItem.Text = "&Absent"
        '
        'ExcusedToolStripMenuItem
        '
        Me.ExcusedToolStripMenuItem.Name = "ExcusedToolStripMenuItem"
        Me.ExcusedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExcusedToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExcusedToolStripMenuItem.Text = "&Excused"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(178, 6)
        '
        'AllStudentsPresentToolStripMenuItem
        '
        Me.AllStudentsPresentToolStripMenuItem.Name = "AllStudentsPresentToolStripMenuItem"
        Me.AllStudentsPresentToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AllStudentsPresentToolStripMenuItem.Text = "All students present"
        '
        'AllStuentsAbsentToolStripMenuItem
        '
        Me.AllStuentsAbsentToolStripMenuItem.Name = "AllStuentsAbsentToolStripMenuItem"
        Me.AllStuentsAbsentToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AllStuentsAbsentToolStripMenuItem.Text = "All stuents absent"
        '
        'AllStudentsExcusedToolStripMenuItem
        '
        Me.AllStudentsExcusedToolStripMenuItem.Name = "AllStudentsExcusedToolStripMenuItem"
        Me.AllStudentsExcusedToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AllStudentsExcusedToolStripMenuItem.Text = "All students excused"
        '
        'SetQualityToolStripMenuItem
        '
        Me.SetQualityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Presentation1ToolStripMenuItem, Me.Presentation2ToolStripMenuItem, Me.Presentation3ToolStripMenuItem, Me.Presentation4ToolStripMenuItem, Me.Presentation5ToolStripMenuItem, Me.Presentation6ToolStripMenuItem, Me.Presentation7ToolStripMenuItem, Me.Presentation8ToolStripMenuItem, Me.Presentation9ToolStripMenuItem, Me.ToolStripSeparator1, Me.SetGendermaleToolStripMenuItem, Me.SetGenderfemaleToolStripMenuItem, Me.SetGenderUnknownToolStripMenuItem})
        Me.SetQualityToolStripMenuItem.Name = "SetQualityToolStripMenuItem"
        Me.SetQualityToolStripMenuItem.Size = New System.Drawing.Size(74, 23)
        Me.SetQualityToolStripMenuItem.Text = "Set quality"
        '
        'Presentation1ToolStripMenuItem
        '
        Me.Presentation1ToolStripMenuItem.Name = "Presentation1ToolStripMenuItem"
        Me.Presentation1ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.Presentation1ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation1ToolStripMenuItem.Text = "Presentation = 1"
        '
        'Presentation2ToolStripMenuItem
        '
        Me.Presentation2ToolStripMenuItem.Name = "Presentation2ToolStripMenuItem"
        Me.Presentation2ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.Presentation2ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation2ToolStripMenuItem.Text = "Presentation = 2"
        '
        'Presentation3ToolStripMenuItem
        '
        Me.Presentation3ToolStripMenuItem.Name = "Presentation3ToolStripMenuItem"
        Me.Presentation3ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.Presentation3ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation3ToolStripMenuItem.Text = "Presentation = 3"
        '
        'Presentation4ToolStripMenuItem
        '
        Me.Presentation4ToolStripMenuItem.Name = "Presentation4ToolStripMenuItem"
        Me.Presentation4ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.Presentation4ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation4ToolStripMenuItem.Text = "Presentation = 4"
        '
        'Presentation5ToolStripMenuItem
        '
        Me.Presentation5ToolStripMenuItem.Name = "Presentation5ToolStripMenuItem"
        Me.Presentation5ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.Presentation5ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation5ToolStripMenuItem.Text = "Presentation = 5"
        '
        'Presentation6ToolStripMenuItem
        '
        Me.Presentation6ToolStripMenuItem.Name = "Presentation6ToolStripMenuItem"
        Me.Presentation6ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.Presentation6ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation6ToolStripMenuItem.Text = "Presentation = 6"
        '
        'Presentation7ToolStripMenuItem
        '
        Me.Presentation7ToolStripMenuItem.Name = "Presentation7ToolStripMenuItem"
        Me.Presentation7ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D7), System.Windows.Forms.Keys)
        Me.Presentation7ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation7ToolStripMenuItem.Text = "Presentation = 7"
        '
        'Presentation8ToolStripMenuItem
        '
        Me.Presentation8ToolStripMenuItem.Name = "Presentation8ToolStripMenuItem"
        Me.Presentation8ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D8), System.Windows.Forms.Keys)
        Me.Presentation8ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation8ToolStripMenuItem.Text = "Presentation = 8"
        '
        'Presentation9ToolStripMenuItem
        '
        Me.Presentation9ToolStripMenuItem.Name = "Presentation9ToolStripMenuItem"
        Me.Presentation9ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D9), System.Windows.Forms.Keys)
        Me.Presentation9ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Presentation9ToolStripMenuItem.Text = "Presentation = 9"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'SetGendermaleToolStripMenuItem
        '
        Me.SetGendermaleToolStripMenuItem.Name = "SetGendermaleToolStripMenuItem"
        Me.SetGendermaleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.SetGendermaleToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SetGendermaleToolStripMenuItem.Text = "Set gender=male"
        '
        'SetGenderfemaleToolStripMenuItem
        '
        Me.SetGenderfemaleToolStripMenuItem.Name = "SetGenderfemaleToolStripMenuItem"
        Me.SetGenderfemaleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SetGenderfemaleToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SetGenderfemaleToolStripMenuItem.Text = "Set gender=female"
        '
        'SetGenderUnknownToolStripMenuItem
        '
        Me.SetGenderUnknownToolStripMenuItem.Name = "SetGenderUnknownToolStripMenuItem"
        Me.SetGenderUnknownToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.SetGenderUnknownToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SetGenderUnknownToolStripMenuItem.Text = "Set gender=unknown"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'txtSessionDate
        '
        Me.txtSessionDate.Name = "txtSessionDate"
        Me.txtSessionDate.Size = New System.Drawing.Size(100, 23)
        Me.txtSessionDate.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSessionDate.ToolTipText = "Session Date"
        '
        'txtFilter
        '
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 23)
        Me.txtFilter.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilter.ToolTipText = "Filter for list"
        '
        'txtStudentGroup
        '
        Me.txtStudentGroup.MaxLength = 2
        Me.txtStudentGroup.Name = "txtStudentGroup"
        Me.txtStudentGroup.Size = New System.Drawing.Size(100, 23)
        Me.txtStudentGroup.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStudentGroup.ToolTipText = "Student group number"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(75, 23)
        Me.ToolStripMenuItem1.Text = "&Clear Filter"
        Me.ToolStripMenuItem1.ToolTipText = "Clear all filters (including hidden students)"
        '
        'PublicToolStripMenuItem
        '
        Me.PublicToolStripMenuItem.Enabled = False
        Me.PublicToolStripMenuItem.Name = "PublicToolStripMenuItem"
        Me.PublicToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.PublicToolStripMenuItem.Text = "Public"
        Me.PublicToolStripMenuItem.ToolTipText = "Open public window"
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudents.Location = New System.Drawing.Point(0, 27)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(719, 429)
        Me.dgvStudents.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStudentsPresent})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 456)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(719, 22)
        Me.StatusStrip1.TabIndex = 3
        '
        'lblStudentsPresent
        '
        Me.lblStudentsPresent.Name = "lblStudentsPresent"
        Me.lblStudentsPresent.Size = New System.Drawing.Size(0, 17)
        '
        'tmrStudentCount
        '
        Me.tmrStudentCount.Enabled = True
        Me.tmrStudentCount.Interval = 2000
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(194, 6)
        '
        'EditCurrentStudentToolStripMenuItem
        '
        Me.EditCurrentStudentToolStripMenuItem.Name = "EditCurrentStudentToolStripMenuItem"
        Me.EditCurrentStudentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.EditCurrentStudentToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EditCurrentStudentToolStripMenuItem.Text = "&Edit current student"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "AdminNumber"
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "LocalName"
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Nickname"
        Me.Column3.HeaderText = "Nickname"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "StudentID"
        Me.Column4.HeaderText = "ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "CurrentAttendenceStatus"
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "CurrentAbsences"
        Me.Column7.HeaderText = "Absent"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Hidden"
        Me.Column6.HeaderText = "Hidden"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Attendance2Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 478)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Attendance2Form"
        Me.Text = "Taking Attendance"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveAndCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncreaseFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecreaseFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcusedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllStudentsPresentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllStuentsAbsentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllStudentsExcusedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetQualityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Presentation9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SetGendermaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGenderfemaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGenderUnknownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSessionDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtFilter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtStudentGroup As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PublicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStudentsPresent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrStudentCount As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditCurrentStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
