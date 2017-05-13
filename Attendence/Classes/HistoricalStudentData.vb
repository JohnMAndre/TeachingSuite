Public Class HistoricalStudentData

    Private Class HistoricalDataItem
        Public Property StudentID As String
        Public Property FieldID As String
        Public Property FieldName As String
        Public Property OldValue As String
        Public Property EndDate As String
    End Class

    Private Shared m_qHistoricalItems As New Queue(Of HistoricalDataItem)
    Private Shared m_boolBusyWriting As Boolean
    Private Shared m_strTransactionID As String '-- will be the same for all historical records created during one app session
    Private Shared m_strStudentDataHistoryFolder As String '-- same for all writes during one app session
    ''' <summary>
    ''' Adds record of student data changing
    ''' </summary>
    ''' <param name="studID"></param>
    ''' <param name="fieldID">ID of the field (e.g., improvement item)</param>
    ''' <param name="fieldName">Name of the field (e.g., PresentationQuality)</param>
    ''' <param name="oldValue">The value before the current change</param>
    ''' <remarks></remarks>
    Public Shared Sub AddHistoricalData(studID As String, fieldID As String, fieldName As String, oldValue As String)
        '-- All we do here is enqueue the item, keep it responsive
        If AppSettings.EnableStudentDataHistory AndAlso studID IsNot Nothing Then

            Dim strEndDate As String = Date.Now.ToString(DATE_TIME_FORMAT_XML)

            Dim objItem As New HistoricalDataItem()
            objItem.StudentID = studID.Trim()
            objItem.FieldID = fieldID
            objItem.FieldName = fieldName
            objItem.OldValue = oldValue
            objItem.EndDate = strEndDate

            m_qHistoricalItems.Enqueue(objItem)

            If Not m_boolBusyWriting Then
                '-- start thread to drain the queue, since one is not currently running
                m_boolBusyWriting = True

                Dim thread As New Threading.Thread(AddressOf WriteHistory)
                thread.Start()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Drains the history queue
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared Sub WriteHistory()
        '-- We will append data in an individual historical data file for each student ID (student ID is file name)
        Try

            '-- This needs to happen on another thread or during idle time to maintain app performance
            If m_strTransactionID Is Nothing Then
                m_strTransactionID = Guid.NewGuid.ToString()
                AddApplicationHistory("Starting to write historical data with Transaction ID: " & m_strTransactionID)
            End If

            If m_strStudentDataHistoryFolder Is Nothing Then
                m_strStudentDataHistoryFolder = System.IO.Path.Combine(GetDataFolder(), "StudentHistory\")
                If Not System.IO.Directory.Exists(m_strStudentDataHistoryFolder) Then
                    System.IO.Directory.CreateDirectory(m_strStudentDataHistoryFolder)
                End If
            End If

            Do While m_qHistoricalItems.Count > 0

                Dim objItem As HistoricalDataItem = m_qHistoricalItems.Dequeue()

                Dim strStudentFilename As String '-- filename to save to
                strStudentFilename = m_strStudentDataHistoryFolder & MakeFilenameLegal(objItem.StudentID) & ".xml"

                Dim xDoc As New Xml.XmlDocument()
                Dim xRoot As Xml.XmlElement

                If System.IO.File.Exists(strStudentFilename) Then
                    xDoc.Load(strStudentFilename)
                    xRoot = xDoc.DocumentElement
                Else
                    '-- Check if student ID (filename key) has changed
                    If objItem.FieldName = "StudentID" Then
                        '-- In this (rare) case, we must change the filename to reflect the new student ID
                        Dim strOldStudentFilename As String
                        strOldStudentFilename = m_strStudentDataHistoryFolder & MakeFilenameLegal(objItem.OldValue) & ".xml"

                        System.IO.File.Move(strOldStudentFilename, strStudentFilename)

                        xDoc.Load(strStudentFilename)
                        xRoot = xDoc.DocumentElement
                    Else
                        xRoot = xDoc.AppendChild(xDoc.CreateElement("Histories"))
                    End If

                End If

                Dim xNewData As Xml.XmlElement = xDoc.CreateElement("History")
                xNewData.SetAttribute("TransactionID", m_strTransactionID)
                xNewData.SetAttribute("FieldID", objItem.FieldID)
                xNewData.SetAttribute("FieldName", objItem.FieldName)
                xNewData.SetAttribute("OldValue", objItem.OldValue)
                xNewData.SetAttribute("EndDate", objItem.EndDate)
                xRoot.AppendChild(xNewData)

                xDoc.Save(strStudentFilename)
            Loop

            m_boolBusyWriting = False '-- Writing is complete, until something else gets queued up

        Catch ex As Exception
            Log(ex)
        End Try

    End Sub

End Class
