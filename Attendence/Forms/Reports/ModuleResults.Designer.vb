<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuleResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuleResults))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFilter = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearFilter = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondRedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblFailPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPassPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMeritPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDistinctionPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblNumberDistinction = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNumberMerit = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalStudents = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFail = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPass = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tmrFilter = New System.Windows.Forms.Timer(Me.components)
        Me.chkIncludeUnprocessed = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.olvStudents)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(778, 335)
        Me.KryptonPanel.TabIndex = 0
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn5)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudents.CellEditUseWholeCell = False
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn5, Me.OlvColumn4, Me.OlvColumn1, Me.OlvColumn3, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn2})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "No data for this module...click menu above."
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 48)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowCommandMenuOnRightClick = True
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(778, 287)
        Me.olvStudents.TabIndex = 8
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "FailedOutcomes"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.IsEditable = False
        Me.OlvColumn5.Text = "Failed"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Student.LocalName"
        Me.OlvColumn4.IsEditable = False
        Me.OlvColumn4.Text = "Name"
        Me.OlvColumn4.Width = 134
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Student.Nickname"
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Nickname"
        Me.OlvColumn1.Width = 113
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Student.StudentID"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 110
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "AchievedMerit"
        Me.OlvColumn6.CheckBoxes = True
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Merit"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "AchievedDistinction"
        Me.OlvColumn7.CheckBoxes = True
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.IsEditable = False
        Me.OlvColumn7.Text = "Destinction"
        Me.OlvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Width = 85
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Student.SchoolClass.Name"
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.Text = "Class"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Width = 120
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.chkIncludeUnprocessed)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel2.Controls.Add(Me.txtFilter)
        Me.KryptonPanel2.Controls.Add(Me.llblClearFilter)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(778, 24)
        Me.KryptonPanel2.TabIndex = 10
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(13, 3)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel4.TabIndex = 28
        Me.KryptonLabel4.Values.Text = "Filter:"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(59, 2)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(117, 19)
        Me.txtFilter.TabIndex = 27
        '
        'llblClearFilter
        '
        Me.llblClearFilter.Location = New System.Drawing.Point(182, 3)
        Me.llblClearFilter.Name = "llblClearFilter"
        Me.llblClearFilter.Size = New System.Drawing.Size(22, 18)
        Me.llblClearFilter.TabIndex = 26
        Me.llblClearFilter.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblClearFilter.Values.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTryToolStripMenuItem, Me.RedoToolStripMenuItem, Me.SecondRedoToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FirstTryToolStripMenuItem
        '
        Me.FirstTryToolStripMenuItem.Name = "FirstTryToolStripMenuItem"
        Me.FirstTryToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FirstTryToolStripMenuItem.Text = "First Try"
        Me.FirstTryToolStripMenuItem.Visible = False
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RedoToolStripMenuItem.Text = "Rework"
        Me.RedoToolStripMenuItem.Visible = False
        '
        'SecondRedoToolStripMenuItem
        '
        Me.SecondRedoToolStripMenuItem.Name = "SecondRedoToolStripMenuItem"
        Me.SecondRedoToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SecondRedoToolStripMenuItem.Text = "2nd Rework"
        Me.SecondRedoToolStripMenuItem.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDataToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.LoadDataToolStripMenuItem.Text = "&Load data"
        '
        'KryptonManager
        '
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonManager.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblFailPercent
        '
        Me.lblFailPercent.Location = New System.Drawing.Point(134, 19)
        Me.lblFailPercent.Name = "lblFailPercent"
        Me.lblFailPercent.Size = New System.Drawing.Size(18, 19)
        Me.lblFailPercent.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lblFailPercent, "Percent of all students")
        Me.lblFailPercent.Values.Text = "0"
        '
        'lblPassPercent
        '
        Me.lblPassPercent.Location = New System.Drawing.Point(134, 1)
        Me.lblPassPercent.Name = "lblPassPercent"
        Me.lblPassPercent.Size = New System.Drawing.Size(18, 19)
        Me.lblPassPercent.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.lblPassPercent, "Percent of all students")
        Me.lblPassPercent.Values.Text = "0"
        '
        'lblMeritPercent
        '
        Me.lblMeritPercent.Location = New System.Drawing.Point(389, 1)
        Me.lblMeritPercent.Name = "lblMeritPercent"
        Me.lblMeritPercent.Size = New System.Drawing.Size(18, 19)
        Me.lblMeritPercent.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.lblMeritPercent, "Percent of all students")
        Me.lblMeritPercent.Values.Text = "0"
        '
        'lblDistinctionPercent
        '
        Me.lblDistinctionPercent.Location = New System.Drawing.Point(389, 19)
        Me.lblDistinctionPercent.Name = "lblDistinctionPercent"
        Me.lblDistinctionPercent.Size = New System.Drawing.Size(18, 19)
        Me.lblDistinctionPercent.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.lblDistinctionPercent, "Percent of all students")
        Me.lblDistinctionPercent.Values.Text = "0"
        '
        'KryptonManager1
        '
        Me.KryptonManager1.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblDistinctionPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblNumberDistinction)
        Me.KryptonPanel1.Controls.Add(Me.lblMeritPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblNumberMerit)
        Me.KryptonPanel1.Controls.Add(Me.lblFailPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblPassPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblTotalStudents)
        Me.KryptonPanel1.Controls.Add(Me.lblFail)
        Me.KryptonPanel1.Controls.Add(Me.lblPass)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 335)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(778, 65)
        Me.KryptonPanel1.TabIndex = 9
        '
        'lblNumberDistinction
        '
        Me.lblNumberDistinction.Location = New System.Drawing.Point(311, 19)
        Me.lblNumberDistinction.Name = "lblNumberDistinction"
        Me.lblNumberDistinction.Size = New System.Drawing.Size(18, 19)
        Me.lblNumberDistinction.TabIndex = 13
        Me.lblNumberDistinction.Values.Text = "0"
        '
        'lblNumberMerit
        '
        Me.lblNumberMerit.Location = New System.Drawing.Point(311, 1)
        Me.lblNumberMerit.Name = "lblNumberMerit"
        Me.lblNumberMerit.Size = New System.Drawing.Size(18, 19)
        Me.lblNumberMerit.TabIndex = 10
        Me.lblNumberMerit.Values.Text = "0"
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.Location = New System.Drawing.Point(69, 37)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(18, 19)
        Me.lblTotalStudents.TabIndex = 5
        Me.lblTotalStudents.Values.Text = "0"
        '
        'lblFail
        '
        Me.lblFail.Location = New System.Drawing.Point(69, 19)
        Me.lblFail.Name = "lblFail"
        Me.lblFail.Size = New System.Drawing.Size(18, 19)
        Me.lblFail.TabIndex = 4
        Me.lblFail.Values.Text = "0"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(69, 1)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(18, 19)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Values.Text = "0"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 37)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Values.Text = "Total:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(13, 19)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(36, 19)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Values.Text = "Fail:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 1)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Pass:"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(225, 19)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel9.TabIndex = 12
        Me.KryptonLabel9.Values.Text = "Distinction:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(225, 1)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel6.TabIndex = 9
        Me.KryptonLabel6.Values.Text = "Merit:"
        '
        'tmrFilter
        '
        Me.tmrFilter.Interval = 200
        '
        'chkIncludeUnprocessed
        '
        Me.chkIncludeUnprocessed.Checked = True
        Me.chkIncludeUnprocessed.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkIncludeUnprocessed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeUnprocessed.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkIncludeUnprocessed.Location = New System.Drawing.Point(225, 3)
        Me.chkIncludeUnprocessed.Name = "chkIncludeUnprocessed"
        Me.chkIncludeUnprocessed.Size = New System.Drawing.Size(147, 19)
        Me.chkIncludeUnprocessed.TabIndex = 66
        Me.chkIncludeUnprocessed.Text = "Include unprocessed"
        Me.ToolTip1.SetToolTip(Me.chkIncludeUnprocessed, "Check to include assignments not processed (for weekly workshops)")
        Me.chkIncludeUnprocessed.Values.Text = "Include unprocessed"
        '
        'ModuleResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 400)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModuleResults"
        Me.Text = "Module Results"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondRedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblFailPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPassPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblTotalStudents As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFail As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPass As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents lblDistinctionPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNumberDistinction As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMeritPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNumberMerit As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFilter As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblClearFilter As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents tmrFilter As System.Windows.Forms.Timer
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents chkIncludeUnprocessed As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
