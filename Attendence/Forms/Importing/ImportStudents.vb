Public Class ImportStudents

    Private m_class As SchoolClass

    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
        lblTitle.Text &= " " & schoolClass.Name
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            Dim intStudentsImported As Integer
            For Each strLine As String In txtImportText.Lines
                Dim strData() As String = strLine.Split(vbTab)
                If strData.Length >= 4 Then
                    Dim student As New Student(m_class)
                    student.AdminNumber = strData(0)
                    student.LocalName = strData(1)
                    student.StudentID = strData(2)
                    If strData.Length >= 4 Then
                        student.Nickname = strData(3)
                    End If
                    If strData.Length >= 5 Then
                        student.EmailAddress = strData(4)
                    End If
                    If strData.Length >= 6 Then
                        student.AltNumber = strData(5)
                    End If

                    m_class.Students.Add(student)
                    intStudentsImported += 1
                End If
            Next

            If intStudentsImported > 0 Then
                MessageBox.Show(intStudentsImported.ToString("#,##0") & " students imported.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub
End Class
