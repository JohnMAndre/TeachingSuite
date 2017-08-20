<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportTeachingAppExportFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportTeachingAppExportFile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowseForExportFile = New System.Windows.Forms.Button()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDataSample = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Step 1: Browse for the import file"
        '
        'btnBrowseForExportFile
        '
        Me.btnBrowseForExportFile.Location = New System.Drawing.Point(254, 15)
        Me.btnBrowseForExportFile.Name = "btnBrowseForExportFile"
        Me.btnBrowseForExportFile.Size = New System.Drawing.Size(193, 27)
        Me.btnBrowseForExportFile.TabIndex = 6
        Me.btnBrowseForExportFile.Tag = ""
        Me.btnBrowseForExportFile.Text = "&Browse for import file"
        Me.btnBrowseForExportFile.UseVisualStyleBackColor = True
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoadFile.Location = New System.Drawing.Point(185, 380)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(150, 27)
        Me.btnLoadFile.TabIndex = 9
        Me.btnLoadFile.Tag = "Click to browse to the file to use"
        Me.btnLoadFile.Text = "&Import data"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Data:"
        '
        'lblDataSample
        '
        Me.lblDataSample.AutoSize = True
        Me.lblDataSample.Location = New System.Drawing.Point(88, 52)
        Me.lblDataSample.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataSample.Name = "lblDataSample"
        Me.lblDataSample.Size = New System.Drawing.Size(0, 18)
        Me.lblDataSample.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 384)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Step 2: Import the data"
        '
        'ImportTeachingAppExportFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 419)
        Me.Controls.Add(Me.lblDataSample)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowseForExportFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ImportTeachingAppExportFile"
        Me.Text = "Import Teaching App Export File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseForExportFile As System.Windows.Forms.Button
    Friend WithEvents btnLoadFile As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDataSample As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
