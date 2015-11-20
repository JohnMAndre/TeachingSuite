Public Class StudentQualityReport

    Private Class StudentQualityReportItem
        Public ModuleName As String
        Public SchoolClass As String
        Public TotalStudents As Integer
        Public CountedPresentation As Integer
        Public CountedWriting As Integer
        Public AveragePresentation As Double
        Public AverageWriting As Double
    End Class

    Private m_lstReport As New List(Of StudentQualityReportItem)

    Private Sub LoadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            m_lstReport.Clear()
            Dim item As StudentQualityReportItem
            Dim intTotalWriting, intTotalPresentation As Integer
            Dim intSemesterTotalWriting, intSemesterTotalPresentation As Integer
            Dim intSemesterCountWriting, intSemesterCountPresentation As Integer

            For Each modu As ClassGroup In ThisSemester.ClassGroups
                For Each clas As SchoolClass In modu.Classes
                    item = New StudentQualityReportItem()
                    item.ModuleName = modu.Name
                    item.SchoolClass = clas.Name
                    item.TotalStudents = clas.Students.Count
                    m_lstReport.Add(item)

                    intTotalWriting = 0
                    intTotalPresentation = 0

                    For Each stud As Student In clas.Students
                        If stud.WritingQuality > 0 Then
                            intTotalWriting += stud.WritingQuality
                            item.CountedWriting += 1
                        End If

                        If stud.PresentationQuality > 0 Then
                            intTotalPresentation += stud.PresentationQuality
                            item.CountedPresentation += 1
                        End If
                    Next

                    intSemesterCountWriting += item.CountedWriting
                    intSemesterCountPresentation += item.CountedPresentation
                    intSemesterTotalWriting += intTotalWriting
                    intSemesterTotalPresentation += intTotalPresentation

                    If item.CountedPresentation = 0 Then
                        item.AveragePresentation = 0
                    Else
                        item.AveragePresentation = intTotalPresentation / item.CountedPresentation
                    End If

                    If item.AverageWriting = 0 Then
                        item.AverageWriting = intTotalWriting / item.CountedWriting
                    Else
                        item.AverageWriting = intTotalWriting / item.CountedWriting
                    End If

                Next
            Next

            lblTotalPresentation.Text = intSemesterCountPresentation.ToString("#,##0")
            lblTotalWriting.Text = intSemesterCountWriting.ToString("#,##0")
            Dim dbl As Double
            dbl = intSemesterTotalPresentation / intSemesterCountPresentation
            lblAveragePresentation.Text = dbl.ToString("#0.0")
            dbl = intSemesterTotalWriting / intSemesterCountWriting
            lblAverageWriting.Text = dbl.ToString("#0.0")

            olvReport.SetObjects(m_lstReport)
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the report data: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AssignmentProcessingReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class
