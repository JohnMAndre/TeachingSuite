<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendenceErrors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendenceErrors))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn25 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.llblRemoveDateFromStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblRemoveDateFromClass = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAddDateToStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.lblTeachingSessions = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentSessions = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.olvClassSessions = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvStudentSessions = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.olvClassSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvStudentSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Palette = Me.KryptonPalette1
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel.Size = New System.Drawing.Size(859, 370)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.olvStudents)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblRemoveDateFromStudent)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblRemoveDateFromClass)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblAddDateToStudent)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.lblTeachingSessions)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.lblStudentSessions)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.olvClassSessions)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.olvStudentSessions)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(859, 370)
        Me.KryptonSplitContainer1.SplitterDistance = 123
        Me.KryptonSplitContainer1.TabIndex = 11
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn25)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn9)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn11)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn4, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn25, Me.OlvColumn9, Me.OlvColumn7, Me.OlvColumn11})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "No students to show"
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 24)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.OwnerDraw = True
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(859, 99)
        Me.olvStudents.TabIndex = 4
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "AdminNumber"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.IsEditable = False
        Me.OlvColumn4.Text = "Admin"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "LocalName"
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.Width = 150
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Nickname"
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.Text = "Nickname"
        Me.OlvColumn2.Width = 150
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StudentID"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 110
        '
        'OlvColumn25
        '
        Me.OlvColumn25.AspectName = "SchoolClass.Name"
        Me.OlvColumn25.IsEditable = False
        Me.OlvColumn25.Text = "Class"
        Me.OlvColumn25.Width = 80
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "SchoolClass.ClassGroup.Name"
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.IsEditable = False
        Me.OlvColumn9.Text = "Module"
        Me.OlvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Width = 101
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "Hidden"
        Me.OlvColumn7.CheckBoxes = True
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.IsEditable = False
        Me.OlvColumn7.Text = "Hidden"
        Me.OlvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 5
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDataToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.LoadDataToolStripMenuItem.Text = "&Load data"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 220)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(859, 22)
        Me.StatusStrip1.TabIndex = 58
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'llblRemoveDateFromStudent
        '
        Me.llblRemoveDateFromStudent.Location = New System.Drawing.Point(675, 79)
        Me.llblRemoveDateFromStudent.Name = "llblRemoveDateFromStudent"
        Me.llblRemoveDateFromStudent.Size = New System.Drawing.Size(156, 20)
        Me.llblRemoveDateFromStudent.TabIndex = 57
        Me.llblRemoveDateFromStudent.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblRemoveDateFromStudent.Values.Text = "Remove date from student"
        '
        'llblRemoveDateFromClass
        '
        Me.llblRemoveDateFromClass.Location = New System.Drawing.Point(229, 147)
        Me.llblRemoveDateFromClass.Name = "llblRemoveDateFromClass"
        Me.llblRemoveDateFromClass.Size = New System.Drawing.Size(156, 20)
        Me.llblRemoveDateFromClass.TabIndex = 56
        Me.llblRemoveDateFromClass.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblRemoveDateFromClass.Values.Text = "Remove session from class"
        '
        'llblAddDateToStudent
        '
        Me.llblAddDateToStudent.Location = New System.Drawing.Point(229, 79)
        Me.llblAddDateToStudent.Name = "llblAddDateToStudent"
        Me.llblAddDateToStudent.Size = New System.Drawing.Size(133, 20)
        Me.llblAddDateToStudent.TabIndex = 55
        Me.llblAddDateToStudent.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblAddDateToStudent.Values.Text = "Add date(s) to student"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(431, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Palette = Me.KryptonPalette1
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel1.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel1.TabIndex = 8
        Me.KryptonLabel1.Values.Text = "Student"
        '
        'lblTeachingSessions
        '
        Me.lblTeachingSessions.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.lblTeachingSessions.Location = New System.Drawing.Point(91, 12)
        Me.lblTeachingSessions.Name = "lblTeachingSessions"
        Me.lblTeachingSessions.Palette = Me.KryptonPalette1
        Me.lblTeachingSessions.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblTeachingSessions.Size = New System.Drawing.Size(18, 20)
        Me.lblTeachingSessions.TabIndex = 9
        Me.lblTeachingSessions.Values.Text = "0"
        '
        'lblStudentSessions
        '
        Me.lblStudentSessions.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.lblStudentSessions.Location = New System.Drawing.Point(577, 12)
        Me.lblStudentSessions.Name = "lblStudentSessions"
        Me.lblStudentSessions.Palette = Me.KryptonPalette1
        Me.lblStudentSessions.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblStudentSessions.Size = New System.Drawing.Size(18, 20)
        Me.lblStudentSessions.TabIndex = 10
        Me.lblStudentSessions.Values.Text = "0"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Palette = Me.KryptonPalette1
        Me.KryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel3.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel3.TabIndex = 7
        Me.KryptonLabel3.Values.Text = "Class"
        '
        'olvClassSessions
        '
        Me.olvClassSessions.AllColumns.Add(Me.OlvColumn5)
        Me.olvClassSessions.AllColumns.Add(Me.OlvColumn10)
        Me.olvClassSessions.AllowColumnReorder = True
        Me.olvClassSessions.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvClassSessions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.olvClassSessions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvClassSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn5, Me.OlvColumn10})
        Me.olvClassSessions.CopySelectionOnControlC = False
        Me.olvClassSessions.CopySelectionOnControlCUsesDragSource = False
        Me.olvClassSessions.EmptyListMsg = "Empty"
        Me.olvClassSessions.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvClassSessions.FullRowSelect = True
        Me.olvClassSessions.GridLines = True
        Me.olvClassSessions.HideSelection = False
        Me.olvClassSessions.Location = New System.Drawing.Point(3, 34)
        Me.olvClassSessions.Name = "olvClassSessions"
        Me.olvClassSessions.SelectAllOnControlA = False
        Me.olvClassSessions.ShowGroups = False
        Me.olvClassSessions.ShowImagesOnSubItems = True
        Me.olvClassSessions.ShowItemCountOnGroups = True
        Me.olvClassSessions.Size = New System.Drawing.Size(209, 183)
        Me.olvClassSessions.TabIndex = 5
        Me.olvClassSessions.UseAlternatingBackColors = True
        Me.olvClassSessions.UseCompatibleStateImageBehavior = False
        Me.olvClassSessions.UseFiltering = True
        Me.olvClassSessions.UseSubItemCheckBoxes = True
        Me.olvClassSessions.View = System.Windows.Forms.View.Details
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "StartDate"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "Date"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Width = 101
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "StudentGroup"
        Me.OlvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.Text = "Group"
        Me.OlvColumn10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'olvStudentSessions
        '
        Me.olvStudentSessions.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudentSessions.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudentSessions.AllowColumnReorder = True
        Me.olvStudentSessions.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudentSessions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.olvStudentSessions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvStudentSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn6, Me.OlvColumn8})
        Me.olvStudentSessions.CopySelectionOnControlC = False
        Me.olvStudentSessions.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudentSessions.EmptyListMsg = "Empty"
        Me.olvStudentSessions.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudentSessions.FullRowSelect = True
        Me.olvStudentSessions.GridLines = True
        Me.olvStudentSessions.HasCollapsibleGroups = False
        Me.olvStudentSessions.HideSelection = False
        Me.olvStudentSessions.Location = New System.Drawing.Point(433, 34)
        Me.olvStudentSessions.MultiSelect = False
        Me.olvStudentSessions.Name = "olvStudentSessions"
        Me.olvStudentSessions.SelectAllOnControlA = False
        Me.olvStudentSessions.ShowGroups = False
        Me.olvStudentSessions.ShowImagesOnSubItems = True
        Me.olvStudentSessions.ShowItemCountOnGroups = True
        Me.olvStudentSessions.Size = New System.Drawing.Size(240, 183)
        Me.olvStudentSessions.TabIndex = 6
        Me.olvStudentSessions.UseAlternatingBackColors = True
        Me.olvStudentSessions.UseCompatibleStateImageBehavior = False
        Me.olvStudentSessions.UseFiltering = True
        Me.olvStudentSessions.View = System.Windows.Forms.View.Details
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "StartDate"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OlvColumn6.Text = "Date"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Width = 97
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "AttendenceStatus"
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "Status"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Width = 105
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "StudentGroup"
        Me.OlvColumn11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.Text = "Group"
        Me.OlvColumn11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AttendenceErrors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 370)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AttendenceErrors"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attendence Errors"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.olvClassSessions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvStudentSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvClassSessions As BrightIdeasSoftware.ObjectListView
    Friend WithEvents olvStudentSessions As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn25 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentSessions As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTeachingSessions As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents llblAddDateToStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblRemoveDateFromClass As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblRemoveDateFromStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
End Class
