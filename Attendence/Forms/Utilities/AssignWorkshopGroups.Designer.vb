<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignWorkshopGroups
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
        Me.nudNumberOfWorkshops = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudNumberOfGroupsPerWorkshop = New System.Windows.Forms.NumericUpDown()
        Me.chkAssignPeerEval = New System.Windows.Forms.CheckBox()
        Me.chkReassignStudentGroup = New System.Windows.Forms.CheckBox()
        Me.nudNumberOfStudentGroups = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExportFile = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.nudNumberOfWorkshops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfGroupsPerWorkshop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfStudentGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudNumberOfWorkshops
        '
        Me.nudNumberOfWorkshops.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudNumberOfWorkshops.Location = New System.Drawing.Point(223, 115)
        Me.nudNumberOfWorkshops.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudNumberOfWorkshops.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfWorkshops.Name = "nudNumberOfWorkshops"
        Me.nudNumberOfWorkshops.Size = New System.Drawing.Size(68, 22)
        Me.nudNumberOfWorkshops.TabIndex = 0
        Me.nudNumberOfWorkshops.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNumberOfWorkshops.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of workshops:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Workshops per day:"
        '
        'nudNumberOfGroupsPerWorkshop
        '
        Me.nudNumberOfGroupsPerWorkshop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudNumberOfGroupsPerWorkshop.Location = New System.Drawing.Point(223, 145)
        Me.nudNumberOfGroupsPerWorkshop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudNumberOfGroupsPerWorkshop.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfGroupsPerWorkshop.Name = "nudNumberOfGroupsPerWorkshop"
        Me.nudNumberOfGroupsPerWorkshop.Size = New System.Drawing.Size(68, 22)
        Me.nudNumberOfGroupsPerWorkshop.TabIndex = 2
        Me.nudNumberOfGroupsPerWorkshop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNumberOfGroupsPerWorkshop.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'chkAssignPeerEval
        '
        Me.chkAssignPeerEval.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAssignPeerEval.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAssignPeerEval.Location = New System.Drawing.Point(51, 175)
        Me.chkAssignPeerEval.Name = "chkAssignPeerEval"
        Me.chkAssignPeerEval.Size = New System.Drawing.Size(237, 25)
        Me.chkAssignPeerEval.TabIndex = 4
        Me.chkAssignPeerEval.Text = "Assign peer eval:"
        Me.chkAssignPeerEval.UseVisualStyleBackColor = True
        '
        'chkReassignStudentGroup
        '
        Me.chkReassignStudentGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkReassignStudentGroup.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkReassignStudentGroup.Location = New System.Drawing.Point(51, 206)
        Me.chkReassignStudentGroup.Name = "chkReassignStudentGroup"
        Me.chkReassignStudentGroup.Size = New System.Drawing.Size(237, 25)
        Me.chkReassignStudentGroup.TabIndex = 5
        Me.chkReassignStudentGroup.Text = "Re-assign student groups:"
        Me.chkReassignStudentGroup.UseVisualStyleBackColor = True
        '
        'nudNumberOfStudentGroups
        '
        Me.nudNumberOfStudentGroups.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudNumberOfStudentGroups.Enabled = False
        Me.nudNumberOfStudentGroups.Location = New System.Drawing.Point(223, 241)
        Me.nudNumberOfStudentGroups.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudNumberOfStudentGroups.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudNumberOfStudentGroups.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfStudentGroups.Name = "nudNumberOfStudentGroups"
        Me.nudNumberOfStudentGroups.Size = New System.Drawing.Size(68, 22)
        Me.nudNumberOfStudentGroups.TabIndex = 6
        Me.nudNumberOfStudentGroups.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNumberOfStudentGroups.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Student groups:"
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStart.Location = New System.Drawing.Point(50, 284)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(106, 32)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExportFile
        '
        Me.btnExportFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExportFile.Enabled = False
        Me.btnExportFile.Location = New System.Drawing.Point(187, 284)
        Me.btnExportFile.Name = "btnExportFile"
        Me.btnExportFile.Size = New System.Drawing.Size(106, 32)
        Me.btnExportFile.TabIndex = 9
        Me.btnExportFile.Text = "&Export file"
        Me.btnExportFile.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(13, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 73)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "2 student groups in 6 workshops with 12 WS per day means each day there are 12 wo" & _
    "rkshop sessions but only 50% of all students are in that day, and there are 12 d" & _
    "ays like this."
        '
        'AssignWorkshopGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 328)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExportFile)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudNumberOfStudentGroups)
        Me.Controls.Add(Me.chkReassignStudentGroup)
        Me.Controls.Add(Me.chkAssignPeerEval)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudNumberOfGroupsPerWorkshop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudNumberOfWorkshops)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AssignWorkshopGroups"
        Me.Text = "Assign Workshop Groups"
        CType(Me.nudNumberOfWorkshops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfGroupsPerWorkshop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfStudentGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudNumberOfWorkshops As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudNumberOfGroupsPerWorkshop As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkAssignPeerEval As System.Windows.Forms.CheckBox
    Friend WithEvents chkReassignStudentGroup As System.Windows.Forms.CheckBox
    Friend WithEvents nudNumberOfStudentGroups As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExportFile As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
