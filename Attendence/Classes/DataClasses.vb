
Public Class Semester
    Private m_strFilename As String

    Public Property Name As String
    Public Property StartDateOverall As Date
    Public Property EndDateOverall As Date
    Public Property StartDateCurrent As Date
    Public Property EndDateCurrent As Date
    'Public Property Closed As Boolean
    Public Property ClassGroups As New List(Of ClassGroup)
    Public Property ImprovementItems As New List(Of ImprovementItem)
    Public Property LastSaveDate As Date
    Public Property LastAutoSaveDate As Date
    Public Property Notes As String
    Public ReadOnly Property DataFilename As String
        Get
            Return m_strFilename
        End Get
    End Property


    Public Event LastSaveChanged(lastSaveDate As Date, lastAutoSaveDate As Date)


    Public Shared Function ListExistingSemesters() As List(Of String)
        Dim files() As String

        files = System.IO.Directory.GetFiles(GetDataFolder(), "*" & DATA_FILE_EXTENSION)
        Array.Sort(files) '-- oldest file first

        Dim lstReturn As New List(Of String)
        For Each strFilename As String In files
            lstReturn.Add(System.IO.Path.GetFileNameWithoutExtension(strFilename))
        Next

        Return lstReturn
    End Function
    ''' <summary>
    ''' Returns FileInfo of the autosave file, or nothing if file does not exist
    ''' </summary>
    ''' <param name="name">Name of semester file</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAutoSaveFileInfo(name As String) As System.IO.FileInfo
        Dim strAutoSaveFilename As String = GetAutoSaveFilename(name)

        If System.IO.File.Exists(strAutoSaveFilename) Then
            Dim fi As New System.IO.FileInfo(strAutoSaveFilename)
            Return fi
        Else
            Return Nothing
        End If

    End Function
    Public Shared Function GetMainDataFileInfo(name As String) As System.IO.FileInfo
        Dim strFilename As String = GetMainDataFilename(name)

        If System.IO.File.Exists(strFilename) Then
            Dim fi As New System.IO.FileInfo(strFilename)
            Return fi
        Else
            Return Nothing
        End If

    End Function
    Public Shared Function GetMainDataFilename(name As String) As String
        Dim strFilename As String

        If name.Contains(System.IO.Path.DirectorySeparatorChar) Then
            strFilename = name
        Else
            strFilename = System.IO.Path.Combine(GetDataFolder(), name & DATA_FILE_EXTENSION)
        End If

        Return strFilename
    End Function
    Public Shared Function GetAutoSaveFilename(name As String) As String
        Dim strAutoSaveFilename As String
        Dim strFilename As String

        If name.Contains(System.IO.Path.DirectorySeparatorChar) Then
            strFilename = name
        Else
            strFilename = System.IO.Path.Combine(GetDataFolder(), name & DATA_FILE_EXTENSION)
        End If

        strAutoSaveFilename = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(strFilename), System.IO.Path.GetFileNameWithoutExtension(strFilename) & DATA_FILE_AUTOSAVE_EXTENSION)
        Return strAutoSaveFilename
    End Function

    ''' <summary>
    ''' Deletes the AutoSave file for the semester name passed in
    ''' </summary>
    ''' <param name="name"></param>
    ''' <remarks></remarks>
    Public Shared Sub DiscardAutoSaveFile(name As String)
        Dim strAutoSaveFilename As String = GetAutoSaveFilename(name)
        System.IO.File.Delete(strAutoSaveFilename)
    End Sub
    Public Shared Sub UseAutoSaveFile(name As String)
        '-- move regular file to 'replaced' file
        '   and move auto save file to regular file
        Dim strAutoSaveFilename As String = GetAutoSaveFilename(name)
        Dim strFilename As String = GetMainDataFilename(name)

        Dim strReplacedFilename As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(strFilename), System.IO.Path.GetFileNameWithoutExtension(strFilename) & DATA_FILE_REPLACED_EXTENSION)
        If System.IO.File.Exists(strReplacedFilename) Then
            Try
                System.IO.File.Delete(strReplacedFilename)
            Catch ex As Exception
                Log(ex)
                '-- cannot delete, so change filename
                strReplacedFilename &= "." & Date.Now.ToString("yyyyMMddHHmmss")
            End Try
        End If
        System.IO.File.Move(strFilename, strReplacedFilename)
        System.IO.File.Move(strAutoSaveFilename, strFilename)
    End Sub
    Public Sub New(name As String)
        Try
            '-- Load from data file
            Dim strAutoSaveFilename As String

            m_strFilename = GetMainDataFilename(name)
            strAutoSaveFilename = GetAutoSaveFilename(name)

            Dim xDoc As New Xml.XmlDocument

            If System.IO.File.Exists(m_strFilename) Then
#If SUPPORT_ZIP Then
                Dim strContents As String
                Using zip As New Ionic.Zip.ZipFile(m_strFilename)
                    Using ms As New System.IO.MemoryStream()
                        zip.Entries(0).Extract(ms)
                        ms.Position = 0
                        Using sr As New System.IO.StreamReader(ms, System.Text.Encoding.Unicode)
                            strContents = sr.ReadToEnd
                            sr.Close()
                        End Using
                        ms.Close()
                    End Using
                End Using
                xDoc.LoadXml(strContents)
#Else
            xDoc.Load(m_strFilename)
#End If
                'xDoc.Load(m_strFilename)
                Me.Name = xDoc.DocumentElement.GetAttribute("Name")
                StartDateOverall = Xml.XmlConvert.ToDateTime(xDoc.DocumentElement.GetAttribute("StartDate"), Xml.XmlDateTimeSerializationMode.Unspecified)
                EndDateOverall = Xml.XmlConvert.ToDateTime(xDoc.DocumentElement.GetAttribute("EndDate"), Xml.XmlDateTimeSerializationMode.Unspecified)
                'Closed = ConvertToBool(xDoc.DocumentElement.GetAttribute("Closed"), False)
                Try
                    StartDateCurrent = Xml.XmlConvert.ToDateTime(xDoc.DocumentElement.GetAttribute("StartDateCurrent"), Xml.XmlDateTimeSerializationMode.Unspecified)
                    EndDateCurrent = Xml.XmlConvert.ToDateTime(xDoc.DocumentElement.GetAttribute("EndDateCurrent"), Xml.XmlDateTimeSerializationMode.Unspecified)
                Catch ex As Exception
                    Application.DoEvents() '-- ignore
                End Try

                Me.Notes = xDoc.DocumentElement.GetAttribute("Notes")

                '-- ImprovementItems must come before students
                Dim xImprovements As Xml.XmlNodeList = xDoc.SelectNodes("//ImprovementItem")
                For Each xItem As Xml.XmlElement In xImprovements
                    Dim objItem As New ImprovementItem()
                    objItem.ID = xItem.GetAttribute("ID")
                    objItem.Name = xItem.GetAttribute("Name")
                    objItem.Description = xItem.GetAttribute("Description")
                    Me.ImprovementItems.Add(objItem)
                Next


                Dim xClassGroupList As Xml.XmlNodeList = xDoc.SelectNodes("/Semester/ClassGroup")
                For Each xClassGroupNode As Xml.XmlElement In xClassGroupList
                    Dim objClassGroup As New ClassGroup(xClassGroupNode, Me)
                    ClassGroups.Add(objClassGroup)
                Next

            Else
                '-- create a new semester file
                Me.Name = name
                StartDateOverall = Date.Today
                EndDateOverall = Date.Today.AddMonths(4)
                StartDateCurrent = Date.Today
                EndDateCurrent = Date.Today.AddMonths(4)
                Save()
            End If

            LastSaveDate = Date.Now
            LastAutoSaveDate = Date.Now
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error loading the semester: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''' <summary>
    ''' Saves the semester data file
    ''' </summary>
    ''' <param name="filename">Name of autosave file. Pass as nothing for normal save</param>
    ''' <param name="forceXMLOnly">True to save in raw XML, False to save as compressed (zip)</param>
    ''' <remarks></remarks>
    Public Sub Save(Optional filename As String = Nothing, Optional forceXMLOnly As Boolean = False)
        Try
            '-- save back to data file
            Dim xDoc As New Xml.XmlDocument()
            xDoc.AppendChild(xDoc.CreateElement("Semester"))
            xDoc.DocumentElement.SetAttribute("Name", Me.Name)
            xDoc.DocumentElement.SetAttribute("StartDate", Me.StartDateOverall.ToString(DATE_FORMAT_XML))
            xDoc.DocumentElement.SetAttribute("EndDate", Me.EndDateOverall.ToString(DATE_FORMAT_XML))
            xDoc.DocumentElement.SetAttribute("StartDateCurrent", Me.StartDateCurrent.ToString(DATE_FORMAT_XML))
            xDoc.DocumentElement.SetAttribute("EndDateCurrent", Me.EndDateCurrent.ToString(DATE_FORMAT_XML))
            xDoc.DocumentElement.SetAttribute("Notes", Me.Notes)

            '-- append ClassGroups
            For Each objClassGroup As ClassGroup In Me.ClassGroups
                xDoc.DocumentElement.AppendChild(objClassGroup.GetXMLElementToPersist(xDoc))
            Next

            '-- append improvement items
            Dim xParent As Xml.XmlElement = xDoc.CreateElement("ImprovementItems")
            Dim xItem As Xml.XmlElement
            For Each item As ImprovementItem In Me.ImprovementItems
                xItem = xDoc.CreateElement("ImprovementItem")
                xItem.SetAttribute("ID", item.ID)
                xItem.SetAttribute("Name", item.Name)
                xItem.SetAttribute("Description", item.Description)
                xParent.AppendChild(xItem)
            Next
            xDoc.DocumentElement.AppendChild(xParent)


#If SUPPORT_ZIP Then
            If forceXMLOnly Then
                xDoc.Save(filename)
            Else
                Using zip As New Ionic.Zip.ZipFile()
                    Dim byteArray() As Byte = System.Text.Encoding.Unicode.GetBytes(xDoc.OuterXml())

                    zip.AddEntry(DATA_FILE_CONTENTS_NAME, byteArray)
                    If filename Is Nothing Then
                        '-- Regular save
                        zip.Save(m_strFilename)
                        LastSaveDate = Date.Now
                        Dim strAutoSaveFilename As String
                        strAutoSaveFilename = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(m_strFilename), System.IO.Path.GetFileNameWithoutExtension(m_strFilename) & DATA_FILE_AUTOSAVE_EXTENSION)
                        If System.IO.File.Exists(strAutoSaveFilename) Then
                            Try
                                System.IO.File.Delete(strAutoSaveFilename)
                            Catch ex As Exception
                                Log(ex) '-- log and continue
                            End Try
                        End If
                    Else
                        '-- AutoSave
                        zip.Save(filename)
                        LastAutoSaveDate = Date.Now
                    End If
                End Using
            End If
#Else
            xDoc.Save(m_strFilename)
#End If
                'xDoc.Save("c:\temp\test.xml")


        Catch ex As Exception
            MessageBox.Show("There was an error saving your data: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

Public Class UnicodeTextWriter
    Inherits System.IO.TextWriter

    Public Overrides ReadOnly Property Encoding As System.Text.Encoding
        Get
            Return System.Text.Encoding.Unicode
        End Get
    End Property
End Class
Public Class PlannedScheduleItem
    Public Property DayOfWeek As DayOfWeek
    Public Property StartTime As Date '-- time component only, date component to be ignored
    Public Property Location As String '-- Room number, for example
    Public Property DurationInMinutes As Integer
    Public Property StudentGroup As Integer '== 0=all students, regardless of group
End Class
Public Enum ScheduleTypeEnum
    Automatic
    Manual
End Enum
Public Class SkipSession
    Public Property StartDateTime As Date
    Public Property Reason As String
End Class
Public Class ActualSessionItem
    Implements IComparable(Of ActualSessionItem)
    Public Sub New(schoolClass As SchoolClass)
        Me.SchoolClass = schoolClass
        UniqueID = Guid.NewGuid.ToString()
        NumberOfTimesExported = 0
    End Sub

    Public Property SchoolClass As SchoolClass
    Public Property StartDateTime As Date
    Public Property SessionNumber As Integer
    Public Property Topic As String '-- name,title, id, etc.
    Public Property Notes As String
    Public Property Prepped As Boolean
    Public Property StudentsEmailed As Boolean
    Public Property ScheduleType As ScheduleTypeEnum
    Public Property Location As String
    Public Property StudentGroup As Integer '-- for workshop session support; 0=all students
    Public Property DurationInMinutes As Integer '-- need here for exporting schedule (may be able to find a work around but too busy now)
    Public Property UniqueID As String '-- for iCal support
    Public Property NumberOfTimesExported '-- for iCal support
    Public ReadOnly Property WeekNumber As Integer
        Get
            Dim ts As TimeSpan = StartDateTime.Date - SchoolClass.ClassGroup.StartDate
            Return (ts.TotalDays \ 7) + 1
        End Get
    End Property
    Public ReadOnly Property DaysInFuture As Double
        Get
            Dim ts As TimeSpan = StartDateTime - Date.Now
            Return ts.TotalDays
        End Get
    End Property
    Public Function CompareTo(ByVal other As ActualSessionItem) As Integer Implements System.IComparable(Of ActualSessionItem).CompareTo
        Return StartDateTime.CompareTo(other.StartDateTime)
    End Function
End Class
Public Class ClassGroup '-- teaching module
    Public Property Semester As Semester '-- parent
    Public Property Name As String
    Public Property Closed As Boolean

    Public Property EndDateOverall As Date
    Public Property StartDateCurrent As Date
    Public Property EndDateCurrent As Date
    Public Property UseNickname As Boolean

    Public Property Classes As New List(Of SchoolClass)
    Public Property AssignmentsBTEC As New List(Of ClassAssignmentBTEC)
    Public Property Assignments As New List(Of ClassAssignment)

    Public Outcomes As New List(Of AssignmentOutcome)
    Public Property LastAssignmentUsed As IClassAssignment
    Public Property LastQuizName As String
    Private m_dtStartDate As Date
    Public Property StartDate As Date
        Get
            If m_dtStartDate = #12:00:00 AM# Then
                If Semester IsNot Nothing Then
                    Return Semester.StartDateOverall
                Else
                    Log("Semester nothing, cannot get start date", 2)
                    Return m_dtStartDate
                End If
            Else
                Return m_dtStartDate
            End If
        End Get
        Set(value As Date)
            m_dtStartDate = value
        End Set
    End Property
    Public Property NumberOfSessions As Integer
    Private m_intSessionLength As Integer
    Public Property SessionLength As Integer '-- in minutes
        Get
            If m_intSessionLength < 1 Then
                Return 1
            Else
                Return m_intSessionLength
            End If
        End Get
        Set(value As Integer)
            If value > 0 AndAlso value < 10000 Then
                m_intSessionLength = value
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function
    Public Sub New(semester As Semester)
        Me.Semester = semester
    End Sub
    ''' <summary>
    ''' Rehydrates object from persisted xml
    ''' </summary>
    ''' <param name="xElement"></param>
    ''' <remarks></remarks>
    Public Sub New(xElement As Xml.XmlElement, semester As Semester)
        Name = xElement.GetAttribute("Name")
        NumberOfSessions = ConvertToInt32(xElement.GetAttribute("NumberOfSessions"), 32)
        SessionLength = ConvertToInt32(xElement.GetAttribute("SessionLength"), 120)
        Closed = ConvertToBool(xElement.GetAttribute("Closed"), False)
        If xElement.GetAttribute("StartDate").Length = 0 Then
            StartDate = #1/1/2013#
        Else
            StartDate = Xml.XmlConvert.ToDateTime(xElement.GetAttribute("StartDate"), Xml.XmlDateTimeSerializationMode.Unspecified)
        End If

        Try
            EndDateOverall = Xml.XmlConvert.ToDateTime(xElement.GetAttribute("EndDate"), Xml.XmlDateTimeSerializationMode.Unspecified)
            StartDateCurrent = Xml.XmlConvert.ToDateTime(xElement.GetAttribute("StartDateCurrent"), Xml.XmlDateTimeSerializationMode.Unspecified)
            EndDateCurrent = Xml.XmlConvert.ToDateTime(xElement.GetAttribute("EndDateCurrent"), Xml.XmlDateTimeSerializationMode.Unspecified)
        Catch ex As Exception
            Application.DoEvents() '-- ignore
        End Try

        UseNickname = ConvertToBool(xElement.GetAttribute("UseNickname"), True)
        Dim strLastUsedAssignmentID As String = xElement.GetAttribute("LastAssignmentUsedID")
        LastQuizName = xElement.GetAttribute("LastQuizName")

        Me.Semester = semester

        Dim boolHigherOutcomesPresent As Boolean
        '-- outcomes must come before assignments because assignments depend on outcomes
        Dim xOutcomeList As Xml.XmlNodeList = xElement.SelectNodes("Outcomes/Outcome")
        Dim xAssignmentList As Xml.XmlNodeList
        If xOutcomeList.Count > 0 Then
            '-- This is a BTEC module
            For Each xOutcome As Xml.XmlElement In xOutcomeList
                Dim objOutcome As New AssignmentOutcome(xOutcome)
                Me.Outcomes.Add(objOutcome)

                '-- We need this so we know whether or not to add M's and D's as outcomes when converting 1.x data to version 2 data
                If objOutcome.GradeGroup = BTECGradeGroup.Merit OrElse objOutcome.GradeGroup = BTECGradeGroup.Distinction Then
                    boolHigherOutcomesPresent = True
                End If
            Next

            '-- For 2.0, we must add M and D outcomes if there are none
            If Not boolHigherOutcomesPresent Then
                Dim objOutcome As AssignmentOutcome

                '-- We will not add descriptions here
                '   instead we will custom populate when we convert data for the BTEC assignment
                objOutcome = New AssignmentOutcome(BTECGradeGroup.Merit)
                objOutcome.Name = "M1"
                Me.Outcomes.Add(objOutcome)
                objOutcome = New AssignmentOutcome(BTECGradeGroup.Merit)
                objOutcome.Name = "M2"
                Me.Outcomes.Add(objOutcome)
                objOutcome = New AssignmentOutcome(BTECGradeGroup.Merit)
                objOutcome.Name = "M3"
                Me.Outcomes.Add(objOutcome)
                objOutcome = New AssignmentOutcome(BTECGradeGroup.Distinction)
                objOutcome.Name = "D1"
                Me.Outcomes.Add(objOutcome)
                objOutcome = New AssignmentOutcome(BTECGradeGroup.Distinction)
                objOutcome.Name = "D2"
                Me.Outcomes.Add(objOutcome)
                objOutcome = New AssignmentOutcome(BTECGradeGroup.Distinction)
                objOutcome.Name = "D3"
                Me.Outcomes.Add(objOutcome)

            End If

            '-- assignments must come before students because students depend on them
            xAssignmentList = xElement.SelectNodes("ClassAssignment") '-- These are BTEC assignments
            For Each xAssignmentNode As Xml.XmlElement In xAssignmentList
                Dim objAssignment As New ClassAssignmentBTEC(xAssignmentNode, Me)
                AssignmentsBTEC.Add(objAssignment)

                '-- If we have a "LastAsmtUsed" then check each asmt for a match
                If strLastUsedAssignmentID.Length > 0 AndAlso objAssignment.ID.ToUpper() = strLastUsedAssignmentID.ToUpper() Then
                    LastAssignmentUsed = objAssignment
                End If
            Next
        End If

        xAssignmentList = xElement.SelectNodes("ClassAssignmentNormal")
        For Each xAssignmentNode As Xml.XmlElement In xAssignmentList
            Dim objAssignment As New ClassAssignment(xAssignmentNode, Me)
            Assignments.Add(objAssignment)

            '-- If we have a "LastAsmtUsed" then check each asmt for a match
            If strLastUsedAssignmentID.Length > 0 AndAlso objAssignment.ID.ToUpper() = strLastUsedAssignmentID.ToUpper() Then
                LastAssignmentUsed = objAssignment
            End If
        Next

        Dim xClassList As Xml.XmlNodeList = xElement.SelectNodes("Class")
        For Each xClassNode As Xml.XmlElement In xClassList
            Dim objClass As New SchoolClass(xClassNode, Me)
            Classes.Add(objClass)
        Next

    End Sub
    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Dim xClassGroupElement As Xml.XmlElement = xDoc.CreateElement("ClassGroup")
        xClassGroupElement.SetAttribute("Name", Name)
        xClassGroupElement.SetAttribute("StartDate", StartDate.ToString(DATE_FORMAT_XML))
        xClassGroupElement.SetAttribute("SessionLength", SessionLength.ToString())
        xClassGroupElement.SetAttribute("NumberOfSessions", NumberOfSessions.ToString())
        xClassGroupElement.SetAttribute("Closed", Closed.ToString())

        xClassGroupElement.SetAttribute("EndDate", Me.EndDateOverall.ToString(DATE_FORMAT_XML))
        xClassGroupElement.SetAttribute("StartDateCurrent", Me.StartDateCurrent.ToString(DATE_FORMAT_XML))
        xClassGroupElement.SetAttribute("EndDateCurrent", Me.EndDateCurrent.ToString(DATE_FORMAT_XML))

        xClassGroupElement.SetAttribute("UseNickname", UseNickname)

        If LastAssignmentUsed IsNot Nothing Then
            xClassGroupElement.SetAttribute("LastAssignmentUsedID", LastAssignmentUsed.ID)
        End If

        xClassGroupElement.SetAttribute("LastQuizName", LastQuizName)



        For Each objClass As SchoolClass In Me.Classes
            xClassGroupElement.AppendChild(objClass.GetXMLElementToPersist(xDoc))
        Next

        '-- Persist the outcomes at ClassGroup level
        Dim xOutcomesElement As Xml.XmlElement = xDoc.CreateElement("Outcomes")
        xOutcomesElement = xClassGroupElement.AppendChild(xOutcomesElement)
        For Each objOutcome As AssignmentOutcome In Outcomes
            xOutcomesElement.AppendChild(objOutcome.GetXMLElementToPersist(xDoc))
        Next

        '-- Persist the assignments
        For Each objAssignment As ClassAssignmentBTEC In AssignmentsBTEC
            xClassGroupElement.AppendChild(objAssignment.GetXMLElementToPersist(xDoc))
        Next
        For Each objAssignment As ClassAssignment In Assignments
            xClassGroupElement.AppendChild(objAssignment.GetXMLElementToPersist(xDoc))
        Next

        Return xClassGroupElement
    End Function
    Friend Sub GenerateModuleReultsExportXLS(filename As String, markingTry As MarkingTry)
        'Const DELIMITER As String = vbTab
        'Using tw As System.IO.StreamWriter = New System.IO.StreamWriter(filename, False, System.Text.Encoding.Unicode) ' System.IO.File.Create(filename, 128, IO.FileOptions.None)
        '    tw.Write("Admin" & DELIMITER & "Alt#" & DELIMITER & "Class" & DELIMITER & "StudentID" & DELIMITER & "LocalName" & DELIMITER & "Nickname" & DELIMITER)

        '    For Each oc As AssignmentOutcome In Me.Outcomes
        '        tw.Write(oc.Name)
        '        tw.Write(DELIMITER)
        '    Next

        '    tw.Write("M1" & DELIMITER & "M2" & DELIMITER & "M3" & DELIMITER & "D1" & DELIMITER & "D2" & DELIMITER & "D3")
        '    tw.Write(Environment.NewLine)

        '    For Each cls As SchoolClass In Classes
        '        For Each stu As Student In cls.Students
        '            Dim studentResults As Student.StudentModuleResult = stu.ModuleResults()

        '            tw.Write(stu.AdminNumber & DELIMITER & stu.AltNumber & DELIMITER & cls.Name & DELIMITER & stu.StudentID & DELIMITER & stu.LocalName & DELIMITER & stu.Nickname & DELIMITER)

        '            For Each rslt As Student.StudentModuleOutcomeResult In studentResults.Outcomes
        '                Select Case rslt.Status
        '                    Case OutcomeResultStatusEnum.Pass
        '                        tw.Write(AppSettings.OutcomeExportMarkPass)
        '                    Case OutcomeResultStatusEnum.Fail
        '                        tw.Write(AppSettings.OutcomeExportMarkFail)
        '                    Case OutcomeResultStatusEnum.Unknown
        '                        tw.Write(AppSettings.OutcomeExportMarkUnknown)
        '                End Select
        '                tw.Write(DELIMITER)
        '            Next

        '            If studentResults.M1Achieved Then
        '                tw.Write(AppSettings.OutcomeExportMarkPass)
        '            Else
        '                tw.Write(AppSettings.OutcomeExportMarkFail)
        '            End If
        '            tw.Write(DELIMITER)
        '            If studentResults.M2Achieved Then
        '                tw.Write(AppSettings.OutcomeExportMarkPass)
        '            Else
        '                tw.Write(AppSettings.OutcomeExportMarkFail)
        '            End If
        '            tw.Write(DELIMITER)
        '            If studentResults.M3Achieved Then
        '                tw.Write(AppSettings.OutcomeExportMarkPass)
        '            Else
        '                tw.Write(AppSettings.OutcomeExportMarkFail)
        '            End If
        '            tw.Write(DELIMITER)
        '            If studentResults.D1Achieved Then
        '                tw.Write(AppSettings.OutcomeExportMarkPass)
        '            Else
        '                tw.Write(AppSettings.OutcomeExportMarkFail)
        '            End If
        '            tw.Write(DELIMITER)
        '            If studentResults.D2Achieved Then
        '                tw.Write(AppSettings.OutcomeExportMarkPass)
        '            Else
        '                tw.Write(AppSettings.OutcomeExportMarkFail)
        '            End If
        '            tw.Write(DELIMITER)
        '            If studentResults.D3Achieved Then
        '                tw.Write(AppSettings.OutcomeExportMarkPass)
        '            Else
        '                tw.Write(AppSettings.OutcomeExportMarkFail)
        '            End If

        '            tw.Write(Environment.NewLine)
        '        Next '-- Student
        '    Next '-- SchoolClass
        '    tw.Close()
        'End Using

    End Sub
    ''' <summary>
    ''' Will generate a file with tab-delimited list of only students who were processed in that marking try
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="assignment"></param>
    ''' <param name="markingTry"></param>
    ''' <remarks></remarks>
    Friend Sub GenerateMarkingList(filename As String, assignment As IClassAssignment, markingTry As MarkingTry)
        Dim lst As New List(Of Student) '-- This is the list of students to include in the report

        For Each cls As SchoolClass In Classes
            For Each stu As Student In cls.Students
                If TypeOf assignment Is ClassAssignmentBTEC Then
                    For Each asmt As StudentAssignmentBTEC In stu.AssignmentsBTEC
                        If asmt.BaseAssignment Is assignment Then
                            '-- ok, this student has this assignment, now are they in this marking try?
                            '   if so, add to the list, otherwise, just keep going around
                            Select Case markingTry
                                Case Globals.MarkingTry.FirstTry
                                    If asmt.FirstTryPrint.Length > 0 Then
                                        lst.Add(stu)
                                    End If
                                Case Globals.MarkingTry.SecondTry
                                    If asmt.SecondTryPrint.Length > 0 Then
                                        lst.Add(stu)
                                    End If
                                Case Globals.MarkingTry.ThirdTry
                                    If asmt.ThirdTryPrint.Length > 0 Then
                                        lst.Add(stu)
                                    End If
                            End Select
                        End If
                    Next
                Else
                    '-- "normal" assignment
                    For Each asmt As StudentAssignment In stu.Assignments
                        If asmt.BaseAssignment Is assignment Then
                            MessageBox.Show("GenerateMarkingList not implemented for normal assignments.")
                            Exit Sub
                            '-- ok, this student has this assignment, now are they in this marking try?
                            '   if so, add to the list, otherwise, just keep going around
                            'Select Case markingTry
                            '    Case Globals.MarkingTry.FirstTry
                            '        If asmt.FirstTryPrint.Length > 0 Then
                            '            lst.Add(stu)
                            '        End If
                            '    Case Globals.MarkingTry.SecondTry
                            '        If asmt.SecondTryPrint.Length > 0 Then
                            '            lst.Add(stu)
                            '        End If
                            '    Case Globals.MarkingTry.ThirdTry
                            '        If asmt.ThirdTryPrint.Length > 0 Then
                            '            lst.Add(stu)
                            '        End If
                            'End Select
                        End If
                    Next
                End If
            Next
        Next

        GenerateModuleReultsExport(filename, markingTry, lst)
    End Sub
    ''' <summary>
    ''' Will generate a file with tab-delimited list of only students who were processed in that marking try
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="assignment"></param>
    ''' <param name="markingTry"></param>
    ''' <remarks></remarks>
    Friend Sub GenerateMarkingListIsolated(filename As String, assignment As IClassAssignment, markingTry As MarkingTry)
        Dim lst As New List(Of Student) '-- This is the list of students to include in the report

        For Each cls As SchoolClass In Classes
            For Each stu As Student In cls.Students
                If TypeOf assignment Is ClassAssignmentBTEC Then
                    For Each asmt As StudentAssignmentBTEC In stu.AssignmentsBTEC
                        If asmt.BaseAssignment Is assignment Then
                            '-- ok, this student has this assignment, now are they in this marking try?
                            '   if so, add to the list, otherwise, just keep going around
                            Select Case markingTry
                                Case Globals.MarkingTry.FirstTry
                                    If asmt.FirstTryPrint.Length > 0 Then
                                        lst.Add(stu)
                                    End If
                                Case Globals.MarkingTry.SecondTry
                                    If asmt.SecondTryPrint.Length > 0 Then
                                        lst.Add(stu)
                                    End If
                                Case Globals.MarkingTry.ThirdTry
                                    If asmt.ThirdTryPrint.Length > 0 Then
                                        lst.Add(stu)
                                    End If
                            End Select
                        End If
                    Next
                Else
                    '-- "normal" assignment
                    For Each asmt As StudentAssignment In stu.Assignments
                        If asmt.BaseAssignment Is assignment Then
                            MessageBox.Show("GenerateMarkingListIsolated not implemented for normal assignments.")
                            Exit Sub
                        End If
                    Next
                End If
            Next
        Next

        GenerateMarkingReportIsolated(filename, markingTry, lst, assignment)
    End Sub
    ''' <summary>
    ''' BTEC-only: Generates and saves a report of outcomes marked for the marking try. If outcome 1.1 was not marked in the second submission then it will output as blank even if it was marked in the first submission
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="markingTry"></param>
    ''' <param name="studentList"></param>
    ''' <remarks></remarks>
    Friend Sub GenerateMarkingReportIsolated(filename As String, markingTry As MarkingTry, studentList As List(Of Student), assignment As ClassAssignmentBTEC)
        Const DELIMITER As String = vbTab
        Using tw As System.IO.StreamWriter = New System.IO.StreamWriter(filename, False, System.Text.Encoding.Unicode) ' System.IO.File.Create(filename, 128, IO.FileOptions.None)
            tw.Write("Admin" & DELIMITER & "Alt#" & DELIMITER & "Class" & DELIMITER & "StudentID" & DELIMITER & "LocalName" & DELIMITER & "Nickname" & DELIMITER)

            '-- output all outcomes on assignment (not all in module)
            assignment.Outcomes.Sort()
            For Each oc As AssignmentOutcome In assignment.Outcomes
                tw.Write(oc.Name)
                tw.Write(DELIMITER)
            Next

            '-- Output headers for M's and D's 
            'tw.Write("M1" & DELIMITER & "M2" & DELIMITER & "M3" & DELIMITER & "D1" & DELIMITER & "D2" & DELIMITER & "D3")
            tw.Write(Environment.NewLine)

            Dim asmtToUse As StudentAssignmentBTEC

            For Each cls As SchoolClass In Classes
                For Each stu As Student In cls.Students
                    '-- If there is no student list, then process all
                    '   if there is a student list, then only include students on that list
                    If studentList IsNot Nothing Then
                        If Not studentList.Contains(stu) Then
                            Continue For '-- the student is not on the list, so skip this student
                        End If
                    End If

                    tw.Write(stu.AdminNumber & DELIMITER & stu.AltNumber & DELIMITER & cls.Name & DELIMITER & stu.StudentID & DELIMITER & stu.LocalName & DELIMITER & stu.Nickname & DELIMITER)

                    asmtToUse = Nothing '-- reset
                    For Each asmt As StudentAssignmentBTEC In stu.AssignmentsBTEC
                        If asmt.BaseAssignment Is assignment Then
                            asmtToUse = asmt
                        End If
                    Next

                    If asmtToUse Is Nothing Then
                        '-- cannot process student because they have no assignment
                        '   This is actually an error because they should have never been on the list
                        '   if they did not have a marked assignment
                        Log("Student in GenerateMarkingReportIsolated without Assignment. ID: " & stu.StudentID, 3)
                        Continue For
                    End If
                    For Each ocr As OutcomeResult In asmtToUse.Outcomes
                        Select Case markingTry
                            Case Globals.MarkingTry.FirstTry
                                Select Case ocr.FirstTryStatus
                                    Case OutcomeResultStatusEnum.Achieved
                                        tw.Write(AppSettings.OutcomeExportMarkPass)
                                    Case OutcomeResultStatusEnum.NotAchieved
                                        tw.Write(AppSettings.OutcomeExportMarkFail)
                                    Case OutcomeResultStatusEnum.Unknown
                                        tw.Write(AppSettings.OutcomeExportMarkUnknown)
                                End Select
                            Case Globals.MarkingTry.SecondTry
                                Select Case ocr.SecondTryStatus
                                    Case OutcomeResultStatusEnum.Achieved
                                        tw.Write(AppSettings.OutcomeExportMarkPass)
                                    Case OutcomeResultStatusEnum.NotAchieved
                                        tw.Write(AppSettings.OutcomeExportMarkFail)
                                    Case OutcomeResultStatusEnum.Unknown
                                        tw.Write(AppSettings.OutcomeExportMarkUnknown)
                                End Select
                            Case Globals.MarkingTry.ThirdTry
                                Select Case ocr.ThirdTryStatus
                                    Case OutcomeResultStatusEnum.Achieved
                                        tw.Write(AppSettings.OutcomeExportMarkPass)
                                    Case OutcomeResultStatusEnum.NotAchieved
                                        tw.Write(AppSettings.OutcomeExportMarkFail)
                                    Case OutcomeResultStatusEnum.Unknown
                                        tw.Write(AppSettings.OutcomeExportMarkUnknown)
                                End Select
                        End Select
                        tw.Write(DELIMITER)
                    Next

                    '-- Potential bug: School policy COULD be to allow M's and D's on second try
                    '   but we don't track WHEN student got M's or D's, just whether they have them or not
                    '   So could output secondTry with M2 but really it was given on firstTry
                    '   Am not changing this now because I'm the only user and none of my schools do this
                    'If asmtToUse.M1Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If asmtToUse.M2Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If asmtToUse.M3Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If asmtToUse.D1Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If asmtToUse.D2Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If asmtToUse.D3Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If

                    tw.Write(Environment.NewLine)
                Next '-- Student
            Next '-- SchoolClass
            tw.Close()
        End Using

    End Sub
    Friend Sub GenerateModuleReultsExport(filename As String, markingTry As MarkingTry, studentList As List(Of Student))
        Const DELIMITER As String = vbTab
        Using tw As System.IO.StreamWriter = New System.IO.StreamWriter(filename, False, System.Text.Encoding.Unicode) ' System.IO.File.Create(filename, 128, IO.FileOptions.None)
            tw.Write("Admin" & DELIMITER & "Alt#" & DELIMITER & "Class" & DELIMITER & "StudentID" & DELIMITER & "LocalName" & DELIMITER & "Nickname" & DELIMITER)

            For Each oc As AssignmentOutcome In Me.Outcomes
                tw.Write(oc.Name)
                tw.Write(DELIMITER)
            Next

            'tw.Write("M1" & DELIMITER & "M2" & DELIMITER & "M3" & DELIMITER & "D1" & DELIMITER & "D2" & DELIMITER & "D3")
            tw.Write(Environment.NewLine)

            For Each cls As SchoolClass In Classes
                For Each stu As Student In cls.Students
                    '-- If there is no student list, then process all
                    '   if there is a student list, then only include students on that list
                    If studentList IsNot Nothing Then
                        If Not studentList.Contains(stu) Then
                            Continue For '-- the student is not on the list, so skip this student
                        End If
                    End If
                    Dim studentResults As Student.StudentModuleResult = stu.ModuleResults(False) '-- Should result in each module outcome one time, regardless of how many asmts it was on

                    tw.Write(stu.AdminNumber & DELIMITER & stu.AltNumber & DELIMITER & cls.Name & DELIMITER & stu.StudentID & DELIMITER & stu.LocalName & DELIMITER & stu.Nickname & DELIMITER)

                    For Each rslt As Student.StudentModuleOutcomeResult In studentResults.Outcomes
                        Select Case rslt.Status
                            Case OutcomeResultStatusEnum.Achieved
                                tw.Write(AppSettings.OutcomeExportMarkPass)
                            Case OutcomeResultStatusEnum.NotAchieved
                                tw.Write(AppSettings.OutcomeExportMarkFail)
                            Case OutcomeResultStatusEnum.Unknown
                                tw.Write(AppSettings.OutcomeExportMarkUnknown)
                        End Select
                        tw.Write(DELIMITER)
                    Next

                    'If studentResults.M1Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If studentResults.M2Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If studentResults.M3Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If studentResults.D1Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If studentResults.D2Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If
                    'tw.Write(DELIMITER)
                    'If studentResults.D3Achieved Then
                    '    tw.Write(AppSettings.OutcomeExportMarkPass)
                    'Else
                    '    tw.Write(AppSettings.OutcomeExportMarkFail)
                    'End If

                    tw.Write(Environment.NewLine)
                Next '-- Student
            Next '-- SchoolClass
            tw.Close()
        End Using
    End Sub
    Public Sub RemoveOutcome(outcome As AssignmentOutcome)
        '-- will throw an error if the outcome is in use by any assignment
        For Each asmt As ClassAssignmentBTEC In Me.AssignmentsBTEC
            For Each oc As AssignmentOutcome In asmt.Outcomes
                If oc.ID = outcome.ID Then
                    '-- This outcome is in use on some student's assignment, cannot be removed
                    Throw New Exception("Outcome is being used in assignment (" & asmt.Name & ") and cannot be removed from this module.")
                End If
            Next
        Next

        '-- If we get here, then we can remove the outcome
        Me.Outcomes.Remove(outcome)
    End Sub
    Public ReadOnly Property AssignmentOutcomeCount As Integer
        Get
            Dim intReturn As Integer
            For Each asmt In Me.AssignmentsBTEC
                intReturn += asmt.Outcomes.Count
            Next

            Return intReturn
        End Get
    End Property
End Class

Public Class SchoolClass
    Public Property ClassGroup As ClassGroup '-- parent
    Public Property Name As String
    Public Property Students As New List(Of Student)
    Public Property EmailAddress As String
    Public Property SessionsToSkip As New List(Of SkipSession)
    Public Property PlannedSchedule As New List(Of PlannedScheduleItem)
    Public Property ActualSessions As New List(Of ActualSessionItem)
    Public Property EmailSendingAccount As Integer
    Public Property ClassSessions As New List(Of ClassSession)
    Public Property Notes As String

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function
    ''' <summary>
    ''' Will strip off any semester-specific data and add the student to this SchoolClass
    ''' </summary>
    ''' <param name="stud">The student to import</param>
    ''' <remarks></remarks>
    Public Sub ImportStudent(stud As Student)
        stud.ClearStudentOfHistoricalData()
        Me.Students.Add(stud)
    End Sub
    ''' <summary>
    ''' Generates auto actual sessions, leaving manual sessions
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GenerateActualSessions()
        Try
            Dim lstNewActualSessions As New List(Of ActualSessionItem)

            Dim dtCurrent As Date = Me.ClassGroup.StartDate
            Dim intPlanningCounter, intMasterCounter As Integer
            Dim objProposedAdd As ActualSessionItem
            Dim boolExistsAlready, boolSkipThisDateTime As Boolean

            If PlannedSchedule.Count = 0 Then
                Exit Sub '-- cannot schedule with no planned schedule
            End If

            '-- Add all manual entries from the old list to the new one
            Dim intCounterMax As Integer = ActualSessions.Count - 1
            For intCounter As Integer = 0 To intCounterMax
                If ActualSessions(intCounter).ScheduleType = ScheduleTypeEnum.Manual Then
                    lstNewActualSessions.Add(ActualSessions(intCounter))
                End If
            Next

            Dim lstDaysOfWeek As New List(Of DayOfWeek)
            For Each item As PlannedScheduleItem In PlannedSchedule
                If Not lstDaysOfWeek.Contains(item.DayOfWeek) Then
                    lstDaysOfWeek.Add(item.DayOfWeek)
                End If
            Next


            '-- Now, build up automatic entries
            Do Until lstNewActualSessions.Count = Me.ClassGroup.NumberOfSessions
                intPlanningCounter = intMasterCounter Mod PlannedSchedule.Count

                '-- If we meet just one day per week, then we must skip a day or the next logic causes infinite loop
                If lstDaysOfWeek.Count = 1 AndAlso intPlanningCounter = 0 AndAlso lstNewActualSessions.Count > 0 Then
                    dtCurrent = dtCurrent.AddDays(1)
                End If

                Do Until dtCurrent.DayOfWeek = PlannedSchedule(intPlanningCounter).DayOfWeek
                    dtCurrent = dtCurrent.AddDays(1)
                Loop

                '-- Create proposed item to add
                objProposedAdd = New ActualSessionItem(Me)
                objProposedAdd.StartDateTime = dtCurrent.Add(PlannedSchedule(intPlanningCounter).StartTime.TimeOfDay)
                objProposedAdd.Location = PlannedSchedule(intPlanningCounter).Location
                objProposedAdd.StudentGroup = PlannedSchedule(intPlanningCounter).StudentGroup
                objProposedAdd.DurationInMinutes = PlannedSchedule(intPlanningCounter).DurationInMinutes

                '-- make sure the item doesn't exist already (as a manual item, for example)
                boolExistsAlready = False
                boolSkipThisDateTime = False
                For Each objActual As ActualSessionItem In lstNewActualSessions

                    '-- Now see if there is already an entity there
                    If objActual.StartDateTime = objProposedAdd.StartDateTime Then
                        boolExistsAlready = True
                        Exit For
                    End If
                Next

                If Not boolExistsAlready Then
                    For Each objSkip As SkipSession In SessionsToSkip
                        If objSkip.StartDateTime = objProposedAdd.StartDateTime Then
                            boolSkipThisDateTime = True
                            Exit For
                        End If
                    Next
                End If

                intMasterCounter += 1


                If Not boolSkipThisDateTime AndAlso Not boolExistsAlready Then
                    objProposedAdd.Prepped = False
                    objProposedAdd.StudentsEmailed = False
                    objProposedAdd.ScheduleType = ScheduleTypeEnum.Automatic
                    'objProposedAdd.Topic = Me.ClassgGroup.Name & " " & intSessionTitleCounter.ToString("#,##0")
                    objProposedAdd.Notes = String.Empty
                    lstNewActualSessions.Add(objProposedAdd)
                End If

            Loop

            '-- at the end, sort by date/time
            lstNewActualSessions.Sort()

            '-- Now, rename/number all the sessions and re-apply the attributes
            Dim intSessionTitleCounter As Integer
            For intCounter As Integer = 0 To lstNewActualSessions.Count - 1
                If ActualSessions.Count <= intCounter Then
                    '-- We don't have enough existing actual sessions, so start adding new blank ones
                    intSessionTitleCounter = intCounter + 1
                    lstNewActualSessions(intCounter).SessionNumber = intSessionTitleCounter
                    lstNewActualSessions(intCounter).Topic = Me.ClassGroup.Name & " " & intSessionTitleCounter.ToString("#,##0")
                    lstNewActualSessions(intCounter).Prepped = False
                    lstNewActualSessions(intCounter).StudentsEmailed = False
                    lstNewActualSessions(intCounter).Notes = String.Empty
                Else
                    '-- re-use data from existing actual sessions
                    intSessionTitleCounter = intCounter + 1
                    lstNewActualSessions(intCounter).SessionNumber = intSessionTitleCounter
                    lstNewActualSessions(intCounter).Topic = ActualSessions(intCounter).Topic
                    lstNewActualSessions(intCounter).Prepped = ActualSessions(intCounter).Prepped
                    lstNewActualSessions(intCounter).StudentsEmailed = ActualSessions(intCounter).StudentsEmailed
                    lstNewActualSessions(intCounter).Notes = ActualSessions(intCounter).Notes
                    lstNewActualSessions(intCounter).UniqueID = ActualSessions(intCounter).UniqueID
                    lstNewActualSessions(intCounter).NumberOfTimesExported = ActualSessions(intCounter).NumberOfTimesExported
                End If
            Next

            '-- and reassign to the persisted list
            ActualSessions = lstNewActualSessions

        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error auto generating actual sessions.", Application.ProductName)
        End Try
    End Sub
    ''' <summary>
    ''' Will return the class session topic for the date/group combination. If there are multiple sessions on the same date, only the first will be used (could cause some confusion).
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="studentGroup"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetSessionTopic(startDate As Date, studentGroup As Integer) As ActualSessionItem
        For Each actualSession As ActualSessionItem In Me.ActualSessions
            If actualSession.StartDateTime.Date = startDate AndAlso (actualSession.StudentGroup = 0 OrElse actualSession.StudentGroup = studentGroup) Then
                '-- just return the first match
                Return actualSession
            End If
        Next

        Return Nothing '-- no match
    End Function

    Public ReadOnly Property HiddenStudents As Integer
        Get
            Dim intReturn As Integer
            For Each stud As Student In Students
                If stud.Hidden Then
                    intReturn += 1
                End If
            Next

            Return intReturn
        End Get
    End Property
    Public Sub GenerateAttendaceExport(filename As String)
        '-- create a list with names and dates and export for opening/manipulation in Excel
        Const DELIMITER As String = vbTab
        Using tw As System.IO.StreamWriter = New System.IO.StreamWriter(filename, False, System.Text.Encoding.Unicode) ' System.IO.File.Create(filename, 128, IO.FileOptions.None)
            tw.Write(DELIMITER)
            tw.Write(DELIMITER)
            tw.Write(DELIMITER)
            tw.Write(DELIMITER)

            Dim intFirstNonZeroStudentGroup As Integer
            Dim dtLastNonZeroCheckDate As Date
            For Each session As ClassSession In ClassSessions
                '-- First add the dates

                '-- Rule: If 1/1/2001 Group 1 has been written, then 1/1/2001 Group 2 should not get a new header,
                '   because the data will not line up
                If session.StudentGroup <> 0 Then
                    If intFirstNonZeroStudentGroup > 0 AndAlso dtLastNonZeroCheckDate = session.StartDate Then
                        '-- we already used one of the group numbers for this date
                        If session.StudentGroup <> intFirstNonZeroStudentGroup Then
                            '-- Ignore this, just loop around
                        Else
                            '-- same group, same date, so we have multiple workshops for the same group on this day (can happen)
                            '   write header

                            tw.Write(session.StartDate.ToString("d"))
                            tw.Write(DELIMITER)
                        End If
                    Else
                        intFirstNonZeroStudentGroup = session.StudentGroup
                        dtLastNonZeroCheckDate = session.StartDate

                        '-- This is the first non-zero group, so use this, ignore others
                        tw.Write(session.StartDate.ToString("d"))
                        tw.Write(DELIMITER)
                    End If
                Else
                    '-- This is an "all" (zero) student group session
                    tw.Write(session.StartDate.ToString("d"))
                    tw.Write(DELIMITER)
                End If
            Next
            tw.Write("Current")
            tw.Write(DELIMITER)
            tw.Write("Total")

            tw.Write(Environment.NewLine)

            '-- Next, walk through the students and mark present, absent, or late
            Dim intCounter As Integer
            Dim intStudentCounter As Integer
            Dim strStatus As String
            Dim intStudentSessionCounterOffset As Integer '-- When -2 then clas.ClassSessions(6) = stud.TeachingSessions(4) [this handles getting out of sync because of studentgroups (workshops)

            For Each student As Student In Students
                intStudentCounter += 1
                intCounter = 0
                tw.Write(student.AdminNumber)
                tw.Write(DELIMITER)
                tw.Write(student.LocalName)
                tw.Write(DELIMITER)
                tw.Write(student.Nickname)
                tw.Write(DELIMITER)
                tw.Write(student.StudentID)
                tw.Write(DELIMITER)

                intCounter = 0
                intStudentSessionCounterOffset = 0

                Dim intSessionCounter As Integer
                For intSessionCounter = 0 To student.SchoolClass.ClassSessions.Count - 1
                    '-- StudentGroup = 0 means that it was the lecture, all students attended
                    '   StudentGroup <> 0 means only students with matching group attended
                    If student.SchoolClass.ClassSessions(intSessionCounter).StudentGroup = 0 OrElse student.SchoolClass.ClassSessions(intSessionCounter).StudentGroup = student.StudentGroup Then
                        Dim session As TeachingSession = student.TeachingSessions(intSessionCounter + intStudentSessionCounterOffset)

                        '-- The second part is in case the student's session is off but it is the only one that is off
                        '   That is, if the next session's date matches then we just assume a single error and keep moving forward
                        If session.StartDate = ClassSessions(intSessionCounter).StartDate Then
                            Select Case session.AttendenceStatus
                                Case AttendenceStatusEnum.Absent
                                    strStatus = AppSettings.AttendenceReportMarkAbsent
                                Case AttendenceStatusEnum.Late
                                    strStatus = AppSettings.AttendenceReportMarkLate
                                Case AttendenceStatusEnum.Present
                                    strStatus = AppSettings.AttendenceReportMarkPresent
                                Case AttendenceStatusEnum.Removed
                                    strStatus = AppSettings.AttendenceReportMarkRemoved
                                Case AttendenceStatusEnum.Unknown
                                    strStatus = AppSettings.AttendenceReportMarkUnknown
                                Case AttendenceStatusEnum.Excused
                                    strStatus = AppSettings.AttendenceReportMarkExcused
                                Case Else
                                    strStatus = AppSettings.AttendenceReportMarkUnknown
                            End Select
                        Else
                            strStatus = AppSettings.AttendenceReportMarkUnknown
                        End If

                        tw.Write(strStatus)
                        tw.Write(DELIMITER)
                        intCounter += 1
                    Else
                        '-- need to skip this classSession by changing the sync offset
                        intStudentSessionCounterOffset -= 1
                    End If
                Next

                tw.Write(student.CurrentAbsences.ToString())
                tw.Write(DELIMITER)
                tw.Write(student.TotalAbsences.ToString())

                '-- Prep for new student
                tw.Write(Environment.NewLine)
            Next
            tw.Close()
        End Using

    End Sub
    ''' <summary>
    ''' Exports student grades for all normal (not BTEC) assignments
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <remarks></remarks>
    Public Sub GenerateStudentGradesExport(filename As String)
        Try
            '-- The output here will be a crosstab
            '   Across will be A1, A2, etc.
            '   Down will be students
            '----------------
            '   Sample (but maybe tabs as delimiter)
            '----------------
            '"Name","","A1","Exam1","Participation"
            '"Weight","","40%","","50%","","10%",""
            '"Max Points","","Out of 100","%","Out of 60","%","Out of 20","%"
            '"John Smith","123456","40","40%","55","92%","10","50%"
            '"Suzi Someone","123457","55","55%","45","75%","18","90%"
            Const DELIMITER As String = vbTab
            Using tw As System.IO.StreamWriter = New System.IO.StreamWriter(filename, False, System.Text.Encoding.Unicode)
                tw.Write("Assessment Name")
                tw.Write(DELIMITER)
                tw.Write("")
                tw.Write(DELIMITER)
                tw.Write("")
                tw.Write(DELIMITER)
                tw.Write("")
                tw.Write(DELIMITER)
                tw.Write("")

                For Each asmt As ClassAssignment In Me.ClassGroup.Assignments
                    tw.Write(DELIMITER)
                    tw.Write(asmt.Name)
                    tw.Write(DELIMITER)
                    tw.Write("")
                Next
                tw.Write(Environment.NewLine)

                tw.Write("Weighting")
                tw.Write(DELIMITER)
                tw.Write("")
                tw.Write(DELIMITER)
                tw.Write("")
                tw.Write(DELIMITER)
                tw.Write("")
                tw.Write(DELIMITER)
                tw.Write("")

                For Each asmt As ClassAssignment In Me.ClassGroup.Assignments
                    tw.Write(DELIMITER)
                    tw.Write(asmt.Weighting.ToString("##0%"))
                    tw.Write(DELIMITER)
                    tw.Write("")
                Next
                tw.Write(Environment.NewLine)

                tw.Write("")
                tw.Write(DELIMITER)
                tw.Write("Local name")
                tw.Write(DELIMITER)
                tw.Write("Nickname")
                tw.Write(DELIMITER)
                tw.Write("StudentID")
                tw.Write(DELIMITER)
                tw.Write("ExtStudentID")

                For Each asmt As ClassAssignment In Me.ClassGroup.Assignments
                    tw.Write(DELIMITER)
                    tw.Write("/" & asmt.MaxPoints)
                    tw.Write(DELIMITER)
                    tw.Write("%")
                Next
                tw.Write(DELIMITER)
                tw.Write("Overall %")

                tw.Write(Environment.NewLine)



                Dim intStudentCounter As Integer

                Dim stuAsmtToProcess As StudentAssignment
                Dim dblOverall As Double
                Dim dblPercent As Double

                For Each student As Student In Students
                    dblOverall = 0 '-- reset
                    intStudentCounter += 1

                    tw.Write(student.AdminNumber)
                    tw.Write(DELIMITER)
                    tw.Write(student.LocalName)
                    tw.Write(DELIMITER)
                    tw.Write(student.Nickname)
                    tw.Write(DELIMITER)
                    tw.Write(student.StudentID)
                    tw.Write(DELIMITER)
                    tw.Write(student.ExtStudentID)

                    For Each asmt As ClassAssignment In Me.ClassGroup.Assignments
                        stuAsmtToProcess = Nothing
                        For Each stuAsmt As StudentAssignment In student.Assignments
                            If stuAsmt.BaseAssignment Is asmt Then
                                stuAsmtToProcess = stuAsmt
                                Exit For
                            End If
                        Next

                        tw.Write(DELIMITER)
                        If stuAsmtToProcess Is Nothing Then
                            '-- not submitted
                            tw.Write(String.Empty)
                            tw.Write(DELIMITER)
                            tw.Write("0%")
                        Else
                            '-- output the highest score
                            Dim intScore As Integer = Math.Max(Math.Max(stuAsmtToProcess.FirstTryPoints, stuAsmtToProcess.SecondTryPoints), stuAsmtToProcess.ThirdTryPoints)
                            tw.Write(intScore.ToString("#,##0"))
                            dblOverall += (intScore / stuAsmtToProcess.BaseAssignment.MaxPoints) * stuAsmtToProcess.BaseAssignment.Weighting
                            tw.Write(DELIMITER)
                            dblPercent = intScore / asmt.MaxPoints
                            tw.Write(dblPercent.ToString("##0%"))
                        End If
                    Next
                    tw.Write(DELIMITER)
                    tw.Write(dblOverall.ToString("##0%"))
                    tw.Write(Environment.NewLine)
                Next
                tw.Close()
            End Using
        Catch ex As Exception
            Log(ex)
            Throw ex
        End Try
    End Sub
    Public Sub GenerateStudentExport(filename As String)
        '-- create a list with names and dates and export for opening/manipulation in Excel
        Const DELIMITER As String = vbTab
        Using tw As System.IO.StreamWriter = New System.IO.StreamWriter(filename, False, System.Text.Encoding.Unicode)
            tw.Write("AdminNumber")
            tw.Write(DELIMITER)
            tw.Write("LocalName")
            tw.Write(DELIMITER)
            tw.Write("Nickname")
            tw.Write(DELIMITER)
            tw.Write("StudentID")
            tw.Write(DELIMITER)
            tw.Write("ExtID")
            tw.Write(DELIMITER)
            tw.Write("Presentation")
            tw.Write(DELIMITER)
            tw.Write("Writing")
            tw.Write(DELIMITER)
            tw.Write("MeritPoints")
            tw.Write(DELIMITER)
            tw.Write("TotalAbsences")
            tw.Write(DELIMITER)
            tw.Write("CurrentAbsences")
            tw.Write(DELIMITER)
            tw.Write("EmailAddress")
            tw.Write(DELIMITER)
            tw.Write("Hidden")
            tw.Write(DELIMITER)
            tw.Write("Group")
            tw.Write(DELIMITER)
            tw.Write("Team")
            tw.Write(DELIMITER)
            tw.Write("Tags")

            tw.Write(Environment.NewLine)

            '-- Next, walk through the students and mark present, absent, or late
            Dim intStudentCounter As Integer

            For Each student As Student In Students
                intStudentCounter += 1
                tw.Write(student.AdminNumber)
                tw.Write(DELIMITER)
                tw.Write(student.LocalName)
                tw.Write(DELIMITER)
                tw.Write(student.Nickname)
                tw.Write(DELIMITER)
                tw.Write(student.StudentID)
                tw.Write(DELIMITER)
                tw.Write(student.ExtStudentID)
                tw.Write(DELIMITER)
                tw.Write(student.PresentationQuality)
                tw.Write(DELIMITER)
                tw.Write(student.WritingQuality)
                tw.Write(DELIMITER)
                tw.Write(student.MeritPoints)
                tw.Write(DELIMITER)
                tw.Write(student.TotalAbsences)
                tw.Write(DELIMITER)
                tw.Write(student.CurrentAbsences)
                tw.Write(DELIMITER)
                tw.Write(student.EmailAddress)
                tw.Write(DELIMITER)
                tw.Write(student.Hidden)
                tw.Write(DELIMITER)
                tw.Write(student.StudentGroup.ToString())
                tw.Write(DELIMITER)
                tw.Write(student.StudentTeam)
                tw.Write(DELIMITER)
                tw.Write(student.Tags)


                '-- Prep for new student
                tw.Write(Environment.NewLine)
            Next
            tw.Close()
        End Using
    End Sub
    Public Sub New(classGroup As ClassGroup)
        Me.ClassGroup = classGroup
        EmailAddress = String.Empty
        EmailSendingAccount = AppSettings.EmailSendingAccount
    End Sub
    ''' <summary>
    ''' Rehydrates object from persisted xml
    ''' </summary>
    ''' <param name="xElement"></param>
    ''' <remarks></remarks>
    Public Sub New(xElement As Xml.XmlElement, classGroup As ClassGroup)
        Name = xElement.GetAttribute("Name")
        Me.ClassGroup = classGroup
        EmailAddress = xElement.GetAttribute("EmailAddress")
        EmailSendingAccount = ConvertToInt32(xElement.GetAttribute("EmailSendingAccount"), AppSettings.EmailSendingAccount)
        Dim xClassNotesElement As Xml.XmlElement = xElement.SelectSingleNode("Notes")
        If xClassNotesElement IsNot Nothing Then
            Notes = xClassNotesElement.InnerText
        End If



        '-- Load skip dates
        Dim xSkipSessions As Xml.XmlNodeList = xElement.SelectNodes("SessionsToSkip/SessionToSkip")
        Dim objSkip As SkipSession
        For Each xSkipSession As Xml.XmlElement In xSkipSessions
            objSkip = New SkipSession
            objSkip.StartDateTime = Xml.XmlConvert.ToDateTime(xSkipSession.InnerText, Xml.XmlDateTimeSerializationMode.Unspecified)
            objSkip.Reason = xSkipSession.GetAttribute("Reason")
            SessionsToSkip.Add(objSkip)
        Next
        '-- Load normal schedule data
        Dim xPlannedScheduleItems As Xml.XmlNodeList = xElement.SelectNodes("PlannedScheduleItems/PlannedScheduleItem")
        For Each xPlannedScheduleItem As Xml.XmlElement In xPlannedScheduleItems
            Dim obj As New PlannedScheduleItem
            obj.StartTime = Date.Parse(xPlannedScheduleItem.GetAttribute("StartTime"))
            obj.DayOfWeek = [Enum].Parse(GetType(DayOfWeek), xPlannedScheduleItem.GetAttribute("DayOfWeek"), True)
            obj.Location = xPlannedScheduleItem.GetAttribute("Location")
            obj.DurationInMinutes = ConvertToInt32(xPlannedScheduleItem.GetAttribute("DurationInMinutes"), Me.ClassGroup.SessionLength)
            obj.StudentGroup = ConvertToInt32(xPlannedScheduleItem.GetAttribute("StudentGroup"), 0)
            PlannedSchedule.Add(obj)
        Next

        '-- Load actual schedule data
        Dim xActualSessionItems As Xml.XmlNodeList = xElement.SelectNodes("ActualSessionItems/ActualSessionItem")
        For Each xActualSessionItem As Xml.XmlElement In xActualSessionItems
            Dim obj As New ActualSessionItem(Me)
            obj.StartDateTime = Xml.XmlConvert.ToDateTime(xActualSessionItem.GetAttribute("StartDateTime"), Xml.XmlDateTimeSerializationMode.Unspecified)
            obj.ScheduleType = [Enum].Parse(GetType(ScheduleTypeEnum), xActualSessionItem.GetAttribute("ScheduleType"), True)
            obj.Topic = xActualSessionItem.GetAttribute("Topic")
            obj.Notes = xActualSessionItem.InnerText
            obj.Location = xActualSessionItem.GetAttribute("Location")
            obj.DurationInMinutes = ConvertToInt32(xActualSessionItem.GetAttribute("DurationInMinutes"), 0)
            obj.StudentGroup = ConvertToInt32(xActualSessionItem.GetAttribute("StudentGroup"), 0)
            obj.Prepped = ConvertToBool(xActualSessionItem.GetAttribute("Prepped"), False)
            obj.StudentsEmailed = ConvertToBool(xActualSessionItem.GetAttribute("StudentsEmailed"), False)
            obj.SessionNumber = ConvertToInt32(xActualSessionItem.GetAttribute("SessionNumber"), 0)
            obj.UniqueID = xActualSessionItem.GetAttribute("UniqueID")
            If obj.UniqueID.Length = 0 Then
                obj.UniqueID = Guid.NewGuid.ToString()
            End If
            obj.NumberOfTimesExported = ConvertToInt32(xActualSessionItem.GetAttribute("NumberOfTimesExported"), 0)
            ActualSessions.Add(obj)
        Next

        Dim xClassSessionList As Xml.XmlNodeList = xElement.SelectNodes("ClassSession")
        For Each xClassSession As Xml.XmlElement In xClassSessionList
            Dim objClassSession As New ClassSession(xClassSession)
            ClassSessions.Add(objClassSession)
        Next


        Dim xStudentList As Xml.XmlNodeList = xElement.SelectNodes("Student")
        For Each xStudentNode As Xml.XmlElement In xStudentList
            Dim objStudent As New Student(xStudentNode, Me)
            Students.Add(objStudent)
        Next


    End Sub
    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Dim xClassElement As Xml.XmlElement = xDoc.CreateElement("Class")
        xClassElement.SetAttribute("Name", Name)
        xClassElement.SetAttribute("EmailAddress", EmailAddress)
        xClassElement.SetAttribute("EmailSendingAccount", EmailSendingAccount)
        Dim xClassNotesElement As Xml.XmlElement = xDoc.CreateElement("Notes")
        xClassNotesElement.InnerText = Me.Notes
        xClassElement.AppendChild(xClassNotesElement)

        '-- save skip sessions
        Dim xSkipSession, xSkipSessions As Xml.XmlElement
        xSkipSessions = xClassElement.AppendChild(xDoc.CreateElement("SessionsToSkip"))
        For Each objSkip As SkipSession In SessionsToSkip
            xSkipSession = xSkipSessions.AppendChild(xDoc.CreateElement("SessionToSkip"))
            xSkipSession.InnerText = objSkip.StartDateTime.ToString(DATE_TIME_FORMAT_XML)
            xSkipSession.SetAttribute("Reason", objSkip.Reason)
        Next

        'TODO: Sort planned sessions by date

        '-- save normal schedule data
        Dim xPlannedScheduleItem, xPlannedScheduleItems As Xml.XmlElement
        xPlannedScheduleItems = xClassElement.AppendChild(xDoc.CreateElement("PlannedScheduleItems"))
        For Each objPlannedScheduleItem As PlannedScheduleItem In PlannedSchedule
            xPlannedScheduleItem = xPlannedScheduleItems.AppendChild(xDoc.CreateElement("PlannedScheduleItem"))
            xPlannedScheduleItem.SetAttribute("DayOfWeek", objPlannedScheduleItem.DayOfWeek.ToString())
            xPlannedScheduleItem.SetAttribute("StartTime", objPlannedScheduleItem.StartTime.ToString(TIME_FORMAT_XML))
            xPlannedScheduleItem.SetAttribute("Location", objPlannedScheduleItem.Location)
            xPlannedScheduleItem.SetAttribute("DurationInMinutes", objPlannedScheduleItem.DurationInMinutes)
            xPlannedScheduleItem.SetAttribute("StudentGroup", objPlannedScheduleItem.StudentGroup)
        Next


        '-- Sort actual by date
        ActualSessions.Sort()

        '-- save actual schedule data
        Dim xActualSessionItem, xActualSessionItems As Xml.XmlElement
        xActualSessionItems = xClassElement.AppendChild(xDoc.CreateElement("ActualSessionItems"))
        For Each objActualScheduleItem As ActualSessionItem In ActualSessions
            xActualSessionItem = xActualSessionItems.AppendChild(xDoc.CreateElement("ActualSessionItem"))
            xActualSessionItem.SetAttribute("ScheduleType", objActualScheduleItem.ScheduleType.ToString())
            xActualSessionItem.SetAttribute("StartDateTime", objActualScheduleItem.StartDateTime.ToString(DATE_TIME_FORMAT_XML))
            xActualSessionItem.SetAttribute("Topic", objActualScheduleItem.Topic)
            xActualSessionItem.SetAttribute("Prepped", objActualScheduleItem.Prepped.ToString())
            xActualSessionItem.SetAttribute("StudentsEmailed", objActualScheduleItem.StudentsEmailed.ToString())
            xActualSessionItem.SetAttribute("SessionNumber", objActualScheduleItem.SessionNumber.ToString())
            xActualSessionItem.SetAttribute("Location", objActualScheduleItem.Location)
            xActualSessionItem.SetAttribute("StudentGroup", objActualScheduleItem.StudentGroup.ToString())
            xActualSessionItem.SetAttribute("DurationInMinutes", objActualScheduleItem.DurationInMinutes.ToString())
            xActualSessionItem.SetAttribute("UniqueID", objActualScheduleItem.UniqueID)
            xActualSessionItem.SetAttribute("NumberOfTimesExported", objActualScheduleItem.NumberOfTimesExported)

            xActualSessionItem.InnerText = objActualScheduleItem.Notes
        Next



        ClassSessions.Sort()
        For Each objClassSession As ClassSession In ClassSessions
            Dim xClassSessionElement As Xml.XmlElement = xDoc.CreateElement("ClassSession")
            xClassSessionElement.SetAttribute("Date", objClassSession.StartDate.ToString(DATE_FORMAT_XML))
            xClassSessionElement.SetAttribute("StudentGroup", objClassSession.StudentGroup)
            xClassElement.AppendChild(xClassSessionElement)
        Next

        'TODO: Sort students by Admin, then by StudentID

        Students.Sort()
        For Each objStudent As Student In Students
            xClassElement.AppendChild(objStudent.GetXMLElementToPersist(xDoc))
        Next

        Return xClassElement
    End Function
End Class
Public Interface IStudentAssignment
    Property OverallComments As String
    Property ImprovementComments As String
    Property Processed As Boolean '-- means completed, ready to notify student

    Property FirstTryPrintDate As Date
    Property SecondTryPrintDate As Date
    Property ThirdTryPrintDate As Date
    ReadOnly Property AssignmentType As AssignmentType
End Interface
Public Class StudentAssignment
    Implements IStudentAssignment, IComparable(Of StudentAssignment)


    Public Student As Student '-- parent

    Public Property BaseAssignment As ClassAssignment
    Public Property FirstTryPoints As Integer
    Public Property SecondTryPoints As Integer
    Public Property ThirdTryPoints As Integer
    Public Property OverallComments As String Implements IStudentAssignment.OverallComments
    Public Property ImprovementComments As String Implements IStudentAssignment.ImprovementComments
    Public Property Processed As Boolean Implements IStudentAssignment.Processed '-- means completed, ready to notify student
    Public Property FirstTryPrintDate As Date = DATE_NO_DATE Implements IStudentAssignment.FirstTryPrintDate
    Public Property SecondTryPrintDate As Date = DATE_NO_DATE Implements IStudentAssignment.SecondTryPrintDate
    Public Property ThirdTryPrintDate As Date = DATE_NO_DATE Implements IStudentAssignment.ThirdTryPrintDate
    Public ReadOnly Property AssignmentType As AssignmentType Implements IStudentAssignment.AssignmentType
        Get
            Return BaseAssignment.AssignmentType
        End Get
    End Property

    Public Sub New(assignment As ClassAssignment)
        '-- copy over outcomes
        BaseAssignment = assignment

    End Sub
    Public Sub New(xElement As Xml.XmlElement, Student As Student)
        Dim strBaseAssignmentID As String = xElement.GetAttribute("BaseAssignmentID")

        For Each asmt As ClassAssignment In Student.SchoolClass.ClassGroup.Assignments
            If asmt.ID = strBaseAssignmentID Then
                BaseAssignment = asmt
                Exit For
            End If
        Next

        FirstTryPoints = ConvertToInt32(xElement.GetAttribute("FirstTryPoints"), 0)
        SecondTryPoints = ConvertToInt32(xElement.GetAttribute("SecondTryPoints"), 0)
        ThirdTryPoints = ConvertToInt32(xElement.GetAttribute("ThirdTryPoints"), 0)

        OverallComments = xElement.GetAttribute("OverallComments")
        ImprovementComments = xElement.GetAttribute("ImprovementComments")
        Processed = ConvertToBool(xElement.GetAttribute("Processed"), False)


        Me.Student = Student

        FirstTryPrintDate = ConvertToDateFromXML(xElement.GetAttribute("FirstTryPrintDate"), DATE_NO_DATE)
        SecondTryPrintDate = ConvertToDateFromXML(xElement.GetAttribute("SecondTryPrintDate"), DATE_NO_DATE)
        ThirdTryPrintDate = ConvertToDateFromXML(xElement.GetAttribute("ThirdTryPrintDate"), DATE_NO_DATE)


    End Sub
    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Dim xAssignmentElement As Xml.XmlElement = xDoc.CreateElement("StudentAssignmentNormal")
        xAssignmentElement.SetAttribute("BaseAssignmentID", BaseAssignment.ID)

        xAssignmentElement.SetAttribute("OverallComments", OverallComments)
        xAssignmentElement.SetAttribute("ImprovementComments", ImprovementComments)
        xAssignmentElement.SetAttribute("Processed", Processed)
        xAssignmentElement.SetAttribute("FirstTryPrintDate", FirstTryPrintDate.ToString(DATE_TIME_FORMAT_XML))
        xAssignmentElement.SetAttribute("FirstTryPoints", FirstTryPoints.ToString())
        xAssignmentElement.SetAttribute("SecondTryPrintDate", SecondTryPrintDate.ToString(DATE_TIME_FORMAT_XML))
        xAssignmentElement.SetAttribute("SecondTryPoints", SecondTryPoints.ToString())
        xAssignmentElement.SetAttribute("ThirdTryPrintDate", ThirdTryPrintDate.ToString(DATE_TIME_FORMAT_XML))
        xAssignmentElement.SetAttribute("ThirdTryPoints", ThirdTryPoints.ToString())


        Return xAssignmentElement
    End Function

    Public Function CompareTo(other As StudentAssignment) As Integer Implements IComparable(Of StudentAssignment).CompareTo
        Return Me.BaseAssignment.Name.CompareTo(other.BaseAssignment.Name)
    End Function
End Class
Public Class StudentAssignmentBTEC
    Implements IComparable(Of StudentAssignmentBTEC), IStudentAssignment

    Public Property Student As Student '-- parent
    Public Property BaseAssignment As ClassAssignmentBTEC
    Public Property Outcomes As New List(Of OutcomeResult) '-- studentAssignment has own outcomes to provide for feedback
    'Public Property M1Achieved As Boolean
    'Public Property M2Achieved As Boolean
    'Public Property M3Achieved As Boolean
    'Public Property D1Achieved As Boolean
    'Public Property D2Achieved As Boolean
    'Public Property D3Achieved As Boolean
    Public ReadOnly Property AchievedMerit As Boolean
        Get
            If AchievedAllAtGrade(BTECGradeGroup.Pass) AndAlso AchievedAllAtGrade(BTECGradeGroup.Merit) Then
                Return True
            Else
                Return False
            End If

        End Get
    End Property
    Public ReadOnly Property AchievedDistinction As Boolean
        Get
            If AchievedAllAtGrade(BTECGradeGroup.Pass) AndAlso AchievedAllAtGrade(BTECGradeGroup.Merit) AndAlso AchievedAllAtGrade(BTECGradeGroup.Distinction) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Public ReadOnly Property PassedOutcomesAtPass As Integer
        Get
            Return AchievedOutcomesAtGradeAndTry(BTECGradeGroup.Pass, MarkingTry.ThirdTry)
        End Get
    End Property
    Public ReadOnly Property PassedAllOutcomes As Boolean
        Get
            Return AchievedAllAtGrade(BTECGradeGroup.Pass)
        End Get
    End Property
    Public ReadOnly Property AvailableOutcomes As Integer
        Get
            Return OutcomesAtGrade(BTECGradeGroup.Pass)
        End Get
    End Property
    Private Function AchievedAllAtGrade(grade As BTECGradeGroup) As Boolean
        Dim intAvailable As Integer = OutcomesAtGrade(grade)
        Dim intAchieved As Integer = AchievedOutcomesAtGrade(grade)
        If intAvailable > 0 Then
            Return intAchieved = intAvailable
        Else
            Return False '-- No outcomes at this grade, so did not achieve anything
        End If
    End Function
    Private Function OutcomesAtGrade(grade As BTECGradeGroup) As Integer
        Dim intReturn As Integer
        For Each asmtOC As AssignmentOutcome In Me.BaseAssignment.Outcomes
            If asmtOC.GradeGroup = grade Then
                intReturn += 1
            End If
        Next

        Return intReturn
    End Function
    ''' <summary>
    ''' Number of pass outcomes achieved during the submission (1st, 2nd, 3rd)
    ''' </summary>
    ''' <param name="grade">Pass, Merit, Distinction</param>
    ''' <param name="submission">First submission, rework, second rework</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function AchievedOutcomesAtGradeAndTry(grade As BTECGradeGroup, submission As MarkingTry) As Integer
        Dim intReturn As Integer
        '-- First, second, or third try all count
        For Each ocResult As OutcomeResult In Me.Outcomes
            If ocResult.BaseOutcome.GradeGroup = grade Then
                Select Case submission
                    Case MarkingTry.FirstTry
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                    Case MarkingTry.SecondTry '-- means passed first or second try
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                    Case MarkingTry.ThirdTry '-- means passed on any try
                        If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                            ocResult.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
                            intReturn += 1
                        End If
                End Select
            End If
        Next

        Return intReturn
    End Function

    Public Function AchievedOutcomesAtGrade(grade As BTECGradeGroup) As Integer
        Dim intReturn As Integer
        '-- First, second, or third try all count
        For Each ocResult As OutcomeResult In Me.Outcomes
            If ocResult.BaseOutcome.GradeGroup = grade Then
                If ocResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                    ocResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse _
                    ocResult.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
                    intReturn += 1
                End If
            End If
        Next

        Return intReturn
    End Function

    Public Property OverallComments As String Implements IStudentAssignment.OverallComments
    Public Property ImprovementComments As String Implements IStudentAssignment.ImprovementComments
    Public Property ObservationComments As String
    Public Property Processed As Boolean Implements IStudentAssignment.Processed '-- means completed, ready to notify student
    Public Property FirstTryPrintDate As Date = DATE_NO_DATE Implements IStudentAssignment.FirstTryPrintDate
    Public Property SecondTryPrintDate As Date = DATE_NO_DATE Implements IStudentAssignment.SecondTryPrintDate
    Public Property ThirdTryPrintDate As Date = DATE_NO_DATE Implements IStudentAssignment.ThirdTryPrintDate
    Public ReadOnly Property AssignmentType As AssignmentType Implements IStudentAssignment.AssignmentType
        Get
            Return BaseAssignment.AssignmentType
        End Get
    End Property

    Public Sub New(xElement As Xml.XmlElement, Student As Student)
       
        Dim strBaseAssignmentID As String = xElement.GetAttribute("BaseAssignmentID")


        For Each asmt As ClassAssignmentBTEC In Student.SchoolClass.ClassGroup.AssignmentsBTEC
            If asmt.ID = strBaseAssignmentID Then
                BaseAssignment = asmt
                Exit For
            End If
        Next

        OverallComments = xElement.GetAttribute("OverallComments")
        ImprovementComments = xElement.GetAttribute("ImprovementComments")
        ObservationComments = xElement.GetAttribute("ObservationComments")
        Processed = ConvertToBool(xElement.GetAttribute("Processed"), False)

        Dim xOutcomeResultList As Xml.XmlNodeList = xElement.SelectNodes("OutcomeResult")
        For Each xOutcomeResultNode As Xml.XmlElement In xOutcomeResultList
            Dim objOutcomeResult As New OutcomeResult(xOutcomeResultNode, BaseAssignment, Me)
            Outcomes.Add(objOutcomeResult)
        Next

        '-- Changed in version 2
        '-- Need to add any outcome results for the higher outcomes (M's and D's)

        If Me.BaseAssignment.Outcomes.Count > Me.Outcomes.Count Then
            Dim objBaseOutcome As AssignmentOutcome
            Dim objOutcomeResult As OutcomeResult
            For intCounterBase As Integer = 0 To Me.BaseAssignment.Outcomes.Count - 1
                objBaseOutcome = Me.BaseAssignment.Outcomes(intCounterBase)

                '-- Is this BaseOutcome represented on this student's assignment? If not, add it
                objOutcomeResult = Nothing '-- reset
                For intCounterStudent As Integer = 0 To Me.Outcomes.Count - 1
                    If Me.Outcomes(intCounterStudent).BaseOutcome Is objBaseOutcome Then
                        objOutcomeResult = Me.Outcomes(intCounterStudent)
                        Exit For '-- This BaseOutcome is already represented on this student's assignment
                    End If
                Next
                If objOutcomeResult Is Nothing Then
                    '-- This assignment outcome is NOT represented on this student's assignment, so add it
                    objOutcomeResult = New OutcomeResult(objBaseOutcome, Me)
                    If ConvertToBool(xElement.GetAttribute(objBaseOutcome.Name & "Achieved"), True) Then
                        objOutcomeResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                    Else
                        objOutcomeResult.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                    End If
                    Me.Outcomes.Add(objOutcomeResult)
                End If
            Next
        End If

        'M1Achieved = ConvertToBool(xElement.GetAttribute("M1Achieved"), True)
        'M2Achieved = ConvertToBool(xElement.GetAttribute("M2Achieved"), True)
        'M3Achieved = ConvertToBool(xElement.GetAttribute("M3Achieved"), True)
        'D1Achieved = ConvertToBool(xElement.GetAttribute("D1Achieved"), True)
        'D2Achieved = ConvertToBool(xElement.GetAttribute("D2Achieved"), True)
        'D3Achieved = ConvertToBool(xElement.GetAttribute("D3Achieved"), True)

        Me.Student = Student

        FirstTryPrintDate = ConvertToDateFromXML(xElement.GetAttribute("FirstTryPrintDate"), DATE_NO_DATE)
        SecondTryPrintDate = ConvertToDateFromXML(xElement.GetAttribute("SecondTryPrintDate"), DATE_NO_DATE)
        ThirdTryPrintDate = ConvertToDateFromXML(xElement.GetAttribute("ThirdTryPrintDate"), DATE_NO_DATE)


    End Sub

    Public Sub New(classAssignment As ClassAssignmentBTEC)
        '-- copy over outcomes
        BaseAssignment = classAssignment
        For Each outcome As AssignmentOutcome In BaseAssignment.Outcomes
            Dim newOut As New OutcomeResult(outcome, Me)
            Outcomes.Add(newOut)
        Next
    End Sub
    Public Overrides Function ToString() As String
        Return Me.BaseAssignment.Name
    End Function
    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Dim xAssignmentElement As Xml.XmlElement = xDoc.CreateElement("StudentAssignment")
        xAssignmentElement.SetAttribute("BaseAssignmentID", BaseAssignment.ID)
        'xAssignmentElement.SetAttribute("M1Achieved", M1Achieved.ToString())
        'xAssignmentElement.SetAttribute("M2Achieved", M2Achieved.ToString())
        'xAssignmentElement.SetAttribute("M3Achieved", M3Achieved.ToString())
        'xAssignmentElement.SetAttribute("D1Achieved", D1Achieved.ToString())
        'xAssignmentElement.SetAttribute("D2Achieved", D2Achieved.ToString())
        'xAssignmentElement.SetAttribute("D3Achieved", D3Achieved.ToString)

        xAssignmentElement.SetAttribute("OverallComments", OverallComments)
        xAssignmentElement.SetAttribute("ImprovementComments", ImprovementComments)
        xAssignmentElement.SetAttribute("ObservationComments", ObservationComments)
        xAssignmentElement.SetAttribute("Processed", Processed)
        xAssignmentElement.SetAttribute("FirstTryPrintDate", FirstTryPrintDate.ToString(DATE_TIME_FORMAT_XML))
        xAssignmentElement.SetAttribute("SecondTryPrintDate", SecondTryPrintDate.ToString(DATE_TIME_FORMAT_XML))
        xAssignmentElement.SetAttribute("ThirdTryPrintDate", ThirdTryPrintDate.ToString(DATE_TIME_FORMAT_XML))

        '-- First, sort outcomes
        Outcomes.Sort()
        For Each outcom As OutcomeResult In Outcomes
            xAssignmentElement.AppendChild(outcom.GetXMLElementToPersist(xDoc))
        Next

        Return xAssignmentElement
    End Function

    Public Function CompareTo(other As StudentAssignmentBTEC) As Integer Implements System.IComparable(Of StudentAssignmentBTEC).CompareTo
        '-- If there are outcomes, then the assignments are sorted by who has the earliest outcome name (1.1 would be before 3.1)
        '   if there are no outcomes, then assignments are sorted by name
        'If BaseAssignment.Outcomes.Count > 0 Then
        '    Return BaseAssignment.Outcomes(0).Name.CompareTo(other.BaseAssignment.Outcomes(0).Name)
        'Else
        Return BaseAssignment.Name.CompareTo(other.BaseAssignment.Name)
        'End If
    End Function

    Public ReadOnly Property FirstTryPrint As String
        Get
            If FirstTryPrintDate = DATE_NO_DATE Then
                Return String.Empty
            Else
                Return FirstTryPrintDate.ToString
            End If
        End Get
    End Property
    Public ReadOnly Property SecondTryPrint As String
        Get
            If SecondTryPrintDate = DATE_NO_DATE Then
                Return String.Empty
            Else
                Return SecondTryPrintDate.ToString
            End If
        End Get
    End Property
    Public ReadOnly Property ThirdTryPrint As String
        Get
            If ThirdTryPrintDate = DATE_NO_DATE Then
                Return String.Empty
            Else
                Return ThirdTryPrintDate.ToString
            End If
        End Get
    End Property
End Class
Public Enum AssignmentType
    BTEC
    Normal
End Enum
Public Interface IClassAssignment
    Property ID As String '-- guid
    ReadOnly Property AssignmentType As AssignmentType
    Property ClassGroup As ClassGroup '-- parent
    Property Name As String
    Property ClosedFirstTry As Boolean
    Property ClosedSecondTry As Boolean
    Property ClosedThirdTry As Boolean
    Property IncludesAttachment As Boolean
    Property ReleaseDate As Date
    Property SubmitDate As Date
    Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement

End Interface
Public Class ClassAssignment
    Implements IClassAssignment
    Public Property MaxPoints As Integer = 100 '-- default to 100 to make percents easy

    Public Property Weighting As Double '-- should sum to 100% across all assignments
    Public Property ClassGroup As ClassGroup Implements IClassAssignment.ClassGroup

    Public Property ID As String Implements IClassAssignment.ID

    Public Property Name As String Implements IClassAssignment.Name

    Public Property ClosedFirstTry As Boolean Implements IClassAssignment.ClosedFirstTry

    Public Property ClosedSecondTry As Boolean Implements IClassAssignment.ClosedSecondTry

    Public Property ClosedThirdTry As Boolean Implements IClassAssignment.ClosedThirdTry
    Public Property IncludesAttachment As Boolean Implements IClassAssignment.IncludesAttachment
    Public Property ReleaseDate As Date Implements IClassAssignment.ReleaseDate
    Public Property SubmitDate As Date Implements IClassAssignment.SubmitDate

    Public Property OverallDefaultText As String

    Public Overrides Function ToString() As String
        Dim strToReturn As String = Me.Name & " "

        If Me.ClosedThirdTry Then
            strToReturn &= "(2nd rework done)"
        ElseIf Me.ClosedSecondTry Then
            strToReturn &= "(1st rework done)"
        ElseIf Me.ClosedFirstTry Then
            strToReturn &= "(First submission done)"
        Else
            strToReturn &= "(Open)"
        End If

        Return strToReturn
    End Function
    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement Implements IClassAssignment.GetXMLElementToPersist
        Dim xAssignmentElement As Xml.XmlElement = xDoc.CreateElement("ClassAssignmentNormal")
        xAssignmentElement.SetAttribute("ID", ID)
        xAssignmentElement.SetAttribute("Name", Name)
        xAssignmentElement.SetAttribute("OverallDefaultText", OverallDefaultText)
        xAssignmentElement.SetAttribute("MaxPoints", MaxPoints.ToString())
        xAssignmentElement.SetAttribute("ClosedFirstTry", ClosedFirstTry.ToString())
        xAssignmentElement.SetAttribute("ClosedSecondTry", ClosedSecondTry.ToString())
        xAssignmentElement.SetAttribute("ClosedThirdTry", ClosedThirdTry.ToString())
        xAssignmentElement.SetAttribute("IncludesAttachment", IncludesAttachment.ToString())
        xAssignmentElement.SetAttribute("ReleaseDate", ReleaseDate.ToString(DATE_FORMAT_XML))
        xAssignmentElement.SetAttribute("SubmitDate", SubmitDate.ToString(DATE_FORMAT_XML))
        xAssignmentElement.SetAttribute("Weighting", Weighting.ToString())

        Return xAssignmentElement
    End Function

    Public ReadOnly Property AssignmentType As AssignmentType Implements IClassAssignment.AssignmentType
        Get
            Return Teaching.AssignmentType.Normal
        End Get
    End Property

    Public Sub New(parent As ClassGroup)
        ID = Guid.NewGuid.ToString()
        Me.ClassGroup = parent
        ReleaseDate = Date.MinValue
        SubmitDate = Date.MinValue
    End Sub
    Public Sub New(xElement As Xml.XmlElement, parent As ClassGroup)
        ID = xElement.GetAttribute("ID")
        If ID.Length = 0 Then
            ID = Guid.NewGuid.ToString()
        End If
        Me.ClassGroup = parent
        Name = xElement.GetAttribute("Name")
        OverallDefaultText = xElement.GetAttribute("OverallDefaultText")
        MaxPoints = ConvertToInt32(xElement.GetAttribute("MaxPoints"), 100)
        ClosedFirstTry = ConvertToBool(xElement.GetAttribute("ClosedFirstTry"), False)
        ClosedSecondTry = ConvertToBool(xElement.GetAttribute("ClosedSecondTry"), False)
        ClosedThirdTry = ConvertToBool(xElement.GetAttribute("ClosedThirdTry"), False)
        IncludesAttachment = ConvertToBool(xElement.GetAttribute("IncludesAttachment"), False)
        ReleaseDate = ConvertToDateFromXML(xElement.GetAttribute("ReleaseDate"), Date.MinValue)
        SubmitDate = ConvertToDateFromXML(xElement.GetAttribute("SubmitDate"), Date.MinValue)
        Weighting = ConvertToDecimal(xElement.GetAttribute("Weighting"), 1)

    End Sub

End Class
Public Class ClassAssignmentBTEC
    Implements IClassAssignment
    Public Property ClassGroup As ClassGroup Implements IClassAssignment.ClassGroup
    Public Property ID As String Implements IClassAssignment.ID
    Public Property Name As String Implements IClassAssignment.Name
    Public Property ClosedFirstTry As Boolean Implements IClassAssignment.ClosedFirstTry
    Public Property ClosedSecondTry As Boolean Implements IClassAssignment.ClosedSecondTry
    Public Property ClosedThirdTry As Boolean Implements IClassAssignment.ClosedThirdTry
    Public Property IncludesAttachment As Boolean Implements IClassAssignment.IncludesAttachment
    Public Property ReleaseDate As Date Implements IClassAssignment.ReleaseDate
    Public Property SubmitDate As Date Implements IClassAssignment.SubmitDate

    Public ReadOnly Property AssignmentType As AssignmentType Implements IClassAssignment.AssignmentType
        Get
            Return Teaching.AssignmentType.BTEC
        End Get
    End Property
    Public Property AssignmentBriefFilename As String
    Public Property SavedAssignmentsFolder As String
    Public Property Outcomes As New List(Of AssignmentOutcome)

    '====== Following are deprecated, keeping just to convert old data on load
    'Public Property M1Available As Boolean
    'Public Property M2Available As Boolean
    'Public Property M3Available As Boolean
    'Public Property D1Available As Boolean
    'Public Property D2Available As Boolean
    'Public Property D3Available As Boolean
    'Public Property M1Description As String
    'Public Property M2Description As String
    'Public Property M3Description As String
    'Public Property D1Description As String
    'Public Property D2Description As String
    'Public Property D3Description As String
    '============= End deprecated

    Public Overrides Function ToString() As String
        Dim strToReturn As String = Me.Name & " "

        If Me.ClosedThirdTry Then
            strToReturn &= "(2nd rework done)"
        ElseIf Me.ClosedSecondTry Then
            strToReturn &= "(1st rework done)"
        ElseIf Me.ClosedFirstTry Then
            strToReturn &= "(First submission done)"
        Else
            strToReturn &= "(Open)"
        End If

        Return strToReturn
    End Function
    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement Implements IClassAssignment.GetXMLElementToPersist
        Dim xAssignmentElement As Xml.XmlElement = xDoc.CreateElement("ClassAssignment")
        xAssignmentElement.SetAttribute("ID", ID)
        xAssignmentElement.SetAttribute("Name", Name)
        'xAssignmentElement.SetAttribute("M1Available", M1Available)
        'xAssignmentElement.SetAttribute("M2Available", M2Available)
        'xAssignmentElement.SetAttribute("M3Available", M3Available)
        'xAssignmentElement.SetAttribute("D1Available", D1Available)
        'xAssignmentElement.SetAttribute("D2Available", D2Available)
        'xAssignmentElement.SetAttribute("D3Available", D3Available)
        'xAssignmentElement.SetAttribute("M1Description", M1Description)
        'xAssignmentElement.SetAttribute("M2Description", M2Description)
        'xAssignmentElement.SetAttribute("M3Description", M3Description)
        'xAssignmentElement.SetAttribute("D1Description", D1Description)
        'xAssignmentElement.SetAttribute("D2Description", D2Description)
        'xAssignmentElement.SetAttribute("D3Description", D3Description)
        xAssignmentElement.SetAttribute("AssignmentBriefFilename", AssignmentBriefFilename)
        xAssignmentElement.SetAttribute("SavedAssignmentsFolder", SavedAssignmentsFolder)
        xAssignmentElement.SetAttribute("ClosedFirstTry", ClosedFirstTry.ToString())
        xAssignmentElement.SetAttribute("ClosedSecondTry", ClosedSecondTry.ToString())
        xAssignmentElement.SetAttribute("ClosedThirdTry", ClosedThirdTry.ToString())
        xAssignmentElement.SetAttribute("IncludesAttachment", IncludesAttachment.ToString())
        xAssignmentElement.SetAttribute("ReleaseDate", ReleaseDate.ToString(DATE_FORMAT_XML))
        xAssignmentElement.SetAttribute("SubmitDate", SubmitDate.ToString(DATE_FORMAT_XML))

        '-- Must replace this old logic as we move outcomes to ClassGroup level
        'For Each objOutcome As AssignmentOutcome In Outcomes
        '    xAssignmentElement.AppendChild(objOutcome.GetXMLElementToPersist(xDoc))
        'Next

        '-- Now setup the reference back to the ClassGroup outcome
        Dim xOutcomes As Xml.XmlElement = xDoc.CreateElement("OutcomeRefs")
        xOutcomes = xAssignmentElement.AppendChild(xOutcomes)
        Dim xOutcome As Xml.XmlElement
        Me.Outcomes.Sort()
        For Each outcome As AssignmentOutcome In Me.Outcomes
            xOutcome = xDoc.CreateElement("OutcomeRef")
            xOutcome.SetAttribute("BaseID", outcome.ID)
            xOutcomes.AppendChild(xOutcome)
        Next

        Return xAssignmentElement
    End Function
    Public Function OutcomesAtGrade(grade As BTECGradeGroup) As Integer
        Dim intReturn As Integer
        For Each asmtOC As AssignmentOutcome In Me.Outcomes
            If asmtOC.GradeGroup = grade Then
                intReturn += 1
            End If
        Next

        Return intReturn
    End Function
    Public Sub New(parent As ClassGroup)
        ID = Guid.NewGuid.ToString()
        Me.ClassGroup = parent
        '== Removed for 2.0
        'M1Description = String.Empty
        'M2Description = String.Empty
        'M3Description = String.Empty
        'D1Description = String.Empty
        'D2Description = String.Empty
        'D3Description = String.Empty
        ReleaseDate = Date.MinValue
        SubmitDate = Date.MinValue
    End Sub
    Public Sub New(xElement As Xml.XmlElement, parent As ClassGroup)
        ID = xElement.GetAttribute("ID")
        If ID.Length = 0 Then
            ID = Guid.NewGuid.ToString()
        End If
        Me.ClassGroup = parent
        Name = xElement.GetAttribute("Name")
        'M1Available = xElement.GetAttribute("M1Available")
        'M2Available = xElement.GetAttribute("M2Available")
        'M3Available = xElement.GetAttribute("M3Available")
        'D1Available = xElement.GetAttribute("D1Available")
        'D2Available = xElement.GetAttribute("D2Available")
        'D3Available = xElement.GetAttribute("D3Available")
        'M1Description = xElement.GetAttribute("M1Description")
        'M2Description = xElement.GetAttribute("M2Description")
        'M3Description = xElement.GetAttribute("M3Description")
        'D1Description = xElement.GetAttribute("D1Description")
        'D2Description = xElement.GetAttribute("D2Description")
        'D3Description = xElement.GetAttribute("D3Description")

        '============= Start data conversion for 1.x to 2
        Dim objHigherOutcome As AssignmentOutcome
        If ConvertToBool(xElement.GetAttribute("M1Available"), False) Then
            For intCounter As Integer = 0 To Me.ClassGroup.Outcomes.Count - 1
                If Me.ClassGroup.Outcomes(intCounter).Name = "M1" Then
                    objHigherOutcome = Me.ClassGroup.Outcomes(intCounter)
                    Exit For
                End If
            Next

            If objHigherOutcome Is Nothing Then
                '-- Strange, we have a problem at the ClassGroup level
                MessageBox.Show("Error loading BTEC Class Assignment data (M1 missing from module: " & Me.ClassGroup.Name & ").")
            Else
                objHigherOutcome.Description = xElement.GetAttribute("M1Description")
                Me.Outcomes.Add(objHigherOutcome)
            End If
        End If

        If ConvertToBool(xElement.GetAttribute("M2Available"), False) Then
            For intCounter As Integer = 0 To Me.ClassGroup.Outcomes.Count - 1
                If Me.ClassGroup.Outcomes(intCounter).Name = "M2" Then
                    objHigherOutcome = Me.ClassGroup.Outcomes(intCounter)
                    Exit For
                End If
            Next

            If objHigherOutcome Is Nothing Then
                '-- Strange, we have a problem at the ClassGroup level
                MessageBox.Show("Error loading BTEC Class Assignment data (M2 missing from module: " & Me.ClassGroup.Name & ").")
            Else
                objHigherOutcome.Description = xElement.GetAttribute("M2Description")
                Me.Outcomes.Add(objHigherOutcome)
            End If
        End If

        If ConvertToBool(xElement.GetAttribute("M3Available"), False) Then
            For intCounter As Integer = 0 To Me.ClassGroup.Outcomes.Count - 1
                If Me.ClassGroup.Outcomes(intCounter).Name = "M3" Then
                    objHigherOutcome = Me.ClassGroup.Outcomes(intCounter)
                    Exit For
                End If
            Next

            If objHigherOutcome Is Nothing Then
                '-- Strange, we have a problem at the ClassGroup level
                MessageBox.Show("Error loading BTEC Class Assignment data (M3 missing from module: " & Me.ClassGroup.Name & ").")
            Else
                objHigherOutcome.Description = xElement.GetAttribute("M3Description")
                Me.Outcomes.Add(objHigherOutcome)
            End If
        End If

        If ConvertToBool(xElement.GetAttribute("D1Available"), False) Then
            For intCounter As Integer = 0 To Me.ClassGroup.Outcomes.Count - 1
                If Me.ClassGroup.Outcomes(intCounter).Name = "D1" Then
                    objHigherOutcome = Me.ClassGroup.Outcomes(intCounter)
                    Exit For
                End If
            Next

            If objHigherOutcome Is Nothing Then
                '-- Strange, we have a problem at the ClassGroup level
                MessageBox.Show("Error loading BTEC Class Assignment data (D1 missing from module: " & Me.ClassGroup.Name & ").")
            Else
                objHigherOutcome.Description = xElement.GetAttribute("D1Description")
                Me.Outcomes.Add(objHigherOutcome)
            End If
        End If

        If ConvertToBool(xElement.GetAttribute("D2Available"), False) Then
            For intCounter As Integer = 0 To Me.ClassGroup.Outcomes.Count - 1
                If Me.ClassGroup.Outcomes(intCounter).Name = "D2" Then
                    objHigherOutcome = Me.ClassGroup.Outcomes(intCounter)
                    Exit For
                End If
            Next

            If objHigherOutcome Is Nothing Then
                '-- Strange, we have a problem at the ClassGroup level
                MessageBox.Show("Error loading BTEC Class Assignment data (D2 missing from module: " & Me.ClassGroup.Name & ").")
            Else
                objHigherOutcome.Description = xElement.GetAttribute("D2Description")
                Me.Outcomes.Add(objHigherOutcome)
            End If
        End If

        If ConvertToBool(xElement.GetAttribute("D3Available"), False) Then
            For intCounter As Integer = 0 To Me.ClassGroup.Outcomes.Count - 1
                If Me.ClassGroup.Outcomes(intCounter).Name = "D3" Then
                    objHigherOutcome = Me.ClassGroup.Outcomes(intCounter)
                    Exit For
                End If
            Next

            If objHigherOutcome Is Nothing Then
                '-- Strange, we have a problem at the ClassGroup level
                MessageBox.Show("Error loading BTEC Class Assignment data (D3 missing from module: " & Me.ClassGroup.Name & ").")
            Else
                objHigherOutcome.Description = xElement.GetAttribute("D3Description")
                Me.Outcomes.Add(objHigherOutcome)
            End If
        End If
        '============= End data conversion for 1.x to 2

        AssignmentBriefFilename = xElement.GetAttribute("AssignmentBriefFilename")
        SavedAssignmentsFolder = xElement.GetAttribute("SavedAssignmentsFolder")
        ClosedFirstTry = ConvertToBool(xElement.GetAttribute("ClosedFirstTry"), False)
        ClosedSecondTry = ConvertToBool(xElement.GetAttribute("ClosedSecondTry"), False)
        ClosedThirdTry = ConvertToBool(xElement.GetAttribute("ClosedThirdTry"), False)
        IncludesAttachment = ConvertToBool(xElement.GetAttribute("IncludesAttachment"), False)
        ReleaseDate = ConvertToDateFromXML(xElement.GetAttribute("ReleaseDate"), Date.MinValue)
        SubmitDate = ConvertToDateFromXML(xElement.GetAttribute("SubmitDate"), Date.MinValue)


        '-- Move outcomes to ClassGroup level (this is only used during the conversion process
        '   after conversion, xOutcomeList.Count will be 0 so nothing will happen
        Dim objOutcome As AssignmentOutcome
        Dim xOutcomeList As Xml.XmlNodeList = xElement.SelectNodes("Outcome")
        For Each xOutcome As Xml.XmlElement In xOutcomeList
            objOutcome = New AssignmentOutcome(xOutcome)
            Me.ClassGroup.Outcomes.Add(objOutcome)
            Me.Outcomes.Add(objOutcome)
        Next

        '-- Now, load the references (this will run only after a data file has been converted)
        Dim boolOutcomeMatchFound As Boolean
        xOutcomeList = xElement.SelectNodes("OutcomeRefs/OutcomeRef")
        For Each xOutcome As Xml.XmlElement In xOutcomeList
            Dim strOutcomeID As String = xOutcome.GetAttribute("BaseID")
            If strOutcomeID.Length > 0 Then
                boolOutcomeMatchFound = False
                For Each objOutcome In Me.ClassGroup.Outcomes
                    If objOutcome.ID = strOutcomeID Then
                        Me.Outcomes.Add(objOutcome)
                        boolOutcomeMatchFound = True
                        Exit For '-- we got our match, stop looking
                    End If
                Next
                If Not boolOutcomeMatchFound Then
                    '-- Somehow, the referenced outcome does not exist, notify user
                    Log("Outcome ID (" & strOutcomeID & ") not found in ClassGroup.", 5)
                End If
            Else
                Log("OutcomeRef found under ClassAssignment without ID.", 5)
            End If
        Next

    End Sub
    Public Sub RemoveOutcome(outcome As AssignmentOutcome)
        '-- will throw an error if the outcome is in use by any student
        For Each cls As SchoolClass In Me.ClassGroup.Classes
            For Each stud As Student In cls.Students
                For Each asmt In stud.AssignmentsBTEC
                    For Each oc As OutcomeResult In asmt.Outcomes
                        If oc.BaseOutcome.ID = outcome.ID Then
                            '-- This outcome is in use on some student's assignment, cannot be removed
                            Throw New Exception("Outcome is being used in student assignment and cannot be removed.")
                        End If
                    Next
                Next
            Next
        Next

        '-- If we get here, then we can remove the outcome
        Me.Outcomes.Remove(outcome)
    End Sub


End Class
Public Class OutcomeResult
    Implements IComparable(Of OutcomeResult)
    'Public Name As String
    'Public Description As String
    Public Assignment As StudentAssignmentBTEC '-- parent
    Public BaseOutcome As AssignmentOutcome
    Public FirstTryStatus As OutcomeResultStatusEnum
    Public FirstTryComments As String = String.Empty
    Public SecondTryStatus As OutcomeResultStatusEnum
    Public SecondTryComments As String = String.Empty
    Public ThirdTryStatus As OutcomeResultStatusEnum
    Public ThirdTryComments As String = String.Empty
    Public Function CompareTo(other As OutcomeResult) As Integer Implements System.IComparable(Of OutcomeResult).CompareTo
        '-- For 2.0 we need to enhance this to sort first by grade group, then by name
        If BaseOutcome.GradeGroup.CompareTo(other.BaseOutcome.GradeGroup) = 0 Then
            Return BaseOutcome.Name.CompareTo(other.BaseOutcome.Name)
        Else
            Return BaseOutcome.GradeGroup.CompareTo(other.BaseOutcome.GradeGroup)
        End If
    End Function
    Public Sub New(outcome As AssignmentOutcome, asmt As StudentAssignmentBTEC)
        BaseOutcome = outcome
        Assignment = asmt
    End Sub
    Public ReadOnly Property Name As String
        Get
            Return BaseOutcome.Name
        End Get
    End Property
    Public ReadOnly Property Description As String
        Get
            Return BaseOutcome.Description
        End Get
    End Property
    Private Function ConvertOutcomeResultForVersion2(currentResult As String) As String
        If currentResult = "Pass" Then
            Return "Achieved"
        ElseIf currentResult = "Fail" Then
            Return "NotAchieved"
        Else
            Return currentResult '-- must be unknown, Achieved, or NonAchieved
        End If
    End Function
    Public Sub New(xElement As Xml.XmlElement, assignment As ClassAssignmentBTEC, asmt As StudentAssignmentBTEC)
        Dim strBaseOutcomeID As String = xElement.GetAttribute("BaseOutcomeID")
        ' = 

        Me.Assignment = asmt

        For Each outcom As AssignmentOutcome In assignment.Outcomes
            If outcom.ID = strBaseOutcomeID Then
                BaseOutcome = outcom
                Exit For
            End If
        Next

        Dim strValue As String
        strValue = xElement.GetAttribute("FirstTryStatus")
        strValue = ConvertOutcomeResultForVersion2(strValue)
        FirstTryStatus = [Enum].Parse(GetType(OutcomeResultStatusEnum), strValue, True)
        FirstTryComments = xElement.GetAttribute("FirstTryComments")
        Me.BaseOutcome.AddStoredResults(FirstTryStatus, FirstTryComments)

        strValue = xElement.GetAttribute("SecondTryStatus")
        strValue = ConvertOutcomeResultForVersion2(strValue)
        SecondTryStatus = [Enum].Parse(GetType(OutcomeResultStatusEnum), strValue, True)
        SecondTryComments = xElement.GetAttribute("SecondTryComments")
        Me.BaseOutcome.AddStoredResults(SecondTryStatus, SecondTryComments)

        strValue = xElement.GetAttribute("ThirdTryStatus")
        strValue = ConvertOutcomeResultForVersion2(strValue)
        ThirdTryStatus = [Enum].Parse(GetType(OutcomeResultStatusEnum), strValue, True)
        ThirdTryComments = xElement.GetAttribute("ThirdTryComments")
        Me.BaseOutcome.AddStoredResults(ThirdTryStatus, ThirdTryComments)
    End Sub

    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Dim xAssignmentElement As Xml.XmlElement = xDoc.CreateElement("OutcomeResult")
        xAssignmentElement.SetAttribute("BaseOutcomeID", BaseOutcome.ID)
        xAssignmentElement.SetAttribute("FirstTryStatus", FirstTryStatus.ToString())
        xAssignmentElement.SetAttribute("FirstTryComments", FirstTryComments)
        xAssignmentElement.SetAttribute("SecondTryStatus", SecondTryStatus.ToString())
        xAssignmentElement.SetAttribute("SecondTryComments", SecondTryComments)
        xAssignmentElement.SetAttribute("ThirdTryStatus", ThirdTryStatus.ToString())
        xAssignmentElement.SetAttribute("ThirdTryComments", ThirdTryComments)

        Return xAssignmentElement

    End Function
End Class

Public Enum BTECGradeGroup
    Pass
    Merit
    Distinction
End Enum
Public Enum BTECGrade
    Referral
    Pass
    Merit
    Distinction
End Enum
'Public Class BTECGradingCriteria
'    Public ID As String
'    Public GradeGroup As BTECGradeGroup '-- Pass, etc.
'    Public Name As String '-- P1 - P9 or M1 - M9, etc.
'    Public Description As String '-- Explain how a small business can develop transnationally and determine the benefits and drawbacks

'    Public Overrides Function ToString() As String
'        Return Name & " - " & Description
'    End Function

'    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
'        Dim xOutcomeElement As Xml.XmlElement = xDoc.CreateElement("Outcome")
'        xOutcomeElement.SetAttribute("ID", ID)
'        xOutcomeElement.SetAttribute("Name", Name)
'        xOutcomeElement.SetAttribute("Description", Description)
'        Return xOutcomeElement
'    End Function
'    Public Sub New()
'        ID = Guid.NewGuid.ToString()
'    End Sub
'    Public Sub New(xElement As Xml.XmlElement)
'        ID = xElement.GetAttribute("ID")
'        If ID.Length = 0 Then
'            ID = Guid.NewGuid.ToString()
'        End If

'        Name = xElement.GetAttribute("Name")
'        Description = xElement.GetAttribute("Description")
'    End Sub
'End Class
Public Class AssignmentOutcome
    Implements IComparable(Of AssignmentOutcome)

    Public ID As String
    Public GradeGroup As BTECGradeGroup '-- Pass, Merit, etc.
    Public Name As String '-- RQF = P1 - P9 or M1 - M9, etc. ---- QCF = 1.1, 1.2, etc.
    Public Description As String
    Public Property StoredResults As New List(Of Result)
    Public Sub AddStoredResults(status As OutcomeResultStatusEnum, comments As String)
        '-- do not add duplicates
        Dim boolOKToAdd As Boolean = True
        comments = comments.Trim()

        If comments.Trim.Length = 0 Then
            Exit Sub
        End If

        For Each item As Result In StoredResults
            If item.Text.ToLower = comments.ToLower Then
                item.ItemCount += 1 '-- Keep track of how many times this result has been used
                boolOKToAdd = False
                Exit Sub
            End If
        Next

        If boolOKToAdd Then
            Dim rslt As New Result
            rslt.Text = comments
            rslt.Status = status
            rslt.ItemCount = 1
            StoredResults.Add(rslt)
        End If
    End Sub
    Public Sub RemoveStoredResults(comments As String)
        comments = comments.Trim()

        For Each item As Result In StoredResults
            If item.Text.ToLower() = comments.ToLower() Then
                If item.ItemCount > 1 Then
                    '-- decrement its usage count
                    item.ItemCount -= 1
                Else
                    '-- actually remove it from the list
                    StoredResults.Remove(item)
                End If
                Exit Sub
            End If
        Next
    End Sub
    Public Overrides Function ToString() As String
        Return Name & " - " & Description
    End Function

    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Dim xOutcomeElement As Xml.XmlElement = xDoc.CreateElement("Outcome")
        xOutcomeElement.SetAttribute("ID", ID)
        xOutcomeElement.SetAttribute("Name", Name)
        xOutcomeElement.SetAttribute("GradeGroup", GradeGroup)
        xOutcomeElement.SetAttribute("Description", Description)
        Return xOutcomeElement
    End Function
    Public Sub New(gradeGroup As BTECGradeGroup)
        ID = Guid.NewGuid.ToString()
        Me.GradeGroup = gradeGroup
        If Me.GradeGroup = BTECGradeGroup.Pass Then
            '-- Just add defaults for pass, not for higher levels
            AddDefaultStoredResults()
        End If
    End Sub
    Public Sub New(xElement As Xml.XmlElement)
        ID = xElement.GetAttribute("ID")
        If ID.Length = 0 Then
            ID = Guid.NewGuid.ToString()
        End If
        Try
            GradeGroup = [Enum].Parse(GetType(BTECGradeGroup), xElement.GetAttribute("GradeGroup"))
        Catch ex As Exception
            '-- Cannot match, default to pass
            GradeGroup = BTECGradeGroup.Pass
        End Try

        Name = xElement.GetAttribute("Name")
        Description = xElement.GetAttribute("Description")
        If GradeGroup = BTECGradeGroup.Pass Then
            '-- Just add defaults for pass, not for higher levels
            AddDefaultStoredResults()
        End If
    End Sub
    Private Sub AddDefaultStoredResults()
        Me.AddStoredResults(OutcomeResultStatusEnum.Achieved, AppSettings.ExamPassDefaultFeedback)
        Me.AddStoredResults(OutcomeResultStatusEnum.Achieved, AppSettings.ExamPassWeakDefaultFeedback)
        Me.AddStoredResults(OutcomeResultStatusEnum.NotAchieved, AppSettings.ExamFailDefaultFeedback)
        Me.AddStoredResults(OutcomeResultStatusEnum.NotAchieved, "Not submitted")
        Me.AddStoredResults(OutcomeResultStatusEnum.NotAchieved, "Plagiarized")
        Me.AddStoredResults(OutcomeResultStatusEnum.NotAchieved, "Plagiarized in other section")
    End Sub

    Public Function CompareTo(other As AssignmentOutcome) As Integer Implements IComparable(Of AssignmentOutcome).CompareTo

        If Me.GradeGroup = other.GradeGroup Then
            '-- So, M2 will be before M3 but after P3
            Return Me.Name.CompareTo(other.Name)
        Else
            '-- So Pass will be before Merit
            Return Me.GradeGroup.CompareTo(other.GradeGroup)
        End If
    End Function
End Class
Public Class Student
    Implements IComparable(Of Student)
    Public Enum GenderEnum
        Unknown
        Male
        Female
        Other
    End Enum
    ''' <summary>
    ''' Only works for Normal assignments (not BTEC)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AssessmentResultsOverallNumeric As Double
        Get
            Dim dblOverall As Double
            Dim intScore As Integer

            For Each asmt In Me.Assignments
                intScore = Math.Max(Math.Max(asmt.FirstTryPoints, asmt.SecondTryPoints), asmt.ThirdTryPoints) '-- get highest score of first 3 submissions

                dblOverall += (intScore / asmt.BaseAssignment.MaxPoints) * asmt.BaseAssignment.Weighting
            Next

            Return dblOverall
        End Get
    End Property
    Public ReadOnly Property AssessmentResultOverall As String
        Get
            '-- Some values
            '   D=BTEC distinction
            '   M=Merit
            '   P1=pass on first submit
            '   P2=pass on second submit
            '   P3=pass on third submit
            '   75% = could also be a percentage

            '-- We are assuming that there will be either BTEC or normal assignments, ==== not a combination of the two types for the same student ====

            If Me.AssignmentsBTEC.Count > 0 Then
                Dim rslt As StudentModuleResult = Me.ModuleResults(False)
                Return rslt.OverallGrade
            ElseIf Me.Assignments.Count > 0 Then
                Return AssessmentResultsOverallNumeric.ToString("#,##0%")
            Else
                '-- no assignments as all
                Return "n/a"
            End If
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return StudentID & " - " & Nickname & " - " & LocalName
    End Function

    Private Property m_schoolClass As SchoolClass
    Public Property SchoolClass As SchoolClass '-- parent
        Get
            Return m_schoolClass
        End Get
        Set(value As SchoolClass)
            If m_schoolClass IsNot Nothing AndAlso m_schoolClass IsNot value Then
                AddToActivityLog("Class changed from " & m_schoolClass.Name & " to " & value.Name & ".")
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "SchoolClass", m_schoolClass.Name)
            End If
            m_schoolClass = value
        End Set
    End Property
    Public Property TempTag As String = String.Empty '-- this is never persisted and is used for processing (for example, processing add/drop students)
    Private m_strLocalNameLatinLetters As String
    Private Sub SetLocalNameLatinLetters()
        If m_strLocalNameLatinLetters Is Nothing OrElse m_strLocalNameLatinLetters.Length = 0 AndAlso LocalName IsNot Nothing AndAlso LocalName.Length > 0 Then
            m_strLocalNameLatinLetters = RemoveAccents(LocalName).Replace("  ", " ") '-- remove extra spaces
        End If
    End Sub
    Public ReadOnly Property LocalNameLatinLetters As String
        Get
            SetLocalNameLatinLetters()

            Return m_strLocalNameLatinLetters
        End Get
    End Property
    Private m_strLocalName As String
    Public Property LocalName As String
        Get
            Return m_strLocalName
        End Get
        Set(value As String)
            If value <> m_strLocalName Then
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "LocalName", m_strLocalName)
                m_strLocalName = value

                '-- keep plain version in sync
                SetLocalNameLatinLetters()
            End If
        End Set
    End Property
    Private m_strNickname As String
    Public Property Nickname As String
        Get
            Return m_strNickname
        End Get
        Set(value As String)
            If value <> m_strNickname Then
                AddToActivityLog("Nickname changed from " & m_strNickname & " to " & value)
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "Nickname", m_strNickname)
            End If
            m_strNickname = value
        End Set
    End Property
    Private m_strStudentID As String
    Public Property StudentID As String
        Get
            Return m_strStudentID
        End Get
        Set(value As String)
            If value <> m_strStudentID Then
                AddToActivityLog("StudentID changed from " & m_strStudentID & " to " & value)
                HistoricalStudentData.AddHistoricalData(value, String.Empty, "StudentID", m_strStudentID)
            End If
            m_strStudentID = value
        End Set
    End Property
    Private m_strExtStudentID As String
    Public Property ExtStudentID As String '-- external (or extra, your choice)
        Get
            Return m_strExtStudentID
        End Get
        Set(value As String)
            If value <> m_strStudentID Then
                AddToActivityLog("ExtStudentID changed from " & m_strExtStudentID & " to " & value)
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "ExtStudentID", m_strExtStudentID)
            End If
            m_strExtStudentID = value
        End Set
    End Property
    Private m_intAdminNumber As Integer
    Public Property AdminNumber As Integer
        Get
            Return m_intAdminNumber
        End Get
        Set(value As Integer)
            If value <> m_intAdminNumber Then
                AddToActivityLog("AdminNumber changed from " & m_intAdminNumber & " to " & value)
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "AdminNumber", m_intAdminNumber)
            End If
            m_intAdminNumber = value
        End Set
    End Property
    Private m_intAltNumber As Integer
    Public Property AltNumber As Integer
        Get
            Return m_intAltNumber
        End Get
        Set(value As Integer)
            If value <> m_intAltNumber Then
                AddToActivityLog("AltNumber changed from " & m_intAltNumber & " to " & value)
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "AltNumber", m_intAltNumber)
            End If
            m_intAltNumber = value
        End Set
    End Property
    Private m_dtDateOfBirth As Date = DATE_NO_DATE '-- initiate to no_date
    Public Property DateOfBirth As Date
        Get
            Return m_dtDateOfBirth
        End Get
        Set(value As Date)
            If value <> m_dtDateOfBirth AndAlso m_dtDateOfBirth <> DATE_NO_DATE Then
                AddToActivityLog("DateOfBirth changed from " & m_dtDateOfBirth & " to " & value)
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "DateOfBirth", m_dtDateOfBirth.ToString(DATE_FORMAT_XML))
            End If
            m_dtDateOfBirth = value
        End Set
    End Property
    Public Property TeachingSessions As New List(Of TeachingSession)
    Public Property CurrentAttendenceStatus As AttendenceStatusEnum
    Private m_strStudentTeam As String = String.Empty
    Public Property StudentTeam As String
        Get
            Return m_strStudentTeam
        End Get
        Set(value As String)
            If value <> m_strStudentTeam Then
                AddToActivityLog("StudentTeam changed from " & m_strStudentTeam & " to " & value)
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "StudentTeam", m_strStudentTeam)
            End If
            m_strStudentTeam = value
        End Set
    End Property

    Private m_intMeritPoints As Integer
    Public Property MeritPoints As Integer
        Get
            Return m_intMeritPoints
        End Get
        Set(value As Integer)
            If value <> m_intMeritPoints Then
                AddToActivityLog("Merit points changed from " & m_intMeritPoints.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "MeritPoints", m_intMeritPoints.ToString())
            End If
            m_intMeritPoints = value
        End Set
    End Property
    Private m_gender As GenderEnum
    Public Property Gender As GenderEnum
        Get
            Return m_gender
        End Get
        Set(value As GenderEnum)
            If value <> m_intMeritPoints Then
                AddToActivityLog("Gender changed from " & m_gender.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "Gender", m_gender.ToString())
            End If
            m_gender = value
        End Set
    End Property
    Public Property Notes As String
    Public Property ActivityLog As String '-- Semester-specific notes
    Private m_boolHidden As Boolean
    Public Property Hidden As Boolean
        Get
            Return m_boolHidden
        End Get
        Set(value As Boolean)
            If value <> m_boolHidden Then
                AddToActivityLog("Hidden changed from " & m_boolHidden.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "Hidden", m_boolHidden.ToString())
            End If
            m_boolHidden = value
        End Set
    End Property
    Public Property AssignmentsBTEC As New List(Of StudentAssignmentBTEC)
    Public Property Assignments As New List(Of StudentAssignment)
    Public Property ImprovementItems As New List(Of StudentImprovementItem)

    Private m_intPresentationQuality As Integer
    Public Property PresentationQuality As Integer '-- presentation
        Get
            Return m_intPresentationQuality
        End Get
        Set(value As Integer)
            '-- we want to log every change in presentation quality so we can see progression over time
            If value <> m_intPresentationQuality Then
                AddToActivityLog("Changed presentation quality from " & m_intPresentationQuality.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "PresentationQuality", m_intPresentationQuality.ToString())
            End If
            m_intPresentationQuality = value
        End Set
    End Property
    Private m_intWritingQuality As Integer
    Public Property WritingQuality As Integer
        Get
            Return m_intWritingQuality
        End Get
        Set(value As Integer)
            If value <> m_intWritingQuality Then
                AddToActivityLog("Writing quality changed from " & m_intWritingQuality.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "WritingQuality", m_intWritingQuality.ToString())
            End If
            m_intWritingQuality = value
        End Set
    End Property
    Private Property m_strEmailAddress As String
    Private m_intStudentGroup As Integer
    Public Property StudentGroup As Integer '-- 0=no group, groups should be >0 (this is used in scheduling sclasses
        Get
            Return m_intStudentGroup
        End Get
        Set(value As Integer)
            If value <> m_intStudentGroup Then
                AddToActivityLog("Student group changed from " & m_intStudentGroup.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "StudentGroup", m_intStudentGroup.ToString())
            End If
            m_intStudentGroup = value
        End Set
    End Property
    Private m_intDraftsChecked As Integer
    Public Property DraftsChecked As Integer '-- to monitor which students had drafts checked
        Get
            Return m_intDraftsChecked
        End Get
        Set(value As Integer)
            If value <> m_intDraftsChecked Then
                AddToActivityLog("Drafts checked changed from " & m_intDraftsChecked.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "DraftsChecked", m_intDraftsChecked.ToString())
            End If
            m_intDraftsChecked = value
        End Set
    End Property
    Private m_intOfficeHoursVisited As Integer
    Public Property OfficeHoursVisited As Integer '-- to monitor how many times this student came for help
        Get
            Return m_intOfficeHoursVisited
        End Get
        Set(value As Integer)
            If value <> m_intOfficeHoursVisited Then
                AddToActivityLog("Office hours visited changed from " & m_intOfficeHoursVisited.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "OfficeHoursVisited", m_intOfficeHoursVisited.ToString())
            End If
            m_intOfficeHoursVisited = value
        End Set
    End Property
    Private m_intResearchQuality As Integer
    Public Property ResearchQuality As Integer
        Get
            Return m_intResearchQuality
        End Get
        Set(value As Integer)
            If value <> m_intResearchQuality Then
                AddToActivityLog("Research quality changed from " & m_intResearchQuality.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "ResearchQuality", m_intResearchQuality.ToString())
            End If
            m_intResearchQuality = value
        End Set
    End Property

    Public Property EmailAddress As String
        Get
            Return m_strEmailAddress
        End Get
        Set(value As String)
            If m_strEmailAddress IsNot Nothing Then
                If m_strEmailAddress.ToLower() <> value.ToLower() Then
                    '-- record change
                    AddToActivityLog("Changed email from: " & m_strEmailAddress & " to: " & value)
                    HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "EmailAddress", m_strEmailAddress)
                End If
            End If
            m_strEmailAddress = value
        End Set
    End Property

#Region " ReadOnly properties "
    Public ReadOnly Property AssignmentCount As Integer
        Get
            Dim intReturn As Integer
            intReturn += AssignmentsBTEC.Count
            intReturn += Assignments.Count

            Return intReturn
        End Get
    End Property
    Public ReadOnly Property ProcessedAssignments As Integer
        Get
            Dim intReturn As Integer
            For Each asmt As StudentAssignmentBTEC In AssignmentsBTEC
                If asmt.Processed Then
                    intReturn += 1
                End If
            Next
            For Each asmt As StudentAssignment In Assignments
                If asmt.Processed Then
                    intReturn += 1
                End If
            Next
            Return intReturn
        End Get
    End Property
    Public ReadOnly Property TotalAbsentPercent As Double
        Get
            Dim dblReturn As Double
            Dim intTotal As Integer = Me.TeachingSessions.Count
            Dim intAbsents As Integer = Me.TotalAbsences
            dblReturn = intAbsents / intTotal
            Return dblReturn
        End Get
    End Property
    Public ReadOnly Property CurrentAbsentPercent As Double
        Get
            Dim dblReturn As Double
            Dim intTotal As Integer
            For Each sess As TeachingSession In Me.TeachingSessions
                If sess.StartDate >= Me.SchoolClass.ClassGroup.StartDateCurrent AndAlso sess.StartDate <= Me.SchoolClass.ClassGroup.EndDateCurrent Then
                    intTotal += 1
                End If
            Next
            Dim intAbsents As Integer = Me.CurrentAbsences

            If intTotal = 0 Then
                dblReturn = 0
            Else
                dblReturn = intAbsents / intTotal
            End If
            Return dblReturn
        End Get
    End Property
#End Region

    Private m_strTags As String = String.Empty
    Public Property Tags As String
        Get
            Return m_strTags
        End Get
        Set(value As String)
            If value <> m_strTags Then
                AddToActivityLog("Tags changed from " & m_strTags & " to " & value)
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "Tags", m_strTags)
            End If
            m_strTags = value
        End Set
    End Property
    Public Property EmailedData As String '-- for emailing, supporting multiple dates
    Private m_intPlagiarismSeverity As Integer
    Public Property PlagiarismSeverity As Integer '-- 0=none, 5=check for five sequential works without palg to make zero.
        Get
            Return m_intPlagiarismSeverity
        End Get
        Set(value As Integer)
            If value <> m_intPlagiarismSeverity Then
                AddToActivityLog("Plagiarism severity changed from " & m_intPlagiarismSeverity.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "PlagiarismSeverity", m_intPlagiarismSeverity)
            End If
            m_intPlagiarismSeverity = value
        End Set
    End Property
    Private m_intPerformanceLastOnlineQuiz As Integer
    Public Property PerformanceLastOnlineQuiz As Integer
        Get
            Return m_intPerformanceLastOnlineQuiz
        End Get
        Set(value As Integer)
            If value <> m_intPerformanceLastOnlineQuiz Then
                AddToActivityLog("Performance on last online quiz changed from " & m_intPerformanceLastOnlineQuiz.ToString() & " to " & value.ToString())
                HistoricalStudentData.AddHistoricalData(Me.StudentID, String.Empty, "PerformanceLastOnlineQuiz", m_intPerformanceLastOnlineQuiz)
            End If
            m_intPerformanceLastOnlineQuiz = value
        End Set
    End Property
    ''' <summary>
    ''' Returns all outcomes (at all gradegroups) but no duplicates (not 2x M1), this data is not intended to be modifyable
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OutcomePerformance() As List(Of OutcomeResult)
        '-- used in studentDetail form
        Dim objReturn As New List(Of OutcomeResult)

        '-- First add all the module outcomes
        Dim objOutcomeResult As OutcomeResult
        For Each objAsmtOutcome As AssignmentOutcome In Me.SchoolClass.ClassGroup.Outcomes
            objOutcomeResult = New OutcomeResult(objAsmtOutcome, Nothing)
            objOutcomeResult.BaseOutcome = objAsmtOutcome

            objReturn.Add(objOutcomeResult)
        Next

        For Each asmt As StudentAssignmentBTEC In Me.AssignmentsBTEC
            '-- Now, check all the outcomes
            For Each objStudentOutcome As OutcomeResult In asmt.Outcomes
                '-- and match to what we added earlier
                For Each objOutcomeResult In objReturn
                    If objOutcomeResult.BaseOutcome.ID = objStudentOutcome.BaseOutcome.ID Then
                        '-- Found a matching student OutcomeResult with module outcome

                        '-- Now, we want to set the status for first, second, etc but favoring achievement
                        '   So we never set notachieved or unknown if achieved is already set
                        '   This is true for P, M, and D outcomes
                        '   So can go from unknown to Achieved or NonAchieved
                        '   Can go from NonAchieved to Achieved
                        '   No reason to change if already achieved
                        If objStudentOutcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                            objOutcomeResult.FirstTryStatus = OutcomeResultStatusEnum.Achieved
                            objOutcomeResult.FirstTryComments = objStudentOutcome.FirstTryComments
                        ElseIf objStudentOutcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved AndAlso objOutcomeResult.FirstTryStatus = OutcomeResultStatusEnum.Unknown Then
                            objOutcomeResult.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved
                            objOutcomeResult.FirstTryComments = objStudentOutcome.FirstTryComments
                        End If

                        If objStudentOutcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                            objOutcomeResult.SecondTryStatus = OutcomeResultStatusEnum.Achieved
                            objOutcomeResult.SecondTryComments = objStudentOutcome.SecondTryComments
                        ElseIf objStudentOutcome.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved AndAlso objOutcomeResult.SecondTryStatus = OutcomeResultStatusEnum.Unknown AndAlso objOutcomeResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            '-- Do not write NonAchieved for 2nd if 1st is already achieved
                            objOutcomeResult.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved
                            objOutcomeResult.SecondTryComments = objStudentOutcome.SecondTryComments
                        End If

                        If objStudentOutcome.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
                            objOutcomeResult.ThirdTryStatus = OutcomeResultStatusEnum.Achieved
                            objOutcomeResult.ThirdTryComments = objStudentOutcome.ThirdTryComments
                        ElseIf objStudentOutcome.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved AndAlso objOutcomeResult.ThirdTryStatus = OutcomeResultStatusEnum.Unknown AndAlso objOutcomeResult.FirstTryStatus <> OutcomeResultStatusEnum.Achieved AndAlso objOutcomeResult.SecondTryStatus <> OutcomeResultStatusEnum.Achieved Then
                            '-- Do not write NonAchieved for 3rd if 1st or 2nd is already achieved
                            objOutcomeResult.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved
                            objOutcomeResult.ThirdTryComments = objStudentOutcome.ThirdTryComments
                        End If

                    End If
                Next
            Next
        Next

        Return objReturn
    End Function
    ''' <summary>
    ''' Returns all outcomes on the module and the student results for that outcome (each outcome is included one time)
    ''' </summary>
    ''' <param name="includeUnprocessed">If false, assignments not marked as processed will be ignored</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ModuleResults(includeUnprocessed As Boolean) As StudentModuleResult
        Dim objReturn As New StudentModuleResult

        '-- First add all the module outcomes
        Dim objOutcomeResult As StudentModuleOutcomeResult
        For Each objAsmtOutcome As AssignmentOutcome In Me.SchoolClass.ClassGroup.Outcomes
            objOutcomeResult = New StudentModuleOutcomeResult()
            objOutcomeResult.Outcome = objAsmtOutcome
            objOutcomeResult.Status = OutcomeResultStatusEnum.NotAchieved '-- We don't know until we know and unknown = not achieved

            objReturn.Outcomes.Add(objOutcomeResult)
        Next

        '-- walk through each assignment and check off M's and D's
        For Each asmt As StudentAssignmentBTEC In Me.AssignmentsBTEC
            If includeUnprocessed OrElse asmt.Processed Then
                '-- only use processed assignment
                '   So if oral exam on an assignment which was never submitted, it will be completely ignored

                '-- Now, check all the outcomes
                For Each objStudentOutcome As OutcomeResult In asmt.Outcomes
                    '-- and match to what we added earlier
                    For Each objModuleOutcomeResult As StudentModuleOutcomeResult In objReturn.Outcomes
                        If objModuleOutcomeResult.Outcome.ID = objStudentOutcome.BaseOutcome.ID Then
                            '-- Found a matching student OutcomeResult

                            If objModuleOutcomeResult.Status <> OutcomeResultStatusEnum.Achieved Then
                                '-- We only consider if the outcome was not passed earlier (like on earlier assignment)
                                If objStudentOutcome.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
                                    '-- Yeah, student passed
                                    objModuleOutcomeResult.Status = OutcomeResultStatusEnum.Achieved
                                    objModuleOutcomeResult.LatestFeedback = objStudentOutcome.ThirdTryComments
                                ElseIf objStudentOutcome.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                                    '-- Yeah, student passed
                                    objModuleOutcomeResult.Status = OutcomeResultStatusEnum.Achieved
                                    objModuleOutcomeResult.LatestFeedback = objStudentOutcome.SecondTryComments
                                ElseIf objStudentOutcome.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                    '-- Yeah, student passed
                                    objModuleOutcomeResult.Status = OutcomeResultStatusEnum.Achieved
                                    objModuleOutcomeResult.LatestFeedback = objStudentOutcome.FirstTryComments



                                    '== At this point, student did not pass, so let's deal with failing feedback
                                    '-- Student fail somewhere
                                ElseIf objStudentOutcome.ThirdTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                    objModuleOutcomeResult.Status = OutcomeResultStatusEnum.NotAchieved
                                    objModuleOutcomeResult.LatestFeedback = objStudentOutcome.ThirdTryComments
                                ElseIf objStudentOutcome.SecondTryStatus = OutcomeResultStatusEnum.NotAchieved Then
                                    objModuleOutcomeResult.Status = OutcomeResultStatusEnum.NotAchieved
                                    objModuleOutcomeResult.LatestFeedback = objStudentOutcome.SecondTryComments
                                ElseIf objStudentOutcome.FirstTryStatus = OutcomeResultStatusEnum.NotAchieved Then

                                    '   Unknown means the student has not attempted the outcome yet
                                    objModuleOutcomeResult.Status = OutcomeResultStatusEnum.NotAchieved
                                    objModuleOutcomeResult.LatestFeedback = objStudentOutcome.FirstTryComments
                                ElseIf objModuleOutcomeResult.Status = OutcomeResultStatusEnum.NotAchieved Then
                                    '-- Did not achieve before (specifically not achieved, not unknown)
                                    '   so leave it and do nothing
                                    Application.DoEvents() '-- only for a breakpoint
                                Else
                                    '-- If we get here, actually this outcome never passed, never failed...so never submitted
                                    objModuleOutcomeResult.Status = OutcomeResultStatusEnum.Unknown
                                    objModuleOutcomeResult.LatestFeedback = AppSettings.NoSubmitFeedback
                                End If
                            End If
                        End If
                    Next
                Next
            End If
        Next

        objReturn.Outcomes.Sort()

        Return objReturn
    End Function
    Public Function AddAssignment(assignment As IClassAssignment) As IStudentAssignment
        Select Case assignment.AssignmentType
            Case AssignmentType.BTEC
                Dim asmt As New StudentAssignmentBTEC(CType(assignment, ClassAssignmentBTEC))
                AssignmentsBTEC.Add(asmt)
                Return asmt
            Case AssignmentType.Normal
                Dim asmt As New StudentAssignment(CType(assignment, ClassAssignment))
                Assignments.Add(asmt)
                Return asmt
        End Select
    End Function
    Public Property LatestAttendenceStatus As AttendenceStatusEnum
        Get
            If TeachingSessions.Count > 0 Then
                Return TeachingSessions(TeachingSessions.Count - 1).AttendenceStatus
            Else
                Return AttendenceStatusEnum.Unknown
            End If
        End Get
        Set(value As AttendenceStatusEnum)
            If TeachingSessions.Count > 0 Then
                TeachingSessions(TeachingSessions.Count - 1).AttendenceStatus = value
            Else
                Application.DoEvents() '-- just ignore
            End If
        End Set
    End Property
    Public ReadOnly Property Photo As Image
        Get
            If EmailAddress IsNot Nothing Then
                Dim strImagePath As String = System.IO.Path.Combine(GetImageFolder, EmailAddress.ToLower().ToLower) & ".jpg"
                If System.IO.File.Exists(strImagePath) Then
                    Try
                        Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(strImagePath)
                        Return img
                    Catch ex As Exception
                        Return Nothing
                    End Try
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If

        End Get
    End Property
    Public ReadOnly Property TotalAbsences As Decimal
        Get
            Dim decReturn As Decimal
            For Each session As TeachingSession In TeachingSessions
                Select Case session.AttendenceStatus
                    Case AttendenceStatusEnum.Absent
                        decReturn += 1
                    Case AttendenceStatusEnum.Late
                        decReturn += 0.5
                    Case AttendenceStatusEnum.Present
                        Application.DoEvents()
                    Case AttendenceStatusEnum.Removed
                        decReturn += 1
                    Case AttendenceStatusEnum.Unknown
                        decReturn += 1
                End Select
            Next
            Return decReturn
        End Get
    End Property
    Public ReadOnly Property TotalExcused As Decimal
        Get
            Dim decReturn As Decimal
            For Each session As TeachingSession In TeachingSessions
                Select Case session.AttendenceStatus
                    Case AttendenceStatusEnum.Excused
                        decReturn += 1
                End Select
            Next
            Return decReturn
        End Get
    End Property
    Public Sub AddToActivityLog(text As String)
        Me.ActivityLog &= Date.Now.ToString(DATE_TIME_FORMAT_DETAIL) & " " & text & Environment.NewLine()
    End Sub
    Public ReadOnly Property CurrentAbsences As Decimal
        Get
            Dim decReturn As Decimal
            For Each session As TeachingSession In TeachingSessions
                'If session.StartDate >= Me.SchoolClass.ClassGroup.Semester.StartDateCurrent AndAlso session.StartDate <= Me.SchoolClass.ClassGroup.Semester.EndDateCurrent Then
                If session.StartDate >= Me.SchoolClass.ClassGroup.StartDateCurrent AndAlso session.StartDate <= Me.SchoolClass.ClassGroup.EndDateCurrent Then
                    Select Case session.AttendenceStatus
                        Case AttendenceStatusEnum.Absent
                            decReturn += 1
                        Case AttendenceStatusEnum.Late
                            decReturn += 0.5
                        Case AttendenceStatusEnum.Present, AttendenceStatusEnum.Excused
                            Application.DoEvents()
                        Case AttendenceStatusEnum.Removed
                            decReturn += 1
                        Case AttendenceStatusEnum.Unknown
                            decReturn += 1
                    End Select
                End If
            Next
            Return decReturn
        End Get
    End Property
    ''' <summary>
    ''' Removes all assignments and other data which is semester-specific so student can be imported into a new semester/class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearStudentOfHistoricalData()
        Try
            AssignmentsBTEC.Clear()
            Assignments.Clear()
            TeachingSessions.Clear()
            Hidden = False
            EmailedData = String.Empty
            ActivityLog = String.Empty
            StudentGroup = 0
            DraftsChecked = 0
            OfficeHoursVisited = 0
            MeritPoints = 0
        Catch ex As Exception
            Log(ex)
            Throw ex
        End Try
    End Sub
    Public Function GetXMLElementToPersist(xDoc As Xml.XmlDocument) As Xml.XmlElement
        Try
            Dim xStudentElement As Xml.XmlElement = xDoc.CreateElement("Student")
            xStudentElement.SetAttribute("LocalName", LocalName)
            xStudentElement.SetAttribute("NickName", Nickname)
            xStudentElement.SetAttribute("StudentID", StudentID)
            xStudentElement.SetAttribute("ExtStudentID", ExtStudentID)
            xStudentElement.SetAttribute("AdminNumber", AdminNumber.ToString())
            xStudentElement.SetAttribute("AltNumber", AltNumber.ToString())
            xStudentElement.SetAttribute("MeritPoints", MeritPoints.ToString())
            xStudentElement.SetAttribute("Hidden", Hidden)
            xStudentElement.SetAttribute("OverallQuality", PresentationQuality.ToString())
            xStudentElement.SetAttribute("WritingQuality", WritingQuality.ToString())
            xStudentElement.SetAttribute("Notes", Notes)
            xStudentElement.SetAttribute("ActivityLog", ActivityLog)
            xStudentElement.SetAttribute("EmailAddress", EmailAddress)
            xStudentElement.SetAttribute("StudentGroup", StudentGroup.ToString())
            xStudentElement.SetAttribute("StudentTeam", StudentTeam)
            xStudentElement.SetAttribute("Tags", Tags)
            xStudentElement.SetAttribute("EmailedData", EmailedData)
            xStudentElement.SetAttribute("DraftsChecked", DraftsChecked.ToString())
            xStudentElement.SetAttribute("OfficeHoursVisited", OfficeHoursVisited.ToString())
            xStudentElement.SetAttribute("Gender", Gender)
            xStudentElement.SetAttribute("PlagiarismSeverity", PlagiarismSeverity.ToString())
            xStudentElement.SetAttribute("ResearchQuality", ResearchQuality.ToString())
            xStudentElement.SetAttribute("DateOfBirth", DateOfBirth.ToString(DATE_FORMAT_XML))
            xStudentElement.SetAttribute("PerformanceLastOnlineQuiz", PerformanceLastOnlineQuiz.ToString())


            TeachingSessions.Sort()
            For Each objSession As TeachingSession In TeachingSessions
                Dim xSessionElement As Xml.XmlElement = xDoc.CreateElement("Session")
                xSessionElement.SetAttribute("Date", objSession.StartDate.ToString(DATE_FORMAT_XML))
                xSessionElement.SetAttribute("Status", objSession.AttendenceStatus.ToString())
                xSessionElement.SetAttribute("Notes", objSession.Notes)
                xStudentElement.AppendChild(xSessionElement)
            Next

            'TODO: Sort assignments by Base.Name

            AssignmentsBTEC.Sort()
            For Each objAssignment As StudentAssignmentBTEC In AssignmentsBTEC
                xStudentElement.AppendChild(objAssignment.GetXMLElementToPersist(xDoc))
            Next

            Assignments.Sort()
            For Each objAssignment As StudentAssignment In Assignments
                xStudentElement.AppendChild(objAssignment.GetXMLElementToPersist(xDoc))
            Next

            Dim xItems As Xml.XmlElement = xDoc.CreateElement("StudentImprovementItems")
            Dim xItem As Xml.XmlElement
            For Each item As StudentImprovementItem In Me.ImprovementItems
                xItem = xDoc.CreateElement("StudentImprovementItem")
                xItem.SetAttribute("ID", item.BaseImprovementItem.ID)
                xItem.SetAttribute("DateAdded", item.DateAdded.ToString(DATE_FORMAT_XML))
                xItem.SetAttribute("DateLastIncluded", item.DateLastIncluded.ToString(DATE_FORMAT_XML))
                xItem.SetAttribute("PerformanceLevel", item.PerformanceLevel.ToString())
                xItems.AppendChild(xItem)
            Next
            xStudentElement.AppendChild(xItems)

            Return xStudentElement
        Catch ex As Exception
            Log(ex)
            Application.DoEvents()
        End Try

    End Function
    Public Sub New(schoolClass As SchoolClass)
        Me.SchoolClass = schoolClass
        AddToActivityLog("Student created.")
    End Sub
    ' ''' <summary>
    ' ''' Temp routine to clean up redundant text
    ' ''' </summary>
    ' ''' <param name="inputLog"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Private Function CleanActivityLog(inputLog As String) As String
    '    Try

    '        Dim sr As New System.IO.StringReader(inputLog)
    '        Dim sb As New System.Text.StringBuilder()
    '        Dim strThisLineFull As String
    '        Dim strPrevLineFull As String
    '        Dim strThisLineShort As String
    '        Dim strPrevLineShort As String = String.Empty
    '        strThisLineFull = sr.ReadLine()
    '        Do Until strThisLineFull Is Nothing
    '            strThisLineShort = strThisLineFull.Substring(17) '-- trim date/time
    '            If strPrevLineShort.Length > 0 Then
    '                If strThisLineShort.Equals(strPrevLineShort) Then
    '                    '-- do not append so this line will drop off
    '                Else
    '                    sb.AppendLine(strThisLineFull)
    '                End If
    '            Else
    '                sb.AppendLine(strThisLineFull)
    '            End If
    '            strPrevLineShort = strThisLineShort
    '            strPrevLineFull = strThisLineFull
    '            strThisLineFull = sr.ReadLine()
    '        Loop
    '        Return sb.ToString().Trim()
    '    Catch ex As Exception
    '        Application.DoEvents()
    '        Return String.Empty
    '    End Try

    'End Function
    Public Sub New(xElement As Xml.XmlElement, schoolClass As SchoolClass)
        Me.SchoolClass = schoolClass
        LocalName = xElement.GetAttribute("LocalName").Replace("  ", " ").Trim '-- remove extra spaces

        SetLocalNameLatinLetters()
        'LocalNameLatinLetters = RemoveAccents(LocalName).Replace("  ", " ") '-- remove extra spaces

        Nickname = xElement.GetAttribute("NickName").Replace("  ", " ").Trim '-- remove extra spaces
        ExtStudentID = xElement.GetAttribute("ExtStudentID").Trim
        AdminNumber = ConvertToInt32(xElement.GetAttribute("AdminNumber"), 0)
        AltNumber = ConvertToInt32(xElement.GetAttribute("AltNumber"), 0)
        StudentGroup = ConvertToInt32(xElement.GetAttribute("StudentGroup"), 0)
        StudentTeam = xElement.GetAttribute("StudentTeam")
        Tags = xElement.GetAttribute("Tags")
        EmailedData = xElement.GetAttribute("EmailedData")
        Dim strTemp As String = xElement.GetAttribute("Gender")
        Try
            Gender = [Enum].Parse(GetType(GenderEnum), strTemp, True)
        Catch ex As Exception
            Gender = GenderEnum.Unknown
        End Try

        Notes = xElement.GetAttribute("Notes")
        ActivityLog = xElement.GetAttribute("ActivityLog")

        '-- This next line is just used when data gets funky and duplicated (like "Drafts changed from 0 to 1" gets duplicated in activitylog).
        'ActivityLog = CleanActivityLog(ActivityLog)

        '-- These properties have changes tracked so we must write to the private variable 
        '   to avoid triggering change logic on every load
        m_strStudentID = xElement.GetAttribute("StudentID").Trim
        m_intDraftsChecked = ConvertToInt32(xElement.GetAttribute("DraftsChecked"), 0)
        m_intOfficeHoursVisited = ConvertToInt32(xElement.GetAttribute("OfficeHoursVisited"), 0)
        m_intResearchQuality = ConvertToInt32(xElement.GetAttribute("ResearchQuality"), 0)
        m_intMeritPoints = xElement.GetAttribute("MeritPoints")
        m_intPresentationQuality = ConvertToInt32(xElement.GetAttribute("OverallQuality"), 0)
        m_intWritingQuality = ConvertToInt32(xElement.GetAttribute("WritingQuality"), 0)
        m_boolHidden = ConvertToBool(xElement.GetAttribute("Hidden"), False)
        m_strEmailAddress = xElement.GetAttribute("EmailAddress")
        m_intPlagiarismSeverity = ConvertToInt32(xElement.GetAttribute("PlagiarismSeverity"), 0)
        m_intPerformanceLastOnlineQuiz = ConvertToInt32(xElement.GetAttribute("PerformanceLastOnlineQuiz"), 0)
        DateOfBirth = ConvertToDateFromXML(xElement.GetAttribute("DateOfBirth"), DATE_NO_DATE)



        Dim xSessionList As Xml.XmlNodeList = xElement.SelectNodes("Session")
        For Each xSessionNode As Xml.XmlElement In xSessionList
            Dim objSession As New TeachingSession(xSessionNode, Me)


            '== This block of logic is used when user takes attendance for the wrong module and 
            '   you need to manually move the attendence records between students in different modules.

            'Dim boolMoved As Boolean
            'boolMoved = False

            'If objSession.StartDate = #5/10/2013# AndAlso Me.SchoolClass.Name.Contains("F04B") Then
            '    Application.DoEvents()

            '    '-- find matching student from ethics and move session record to other student
            '    For Each grp As ClassGroup In Me.SchoolClass.ClassgGroup.Semester.ClassGroups
            '        For Each cls As SchoolClass In grp.Classes
            '            For Each stud As Student In cls.Students
            '                If stud.StudentID = Me.StudentID AndAlso stud IsNot Me Then
            '                    stud.TeachingSessions.Add(objSession)
            '                    boolMoved = True
            '                    Exit For
            '                End If
            '            Next
            '            If boolMoved Then
            '                Exit For
            '            End If
            '        Next
            '        If boolMoved Then
            '            Exit For
            '        End If
            '    Next
            'End If
            'If Not boolMoved Then
            TeachingSessions.Add(objSession)
            'End If
        Next


        Dim xItems As Xml.XmlNodeList = xElement.SelectNodes("StudentImprovementItems/StudentImprovementItem")
        Dim xItem As Xml.XmlElement
        Dim item As StudentImprovementItem
        '-- Add improvementitems for this student
        For Each xItem In xItems
            item = New StudentImprovementItem(Me)
            item.DateAdded = ConvertToDateFromXML(xItem.GetAttribute("DateAdded"), DATE_NO_DATE)
            '-- 24 Jan 2017 I am adding PerfLevel for improvementitems
            '   Note: This has to be done before assigning the baseimprovementitem or history logging will take place
            strTemp = xItem.GetAttribute("PerformanceLevel")
            item.DateLastIncluded = ConvertToDateFromXML(xItem.GetAttribute("DateLastIncluded"), DATE_NO_DATE)

            item.PerformanceLevel = ConvertToByte(strTemp, 3) '-- If the data has no perfLevel then we just start at 3 (wrong but not horrible)


            For Each baseItem As ImprovementItem In Me.SchoolClass.ClassGroup.Semester.ImprovementItems
                If baseItem.ID.ToUpper() = xItem.GetAttribute("ID").ToUpper() Then
                    item.BaseImprovementItem = baseItem
                    Exit For
                End If
            Next


            If item.BaseImprovementItem Is Nothing Then
                '-- the base item no longer exists, so remove from student
                Application.DoEvents() '-- do nothing
            Else
                Me.ImprovementItems.Add(item)
            End If

        Next

        Dim xAssignmentList As Xml.XmlNodeList = xElement.SelectNodes("StudentAssignment")
        For Each xAssignmentNode As Xml.XmlElement In xAssignmentList
            Dim objAssignment As New StudentAssignmentBTEC(xAssignmentNode, Me)
            If objAssignment.OverallComments.StartsWith("Imported ") Then
                Application.DoEvents()
            Else
                AssignmentsBTEC.Add(objAssignment)
            End If
            'Dim objAssignment As New StudentAssignment(xAssignmentNode, Me)
            'Assignments.Add(objAssignment)
        Next

        xAssignmentList = xElement.SelectNodes("StudentAssignmentNormal")
        For Each xAssignmentNode As Xml.XmlElement In xAssignmentList
            Dim objAssignment As New StudentAssignment(xAssignmentNode, Me)
            Assignments.Add(objAssignment)
        Next
    End Sub
    Public Class StudentModuleResult
        Public Function AchievedMerit() As Boolean
            Dim boolReturn As Boolean = True '-- assume true
            For Each oc As StudentModuleOutcomeResult In Me.Outcomes
                If oc.Outcome.GradeGroup = BTECGradeGroup.Pass OrElse oc.Outcome.GradeGroup = BTECGradeGroup.Merit Then
                    If Not oc.Status = OutcomeResultStatusEnum.Achieved Then
                        boolReturn = False '-- student failed at least one relevant outcome
                        Exit For
                    End If
                End If
            Next
            Return boolReturn
        End Function
        Public Function AchievedDistinction() As Boolean
            Dim boolReturn As Boolean = True '-- assume true
            For Each oc As StudentModuleOutcomeResult In Me.Outcomes
                If oc.Outcome.GradeGroup = BTECGradeGroup.Pass OrElse oc.Outcome.GradeGroup = BTECGradeGroup.Merit OrElse oc.Outcome.GradeGroup = BTECGradeGroup.Distinction Then
                    If Not oc.Status = OutcomeResultStatusEnum.Achieved Then
                        boolReturn = False '-- student failed at least one relevant outcome
                        Exit For
                    End If
                End If
            Next
            Return boolReturn
        End Function
        Public Function OverallGrade() As String
            Dim boolPass As Boolean = True
            Dim boolMerit As Boolean = True
            Dim boolDistinction As Boolean = True

            '-- Since these are MODULE results (not assignment), we do not need to check for presence 
            '   of P, M, D outcomes because we must have some of each (BTEC rule)
            For Each oc As StudentModuleOutcomeResult In Me.Outcomes
                Select Case oc.Outcome.GradeGroup
                    Case BTECGradeGroup.Distinction
                        If oc.Status = OutcomeResultStatusEnum.NotAchieved Then
                            boolDistinction = False
                        End If
                    Case BTECGradeGroup.Merit
                        If oc.Status = OutcomeResultStatusEnum.NotAchieved Then
                            boolMerit = False
                        End If
                    Case BTECGradeGroup.Pass
                        If oc.Status = OutcomeResultStatusEnum.NotAchieved Then
                            boolPass = False
                        End If
                End Select
            Next

            If boolPass Then
                If boolMerit Then
                    If boolDistinction Then
                        Return "D"
                    Else
                        Return "M"
                    End If
                Else
                    Return "P"
                End If
            Else
                Return "R"
            End If
        End Function

        'Public Property M1Achieved As Boolean
        'Public Property M2Achieved As Boolean
        'Public Property M3Achieved As Boolean
        'Public Property D1Achieved As Boolean
        'Public Property D2Achieved As Boolean
        'Public Property D3Achieved As Boolean
        Public Property Outcomes As New List(Of StudentModuleOutcomeResult)
        ''' <summary>
        ''' Returns the number of Pass outcomes passed
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PassOutcomesPassed() As Integer
            Dim intReturn As Integer
            For Each oc As StudentModuleOutcomeResult In Me.Outcomes
                If oc.Status = OutcomeResultStatusEnum.Achieved AndAlso oc.Outcome.GradeGroup = BTECGradeGroup.Pass Then
                    intReturn += 1
                End If
            Next
            Return intReturn
        End Function
    End Class
    Public Class StudentModuleOutcomeResult
        Implements IComparable(Of StudentModuleOutcomeResult)

        Public Property Outcome As AssignmentOutcome
        Public Property Status As OutcomeResultStatusEnum
        Public Property LatestFeedback As String
        Public Overrides Function ToString() As String
            Return Outcome.Name
        End Function
        Public Function CompareTo(other As StudentModuleOutcomeResult) As Integer Implements IComparable(Of StudentModuleOutcomeResult).CompareTo
            '-- Changing for 2.0 for BTEC RQF  --      Return Me.Outcome.Name.CompareTo(other.Outcome.Name)
            Dim strThisOne As String = ConvertToInt32(Me.Outcome.GradeGroup, 0).ToString() & Me.Outcome.Name
            Dim strTheOther As String = ConvertToInt32(other.Outcome.GradeGroup, 0).ToString() & other.Outcome.Name
            Return strThisOne.CompareTo(strTheOther)
        End Function
    End Class
    Public Class DetailAssignmentResults
        Public Property Outcomes As New List(Of OutcomeResult)
        Public Property M1Achieved As Boolean
        Public Property M2Achieved As Boolean
        Public Property M3Achieved As Boolean
        Public Property D1Achieved As Boolean
        Public Property D2Achieved As Boolean
        Public Property D3Achieved As Boolean
    End Class
    Public Class QuickAssignmentResults
        Public Property OutcomesPassed As Integer
        Public Property OutcomesIncluded As Integer
        Public Property M1Achieved As Boolean
        Public Property M2Achieved As Boolean
        Public Property M3Achieved As Boolean
        Public Property D1Achieved As Boolean
        Public Property D2Achieved As Boolean
        Public Property D3Achieved As Boolean
    End Class
    Friend Function GetDetailedAssignmentResults(attempt As MarkingTry) As DetailAssignmentResults
        Try
            Dim rtn As New DetailAssignmentResults()
            'For Each asmt As StudentAssignmentBTEC In Me.AssignmentsBTEC
            '    If asmt.M1Achieved Then
            '        rtn.M1Achieved = True
            '    End If
            '    If asmt.M2Achieved Then
            '        rtn.M2Achieved = True
            '    End If
            '    If asmt.M3Achieved Then
            '        rtn.M3Achieved = True
            '    End If
            '    If asmt.D1Achieved Then
            '        rtn.D1Achieved = True
            '    End If
            '    If asmt.D2Achieved Then
            '        rtn.D2Achieved = True
            '    End If
            '    If asmt.D3Achieved Then
            '        rtn.D3Achieved = True
            '    End If
            'Next

            Dim boolOutcomeAdded As Boolean

            '-- Now, get each outcome result
            '   we cannot skip any, even if they are not there
            For Each asmt As ClassAssignmentBTEC In Me.SchoolClass.ClassGroup.AssignmentsBTEC
                For Each oc As AssignmentOutcome In asmt.Outcomes
                    '-- Now we have the outcome, we must see if the student passed it or not
                    boolOutcomeAdded = False

                    For Each studAsmt As StudentAssignmentBTEC In AssignmentsBTEC
                        For Each ocRslt As OutcomeResult In studAsmt.Outcomes
                            If ocRslt.BaseOutcome Is oc Then
                                rtn.Outcomes.Add(ocRslt)
                                boolOutcomeAdded = True
                                Exit For
                            End If
                        Next

                        If boolOutcomeAdded Then
                            Exit For
                        End If

                    Next
                    If Not boolOutcomeAdded Then
                        '-- Student didn't submit, mark as unknown
                        Dim ocRslt As New OutcomeResult(oc, Nothing)
                        ocRslt.FirstTryStatus = OutcomeResultStatusEnum.Unknown
                        ocRslt.FirstTryComments = AppSettings.NoSubmitFeedback
                        ocRslt.SecondTryStatus = OutcomeResultStatusEnum.Unknown
                        ocRslt.SecondTryComments = AppSettings.NoSubmitFeedback
                        ocRslt.ThirdTryStatus = OutcomeResultStatusEnum.Unknown
                        ocRslt.ThirdTryComments = AppSettings.NoSubmitFeedback
                        rtn.Outcomes.Add(ocRslt)
                    End If
                Next
            Next


            Return rtn
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Friend Function GetQuickAssignmentResults(attempt As MarkingTry) As QuickAssignmentResults
        Dim rtn As New QuickAssignmentResults()
        For Each asmt As StudentAssignmentBTEC In Me.AssignmentsBTEC
            'If asmt.M1Achieved Then
            '    rtn.M1Achieved = True
            'End If
            'If asmt.M2Achieved Then
            '    rtn.M2Achieved = True
            'End If
            'If asmt.M3Achieved Then
            '    rtn.M3Achieved = True
            'End If
            'If asmt.D1Achieved Then
            '    rtn.D1Achieved = True
            'End If
            'If asmt.D2Achieved Then
            '    rtn.D2Achieved = True
            'End If
            'If asmt.D3Achieved Then
            '    rtn.D3Achieved = True
            'End If
            For Each rslt As OutcomeResult In asmt.Outcomes
                If rslt.BaseOutcome.GradeGroup = BTECGradeGroup.Pass Then
                    rtn.OutcomesIncluded += 1
                    Select Case attempt
                        Case MarkingTry.FirstTry
                            If rslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved Then
                                rtn.OutcomesPassed += 1
                            End If
                        Case MarkingTry.SecondTry
                            If rslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse rslt.SecondTryStatus = OutcomeResultStatusEnum.Achieved Then
                                rtn.OutcomesPassed += 1
                            End If
                        Case MarkingTry.ThirdTry
                            If rslt.FirstTryStatus = OutcomeResultStatusEnum.Achieved OrElse rslt.SecondTryStatus = OutcomeResultStatusEnum.Achieved OrElse rslt.ThirdTryStatus = OutcomeResultStatusEnum.Achieved Then
                                rtn.OutcomesPassed += 1
                            End If
                    End Select
                End If
            Next
        Next

        Return rtn
    End Function

    Public Function CompareTo(other As Student) As Integer Implements System.IComparable(Of Student).CompareTo
        Return Me.AdminNumber.CompareTo(other.AdminNumber)
    End Function
    Public Class CompareOnStudentID
        Implements IComparer(Of Student)
        Public Function Compare(x As Student, y As Student) As Integer Implements IComparer(Of Student).Compare
            Return x.StudentID.CompareTo(y.StudentID)
        End Function
    End Class
End Class

Public Class TeachingSession
    Implements IComparable(Of TeachingSession)

    Public Property StartDate As Date
    Public Property AttendenceStatus As AttendenceStatusEnum
    Public Property Notes As String
    Public Property Student As Student

    Public Sub New(student As Student)
        Me.Student = student

    End Sub
    Public Sub New(xElement As Xml.XmlElement, student As Student)
        StartDate = Xml.XmlConvert.ToDateTime(xElement.GetAttribute("Date"), Xml.XmlDateTimeSerializationMode.Unspecified)

        Dim strValue As String = xElement.GetAttribute("Status")
        AttendenceStatus = [Enum].Parse(GetType(AttendenceStatusEnum), strValue, True)

        Notes = xElement.GetAttribute("Notes")
        Me.Student = student

    End Sub

    Public Function CompareTo(other As TeachingSession) As Integer Implements System.IComparable(Of TeachingSession).CompareTo
        Return StartDate.CompareTo(other.StartDate)
    End Function
End Class

Public Class ClassSession
    Implements IComparable(Of ClassSession)

    Public Property StartDate As Date
    Public Property StudentGroup As Integer

    Public Overrides Function ToString() As String
        Return Me.StartDate
    End Function
    Public Sub New()

    End Sub
    Public Sub New(xElement As Xml.XmlElement)
        StartDate = Xml.XmlConvert.ToDateTime(xElement.GetAttribute("Date"), Xml.XmlDateTimeSerializationMode.Unspecified)
        StudentGroup = ConvertToInt32(xElement.GetAttribute("StudentGroup"), 0)
    End Sub

    Public Function CompareTo(other As ClassSession) As Integer Implements System.IComparable(Of ClassSession).CompareTo
        '-- first sort by start date, then by student group
        If StartDate.Equals(other.StartDate) Then
            Return StudentGroup.CompareTo(other.StudentGroup)
        Else
            Return StartDate.CompareTo(other.StartDate)
        End If
    End Function
End Class

Public Enum AttendenceStatusEnum
    Unknown
    Present
    Absent
    Removed
    Late
    Excused
End Enum
Public Enum OutcomeResultStatusEnum
    Unknown
    Achieved
    NotAchieved
End Enum
Public Class Result
    Public Property Text As String
    Public Property Status As OutcomeResultStatusEnum
    Public Property ItemCount As Integer
End Class
Public Class ImprovementItem '-- This is the master list of what counts as an improvement item (for the semester)
    Public Property ID As String = Guid.NewGuid.ToString()
    Public Property Name As String
    Public Property Description As String
End Class
Public Class StudentImprovementItem '-- This is for the student and references the base item
    Public Sub New(student As Student)
        Me.Student = student
        DateAdded = DATE_NO_DATE
        DateLastIncluded = DATE_NO_DATE
    End Sub
    Public Property Student As Student
    Public Property BaseImprovementItem As ImprovementItem
    Public Property DateAdded As Date
    Public Property DateLastIncluded As Date
    Public Overrides Function ToString() As String
        If BaseImprovementItem IsNot Nothing Then
            Return BaseImprovementItem.Name & " (" & BaseImprovementItem.ID & ")"
        Else
            Return "Undefined improvement item"
        End If
        Return MyBase.ToString()
    End Function
    ''' <summary>
    ''' Sets the DateLastIncluded to now and also adds to student's activity log
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub IncludeToday()
        DateLastIncluded = Date.Now
        Student.AddToActivityLog("Improvement item included: " & Me.ToString())
    End Sub

    Private m_bytPerformanceLevel As Integer
    '0=Not evaluated
    '1=Completely unacceptable
    '2=Very weak, incorrect very often
    '3=Sometimes ok but inconsistent
    '4=Good but still room for improvement
    '5=Completely correct
    Public Property PerformanceLevel As Integer
        Get
            Return m_bytPerformanceLevel
        End Get
        Set(value As Integer)
            If value > 5 Then
                value = 5 '-- cannot be above 5, 5 represents completely correct (could 6=innovative, or is innovation a new skill?)
            ElseIf value < 0 Then
                value = 0 '-- cannot be neg
            End If
            If BaseImprovementItem IsNot Nothing AndAlso value <> m_bytPerformanceLevel Then '-- make sure we are fully initialized
                '-- Log change
                Dim strExtra As String
                If DateAdded = DATE_NO_DATE Then
                    strExtra = " (but item was never added to student)"
                Else
                    strExtra = String.Empty
                End If
                Me.Student.AddToActivityLog("Improvement item: " & BaseImprovementItem.Name & " performance level changed from " & m_bytPerformanceLevel.ToString() & " to " & value.ToString() & strExtra)
                HistoricalStudentData.AddHistoricalData(Me.Student.StudentID, BaseImprovementItem.ID, BaseImprovementItem.Name, m_bytPerformanceLevel.ToString())
            End If
            m_bytPerformanceLevel = value
        End Set
    End Property
End Class

Public Class EmailRecipient
    Public Property Name As String
    Public Property EmailAddress As String
    Public Sub New(name As String, emailAddress As String)
        Me.Name = name
        Me.EmailAddress = emailAddress
    End Sub
End Class
