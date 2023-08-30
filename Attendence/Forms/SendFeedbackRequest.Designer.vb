<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendFeedbackRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendFeedbackRequest))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalStudentsPresent = New System.Windows.Forms.Label()
        Me.lblTotalStudentsExcused = New System.Windows.Forms.Label()
        Me.lblTotalStudentsPresentAndExcused = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudStudentsPresentAtEnd = New System.Windows.Forms.NumericUpDown()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.lblSent = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudDelaySend = New System.Windows.Forms.NumericUpDown()
        Me.llblOptions = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        CType(Me.nudStudentsPresentAtEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDelaySend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total students:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total present:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Excused:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Present && excused:"
        '
        'lblTotalStudentsPresent
        '
        Me.lblTotalStudentsPresent.AutoSize = True
        Me.lblTotalStudentsPresent.Location = New System.Drawing.Point(110, 38)
        Me.lblTotalStudentsPresent.Name = "lblTotalStudentsPresent"
        Me.lblTotalStudentsPresent.Size = New System.Drawing.Size(18, 16)
        Me.lblTotalStudentsPresent.TabIndex = 4
        Me.lblTotalStudentsPresent.Text = "-1"
        '
        'lblTotalStudentsExcused
        '
        Me.lblTotalStudentsExcused.AutoSize = True
        Me.lblTotalStudentsExcused.Location = New System.Drawing.Point(240, 38)
        Me.lblTotalStudentsExcused.Name = "lblTotalStudentsExcused"
        Me.lblTotalStudentsExcused.Size = New System.Drawing.Size(18, 16)
        Me.lblTotalStudentsExcused.TabIndex = 5
        Me.lblTotalStudentsExcused.Text = "-1"
        '
        'lblTotalStudentsPresentAndExcused
        '
        Me.lblTotalStudentsPresentAndExcused.AutoSize = True
        Me.lblTotalStudentsPresentAndExcused.Location = New System.Drawing.Point(437, 38)
        Me.lblTotalStudentsPresentAndExcused.Name = "lblTotalStudentsPresentAndExcused"
        Me.lblTotalStudentsPresentAndExcused.Size = New System.Drawing.Size(18, 16)
        Me.lblTotalStudentsPresentAndExcused.TabIndex = 6
        Me.lblTotalStudentsPresentAndExcused.Text = "-1"
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.Location = New System.Drawing.Point(110, 9)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(18, 16)
        Me.lblTotalStudents.TabIndex = 7
        Me.lblTotalStudents.Text = "-1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "At end of class:"
        '
        'nudStudentsPresentAtEnd
        '
        Me.nudStudentsPresentAtEnd.Location = New System.Drawing.Point(116, 67)
        Me.nudStudentsPresentAtEnd.Name = "nudStudentsPresentAtEnd"
        Me.nudStudentsPresentAtEnd.Size = New System.Drawing.Size(55, 22)
        Me.nudStudentsPresentAtEnd.TabIndex = 9
        Me.nudStudentsPresentAtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSend
        '
        Me.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSend.Location = New System.Drawing.Point(249, 451)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "&Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Subject:"
        '
        'txtSubject
        '
        Me.txtSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubject.Location = New System.Drawing.Point(73, 98)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(504, 22)
        Me.txtSubject.TabIndex = 12
        Me.txtSubject.Text = "Class Feedback Request"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "URL:"
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(73, 131)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(504, 22)
        Me.txtURL.TabIndex = 12
        Me.txtURL.Text = "https://docs.google.com/forms/d/e/1FAIpQLSdoIV4dovv5LQ8e5cRm_nB1zYFVW8ICOzSYB0VzC" &
    "OX4xPsVXA/viewform?usp=pp_url&entry.913466184=[[SessionDate]]&entry.836959787=[[" &
    "ClassName]]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Body:"
        '
        'txtBody
        '
        Me.txtBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBody.Location = New System.Drawing.Point(73, 168)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBody.Size = New System.Drawing.Size(504, 166)
        Me.txtBody.TabIndex = 12
        Me.txtBody.Text = resources.GetString("txtBody.Text")
        '
        'lblSent
        '
        Me.lblSent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSent.AutoSize = True
        Me.lblSent.Location = New System.Drawing.Point(56, 454)
        Me.lblSent.Name = "lblSent"
        Me.lblSent.Size = New System.Drawing.Size(14, 16)
        Me.lblSent.TabIndex = 14
        Me.lblSent.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 454)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Sent:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(309, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Hours to delay send:"
        '
        'nudDelaySend
        '
        Me.nudDelaySend.Location = New System.Drawing.Point(442, 67)
        Me.nudDelaySend.Name = "nudDelaySend"
        Me.nudDelaySend.Size = New System.Drawing.Size(55, 22)
        Me.nudDelaySend.TabIndex = 9
        Me.nudDelaySend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudDelaySend.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'llblOptions
        '
        Me.llblOptions.AutoSize = True
        Me.llblOptions.Location = New System.Drawing.Point(503, 11)
        Me.llblOptions.Name = "llblOptions"
        Me.llblOptions.Size = New System.Drawing.Size(52, 16)
        Me.llblOptions.TabIndex = 15
        Me.llblOptions.TabStop = True
        Me.llblOptions.Text = "Options"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 343)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Notes:"
        '
        'txtComments
        '
        Me.txtComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComments.Location = New System.Drawing.Point(73, 340)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(504, 98)
        Me.txtComments.TabIndex = 12
        Me.txtComments.Text = "Students were very engaged" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tried something new: [what was that?]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Let students o" &
    "ut early" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gave extra breaks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SendFeedbackRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(589, 486)
        Me.Controls.Add(Me.llblOptions)
        Me.Controls.Add(Me.lblSent)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.nudDelaySend)
        Me.Controls.Add(Me.nudStudentsPresentAtEnd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalStudents)
        Me.Controls.Add(Me.lblTotalStudentsPresentAndExcused)
        Me.Controls.Add(Me.lblTotalStudentsExcused)
        Me.Controls.Add(Me.lblTotalStudentsPresent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SendFeedbackRequest"
        Me.Text = "Send Feedback Request"
        CType(Me.nudStudentsPresentAtEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDelaySend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalStudentsPresent As Label
    Friend WithEvents lblTotalStudentsExcused As Label
    Friend WithEvents lblTotalStudentsPresentAndExcused As Label
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nudStudentsPresentAtEnd As NumericUpDown
    Friend WithEvents btnSend As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtURL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBody As TextBox
    Friend WithEvents lblSent As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nudDelaySend As NumericUpDown
    Friend WithEvents llblOptions As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtComments As TextBox
End Class
