Public Class ImportMarkingFromOtherSemesterFile
    Public Class ReportData
        Public Property Student As Student
        Public Property Assignment As StudentAssignment
        Public Property AssignmentBTEC As StudentAssignmentBTEC
        Public Sub New(stud As Student, asmt As StudentAssignment, asmtBTEC As StudentAssignmentBTEC)
            Student = stud
            Assignment = asmt
            AssignmentBTEC = asmtBTEC
        End Sub
        Public ReadOnly Property AdminNumber As Integer
            Get
                Return Student.AdminNumber
            End Get
        End Property
        Public ReadOnly Property AltID As Integer
            Get
                Return Student.AltNumber
            End Get
        End Property

        Public ReadOnly Property LocalName As String
            Get
                Return Student.LocalNameLatinLetters
            End Get
        End Property
        Public ReadOnly Property Nickname As String
            Get
                Return Student.Nickname
            End Get
        End Property
        Public ReadOnly Property ExtStudentID As String
            Get
                Return Student.ExtStudentID
            End Get
        End Property
        Public ReadOnly Property StudentID As String
            Get
                Return Student.StudentID
            End Get
        End Property
        Public ReadOnly Property Tags As String
            Get
                Return Student.Tags
            End Get
        End Property
        Public ReadOnly Property StudentGroup As Integer
            Get
                Return Student.StudentGroup
            End Get
        End Property
        Public ReadOnly Property StudentTeam As String
            Get
                Return Student.StudentTeam
            End Get
        End Property
        Public ReadOnly Property SchoolClass As String
            Get
                Return Student.SchoolClass.Name
            End Get
        End Property
        Public ReadOnly Property PresentationQuality As Integer
            Get
                Return Student.PresentationQuality
            End Get
        End Property
        Public ReadOnly Property ResearchQuality As Integer
            Get
                Return Student.ResearchQuality
            End Get
        End Property
        Public ReadOnly Property PlagiarismSeverity As Integer
            Get
                Return Student.PlagiarismSeverity
            End Get
        End Property
        Public ReadOnly Property AssignmentScoreFirst
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.FirstTryPoints
                Else
                    Return -1
                End If
            End Get
        End Property
        Public ReadOnly Property Creator As String
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.FirstUserFullName
                Else
                    Return AssignmentBTEC.FirstUserFullName
                End If
            End Get
        End Property
        Public ReadOnly Property Editor As String
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.LastUserFullName
                Else
                    Return AssignmentBTEC.LastUserFullName
                End If
            End Get
        End Property
        Public ReadOnly Property Overall As String
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.OverallComments
                Else
                    Return AssignmentBTEC.OverallComments
                End If
            End Get
        End Property
        Public ReadOnly Property Improvement As String
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.ImprovementComments
                Else
                    Return AssignmentBTEC.ImprovementComments
                End If
            End Get
        End Property
        Public ReadOnly Property AchievedPass As Boolean
            Get
                If Assignment IsNot Nothing Then
                    Return False
                Else
                    Return AssignmentBTEC.AchievedPass
                End If
            End Get
        End Property
        Public ReadOnly Property AchievedMerit As Boolean
            Get
                If Assignment IsNot Nothing Then
                    Return False
                Else
                    Return AssignmentBTEC.AchievedMerit
                End If
            End Get
        End Property
        Public ReadOnly Property AchievedDistinction As Boolean
            Get
                If Assignment IsNot Nothing Then
                    Return False
                Else
                    Return AssignmentBTEC.AchievedDistinction
                End If
            End Get
        End Property
    End Class
    Private m_tempSemester As Semester
    Private m_lstCurrentListOfStudents As List(Of ReportData)

    Private m_objLocalClassGroup As ClassGroup

    Public Sub New(classGroup As ClassGroup)

        ' This call is required by the designer.
        InitializeComponent()

        m_objLocalClassGroup = classGroup
    End Sub

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
            dgvStudentsNormal.DataSource = Nothing
            Exit Sub

        End If

        Dim lstAllStudentsInClass As List(Of Student)

        dgvStudentsNormal.AutoGenerateColumns = False
        dgvStudentsBTEC.AutoGenerateColumns = False

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


        m_lstCurrentListOfStudents = New List(Of ReportData)
        Dim objData As ReportData

        If asmt.AssignmentType = AssignmentType.Normal Then
            dgvStudentsNormal.Visible = True
            dgvStudentsBTEC.Visible = False

            '-- Now, walk the list and only get students who have the selected assignment
            For Each stud As Student In lstAllStudentsInClass
                For Each objAssignment As StudentAssignment In stud.Assignments
                    If objAssignment.BaseAssignment Is asmt Then
                        objData = New ReportData(stud, objAssignment, Nothing)
                        m_lstCurrentListOfStudents.Add(objData)
                        Exit For '-- go to next student
                    End If
                Next
            Next

            dgvStudentsNormal.DataSource = m_lstCurrentListOfStudents
        Else
            dgvStudentsNormal.Visible = False
            dgvStudentsBTEC.Visible = True

            '-- Now, walk the list and only get students who have the selected assignment
            For Each stud As Student In lstAllStudentsInClass
                For Each objAssignment As StudentAssignmentBTEC In stud.AssignmentsBTEC
                    If objAssignment.BaseAssignment Is asmt Then
                        objData = New ReportData(stud, Nothing, objAssignment)
                        m_lstCurrentListOfStudents.Add(objData)
                        Exit For '-- go to next student
                    End If
                Next
            Next

            dgvStudentsBTEC.DataSource = m_lstCurrentListOfStudents
        End If


        Try
            dgvStudentsNormal.AutoResizeColumns()
            dgvStudentsBTEC.AutoResizeColumns()
        Catch ex As Exception
            Log(ex) '-- Log and continue
            MessageBox.Show("There was an error loading the data: " & ex.Message)
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
                Dim permStud As Student '-- in the perm database (ThisSemester)
                Dim permItem As StudentImprovementItem
                Dim baseItem As ImprovementItem
                Dim boolMatchedItem As Boolean
                Dim intStudentsImported As Integer

                Dim xDoc As New Xml.XmlDocument() '-- just for working with xmlpersistance routines
                For Each stud As ReportData In m_lstCurrentListOfStudents
                    intStudentsImported += 1
                    'permStud = Student.GetByStudentID(stud.StudentID)
                    permStud = m_objLocalClassGroup.GetStudentByID(stud.StudentID)
                    If permStud Is Nothing Then
                        If MessageBox.Show("Could not match student (ID:" & stud.StudentID & " - " & stud.LocalName & "). Cancel?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                            Exit Sub
                        Else
                            Continue For
                        End If
                    End If

                    '-- Student-level data
                    permStud.PresentationQuality = stud.PresentationQuality
                    permStud.ResearchQuality = stud.ResearchQuality
                    permStud.PlagiarismSeverity = stud.PlagiarismSeverity

                    'TODO: we should look for notes and activitylog differences and add them

                    '-- Assignment
                    If baseAsmt.AssignmentType = AssignmentType.Normal Then
                        Dim tempAsmt As StudentAssignment
                        Dim permAsmt As StudentAssignment

                        For Each tempAsmt In stud.Student.Assignments
                            If tempAsmt.BaseAssignment Is baseAsmt Then
                                Exit For
                            End If
                        Next

                        '-- It seems impossible that the assignment could be missing because it was required to load the student in the list
                        permAsmt = New StudentAssignment(tempAsmt.GetXMLElementToPersist(xDoc), permStud)
                        If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                            '-- Need to override the marker's name
                            permAsmt.FirstUserFullName = txtOverrideMarkerName.Text.Trim()
                            permAsmt.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                        End If
                        permStud.Assignments.Add(permAsmt)
                    Else
                        '-- BTEC
                        Dim tempAsmt As StudentAssignmentBTEC
                        Dim permAsmt As StudentAssignmentBTEC

                        For Each tempAsmt In stud.Student.AssignmentsBTEC
                            If tempAsmt.BaseAssignment Is baseAsmt Then
                                Exit For
                            End If
                        Next

                        '-- It seems impossible that the assignment could be missing because it was required to load the student in the list
                        permAsmt = New StudentAssignmentBTEC(tempAsmt.GetXMLElementToPersist(xDoc), permStud)
                        If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                            '-- Need to override the marker's name
                            permAsmt.FirstUserFullName = txtOverrideMarkerName.Text.Trim()
                            permAsmt.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                        End If
                        permStud.AssignmentsBTEC.Add(permAsmt)
                    End If


                    '-- Now, improvement items (add/update)
                    For Each tempItem As StudentImprovementItem In stud.Student.ImprovementItems
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
                AddApplicationHistory("Imported " & intStudentsImported.ToString("#,##0") & " student assignments (" & baseAsmt.Name & ") from other database.")
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

    Private Sub DeleteSelectedAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedAssignmentsToolStripMenuItem.Click
        Dim asmt As IClassAssignment = GetSelectedAssignment()

        If asmt.AssignmentType = AssignmentType.Normal Then
            Dim lst As List(Of ReportData) = GetSelectedStudentsFromGrid()
            For Each objData As ReportData In lst
                m_lstCurrentListOfStudents.Remove(objData)
            Next


            dgvStudentsNormal.DataSource = Nothing
            dgvStudentsNormal.DataSource = m_lstCurrentListOfStudents

            lblStudentCount.Text = "Students: " & m_lstCurrentListOfStudents.Count.ToString("#,##0")
        Else
            Dim lst As List(Of ReportData) = GetSelectedStudentsFromBTECGrid()
            For Each objData As ReportData In lst
                m_lstCurrentListOfStudents.Remove(objData)
            Next


            dgvStudentsBTEC.DataSource = Nothing
            dgvStudentsBTEC.DataSource = m_lstCurrentListOfStudents

            lblStudentCount.Text = "Students: " & m_lstCurrentListOfStudents.Count.ToString("#,##0")
        End If
    End Sub

    Private Sub btnLoadSemester_Click(sender As Object, e As EventArgs) Handles btnLoadSemester.Click
        LoadSemesterFile()
    End Sub
    Private Function GetSelectedStudentsFromGrid() As List(Of ReportData)
        Dim lstReturn As New List(Of ReportData)

        Dim cells As DataGridViewSelectedCellCollection

        cells = dgvStudentsNormal.SelectedCells

        Dim row As DataGridViewRow
        Dim stud As ReportData

        Dim dict As New Dictionary(Of Integer, Object)
        For Each cell As DataGridViewCell In cells
            If Not dict.ContainsKey(cell.RowIndex) Then
                dict.Add(cell.RowIndex, Nothing)

                row = dgvStudentsNormal.Rows(cell.RowIndex)
                stud = row.DataBoundItem
                If stud IsNot Nothing Then
                    lstReturn.Add(stud)
                End If
            End If
        Next
        Return lstReturn
    End Function
    Private Function GetSelectedStudentsFromBTECGrid() As List(Of ReportData)
        Dim lstReturn As New List(Of ReportData)

        Dim cells As DataGridViewSelectedCellCollection

        cells = dgvStudentsBTEC.SelectedCells

        Dim row As DataGridViewRow
        Dim stud As ReportData

        Dim dict As New Dictionary(Of Integer, Object)
        For Each cell As DataGridViewCell In cells
            If Not dict.ContainsKey(cell.RowIndex) Then
                dict.Add(cell.RowIndex, Nothing)

                row = dgvStudentsBTEC.Rows(cell.RowIndex)
                stud = row.DataBoundItem
                If stud IsNot Nothing Then
                    lstReturn.Add(stud)
                End If
            End If
        Next
        Return lstReturn
    End Function

End Class