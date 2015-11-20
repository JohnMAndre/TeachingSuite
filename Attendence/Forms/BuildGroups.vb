Public Class BuildGroups

    Private m_assignmentStudents As New List(Of Integer)
    Private m_class As SchoolClass

    Public Sub New(cls As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = cls

        olvStudents.SetObjects(m_class.Students)
    End Sub
    Private Sub llblCreateGroups_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblCreateGroups.LinkClicked
        Try
            If nudNumberOfGroups.Value > 1 Then
                '-- Randomly assign members to each group
                Randomize()

                Dim intGroup As Integer
                Dim intBigCounter As Integer
                Dim intNext As Integer
                Dim intLoopCounter As Integer
                Do Until m_assignmentStudents.Count = m_class.Students.Count
                    intBigCounter += 1
                    intGroup = (intBigCounter Mod nudNumberOfGroups.Value) + 1
                    Dim rnd As New Random()
                    Dim intPos As Integer
                    intPos = rnd.Next Mod m_class.Students.Count
                    intLoopCounter = 0
                    Do Until Not m_assignmentStudents.Contains(intPos)
                        '-- keep looking until we get a student not yet assigned to a group
                        intNext = rnd.Next
                        intPos = intNext Mod (m_class.Students.Count)
                        intLoopCounter += 1
                    Loop

                    If m_class.Students(intPos).Tags.Length > 0 Then
                        m_class.Students(intPos).Tags &= " "
                    End If

                    m_class.Students(intPos).Tags &= "Group " & intGroup.ToString()
                    Me.olvStudents.RefreshObject(m_class.Students(intPos))
                    m_assignmentStudents.Add(intPos)
                Loop
                Application.DoEvents()
            Else
                MessageBox.Show("Please select a number of groups above 1.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub nudNumberOfGroups_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudNumberOfGroups.ValueChanged
        Try
            Dim dblGroupSize As Double = olvStudents.Items.Count / nudNumberOfGroups.Value
            lblMembersPerGroup.Text = dblGroupSize.ToString("#,##0.0") & " students in each group"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK)
        End Try
    End Sub
End Class
