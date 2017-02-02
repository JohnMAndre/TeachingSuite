<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprovementItemReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprovementItemReport))
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvReport = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalThird = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalReworkMarked = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalSecond = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalFirst = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalMarked = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.olvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.olvReport)
        Me.KryptonPanel2.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel2.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(799, 459)
        Me.KryptonPanel2.TabIndex = 4
        '
        'olvReport
        '
        Me.olvReport.AllColumns.Add(Me.OlvColumn1)
        Me.olvReport.AllColumns.Add(Me.OlvColumn2)
        Me.olvReport.AllColumns.Add(Me.OlvColumn3)
        Me.olvReport.AllowColumnReorder = True
        Me.olvReport.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvReport.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvReport.CellEditUseWholeCell = False
        Me.olvReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3})
        Me.olvReport.CopySelectionOnControlC = False
        Me.olvReport.CopySelectionOnControlCUsesDragSource = False
        Me.olvReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvReport.EmptyListMsg = "No items found"
        Me.olvReport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvReport.FullRowSelect = True
        Me.olvReport.GridLines = True
        Me.olvReport.HasCollapsibleGroups = False
        Me.olvReport.HideSelection = False
        Me.olvReport.Location = New System.Drawing.Point(0, 24)
        Me.olvReport.MultiSelect = False
        Me.olvReport.Name = "olvReport"
        Me.olvReport.SelectAllOnControlA = False
        Me.olvReport.ShowCommandMenuOnRightClick = True
        Me.olvReport.ShowGroups = False
        Me.olvReport.ShowImagesOnSubItems = True
        Me.olvReport.ShowItemCountOnGroups = True
        Me.olvReport.Size = New System.Drawing.Size(799, 388)
        Me.olvReport.TabIndex = 5
        Me.olvReport.UseAlternatingBackColors = True
        Me.olvReport.UseCompatibleStateImageBehavior = False
        Me.olvReport.UseFiltering = True
        Me.olvReport.UseSubItemCheckBoxes = True
        Me.olvReport.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Name"
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Text = "Improvement item"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Width = 134
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Students"
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Text = "Students"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Width = 91
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "AverageQualityLevel"
        Me.OlvColumn3.AspectToStringFormat = "{0:0.0}"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Avg Quality"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 91
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(799, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadToolStripMenuItem.Text = "&Reload"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.lblTotalThird)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.lblTotalReworkMarked)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.lblTotalSecond)
        Me.KryptonPanel1.Controls.Add(Me.lblTotalFirst)
        Me.KryptonPanel1.Controls.Add(Me.lblTotalMarked)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 412)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Palette = Me.kryptonPalette2
        Me.KryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel1.Size = New System.Drawing.Size(799, 47)
        Me.KryptonPanel1.TabIndex = 7
        Me.KryptonPanel1.Visible = False
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(408, 19)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(136, 19)
        Me.KryptonLabel7.TabIndex = 15
        Me.KryptonLabel7.Values.Text = "2nd reworks marked:"
        '
        'lblTotalThird
        '
        Me.lblTotalThird.Location = New System.Drawing.Point(540, 19)
        Me.lblTotalThird.Name = "lblTotalThird"
        Me.lblTotalThird.Size = New System.Drawing.Size(18, 19)
        Me.lblTotalThird.TabIndex = 14
        Me.lblTotalThird.Values.Text = "0"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(198, 19)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(131, 19)
        Me.KryptonLabel6.TabIndex = 13
        Me.KryptonLabel6.Values.Text = "1st reworks marked:"
        '
        'lblTotalReworkMarked
        '
        Me.lblTotalReworkMarked.Location = New System.Drawing.Point(422, 1)
        Me.lblTotalReworkMarked.Name = "lblTotalReworkMarked"
        Me.lblTotalReworkMarked.Size = New System.Drawing.Size(18, 19)
        Me.lblTotalReworkMarked.TabIndex = 12
        Me.lblTotalReworkMarked.Values.Text = "0"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(260, 1)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(143, 19)
        Me.KryptonLabel5.TabIndex = 11
        Me.KryptonLabel5.Values.Text = "Total reworks marked:"
        '
        'lblTotalSecond
        '
        Me.lblTotalSecond.Location = New System.Drawing.Point(330, 19)
        Me.lblTotalSecond.Name = "lblTotalSecond"
        Me.lblTotalSecond.Size = New System.Drawing.Size(18, 19)
        Me.lblTotalSecond.TabIndex = 10
        Me.lblTotalSecond.Values.Text = "0"
        '
        'lblTotalFirst
        '
        Me.lblTotalFirst.Location = New System.Drawing.Point(111, 19)
        Me.lblTotalFirst.Name = "lblTotalFirst"
        Me.lblTotalFirst.Size = New System.Drawing.Size(18, 19)
        Me.lblTotalFirst.TabIndex = 7
        Me.lblTotalFirst.Values.Text = "0"
        '
        'lblTotalMarked
        '
        Me.lblTotalMarked.Location = New System.Drawing.Point(175, 1)
        Me.lblTotalMarked.Name = "lblTotalMarked"
        Me.lblTotalMarked.Size = New System.Drawing.Size(18, 19)
        Me.lblTotalMarked.TabIndex = 6
        Me.lblTotalMarked.Values.Text = "0"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(13, 19)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(99, 19)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Values.Text = "First markings:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 1)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(172, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Total assignments marked:"
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'ImprovementItemReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 459)
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImprovementItemReport"
        Me.Text = "Improvement Outcome Report"
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.olvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents olvReport As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalThird As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalReworkMarked As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalSecond As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalFirst As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalMarked As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
