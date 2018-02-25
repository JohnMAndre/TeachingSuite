<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprovementItemManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprovementItemManager))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewImprovementItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedImprovementItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectedImprovementItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveItemupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveItemdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.olvImprovementItems = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionsToolStripMenuItem, Me.ReorderToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(689, 24)
        Me.MenuStrip1.TabIndex = 125
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewImprovementItemToolStripMenuItem, Me.DeleteSelectedImprovementItemToolStripMenuItem, Me.EditSelectedImprovementItemToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ActionsToolStripMenuItem.Text = "&Actions"
        '
        'NewImprovementItemToolStripMenuItem
        '
        Me.NewImprovementItemToolStripMenuItem.Name = "NewImprovementItemToolStripMenuItem"
        Me.NewImprovementItemToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewImprovementItemToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.NewImprovementItemToolStripMenuItem.Text = "&New improvement item"
        '
        'DeleteSelectedImprovementItemToolStripMenuItem
        '
        Me.DeleteSelectedImprovementItemToolStripMenuItem.Name = "DeleteSelectedImprovementItemToolStripMenuItem"
        Me.DeleteSelectedImprovementItemToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteSelectedImprovementItemToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.DeleteSelectedImprovementItemToolStripMenuItem.Text = "&Delete selected improvement item"
        '
        'EditSelectedImprovementItemToolStripMenuItem
        '
        Me.EditSelectedImprovementItemToolStripMenuItem.Name = "EditSelectedImprovementItemToolStripMenuItem"
        Me.EditSelectedImprovementItemToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditSelectedImprovementItemToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.EditSelectedImprovementItemToolStripMenuItem.Text = "&Edit selected improvement item..."
        '
        'ReorderToolStripMenuItem
        '
        Me.ReorderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveItemupToolStripMenuItem, Me.MoveItemdownToolStripMenuItem})
        Me.ReorderToolStripMenuItem.Name = "ReorderToolStripMenuItem"
        Me.ReorderToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReorderToolStripMenuItem.Text = "&Reorder"
        '
        'MoveItemupToolStripMenuItem
        '
        Me.MoveItemupToolStripMenuItem.Name = "MoveItemupToolStripMenuItem"
        Me.MoveItemupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.MoveItemupToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.MoveItemupToolStripMenuItem.Text = "Move item &up"
        '
        'MoveItemdownToolStripMenuItem
        '
        Me.MoveItemdownToolStripMenuItem.Name = "MoveItemdownToolStripMenuItem"
        Me.MoveItemdownToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MoveItemdownToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.MoveItemdownToolStripMenuItem.Text = "Move item &down"
        '
        'olvImprovementItems
        '
        Me.olvImprovementItems.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn1)
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn5)
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn2)
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn3)
        Me.olvImprovementItems.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvImprovementItems.CellEditUseWholeCell = False
        Me.olvImprovementItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn5, Me.OlvColumn2, Me.OlvColumn3})
        Me.olvImprovementItems.CopySelectionOnControlC = False
        Me.olvImprovementItems.CopySelectionOnControlCUsesDragSource = False
        Me.olvImprovementItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvImprovementItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvImprovementItems.EmptyListMsg = "No improvement items"
        Me.olvImprovementItems.FullRowSelect = True
        Me.olvImprovementItems.Location = New System.Drawing.Point(0, 24)
        Me.olvImprovementItems.MultiSelect = False
        Me.olvImprovementItems.Name = "olvImprovementItems"
        Me.olvImprovementItems.ShowGroups = False
        Me.olvImprovementItems.ShowImagesOnSubItems = True
        Me.olvImprovementItems.ShowItemToolTips = True
        Me.olvImprovementItems.Size = New System.Drawing.Size(689, 308)
        Me.olvImprovementItems.TabIndex = 126
        Me.olvImprovementItems.UseCompatibleStateImageBehavior = False
        Me.olvImprovementItems.UseFiltering = True
        Me.olvImprovementItems.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Name"
        Me.OlvColumn1.AutoCompleteEditor = False
        Me.OlvColumn1.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn1.DisplayIndex = 1
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.Width = 128
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "Description"
        Me.OlvColumn5.AutoCompleteEditor = False
        Me.OlvColumn5.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn5.DisplayIndex = 2
        Me.OlvColumn5.Text = "Description"
        Me.OlvColumn5.Width = 378
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "OrderingID"
        Me.OlvColumn2.DisplayIndex = 0
        Me.OlvColumn2.Text = "Pos"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "AssessmentCategoryList"
        Me.OlvColumn3.Text = "Categories"
        Me.OlvColumn3.Width = 107
        '
        'ImprovementItemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 332)
        Me.Controls.Add(Me.olvImprovementItems)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImprovementItemManager"
        Me.Text = "Improvement Item Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents olvImprovementItems As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents NewImprovementItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedImprovementItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveItemupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveItemdownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents EditSelectedImprovementItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
