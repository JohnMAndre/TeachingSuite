<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportImprovementItemsFromOtherSemester
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnLoadSemester = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboSemester = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.olvImprovementItems = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnOK = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        CType(Me.cboSemester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.btnLoadSemester)
        Me.KryptonPanel3.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel3.Controls.Add(Me.cboSemester)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 24)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(600, 42)
        Me.KryptonPanel3.TabIndex = 31
        '
        'btnLoadSemester
        '
        Me.btnLoadSemester.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadSemester.Enabled = False
        Me.btnLoadSemester.Location = New System.Drawing.Point(566, 12)
        Me.btnLoadSemester.Name = "btnLoadSemester"
        Me.btnLoadSemester.Size = New System.Drawing.Size(22, 18)
        Me.btnLoadSemester.TabIndex = 23
        Me.btnLoadSemester.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnLoadSemester.Values.Text = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel3.TabIndex = 7
        Me.KryptonLabel3.Values.Text = "Semester:"
        '
        'cboSemester
        '
        Me.cboSemester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.DropDownWidth = 121
        Me.cboSemester.Location = New System.Drawing.Point(82, 11)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(478, 21)
        Me.cboSemester.TabIndex = 6
        '
        'olvImprovementItems
        '
        Me.olvImprovementItems.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn1)
        Me.olvImprovementItems.AllColumns.Add(Me.OlvColumn5)
        Me.olvImprovementItems.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvImprovementItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn5})
        Me.olvImprovementItems.CopySelectionOnControlC = False
        Me.olvImprovementItems.CopySelectionOnControlCUsesDragSource = False
        Me.olvImprovementItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvImprovementItems.EmptyListMsg = "No improvement items"
        Me.olvImprovementItems.FullRowSelect = True
        Me.olvImprovementItems.Location = New System.Drawing.Point(0, 66)
        Me.olvImprovementItems.Name = "olvImprovementItems"
        Me.olvImprovementItems.ShowGroups = False
        Me.olvImprovementItems.ShowImagesOnSubItems = True
        Me.olvImprovementItems.ShowItemToolTips = True
        Me.olvImprovementItems.Size = New System.Drawing.Size(600, 298)
        Me.olvImprovementItems.TabIndex = 92
        Me.olvImprovementItems.UseCompatibleStateImageBehavior = False
        Me.olvImprovementItems.UseFiltering = True
        Me.olvImprovementItems.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Name"
        Me.OlvColumn1.AspectToStringFormat = ""
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.Width = 158
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "Description"
        Me.OlvColumn5.IsEditable = False
        Me.OlvColumn5.Text = "Description"
        Me.OlvColumn5.Width = 210
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.btnOK)
        Me.KryptonPanel2.Controls.Add(Me.btnCancel)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 364)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(600, 41)
        Me.KryptonPanel2.TabIndex = 24
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(319, 10)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 28)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnOK.Values.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(192, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Values.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.btnCancel.Values.Text = "&Cancel"
        '
        'ImportImprovementItemsFromOtherSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 405)
        Me.Controls.Add(Me.olvImprovementItems)
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Controls.Add(Me.KryptonPanel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ImportImprovementItemsFromOtherSemester"
        Me.Text = "Import Improvement Items"
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        Me.KryptonPanel3.PerformLayout()
        CType(Me.cboSemester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olvImprovementItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnLoadSemester As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboSemester As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents olvImprovementItems As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnOK As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
