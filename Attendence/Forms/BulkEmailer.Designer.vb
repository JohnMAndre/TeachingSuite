<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulkEmailer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BulkEmailer))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonPanel4 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.splitOverall = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.txtLinkAddress = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblCreateLink = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudSendInXHours = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmailTrailingText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblSendingStatus = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudEmailSendingAccount = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.txtSubject = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.llblMakeQuiz = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lblRecipientCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.llblUnSelectStudents = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtStudentFilter = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearFilter = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblSelectStudents = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.tmrFilterStudents = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel4.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.Panel1.SuspendLayout()
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.Panel2.SuspendLayout()
        Me.splitOverall.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel4)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1255, 621)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel4
        '
        Me.KryptonPanel4.Controls.Add(Me.ToolStripContainer2)
        Me.KryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel4.Name = "KryptonPanel4"
        Me.KryptonPanel4.Size = New System.Drawing.Size(1255, 621)
        Me.KryptonPanel4.TabIndex = 9
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.KryptonPanel3)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(1255, 597)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(1255, 621)
        Me.ToolStripContainer2.TabIndex = 10
        Me.ToolStripContainer2.Text = "ToolStripContainer1"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.MenuStrip2)
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.splitOverall)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(1255, 597)
        Me.KryptonPanel3.TabIndex = 9
        '
        'splitOverall
        '
        Me.splitOverall.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitOverall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitOverall.Location = New System.Drawing.Point(0, 0)
        Me.splitOverall.Name = "splitOverall"
        '
        'splitOverall.Panel1
        '
        Me.splitOverall.Panel1.Controls.Add(Me.txtLinkAddress)
        Me.splitOverall.Panel1.Controls.Add(Me.llblCreateLink)
        Me.splitOverall.Panel1.Controls.Add(Me.btnCancel)
        Me.splitOverall.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.splitOverall.Panel1.Controls.Add(Me.nudSendInXHours)
        Me.splitOverall.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.splitOverall.Panel1.Controls.Add(Me.txtEmailTrailingText)
        Me.splitOverall.Panel1.Controls.Add(Me.lblSendingStatus)
        Me.splitOverall.Panel1.Controls.Add(Me.ProgressBar1)
        Me.splitOverall.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.splitOverall.Panel1.Controls.Add(Me.nudEmailSendingAccount)
        Me.splitOverall.Panel1.Controls.Add(Me.txtSubject)
        Me.splitOverall.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.splitOverall.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.splitOverall.Panel1.Controls.Add(Me.btnOK)
        Me.splitOverall.Panel1.Controls.Add(Me.llblMakeQuiz)
        '
        'splitOverall.Panel2
        '
        Me.splitOverall.Panel2.Controls.Add(Me.lblRecipientCount)
        Me.splitOverall.Panel2.Controls.Add(Me.olvStudents)
        Me.splitOverall.Panel2.Controls.Add(Me.llblUnSelectStudents)
        Me.splitOverall.Panel2.Controls.Add(Me.txtStudentFilter)
        Me.splitOverall.Panel2.Controls.Add(Me.llblClearFilter)
        Me.splitOverall.Panel2.Controls.Add(Me.llblSelectStudents)
        Me.splitOverall.Panel2.Controls.Add(Me.KryptonLabel2)
        Me.splitOverall.Size = New System.Drawing.Size(1255, 597)
        Me.splitOverall.SplitterDistance = 211
        Me.splitOverall.TabIndex = 28
        '
        'txtLinkAddress
        '
        Me.txtLinkAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLinkAddress.Location = New System.Drawing.Point(49, 172)
        Me.txtLinkAddress.Name = "txtLinkAddress"
        Me.txtLinkAddress.Size = New System.Drawing.Size(157, 19)
        Me.txtLinkAddress.TabIndex = 62
        '
        'llblCreateLink
        '
        Me.llblCreateLink.Location = New System.Drawing.Point(8, 174)
        Me.llblCreateLink.Name = "llblCreateLink"
        Me.llblCreateLink.Size = New System.Drawing.Size(39, 19)
        Me.llblCreateLink.TabIndex = 61
        Me.llblCreateLink.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblCreateLink.Values.Text = "Link:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(116, 570)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 25)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        Me.btnCancel.Visible = False
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(3, 117)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(107, 19)
        Me.KryptonLabel8.TabIndex = 44
        Me.KryptonLabel8.Values.Text = "hours from now."
        '
        'nudSendInXHours
        '
        Me.nudSendInXHours.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudSendInXHours.Location = New System.Drawing.Point(146, 89)
        Me.nudSendInXHours.Name = "nudSendInXHours"
        Me.nudSendInXHours.Size = New System.Drawing.Size(58, 21)
        Me.nudSendInXHours.TabIndex = 43
        Me.nudSendInXHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSendInXHours.ThousandsSeparator = True
        Me.nudSendInXHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(4, 196)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(94, 19)
        Me.KryptonLabel7.TabIndex = 42
        Me.KryptonLabel7.Values.Text = "Message text:"
        '
        'txtEmailTrailingText
        '
        Me.txtEmailTrailingText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailTrailingText.Location = New System.Drawing.Point(0, 222)
        Me.txtEmailTrailingText.Multiline = True
        Me.txtEmailTrailingText.Name = "txtEmailTrailingText"
        Me.txtEmailTrailingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEmailTrailingText.Size = New System.Drawing.Size(208, 238)
        Me.txtEmailTrailingText.TabIndex = 41
        '
        'lblSendingStatus
        '
        Me.lblSendingStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSendingStatus.Location = New System.Drawing.Point(8, 546)
        Me.lblSendingStatus.Name = "lblSendingStatus"
        Me.lblSendingStatus.Size = New System.Drawing.Size(6, 2)
        Me.lblSendingStatus.TabIndex = 40
        Me.lblSendingStatus.Values.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 493)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(204, 23)
        Me.ProgressBar1.TabIndex = 39
        Me.ProgressBar1.Visible = False
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(3, 91)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(56, 19)
        Me.KryptonLabel5.TabIndex = 34
        Me.KryptonLabel5.Values.Text = "Send in"
        '
        'nudEmailSendingAccount
        '
        Me.nudEmailSendingAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudEmailSendingAccount.Location = New System.Drawing.Point(161, 8)
        Me.nudEmailSendingAccount.Name = "nudEmailSendingAccount"
        Me.nudEmailSendingAccount.Size = New System.Drawing.Size(43, 21)
        Me.nudEmailSendingAccount.TabIndex = 28
        Me.nudEmailSendingAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubject
        '
        Me.txtSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubject.Location = New System.Drawing.Point(3, 61)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(201, 19)
        Me.txtSubject.TabIndex = 29
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 40)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(59, 19)
        Me.KryptonLabel3.TabIndex = 32
        Me.KryptonLabel3.Values.Text = "Subject:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 10)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(114, 19)
        Me.KryptonLabel1.TabIndex = 31
        Me.KryptonLabel1.Values.Text = "Sending account:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(8, 143)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(196, 25)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&Send Selected"
        '
        'llblMakeQuiz
        '
        Me.llblMakeQuiz.Location = New System.Drawing.Point(98, 40)
        Me.llblMakeQuiz.Name = "llblMakeQuiz"
        Me.llblMakeQuiz.Size = New System.Drawing.Size(106, 19)
        Me.llblMakeQuiz.TabIndex = 63
        Me.llblMakeQuiz.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblMakeQuiz.Values.Text = "Load quiz name"
        '
        'lblRecipientCount
        '
        Me.lblRecipientCount.Location = New System.Drawing.Point(328, -1)
        Me.lblRecipientCount.Name = "lblRecipientCount"
        Me.lblRecipientCount.Size = New System.Drawing.Size(88, 19)
        Me.lblRecipientCount.TabIndex = 33
        Me.lblRecipientCount.Values.Text = "Recipients: 0"
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn5)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn9)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvStudents.CellEditUseWholeCell = False
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn7, Me.OlvColumn4, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn8, Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn9})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "No students, check filter and Submission menu"
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HasCollapsibleGroups = False
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 19)
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(1039, 578)
        Me.olvStudents.TabIndex = 3
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "Selected"
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Text = "Selected"
        Me.OlvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Width = 90
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Student.AdminNumber"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Admin"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Student.LocalName"
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.Width = 150
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Student.Nickname"
        Me.OlvColumn2.Text = "Nickname"
        Me.OlvColumn2.Width = 108
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Student.StudentID"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 90
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "Student.Hidden"
        Me.OlvColumn8.CheckBoxes = True
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "Hidden"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "Student.EmailAddress"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "Email"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Width = 120
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "Student.Tags"
        Me.OlvColumn6.Text = "Tags"
        Me.OlvColumn6.Width = 150
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "ProcessStatus"
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Text = "Status"
        Me.OlvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Width = 157
        '
        'llblUnSelectStudents
        '
        Me.llblUnSelectStudents.Location = New System.Drawing.Point(261, 2)
        Me.llblUnSelectStudents.Name = "llblUnSelectStudents"
        Me.llblUnSelectStudents.Size = New System.Drawing.Size(22, 18)
        Me.llblUnSelectStudents.TabIndex = 16
        Me.llblUnSelectStudents.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.llblUnSelectStudents.Values.Text = ""
        '
        'txtStudentFilter
        '
        Me.txtStudentFilter.Location = New System.Drawing.Point(62, 0)
        Me.txtStudentFilter.Name = "txtStudentFilter"
        Me.txtStudentFilter.Size = New System.Drawing.Size(117, 19)
        Me.txtStudentFilter.TabIndex = 25
        '
        'llblClearFilter
        '
        Me.llblClearFilter.Location = New System.Drawing.Point(180, 1)
        Me.llblClearFilter.Name = "llblClearFilter"
        Me.llblClearFilter.Size = New System.Drawing.Size(22, 18)
        Me.llblClearFilter.TabIndex = 23
        Me.llblClearFilter.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblClearFilter.Values.Text = ""
        '
        'llblSelectStudents
        '
        Me.llblSelectStudents.Location = New System.Drawing.Point(233, 3)
        Me.llblSelectStudents.Name = "llblSelectStudents"
        Me.llblSelectStudents.Size = New System.Drawing.Size(22, 18)
        Me.llblSelectStudents.TabIndex = 17
        Me.llblSelectStudents.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.llblSelectStudents.Values.Text = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(1039, 19)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Values.Text = "Students:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem24})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1255, 24)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem2.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem25})
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem24.Text = "&Help"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem25.Text = "&About"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tmrFilterStudents
        '
        Me.tmrFilterStudents.Interval = 200
        '
        'BulkEmailer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 621)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BulkEmailer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bulk Emailer"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel4.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.Panel1.ResumeLayout(False)
        Me.splitOverall.Panel1.PerformLayout()
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.Panel2.ResumeLayout(False)
        Me.splitOverall.Panel2.PerformLayout()
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.ResumeLayout(False)
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
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
    Friend WithEvents KryptonPanel4 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents splitOverall As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudSendInXHours As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmailTrailingText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblSendingStatus As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudEmailSendingAccount As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents txtSubject As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents llblUnSelectStudents As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents txtStudentFilter As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblClearFilter As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblSelectStudents As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents tmrFilterStudents As System.Windows.Forms.Timer
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents llblCreateLink As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents txtLinkAddress As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblMakeQuiz As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents lblRecipientCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
