<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulkGenerateMarkingSheetsAllCombined
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAssessmentBriefFilename = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Try:"
        '
        'lblMarkingTry
        '
        Me.lblMarkingTry.AutoSize = True
        Me.lblMarkingTry.Location = New System.Drawing.Point(132, 197)
        Me.lblMarkingTry.Name = "lblMarkingTry"
        Me.lblMarkingTry.Size = New System.Drawing.Size(10, 13)
        Me.lblMarkingTry.TabIndex = 27
        Me.lblMarkingTry.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 349)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Skipped:"
        '
        'lblStudentsSkipped
        '
        Me.lblStudentsSkipped.AutoSize = True
        Me.lblStudentsSkipped.Location = New System.Drawing.Point(132, 349)
        Me.lblStudentsSkipped.Name = "lblStudentsSkipped"
        Me.lblStudentsSkipped.Size = New System.Drawing.Size(10, 13)
        Me.lblStudentsSkipped.TabIndex = 22
        Me.lblStudentsSkipped.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Generated:"
        '
        'lblStudentsGenerated
        '
        Me.lblStudentsGenerated.AutoSize = True
        Me.lblStudentsGenerated.Location = New System.Drawing.Point(132, 319)
        Me.lblStudentsGenerated.Name = "lblStudentsGenerated"
        Me.lblStudentsGenerated.Size = New System.Drawing.Size(10, 13)
        Me.lblStudentsGenerated.TabIndex = 21
        Me.lblStudentsGenerated.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Students:"
        '
        'lblNumberOfStudents
        '
        Me.lblNumberOfStudents.AutoSize = True
        Me.lblNumberOfStudents.Location = New System.Drawing.Point(132, 161)
        Me.lblNumberOfStudents.Name = "lblNumberOfStudents"
        Me.lblNumberOfStudents.Size = New System.Drawing.Size(10, 13)
        Me.lblNumberOfStudents.TabIndex = 23
        Me.lblNumberOfStudents.Text = " "
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(394, 255)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(135, 255)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(163, 23)
        Me.btnGenerate.TabIndex = 19
        Me.btnGenerate.Text = "&Generate Combined"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Assessment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Class:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Module:"
        '
        'lblAssessmentName
        '
        Me.lblAssessmentName.AutoSize = True
        Me.lblAssessmentName.Location = New System.Drawing.Point(132, 125)
        Me.lblAssessmentName.Name = "lblAssessmentName"
        Me.lblAssessmentName.Size = New System.Drawing.Size(10, 13)
        Me.lblAssessmentName.TabIndex = 14
        Me.lblAssessmentName.Text = " "
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Location = New System.Drawing.Point(132, 89)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(10, 13)
        Me.lblClassName.TabIndex = 13
        Me.lblClassName.Text = " "
        '
        'lblModuleName
        '
        Me.lblModuleName.AutoSize = True
        Me.lblModuleName.Location = New System.Drawing.Point(132, 53)
        Me.lblModuleName.Name = "lblModuleName"
        Me.lblModuleName.Size = New System.Drawing.Size(10, 13)
        Me.lblModuleName.TabIndex = 12
        Me.lblModuleName.Text = " "
        '
        'lblOutputPath
        '
        Me.lblOutputPath.AutoSize = True
        Me.lblOutputPath.Location = New System.Drawing.Point(132, 17)
        Me.lblOutputPath.Name = "lblOutputPath"
        Me.lblOutputPath.Size = New System.Drawing.Size(10, 13)
        Me.lblOutputPath.TabIndex = 15
        Me.lblOutputPath.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Output path:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(286, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Note: Hidden students will be ignored"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Assessment filename:"
        '
        'lblAssessmentBriefFilename
        '
        Me.lblAssessmentBriefFilename.AutoSize = True
        Me.lblAssessmentBriefFilename.Location = New System.Drawing.Point(172, 224)
        Me.lblAssessmentBriefFilename.Name = "lblAssessmentBriefFilename"
        Me.lblAssessmentBriefFilename.Size = New System.Drawing.Size(10, 13)
        Me.lblAssessmentBriefFilename.TabIndex = 39
        Me.lblAssessmentBriefFilename.Text = " "
        '
        'BulkGenerateMarkingSheetsAllCombined
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 375)
        Me.Controls.Add(Me.lblAssessmentBriefFilename)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
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
        Me.Name = "BulkGenerateMarkingSheetsAllCombined"
        Me.Text = "Bulk Generate Marking Sheets All Combined"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents lblMarkingTry As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblStudentsSkipped As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStudentsGenerated As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumberOfStudents As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAssessmentName As Label
    Friend WithEvents lblClassName As Label
    Friend WithEvents lblModuleName As Label
    Friend WithEvents lblOutputPath As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblAssessmentBriefFilename As Label
End Class
