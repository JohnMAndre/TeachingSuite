Imports System.Windows.Forms

Public Class MainFormPlain
    Implements IMainForm

    Private WithEvents m_bkgndExportAttendence As System.ComponentModel.BackgroundWorker
    Private WithEvents m_bkgndExportStudents As System.ComponentModel.BackgroundWorker
    Private WithEvents m_bkgndExportStudentGrades As System.ComponentModel.BackgroundWorker
    Private WithEvents m_bkgndExportModuleResults As System.ComponentModel.BackgroundWorker
    Private WithEvents m_bkgndExportMarkingResults As System.ComponentModel.BackgroundWorker
    Private WithEvents m_bkgndExportMarkingResultsIsolated As System.ComponentModel.BackgroundWorker
    Private WithEvents m_bkgndAutoSave As New System.ComponentModel.BackgroundWorker()
    Private WithEvents m_bkgndDelayedActions As New System.ComponentModel.BackgroundWorker()


    Private m_lstCurrentScheduleItems As New List(Of ActualSessionItem)
    Private m_intReorderAdminCounter As Integer
    Private m_dtLastAutoSave As Date

    Private m_lstFoundStudents As New List(Of Student)
    Private m_lstCurrentListOfStudents As List(Of Student)

    Private Sub MainForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ThisSemester IsNot Nothing Then
            '-- Save back any changes
            ThisSemester.Notes = txtSemesterNotes.Text
            Try
                ThisSemester.Save()
            Catch ex As Exception
                Log(ex)
                Dim rslt As DialogResult = MessageBox.Show("There was an error saving this semester. Do you want to close WITHOUT saving?" & _
                                                           Environment.NewLine & Environment.NewLine & "This will cause you to LOSE the DATA since you opened this application.", _
                                                           Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                If rslt = System.Windows.Forms.DialogResult.Yes Then
                    Log("User chose to close without saving after save error.", 1)
                    Exit Sub
                Else
                    e.Cancel = True
                    Exit Sub
                End If
            End Try

            '-- backup after saving (in case data file is over written between uses
            MakeBackupDataFile(ThisSemester.Name, "postsave")
        End If

        AppSettings.Notes = txtNotes.Text


        AppSettings.Save()
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AppSettings = New ApplicationSettings()

        MainFormReference = Me

        '-- stupid krypton
        AddHandler lstAssignments.DoubleClick, AddressOf lstAssignments_DoubleClick


        '-- Load semester list
        LoadSemesters()


        If AppSettings.LastSemesterFile.Length > 0 Then
            '-- Select previously used semester file
            For Each item As String In cboSemester.Items
                If item = AppSettings.LastSemesterFile Then
                    cboSemester.SelectedItem = item
                    LoadSemester()
                    Me.pnlSelectSemester.Hide()
                    Exit For
                End If
            Next
        End If


        m_dtLastAutoSave = Date.Now

        dtpScheduleDate.Value = Today
        LoadSchedule()

        txtNotes.Text = AppSettings.Notes

        tmrAutoSave.Start()


        '-- setup spell check for notes
        'C1SpellChecker1.MainDictionary.FileName = GetDictionaryFilename()
        'C1SpellChecker1.SetActiveSpellChecking(txtNotes, True)

        '-- Check for update
        Dim ts As TimeSpan = Date.Now - AppSettings.LastUpdateCheck
        If ts.TotalDays > 30 Then
            CheckForupdatesToolStripMenuItem.PerformClick()
        End If
        If ts.TotalDays > 0.5 Then
            CheckForupdatesToolStripMenuItem.ToolTipText = "Last checked " & ts.TotalDays.ToString("#,##0.0") & " days ago."
        End If

        '-- Setup dgvStudents stuff
        Dim typEnum As System.Type
        typEnum = GetType(AttendanceStatusEnum)
        dcolAttendanceStatus.DataSource = [Enum].GetValues(typEnum)
        dcolAttendanceStatus.ValueType = typEnum

        typEnum = GetType(Student.GenderEnum)
        dcolGender.DataSource = [Enum].GetValues(typEnum)
        dcolGender.ValueType = typEnum

        If ThisSemester Is Nothing Then
            AddApplicationHistory("Opened app without active semester")
        Else
            AddApplicationHistory("Opened app. Active semester: " & ThisSemester.Name)
        End If

        m_bkgndDelayedActions.RunWorkerAsync()
    End Sub

    Private Sub LoadSemesters()
        Dim lstSemesters As List(Of String) = Semester.ListExistingSemesters()
        'Dim files() As String

        '-- uncompressed
        '        files = System.IO.Directory.GetFiles(GetDataFolder(), "*" & DATA_FILE_EXTENSION)
        '        Array.Sort(files)

        cboSemester.Items.Clear()
        For Each strFilename As String In lstSemesters
            If strFilename = DUMMY_SEMESTER_NAME Then
                '-- Delete the dummy semester file (keep system clean)
                Try
                    System.IO.File.Delete(System.IO.Path.Combine(GetDataFolder(), strFilename & DATA_FILE_EXTENSION))
                Catch ex As Exception
                    Log(ex) '-- just log and continue, not a huge problem if it stays there
                End Try
            Else
                cboSemester.Items.Add(System.IO.Path.GetFileNameWithoutExtension(strFilename))
            End If
        Next

        cboSemester.Items.Add("<Add New>")
        btnLoadSemester.Enabled = False
    End Sub
    Private Sub cboSemester_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSemester.SelectedIndexChanged
        If cboSemester.SelectedIndex = cboSemester.Items.Count - 1 Then
            Using frm As New AddSemester()
                frm.ShowDialog(Me)
                LoadSemesters()
            End Using
        ElseIf cboSemester.SelectedIndex = -1 Then
            btnLoadSemester.Enabled = False
            dtpSemesterStart.Enabled = False
            dtpSemesterEnd.Enabled = False
            dtpSemesterStartCurrent.Enabled = False
            dtpSemesterEndCurrent.Enabled = False
        Else
            If ThisSemester IsNot Nothing Then
                If cboSemester.Items(cboSemester.SelectedIndex) = ThisSemester.Name Then
                    dtpSemesterStart.Enabled = True
                    dtpSemesterEnd.Enabled = True
                    btnLoadSemester.Enabled = False
                    dtpSemesterStartCurrent.Enabled = True
                    dtpSemesterEndCurrent.Enabled = True
                Else
                    btnLoadSemester.Enabled = True
                    dtpSemesterStart.Enabled = False
                    dtpSemesterEnd.Enabled = False
                    dtpSemesterStartCurrent.Enabled = False
                    dtpSemesterEndCurrent.Enabled = False
                End If
            Else
                btnLoadSemester.Enabled = True
                dtpSemesterStart.Enabled = False
                dtpSemesterEnd.Enabled = False
                dtpSemesterStartCurrent.Enabled = False
                dtpSemesterEndCurrent.Enabled = False
            End If
        End If
    End Sub

    Private Sub llblCloseSemesterPanel_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblCloseSemesterPanel.Click
        Me.pnlSelectSemester.Hide()
    End Sub

    Private Sub LoadClassGroups()
        lstAssignments.Items.Clear()
        lstClasses.Items.Clear()
        lstClassGroups.Items.Clear()
        For Each objClassGroup As ClassGroup In ThisSemester.ClassGroups
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
                Application.DoEvents()
                LoadStudents()
            End If
        End If
    End Sub
    Private Sub MakeBackupDataFile(filename As String, extra As String)
        Try
            Const BACKUP_EXTENSION As String = ".backup"
            Dim strSource As String = System.IO.Path.Combine(GetDataFolder(), filename) & DATA_FILE_EXTENSION
            Dim strDestination As String = System.IO.Path.Combine(GetBackupFolder(), filename) & "." & Date.Now.ToString("yyyyMMddHHmmss") & "." & extra & BACKUP_EXTENSION
            System.IO.File.Copy(strSource, strDestination)

            '-- if there are too many backups (for this semester), trim it down
            Dim files() As String = System.IO.Directory.GetFiles(GetBackupFolder(), filename & ".*" & BACKUP_EXTENSION)
            If files.Length > AppSettings.DataBackupsToRetain Then
                '-- now, need to sort and trim
                Dim intToDelete As Integer = files.Length - AppSettings.DataBackupsToRetain
                Array.Sort(files)
                For intCounter As Integer = 0 To intToDelete - 1
                    'Console.WriteLine(files(intCounter))
                    System.IO.File.Delete(files(intCounter))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Backup error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadSemester()
        Try
            '-- First make a 'pre-load' backup
            MakeBackupDataFile(cboSemester.Items(cboSemester.SelectedIndex), "preload")

            '-- Load the selected semester from data file
            Dim strSemesterName As String = cboSemester.Items(cboSemester.SelectedIndex)
            Dim fi As System.IO.FileInfo = Semester.GetAutoSaveFileInfo(strSemesterName)

            If fi IsNot Nothing Then
                Dim frmAutoSave As New AutoSaveRecovery(strSemesterName)
                If frmAutoSave.ShowDialog() = DialogResult.Cancel Then
                    '-- should not load anything
                    Exit Sub
                Else
                    '-- The autosave form did all the work
                    Application.DoEvents() '-- for breakpoint only
                End If
            End If

            '-- clear old data (for user experience only)
            lstClasses.Items.Clear()
            lstClassGroups.Items.Clear()
            lstAssignments.Items.Clear()
            dgvStudents.DataSource = Nothing

            ThisSemester = New Semester(strSemesterName)
            AppSettings.LastSemesterFile = cboSemester.Items(cboSemester.SelectedIndex)
            Me.Text = Application.ProductName & " - " & ThisSemester.Name
            btnLoadSemester.Enabled = False

            dtpSemesterStart.Value = ThisSemester.StartDateOverall
            dtpSemesterEnd.Value = ThisSemester.EndDateOverall
            If ThisSemester.StartDateCurrent > New Date(2010, 1, 1) Then
                dtpSemesterStartCurrent.Value = ThisSemester.StartDateCurrent
            End If
            If ThisSemester.StartDateCurrent > New Date(2010, 1, 1) Then
                dtpSemesterEndCurrent.Value = ThisSemester.EndDateCurrent
            End If

            dtpSemesterStart.Enabled = True
            dtpSemesterEnd.Enabled = True
            dtpSemesterStartCurrent.Enabled = True
            dtpSemesterEndCurrent.Enabled = True

            txtSemesterNotes.Text = ThisSemester.Notes

            AddApplicationHistory("Loaded semester: " & ThisSemester.Name)

            LoadClassGroups()
            'olvStudents.ClearObjects()
            dgvStudents.DataSource = Nothing
            LoadSchedule()

        Catch ex As Exception
            MessageBox.Show("There was an error loading the selected semester: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnLoadSemester_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnLoadSemester.Click
        LoadSemester()
    End Sub

    Private Sub dtpSemesterStart_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpSemesterStart.ValueChanged
        ThisSemester.StartDateOverall = dtpSemesterStart.Value
    End Sub

    Private Sub dtpSemesterEnd_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpSemesterEnd.ValueChanged
        ThisSemester.EndDateOverall = dtpSemesterEnd.Value
    End Sub

    Private Sub llblAddClass_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnAddClass.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intClasses As Integer = GetSelectedClassGroup.Classes.Count + 1
            Dim strDefaultName As String = GetSelectedClassGroup.Name & "-" & intClasses.ToString()
            Dim strNewClass As String = GetInput("What would you like to call the new class?", False, strDefaultName)
            If strNewClass = Chr(0) Then
                '-- do nothing
            ElseIf strNewClass.ToLower() = COMBINED_VIEW_NAME.ToLower() Then
                MessageBox.Show(COMBINED_VIEW_NAME & " is a protected name. Please choose a different name for your class.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '--  add class
                Dim objNewClass As New SchoolClass(GetSelectedClassGroup())
                objNewClass.Name = strNewClass
                GetSelectedClassGroup.Classes.Add(objNewClass)
                LoadClasses()
            End If
        End If
    End Sub
    Private Function GetSelectedStudentsFromGrid() As List(Of Student)
        Dim lstReturn As New List(Of Student)

        Dim cells As DataGridViewSelectedCellCollection

        cells = dgvStudents.SelectedCells

        Dim row As DataGridViewRow
        Dim stud As Student

        Dim dict As New Dictionary(Of Integer, Object)
        For Each cell As DataGridViewCell In cells
            If Not dict.ContainsKey(cell.RowIndex) Then
                dict.Add(cell.RowIndex, Nothing)

                row = dgvStudents.Rows(cell.RowIndex)
                stud = row.DataBoundItem
                If stud IsNot Nothing Then
                    lstReturn.Add(stud)
                End If
            End If
        Next
        Return lstReturn
    End Function

    Private Function GetSelectedStudentGridCanOnlyBeOne() As Student
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid()

        If lstStudents.Count = 0 Then
            Return Nothing
        ElseIf lstStudents.Count > 1 Then
            MessageBox.Show("Please select only one student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Else
            Return lstStudents(0)
        End If

    End Function
    Private Function GetSelectedAssignment() As IClassAssignment
        If lstAssignments.SelectedIndex = -1 Then
            If GetSelectedClassGroup.LastAssignmentUsed IsNot Nothing Then
                '-- we have a defaul asmt, use it since nothing is selected
                Return GetSelectedClassGroup.LastAssignmentUsed
            Else
                '-- no default asmt
                If lstAssignments.Items.Count = 1 Then
                    lstAssignments.SelectedIndex = 0
                Else
                    Return Nothing
                End If
            End If
        End If

        Dim asmt As IClassAssignment = lstAssignments.Items(lstAssignments.SelectedIndex)
        GetSelectedClassGroup.LastAssignmentUsed = asmt
        Return asmt

    End Function
    Private Function GetSelectedClassGroup() As ClassGroup
        If lstClassGroups.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstClassGroups.Items(lstClassGroups.SelectedIndex)
        End If
    End Function
    Public Function GetSelectedClass() As SchoolClass Implements IMainForm.GetSelectedClass
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
    Private Sub btnEditClass_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnEditClass.Click
        EditSelectedClass()
    End Sub
    Private Sub LoadStudents()
        Dim objClass As SchoolClass = GetSelectedClass()
        dgvStudents.AutoGenerateColumns = False
        If objClass Is Nothing Then
            'olvStudents.ClearObjects()
            dgvStudents.DataSource = Nothing
        Else
            If ClassIsCombinedView(objClass) Then
                m_lstCurrentListOfStudents = New List(Of Student)
                Dim boolSetAlready As Boolean
                For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                    If Not boolSetAlready Then
                        m_lstCurrentListOfStudents.AddRange(objCls.Students)
                        'olvStudents.SetObjects(objCls.Students)
                        boolSetAlready = True
                    Else
                        '-- Need to ensure all students in all classes in this module are loaded
                        m_lstCurrentListOfStudents.AddRange(objCls.Students)
                        'olvStudents.AddObjects(objCls.Students)
                    End If
                Next
                dgvStudents.DataSource = m_lstCurrentListOfStudents
            Else
                'olvStudents.SetObjects(objClass.Students)
                m_lstCurrentListOfStudents = objClass.Students
                dgvStudents.DataSource = m_lstCurrentListOfStudents
            End If
        End If

        Try
            dgvStudents.AutoResizeColumns()
        Catch ex As Exception
            Log(ex) '-- Log and continue
        End Try

        m_lstRandomlySelected.Clear()
        ShowStudentCount()
    End Sub
    Private Function ConvertStudentListToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Try
            Dim table As New DataTable()

            Dim fields() As System.Reflection.FieldInfo = GetType(T).GetFields()
            For Each field As System.Reflection.FieldInfo In fields
                table.Columns.Add(field.Name, field.FieldType)
            Next

            For Each item As T In list
                Dim row As DataRow = table.NewRow()
                For Each field As System.Reflection.FieldInfo In fields
                    row(field.Name) = field.GetValue(item)
                Next
                table.Rows.Add(row)
            Next

            Return table
        Catch ex As Exception
            Application.DoEvents()
        End Try
    End Function
    Private Sub llblAddStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddStudent.Click
        Dim clas As SchoolClass = GetSelectedClass()
        If clas Is Nothing Then
            MessageBox.Show("Please select a class first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ClassIsCombinedView(clas) Then
            MessageBox.Show("You cannot add to 'Combined View' class.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Using frm As New StudentDetail(clas)
                If frm.ShowDialog = DialogResult.OK Then
                    LoadStudents()
                End If
            End Using
        End If
    End Sub

    Private Sub lstClasses_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClasses.SelectedIndexChanged
        LoadStudents()
    End Sub

    Private Sub btnEditStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnEditStudent.Click
        EditSelectedStudent()
    End Sub
    Private Sub EditSelectedStudent()
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() 'GetSelectedStudentCanOnlyBeOne()
        If stud Is Nothing Then
            Exit Sub
        Else
            Using frm As New StudentDetail(stud)
                If frm.ShowDialog = DialogResult.OK Then
                    'olvStudents.RefreshSelectedObjects()
                    dgvStudents.Refresh()
                End If
            End Using
        End If
    End Sub
    Private Sub EditSelectedStudentGrid()
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid()

        For Each stud As Student In lstStudents
            Using frm As New StudentDetail(stud)
                If frm.ShowDialog = DialogResult.OK Then
                    dgvStudents.Refresh()
                End If
            End Using
        Next
        'Dim cells As DataGridViewSelectedCellCollection = dgvStudents.SelectedCells
        'Dim row As DataGridViewRow
        'Dim stud As Student
        'For Each cell As DataGridViewCell In cells
        '    row = dgvStudents.Rows(cell.RowIndex)
        '    stud = row.DataBoundItem
        '    If stud Is Nothing Then
        '        Exit Sub
        '    Else
        '        Using frm As New StudentDetail(stud)
        '            If frm.ShowDialog = DialogResult.OK Then
        '                dgvStudents.Refresh()
        '            End If
        '        End Using
        '    End If
        'Next
    End Sub

    'Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
    '    If ReorderAdminNumbersToolStripMenuItem.Checked Then
    '        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() 'GetSelectedStudentCanOnlyBeOne()
    '        If stud Is Nothing Then
    '            Exit Sub
    '        Else
    '            m_intReorderAdminCounter += 1
    '            lblRenumberAdminCurrent.Text = m_intReorderAdminCounter.ToString("#,##0")
    '            stud.AdminNumber = m_intReorderAdminCounter
    '            olvStudents.RefreshSelectedObjects()
    '        End If
    '    Else
    '        EditSelectedStudent()
    '    End If
    'End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub TakeAttendenceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TakeAttendenceToolStripMenuItem.Click
        If GetSelectedClass() IsNot Nothing Then
            Using frm As New AttendenceForm(GetSelectedClass())
                If frm.ShowDialog() = DialogResult.OK Then
                    '-- trigger autosave to capture attendance
                    AutoSave()
                End If
            End Using
        Else
            MessageBox.Show("Please select a class first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub llblRemoveStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveStudent.Click
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid() 'GetSelectedStudents()

        If lstStudents.Count > 0 Then
            For Each stud As Student In lstStudents
                If MessageBox.Show("Are you sure you want to remove " & stud.LocalName & " (" & stud.Nickname & ")" & " from " & stud.SchoolClass.Name & "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    stud.SchoolClass.Students.Remove(stud)
                    'olvStudents.RemoveObject(stud)
                End If
            Next
        Else
            MessageBox.Show("Please select one or more students to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtStudentFilter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtStudentFilter.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtStudentFilter.Clear()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="lstFiltered"></param>
    ''' <remarks></remarks>
    Private Sub ShowStudentCount(Optional lstFiltered As List(Of Student) = Nothing)
        If lstFiltered Is Nothing Then
            lblStudentCount.Text = "Students: " & m_lstCurrentListOfStudents.Count().ToString("#,##0")
        Else
            'Dim intFilteredCount As Integer
            'For Each o As Object In olvStudents.FilteredObjects
            '    intFilteredCount += 1
            'Next
            lblStudentCount.Text = "Filtered: " & lstFiltered.Count.ToString("#,##0")
        End If

    End Sub
    Private Sub llblMoveStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblMoveStudent.Click
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid() ' GetSelectedStudents()

        If lstStudents.Count = 0 Then
            MessageBox.Show("Please select one or more students to move.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New ClassSelector(GetSelectedClassGroup())
                If frm.ShowDialog = DialogResult.OK Then
                    If GetSelectedClass() IsNot frm.SelectedClass Then
                        For Each stud As Student In lstStudents
                            GetSelectedClass().Students.Remove(stud)
                            frm.SelectedClass.Students.Add(stud)

                            stud.AddToActivityLog("Student moved from " & GetSelectedClass().Name & " to " & frm.SelectedClass.Name)
                            'olvStudents.RemoveObject(stud)
                            dgvStudents.Refresh() '-- Not sure this will work since it is not bound to a binding list (no notivation of list changes)
                        Next
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub llblRemoveClass_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveClass.Click
        RemoveSelectedClass()
    End Sub

    Private Sub MeritToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MeritToolStripMenuItem.Click
        '-- Give a merit point to each student
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid() 'GetSelectedStudents()
        For Each stud As Student In lstStudents
            stud.MeritPoints += 1
        Next
        'olvStudents.RefreshSelectedObjects()
        dgvStudents.Refresh()
    End Sub

    Private Sub DemeritToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DemeritToolStripMenuItem.Click
        '-- Deduct a merit point from each student
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid() ' GetSelectedStudents()
        For Each stud As Student In lstStudents
            stud.MeritPoints -= 1
        Next
        'olvStudents.RefreshSelectedObjects()
        dgvStudents.Refresh()
    End Sub

    Private Sub llblImportStudents_LinkClicked(sender As System.Object, e As System.EventArgs)
        Using frm As New ImportStudentsFromText(GetSelectedClass())
            If frm.ShowDialog() = DialogResult.OK Then
                LoadStudents()
            End If
        End Using
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            If ThisSemester IsNot Nothing Then
                ThisSemester.Notes = txtSemesterNotes.Text
                ThisSemester.Save()

                UpdateLastSaved()
            End If
            AppSettings.Save()
        Catch ex As Exception
            MessageBox.Show("There was an error (" & ex.Message & ") saving.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSemesterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadSemesterToolStripMenuItem.Click
        pnlSelectSemester.Visible = Not pnlSelectSemester.Visible
    End Sub

    Private Sub llblClearFilter_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblClearFilter.Click
        txtStudentFilter.Text = String.Empty
        txtStudentFilter.Focus()
    End Sub

    Property m_lstRandomlySelected As New List(Of Integer)
    Private Function SelectRandomStudent() As Boolean
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class before requesting a random student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Randomize()
            Dim int As Integer

            '-- don't select the same student twice unless all students have been selected. In that case, clear the list and start anew
            If m_lstRandomlySelected.Count = m_lstCurrentListOfStudents.Count Then
                m_lstRandomlySelected.Clear()
            End If

            Do
                Dim rnd As New Random()
                int = rnd.Next Mod GetSelectedClass.Students.Count
            Loop While m_lstRandomlySelected.Contains(int) '-- select another one

            'If olvStudents.Items.Count <= int Then
            '    MessageBox.Show("Too few students. Is the filter set?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    m_lstRandomlySelected.Add(int)
            '    olvStudents.Items(int).Selected = True
            '    olvStudents.Items(int).EnsureVisible()
            'End If

            'olvStudents.Focus()
            Return True
        End If
    End Function
    Private Sub btnSelectRandomStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnSelectRandomStudent.Click
        SelectRandomStudent()
    End Sub

    Private Sub ExportAttendenceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportAttendanceToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If ClassIsCombinedView(GetSelectedClass()) Then
                '-- classes combined cannot get export of attendance
                MessageBox.Show("Cannot export attendance on combined classes (sessions can be on different days).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim sfd As New SaveFileDialog()
            sfd.Title = "Select export location"
            sfd.AddExtension = True
            sfd.Filter = "Text files (*.txt)|*.txt"
            sfd.OverwritePrompt = True
            sfd.FileName = GetSelectedClass.Name & " Export"
            If sfd.ShowDialog = DialogResult.OK Then
                '-- Export
                m_bkgndExportAttendence = New System.ComponentModel.BackgroundWorker()
                Dim expData As New ExportClassData
                expData.SchoolClass = GetSelectedClass()
                expData.Filename = sfd.FileName
                m_bkgndExportAttendence.RunWorkerAsync(expData)
            End If
        End If
    End Sub


    Private Class ExportModuleResultData
        Public ClassGroup As ClassGroup
        Public Filename As String
    End Class
    Private Class ExportMarkingListData
        Public ClassGroup As ClassGroup
        Public Filename As String
        Public MarkingTry As Semester.MarkingTry
        Public Assignment As IClassAssignment
    End Class

    Private Sub m_bkgndExportAttendence_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndExportAttendence.DoWork
        Dim expData As ExportClassData = CType(e.Argument, ExportClassData)

        expData.SchoolClass.GenerateAttendaceExport(expData.Filename)

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Using frm As New OptionsForm
            If frm.ShowDialog(Me) = DialogResult.OK Then
                '-- reload data which might have changed
                'C1SpellChecker1.MainDictionary.FileName = GetDictionaryFilename()
            End If
        End Using
    End Sub
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
    Private Sub CreateNewBTECAssignment()
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New ClassAssignmentDetails(GetSelectedClassGroup())
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadClassAssignments()
                End If
            End Using
        End If
    End Sub
    Private Sub llblAddAssignment_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddAssignment.Click
        ctxmnuNewAssignment.Show(llblAddAssignment, New Point(0, 0))
    End Sub
    Private Sub EditSelectedAssignment()
        If GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim asmt As IClassAssignment = GetSelectedAssignment()
            Select Case asmt.AssignmentType
                Case AssignmentType.BTEC
                    Using frm As New ClassAssignmentDetails(GetSelectedClassGroup(), GetSelectedAssignment())
                        If frm.ShowDialog(Me) = DialogResult.OK Then
                            LoadClassAssignments()
                        End If
                    End Using
                Case AssignmentType.Normal
                    Using frm As New ClassAssignmentNormalDetails(GetSelectedClassGroup(), GetSelectedAssignment())
                        If frm.ShowDialog(Me) = DialogResult.OK Then
                            LoadClassAssignments()
                        End If
                    End Using
            End Select
        End If
    End Sub
    Private Sub llblEditAssignment_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblEditAssignment.Click
        EditSelectedAssignment()
    End Sub
    Private Sub DeleteSelectedAssignment()
        If GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Are you sure you want to delete " & GetSelectedAssignment.Name & " for the class " & GetSelectedClass.Name & "?" &
                               Environment.NewLine & Environment.NewLine, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                If GetSelectedAssignment.AssignmentType = AssignmentType.BTEC Then
                    GetSelectedClassGroup().AssignmentsBTEC.Remove(GetSelectedAssignment())
                Else
                    GetSelectedClassGroup().Assignments.Remove(GetSelectedAssignment())
                End If
                LoadClassAssignments()
            End If
        End If
    End Sub
    Private Sub llblRemoveAssignment_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveAssignment.Click
        DeleteSelectedAssignment()
    End Sub

    Private Sub CreateNewAssignmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateNewAssignmentToolStripMenuItem.Click
        CreateNewBTECAssignment()
    End Sub

    Private Sub DeleteSelectedAssignmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteSelectedAssignmentToolStripMenuItem.Click
        DeleteSelectedAssignment()
    End Sub

    Private Sub EditSelectedAssignmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditSelectedAssignmentToolStripMenuItem.Click
        EditSelectedAssignment()
    End Sub

    Private Sub PasteNewAssignmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteNewAssignmentToolStripMenuItem.Click
        Try
            Dim xDoc As New Xml.XmlDocument()
            xDoc.LoadXml(Clipboard.GetText)
            Dim objAssignment As New ClassAssignmentBTEC(xDoc.DocumentElement, GetSelectedClassGroup())
            GetSelectedClassGroup.AssignmentsBTEC.Add(objAssignment)
            LoadClassAssignments()
        Catch ex As Exception
            MessageBox.Show("There is no assignment on the clipboard to use. Please copy an existing assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CopyAssignmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyAssignmentToolStripMenuItem.Click
        If GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim xDoc As New Xml.XmlDocument()
            Dim strText As String = GetSelectedAssignment().GetXMLElementToPersist(xDoc).OuterXml
            Clipboard.SetText(strText)
        End If
    End Sub

    Private Sub lstAssignments_DoubleClick(sender As System.Object, e As System.EventArgs)
        EditSelectedAssignment()
    End Sub
    Private Sub StartOralExam(attempt As Semester.MarkingTry)
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class first", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment first", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If attempt = Semester.MarkingTry.FirstTry AndAlso GetSelectedAssignment.ClosedFirstTry Then
            If MessageBox.Show("Are you sure you want to modify the first submission (for: " & GetSelectedAssignment.Name & ")? It has already been closed.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
        ElseIf attempt = Semester.MarkingTry.SecondTry AndAlso Not GetSelectedAssignment.ClosedSecondTry Then
            If MessageBox.Show("Are you sure you want to modify the second submission (for: " & GetSelectedAssignment.Name & ")? It has already been closed.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
        End If

        '-- Must select an assignment for first attempt (not other attempts)
        If attempt = Semester.MarkingTry.FirstTry AndAlso GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment first", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim frm As New OralExamDetails(GetSelectedClass, GetSelectedAssignment, attempt)
        frm.Show()
    End Sub
    Private Sub ExamToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExamToolStripMenuItem.Click
        StartOralExam(Semester.MarkingTry.FirstTry)
    End Sub

    Private Sub ExamRedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExamRedoToolStripMenuItem.Click
        StartOralExam(Semester.MarkingTry.SecondTry)
    End Sub

    Private Sub Exam2ndRedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Exam2ndRedoToolStripMenuItem.Click
        StartOralExam(Semester.MarkingTry.ThirdTry)
    End Sub

    Private Sub ProcessExamForStudent_Click(sender As System.Object, e As System.EventArgs) Handles ProcessExamForStudent.Click
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() 'GetSelectedStudentCanOnlyBeOne()
        If stud IsNot Nothing Then
            MarkExamForStudent(stud, GetSelectedAssignment(), Semester.MarkingTry.FirstTry)
        End If
    End Sub

    Private Sub dtpSemesterStartCurrent_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpSemesterStartCurrent.ValueChanged
        If ThisSemester IsNot Nothing Then
            ThisSemester.StartDateCurrent = dtpSemesterStartCurrent.Value
        End If
    End Sub

    Private Sub dtpSemesterEndCurrent_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpSemesterEndCurrent.ValueChanged
        If ThisSemester IsNot Nothing Then
            ThisSemester.EndDateCurrent = dtpSemesterEndCurrent.Value
        End If
    End Sub

    Private Sub llblEditClassGroup_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblEditClassGroup.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module to edit.", Application.ProductName)
        Else
            Using frm As New ClassGroupDetails(GetSelectedClassGroup())
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadClassGroups()
                End If
            End Using
        End If
    End Sub

    Private Sub llblAddClassGroup_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblAddClassGroup.Click
        If ThisSemester Is Nothing Then
            MessageBox.Show("Please load a semester first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim strNewClass As String = GetInput("What would you like to call the new module?", False, "Module A")
            If strNewClass = Chr(0) Then
                '-- do nothing
            Else
                '--  add class
                Dim objNewClassGroup As New ClassGroup(ThisSemester)
                objNewClassGroup.Name = strNewClass
                ThisSemester.ClassGroups.Add(objNewClassGroup)
                LoadClassGroups()
            End If
        End If
    End Sub

    Private Sub llblRemoveClassGroup_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRemoveClassGroup.Click
        Dim intClasses As Integer = GetSelectedClassGroup.Classes.Count
        If MessageBox.Show("Are you sure you want to delete " & GetSelectedClassGroup.Name & "?" &
                           Environment.NewLine & Environment.NewLine &
                           "It has " & intClasses.ToString("#,##0") & " classes.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            ThisSemester.ClassGroups.Remove(GetSelectedClassGroup())
            LoadClassGroups()
        End If
    End Sub

    Private Sub lstClassGroups_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClassGroups.SelectedIndexChanged
        'olvStudents.ClearObjects()
        dgvStudents.DataSource = Nothing
        LoadClassAssignments()
        LoadClasses()
    End Sub

    Private Sub StudentAttendanceErrorsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentAttendanceErrorsToolStripMenuItem.Click
        If ThisSemester Is Nothing Then
            MessageBox.Show("Please load a semester first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New AttendenceErrors()
            frm.Show(Me)
        End If
    End Sub

    Private Sub MarkExamForStudent(student As Student, assignment As IClassAssignment, attempt As Semester.MarkingTry)
        If assignment Is Nothing Then
            MessageBox.Show("Please select an assignment first", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If student Is Nothing Then
            MessageBox.Show("Please select a student first", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If attempt = Semester.MarkingTry.FirstTry AndAlso assignment.ClosedFirstTry Then
            If MessageBox.Show("Are you sure you want to modify the first submission (for: " & assignment.Name & ")? It has already been closed.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
            'ElseIf attempt = Semester.MarkingTry.SecondTry AndAlso Not student.SchoolClass.ClassGroup.Closed Then
        ElseIf attempt = Semester.MarkingTry.SecondTry AndAlso assignment.ClosedSecondTry Then
            'MessageBox.Show("You must 'close' the semester (for: " & student.SchoolClass.Name & ") before entering redo. Go to Tools->Close regular semeseter.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MessageBox.Show("Are you sure you want to modify the second submission (for: " & assignment.Name & ")? It has already been closed.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
        End If

        AddApplicationHistory("Marking " & assignment.Name & " (class: " & student.SchoolClass.Name & "; student: " & student.ToString() & ")")

        Select Case assignment.AssignmentType
            Case AssignmentType.BTEC
                Dim frm As New StudentAssignmentDetails(student, CType(assignment, ClassAssignmentBTEC), attempt)
                frm.Show()
            Case AssignmentType.Normal
                Dim frm As New StudentAssignmentNormalDetails(student, CType(assignment, ClassAssignment), attempt)
                frm.Show()
        End Select
    End Sub
    Private Sub ProcessExamRedoForStudent_Click(sender As System.Object, e As System.EventArgs) Handles ProcessExamRedoForStudent.Click
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() ' GetSelectedStudentCanOnlyBeOne()
        If stud IsNot Nothing Then
            MarkExamForStudent(stud, GetSelectedAssignment(), Semester.MarkingTry.SecondTry)
        End If
    End Sub

    Private Sub ProcessExam2ndReDoForStudent_Click(sender As System.Object, e As System.EventArgs) Handles ProcessExam2ndReDoForStudent.Click
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() 'GetSelectedStudentCanOnlyBeOne()
        If stud IsNot Nothing Then
            MarkExamForStudent(stud, GetSelectedAssignment(), Semester.MarkingTry.ThirdTry)
        End If
    End Sub

    Private Sub AssignmentResultsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AssignmentResultsToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf TypeOf GetSelectedAssignment() Is ClassAssignment Then
            MessageBox.Show("This report is only for BTEC assignments.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Using frm As New AssignmentResults(GetSelectedClassGroup(), GetSelectedAssignment())
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub QuitWithoutSavingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitWithoutSavingToolStripMenuItem.Click
        AddApplicationHistory("Closed app without saving.")

        ThisSemester = Nothing '-- this will stop backing and saving logic from firing
        Close()
    End Sub

    Private Sub ModuleResultsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModuleResultsToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim groupToInclude As ClassGroup
        Dim frm As ModuleResults

        If GetSelectedClass() Is Nothing OrElse ClassIsCombinedView(GetSelectedClass()) Then
            '-- use whole module
            frm = New ModuleResults(GetSelectedClassGroup())
        Else
            groupToInclude = New ClassGroup(GetSelectedClassGroup.GetXMLElementToPersist(New Xml.XmlDocument()), ThisSemester) '-- not sure if this will work
            Dim lstToRemove As New List(Of SchoolClass)
            For Each cls As SchoolClass In groupToInclude.Classes
                If cls.Name <> GetSelectedClass().Name Then
                    lstToRemove.Add(cls)
                End If
            Next
            For Each cls As SchoolClass In lstToRemove
                groupToInclude.Classes.Remove(cls)
            Next
            frm = New ModuleResults(groupToInclude)
        End If
        frm.Show(Me)
    End Sub

    Private Sub ImportAttendanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportAttendanceToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Teaching App databases|*" & DATA_FILE_EXTENSION
        ofd.Title = "Select attendence file to access."
        If ofd.ShowDialog = DialogResult.OK Then
            Dim frm As New AttendenceImport(ofd.FileName)
            frm.Show(Me)
        End If
    End Sub

    Private Sub ClassSelectorsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassSelectorsToolStripMenuItem.Click
        splitOverall.Panel1Collapsed = Not splitOverall.Panel1Collapsed
    End Sub

    Private Sub ViewToolStripMenuItem_DropDownOpening(sender As System.Object, e As System.EventArgs) Handles ViewToolStripMenuItem.DropDownOpening
        ClassSelectorsToolStripMenuItem.Checked = Not splitOverall.Panel1Collapsed
    End Sub
    Private Sub RemoveCurrentStudent()
        '-- take out of class for the day
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid() 'GetSelectedStudents()

        For Each stud As Student In lstStudents
            stud.CurrentAttendenceStatus = AttendanceStatusEnum.Removed
            stud.TeachingSessions(stud.TeachingSessions.Count - 1).AttendenceStatus = AttendanceStatusEnum.Removed
            stud.MeritPoints -= 1 '-- 1 demerit for removal
            'olvStudents.RefreshSelectedObjects()
            dgvStudents.Refresh() '--- Might need to bind to a binding list to make this work
        Next
    End Sub
    Private Sub btnRemoveStudent_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnRemoveStudent.Click
        RemoveCurrentStudent()
    End Sub


    Private Sub EmailAssignmentResultsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmailAssignmentResultsToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to email.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim objClassToSend As SchoolClass
            Dim objClass As SchoolClass = CType(lstClasses.Items(lstClasses.SelectedIndex), SchoolClass)
            If ClassIsCombinedView(objClass) Then
                Dim boolSetAlready As Boolean
                For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                    If Not boolSetAlready Then
                        Dim grp As New ClassGroup(Nothing)
                        grp.UseNickname = GetSelectedClassGroup.UseNickname
                        objClassToSend = New SchoolClass(grp)
                        objClassToSend.Name = objClass.ClassGroup.Name & " (combined view)" '-- helpful for logging 
                        objClassToSend.Students.AddRange(objCls.Students)
                        boolSetAlready = True
                    Else
                        objClassToSend.Students.AddRange(objCls.Students)
                    End If
                Next
            Else
                objClassToSend = objClass
            End If

            objClassToSend.ClassGroup = GetSelectedClassGroup()
            Dim frm As New EmailModuleResults(objClassToSend)
            frm.Show(Me)
        End If
    End Sub

    Private Sub FormGroupsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormGroupsToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to group.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New BuildGroups(GetSelectedClass())
                frm.ShowDialog(Me)
            End Using
        End If
    End Sub

    Private Sub EditStudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditStudentToolStripMenuItem.Click
        EditSelectedStudent()
    End Sub

    Private Sub ModuleFeedbackCheckToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModuleFeedbackCheckToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module to use.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New ModuleFeedbackVerification(GetSelectedClassGroup())
            frm.Show(Me)
        End If
    End Sub

    Private Sub ExportModuleResultsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportModuleResultsToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim sfd As New SaveFileDialog()
            sfd.Title = "Select export location"
            sfd.AddExtension = True
            sfd.Filter = "Text files (*.txt)|*.txt"
            sfd.OverwritePrompt = True
            sfd.FileName = GetSelectedClassGroup.Name & " Module Results Export"
            If sfd.ShowDialog = DialogResult.OK Then
                '-- Export
                m_bkgndExportModuleResults = New System.ComponentModel.BackgroundWorker()
                Dim expData As New ExportModuleResultData
                expData.ClassGroup = GetSelectedClassGroup()
                expData.Filename = sfd.FileName
                m_bkgndExportModuleResults.RunWorkerAsync(expData)
            End If
        End If
    End Sub

    Private Sub m_bkgndExportModuleResults_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndExportModuleResults.DoWork
        Dim expData As ExportModuleResultData = CType(e.Argument, ExportModuleResultData)

        expData.ClassGroup.GenerateModuleReultsExport(expData.Filename, Semester.MarkingTry.ThirdTry, Nothing)
    End Sub

    Private Sub m_bkgndExportMarkingResults_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndExportMarkingResults.DoWork
        Dim expData As ExportMarkingListData = CType(e.Argument, ExportMarkingListData)

        expData.ClassGroup.GenerateMarkingList(expData.Filename, expData.Assignment, expData.MarkingTry)
    End Sub
    Private Sub m_bkgndExportMarkingResultsIsolated_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndExportMarkingResultsIsolated.DoWork
        Dim expData As ExportMarkingListData = CType(e.Argument, ExportMarkingListData)

        expData.ClassGroup.GenerateMarkingListIsolated(expData.Filename, expData.Assignment, expData.MarkingTry)
    End Sub

    Private Sub ImportStudentsFromTextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportStudentsFromTextToolStripMenuItem.Click
        Try
            If GetSelectedClass() Is Nothing Then
                MessageBox.Show("Please select a class to receive students.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Using frm As New ImportStudentsFromText(GetSelectedClass())
                    Dim rst As DialogResult = frm.ShowDialog(Me)
                    If rst = DialogResult.OK Then
                        LoadStudents()
                    End If
                End Using
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub




    ''' <summary>
    ''' Will change outcome marks from pass to fail if there are any 'unknown' status on the matching assignment
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CleanUpStudentAssignments(group As ClassGroup, targetAssignment As IClassAssignment, submission As Semester.MarkingTry)
        Try
            'Dim boolAssignmentNotSubmitted As Boolean

            'For Each group As ClassGroup In ThisSemester.ClassGroups

            '-- first, check to see if earlier submissions are closed already
            If submission = Semester.MarkingTry.SecondTry AndAlso Not targetAssignment.ClosedFirstTry Then
                MessageBox.Show("You must close the first submission before closing rework.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Throw New Exception("Earlier submissions not closed yet.")
            ElseIf submission = Semester.MarkingTry.ThirdTry AndAlso (Not targetAssignment.ClosedFirstTry OrElse Not targetAssignment.ClosedSecondTry) Then
                MessageBox.Show("You must close the first and second submission before closing third submission.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Throw New Exception("Earlier submissions not closed yet.")
            End If

            '-- Removing logic to clean up open student assignments when closing an assignment
            'For Each clas As SchoolClass In group.Classes
            '    For Each stud As Student In clas.Students

            '        For Each asmt As StudentAssignment In stud.Assignments
            '            '-- If there are any outcomes with status 'unknown' then we know the student didn't submit that assignment
            '            '   then we fail all outcomes on that assignment with comments of 'did not submit'
            '            '   If the student doesn't have the right number of total outcomes (that means he did not submit)
            '            '   then we add the assignment, failing all outcomes with comments of 'did not submit'
            '            If asmt.BaseAssignment Is targetAssignment Then
            '                boolAssignmentNotSubmitted = False
            '                Select Case submission
            '                    Case Semester.MarkingTry.FirstTry
            '                        For Each oc As OutcomeResult In asmt.Outcomes
            '                            If oc.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
            '                                boolAssignmentNotSubmitted = True
            '                                Exit For '-- just need one
            '                            End If
            '                        Next

            '                        If boolAssignmentNotSubmitted Then
            '                            For Each oc As OutcomeResult In asmt.Outcomes
            '                                oc.FirstTryStatus = OutcomeResultStatusEnum.Fail
            '                                oc.FirstTryComments = AppSettings.AssignmentNotSubmittedDefaultOutcomeComment
            '                            Next
            '                        End If
            '                    Case Semester.MarkingTry.SecondTry
            '                        For Each oc As OutcomeResult In asmt.Outcomes
            '                            If oc.SecondTryStatus = OutcomeResultStatusEnum.Unknown AndAlso oc.FirstTryStatus <> OutcomeResultStatusEnum.Pass Then
            '                                '-- unknown expected if previous submission passed but if not passed, then unknown
            '                                boolAssignmentNotSubmitted = True
            '                                Exit For '-- just need one
            '                            End If
            '                        Next

            '                        If boolAssignmentNotSubmitted Then
            '                            For Each oc As OutcomeResult In asmt.Outcomes
            '                                oc.SecondTryStatus = OutcomeResultStatusEnum.Fail
            '                                oc.SecondTryComments = AppSettings.AssignmentNotSubmittedDefaultOutcomeComment
            '                            Next
            '                        End If
            '                    Case Semester.MarkingTry.ThirdTry
            '                        For Each oc As OutcomeResult In asmt.Outcomes
            '                            If oc.ThirdTryStatus = OutcomeResultStatusEnum.Unknown AndAlso oc.FirstTryStatus <> OutcomeResultStatusEnum.Pass AndAlso oc.SecondTryStatus <> OutcomeResultStatusEnum.Pass Then
            '                                boolAssignmentNotSubmitted = True
            '                                Exit For '-- just need one
            '                            End If
            '                        Next

            '                        If boolAssignmentNotSubmitted Then
            '                            For Each oc As OutcomeResult In asmt.Outcomes
            '                                oc.ThirdTryStatus = OutcomeResultStatusEnum.Fail
            '                                oc.ThirdTryComments = AppSettings.AssignmentNotSubmittedDefaultOutcomeComment
            '                            Next
            '                        End If
            '                End Select
            '            End If
            '        Next

            '        '-- This next step is only for closing first try, after that, asmt must exist
            '        If submission = Semester.MarkingTry.FirstTry Then
            '            Dim boolExists As Boolean
            '            boolExists = False
            '            For Each asmt As StudentAssignment In stud.Assignments
            '                '-- Is it there? If not, add it
            '                If asmt.BaseAssignment Is targetAssignment Then
            '                    boolExists = True
            '                    Exit For
            '                End If
            '            Next

            '            If Not boolExists Then
            '                'boolPassedAllOutcomes = False
            '                '-- this student never got this assignment, so add it
            '                Dim studAsignmnt As StudentAssignment = stud.AddAssignment(targetAssignment)
            '                For Each oc As OutcomeResult In studAsignmnt.Outcomes
            '                    oc.FirstTryStatus = OutcomeResultStatusEnum.Fail
            '                    oc.FirstTryComments = AppSettings.AssignmentNotSubmittedDefaultOutcomeComment
            '                Next
            '            End If
            '        End If
            '    Next
            'Next

            group.Closed = True
            Select Case submission
                Case Semester.MarkingTry.FirstTry
                    targetAssignment.ClosedFirstTry = True
                Case Semester.MarkingTry.SecondTry
                    targetAssignment.ClosedSecondTry = True
                Case Semester.MarkingTry.ThirdTry
                    targetAssignment.ClosedThirdTry = True
            End Select

            AddApplicationHistory("Closed assignment: " & targetAssignment.Name & " (" & submission.ToString() & ")")
        Catch ex As Exception
            MessageBox.Show("There was an error cleaning up the student assignments: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub lstClassGroups_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles lstClassGroups.SelectedValueChanged
        LoadClassAssignments()
        LoadClasses()
        'olvStudents.ClearObjects()
        dgvStudents.DataSource = Nothing
    End Sub

    Private Sub lstClasses_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles lstClasses.SelectedValueChanged
        LoadStudents()
    End Sub

    Private Sub llblRefreshSchedule_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblRefreshSchedule.LinkClicked
        LoadSchedule()
    End Sub
    Private Sub LoadSchedule()
        m_lstCurrentScheduleItems.Clear()
        If ThisSemester IsNot Nothing Then
            For Each grp As ClassGroup In ThisSemester.ClassGroups
                For Each cls As SchoolClass In grp.Classes
                    For Each item As ActualSessionItem In cls.ActualSessions
                        If item.StartDateTime.Date = dtpScheduleDate.Value.Date Then
                            m_lstCurrentScheduleItems.Add(item)
                        End If
                    Next
                Next
            Next
        End If
        m_lstCurrentScheduleItems.Sort()

        Dim bndSrc As New BindingSource()
        bndSrc.DataSource = m_lstCurrentScheduleItems

        dgvSchedule.AutoGenerateColumns = False
        dgvSchedule.DataSource = bndSrc
        dgvSchedule.AutoResizeColumns()

        lblScheduleDay.Text = dtpScheduleDate.Value.DayOfWeek.ToString()
    End Sub
    Private Sub ViewScheduleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewScheduleToolStripMenuItem.Click
        pnlStudentSchedulePanel.Visible = Not ViewScheduleToolStripMenuItem.Checked
    End Sub

    Private Sub llblScheduleForwardOneDay_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblScheduleForwardOneDay.LinkClicked
        dtpScheduleDate.Value = dtpScheduleDate.Value.AddDays(1)
        LoadSchedule()
    End Sub

    Private Sub llblScheduleBackOneDay_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblScheduleBackOneDay.LinkClicked
        dtpScheduleDate.Value = dtpScheduleDate.Value.AddDays(-1)
        LoadSchedule()
    End Sub


    Private Sub dtpScheduleDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpScheduleDate.ValueChanged
        LoadSchedule()
    End Sub

    Private Sub ExportStudentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportStudentsToolStripMenuItem.Click
        Try
            If GetSelectedClass() Is Nothing Then
                MessageBox.Show("Please select a class to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim sfd As New SaveFileDialog()
                sfd.Title = "Select export location"
                sfd.AddExtension = True
                sfd.Filter = "Text files (*.txt)|*.txt"
                sfd.OverwritePrompt = True
                sfd.FileName = GetSelectedClass.Name & " Student Export"
                If sfd.ShowDialog = DialogResult.OK Then
                    '-- Export
                    m_bkgndExportStudents = New System.ComponentModel.BackgroundWorker()
                    Dim expData As New ExportClassData
                    Dim objClassToSend As SchoolClass
                    If ClassIsCombinedView(GetSelectedClass()) Then
                        '-- need all classes combined
                        Dim boolSetAlready As Boolean
                        For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                            If Not boolSetAlready Then
                                Dim grp As New ClassGroup(Nothing)
                                grp.UseNickname = GetSelectedClassGroup.UseNickname
                                objClassToSend = New SchoolClass(grp)
                                objClassToSend.Students.AddRange(objCls.Students)
                                boolSetAlready = True
                            Else
                                objClassToSend.Students.AddRange(objCls.Students)
                            End If
                        Next
                    Else
                        objClassToSend = GetSelectedClass()
                    End If
                    expData.SchoolClass = objClassToSend
                    expData.Filename = sfd.FileName
                    m_bkgndExportStudents.RunWorkerAsync(expData)
                End If
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub m_bkgndExportStudents_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndExportStudents.DoWork
        Dim expData As ExportClassData = CType(e.Argument, ExportClassData)

        expData.SchoolClass.GenerateStudentExport(expData.Filename)
    End Sub

    Private Sub UpdateEmailAddressToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateEmailAddressToolStripMenuItem.Click
        Dim strEmail As String
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() 'GetSelectedStudentCanOnlyBeOne
        If stud IsNot Nothing Then
            strEmail = stud.EmailAddress
        Else
            strEmail = String.Empty
        End If
        Using frm As New UpdateEmailAddressForm(strEmail)
            frm.ShowDialog(Me)
        End Using
    End Sub
    Private Sub SelectRandomStudentAndDisplayMessage()
        If SelectRandomStudent() Then
            Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() 'GetSelectedStudentCanOnlyBeOne

            Select Case MessageBox.Show(stud.Nickname & " - " & stud.LocalName & " - " & stud.CurrentAttendenceStatus.ToString() &
                                                                    Environment.NewLine & Environment.NewLine & "Overall: " & stud.PresentationQuality.ToString() &
                                                                    Environment.NewLine & Environment.NewLine & "Mark removed and select a new student (yes)?" &
                                                                    Environment.NewLine & "Ignore and select a new student (no)?" &
                                                                    Environment.NewLine & "Do nothing (cancel)?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case DialogResult.Yes
                    RemoveCurrentStudent()
                    SelectRandomStudentAndDisplayMessage()
                Case DialogResult.No
                    SelectRandomStudentAndDisplayMessage()
                Case DialogResult.Cancel
                    '-- do nothing
                    Application.DoEvents() '-- for breakpoint
            End Select
        End If
    End Sub
    Private Sub SelectRandomStudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectRandomStudentToolStripMenuItem.Click
        SelectRandomStudentAndDisplayMessage()
    End Sub

    Private Sub EmailstudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmailstudentToolStripMenuItem.Click
        EmailStudent(GetSelectedStudentsFromGrid())
    End Sub
    Private Sub EmailStudent(listOfStudents As List(Of Student))
        Try
            If AppSettings.PathToTrulyMailEXE.Trim.Length = 0 OrElse Not System.IO.File.Exists(AppSettings.PathToTrulyMailEXE) Then
                MessageBox.Show("Please go to Tools->Options on main form and select the path to TrulyMail. TrulyMail must be used for emailing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If listOfStudents.Count = 0 Then
                MessageBox.Show("Please select a student to email.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim tm As Object ' New TrulyMail.NewMessage()
            Dim mainform As System.Runtime.Remoting.ObjectHandle
            Dim obj As Object
            mainform = Activator.CreateInstanceFrom(AppSettings.PathToTrulyMailEXE, "TrulyMail.MainForm") '-- load appsettings, etc.
            obj = mainform.Unwrap()
            Application.DoEvents()

            tm = obj.CreateNewMessage(Not AppSettings.EmailAsHTML) '-- true = force plaintext

            For Each stud As Student In listOfStudents
                If stud.Nickname.Trim.Length > 0 Then
                    tm.AddRecipient(stud.Nickname, stud.EmailAddress)
                Else
                    tm.AddRecipient(stud.LocalName, stud.EmailAddress)
                End If
            Next

            tm.show() '-- don't show, doesn't load all the smtp accounts
            tm.UseSendingAccount(GetSelectedClass.EmailSendingAccount)
            tm.SendAsPlainText = Not AppSettings.EmailAsHTML

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FailedoutcomesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FailedoutcomesToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim frm As New FailedOutcomes(GetSelectedClassGroup())
        frm.Show(Me)
    End Sub
    Private Sub SendBulkEmailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SendBulkEmailToolStripMenuItem.Click
        Try
            If GetSelectedClass() Is Nothing Then
                MessageBox.Show("Please select a class first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim objClassToSend As SchoolClass
            Dim objClass As SchoolClass = CType(lstClasses.Items(lstClasses.SelectedIndex), SchoolClass)
            If ClassIsCombinedView(objClass) Then
                Dim boolSetAlready As Boolean
                For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                    If Not boolSetAlready Then
                        Dim grp As New ClassGroup(Nothing)
                        grp.UseNickname = GetSelectedClassGroup.UseNickname
                        objClassToSend = New SchoolClass(grp)
                        objClassToSend.EmailSendingAccount = objCls.EmailSendingAccount
                        objClassToSend.Students.AddRange(objCls.Students)
                        boolSetAlready = True
                    Else
                        objClassToSend.Students.AddRange(objCls.Students)
                    End If
                Next
            Else
                objClassToSend = objClass
            End If

            Dim frm As New BulkEmailer(objClassToSend)
            frm.Show(Me)
        Catch ex As Exception
            MessageBox.Show("There was an error (" & ex.Message & ") loading the bulk email form.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub llblScheduleNextUnprepped_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblScheduleNextUnprepped.LinkClicked
        Dim dtBaseDate As Date = dtpScheduleDate.Value.AddDays(1)
        Dim earliestItem As ActualSessionItem = Nothing

        For Each grp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In grp.Classes
                For Each item As ActualSessionItem In cls.ActualSessions
                    If Not item.Prepped Then
                        If item.StartDateTime.Date >= dtBaseDate Then
                            If earliestItem Is Nothing OrElse item.StartDateTime.Date < earliestItem.StartDateTime.Date Then
                                earliestItem = item
                            End If
                        End If
                    End If
                Next
            Next
        Next

        If earliestItem Is Nothing Then
            MessageBox.Show("There are no future unprepped classes.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dtpScheduleDate.Value = earliestItem.StartDateTime.Date
        End If
        LoadSchedule()
    End Sub

    Private Sub llblScheduleNextClassDay_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblScheduleNextClassDay.LinkClicked
        Dim dtBaseDate As Date = dtpScheduleDate.Value.AddDays(1)
        Dim earliestItem As ActualSessionItem = Nothing

        For Each grp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In grp.Classes
                For Each item As ActualSessionItem In cls.ActualSessions
                    If item.StartDateTime.Date >= dtBaseDate Then
                        If earliestItem Is Nothing OrElse item.StartDateTime.Date < earliestItem.StartDateTime.Date Then
                            earliestItem = item
                        End If
                    End If
                Next
            Next
        Next

        If earliestItem Is Nothing Then
            MessageBox.Show("There are no future classes.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dtpScheduleDate.Value = earliestItem.StartDateTime.Date
        End If
        LoadSchedule()
    End Sub

    Private Sub ImportClassToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportClassToolStripMenuItem.Click
        If ThisSemester Is Nothing Then
            MessageBox.Show("Please load a semester before import.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New ImportClassFromSemester()
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadClassGroups()
                End If
            End Using
        End If
    End Sub
    Private Sub ImportStudentsFromOtherSemesterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportStudentsFromOtherSemesterToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class for import.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New ImportStudentsFromSemester(GetSelectedClass())
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadStudents()
                End If
            End Using
        End If
    End Sub

    Private Sub StudentOutcomeResultsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentOutcomeResultsToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim frm As New StudentOutcomeResults(GetSelectedClassGroup())
        frm.Show(Me)
    End Sub

    Private Sub FirstSubmissionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FirstSubmissionToolStripMenuItem.Click, CloseAssignment1stToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module to close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment to close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim strMessage As String = "Are you sure you want to close first submission for this assignment (" & GetSelectedAssignment.Name & " for: " & GetSelectedClassGroup.Name & ")?"
            If GetSelectedAssignment.AssignmentType = AssignmentType.BTEC Then
                strMessage &= Environment.NewLine & Environment.NewLine &
                               "This will change outcome markings from pass to fail if the student has any 'unknown' outcome statuses for that assignment (indicating they did not submit that assignment)."
            End If
            If MessageBox.Show(strMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                CleanUpStudentAssignments(GetSelectedClassGroup(), GetSelectedAssignment(), Semester.MarkingTry.FirstTry)
                MessageBox.Show("The first submission for this assignment (" & GetSelectedAssignment.Name & " for: " & GetSelectedClassGroup.Name & ") has been closed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub SecondSubmissionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SecondSubmissionToolStripMenuItem.Click, CloseAssignment2ndToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module to close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment to close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim strMessage As String = "Are you sure you want to close rework for this assignment (" & GetSelectedAssignment.Name & " for: " & GetSelectedClassGroup.Name & ")?"
            If GetSelectedAssignment.AssignmentType = AssignmentType.BTEC Then
                strMessage &= Environment.NewLine & Environment.NewLine &
                               "This will change outcome markings from pass to fail if the student has any 'unknown' outcome statuses for that assignment (indicating they did not submit that assignment)."
            End If

            If MessageBox.Show(strMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Try
                    CleanUpStudentAssignments(GetSelectedClassGroup(), GetSelectedAssignment(), Semester.MarkingTry.SecondTry)
                    MessageBox.Show("The rework submission for this assignment (" & GetSelectedAssignment.Name & " for: " & GetSelectedClassGroup.Name & ") has been closed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Nothing was changed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub ThirdSubmissionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ThirdSubmissionToolStripMenuItem.Click, CloseAssignment3rdToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module to close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment to close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim strMessage As String = "Are you sure you want to close 2nd rework for this assignment (" & GetSelectedAssignment.Name & " for: " & GetSelectedClassGroup.Name & ")?"
            If GetSelectedAssignment.AssignmentType = AssignmentType.BTEC Then
                strMessage &= Environment.NewLine & Environment.NewLine &
                               "This will change outcome markings from pass to fail if the student has any 'unknown' outcome statuses for that assignment (indicating they did not submit that assignment)."
            End If

            If MessageBox.Show(strMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Try
                    CleanUpStudentAssignments(GetSelectedClassGroup(), GetSelectedAssignment(), Semester.MarkingTry.ThirdTry)
                    MessageBox.Show("The 2nd rework submission for this assignment (" & GetSelectedAssignment.Name & " for: " & GetSelectedClassGroup.Name & ") has been closed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Nothing was changed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub HideStudentsWhoPassedAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HideStudentsWhoPassedAllToolStripMenuItem.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module to use.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim group As ClassGroup = GetSelectedClassGroup()
            Dim boolAtLeastOneFail As Boolean
            For Each clas As SchoolClass In group.Classes
                For Each stud As Student In clas.Students
                    boolAtLeastOneFail = False
                    For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                        For Each oc As OutcomeResult In asmt.Outcomes
                            If oc.FirstTryStatus = OutcomeResultStatusEnum.Unknown OrElse oc.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                boolAtLeastOneFail = True
                                Exit For '-- just need one
                            ElseIf oc.SecondTryStatus = OutcomeResultStatusEnum.Unknown OrElse oc.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                boolAtLeastOneFail = True
                                Exit For '-- just need one
                            ElseIf oc.ThirdTryStatus = OutcomeResultStatusEnum.Unknown OrElse oc.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                boolAtLeastOneFail = True
                                Exit For '-- just need one
                            End If
                        Next
                    Next

                    If boolAtLeastOneFail Then
                        '-- should be visisble
                        stud.Hidden = False
                    Else
                        stud.Hidden = True
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub StudentphotoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentphotoToolStripMenuItem.Click
        picStudent.Visible = Not picStudent.Visible
    End Sub

    Private Sub olvStudents_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'Dim stud As Student = GetSelectedStudentCanOnlyBeOne()
        'If stud IsNot Nothing Then
        '    If stud.Photo Is Nothing Then
        '        picStudent.Image = Nothing
        '    Else
        '        picStudent.Image = stud.Photo
        '    End If
        'Else
        '    picStudent.Image = Nothing
        'End If
    End Sub

    Private Sub MarkSelectedAssignmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MarkSelectedAssignmentToolStripMenuItem.Click
        Try
            Dim stud As Student
            'If txtStudentFilter.Text.Length > 0 Then
            '    stud = GetSelectedStudentGridCanOnlyBeOne() 'GetSelectedStudentCanOnlyBeOne()
            '    If GetSelectedStudentGridCanOnlyBeOne() Is Nothing Then
            '        dgvStudents.SelectedRows..SelectedIndex = 0
            '    End If
            'End If
            stud = GetSelectedStudentGridCanOnlyBeOne()
            If stud Is Nothing Then
                If txtStudentFilter.Text.Length > 0 Then

                End If
                MessageBox.Show("Please select a student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim asmt As IClassAssignment = GetSelectedAssignment()
            If asmt Is Nothing Then
                MessageBox.Show("Please select an assignment.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not asmt.ClosedFirstTry Then
                MarkExamForStudent(stud, asmt, Semester.MarkingTry.FirstTry)
            ElseIf Not asmt.ClosedSecondTry Then
                MarkExamForStudent(stud, asmt, Semester.MarkingTry.SecondTry)
            Else
                MarkExamForStudent(stud, asmt, Semester.MarkingTry.ThirdTry)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToggleHiddenForSelectedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToggleHiddenForSelectedToolStripMenuItem.Click
        Try
            Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid() ' GetSelectedStudents()

            For Each stud As Student In lstStudents
                stud.Hidden = Not stud.Hidden
            Next
            'olvStudents.RefreshSelectedObjects()
            dgvStudents.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tmrAutoSave_Tick(sender As System.Object, e As System.EventArgs) Handles tmrAutoSave.Tick
        If ThisSemester IsNot Nothing Then
            'Me.Text = Application.ProductName & " - " & ThisSemester.Name & " - LastSave: " & ThisSemester.LastSaveDate.ToString("HH:mm")

            If AppSettings.AutoSaveEnabled Then
                Dim ts As TimeSpan = Date.Now - m_dtLastAutoSave
                If ts.TotalSeconds >= AppSettings.AutoSaveSeconds Then
                    tmrAutoSave.Stop()
                    AutoSave()
                End If

            End If


        End If
    End Sub
    Private Sub UpdateLastSaved()
        Me.Text = Application.ProductName & " - " & ThisSemester.Name & " - Saved: " & ThisSemester.LastSaveDate.ToString("HH:mm")

        If AppSettings.AutoSaveEnabled Then
            Me.Text &= " - AutoSaved: " & ThisSemester.LastAutoSaveDate.ToString("HH:mm")
        End If

    End Sub
    Public Delegate Sub NoParamSubDelegate()
    Public Sub AutoSave() Implements IMainForm.AutoSave
        If m_bkgndAutoSave.IsBusy Then
            '-- If we are already auto-saving, then just let it be
            Exit Sub
        End If

        If InvokeRequired Then
            Dim deleg As New NoParamSubDelegate(AddressOf AutoSave)
            Invoke(deleg)
        Else
            m_bkgndAutoSave.RunWorkerAsync()
        End If
    End Sub

    Private Sub m_bkgndAutoSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndAutoSave.DoWork
        '-- autosave on background thread
        Try
            ThisSemester.Save(System.IO.Path.Combine(GetDataFolder(), ThisSemester.Name & DATA_FILE_AUTOSAVE_EXTENSION))
            m_dtLastAutoSave = Date.Now
        Catch ex As Exception
            Application.DoEvents()
        End Try
    End Sub

    Private Sub m_bkgndAutoSave_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles m_bkgndAutoSave.RunWorkerCompleted
        tmrAutoSave.Start()
        UpdateLastSaved()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Using frm As New AboutBox()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub SessionprepStatusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SessionprepStatusToolStripMenuItem.Click
        Dim frm As New PreperationStatus()
        frm.Show()
    End Sub

    Private Sub AssignmentProcessingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AssignmentProcessingToolStripMenuItem.Click
        Dim frm As New AssignmentProcessingReport
        frm.Show()
    End Sub

    Private Sub ExportScheduleAsICalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportScheduleAsICalToolStripMenuItem.Click
        Dim frm As New ScheduleExport()
        frm.Show()
    End Sub

    Private Sub ClearStudentFilterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearStudentFilterToolStripMenuItem.Click
        txtStudentFilter.Text = String.Empty
        txtStudentFilter.Focus()
    End Sub

    Private Sub JustOneFromOtherSemesterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class for import.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New ImportStudentsFromSemester(GetSelectedClass())
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadStudents()
                End If
            End Using
        End If
    End Sub

    Private Sub ViewLogFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewLogFileToolStripMenuItem.Click
        ShowErrorLog()
    End Sub

    Private Sub ExcuseMostRecentAbsenceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExcuseMostRecentAbsenceToolStripMenuItem.Click
        Try
            Dim stud As Student
            Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid() 'GetSelectedStudents()
            If lstStudents.Count = 0 Then
                MessageBox.Show("Please select a student to excuse.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                For Each stud In lstStudents
                    For intCounter = stud.TeachingSessions.Count - 1 To 0 Step -1
                        If stud.TeachingSessions(intCounter).AttendenceStatus = AttendanceStatusEnum.Absent Then
                            stud.TeachingSessions(intCounter).AttendenceStatus = AttendanceStatusEnum.Excused
                            Exit For
                        End If
                    Next
                    'olvStudents.RefreshObject(stud)
                    dgvStudents.Refresh()
                Next
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error (" & ex.Message & ") excusing the student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FindDuplicateStudentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindDuplicateStudentsToolStripMenuItem.Click
        '-- This routine scans the selected class and if any student is found to exist in any other classes in the same classgroup,
        '   then we move that student (the dup student) to a new "dup" class.
        '   The user can then remove the dup group to remove all dups
        Try
            If GetSelectedClassGroup() Is Nothing Then
                MessageBox.Show("Please select a class to check for duplicates.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim objNewClass As New SchoolClass(GetSelectedClassGroup())
                objNewClass.Name = "Dups " & Date.Now.ToString("yyyy-MM-dd")

                Dim objSelectedClass As SchoolClass = GetSelectedClass()
                If ClassIsCombinedView(objSelectedClass) Then
                    MessageBox.Show("Cannot remove duplicated from combined view. Please select an individual class to process.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If objSelectedClass Is Nothing Then
                    MessageBox.Show("Please select a class to check for duplicates.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    For Each objPotentialDupStudent As Student In objSelectedClass.Students
                        For Each cls As SchoolClass In objNewClass.ClassGroup.Classes
                            If cls IsNot objSelectedClass Then
                                '-- do not check same class, that would be silly
                                For Each stud As Student In cls.Students
                                    If stud.StudentID = objPotentialDupStudent.StudentID AndAlso stud.StudentID.Length > 0 Then
                                        '-- Student ID's match, let's move from the selected class into the new class
                                        objNewClass.Students.Add(objPotentialDupStudent)
                                        objPotentialDupStudent.AddToActivityLog("Moved to dup class because matching student found in: " & cls.Name)
                                    End If
                                Next
                            End If
                        Next
                    Next

                    If objNewClass.Students.Count > 0 Then
                        For Each stud As Student In objNewClass.Students
                            objSelectedClass.Students.Remove(stud)
                        Next

                        objNewClass.ClassGroup.Classes.Add(objNewClass)
                        LoadClasses()
                    Else
                        MessageBox.Show("No duplicates were found.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("Error processing duplicate students: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmailOnlineQuizResultsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmailOnlineQuizResultsToolStripMenuItem.Click
        Dim lst As List(Of Student) = GetStudentsFromSelectedClass()
        If lst Is Nothing Then
            Exit Sub
        Else
            Dim frm As New EmailQuizResults(lst, GetSelectedClass())
            frm.Show()
        End If
    End Sub
    Private Function GetStudentsFromSelectedClass() As List(Of Student)
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class.", Application.ProductName)
        Else
            If ClassIsCombinedView(GetSelectedClass()) Then
                Dim objListToReturn As New List(Of Student)
                For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                    objListToReturn.AddRange(objCls.Students)
                Next
                Return objListToReturn
            Else
                Return GetSelectedClass().Students
            End If
        End If
    End Function

    Private Sub FindhistoricalStudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindhistoricalStudentToolStripMenuItem.Click
        Dim frm As New HistoricalStudentFinder()
        frm.Show()
    End Sub

    Private Sub llblLoadLatestSemester_LinkClicked_1(sender As System.Object, e As System.EventArgs) Handles llblLoadLatestSemester.LinkClicked
        cboSemester.SelectedIndex = cboSemester.Items.Count - 2
        LoadSemester()
    End Sub

    Private Sub llblLoadPreviousOneSemester_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblLoadPreviousOneSemester.LinkClicked
        If cboSemester.SelectedIndex > 0 Then
            cboSemester.SelectedIndex -= 1
            LoadSemester()
        End If
    End Sub

    Private Sub llblLoadFutureOneSemester_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblLoadFutureOneSemester.LinkClicked
        If cboSemester.SelectedIndex < cboSemester.Items.Count - 2 Then
            cboSemester.SelectedIndex += 1
            LoadSemester()
        End If
    End Sub

    Private Sub ScheduledSessionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScheduledSessionsToolStripMenuItem.Click
        'Dim frm As New SecheduleItemList
        Dim frm As New ScheduledItemListPlain()
        frm.Show()
    End Sub

    Private Sub AssignmentMoveUpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AssignmentMoveUpToolStripMenuItem.Click
        Dim intIndex As Integer = lstAssignments.SelectedIndex
        If intIndex > 0 Then
            '-- We are assuming that we never mix btec and regular assignments
            Dim asmt As IClassAssignment = lstAssignments.SelectedItem
            If asmt.AssignmentType = AssignmentType.BTEC Then
                '-- BTEC assignments
                GetSelectedClassGroup.AssignmentsBTEC.Remove(asmt)
                GetSelectedClassGroup.AssignmentsBTEC.Insert(intIndex - 1, asmt)
            Else
                '-- normal assignments
                GetSelectedClassGroup.Assignments.Remove(asmt)
                GetSelectedClassGroup.Assignments.Insert(intIndex - 1, asmt)
            End If
            LoadClassAssignments()
        End If

    End Sub

    Private Sub AssignmentMoveDownToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AssignmentMoveDownToolStripMenuItem.Click
        Dim intIndex As Integer = lstAssignments.SelectedIndex
        If intIndex < lstAssignments.Items.Count - 1 Then
            Dim asmt As ClassAssignmentBTEC = lstAssignments.SelectedItem
            GetSelectedClassGroup.AssignmentsBTEC.Remove(asmt)
            GetSelectedClassGroup.AssignmentsBTEC.Insert(intIndex + 1, asmt)
            LoadClassAssignments()
        End If
    End Sub



    Private Sub ManageImprovementItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageImprovementItemsToolStripMenuItem.Click
        Dim frm As New ImprovementItemManager()
        frm.Show()
    End Sub

    Private Sub EitherOrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EitherOrToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to process.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim frm As New EitherOrAttendance(GetSelectedClass)
        frm.Show()
    End Sub

    Private Sub ExportMarkingResultsFirstSubmitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportMarkingResultsFirstSubmitToolStripMenuItem.Click, ExportMarkingResultsSecondSubmitToolStripMenuItem.Click, ExportMarkingResultsThirdSubmitToolStripMenuItem.Click
        If GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Title = "Select export location"
        sfd.AddExtension = True
        sfd.Filter = "Text files (*.txt)|*.txt"
        sfd.OverwritePrompt = True
        sfd.FileName = GetSelectedClassGroup.Name & " Marking Results Export"
        If sfd.ShowDialog = DialogResult.OK Then
            '-- Export
            m_bkgndExportMarkingResults = New System.ComponentModel.BackgroundWorker()
            Dim expData As New ExportMarkingListData
            expData.ClassGroup = GetSelectedClassGroup()
            expData.Filename = sfd.FileName
            expData.Assignment = GetSelectedAssignment()
            If sender Is ExportMarkingResultsFirstSubmitToolStripMenuItem Then
                expData.MarkingTry = Semester.MarkingTry.FirstTry
            ElseIf sender Is ExportMarkingResultsSecondSubmitToolStripMenuItem Then
                expData.MarkingTry = Semester.MarkingTry.SecondTry
            ElseIf sender Is ExportMarkingResultsThirdSubmitToolStripMenuItem Then
                expData.MarkingTry = Semester.MarkingTry.ThirdTry
            End If
            m_bkgndExportMarkingResults.RunWorkerAsync(expData)
        End If
    End Sub

    Private Sub StudentQualityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentQualityToolStripMenuItem.Click
        Dim frm As New StudentQualityReport
        frm.Show()
    End Sub

    Private Sub SetGendermaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGendermaleToolStripMenuItem.Click
        Try
            Dim lstStudent As List(Of Student) = GetSelectedStudentsFromGrid() ' GetSelectedStudents()

            For Each stud As Student In lstStudent
                stud.Gender = Student.GenderEnum.Male
            Next

            'olvStudents.RefreshSelectedObjects()
            dgvStudents.Refresh()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub SetGenderfemaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetGenderfemaleToolStripMenuItem.Click
        Try
            Dim lstStudent As List(Of Student) = GetSelectedStudentsFromGrid() 'GetSelectedStudents()

            For Each stud As Student In lstStudent
                stud.Gender = Student.GenderEnum.Female
            Next

            dgvStudents.Refresh()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub ClearTagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTagsToolStripMenuItem.Click
        Try
            Dim lst As List(Of Student) = dgvStudents.DataSource
            For Each stud As Student In lst
                stud.Tags = String.Empty
            Next
            dgvStudents.Refresh()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub EditClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditClassToolStripMenuItem.Click
        EditSelectedClass()
    End Sub

    Private Sub EmailclassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailclassToolStripMenuItem.Click
        Try
            If AppSettings.PathToTrulyMailEXE.Trim.Length = 0 OrElse Not System.IO.File.Exists(AppSettings.PathToTrulyMailEXE) Then
                MessageBox.Show("Please go to Tools->Options on main form and select the path to TrulyMail. TrulyMail must be used for emailing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim cls As SchoolClass = GetSelectedClass()
            If cls Is Nothing Then
                MessageBox.Show("Please select a student to email.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim tm As Object ' New TrulyMail.NewMessage()
            Dim mainform As System.Runtime.Remoting.ObjectHandle
            Dim obj As Object
            mainform = Activator.CreateInstanceFrom(AppSettings.PathToTrulyMailEXE, "TrulyMail.MainForm") '-- load appsettings, etc.
            obj = mainform.Unwrap()
            Application.DoEvents()

            tm = obj.CreateNewMessage(Not AppSettings.EmailAsHTML) '-- true = force plaintext
            If ClassIsCombinedView(cls) Then
                For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                    tm.AddRecipient(GetClassNameToEmail(objCls), objCls.EmailAddress)
                Next
            Else
                tm.AddRecipient(GetClassNameToEmail(cls), cls.EmailAddress)
            End If
            tm.show() '-- don't show, doesn't load all the smtp accounts
            tm.UseSendingAccount(cls.EmailSendingAccount)
            tm.SendAsPlainText = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Function GetClassNameToEmail(clas As SchoolClass) As String
        Dim strReturn As String = clas.Name
        If strReturn.IndexOf("-") > 0 Then
            strReturn = strReturn.Substring(0, strReturn.IndexOf("-"))
        End If
        Return strReturn
    End Function
    Private Sub DeleteClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteClassToolStripMenuItem.Click
        RemoveSelectedClass()
    End Sub
    Private Sub EditSelectedClass()
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to edit.", Application.ProductName)
        Else
            Using frm As New ClassDetails(GetSelectedClass())
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadClasses()
                End If
            End Using
        End If

    End Sub
    Private Sub RemoveSelectedClass()
        Dim intStudents As Integer = GetSelectedClass.Students.Count
        If MessageBox.Show("Are you sure you want to delete " & GetSelectedClass.Name & "?" &
                           Environment.NewLine & Environment.NewLine &
                           "It has " & intStudents.ToString("#,##0") & " students.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            GetSelectedClassGroup.Classes.Remove(GetSelectedClass())
            LoadClasses()
            dgvStudents.DataSource = Nothing
        End If
    End Sub

    Private Sub StatisticsToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles StatisticsToolStripMenuItem.DropDownOpening
        Dim intTotalStudents, intHiddenStudents, intVisibleStudents As Integer

        Try
            Dim objClass As SchoolClass = GetSelectedClass()
            If ClassIsCombinedView(objClass) Then

                For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                    intTotalStudents += objCls.Students.Count
                    intHiddenStudents += objCls.HiddenStudents
                Next
                intVisibleStudents = intTotalStudents - intHiddenStudents
            Else
                intTotalStudents = GetSelectedClass.Students.Count
                intHiddenStudents = GetSelectedClass.HiddenStudents
                intVisibleStudents = intTotalStudents - intHiddenStudents
            End If

            StudentsToolStripMenuItem.Text = "Total students: " & intTotalStudents.ToString("#,##0")
            HiddenStudentsToolStripMenuItem.Text = "Hidden students: " & intHiddenStudents.ToString("#,##0")
            VisibleStudentsToolStripMenuItem.Text = "Visible students: " & intVisibleStudents.ToString("#,##0")

        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub ImportEmailAddressesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportEmailAddressesToolStripMenuItem.Click
        Using frm As New ImportAdditionalStudentData()
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub NewBTECAssignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBTECAssignmentToolStripMenuItem.Click
        CreateNewBTECAssignment()
    End Sub
    Private Sub CreateNewNormalAssignment()
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New ClassAssignmentNormalDetails(GetSelectedClassGroup())
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadClassAssignments()
                End If
            End Using
        End If
    End Sub
    Private Sub NewNormalAssignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewNormalAssignmentToolStripMenuItem.Click
        CreateNewNormalAssignment()
    End Sub

    Private Sub ImportImprovementItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportImprovementItemsToolStripMenuItem.Click
        Using frm As New ImportImprovementItemsFromOtherSemester()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub ImportStudentAssignmentScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportStudentAssignmentScoresToolStripMenuItem.Click
        If GetSelectedClassGroup() IsNot Nothing Then
            If GetSelectedAssignment() IsNot Nothing Then
                Using frm As New ImportAssignmentNormalGrades(GetSelectedClassGroup(), GetSelectedAssignment())
                    frm.ShowDialog()
                End Using
            Else
                MessageBox.Show("Please select an assignment to use.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a module first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub StudentGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentGradesToolStripMenuItem.Click
        Try
            Dim frm As New StudentGrades()
            frm.Show()
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the report: " & ex.Message)
        End Try
    End Sub

    Private Sub SemesterStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemesterStatisticsToolStripMenuItem.Click
        Using frm As New SemesterStatistics()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub ExportStudentGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportStudentGradesToolStripMenuItem.Click
        Try
            If GetSelectedClass() Is Nothing Then
                MessageBox.Show("Please select a class to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim sfd As New SaveFileDialog()
                sfd.Title = "Select export location"
                sfd.AddExtension = True
                sfd.Filter = "Text files (*.txt)|*.txt"
                sfd.OverwritePrompt = True
                sfd.FileName = GetSelectedClass.Name & " Student Grade Export"
                If sfd.ShowDialog = DialogResult.OK Then
                    '-- Export
                    If m_bkgndExportStudentGrades Is Nothing Then
                        m_bkgndExportStudentGrades = New System.ComponentModel.BackgroundWorker()
                    End If
                    Dim expData As New ExportClassData
                    Dim objClassToSend As SchoolClass
                    If ClassIsCombinedView(GetSelectedClass()) Then
                        '-- need all classes combined
                        Dim boolSetAlready As Boolean
                        For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                            If Not boolSetAlready Then
                                Dim grp As New ClassGroup(Nothing)
                                grp.UseNickname = GetSelectedClassGroup.UseNickname

                                '-- Add normal assignments
                                For Each asmt As ClassAssignment In objCls.ClassGroup.Assignments
                                    grp.Assignments.Add(asmt)
                                Next

                                '-- Add btec assignments (THIS NEVER GETS USED
                                'For Each asmt As ClassAssignmentBTEC In objCls.ClassGroup.AssignmentsBTEC
                                '    grp.AssignmentsBTEC.Add(asmt)
                                'Next

                                objClassToSend = New SchoolClass(grp)
                                objClassToSend.Students.AddRange(objCls.Students)
                                boolSetAlready = True
                            Else
                                objClassToSend.Students.AddRange(objCls.Students)
                            End If
                        Next
                    Else
                        objClassToSend = GetSelectedClass()
                    End If
                    expData.SchoolClass = objClassToSend
                    expData.Filename = sfd.FileName
                    m_bkgndExportStudentGrades.RunWorkerAsync(expData)
                End If
            End If

        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub m_bkgndExportStudentGrades_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndExportStudentGrades.DoWork
        Dim expData As ExportClassData = CType(e.Argument, ExportClassData)

        expData.SchoolClass.GenerateStudentGradesExport(expData.Filename)
    End Sub

    Private Sub ProcessAddDropStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessAddDropStudentsToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to process.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Using frm As New ImportAddDropStudents(GetSelectedClass())
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadStudents()
                End If
            End Using
        End If
    End Sub

    Private Sub RemoveAllStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllStudentsToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to remove all these studenst from this class? This cannot be undone.", "Remove all students", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            'For Each stud As Student In olvStudents.FilteredObjects
            '    stud.SchoolClass.Students.Remove(stud)
            'Next
        End If
    End Sub

    Private Sub RemoveAllStudentsFromSelectedClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllStudentsFromSelectedClassToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to process.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Are you sure you want to remove all these students from this class? This cannot be undone.", "Remove all students", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Dim lst As New List(Of Student)
                'For Each stud As Student In olvStudents.FilteredObjects()
                '    lst.Add(stud)
                'Next

                'For Each stud As Student In lst
                '    GetSelectedClass.Students.Remove(stud)
                'Next

                'lst.Clear()

                'LoadStudents() '-- refresh list

            End If
        End If
    End Sub

    Private Sub NotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotesToolStripMenuItem.Click
        pnlNotes.Visible = NotesToolStripMenuItem.Checked
    End Sub
    'Private
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'AppSettings.PremiumFeaturesEnabled = Not AppSettings.PremiumFeaturesEnabled
        '-- Going to import student Normal assignments from another database
        'ImportAssignmentsFromOtherSemester()
    End Sub

    Private m_dtStopwatch As Date
    Private m_boolStopwatchRunning As Boolean
    Private Sub tmrStopwatch_Tick(sender As Object, e As EventArgs) Handles tmrStopwatch.Tick
        If m_boolStopwatchRunning Then
            Dim ts As TimeSpan = Date.Now - m_dtStopwatch
            lblStopwatchDuration.Text = ts.Duration.Hours.ToString() & ":" & ts.Duration.Minutes.ToString("00") & ":" & ts.Duration.Seconds.ToString("00")
        Else
            tmrStopwatch.Stop()
        End If
    End Sub

    Private Sub llblStartPauseStopwatch_LinkClicked(sender As Object, e As EventArgs) Handles llblStartPauseStopwatch.Click
        If m_boolStopwatchRunning Then
            llblStartPauseStopwatch.Image = My.Resources.play_32
            tmrStopwatch.Stop()
        Else
            m_dtStopwatch = Date.Now
            llblStartPauseStopwatch.Image = My.Resources.Pause_32
            tmrStopwatch.Start()
        End If
        m_boolStopwatchRunning = Not m_boolStopwatchRunning
    End Sub

    Private Sub llblClearNotes_LinkClicked(sender As Object, e As EventArgs) Handles llblClearNotes.Click
        txtNotes.Text = String.Empty
    End Sub

    Private Sub FilterForSelectedGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterForSelectedGroupToolStripMenuItem.Click
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne() ' GetSelectedStudentCanOnlyBeOne()
        If stud IsNot Nothing Then
            Dim strGroup As String = stud.StudentTeam.Trim()
            If strGroup.Length > 0 Then
                txtStudentFilter.Text = strGroup
                FindStudentsFromSearchText()
            Else
                MessageBox.Show("This student is not on a team.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Dim intPosition As Integer = strGroup.IndexOf("group")
            'If intPosition > -1 Then
            '    '-- There is a group, now set the filter
            '    Dim intEndPosition As Integer = strGroup.IndexOf(" ", intPosition)
            '    If intEndPosition < 0 Then
            '        intEndPosition = strGroup.Length
            '    End If
            '    strGroup = strGroup.Substring(intPosition, intEndPosition - intPosition)
            '    txtStudentFilter.Text = strGroup
            'End If
        End If
    End Sub

    Private Sub ExcessiveAbsencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcessiveAbsencesToolStripMenuItem.Click
        Dim frm As New ExcessiveAbsencesReport()
        frm.Show()
    End Sub

    Private Sub BatchSaveMarkingSheets(markTry As Semester.MarkingTry)
        Try
            If GetSelectedClass() Is Nothing Then
                MessageBox.Show("Please select a class to email.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If GetSelectedAssignment() Is Nothing Then
                    MessageBox.Show("Please select an assignment first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If GetSelectedAssignment().AssignmentType = AssignmentType.Normal Then
                        MessageBox.Show("Please select a BTEC assignment first. This process will not work with normal assignments.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        Dim asmt As ClassAssignmentBTEC = CType(GetSelectedAssignment(), ClassAssignmentBTEC)

                        Dim frm As New BulkGenerateMarkingSheets(GetSelectedClassGroup(), GetSelectedClass(), asmt, markTry)
                        frm.Show()

                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("There was an error with the batch: " & ex.Message)
        End Try


    End Sub


    Private Sub FirstTryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirstTryToolStripMenuItem.Click
        BatchSaveMarkingSheets(Semester.MarkingTry.FirstTry)
    End Sub

    Private Sub SecondTryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecondTryToolStripMenuItem.Click
        BatchSaveMarkingSheets(Semester.MarkingTry.SecondTry)
    End Sub

    Private Sub ThirdTryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThirdTryToolStripMenuItem.Click
        BatchSaveMarkingSheets(Semester.MarkingTry.ThirdTry)
    End Sub

    Private Sub LoadSchoolClassForSession(session As ActualSessionItem)
        Dim objClass As SchoolClass = session.SchoolClass
        Dim objGroup As ClassGroup = session.SchoolClass.ClassGroup

        '-- Select the group, then the class
        For Each grp As ClassGroup In lstClassGroups.Items
            If grp Is objGroup Then
                lstClassGroups.SelectedItem = grp
                Exit For
            End If
        Next

        For Each cls As SchoolClass In lstClasses.Items
            If cls Is objClass Then
                lstClasses.SelectedItem = objClass
                Exit For
            End If
        Next
    End Sub

    Private Sub ExportMarkingResultsIsolatedSubmitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem.Click, ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem.Click, ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem.Click
        If GetSelectedAssignment() Is Nothing Then
            MessageBox.Show("Please select an assignment to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Title = "Select export location"
        sfd.AddExtension = True
        sfd.Filter = "Text files (*.txt)|*.txt"
        sfd.OverwritePrompt = True
        sfd.FileName = GetSelectedClassGroup.Name & " Marking Results (isolated) Export"
        If sfd.ShowDialog = DialogResult.OK Then
            '-- Export
            m_bkgndExportMarkingResultsIsolated = New System.ComponentModel.BackgroundWorker()
            Dim expData As New ExportMarkingListData
            expData.ClassGroup = GetSelectedClassGroup()
            expData.Filename = sfd.FileName
            expData.Assignment = GetSelectedAssignment()
            If sender Is ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem Then
                expData.MarkingTry = Semester.MarkingTry.FirstTry
            ElseIf sender Is ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem Then
                expData.MarkingTry = Semester.MarkingTry.SecondTry
            ElseIf sender Is ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem Then
                expData.MarkingTry = Semester.MarkingTry.ThirdTry
            End If

            m_bkgndExportMarkingResultsIsolated.RunWorkerAsync(expData)
        End If
    End Sub
    Private Sub CheckForupdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForupdatesToolStripMenuItem.Click
        Try
            'Dim strFilename As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "TeachingUpdater.exe")
            'System.Diagnostics.Process.Start(strFilename, Application.ProductVersion & " False") '-- this app is not supporting betas yet, but the updater does
            System.Diagnostics.Process.Start("http://educators.johnmandre.com/teaching-app-news") '-- Simpler, since I play to take TrulyMail.com offline

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error launching the updater (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub UpgradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeToolStripMenuItem.Click
        Using frm As New Upgrade()
            If frm.ShowDialog = DialogResult.OK Then
                MessageBox.Show("You need to restart the application for the new features to show.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub HelpToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.DropDownOpening
        UpgradeToolStripMenuItem.Visible = Not AppSettings.PremiumFeaturesEnabled
    End Sub

    Private Sub ctxmnuClasses_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxmnuClasses.Opening
        EmailclassToolStripMenuItem.Visible = AppSettings.PremiumFeaturesEnabled
    End Sub

    Private Sub ctxmnuStudents_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxmnuStudents.Opening
        ToolStripSeparator2.Visible = AppSettings.PremiumFeaturesEnabled
        ToolStripSeparator8.Visible = AppSettings.PremiumFeaturesEnabled
        EmailstudentToolStripMenuItem.Visible = AppSettings.PremiumFeaturesEnabled
        ProcessExam2ndReDoForStudent.Visible = AppSettings.PremiumFeaturesEnabled
        ProcessExamRedoForStudent.Visible = AppSettings.PremiumFeaturesEnabled
        ProcessExamForStudent.Visible = AppSettings.PremiumFeaturesEnabled
    End Sub
    'Private Function MainRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
    '    Dim stud As Student = CType(olvi.RowObject, Student)

    '    olvi.UseItemStyleForSubItems = False

    '    Dim intPositionCurrentAbsences As Integer = Me.olvStudents.Columns.IndexOf(Me.olvcolCurrentAbsences)

    '    olvi.SubItems(intPositionCurrentAbsences).BackColor = Color.LightGray
    'End Function

    Private Sub ExportEntireSemesterAsXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportEntireSemesterAsXMLToolStripMenuItem.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.OverwritePrompt = True
            sfd.Title = "Select location to save XML file"
            sfd.Filter = "XML files|*.xml"
            sfd.AddExtension = True
            If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim strFilename As String = sfd.FileName
                ThisSemester.Save(strFilename, True)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadCurrentClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadCurrentClassToolStripMenuItem.Click
        Try
            Dim ts As TimeSpan
            For Each group As ClassGroup In ThisSemester.ClassGroups
                For Each cls As SchoolClass In group.Classes
                    For Each sess As ActualSessionItem In cls.ActualSessions
                        If sess.StartDateTime <= Date.Now Then
                            ts = Date.Now - sess.StartDateTime
                            If ts.TotalMinutes < sess.DurationInMinutes Then
                                '-- we have our current class
                                LoadSchoolClassForSession(sess)
                                Exit Sub
                            End If
                        End If
                    Next
                Next
            Next
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the current class: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MissingGradeDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MissingGradeDataToolStripMenuItem.Click
        Dim frm As New MissingGradeDataReport()
        frm.Show()
    End Sub

    Private Sub ImprovementItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprovementItemsToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class for the report.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frm As New ImprovementItemReport(GetSelectedClass())
            frm.Show()
        End If
    End Sub

    Private Sub llblAddTag_LinkClicked(sender As Object, e As EventArgs) Handles llblAddTag.Click
        If txtTag.Text.Trim().Length = 0 Then
            '-- do nothing
        Else
            Dim lst As List(Of Student) = GetSelectedStudentsFromGrid()
            For Each stud As Student In lst
                If stud.Tags.Length > 0 Then
                    stud.Tags &= " " '-- add a space to separate this tag from other tags
                End If
                stud.Tags &= txtTag.Text.Trim()
                'olvStudents.RefreshObject(stud)
                dgvStudents.Refresh()
            Next
        End If
    End Sub

    Private Sub ExportModuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportModuleToolStripMenuItem.Click
        Dim frm As New ExportToTeachingAppExportFile(GetSelectedClassGroup, GetSelectedClass, GetSelectedAssignment)
        frm.ShowDialog()
    End Sub

    Private Sub ImportSpecialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportSpecialToolStripMenuItem.Click
        Dim frm As New ImportTeachingAppExportFile
        frm.ShowDialog()

    End Sub

    Private Sub Attendance2FromSchedule()
        If dgvSchedule.CurrentRow IsNot Nothing Then
            Dim item As ActualSessionItem = CType(dgvSchedule.CurrentRow.DataBoundItem, ActualSessionItem)
            Using frm As New Attendance2Form(item)
                frm.ShowDialog()
            End Using
        Else
            MessageBox.Show("Please select a schedule item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SpecialAttendanceToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialAttendanceToolToolStripMenuItem.Click
        If GetSelectedClass() IsNot Nothing Then
            Dim frm As New AttendanceFromAssignment(GetSelectedClass())
            frm.Show()
        Else
            MessageBox.Show("Please select a class first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvSchedule_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSchedule.CellFormatting
        'If dgvSchedule.Columns(e.ColumnIndex).Name.Equals(dgcDay.Name) Then
        'End If
        If m_lstCurrentScheduleItems.Count > e.RowIndex Then
            Select Case dgvSchedule.Columns(e.ColumnIndex).Name
                Case dgcDay.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).StartDateTime.DayOfWeek.ToString()
                Case dgcStarts.Name
                    '-- Do nothing here
                Case dgcModule.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).SchoolClass.ClassGroup.Name
                Case dgcClass.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).SchoolClass.Name
                Case dgcSession.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).SessionNumber
                Case dgcTopic.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).Topic
                Case dgcLocation.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).Location
                Case dgcNotes.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).Notes
                Case dgcPrepped.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).Prepped
                Case dgcSent.Name
                    e.Value = m_lstCurrentScheduleItems(e.RowIndex).StudentsEmailed
            End Select
        End If
    End Sub

    Private Sub ScheduleLoadClassMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleLoadClassMenuItem.Click
        Try
            If dgvSchedule.CurrentRow IsNot Nothing Then
                Dim item As ActualSessionItem = CType(dgvSchedule.CurrentRow.DataBoundItem, ActualSessionItem)
                LoadSchoolClassForSession(item)
            Else
                MessageBox.Show("Please select a schedule item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the scheduled session: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ScheduleTakeAttendanceMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleTakeAttendanceMenuItem.Click
        Attendance2FromSchedule()
    End Sub

    Private Sub ScheduleSkipSessionMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleSkipSessionMenuItem.Click
        If dgvSchedule.CurrentRow IsNot Nothing Then
            Dim item As ActualSessionItem = CType(dgvSchedule.CurrentRow.DataBoundItem, ActualSessionItem)
            If MessageBox.Show("Are you sure you want to skip the selected session (" & item.Topic & ")?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                Dim objSkip As New SkipSession()
                objSkip.StartDateTime = item.StartDateTime
                item.SchoolClass.SessionsToSkip.Add(objSkip)

                item.SchoolClass.ActualSessions.Remove(item)

                Using frm As New ClassDetails(item.SchoolClass)
                    If frm.ShowDialog(Me) = DialogResult.OK Then
                        LoadClasses()
                    End If
                End Using

                LoadSchedule()
            End If
        End If
    End Sub

    Private Sub dgvSchedule_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellDoubleClick
        Attendance2FromSchedule()
    End Sub

    Private Sub EmailStudentGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailStudentGridToolStripMenuItem.Click
        EmailStudent(GetSelectedStudentsFromGrid)
    End Sub

    Private Sub EditStudentGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStudentGridToolStripMenuItem.Click
        EditSelectedStudentGrid()
    End Sub

    Private Sub IncreaseMeritGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseMeritGridToolStripMenuItem.Click
        '-- Give a merit point to each student
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid()
        For Each stud As Student In lstStudents
            stud.MeritPoints += 1
        Next
        dgvStudents.Refresh()
    End Sub

    Private Sub DecreaseMeritGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseMeritGridToolStripMenuItem.Click
        '-- Give a merit point to each student
        Dim lstStudents As List(Of Student) = GetSelectedStudentsFromGrid()
        For Each stud As Student In lstStudents
            stud.MeritPoints -= 1
        Next
        dgvStudents.Refresh()
    End Sub

    Private Sub MarkAssessment1GridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAssessment1GridToolStripMenuItem.Click
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne()
        If stud IsNot Nothing Then
            MarkExamForStudent(stud, GetSelectedAssignment(), Semester.MarkingTry.FirstTry)
        End If
    End Sub

    Private Sub MarkAssessment2GridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAssessment2GridToolStripMenuItem.Click
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne()
        If stud IsNot Nothing Then
            MarkExamForStudent(stud, GetSelectedAssignment(), Semester.MarkingTry.SecondTry)
        End If
    End Sub

    Private Sub MarkAssessment3GridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAssessment3GridToolStripMenuItem.Click
        Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne()
        If stud IsNot Nothing Then
            MarkExamForStudent(stud, GetSelectedAssignment(), Semester.MarkingTry.ThirdTry)
        End If
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        FindStudentsFromSearchText()
    End Sub

    Private Sub StudentAssessmentcompletionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentAssessmentcompletionToolStripMenuItem.Click
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class to process.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frm As New StudentAssessmentCompletionReport(GetSelectedClass())
            frm.Show()
        End If
    End Sub

    Private Sub FindStudentsFromSearchText()

        Dim strSearchFor As String
        If txtStudentFilter.Text.Length = 0 Then
            dgvStudents.DataSource = m_lstCurrentListOfStudents
            ShowStudentCount()
        Else
            strSearchFor = txtStudentFilter.Text.ToLower
            Dim lstFiltered As List(Of Student) = m_lstCurrentListOfStudents.Where(Function(x) x.StudentID.ToLower.Contains(strSearchFor) OrElse _
                                                                                 x.Nickname.ToLower.Contains(strSearchFor) OrElse _
                                                                                 x.LocalNameLatinLetters.ToLower.Contains(strSearchFor) OrElse _
                                                                                 x.ExtStudentID.ToLower.Contains(strSearchFor) OrElse _
                                                                                 x.Tags.ToLower.Contains(strSearchFor) OrElse _
                                                                                 x.EmailAddress.ToLower.Contains(strSearchFor) OrElse _
                                                                                 x.Nickname.ToLower.Contains(strSearchFor) OrElse _
                                                                                 x.StudentTeam.ToLower.Contains(strSearchFor)).ToList()

            dgvStudents.DataSource = lstFiltered
            ShowStudentCount(lstFiltered)
        End If
    End Sub

    Private Sub txtStudentFilter_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtStudentFilter.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            '-- remove cr and lf (issue pasting from WPS under Wine)
            txtStudentFilter.Text = txtStudentFilter.Text.Replace(Chr(10), "")
            txtStudentFilter.Text = txtStudentFilter.Text.Replace(Chr(13), "")

            'If ModifierKeys And Keys.Shift = Keys.Shift Then
            '    Dim strReturn As String = "Shift was pressed" & Environment.NewLine
            '    For Each ch As Char In txtStudentFilter.Text
            '        strReturn &= Asc(ch).ToString() & Environment.NewLine
            '    Next
            '    MessageBox.Show(strReturn)
            'Else
            FindStudentsFromSearchText()
            'End If
        End If
    End Sub

    Private Sub ClearTeamForTheseStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTeamForTheseStudentsToolStripMenuItem.Click
        Try
            Dim lst As List(Of Student) = dgvStudents.DataSource
            For Each stud As Student In lst
                stud.StudentTeam = String.Empty
            Next
            dgvStudents.Refresh()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Sub dgvStudents_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStudents.ColumnHeaderMouseClick
        '-- Manually sort
        Try
            Dim col As DataGridViewColumn = dgvStudents.Columns(e.ColumnIndex)
            Dim lst As List(Of Student) = dgvStudents.DataSource
            Dim cmp As IComparer(Of Student)
            Dim boolSort As Boolean = True

            If col IsNot Nothing Then
                Select Case col.DataPropertyName
                    Case "ExtStudentID"
                        cmp = New StudentComparerByExtStudentID
                    Case "StudentID"
                        cmp = New StudentComparerByStudentID
                    Case "StudentTeam"
                        cmp = New StudentComparerByStudentTeam
                    Case "StudentGroup"
                        cmp = New StudentComparerByStudentGroup
                    Case "DateOfBirth"
                        cmp = New StudentComparerByDateOfBirth
                    Case "Gender"
                        cmp = New StudentComparerByGender
                    Case "Tags"
                        cmp = New StudentComparerByTags
                    Case "LatestAttendenceStatus"
                        cmp = New StudentComparerByLatestAttendenceStatus
                    Case "Nickname"
                        cmp = New StudentComparerByNickname
                    Case "LocalName"
                        cmp = New StudentComparerByLocalName
                    Case "AltNumber"
                        cmp = New StudentComparerByAltNumber
                    Case "AdminNumber"
                        cmp = New StudentComparerByAdminNumber
                    Case Else
                        boolSort = False
                End Select

                If boolSort Then
                    lst.Sort(cmp)
                    dgvStudents.DataSource = Nothing
                    dgvStudents.Refresh()
                    dgvStudents.DataSource = lst
                    dgvStudents.Refresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error sorting: " & ex.Message)
        End Try

    End Sub

    Private Sub ConvertLocalNamesToStandardnondiacriticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertLocalNamesToStandardnondiacriticToolStripMenuItem.Click
        Dim boolConvertAll As Boolean
        Select Case MessageBox.Show("Convert all classes?" & Environment.NewLine & _
                                    Environment.NewLine & _
                                    "Yes    = Convert all classes" & Environment.NewLine & _
                                    "No     = Convert this class" & Environment.NewLine & _
                                    "Cancel = Do nothing", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                boolConvertAll = True
            Case Windows.Forms.DialogResult.No
                boolConvertAll = False
            Case Windows.Forms.DialogResult.Cancel
                Exit Sub
        End Select

        If boolConvertAll Then
            For Each grp As ClassGroup In ThisSemester.ClassGroups
                For Each cls As SchoolClass In grp.Classes
                    For Each stud As Student In cls.Students
                        '-- convert
                        stud.LocalName = stud.LocalNameLatinLetters
                    Next
                Next
            Next
        Else
            Dim cls As SchoolClass = GetSelectedClass()
            If cls Is Nothing Then
                MessageBox.Show("Please select a class to convert and try again.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            For Each stud As Student In cls.Students
                '-- convert
                stud.LocalName = stud.LocalNameLatinLetters
            Next
        End If

        MessageBox.Show("Done.", Application.ProductName)
    End Sub

    Private Sub m_bkgndDelayedActions_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles m_bkgndDelayedActions.DoWork
        '-- This is for actions that should be done off-main-thread and after startup

        '-- Load up the SemesterCache so it will be faster (but will consume more memory)
        If AppSettings.LoadSemesterCacheOnStartup Then
            Dim cache As SemesterCache = SemesterCache.GetCache() '-- should not need to do more than get an instance
        End If

    End Sub

    Private Sub llblScheduleToday_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblScheduleToday.LinkClicked
        dtpScheduleDate.Value = Date.Today
        LoadSchedule()
    End Sub

    Private Sub MarkGroupPresentation(attempt As Semester.MarkingTry)
        Try
            Dim stud As Student = GetSelectedStudentGridCanOnlyBeOne()

            If stud Is Nothing Then
                MessageBox.Show("Please select a student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            If GetSelectedAssignment() Is Nothing Then
                MessageBox.Show("Please select an assignment.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim strTeam As String = stud.StudentTeam

            Dim lstFiltered As List(Of Student)
            If ClassIsCombinedView(GetSelectedClass) Then
                Dim lst As New List(Of Student)
                Dim boolSetAlready As Boolean
                For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                    If Not boolSetAlready Then
                        lst.AddRange(objCls.Students)
                        boolSetAlready = True
                    Else
                        lst.AddRange(objCls.Students)
                    End If
                Next
                lstFiltered = lst.Where(Function(x) x.StudentTeam.ToLower.Equals(strTeam.ToLower())).ToList()
            Else
                lstFiltered = GetSelectedClass.Students.Where(Function(x) x.StudentTeam.ToLower.Equals(strTeam.ToLower())).ToList()
            End If

            Dim asmt As ClassAssignment = CType(GetSelectedAssignment(), ClassAssignment)
            Dim frm As New GroupPresentationAssessment(lstFiltered, asmt, attempt)
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FirstTryMarkGroupPresentationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FirstTryMarkGroupPresentationToolStripMenuItem1.Click
        MarkGroupPresentation(Semester.MarkingTry.FirstTry)
    End Sub

    Private Sub SecondTryMarkGroupPresentationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SecondTryMarkGroupPresentationToolStripMenuItem1.Click
        MarkGroupPresentation(Semester.MarkingTry.SecondTry)
    End Sub
    Public Property Notes As String Implements IMainForm.Notes
        Get
            Return txtNotes.Text
        End Get
        Set(value As String)
            txtNotes.Text = value
        End Set
    End Property

    Private Sub CaptureStudentImageFromClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaptureStudentImageFromClipboardToolStripMenuItem.Click
        Dim stud As Student
        Dim img As Image
        Try

            stud = GetSelectedStudentGridCanOnlyBeOne()
            If stud Is Nothing Then
                MessageBox.Show("Please select one student first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            img = Clipboard.GetImage()
            If img Is Nothing Then
                MessageBox.Show("There is no image on the clipboard.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            stud.Photo = img '-- save it back
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error capturing the image: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudents.SelectionChanged
        Try
            If picStudent.Visible Then
                Dim stud As Student
                stud = GetSelectedStudentGridCanOnlyBeOne()
                If stud IsNot Nothing Then
                    picStudent.Image = stud.Photo
                End If
            End If
        Catch ex As Exception
            Log(ex) '-- ignore and continue
        End Try

    End Sub
End Class