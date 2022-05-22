<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupPresentationQuickFeedback
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
        Me.dgvQuickFeedback = New System.Windows.Forms.DataGridView()
        Me.Copy = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.QuickText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyQuickTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuickTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewQuickTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvQuickFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvQuickFeedback
        '
        Me.dgvQuickFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuickFeedback.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Copy, Me.QuickText})
        Me.dgvQuickFeedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQuickFeedback.Location = New System.Drawing.Point(0, 24)
        Me.dgvQuickFeedback.MultiSelect = False
        Me.dgvQuickFeedback.Name = "dgvQuickFeedback"
        Me.dgvQuickFeedback.Size = New System.Drawing.Size(432, 293)
        Me.dgvQuickFeedback.TabIndex = 0
        '
        'Copy
        '
        Me.Copy.HeaderText = "Copy"
        Me.Copy.Name = "Copy"
        Me.Copy.ReadOnly = True
        Me.Copy.Text = "Copy"
        Me.Copy.Width = 40
        '
        'QuickText
        '
        Me.QuickText.DataPropertyName = "Text"
        Me.QuickText.HeaderText = "Text"
        Me.QuickText.Name = "QuickText"
        Me.QuickText.Width = 300
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(432, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyQuickTextToolStripMenuItem, Me.DeleteQuickTextToolStripMenuItem, Me.AddNewQuickTextToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'CopyQuickTextToolStripMenuItem
        '
        Me.CopyQuickTextToolStripMenuItem.Name = "CopyQuickTextToolStripMenuItem"
        Me.CopyQuickTextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyQuickTextToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CopyQuickTextToolStripMenuItem.Text = "&Copy quick text"
        '
        'DeleteQuickTextToolStripMenuItem
        '
        Me.DeleteQuickTextToolStripMenuItem.Name = "DeleteQuickTextToolStripMenuItem"
        Me.DeleteQuickTextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteQuickTextToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.DeleteQuickTextToolStripMenuItem.Text = "&Delete quick text"
        '
        'AddNewQuickTextToolStripMenuItem
        '
        Me.AddNewQuickTextToolStripMenuItem.Name = "AddNewQuickTextToolStripMenuItem"
        Me.AddNewQuickTextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddNewQuickTextToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AddNewQuickTextToolStripMenuItem.Text = "&Add new quick text"
        '
        'GroupPresentationQuickFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvQuickFeedback)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GroupPresentationQuickFeedback"
        Me.Text = "Quick Feedback"
        CType(Me.dgvQuickFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvQuickFeedback As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyQuickTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteQuickTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewQuickTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Copy As DataGridViewButtonColumn
    Friend WithEvents QuickText As DataGridViewTextBoxColumn
End Class
