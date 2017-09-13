Public Class ClassDetails

    Private m_class As SchoolClass

    Public Sub New(cls As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = cls
        txtClassName.Text = cls.Name
        txtEmailAddress.Text = m_class.EmailAddress
        nudEmailAccountToUse.Value = m_class.EmailSendingAccount
        txtNotes.Text = m_class.Notes
    End Sub


    Private Sub btnShowActualSessions_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnShowActualSessions.LinkClicked
        olvActualSessions.BringToFront()
    End Sub

    Private Sub btnShowNormalSchedule_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnShowNormalSchedule.LinkClicked
        olvPlannedSchedule.BringToFront()
    End Sub

    Private Sub btnShowSkips_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnShowSkips.LinkClicked
        olvSessionsToSkip.BringToFront()
    End Sub

    Private Sub AddScheduleItemToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddScheduleItemToolStripMenuItem.Click
        m_class.PlannedSchedule.Add(New PlannedScheduleItem)
        LoadPlannedSchedule()
    End Sub
    Private Sub LoadPlannedSchedule()
        olvPlannedSchedule.SetObjects(m_class.PlannedSchedule)
    End Sub
    Private Sub LoadSkipSessions()
        olvSessionsToSkip.SetObjects(m_class.SessionsToSkip)
    End Sub
    Private Sub LoadActualSessions()
        olvActualSessions.SetObjects(m_class.ActualSessions)
    End Sub
    Private Sub LoadAttendanceSessions()
        olvAttendanceSessions.SetObjects(m_class.ClassSessions)
    End Sub

    Private Sub ClassGroupForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.olvActualSessions.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf ActualSessionsRowFormatter)

            LoadSkipSessions()
            LoadPlannedSchedule()
            LoadActualSessions()
            LoadAttendanceSessions()

            SetupForLiteVersion()

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the class form: " & ex.Message)
        End Try

    End Sub
    Private Function ActualSessionsRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim item As ActualSessionItem = CType(olvi.RowObject, ActualSessionItem)

        Dim COLOR_PAST As Color = Color.LightGray
        Dim COLOR_PRESENT As Color = Color.Yellow
        Dim COLOR_FUTURE As Color = Color.White
        Dim newColor As Color

        If item.StartDateTime.Date < Date.Today.Date Then
            newColor = COLOR_PAST
        ElseIf item.StartDateTime.Date > Date.Today.Date Then
            newColor = COLOR_FUTURE
        Else
            newColor = COLOR_PRESENT
        End If

        If item IsNot Nothing Then
            olvi.BackColor = newColor
            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).BackColor = newColor
            Next
        End If
    End Function

    ''' <summary>
    ''' Removes some features for Lite (free) version
    ''' </summary>
    Private Sub SetupForLiteVersion()
        Try
            If Not AppSettings.PremiumFeaturesEnabled Then
                olvActualSessions.Visible = False
                nudEmailAccountToUse.Visible = False
                txtEmailAddress.Visible = False
                lblEmailCaption.Visible = False
                lblEmailAccountCaption.Visible = False
                btnShowActualSessions.Visible = False
                btnShowNormalSchedule.Visible = False
                btnShowSkips.Visible = False
                llblCopyTopics.Visible = False
                llblPasteTopics.Visible = False
                btnCopySessionsFromOtherClass.Visible = False
                btnRegenerateActualSchedule.Visible = False
                llblCalculateTotalTime.Visible = False
                ScheduleItemToolStripMenuItem.Visible = False

                Me.Height = 171 '-- shrink to fit visible controls
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub
    Private Sub olvPlannedSchedule_CellEditStarting(sender As System.Object, e As BrightIdeasSoftware.CellEditEventArgs) Handles olvPlannedSchedule.CellEditStarting
        If TypeOf e.Control Is DateTimePicker Then
            CType(e.Control, DateTimePicker).Format = DateTimePickerFormat.Time
            CType(e.Control, DateTimePicker).ShowUpDown = True
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If txtClassName.Text.ToLower() = COMBINED_VIEW_NAME.ToLower Then
            MessageBox.Show(COMBINED_VIEW_NAME & " is a protected name. Please choose a different name for your class.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        m_class.Name = txtClassName.Text
        m_class.EmailAddress = txtEmailAddress.Text
        m_class.EmailSendingAccount = nudEmailAccountToUse.Value
        m_class.Notes = txtNotes.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub RemoveSkipSessionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveSkipSessionToolStripMenuItem.Click
        If olvSessionsToSkip.SelectedObject IsNot Nothing Then
            m_class.SessionsToSkip.Remove(olvSessionsToSkip.SelectedObject)
            LoadSkipSessions()
        End If
    End Sub

    Private Sub SkipActualSessionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SkipActualSessionToolStripMenuItem.Click
        '-- Remove session and ignore /remove it from schedule (so we will no longer teach the subject of that session)
        If olvActualSessions.SelectedObject IsNot Nothing Then
            Dim objActual As ActualSessionItem = CType(olvActualSessions.SelectedObject, ActualSessionItem)
            Dim objSkip As New SkipSession()
            objSkip.StartDateTime = objActual.StartDateTime
            m_class.SessionsToSkip.Add(objSkip)
            LoadSkipSessions()

            '-- remove from collection and from grid
            m_class.ActualSessions.Remove(objActual)
            olvActualSessions.RemoveObject(objActual)
        End If
    End Sub

    Private Sub btnRegenerateActualSchedule_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnRegenerateActualSchedule.LinkClicked
        If MessageBox.Show("Are you sure you want to regenerate the actual sessions? This will remove data from the automatic sessions.", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            m_class.GenerateActualSessions()
            LoadActualSessions()
        End If
    End Sub

    Private Sub btnCopySessionsFromOtherClass_LinkClicked(sender As System.Object, e As System.EventArgs) Handles btnCopySessionsFromOtherClass.LinkClicked
        Using frm As New ClassSelector(m_class.ClassGroup)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                If m_class IsNot frm.SelectedClass Then
                    'GetSelectedClass().Students.Remove(Student)
                    'frm.SelectedClass.Students.Add(Student)

                    For intCounter As Integer = 0 To m_class.ActualSessions.Count - 1
                        If frm.SelectedClass.ActualSessions.Count <= intCounter Then
                            '-- do nothing
                        Else
                            m_class.ActualSessions(intCounter).Topic = frm.SelectedClass.ActualSessions(intCounter).Topic
                            m_class.ActualSessions(intCounter).Prepped = frm.SelectedClass.ActualSessions(intCounter).Prepped
                            m_class.ActualSessions(intCounter).StudentsEmailed = frm.SelectedClass.ActualSessions(intCounter).StudentsEmailed
                            m_class.ActualSessions(intCounter).Notes = frm.SelectedClass.ActualSessions(intCounter).Notes
                        End If
                    Next
                    LoadActualSessions()
                End If
            End If
        End Using
    End Sub

    Private Sub RemoveScheduleItemToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveScheduleItemToolStripMenuItem.Click
        If olvPlannedSchedule.SelectedObject Is Nothing Then
            MessageBox.Show("Please select a planned item to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            m_class.PlannedSchedule.Remove(CType(olvPlannedSchedule.SelectedObject, PlannedScheduleItem))
        End If
        LoadPlannedSchedule()
    End Sub

    Private Sub olvActualSessions_ItemActivate(sender As System.Object, e As System.EventArgs) Handles olvActualSessions.ItemActivate
        Using frm As New EditManualScheduleItem(olvActualSessions.SelectedObject)
            If frm.ShowDialog() = DialogResult.OK Then
                olvActualSessions.RefreshSelectedObjects()
            End If
        End Using
    End Sub

    Private Sub llblPasteTopics_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblPasteTopics.LinkClicked
        If Clipboard.ContainsText Then
            Try
                Dim strText As String = Clipboard.GetText()
                Dim xDoc As New Xml.XmlDocument
                xDoc.LoadXml(strText)
                If xDoc.DocumentElement.Name = "ClassTopics" Then
                    Dim intCounter As Integer
                    For Each item As ActualSessionItem In olvActualSessions.Objects
                        If xDoc.DocumentElement.ChildNodes.Count >= intCounter + 1 Then
                            Dim xElement As Xml.XmlElement = xDoc.DocumentElement.ChildNodes(intCounter)
                            item.Topic = xElement.InnerText
                            item.Notes = xElement.GetAttribute("Notes")
                            olvActualSessions.RefreshObject(item)
                        Else
                            '-- nothing else from clipboard to use
                            Exit For
                        End If

                        intCounter += 1
                    Next

                Else
                    MessageBox.Show("Cannot find on the clipboard. Please copy again.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Cannot find on the clipboard. Please copy again. Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Cannot find on the clipboard. Please copy again.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub llblCopyTopics_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblCopyTopics.LinkClicked
        Dim xDoc As New Xml.XmlDocument
        Dim root As Xml.XmlElement = xDoc.AppendChild(xDoc.CreateElement("ClassTopics"))
        Dim xTopic As Xml.XmlElement
        For Each item As ActualSessionItem In olvActualSessions.SelectedObjects
            xTopic = xDoc.CreateElement("Topic")
            xTopic.InnerText = item.Topic
            xTopic.SetAttribute("Notes", item.Notes)
            root.AppendChild(xTopic)
        Next
        Clipboard.SetText(xDoc.OuterXml)
    End Sub

    Private Sub SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SkipSelectedSessionAndRecalculateAllSessionsToolStripMenuItem.Click
        '-- Remove session and ignore /remove it from schedule (so we will no longer teach the subject of that session)
        If olvActualSessions.SelectedObject IsNot Nothing Then
            Dim objActual As ActualSessionItem = CType(olvActualSessions.SelectedObject, ActualSessionItem)
            Dim objSkip As New SkipSession()
            objSkip.StartDateTime = objActual.StartDateTime
            m_class.SessionsToSkip.Add(objSkip)
            LoadSkipSessions()

            '-- Regen sessions
            m_class.GenerateActualSessions()
            LoadActualSessions()
        End If
    End Sub

    Private Sub InsertSessionBeforeSelectedSessionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InsertSessionBeforeSelectedSessionToolStripMenuItem.Click
        '-- Add new session before the selected session
        If olvActualSessions.SelectedObject IsNot Nothing Then
            Dim objActual As ActualSessionItem = CType(olvActualSessions.SelectedObject, ActualSessionItem)

            Dim objNewSession As New ActualSessionItem(m_class)
            objNewSession.SessionNumber = objActual.SessionNumber + 1
            objNewSession.Prepped = False
            objNewSession.Location = String.Empty
            objNewSession.ScheduleType = ScheduleTypeEnum.Manual
            objNewSession.StartDateTime = objActual.StartDateTime
            objNewSession.StudentsEmailed = False
            objNewSession.Topic = "New topic"

            '-- Add to collection and grid
            m_class.ActualSessions.Insert(m_class.ActualSessions.IndexOf(objActual), objNewSession)
            LoadActualSessions()
        End If
    End Sub

    Private Sub MovedownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovedownToolStripMenuItem.Click
        MoveActualItemDown()
    End Sub

    Private Sub MoveupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveupToolStripMenuItem.Click


    End Sub
    Private Sub MoveActualItemDown()
        '-- as long as this is not the final item in the schedule, then we will move it down and move the one below it up
        If olvActualSessions.SelectedObject IsNot Nothing Then
            Dim intIndex As Integer

            Dim objActual1 As ActualSessionItem = CType(olvActualSessions.SelectedObject, ActualSessionItem)
            Dim objActual2 As ActualSessionItem
            intIndex = m_class.ActualSessions.IndexOf(objActual1)
            If intIndex < m_class.ActualSessions.Count - 1 Then
                objActual2 = m_class.ActualSessions(intIndex + 1)

                Dim dtTemp As Date = objActual1.StartDateTime
                objActual1.StartDateTime = objActual2.StartDateTime
                objActual2.StartDateTime = dtTemp

                Dim intTemp As Integer = objActual1.SessionNumber
                objActual1.SessionNumber = objActual2.SessionNumber
                objActual2.SessionNumber = intTemp

                m_class.ActualSessions.RemoveAt(intIndex)
                m_class.ActualSessions.Insert(intIndex + 1, objActual1)
            End If

            LoadActualSessions()
            olvActualSessions.SelectObject(objActual1)
        End If
    End Sub
    Private Sub MoveDownToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoveDownToolStripMenuItem1.Click
        MoveActualItemDown()
    End Sub
    Private Sub MoveActualItemUp()
        '-- as long as this is not the first item in the schedule, then we will move it up and move the one above it down
        If olvActualSessions.SelectedObject IsNot Nothing Then
            Dim intIndex As Integer

            Dim objActual1 As ActualSessionItem = CType(olvActualSessions.SelectedObject, ActualSessionItem)
            Dim objActual2 As ActualSessionItem
            intIndex = m_class.ActualSessions.IndexOf(objActual1)
            If intIndex > 0 Then
                objActual2 = m_class.ActualSessions(intIndex - 1)

                Dim dtTemp As Date = objActual1.StartDateTime
                objActual1.StartDateTime = objActual2.StartDateTime
                objActual2.StartDateTime = dtTemp

                Dim intTemp As Integer = objActual1.SessionNumber
                objActual1.SessionNumber = objActual2.SessionNumber
                objActual2.SessionNumber = intTemp

                m_class.ActualSessions.RemoveAt(intIndex)
                m_class.ActualSessions.Insert(intIndex - 1, objActual1)
            End If

            LoadActualSessions()
            olvActualSessions.SelectObject(objActual1)
        End If
    End Sub
    Private Sub MoveupToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoveupToolStripMenuItem1.Click
        MoveActualItemUp()
    End Sub

    Private Sub llblCalculateTotalTime_LinkClicked(sender As Object, e As EventArgs) Handles llblCalculateTotalTime.LinkClicked
        Dim intTotalMinutes As Integer
        For Each item As ActualSessionItem In m_class.ActualSessions
            intTotalMinutes += item.DurationInMinutes
        Next
        Dim dblHours As Double = intTotalMinutes / 60
        llblCalculateTotalTime.Text = dblHours.ToString("#,##0.0") & " hours"

        tmrResetDuration.Start()
    End Sub

    Private Sub tmrResetDuration_Tick(sender As Object, e As EventArgs) Handles tmrResetDuration.Tick
        tmrResetDuration.Stop()
        llblCalculateTotalTime.Text = "Calculate total duration"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DeleteAttendanceSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAttendanceSessionToolStripMenuItem.Click
        Dim session As ClassSession = olvAttendanceSessions.GetSelectedObject
        If session Is Nothing Then
            MessageBox.Show("Please select an attendance record to remove.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.m_class.ClassSessions.Remove(session)
            olvAttendanceSessions.RemoveObject(session)
        End If
    End Sub

    Private Sub AddAttendanceSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAttendanceSessionToolStripMenuItem.Click
        Dim session As New ClassSession()
        session.StudentGroup = 0
        session.StartDate = Date.Today
        Me.m_class.ClassSessions.Add(session)
        olvAttendanceSessions.AddObject(session)
    End Sub

    Private Sub btnShowAttendanceSessions_LinkClicked(sender As Object, e As EventArgs) Handles btnShowAttendanceSessions.LinkClicked
        olvAttendanceSessions.BringToFront()
    End Sub
End Class
