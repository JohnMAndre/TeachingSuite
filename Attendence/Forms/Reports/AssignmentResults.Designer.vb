<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignmentResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignmentResults))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPassPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFailPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNoSubmitPercent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPassPercentSubmit = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFailPercentSubmit = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblNoSubmit = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFail = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPass = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.miniToolStrip = New System.Windows.Forms.MenuStrip()
        Me.FirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondRedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblSubmissionAttempt = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
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
        'lblFailPercent
        '
        Me.lblFailPercent.Location = New System.Drawing.Point(134, 19)
        Me.lblFailPercent.Name = "lblFailPercent"
        Me.lblFailPercent.Size = New System.Drawing.Size(18, 19)
        Me.lblFailPercent.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lblFailPercent, "Percent of all students")
        Me.lblFailPercent.Values.Text = "0"
        '
        'lblNoSubmitPercent
        '
        Me.lblNoSubmitPercent.Location = New System.Drawing.Point(134, 37)
        Me.lblNoSubmitPercent.Name = "lblNoSubmitPercent"
        Me.lblNoSubmitPercent.Size = New System.Drawing.Size(18, 19)
        Me.lblNoSubmitPercent.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.lblNoSubmitPercent, "Percent of all students")
        Me.lblNoSubmitPercent.Values.Text = "0"
        '
        'lblPassPercentSubmit
        '
        Me.lblPassPercentSubmit.Location = New System.Drawing.Point(211, 1)
        Me.lblPassPercentSubmit.Name = "lblPassPercentSubmit"
        Me.lblPassPercentSubmit.Size = New System.Drawing.Size(18, 19)
        Me.lblPassPercentSubmit.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.lblPassPercentSubmit, "Percent of students who submitted")
        Me.lblPassPercentSubmit.Values.Text = "0"
        '
        'lblFailPercentSubmit
        '
        Me.lblFailPercentSubmit.Location = New System.Drawing.Point(211, 19)
        Me.lblFailPercentSubmit.Name = "lblFailPercentSubmit"
        Me.lblFailPercentSubmit.Size = New System.Drawing.Size(18, 19)
        Me.lblFailPercentSubmit.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.lblFailPercentSubmit, "Percent of students who submitted")
        Me.lblFailPercentSubmit.Values.Text = "0"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblSubmissionAttempt)
        Me.KryptonPanel1.Controls.Add(Me.lblFailPercentSubmit)
        Me.KryptonPanel1.Controls.Add(Me.lblPassPercentSubmit)
        Me.KryptonPanel1.Controls.Add(Me.lblNoSubmitPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblFailPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblPassPercent)
        Me.KryptonPanel1.Controls.Add(Me.lblNoSubmit)
        Me.KryptonPanel1.Controls.Add(Me.lblFail)
        Me.KryptonPanel1.Controls.Add(Me.lblPass)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 379)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(914, 65)
        Me.KryptonPanel1.TabIndex = 7
        '
        'lblNoSubmit
        '
        Me.lblNoSubmit.Location = New System.Drawing.Point(56, 37)
        Me.lblNoSubmit.Name = "lblNoSubmit"
        Me.lblNoSubmit.Size = New System.Drawing.Size(18, 19)
        Me.lblNoSubmit.TabIndex = 5
        Me.lblNoSubmit.Values.Text = "0"
        '
        'lblFail
        '
        Me.lblFail.Location = New System.Drawing.Point(56, 19)
        Me.lblFail.Name = "lblFail"
        Me.lblFail.Size = New System.Drawing.Size(18, 19)
        Me.lblFail.TabIndex = 4
        Me.lblFail.Values.Text = "0"
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(56, 1)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(18, 19)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Values.Text = "0"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 37)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(33, 19)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Values.Text = "NS:"
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
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.miniToolStrip.Location = New System.Drawing.Point(206, 2)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(914, 24)
        Me.miniToolStrip.TabIndex = 6
        '
        'FirstTryToolStripMenuItem
        '
        Me.FirstTryToolStripMenuItem.Name = "FirstTryToolStripMenuItem"
        Me.FirstTryToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FirstTryToolStripMenuItem.Text = "First Try"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RedoToolStripMenuItem.Text = "Rework"
        '
        'SecondRedoToolStripMenuItem
        '
        Me.SecondRedoToolStripMenuItem.Name = "SecondRedoToolStripMenuItem"
        Me.SecondRedoToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SecondRedoToolStripMenuItem.Text = "2nd Rework"
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn5)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudents.CellEditUseWholeCell = False
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn5, Me.OlvColumn3, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn1, Me.OlvColumn2})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "No data for this assignment...click menu above."
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 24)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowCommandMenuOnRightClick = True
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(914, 355)
        Me.olvStudents.TabIndex = 5
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
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Student.StudentID"
        Me.OlvColumn3.DisplayIndex = 2
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 129
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "AchievedMerit"
        Me.OlvColumn6.CheckBoxes = True
        Me.OlvColumn6.DisplayIndex = 3
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Merit"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "AchievedDistinction"
        Me.OlvColumn7.CheckBoxes = True
        Me.OlvColumn7.DisplayIndex = 4
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.IsEditable = False
        Me.OlvColumn7.Text = "Distinction"
        Me.OlvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Width = 85
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Student.Nickname"
        Me.OlvColumn1.DisplayIndex = 1
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Nickname"
        Me.OlvColumn1.Width = 130
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
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.olvStudents)
        Me.KryptonPanel.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(914, 444)
        Me.KryptonPanel.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTryToolStripMenuItem, Me.RedoToolStripMenuItem, Me.SecondRedoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblSubmissionAttempt
        '
        Me.lblSubmissionAttempt.Location = New System.Drawing.Point(254, 43)
        Me.lblSubmissionAttempt.Name = "lblSubmissionAttempt"
        Me.lblSubmissionAttempt.Size = New System.Drawing.Size(6, 2)
        Me.lblSubmissionAttempt.TabIndex = 11
        Me.lblSubmissionAttempt.Values.Text = ""
        '
        'AssignmentResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 444)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AssignmentResults"
        Me.Text = "Assignment Results"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblFailPercentSubmit As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPassPercentSubmit As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNoSubmitPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFailPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPassPercent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNoSubmit As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFail As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPass As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents miniToolStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondRedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblSubmissionAttempt As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
