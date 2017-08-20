Public Class ExportToTeachingAppExportFile

    Private m_group As ClassGroup
    Private m_class As SchoolClass
    Private m_asmt As IClassAssignment
    Private Const FILE_EXTENSION_FOR_IMPORT = ".taex"

    Public Sub New(group As ClassGroup, schoolClass As SchoolClass, asmt As IClassAssignment)

        ' This call is required by the designer.
        InitializeComponent()

        m_group = group
        m_class = schoolClass
        m_asmt = asmt

        Me.lblExportCaption.Text = "Exporting: Module=" & m_group.Name & "; Class=" & m_class.Name & "; Assignment:" & m_asmt.Name


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Enum ExportTypeEnum
        ExportForAdmin
        ExportForXML
    End Enum

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try

            Dim export As ExportTypeEnum
            If cboExportType.SelectedIndex = 0 Then
                export = ExportTypeEnum.ExportForAdmin
            Else
                export = ExportTypeEnum.ExportForXML
            End If

            If m_class Is Nothing Then
                MessageBox.Show("Please select a class to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtOutputFile.Text = txtOutputFile.Text.Trim()
                If txtOutputFile.Text.Length > 0 Then
                    Select Case export
                        Case ExportTypeEnum.ExportForAdmin
                            '-- Tabular
                            Dim objClassToSend As SchoolClass
                            If ClassIsCombinedView(m_class) Then
                                '-- need all classes combined
                                Dim boolSetAlready As Boolean
                                For Each objCls As SchoolClass In m_group.Classes
                                    If Not boolSetAlready Then
                                        Dim grp As New ClassGroup(Nothing)
                                        grp.UseNickname = m_group.UseNickname

                                        '-- Add normal assignments
                                        For Each asmt As ClassAssignment In objCls.ClassGroup.Assignments
                                            grp.Assignments.Add(asmt)
                                        Next

                                        '-- Add btec assignments (THIS NEVER GETS USED
                                        'For Each asmt As ClassAssignmentBTEC In objCls.ClassGroup.AssignmentsBTEC
                                        '    grp.AssignmentsBTEC.Add(asmt)
                                        'Next

                                        objClassToSend = New SchoolClass(grp)
                                        objClassToSend.Name = m_group.Name & " - " & m_class.Name
                                        objClassToSend.Students.AddRange(objCls.Students)
                                        boolSetAlready = True
                                    Else
                                        objClassToSend.Students.AddRange(objCls.Students)
                                    End If
                                Next
                            Else
                                objClassToSend = m_class
                            End If '-- combined view

                            btnOK.Hide()
                            btnCancel.Hide()
                            lblExporting.Show()
                            Application.DoEvents()
                            objClassToSend.GenerateStudentGradesExport(txtOutputFile.Text)
                            Close()
                        Case ExportTypeEnum.ExportForXML
                            '-- XML
                            '-- Just export the included students' scores on the selected assignments
                            '   and perhaps attendance records, if the user chose that option
                            Dim grp As New ClassGroup(Nothing)
                            grp.Name = m_group.Name
                            grp.UseNickname = m_group.UseNickname
                            Dim objClassToSend As SchoolClass = New SchoolClass(grp)

                            '-- Add the single selected normal assignment
                            grp.Assignments.Add(m_asmt)

                            '-- Put attendance dates into a list
                            Dim lstAttendanceDates As New Dictionary(Of Date, Object)
                            For Each dt As Date In lstSelectedAttendanceDates.Items
                                lstAttendanceDates.Add(dt, Nothing)
                            Next

                            If ClassIsCombinedView(m_class) Then
                                '-- need all classes combined

                                objClassToSend.Name = m_group.Name & " - " & m_class.Name

                                For Each objCls As SchoolClass In m_group.Classes
                                    objClassToSend.Students.AddRange(objCls.Students)
                                Next
                            Else
                                objClassToSend.Name = m_class.Name
                                objClassToSend.Students.AddRange(m_class.Students)
                            End If '-- combined view

                            btnOK.Hide()
                            btnCancel.Hide()
                            lblExporting.Show()
                            Application.DoEvents()
                            objClassToSend.GenerateStudentGradesExportXML(txtOutputFile.Text, lstAttendanceDates)
                            Close()
                        Case Else
                            MessageBox.Show("Please select the format to use for export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Select
                Else
                    MessageBox.Show("Please enter a valid filename or click the browse (...) button.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If '-- m_class is nothing
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBrowseForExportFile_Click(sender As Object, e As EventArgs) Handles btnBrowseForExportFile.Click
        Dim sfd As New SaveFileDialog()
        sfd.Title = "Select export location"
        sfd.AddExtension = True
        Select Case cboExportType.SelectedIndex
            Case 0
                sfd.Filter = "Text files (*.txt)|*.txt"
            Case 1
                sfd.Filter = "Export-Import files (*" & FILE_EXTENSION_FOR_IMPORT & ")|*" & FILE_EXTENSION_FOR_IMPORT
        End Select
        sfd.OverwritePrompt = True
        sfd.FileName = m_group.Name & " - " & m_class.Name & " Student Grade Export"
        If sfd.ShowDialog = DialogResult.OK Then
            txtOutputFile.Text = sfd.FileName
        End If
    End Sub

    Private Sub cboExportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExportType.SelectedIndexChanged
        Select Case cboExportType.SelectedIndex
            Case 0
                lstAvailableAttendanceDates.Enabled = False
                lstSelectedAttendanceDates.Enabled = False
                btnAddAttendanceDate.Enabled = False
                If txtOutputFile.Text.Trim.Length > 0 Then
                    '-- change file extension
                    txtOutputFile.Text = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(txtOutputFile.Text), System.IO.Path.GetFileNameWithoutExtension(txtOutputFile.Text) & ".txt")
                End If
            Case 1
                lstAvailableAttendanceDates.Enabled = True
                lstSelectedAttendanceDates.Enabled = True
                btnAddAttendanceDate.Enabled = True
                If txtOutputFile.Text.Trim.Length > 0 Then
                    '-- change file extension
                    txtOutputFile.Text = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(txtOutputFile.Text), System.IO.Path.GetFileNameWithoutExtension(txtOutputFile.Text) & FILE_EXTENSION_FOR_IMPORT)
                End If
        End Select

    End Sub

    Private Sub ExportToTeachingAppExportFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboExportType.SelectedIndex = 0
        If ClassIsCombinedView(m_class) Then
            Dim dict As New Dictionary(Of Date, Object)
            For Each objCls As SchoolClass In m_group.Classes
                For Each session As ClassSession In objCls.ClassSessions
                    If Not dict.ContainsKey(session.StartDate) Then
                        dict.Add(session.StartDate, Nothing)
                    End If
                Next
            Next

            For Each dt As Date In dict.Keys
                lstAvailableAttendanceDates.Items.Add(dt)
            Next
        Else
            For Each session As ClassSession In m_class.ClassSessions
                lstAvailableAttendanceDates.Items.Add(session.StartDate)
            Next
        End If
    End Sub

    Private Sub btnAddAttendanceDate_Click(sender As Object, e As EventArgs) Handles btnAddAttendanceDate.Click
        If lstAvailableAttendanceDates.SelectedIndex >= 0 Then
            lstSelectedAttendanceDates.Items.Add(lstAvailableAttendanceDates.SelectedItem)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstSelectedAttendanceDates.SelectedIndex >= 0 Then
            lstSelectedAttendanceDates.Items.RemoveAt(lstSelectedAttendanceDates.SelectedIndex)
        End If
    End Sub

    Private Sub lstAvailableAttendanceDates_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstAvailableAttendanceDates.MouseDoubleClick
        btnAddAttendanceDate.PerformClick()
    End Sub

    Private Sub lstSelectedAttendanceDates_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstSelectedAttendanceDates.MouseDoubleClick
        btnRemove.PerformClick()
    End Sub
End Class