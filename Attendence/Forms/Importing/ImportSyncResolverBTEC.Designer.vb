<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportSyncResolverBTEC
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUseImport = New System.Windows.Forms.Button()
        Me.btnUseExisting = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblImportImprovement = New System.Windows.Forms.Label()
        Me.lblImportOverall = New System.Windows.Forms.Label()
        Me.lblExistingImprovement = New System.Windows.Forms.Label()
        Me.lblExistingOverall = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstStudentID = New System.Windows.Forms.ListBox()
        Me.olvOutcomes = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumnOutcomeName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ObjectListView1 = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn15 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn16 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn17 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.olvOutcomes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(10, 447)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(132, 32)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUseImport
        '
        Me.btnUseImport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnUseImport.Location = New System.Drawing.Point(0, 426)
        Me.btnUseImport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUseImport.Name = "btnUseImport"
        Me.btnUseImport.Size = New System.Drawing.Size(291, 32)
        Me.btnUseImport.TabIndex = 34
        Me.btnUseImport.Text = "Use &import"
        Me.btnUseImport.UseVisualStyleBackColor = True
        '
        'btnUseExisting
        '
        Me.btnUseExisting.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnUseExisting.Location = New System.Drawing.Point(0, 426)
        Me.btnUseExisting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUseExisting.Name = "btnUseExisting"
        Me.btnUseExisting.Size = New System.Drawing.Size(240, 32)
        Me.btnUseExisting.TabIndex = 33
        Me.btnUseExisting.Text = "Use &existing"
        Me.btnUseExisting.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Student ID"
        '
        'lblImportImprovement
        '
        Me.lblImportImprovement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblImportImprovement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblImportImprovement.Location = New System.Drawing.Point(0, 251)
        Me.lblImportImprovement.Name = "lblImportImprovement"
        Me.lblImportImprovement.Size = New System.Drawing.Size(291, 175)
        Me.lblImportImprovement.TabIndex = 31
        '
        'lblImportOverall
        '
        Me.lblImportOverall.BackColor = System.Drawing.Color.White
        Me.lblImportOverall.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblImportOverall.Location = New System.Drawing.Point(0, 160)
        Me.lblImportOverall.Name = "lblImportOverall"
        Me.lblImportOverall.Size = New System.Drawing.Size(291, 91)
        Me.lblImportOverall.TabIndex = 30
        '
        'lblExistingImprovement
        '
        Me.lblExistingImprovement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblExistingImprovement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExistingImprovement.Location = New System.Drawing.Point(0, 251)
        Me.lblExistingImprovement.Name = "lblExistingImprovement"
        Me.lblExistingImprovement.Size = New System.Drawing.Size(240, 175)
        Me.lblExistingImprovement.TabIndex = 29
        '
        'lblExistingOverall
        '
        Me.lblExistingOverall.BackColor = System.Drawing.Color.White
        Me.lblExistingOverall.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblExistingOverall.Location = New System.Drawing.Point(0, 160)
        Me.lblExistingOverall.Name = "lblExistingOverall"
        Me.lblExistingOverall.Size = New System.Drawing.Size(240, 91)
        Me.lblExistingOverall.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(291, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "To import"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Existing"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(165, 20)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(0, 16)
        Me.lblStudentName.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Improvement:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Overall:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Outcomes:"
        '
        'lstStudentID
        '
        Me.lstStudentID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstStudentID.FormattingEnabled = True
        Me.lstStudentID.ItemHeight = 16
        Me.lstStudentID.Location = New System.Drawing.Point(12, 50)
        Me.lstStudentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstStudentID.Name = "lstStudentID"
        Me.lstStudentID.Size = New System.Drawing.Size(130, 372)
        Me.lstStudentID.TabIndex = 19
        '
        'olvOutcomes
        '
        Me.olvOutcomes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumnOutcomeName)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn6)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn7)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn8)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn9)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn10)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn11)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn12)
        Me.olvOutcomes.AllColumns.Add(Me.OlvColumn2)
        Me.olvOutcomes.AllowColumnReorder = True
        Me.olvOutcomes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvOutcomes.CellEditUseWholeCell = False
        Me.olvOutcomes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumnOutcomeName, Me.OlvColumn6, Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn11, Me.OlvColumn12, Me.OlvColumn2})
        Me.olvOutcomes.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvOutcomes.Dock = System.Windows.Forms.DockStyle.Top
        Me.olvOutcomes.EmptyListMsg = "No learning outcomes for this assessment"
        Me.olvOutcomes.FullRowSelect = True
        Me.olvOutcomes.HideSelection = False
        Me.olvOutcomes.Location = New System.Drawing.Point(0, 16)
        Me.olvOutcomes.Name = "olvOutcomes"
        Me.olvOutcomes.ShowGroups = False
        Me.olvOutcomes.Size = New System.Drawing.Size(240, 144)
        Me.olvOutcomes.TabIndex = 43
        Me.olvOutcomes.TriggerCellOverEventsWhenOverHeader = False
        Me.olvOutcomes.UseCompatibleStateImageBehavior = False
        Me.olvOutcomes.View = System.Windows.Forms.View.Details
        '
        'OlvColumnOutcomeName
        '
        Me.OlvColumnOutcomeName.AspectName = "Name"
        Me.OlvColumnOutcomeName.DisplayIndex = 1
        Me.OlvColumnOutcomeName.IsEditable = False
        Me.OlvColumnOutcomeName.Text = "Name"
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "Description"
        Me.OlvColumn6.DisplayIndex = 0
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Description"
        Me.OlvColumn6.Width = 144
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "FirstTryStatus"
        Me.OlvColumn7.DisplayIndex = 3
        Me.OlvColumn7.Text = "First"
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "FirstTryComments"
        Me.OlvColumn8.AutoCompleteEditor = False
        Me.OlvColumn8.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn8.DisplayIndex = 4
        Me.OlvColumn8.Text = "Feedback"
        Me.OlvColumn8.Width = 299
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "SecondTryStatus"
        Me.OlvColumn9.DisplayIndex = 5
        Me.OlvColumn9.Text = "Rework"
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "SecondTryComments"
        Me.OlvColumn10.AutoCompleteEditor = False
        Me.OlvColumn10.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn10.DisplayIndex = 6
        Me.OlvColumn10.Text = "Feedback"
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "ThirdTryStatus"
        Me.OlvColumn11.DisplayIndex = 7
        Me.OlvColumn11.Text = "2nd Rework"
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "ThirdTryComments"
        Me.OlvColumn12.AutoCompleteEditor = False
        Me.OlvColumn12.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn12.DisplayIndex = 8
        Me.OlvColumn12.Text = "Feedback"
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "BaseOutcome.GradeGroup"
        Me.OlvColumn2.DisplayIndex = 2
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.Text = "Grade"
        Me.OlvColumn2.Width = 77
        '
        'ObjectListView1
        '
        Me.ObjectListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn1)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn3)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn4)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn5)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn13)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn14)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn15)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn16)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn17)
        Me.ObjectListView1.AllowColumnReorder = True
        Me.ObjectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.ObjectListView1.CellEditUseWholeCell = False
        Me.ObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn5, Me.OlvColumn13, Me.OlvColumn14, Me.OlvColumn15, Me.OlvColumn16, Me.OlvColumn17})
        Me.ObjectListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ObjectListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ObjectListView1.EmptyListMsg = "No learning outcomes for this assessment"
        Me.ObjectListView1.FullRowSelect = True
        Me.ObjectListView1.HideSelection = False
        Me.ObjectListView1.Location = New System.Drawing.Point(0, 16)
        Me.ObjectListView1.Name = "ObjectListView1"
        Me.ObjectListView1.ShowGroups = False
        Me.ObjectListView1.Size = New System.Drawing.Size(291, 144)
        Me.ObjectListView1.TabIndex = 44
        Me.ObjectListView1.TriggerCellOverEventsWhenOverHeader = False
        Me.ObjectListView1.UseCompatibleStateImageBehavior = False
        Me.ObjectListView1.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Name"
        Me.OlvColumn1.DisplayIndex = 1
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Name"
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Description"
        Me.OlvColumn3.DisplayIndex = 0
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Description"
        Me.OlvColumn3.Width = 144
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "FirstTryStatus"
        Me.OlvColumn4.DisplayIndex = 3
        Me.OlvColumn4.Text = "First"
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "FirstTryComments"
        Me.OlvColumn5.AutoCompleteEditor = False
        Me.OlvColumn5.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn5.DisplayIndex = 4
        Me.OlvColumn5.Text = "Feedback"
        Me.OlvColumn5.Width = 299
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "SecondTryStatus"
        Me.OlvColumn13.DisplayIndex = 5
        Me.OlvColumn13.Text = "Rework"
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "SecondTryComments"
        Me.OlvColumn14.AutoCompleteEditor = False
        Me.OlvColumn14.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn14.DisplayIndex = 6
        Me.OlvColumn14.Text = "Feedback"
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "ThirdTryStatus"
        Me.OlvColumn15.DisplayIndex = 7
        Me.OlvColumn15.Text = "2nd Rework"
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "ThirdTryComments"
        Me.OlvColumn16.AutoCompleteEditor = False
        Me.OlvColumn16.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None
        Me.OlvColumn16.DisplayIndex = 8
        Me.OlvColumn16.Text = "Feedback"
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "BaseOutcome.GradeGroup"
        Me.OlvColumn17.DisplayIndex = 2
        Me.OlvColumn17.IsEditable = False
        Me.OlvColumn17.Text = "Grade"
        Me.OlvColumn17.Width = 77
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(244, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblExistingImprovement)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblExistingOverall)
        Me.SplitContainer1.Panel1.Controls.Add(Me.olvOutcomes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUseExisting)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblImportImprovement)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblImportOverall)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ObjectListView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnUseImport)
        Me.SplitContainer1.Size = New System.Drawing.Size(535, 458)
        Me.SplitContainer1.SplitterDistance = 240
        Me.SplitContainer1.TabIndex = 45
        '
        'ImportSyncResolverBTEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 499)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstStudentID)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImportSyncResolverBTEC"
        Me.Text = "BTEC Asmt Sync Resolver"
        CType(Me.olvOutcomes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnUseImport As Button
    Friend WithEvents btnUseExisting As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblImportImprovement As Label
    Friend WithEvents lblImportOverall As Label
    Friend WithEvents lblExistingImprovement As Label
    Friend WithEvents lblExistingOverall As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstStudentID As ListBox
    Friend WithEvents olvOutcomes As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumnOutcomeName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ObjectListView1 As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
