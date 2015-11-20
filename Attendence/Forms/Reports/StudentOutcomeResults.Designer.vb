<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentOutcomeResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentOutcomeResults))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.olvcolAdmin = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolStudentID = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolOutcomeName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFilter = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearFilter = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondRedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrFilterStudents = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(875, 515)
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
        Me.KryptonPanel1.Size = New System.Drawing.Size(875, 515)
        Me.KryptonPanel1.TabIndex = 1
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.olvcolAdmin)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllColumns.Add(Me.olvcolStudentID)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudents.AllColumns.Add(Me.olvcolOutcomeName)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn9)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn10)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn11)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn12)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn13)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.olvcolAdmin, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn4, Me.olvcolStudentID, Me.OlvColumn6, Me.olvcolOutcomeName, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn11, Me.OlvColumn12, Me.OlvColumn13})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "No data for this assignment...click menu above."
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 52)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.OwnerDraw = True
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowCommandMenuOnRightClick = True
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(875, 463)
        Me.olvStudents.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.olvStudents.TabIndex = 5
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'olvcolAdmin
        '
        Me.olvcolAdmin.AspectName = "Assignment.Student.AdminNumber"
        Me.olvcolAdmin.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolAdmin.IsEditable = False
        Me.olvcolAdmin.Text = "Admin"
        Me.olvcolAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolAdmin.Width = 63
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Assignment.Student.AltNumber"
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.Text = "Alt"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Assignment.Student.LocalName"
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Local"
        Me.OlvColumn3.Width = 87
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Assignment.Student.Nickname"
        Me.OlvColumn4.IsEditable = False
        Me.OlvColumn4.Text = "Nickname"
        Me.OlvColumn4.Width = 96
        '
        'olvcolStudentID
        '
        Me.olvcolStudentID.AspectName = "Assignment.Student.StudentID"
        Me.olvcolStudentID.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolStudentID.IsEditable = False
        Me.olvcolStudentID.Text = "ID"
        Me.olvcolStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolStudentID.Width = 80
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "Assignment.BaseAssignment.Name"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Asmt"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Width = 86
        '
        'olvcolOutcomeName
        '
        Me.olvcolOutcomeName.AspectName = "BaseOutcome.Name"
        Me.olvcolOutcomeName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolOutcomeName.IsEditable = False
        Me.olvcolOutcomeName.Text = "Outcome"
        Me.olvcolOutcomeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolOutcomeName.Width = 71
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "FirstTryStatus"
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "First Try"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Width = 102
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "FirstTryComments"
        Me.OlvColumn9.Text = "First comments"
        Me.OlvColumn9.Width = 197
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "SecondTryStatus"
        Me.OlvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.Text = "Second Try"
        Me.OlvColumn10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "SecondTryComments"
        Me.OlvColumn11.Text = "Second comments"
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "ThirdTryStatus"
        Me.OlvColumn12.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.Text = "Third Try"
        Me.OlvColumn12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "ThirdTryComments"
        Me.OlvColumn13.Text = "Third comments"
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel2.Controls.Add(Me.txtFilter)
        Me.KryptonPanel2.Controls.Add(Me.llblClearFilter)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(875, 28)
        Me.KryptonPanel2.TabIndex = 7
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 5)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(40, 20)
        Me.KryptonLabel3.TabIndex = 66
        Me.KryptonLabel3.Values.Text = "Filter:"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(49, 3)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(405, 20)
        Me.txtFilter.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.txtFilter, "Student filter")
        '
        'llblClearFilter
        '
        Me.llblClearFilter.Location = New System.Drawing.Point(460, 5)
        Me.llblClearFilter.Name = "llblClearFilter"
        Me.llblClearFilter.Size = New System.Drawing.Size(22, 18)
        Me.llblClearFilter.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.llblClearFilter, "Clear filter")
        Me.llblClearFilter.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblClearFilter.Values.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTryToolStripMenuItem, Me.RedoToolStripMenuItem, Me.SecondRedoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 24)
        Me.MenuStrip1.TabIndex = 6
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
        'tmrFilterStudents
        '
        Me.tmrFilterStudents.Interval = 200
        '
        'StudentOutcomeResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 515)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentOutcomeResults"
        Me.Text = "Student Outcome Results"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents olvcolAdmin As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolStudentID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolOutcomeName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondRedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents txtFilter As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblClearFilter As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents tmrFilterStudents As System.Windows.Forms.Timer
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
