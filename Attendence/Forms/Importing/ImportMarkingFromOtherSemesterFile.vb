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
Imports DocumentFormat.OpenXml.Math
Imports Microsoft.Office.Interop.Word

Public Class ImportMarkingFromOtherSemesterFile

    Private Enum ExistingAssignmentOptionEnum
        SkipExisting
        OverwriteExisting
        OverwriteRework
    End Enum

    Public Class SyncResolverNormalData
        Public Property Student As Student
        Public Property TempAssignment As StudentAssignment
        Public Property PermExistingAssignment As StudentAssignment
        Public Overrides Function ToString() As String
            Return Me.Student.StudentID
        End Function
    End Class
    Public Class SyncResolverBTECData
        Public Property Student As Student
        Public Property TempAssignment As StudentAssignmentBTEC
        Public Property PermExistingAssignment As StudentAssignmentBTEC
        Public Overrides Function ToString() As String
            Return Me.Student.StudentID
        End Function
    End Class

    Private m_lstSyncResolverNormal As New List(Of SyncResolverNormalData)
    Private m_lstSyncResolverBTEC As New List(Of SyncResolverBTECData)

    Public Class ReportData
        Implements IComparable(Of ReportData)

        Public Property Student As Student
        Public Property Assignment As StudentAssignment
        Public Property AssignmentBTEC As StudentAssignmentBTEC
        Public Property CountMatchingAssignmentsNormal As Integer
        Public Property CountMatchingAssignmentsBTEC As Integer
        Public Sub New(stud As Student, asmt As StudentAssignment, asmtBTEC As StudentAssignmentBTEC, localClassGroup As ClassGroup)
            Student = stud
            Assignment = asmt
            AssignmentBTEC = asmtBTEC

            Dim permStudent As Student = localClassGroup.GetStudentByID(stud.StudentID)
            If permStudent Is Nothing Then
                CountMatchingAssignmentsNormal = -99 '-- hint of missing student in local database
                CountMatchingAssignmentsBTEC = -99
            Else
                If asmt IsNot Nothing Then
                    For Each tempAsmt As StudentAssignment In permStudent.Assignments
                        If asmt.BaseAssignment.ID = tempAsmt.BaseAssignment.ID Then
                            CountMatchingAssignmentsNormal += 1
                        End If
                    Next
                End If

                If asmtBTEC IsNot Nothing Then
                    For Each tempAsmt As StudentAssignmentBTEC In permStudent.AssignmentsBTEC
                        If asmtBTEC.BaseAssignment.ID = tempAsmt.BaseAssignment.ID Then
                            CountMatchingAssignmentsBTEC += 1
                        End If
                    Next
                End If
            End If

        End Sub


        Public Function CompareTo(other As ReportData) As Integer Implements IComparable(Of ReportData).CompareTo
            Throw New NotImplementedException()
        End Function
#Region " Properties "
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
        Public Property AssignmentScoreFirst As Integer
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.FirstTryPoints
                Else
                    Return -1
                End If
            End Get
            Set(value As Integer)
                If Assignment IsNot Nothing Then
                    Assignment.FirstTryPoints = value
                Else
                    '-- do nothing
                End If
            End Set
        End Property
        Public Property AssignmentScoreSecond As Integer
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.SecondTryPoints
                Else
                    Return -1
                End If
            End Get
            Set(value As Integer)
                If Assignment IsNot Nothing Then
                    Assignment.SecondTryPoints = value
                Else
                    '-- do nothing
                End If
            End Set
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
        Public ReadOnly Property Overall2 As String
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.OverallCommentsRework
                Else
                    Return AssignmentBTEC.OverallCommentsRework
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
        Public ReadOnly Property Improvement2 As String
            Get
                If Assignment IsNot Nothing Then
                    Return Assignment.ImprovementCommentsRework
                Else
                    Return AssignmentBTEC.ImprovementCommentsRework
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
#End Region

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
        If ofd.ShowDialog = DialogResult.OK Then
            txtSemesterFile.Text = ofd.FileName
            btnLoadSemester.Hide()
            System.Windows.Forms.Application.DoEvents()
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
            MessageBox.Show("There was an error loading the selected semester file: " & ex.Message, PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Please select a class first.", PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        objData = New ReportData(stud, objAssignment, Nothing, m_objLocalClassGroup)
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
                        objData = New ReportData(stud, Nothing, objAssignment, m_objLocalClassGroup)
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

    Private Sub DeleteSelectedAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedAssignmentsToolStripMenuItem.Click
        Dim asmt As IClassAssignment = GetSelectedAssignment()
        Dim lst As List(Of ReportData)

        If asmt.AssignmentType = AssignmentType.Normal Then
            lst = GetSelectedStudentsFromGrid()
        Else
            lst = GetSelectedStudentsFromBTECGrid()
        End If

        For Each objData As ReportData In lst
            m_lstCurrentListOfStudents.Remove(objData)
        Next

        If asmt.AssignmentType = AssignmentType.Normal Then
            dgvStudentsNormal.DataSource = Nothing
            dgvStudentsNormal.DataSource = m_lstCurrentListOfStudents
        Else
            dgvStudentsBTEC.DataSource = Nothing
            dgvStudentsBTEC.DataSource = m_lstCurrentListOfStudents
        End If

        lblStudentCount.Text = "Students: " & m_lstCurrentListOfStudents.Count.ToString("#,##0")
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

    Private Sub SkipAnyAssignmentWhichAlreadyExistsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SkipAnyAssignmentWhichAlreadyExistsToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to import assignments (skipping any who have an existing assignment), improvement items, and changes in data for these students?", PRODUCT_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
            ImportAssignments(ExistingAssignmentOptionEnum.SkipExisting)
        Else
            MessageBox.Show("Nothing was imported.")
        End If
    End Sub

    Private Sub OverwriteExistingCompletelyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverwriteExistingCompletelyToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to import assignments (overwriting any existing assignment), improvement items, and changes in data for these students?", PRODUCT_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
            ImportAssignments(ExistingAssignmentOptionEnum.OverwriteExisting)
        Else
            MessageBox.Show("Nothing was imported.")
        End If
    End Sub

    Private Sub OverwriteOnlyReworkElementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverwriteOnlyReworkElementsToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to import assignments (overwriting rework elements of existing assignments, importing full assignments where none exist), improvement items, and changes in data for these students?", PRODUCT_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
            ImportAssignments(ExistingAssignmentOptionEnum.OverwriteRework)
        Else
            MessageBox.Show("Nothing was imported.")
        End If
    End Sub

    Private Sub ImportAssignments(handleExisting As ExistingAssignmentOptionEnum)
        Try
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

            m_lstSyncResolverNormal.Clear()
            m_lstSyncResolverBTEC.Clear()

            Dim xDoc As New Xml.XmlDocument() '-- just for working with xmlpersistance routines
            For Each stud As ReportData In m_lstCurrentListOfStudents
                intStudentsImported += 1
                permStud = m_objLocalClassGroup.GetStudentByID(stud.StudentID)
                If permStud Is Nothing Then
                    If MessageBox.Show("Could not match student (ID:" & stud.StudentID & " - " & stud.LocalName & "). Cancel?", PRODUCT_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
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

                '-- Normal Assignment
                If baseAsmt.AssignmentType = AssignmentType.Normal Then
                    Dim tempAsmt As StudentAssignment '-- in external database
                    Dim permAsmtExisting As StudentAssignment '-- existing in present database
                    Dim permAsmtNew As StudentAssignment '-- Going to be added to present database

                    tempAsmt = Nothing
                    permAsmtExisting = Nothing
                    permAsmtNew = Nothing

                    '-- Find temp assigment in external DB
                    For Each tempAsmt In stud.Student.Assignments
                        If tempAsmt.BaseAssignment Is baseAsmt Then
                            Exit For
                        End If
                    Next

                    '-- Is there an existing student assignment?
                    For Each asmt As StudentAssignment In permStud.Assignments
                        If asmt.BaseAssignment.ID = baseAsmt.ID Then
                            permAsmtExisting = asmt
                            Exit For
                        End If
                    Next


                    Select Case handleExisting
                        Case ExistingAssignmentOptionEnum.OverwriteExisting
                            If permAsmtExisting IsNot Nothing Then
                                '-- Delete existing
                                permStud.AddToActivityLog("Deleted existing assignment (" & permAsmtExisting.BaseAssignment.Name & ")  to replace with imported data.")
                                permStud.Assignments.Remove(permAsmtExisting)
                            End If

                            '-- It seems impossible that the assignment could be missing because it was required to load the student in the list
                            permAsmtNew = New StudentAssignment(tempAsmt.GetXMLElementToPersist(xDoc), permStud)
                            If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                '-- Need to override the marker's name
                                permAsmtNew.FirstUserFullName = txtOverrideMarkerName.Text.Trim()
                                permAsmtNew.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                            End If
                            permStud.Assignments.Add(permAsmtNew)

                            If chkMarkImportedAsProcessed.Checked Then
                                permAsmtNew.Processed = True
                            End If
                        Case ExistingAssignmentOptionEnum.OverwriteRework
                            If permAsmtExisting Is Nothing Then
                                '-- Just import full assignment since there is no existing
                                '-- It seems impossible that the assignment could be missing because it was required to load the student in the list
                                permAsmtNew = New StudentAssignment(tempAsmt.GetXMLElementToPersist(xDoc), permStud)
                                If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                    '-- Need to override the marker's name
                                    permAsmtNew.FirstUserFullName = txtOverrideMarkerName.Text.Trim()
                                    permAsmtNew.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                                End If
                                permStud.Assignments.Add(permAsmtNew)
                                permStud.AddToActivityLog("Imported assignment (" & permAsmtNew.BaseAssignment.Name & ").")

                                If chkMarkImportedAsProcessed.Checked Then
                                    permAsmtNew.Processed = True
                                End If
                            Else
                                '-- Since there is existing, we only want to update that existing assignment
                                '   but only update rework elements, and only where rework exists and original assignment's rework elements are empty
                                '   If new assignment's overall RW and improvement RW contain something and existing assignment's overall RW and improvement RW do not, overwrite RW elements
                                '   If new assignment's overall RW and improvement RW are empty, skip this student
                                '   if existing assignment and new assignment both have overall RW and improvement RW contents, then notify the user to process it manually (or give a sync decider dialog)
                                If tempAsmt.OverallCommentsRework.Trim().Length + tempAsmt.ImprovementCommentsRework.Trim().Length = 0 Then
                                    '-- skip and leave existing asmt alone
                                    Continue For
                                Else
                                    '-- new assignment has rework contents, make sure existing does not
                                    If permAsmtExisting.OverallCommentsRework.Trim().Length + permAsmtExisting.ImprovementCommentsRework.Trim().Length = 0 Then
                                        permAsmtExisting.OverallCommentsRework = tempAsmt.OverallCommentsRework
                                        permAsmtExisting.ImprovementCommentsRework = tempAsmt.ImprovementCommentsRework
                                        permAsmtExisting.SecondTryPoints = tempAsmt.SecondTryPoints

                                        If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                            '-- Need to override the marker's name
                                            permAsmtExisting.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                                        Else
                                            permAsmtExisting.LastUserFullName = tempAsmt.LastUserFullName
                                        End If

                                        If chkMarkImportedAsProcessed.Checked Then
                                            permAsmtExisting.Processed = True
                                        End If

                                        '-- Update only if new data is greater than old data
                                        If stud.PlagiarismSeverity > permStud.PlagiarismSeverity Then
                                            permStud.PlagiarismSeverity = stud.PlagiarismSeverity
                                        End If
                                        If stud.PresentationQuality > permStud.PresentationQuality Then
                                            permStud.PresentationQuality = stud.PresentationQuality
                                        End If
                                        permStud.AddToActivityLog("Updated existing assignment (" & permAsmtExisting.BaseAssignment.Name & ")  with imported rework data.")

                                    Else
                                        '-- Both new asmt and existing asmt have rework contents, need user to decide case by case (special dialog needed here)
                                        Dim resolverData As New SyncResolverNormalData()
                                        resolverData.Student = permStud
                                        resolverData.TempAssignment = tempAsmt
                                        resolverData.PermExistingAssignment = permAsmtExisting
                                        m_lstSyncResolverNormal.Add(resolverData)
                                    End If
                                End If
                            End If

                        Case ExistingAssignmentOptionEnum.SkipExisting
                            '-- skip this student
                            Continue For
                    End Select

                Else
                    '-- BTEC Assignment
                    Dim tempAsmt As StudentAssignmentBTEC '-- in external database
                    Dim permAsmtExisting As StudentAssignmentBTEC '-- existing in present database
                    Dim permAsmtNew As StudentAssignmentBTEC '-- Going to be added to present database
                    Dim baseOC As AssignmentOutcome

                    baseOC = Nothing
                    tempAsmt = Nothing
                    permAsmtExisting = Nothing
                    permAsmtNew = Nothing

                    '-- Find temp assigment in external DB
                    For Each tempAsmt In stud.Student.AssignmentsBTEC
                        If tempAsmt.BaseAssignment Is baseAsmt Then
                            Exit For
                        End If
                    Next

                    '-- Is there an existing student assignment?
                    For Each asmt As StudentAssignmentBTEC In permStud.AssignmentsBTEC
                        If asmt.BaseAssignment.ID = baseAsmt.ID Then
                            permAsmtExisting = asmt
                            Exit For
                        End If
                    Next

                    Select Case handleExisting
                        Case ExistingAssignmentOptionEnum.OverwriteExisting
                            If permAsmtExisting IsNot Nothing Then
                                '-- Delete existing
                                permStud.AddToActivityLog("Deleted existing assignment (" & permAsmtExisting.BaseAssignment.Name & ")  to replace with imported data.")
                                permStud.AssignmentsBTEC.Remove(permAsmtExisting)
                            End If

                            '-- It seems impossible that the assignment could be missing because it was required to load the student in the list
                            permAsmtNew = New StudentAssignmentBTEC(tempAsmt.GetXMLElementToPersist(xDoc), permStud)
                            If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                '-- Need to override the marker's name
                                permAsmtNew.FirstUserFullName = txtOverrideMarkerName.Text.Trim()
                                permAsmtNew.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                            End If
                            permStud.AssignmentsBTEC.Add(permAsmtNew)

                            If chkMarkImportedAsProcessed.Checked Then
                                permAsmtNew.Processed = True
                            End If
                        Case ExistingAssignmentOptionEnum.OverwriteRework
                            If permAsmtExisting Is Nothing Then
                                '-- Just import full assignment since there is no existing
                                '-- It seems impossible that the assignment could be missing because it was required to load the student in the list
                                permAsmtNew = New StudentAssignmentBTEC(tempAsmt.GetXMLElementToPersist(xDoc), permStud)

                                If permAsmtNew.BaseAssignment Is Nothing Then
                                    MessageBox.Show("There is no matching assignment in the current database.", PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If

                                If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                    '-- Need to override the marker's name
                                    permAsmtNew.FirstUserFullName = txtOverrideMarkerName.Text.Trim()
                                    permAsmtNew.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                                End If
                                permStud.AssignmentsBTEC.Add(permAsmtNew)
                                permStud.AddToActivityLog("Imported assignment (" & permAsmtNew.BaseAssignment.Name & ").")

                                If chkMarkImportedAsProcessed.Checked Then
                                    permAsmtNew.Processed = True
                                End If
                            Else
                                '-- Since there is existing, we only want to update that existing assignment
                                '   but only update rework elements, and only where rework exists and original assignment's rework elements are empty
                                '   If new assignment's overall RW and improvement RW contain something and existing assignment's overall RW and improvement RW do not, overwrite RW elements
                                '   If new assignment's overall RW and improvement RW are empty, skip this student
                                '   if existing assignment and new assignment both have overall RW and improvement RW contents, then notify the user to process it manually (or give a sync decider dialog)
                                If tempAsmt.OverallCommentsRework.Trim().Length + tempAsmt.ImprovementCommentsRework.Trim().Length = 0 Then
                                    '-- skip and leave existing asmt alone (new temp asmt is empty as far as RW)
                                    Continue For
                                Else
                                    '-- new assignment has rework contents, make sure existing does not
                                    If permAsmtExisting.OverallCommentsRework.Trim().Length + permAsmtExisting.ImprovementCommentsRework.Trim().Length = 0 Then
                                        permAsmtExisting.OverallCommentsRework = tempAsmt.OverallCommentsRework
                                        permAsmtExisting.ImprovementCommentsRework = tempAsmt.ImprovementCommentsRework

                                        Dim intOutcomesUpdated As Integer
                                        '-- Handle all the learning outcomes on this assignment
                                        For Each tempOC As OutcomeResult In tempAsmt.Outcomes
                                            If tempOC.SecondTryStatus <> OutcomeResultStatusEnum.Unknown Then
                                                '-- Now finding the matching outcome on the permExisting assignment and update it
                                                For Each permOC As OutcomeResult In permAsmtExisting.Outcomes
                                                    If permOC.BaseOutcome.ID = tempOC.BaseOutcome.ID Then
                                                        '-- We found the matching learning outcome on the permAssignment
                                                        permOC.SecondTryStatus = tempOC.SecondTryStatus
                                                        permOC.SecondTryComments = tempOC.SecondTryComments
                                                        intOutcomesUpdated += 1
                                                        Exit For
                                                    End If
                                                Next
                                            End If
                                        Next


                                        If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                            '-- Need to override the marker's name
                                            permAsmtExisting.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                                        Else
                                            permAsmtExisting.LastUserFullName = tempAsmt.LastUserFullName
                                        End If

                                        If chkMarkImportedAsProcessed.Checked Then
                                            permAsmtExisting.Processed = True
                                        End If

                                        '-- Update only if new data is greater than old data
                                        If stud.PlagiarismSeverity > permStud.PlagiarismSeverity Then
                                            permStud.PlagiarismSeverity = stud.PlagiarismSeverity
                                        End If
                                        If stud.PresentationQuality > permStud.PresentationQuality Then
                                            permStud.PresentationQuality = stud.PresentationQuality
                                        End If
                                        permStud.AddToActivityLog("Updated existing assignment (" & permAsmtExisting.BaseAssignment.Name & ")  with imported rework data (including " & intOutcomesUpdated.ToString() & " outcomes).")

                                    Else
                                        '-- Both new asmt and existing asmt have rework contents, need user to decide case by case (special dialog needed here)
                                        Dim resolverData As New SyncResolverBTECData()
                                        resolverData.Student = permStud
                                        resolverData.TempAssignment = tempAsmt
                                        resolverData.PermExistingAssignment = permAsmtExisting
                                        m_lstSyncResolverBTEC.Add(resolverData)
                                    End If
                                End If
                            End If

                        Case ExistingAssignmentOptionEnum.SkipExisting
                            '-- skip this student
                            Continue For
                    End Select
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

            '-- Show resolvers, as needed
            '   first, normal ones
            If m_lstSyncResolverNormal.Count > 0 Then
                Dim frm As New ImportSyncResolveNormal(m_lstSyncResolverNormal)
                frm.ShowDialog()
            End If

            '   next, BTEC
            If m_lstSyncResolverBTEC.Count > 0 Then
                Dim frm As New ImportSyncResolverBTEC(m_lstSyncResolverBTEC)
                frm.ShowDialog()
            End If


            MessageBox.Show("Imported " & intStudentsImported.ToString("#,##0") & " student assignments.", PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddApplicationHistory("Imported " & intStudentsImported.ToString("#,##0") & " student assignments (" & baseAsmt.Name & ") from other database.")
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message)
        End Try

    End Sub

    Private Sub ImportreworkForAllExistingAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportreworkForAllExistingAssignmentsToolStripMenuItem.Click
        Dim permStud As Student '-- in the perm database (ThisSemester)
        Dim baseAsmt As IClassAssignment
        Dim grp As ClassGroup
        Dim boolSkipBTEC As Boolean
        Dim xDoc As Xml.XmlDocument '-- just for working with xmlpersistance routines
        Dim intUpdatesMade As Integer

        Try
            xDoc = New Xml.XmlDocument()
            grp = GetSelectedClassGroup()

            If grp IsNot Nothing Then
                If MessageBox.Show("Are you sure you want to overall write all 2nd markings (grades and comments) for ALL assessments in all classes in the selected module (" &
                                   grp.Name & ") in the selected database?", PRODUCT_NAME, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    For Each cls As SchoolClass In grp.Classes '-- in external DB
                        For Each tempStud As Student In cls.Students
                            '-- Match external student with local database student
                            permStud = m_objLocalClassGroup.GetStudentByID(tempStud.StudentID)
                            If permStud Is Nothing Then
                                If MessageBox.Show("Could not match student (ID:" & tempStud.StudentID & " - " & tempStud.LocalName & "). Cancel?",
                                                   PRODUCT_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                                    Exit Sub
                                Else
                                    Continue For
                                End If
                            End If

                            '-- Process all assignments for this student in the external db
                            For Each studAsmt As StudentAssignment In tempStud.Assignments
                                baseAsmt = GetLocalBaseAssignmentByID(studAsmt.BaseAssignment.ID)

                                '-- Normal Assignment
                                If baseAsmt.AssignmentType = AssignmentType.Normal Then
                                    Dim tempAsmt As StudentAssignment '-- in external database
                                    Dim permAsmtExisting As StudentAssignment '-- existing in present database
                                    Dim permAsmtNew As StudentAssignment '-- Going to be added to present database

                                    '-- reset on the loop
                                    tempAsmt = studAsmt
                                    permAsmtExisting = Nothing
                                    permAsmtNew = Nothing

                                    '-- Is there an existing student assignment?
                                    For Each asmt As StudentAssignment In permStud.Assignments
                                        If asmt.BaseAssignment.ID = baseAsmt.ID Then
                                            permAsmtExisting = asmt
                                            Exit For
                                        End If
                                    Next

                                    '-- Note: We will always overwrite rework (or add new if missing) using this feature
                                    If permAsmtExisting Is Nothing Then
                                        '-- Just import full assignment since there is no existing
                                        '-- It seems impossible that the assignment could be missing because it was required to load the student in the list
                                        permAsmtNew = New StudentAssignment(tempAsmt.GetXMLElementToPersist(xDoc), permStud)
                                        If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                            '-- Need to override the marker's name
                                            permAsmtNew.FirstUserFullName = txtOverrideMarkerName.Text.Trim()
                                            permAsmtNew.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                                        End If
                                        permStud.Assignments.Add(permAsmtNew)
                                        permStud.AddToActivityLog("Imported assignment (" & permAsmtNew.BaseAssignment.Name & ").")

                                        If chkMarkImportedAsProcessed.Checked Then
                                            permAsmtNew.Processed = True
                                        End If

                                        intUpdatesMade += 1
                                    Else
                                        '-- Since there is existing, we only want to update that existing assignment
                                        '   but only update rework elements, and only where rework exists and original assignment's rework elements are empty
                                        '   If external assignment's overall RW and improvement RW contain something and existing assignment's overall RW and improvement RW do not, 
                                        '   ... then overwrite RW elements
                                        '   If external assignment's overall RW and improvement RW are empty, skip this student
                                        '   if existing assignment and new assignment both have overall RW and improvement RW contents, 
                                        '   ... then notify the user to process it manually (or give a sync decider dialog)
                                        If tempAsmt.OverallCommentsRework.Trim().Length + tempAsmt.ImprovementCommentsRework.Trim().Length = 0 Then
                                            '-- skip and leave existing asmt alone
                                            Continue For
                                        Else
                                            '-- external assignment has rework contents, make sure existing does not
                                            If permAsmtExisting.OverallCommentsRework.Trim().Length + permAsmtExisting.ImprovementCommentsRework.Trim().Length = 0 Then
                                                '-- Set rework data in existing assignment
                                                permAsmtExisting.OverallCommentsRework = tempAsmt.OverallCommentsRework
                                                permAsmtExisting.ImprovementCommentsRework = tempAsmt.ImprovementCommentsRework
                                                permAsmtExisting.SecondTryPoints = tempAsmt.SecondTryPoints

                                                If txtOverrideMarkerName.Text.Trim() <> String.Empty Then
                                                    '-- Need to override the marker's name
                                                    permAsmtExisting.LastUserFullName = txtOverrideMarkerName.Text.Trim()
                                                Else
                                                    permAsmtExisting.LastUserFullName = tempAsmt.LastUserFullName
                                                End If

                                                If chkMarkImportedAsProcessed.Checked Then
                                                    permAsmtExisting.Processed = True
                                                End If

                                                '-- Update only if new data is greater than old data
                                                If tempStud.PlagiarismSeverity > permStud.PlagiarismSeverity Then
                                                    permStud.PlagiarismSeverity = tempStud.PlagiarismSeverity
                                                End If
                                                permStud.AddToActivityLog("Updated existing assignment (" & permAsmtExisting.BaseAssignment.Name & ")  with imported rework data.")
                                                intUpdatesMade += 1
                                            Else
                                                '-- Both new asmt and existing asmt have rework contents, need user to decide case by case (special dialog needed here)
                                                Dim resolverData As New SyncResolverNormalData()
                                                resolverData.Student = permStud
                                                resolverData.TempAssignment = tempAsmt
                                                resolverData.PermExistingAssignment = permAsmtExisting
                                                m_lstSyncResolverNormal.Add(resolverData)
                                            End If
                                        End If
                                    End If

                                Else
                                    boolSkipBTEC = True '-- just notify at the end (not a thousand times during processing)
                                End If
                            Next
                        Next
                    Next

                    AddApplicationHistory("Bulk import of rework data (" & grp.Name & "). " & intUpdatesMade.ToString("#,##0") & " assessments updated or created.")

                    If boolSkipBTEC Then
                        MessageBox.Show("Skipped BTEC assignments (functionality not implemented).")
                    End If

                    MessageBox.Show("Done. " & intUpdatesMade.ToString("#,##0") & " assessments updated or created.")
                End If
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message)
        End Try
    End Sub
    Private Function GetLocalBaseAssignmentByID(id As String) As IClassAssignment
        For Each asmt As ClassAssignment In m_objLocalClassGroup.Assignments
            If asmt.ID = id Then
                Return asmt
            End If
        Next

        For Each asmt As ClassAssignmentBTEC In m_objLocalClassGroup.AssignmentsBTEC
            If asmt.ID = id Then
                Return asmt
            End If
        Next

        Return Nothing '-- could not match regular or BTEC assignment
    End Function

    Private Sub txtSemesterFile_DragOver(sender As Object, e As DragEventArgs) Handles txtSemesterFile.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub txtSemesterFile_DragDrop(sender As Object, e As DragEventArgs) Handles txtSemesterFile.DragDrop
        Try
            Dim boolReadyToLoad As Boolean
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim objFilenames As Object = e.Data.GetData(DataFormats.FileDrop)
                Dim strFilenames() As String = CType(objFilenames, String())
                For Each strFilename As String In strFilenames
                    txtSemesterFile.Text = strFilename
                    boolReadyToLoad = True
                    Exit For
                Next
            End If

            If boolReadyToLoad Then
                LoadSemesterFile()
            End If

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error adding the file: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvStudentsBTEC_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStudentsBTEC.ColumnHeaderMouseClick
        '-- not implemented yet
    End Sub

    Private Sub dgvStudentsNormal_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStudentsNormal.ColumnHeaderMouseClick
        Try
            Dim col As DataGridViewColumn = dgvStudentsNormal.Columns(e.ColumnIndex)
            Dim lst As List(Of ReportData) = dgvStudentsNormal.DataSource
            Dim cmp As IComparer(Of ReportData)
            Dim boolSort As Boolean = True

            If col IsNot Nothing Then
                Select Case col.DataPropertyName
                    Case "ExtStudentID"
                        cmp = New ReportDataComparerByExtStudentID
                    Case "StudentID"
                        cmp = New ReportDataComparerByStudentID
                    Case "StudentTeam"
                        cmp = New ReportDataComparerByStudentTeam
                    Case "StudentGroup"
                        cmp = New ReportDataComparerByStudentGroup
                    Case "CountMatchingAssignmentsNormal"
                        cmp = New ReportDataComparerByCountMatchingAssignmentsNormal
                    Case "AssignmentScoreFirst"
                        cmp = New ReportDataComparerByAssignmentScoreFirst
                    Case "Tags"
                        cmp = New ReportDataComparerByTags
                    Case "Overall"
                        cmp = New ReportDataComparerByOverall
                    Case "Overall2"
                        cmp = New ReportDataComparerByOverall2
                    Case "Nickname"
                        cmp = New ReportDataComparerByNickname
                    Case "LocalName"
                        cmp = New ReportDataComparerByLocalName
                    Case "AltID"
                        cmp = New ReportDataComparerByAltID
                    Case "AdminNumber"
                        cmp = New ReportDataComparerByAdminNumber
                    Case "Improvement"
                        cmp = New ReportDataComparerByImprovement
                    Case "Improvement2"
                        cmp = New ReportDataComparerByImprovement2
                    Case "AssignmentScoreSecond"
                        cmp = New ReportDataComparerByAssignmentScoreSecond
                    Case "PresentationQuality"
                        cmp = New ReportDataComparerByPresentationQuality
                    Case "SchoolClass"
                        cmp = New ReportDataComparerBySchoolClassName
                    Case "Creator"
                        cmp = New ReportDataComparerByCreator
                    Case "Editor"
                        cmp = New ReportDataComparerByEditor
                    Case Else
                        boolSort = False
                End Select

                If boolSort Then
                    lst.Sort(cmp)
                    dgvStudentsNormal.DataSource = Nothing
                    dgvStudentsNormal.Refresh()
                    dgvStudentsNormal.DataSource = lst
                    dgvStudentsNormal.Refresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error sorting: " & ex.Message)
        End Try
    End Sub

    Private Sub ManagableColumnSizesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagableColumnSizesToolStripMenuItem.Click
        For Each col As DataGridViewColumn In dgvStudentsNormal.Columns
            col.Width = 80
        Next
        For Each col As DataGridViewColumn In dgvStudentsBTEC.Columns
            col.Width = 80
        Next
    End Sub

    Private Sub DeleteemptyAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteemptyAssignmentsToolStripMenuItem.Click
        Dim asmt As IClassAssignment = GetSelectedAssignment()
        Dim lstToRemove As New List(Of ReportData)

        '-- assignments without feedback or grade get added to the remove list
        If asmt.AssignmentType = AssignmentType.Normal Then
            For Each objData As ReportData In m_lstCurrentListOfStudents
                If objData.Improvement.Trim().Length = 0 AndAlso objData.Improvement2.Trim().Length = 0 _
                    AndAlso objData.Overall.Trim().Length = 0 AndAlso objData.Overall2.Trim().Length = 0 _
                    AndAlso objData.AssignmentScoreFirst = 0 AndAlso objData.AssignmentScoreSecond = 0 Then

                    lstToRemove.Add(objData)
                End If
            Next
        Else
            For Each objData As ReportData In m_lstCurrentListOfStudents
                If objData.Improvement.Trim().Length = 0 AndAlso objData.Improvement2.Trim().Length = 0 _
                    AndAlso objData.Overall.Trim().Length = 0 AndAlso objData.Overall2.Trim().Length = 0 _
                    AndAlso objData.AchievedPass = False Then

                    lstToRemove.Add(objData)
                End If
            Next
        End If

        '-- Actually remove items from main list
        For Each objData As ReportData In lstToRemove
            m_lstCurrentListOfStudents.Remove(objData)
        Next

        '-- Reload the grid
        If asmt.AssignmentType = AssignmentType.Normal Then
            dgvStudentsNormal.DataSource = Nothing
            dgvStudentsNormal.DataSource = m_lstCurrentListOfStudents
        Else
            dgvStudentsBTEC.DataSource = Nothing
            dgvStudentsBTEC.DataSource = m_lstCurrentListOfStudents
        End If


        lblStudentCount.Text = "Students: " & m_lstCurrentListOfStudents.Count.ToString("#,##0")

    End Sub
End Class