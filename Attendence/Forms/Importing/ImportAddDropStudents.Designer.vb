<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportAddDropStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportAddDropStudents))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.splitAddDrop = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvStudentsToAdd = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.olvStudentsToDrop = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblStudentsLoaded = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearched = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearchedCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnProcess = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.splitAddDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitAddDrop.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitAddDrop.Panel1.SuspendLayout()
        CType(Me.splitAddDrop.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitAddDrop.Panel2.SuspendLayout()
        Me.splitAddDrop.SuspendLayout()
        CType(Me.olvStudentsToAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.olvStudentsToDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.splitAddDrop)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(821, 419)
        Me.KryptonPanel.TabIndex = 1
        '
        'splitAddDrop
        '
        Me.splitAddDrop.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitAddDrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitAddDrop.Location = New System.Drawing.Point(0, 0)
        Me.splitAddDrop.Name = "splitAddDrop"
        '
        'splitAddDrop.Panel1
        '
        Me.splitAddDrop.Panel1.Controls.Add(Me.olvStudentsToAdd)
        Me.splitAddDrop.Panel1.Controls.Add(Me.KryptonPanel2)
        '
        'splitAddDrop.Panel2
        '
        Me.splitAddDrop.Panel2.Controls.Add(Me.olvStudentsToDrop)
        Me.splitAddDrop.Panel2.Controls.Add(Me.KryptonPanel3)
        Me.splitAddDrop.Size = New System.Drawing.Size(821, 312)
        Me.splitAddDrop.SplitterDistance = 408
        Me.splitAddDrop.TabIndex = 29
        '
        'olvStudentsToAdd
        '
        Me.olvStudentsToAdd.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudentsToAdd.AllColumns.Add(Me.OlvColumn11)
        Me.olvStudentsToAdd.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudentsToAdd.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudentsToAdd.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudentsToAdd.AllColumns.Add(Me.OlvColumn5)
        Me.olvStudentsToAdd.AllColumns.Add(Me.OlvColumn13)
        Me.olvStudentsToAdd.AllowColumnReorder = True
        Me.olvStudentsToAdd.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudentsToAdd.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudentsToAdd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn4, Me.OlvColumn11, Me.OlvColumn3, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn5, Me.OlvColumn13})
        Me.olvStudentsToAdd.CopySelectionOnControlC = False
        Me.olvStudentsToAdd.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudentsToAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudentsToAdd.EmptyListMsg = "Copy and paste from spreadsheet."
        Me.olvStudentsToAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudentsToAdd.FullRowSelect = True
        Me.olvStudentsToAdd.GridLines = True
        Me.olvStudentsToAdd.HasCollapsibleGroups = False
        Me.olvStudentsToAdd.HideSelection = False
        Me.olvStudentsToAdd.Location = New System.Drawing.Point(0, 34)
        Me.olvStudentsToAdd.Name = "olvStudentsToAdd"
        Me.olvStudentsToAdd.OwnerDraw = True
        Me.olvStudentsToAdd.ShowGroups = False
        Me.olvStudentsToAdd.ShowImagesOnSubItems = True
        Me.olvStudentsToAdd.ShowItemCountOnGroups = True
        Me.olvStudentsToAdd.Size = New System.Drawing.Size(408, 278)
        Me.olvStudentsToAdd.TabIndex = 5
        Me.olvStudentsToAdd.UseAlternatingBackColors = True
        Me.olvStudentsToAdd.UseCompatibleStateImageBehavior = False
        Me.olvStudentsToAdd.UseFiltering = True
        Me.olvStudentsToAdd.UseSubItemCheckBoxes = True
        Me.olvStudentsToAdd.View = System.Windows.Forms.View.Details
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "AdminNumber"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Admin"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "AltNumber"
        Me.OlvColumn11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.Text = "Alt"
        Me.OlvColumn11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.ToolTipText = "Alternate number"
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StudentID"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 90
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "LocalName"
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.Width = 150
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Nickname"
        Me.OlvColumn2.Text = "Nickname"
        Me.OlvColumn2.Width = 108
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "EmailAddress"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "Email"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Width = 120
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "ExtStudentID"
        Me.OlvColumn13.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.Text = "ExtID"
        Me.OlvColumn13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn13.Width = 97
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(408, 34)
        Me.KryptonPanel2.TabIndex = 6
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.KryptonLabel6.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(131, 20)
        Me.KryptonLabel6.TabIndex = 29
        Me.KryptonLabel6.Values.Text = "New students to add"
        '
        'olvStudentsToDrop
        '
        Me.olvStudentsToDrop.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudentsToDrop.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudentsToDrop.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudentsToDrop.AllColumns.Add(Me.OlvColumn9)
        Me.olvStudentsToDrop.AllColumns.Add(Me.OlvColumn10)
        Me.olvStudentsToDrop.AllColumns.Add(Me.OlvColumn12)
        Me.olvStudentsToDrop.AllColumns.Add(Me.OlvColumn14)
        Me.olvStudentsToDrop.AllowColumnReorder = True
        Me.olvStudentsToDrop.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudentsToDrop.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudentsToDrop.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn12, Me.OlvColumn14})
        Me.olvStudentsToDrop.CopySelectionOnControlC = False
        Me.olvStudentsToDrop.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudentsToDrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudentsToDrop.EmptyListMsg = "Copy and paste from spreadsheet."
        Me.olvStudentsToDrop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudentsToDrop.FullRowSelect = True
        Me.olvStudentsToDrop.GridLines = True
        Me.olvStudentsToDrop.HasCollapsibleGroups = False
        Me.olvStudentsToDrop.HideSelection = False
        Me.olvStudentsToDrop.Location = New System.Drawing.Point(0, 34)
        Me.olvStudentsToDrop.Name = "olvStudentsToDrop"
        Me.olvStudentsToDrop.OwnerDraw = True
        Me.olvStudentsToDrop.ShowGroups = False
        Me.olvStudentsToDrop.ShowImagesOnSubItems = True
        Me.olvStudentsToDrop.ShowItemCountOnGroups = True
        Me.olvStudentsToDrop.Size = New System.Drawing.Size(408, 278)
        Me.olvStudentsToDrop.TabIndex = 6
        Me.olvStudentsToDrop.UseAlternatingBackColors = True
        Me.olvStudentsToDrop.UseCompatibleStateImageBehavior = False
        Me.olvStudentsToDrop.UseFiltering = True
        Me.olvStudentsToDrop.UseSubItemCheckBoxes = True
        Me.olvStudentsToDrop.View = System.Windows.Forms.View.Details
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "AdminNumber"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Text = "Admin"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "AltNumber"
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Text = "Alt"
        Me.OlvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.ToolTipText = "Alternate number"
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "StudentID"
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "Student ID"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Width = 90
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "LocalName"
        Me.OlvColumn9.Text = "Name"
        Me.OlvColumn9.Width = 150
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "Nickname"
        Me.OlvColumn10.Text = "Nickname"
        Me.OlvColumn10.Width = 108
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "EmailAddress"
        Me.OlvColumn12.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.Text = "Email"
        Me.OlvColumn12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.Width = 120
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "ExtStudentID"
        Me.OlvColumn14.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.Text = "ExtID"
        Me.OlvColumn14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.Width = 97
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(408, 34)
        Me.KryptonPanel3.TabIndex = 7
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(191, 20)
        Me.KryptonLabel1.TabIndex = 29
        Me.KryptonLabel1.Values.Text = "Old students to tag as dropped"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsLoaded)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsSearched)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsSearchedCaption)
        Me.KryptonPanel1.Controls.Add(Me.btnProcess)
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 312)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(821, 107)
        Me.KryptonPanel1.TabIndex = 3
        '
        'lblStudentsLoaded
        '
        Me.lblStudentsLoaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsLoaded.Location = New System.Drawing.Point(792, 50)
        Me.lblStudentsLoaded.Name = "lblStudentsLoaded"
        Me.lblStudentsLoaded.Size = New System.Drawing.Size(17, 20)
        Me.lblStudentsLoaded.TabIndex = 76
        Me.lblStudentsLoaded.Values.Text = "0"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(652, 50)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(102, 20)
        Me.KryptonLabel3.TabIndex = 75
        Me.KryptonLabel3.Values.Text = "Students loaded:"
        '
        'lblStudentsSearched
        '
        Me.lblStudentsSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearched.Location = New System.Drawing.Point(792, 30)
        Me.lblStudentsSearched.Name = "lblStudentsSearched"
        Me.lblStudentsSearched.Size = New System.Drawing.Size(17, 20)
        Me.lblStudentsSearched.TabIndex = 74
        Me.lblStudentsSearched.Values.Text = "0"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(392, 20)
        Me.KryptonLabel2.TabIndex = 29
        Me.KryptonLabel2.Values.Text = "Copy and paste from spreadsheet with the column order you see here"
        '
        'lblStudentsSearchedCaption
        '
        Me.lblStudentsSearchedCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearchedCaption.Location = New System.Drawing.Point(641, 30)
        Me.lblStudentsSearchedCaption.Name = "lblStudentsSearchedCaption"
        Me.lblStudentsSearchedCaption.Size = New System.Drawing.Size(113, 20)
        Me.lblStudentsSearchedCaption.TabIndex = 73
        Me.lblStudentsSearchedCaption.Values.Text = "Students searched:"
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnProcess.Enabled = False
        Me.btnProcess.Location = New System.Drawing.Point(429, 76)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(90, 27)
        Me.btnProcess.TabIndex = 28
        Me.btnProcess.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnProcess.Values.Text = "&Process"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(302, 76)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 27)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 24)
        Me.MenuStrip1.TabIndex = 6
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
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Enabled = False
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'ImportAddDropStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 443)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportAddDropStudents"
        Me.Text = "Import add / drop students"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.splitAddDrop.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAddDrop.Panel1.ResumeLayout(False)
        CType(Me.splitAddDrop.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAddDrop.Panel2.ResumeLayout(False)
        CType(Me.splitAddDrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAddDrop.ResumeLayout(False)
        CType(Me.olvStudentsToAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.olvStudentsToDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        Me.KryptonPanel3.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblStudentsLoaded As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearched As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearchedCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnProcess As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents olvStudentsToDrop As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvStudentsToAdd As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents splitAddDrop As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
