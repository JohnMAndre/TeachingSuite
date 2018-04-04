Public Class BaseAssignmentSelector

    Private m_classGroup As ClassGroup

    Public Sub New(classGroup As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = classGroup

    End Sub
    Private Sub BaseAssignmentSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstAssignments.Items.Clear()

        '-- add both BTEC and normal assignments
        For Each objClassAssignment As ClassAssignmentBTEC In m_classGroup.AssignmentsBTEC
            lstAssignments.Items.Add(objClassAssignment)
        Next
        For Each objClassAssignment As ClassAssignment In m_classGroup.Assignments
            lstAssignments.Items.Add(objClassAssignment)
        Next
    End Sub

    Private Sub btnChooseAssignment_Click(sender As Object, e As EventArgs) Handles btnChooseAssignment.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Public ReadOnly Property SelectedAssignment As IClassAssignment
        Get
            Return lstAssignments.Items(lstAssignments.SelectedIndex)
        End Get
    End Property

End Class