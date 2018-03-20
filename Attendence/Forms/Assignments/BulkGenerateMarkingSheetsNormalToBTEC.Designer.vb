<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulkGenerateMarkingSheetsNormalToBTEC
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMarkingTry = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStudentsSkipped = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStudentsGenerated = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumberOfStudents = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAssessmentName = New System.Windows.Forms.Label()
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lblModuleName = New System.Windows.Forms.Label()
        Me.lblOutputPath = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMinScorePass = New System.Windows.Forms.TextBox()
        Me.lblMinPass = New System.Windows.Forms.Label()
        Me.txtMinScoreMerit = New System.Windows.Forms.TextBox()
        Me.lblMinMerit = New System.Windows.Forms.Label()
        Me.txtMinScoreDistinction = New System.Windows.Forms.TextBox()
        Me.lblMinDistinction = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnAutoProcessOutcomes = New System.Windows.Forms.RadioButton()
        Me.rbtnManualProcessOutcomes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Try:"
        '
        'lblMarkingTry
        '
        Me.lblMarkingTry.AutoSize = True
        Me.lblMarkingTry.Location = New System.Drawing.Point(99, 193)
        Me.lblMarkingTry.Name = "lblMarkingTry"
        Me.lblMarkingTry.Size = New System.Drawing.Size(12, 16)
        Me.lblMarkingTry.TabIndex = 27
        Me.lblMarkingTry.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Skipped:"
        '
        'lblStudentsSkipped
        '
        Me.lblStudentsSkipped.AutoSize = True
        Me.lblStudentsSkipped.Location = New System.Drawing.Point(99, 300)
        Me.lblStudentsSkipped.Name = "lblStudentsSkipped"
        Me.lblStudentsSkipped.Size = New System.Drawing.Size(12, 16)
        Me.lblStudentsSkipped.TabIndex = 22
        Me.lblStudentsSkipped.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Generated:"
        '
        'lblStudentsGenerated
        '
        Me.lblStudentsGenerated.AutoSize = True
        Me.lblStudentsGenerated.Location = New System.Drawing.Point(99, 270)
        Me.lblStudentsGenerated.Name = "lblStudentsGenerated"
        Me.lblStudentsGenerated.Size = New System.Drawing.Size(12, 16)
        Me.lblStudentsGenerated.TabIndex = 21
        Me.lblStudentsGenerated.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Students:"
        '
        'lblNumberOfStudents
        '
        Me.lblNumberOfStudents.AutoSize = True
        Me.lblNumberOfStudents.Location = New System.Drawing.Point(99, 157)
        Me.lblNumberOfStudents.Name = "lblNumberOfStudents"
        Me.lblNumberOfStudents.Size = New System.Drawing.Size(12, 16)
        Me.lblNumberOfStudents.TabIndex = 23
        Me.lblNumberOfStudents.Text = " "
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(294, 229)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(152, 229)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 19
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Assessment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Class:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Module:"
        '
        'lblAssessmentName
        '
        Me.lblAssessmentName.AutoSize = True
        Me.lblAssessmentName.Location = New System.Drawing.Point(99, 121)
        Me.lblAssessmentName.Name = "lblAssessmentName"
        Me.lblAssessmentName.Size = New System.Drawing.Size(147, 16)
        Me.lblAssessmentName.TabIndex = 14
        Me.lblAssessmentName.Text = "Convert normal to BTEC"
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Location = New System.Drawing.Point(99, 85)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(12, 16)
        Me.lblClassName.TabIndex = 13
        Me.lblClassName.Text = " "
        '
        'lblModuleName
        '
        Me.lblModuleName.AutoSize = True
        Me.lblModuleName.Location = New System.Drawing.Point(99, 49)
        Me.lblModuleName.Name = "lblModuleName"
        Me.lblModuleName.Size = New System.Drawing.Size(12, 16)
        Me.lblModuleName.TabIndex = 12
        Me.lblModuleName.Text = " "
        '
        'lblOutputPath
        '
        Me.lblOutputPath.AutoSize = True
        Me.lblOutputPath.Location = New System.Drawing.Point(99, 13)
        Me.lblOutputPath.Name = "lblOutputPath"
        Me.lblOutputPath.Size = New System.Drawing.Size(12, 16)
        Me.lblOutputPath.TabIndex = 15
        Me.lblOutputPath.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Output path:"
        '
        'txtMinScorePass
        '
        Me.txtMinScorePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinScorePass.Location = New System.Drawing.Point(151, 82)
        Me.txtMinScorePass.Name = "txtMinScorePass"
        Me.txtMinScorePass.Size = New System.Drawing.Size(71, 22)
        Me.txtMinScorePass.TabIndex = 29
        Me.txtMinScorePass.Text = "45"
        Me.txtMinScorePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMinPass
        '
        Me.lblMinPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinPass.AutoSize = True
        Me.lblMinPass.Location = New System.Drawing.Point(46, 85)
        Me.lblMinPass.Name = "lblMinPass"
        Me.lblMinPass.Size = New System.Drawing.Size(67, 16)
        Me.lblMinPass.TabIndex = 30
        Me.lblMinPass.Text = "Min Pass:"
        '
        'txtMinScoreMerit
        '
        Me.txtMinScoreMerit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinScoreMerit.Location = New System.Drawing.Point(151, 110)
        Me.txtMinScoreMerit.Name = "txtMinScoreMerit"
        Me.txtMinScoreMerit.Size = New System.Drawing.Size(71, 22)
        Me.txtMinScoreMerit.TabIndex = 31
        Me.txtMinScoreMerit.Text = "55"
        Me.txtMinScoreMerit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMinMerit
        '
        Me.lblMinMerit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinMerit.AutoSize = True
        Me.lblMinMerit.Location = New System.Drawing.Point(46, 113)
        Me.lblMinMerit.Name = "lblMinMerit"
        Me.lblMinMerit.Size = New System.Drawing.Size(66, 16)
        Me.lblMinMerit.TabIndex = 32
        Me.lblMinMerit.Text = "Min Merit:"
        '
        'txtMinScoreDistinction
        '
        Me.txtMinScoreDistinction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinScoreDistinction.Location = New System.Drawing.Point(151, 138)
        Me.txtMinScoreDistinction.Name = "txtMinScoreDistinction"
        Me.txtMinScoreDistinction.Size = New System.Drawing.Size(71, 22)
        Me.txtMinScoreDistinction.TabIndex = 33
        Me.txtMinScoreDistinction.Text = "64"
        Me.txtMinScoreDistinction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMinDistinction
        '
        Me.lblMinDistinction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinDistinction.AutoSize = True
        Me.lblMinDistinction.Location = New System.Drawing.Point(46, 141)
        Me.lblMinDistinction.Name = "lblMinDistinction"
        Me.lblMinDistinction.Size = New System.Drawing.Size(98, 16)
        Me.lblMinDistinction.TabIndex = 34
        Me.lblMinDistinction.Text = "Min Distinction:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnAutoProcessOutcomes)
        Me.GroupBox1.Controls.Add(Me.rbtnManualProcessOutcomes)
        Me.GroupBox1.Controls.Add(Me.txtMinScorePass)
        Me.GroupBox1.Controls.Add(Me.txtMinScoreDistinction)
        Me.GroupBox1.Controls.Add(Me.lblMinPass)
        Me.GroupBox1.Controls.Add(Me.lblMinDistinction)
        Me.GroupBox1.Controls.Add(Me.lblMinMerit)
        Me.GroupBox1.Controls.Add(Me.txtMinScoreMerit)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 179)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outcome processing"
        '
        'rbtnAutoProcessOutcomes
        '
        Me.rbtnAutoProcessOutcomes.AutoSize = True
        Me.rbtnAutoProcessOutcomes.Checked = True
        Me.rbtnAutoProcessOutcomes.Location = New System.Drawing.Point(6, 55)
        Me.rbtnAutoProcessOutcomes.Name = "rbtnAutoProcessOutcomes"
        Me.rbtnAutoProcessOutcomes.Size = New System.Drawing.Size(164, 20)
        Me.rbtnAutoProcessOutcomes.TabIndex = 36
        Me.rbtnAutoProcessOutcomes.TabStop = True
        Me.rbtnAutoProcessOutcomes.Text = "Auto-process based on:"
        Me.rbtnAutoProcessOutcomes.UseVisualStyleBackColor = True
        '
        'rbtnManualProcessOutcomes
        '
        Me.rbtnManualProcessOutcomes.AutoSize = True
        Me.rbtnManualProcessOutcomes.Location = New System.Drawing.Point(7, 22)
        Me.rbtnManualProcessOutcomes.Name = "rbtnManualProcessOutcomes"
        Me.rbtnManualProcessOutcomes.Size = New System.Drawing.Size(185, 20)
        Me.rbtnManualProcessOutcomes.TabIndex = 35
        Me.rbtnManualProcessOutcomes.Text = "Manually process each one"
        Me.rbtnManualProcessOutcomes.UseVisualStyleBackColor = True
        '
        'BulkGenerateMarkingSheetsNormalToBTEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMarkingTry)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblStudentsSkipped)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblStudentsGenerated)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNumberOfStudents)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAssessmentName)
        Me.Controls.Add(Me.lblClassName)
        Me.Controls.Add(Me.lblModuleName)
        Me.Controls.Add(Me.lblOutputPath)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BulkGenerateMarkingSheetsNormalToBTEC"
        Me.Text = "Bulk Generate Marking Sheets  (normal to BTEC)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMarkingTry As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblStudentsSkipped As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblStudentsGenerated As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfStudents As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAssessmentName As System.Windows.Forms.Label
    Friend WithEvents lblClassName As System.Windows.Forms.Label
    Friend WithEvents lblModuleName As System.Windows.Forms.Label
    Friend WithEvents lblOutputPath As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMinScorePass As System.Windows.Forms.TextBox
    Friend WithEvents lblMinPass As System.Windows.Forms.Label
    Friend WithEvents txtMinScoreMerit As System.Windows.Forms.TextBox
    Friend WithEvents lblMinMerit As System.Windows.Forms.Label
    Friend WithEvents txtMinScoreDistinction As System.Windows.Forms.TextBox
    Friend WithEvents lblMinDistinction As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAutoProcessOutcomes As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnManualProcessOutcomes As System.Windows.Forms.RadioButton
End Class
