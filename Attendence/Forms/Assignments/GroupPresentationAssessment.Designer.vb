<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupPresentationAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupPresentationAssessment))
        Me.IndividualMarkInGroupPresentation1 = New Teaching.IndividualMarkInGroupPresentation()
        Me.SuspendLayout()
        '
        'IndividualMarkInGroupPresentation1
        '
        Me.IndividualMarkInGroupPresentation1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndividualMarkInGroupPresentation1.Location = New System.Drawing.Point(13, 13)
        Me.IndividualMarkInGroupPresentation1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IndividualMarkInGroupPresentation1.Name = "IndividualMarkInGroupPresentation1"
        Me.IndividualMarkInGroupPresentation1.Size = New System.Drawing.Size(515, 330)
        Me.IndividualMarkInGroupPresentation1.TabIndex = 0
        '
        'GroupPresentationAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 436)
        Me.Controls.Add(Me.IndividualMarkInGroupPresentation1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GroupPresentationAssessment"
        Me.Text = "Group Presentation Assessment"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IndividualMarkInGroupPresentation1 As Teaching.IndividualMarkInGroupPresentation
End Class
