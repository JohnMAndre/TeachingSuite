Imports System.Runtime.CompilerServices

Module Globals

    '== Constants
#If SUPPORT_ZIP Then
    Public Const DATA_FILE_EXTENSION As String = ".datx"
#Else
    Public Const DATA_FILE_EXTENSION As String = ".dat"
#End If

    Public Const DATA_FILE_AUTOSAVE_EXTENSION As String = ".autosave"
    Public Const DATA_FILE_REPLACED_EXTENSION As String = ".replaced" '-- replaced by autosave recovery (can delete this file)
    Public Const DATA_FILE_CONTENTS_NAME As String = "data"
    Public Const DATE_FORMAT_XML As String = "yyyy-MM-dd"
    Public Const TIME_FORMAT_XML As String = "HH:mm"
    Public Const DATE_TIME_FORMAT_XML As String = "yyyy-MM-ddTHH:mm:00"
    Public Const DATE_TIME_DETAILED_FORMAT_XML As String = "yyyy-MM-ddTHH:mm:ss"
    Public Const DATE_TIME_FORMAT_DETAIL As String = "yyyy-MM-dd HH:mm"
    Public Const DATE_TIME_FORMAT_FILENAME As String = "yyyy-MM-dd HH-mm-ss"
    Public DATE_NO_DATE As Date = New Date(2010, 1, 1)
    Public Const COMBINED_VIEW_NAME As String = "Combined View"


    '== Global vars
    Public ThisSemester As Semester '-- current data set
    Public AppSettings As ApplicationSettings
    Public MainFormReference As IMainForm




    Public Const DUMMY_SEMESTER_NAME As String = "dummy"

    Friend Delegate Sub NoParameterCallback()


    ''' <summary>
    ''' Takes in an email address, spits back a hash
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetUgradeCode(input As String) As String
        Dim email As String = input.ToLower()
        Dim md5 As System.Security.Cryptography.MD5 = System.Security.Cryptography.MD5.Create()
        Dim hash() As Byte = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input.ToLower()))
        Dim strReturn As String = Convert.ToBase64String(hash)
        Return strReturn
    End Function



    Public Function GetImageFolder() As String
        Dim strFolder As String = System.IO.Path.Combine(GetDataFolder(), "Photos")
        If Not System.IO.Directory.Exists(strFolder) Then
            System.IO.Directory.CreateDirectory(strFolder)
        End If
        Return strFolder
    End Function
    Public Function GetModuleDataFolder() As String
        Dim strFolder As String = System.IO.Path.Combine(GetDataFolder(), "ModuleData")
        If Not System.IO.Directory.Exists(strFolder) Then
            System.IO.Directory.CreateDirectory(strFolder)
        End If
        Return strFolder
    End Function
    Public Function GetBackupFolder() As String
        Dim strFolder As String = System.IO.Path.Combine(GetDataFolder(), "Backup")
        If Not System.IO.Directory.Exists(strFolder) Then
            System.IO.Directory.CreateDirectory(strFolder)
        End If
        Return strFolder
    End Function
    Public Function GetMarkingFolder() As String
        Return System.IO.Path.Combine(GetDataFolder, "Marking\")
    End Function
    Public Function GetQuizResultsFolder() As String
        Dim strPath As String = System.IO.Path.Combine(GetDataFolder, "QuizResults\")

        If Not System.IO.Directory.Exists(strPath) Then
            System.IO.Directory.CreateDirectory(strPath)
        End If

        Return strPath
    End Function
    Public Function GetDataFolder() As String
        Const SETTINGS_FOLDER As String = "Data"
        Dim di As New System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(Application.ExecutablePath))
        di = di.Parent
        Dim strPath As String = di.FullName
        If Not strPath.EndsWith("\") Then
            strPath &= "\"
        End If
        strPath &= SETTINGS_FOLDER

        If Not System.IO.Directory.Exists(strPath) Then
            System.IO.Directory.CreateDirectory(strPath)
        End If

        Return strPath
    End Function
    Public Function GetDictionaryFilename() As String
        '-- for spell checking
        Dim di As New System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(Application.ExecutablePath))
        Dim strPath As String = di.FullName
        If Not strPath.EndsWith("\") Then
            strPath &= "\"
        End If
        strPath &= AppSettings.DictionaryName '"English (US).dct"

        Return strPath
    End Function

    '== Global routines
    Friend Function GetInput(ByVal message As String, ByVal isPassword As Boolean, Optional ByVal defaultText As String = "") As String
        Dim frm As New InputBox(message, isPassword)
        frm.Input = defaultText
        If frm.ShowDialog() = DialogResult.OK Then
            Return frm.Input
        Else
            Return Chr(0)
        End If

    End Function


    Private Function GetHistoryLocation() As String
        Dim strHistoryFilename As String = System.IO.Path.GetFileNameWithoutExtension(ThisSemester.DataFilename) & ".History.txt"
        Return System.IO.Path.Combine(GetDataFolder(), strHistoryFilename)
    End Function
    Public Sub AddApplicationHistory(text As String)
        Try
            If ThisSemester Is Nothing Then
                '-- ignore, there is no semester to worry about
            Else
                Dim strSemester As String
                If ThisSemester Is Nothing Then
                    strSemester = "No semester loaded"
                Else
                    strSemester = ThisSemester.Name
                End If

                '-- We want to pre-pend the new entry (so newest always at the top - it's for syncing anyway)
                If System.IO.File.Exists(GetHistoryLocation()) Then
                    Dim strPreviousLogContents As String
                    strPreviousLogContents = System.IO.File.ReadAllText(GetHistoryLocation())
                    If strPreviousLogContents.Length > AppSettings.ApplicationHistoryMaxFileSize Then '-- we want to keep the log file small
                        strPreviousLogContents = strPreviousLogContents.Substring(0, AppSettings.ApplicationHistoryMaxFileSize - 200)
                    End If
                    System.IO.File.Delete(GetHistoryLocation())
                    System.IO.File.AppendAllText(GetHistoryLocation(), Date.Now.ToString("yyyy-MM-dd HH:mm") & " " & text & " [Semester: " & strSemester & "]." & Environment.NewLine)
                    System.IO.File.AppendAllText(GetHistoryLocation(), strPreviousLogContents)
                Else
                    '-- No history file, so just create it now
                    Log("Creating history file: " & GetHistoryLocation(), 5)
                    System.IO.File.AppendAllText(GetHistoryLocation(), Date.Now.ToString("yyyy-MM-dd HH:mm") & " " & text & " [Semester: " & strSemester & "]." & Environment.NewLine)
                End If
            End If
        Catch ex As Exception
            Log(ex) '-- Log and continue
        End Try
    End Sub

    Private Function GetErrorLogLocation() As String
        Const LOG_FILENAME As String = "Log.txt"
        Return System.IO.Path.Combine(GetDataFolder(), LOG_FILENAME)
    End Function
    Public Sub Log(ex As Exception)
        Try
            System.IO.File.AppendAllText(GetErrorLogLocation(), Date.Now.ToString("yyyy-MM-dd") & " " & ex.Message & Environment.NewLine)
        Catch ex1 As Exception
            MessageBox.Show("There was an error writing to the log file. Error: " & ex1.Message, Application.ProductName)
        End Try
    End Sub
    ''' <summary>
    ''' Add text to local log file
    ''' </summary>
    ''' <param name="text">The text to add to the log file</param>
    ''' <param name="level">The minimum logging level (lower = less chance to log this entry)</param>
    ''' <remarks></remarks>
    Public Sub Log(text As String, level As Integer)
        If AppSettings Is Nothing Then
            '-- Must be a problem in AppSettings
            System.IO.File.AppendAllText(GetErrorLogLocation(), Date.Now.ToString("yyyy-MM-dd") & " " & text & Environment.NewLine)
        Else
            If level >= AppSettings.LoggingThreshold Then
                System.IO.File.AppendAllText(GetErrorLogLocation(), Date.Now.ToString("yyyy-MM-dd") & " " & text & Environment.NewLine)
            Else
                '-- do nothing
            End If
        End If
    End Sub
    Public Sub ShowErrorLog()
        Try
            If System.IO.File.Exists(GetErrorLogLocation()) Then
                System.Diagnostics.Process.Start(GetErrorLogLocation())
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error opening the log file. Error: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function RemoveDoubleSpaces(original As String) As String

        Dim strToReturn As String = original
        Do Until strToReturn.IndexOf("  ") < 0
            strToReturn = strToReturn.Replace("  ", " ")
        Loop

        Return strToReturn
    End Function

    Public Function ClassIsCombinedView(objClass As SchoolClass) As Boolean
        Try
            If objClass IsNot Nothing Then
                Return objClass.Students.Count = 0 AndAlso objClass.Name = COMBINED_VIEW_NAME
            Else
                Return False
            End If
        Catch ex As Exception
            Log(ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Returns size formatted in KB, MB, or GB as appropriate
    ''' </summary>
    ''' <param name="TotalBytes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function FormatDataSizeString(ByVal TotalBytes As Long) As String
        Dim KB As Long = 1024
        Dim MB As Long = Convert.ToInt64(1024 ^ 2)
        Dim GB As Long = Convert.ToInt64(1024 ^ 3)
        Dim dbl As Double

        '-- compare to 90%
        Select Case TotalBytes
            Case Is >= GB * 0.9
                dbl = TotalBytes / GB
                If dbl >= 100 Then
                    Return dbl.ToString("#,##0 GB")
                Else
                    Return dbl.ToString("#,##0.# GB")
                End If
            Case Is >= MB * 0.9
                dbl = TotalBytes / MB
                If dbl >= 100 Then
                    Return dbl.ToString("#,##0 MB")
                Else
                    Return dbl.ToString("#,##0.# MB")
                End If
            Case Is >= KB * 0.9
                dbl = TotalBytes / KB
                If dbl >= 100 Then
                    Return dbl.ToString("#,##0 KB")
                Else
                    Return dbl.ToString("#,##0.# KB")
                End If
            Case Else
                Return TotalBytes.ToString("#,##0 B")
        End Select
    End Function
#Region " ObjectListView Helpers "
    Friend Sub AutoSizeColumn(ByVal col As ColumnHeader, Optional ByVal SkipHeaderSize As Boolean = False)
        If SkipHeaderSize Then
            col.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        Else
            col.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
            Dim intWidth As Integer = col.Width
            col.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)

            If intWidth > col.Width Then
                col.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
            End If
        End If
    End Sub
    Friend Delegate Sub AutoSizeColumnsCallback(ByVal lv As ListView)
    Friend Sub AutoSizeColumns(ByVal lv As ListView)
        If lv.InvokeRequired Then
            Dim deleg As New AutoSizeColumnsCallback(AddressOf AutoSizeColumns)
            lv.Invoke(deleg, lv)
        Else
            For Each col As ColumnHeader In lv.Columns
                AutoSizeColumn(col)
            Next
        End If
    End Sub
#End Region

    ''' <summary>
    ''' Changes illegal characters (e.g., ":" or "?") into spaces
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function MakeFilenameLegal(ByVal filename As String) As String
        Dim strBadChars() As String = {"\", "/", ":", "*", "?", """", "<", ">", "|", vbCr, vbLf}
        Dim sb As New System.Text.StringBuilder(filename)
        For Each character As String In strBadChars
            sb.Replace(character, " ")
        Next
        Return sb.ToString()
    End Function

    Friend Class ExportClassData
        Public SchoolClass As SchoolClass
        Public Filename As String
    End Class
    ''' <summary>
    ''' Centralized routine for reading back zipped (or not) xml data file
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LoadXMLDataFromFile(filename As String) As Xml.XmlDocument
#If SUPPORT_ZIP Then
        Dim strContents As String
        Dim xDoc As New Xml.XmlDocument

        Using zip As New Ionic.Zip.ZipFile(filename)
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
        xDoc.Load(filename)
#End If

        Return xDoc
    End Function
    ''' <summary>
    ''' Centralized routine to make sure a consistent save and zipping format is used throughout
    ''' </summary>
    ''' <param name="xDoc">XMLDocument to save</param>
    ''' <param name="filename">Destination filename</param>
    ''' <param name="zipFile">False if you want to save as xml, true if you want to compress as a zip file</param>
    ''' <remarks></remarks>
    Public Sub SaveXMLData(xDoc As Xml.XmlDocument, filename As String, zipFile As Boolean)
        If zipFile Then
            Dim byteArray() As Byte = System.Text.Encoding.Unicode.GetBytes(xDoc.OuterXml())
            Using zip As New Ionic.Zip.ZipFile()
                zip.AddEntry(DATA_FILE_CONTENTS_NAME, byteArray)
                zip.Save(filename)
            End Using
        Else
            xDoc.Save(filename)
        End If
    End Sub
    Public Function GetRowsFromSpreadsheetClipboardData(data As String) As String()
        Dim strRows() As String

        '-- Under Ubuntu, WPS spreadsheet gives chr(13) chr(13) chr(10) for a new line
        '   This correction should not impact window machines since they will never have chr(13) chr(13) together
        Dim strHolding As String = data.Replace(Chr(13) & Chr(13), Chr(13))

        strRows = strHolding.Split(Environment.NewLine)

        Return strRows
    End Function
    Public Function GetSpacePaddedString(text As String, totalLength As Integer) As String
        Dim intSpaces As Integer = totalLength - text.Length
        If intSpaces <= 0 Then
            Return text
        Else
            For intCounter As Integer = 1 To intSpaces
                text &= " "
            Next
        End If

        Return text
    End Function

    ''' <summary>
    ''' Randomizes the contents of the list using Fisher–Yates shuffle (a.k.a. Knuth shuffle).
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns>Randomized result</returns>
    ''' <remarks></remarks>
    <Extension()>
    Function RandomizeOrder(Of T)(ByVal list As List(Of T)) As List(Of T)
        Dim rand As New Random()
        Dim temp As T
        Dim indexRand As Integer
        Dim indexLast As Integer = list.Count - 1
        For index As Integer = 0 To indexLast
            indexRand = rand.Next(index, indexLast)
            temp = list(indexRand)
            list(indexRand) = list(index)
            list(index) = temp
        Next index
        Return list
    End Function

    Public Function GetAssignmentBTECGrade(asmt As StudentAssignmentBTEC) As BTECGrade
        '-- Logic: If asmt has any D outcomes then consider D, if asmt has any M outcomes then consider M
        '          if any P outcome not achieved, then referral.
        '          if all P achieved achieved then if all M achieved then if all D achieved then D else M else P

        Dim boolHasD, boolHasM As Boolean
        Dim boolFailAnyD, boolFailAnyM, boolFailAnyP As Boolean

        For Each oc As OutcomeResult In asmt.Outcomes
            Select Case oc.BaseOutcome.GradeGroup
                Case BTECGradeGroup.Distinction
                    boolHasD = True
                    boolFailAnyD = oc.FirstTryStatus <> OutcomeResultStatusEnum.Achieved
                Case BTECGradeGroup.Merit
                    boolHasM = True
                    boolFailAnyM = oc.FirstTryStatus <> OutcomeResultStatusEnum.Achieved
                Case BTECGradeGroup.Pass
                    boolFailAnyP = oc.FirstTryStatus <> OutcomeResultStatusEnum.Achieved
            End Select
        Next

        If boolHasD AndAlso Not boolFailAnyP AndAlso Not boolFailAnyM AndAlso Not boolFailAnyD Then
            Return BTECGrade.Distinction
        ElseIf boolHasM AndAlso Not boolFailAnyP AndAlso Not boolFailAnyM Then
            Return BTECGrade.Merit
        ElseIf Not boolFailAnyP Then
            Return BTECGrade.Pass
        Else
            Return BTECGrade.Referral
        End If
    End Function
    Public Function GetAssignmentNormalGrade(asmt As StudentAssignment) As Integer
        Return asmt.FirstTryPoints
    End Function
End Module

