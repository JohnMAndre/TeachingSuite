<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportAssignmentNormalGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportAssignmentNormalGrades))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvData = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.txtOutput = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboIDToUse = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblStudentsLoaded = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnImport = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblStudentsSearched = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearchedCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkIncludeImportingData = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkMarkAssignmentProcessed = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.olvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.cboIDToUse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 24)
        Me.MenuStrip1.TabIndex = 7
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
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.olvData)
        Me.KryptonPanel.Controls.Add(Me.txtOutput)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel3)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(955, 479)
        Me.KryptonPanel.TabIndex = 9
        '
        'olvData
        '
        Me.olvData.AllColumns.Add(Me.OlvColumn1)
        Me.olvData.AllColumns.Add(Me.OlvColumn2)
        Me.olvData.AllColumns.Add(Me.OlvColumn3)
        Me.olvData.AllColumns.Add(Me.OlvColumn4)
        Me.olvData.AllColumns.Add(Me.OlvColumn5)
        Me.olvData.AllowColumnReorder = True
        Me.olvData.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvData.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvData.CellEditUseWholeCell = False
        Me.olvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn5})
        Me.olvData.CopySelectionOnControlC = False
        Me.olvData.CopySelectionOnControlCUsesDragSource = False
        Me.olvData.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvData.EmptyListMsg = "Copy and paste from spreadsheet."
        Me.olvData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvData.FullRowSelect = True
        Me.olvData.GridLines = True
        Me.olvData.HasCollapsibleGroups = False
        Me.olvData.HideSelection = False
        Me.olvData.Location = New System.Drawing.Point(0, 32)
        Me.olvData.Name = "olvData"
        Me.olvData.ShowGroups = False
        Me.olvData.ShowImagesOnSubItems = True
        Me.olvData.ShowItemCountOnGroups = True
        Me.olvData.Size = New System.Drawing.Size(717, 387)
        Me.olvData.TabIndex = 8
        Me.olvData.UseAlternatingBackColors = True
        Me.olvData.UseCompatibleStateImageBehavior = False
        Me.olvData.UseFiltering = True
        Me.olvData.UseSubItemCheckBoxes = True
        Me.olvData.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "ExtStudentID"
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Text = "ID"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Width = 140
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Student.LocalName"
        Me.OlvColumn2.Text = "LocalName"
        Me.OlvColumn2.Width = 193
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Student.Nickname"
        Me.OlvColumn3.Text = "Nickname"
        Me.OlvColumn3.Width = 148
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Grade"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Grade"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Width = 75
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "OverallComments"
        Me.OlvColumn5.Text = "Comments"
        Me.OlvColumn5.Width = 150
        '
        'txtOutput
        '
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtOutput.Location = New System.Drawing.Point(717, 32)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(238, 387)
        Me.txtOutput.TabIndex = 7
        Me.txtOutput.Text = "Results will be written here."
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.chkMarkAssignmentProcessed)
        Me.KryptonPanel2.Controls.Add(Me.chkIncludeImportingData)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel2.Controls.Add(Me.cboIDToUse)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(955, 32)
        Me.KryptonPanel2.TabIndex = 6
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 6)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel1.TabIndex = 9
        Me.KryptonLabel1.Values.Text = "ID to use:"
        '
        'cboIDToUse
        '
        Me.cboIDToUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIDToUse.DropDownWidth = 121
        Me.cboIDToUse.Items.AddRange(New Object() {"StudentID", "ExtStudentID"})
        Me.cboIDToUse.Location = New System.Drawing.Point(82, 5)
        Me.cboIDToUse.Name = "cboIDToUse"
        Me.cboIDToUse.Size = New System.Drawing.Size(215, 20)
        Me.cboIDToUse.TabIndex = 8
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.lblStudentsLoaded)
        Me.KryptonPanel3.Controls.Add(Me.btnImport)
        Me.KryptonPanel3.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel3.Controls.Add(Me.btnClose)
        Me.KryptonPanel3.Controls.Add(Me.lblStudentsSearched)
        Me.KryptonPanel3.Controls.Add(Me.lblStudentsSearchedCaption)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 419)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(955, 60)
        Me.KryptonPanel3.TabIndex = 5
        '
        'lblStudentsLoaded
        '
        Me.lblStudentsLoaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsLoaded.Location = New System.Drawing.Point(890, 26)
        Me.lblStudentsLoaded.Name = "lblStudentsLoaded"
        Me.lblStudentsLoaded.Size = New System.Drawing.Size(18, 19)
        Me.lblStudentsLoaded.TabIndex = 80
        Me.lblStudentsLoaded.Values.Text = "0"
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Enabled = False
        Me.btnImport.Location = New System.Drawing.Point(528, 16)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(90, 32)
        Me.btnImport.TabIndex = 28
        Me.btnImport.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnImport.Values.Text = "&Import"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(742, 26)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(111, 19)
        Me.KryptonLabel3.TabIndex = 79
        Me.KryptonLabel3.Values.Text = "Students loaded:"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(335, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 32)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnClose.Values.Text = "&Close"
        '
        'lblStudentsSearched
        '
        Me.lblStudentsSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearched.Location = New System.Drawing.Point(890, 6)
        Me.lblStudentsSearched.Name = "lblStudentsSearched"
        Me.lblStudentsSearched.Size = New System.Drawing.Size(18, 19)
        Me.lblStudentsSearched.TabIndex = 78
        Me.lblStudentsSearched.Values.Text = "0"
        '
        'lblStudentsSearchedCaption
        '
        Me.lblStudentsSearchedCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearchedCaption.Location = New System.Drawing.Point(727, 6)
        Me.lblStudentsSearchedCaption.Name = "lblStudentsSearchedCaption"
        Me.lblStudentsSearchedCaption.Size = New System.Drawing.Size(126, 19)
        Me.lblStudentsSearchedCaption.TabIndex = 77
        Me.lblStudentsSearchedCaption.Values.Text = "Students searched:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'chkIncludeImportingData
        '
        Me.chkIncludeImportingData.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkIncludeImportingData.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkIncludeImportingData.Location = New System.Drawing.Point(335, 6)
        Me.chkIncludeImportingData.Name = "chkIncludeImportingData"
        Me.chkIncludeImportingData.Size = New System.Drawing.Size(190, 19)
        Me.chkIncludeImportingData.TabIndex = 54
        Me.chkIncludeImportingData.Text = "Include ""Imported on {date}"""
        Me.chkIncludeImportingData.Values.Text = "Include ""Imported on {date}"""
        '
        'chkMarkAssignmentProcessed
        '
        Me.chkMarkAssignmentProcessed.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkMarkAssignmentProcessed.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkMarkAssignmentProcessed.Location = New System.Drawing.Point(571, 6)
        Me.chkMarkAssignmentProcessed.Name = "chkMarkAssignmentProcessed"
        Me.chkMarkAssignmentProcessed.Size = New System.Drawing.Size(207, 19)
        Me.chkMarkAssignmentProcessed.TabIndex = 54
        Me.chkMarkAssignmentProcessed.Text = "Mark assignments ""processed"""
        Me.chkMarkAssignmentProcessed.Values.Text = "Mark assignments ""processed"""
        '
        'ImportAssignmentNormalGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 503)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportAssignmentNormalGrades"
        Me.Text = "Import Assignment Grades"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.olvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.cboIDToUse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        Me.KryptonPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents olvData As BrightIdeasSoftware.ObjectListView
    Friend WithEvents txtOutput As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnImport As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblStudentsLoaded As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearched As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearchedCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboIDToUse As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Private WithEvents chkMarkAssignmentProcessed As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkIncludeImportingData As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
