Public Class AssignPeerEvaluation
    Private m_class As SchoolClass
    Private m_rnd As New Random()
    Private m_lstAssignedIDs As New List(Of String)

    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = clas
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            Dim objPeer As Student
            Dim strOutput As String = "Student ID" & vbTab & "Group" & vbTab & "Team" & vbTab & "Old Peer ID" & vbTab & "New Peer ID"
            AddOutput(strOutput)

            m_lstAssignedIDs.Clear() '-- reset each run

            For Each stud As Student In m_class.Students
                strOutput = stud.StudentID & vbTab & stud.StudentGroup.ToString() & vbTab & stud.StudentTeam & vbTab & stud.StudentIDToPeerReview
                objPeer = GetRandomPeer(stud)
                If objPeer Is Nothing Then
                    stud.StudentIDToPeerReview = String.Empty
                Else
                    stud.StudentIDToPeerReview = objPeer.StudentID
                End If

                strOutput &= vbTab & stud.StudentIDToPeerReview

                AddOutput(strOutput)
            Next
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error assigning peers: " & ex.Message)
        End Try
    End Sub
    Private Function GetRandomPeer(student As Student) As Student
        Dim intIndex As Integer
        Dim lst As New List(Of Student)
        Dim intCounter As Integer
        Dim objReturn As Student

        For Each stud As Student In m_class.Students
            '-- Test logic: Team must be different
            'If stud.StudentGroup = student.StudentGroup AndAlso stud.StudentTeam <> student.StudentTeam Then
            '-- Production logic Group must be different
            If stud.StudentGroup <> student.StudentGroup AndAlso stud.StudentTeam = student.StudentTeam Then
                lst.Add(stud)
            End If
        Next
        If lst.Count > 0 Then
            '-- We will randomly select the student to return
            '   but we make sure we do not return one we have returned before
            '   but because we could have a mismatch between number of students in
            '   one group, we might NEED to return duplicates
            '   so to ensure we do not return too many duplicated, we will only
            '   return a duplicate if we have tried 1,000 times to return a non-duplicate
            Do
                intIndex = m_rnd.Next(0, lst.Count)
                objReturn = lst(intIndex)
                intCounter += 1
            Loop Until (Not m_lstAssignedIDs.Contains(objReturn.StudentID)) OrElse (intCounter > 1000)

            m_lstAssignedIDs.Add(objReturn.StudentID)

            Return objReturn
        Else
            '-- No peers
            Return Nothing
        End If

    End Function
    Private Sub AssignPeerEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstGroup As New List(Of String)
        Dim lstTeam As New List(Of String)

        For Each stud As Student In m_class.Students
            If Not lstGroup.Contains(stud.StudentGroup.ToString()) Then
                lstGroup.Add(stud.StudentGroup.ToString())
            End If
            If Not lstTeam.Contains(stud.StudentTeam.ToString()) Then
                lstTeam.Add(stud.StudentTeam.ToString())
            End If
        Next

        lstGroup.Sort()
        lstTeam.Sort()

        If lstGroup.Count > 2 Then
            lstGroups.BackColor = Color.Yellow
        End If

        lstTeams.DataSource = lstTeam
        lstGroups.DataSource = lstGroup

    End Sub
    Private Sub AddOutput(text As String)
        txtOutput.Text &= text & Environment.NewLine
        txtOutput.Refresh()
    End Sub
End Class