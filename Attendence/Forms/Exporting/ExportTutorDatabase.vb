Public Class ExportTutorDatabase
    Private m_objNewSemester As Semester
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub ExportTutorDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_objNewSemester = ThisSemester.Clone()
        lstClassGroups.DataSource = m_objNewSemester.ClassGroups
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim lstToDelete As New List(Of ClassGroup)
        For Each grp As ClassGroup In m_objNewSemester.ClassGroups
            If lstClassGroups.SelectedItems.Contains(grp) Then
                Application.DoEvents()
            Else
                '-- delete this branch
                lstToDelete.Add(grp)
            End If
        Next

        lstClassGroups.DataSource = Nothing

        For Each grp As ClassGroup In lstToDelete
            m_objNewSemester.ClassGroups.Remove(grp)
        Next
        lstClassGroups.DataSource = m_objNewSemester.ClassGroups

        If chkClearTags.Checked Then
            For Each grp As ClassGroup In m_objNewSemester.ClassGroups
                For Each cls As SchoolClass In grp.Classes
                    For Each stud As Student In cls.Students
                        stud.SupressChangeTracking = True '-- do not record this as history (just for tutor database)
                        stud.Tags = String.Empty
                    Next
                Next
            Next
        End If

        Dim sfd As New SaveFileDialog()
        sfd.FileName = m_objNewSemester.Name
        sfd.Filter = "Database files|*.datx"
        If sfd.ShowDialog() = DialogResult.OK Then
            m_objNewSemester.Save(sfd.FileName)
        End If
    End Sub
End Class