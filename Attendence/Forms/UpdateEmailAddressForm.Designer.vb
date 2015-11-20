<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateEmailAddressForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateEmailAddressForm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.btnPreview = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.lblStudentsUpdated = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNewEmailAddress = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtOldEmailAddress = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.picStudent)
        Me.KryptonPanel.Controls.Add(Me.btnPreview)
        Me.KryptonPanel.Controls.Add(Me.olvStudents)
        Me.KryptonPanel.Controls.Add(Me.lblStudentsUpdated)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.txtNewEmailAddress)
        Me.KryptonPanel.Controls.Add(Me.txtOldEmailAddress)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(611, 396)
        Me.KryptonPanel.TabIndex = 0
        '
        'picStudent
        '
        Me.picStudent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picStudent.Location = New System.Drawing.Point(311, 12)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(297, 200)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStudent.TabIndex = 92
        Me.picStudent.TabStop = False
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(215, 172)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(90, 25)
        Me.btnPreview.TabIndex = 49
        Me.btnPreview.Values.Image = Global.Teaching.My.Resources.Resources.detective_16
        Me.btnPreview.Values.Text = "&Preview"
        '
        'olvStudents
        '
        Me.olvStudents.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn4, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3})
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.Location = New System.Drawing.Point(0, 218)
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.Size = New System.Drawing.Size(611, 178)
        Me.olvStudents.TabIndex = 91
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "EmailAddress"
        Me.OlvColumn4.Text = "Email"
        Me.OlvColumn4.Width = 200
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "SchoolClass.Name"
        Me.OlvColumn1.Text = "Class"
        Me.OlvColumn1.Width = 120
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "LocalName"
        Me.OlvColumn2.Text = "Name"
        Me.OlvColumn2.Width = 130
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Nickname"
        Me.OlvColumn3.Text = "Nickname"
        Me.OlvColumn3.Width = 130
        '
        'lblStudentsUpdated
        '
        Me.lblStudentsUpdated.Location = New System.Drawing.Point(167, 64)
        Me.lblStudentsUpdated.Name = "lblStudentsUpdated"
        Me.lblStudentsUpdated.Size = New System.Drawing.Size(10, 20)
        Me.lblStudentsUpdated.TabIndex = 50
        Me.lblStudentsUpdated.Values.Text = " "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 64)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(149, 20)
        Me.KryptonLabel2.TabIndex = 49
        Me.KryptonLabel2.Values.Text = "Student records updated:"
        '
        'txtNewEmailAddress
        '
        Me.txtNewEmailAddress.Location = New System.Drawing.Point(84, 38)
        Me.txtNewEmailAddress.Name = "txtNewEmailAddress"
        Me.txtNewEmailAddress.Size = New System.Drawing.Size(221, 20)
        Me.txtNewEmailAddress.TabIndex = 47
        '
        'txtOldEmailAddress
        '
        Me.txtOldEmailAddress.Location = New System.Drawing.Point(84, 12)
        Me.txtOldEmailAddress.Name = "txtOldEmailAddress"
        Me.txtOldEmailAddress.Size = New System.Drawing.Size(221, 20)
        Me.txtOldEmailAddress.TabIndex = 46
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 38)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel1.TabIndex = 48
        Me.KryptonLabel1.Values.Text = "New email:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel3.TabIndex = 45
        Me.KryptonLabel3.Values.Text = "Old email:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(114, 172)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 25)
        Me.btnOK.TabIndex = 48
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(7, 172)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'UpdateEmailAddressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 396)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateEmailAddressForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Email Address"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblStudentsUpdated As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNewEmailAddress As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtOldEmailAddress As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnPreview As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents picStudent As System.Windows.Forms.PictureBox
End Class
