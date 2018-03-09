Public Class ScheduleExport

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            ExportSessions()
            Close()

        Catch ex As Exception
            Log(ex)
            btnOK.Enabled = True
            btnCancel.Enabled = True

        End Try
    End Sub

    Public Sub ExportSessions()
        If txtFilename.Text.Trim.Length = 0 Then
            MessageBox.Show("Please select an export filename.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New Exception("Missing filename.")
        End If

        If lstClassGroups.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select the module(s) to export.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New Exception("Modules not selected.")
        End If
        
        btnOK.Enabled = False
        btnCancel.Enabled = False

        Dim strFilenameMainFile, strFilenameRollback As String
        Dim sbMailFile As New System.Text.StringBuilder()
        Dim sbRollback As New System.Text.StringBuilder()
        Dim dtEnd As DateTime

        sbMailFile.AppendLine("BEGIN:VCALENDAR")
        sbMailFile.AppendLine("VERSION:2.0")
        sbMailFile.AppendLine("PRODID:Teaching App")

        If chkCreateRollbackFile.Checked Then
            sbRollback = New System.Text.StringBuilder()
            sbRollback.AppendLine("BEGIN:VCALENDAR")
            sbRollback.AppendLine("VERSION:2.0")
            sbRollback.AppendLine("PRODID:Teaching App")
        End If

        Dim strSummary As String
        strFilenameMainFile = txtFilename.Text.Trim
        strFilenameRollback = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(txtFilename.Text.Trim), System.IO.Path.GetFileNameWithoutExtension(txtFilename.Text.Trim()) & ".Rollback" & System.IO.Path.GetExtension(txtFilename.Text.Trim()))

        For Each grp As ClassGroup In lstClassGroups.SelectedItems
            For Each cls As SchoolClass In grp.Classes
                For Each item As ActualSessionItem In cls.ActualSessions
                    If (chkExportAllSessions.Checked) OrElse (item.StartDateTime > Date.Now) Then

                        sbMailFile.AppendLine("BEGIN:VEVENT")
                        sbMailFile.AppendLine("UID:" & item.UniqueID)
                        If item.NumberOfTimesExported > 0 Then
                            sbMailFile.AppendLine("SEQUENCE:" & item.NumberOfTimesExported)
                        End If
                        item.NumberOfTimesExported += 1
                        sbMailFile.AppendLine("DTSTART:" & item.StartDateTime.ToString("yyyyMMddTHHmm00"))
                        If item.DurationInMinutes = 0 Then
                            '-- older data (before 2015) will not have duration at the item level so much go to classgroup level
                            dtEnd = item.StartDateTime.AddMinutes(grp.SessionLength)
                        Else
                            dtEnd = item.StartDateTime.AddMinutes(item.DurationInMinutes)
                        End If
                        sbMailFile.AppendLine("DTEND:" & dtEnd.ToString("yyyyMMddTHHmm00"))
                        If grp.Classes.Count = 1 Then
                            '-- If just one, then only use the Group name
                            strSummary = item.Location & " " & grp.Name & " " & item.Topic
                        Else
                            '-- If more than one, use group and class name
                            strSummary = item.Location & " " & grp.Name & " " & cls.Name & " " & item.Topic
                        End If
                        sbMailFile.AppendLine("SUMMARY:" & strSummary)
                        sbMailFile.AppendLine("DESCRIPTION:" & item.Notes)
                        If chkSetAlarm.Checked Then
                            sbMailFile.AppendLine("BEGIN:VALARM")
                            sbMailFile.AppendLine("TRIGGER:-PT" & nudAlarmMinutes.Value.ToString() & "M")
                            sbMailFile.AppendLine("ACTION:DISPLAY")
                            sbMailFile.AppendLine("DESCRIPTION:" & strSummary)
                            sbMailFile.AppendLine("END:VALARM")
                        End If
                        sbMailFile.AppendLine("END:VEVENT")


                        '-- Now do for rollback
                        If chkCreateRollbackFile.Checked Then
                            sbRollback.AppendLine("BEGIN:VEVENT")
                            sbRollback.AppendLine("UID:" & item.UniqueID)
                            sbRollback.AppendLine("SEQUENCE:" & item.NumberOfTimesExported)
                            sbRollback.AppendLine("STATUS:CANCELLED")
                            sbRollback.AppendLine("DTSTART:" & item.StartDateTime.ToString("yyyyMMddTHHmm00"))
                            If item.DurationInMinutes = 0 Then
                                '-- older data (before 2015) will not have duration at the item level so much go to classgroup level
                                dtEnd = item.StartDateTime.AddMinutes(grp.SessionLength)
                            Else
                                dtEnd = item.StartDateTime.AddMinutes(item.DurationInMinutes)
                            End If
                            sbRollback.AppendLine("DTEND:" & dtEnd.ToString("yyyyMMddTHHmm00"))
                            sbRollback.AppendLine("SUMMARY:" & strSummary)
                            sbRollback.AppendLine("DESCRIPTION:" & item.Notes)
                            If chkSetAlarm.Checked Then
                                sbRollback.AppendLine("BEGIN:VALARM")
                                sbRollback.AppendLine("TRIGGER:-PT" & nudAlarmMinutes.Value.ToString() & "M")
                                sbRollback.AppendLine("ACTION:DISPLAY")
                                sbRollback.AppendLine("DESCRIPTION:" & strSummary) '-- description of the alarm, not the event
                                sbRollback.AppendLine("END:VALARM")
                            End If
                            sbRollback.AppendLine("END:VEVENT")
                        End If
                    End If
                Next
            Next
        Next
        sbMailFile.AppendLine("END:VCALENDAR")
        System.IO.File.WriteAllText(strFilenameMainFile, sbMailFile.ToString())

        If chkCreateRollbackFile.Checked Then
            sbRollback.AppendLine("END:VCALENDAR")
            System.IO.File.WriteAllText(strFilenameRollback, sbRollback.ToString())
        End If

        btnOK.Enabled = True
        btnCancel.Enabled = True

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub llblBrowseForExportFilename_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblBrowseForExportFilename.LinkClicked
        Dim sfd As New SaveFileDialog()
        sfd.AddExtension = True
        sfd.DefaultExt = "ics"
        sfd.Filter = "iCalendar files|*.ics"
        sfd.OverwritePrompt = True
        If sfd.ShowDialog() = DialogResult.OK Then
            txtFilename.Text = sfd.FileName
        End If
    End Sub
    Private Sub LoadClassGroups()
        lstClassGroups.Items.Clear()
        For Each objClassGroup As ClassGroup In ThisSemester.ClassGroups
            If objClassGroup IsNot Nothing Then
                lstClassGroups.Items.Add(objClassGroup)
            End If
        Next

        '-- Auto-select if there is a single module
        If lstClassGroups.Items.Count = 1 Then
            lstClassGroups.SelectedIndex = 0
        End If
    End Sub

    Private Sub ScheduleExport_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadClassGroups()
    End Sub
End Class
