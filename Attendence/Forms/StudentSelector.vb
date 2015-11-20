Public Class StudentSelector
   
    Public ReadOnly Property SelectedStudent As Student
        Get
            If olvStudents.SelectedObject Is Nothing Then
                Return Nothing
            Else
                Return CType(olvStudents.SelectedObject, Student)
            End If
        End Get
    End Property
    Private Sub LoadClassGroups()
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
            For Each objClass As SchoolClass In GetSelectedClassGroup.Classes
                lstClasses.Items.Add(objClass)
            Next
            If GetSelectedClassGroup.Classes.Count > 1 Then
                Dim cls As New SchoolClass(GetSelectedClassGroup())
                cls.Name = COMBINED_VIEW_NAME
                lstClasses.Items.Add(cls)
            ElseIf GetSelectedClassGroup.Classes.Count = 1 Then
                '-- auto-select the only class there
                lstClasses.SelectedIndex = 0
                Application.DoEvents()
                LoadStudents()
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
    Private Function GetSelectedClass() As SchoolClass
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
    Private Sub LoadStudents()
        Dim objClass As SchoolClass = CType(lstClasses.Items(lstClasses.SelectedIndex), SchoolClass)
        If ClassIsCombinedView(objClass) Then
            Dim boolSetAlready As Boolean
            For Each objCls As SchoolClass In GetSelectedClassGroup.Classes
                If Not boolSetAlready Then
                    olvStudents.SetObjects(objCls.Students)
                    boolSetAlready = True
                Else
                    olvStudents.AddObjects(objCls.Students)
                End If
            Next
        Else
            olvStudents.SetObjects(objClass.Students)
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If SelectedStudent Is Nothing Then
            MessageBox.Show("Please select a student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub StudentSelector_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadClassGroups()
    End Sub
    Private Sub lstClassGroups_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClassGroups.SelectedIndexChanged
        olvStudents.ClearObjects()
        LoadClasses()
    End Sub
    Private Sub lstClasses_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstClasses.SelectedIndexChanged
        LoadStudents()
    End Sub
End Class
