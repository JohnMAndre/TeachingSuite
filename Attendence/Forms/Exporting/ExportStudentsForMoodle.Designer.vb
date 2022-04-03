<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportStudentsForMoodle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportStudentsForMoodle))
        Me.btnExport = New System.Windows.Forms.Button()
        Me.chkFirstNameFirst = New System.Windows.Forms.CheckBox()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.txtRoleName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoGroupUseNothing = New System.Windows.Forms.RadioButton()
        Me.rdoGroupUseTeam = New System.Windows.Forms.RadioButton()
        Me.rdoGroupUseGroup = New System.Windows.Forms.RadioButton()
        Me.txtGroupPrefix = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblExportCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(187, 265)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(91, 40)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'chkFirstNameFirst
        '
        Me.chkFirstNameFirst.AutoSize = True
        Me.chkFirstNameFirst.Location = New System.Drawing.Point(39, 31)
        Me.chkFirstNameFirst.Name = "chkFirstNameFirst"
        Me.chkFirstNameFirst.Size = New System.Drawing.Size(276, 20)
        Me.chkFirstNameFirst.TabIndex = 1
        Me.chkFirstNameFirst.Text = "&First name is first word of full student name"
        Me.chkFirstNameFirst.UseVisualStyleBackColor = True
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(168, 57)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(153, 22)
        Me.txtCourseID.TabIndex = 2
        '
        'txtRoleName
        '
        Me.txtRoleName.Location = New System.Drawing.Point(168, 85)
        Me.txtRoleName.Name = "txtRoleName"
        Me.txtRoleName.Size = New System.Drawing.Size(153, 22)
        Me.txtRoleName.TabIndex = 3
        Me.txtRoleName.Text = "student"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " Course short name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Student role name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoGroupUseGroup)
        Me.GroupBox1.Controls.Add(Me.rdoGroupUseTeam)
        Me.GroupBox1.Controls.Add(Me.rdoGroupUseNothing)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Group"
        '
        'rdoGroupUseNothing
        '
        Me.rdoGroupUseNothing.AutoSize = True
        Me.rdoGroupUseNothing.Checked = True
        Me.rdoGroupUseNothing.Location = New System.Drawing.Point(32, 22)
        Me.rdoGroupUseNothing.Name = "rdoGroupUseNothing"
        Me.rdoGroupUseNothing.Size = New System.Drawing.Size(85, 20)
        Me.rdoGroupUseNothing.TabIndex = 0
        Me.rdoGroupUseNothing.TabStop = True
        Me.rdoGroupUseNothing.Text = "No groups"
        Me.rdoGroupUseNothing.UseVisualStyleBackColor = True
        '
        'rdoGroupUseTeam
        '
        Me.rdoGroupUseTeam.AutoSize = True
        Me.rdoGroupUseTeam.Location = New System.Drawing.Point(30, 48)
        Me.rdoGroupUseTeam.Name = "rdoGroupUseTeam"
        Me.rdoGroupUseTeam.Size = New System.Drawing.Size(84, 20)
        Me.rdoGroupUseTeam.TabIndex = 0
        Me.rdoGroupUseTeam.Text = "Use Team"
        Me.rdoGroupUseTeam.UseVisualStyleBackColor = True
        '
        'rdoGroupUseGroup
        '
        Me.rdoGroupUseGroup.AutoSize = True
        Me.rdoGroupUseGroup.Location = New System.Drawing.Point(30, 74)
        Me.rdoGroupUseGroup.Name = "rdoGroupUseGroup"
        Me.rdoGroupUseGroup.Size = New System.Drawing.Size(88, 20)
        Me.rdoGroupUseGroup.TabIndex = 0
        Me.rdoGroupUseGroup.Text = "Use Group"
        Me.rdoGroupUseGroup.UseVisualStyleBackColor = True
        '
        'txtGroupPrefix
        '
        Me.txtGroupPrefix.Location = New System.Drawing.Point(187, 219)
        Me.txtGroupPrefix.Name = "txtGroupPrefix"
        Me.txtGroupPrefix.Size = New System.Drawing.Size(134, 22)
        Me.txtGroupPrefix.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Add prefix before group:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(74, 265)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblExportCount
        '
        Me.lblExportCount.AutoSize = True
        Me.lblExportCount.Location = New System.Drawing.Point(189, 244)
        Me.lblExportCount.Name = "lblExportCount"
        Me.lblExportCount.Size = New System.Drawing.Size(15, 16)
        Me.lblExportCount.TabIndex = 7
        Me.lblExportCount.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Exported:"
        '
        'ExportStudentsForMoodle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(348, 323)
        Me.Controls.Add(Me.lblExportCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtRoleName)
        Me.Controls.Add(Me.txtGroupPrefix)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFirstNameFirst)
        Me.Controls.Add(Me.btnExport)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExportStudentsForMoodle"
        Me.Text = "Export Students for Moodle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExport As Button
    Friend WithEvents chkFirstNameFirst As CheckBox
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents txtRoleName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoGroupUseGroup As RadioButton
    Friend WithEvents rdoGroupUseTeam As RadioButton
    Friend WithEvents rdoGroupUseNothing As RadioButton
    Friend WithEvents txtGroupPrefix As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblExportCount As Label
    Friend WithEvents Label5 As Label
End Class
