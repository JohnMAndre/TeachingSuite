Imports System.IO
Imports System.Xml

Public Class SendFeedbackRequest

    Private m_scheduleItem As ActualSessionItem

    Public Sub New(item As ActualSessionItem)

        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = item.ClassGroupName & " - " & item.SchoolClassName
        m_scheduleItem = item

    End Sub
    Private Sub SendFeedbackRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intPresent, intExcused, intTotalStudents As Integer
        For Each stud As Student In m_scheduleItem.SchoolClass.Students
            intTotalStudents += 1
            Select Case stud.LatestAttendenceStatus
                Case AttendanceStatusEnum.Excused
                    intExcused += 1
                Case AttendanceStatusEnum.Present
                    intPresent += 1
            End Select
        Next

        nudStudentsPresentAtEnd.Maximum = intTotalStudents

        lblTotalStudents.Text = intTotalStudents.ToString()
        lblTotalStudentsExcused.Text = intExcused.ToString()
        lblTotalStudentsPresent.Text = intPresent.ToString()
        intTotalStudents = intExcused + intPresent
        lblTotalStudentsPresentAndExcused.Text = intTotalStudents.ToString()

        nudStudentsPresentAtEnd.Value = intTotalStudents.ToString() '-- default

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        '-- send emails
        Try
            btnSend.Enabled = False
            Dim intSent As Integer
            Dim obj As EmailCreator
            Dim strTrulyMailOutboxPath As String
            Dim strURL As String
            Dim dtWhenToSend As Date = Date.Now.AddHours(nudDelaySend.Value)

            Dim di As New DirectoryInfo(AppSettings.PathToTrulyMailEXE)
            di = di.Parent
            di = di.Parent
            strTrulyMailOutboxPath = Path.Combine(di.FullName, "Data", "Profile", "Messages", "Outbox")
            di = Nothing

            '-- Pre-fill the date and class name
            strURL = txtURL.Text.Replace("[[ClassName]]", m_scheduleItem.SchoolClass.ID).Replace("[[SessionDate]]", m_scheduleItem.StartDateTime.Date.ToString("yyyy-MM-dd"))

            For Each stud As Student In m_scheduleItem.SchoolClass.Students
                obj = New EmailCreator()
                obj.RecipientAddress = stud.EmailAddress
                If stud.Nickname.Length > 0 Then
                    '-- use nickname if there is one
                    obj.RecipientFullName = stud.Nickname
                Else
                    obj.RecipientFullName = stud.LocalNameLatinLetters
                End If
                obj.Subject = txtSubject.Text
                obj.Body = txtBody.Text.Replace("[[FullName]]", stud.LocalNameLatinLetters).Replace("[[URL]]", strURL)
                obj.SendAfter = dtWhenToSend
                obj.PlainText = True
                obj.SMTPAccount = AppSettings.EmailSendingAccount
                obj.SendToOutbox(strTrulyMailOutboxPath)
                intSent += 1
                lblSent.Text = intSent.ToString()
                Application.DoEvents()
            Next

            '-- Now log that we sent for later analysis
            Dim xDoc As New Xml.XmlDocument()
            Dim strDataFilename As String

            di = New DirectoryInfo(Application.ExecutablePath)
            di = di.Parent
            di = di.Parent

            strDataFilename = Path.Combine(di.FullName, "Data", "FeedbackRequests", "FeedbackRequestData.xml")

            If System.IO.File.Exists(strDataFilename) Then
                '-- Use existing data file
                xDoc.Load(strDataFilename)

                '-- Check if file was converted yet
                If CType(xDoc.DocumentElement.ChildNodes(0), XmlElement).GetAttribute("URL").Length = 0 Then
                    '-- Not converted yet, so convert now
                    Application.DoEvents()
                    For Each xElement As XmlElement In xDoc.DocumentElement.ChildNodes
                        xElement.SetAttribute("URL", xElement.InnerText)
                        xElement.InnerText = String.Empty
                    Next
                End If

            Else
                '-- we use the default data file from app folder
                xDoc.Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "html", "FeedbackRequestData.xml"))
            End If
            Dim xRequests As Xml.XmlElement = xDoc.DocumentElement
            Dim xRequest As Xml.XmlElement = xDoc.CreateElement("Request")
            xRequests.AppendChild(xRequest)

            xRequest.SetAttribute("StudentsAtEndOfClass", nudStudentsPresentAtEnd.Value.ToString())
            xRequest.SetAttribute("StudentsPresent", lblTotalStudentsPresent.Text)
            xRequest.SetAttribute("StudentsExcused", lblTotalStudentsExcused.Text)
            xRequest.SetAttribute("TotalStudents", lblTotalStudents.Text)
            xRequest.SetAttribute("StudentsSent", lblSent.Text)
            xRequest.SetAttribute("WhenSent", dtWhenToSend.ToString("yyyy-MM-ddTHH-mm"))
            xRequest.SetAttribute("ClassGroup", m_scheduleItem.ClassGroupName)
            xRequest.SetAttribute("ClassName", m_scheduleItem.SchoolClass.Name)
            xRequest.SetAttribute("SessionTopic", m_scheduleItem.Topic)
            xRequest.SetAttribute("Location", m_scheduleItem.Location)
            xRequest.SetAttribute("Duration", m_scheduleItem.DurationInMinutes)
            xRequest.SetAttribute("Notes", m_scheduleItem.Notes)
            xRequest.SetAttribute("SessionDate", m_scheduleItem.StartDateTime.Date.ToString("yyyy-MM-dd"))
            xRequest.SetAttribute("SessionID", m_scheduleItem.UniqueID)
            xRequest.SetAttribute("URL", strURL)
            xRequest.InnerText = txtComments.Text.Trim()

            If Not System.IO.Directory.Exists(Path.GetDirectoryName(strDataFilename)) Then
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(strDataFilename))
            End If

            xDoc.Save(strDataFilename)


        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub llblOptions_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblOptions.LinkClicked
        Using frm As New OptionsForm
            If frm.ShowDialog(Me) = DialogResult.OK Then
                '-- Do nothing
            End If
        End Using
    End Sub
End Class