Friend Class StudentAssignmentNormalDetails
    Private m_student As Student
    Private m_studentAssignment As StudentAssignment
    Private m_studentModuleResults As Student.StudentModuleResult
    Private m_boolAssignmentCreated As Boolean
    Private m_try As MarkingTry
    Private m_dtTimerStart As Date = Date.Now
    Private m_boolTimerRunning As Boolean = True
    Private m_tsTimer As TimeSpan
    Private m_improvementItems As New List(Of StudentImprovementItem) '-- include those assigned to the student and those not

    Public Sub New(student As Student, assignment As StudentAssignment, attempt As MarkingTry)

        ' This call is required by the designer.
        InitializeComponent()

        m_student = student
        m_studentAssignment = assignment
        m_try = attempt
    End Sub
    Public Sub New(student As Student, assignment As ClassAssignment, attempt As MarkingTry)
        Try
            ' This call is required by the designer.
            InitializeComponent()

            m_student = student
            m_try = attempt '-- could be redo because didn't submit...so second try, first failed all
            lblMaxPoints.Text &= assignment.MaxPoints.ToString("#,##0")

            '-- find student assignment
            For Each asmt As StudentAssignment In student.Assignments
                If asmt.BaseAssignment Is assignment Then
                    m_studentAssignment = asmt
                    Exit For
                End If
            Next

            If m_studentAssignment Is Nothing Then
                '-- create assignment for student
                m_studentAssignment = m_student.AddAssignment(assignment)
                m_boolAssignmentCreated = True
                m_studentAssignment.OverallComments = assignment.OverallDefaultText
            End If
        Catch ex As Exception
            Log(ex)
        End Try


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub StudentAssignmentNormalDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AppSettings.StudentAssignmentNormalWindowX = Me.Location.X
        AppSettings.StudentAssignmentNormalWindowY = Me.Location.Y
        AppSettings.StudentAssignmentNormalWindowWidth = Me.Size.Width
        AppSettings.StudentAssignmentNormalWindowHeight = Me.Size.Height
    End Sub

    Private Function ImprovementItemRowFormatter(ByVal olvi As BrightIdeasSoftware.OLVListItem) As Object
        Dim item As StudentImprovementItem = CType(olvi.RowObject, StudentImprovementItem)

        Dim RESOLVED_ISSUE_COLOR As Color = Color.LightGreen
        Dim CURRENT_ISSUE_COLOR As Color = Color.Yellow
        Dim NON_ISSUE_COLOR As Color = Color.White
        Dim newColor As Color

        If item.DateAdded = DATE_NO_DATE Then
            newColor = NON_ISSUE_COLOR
            olvi.SubItems(olvcolDataAdded.Index).Text = String.Empty
        Else
            '-- so it was a problem
            If item.DateRemoved = DATE_NO_DATE Then
                '-- and it is still a problem
                newColor = CURRENT_ISSUE_COLOR
            Else
                '-- the student has fixed this problem
                newColor = RESOLVED_ISSUE_COLOR
            End If
        End If

        If item.DateLastIncluded = DATE_NO_DATE Then
            olvi.SubItems(olvcolDateRemoved.Index).Text = String.Empty
        End If

        If item IsNot Nothing Then
            olvi.BackColor = newColor
            For intCounter As Integer = 0 To olvi.SubItems.Count - 1
                olvi.SubItems(intCounter).BackColor = newColor
            Next
        End If
    End Function

    Private Sub StudentAssignmentNormalDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.olvImprovementItems.RowFormatter = New BrightIdeasSoftware.RowFormatterDelegate(AddressOf ImprovementItemRowFormatter)
        olvcolPerformanceLevel.ToolTipText = "Performance level (0-5)" & Environment.NewLine & "0=Not evaluated" & Environment.NewLine & "1=Unacceptable" & Environment.NewLine & "2=Very weak, incorrect very often" & Environment.NewLine & "3=Sometimes OK but inconsistent" & Environment.NewLine & "4=Good but still room for improvement" & Environment.NewLine & "5=Completely correct"

        chkProcessed.Checked = m_studentAssignment.Processed

        rtbOverallComments.Text = m_studentAssignment.OverallComments
        rtbImprovementComments.Text = m_studentAssignment.ImprovementComments

        txtNickName.Text = m_student.Nickname
        txtStudentID.Text = m_student.StudentID
        nudPresentationQuality.Text = m_student.PresentationQuality
        nudWritingQuality.Value = m_student.WritingQuality
        txtAssignmentName.Text = m_studentAssignment.BaseAssignment.Name
        nudAltNumber.Text = m_student.AltNumber
        txtSchoolClass.Text = m_student.SchoolClass.Name
        Me.Text &= " - " & m_student.LocalName


        nudFirstTryPoints.Value = m_studentAssignment.FirstTryPoints
        nudSecondTryPoints.Value = m_studentAssignment.SecondTryPoints
        nudThirdTryPoints.Value = m_studentAssignment.ThirdTryPoints


        C1SpellChecker1.MainDictionary.FileName = GetDictionaryFilename()
        C1SpellChecker1.SetActiveSpellChecking(rtbImprovementComments.RichTextBox, True)
        C1SpellChecker1.SetActiveSpellChecking(rtbOverallComments.RichTextBox, True)

        nudPlagiarismSeverity.Value = m_student.PlagiarismSeverity

        '-- Load all the improvement items and include date added/removed for those that apply to this student
        Dim boolItemAdded As Boolean
        For Each item As ImprovementItem In ThisSemester.ImprovementItems
            boolItemAdded = False
            For Each studItem As StudentImprovementItem In m_student.ImprovementItems
                If studItem.BaseImprovementItem Is item Then
                    m_improvementItems.Add(studItem)
                    boolItemAdded = True
                    Exit For
                End If
            Next
            If Not boolItemAdded Then
                Dim studItem As New StudentImprovementItem(m_student)
                studItem.BaseImprovementItem = item
                studItem.DateAdded = DATE_NO_DATE
                studItem.DateRemoved = DATE_NO_DATE
                m_improvementItems.Add(studItem)
            End If
        Next
        olvImprovementItems.SetObjects(m_improvementItems)
        AutoSizeColumns(olvImprovementItems)


        Me.Location = New Point(AppSettings.StudentAssignmentNormalWindowX, AppSettings.StudentAssignmentNormalWindowY)
        Me.Size = New Size(AppSettings.StudentAssignmentNormalWindowWidth, AppSettings.StudentAssignmentNormalWindowHeight)

    End Sub

    Private Sub llblDeleteAssignment_LinkClicked(sender As Object, e As EventArgs) Handles llblDeleteAssignment.LinkClicked
        If MessageBox.Show("Are you sure you want to delete this student's assignment?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            m_student.Assignments.Remove(m_studentAssignment)
            MessageBox.Show("Assignment was removed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        End If
    End Sub

    Private Sub llblToggleTimer_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblToggleTimer.LinkClicked
        m_boolTimerRunning = Not m_boolTimerRunning
        Me.tmrTimer.Enabled = m_boolTimerRunning
        If m_boolTimerRunning Then
            '-- Just switched to running, so need to update the base time
            m_dtTimerStart = Date.Now - m_tsTimer
            llblToggleTimer.Values.Image = My.Resources.Pause_32
        Else
            llblToggleTimer.Values.Image = My.Resources.play_32
        End If
        DrawTimer()
    End Sub

    Private Sub llblResetTimer_LinkClicked(sender As System.Object, e As System.EventArgs) Handles llblResetTimer.LinkClicked
        m_dtTimerStart = Date.Now
        DrawTimer()
    End Sub

    Private Sub tmrTimer_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTimer.Tick
        DrawTimer()
    End Sub
    Private Sub DrawTimer()
        m_tsTimer = Date.Now - m_dtTimerStart
        txtTimer.Text = m_tsTimer.Hours.ToString("00") & ":" & m_tsTimer.Minutes.ToString("00") & ":" & m_tsTimer.Seconds.ToString("00")

        If m_tsTimer.TotalMinutes >= AppSettings.AssignmentMarkingWarning2 Then
            llblWarningNotice.Values.Image = My.Resources.redball_32
        ElseIf m_tsTimer.TotalMinutes >= AppSettings.AssignmentMarkingWarning1 Then
            llblWarningNotice.Values.Image = My.Resources.yellowball_32
        Else
            llblWarningNotice.Values.Image = Nothing
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If SaveChanges() Then
            Close()
        End If

    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        '-- If we created it and canceled then we must remove it
        If m_boolAssignmentCreated Then
            m_student.Assignments.Remove(m_studentAssignment)
        End If

        Close()
    End Sub
    Private Function SaveChanges() As Boolean
        '-- validation checks
        If nudFirstTryPoints.Value > m_studentAssignment.BaseAssignment.MaxPoints OrElse _
            nudSecondTryPoints.Value > m_studentAssignment.BaseAssignment.MaxPoints OrElse _
            nudThirdTryPoints.Value > m_studentAssignment.BaseAssignment.MaxPoints Then
            MessageBox.Show("Points are set above the maximum for this assignment.")
            Return False
        End If
        m_studentAssignment.OverallComments = rtbOverallComments.Text
        m_studentAssignment.ImprovementComments = rtbImprovementComments.Text

        m_student.AltNumber = nudAltNumber.Value

        m_studentAssignment.Processed = chkProcessed.Checked
        m_studentAssignment.FirstTryPoints = nudFirstTryPoints.Value
        m_studentAssignment.SecondTryPoints = nudSecondTryPoints.Value
        m_studentAssignment.ThirdTryPoints = nudThirdTryPoints.Value

        If m_student.PresentationQuality <> nudPresentationQuality.Value Then
            m_student.AddToActivityLog("Changed presentation quality from " & m_student.PresentationQuality.ToString() & " to " & nudPresentationQuality.Value.ToString() & " on " & m_studentAssignment.BaseAssignment.Name)
            m_student.PresentationQuality = nudPresentationQuality.Value
        End If
        If m_student.WritingQuality <> nudWritingQuality.Value Then
            m_student.AddToActivityLog("Changed writing quality from " & m_student.WritingQuality.ToString() & " to " & nudWritingQuality.Value.ToString() & " on " & m_studentAssignment.BaseAssignment.Name)
            m_student.WritingQuality = nudWritingQuality.Value
        End If

        If m_student.PlagiarismSeverity <> nudPlagiarismSeverity.Value Then
            m_student.AddToActivityLog("Changed plagiarism severity from " & m_student.PlagiarismSeverity.ToString() & " to " & nudPlagiarismSeverity.Value.ToString() & " on " & m_studentAssignment.BaseAssignment.Name)
            m_student.PlagiarismSeverity = nudPlagiarismSeverity.Value
        End If

        For Each item As StudentImprovementItem In olvImprovementItems.CheckedObjects
            item.IncludeToday()
        Next

        AddHistory("Finished marking student (" & m_student.ToString() & ") on assignment (" & m_studentAssignment.BaseAssignment.Name & ").")

        Return True
    End Function

    Private Sub AutoGenImprovementComments(includePerformanceLevel As Boolean)
        rtbImprovementComments.AppendText(GetImprovementNotes(includePerformanceLevel))
    End Sub
    Private Sub llblAutoGenImprovements_LinkClicked(sender As Object, e As EventArgs) Handles llblAutoGenImprovements.LinkClicked
        AutoGenImprovementComments(True)
    End Sub
    Private Function GetImprovementNotes(includePerformanceLevel As Boolean) As String
        Try
            Dim strReturn As String = String.Empty
            For Each item As StudentImprovementItem In olvImprovementItems.CheckedObjects
                strReturn &= " " & item.BaseImprovementItem.Description
                If includePerformanceLevel Then
                    strReturn &= " (your performance level: " & item.PerformanceLevel & " out of 5)" & Environment.NewLine
                End If
            Next

            Return strReturn.Trim()
        Catch ex As Exception
            MessageBox.Show("There was an error with the improvement note list: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub llblAddImprovementItem_LinkClicked(sender As Object, e As EventArgs) Handles llblAddImprovementItem.LinkClicked
        AddSelectedImprovementItem()
    End Sub
    Private Sub AddSelectedImprovementItem()
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem Is Nothing Then
            MessageBox.Show("Please select an improvement item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If selItem.DateAdded > DATE_NO_DATE Then
                'MessageBox.Show("This improvement item already exists for this student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- add item to student
                m_student.ImprovementItems.Add(selItem)
                selItem.DateAdded = Date.Now
                selItem.PerformanceLevel = 3 '-- default to 3
                olvImprovementItems.RefreshObject(selItem)
                olvImprovementItems.ModelToItem(selItem).Checked = True
                AutoSizeColumns(olvImprovementItems)
            End If
        End If
    End Sub
    Private Sub llblRemoveImprovementItem_LinkClicked(sender As Object, e As EventArgs) Handles llblRemoveImprovementItem.LinkClicked
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem Is Nothing Then
            MessageBox.Show("Please select an improvement item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If selItem.DateRemoved > DATE_NO_DATE Then
                MessageBox.Show("This improvement item was already removed from this student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- add item to student
                selItem.DateRemoved = Date.Now
                olvImprovementItems.RefreshObject(selItem)
                olvImprovementItems.ModelToItem(selItem).Checked = False
                AutoSizeColumns(olvImprovementItems)
            End If
        End If
    End Sub

    Private Sub llblClearImprovementItem_LinkClicked(sender As Object, e As EventArgs) Handles llblClearImprovementItem.LinkClicked
        Dim selItem As StudentImprovementItem = olvImprovementItems.SelectedObject
        If selItem Is Nothing Then
            MessageBox.Show("Please select an improvement item first.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If selItem.DateAdded = DATE_NO_DATE AndAlso selItem.DateRemoved = DATE_NO_DATE Then
                MessageBox.Show("This improvement item does not exist for this student.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '-- add item to student
                m_student.ImprovementItems.Remove(selItem)
                selItem.DateAdded = DATE_NO_DATE
                selItem.DateRemoved = DATE_NO_DATE
                olvImprovementItems.RefreshObject(selItem)
                olvImprovementItems.ModelToItem(selItem).Checked = False
                AutoSizeColumns(olvImprovementItems)
            End If
        End If
    End Sub

    Private Sub olvImprovementItems_ItemActivate(sender As Object, e As EventArgs) Handles olvImprovementItems.ItemActivate
        AddSelectedImprovementItem()
    End Sub
    Private Sub AutoCalcScore()
        Try
            Dim intPoints As Integer
            Dim intLastSpace As Integer
            For Each strLine As String In rtbOverallComments.Lines
                intLastSpace = strLine.LastIndexOf(" ")
                If intLastSpace >= 0 Then
                    intPoints += ExtractPointsFromLine(strLine.Substring(intLastSpace).Trim())
                End If
            Next

            Select Case m_try
                Case MarkingTry.FirstTry
                    nudFirstTryPoints.Value = intPoints
                Case MarkingTry.SecondTry
                    nudSecondTryPoints.Value = intPoints
                Case MarkingTry.ThirdTry
                    nudThirdTryPoints.Value = intPoints
            End Select
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error calculating the score: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub llblAutoCalcScore_LinkClicked(sender As Object, e As EventArgs) Handles llblAutoCalcScore.LinkClicked
        AutoCalcScore()
    End Sub
    Private Function ExtractPointsFromLine(line As String) As Integer
        Try
            Dim strWorking As String = line.Trim().Replace(" ", String.Empty) '-- change " 30 / 45" to "30/45"

            If strWorking.Contains("/") Then
                '-- remove everything to the right of the /
                strWorking = strWorking.Substring(0, strWorking.IndexOf("/"))
            End If

            If IsNumeric(strWorking) Then
                Return ConvertToInt32(strWorking, 0)
            Else
                '-- problem, return 0
                Return 0
            End If
        Catch ex As Exception
            Log(ex)
            Throw ex
        End Try
    End Function

    Private Sub nudFirstTryPoints_ValueChanged(sender As Object, e As EventArgs) Handles nudFirstTryPoints.ValueChanged
        If m_studentAssignment IsNot Nothing Then
            Dim dbl As Double = nudFirstTryPoints.Value / m_studentAssignment.BaseAssignment.MaxPoints
            lblFirstTryPercent.Text = dbl.ToString("##0%")
        End If
    End Sub

    Private Sub ReduceSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReduceSizeToolStripMenuItem.Click
        Try
            KryptonSplitContainer1.Panel2Collapsed = Not KryptonSplitContainer1.Panel2Collapsed
            llblAddImprovementItem.Visible = Not KryptonSplitContainer1.Panel2Collapsed
            llblRemoveImprovementItem.Visible = Not KryptonSplitContainer1.Panel2Collapsed
            llblClearImprovementItem.Visible = Not KryptonSplitContainer1.Panel2Collapsed
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error reducing the form size: " & ex.Message)
        End Try
    End Sub

    Private Sub AutocalcScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutocalcScoreToolStripMenuItem.Click
        AutoCalcScore()
    End Sub

    Private Sub AutogenImprovementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutogenImprovementsToolStripMenuItem.Click
        AutoGenImprovementComments(True)
    End Sub

    Private Sub llblEditStudent_LinkClicked(sender As Object, e As EventArgs) Handles llblEditStudent.LinkClicked
        Using frm As New StudentDetail(m_student)
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub llblAutoGenImprovementsWithoutPerformanceLevel_LinkClicked(sender As Object, e As EventArgs) Handles llblAutoGenImprovementsWithoutPerformanceLevel.LinkClicked
        AutoGenImprovementComments(False)
    End Sub

End Class