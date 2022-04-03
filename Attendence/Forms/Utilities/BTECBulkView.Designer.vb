<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BTECBulkView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BTECBulkView))
        Me.dgvOutcomeResults = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCellToAchievedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCellToNotAchievedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCellToUnknownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerateMarkingSheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoadDataForFirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataForSecondTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutcomeFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoSizeColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.prgGeneration = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumberGenerated = New System.Windows.Forms.Label()
        Me.llblCancel = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvOutcomeResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvOutcomeResults
        '
        Me.dgvOutcomeResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOutcomeResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutcomeResults.Location = New System.Drawing.Point(0, 24)
        Me.dgvOutcomeResults.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvOutcomeResults.Name = "dgvOutcomeResults"
        Me.dgvOutcomeResults.Size = New System.Drawing.Size(1078, 502)
        Me.dgvOutcomeResults.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1078, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveChangesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveChangesToolStripMenuItem
        '
        Me.SaveChangesToolStripMenuItem.Name = "SaveChangesToolStripMenuItem"
        Me.SaveChangesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SaveChangesToolStripMenuItem.Text = "&Save changes"
        Me.SaveChangesToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeCellToAchievedToolStripMenuItem, Me.ChangeCellToNotAchievedToolStripMenuItem, Me.ChangeCellToUnknownToolStripMenuItem, Me.ToolStripSeparator1, Me.GenerateMarkingSheetsToolStripMenuItem, Me.ToolStripSeparator2, Me.LoadDataForFirstTryToolStripMenuItem, Me.LoadDataForSecondTryToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'ChangeCellToAchievedToolStripMenuItem
        '
        Me.ChangeCellToAchievedToolStripMenuItem.Name = "ChangeCellToAchievedToolStripMenuItem"
        Me.ChangeCellToAchievedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ChangeCellToAchievedToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.ChangeCellToAchievedToolStripMenuItem.Text = "Change cell to Achieved"
        '
        'ChangeCellToNotAchievedToolStripMenuItem
        '
        Me.ChangeCellToNotAchievedToolStripMenuItem.Name = "ChangeCellToNotAchievedToolStripMenuItem"
        Me.ChangeCellToNotAchievedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.ChangeCellToNotAchievedToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.ChangeCellToNotAchievedToolStripMenuItem.Text = "Change cell to Not Achieved"
        '
        'ChangeCellToUnknownToolStripMenuItem
        '
        Me.ChangeCellToUnknownToolStripMenuItem.Name = "ChangeCellToUnknownToolStripMenuItem"
        Me.ChangeCellToUnknownToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.ChangeCellToUnknownToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.ChangeCellToUnknownToolStripMenuItem.Text = "Change cell to Unknown"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(272, 6)
        '
        'GenerateMarkingSheetsToolStripMenuItem
        '
        Me.GenerateMarkingSheetsToolStripMenuItem.Name = "GenerateMarkingSheetsToolStripMenuItem"
        Me.GenerateMarkingSheetsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GenerateMarkingSheetsToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.GenerateMarkingSheetsToolStripMenuItem.Text = "&Generate marking sheets"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(272, 6)
        '
        'LoadDataForFirstTryToolStripMenuItem
        '
        Me.LoadDataForFirstTryToolStripMenuItem.Name = "LoadDataForFirstTryToolStripMenuItem"
        Me.LoadDataForFirstTryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LoadDataForFirstTryToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LoadDataForFirstTryToolStripMenuItem.Text = "Load data for first try"
        '
        'LoadDataForSecondTryToolStripMenuItem
        '
        Me.LoadDataForSecondTryToolStripMenuItem.Name = "LoadDataForSecondTryToolStripMenuItem"
        Me.LoadDataForSecondTryToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LoadDataForSecondTryToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LoadDataForSecondTryToolStripMenuItem.Text = "Load data for second try"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutcomeFeedbackToolStripMenuItem, Me.AutoSizeColumnsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'OutcomeFeedbackToolStripMenuItem
        '
        Me.OutcomeFeedbackToolStripMenuItem.Checked = True
        Me.OutcomeFeedbackToolStripMenuItem.CheckOnClick = True
        Me.OutcomeFeedbackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OutcomeFeedbackToolStripMenuItem.Name = "OutcomeFeedbackToolStripMenuItem"
        Me.OutcomeFeedbackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.OutcomeFeedbackToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.OutcomeFeedbackToolStripMenuItem.Text = "Outcome feedback"
        '
        'AutoSizeColumnsToolStripMenuItem
        '
        Me.AutoSizeColumnsToolStripMenuItem.Name = "AutoSizeColumnsToolStripMenuItem"
        Me.AutoSizeColumnsToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AutoSizeColumnsToolStripMenuItem.Text = "Auto size columns"
        '
        'prgGeneration
        '
        Me.prgGeneration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prgGeneration.Location = New System.Drawing.Point(0, 555)
        Me.prgGeneration.Name = "prgGeneration"
        Me.prgGeneration.Size = New System.Drawing.Size(1078, 23)
        Me.prgGeneration.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgGeneration.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 530)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Written:"
        '
        'lblNumberGenerated
        '
        Me.lblNumberGenerated.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumberGenerated.AutoSize = True
        Me.lblNumberGenerated.Location = New System.Drawing.Point(72, 530)
        Me.lblNumberGenerated.Name = "lblNumberGenerated"
        Me.lblNumberGenerated.Size = New System.Drawing.Size(15, 16)
        Me.lblNumberGenerated.TabIndex = 3
        Me.lblNumberGenerated.Text = "0"
        '
        'llblCancel
        '
        Me.llblCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llblCancel.AutoSize = True
        Me.llblCancel.Location = New System.Drawing.Point(255, 530)
        Me.llblCancel.Name = "llblCancel"
        Me.llblCancel.Size = New System.Drawing.Size(48, 16)
        Me.llblCancel.TabIndex = 4
        Me.llblCancel.TabStop = True
        Me.llblCancel.Text = "Cancel"
        '
        'BTECBulkView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 578)
        Me.Controls.Add(Me.llblCancel)
        Me.Controls.Add(Me.lblNumberGenerated)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prgGeneration)
        Me.Controls.Add(Me.dgvOutcomeResults)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BTECBulkView"
        Me.Text = "BTEC Bulk View"
        CType(Me.dgvOutcomeResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvOutcomeResults As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateMarkingSheetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeCellToAchievedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeCellToNotAchievedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeCellToUnknownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutcomeFeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveChangesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LoadDataForFirstTryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadDataForSecondTryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoSizeColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents prgGeneration As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumberGenerated As Label
    Friend WithEvents llblCancel As LinkLabel
End Class
