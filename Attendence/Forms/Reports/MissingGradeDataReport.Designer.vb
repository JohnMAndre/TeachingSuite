<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MissingGradeDataReport
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblLoadingHistoricalStudents = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.lblClassesSearched = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearched = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearchedCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.olvData = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.olvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.olvData)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(792, 297)
        Me.KryptonPanel.TabIndex = 1
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblLoadingHistoricalStudents)
        Me.KryptonPanel1.Controls.Add(Me.lblClassesSearched)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsSearched)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsSearchedCaption)
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 190)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(792, 107)
        Me.KryptonPanel1.TabIndex = 7
        '
        'lblLoadingHistoricalStudents
        '
        Me.lblLoadingHistoricalStudents.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.lblLoadingHistoricalStudents.Location = New System.Drawing.Point(12, 30)
        Me.lblLoadingHistoricalStudents.Name = "lblLoadingHistoricalStudents"
        Me.lblLoadingHistoricalStudents.Palette = Me.KryptonPalette1
        Me.lblLoadingHistoricalStudents.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblLoadingHistoricalStudents.Size = New System.Drawing.Size(196, 29)
        Me.lblLoadingHistoricalStudents.TabIndex = 77
        Me.lblLoadingHistoricalStudents.Values.Text = "Analyzing data from:  "
        Me.lblLoadingHistoricalStudents.Visible = False
        '
        'lblClassesSearched
        '
        Me.lblClassesSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClassesSearched.Location = New System.Drawing.Point(762, 50)
        Me.lblClassesSearched.Name = "lblClassesSearched"
        Me.lblClassesSearched.Size = New System.Drawing.Size(18, 19)
        Me.lblClassesSearched.TabIndex = 76
        Me.lblClassesSearched.Values.Text = "0"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(604, 50)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(121, 19)
        Me.KryptonLabel3.TabIndex = 75
        Me.KryptonLabel3.Values.Text = "Classes searched:"
        '
        'lblStudentsSearched
        '
        Me.lblStudentsSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearched.Location = New System.Drawing.Point(762, 30)
        Me.lblStudentsSearched.Name = "lblStudentsSearched"
        Me.lblStudentsSearched.Size = New System.Drawing.Size(18, 19)
        Me.lblStudentsSearched.TabIndex = 74
        Me.lblStudentsSearched.Values.Text = "0"
        '
        'lblStudentsSearchedCaption
        '
        Me.lblStudentsSearchedCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearchedCaption.Location = New System.Drawing.Point(599, 30)
        Me.lblStudentsSearchedCaption.Name = "lblStudentsSearchedCaption"
        Me.lblStudentsSearchedCaption.Size = New System.Drawing.Size(126, 19)
        Me.lblStudentsSearchedCaption.TabIndex = 73
        Me.lblStudentsSearchedCaption.Values.Text = "Students searched:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(353, 77)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 27)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Close"
        '
        'olvData
        '
        Me.olvData.AllColumns.Add(Me.OlvColumn4)
        Me.olvData.AllColumns.Add(Me.OlvColumn12)
        Me.olvData.AllColumns.Add(Me.OlvColumn13)
        Me.olvData.AllColumns.Add(Me.OlvColumn14)
        Me.olvData.AllColumns.Add(Me.OlvColumn1)
        Me.olvData.AllowColumnReorder = True
        Me.olvData.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvData.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvData.CellEditUseWholeCell = False
        Me.olvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn4, Me.OlvColumn12, Me.OlvColumn13, Me.OlvColumn14, Me.OlvColumn1})
        Me.olvData.CopySelectionOnControlC = False
        Me.olvData.CopySelectionOnControlCUsesDragSource = False
        Me.olvData.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvData.EmptyListMsg = "Reload data to run the report"
        Me.olvData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvData.FullRowSelect = True
        Me.olvData.GridLines = True
        Me.olvData.HideSelection = False
        Me.olvData.Location = New System.Drawing.Point(0, 24)
        Me.olvData.MultiSelect = False
        Me.olvData.Name = "olvData"
        Me.olvData.SelectAllOnControlA = False
        Me.olvData.ShowCommandMenuOnRightClick = True
        Me.olvData.ShowGroups = False
        Me.olvData.ShowImagesOnSubItems = True
        Me.olvData.ShowItemCountOnGroups = True
        Me.olvData.Size = New System.Drawing.Size(792, 166)
        Me.olvData.TabIndex = 5
        Me.olvData.UseAlternatingBackColors = True
        Me.olvData.UseCompatibleStateImageBehavior = False
        Me.olvData.UseFiltering = True
        Me.olvData.UseSubItemCheckBoxes = True
        Me.olvData.View = System.Windows.Forms.View.Details
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Semester"
        Me.OlvColumn4.Text = "Semester"
        Me.OlvColumn4.Width = 98
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "ClassGroup"
        Me.OlvColumn12.Text = "Module"
        Me.OlvColumn12.Width = 143
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "SchoolClass"
        Me.OlvColumn13.Text = "Class"
        Me.OlvColumn13.Width = 125
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "TotalStudents"
        Me.OlvColumn14.Text = "Total students"
        Me.OlvColumn14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.Width = 119
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTryToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FirstTryToolStripMenuItem
        '
        Me.FirstTryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FirstTryToolStripMenuItem.Name = "FirstTryToolStripMenuItem"
        Me.FirstTryToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FirstTryToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadDataToolStripMenuItem})
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.RedoToolStripMenuItem.Text = "&Data"
        '
        'ReloadDataToolStripMenuItem
        '
        Me.ReloadDataToolStripMenuItem.Name = "ReloadDataToolStripMenuItem"
        Me.ReloadDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadDataToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ReloadDataToolStripMenuItem.Text = "&Reload data"
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "StudentsWithoutGrades"
        Me.OlvColumn1.Text = "Students without grades"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Width = 167
        '
        'MissingGradeDataReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 297)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "MissingGradeDataReport"
        Me.Text = "Modules missing grades"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.olvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents olvData As BrightIdeasSoftware.ObjectListView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblLoadingHistoricalStudents As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblClassesSearched As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearched As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearchedCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
End Class
