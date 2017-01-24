<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendencePublic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendencePublic))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolLocalName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvcolNickname = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvColumnStatus = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.lblClock = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFilterHiddenStudents = New System.Windows.Forms.Timer(Me.components)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.olvStudents)
        Me.KryptonPanel.Controls.Add(Me.lblClock)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1130, 361)
        Me.KryptonPanel.TabIndex = 0
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudents.AllColumns.Add(Me.olvcolLocalName)
        Me.olvStudents.AllColumns.Add(Me.olvcolNickname)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudents.AllColumns.Add(Me.olvColumnStatus)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvStudents.CellEditUseWholeCell = False
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn8, Me.olvcolLocalName, Me.olvcolNickname, Me.OlvColumn6, Me.olvColumnStatus, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn1, Me.OlvColumn4})
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.Location = New System.Drawing.Point(0, 0)
        Me.olvStudents.MultiSelect = False
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.SelectedForeColor = System.Drawing.Color.Yellow
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.Size = New System.Drawing.Size(1130, 325)
        Me.olvStudents.TabIndex = 5
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "AdminNumber"
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.IsEditable = False
        Me.OlvColumn8.Text = "#"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.Width = 75
        '
        'olvcolLocalName
        '
        Me.olvcolLocalName.AspectName = "LocalName"
        Me.olvcolLocalName.IsEditable = False
        Me.olvcolLocalName.Text = "Name"
        Me.olvcolLocalName.Width = 350
        '
        'olvcolNickname
        '
        Me.olvcolNickname.AspectName = "Nickname"
        Me.olvcolNickname.IsEditable = False
        Me.olvcolNickname.Text = "Nickname"
        Me.olvcolNickname.Width = 200
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "StudentID"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Student ID"
        Me.OlvColumn6.Width = 225
        '
        'olvColumnStatus
        '
        Me.olvColumnStatus.AspectName = "CurrentAttendenceStatus"
        Me.olvColumnStatus.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.olvColumnStatus.IsEditable = False
        Me.olvColumnStatus.Text = "Status"
        Me.olvColumnStatus.Width = 175
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "CurrentAbsences"
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.IsEditable = False
        Me.OlvColumn2.Text = "Abs"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Width = 62
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "CurrentAbsentPercent"
        Me.OlvColumn3.AspectToStringFormat = "{0:P0}"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.IsEditable = False
        Me.OlvColumn3.Text = "Abs%"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 95
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "DateOfBirth"
        Me.OlvColumn1.AspectToStringFormat = "{0:d}"
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "DoB"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.ToolTipText = "Date of Birth"
        '
        'lblClock
        '
        Me.lblClock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblClock.Location = New System.Drawing.Point(0, 325)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(1130, 36)
        Me.lblClock.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.TabIndex = 48
        Me.lblClock.Values.Text = "Current Time:"
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'tmrFilterHiddenStudents
        '
        Me.tmrFilterHiddenStudents.Enabled = True
        Me.tmrFilterHiddenStudents.Interval = 3000
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "StudentTeam"
        Me.OlvColumn4.Text = "Team"
        '
        'AttendencePublic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 361)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AttendencePublic"
        Me.Text = "Attendence"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolLocalName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvcolNickname As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvColumnStatus As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents lblClock As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents tmrFilterHiddenStudents As System.Windows.Forms.Timer
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
End Class
