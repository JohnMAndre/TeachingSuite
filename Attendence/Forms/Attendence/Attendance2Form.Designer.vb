<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance2Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance2Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadStudentsInTraditionalOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAndCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncreaseFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditCurrentStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverlayClockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilightBirthdaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RedLastFewSecondsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcusedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AllStudentsPresentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllStuentsAbsentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllStudentsExcusedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PresentFrontRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentSecondRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentThirdRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentFourthRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentFifthRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentSixthRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentSeventhRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentEighthRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentWayBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Present3MeritToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Present3DemeritToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetQualityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGendermaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGenderfemaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGenderUnknownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlagStudentInTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSessionDate = New System.Windows.Forms.ToolStripTextBox()
        Me.txtFilter = New System.Windows.Forms.ToolStripTextBox()
        Me.txtStudentGroup = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStudentsPresent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStudentsExcused = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStudentsLate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStudentsAbsent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrStudentCount = New System.Windows.Forms.Timer(Me.components)
        Me.pbTimer = New System.Windows.Forms.PictureBox()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pbTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.MarkToolStripMenuItem, Me.SetQualityToolStripMenuItem, Me.HelpToolStripMenuItem, Me.txtSessionDate, Me.txtFilter, Me.txtStudentGroup, Me.ToolStripMenuItem1, Me.PublicToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadStudentsInTraditionalOrderToolStripMenuItem, Me.ReloadStudentsToolStripMenuItem, Me.ToolStripSeparator2, Me.SaveAndCloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadStudentsInTraditionalOrderToolStripMenuItem
        '
        Me.LoadStudentsInTraditionalOrderToolStripMenuItem.Name = "LoadStudentsInTraditionalOrderToolStripMenuItem"
        Me.LoadStudentsInTraditionalOrderToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.LoadStudentsInTraditionalOrderToolStripMenuItem.Text = "&Load students in traditional order"
        '
        'ReloadStudentsToolStripMenuItem
        '
        Me.ReloadStudentsToolStripMenuItem.Name = "ReloadStudentsToolStripMenuItem"
        Me.ReloadStudentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadStudentsToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ReloadStudentsToolStripMenuItem.Text = "&Reload students"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(246, 6)
        '
        'SaveAndCloseToolStripMenuItem
        '
        Me.SaveAndCloseToolStripMenuItem.Name = "SaveAndCloseToolStripMenuItem"
        Me.SaveAndCloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAndCloseToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SaveAndCloseToolStripMenuItem.Text = "&Save and close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseFontToolStripMenuItem, Me.DecreaseFontToolStripMenuItem, Me.ToolStripSeparator4, Me.EditCurrentStudentToolStripMenuItem, Me.OverlayClockToolStripMenuItem, Me.HilightBirthdaysToolStripMenuItem, Me.ToolStripSeparator6, Me.RedLastFewSecondsToolStripMenuItem, Me.MessageToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'IncreaseFontToolStripMenuItem
        '
        Me.IncreaseFontToolStripMenuItem.Name = "IncreaseFontToolStripMenuItem"
        Me.IncreaseFontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.IncreaseFontToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.IncreaseFontToolStripMenuItem.Text = "&Increase font"
        '
        'DecreaseFontToolStripMenuItem
        '
        Me.DecreaseFontToolStripMenuItem.Name = "DecreaseFontToolStripMenuItem"
        Me.DecreaseFontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DecreaseFontToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DecreaseFontToolStripMenuItem.Text = "&Decrease font"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(244, 6)
        '
        'EditCurrentStudentToolStripMenuItem
        '
        Me.EditCurrentStudentToolStripMenuItem.Name = "EditCurrentStudentToolStripMenuItem"
        Me.EditCurrentStudentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.EditCurrentStudentToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EditCurrentStudentToolStripMenuItem.Text = "&Edit current student"
        '
        'OverlayClockToolStripMenuItem
        '
        Me.OverlayClockToolStripMenuItem.Name = "OverlayClockToolStripMenuItem"
        Me.OverlayClockToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OverlayClockToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.OverlayClockToolStripMenuItem.Text = "&Overlay clock"
        '
        'HilightBirthdaysToolStripMenuItem
        '
        Me.HilightBirthdaysToolStripMenuItem.Name = "HilightBirthdaysToolStripMenuItem"
        Me.HilightBirthdaysToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.HilightBirthdaysToolStripMenuItem.Text = "&Hilight birthdays"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(244, 6)
        '
        'RedLastFewSecondsToolStripMenuItem
        '
        Me.RedLastFewSecondsToolStripMenuItem.CheckOnClick = True
        Me.RedLastFewSecondsToolStripMenuItem.Name = "RedLastFewSecondsToolStripMenuItem"
        Me.RedLastFewSecondsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RedLastFewSecondsToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.RedLastFewSecondsToolStripMenuItem.Text = "&Red last few seconds"
        '
        'MessageToolStripMenuItem
        '
        Me.MessageToolStripMenuItem.CheckOnClick = True
        Me.MessageToolStripMenuItem.Name = "MessageToolStripMenuItem"
        Me.MessageToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MessageToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.MessageToolStripMenuItem.Text = "Message"
        '
        'MarkToolStripMenuItem
        '
        Me.MarkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentToolStripMenuItem, Me.LateToolStripMenuItem, Me.RemovedToolStripMenuItem, Me.AbsentToolStripMenuItem, Me.ExcusedToolStripMenuItem, Me.ToolStripSeparator3, Me.AllStudentsPresentToolStripMenuItem, Me.AllStuentsAbsentToolStripMenuItem, Me.AllStudentsExcusedToolStripMenuItem, Me.ToolStripSeparator5, Me.PresentFrontRowToolStripMenuItem, Me.PresentSecondRowToolStripMenuItem, Me.PresentThirdRowToolStripMenuItem, Me.PresentFourthRowToolStripMenuItem, Me.PresentFifthRowToolStripMenuItem, Me.PresentSixthRowToolStripMenuItem, Me.PresentSeventhRowToolStripMenuItem, Me.PresentEighthRowToolStripMenuItem, Me.PresentWayBackToolStripMenuItem, Me.ToolStripSeparator7, Me.Present3MeritToolStripMenuItem, Me.Present3DemeritToolStripMenuItem})
        Me.MarkToolStripMenuItem.Name = "MarkToolStripMenuItem"
        Me.MarkToolStripMenuItem.Size = New System.Drawing.Size(46, 23)
        Me.MarkToolStripMenuItem.Text = "&Mark"
        '
        'PresentToolStripMenuItem
        '
        Me.PresentToolStripMenuItem.Name = "PresentToolStripMenuItem"
        Me.PresentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PresentToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentToolStripMenuItem.Text = "&Present"
        '
        'LateToolStripMenuItem
        '
        Me.LateToolStripMenuItem.Name = "LateToolStripMenuItem"
        Me.LateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LateToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.LateToolStripMenuItem.Text = "&Late"
        '
        'RemovedToolStripMenuItem
        '
        Me.RemovedToolStripMenuItem.Name = "RemovedToolStripMenuItem"
        Me.RemovedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.RemovedToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.RemovedToolStripMenuItem.Text = "&Removed"
        '
        'AbsentToolStripMenuItem
        '
        Me.AbsentToolStripMenuItem.Name = "AbsentToolStripMenuItem"
        Me.AbsentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbsentToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.AbsentToolStripMenuItem.Text = "&Absent"
        '
        'ExcusedToolStripMenuItem
        '
        Me.ExcusedToolStripMenuItem.Name = "ExcusedToolStripMenuItem"
        Me.ExcusedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExcusedToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ExcusedToolStripMenuItem.Text = "&Excused"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(255, 6)
        '
        'AllStudentsPresentToolStripMenuItem
        '
        Me.AllStudentsPresentToolStripMenuItem.Name = "AllStudentsPresentToolStripMenuItem"
        Me.AllStudentsPresentToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.AllStudentsPresentToolStripMenuItem.Text = "All students present"
        '
        'AllStuentsAbsentToolStripMenuItem
        '
        Me.AllStuentsAbsentToolStripMenuItem.Name = "AllStuentsAbsentToolStripMenuItem"
        Me.AllStuentsAbsentToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.AllStuentsAbsentToolStripMenuItem.Text = "All stuents absent"
        '
        'AllStudentsExcusedToolStripMenuItem
        '
        Me.AllStudentsExcusedToolStripMenuItem.Name = "AllStudentsExcusedToolStripMenuItem"
        Me.AllStudentsExcusedToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.AllStudentsExcusedToolStripMenuItem.Text = "All students excused"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(255, 6)
        '
        'PresentFrontRowToolStripMenuItem
        '
        Me.PresentFrontRowToolStripMenuItem.Name = "PresentFrontRowToolStripMenuItem"
        Me.PresentFrontRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.PresentFrontRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentFrontRowToolStripMenuItem.Text = "Present-Front Row"
        '
        'PresentSecondRowToolStripMenuItem
        '
        Me.PresentSecondRowToolStripMenuItem.Name = "PresentSecondRowToolStripMenuItem"
        Me.PresentSecondRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.PresentSecondRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentSecondRowToolStripMenuItem.Text = "Present-Second Row"
        '
        'PresentThirdRowToolStripMenuItem
        '
        Me.PresentThirdRowToolStripMenuItem.Name = "PresentThirdRowToolStripMenuItem"
        Me.PresentThirdRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.PresentThirdRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentThirdRowToolStripMenuItem.Text = "Present-Third Row"
        '
        'PresentFourthRowToolStripMenuItem
        '
        Me.PresentFourthRowToolStripMenuItem.Name = "PresentFourthRowToolStripMenuItem"
        Me.PresentFourthRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.PresentFourthRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentFourthRowToolStripMenuItem.Text = "Present-Fourth Row"
        '
        'PresentFifthRowToolStripMenuItem
        '
        Me.PresentFifthRowToolStripMenuItem.Name = "PresentFifthRowToolStripMenuItem"
        Me.PresentFifthRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.PresentFifthRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentFifthRowToolStripMenuItem.Text = "Present-Fifth Row"
        '
        'PresentSixthRowToolStripMenuItem
        '
        Me.PresentSixthRowToolStripMenuItem.Name = "PresentSixthRowToolStripMenuItem"
        Me.PresentSixthRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.PresentSixthRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentSixthRowToolStripMenuItem.Text = "Present-Sixth Row"
        '
        'PresentSeventhRowToolStripMenuItem
        '
        Me.PresentSeventhRowToolStripMenuItem.Name = "PresentSeventhRowToolStripMenuItem"
        Me.PresentSeventhRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D7), System.Windows.Forms.Keys)
        Me.PresentSeventhRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentSeventhRowToolStripMenuItem.Text = "Present-Seventh Row"
        '
        'PresentEighthRowToolStripMenuItem
        '
        Me.PresentEighthRowToolStripMenuItem.Name = "PresentEighthRowToolStripMenuItem"
        Me.PresentEighthRowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D8), System.Windows.Forms.Keys)
        Me.PresentEighthRowToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentEighthRowToolStripMenuItem.Text = "Present-Eighth Row"
        '
        'PresentWayBackToolStripMenuItem
        '
        Me.PresentWayBackToolStripMenuItem.Name = "PresentWayBackToolStripMenuItem"
        Me.PresentWayBackToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D9), System.Windows.Forms.Keys)
        Me.PresentWayBackToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.PresentWayBackToolStripMenuItem.Text = "Present-Way Back"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(255, 6)
        '
        'Present3MeritToolStripMenuItem
        '
        Me.Present3MeritToolStripMenuItem.Name = "Present3MeritToolStripMenuItem"
        Me.Present3MeritToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.Present3MeritToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.Present3MeritToolStripMenuItem.Text = "Present + 3 merit"
        '
        'Present3DemeritToolStripMenuItem
        '
        Me.Present3DemeritToolStripMenuItem.Name = "Present3DemeritToolStripMenuItem"
        Me.Present3DemeritToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.Present3DemeritToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.Present3DemeritToolStripMenuItem.Text = "Present + 3 demerit"
        '
        'SetQualityToolStripMenuItem
        '
        Me.SetQualityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetGendermaleToolStripMenuItem, Me.SetGenderfemaleToolStripMenuItem, Me.SetGenderUnknownToolStripMenuItem, Me.ToolStripSeparator1, Me.FlagStudentInTagToolStripMenuItem})
        Me.SetQualityToolStripMenuItem.Name = "SetQualityToolStripMenuItem"
        Me.SetQualityToolStripMenuItem.Size = New System.Drawing.Size(60, 23)
        Me.SetQualityToolStripMenuItem.Text = "&Student"
        '
        'SetGendermaleToolStripMenuItem
        '
        Me.SetGendermaleToolStripMenuItem.Name = "SetGendermaleToolStripMenuItem"
        Me.SetGendermaleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.SetGendermaleToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SetGendermaleToolStripMenuItem.Text = "Set gender=male"
        '
        'SetGenderfemaleToolStripMenuItem
        '
        Me.SetGenderfemaleToolStripMenuItem.Name = "SetGenderfemaleToolStripMenuItem"
        Me.SetGenderfemaleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SetGenderfemaleToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SetGenderfemaleToolStripMenuItem.Text = "Set gender=female"
        '
        'SetGenderUnknownToolStripMenuItem
        '
        Me.SetGenderUnknownToolStripMenuItem.Name = "SetGenderUnknownToolStripMenuItem"
        Me.SetGenderUnknownToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.SetGenderUnknownToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SetGenderUnknownToolStripMenuItem.Text = "Set gender=unknown"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'FlagStudentInTagToolStripMenuItem
        '
        Me.FlagStudentInTagToolStripMenuItem.Name = "FlagStudentInTagToolStripMenuItem"
        Me.FlagStudentInTagToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.FlagStudentInTagToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.FlagStudentInTagToolStripMenuItem.Text = "Flag student in tag"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'txtSessionDate
        '
        Me.txtSessionDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSessionDate.Name = "txtSessionDate"
        Me.txtSessionDate.Size = New System.Drawing.Size(100, 23)
        Me.txtSessionDate.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSessionDate.ToolTipText = "Session Date"
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 23)
        Me.txtFilter.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilter.ToolTipText = "Filter for list"
        '
        'txtStudentGroup
        '
        Me.txtStudentGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentGroup.MaxLength = 2
        Me.txtStudentGroup.Name = "txtStudentGroup"
        Me.txtStudentGroup.Size = New System.Drawing.Size(100, 23)
        Me.txtStudentGroup.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStudentGroup.ToolTipText = "Student group number"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(75, 23)
        Me.ToolStripMenuItem1.Text = "&Clear Filter"
        Me.ToolStripMenuItem1.ToolTipText = "Clear all filters (including hidden students)"
        '
        'PublicToolStripMenuItem
        '
        Me.PublicToolStripMenuItem.Enabled = False
        Me.PublicToolStripMenuItem.Name = "PublicToolStripMenuItem"
        Me.PublicToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.PublicToolStripMenuItem.Text = "Public"
        Me.PublicToolStripMenuItem.ToolTipText = "Open public window"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudents.Location = New System.Drawing.Point(0, 27)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.ShowCellToolTips = False
        Me.dgvStudents.Size = New System.Drawing.Size(719, 429)
        Me.dgvStudents.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "AdminNumber"
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Icon"
        Me.Column8.HeaderText = "Icon"
        Me.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "LocalName"
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Nickname"
        Me.Column3.HeaderText = "Nickname"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "StudentID"
        Me.Column4.HeaderText = "ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "AttendanceStatus"
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "CurrentAbsences"
        Me.Column7.HeaderText = "Absent"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Hidden"
        Me.Column6.HeaderText = "Hidden"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStudentsPresent, Me.lblStudentsExcused, Me.lblStudentsLate, Me.lblStudentsAbsent})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 456)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(719, 22)
        Me.StatusStrip1.TabIndex = 3
        '
        'lblStudentsPresent
        '
        Me.lblStudentsPresent.Name = "lblStudentsPresent"
        Me.lblStudentsPresent.Size = New System.Drawing.Size(0, 17)
        '
        'lblStudentsExcused
        '
        Me.lblStudentsExcused.Name = "lblStudentsExcused"
        Me.lblStudentsExcused.Size = New System.Drawing.Size(0, 17)
        '
        'lblStudentsLate
        '
        Me.lblStudentsLate.Name = "lblStudentsLate"
        Me.lblStudentsLate.Size = New System.Drawing.Size(0, 17)
        '
        'lblStudentsAbsent
        '
        Me.lblStudentsAbsent.Name = "lblStudentsAbsent"
        Me.lblStudentsAbsent.Size = New System.Drawing.Size(0, 17)
        '
        'tmrStudentCount
        '
        Me.tmrStudentCount.Enabled = True
        Me.tmrStudentCount.Interval = 2000
        '
        'pbTimer
        '
        Me.pbTimer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbTimer.BackColor = System.Drawing.Color.Black
        Me.pbTimer.Location = New System.Drawing.Point(0, 48)
        Me.pbTimer.Name = "pbTimer"
        Me.pbTimer.Size = New System.Drawing.Size(719, 408)
        Me.pbTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTimer.TabIndex = 4
        Me.pbTimer.TabStop = False
        Me.pbTimer.Visible = False
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'Attendance2Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 478)
        Me.Controls.Add(Me.pbTimer)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Attendance2Form"
        Me.Text = "Taking Attendance"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pbTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveAndCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncreaseFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecreaseFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcusedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllStudentsPresentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllStuentsAbsentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllStudentsExcusedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetQualityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGendermaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGenderfemaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGenderUnknownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSessionDate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtFilter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtStudentGroup As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PublicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStudentsPresent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrStudentCount As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditCurrentStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OverlayClockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbTimer As System.Windows.Forms.PictureBox
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents LoadStudentsInTraditionalOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PresentFrontRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentSecondRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentThirdRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentFourthRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentFifthRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentSixthRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentSeventhRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentEighthRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentWayBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilightBirthdaysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents RedLastFewSecondsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FlagStudentInTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStudentsExcused As ToolStripStatusLabel
    Friend WithEvents lblStudentsLate As ToolStripStatusLabel
    Friend WithEvents lblStudentsAbsent As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents Present3MeritToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Present3DemeritToolStripMenuItem As ToolStripMenuItem
End Class
