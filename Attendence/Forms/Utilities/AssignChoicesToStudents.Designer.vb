<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignChoicesToStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignChoicesToStudents))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudChoicesPerStudent = New System.Windows.Forms.NumericUpDown()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.dgvChoices = New System.Windows.Forms.DataGridView()
        Me.colChoiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colShortName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLongName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPreferences = New System.Windows.Forms.DataGridView()
        Me.llblLoadPreferences = New System.Windows.Forms.LinkLabel()
        Me.llblLoadChoices = New System.Windows.Forms.LinkLabel()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrefOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colChoiceID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nudChoicesPerStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPreferences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(693, 94)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of choices per student:"
        '
        'nudChoicesPerStudent
        '
        Me.nudChoicesPerStudent.Location = New System.Drawing.Point(250, 85)
        Me.nudChoicesPerStudent.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudChoicesPerStudent.Name = "nudChoicesPerStudent"
        Me.nudChoicesPerStudent.Size = New System.Drawing.Size(87, 26)
        Me.nudChoicesPerStudent.TabIndex = 3
        Me.nudChoicesPerStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudChoicesPerStudent.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(285, 432)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(137, 31)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&Generate file"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'dgvChoices
        '
        Me.dgvChoices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colChoiceID, Me.colShortName, Me.colLongName})
        Me.dgvChoices.Location = New System.Drawing.Point(12, 141)
        Me.dgvChoices.Name = "dgvChoices"
        Me.dgvChoices.Size = New System.Drawing.Size(287, 285)
        Me.dgvChoices.TabIndex = 5
        '
        'colChoiceID
        '
        Me.colChoiceID.DataPropertyName = "ChoiceID"
        Me.colChoiceID.HeaderText = "ID"
        Me.colChoiceID.Name = "colChoiceID"
        '
        'colShortName
        '
        Me.colShortName.DataPropertyName = "ShortName"
        Me.colShortName.HeaderText = "Short"
        Me.colShortName.Name = "colShortName"
        '
        'colLongName
        '
        Me.colLongName.DataPropertyName = "LongName"
        Me.colLongName.HeaderText = "Long"
        Me.colLongName.Name = "colLongName"
        '
        'dgvPreferences
        '
        Me.dgvPreferences.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPreferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPreferences.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStudentID, Me.colGrade, Me.colPrefOrder, Me.colChoiceID2})
        Me.dgvPreferences.Location = New System.Drawing.Point(305, 141)
        Me.dgvPreferences.Name = "dgvPreferences"
        Me.dgvPreferences.Size = New System.Drawing.Size(407, 285)
        Me.dgvPreferences.TabIndex = 6
        '
        'llblLoadPreferences
        '
        Me.llblLoadPreferences.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblLoadPreferences.AutoSize = True
        Me.llblLoadPreferences.Location = New System.Drawing.Point(521, 120)
        Me.llblLoadPreferences.Name = "llblLoadPreferences"
        Me.llblLoadPreferences.Size = New System.Drawing.Size(190, 18)
        Me.llblLoadPreferences.TabIndex = 7
        Me.llblLoadPreferences.TabStop = True
        Me.llblLoadPreferences.Text = "Paste student preferences"
        Me.llblLoadPreferences.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'llblLoadChoices
        '
        Me.llblLoadChoices.AutoSize = True
        Me.llblLoadChoices.Location = New System.Drawing.Point(12, 120)
        Me.llblLoadChoices.Name = "llblLoadChoices"
        Me.llblLoadChoices.Size = New System.Drawing.Size(173, 18)
        Me.llblLoadChoices.TabIndex = 8
        Me.llblLoadChoices.TabStop = True
        Me.llblLoadChoices.Text = "Paste available choices"
        '
        'colStudentID
        '
        Me.colStudentID.DataPropertyName = "StudentID"
        Me.colStudentID.HeaderText = "StudentID"
        Me.colStudentID.Name = "colStudentID"
        Me.colStudentID.Width = 130
        '
        'colGrade
        '
        Me.colGrade.DataPropertyName = "StudentGrade"
        Me.colGrade.HeaderText = "Grade"
        Me.colGrade.Name = "colGrade"
        Me.colGrade.Width = 60
        '
        'colPrefOrder
        '
        Me.colPrefOrder.DataPropertyName = "PreferenceOrder"
        Me.colPrefOrder.HeaderText = "Pref"
        Me.colPrefOrder.Name = "colPrefOrder"
        Me.colPrefOrder.Width = 50
        '
        'colChoiceID2
        '
        Me.colChoiceID2.DataPropertyName = "ChoiceID"
        Me.colChoiceID2.HeaderText = "ID"
        Me.colChoiceID2.Name = "colChoiceID2"
        '
        'AssignChoicesToStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(724, 475)
        Me.Controls.Add(Me.llblLoadChoices)
        Me.Controls.Add(Me.llblLoadPreferences)
        Me.Controls.Add(Me.dgvPreferences)
        Me.Controls.Add(Me.dgvChoices)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.nudChoicesPerStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AssignChoicesToStudents"
        Me.Text = "Assign Choices to Students"
        CType(Me.nudChoicesPerStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPreferences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudChoicesPerStudent As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents dgvChoices As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPreferences As System.Windows.Forms.DataGridView
    Friend WithEvents llblLoadPreferences As System.Windows.Forms.LinkLabel
    Friend WithEvents llblLoadChoices As System.Windows.Forms.LinkLabel
    Friend WithEvents colChoiceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colShortName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLongName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrefOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChoiceID2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
