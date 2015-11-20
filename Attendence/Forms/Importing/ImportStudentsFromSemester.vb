Public Class ImportStudentsFromSemester

    Private m_TargetClass As SchoolClass

    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_TargetClass = clas

    End Sub

    Private m_sourceSemester As Semester

    Private Sub ImportStudentsFromSemester_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        olvStudents.ClearObjects()
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
    Private Function GetSelectedClass() As SchoolClass
        If lstClasses.SelectedIndex = -1 Then
            Return Nothing
        Else
            Return lstClasses.Items(lstClasses.SelectedIndex)
        End If
    End Function

    Private Sub lstClassGroups_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClassGroups.SelectedIndexChanged
        LoadClasses()
    End Sub
    Private Sub LoadStudents()
        If GetSelectedClass() Is Nothing Then
            MessageBox.Show("Please select a class first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            olvStudents.SetObjects(GetSelectedClass.Students)
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        For Each stu As Student In olvStudents.SelectedObjects
            stu.AssignmentsBTEC.Clear()
            stu.TeachingSessions.Clear()
            stu.Hidden = False
            m_TargetClass.Students.Add(stu)
            stu.AddToActivityLog("Student imported from " & m_sourceSemester.Name & " - " & GetSelectedClassGroup.Name & " - " & GetSelectedClass.Name)
            stu.ActivityLog = String.Empty '-- clear log on import
        Next



        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub lstClasses_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lstClasses.SelectedIndexChanged
        LoadStudents()
    End Sub
End Class
