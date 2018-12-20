<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulkGenerateMarkingSheets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BulkGenerateMarkingSheets))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutputPath = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblModuleName = New System.Windows.Forms.Label()
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lblAssessmentName = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumberOfStudents = New System.Windows.Forms.Label()
        Me.lblStudentsGenerated = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStudentsSkipped = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMarkingTry = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Output path:"
        '
        'lblOutputPath
        '
        Me.lblOutputPath.AutoSize = True
        Me.lblOutputPath.Location = New System.Drawing.Point(101, 16)
        Me.lblOutputPath.Name = "lblOutputPath"
        Me.lblOutputPath.Size = New System.Drawing.Size(12, 16)
        Me.lblOutputPath.TabIndex = 1
        Me.lblOutputPath.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Module:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Assessment:"
        '
        'lblModuleName
        '
        Me.lblModuleName.AutoSize = True
        Me.lblModuleName.Location = New System.Drawing.Point(101, 52)
        Me.lblModuleName.Name = "lblModuleName"
        Me.lblModuleName.Size = New System.Drawing.Size(12, 16)
        Me.lblModuleName.TabIndex = 1
        Me.lblModuleName.Text = " "
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Location = New System.Drawing.Point(101, 88)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(12, 16)
        Me.lblClassName.TabIndex = 1
        Me.lblClassName.Text = " "
        '
        'lblAssessmentName
        '
        Me.lblAssessmentName.AutoSize = True
        Me.lblAssessmentName.Location = New System.Drawing.Point(101, 124)
        Me.lblAssessmentName.Name = "lblAssessmentName"
        Me.lblAssessmentName.Size = New System.Drawing.Size(12, 16)
        Me.lblAssessmentName.TabIndex = 1
        Me.lblAssessmentName.Text = " "
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(104, 232)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(163, 23)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate &BTEC"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(363, 232)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Students:"
        '
        'lblNumberOfStudents
        '
        Me.lblNumberOfStudents.AutoSize = True
        Me.lblNumberOfStudents.Location = New System.Drawing.Point(101, 160)
        Me.lblNumberOfStudents.Name = "lblNumberOfStudents"
        Me.lblNumberOfStudents.Size = New System.Drawing.Size(12, 16)
        Me.lblNumberOfStudents.TabIndex = 7
        Me.lblNumberOfStudents.Text = " "
        '
        'lblStudentsGenerated
        '
        Me.lblStudentsGenerated.AutoSize = True
        Me.lblStudentsGenerated.Location = New System.Drawing.Point(101, 273)
        Me.lblStudentsGenerated.Name = "lblStudentsGenerated"
        Me.lblStudentsGenerated.Size = New System.Drawing.Size(12, 16)
        Me.lblStudentsGenerated.TabIndex = 7
        Me.lblStudentsGenerated.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Generated:"
        '
        'lblStudentsSkipped
        '
        Me.lblStudentsSkipped.AutoSize = True
        Me.lblStudentsSkipped.Location = New System.Drawing.Point(101, 303)
        Me.lblStudentsSkipped.Name = "lblStudentsSkipped"
        Me.lblStudentsSkipped.Size = New System.Drawing.Size(12, 16)
        Me.lblStudentsSkipped.TabIndex = 7
        Me.lblStudentsSkipped.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Skipped:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Try:"
        '
        'lblMarkingTry
        '
        Me.lblMarkingTry.AutoSize = True
        Me.lblMarkingTry.Location = New System.Drawing.Point(101, 196)
        Me.lblMarkingTry.Name = "lblMarkingTry"
        Me.lblMarkingTry.Size = New System.Drawing.Size(12, 16)
        Me.lblMarkingTry.TabIndex = 9
        Me.lblMarkingTry.Text = " "
        '
        'BulkGenerateMarkingSheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 335)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BulkGenerateMarkingSheets"
        Me.Text = "Bulk Generate Marking Sheets (BTEC)"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOutputPath As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblModuleName As System.Windows.Forms.Label
    Friend WithEvents lblClassName As System.Windows.Forms.Label
    Friend WithEvents lblAssessmentName As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfStudents As System.Windows.Forms.Label
    Friend WithEvents lblStudentsGenerated As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblStudentsSkipped As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMarkingTry As System.Windows.Forms.Label
End Class
