Public Class ImportClassFromSemester

    Private m_sourceSemester As Semester

    Private Sub ImportStudentsFromSemester_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstAssignments.Visible = False
        lblAssignments.Visible = False

        LoadSemesters()
    End Sub
    Private Sub LoadSemesters()
        Dim files() As String = System.IO.Directory.GetFiles(GetDataFolder(), "*" & DATA_FILE_EXTENSION)
        cboSemester.Items.Clear()
        For Each strFilename As String In files
            cboSemester.Items.Add(System.IO.Path.GetFileNameWithoutExtension(strFilename))
        Next
    End Sub

    Private Sub cboSemester_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSemester.SelectedIndexChanged
        btnLoadSemester.Enabled = True
    End Sub

    Private Sub btnLoadSemester_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnLoadSemester.LinkClicked
        LoadSemester()
    End Sub
    Private Sub LoadSemester()
        Try
            '-- Load the selected semester from data file
            m_sourceSemester = New Semester(cboSemester.Items(cboSemester.SelectedIndex))
            Me.Text = "Import From - " & m_sourceSemester.Name
            btnLoadSemester.Enabled = False

            LoadClassGroups()
        Catch ex As Exception
            MessageBox.Show("There was an error loading the selected semester: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadClassGroups()
        lstAssignments.Items.Clear()
        lstClasses.Items.Clear()
        lstClassGroups.Items.Clear()
        For Each objClassGroup As ClassGroup In m_sourceSemester.ClassGroups
            lstClassGroups.Items.Add(objClassGroup)
        Next
    End Sub
    Private Sub LoadClasses()
        lstClasses.Items.Clear()
        For Each objClass As SchoolClass In GetSelectedClassGroup.Classes
            lstClasses.Items.Add(objClass)
        Next
    End Sub
    Private Function GetSelectedClassGroup() As ClassGroup
        If lstClassGroups.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstClassGroups.Items(lstClassGroups.SelectedIndex)
        End If
    End Function

    Private Sub lstClassGroups_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClassGroups.SelectedIndexChanged
        LoadClassAssignments()
        LoadClasses()
    End Sub
    Private Sub LoadClassAssignments()
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a class first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstAssignments.Items.Clear()
            For Each objClassAssignment As ClassAssignmentBTEC In GetSelectedClassGroup().AssignmentsBTEC
                lstAssignments.Items.Add(objClassAssignment)
            Next
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If GetSelectedClassGroup() Is Nothing Then
            MessageBox.Show("Please select a module, class(es), and/or assignment(s) to import.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim group As New ClassGroup(ThisSemester)
            group.Name = CType(lstClassGroups.SelectedItem, ClassGroup).Name
            ThisSemester.ClassGroups.Add(group)

            '-- Should we import class(es)?
            For Each clas As SchoolClass In lstClasses.SelectedItems
                'MsgBox("Import Class: " & clas.Name)
                '-- Import class, students, but not student assignment or outcome results or sessions
                group.Classes.Add(clas)
                clas.ClassSessions.Clear()
                For Each stud As Student In clas.Students
                    stud.TeachingSessions.Clear()
                    stud.Hidden = False
                    stud.MeritPoints = 0
                    stud.EmailedData = String.Empty
                    'stud.AltNumber = 0
                    'stud.AdminNumber=0
                    stud.AssignmentsBTEC.Clear()
                Next
                AddHistory("Imported class from previous semester (Prev Semester: " & m_sourceSemester.Name & ", Class: " & clas.ToString() & ").")
            Next

            '-- Should we import class assignment(s)?
            For Each asmt As ClassAssignmentBTEC In lstAssignments.SelectedItems
                'MsgBox("Import assignment: " & asmt.Name)
                group.AssignmentsBTEC.Add(asmt)
                asmt.SavedAssignmentsFolder = String.Empty
            Next

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
