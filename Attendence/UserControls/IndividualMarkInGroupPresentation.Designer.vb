<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualMarkInGroupPresentation
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IndividualMarkInGroupPresentation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOverall = New System.Windows.Forms.TextBox()
        Me.txtImprovement = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.picLanguageMark = New System.Windows.Forms.PictureBox()
        Me.picPresentationMark = New System.Windows.Forms.PictureBox()
        Me.picContentMark = New System.Windows.Forms.PictureBox()
        Me.lblContentGrade = New System.Windows.Forms.Label()
        Me.lblPresentationGrade = New System.Windows.Forms.Label()
        Me.lblLanguageGrade = New System.Windows.Forms.Label()
        Me.lblAverageGrade = New System.Windows.Forms.Label()
        Me.lblLanguageWeight = New System.Windows.Forms.Label()
        Me.lblPresentationWeight = New System.Windows.Forms.Label()
        Me.lblContentWeight = New System.Windows.Forms.Label()
        CType(Me.picLanguageMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPresentationMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContentMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Content:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Presentation:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Language:"
        '
        'txtOverall
        '
        Me.txtOverall.Location = New System.Drawing.Point(98, 120)
        Me.txtOverall.Multiline = True
        Me.txtOverall.Name = "txtOverall"
        Me.txtOverall.Size = New System.Drawing.Size(267, 102)
        Me.txtOverall.TabIndex = 6
        '
        'txtImprovement
        '
        Me.txtImprovement.Location = New System.Drawing.Point(98, 228)
        Me.txtImprovement.Multiline = True
        Me.txtImprovement.Name = "txtImprovement"
        Me.txtImprovement.Size = New System.Drawing.Size(267, 84)
        Me.txtImprovement.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Overall:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Improvement:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(117, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "F"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(171, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "R"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(223, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "P"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.GreenYellow
        Me.Label9.Location = New System.Drawing.Point(276, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "M"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LimeGreen
        Me.Label10.Location = New System.Drawing.Point(331, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "D"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(306, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "4"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(251, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(198, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(146, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(92, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 16)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "5"
        '
        'picLanguageMark
        '
        Me.picLanguageMark.Image = CType(resources.GetObject("picLanguageMark.Image"), System.Drawing.Image)
        Me.picLanguageMark.Location = New System.Drawing.Point(98, 88)
        Me.picLanguageMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLanguageMark.Name = "picLanguageMark"
        Me.picLanguageMark.Size = New System.Drawing.Size(267, 24)
        Me.picLanguageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLanguageMark.TabIndex = 4
        Me.picLanguageMark.TabStop = False
        '
        'picPresentationMark
        '
        Me.picPresentationMark.Image = CType(resources.GetObject("picPresentationMark.Image"), System.Drawing.Image)
        Me.picPresentationMark.Location = New System.Drawing.Point(98, 60)
        Me.picPresentationMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPresentationMark.Name = "picPresentationMark"
        Me.picPresentationMark.Size = New System.Drawing.Size(267, 24)
        Me.picPresentationMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPresentationMark.TabIndex = 2
        Me.picPresentationMark.TabStop = False
        '
        'picContentMark
        '
        Me.picContentMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picContentMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picContentMark.Image = Global.Teaching.My.Resources.Resources.MarkingGridForPresentations
        Me.picContentMark.Location = New System.Drawing.Point(98, 32)
        Me.picContentMark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picContentMark.Name = "picContentMark"
        Me.picContentMark.Size = New System.Drawing.Size(267, 24)
        Me.picContentMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContentMark.TabIndex = 0
        Me.picContentMark.TabStop = False
        '
        'lblContentGrade
        '
        Me.lblContentGrade.AutoSize = True
        Me.lblContentGrade.Location = New System.Drawing.Point(371, 35)
        Me.lblContentGrade.Name = "lblContentGrade"
        Me.lblContentGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblContentGrade.TabIndex = 21
        Me.lblContentGrade.Text = "--"
        '
        'lblPresentationGrade
        '
        Me.lblPresentationGrade.AutoSize = True
        Me.lblPresentationGrade.Location = New System.Drawing.Point(371, 63)
        Me.lblPresentationGrade.Name = "lblPresentationGrade"
        Me.lblPresentationGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblPresentationGrade.TabIndex = 22
        Me.lblPresentationGrade.Text = "--"
        '
        'lblLanguageGrade
        '
        Me.lblLanguageGrade.AutoSize = True
        Me.lblLanguageGrade.Location = New System.Drawing.Point(371, 91)
        Me.lblLanguageGrade.Name = "lblLanguageGrade"
        Me.lblLanguageGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblLanguageGrade.TabIndex = 23
        Me.lblLanguageGrade.Text = "--"
        '
        'lblAverageGrade
        '
        Me.lblAverageGrade.AutoSize = True
        Me.lblAverageGrade.Location = New System.Drawing.Point(371, 123)
        Me.lblAverageGrade.Name = "lblAverageGrade"
        Me.lblAverageGrade.Size = New System.Drawing.Size(16, 16)
        Me.lblAverageGrade.TabIndex = 24
        Me.lblAverageGrade.Text = "--"
        '
        'lblLanguageWeight
        '
        Me.lblLanguageWeight.AutoSize = True
        Me.lblLanguageWeight.Location = New System.Drawing.Point(393, 91)
        Me.lblLanguageWeight.Name = "lblLanguageWeight"
        Me.lblLanguageWeight.Size = New System.Drawing.Size(16, 16)
        Me.lblLanguageWeight.TabIndex = 27
        Me.lblLanguageWeight.Text = "--"
        '
        'lblPresentationWeight
        '
        Me.lblPresentationWeight.AutoSize = True
        Me.lblPresentationWeight.Location = New System.Drawing.Point(393, 63)
        Me.lblPresentationWeight.Name = "lblPresentationWeight"
        Me.lblPresentationWeight.Size = New System.Drawing.Size(16, 16)
        Me.lblPresentationWeight.TabIndex = 26
        Me.lblPresentationWeight.Text = "--"
        '
        'lblContentWeight
        '
        Me.lblContentWeight.AutoSize = True
        Me.lblContentWeight.Location = New System.Drawing.Point(393, 35)
        Me.lblContentWeight.Name = "lblContentWeight"
        Me.lblContentWeight.Size = New System.Drawing.Size(16, 16)
        Me.lblContentWeight.TabIndex = 25
        Me.lblContentWeight.Text = "--"
        '
        'IndividualMarkInGroupPresentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblLanguageWeight)
        Me.Controls.Add(Me.lblPresentationWeight)
        Me.Controls.Add(Me.lblContentWeight)
        Me.Controls.Add(Me.lblAverageGrade)
        Me.Controls.Add(Me.lblLanguageGrade)
        Me.Controls.Add(Me.lblPresentationGrade)
        Me.Controls.Add(Me.lblContentGrade)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtImprovement)
        Me.Controls.Add(Me.txtOverall)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picLanguageMark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picPresentationMark)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picContentMark)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IndividualMarkInGroupPresentation"
        Me.Size = New System.Drawing.Size(515, 330)
        CType(Me.picLanguageMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPresentationMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContentMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picContentMark As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picPresentationMark As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picLanguageMark As System.Windows.Forms.PictureBox
    Friend WithEvents txtOverall As System.Windows.Forms.TextBox
    Friend WithEvents txtImprovement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblContentGrade As System.Windows.Forms.Label
    Friend WithEvents lblPresentationGrade As System.Windows.Forms.Label
    Friend WithEvents lblLanguageGrade As System.Windows.Forms.Label
    Friend WithEvents lblAverageGrade As System.Windows.Forms.Label
    Friend WithEvents lblLanguageWeight As System.Windows.Forms.Label
    Friend WithEvents lblPresentationWeight As System.Windows.Forms.Label
    Friend WithEvents lblContentWeight As System.Windows.Forms.Label

End Class
