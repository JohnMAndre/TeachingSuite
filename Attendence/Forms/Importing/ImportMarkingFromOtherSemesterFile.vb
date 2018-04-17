Public Class ImportMarkingFromOtherSemesterFile

    Private m_tempSemester As Semester
    Private m_lstCurrentListOfStudents As List(Of Student)

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub llblBrowseForSemesterFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblBrowseForSemesterFile.LinkClicked
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Semester databases|*.datx"
        ofd.Multiselect = False
        ofd.Title = "Select semester file to import from"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtSemesterFile.Text = ofd.FileName
            btnLoadSemester.Hide()
            Application.DoEvents()
            LoadSemesterFile()
            btnLoadSemester.Show()
        End If
    End Sub
    Private Sub lstClassGroups_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClassGroups.SelectedIndexChanged
        LoadClassAssignments()
        LoadClasses()
    End Sub
    Private Sub LoadSemesterFile()
        Try
            m_tempSemester = New Semester(txtSemesterFile.Text)

            LoadClassGroups()
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the selected semester file: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadClassGroups()
        lstAssignments.Items.Clear()
        lstClasses.Items.Clear()
        lstClassGroups.Items.Clear()
        For Each objClassGroup As ClassGroup In m_tempSemester.ClassGroups
            If objClassGroup IsNot Nothing Then
                lstClassGroups.Items.Add(objClassGroup)
            End If
        Next
    End Sub
    Private Sub LoadClasses()
        If GetSelectedClassGroup() IsNot Nothing Then
            lstClasses.Items.Clear()
            Dim intEmailSendingAccountForCombinedClass As Integer
            For Each objClass As SchoolClass In GetSelectedClassGroup.Classes
                lstClasses.Items.Add(objClass)
                intEmailSendingAccountForCombinedClass = objClass.EmailSendingAccount '-- simply logic, just take the last class
            Next
            If GetSelectedClassGroup.Classes.Count > 1 Then
                Dim cls As New SchoolClass(GetSelectedClassGroup())
                cls.Name = COMBINED_VIEW_NAME
                cls.EmailSendingAccount = intEmailSendingAccountForCombinedClass
                lstClasses.Items.Add(cls)
            ElseIf GetSelectedClassGroup.Classes.Count = 1 Then
                '-- auto-select the only class there
                lstClasses.SelectedIndex = 0
                'Application.DoEvents()
                'LoadStudents()
            End If
        End If
    End Sub
    Private Function GetSelectedClassGroup() As ClassGroup
        If lstClassGroups.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstClassGroups.Items(lstClassGroups.SelectedIndex)
        End If
    End Function
    Public Function GetSelectedClass() As SchoolClass
        If lstClasses.SelectedIndex = -1 Then
            If lstClasses.Items.Count = 1 Then
                lstClasses.SelectedIndex = 0
                Return lstClasses.Items(lstClasses.SelectedIndex)
            Else
                Return Nothing
            End If
        Else
            Return lstClasses.Items(lstClasses.SelectedIndex)
        End If
    End Function
    Private Sub LoadClassAssignments()
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a class first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstAssignments.Items.Clear()

            '-- add both BTEC and normal assignments
            For Each objClassAssignment As ClassAssignmentBTEC In GetSelectedClassGroup().AssignmentsBTEC
                lstAssignments.Items.Add(objClassAssignment)
            Next
            For Each objClassAssignment As ClassAssignment In GetSelectedClassGroup().Assignments
                lstAssignments.Items.Add(objClassAssignment)
            Next
        End If
    End Sub

    Private Sub lstAssignments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAssignments.SelectedIndexChanged
        '-- When we select an assignment, then show all students in the selected class with that assignment
        If GetSelectedClass() Is Nothing Then
            '-- do nothing
        Else
            LoadStudentsWithAssignment()
        End If
    End Sub
    Private Sub LoadStudentsWithAssignment()
        Dim asmt As IClassAssignment = GetSelectedAssignment()
        Dim cls As SchoolClass = GetSelectedClass()

        If asmt Is Nothing OrElse cls Is Nothing Then
            '-- Nothing to do, we need both
            dgvStudents.DataSource = Nothing
            Exit Sub

        End If

        Dim lstAllStudentsInClass As List(Of Student)

        dgvStudents.AutoGenerateColumns = False
        If ClassIsCombinedView(cls) Then
            lstAllStudentsInClass = New List(Of Student)
            Dim boolSetAlready As Boolean
            For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                If Not boolSetAlready Then
                    lstAllStudentsInClass.AddRange(objCls.Students)
                    boolSetAlready = True
                Else
                    '-- Need to ensure all students in all classes in this module are loaded
                    lstAllStudentsInClass.AddRange(objCls.Students)
                End If
            Next
        Else
            lstAllStudentsInClass = cls.Students
        End If


        m_lstCurrentListOfStudents = New List(Of Student)

        '-- Now, walk the list and only get students who have the selected assignment
        For Each stud As Student In lstAllStudentsInClass
            For Each objAssignment As StudentAssignment In stud.Assignments
                If objAssignment.BaseAssignment Is asmt Then
                    m_lstCurrentListOfStudents.Add(stud)
                    Exit For '-- go to next student
                End If
            Next
        Next


        dgvStudents.DataSource = m_lstCurrentListOfStudents


        Try
            dgvStudents.AutoResizeColumns()
        Catch ex As Exception
            Log(ex) '-- Log and continue
        End Try

        ShowStudentCount()
    End Sub
    Private Sub ShowStudentCount(Optional lstFiltered As List(Of Student) = Nothing)
        If lstFiltered Is Nothing Then
            lblStudentCount.Text = "Students: " & m_lstCurrentListOfStudents.Count().ToString("#,##0")
        Else
            lblStudentCount.Text = "Filtered: " & lstFiltered.Count.ToString("#,##0")
        End If

    End Sub

    Private Sub lstClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClasses.SelectedIndexChanged
        Dim asmt As IClassAssignment = GetSelectedAssignment()
        If asmt Is Nothing Then
            '-- do nothing
        Else
            LoadStudentsWithAssignment()
        End If
    End Sub
    Private Function GetSelectedAssignment() As IClassAssignment
        If lstAssignments.SelectedIndex = -1 Then
            Return Nothing
        Else
            Dim asmt As IClassAssignment = lstAssignments.Items(lstAssignments.SelectedIndex)
            GetSelectedClassGroup.LastAssignmentUsed = asmt
            Return asmt
        End If
    End Function

    Private Sub ImportStudentAssignments()
        Try
            If MessageBox.Show("Are you sure you want to import assignments, improvement items, and changes in data for these students?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                '-- No or cancel will stop this process

                '-- If we get here, for each student, import:
                '   This one assignment
                '   Any new improvement items
                '   Any changes in improvement item performance levels
                '   Any changes in student's presentation, research, plagiarism
                Dim baseAsmt As IClassAssignment = GetSelectedAssignment()
                Dim tempAsmt As StudentAssignment
                Dim permStud As Student '-- in the perm database (ThisSemester)
                Dim permAsmt As StudentAssignment
                Dim permItem As StudentImprovementItem
                Dim baseItem As ImprovementItem
                Dim boolMatchedItem As Boolean
                Dim intStudentsImported As Integer

                Dim xDoc As New Xml.XmlDocument() '-- just for working with xmlpersistance routines
                For Each stud As Student In m_lstCurrentListOfStudents
                    intStudentsImported += 1
                    permStud = Student.GetByStudentID(stud.StudentID)
                    If permStud Is Nothing Then
                        If MessageBox.Show("Could not match student (ID:" & stud.StudentID & "). Cancel?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                            Exit Sub
                        End If
                    End If

                    '-- Student-level data
                    permStud.PresentationQuality = stud.PresentationQuality
                    permStud.ResearchQuality = stud.ResearchQuality
                    permStud.PlagiarismSeverity = stud.PlagiarismSeverity

                    'TODO: we should look for notes and activitylog differences and add them

                    '-- Assignment
                    For Each tempAsmt In stud.Assignments
                        If tempAsmt.BaseAssignment Is baseAsmt Then
                            Exit For
                        End If
                    Next

                    '-- It seems impossible that the assignment could be missing because it was required to load the student in the list

                    permAsmt = New StudentAssignment(tempAsmt.GetXMLElementToPersist(xDoc), permStud)
                    permStud.Assignments.Add(permAsmt)


                    '-- Now, improvement items (add/update)
                    For Each tempItem As StudentImprovementItem In stud.ImprovementItems
                        boolMatchedItem = False '-- reset

                        For Each permItem In permStud.ImprovementItems
                            If tempItem.BaseImprovementItem.ID = permItem.BaseImprovementItem.ID Then
                                '-- this student already has this item, let's make sure the data is current
                                boolMatchedItem = True
                            End If
                        Next
                        If boolMatchedItem Then
                            '-- just update item data
                            permItem.PerformanceLevel = tempItem.PerformanceLevel
                            permItem.DateLastIncluded = tempItem.DateLastIncluded '-- should update both the date and the qty given
                        Else
                            '-- could not match this item, need to create it
                            '  add item to student

                            '   First we must find the base improvement item
                            baseItem = ImprovementItem.GetByID(tempItem.BaseImprovementItem.ID)
                            If baseItem Is Nothing Then
                                '-- needs to be created
                                '   but first, see if there is a similar match we can use
                                'TODO: Add missing base improvement item
                            End If
                            permItem = New StudentImprovementItem(permStud)
                            permItem.BaseImprovementItem = baseItem
                            permStud.ImprovementItems.Add(permItem)
                            permItem.DateAdded = tempItem.DateAdded
                            permItem.PerformanceLevel = tempItem.PerformanceLevel
                            If permItem.PerformanceLevel = 0 Then
                                permItem.PerformanceLevel = 3 '-- default to 3
                            End If

                            '-- if date included was not added
                            If tempItem.DateLastIncluded = DATE_NO_DATE Then
                                permItem.DateLastIncluded = tempItem.DateAdded
                            Else
                                permItem.DateLastIncluded = tempItem.DateLastIncluded
                            End If
                        End If
                    Next
                Next
                MessageBox.Show("Imported " & intStudentsImported.ToString("#,##0") & " student assignments.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nothing was imported.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error importing the data: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImportStudentAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportStudentAssignmentsToolStripMenuItem.Click
        ImportStudentAssignments()
    End Sub
End Class