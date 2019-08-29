<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportAdditionalStudentData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportAdditionalStudentData))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.colStudentID = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colEmail = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colNickname = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colExtID = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.colTags = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.txtErrors = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblStudentsLoaded = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearched = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentsSearchedCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.lblErrorCaption = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportnicknameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportemailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportExtIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImporttagsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.colPeerRevieweeID = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ImportpeerRevieweeStudentIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.olvStudents)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtErrors)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.KryptonPanel2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.KryptonPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(911, 413)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(911, 437)
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
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudents.CellEditUseWholeCell = False
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colStudentID, Me.colEmail, Me.colNickname, Me.colExtID, Me.colTags, Me.colPeerRevieweeID})
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
        Me.olvStudents.Location = New System.Drawing.Point(0, 30)
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(614, 333)
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
        'txtErrors
        '
        Me.txtErrors.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtErrors.Location = New System.Drawing.Point(614, 30)
        Me.txtErrors.Multiline = True
        Me.txtErrors.Name = "txtErrors"
        Me.txtErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErrors.Size = New System.Drawing.Size(297, 333)
        Me.txtErrors.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtErrors, "These are the lines which did not match any students in the class.")
        Me.txtErrors.Visible = False
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.lblStudentsLoaded)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel2.Controls.Add(Me.lblStudentsSearched)
        Me.KryptonPanel2.Controls.Add(Me.lblStudentsSearchedCaption)
        Me.KryptonPanel2.Controls.Add(Me.btnOK)
        Me.KryptonPanel2.Controls.Add(Me.btnCancel)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 363)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(911, 50)
        Me.KryptonPanel2.TabIndex = 3
        '
        'lblStudentsLoaded
        '
        Me.lblStudentsLoaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsLoaded.Location = New System.Drawing.Point(854, 26)
        Me.lblStudentsLoaded.Name = "lblStudentsLoaded"
        Me.lblStudentsLoaded.Size = New System.Drawing.Size(18, 19)
        Me.lblStudentsLoaded.TabIndex = 81
        Me.lblStudentsLoaded.Values.Text = "0"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel4.Location = New System.Drawing.Point(706, 26)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(111, 19)
        Me.KryptonLabel4.TabIndex = 80
        Me.KryptonLabel4.Values.Text = "Students loaded:"
        '
        'lblStudentsSearched
        '
        Me.lblStudentsSearched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearched.Location = New System.Drawing.Point(854, 6)
        Me.lblStudentsSearched.Name = "lblStudentsSearched"
        Me.lblStudentsSearched.Size = New System.Drawing.Size(18, 19)
        Me.lblStudentsSearched.TabIndex = 79
        Me.lblStudentsSearched.Values.Text = "0"
        '
        'lblStudentsSearchedCaption
        '
        Me.lblStudentsSearchedCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudentsSearchedCaption.Location = New System.Drawing.Point(691, 6)
        Me.lblStudentsSearchedCaption.Name = "lblStudentsSearchedCaption"
        Me.lblStudentsSearchedCaption.Size = New System.Drawing.Size(126, 19)
        Me.lblStudentsSearchedCaption.TabIndex = 78
        Me.lblStudentsSearchedCaption.Values.Text = "Students searched:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(474, 15)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&Import"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(347, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Close"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.lblErrorCaption)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(911, 30)
        Me.KryptonPanel1.TabIndex = 0
        '
        'lblErrorCaption
        '
        Me.lblErrorCaption.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblErrorCaption.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.lblErrorCaption.Location = New System.Drawing.Point(615, 6)
        Me.lblErrorCaption.Name = "lblErrorCaption"
        Me.lblErrorCaption.Size = New System.Drawing.Size(210, 19)
        Me.lblErrorCaption.TabIndex = 33
        Me.lblErrorCaption.Values.Text = "Data which could not be imported"
        Me.lblErrorCaption.Visible = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.KryptonLabel3.Location = New System.Drawing.Point(208, 6)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(140, 19)
        Me.KryptonLabel3.TabIndex = 30
        Me.KryptonLabel3.Values.Text = "Data to use for import"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 24)
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportnicknameToolStripMenuItem, Me.ImportemailToolStripMenuItem, Me.ImportExtIDToolStripMenuItem, Me.ImporttagsToolStripMenuItem, Me.ImportpeerRevieweeStudentIDToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'ImportnicknameToolStripMenuItem
        '
        Me.ImportnicknameToolStripMenuItem.Checked = True
        Me.ImportnicknameToolStripMenuItem.CheckOnClick = True
        Me.ImportnicknameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ImportnicknameToolStripMenuItem.Name = "ImportnicknameToolStripMenuItem"
        Me.ImportnicknameToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ImportnicknameToolStripMenuItem.Text = "Import &nickname"
        '
        'ImportemailToolStripMenuItem
        '
        Me.ImportemailToolStripMenuItem.Checked = True
        Me.ImportemailToolStripMenuItem.CheckOnClick = True
        Me.ImportemailToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ImportemailToolStripMenuItem.Name = "ImportemailToolStripMenuItem"
        Me.ImportemailToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ImportemailToolStripMenuItem.Text = "Import &email"
        '
        'ImportExtIDToolStripMenuItem
        '
        Me.ImportExtIDToolStripMenuItem.Checked = True
        Me.ImportExtIDToolStripMenuItem.CheckOnClick = True
        Me.ImportExtIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ImportExtIDToolStripMenuItem.Name = "ImportExtIDToolStripMenuItem"
        Me.ImportExtIDToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ImportExtIDToolStripMenuItem.Text = "Import E&xtID"
        '
        'ImporttagsToolStripMenuItem
        '
        Me.ImporttagsToolStripMenuItem.Checked = True
        Me.ImporttagsToolStripMenuItem.CheckOnClick = True
        Me.ImporttagsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ImporttagsToolStripMenuItem.Name = "ImporttagsToolStripMenuItem"
        Me.ImporttagsToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ImporttagsToolStripMenuItem.Text = "Import &tags"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'colPeerRevieweeID
        '
        Me.colPeerRevieweeID.AspectName = "PeerRevieweeStudentID"
        Me.colPeerRevieweeID.Text = "Peer Reviewee ID"
        Me.colPeerRevieweeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPeerRevieweeID.Width = 124
        '
        'ImportpeerRevieweeStudentIDToolStripMenuItem
        '
        Me.ImportpeerRevieweeStudentIDToolStripMenuItem.Checked = True
        Me.ImportpeerRevieweeStudentIDToolStripMenuItem.CheckOnClick = True
        Me.ImportpeerRevieweeStudentIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ImportpeerRevieweeStudentIDToolStripMenuItem.Name = "ImportpeerRevieweeStudentIDToolStripMenuItem"
        Me.ImportpeerRevieweeStudentIDToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ImportpeerRevieweeStudentIDToolStripMenuItem.Text = "Import &peer reviewee StudentID"
        '
        'ImportAdditionalStudentData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 437)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtErrors As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblErrorCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsLoaded As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearched As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblStudentsSearchedCaption As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportemailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportExtIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImporttagsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportnicknameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents colStudentID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colEmail As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colNickname As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colExtID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents colTags As BrightIdeasSoftware.OLVColumn
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents colPeerRevieweeID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ImportpeerRevieweeStudentIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
