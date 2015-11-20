<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemesterStatistics
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
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalSessionCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAssessmentCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblClassCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblModuleCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSemesterName = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(103, 193)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 58
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel3.TabIndex = 57
        Me.KryptonLabel3.Values.Text = "Name:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 38)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel1.TabIndex = 59
        Me.KryptonLabel1.Values.Text = "Total modules:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 64)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel2.TabIndex = 60
        Me.KryptonLabel2.Values.Text = "Total classes:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 90)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(111, 20)
        Me.KryptonLabel4.TabIndex = 61
        Me.KryptonLabel4.Values.Text = "Total assessments:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 116)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel5.TabIndex = 62
        Me.KryptonLabel5.Values.Text = "Total students:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 142)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(118, 20)
        Me.KryptonLabel6.TabIndex = 63
        Me.KryptonLabel6.Values.Text = "Scheduled sessions:"
        '
        'lblTotalSessionCount
        '
        Me.lblTotalSessionCount.Location = New System.Drawing.Point(136, 142)
        Me.lblTotalSessionCount.Name = "lblTotalSessionCount"
        Me.lblTotalSessionCount.Size = New System.Drawing.Size(118, 20)
        Me.lblTotalSessionCount.TabIndex = 70
        Me.lblTotalSessionCount.Values.Text = "Scheduled sessions:"
        '
        'lblStudentCount
        '
        Me.lblStudentCount.Location = New System.Drawing.Point(136, 116)
        Me.lblStudentCount.Name = "lblStudentCount"
        Me.lblStudentCount.Size = New System.Drawing.Size(90, 20)
        Me.lblStudentCount.TabIndex = 69
        Me.lblStudentCount.Values.Text = "Total students:"
        '
        'lblAssessmentCount
        '
        Me.lblAssessmentCount.Location = New System.Drawing.Point(136, 90)
        Me.lblAssessmentCount.Name = "lblAssessmentCount"
        Me.lblAssessmentCount.Size = New System.Drawing.Size(111, 20)
        Me.lblAssessmentCount.TabIndex = 68
        Me.lblAssessmentCount.Values.Text = "Total assessments:"
        '
        'lblClassCount
        '
        Me.lblClassCount.Location = New System.Drawing.Point(136, 64)
        Me.lblClassCount.Name = "lblClassCount"
        Me.lblClassCount.Size = New System.Drawing.Size(81, 20)
        Me.lblClassCount.TabIndex = 67
        Me.lblClassCount.Values.Text = "Total classes:"
        '
        'lblModuleCount
        '
        Me.lblModuleCount.Location = New System.Drawing.Point(136, 38)
        Me.lblModuleCount.Name = "lblModuleCount"
        Me.lblModuleCount.Size = New System.Drawing.Size(91, 20)
        Me.lblModuleCount.TabIndex = 66
        Me.lblModuleCount.Values.Text = "Total modules:"
        '
        'lblSemesterName
        '
        Me.lblSemesterName.Location = New System.Drawing.Point(136, 12)
        Me.lblSemesterName.Name = "lblSemesterName"
        Me.lblSemesterName.Size = New System.Drawing.Size(46, 20)
        Me.lblSemesterName.TabIndex = 65
        Me.lblSemesterName.Values.Text = "Name:"
        '
        'SemesterStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 230)
        Me.Controls.Add(Me.lblTotalSessionCount)
        Me.Controls.Add(Me.lblStudentCount)
        Me.Controls.Add(Me.lblAssessmentCount)
        Me.Controls.Add(Me.lblClassCount)
        Me.Controls.Add(Me.lblModuleCount)
        Me.Controls.Add(Me.lblSemesterName)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.KryptonLabel4)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.KryptonLabel3)
        Me.Name = "SemesterStatistics"
        Me.Text = "Semester Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalSessionCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAssessmentCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblClassCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblModuleCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSemesterName As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
