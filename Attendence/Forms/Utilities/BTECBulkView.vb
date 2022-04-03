'Copyright 2011-2022 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Teaching Suite Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Teaching Suite.  If Not, see < https: //www.gnu.org/licenses/>.

Public Class BTECBulkView

    Private m_clas As SchoolClass
    Private m_data As List(Of ReportData)
    Private m_cancel As Boolean

    Private Class ReportData
        Implements IComparable(Of ReportData)
        Public Property Student As Student
        Public Property StudentID As String
        Public Property StudentName As String
        Public Property Tags As String
        Public Property StudentGroup As String
        Public Property StudentTeam As String
        Public OverallFeedback As String = String.Empty
        Public ImprovementFeedback As String = String.Empty

        Public Property P1 As OutcomeResultStatusEnum
        Public Property P2 As OutcomeResultStatusEnum
        Public Property P3 As OutcomeResultStatusEnum
        Public Property P4 As OutcomeResultStatusEnum
        Public Property P5 As OutcomeResultStatusEnum
        Public Property P6 As OutcomeResultStatusEnum
        Public Property P7 As OutcomeResultStatusEnum
        Public Property P8 As OutcomeResultStatusEnum
        Public Property P9 As OutcomeResultStatusEnum
        Public Property M1 As OutcomeResultStatusEnum
        Public Property M2 As OutcomeResultStatusEnum
        Public Property M3 As OutcomeResultStatusEnum
        Public Property M4 As OutcomeResultStatusEnum
        Public Property M5 As OutcomeResultStatusEnum
        Public Property M6 As OutcomeResultStatusEnum
        Public Property M7 As OutcomeResultStatusEnum
        Public Property M8 As OutcomeResultStatusEnum
        Public Property M9 As OutcomeResultStatusEnum
        Public Property D1 As OutcomeResultStatusEnum
        Public Property D2 As OutcomeResultStatusEnum
        Public Property D3 As OutcomeResultStatusEnum
        Public Property D4 As OutcomeResultStatusEnum
        Public Property D5 As OutcomeResultStatusEnum
        Public Property D6 As OutcomeResultStatusEnum
        Public Property D7 As OutcomeResultStatusEnum
        Public Property D8 As OutcomeResultStatusEnum
        Public Property D9 As OutcomeResultStatusEnum

        Public ReadOnly Property P1Image As Image
            Get
                Select Case P1
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property
        Public ReadOnly Property P2Image As Image
            Get
                Select Case P2
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property
        Public ReadOnly Property P3Image As Image
            Get
                Select Case P3
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property P4Image As Image
            Get
                Select Case P4
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property P5Image As Image
            Get
                Select Case P5
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property P6Image As Image
            Get
                Select Case P6
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property P7Image As Image
            Get
                Select Case P7
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property P8Image As Image
            Get
                Select Case P8
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property P9Image As Image
            Get
                Select Case P9
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M1Image As Image
            Get
                Select Case M1
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M2Image As Image
            Get
                Select Case M2
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M3Image As Image
            Get
                Select Case M3
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M4Image As Image
            Get
                Select Case M4
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M5Image As Image
            Get
                Select Case M5
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M6Image As Image
            Get
                Select Case M6
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M7Image As Image
            Get
                Select Case M7
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M8Image As Image
            Get
                Select Case M8
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property M9Image As Image
            Get
                Select Case M9
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D1Image As Image
            Get
                Select Case D1
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D2Image As Image
            Get
                Select Case D2
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D3Image As Image
            Get
                Select Case D3
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D4Image As Image
            Get
                Select Case D4
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D5Image As Image
            Get
                Select Case D5
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D6Image As Image
            Get
                Select Case D6
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D7Image As Image
            Get
                Select Case D7
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D8Image As Image
            Get
                Select Case D8
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property

        Public ReadOnly Property D9Image As Image
            Get
                Select Case D9
                    Case OutcomeResultStatusEnum.Unknown
                        Return My.Resources.grey_ball_32
                    Case OutcomeResultStatusEnum.Achieved
                        Return My.Resources.checkmark_32
                    Case Else ' OutcomeResultStatusEnum.NotAchieved
                        Return My.Resources.delete_v2
                End Select
            End Get
        End Property


        Public Property P1Feedback As String
        Public Property P2Feedback As String
        Public Property P3Feedback As String
        Public Property P4Feedback As String
        Public Property P5Feedback As String
        Public Property P6Feedback As String
        Public Property P7Feedback As String
        Public Property P8Feedback As String
        Public Property P9Feedback As String
        Public Property M1Feedback As String
        Public Property M2Feedback As String
        Public Property M3Feedback As String
        Public Property M4Feedback As String
        Public Property M5Feedback As String
        Public Property M6Feedback As String
        Public Property M7Feedback As String
        Public Property M8Feedback As String
        Public Property M9Feedback As String
        Public Property D1Feedback As String
        Public Property D2Feedback As String
        Public Property D3Feedback As String
        Public Property D4Feedback As String
        Public Property D5Feedback As String
        Public Property D6Feedback As String
        Public Property D7Feedback As String
        Public Property D8Feedback As String
        Public Property D9Feedback As String

        Public Function CompareTo(other As ReportData) As Integer Implements IComparable(Of ReportData).CompareTo
            Return Me.StudentID.CompareTo(other.StudentID)
        End Function
    End Class
    Public Sub New(clas As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_clas = clas
        Me.Text &= " - " & m_clas.ClassGroup.Name & " - " & m_clas.Name

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SetupGrid()
        '-- need to dynamically generate columns because each outcome will be its own column
        dgvOutcomeResults.AutoGenerateColumns = False

        '-- Columns:
        '   Student ID, Name, Tags, Team, Group, then all the outcomes (P then M then D)
        Dim col As DataGridViewColumn
        'Dim styleText As New DataGridViewCellStyle()

        col = New DataGridViewTextBoxColumn()
        col.Width = 70
        col.HeaderText = "StudentID"
        col.Name = "colStudentID"
        col.ReadOnly = True
        col.DataPropertyName = "StudentID"
        'col.DefaultCellStyle = styleText
        dgvOutcomeResults.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.Width = 120
        col.HeaderText = "Name"
        col.Name = "colStudentName"
        col.ReadOnly = True
        col.DataPropertyName = "StudentName"
        dgvOutcomeResults.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.Width = 50
        col.HeaderText = "Tags"
        col.Name = "colTags"
        col.ReadOnly = True
        col.DataPropertyName = "Tags"
        dgvOutcomeResults.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.Width = 50
        col.HeaderText = "Team"
        col.Name = "colStudentTeam"
        col.ReadOnly = True
        col.DataPropertyName = "StudentTeam"
        dgvOutcomeResults.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.Width = 50
        col.HeaderText = "Group"
        col.Name = "colStudentGroup"
        col.ReadOnly = True
        col.DataPropertyName = "StudentGroup"
        dgvOutcomeResults.Columns.Add(col)

        For intCounter As Integer = 1 To m_clas.ClassGroup.Outcomes.Count
            'col = New DataGridViewCheckBoxColumn()
            col = New DataGridViewImageColumn()
            col.Width = 50
            col.HeaderText = m_clas.ClassGroup.Outcomes(intCounter - 1).Name
            col.Name = "colOutcome" & m_clas.ClassGroup.Outcomes(intCounter - 1).Name
            col.ReadOnly = True
            col.DataPropertyName = m_clas.ClassGroup.Outcomes(intCounter - 1).Name & "Image"
            CType(col, DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
            dgvOutcomeResults.Columns.Add(col)

            col = New DataGridViewTextBoxColumn()
            col.Width = 120
            col.HeaderText = m_clas.ClassGroup.Outcomes(intCounter - 1).Name & " feedback"
            col.Name = "colOutcomeFeedback" & m_clas.ClassGroup.Outcomes(intCounter - 1).Name
            col.ReadOnly = False
            col.DataPropertyName = m_clas.ClassGroup.Outcomes(intCounter - 1).Name & "Feedback"
            dgvOutcomeResults.Columns.Add(col)
        Next

    End Sub

    Private Sub LoadGrid(attempt As Semester.MarkingTry)
        '-- Here we will load the data from this class into the grid
        '-- Note: Data in the grid can be changed once it is loaded so M2 can be changed from NotAchieved to Achieved and D3 can be changed from Achieved to Not Achieved (to adjust someone down to merit for holistic marking)
        dgvOutcomeResults.DataSource = Nothing
        Application.DoEvents()

        m_data = New List(Of ReportData)

        Dim results As Student.DetailAssignmentResults
        For Each stud As Student In m_clas.Students
            Dim objData As New ReportData()
            'objData.Student = stud '-- useful when we save back changed data
            objData.StudentName = stud.LocalName
            objData.StudentID = stud.StudentID
            objData.StudentTeam = stud.StudentTeam
            objData.StudentGroup = stud.StudentGroup.ToString()
            objData.Tags = stud.Tags

            m_data.Add(objData)

            results = stud.GetDetailedAssignmentResults(attempt)
            'results.Outcomes'-- collection of outcomes with firsttry, firsttrycomments, etc.
            For Each objResult As OutcomeResult In results.Outcomes
                Select Case objResult.BaseOutcome.Name
                    Case "P1"
                        objData.P1 = objResult.FirstTryStatus
                        objData.P1Feedback = objResult.FirstTryComments
                    Case "P2"
                        objData.P2 = objResult.FirstTryStatus
                        objData.P2Feedback = objResult.FirstTryComments
                    Case "P3"
                        objData.P3 = objResult.FirstTryStatus
                        objData.P3Feedback = objResult.FirstTryComments
                    Case "P4"
                        objData.P4 = objResult.FirstTryStatus
                        objData.P4Feedback = objResult.FirstTryComments
                    Case "P5"
                        objData.P5 = objResult.FirstTryStatus
                        objData.P5Feedback = objResult.FirstTryComments
                    Case "P6"
                        objData.P6 = objResult.FirstTryStatus
                        objData.P6Feedback = objResult.FirstTryComments
                    Case "P7"
                        objData.P7 = objResult.FirstTryStatus
                        objData.P7Feedback = objResult.FirstTryComments
                    Case "P8"
                        objData.P8 = objResult.FirstTryStatus
                        objData.P8Feedback = objResult.FirstTryComments
                    Case "P9"
                        objData.P9 = objResult.FirstTryStatus
                        objData.P9Feedback = objResult.FirstTryComments

                    Case "M1"
                        objData.M1 = objResult.FirstTryStatus
                        objData.M1Feedback = objResult.FirstTryComments
                    Case "M2"
                        objData.M2 = objResult.FirstTryStatus
                        objData.M2Feedback = objResult.FirstTryComments
                    Case "M3"
                        objData.M3 = objResult.FirstTryStatus
                        objData.M3Feedback = objResult.FirstTryComments
                    Case "M4"
                        objData.M4 = objResult.FirstTryStatus
                        objData.M4Feedback = objResult.FirstTryComments
                    Case "M5"
                        objData.M5 = objResult.FirstTryStatus
                        objData.M5Feedback = objResult.FirstTryComments
                    Case "M6"
                        objData.M6 = objResult.FirstTryStatus
                        objData.M6Feedback = objResult.FirstTryComments
                    Case "M7"
                        objData.M7 = objResult.FirstTryStatus
                        objData.M7Feedback = objResult.FirstTryComments
                    Case "M8"
                        objData.M8 = objResult.FirstTryStatus
                        objData.M8Feedback = objResult.FirstTryComments
                    Case "M9"
                        objData.M9 = objResult.FirstTryStatus
                        objData.M9Feedback = objResult.FirstTryComments

                    Case "D1"
                        objData.D1 = objResult.FirstTryStatus
                        objData.D1Feedback = objResult.FirstTryComments
                    Case "D2"
                        objData.D2 = objResult.FirstTryStatus
                        objData.D2Feedback = objResult.FirstTryComments
                    Case "D3"
                        objData.D3 = objResult.FirstTryStatus
                        objData.D3Feedback = objResult.FirstTryComments
                    Case "D4"
                        objData.D4 = objResult.FirstTryStatus
                        objData.D4Feedback = objResult.FirstTryComments
                    Case "D5"
                        objData.D5 = objResult.FirstTryStatus
                        objData.D5Feedback = objResult.FirstTryComments
                    Case "D6"
                        objData.D6 = objResult.FirstTryStatus
                        objData.D6Feedback = objResult.FirstTryComments
                    Case "D7"
                        objData.D7 = objResult.FirstTryStatus
                        objData.D7Feedback = objResult.FirstTryComments
                    Case "D8"
                        objData.D8 = objResult.FirstTryStatus
                        objData.D8Feedback = objResult.FirstTryComments
                    Case "D9"
                        objData.D9 = objResult.FirstTryStatus
                        objData.D9Feedback = objResult.FirstTryComments
                End Select

                '-- Now that we have the outcome mark and feedback, we need overall and improvement feedback on each component (assessment)
                objData.OverallFeedback = String.Empty
                objData.ImprovementFeedback = String.Empty
                For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                    objData.OverallFeedback &= "Overall feedback for " & asmt.BaseAssignment.Name & Environment.NewLine
                    objData.OverallFeedback &= asmt.OverallComments & Environment.NewLine & Environment.NewLine & Environment.NewLine

                    objData.ImprovementFeedback &= "Improvement feedback for " & asmt.BaseAssignment.Name & Environment.NewLine
                    objData.ImprovementFeedback &= asmt.ImprovementComments & Environment.NewLine & Environment.NewLine & Environment.NewLine
                Next
            Next
            Application.DoEvents()
        Next

        dgvOutcomeResults.DataSource = m_data
        dgvOutcomeResults.Refresh()
    End Sub

    Private Sub GenerateMarkingSheetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateMarkingSheetsToolStripMenuItem.Click
        Try
            '-- Generate marking sheets based on contents of the grid
            Dim strFilename As String
            Dim ofd As New OpenFileDialog()
            If ofd.ShowDialog = DialogResult.OK Then
                strFilename = ofd.FileName
            Else
                Exit Sub
            End If
            llblCancel.Text = "Cancel"
            prgGeneration.Maximum = m_data.Count
            prgGeneration.Value = 0
            m_cancel = False
            Application.DoEvents()

            Dim intCounter As Integer
            For Each obj As ReportData In m_data
                intCounter += 1
                PrepareMarkingPageSimple(obj, strFilename)
                lblNumberGenerated.Text = intCounter.ToString("#,##0")
                prgGeneration.Value = intCounter
                Application.DoEvents()
                If m_cancel Then
                    llblCancel.Text = "Canceled"
                    Exit Sub
                End If
            Next

            llblCancel.Text = "Complete"

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub OutcomeFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutcomeFeedbackToolStripMenuItem.Click
        For Each col As DataGridViewColumn In dgvOutcomeResults.Columns
            If col.Name.StartsWith("colOutcomeFeedback") Then
                col.Visible = OutcomeFeedbackToolStripMenuItem.Checked
            End If
        Next
    End Sub

    Private Sub SaveChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveChangesToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to update the student(s) with the changes on this form?", PRODUCT_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            '-- Persist the changes

            MainFormReference.AutoSave() '-- persist to autosave file but not to main file, so can still be undone by closing without saving
            MessageBox.Show("Changes have been saved.", PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Nothing changed.", PRODUCT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BTECBulkView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGrid()
    End Sub

    Private Sub LoadDataForFirstTryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataForFirstTryToolStripMenuItem.Click
        LoadGrid(Semester.MarkingTry.FirstTry)
    End Sub

    Private Sub LoadDataForSecondTryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataForSecondTryToolStripMenuItem.Click
        LoadGrid(Semester.MarkingTry.SecondTry)
    End Sub

    Private Sub AutoSizeColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoSizeColumnsToolStripMenuItem.Click
        dgvOutcomeResults.AutoResizeColumns()
    End Sub

    Private Sub ChangeCellToAchievedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCellToAchievedToolStripMenuItem.Click
        SetCellTo(OutcomeResultStatusEnum.Achieved)
    End Sub

    Private Sub ChangeCellToNotAchievedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCellToNotAchievedToolStripMenuItem.Click
        SetCellTo(OutcomeResultStatusEnum.NotAchieved)
    End Sub
    Private Sub SetCellTo(status As OutcomeResultStatusEnum)
        Dim obj As ReportData = GetCurrentlySelectedStudent()
        If obj IsNot Nothing Then
            Select Case dgvOutcomeResults.Columns(dgvOutcomeResults.CurrentCell.ColumnIndex).DataPropertyName.Substring(0, 2)
                Case "P1"
                    obj.P1 = status
                Case "P2"
                    obj.P2 = status
                Case "P3"
                    obj.P3 = status
                Case "P4"
                    obj.P4 = status
                Case "P5"
                    obj.P5 = status
                Case "P6"
                    obj.P6 = status
                Case "P7"
                    obj.P7 = status
                Case "P8"
                    obj.P8 = status
                Case "P9"
                    obj.P9 = status

                Case "M1"
                    obj.M1 = status
                Case "M2"
                    obj.M2 = status
                Case "M3"
                    obj.M3 = status
                Case "M4"
                    obj.M4 = status
                Case "M5"
                    obj.M5 = status
                Case "M6"
                    obj.M6 = status
                Case "M7"
                    obj.M7 = status
                Case "M8"
                    obj.M8 = status
                Case "M9"
                    obj.M9 = status

                Case "D1"
                    obj.D1 = status
                Case "D2"
                    obj.D2 = status
                Case "D3"
                    obj.D3 = status
                Case "D4"
                    obj.D4 = status
                Case "D5"
                    obj.D5 = status
                Case "D6"
                    obj.D6 = status
                Case "D7"
                    obj.D7 = status
                Case "D8"
                    obj.D8 = status
                Case "D9"
                    obj.D9 = status

            End Select
            dgvOutcomeResults.Refresh()
        End If
    End Sub
    Private Sub ChangeCellToUnknownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCellToUnknownToolStripMenuItem.Click
        SetCellTo(OutcomeResultStatusEnum.Unknown)
    End Sub
    Private Function GetCurrentlySelectedStudent() As ReportData
        If dgvOutcomeResults.CurrentRow Is Nothing Then
            Return Nothing
        Else
            Return CType(dgvOutcomeResults.CurrentRow.DataBoundItem, ReportData)
        End If
    End Function

    Private Sub PrepareMarkingPageSimple(obj As ReportData, markingFilename As String)
        Try
            '-- copy template over to new file, in case user accidentally saves it
            Dim strTemplateFilename As String = markingFilename
            Dim strWorkingFilename As String = System.IO.Path.Combine(GetMarkingFolder(), "~temp1.docx")
            If System.IO.File.Exists(strWorkingFilename) Then
                System.IO.File.Delete(strWorkingFilename)
            End If

            System.IO.File.Copy(strTemplateFilename, strWorkingFilename, True)


            Dim strDestination As String
            Using docMarking As Xceed.Words.NET.DocX = Xceed.Words.NET.DocX.Load(strWorkingFilename)
                docMarking.ReplaceText("OOStudentIDOO", obj.StudentID)
                docMarking.ReplaceText("OOStudentNameOO", obj.StudentName)
                docMarking.ReplaceText("OOOVERALLOO", obj.OverallFeedback)
                docMarking.ReplaceText("OOIMPROVEMENTSOO", obj.ImprovementFeedback)
                docMarking.ReplaceText("OODATEOO", Date.Today.ToString("dd / MMM / yyyy"))

                strDestination = GetMarkingPageFilename(obj.StudentID)
                If System.IO.File.Exists(strDestination) Then
                    System.IO.File.Delete(strDestination)
                End If

                SetFeedbackAndMark(docMarking, "P1", obj.P1, obj.P1Feedback)
                SetFeedbackAndMark(docMarking, "P2", obj.P2, obj.P2Feedback)
                SetFeedbackAndMark(docMarking, "P3", obj.P3, obj.P3Feedback)
                SetFeedbackAndMark(docMarking, "P4", obj.P4, obj.P4Feedback)
                SetFeedbackAndMark(docMarking, "P5", obj.P5, obj.P5Feedback)
                SetFeedbackAndMark(docMarking, "P6", obj.P6, obj.P6Feedback)
                SetFeedbackAndMark(docMarking, "P7", obj.P7, obj.P7Feedback)
                SetFeedbackAndMark(docMarking, "P8", obj.P8, obj.P8Feedback)
                SetFeedbackAndMark(docMarking, "P9", obj.P9, obj.P9Feedback)

                SetFeedbackAndMark(docMarking, "M1", obj.M1, obj.M1Feedback)
                SetFeedbackAndMark(docMarking, "M2", obj.M2, obj.M2Feedback)
                SetFeedbackAndMark(docMarking, "M3", obj.M3, obj.M3Feedback)
                SetFeedbackAndMark(docMarking, "M4", obj.M4, obj.M4Feedback)
                SetFeedbackAndMark(docMarking, "M5", obj.M5, obj.M5Feedback)
                SetFeedbackAndMark(docMarking, "M6", obj.M6, obj.M6Feedback)
                SetFeedbackAndMark(docMarking, "M7", obj.M7, obj.M7Feedback)
                SetFeedbackAndMark(docMarking, "M8", obj.M8, obj.M8Feedback)
                SetFeedbackAndMark(docMarking, "M9", obj.M9, obj.M9Feedback)

                SetFeedbackAndMark(docMarking, "D1", obj.D1, obj.D1Feedback)
                SetFeedbackAndMark(docMarking, "D2", obj.D2, obj.D2Feedback)
                SetFeedbackAndMark(docMarking, "D3", obj.D3, obj.D3Feedback)
                SetFeedbackAndMark(docMarking, "D4", obj.D4, obj.D4Feedback)
                SetFeedbackAndMark(docMarking, "D5", obj.D5, obj.D5Feedback)
                SetFeedbackAndMark(docMarking, "D6", obj.D6, obj.D6Feedback)
                SetFeedbackAndMark(docMarking, "D7", obj.D7, obj.D7Feedback)
                SetFeedbackAndMark(docMarking, "D8", obj.D8, obj.D8Feedback)
                SetFeedbackAndMark(docMarking, "D9", obj.D9, obj.D9Feedback)

                docMarking.SaveAs(strDestination)

            End Using

        Catch ex As Exception
            Log(ex)
            Throw ex
        End Try

    End Sub
    Private Sub SetFeedbackAndMark(doc As Xceed.Words.NET.DocX, outcomeName As String, outcomeMark As OutcomeResultStatusEnum, outcomeFeedback As String)
        Try
            If outcomeFeedback Is Nothing Then
                outcomeFeedback = String.Empty
            End If
            Const CHECKMARK As String = "V"
            Const XMARK As String = "X"
            'Const BLANK As String = " "

            Dim originalText As String
            originalText = "OOOUTCOME" & outcomeName & "COMMENTSOO"
            doc.ReplaceText(originalText, outcomeFeedback)

            originalText = "OO" & outcomeName & "OO"
            If outcomeMark = OutcomeResultStatusEnum.Achieved Then
                doc.ReplaceText(originalText, CHECKMARK)
            Else
                doc.ReplaceText(originalText, XMARK)
            End If

        Catch ex As Exception
            Log(ex)
        End Try
    End Sub
    Private Function GetMarkingPageFilename(studentID As String) As String
        Dim strDestination As String = System.IO.Path.Combine(AppSettings.MarkingPageSaveFolder)
        If Not System.IO.Directory.Exists(strDestination) Then
            System.IO.Directory.CreateDirectory(strDestination)
        End If
        strDestination = System.IO.Path.Combine(strDestination, studentID & " - " & m_clas.ClassGroup.Name & ".docx")
        Return strDestination
    End Function

    Private Sub llblCancel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblCancel.LinkClicked
        m_cancel = True
    End Sub

    Private Sub dgvOutcomeResults_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOutcomeResults.ColumnHeaderMouseClick
        m_data.Sort()
        dgvOutcomeResults.Refresh()
    End Sub
End Class