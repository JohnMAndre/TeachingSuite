Public Class UpdateEmailAddressForm

    Private m_lstPreview As New List(Of Student)

    Public Sub New(emailAddress As String)

        ' This call is required by the designer.
        InitializeComponent()

        txtOldEmailAddress.Text = emailAddress
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If txtOldEmailAddress.Text.Trim.Length = 0 Then
            If MessageBox.Show("Are you sure you want to update ALL students WITHOUT email addresses?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Exit Sub
            End If
        End If

        Dim intCounter As Integer
        For Each clsgrp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In clsgrp.Classes
                For Each stud As Student In cls.Students
                    If stud.EmailAddress.ToLower = txtOldEmailAddress.Text.ToLower Then
                        stud.EmailAddress = txtNewEmailAddress.Text
                        intCounter += 1
                    End If
                Next
            Next
        Next

        Dim boolReplace As Boolean
        Dim strOldPhotoFilename As String = System.IO.Path.Combine(GetImageFolder(), txtOldEmailAddress.Text & ".jpg")
        Dim strNewPhotoFilename As String = System.IO.Path.Combine(GetImageFolder(), txtNewEmailAddress.Text & ".jpg")
        If System.IO.File.Exists(strOldPhotoFilename) Then
            If System.IO.File.Exists(strNewPhotoFilename) Then
                If MessageBox.Show(strNewPhotoFilename & " already exists. Overwrite?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    boolReplace = True
                    Try
                        System.IO.File.Delete(strNewPhotoFilename)
                    Catch ex As Exception
                        MessageBox.Show(strNewPhotoFilename & " could not be deleted. Perhaps it is being used somewhere else." & Environment.NewLine & Environment.NewLine & _
                                        "Try restarting this application.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        boolReplace = False
                    End Try
                Else
                    boolReplace = False
                End If
            Else
                boolReplace = True
            End If
            If boolReplace Then
                picStudent.Image.Dispose()
                picStudent.Image = Nothing
                System.IO.File.Copy(strOldPhotoFilename, strNewPhotoFilename)
            End If
        End If

        lblStudentsUpdated.Text = intCounter.ToString("#,##0")
    End Sub

    Private Sub btnPreview_Click(sender As System.Object, e As System.EventArgs) Handles btnPreview.Click
        m_lstPreview.Clear()

        For Each clsgrp As ClassGroup In ThisSemester.ClassGroups
            For Each cls As SchoolClass In clsgrp.Classes
                For Each stud As Student In cls.Students
                    If stud.EmailAddress.ToLower = txtOldEmailAddress.Text.ToLower Then
                        m_lstPreview.Add(stud)
                        picStudent.Image = stud.Photo
                    End If
                Next
            Next
        Next
        olvStudents.SetObjects(m_lstPreview)

        '-- Now, set the photo
        If picStudent.Image Is Nothing Then
            picStudent.Image = My.Resources.NoImage
        End If
    End Sub
    Private Sub EditSelectedStudent()
        Using frm As New StudentDetail(CType(olvStudents.SelectedObject, Student))
            If frm.ShowDialog = DialogResult.OK Then
                olvStudents.RefreshSelectedObjects()
            End If
        End Using
    End Sub
    Private Sub olvStudents_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvStudents.ItemActivate
        EditSelectedStudent()
    End Sub
End Class
