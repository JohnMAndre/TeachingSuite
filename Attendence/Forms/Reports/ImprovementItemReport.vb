Public Class ImprovementItemReport

    Public Class ImprovementData
        Public Property ID As String
        Public Property Name As String
        Public Students As Integer
        Public TotalQualityLevel As Integer
        Public AverageQualityLevel As Double
    End Class
    Private m_class As SchoolClass
    Private m_lst As List(Of ImprovementData)

    Public Sub New(schoolClass As SchoolClass)

        ' This call is required by the designer.
        InitializeComponent()

        m_class = schoolClass
    End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            m_lst = New List(Of ImprovementData)

            Dim objFoundItem As ImprovementData

            For Each stud As Student In m_class.Students
                For Each objItem As StudentImprovementItem In stud.ImprovementItems
                    If objItem.PerformanceLevel > 0 AndAlso objItem.PerformanceLevel < 5 Then
                        '-- see if it exists for this student already
                        objFoundItem = m_lst.Find(Function(value As ImprovementData) value.ID = objItem.BaseImprovementItem.ID)
                        If objFoundItem Is Nothing Then
                            '-- need to add
                            objFoundItem = New ImprovementData()
                            objFoundItem.ID = objItem.BaseImprovementItem.ID
                            objFoundItem.Name = objItem.BaseImprovementItem.Name
                            objFoundItem.Students = 1
                            objFoundItem.TotalQualityLevel = objItem.PerformanceLevel
                            m_lst.Add(objFoundItem)
                        Else
                            '--increment
                            objFoundItem.Students += 1
                            objFoundItem.TotalQualityLevel += objItem.PerformanceLevel
                        End If
                    End If
                Next
            Next

            '-- Calculate averages
            For Each objItem As ImprovementData In m_lst
                objItem.AverageQualityLevel = ConvertToDouble(objItem.TotalQualityLevel, 1) / objItem.Students
            Next
            olvReport.SetObjects(m_lst)
        Catch ex As Exception
            Log(ex)
        End Try

    End Sub
End Class