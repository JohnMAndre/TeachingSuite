Public Class GroupPresentationAssessment


    Public Sub New(studentList As List(Of Student), asmt As ClassAssignment, attempt As Semester.MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        For Each stud In studentList
            LoadStudent(stud, asmt, attempt)
        Next

        If studentList.Count > 0 Then
            Me.Text &= " - " & studentList(0).StudentTeam
        End If

    End Sub
    Public Sub LoadStudent(stud As Student, asmt As ClassAssignment, attempt As Semester.MarkingTry)
        Dim ctl As New IndividualMarkInGroupPresentation()
        Me.FlowLayoutPanel1.Controls.Add(ctl)
        ctl.LoadStudent(stud, asmt, attempt)
        ctl.BackColor = Color.White
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For Each ctl As IndividualMarkInGroupPresentation In Me.FlowLayoutPanel1.Controls
                ctl.Save()
            Next

            Close()
        Catch ex As Exception
            MessageBox.Show("There was an error saving: " & ex.Message)
        End Try

    End Sub
End Class