<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsWithAssignment
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAssignmentCount = New System.Windows.Forms.Label()
        Me.lblStudentCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dcolLocalName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolNickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolExtStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolTags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstTry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecondTry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Overall = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Improvement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Creator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolStudentGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolStudentTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstAssignments = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBaseAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteSelectedAssignmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lstAssignments)
        Me.Panel1.Controls.Add(Me.lblStudentCount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblAssignmentCount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 526)
        Me.Panel1.TabIndex = 0
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AllowUserToOrderColumns = True
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dcolLocalName, Me.dcolNickname, Me.dcolStudentID, Me.dcolExtStudentID, Me.dcolTags, Me.FirstTry, Me.SecondTry, Me.Overall, Me.Improvement, Me.Creator, Me.Editor, Me.dcolStudentGroup, Me.dcolStudentTeam, Me.dcolClass})
        Me.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudents.Location = New System.Drawing.Point(217, 24)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(986, 526)
        Me.dgvStudents.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assignments:"
        '
        'lblAssignmentCount
        '
        Me.lblAssignmentCount.AutoSize = True
        Me.lblAssignmentCount.Location = New System.Drawing.Point(124, 10)
        Me.lblAssignmentCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAssignmentCount.Name = "lblAssignmentCount"
        Me.lblAssignmentCount.Size = New System.Drawing.Size(17, 18)
        Me.lblAssignmentCount.TabIndex = 1
        Me.lblAssignmentCount.Text = "0"
        '
        'lblStudentCount
        '
        Me.lblStudentCount.AutoSize = True
        Me.lblStudentCount.Location = New System.Drawing.Point(124, 39)
        Me.lblStudentCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentCount.Name = "lblStudentCount"
        Me.lblStudentCount.Size = New System.Drawing.Size(17, 18)
        Me.lblStudentCount.TabIndex = 3
        Me.lblStudentCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Students:"
        '
        'dcolLocalName
        '
        Me.dcolLocalName.DataPropertyName = "StudentName"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dcolLocalName.DefaultCellStyle = DataGridViewCellStyle25
        Me.dcolLocalName.HeaderText = "Name"
        Me.dcolLocalName.Name = "dcolLocalName"
        Me.dcolLocalName.ReadOnly = True
        '
        'dcolNickname
        '
        Me.dcolNickname.DataPropertyName = "StudentNickname"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dcolNickname.DefaultCellStyle = DataGridViewCellStyle26
        Me.dcolNickname.HeaderText = "Nickname"
        Me.dcolNickname.Name = "dcolNickname"
        Me.dcolNickname.ReadOnly = True
        '
        'dcolStudentID
        '
        Me.dcolStudentID.DataPropertyName = "StudentID"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolStudentID.DefaultCellStyle = DataGridViewCellStyle27
        Me.dcolStudentID.HeaderText = "StudentID"
        Me.dcolStudentID.Name = "dcolStudentID"
        Me.dcolStudentID.ReadOnly = True
        '
        'dcolExtStudentID
        '
        Me.dcolExtStudentID.DataPropertyName = "StudentExtStudentID"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolExtStudentID.DefaultCellStyle = DataGridViewCellStyle28
        Me.dcolExtStudentID.HeaderText = "ExtID"
        Me.dcolExtStudentID.Name = "dcolExtStudentID"
        Me.dcolExtStudentID.ReadOnly = True
        '
        'dcolTags
        '
        Me.dcolTags.DataPropertyName = "StudentTags"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dcolTags.DefaultCellStyle = DataGridViewCellStyle29
        Me.dcolTags.HeaderText = "Tags"
        Me.dcolTags.Name = "dcolTags"
        Me.dcolTags.ReadOnly = True
        '
        'FirstTry
        '
        Me.FirstTry.DataPropertyName = "FirstTry"
        Me.FirstTry.HeaderText = "1st"
        Me.FirstTry.Name = "FirstTry"
        Me.FirstTry.ReadOnly = True
        Me.FirstTry.Width = 45
        '
        'SecondTry
        '
        Me.SecondTry.DataPropertyName = "SecondTry"
        Me.SecondTry.HeaderText = "2nd"
        Me.SecondTry.Name = "SecondTry"
        Me.SecondTry.ReadOnly = True
        Me.SecondTry.Width = 45
        '
        'Overall
        '
        Me.Overall.DataPropertyName = "OverallComments"
        Me.Overall.HeaderText = "Overall"
        Me.Overall.Name = "Overall"
        Me.Overall.ReadOnly = True
        '
        'Improvement
        '
        Me.Improvement.DataPropertyName = "ImprovementComments"
        Me.Improvement.HeaderText = "Improvement"
        Me.Improvement.Name = "Improvement"
        Me.Improvement.ReadOnly = True
        '
        'Creator
        '
        Me.Creator.DataPropertyName = "FirstUsername"
        Me.Creator.HeaderText = "Creator"
        Me.Creator.Name = "Creator"
        Me.Creator.ReadOnly = True
        '
        'Editor
        '
        Me.Editor.DataPropertyName = "LastUsername"
        Me.Editor.HeaderText = "Editor"
        Me.Editor.Name = "Editor"
        Me.Editor.ReadOnly = True
        '
        'dcolStudentGroup
        '
        Me.dcolStudentGroup.DataPropertyName = "StudentGroup"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolStudentGroup.DefaultCellStyle = DataGridViewCellStyle30
        Me.dcolStudentGroup.HeaderText = "Group"
        Me.dcolStudentGroup.Name = "dcolStudentGroup"
        Me.dcolStudentGroup.ReadOnly = True
        '
        'dcolStudentTeam
        '
        Me.dcolStudentTeam.DataPropertyName = "StudentTeam"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolStudentTeam.DefaultCellStyle = DataGridViewCellStyle31
        Me.dcolStudentTeam.HeaderText = "Team"
        Me.dcolStudentTeam.Name = "dcolStudentTeam"
        Me.dcolStudentTeam.ReadOnly = True
        '
        'dcolClass
        '
        Me.dcolClass.DataPropertyName = "SchoolClassName"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolClass.DefaultCellStyle = DataGridViewCellStyle32
        Me.dcolClass.HeaderText = "Class"
        Me.dcolClass.Name = "dcolClass"
        Me.dcolClass.ReadOnly = True
        '
        'lstAssignments
        '
        Me.lstAssignments.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstAssignments.FormattingEnabled = True
        Me.lstAssignments.ItemHeight = 18
        Me.lstAssignments.Location = New System.Drawing.Point(0, 180)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.Size = New System.Drawing.Size(217, 346)
        Me.lstAssignments.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1203, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeBaseAssignmentToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteSelectedAssignmentsToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "&Action"
        '
        'ChangeBaseAssignmentToolStripMenuItem
        '
        Me.ChangeBaseAssignmentToolStripMenuItem.Name = "ChangeBaseAssignmentToolStripMenuItem"
        Me.ChangeBaseAssignmentToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ChangeBaseAssignmentToolStripMenuItem.Text = "&Change base assignment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'DeleteSelectedAssignmentsToolStripMenuItem
        '
        Me.DeleteSelectedAssignmentsToolStripMenuItem.Name = "DeleteSelectedAssignmentsToolStripMenuItem"
        Me.DeleteSelectedAssignmentsToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.DeleteSelectedAssignmentsToolStripMenuItem.Text = "&Delete selected assignment(s)"
        '
        'StudentsWithAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 550)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StudentsWithAssignment"
        Me.Text = "StudentsWithAssignment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents lblAssignmentCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStudentCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dcolLocalName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolNickname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolExtStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolTags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstTry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecondTry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Overall As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Improvement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Creator As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Editor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolStudentGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolStudentTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolClass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lstAssignments As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeBaseAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteSelectedAssignmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
