Public Class StudentGrades

    Private m_lst As New List(Of Student)

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        Try
            m_lst.Clear()
            For Each grp As ClassGroup In ThisSemester.ClassGroups
                For Each cls As SchoolClass In grp.Classes
                    m_lst.AddRange(cls.Students)
                Next
            Next
            olvData.SetObjects(m_lst)
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the data: " & ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class