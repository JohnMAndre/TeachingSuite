<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreperationStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreperationStatus))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lblPreppedPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUnpreppedPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.olvReport = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.lblUnprepped = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPreppedSessions = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblNextUnpreppedModuleName = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDaysUntilNextUnprepped = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNextUnprepped = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalSessions = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(901, 437)
        Me.KryptonPanel.TabIndex = 0
        '
        'lblPreppedPercent
        '
        Me.lblPreppedPercent.Location = New System.Drawing.Point(211, 19)
        Me.lblPreppedPercent.Name = "lblPreppedPercent"
        Me.lblPreppedPercent.Size = New System.Drawing.Size(17, 20)
        Me.lblPreppedPercent.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.lblPreppedPercent, "Percent of sessions prepped")
        Me.lblPreppedPercent.Values.Text = "0"
        '
        'lblUnpreppedPercent
        '
        Me.lblUnpreppedPercent.Location = New System.Drawing.Point(211, 37)
        Me.lblUnpreppedPercent.Name = "lblUnpreppedPercent"
        Me.lblUnpreppedPercent.Size = New System.Drawing.Size(17, 20)
        Me.lblUnpreppedPercent.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.lblUnpreppedPercent, "Percent of sessions unprepped")
        Me.lblUnpreppedPercent.Values.Text = "0"
        '
        'olvReport
        '
        Me.olvReport.AllColumns.Add(Me.OlvColumn1)
        Me.olvReport.AllColumns.Add(Me.OlvColumn4)
        Me.olvReport.AllColumns.Add(Me.OlvColumn2)
        Me.olvReport.AllColumns.Add(Me.OlvColumn3)
        Me.olvReport.AllColumns.Add(Me.OlvColumn7)
        Me.olvReport.AllColumns.Add(Me.OlvColumn5)
        Me.olvReport.AllColumns.Add(Me.OlvColumn6)
        Me.olvReport.AllowColumnReorder = True
        Me.olvReport.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvReport.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn4, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn7, Me.OlvColumn5, Me.OlvColumn6})
        Me.olvReport.CopySelectionOnControlC = False
        Me.olvReport.CopySelectionOnControlCUsesDragSource = False
        Me.olvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvReport.EmptyListMsg = "No module sessions found"
        Me.olvReport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvReport.FullRowSelect = True
        Me.olvReport.GridLines = True
        Me.olvReport.HasCollapsibleGroups = False
        Me.olvReport.HideSelection = False
        Me.olvReport.Location = New System.Drawing.Point(0, 24)
        Me.olvReport.MultiSelect = False
        Me.olvReport.Name = "olvReport"
        Me.olvReport.OwnerDraw = True
        Me.olvReport.SelectAllOnControlA = False
        Me.olvReport.ShowCommandMenuOnRightClick = True
        Me.olvReport.ShowGroups = False
        Me.olvReport.ShowImagesOnSubItems = True
        Me.olvReport.ShowItemCountOnGroups = True
        Me.olvReport.Size = New System.Drawing.Size(901, 348)
        Me.olvReport.TabIndex = 5
        Me.olvReport.UseAlternatingBackColors = True
        Me.olvReport.UseCompatibleStateImageBehavior = False
        Me.olvReport.UseFiltering = True
        Me.olvReport.UseSubItemCheckBoxes = True
        Me.olvReport.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "ModuleName"
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Text = "Module"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Width = 134
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "TotalSessions"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Sessions"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Width = 108
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "PreppedSessions"
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Text = "Prepped"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Width = 83
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "UnpreppedSessions"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Unprepped"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 91
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "PercentComplete"
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Text = "%"
        Me.OlvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "EarliestUnpreppedText"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "Earliest unprepped day"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Width = 147
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "FinalSession"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Text = "Final session"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Width = 150
        '
        'lblUnprepped
        '
        Me.lblUnprepped.Location = New System.Drawing.Point(134, 37)
        Me.lblUnprepped.Name = "lblUnprepped"
        Me.lblUnprepped.Size = New System.Drawing.Size(17, 20)
        Me.lblUnprepped.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.lblUnprepped, "Sessions not prepped yet")
        Me.lblUnprepped.Values.Text = "0"
        '
        'lblPreppedSessions
        '
        Me.lblPreppedSessions.Location = New System.Drawing.Point(134, 19)
        Me.lblPreppedSessions.Name = "lblPreppedSessions"
        Me.lblPreppedSessions.Size = New System.Drawing.Size(17, 20)
        Me.lblPreppedSessions.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lblPreppedSessions, "Sessions already prepped")
        Me.lblPreppedSessions.Values.Text = "0"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblNextUnpreppedModuleName)
        Me.KryptonPanel1.Controls.Add(Me.lblDaysUntilNextUnprepped)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.lblNextUnprepped)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.lblPreppedPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblUnpreppedPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblUnprepped)
        Me.KryptonPanel1.Controls.Add(Me.lblPreppedSessions)
        Me.KryptonPanel1.Controls.Add(Me.lblTotalSessions)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 372)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(901, 65)
        Me.KryptonPanel1.TabIndex = 7
        '
        'lblNextUnpreppedModuleName
        '
        Me.lblNextUnpreppedModuleName.Location = New System.Drawing.Point(495, 37)
        Me.lblNextUnpreppedModuleName.Name = "lblNextUnpreppedModuleName"
        Me.lblNextUnpreppedModuleName.Size = New System.Drawing.Size(6, 2)
        Me.lblNextUnpreppedModuleName.TabIndex = 15
        Me.lblNextUnpreppedModuleName.Values.Text = ""
        '
        'lblDaysUntilNextUnprepped
        '
        Me.lblDaysUntilNextUnprepped.Location = New System.Drawing.Point(435, 37)
        Me.lblDaysUntilNextUnprepped.Name = "lblDaysUntilNextUnprepped"
        Me.lblDaysUntilNextUnprepped.Size = New System.Drawing.Size(17, 20)
        Me.lblDaysUntilNextUnprepped.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.lblDaysUntilNextUnprepped, "Number of days until you reach the next unprepped teaching session")
        Me.lblDaysUntilNextUnprepped.Values.Text = "0"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(314, 37)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(118, 20)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Values.Text = "Days to unprepped:"
        '
        'lblNextUnprepped
        '
        Me.lblNextUnprepped.Location = New System.Drawing.Point(435, 3)
        Me.lblNextUnprepped.Name = "lblNextUnprepped"
        Me.lblNextUnprepped.Size = New System.Drawing.Size(17, 20)
        Me.lblNextUnprepped.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.lblNextUnprepped, "Start time of next unprepped teaching session")
        Me.lblNextUnprepped.Values.Text = "0"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(314, 3)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(102, 20)
        Me.KryptonLabel5.TabIndex = 11
        Me.KryptonLabel5.Values.Text = "Next unprepped:"
        '
        'lblTotalSessions
        '
        Me.lblTotalSessions.Location = New System.Drawing.Point(134, 1)
        Me.lblTotalSessions.Name = "lblTotalSessions"
        Me.lblTotalSessions.Size = New System.Drawing.Size(17, 20)
        Me.lblTotalSessions.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.lblTotalSessions, "Total sessions to deliver")
        Me.lblTotalSessions.Values.Text = "0"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 37)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(75, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Values.Text = "Unprepped:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(13, 19)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(59, 20)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Values.Text = "Prepped:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 1)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Total sessions:"
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.olvReport)
        Me.KryptonPanel2.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel2.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(901, 437)
        Me.KryptonPanel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(901, 24)
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
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.LoadToolStripMenuItem.Text = "&Reload"
        '
        'PreperationStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 437)
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PreperationStatus"
        Me.Text = "Preperation Status"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents lblPreppedPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblUnpreppedPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents olvReport As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents lblUnprepped As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPreppedSessions As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblTotalSessions As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDaysUntilNextUnprepped As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNextUnprepped As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNextUnpreppedModuleName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
End Class
