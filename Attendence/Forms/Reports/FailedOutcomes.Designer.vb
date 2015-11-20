<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FailedOutcomes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FailedOutcomes))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFilter = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearFilter = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondRedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOnGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOffGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CollapseAllGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpandAllGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.KryptonManager2 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tmrFilter = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(778, 400)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.olvStudents)
        Me.KryptonPanel1.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel1.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(778, 400)
        Me.KryptonPanel1.TabIndex = 10
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn5)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn12)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn3, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn4, Me.OlvColumn5, Me.OlvColumn12})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "No data for this module...click menu above."
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 48)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.OwnerDraw = True
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowCommandMenuOnRightClick = True
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(778, 352)
        Me.olvStudents.TabIndex = 8
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StudentID"
        Me.OlvColumn3.DisplayIndex = 1
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 110
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Nickname"
        Me.OlvColumn1.DisplayIndex = 0
        Me.OlvColumn1.Text = "Nickname"
        Me.OlvColumn1.Width = 100
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "SchoolClassName"
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Text = "Class"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Width = 120
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "BaseOutcome.Name"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Outcome"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Width = 100
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "Comments"
        Me.OlvColumn5.Text = "Feedback"
        Me.OlvColumn5.Width = 200
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "BaseOutcome.Description"
        Me.OlvColumn12.Text = "Description"
        Me.OlvColumn12.Width = 150
        '
        'KryptonPanel2
        '
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
        Me.KryptonLabel4.Size = New System.Drawing.Size(40, 20)
        Me.KryptonLabel4.TabIndex = 28
        Me.KryptonLabel4.Values.Text = "Filter:"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(59, 2)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(117, 20)
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTryToolStripMenuItem, Me.RedoToolStripMenuItem, Me.SecondRedoToolStripMenuItem, Me.GroupsToolStripMenuItem})
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
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'SecondRedoToolStripMenuItem
        '
        Me.SecondRedoToolStripMenuItem.Name = "SecondRedoToolStripMenuItem"
        Me.SecondRedoToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.SecondRedoToolStripMenuItem.Text = "2nd Redo"
        '
        'GroupsToolStripMenuItem
        '
        Me.GroupsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnOnGroupsToolStripMenuItem, Me.TurnOffGroupsToolStripMenuItem, Me.ToolStripSeparator1, Me.CollapseAllGroupsToolStripMenuItem, Me.ExpandAllGroupsToolStripMenuItem})
        Me.GroupsToolStripMenuItem.Name = "GroupsToolStripMenuItem"
        Me.GroupsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.GroupsToolStripMenuItem.Text = "&Groups"
        '
        'TurnOnGroupsToolStripMenuItem
        '
        Me.TurnOnGroupsToolStripMenuItem.Name = "TurnOnGroupsToolStripMenuItem"
        Me.TurnOnGroupsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TurnOnGroupsToolStripMenuItem.Text = "Turn on groups"
        '
        'TurnOffGroupsToolStripMenuItem
        '
        Me.TurnOffGroupsToolStripMenuItem.Name = "TurnOffGroupsToolStripMenuItem"
        Me.TurnOffGroupsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TurnOffGroupsToolStripMenuItem.Text = "Turn off groups"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'CollapseAllGroupsToolStripMenuItem
        '
        Me.CollapseAllGroupsToolStripMenuItem.Name = "CollapseAllGroupsToolStripMenuItem"
        Me.CollapseAllGroupsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CollapseAllGroupsToolStripMenuItem.Text = "Collapse all groups"
        '
        'ExpandAllGroupsToolStripMenuItem
        '
        Me.ExpandAllGroupsToolStripMenuItem.Name = "ExpandAllGroupsToolStripMenuItem"
        Me.ExpandAllGroupsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ExpandAllGroupsToolStripMenuItem.Text = "Expand all groups"
        '
        'tmrFilter
        '
        Me.tmrFilter.Interval = 200
        '
        'FailedOutcomes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 400)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FailedOutcomes"
        Me.Text = "Failed Outcomes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFilter As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblClearFilter As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondRedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonManager2 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents tmrFilter As System.Windows.Forms.Timer
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents GroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOnGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOffGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollapseAllGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpandAllGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
