Public Class StudentOutcomeResults

    Private m_classGroup As ClassGroup
    Private m_ocResultList As New List(Of OutcomeResult)

    Public Sub New(classGroup As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_classGroup = classGroup
        LoadOutcomeData()
    End Sub
    Private Sub LoadOutcomeData()
        For Each cls As SchoolClass In m_classGroup.Classes
            For Each stud As Student In cls.Students
                For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                    For Each ocResult As OutcomeResult In asmt.Outcomes
                        m_ocResultList.Add(ocResult)
                    Next
                Next
            Next
        Next

        olvStudents.SetObjects(m_ocResultList)

    End Sub

    Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged
        tmrFilterStudents.Stop()
        tmrFilterStudents.Start()
    End Sub

    Private Sub tmrFilterStudents_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFilterStudents.Tick
        FilterStudents()
    End Sub
    Private Sub FilterStudents()
        Try
            tmrFilterStudents.Stop()

            olvStudents.ModelFilter = New BrightIdeasSoftware.TextMatchFilter(olvStudents, txtFilter.Text)

            If txtFilter.Text.Length = 0 Then
                olvStudents.EmptyListMsg = "This list is empty"
            Else
                olvStudents.EmptyListMsg = "No outcome results match your filter"
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error filtering outcomes: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub llblClearFilter_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearFilter.LinkClicked
        txtFilter.Text = String.Empty
        txtFilter.Focus()
    End Sub

    Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
        EditSelectedStudent()
    End Sub
    Private Sub EditSelectedStudent()
        Using frm As New StudentDetail(CType(olvStudents.SelectedObject, OutcomeResult).Assignment.Student)
            If frm.ShowDialog = DialogResult.OK Then
                olvStudents.RefreshSelectedObjects()
            End If
        End Using
    End Sub

    Private Sub StudentOutcomeResults_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        olvStudents.PrimarySortColumn = olvcolStudentID
        olvStudents.SecondarySortColumn = olvcolOutcomeName
        olvStudents.Sort()
    End Sub
End Class
