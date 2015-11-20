<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuleFeedbackVerification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuleFeedbackVerification))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondRedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.KryptonManager2 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.olvFeedback = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.olvFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StudentID"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 110
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTryToolStripMenuItem, Me.RedoToolStripMenuItem, Me.SecondRedoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 11
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
        'olvFeedback
        '
        Me.olvFeedback.AllColumns.Add(Me.OlvColumn3)
        Me.olvFeedback.AllColumns.Add(Me.OlvColumn4)
        Me.olvFeedback.AllColumns.Add(Me.OlvColumn1)
        Me.olvFeedback.AllColumns.Add(Me.OlvColumn2)
        Me.olvFeedback.AllowColumnReorder = True
        Me.olvFeedback.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvFeedback.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvFeedback.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn1, Me.OlvColumn2})
        Me.olvFeedback.CopySelectionOnControlC = False
        Me.olvFeedback.CopySelectionOnControlCUsesDragSource = False
        Me.olvFeedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvFeedback.EmptyListMsg = "No data for this module...click menu above."
        Me.olvFeedback.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvFeedback.FullRowSelect = True
        Me.olvFeedback.GridLines = True
        Me.olvFeedback.HideSelection = False
        Me.olvFeedback.Location = New System.Drawing.Point(0, 24)
        Me.olvFeedback.MultiSelect = False
        Me.olvFeedback.Name = "olvFeedback"
        Me.olvFeedback.OwnerDraw = True
        Me.olvFeedback.SelectAllOnControlA = False
        Me.olvFeedback.ShowCommandMenuOnRightClick = True
        Me.olvFeedback.ShowGroups = False
        Me.olvFeedback.ShowImagesOnSubItems = True
        Me.olvFeedback.ShowItemCountOnGroups = True
        Me.olvFeedback.Size = New System.Drawing.Size(709, 354)
        Me.olvFeedback.TabIndex = 12
        Me.olvFeedback.UseAlternatingBackColors = True
        Me.olvFeedback.UseCompatibleStateImageBehavior = False
        Me.olvFeedback.UseFiltering = True
        Me.olvFeedback.UseSubItemCheckBoxes = True
        Me.olvFeedback.View = System.Windows.Forms.View.Details
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Outcome"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Outcome"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Width = 97
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Status"
        Me.OlvColumn1.Text = "Pass"
        Me.OlvColumn1.Width = 74
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Feedback"
        Me.OlvColumn2.Text = "Feedback"
        Me.OlvColumn2.Width = 377
        '
        'ModuleFeedbackVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 378)
        Me.Controls.Add(Me.olvFeedback)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModuleFeedbackVerification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Module Feedback Verification"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.olvFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondRedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonManager2 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents olvFeedback As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
End Class
