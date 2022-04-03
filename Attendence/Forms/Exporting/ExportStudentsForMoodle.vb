Public Class ExportStudentsForMoodle

    Private m_class As SchoolClass
    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = clas
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Title = "Select export location"
            sfd.AddExtension = True
            sfd.Filter = "Text files (*.txt)|*.txt"
            sfd.OverwritePrompt = True
            sfd.FileName = m_class.ClassGroup.Name & "-" & m_class.Name & " Student Export for Moodle"
            If sfd.ShowDialog = DialogResult.OK Then
                '-- Export
                GenerateStudentExportForMoodle(sfd.FileName)
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message, PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Public Sub GenerateStudentExportForMoodle(filename As String)
        '-- create a list with everything you need to upload students to Moodle
        Const DELIMITER As String = ","
        Using tw As System.IO.StreamWriter = New System.IO.StreamWriter(filename, False, System.Text.Encoding.Unicode)
            tw.Write("username")
            tw.Write(DELIMITER)
            tw.Write("firstname")
            tw.Write(DELIMITER)
            tw.Write("lastname")
            tw.Write(DELIMITER)
            tw.Write("email")
            tw.Write(DELIMITER)
            tw.Write("course1")
            tw.Write(DELIMITER)
            tw.Write("role1")
            If rdoGroupUseNothing.Checked = False Then
                tw.Write(DELIMITER)
                tw.Write("group1")
            End If
            tw.Write(DELIMITER)
            tw.Write("idnumber")
            tw.Write(Environment.NewLine)

            Dim intStudentCounter As Integer '-- counter for troubleshooting
            Dim strWorking As String '-- just a workspace
            Dim strFirstname, strLastname As String
            Dim intPos, intLength As Integer

            For Each student As Student In m_class.Students
                intStudentCounter += 1
                tw.Write(student.EmailAddress.Substring(0, student.EmailAddress.IndexOf("@")))
                tw.Write(DELIMITER)
                strWorking = student.LocalNameLatinLetters.Trim()

                If chkFirstNameFirst.Checked Then
                    intPos = 0
                    intLength = strWorking.IndexOf(" ")
                    strFirstname = strWorking.Substring(intPos, intLength)

                    intPos = intLength + 1
                    strLastname = strWorking.Substring(intPos)
                Else
                    intPos = strWorking.LastIndexOf(" ") + 1
                    intLength = strWorking.Length - intPos
                    strFirstname = strWorking.Substring(intPos, intLength)

                    intLength = intPos - 1
                    intPos = 0
                    strLastname = strWorking.Substring(intPos, intLength)
                End If
                tw.Write(strFirstname)
                tw.Write(DELIMITER)
                tw.Write(strLastname)
                tw.Write(DELIMITER)
                tw.Write(student.EmailAddress)
                tw.Write(DELIMITER)
                tw.Write(txtCourseID.Text)
                tw.Write(DELIMITER)
                tw.Write(txtRoleName.Text)
                If rdoGroupUseGroup.Checked Then
                    tw.Write(DELIMITER)
                    tw.Write(txtGroupPrefix.Text & student.StudentGroup.ToString())
                ElseIf rdoGroupUseTeam.Checked Then
                    tw.Write(DELIMITER)
                    tw.Write(txtGroupPrefix.Text & student.StudentTeam.ToString())
                End If
                tw.Write(DELIMITER)
                tw.Write(student.StudentID)

                lblExportCount.Text = intStudentCounter.ToString("#,##0")
                lblExportCount.Refresh()

                '-- Prep for new student
                tw.Write(Environment.NewLine)
            Next
            tw.Close()
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class