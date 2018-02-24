Public Class GroupPresentationAssessment

    Public Sub New(studentList As List(Of Student))

        ' This call is required by the designer.
        InitializeComponent()

        For Each stud In studentList
            LoadStudent(stud)
        Next

    End Sub
    Public Sub LoadStudent(stud As Student)
        Dim ctl As New IndividualMarkInGroupPresentation()
        Me.FlowLayoutPanel1.Controls.Add(ctl)
        ctl.LoadStudent(stud)
        ctl.BackColor = Color.White
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MessageBox.Show("Soon, this will save the information.")
    End Sub
End Class