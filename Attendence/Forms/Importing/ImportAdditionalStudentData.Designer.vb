<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportAdditionalStudentData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportAdditionalStudentData))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.colStudentID = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colEmail = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colNickname = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colExtID = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colTags = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colPeerRevieweeID = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colStudentGroup = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colTeam = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colDoB = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.txtErrors = New System.Windows.Forms.TextBox()
        Me.grpFields = New System.Windows.Forms.GroupBox()
        Me.chkDob = New System.Windows.Forms.CheckBox()
        Me.chkTeam = New System.Windows.Forms.CheckBox()
        Me.chkGroup = New System.Windows.Forms.CheckBox()
        Me.chkPeerStudentID = New System.Windows.Forms.CheckBox()
        Me.chkTags = New System.Windows.Forms.CheckBox()
        Me.chkExtStudentID = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.chkNickname = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStudentsLoaded = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblStudentsSearched = New System.Windows.Forms.Label()
        Me.lblStudentsSearchedCaption = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblErrorCaption = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UncheckallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFields.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.olvStudents)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtErrors)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.grpFields)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel2)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1063, 514)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1063, 538)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.colStudentID)
        Me.olvStudents.AllColumns.Add(Me.colEmail)
        Me.olvStudents.AllColumns.Add(Me.colNickname)
        Me.olvStudents.AllColumns.Add(Me.colExtID)
        Me.olvStudents.AllColumns.Add(Me.colTags)
        Me.olvStudents.AllColumns.Add(Me.colPeerRevieweeID)
        Me.olvStudents.AllColumns.Add(Me.colStudentGroup)
        Me.olvStudents.AllColumns.Add(Me.colTeam)
        Me.olvStudents.AllColumns.Add(Me.colDoB)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudents.CellEditUseWholeCell = False
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colStudentID, Me.colEmail, Me.colNickname, Me.colExtID, Me.colTags, Me.colPeerRevieweeID, Me.colStudentGroup, Me.colTeam, Me.colDoB})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "Copy and paste from spreadsheet."
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HasCollapsibleGroups = False
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(159, 34)
        Me.olvStudents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(619, 426)
        Me.olvStudents.TabIndex = 5
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'colStudentID
        '
        Me.colStudentID.AspectName = "StudentID"
        Me.colStudentID.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colStudentID.Text = "Student ID"
        Me.colStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colStudentID.Width = 90
        '
        'colEmail
        '
        Me.colEmail.AspectName = "EmailAddress"
        Me.colEmail.DisplayIndex = 2
        Me.colEmail.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colEmail.Text = "Email"
        Me.colEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colEmail.Width = 101
        '
        'colNickname
        '
        Me.colNickname.AspectName = "Nickname"
        Me.colNickname.DisplayIndex = 1
        Me.colNickname.Text = "Nickname"
        Me.colNickname.Width = 108
        '
        'colExtID
        '
        Me.colExtID.AspectName = "ExtStudentID"
        Me.colExtID.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colExtID.Text = "ExtID"
        Me.colExtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colExtID.Width = 97
        '
        'colTags
        '
        Me.colTags.AspectName = "Tags"
        Me.colTags.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colTags.Text = "Tags"
        Me.colTags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colTags.Width = 81
        '
        'colPeerRevieweeID
        '
        Me.colPeerRevieweeID.AspectName = "PeerRevieweeStudentID"
        Me.colPeerRevieweeID.Text = "Peer Reviewee ID"
        Me.colPeerRevieweeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPeerRevieweeID.Width = 124
        '
        'colStudentGroup
        '
        Me.colStudentGroup.AspectName = "StudentGroup"
        Me.colStudentGroup.Text = "Group"
        Me.colStudentGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colTeam
        '
        Me.colTeam.AspectName = "StudentTeam"
        Me.colTeam.Text = "Team"
        Me.colTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colDoB
        '
        Me.colDoB.AspectName = "DateOfBirth"
        Me.colDoB.Text = "DoB"
        '
        'txtErrors
        '
        Me.txtErrors.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtErrors.Location = New System.Drawing.Point(778, 34)
        Me.txtErrors.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtErrors.Multiline = True
        Me.txtErrors.Name = "txtErrors"
        Me.txtErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErrors.Size = New System.Drawing.Size(285, 426)
        Me.txtErrors.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtErrors, "These are the lines which did not match any students in the class.")
        Me.txtErrors.Visible = False
        '
        'grpFields
        '
        Me.grpFields.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpFields.Controls.Add(Me.chkDob)
        Me.grpFields.Controls.Add(Me.chkTeam)
        Me.grpFields.Controls.Add(Me.chkGroup)
        Me.grpFields.Controls.Add(Me.chkPeerStudentID)
        Me.grpFields.Controls.Add(Me.chkTags)
        Me.grpFields.Controls.Add(Me.chkExtStudentID)
        Me.grpFields.Controls.Add(Me.chkEmail)
        Me.grpFields.Controls.Add(Me.chkNickname)
        Me.grpFields.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpFields.Location = New System.Drawing.Point(0, 34)
        Me.grpFields.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFields.Name = "grpFields"
        Me.grpFields.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFields.Size = New System.Drawing.Size(159, 426)
        Me.grpFields.TabIndex = 7
        Me.grpFields.TabStop = False
        Me.grpFields.Text = "Fields to import"
        '
        'chkDob
        '
        Me.chkDob.AutoSize = True
        Me.chkDob.Location = New System.Drawing.Point(12, 219)
        Me.chkDob.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkDob.Name = "chkDob"
        Me.chkDob.Size = New System.Drawing.Size(75, 20)
        Me.chkDob.TabIndex = 7
        Me.chkDob.Text = "Birthday"
        Me.chkDob.UseVisualStyleBackColor = True
        '
        'chkTeam
        '
        Me.chkTeam.AutoSize = True
        Me.chkTeam.Location = New System.Drawing.Point(12, 191)
        Me.chkTeam.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkTeam.Name = "chkTeam"
        Me.chkTeam.Size = New System.Drawing.Size(58, 20)
        Me.chkTeam.TabIndex = 6
        Me.chkTeam.Text = "Tea&m"
        Me.chkTeam.UseVisualStyleBackColor = True
        '
        'chkGroup
        '
        Me.chkGroup.AutoSize = True
        Me.chkGroup.Location = New System.Drawing.Point(12, 163)
        Me.chkGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkGroup.Name = "chkGroup"
        Me.chkGroup.Size = New System.Drawing.Size(62, 20)
        Me.chkGroup.TabIndex = 5
        Me.chkGroup.Text = "&Group"
        Me.chkGroup.UseVisualStyleBackColor = True
        '
        'chkPeerStudentID
        '
        Me.chkPeerStudentID.AutoSize = True
        Me.chkPeerStudentID.Location = New System.Drawing.Point(12, 135)
        Me.chkPeerStudentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkPeerStudentID.Name = "chkPeerStudentID"
        Me.chkPeerStudentID.Size = New System.Drawing.Size(115, 20)
        Me.chkPeerStudentID.TabIndex = 4
        Me.chkPeerStudentID.Text = "&Peer StudentID"
        Me.chkPeerStudentID.UseVisualStyleBackColor = True
        '
        'chkTags
        '
        Me.chkTags.AutoSize = True
        Me.chkTags.Location = New System.Drawing.Point(12, 107)
        Me.chkTags.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkTags.Name = "chkTags"
        Me.chkTags.Size = New System.Drawing.Size(54, 20)
        Me.chkTags.TabIndex = 3
        Me.chkTags.Text = "&Tags"
        Me.chkTags.UseVisualStyleBackColor = True
        '
        'chkExtStudentID
        '
        Me.chkExtStudentID.AutoSize = True
        Me.chkExtStudentID.Location = New System.Drawing.Point(12, 79)
        Me.chkExtStudentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkExtStudentID.Name = "chkExtStudentID"
        Me.chkExtStudentID.Size = New System.Drawing.Size(104, 20)
        Me.chkExtStudentID.TabIndex = 2
        Me.chkExtStudentID.Text = "E&xtStudentID"
        Me.chkExtStudentID.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(12, 51)
        Me.chkEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(60, 20)
        Me.chkEmail.TabIndex = 1
        Me.chkEmail.Text = "E&mail"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'chkNickname
        '
        Me.chkNickname.AutoSize = True
        Me.chkNickname.Location = New System.Drawing.Point(12, 23)
        Me.chkNickname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNickname.Name = "chkNickname"
        Me.chkNickname.Size = New System.Drawing.Size(85, 20)
        Me.chkNickname.TabIndex = 0
        Me.chkNickname.Text = "&Nickname"
        Me.chkNickname.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStudentsLoaded)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.lblStudentsSearched)
        Me.Panel1.Controls.Add(Me.lblStudentsSearchedCaption)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 460)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1063, 54)
        Me.Panel1.TabIndex = 8
        '
        'lblStudentsLoaded
        '
        Me.lblStudentsLoaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsLoaded.Location = New System.Drawing.Point(991, 27)
        Me.lblStudentsLoaded.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblStudentsLoaded.Name = "lblStudentsLoaded"
        Me.lblStudentsLoaded.Size = New System.Drawing.Size(51, 19)
        Me.lblStudentsLoaded.TabIndex = 81
        Me.lblStudentsLoaded.Text = "0"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(397, 13)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 31)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&Close"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(834, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 19)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Students loaded:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(545, 13)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(105, 31)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "&Import"
        '
        'lblStudentsSearched
        '
        Me.lblStudentsSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearched.Location = New System.Drawing.Point(991, 2)
        Me.lblStudentsSearched.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblStudentsSearched.Name = "lblStudentsSearched"
        Me.lblStudentsSearched.Size = New System.Drawing.Size(51, 19)
        Me.lblStudentsSearched.TabIndex = 79
        Me.lblStudentsSearched.Text = "0"
        '
        'lblStudentsSearchedCaption
        '
        Me.lblStudentsSearchedCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearchedCaption.Location = New System.Drawing.Point(819, 2)
        Me.lblStudentsSearchedCaption.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblStudentsSearchedCaption.Name = "lblStudentsSearchedCaption"
        Me.lblStudentsSearchedCaption.Size = New System.Drawing.Size(126, 19)
        Me.lblStudentsSearchedCaption.TabIndex = 78
        Me.lblStudentsSearchedCaption.Text = "Students searched:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblErrorCaption)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1063, 34)
        Me.Panel2.TabIndex = 9
        '
        'lblErrorCaption
        '
        Me.lblErrorCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblErrorCaption.Location = New System.Drawing.Point(834, 11)
        Me.lblErrorCaption.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblErrorCaption.Name = "lblErrorCaption"
        Me.lblErrorCaption.Size = New System.Drawing.Size(210, 19)
        Me.lblErrorCaption.TabIndex = 33
        Me.lblErrorCaption.Text = "Data which could not be imported"
        Me.lblErrorCaption.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Location = New System.Drawing.Point(253, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Data to use for import"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip1.TabIndex = 1
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
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
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UncheckallToolStripMenuItem, Me.CheckAllToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'UncheckallToolStripMenuItem
        '
        Me.UncheckallToolStripMenuItem.Name = "UncheckallToolStripMenuItem"
        Me.UncheckallToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UncheckallToolStripMenuItem.Text = "&Uncheck all"
        '
        'CheckAllToolStripMenuItem
        '
        Me.CheckAllToolStripMenuItem.Name = "CheckAllToolStripMenuItem"
        Me.CheckAllToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CheckAllToolStripMenuItem.Text = "&Check all"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ImportAdditionalStudentData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 538)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImportAdditionalStudentData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Email"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFields.ResumeLayout(False)
        Me.grpFields.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtErrors As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorCaption As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblStudentsLoaded As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblStudentsSearched As System.Windows.Forms.Label
    Friend WithEvents lblStudentsSearchedCaption As System.Windows.Forms.Label
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents colStudentID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colEmail As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colNickname As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colExtID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colTags As BrightIdeasSoftware.OLVColumn
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents colPeerRevieweeID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colStudentGroup As BrightIdeasSoftware.OLVColumn
    Friend WithEvents UncheckallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpFields As System.Windows.Forms.GroupBox
    Friend WithEvents chkGroup As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeerStudentID As System.Windows.Forms.CheckBox
    Friend WithEvents chkTags As System.Windows.Forms.CheckBox
    Friend WithEvents chkExtStudentID As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents chkNickname As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkTeam As CheckBox
    Friend WithEvents colTeam As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colDoB As BrightIdeasSoftware.OLVColumn
    Friend WithEvents chkDob As CheckBox
End Class
