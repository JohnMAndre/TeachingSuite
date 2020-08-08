'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of Teaching Suite.

'Teaching Suite Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Foobar Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Foobar.  If Not, see < https: //www.gnu.org/licenses/>.
Public Class AssignmentProcessingReport

    Private Class AssignmentProcessingReportItem
        Public ModuleName As String
        Public FirstMarkings As Integer
        Public SecondMarkings As Integer
        Public ThirdMarkings As Integer
        Public ReadOnly Property TotalMarkings As Integer
            Get
                Return FirstMarkings + SecondMarkings + ThirdMarkings
            End Get
        End Property
        Public ReadOnly Property ReworkMarkings As Integer
            Get
                Return SecondMarkings + ThirdMarkings
            End Get
        End Property
    End Class

    Private m_lstReport As New List(Of AssignmentProcessingReportItem)

    Private Sub LoadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        LoadData()
    End Sub
    Private Sub LoadData()
        Try


            m_lstReport.Clear()
            Dim item As AssignmentProcessingReportItem
            Dim intFirst, intSecond, intThird As Integer
            Dim boolFirstProcessed, boolSecondProcessed, boolThirdProcessed As Boolean
            Dim boolAtLeastOneSecond, boolAtLeastOneThird As Boolean

            For Each modu As ClassGroup In ThisSemester.ClassGroups
                item = New AssignmentProcessingReportItem()
                item.ModuleName = modu.Name
                m_lstReport.Add(item)

                For Each clas As SchoolClass In modu.Classes
                    For Each stud As Student In clas.Students
                        For Each asmt As StudentAssignmentBTEC In stud.AssignmentsBTEC
                            If asmt.Processed Then '-- if not processed then we didn't really mark the assignment
                                boolFirstProcessed = True
                                boolSecondProcessed = True
                                boolThirdProcessed = True
                                boolAtLeastOneSecond = False
                                boolAtLeastOneThird = False

                                For Each oc As OutcomeResult In asmt.Outcomes
                                    If oc.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                                        '-- did not process first
                                        boolFirstProcessed = False
                                    End If
                                    If oc.SecondTryStatus = OutcomeResultStatusEnum.Unknown Then
                                        If oc.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                                            '-- did not process second
                                            boolSecondProcessed = False
                                        End If
                                    Else
                                        '-- we processed at least one outcome on second marking
                                        boolAtLeastOneSecond = True
                                    End If
                                    If oc.ThirdTryStatus = OutcomeResultStatusEnum.Unknown Then
                                        If (oc.SecondTryStatus <> OutcomeResultStatusEnum.Achieved) AndAlso (oc.FirstTryStatus <> OutcomeResultStatusEnum.Achieved) Then
                                            '-- did not process third
                                            boolThirdProcessed = False
                                        End If
                                    Else
                                        '-- we processed at least one outcome on third marking
                                        boolAtLeastOneThird = True
                                    End If
                                Next

                                '-- Now we can see if this asmt counts as being marked
                                If boolFirstProcessed Then
                                    item.FirstMarkings += 1
                                End If
                                If boolSecondProcessed AndAlso boolAtLeastOneSecond Then
                                    item.SecondMarkings += 1
                                End If
                                If boolThirdProcessed AndAlso boolAtLeastOneThird Then
                                    item.ThirdMarkings += 1
                                End If
                            End If
                        Next
                    Next
                Next
            Next

            '-- create totals
            For Each item In m_lstReport
                intFirst += item.FirstMarkings
                intSecond += item.SecondMarkings
                intThird += item.ThirdMarkings
            Next

            lblTotalFirst.Text = intFirst.ToString("#,##0")
            lblTotalSecond.Text = intSecond.ToString("#,##0")
            lblTotalThird.Text = intThird.ToString("#,##0")
            Dim intSum As Integer
            intSum = intSecond + intThird
            lblTotalReworkMarked.Text = intSum.ToString("#,##0")

            intSum += intFirst
            lblTotalMarked.Text = intSum.ToString("#,##0")

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
