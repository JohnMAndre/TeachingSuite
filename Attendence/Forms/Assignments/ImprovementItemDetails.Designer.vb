<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprovementItemDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprovementItemDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudOrderingID = New System.Windows.Forms.NumericUpDown()
        Me.cboAssessmentCategory = New System.Windows.Forms.ComboBox()
        Me.llblAddCategory = New System.Windows.Forms.LinkLabel()
        Me.llblDeleteCategory = New System.Windows.Forms.LinkLabel()
        Me.lstAssessmentCategories = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.nudOrderingID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Assessment categories:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(96, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(404, 22)
        Me.txtName.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(96, 40)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(404, 22)
        Me.txtDescription.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Location = New System.Drawing.Point(96, 68)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(404, 22)
        Me.txtID.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ordering:"
        '
        'nudOrderingID
        '
        Me.nudOrderingID.Location = New System.Drawing.Point(96, 96)
        Me.nudOrderingID.Name = "nudOrderingID"
        Me.nudOrderingID.Size = New System.Drawing.Size(73, 22)
        Me.nudOrderingID.TabIndex = 9
        Me.nudOrderingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboAssessmentCategory
        '
        Me.cboAssessmentCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssessmentCategory.FormattingEnabled = True
        Me.cboAssessmentCategory.Location = New System.Drawing.Point(15, 189)
        Me.cboAssessmentCategory.Name = "cboAssessmentCategory"
        Me.cboAssessmentCategory.Size = New System.Drawing.Size(146, 24)
        Me.cboAssessmentCategory.TabIndex = 10
        '
        'llblAddCategory
        '
        Me.llblAddCategory.AutoSize = True
        Me.llblAddCategory.Location = New System.Drawing.Point(76, 216)
        Me.llblAddCategory.Name = "llblAddCategory"
        Me.llblAddCategory.Size = New System.Drawing.Size(85, 16)
        Me.llblAddCategory.TabIndex = 11
        Me.llblAddCategory.TabStop = True
        Me.llblAddCategory.Text = "Add category"
        '
        'llblDeleteCategory
        '
        Me.llblDeleteCategory.AutoSize = True
        Me.llblDeleteCategory.Location = New System.Drawing.Point(63, 245)
        Me.llblDeleteCategory.Name = "llblDeleteCategory"
        Me.llblDeleteCategory.Size = New System.Drawing.Size(98, 16)
        Me.llblDeleteCategory.TabIndex = 12
        Me.llblDeleteCategory.TabStop = True
        Me.llblDeleteCategory.Text = "Delete selected"
        '
        'lstAssessmentCategories
        '
        Me.lstAssessmentCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAssessmentCategories.FormattingEnabled = True
        Me.lstAssessmentCategories.ItemHeight = 16
        Me.lstAssessmentCategories.Location = New System.Drawing.Point(167, 127)
        Me.lstAssessmentCategories.Name = "lstAssessmentCategories"
        Me.lstAssessmentCategories.Size = New System.Drawing.Size(333, 196)
        Me.lstAssessmentCategories.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Location = New System.Drawing.Point(148, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(278, 329)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ImprovementItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 368)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstAssessmentCategories)
        Me.Controls.Add(Me.llblDeleteCategory)
        Me.Controls.Add(Me.llblAddCategory)
        Me.Controls.Add(Me.cboAssessmentCategory)
        Me.Controls.Add(Me.nudOrderingID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImprovementItemDetails"
        Me.Text = "Improvement Item Details"
        CType(Me.nudOrderingID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudOrderingID As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboAssessmentCategory As System.Windows.Forms.ComboBox
    Friend WithEvents llblAddCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents llblDeleteCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents lstAssessmentCategories As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
