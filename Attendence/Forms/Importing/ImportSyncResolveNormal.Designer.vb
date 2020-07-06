<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportSyncResolveNormal
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
        Me.lstStudentID = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblExistingPoints = New System.Windows.Forms.Label()
        Me.lblImportPoints = New System.Windows.Forms.Label()
        Me.lblExistingOverall = New System.Windows.Forms.Label()
        Me.lblExistingImprovement = New System.Windows.Forms.Label()
        Me.lblImportImprovement = New System.Windows.Forms.Label()
        Me.lblImportOverall = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUseExisting = New System.Windows.Forms.Button()
        Me.btnUseImport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstStudentID
        '
        Me.lstStudentID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstStudentID.FormattingEnabled = True
        Me.lstStudentID.ItemHeight = 16
        Me.lstStudentID.Location = New System.Drawing.Point(14, 41)
        Me.lstStudentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstStudentID.Name = "lstStudentID"
        Me.lstStudentID.Size = New System.Drawing.Size(130, 388)
        Me.lstStudentID.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "2nd try points:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Overall:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Improvement:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(153, 11)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(0, 16)
        Me.lblStudentName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Existing"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(603, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "To import"
        '
        'lblExistingPoints
        '
        Me.lblExistingPoints.AutoSize = True
        Me.lblExistingPoints.Location = New System.Drawing.Point(297, 66)
        Me.lblExistingPoints.Name = "lblExistingPoints"
        Me.lblExistingPoints.Size = New System.Drawing.Size(26, 16)
        Me.lblExistingPoints.TabIndex = 7
        Me.lblExistingPoints.Text = "-10"
        '
        'lblImportPoints
        '
        Me.lblImportPoints.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImportPoints.AutoSize = True
        Me.lblImportPoints.Location = New System.Drawing.Point(610, 66)
        Me.lblImportPoints.Name = "lblImportPoints"
        Me.lblImportPoints.Size = New System.Drawing.Size(26, 16)
        Me.lblImportPoints.TabIndex = 10
        Me.lblImportPoints.Text = "-10"
        '
        'lblExistingOverall
        '
        Me.lblExistingOverall.BackColor = System.Drawing.Color.White
        Me.lblExistingOverall.Location = New System.Drawing.Point(248, 104)
        Me.lblExistingOverall.Name = "lblExistingOverall"
        Me.lblExistingOverall.Size = New System.Drawing.Size(224, 65)
        Me.lblExistingOverall.TabIndex = 11
        '
        'lblExistingImprovement
        '
        Me.lblExistingImprovement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExistingImprovement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblExistingImprovement.Location = New System.Drawing.Point(248, 183)
        Me.lblExistingImprovement.Name = "lblExistingImprovement"
        Me.lblExistingImprovement.Size = New System.Drawing.Size(224, 235)
        Me.lblExistingImprovement.TabIndex = 12
        '
        'lblImportImprovement
        '
        Me.lblImportImprovement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImportImprovement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblImportImprovement.Location = New System.Drawing.Point(479, 183)
        Me.lblImportImprovement.Name = "lblImportImprovement"
        Me.lblImportImprovement.Size = New System.Drawing.Size(263, 235)
        Me.lblImportImprovement.TabIndex = 14
        '
        'lblImportOverall
        '
        Me.lblImportOverall.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImportOverall.BackColor = System.Drawing.Color.White
        Me.lblImportOverall.Location = New System.Drawing.Point(479, 104)
        Me.lblImportOverall.Name = "lblImportOverall"
        Me.lblImportOverall.Size = New System.Drawing.Size(263, 65)
        Me.lblImportOverall.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Student ID"
        '
        'btnUseExisting
        '
        Me.btnUseExisting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUseExisting.Location = New System.Drawing.Point(252, 439)
        Me.btnUseExisting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUseExisting.Name = "btnUseExisting"
        Me.btnUseExisting.Size = New System.Drawing.Size(220, 32)
        Me.btnUseExisting.TabIndex = 16
        Me.btnUseExisting.Text = "Use &existing"
        Me.btnUseExisting.UseVisualStyleBackColor = True
        '
        'btnUseImport
        '
        Me.btnUseImport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUseImport.Location = New System.Drawing.Point(483, 439)
        Me.btnUseImport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUseImport.Name = "btnUseImport"
        Me.btnUseImport.Size = New System.Drawing.Size(258, 32)
        Me.btnUseImport.TabIndex = 17
        Me.btnUseImport.Text = "Use &import"
        Me.btnUseImport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(12, 439)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(132, 32)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ImportSyncResolveNormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 490)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUseImport)
        Me.Controls.Add(Me.btnUseExisting)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblImportImprovement)
        Me.Controls.Add(Me.lblImportOverall)
        Me.Controls.Add(Me.lblExistingImprovement)
        Me.Controls.Add(Me.lblExistingOverall)
        Me.Controls.Add(Me.lblImportPoints)
        Me.Controls.Add(Me.lblExistingPoints)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstStudentID)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImportSyncResolveNormal"
        Me.Text = "Normal Asmt Sync Resolver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStudentID As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblExistingPoints As Label
    Friend WithEvents lblImportPoints As Label
    Friend WithEvents lblExistingOverall As Label
    Friend WithEvents lblExistingImprovement As Label
    Friend WithEvents lblImportImprovement As Label
    Friend WithEvents lblImportOverall As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnUseExisting As Button
    Friend WithEvents btnUseImport As Button
    Friend WithEvents btnClose As Button
End Class
