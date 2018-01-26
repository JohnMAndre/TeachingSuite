<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportStudentsFromText
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportStudentsFromText))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.dcolAdmin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolAlt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolLocalName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolNickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolExtStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolDateOfBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcolNameLatinLetters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitle = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblLoadingHistoricalStudents = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsLoaded = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearched = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearchedCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgvStudents)
        Me.KryptonPanel.Controls.Add(Me.lblTitle)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.MenuStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Palette = Me.KryptonPalette1
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel.Size = New System.Drawing.Size(852, 538)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AllowUserToOrderColumns = True
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dcolAdmin, Me.dcolAlt, Me.dcolStudentID, Me.dcolLocalName, Me.dcolNickname, Me.dcolEmail, Me.dcolExtStudentID, Me.dcolDateOfBirth, Me.dcolGender, Me.dcolNameLatinLetters})
        Me.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudents.Location = New System.Drawing.Point(0, 53)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(852, 378)
        Me.dgvStudents.TabIndex = 6
        '
        'dcolAdmin
        '
        Me.dcolAdmin.DataPropertyName = "AdminNumber"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolAdmin.DefaultCellStyle = DataGridViewCellStyle1
        Me.dcolAdmin.HeaderText = "Admin"
        Me.dcolAdmin.Name = "dcolAdmin"
        '
        'dcolAlt
        '
        Me.dcolAlt.DataPropertyName = "AltNumber"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolAlt.DefaultCellStyle = DataGridViewCellStyle2
        Me.dcolAlt.HeaderText = "Alt"
        Me.dcolAlt.Name = "dcolAlt"
        Me.dcolAlt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dcolAlt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dcolStudentID
        '
        Me.dcolStudentID.DataPropertyName = "StudentID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolStudentID.DefaultCellStyle = DataGridViewCellStyle3
        Me.dcolStudentID.HeaderText = "StudentID"
        Me.dcolStudentID.Name = "dcolStudentID"
        '
        'dcolLocalName
        '
        Me.dcolLocalName.DataPropertyName = "LocalName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dcolLocalName.DefaultCellStyle = DataGridViewCellStyle4
        Me.dcolLocalName.HeaderText = "Name"
        Me.dcolLocalName.Name = "dcolLocalName"
        '
        'dcolNickname
        '
        Me.dcolNickname.DataPropertyName = "Nickname"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dcolNickname.DefaultCellStyle = DataGridViewCellStyle5
        Me.dcolNickname.HeaderText = "Nickname"
        Me.dcolNickname.Name = "dcolNickname"
        '
        'dcolEmail
        '
        Me.dcolEmail.DataPropertyName = "EmailAddress"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolEmail.DefaultCellStyle = DataGridViewCellStyle6
        Me.dcolEmail.HeaderText = "Email"
        Me.dcolEmail.Name = "dcolEmail"
        Me.dcolEmail.ReadOnly = True
        '
        'dcolExtStudentID
        '
        Me.dcolExtStudentID.DataPropertyName = "ExtStudentID"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolExtStudentID.DefaultCellStyle = DataGridViewCellStyle7
        Me.dcolExtStudentID.HeaderText = "ExtID"
        Me.dcolExtStudentID.Name = "dcolExtStudentID"
        '
        'dcolDateOfBirth
        '
        Me.dcolDateOfBirth.DataPropertyName = "DateOfBirth"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolDateOfBirth.DefaultCellStyle = DataGridViewCellStyle8
        Me.dcolDateOfBirth.HeaderText = "DoB"
        Me.dcolDateOfBirth.Name = "dcolDateOfBirth"
        '
        'dcolGender
        '
        Me.dcolGender.DataPropertyName = "Gender"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dcolGender.DefaultCellStyle = DataGridViewCellStyle9
        Me.dcolGender.HeaderText = "Gender"
        Me.dcolGender.Name = "dcolGender"
        Me.dcolGender.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dcolNameLatinLetters
        '
        Me.dcolNameLatinLetters.DataPropertyName = "LocalNameLatinLetters"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dcolNameLatinLetters.DefaultCellStyle = DataGridViewCellStyle10
        Me.dcolNameLatinLetters.HeaderText = "Standard"
        Me.dcolNameLatinLetters.Name = "dcolNameLatinLetters"
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblTitle.Location = New System.Drawing.Point(0, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Palette = Me.KryptonPalette1
        Me.lblTitle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblTitle.Size = New System.Drawing.Size(852, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Values.Text = "Import students into class: "
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblLoadingHistoricalStudents)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsLoaded)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsSearched)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.lblStudentsSearchedCaption)
        Me.KryptonPanel1.Controls.Add(Me.btnOK)
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 431)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(852, 107)
        Me.KryptonPanel1.TabIndex = 2
        '
        'lblLoadingHistoricalStudents
        '
        Me.lblLoadingHistoricalStudents.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblLoadingHistoricalStudents.Location = New System.Drawing.Point(12, 30)
        Me.lblLoadingHistoricalStudents.Name = "lblLoadingHistoricalStudents"
        Me.lblLoadingHistoricalStudents.Palette = Me.KryptonPalette1
        Me.lblLoadingHistoricalStudents.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblLoadingHistoricalStudents.Size = New System.Drawing.Size(300, 29)
        Me.lblLoadingHistoricalStudents.TabIndex = 77
        Me.lblLoadingHistoricalStudents.Values.Text = "Loading historical students from: "
        '
        'lblStudentsLoaded
        '
        Me.lblStudentsLoaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsLoaded.Location = New System.Drawing.Point(822, 50)
        Me.lblStudentsLoaded.Name = "lblStudentsLoaded"
        Me.lblStudentsLoaded.Size = New System.Drawing.Size(18, 19)
        Me.lblStudentsLoaded.TabIndex = 76
        Me.lblStudentsLoaded.Values.Text = "0"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(674, 50)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(111, 19)
        Me.KryptonLabel3.TabIndex = 75
        Me.KryptonLabel3.Values.Text = "Students loaded:"
        '
        'lblStudentsSearched
        '
        Me.lblStudentsSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearched.Location = New System.Drawing.Point(822, 30)
        Me.lblStudentsSearched.Name = "lblStudentsSearched"
        Me.lblStudentsSearched.Size = New System.Drawing.Size(18, 19)
        Me.lblStudentsSearched.TabIndex = 74
        Me.lblStudentsSearched.Values.Text = "0"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Palette = Me.KryptonPalette1
        Me.KryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel2.Size = New System.Drawing.Size(335, 20)
        Me.KryptonLabel2.TabIndex = 29
        Me.KryptonLabel2.Values.Text = "Copy and paste from spreadsheet in the order you see here"
        '
        'lblStudentsSearchedCaption
        '
        Me.lblStudentsSearchedCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearchedCaption.Location = New System.Drawing.Point(659, 30)
        Me.lblStudentsSearchedCaption.Name = "lblStudentsSearchedCaption"
        Me.lblStudentsSearchedCaption.Size = New System.Drawing.Size(126, 19)
        Me.lblStudentsSearchedCaption.TabIndex = 73
        Me.lblStudentsSearchedCaption.Values.Text = "Students searched:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(445, 76)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 27)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&Import"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(318, 76)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 27)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'KryptonManager
        '
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonManager.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'KryptonPalette2
        '
        Me.KryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 200
        '
        'ImportStudentsFromText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 538)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ImportStudentsFromText"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Students"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents lblTitle As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblStudentsLoaded As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearched As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearchedCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblLoadingHistoricalStudents As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents dcolAdmin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolAlt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolLocalName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolNickname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolExtStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolDateOfBirth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolGender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcolNameLatinLetters As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
