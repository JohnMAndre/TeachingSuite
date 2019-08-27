Public Class SemesterCache

    Private Const FILENAME As String = "SemesterDataCache.bin"
    Private Shared m_cache As SemesterCache
    Private m_semesters As List(Of CachedSemester)
    Private m_boolDirty As Boolean '-- True if cache needs to be re-persisted

    Private Sub New()
        'Throw New Exception("This class should not be instanciated. Please call GetCache() to get a new instance.")
    End Sub
    Public Shared Function GetCache() As SemesterCache
        '-- Singleton pattern
        If m_cache Is Nothing Then
            m_cache = New SemesterCache
            m_cache.LoadData()
        End If
        Return m_cache
    End Function

    Public ReadOnly Property Semesters As List(Of CachedSemester)
        Get
            Return m_semesters
        End Get
    End Property
    Public Sub SaveCache()
        '-- Save master cache back to FILENAME
        '   but only if the cache is dirty (flagged no load)
        If m_boolDirty Then
            Dim xMasterDoc As New Xml.XmlDocument()
            xMasterDoc.AppendChild(xMasterDoc.CreateElement("SemesterCache"))

            Dim xDoc As Xml.XmlDocument
            For Each sem As CachedSemester In m_semesters
                xDoc = sem.GetXMLDocumentToPersist()

                '-- record the last cache date
                xDoc.DocumentElement.SetAttribute("LastCached", sem.LastCached.ToString(DATE_TIME_DETAILED_FORMAT_XML))

                '-- Import into master file XmlDoc
                Dim xElement As Xml.XmlElement = xMasterDoc.ImportNode(xDoc.DocumentElement, True)
                xMasterDoc.DocumentElement.AppendChild(xElement)
            Next

#If SUPPORT_ZIP Then
            SaveXMLData(xMasterDoc, GetCacheFilename(), True)
            m_boolDirty = False
#Else
            SaveXMLData(xMasterDoc, GetCacheFilename(), False)
#End If
        End If
    End Sub


#Region " Private routines "
    Private Sub LoadData()
        m_semesters = New List(Of CachedSemester)

        Dim lstSemesters As List(Of String) = Semester.ListExistingSemesters()
        Dim semCurrent As CachedSemester
        Dim fi As System.IO.FileInfo
        Dim dtLastCached As Date

        '-- Load existing from cache file
        If System.IO.File.Exists(GetCacheFilename()) Then
            Dim xDoc As Xml.XmlDocument = LoadXMLDataFromFile(GetCacheFilename())
            Dim sem As CachedSemester
            Dim xList As Xml.XmlNodeList = xDoc.SelectNodes("//Semester")
            For Each xSemester As Xml.XmlElement In xList
                sem = New CachedSemester(xSemester)
                m_semesters.Add(sem)
            Next
            xDoc = Nothing '-- free memory
        End If

        '-- Now walk through all the semester files
        '   if any have been saved since last cache date
        '   then recache them
        Dim semToRemove As CachedSemester
        For intCounter As Integer = 0 To lstSemesters.Count - 1
            fi = New IO.FileInfo(System.IO.Path.Combine(GetDataFolder(), lstSemesters(intCounter)) & DATA_FILE_EXTENSION)
            For Each sem In m_semesters
                dtLastCached = DATE_NO_DATE
                If sem.Name = System.IO.Path.GetFileNameWithoutExtension(fi.Name) Then
                    dtLastCached = sem.LastCached
                    semToRemove = sem
                    Exit For '-- first match is ok. We assume there is one file per semester (no copies floating around)
                End If
            Next
            If fi.LastWriteTimeUtc > dtLastCached Then
                '-- remove existing
                m_semesters.Remove(semToRemove)

                '-- recache
                semCurrent = New CachedSemester(fi.FullName) '-- load
                semCurrent.LastCached = Date.UtcNow
                m_semesters.Insert(0, semCurrent) '-- Most recently changed semester file will be at the top of the list

                m_boolDirty = True
            Else
                '-- use existing
                '   do nothing
            End If
        Next


        ' This next logic does not work
        '   because copy-and-pasting sem.datx will result in sem (copy).datx but the name of the semester will still be "sem"
        '   and the other logic in the app does not account for this, assuming that the filename is always the name of the semeter
        '   So, to clean things up, just manually delete the cache file periodically
        'For intCounter As Integer = 0 To m_semesters.Count - 1
        '    semCurrent = m_semesters(intCounter)
        '    If (semCurrent.DataFilename Is Nothing) OrElse (Not System.IO.File.Exists(semCurrent.DataFilename)) Then
        '        '-- file was removed, so remove from list of semesters
        '        m_semesters.Remove(semCurrent)
        '        intCounter -= 1
        '        If intCounter = m_semesters.Count - 1 Then
        '            Exit For
        '        End If
        '    End If
        'Next


    End Sub

    Private Function GetCacheFilename() As String
        Return System.IO.Path.Combine(GetDataFolder(), FILENAME)
    End Function

#End Region

End Class
Public Class CachedSemester
    '== Here we want an exact copy of semester but also to add an attribute
    '   to reflect the date it was last cached
    Inherits Semester

    Public Sub New(name As String)
        MyBase.New(name)
    End Sub
    Public Sub New(xmlElement As Xml.XmlElement)
        MyBase.New(xmlElement)
        Me.LastCached = xmlElement.GetAttribute("LastCached")
    End Sub
    Public Property LastCached As Date

End Class