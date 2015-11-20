<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EitherOrAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EitherOrAttendance))
        Me.btnOK2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.olvActualSessions = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.txtClassName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.splitOverall = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn25 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.btnOK4 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.olvActualSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.Panel1.SuspendLayout()
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.Panel2.SuspendLayout()
        Me.splitOverall.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK2
        '
        Me.btnOK2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK2.Location = New System.Drawing.Point(526, 578)
        Me.btnOK2.Name = "btnOK2"
        Me.btnOK2.Size = New System.Drawing.Size(108, 25)
        Me.btnOK2.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.btnOK2, "Click this button if there is just 1 attendence for each session above (2 schedul" & _
        "ed sessions = 2 attendence records)")
        Me.btnOK2.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK2.Values.Text = "OK &2"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(344, 578)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 77
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Close"
        '
        'olvActualSessions
        '
        Me.olvActualSessions.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn5)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn6)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn3)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn4)
        Me.olvActualSessions.AllColumns.Add(Me.OlvColumn10)
        Me.olvActualSessions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvActualSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn10})
        Me.olvActualSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvActualSessions.FullRowSelect = True
        Me.olvActualSessions.Location = New System.Drawing.Point(0, 0)
        Me.olvActualSessions.Name = "olvActualSessions"
        Me.olvActualSessions.OwnerDraw = True
        Me.olvActualSessions.ShowGroups = False
        Me.olvActualSessions.ShowImagesOnSubItems = True
        Me.olvActualSessions.Size = New System.Drawing.Size(611, 501)
        Me.olvActualSessions.TabIndex = 79
        Me.olvActualSessions.UseAlternatingBackColors = True
        Me.olvActualSessions.UseCompatibleStateImageBehavior = False
        Me.olvActualSessions.UseFiltering = True
        Me.olvActualSessions.UseSubItemCheckBoxes = True
        Me.olvActualSessions.View = System.Windows.Forms.View.Details
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "SessionNumber"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.IsEditable = False
        Me.OlvColumn5.Text = "#"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "WeekNumber"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Week"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StartDateTime"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Start"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 147
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Topic"
        Me.OlvColumn4.IsEditable = False
        Me.OlvColumn4.Text = "Topic"
        Me.OlvColumn4.Width = 174
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "Notes"
        Me.OlvColumn10.Text = "Notes"
        Me.OlvColumn10.Width = 162
        '
        'txtClassName
        '
        Me.txtClassName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClassName.Location = New System.Drawing.Point(92, 12)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.ReadOnly = True
        Me.txtClassName.Size = New System.Drawing.Size(1002, 20)
        Me.txtClassName.TabIndex = 81
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel1.TabIndex = 80
        Me.KryptonLabel1.Values.Text = "Class name:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 49)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(721, 20)
        Me.KryptonLabel2.TabIndex = 82
        Me.KryptonLabel2.Values.Text = "Select 2 sessions and click OK. If a student was present in one and absent in the" & _
    " other, the other will be marked ""excused""."
        '
        'splitOverall
        '
        Me.splitOverall.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitOverall.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitOverall.Location = New System.Drawing.Point(1, 71)
        Me.splitOverall.Name = "splitOverall"
        '
        'splitOverall.Panel1
        '
        Me.splitOverall.Panel1.Controls.Add(Me.olvActualSessions)
        '
        'splitOverall.Panel2
        '
        Me.splitOverall.Panel2.Controls.Add(Me.olvStudents)
        Me.splitOverall.Size = New System.Drawing.Size(1104, 501)
        Me.splitOverall.SplitterDistance = 611
        Me.splitOverall.TabIndex = 83
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn25)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn2, Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn25})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "No students to display"
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 0)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.OwnerDraw = True
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowCommandMenuOnRightClick = True
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(488, 501)
        Me.olvStudents.TabIndex = 4
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Student.LocalName"
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.Text = "Name"
        Me.OlvColumn2.Width = 150
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "Student.Nickname"
        Me.OlvColumn7.IsEditable = False
        Me.OlvColumn7.Text = "Nickname"
        Me.OlvColumn7.Width = 108
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "Student.StudentID"
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.IsEditable = False
        Me.OlvColumn8.Text = "Student ID"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Width = 90
        '
        'OlvColumn25
        '
        Me.OlvColumn25.AspectName = "Results"
        Me.OlvColumn25.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn25.IsEditable = False
        Me.OlvColumn25.Text = "Results"
        Me.OlvColumn25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn25.Width = 122
        '
        'btnOK4
        '
        Me.btnOK4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK4.Location = New System.Drawing.Point(694, 578)
        Me.btnOK4.Name = "btnOK4"
        Me.btnOK4.Size = New System.Drawing.Size(108, 25)
        Me.btnOK4.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.btnOK4, "Click this button if there are 2 attendence for each session above (2 scheduled s" & _
        "essions = 4 attendence records)")
        Me.btnOK4.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK4.Values.Text = "OK &4"
        '
        'EitherOrAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 615)
        Me.Controls.Add(Me.btnOK4)
        Me.Controls.Add(Me.splitOverall)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.txtClassName)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.btnOK2)
        Me.Controls.Add(Me.btnCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EitherOrAttendance"
        Me.Text = "Either Or Attendance"
        CType(Me.olvActualSessions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.Panel1.ResumeLayout(False)
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.Panel2.ResumeLayout(False)
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.ResumeLayout(False)
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents olvActualSessions As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents txtClassName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents splitOverall As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn25 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents btnOK4 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
