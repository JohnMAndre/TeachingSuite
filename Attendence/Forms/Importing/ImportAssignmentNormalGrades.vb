Public Class ImportAssignmentNormalGrades
    Friend Class ImportData
        Public Property Student As Student
        Public Property ExtStudentID As String
        Public Property Grade As Integer
        Public Property OverallComments As String
    End Class

    Private m_boolCancel As Boolean
    Private m_dictHistoricalStudentsByExtStudentID As New Dictionary(Of String, Student)
    Private m_dictHistoricalStudentsByStudentID As New Dictionary(Of String, Student)
    Private m_lst As New List(Of ImportData)
    Private m_clsGroup As ClassGroup
    Private m_asmt As ClassAssignment

    Public Sub New(clsGroup As ClassGroup, asmt As ClassAssignment)

        ' This call is required by the designer.
        InitializeComponent()

        m_clsGroup = clsGroup
        m_asmt = asmt
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            m_lst.Clear()
            Dim objStud As Student
            Dim objData As ImportData

            Dim strClipboard As String = Clipboard.GetText()
            If strClipboard Is Nothing Then
                MessageBox.Show("The clipboard is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(vbTab) Then
                MessageBox.Show("The clipboard data does not contain tabs. It must be spreadsheet data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not strClipboard.Contains(Environment.NewLine) Then
                MessageBox.Show("The clipboard does not contain multiple lines but it needs to (you can manually enter one student, right?).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim strRows() As String
                strRows = strClipboard.Split(Environment.NewLine)
                Dim row() As String
                For intCounter As Integer = 0 To strRows.Count - 1
                    row = strRows(intCounter).Split(vbTab)
                    If row.Length < 2 Then
                        If m_lst.Count > 0 Then
                            '-- we are done
                            Exit For
                        Else
                            MessageBox.Show("There should be 2 columns of data: ExtStudentID and Grade (the clipboard has " & row.Length & ").")
                        End If
                    End If
                    objData = New ImportData()
                    objData.ExtStudentID = row(0).Trim
                    objData.Grade = ConvertToInt32(row(1).Trim(), 0)
                    If row.Length > 2 Then
                        objData.OverallComments = row(2).Trim()
                        If objData.OverallComments.StartsWith("""") Then
                            objData.OverallComments = objData.OverallComments.Substring(1) '-- eliminate leading quote
                        End If

                        If objData.OverallComments.EndsWith("""") Then
                            objData.OverallComments = objData.OverallComments.Substring(0, objData.OverallComments.Length - 1) '-- eliminate trailing quote
                        End If

                    End If

                    Select Case cboIDToUse.SelectedIndex
                        Case 0
                            objStud = GetStudentByStudentID(objData.ExtStudentID)
                        Case 1
                            objStud = GetStudentByExtStudentID(objData.ExtStudentID)
                    End Select
                    If objStud IsNot Nothing Then
                        objData.Student = objStud
                    Else
                        objData.Student = Nothing
                    End If

                    m_lst.Add(objData)
                Next
                olvData.SetObjects(m_lst)
            End If
        Catch ex As Exception
            MessageBox.Show("There was a problem pasting (" & ex.Message & ").", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetStudentByExtStudentID(extStudentID As String) As Student
        If m_dictHistoricalStudentsByExtStudentID.ContainsKey(extStudentID.ToUpper()) Then
            Return m_dictHistoricalStudentsByExtStudentID(extStudentID.ToUpper())
        Else
            Return Nothing
        End If
    End Function
    Private Function GetStudentByStudentID(studentID As String) As Student
        If m_dictHistoricalStudentsByStudentID.ContainsKey(studentID.ToUpper()) Then
            Return m_dictHistoricalStudentsByStudentID(studentID.ToUpper())
        Else
            Return Nothing
        End If
    End Function
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim ht As New Hashtable() '-- key  = extstudentID, value = student object

        Dim intStudentsAdded, intStudentsSearched As Integer
        Do
            For Each cls As SchoolClass In m_clsGroup.Classes
                For Each stud In cls.Students
                    intStudentsSearched += 1
                    '-- add to collection, only if there IS a student ID
                    If Not m_dictHistoricalStudentsByExtStudentID.ContainsKey(stud.ExtStudentID.ToUpper()) AndAlso stud.ExtStudentID.Trim.Length > 0 Then
                        m_dictHistoricalStudentsByExtStudentID.Add(stud.ExtStudentID.ToUpper, stud)
                        intStudentsAdded += 1
                    End If

                    If Not m_dictHistoricalStudentsByStudentID.ContainsKey(stud.StudentID.ToUpper()) AndAlso stud.StudentID.Trim.Length > 0 Then
                        m_dictHistoricalStudentsByStudentID.Add(stud.StudentID.ToUpper, stud)
                        intStudentsAdded += 1
                    End If

                    lblStudentsSearched.Text = intStudentsSearched.ToString("#,##0")
                    lblStudentsLoaded.Text = intStudentsAdded.ToString("#,##0")
                    If m_boolCancel Then
                        Exit Do
                    End If
                    Application.DoEvents()
                Next
            Next

            Exit Do
        Loop While True

        btnImport.Enabled = True
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            txtOutput.Text = String.Empty

            '-- Create asmt for student and populate with data
            Dim intCounter As Integer
            Dim asmtToUse As StudentAssignment
            For Each data As ImportData In m_lst
                If data.Student IsNot Nothing Then
                    asmtToUse = Nothing
                    For Each asmt As StudentAssignment In data.Student.Assignments
                        If asmt.BaseAssignment.ID = m_asmt.ID Then
                            asmtToUse = asmt
                            Exit For
                        End If
                    Next

                    If asmtToUse Is Nothing Then
                        asmtToUse = data.Student.AddAssignment(m_asmt)
                        asmtToUse.FirstTryPoints = data.Grade
                        asmtToUse.OverallComments = data.OverallComments & Environment.NewLine & Environment.NewLine & "Imported on " & Date.Today.ToString("dd-MM-yyyy")
                    End If

                    intCounter += 1
                Else
                    '-- what to do if there is no student? Write to output panel I guess.
                    txtOutput.Text &= "Student (ExtID: " & data.ExtStudentID & ") could not be found in database." & Environment.NewLine
                End If
            Next

            AddHistory("Imported normal assignment grades (Module: " & m_asmt.ClassGroup.ToString() & ", assignment: " & m_asmt.ToString() & ").")

            txtOutput.Text &= "Imported " & intCounter.ToString("#,##0") & " records." & Environment.NewLine
            'MessageBox.Show("Imported " & intCounter.ToString("#,##0") & " records.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error importing: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ImportAssignmentNormalGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboIDToUse.SelectedIndex = 1 '-- default to ExtStudentID
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class