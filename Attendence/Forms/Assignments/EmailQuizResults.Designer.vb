<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailQuizResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmailQuizResults))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvQuizDetails = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolRecordType = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn15 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn16 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn17 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn18 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn19 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.txtOutput = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtQuizName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.llblViewQuizResultsFolder = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtEmailTrailingText = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudSendInXHours = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.nudEmailSendingAccount = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.olvQuizDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.olvQuizDetails)
        Me.KryptonPanel.Controls.Add(Me.txtOutput)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(986, 405)
        Me.KryptonPanel.TabIndex = 0
        '
        'olvQuizDetails
        '
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn6)
        Me.olvQuizDetails.AllColumns.Add(Me.olvcolRecordType)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn8)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn9)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn10)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn12)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn14)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn15)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn16)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn17)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn18)
        Me.olvQuizDetails.AllColumns.Add(Me.OlvColumn19)
        Me.olvQuizDetails.AllowColumnReorder = True
        Me.olvQuizDetails.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvQuizDetails.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only
        Me.olvQuizDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn6, Me.olvcolRecordType, Me.OlvColumn8, Me.OlvColumn9, Me.OlvColumn10, Me.OlvColumn12, Me.OlvColumn14, Me.OlvColumn15, Me.OlvColumn16, Me.OlvColumn17, Me.OlvColumn18, Me.OlvColumn19})
        Me.olvQuizDetails.CopySelectionOnControlC = False
        Me.olvQuizDetails.CopySelectionOnControlCUsesDragSource = False
        Me.olvQuizDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvQuizDetails.EmptyListMsg = "Copy and paste from spreadsheet."
        Me.olvQuizDetails.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvQuizDetails.FullRowSelect = True
        Me.olvQuizDetails.GridLines = True
        Me.olvQuizDetails.HasCollapsibleGroups = False
        Me.olvQuizDetails.HideSelection = False
        Me.olvQuizDetails.Location = New System.Drawing.Point(0, 32)
        Me.olvQuizDetails.Name = "olvQuizDetails"
        Me.olvQuizDetails.OwnerDraw = True
        Me.olvQuizDetails.ShowGroups = False
        Me.olvQuizDetails.ShowImagesOnSubItems = True
        Me.olvQuizDetails.ShowItemCountOnGroups = True
        Me.olvQuizDetails.Size = New System.Drawing.Size(748, 220)
        Me.olvQuizDetails.TabIndex = 8
        Me.olvQuizDetails.UseAlternatingBackColors = True
        Me.olvQuizDetails.UseCompatibleStateImageBehavior = False
        Me.olvQuizDetails.UseFiltering = True
        Me.olvQuizDetails.UseSubItemCheckBoxes = True
        Me.olvQuizDetails.View = System.Windows.Forms.View.Details
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "Identifier"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.Text = "ID"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'olvcolRecordType
        '
        Me.olvcolRecordType.AspectName = "RecordType"
        Me.olvcolRecordType.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvcolRecordType.Text = "Type"
        Me.olvcolRecordType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "Question1"
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Text = "1"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "Question2"
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Text = "2"
        Me.OlvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "Question3"
        Me.OlvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.Text = "3"
        Me.OlvColumn10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "Question4"
        Me.OlvColumn12.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.Text = "4"
        Me.OlvColumn12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "Question5"
        Me.OlvColumn14.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn14.Text = "5"
        Me.OlvColumn14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "Question6"
        Me.OlvColumn15.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn15.Text = "6"
        Me.OlvColumn15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "Question7"
        Me.OlvColumn16.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn16.Text = "7"
        Me.OlvColumn16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "Question8"
        Me.OlvColumn17.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Text = "8"
        Me.OlvColumn17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn18
        '
        Me.OlvColumn18.AspectName = "Question9"
        Me.OlvColumn18.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn18.Text = "9"
        Me.OlvColumn18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn19
        '
        Me.OlvColumn19.AspectName = "Question10"
        Me.OlvColumn19.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn19.Text = "10"
        Me.OlvColumn19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutput
        '
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtOutput.Location = New System.Drawing.Point(748, 32)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(238, 220)
        Me.txtOutput.TabIndex = 7
        Me.txtOutput.Text = "Results will be written here."
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.txtQuizName)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(986, 32)
        Me.KryptonPanel2.TabIndex = 6
        '
        'txtQuizName
        '
        Me.txtQuizName.Location = New System.Drawing.Point(97, 3)
        Me.txtQuizName.Name = "txtQuizName"
        Me.txtQuizName.Size = New System.Drawing.Size(243, 20)
        Me.txtQuizName.TabIndex = 30
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(87, 20)
        Me.KryptonLabel1.TabIndex = 29
        Me.KryptonLabel1.Values.Text = "Name of quiz:"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.llblViewQuizResultsFolder)
        Me.KryptonPanel1.Controls.Add(Me.txtEmailTrailingText)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.nudSendInXHours)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.nudEmailSendingAccount)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.btnOK)
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 252)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(986, 153)
        Me.KryptonPanel1.TabIndex = 5
        '
        'llblViewQuizResultsFolder
        '
        Me.llblViewQuizResultsFolder.Location = New System.Drawing.Point(4, 67)
        Me.llblViewQuizResultsFolder.Name = "llblViewQuizResultsFolder"
        Me.llblViewQuizResultsFolder.Size = New System.Drawing.Size(137, 20)
        Me.llblViewQuizResultsFolder.TabIndex = 54
        Me.llblViewQuizResultsFolder.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblViewQuizResultsFolder.Values.Text = "View quiz results folder"
        '
        'txtEmailTrailingText
        '
        Me.txtEmailTrailingText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailTrailingText.Location = New System.Drawing.Point(249, 25)
        Me.txtEmailTrailingText.Multiline = True
        Me.txtEmailTrailingText.Name = "txtEmailTrailingText"
        Me.txtEmailTrailingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEmailTrailingText.Size = New System.Drawing.Size(725, 116)
        Me.txtEmailTrailingText.TabIndex = 52
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(249, 6)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel7.TabIndex = 53
        Me.KryptonLabel7.Values.Text = "Trailing text:"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(107, 36)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(107, 20)
        Me.KryptonLabel8.TabIndex = 51
        Me.KryptonLabel8.Values.Text = "hour(s) from now."
        '
        'nudSendInXHours
        '
        Me.nudSendInXHours.Location = New System.Drawing.Point(46, 34)
        Me.nudSendInXHours.Name = "nudSendInXHours"
        Me.nudSendInXHours.Size = New System.Drawing.Size(55, 22)
        Me.nudSendInXHours.TabIndex = 50
        Me.nudSendInXHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSendInXHours.ThousandsSeparator = True
        Me.nudSendInXHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(2, 36)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(38, 20)
        Me.KryptonLabel5.TabIndex = 49
        Me.KryptonLabel5.Values.Text = "Send"
        '
        'nudEmailSendingAccount
        '
        Me.nudEmailSendingAccount.Location = New System.Drawing.Point(114, 6)
        Me.nudEmailSendingAccount.Name = "nudEmailSendingAccount"
        Me.nudEmailSendingAccount.Size = New System.Drawing.Size(43, 22)
        Me.nudEmailSendingAccount.TabIndex = 45
        Me.nudEmailSendingAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(4, 6)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(104, 20)
        Me.KryptonLabel4.TabIndex = 47
        Me.KryptonLabel4.Values.Text = "Sending account:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(153, 109)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 32)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&Send"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(38, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 32)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Close"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(986, 24)
        Me.MenuStrip1.TabIndex = 6
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
        'EmailQuizResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 429)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmailQuizResults"
        Me.Text = "Email Quiz Results"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.olvQuizDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtQuizName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtOutput As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudSendInXHours As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents nudEmailSendingAccount As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmailTrailingText As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblViewQuizResultsFolder As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents olvQuizDetails As BrightIdeasSoftware.ObjectListView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolRecordType As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn18 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn19 As BrightIdeasSoftware.OLVColumn
End Class
