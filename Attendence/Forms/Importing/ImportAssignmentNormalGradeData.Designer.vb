<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportAssignmentNormalGradeData
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboIDToUse = New System.Windows.Forms.ComboBox()
        Me.chkMarkAssignmentProcessed = New System.Windows.Forms.CheckBox()
        Me.chkIncludeImportingData = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblStudentsLoaded = New System.Windows.Forms.Label()
        Me.lblStudentsSearched = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.txtOutput = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.olvData = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.olvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboIDToUse)
        Me.Panel1.Controls.Add(Me.chkMarkAssignmentProcessed)
        Me.Panel1.Controls.Add(Me.chkIncludeImportingData)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 39)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID to Use:"
        '
        'cboIDToUse
        '
        Me.cboIDToUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIDToUse.FormattingEnabled = True
        Me.cboIDToUse.Items.AddRange(New Object() {"StudentID", "ExtStudentID"})
        Me.cboIDToUse.Location = New System.Drawing.Point(108, 7)
        Me.cboIDToUse.Name = "cboIDToUse"
        Me.cboIDToUse.Size = New System.Drawing.Size(153, 24)
        Me.cboIDToUse.TabIndex = 2
        '
        'chkMarkAssignmentProcessed
        '
        Me.chkMarkAssignmentProcessed.AutoSize = True
        Me.chkMarkAssignmentProcessed.Location = New System.Drawing.Point(541, 10)
        Me.chkMarkAssignmentProcessed.Name = "chkMarkAssignmentProcessed"
        Me.chkMarkAssignmentProcessed.Size = New System.Drawing.Size(171, 20)
        Me.chkMarkAssignmentProcessed.TabIndex = 1
        Me.chkMarkAssignmentProcessed.Text = "Mark assignments ""processed"""
        Me.chkMarkAssignmentProcessed.UseVisualStyleBackColor = True
        '
        'chkIncludeImportingData
        '
        Me.chkIncludeImportingData.AutoSize = True
        Me.chkIncludeImportingData.Location = New System.Drawing.Point(298, 10)
        Me.chkIncludeImportingData.Name = "chkIncludeImportingData"
        Me.chkIncludeImportingData.Size = New System.Drawing.Size(159, 20)
        Me.chkIncludeImportingData.TabIndex = 0
        Me.chkIncludeImportingData.Text = "Include ""Imported on {date}"""
        Me.chkIncludeImportingData.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(993, 24)
        Me.MenuStrip1.TabIndex = 1
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl2)
        Me.Panel2.Controls.Add(Me.lbl1)
        Me.Panel2.Controls.Add(Me.lblStudentsLoaded)
        Me.Panel2.Controls.Add(Me.lblStudentsSearched)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnImport)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 431)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(993, 56)
        Me.Panel2.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(823, 33)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(86, 16)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Students loaded:"
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(811, 11)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(98, 16)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "Students searched:"
        '
        'lblStudentsLoaded
        '
        Me.lblStudentsLoaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsLoaded.AutoSize = True
        Me.lblStudentsLoaded.Location = New System.Drawing.Point(966, 33)
        Me.lblStudentsLoaded.Name = "lblStudentsLoaded"
        Me.lblStudentsLoaded.Size = New System.Drawing.Size(14, 16)
        Me.lblStudentsLoaded.TabIndex = 5
        Me.lblStudentsLoaded.Text = "0"
        '
        'lblStudentsSearched
        '
        Me.lblStudentsSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearched.AutoSize = True
        Me.lblStudentsSearched.Location = New System.Drawing.Point(966, 7)
        Me.lblStudentsSearched.Name = "lblStudentsSearched"
        Me.lblStudentsSearched.Size = New System.Drawing.Size(14, 16)
        Me.lblStudentsSearched.TabIndex = 4
        Me.lblStudentsSearched.Text = "0"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(251, 11)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(146, 34)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Enabled = False
        Me.btnImport.Image = Global.Teaching.My.Resources.Resources.checkmark_32
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(471, 11)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(130, 34)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "&Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtOutput.Location = New System.Drawing.Point(755, 63)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(238, 368)
        Me.txtOutput.TabIndex = 8
        Me.txtOutput.Text = "Results will be written here."
        '
        'olvData
        '
        Me.olvData.AllColumns.Add(Me.OlvColumn1)
        Me.olvData.AllColumns.Add(Me.OlvColumn2)
        Me.olvData.AllColumns.Add(Me.OlvColumn3)
        Me.olvData.AllColumns.Add(Me.OlvColumn4)
        Me.olvData.AllColumns.Add(Me.OlvColumn5)
        Me.olvData.AllColumns.Add(Me.OlvColumn6)
        Me.olvData.AllowColumnReorder = True
        Me.olvData.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvData.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvData.CellEditUseWholeCell = False
        Me.olvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn5, Me.OlvColumn6})
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
        Me.olvData.Location = New System.Drawing.Point(0, 63)
        Me.olvData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.olvData.Name = "olvData"
        Me.olvData.ShowGroups = False
        Me.olvData.ShowImagesOnSubItems = True
        Me.olvData.ShowItemCountOnGroups = True
        Me.olvData.Size = New System.Drawing.Size(755, 368)
        Me.olvData.TabIndex = 9
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
        Me.OlvColumn5.Text = "Overall"
        Me.OlvColumn5.Width = 150
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "ImprovementComments"
        Me.OlvColumn6.Text = "Improvement"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'ImportAssignmentNormalGradeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 487)
        Me.Controls.Add(Me.olvData)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImportAssignmentNormalGradeData"
        Me.Text = "Import Assignment Grades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.olvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtOutput As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents olvData As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents btnClose As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboIDToUse As ComboBox
    Friend WithEvents chkMarkAssignmentProcessed As CheckBox
    Friend WithEvents chkIncludeImportingData As CheckBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblStudentsLoaded As Label
    Friend WithEvents lblStudentsSearched As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
End Class
