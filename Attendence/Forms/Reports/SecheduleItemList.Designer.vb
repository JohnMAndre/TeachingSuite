<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecheduleItemList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecheduleItemList))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.llblLoadUnsentSessions = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblLoadAllSessions = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.olvSchedule = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn29 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn30 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn16 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn31 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn33 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn32 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn17 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn34 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn35 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn36 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.txtFilter = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.llblClearFilter = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tmrFilterSessions = New System.Windows.Forms.Timer(Me.components)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.olvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.llblLoadUnsentSessions)
        Me.KryptonPanel.Controls.Add(Me.llblLoadAllSessions)
        Me.KryptonPanel.Controls.Add(Me.olvSchedule)
        Me.KryptonPanel.Controls.Add(Me.txtFilter)
        Me.KryptonPanel.Controls.Add(Me.llblClearFilter)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(898, 513)
        Me.KryptonPanel.TabIndex = 0
        '
        'llblLoadUnsentSessions
        '
        Me.llblLoadUnsentSessions.Location = New System.Drawing.Point(383, -1)
        Me.llblLoadUnsentSessions.Name = "llblLoadUnsentSessions"
        Me.llblLoadUnsentSessions.Size = New System.Drawing.Size(125, 20)
        Me.llblLoadUnsentSessions.TabIndex = 30
        Me.llblLoadUnsentSessions.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblLoadUnsentSessions.Values.Text = "Load unsent sessions"
        '
        'llblLoadAllSessions
        '
        Me.llblLoadAllSessions.Location = New System.Drawing.Point(231, -1)
        Me.llblLoadAllSessions.Name = "llblLoadAllSessions"
        Me.llblLoadAllSessions.Size = New System.Drawing.Size(101, 20)
        Me.llblLoadAllSessions.TabIndex = 29
        Me.llblLoadAllSessions.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblLoadAllSessions.Values.Text = "Load all sessions"
        '
        'olvSchedule
        '
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn29)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn1)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn30)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn16)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn31)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn33)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn32)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn17)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn34)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn35)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn36)
        Me.olvSchedule.AllowColumnReorder = True
        Me.olvSchedule.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvSchedule.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn29, Me.OlvColumn1, Me.OlvColumn30, Me.OlvColumn16, Me.OlvColumn31, Me.OlvColumn33, Me.OlvColumn32, Me.OlvColumn17, Me.OlvColumn34, Me.OlvColumn35, Me.OlvColumn36})
        Me.olvSchedule.CopySelectionOnControlC = False
        Me.olvSchedule.CopySelectionOnControlCUsesDragSource = False
        Me.olvSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvSchedule.EmptyListMsg = "Nothing scheduled for this day"
        Me.olvSchedule.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvSchedule.FullRowSelect = True
        Me.olvSchedule.GridLines = True
        Me.olvSchedule.HasCollapsibleGroups = False
        Me.olvSchedule.HideSelection = False
        Me.olvSchedule.Location = New System.Drawing.Point(0, 20)
        Me.olvSchedule.MultiSelect = False
        Me.olvSchedule.Name = "olvSchedule"
        Me.olvSchedule.OwnerDraw = True
        Me.olvSchedule.SelectAllOnControlA = False
        Me.olvSchedule.ShowGroups = False
        Me.olvSchedule.ShowImagesOnSubItems = True
        Me.olvSchedule.ShowItemCountOnGroups = True
        Me.olvSchedule.Size = New System.Drawing.Size(898, 493)
        Me.olvSchedule.TabIndex = 29
        Me.olvSchedule.UseAlternatingBackColors = True
        Me.olvSchedule.UseCompatibleStateImageBehavior = False
        Me.olvSchedule.UseFiltering = True
        Me.olvSchedule.UseSubItemCheckBoxes = True
        Me.olvSchedule.View = System.Windows.Forms.View.Details
        '
        'OlvColumn29
        '
        Me.OlvColumn29.AspectName = "StartDateTime.DayOfWeek"
        Me.OlvColumn29.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn29.Text = "Day"
        Me.OlvColumn29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn30
        '
        Me.OlvColumn30.AspectName = "StartDateTime"
        Me.OlvColumn30.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn30.Text = "Starts"
        Me.OlvColumn30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn30.Width = 150
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "SchoolClass.ClassGroup.Name"
        Me.OlvColumn16.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn16.Text = "Module"
        Me.OlvColumn16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn16.Width = 100
        '
        'OlvColumn31
        '
        Me.OlvColumn31.AspectName = "SchoolClass"
        Me.OlvColumn31.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn31.Text = "Class"
        Me.OlvColumn31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn31.Width = 117
        '
        'OlvColumn33
        '
        Me.OlvColumn33.AspectName = "SessionNumber"
        Me.OlvColumn33.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn33.Text = "Session"
        Me.OlvColumn33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn32
        '
        Me.OlvColumn32.AspectName = "Topic"
        Me.OlvColumn32.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn32.Text = "Topic"
        Me.OlvColumn32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn32.Width = 124
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "Location"
        Me.OlvColumn17.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Text = "Location"
        Me.OlvColumn17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Width = 75
        '
        'OlvColumn34
        '
        Me.OlvColumn34.AspectName = "Notes"
        Me.OlvColumn34.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn34.Text = "Notes"
        Me.OlvColumn34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn35
        '
        Me.OlvColumn35.AspectName = "Prepped"
        Me.OlvColumn35.CheckBoxes = True
        Me.OlvColumn35.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn35.Text = "Prepped"
        Me.OlvColumn35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn36
        '
        Me.OlvColumn36.AspectName = "StudentsEmailed"
        Me.OlvColumn36.CheckBoxes = True
        Me.OlvColumn36.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn36.Text = "Sent"
        Me.OlvColumn36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(39, 0)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(147, 20)
        Me.txtFilter.TabIndex = 28
        '
        'llblClearFilter
        '
        Me.llblClearFilter.Location = New System.Drawing.Point(187, 1)
        Me.llblClearFilter.Name = "llblClearFilter"
        Me.llblClearFilter.Size = New System.Drawing.Size(22, 18)
        Me.llblClearFilter.TabIndex = 27
        Me.llblClearFilter.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblClearFilter.Values.Text = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(898, 20)
        Me.KryptonLabel2.TabIndex = 26
        Me.KryptonLabel2.Values.Text = "Filter:"
        '
        'tmrFilterSessions
        '
        Me.tmrFilterSessions.Interval = 200
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "DaysInFuture"
        Me.OlvColumn1.AspectToStringFormat = "{0:N0}"
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Text = "Days"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecheduleItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 513)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SecheduleItemList"
        Me.Text = "Secheduled Sessions"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.olvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtFilter As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents llblClearFilter As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents olvSchedule As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn29 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn30 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn31 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn33 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn32 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn34 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn35 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn36 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents llblLoadUnsentSessions As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblLoadAllSessions As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents tmrFilterSessions As System.Windows.Forms.Timer
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
End Class
