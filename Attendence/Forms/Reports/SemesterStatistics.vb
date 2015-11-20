Public Class SemesterStatistics

    Private Sub SemesterStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim intClassCount, intAssessmentCount, intStudentCount, intTotalSessions, intFutureSessions As Integer
            lblSemesterName.Text = ThisSemester.Name
            lblModuleCount.Text = ThisSemester.ClassGroups.Count.ToString("#,##0")
            For Each grp As ClassGroup In ThisSemester.ClassGroups
                intAssessmentCount += grp.Assignments.Count
                intAssessmentCount += grp.AssignmentsBTEC.Count
                For Each cls As SchoolClass In grp.Classes
                    intClassCount += 1
                    intStudentCount += cls.Students.Count
                    intTotalSessions += cls.ActualSessions.Count
                Next
            Next

            lblAssessmentCount.Text = intAssessmentCount.ToString("#,##0")
            lblClassCount.Text = intClassCount.ToString("#,##0")
            lblStudentCount.Text = intStudentCount.ToString("#,##0")
            lblTotalSessionCount.Text = intTotalSessions.ToString("#,##0")

        Catch ex As Exception
            MessageBox.Show("There was an error loading the data: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub
End Class