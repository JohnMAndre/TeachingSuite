<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceFromAssignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceFromAssignment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAssignments = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboNegativeStatus = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPositiveStatus = New System.Windows.Forms.ComboBox()
        Me.dtpSessionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNormalAssignmentScoreCaption = New System.Windows.Forms.Label()
        Me.nudNormalAssignmentScore = New System.Windows.Forms.NumericUpDown()
        Me.lblNormalAssignmentMaxScore = New System.Windows.Forms.Label()
        Me.pnlNormalAssignment = New System.Windows.Forms.Panel()
        Me.pnlBTECAssignment = New System.Windows.Forms.Panel()
        Me.cboLearningOutcome = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.llblToday = New System.Windows.Forms.LinkLabel()
        CType(Me.nudNormalAssignmentScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNormalAssignment.SuspendLayout()
        Me.pnlBTECAssignment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(735, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "All students with assignment: "
        '
        'cboAssignments
        '
        Me.cboAssignments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAssignments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssignments.FormattingEnabled = True
        Me.cboAssignments.Location = New System.Drawing.Point(241, 109)
        Me.cboAssignments.Name = "cboAssignments"
        Me.cboAssignments.Size = New System.Drawing.Size(516, 26)
        Me.cboAssignments.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "All others marked:"
        '
        'cboNegativeStatus
        '
        Me.cboNegativeStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNegativeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNegativeStatus.FormattingEnabled = True
        Me.cboNegativeStatus.Location = New System.Drawing.Point(293, 232)
        Me.cboNegativeStatus.Name = "cboNegativeStatus"
        Me.cboNegativeStatus.Size = New System.Drawing.Size(464, 26)
        Me.cboNegativeStatus.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(413, 370)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(272, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(12, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(746, 45)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "You should consider saving your database before clicking OK. Then if you make a m" & _
    "istake, you can Quit Without Saving if necessary."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "should be marked:"
        '
        'cboPositiveStatus
        '
        Me.cboPositiveStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPositiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPositiveStatus.FormattingEnabled = True
        Me.cboPositiveStatus.Location = New System.Drawing.Point(293, 187)
        Me.cboPositiveStatus.Name = "cboPositiveStatus"
        Me.cboPositiveStatus.Size = New System.Drawing.Size(464, 26)
        Me.cboPositiveStatus.TabIndex = 7
        '
        'dtpSessionDate
        '
        Me.dtpSessionDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSessionDate.Location = New System.Drawing.Point(293, 265)
        Me.dtpSessionDate.Name = "dtpSessionDate"
        Me.dtpSessionDate.Size = New System.Drawing.Size(409, 26)
        Me.dtpSessionDate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "New attendance records on:"
        '
        'lblNormalAssignmentScoreCaption
        '
        Me.lblNormalAssignmentScoreCaption.AutoSize = True
        Me.lblNormalAssignmentScoreCaption.Location = New System.Drawing.Point(4, 8)
        Me.lblNormalAssignmentScoreCaption.Name = "lblNormalAssignmentScoreCaption"
        Me.lblNormalAssignmentScoreCaption.Size = New System.Drawing.Size(188, 18)
        Me.lblNormalAssignmentScoreCaption.TabIndex = 11
        Me.lblNormalAssignmentScoreCaption.Text = "with first try points at least:"
        '
        'nudNormalAssignmentScore
        '
        Me.nudNormalAssignmentScore.Location = New System.Drawing.Point(270, 6)
        Me.nudNormalAssignmentScore.Name = "nudNormalAssignmentScore"
        Me.nudNormalAssignmentScore.Size = New System.Drawing.Size(104, 26)
        Me.nudNormalAssignmentScore.TabIndex = 12
        Me.nudNormalAssignmentScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNormalAssignmentMaxScore
        '
        Me.lblNormalAssignmentMaxScore.AutoSize = True
        Me.lblNormalAssignmentMaxScore.Location = New System.Drawing.Point(380, 8)
        Me.lblNormalAssignmentMaxScore.Name = "lblNormalAssignmentMaxScore"
        Me.lblNormalAssignmentMaxScore.Size = New System.Drawing.Size(107, 18)
        Me.lblNormalAssignmentMaxScore.TabIndex = 13
        Me.lblNormalAssignmentMaxScore.Text = "(max score: 0)"
        '
        'pnlNormalAssignment
        '
        Me.pnlNormalAssignment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNormalAssignment.Controls.Add(Me.lblNormalAssignmentScoreCaption)
        Me.pnlNormalAssignment.Controls.Add(Me.lblNormalAssignmentMaxScore)
        Me.pnlNormalAssignment.Controls.Add(Me.nudNormalAssignmentScore)
        Me.pnlNormalAssignment.Location = New System.Drawing.Point(25, 141)
        Me.pnlNormalAssignment.Name = "pnlNormalAssignment"
        Me.pnlNormalAssignment.Size = New System.Drawing.Size(733, 39)
        Me.pnlNormalAssignment.TabIndex = 14
        Me.pnlNormalAssignment.Visible = False
        '
        'pnlBTECAssignment
        '
        Me.pnlBTECAssignment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBTECAssignment.Controls.Add(Me.cboLearningOutcome)
        Me.pnlBTECAssignment.Controls.Add(Me.Label7)
        Me.pnlBTECAssignment.Location = New System.Drawing.Point(25, 141)
        Me.pnlBTECAssignment.Name = "pnlBTECAssignment"
        Me.pnlBTECAssignment.Size = New System.Drawing.Size(732, 39)
        Me.pnlBTECAssignment.TabIndex = 15
        Me.pnlBTECAssignment.Visible = False
        '
        'cboLearningOutcome
        '
        Me.cboLearningOutcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLearningOutcome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLearningOutcome.FormattingEnabled = True
        Me.cboLearningOutcome.Location = New System.Drawing.Point(268, 4)
        Me.cboLearningOutcome.Name = "cboLearningOutcome"
        Me.cboLearningOutcome.Size = New System.Drawing.Size(458, 26)
        Me.cboLearningOutcome.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "achieving learning outcome:"
        '
        'llblToday
        '
        Me.llblToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblToday.AutoSize = True
        Me.llblToday.Location = New System.Drawing.Point(708, 268)
        Me.llblToday.Name = "llblToday"
        Me.llblToday.Size = New System.Drawing.Size(49, 18)
        Me.llblToday.TabIndex = 16
        Me.llblToday.TabStop = True
        Me.llblToday.Text = "Today"
        '
        'AttendanceFromAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(770, 414)
        Me.Controls.Add(Me.llblToday)
        Me.Controls.Add(Me.pnlBTECAssignment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpSessionDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboPositiveStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboNegativeStatus)
        Me.Controls.Add(Me.cboAssignments)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlNormalAssignment)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AttendanceFromAssignment"
        Me.Text = "Attendance from assignment"
        CType(Me.nudNormalAssignmentScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNormalAssignment.ResumeLayout(False)
        Me.pnlNormalAssignment.PerformLayout()
        Me.pnlBTECAssignment.ResumeLayout(False)
        Me.pnlBTECAssignment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAssignments As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboNegativeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPositiveStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpSessionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNormalAssignmentScoreCaption As System.Windows.Forms.Label
    Friend WithEvents nudNormalAssignmentScore As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNormalAssignmentMaxScore As System.Windows.Forms.Label
    Friend WithEvents pnlNormalAssignment As System.Windows.Forms.Panel
    Friend WithEvents pnlBTECAssignment As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboLearningOutcome As System.Windows.Forms.ComboBox
    Friend WithEvents llblToday As System.Windows.Forms.LinkLabel
End Class
