'Copyright 2011-2020 John M Andre (John At JohnMAndre dot COM)

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

Public Class HistoricalStudentData

    Private Class HistoricalDataItem
        Public Property StudentID As String
        Public Property FieldID As String
        Public Property FieldName As String
        Public Property OldValue As String
        Public Property EndDate As Date
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

            Dim objItem As New HistoricalDataItem()
            objItem.StudentID = studID.Trim()
            objItem.FieldID = fieldID
            objItem.FieldName = fieldName
            objItem.OldValue = oldValue
            objItem.EndDate = Date.Now

            m_qHistoricalItems.Enqueue(objItem)

            If Not m_boolBusyWriting Then
                '-- start thread to drain the queue, since one is not currently running
                m_boolBusyWriting = True

                Dim thread As New Threading.Thread(AddressOf WriteHistory)
                thread.Start()
            End If
        End If
    End Sub
    Private Shared Function GetStudentFilename(studentID As String) As String
        If m_strStudentDataHistoryFolder Is Nothing Then
            m_strStudentDataHistoryFolder = System.IO.Path.Combine(GetDataFolder(), "StudentHistory\")
            If Not System.IO.Directory.Exists(m_strStudentDataHistoryFolder) Then
                System.IO.Directory.CreateDirectory(m_strStudentDataHistoryFolder)
            End If
        End If

        Return m_strStudentDataHistoryFolder & MakeFilenameLegal(studentID) & ".xml"
    End Function
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
                AddApplicationHistory("Starting to write historical data (queue depth: " & m_qHistoricalItems.Count.ToString("#,##0") & ") with Transaction ID: " & m_strTransactionID)
            End If

            'If m_strStudentDataHistoryFolder Is Nothing Then
            '    m_strStudentDataHistoryFolder = System.IO.Path.Combine(GetDataFolder(), "StudentHistory\")
            '    If Not System.IO.Directory.Exists(m_strStudentDataHistoryFolder) Then
            '        System.IO.Directory.CreateDirectory(m_strStudentDataHistoryFolder)
            '    End If
            'End If

            Do While m_qHistoricalItems.Count > 0

                Dim objItem As HistoricalDataItem = m_qHistoricalItems.Dequeue()

                Dim strStudentFilename As String '-- filename to save to
                strStudentFilename = GetStudentFilename(objItem.StudentID) 'm_strStudentDataHistoryFolder & MakeFilenameLegal(objItem.StudentID) & ".xml"

                Dim xDoc As New Xml.XmlDocument()
                Dim xRoot As Xml.XmlElement

                If System.IO.File.Exists(strStudentFilename) Then
                    xDoc.Load(strStudentFilename)
                    xRoot = xDoc.DocumentElement
                Else
                    '-- Check if student ID (filename key) has changed (but don't worry for new students
                    If objItem.FieldName = "StudentID" AndAlso (objItem.OldValue IsNot Nothing AndAlso objItem.OldValue.Length > 0) Then
                        '-- In this (rare) case, we must change the filename to reflect the new student ID
                        Dim strOldStudentFilename As String
                        strOldStudentFilename = GetStudentFilename(objItem.OldValue) 'm_strStudentDataHistoryFolder & MakeFilenameLegal(objItem.OldValue) & ".xml"

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
                xNewData.SetAttribute("EndDate", objItem.EndDate.ToString(DATE_TIME_DETAILED_FORMAT_XML))
                xRoot.AppendChild(xNewData)

                xDoc.Save(strStudentFilename)
            Loop

            m_boolBusyWriting = False '-- Writing is complete, until something else gets queued up

        Catch ex As Exception
            Log(ex)
        End Try

    End Sub

    Public Sub New(studentID As String)

        HistoricalData = New List(Of HistoricalStudentDataItem)

        Dim strStudentFilename As String = GetStudentFilename(studentID)

        If System.IO.File.Exists(strStudentFilename) Then
            Dim xDoc As New Xml.XmlDocument()
            Dim xRoot As Xml.XmlElement
            xDoc.Load(strStudentFilename)
            xRoot = xDoc.DocumentElement

            Dim xElement As Xml.XmlElement
            Dim objThisItem As HistoricalStudentDataItem
            'Dim objPreviousItem As HistoricalStudentDataItem

            For Each xElement In xRoot.ChildNodes
                objThisItem = New HistoricalStudentDataItem()
                objThisItem.FieldID = xElement.GetAttribute("FieldID")
                objThisItem.FieldName = xElement.GetAttribute("FieldName")
                objThisItem.FromOldValue = xElement.GetAttribute("OldValue")
                objThisItem.ChangeDate = ConvertToDateFromXML(xElement.GetAttribute("EndDate"), Date.Now)

                HistoricalData.Add(objThisItem)
                '-- The rest need to handle in post-processing (after all items are loaded, walk the list and post-process)
                'item.ToNewValue = xElement.GetAttribute("FieldName")
                'item.TimeInForce = xElement.GetAttribute("FieldName")
            Next

            Dim strCompareBase As String
            Dim intOuterCounter, intInnerCounter, intMaxListIndex As Integer
            Dim objOuterItem, objInnerItem As HistoricalStudentDataItem
            objInnerItem = Nothing
            Dim boolMatchFound As Boolean
            Dim objStudent As Student = Student.GetByStudentID(studentID)

            intMaxListIndex = HistoricalData.Count - 1
            '-- Now do the post processing to fill in the extra data
            For intOuterCounter = 0 To intMaxListIndex
                objOuterItem = HistoricalData(intOuterCounter)

                '-- walk the list in a double loop
                If objOuterItem.FieldID.Length = 0 Then
                    strCompareBase = objOuterItem.FieldName
                Else
                    strCompareBase = objOuterItem.FieldID
                End If

                '-- Now, the second loop
                boolMatchFound = False '-- reset
                If (intOuterCounter + 1) <= intMaxListIndex Then
                    For intInnerCounter = intOuterCounter + 1 To intMaxListIndex
                        objInnerItem = HistoricalData(intInnerCounter)

                        If objInnerItem.FieldID.Length = 0 Then
                            If strCompareBase = objInnerItem.FieldName Then
                                '-- match
                                boolMatchFound = True
                                Exit For
                            End If
                        Else
                            If strCompareBase = objInnerItem.FieldID Then
                                '-- match
                                boolMatchFound = True
                                Exit For
                            End If
                        End If
                    Next
                End If

                If boolMatchFound Then
                    '-- fill OuterItem from InnerItem
                    objOuterItem.ToNewValue = objInnerItem.FromOldValue
                    objOuterItem.TimeInForce = objInnerItem.ChangeDate - objOuterItem.ChangeDate '-- how long was the ToNewValue the current value
                Else
                    '-- no match found, compare to current values
                    objOuterItem.ToNewValue = objStudent.GetCurrentValue(strCompareBase)
                    objOuterItem.TimeInForce = Date.Now - objOuterItem.ChangeDate '-- how long was the ToNewValue the current value
                End If
            Next

        Else
            '-- do nothing
            Application.DoEvents() '-- for breakpoint only
        End If
    End Sub

    Public Property HistoricalData As List(Of HistoricalStudentDataItem)

    Public Class HistoricalStudentDataItem
        'Public Property TransactionID As String
        Public Property FieldID As String
        Public Property FieldName As String
        Public Property FromOldValue As String '-- This is the old value for the record
        Public Property ToNewValue As String '-- This is either the current value or the old value from the next newer record
        Public Property ChangeDate As Date '-- The date the change happend
        Public Property TimeInForce As TimeSpan '-- The time FromOldValue was the current value. So:  this.ChangeDate - oneOlder.EndDate
    End Class


End Class
