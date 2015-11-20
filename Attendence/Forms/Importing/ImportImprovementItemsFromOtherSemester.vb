Public Class ImportImprovementItemsFromOtherSemester

    Private m_sourceSemester As Semester

    Private Sub ImportImprovementItemsFromOtherSemester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSemesters()
    End Sub
    Private Sub LoadSemesters()
        Dim files() As String = System.IO.Directory.GetFiles(GetDataFolder(), "*" & DATA_FILE_EXTENSION)
        Dim lst As New List(Of String)
        For Each s As String In files
            lst.Add(s)
        Next
        lst.Sort()
        cboSemester.Items.Clear()
        For Each strFilename As String In lst
            cboSemester.Items.Add(System.IO.Path.GetFileNameWithoutExtension(strFilename))
        Next
    End Sub

    Private Sub btnLoadSemester_LinkClicked(sender As Object, e As EventArgs) Handles btnLoadSemester.LinkClicked
        LoadSemester()
    End Sub
    Private Sub LoadSemester()
        Try
            '-- Load the selected semester from data file
            m_sourceSemester = New Semester(cboSemester.Items(cboSemester.SelectedIndex))
            Me.Text = "Import From - " & m_sourceSemester.Name
            btnLoadSemester.Enabled = False

            LoadImprovementItems()
        Catch ex As Exception
            MessageBox.Show("There was an error loading the selected semester: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadImprovementItems()
        'Dim boolItemAdded As Boolean
        'For Each item As ImprovementItem In m_sourceSemester.ImprovementItems
        '    boolItemAdded = False
        '    For Each studItem As StudentImprovementItem In m_student.ImprovementItems
        '        If studItem.BaseImprovementItem Is item Then
        '            m_improvementItems.Add(studItem)
        '            boolItemAdded = True
        '            Exit For
        '        End If
        '    Next
        '    If Not boolItemAdded Then
        '        Dim studItem As New StudentImprovementItem()
        '        studItem.BaseImprovementItem = item
        '        studItem.DateAdded = DATE_NO_DATE
        '        studItem.DateRemoved = DATE_NO_DATE
        '        m_improvementItems.Add(studItem)
        '    End If
        'Next
        olvImprovementItems.SetObjects(m_sourceSemester.ImprovementItems)
        AutoSizeColumns(olvImprovementItems)
    End Sub

    Private Sub cboSemester_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSemester.SelectedIndexChanged
        btnLoadSemester.Enabled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If olvImprovementItems.SelectedObjects.Count = 0 Then
            MessageBox.Show("Please select which items you want to import.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim boolOKToAdd As Boolean
        Dim lstItemsNotImported As New List(Of ImprovementItem)

        For Each item As ImprovementItem In olvImprovementItems.SelectedObjects
            boolOKToAdd = True
            '-- make sure it does not exist already
            For Each existing As ImprovementItem In ThisSemester.ImprovementItems
                If existing.Name.ToLower = item.Name.ToLower OrElse _
                    existing.Description.ToLower = item.Description.ToLower OrElse _
                    existing.ID.ToLower = item.ID.ToLower Then
                    lstItemsNotImported.Add(item)
                    boolOKToAdd = False
                    Exit For
                End If
            Next
            If boolOKToAdd Then
                ThisSemester.ImprovementItems.Add(item)
            End If
        Next

        If lstItemsNotImported.Count > 0 Then
            If MessageBox.Show(lstItemsNotImported.Count.ToString("#,##0") & " items were not added because they seem to exist already." & _
                            Environment.NewLine & Environment.NewLine & "Would you like to see that list now?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                olvImprovementItems.SetObjects(lstItemsNotImported)
            End If
        Else
            Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class