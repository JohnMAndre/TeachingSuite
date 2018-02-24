Public Class GroupPresentationAssessment

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ctl As New IndividualMarkInGroupPresentation()
        Me.FlowLayoutPanel1.Controls.Add(ctl)
        Dim stud As Student = Student.GetByStudentID(txtTags.Text)
        ctl.LoadStudent(stud)
        ctl.BackColor = Color.White
    End Sub
End Class