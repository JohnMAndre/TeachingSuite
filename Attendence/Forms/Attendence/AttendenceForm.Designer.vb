<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendenceForm
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendenceForm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn15 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStudentsPresent = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.tmrStudentCount = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFilterStudents = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFilterHiddenStudents = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPublicFilter = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.olvStudents)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Palette = Me.KryptonPalette1
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel.Size = New System.Drawing.Size(790, 281)
        Me.KryptonPanel.TabIndex = 0
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn5)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn12)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn9)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn10)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn11)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn13)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn14)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn15)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn8, Me.OlvColumn1, Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn12, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn11, Me.OlvColumn13, Me.OlvColumn14, Me.OlvColumn15})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.Location = New System.Drawing.Point(0, 0)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.Size = New System.Drawing.Size(790, 281)
        Me.olvStudents.TabIndex = 4
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "AdminNumber"
        Me.OlvColumn8.AutoCompleteEditor = False
        Me.OlvColumn8.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.IsEditable = False
        Me.OlvColumn8.Text = "Admin"
        Me.OlvColumn8.ToolTipText = "Admin number"
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "LocalName"
        Me.OlvColumn1.AutoCompleteEditor = False
        Me.OlvColumn1.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.ToolTipText = "Local name"
        Me.OlvColumn1.Width = 150
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "Nickname"
        Me.OlvColumn5.AutoCompleteEditor = False
        Me.OlvColumn5.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn5.Text = "Nickname"
        Me.OlvColumn5.ToolTipText = "Nickname"
        Me.OlvColumn5.Width = 150
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "StudentID"
        Me.OlvColumn6.AutoCompleteEditor = False
        Me.OlvColumn6.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Text = "Student ID"
        Me.OlvColumn6.ToolTipText = "Student ID"
        Me.OlvColumn6.Width = 140
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "CurrentAttendenceStatus"
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Text = "Status"
        Me.OlvColumn7.ToolTipText = "Current absence status"
        Me.OlvColumn7.Width = 100
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "PresentationQuality"
        Me.OlvColumn12.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.Text = "Pres"
        Me.OlvColumn12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.ToolTipText = "Presentation quality"
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "Hidden"
        Me.OlvColumn9.CheckBoxes = True
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.IsEditable = False
        Me.OlvColumn9.Text = "Hid"
        Me.OlvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.ToolTipText = "Is student marked as hidden?"
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "CurrentAbsences"
        Me.OlvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.Text = "Absences"
        Me.OlvColumn10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.ToolTipText = "Current absences"
        Me.OlvColumn10.Width = 75
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "LocalNameLatinLetters"
        Me.OlvColumn11.Text = "Plain"
        Me.OlvColumn11.ToolTipText = "Local name (Latin letters)"
        Me.OlvColumn11.Width = 120
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "Gender"
        Me.OlvColumn13.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.Text = "Gender"
        Me.OlvColumn13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.ToolTipText = "Gender"
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "StudentGroup"
        Me.OlvColumn14.AutoCompleteEditor = False
        Me.OlvColumn14.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn14.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.Text = "Group"
        Me.OlvColumn14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.ToolTipText = "Student group"
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "DateOfBirth"
        Me.OlvColumn15.AspectToStringFormat = "{0:d}"
        Me.OlvColumn15.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn15.Text = "DoB"
        Me.OlvColumn15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn15.ToolTipText = "Date of Birth"
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Nickname"
        Me.OlvColumn2.DisplayIndex = 1
        Me.OlvColumn2.Text = "Nickname"
        Me.OlvColumn2.Width = 150
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StudentID"
        Me.OlvColumn3.DisplayIndex = 2
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.Width = 110
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "AttendenceStatus"
        Me.OlvColumn4.DisplayIndex = 3
        Me.OlvColumn4.Text = "Status"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.KryptonPanel)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(790, 281)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(790, 330)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStudentsPresent})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(790, 22)
        Me.StatusStrip1.TabIndex = 0
        '
        'lblStudentsPresent
        '
        Me.lblStudentsPresent.Name = "lblStudentsPresent"
        Me.lblStudentsPresent.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.MarkToolStripMenuItem, Me.SetQualityToolStripMenuItem, Me.HelpToolStripMenuItem, Me.txtSessionDate, Me.txtFilter, Me.txtStudentGroup, Me.ToolStripMenuItem1, Me.PublicToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(790, 27)
        Me.MenuStrip1.TabIndex = 0
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseFontToolStripMenuItem, Me.DecreaseFontToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'IncreaseFontToolStripMenuItem
        '
        Me.IncreaseFontToolStripMenuItem.Name = "IncreaseFontToolStripMenuItem"
        Me.IncreaseFontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.IncreaseFontToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.IncreaseFontToolStripMenuItem.Text = "Increase font"
        '
        'DecreaseFontToolStripMenuItem
        '
        Me.DecreaseFontToolStripMenuItem.Name = "DecreaseFontToolStripMenuItem"
        Me.DecreaseFontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DecreaseFontToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
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
        'tmrStudentCount
        '
        Me.tmrStudentCount.Enabled = True
        Me.tmrStudentCount.Interval = 2000
        '
        'tmrFilterStudents
        '
        Me.tmrFilterStudents.Enabled = True
        Me.tmrFilterStudents.Interval = 200
        '
        'tmrFilterHiddenStudents
        '
        Me.tmrFilterHiddenStudents.Enabled = True
        Me.tmrFilterHiddenStudents.Interval = 500
        '
        'tmrPublicFilter
        '
        Me.tmrPublicFilter.Enabled = True
        Me.tmrPublicFilter.Interval = 2000
        '
        'AttendenceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 330)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AttendenceForm"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.Text = "Taking Attendence"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAndCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSessionDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblStudentsPresent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrStudentCount As System.Windows.Forms.Timer
    Friend WithEvents txtFilter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tmrFilterStudents As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrFilterHiddenStudents As System.Windows.Forms.Timer
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PublicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ReloadStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
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
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SetGendermaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGenderfemaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGenderUnknownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents txtStudentGroup As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tmrPublicFilter As System.Windows.Forms.Timer
    Friend WithEvents ExcusedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllStudentsPresentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllStuentsAbsentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllStudentsExcusedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncreaseFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecreaseFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
