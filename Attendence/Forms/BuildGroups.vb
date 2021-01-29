'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Teaching Suite Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Teaching Suite.  If Not, see < https: //www.gnu.org/licenses/>.
Public Class BuildGroups
    Private m_assignmentStudents As New List(Of Integer)
    Private m_class As SchoolClass

    Public Sub New(cls As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = cls

        olvStudents.SetObjects(m_class.Students)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub EraseTeams()
        Dim boolEraseAll As Boolean
        For intCounter As Integer = 0 To m_class.Students.Count - 1
            If m_class.Students(intCounter).StudentTeam.Length > 0 Then
                boolEraseAll = (MessageBox.Show("Teams is not empty. Erase and replace?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes)
                Exit For
            End If
        Next

        If boolEraseAll Then
            For intCounter As Integer = 0 To m_class.Students.Count - 1
                m_class.Students(intCounter).StudentTeam = String.Empty
                Me.olvStudents.RefreshObject(m_class.Students(intCounter))
            Next
        End If
    End Sub
    Private Sub BuildGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildGroupsToolStripMenuItem.Click
        Try
            If chkUseTeam.Checked Then
                EraseTeams()
            End If

            m_assignmentStudents.Clear()

            Dim lstGroupNames As New List(Of String)
            If chkUseCustomGroupNames.Checked Then
                For Each line As String In txtGroupNames.Lines
                    lstGroupNames.Add(line)
                Next
            Else
                For intCounter As Integer = 1 To nudNumberOfGroups.Value
                    If chkUseTeam.Checked Then
                        Dim strName As String = ConvertToLetter(intCounter)
                        lstGroupNames.Add(strName.ToUpper())
                    Else
                        lstGroupNames.Add("Team_" & intCounter.ToString("00"))
                    End If
                Next
            End If

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

                    If chkUseTeam.Checked Then
                        '-- Team was erased earlier
                        m_class.Students(intPos).StudentTeam = lstGroupNames(intGroup - 1)
                    Else
                        '-- Tags get appended
                        If m_class.Students(intPos).Tags.Length > 0 Then
                            m_class.Students(intPos).Tags &= " "
                        End If
                        m_class.Students(intPos).Tags &= lstGroupNames(intGroup - 1)
                    End If

                    Me.olvStudents.RefreshObject(m_class.Students(intPos))
                    m_assignmentStudents.Add(intPos)
                Loop
                Application.DoEvents()
            Else
                MessageBox.Show("Please select a number of teams above 1.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub nudGroups_ValueChanged(sender As Object, e As EventArgs) Handles nudNumberOfGroups.ValueChanged
        Try
            UpdateStats()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub UpdateStats()
        Dim dblGroupSize As Double = olvStudents.Items.Count / nudNumberOfGroups.Value
        lblMembersPerGroup.Text = dblGroupSize.ToString("#,##0.0") & " students in each team"
    End Sub

    Private Sub BuildGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateStats()
    End Sub
End Class