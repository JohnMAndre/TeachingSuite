<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportToTeachingAppExportFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportToTeachingAppExportFile))
        Me.lblExportCaption = New System.Windows.Forms.Label()
        Me.btnBrowseForExportFile = New System.Windows.Forms.Button()
        Me.txtOutputFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblExporting = New System.Windows.Forms.Label()
        Me.cboExportType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddAttendanceDate = New System.Windows.Forms.Button()
        Me.lstSelectedAttendanceDates = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstAvailableAttendanceDates = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExportCaption
        '
        Me.lblExportCaption.AutoSize = True
        Me.lblExportCaption.Location = New System.Drawing.Point(18, 12)
        Me.lblExportCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExportCaption.Name = "lblExportCaption"
        Me.lblExportCaption.Size = New System.Drawing.Size(82, 18)
        Me.lblExportCaption.TabIndex = 1
        Me.lblExportCaption.Text = "Exporting: "
        '
        'btnBrowseForExportFile
        '
        Me.btnBrowseForExportFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseForExportFile.Location = New System.Drawing.Point(623, 94)
        Me.btnBrowseForExportFile.Name = "btnBrowseForExportFile"
        Me.btnBrowseForExportFile.Size = New System.Drawing.Size(36, 23)
        Me.btnBrowseForExportFile.TabIndex = 3
        Me.btnBrowseForExportFile.Tag = "Click to browse to the file to use"
        Me.btnBrowseForExportFile.Text = "..."
        Me.btnBrowseForExportFile.UseVisualStyleBackColor = True
        '
        'txtOutputFile
        '
        Me.txtOutputFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputFile.Location = New System.Drawing.Point(106, 94)
        Me.txtOutputFile.Name = "txtOutputFile"
        Me.txtOutputFile.Size = New System.Drawing.Size(509, 26)
        Me.txtOutputFile.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filename:"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(357, 372)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(77, 27)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Tag = "Click to browse to the file to use"
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(253, 372)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 27)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Tag = "Click to browse to the file to use"
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblExporting
        '
        Me.lblExporting.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblExporting.AutoSize = True
        Me.lblExporting.Location = New System.Drawing.Point(361, 377)
        Me.lblExporting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExporting.Name = "lblExporting"
        Me.lblExporting.Size = New System.Drawing.Size(74, 18)
        Me.lblExporting.TabIndex = 11
        Me.lblExporting.Text = "Exporting"
        Me.lblExporting.Visible = False
        '
        'cboExportType
        '
        Me.cboExportType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExportType.FormattingEnabled = True
        Me.cboExportType.Items.AddRange(New Object() {"Tabular (to use as spreadsheet)", "XML (for import into Teaching App)"})
        Me.cboExportType.Location = New System.Drawing.Point(108, 54)
        Me.cboExportType.Name = "cboExportType"
        Me.cboExportType.Size = New System.Drawing.Size(507, 26)
        Me.cboExportType.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Export type:"
        '
        'btnAddAttendanceDate
        '
        Me.btnAddAttendanceDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAttendanceDate.AutoSize = True
        Me.btnAddAttendanceDate.Location = New System.Drawing.Point(327, 215)
        Me.btnAddAttendanceDate.Name = "btnAddAttendanceDate"
        Me.btnAddAttendanceDate.Size = New System.Drawing.Size(79, 28)
        Me.btnAddAttendanceDate.TabIndex = 14
        Me.btnAddAttendanceDate.Tag = "Click to browse to the file to use"
        Me.btnAddAttendanceDate.Text = "&Add"
        Me.btnAddAttendanceDate.UseVisualStyleBackColor = True
        '
        'lstSelectedAttendanceDates
        '
        Me.lstSelectedAttendanceDates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSelectedAttendanceDates.FormattingEnabled = True
        Me.lstSelectedAttendanceDates.ItemHeight = 18
        Me.lstSelectedAttendanceDates.Location = New System.Drawing.Point(439, 174)
        Me.lstSelectedAttendanceDates.Name = "lstSelectedAttendanceDates"
        Me.lstSelectedAttendanceDates.Size = New System.Drawing.Size(198, 166)
        Me.lstSelectedAttendanceDates.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Attendance dates to include"
        '
        'lstAvailableAttendanceDates
        '
        Me.lstAvailableAttendanceDates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAvailableAttendanceDates.FormattingEnabled = True
        Me.lstAvailableAttendanceDates.ItemHeight = 18
        Me.lstAvailableAttendanceDates.Location = New System.Drawing.Point(106, 174)
        Me.lstAvailableAttendanceDates.Name = "lstAvailableAttendanceDates"
        Me.lstAvailableAttendanceDates.Size = New System.Drawing.Size(199, 166)
        Me.lstAvailableAttendanceDates.TabIndex = 17
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.AutoSize = True
        Me.btnRemove.Location = New System.Drawing.Point(327, 278)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(79, 28)
        Me.btnRemove.TabIndex = 18
        Me.btnRemove.Tag = "Click to browse to the file to use"
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Attendance dates available"
        '
        'ExportToTeachingAppExportFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 411)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstAvailableAttendanceDates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSelectedAttendanceDates)
        Me.Controls.Add(Me.btnAddAttendanceDate)
        Me.Controls.Add(Me.cboExportType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOutputFile)
        Me.Controls.Add(Me.btnBrowseForExportFile)
        Me.Controls.Add(Me.lblExportCaption)
        Me.Controls.Add(Me.lblExporting)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ExportToTeachingAppExportFile"
        Me.Text = "Exporting student results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblExportCaption As System.Windows.Forms.Label
    Friend WithEvents btnBrowseForExportFile As System.Windows.Forms.Button
    Friend WithEvents txtOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblExporting As System.Windows.Forms.Label
    Friend WithEvents cboExportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddAttendanceDate As System.Windows.Forms.Button
    Friend WithEvents lstSelectedAttendanceDates As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstAvailableAttendanceDates As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
