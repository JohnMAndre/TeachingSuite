Imports System.Runtime.CompilerServices


Public Class AssignWorkshopGroups

    Private Class StudentWorkshopItem
        Implements IComparable(Of StudentWorkshopItem)

        Public Property StudentPresentor As Student
        Public Property WorkshopNumber As Integer '-- 1 to 6 if there are 6 workshops per student
        Public Property WorkshopGroup As Integer '-- 1 to 12 if there are 12 WS groups per day
        Public Property StudentEvaluator As Student '-- The person doing the peer evaluation

        Public Function CompareTo(other As StudentWorkshopItem) As Integer Implements IComparable(Of StudentWorkshopItem).CompareTo
            Dim strMe As String = Me.StudentPresentor.StudentGroup.ToString("000") & "-" & Me.WorkshopNumber.ToString("000") & "-" & Me.WorkshopGroup.ToString("000")
            Dim strOther As String = other.StudentPresentor.StudentGroup.ToString("000") & "-" & other.WorkshopNumber.ToString("000") & "-" & other.WorkshopGroup.ToString("000")

            Return strMe.CompareTo(strOther)
        End Function
    End Class


    Private m_lstPresenters As New List(Of StudentWorkshopItem)


    Private Property m_objClassGroup As ClassGroup

    Public Sub New(classGroup As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_objClassGroup = classGroup

    End Sub

    Private Sub chkReassignStudentGroup_CheckedChanged(sender As Object, e As EventArgs) Handles chkReassignStudentGroup.CheckedChanged
        nudNumberOfStudentGroups.Enabled = chkReassignStudentGroup.Checked
    End Sub


    Private Sub btnExportFile_Click(sender As Object, e As EventArgs) Handles btnExportFile.Click
        '-- At the end of it all, write out a simple text file
        '   WS (1-6), Student Group (1-2), Evaluator Student ID & Name, Evaluatee Student ID & Name
        Dim sfd As New SaveFileDialog()
        sfd.OverwritePrompt = True
        sfd.Filter = "Text files|*.txt"
        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim tw As System.IO.TextWriter = System.IO.File.CreateText(sfd.FileName)
            tw.WriteLine("StudentGroup,Workshop,WorkshopGroup,PresentorStudentID,EvaluatorStudentID")
            Dim strEvaluatorStudentID As String
            For Each item As StudentWorkshopItem In m_lstPresenters
                If item.StudentEvaluator Is Nothing Then
                    strEvaluatorStudentID = String.Empty
                Else
                    strEvaluatorStudentID = item.StudentEvaluator.StudentID
                End If
                tw.WriteLine(item.StudentPresentor.StudentGroup.ToString() & "," & item.WorkshopNumber.ToString() & "," & item.WorkshopGroup.ToString() & "," & item.StudentPresentor.StudentID & "," & strEvaluatorStudentID)
            Next
            tw.Close()
            tw.Dispose()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            '-- If reassign student groups is chosen
            '   then go through current ClassGroup and randomly
            '   set each student to one of the student groups
            '   For this, randomly select student and then sequentially 
            '   assign them
            Dim intNumberOfStudentGroups As Integer
            Dim dicStudentGroups As New Dictionary(Of Integer, Integer) '-- Key = StudentGroup; Value = number of students in that group
            m_lstPresenters.Clear() '-- in case it gets run multiple times 

            Dim lstAllStudents As New List(Of Student) '-- This is across all SchoolClasses within a ClassGroup

            For Each cls As SchoolClass In m_objClassGroup.Classes
                lstAllStudents.AddRange(cls.Students)
            Next

            '-- Remove hidden students from this process
            '   They are presumed dropped but not removed from the data
            Dim intListCount As Integer = lstAllStudents.Count - 1
            For intCounter As Integer = 0 To intListCount
                If lstAllStudents(intCounter).Hidden Then
                    lstAllStudents.RemoveAt(intCounter)
                    intCounter -= 1
                    intListCount -= 1
                End If
                If intCounter >= intListCount Then
                    Exit For
                End If
            Next

            If chkReassignStudentGroup.Checked Then
                intNumberOfStudentGroups = nudNumberOfStudentGroups.Value
                If lstAllStudents.Count > intNumberOfStudentGroups Then
                    For intCounter As Integer = 1 To intNumberOfStudentGroups
                        '-- setup the dictionary so we can use it later
                        dicStudentGroups.Add(intCounter, 0)
                    Next
                Else
                    MessageBox.Show("There are fewer students than number of student groups.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                '-- First, randomize the list
                lstAllStudents.RandomizeOrder()

                '-- walk through, alternating through the group numbers
                Dim intStudentGroup As Integer = 1
                For Each stud As Student In lstAllStudents
                    stud.StudentGroup = intStudentGroup

                    If (intStudentGroup Mod intNumberOfStudentGroups) = 0 Then
                        intStudentGroup = 1
                    Else
                        intStudentGroup += 1
                    End If
                Next

            Else
                '-- Here we must go to the data and see how many student groups we have
                '   and assign to our variable
                For Each stud As Student In lstAllStudents
                    If dicStudentGroups.ContainsKey(stud.StudentGroup) Then
                        dicStudentGroups(stud.StudentGroup) += 1 '-- Increment the value for this dictionary item
                    Else
                        dicStudentGroups.Add(stud.StudentGroup, 1)
                    End If
                Next
                intNumberOfStudentGroups = dicStudentGroups.Count
            End If

            '-- Now we have a randomized list of students and the number of student groups in the data


            Dim objWSItem As StudentWorkshopItem

            '-- For each workshop number (e.g., 6 of them)
            '-- For each student group in the database 
            '   Get this from the data, do not simply look to the NUD
            '   Randomly select student from student group
            Dim intMaxWorkshops As Integer = nudNumberOfWorkshops.Value
            Dim intMaxWorkshopGroups As Integer = nudNumberOfGroupsPerWorkshop.Value
            Dim intWorkshopGroup As Integer

            For Each intStudentGroup As Integer In dicStudentGroups.Keys '-- This will handle the case where the student group numbers are not sequential
                For intWSCounter As Integer = 1 To intMaxWorkshops '-- each time through is a new day
                    lstAllStudents.RandomizeOrder() '-- re-randomize each day
                    intWorkshopGroup = 1 '-- reset each time around
                    For Each stud As Student In lstAllStudents
                        If stud.StudentGroup = intStudentGroup Then
                            '-- process this student, skip the others
                            objWSItem = New StudentWorkshopItem()
                            objWSItem.StudentPresentor = stud
                            objWSItem.WorkshopNumber = intWSCounter
                            objWSItem.WorkshopGroup = intWorkshopGroup

                            If (intWorkshopGroup Mod intMaxWorkshopGroups) = 0 Then '-- can go sequential because students are already in a random order
                                intWorkshopGroup = 1
                            Else
                                intWorkshopGroup += 1
                            End If

                            m_lstPresenters.Add(objWSItem)
                        End If
                    Next
                Next
            Next



            '-- Once this is complete, then we can look at Peer Eval

            '-- If Peer eval is chosen then student has one evaluator and one evaluatee (and they will likely be different)
            '   We only need to track the evaluator (can cross reference to find evaluatee)
            '   Since students were already in a sorted order for each workshop, we can do this easily
            '   The first student in a workshopgroup will evaluate the second
            '   When the workshopgroup changes, the last student will evaluate the first of the previous workshop group

            Dim intPreviousWorkshopGroup As Integer
            Dim objFirstItemInWorkshopGroup As StudentWorkshopItem
            Dim objMostRecentItemInWorkshopGroup As StudentWorkshopItem

            If chkAssignPeerEval.Checked Then
                '-- First, sort by StudentGroup then WorkshopNumber then WorkshopGroup
                m_lstPresenters.Sort()


                intPreviousWorkshopGroup = m_lstPresenters(0).WorkshopGroup '-- So first item does not trigger change in WorkshopGroup
                objFirstItemInWorkshopGroup = m_lstPresenters(0)

                For Each item As StudentWorkshopItem In m_lstPresenters
                    If item.WorkshopGroup <> intPreviousWorkshopGroup Then
                        '-- It changed, we need to go back and assign that last one to the first one
                        objFirstItemInWorkshopGroup.StudentEvaluator = objMostRecentItemInWorkshopGroup.StudentPresentor

                        objFirstItemInWorkshopGroup = item
                        intPreviousWorkshopGroup = item.WorkshopGroup
                    Else
                        If objMostRecentItemInWorkshopGroup IsNot Nothing Then
                            item.StudentEvaluator = objMostRecentItemInWorkshopGroup.StudentPresentor '-- So, #2 evaluated by #1; #3 evaluated by #4; #1 evaluated by last presenter in group
                        End If
                    End If

                    objMostRecentItemInWorkshopGroup = item '-- for use the next time around
                Next

                '-- Need to repeat the above logic when we change workshopGroups here
                objFirstItemInWorkshopGroup.StudentEvaluator = objMostRecentItemInWorkshopGroup.StudentPresentor


            End If

            btnExportFile.Enabled = True

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message)
        End Try

    End Sub
  
End Class