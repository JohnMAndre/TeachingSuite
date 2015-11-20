<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamClockForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamClockForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.llblPassWeakOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblStartClock = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lblStudentName = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblNewStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblNewOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblFailOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblPassOutcome = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.llblSaveNotes = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.pbTimer = New System.Windows.Forms.PictureBox()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.chkAbsent = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lblStudentGivenOverall = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFailed = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPassed = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkD3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkD2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkD1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkM3 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkM2 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkM1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.splitOutcomeNotes = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.txtOutcomeText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNotes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.pbTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.splitOutcomeNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitOutcomeNotes.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOutcomeNotes.Panel1.SuspendLayout()
        CType(Me.splitOutcomeNotes.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOutcomeNotes.Panel2.SuspendLayout()
        Me.splitOutcomeNotes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.llblPassWeakOutcome)
        Me.KryptonPanel1.Controls.Add(Me.llblStartClock)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentName)
        Me.KryptonPanel1.Controls.Add(Me.llblNewStudent)
        Me.KryptonPanel1.Controls.Add(Me.llblNewOutcome)
        Me.KryptonPanel1.Controls.Add(Me.llblFailOutcome)
        Me.KryptonPanel1.Controls.Add(Me.llblPassOutcome)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 252)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(642, 39)
        Me.KryptonPanel1.TabIndex = 3
        '
        'llblPassWeakOutcome
        '
        Me.llblPassWeakOutcome.Location = New System.Drawing.Point(88, 2)
        Me.llblPassWeakOutcome.Name = "llblPassWeakOutcome"
        Me.llblPassWeakOutcome.Size = New System.Drawing.Size(38, 34)
        Me.llblPassWeakOutcome.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.llblPassWeakOutcome, "Pass outcome but very weak")
        Me.llblPassWeakOutcome.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_32
        Me.llblPassWeakOutcome.Values.Text = ""
        Me.llblPassWeakOutcome.Visible = False
        '
        'llblStartClock
        '
        Me.llblStartClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblStartClock.Location = New System.Drawing.Point(510, 2)
        Me.llblStartClock.Name = "llblStartClock"
        Me.llblStartClock.Size = New System.Drawing.Size(38, 34)
        Me.llblStartClock.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.llblStartClock, "Start / stop clock")
        Me.llblStartClock.Values.Image = Global.Teaching.My.Resources.Resources.startbutton_32
        Me.llblStartClock.Values.Text = ""
        Me.llblStartClock.Visible = False
        '
        'lblStudentName
        '
        Me.lblStudentName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentName.AutoSize = False
        Me.lblStudentName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.lblStudentName.Location = New System.Drawing.Point(100, 3)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(404, 30)
        Me.lblStudentName.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.lblStudentName.TabIndex = 22
        Me.lblStudentName.Values.Text = "Super Student"
        '
        'llblNewStudent
        '
        Me.llblNewStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblNewStudent.Location = New System.Drawing.Point(599, 2)
        Me.llblNewStudent.Name = "llblNewStudent"
        Me.llblNewStudent.Size = New System.Drawing.Size(38, 34)
        Me.llblNewStudent.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.llblNewStudent, "Select new student")
        Me.llblNewStudent.Values.Image = Global.Teaching.My.Resources.Resources.adduser_32
        Me.llblNewStudent.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblNewStudent.Values.Text = ""
        Me.llblNewStudent.Visible = False
        '
        'llblNewOutcome
        '
        Me.llblNewOutcome.Location = New System.Drawing.Point(3, 3)
        Me.llblNewOutcome.Name = "llblNewOutcome"
        Me.llblNewOutcome.Size = New System.Drawing.Size(38, 34)
        Me.llblNewOutcome.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.llblNewOutcome, "Select new outcome")
        Me.llblNewOutcome.Values.Image = Global.Teaching.My.Resources.Resources.again_32
        Me.llblNewOutcome.Values.Text = ""
        Me.llblNewOutcome.Visible = False
        '
        'llblFailOutcome
        '
        Me.llblFailOutcome.Location = New System.Drawing.Point(44, 2)
        Me.llblFailOutcome.Name = "llblFailOutcome"
        Me.llblFailOutcome.Size = New System.Drawing.Size(38, 34)
        Me.llblFailOutcome.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.llblFailOutcome, "Fail outcome")
        Me.llblFailOutcome.Values.Image = Global.Teaching.My.Resources.Resources.erase_32
        Me.llblFailOutcome.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblFailOutcome.Values.Text = ""
        Me.llblFailOutcome.Visible = False
        '
        'llblPassOutcome
        '
        Me.llblPassOutcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblPassOutcome.Location = New System.Drawing.Point(554, 2)
        Me.llblPassOutcome.Name = "llblPassOutcome"
        Me.llblPassOutcome.Size = New System.Drawing.Size(38, 34)
        Me.llblPassOutcome.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.llblPassOutcome, "Pass outcome")
        Me.llblPassOutcome.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_32
        Me.llblPassOutcome.Values.Text = ""
        Me.llblPassOutcome.Visible = False
        '
        'llblSaveNotes
        '
        Me.llblSaveNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.llblSaveNotes.Location = New System.Drawing.Point(0, 45)
        Me.llblSaveNotes.Name = "llblSaveNotes"
        Me.llblSaveNotes.Size = New System.Drawing.Size(100, 55)
        Me.llblSaveNotes.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.llblSaveNotes.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.llblSaveNotes, "Save notes")
        Me.llblSaveNotes.Values.Text = "Save"
        '
        'pbTimer
        '
        Me.pbTimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbTimer.Location = New System.Drawing.Point(0, 0)
        Me.pbTimer.Name = "pbTimer"
        Me.pbTimer.Size = New System.Drawing.Size(642, 291)
        Me.pbTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTimer.TabIndex = 2
        Me.pbTimer.TabStop = False
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.chkAbsent)
        Me.KryptonPanel2.Controls.Add(Me.lblStudentGivenOverall)
        Me.KryptonPanel2.Controls.Add(Me.lblFailed)
        Me.KryptonPanel2.Controls.Add(Me.lblPassed)
        Me.KryptonPanel2.Controls.Add(Me.chkD3)
        Me.KryptonPanel2.Controls.Add(Me.chkD2)
        Me.KryptonPanel2.Controls.Add(Me.chkD1)
        Me.KryptonPanel2.Controls.Add(Me.chkM3)
        Me.KryptonPanel2.Controls.Add(Me.chkM2)
        Me.KryptonPanel2.Controls.Add(Me.chkM1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 223)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(642, 29)
        Me.KryptonPanel2.TabIndex = 5
        Me.KryptonPanel2.Visible = False
        '
        'chkAbsent
        '
        Me.chkAbsent.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkAbsent.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkAbsent.Location = New System.Drawing.Point(348, 5)
        Me.chkAbsent.Name = "chkAbsent"
        Me.chkAbsent.Size = New System.Drawing.Size(64, 20)
        Me.chkAbsent.TabIndex = 62
        Me.chkAbsent.Text = "Absent:"
        Me.chkAbsent.Values.Text = "Absent:"
        '
        'lblStudentGivenOverall
        '
        Me.lblStudentGivenOverall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentGivenOverall.AutoSize = False
        Me.lblStudentGivenOverall.Location = New System.Drawing.Point(412, 0)
        Me.lblStudentGivenOverall.Name = "lblStudentGivenOverall"
        Me.lblStudentGivenOverall.Size = New System.Drawing.Size(40, 29)
        Me.lblStudentGivenOverall.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentGivenOverall.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.lblStudentGivenOverall.TabIndex = 61
        Me.lblStudentGivenOverall.Values.Text = "?"
        '
        'lblFailed
        '
        Me.lblFailed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFailed.AutoSize = False
        Me.lblFailed.Location = New System.Drawing.Point(460, 0)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(88, 29)
        Me.lblFailed.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.lblFailed.TabIndex = 60
        Me.lblFailed.Values.Text = ""
        '
        'lblPassed
        '
        Me.lblPassed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassed.AutoSize = False
        Me.lblPassed.Location = New System.Drawing.Point(554, 0)
        Me.lblPassed.Name = "lblPassed"
        Me.lblPassed.Size = New System.Drawing.Size(88, 29)
        Me.lblPassed.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassed.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.lblPassed.TabIndex = 24
        Me.lblPassed.Values.Text = ""
        '
        'chkD3
        '
        Me.chkD3.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkD3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkD3.Location = New System.Drawing.Point(276, 5)
        Me.chkD3.Name = "chkD3"
        Me.chkD3.Size = New System.Drawing.Size(42, 20)
        Me.chkD3.TabIndex = 59
        Me.chkD3.Text = "D3:"
        Me.chkD3.Values.Text = "D3:"
        '
        'chkD2
        '
        Me.chkD2.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkD2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkD2.Location = New System.Drawing.Point(223, 5)
        Me.chkD2.Name = "chkD2"
        Me.chkD2.Size = New System.Drawing.Size(42, 20)
        Me.chkD2.TabIndex = 58
        Me.chkD2.Text = "D2:"
        Me.chkD2.Values.Text = "D2:"
        '
        'chkD1
        '
        Me.chkD1.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkD1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkD1.Location = New System.Drawing.Point(175, 5)
        Me.chkD1.Name = "chkD1"
        Me.chkD1.Size = New System.Drawing.Size(42, 20)
        Me.chkD1.TabIndex = 57
        Me.chkD1.Text = "D1:"
        Me.chkD1.Values.Text = "D1:"
        '
        'chkM3
        '
        Me.chkM3.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkM3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkM3.Location = New System.Drawing.Point(112, 5)
        Me.chkM3.Name = "chkM3"
        Me.chkM3.Size = New System.Drawing.Size(44, 20)
        Me.chkM3.TabIndex = 56
        Me.chkM3.Text = "M3:"
        Me.chkM3.Values.Text = "M3:"
        '
        'chkM2
        '
        Me.chkM2.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkM2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkM2.Location = New System.Drawing.Point(62, 5)
        Me.chkM2.Name = "chkM2"
        Me.chkM2.Size = New System.Drawing.Size(44, 20)
        Me.chkM2.TabIndex = 55
        Me.chkM2.Text = "M2:"
        Me.chkM2.Values.Text = "M2:"
        '
        'chkM1
        '
        Me.chkM1.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkM1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.chkM1.Location = New System.Drawing.Point(12, 5)
        Me.chkM1.Name = "chkM1"
        Me.chkM1.Size = New System.Drawing.Size(44, 20)
        Me.chkM1.TabIndex = 54
        Me.chkM1.Text = "M1:"
        Me.chkM1.Values.Text = "M1:"
        '
        'splitOutcomeNotes
        '
        Me.splitOutcomeNotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitOutcomeNotes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.splitOutcomeNotes.Location = New System.Drawing.Point(0, 291)
        Me.splitOutcomeNotes.Name = "splitOutcomeNotes"
        '
        'splitOutcomeNotes.Panel1
        '
        Me.splitOutcomeNotes.Panel1.Controls.Add(Me.txtOutcomeText)
        '
        'splitOutcomeNotes.Panel2
        '
        Me.splitOutcomeNotes.Panel2.Controls.Add(Me.llblSaveNotes)
        Me.splitOutcomeNotes.Panel2.Controls.Add(Me.txtNotes)
        Me.splitOutcomeNotes.Panel2Collapsed = True
        Me.splitOutcomeNotes.Size = New System.Drawing.Size(642, 65)
        Me.splitOutcomeNotes.SplitterDistance = 214
        Me.splitOutcomeNotes.TabIndex = 7
        '
        'txtOutcomeText
        '
        Me.txtOutcomeText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutcomeText.Location = New System.Drawing.Point(0, 0)
        Me.txtOutcomeText.Multiline = True
        Me.txtOutcomeText.Name = "txtOutcomeText"
        Me.txtOutcomeText.ReadOnly = True
        Me.txtOutcomeText.Size = New System.Drawing.Size(642, 65)
        Me.txtOutcomeText.StateCommon.Content.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutcomeText.TabIndex = 5
        Me.txtOutcomeText.Text = "This is the outcome"
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(100, 45)
        Me.txtNotes.StateCommon.Content.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.TabIndex = 7
        '
        'ExamClockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(642, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.pbTimer)
        Me.Controls.Add(Me.splitOutcomeNotes)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ExamClockForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Oral Exam"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.pbTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.splitOutcomeNotes.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOutcomeNotes.Panel1.ResumeLayout(False)
        Me.splitOutcomeNotes.Panel1.PerformLayout()
        CType(Me.splitOutcomeNotes.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOutcomeNotes.Panel2.ResumeLayout(False)
        Me.splitOutcomeNotes.Panel2.PerformLayout()
        CType(Me.splitOutcomeNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOutcomeNotes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbTimer As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents llblPassOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblFailOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblNewStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblNewOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblStudentName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblStartClock As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkD3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkD2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkD1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkM3 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkM2 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkM1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblFailed As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPassed As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentGivenOverall As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents splitOutcomeNotes As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents txtOutcomeText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNotes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblSaveNotes As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblPassWeakOutcome As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents chkAbsent As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
