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
    Public Const DATE_TIME_FORMAT_DETAIL As String = "yyyy-MM-dd HH:mm"
    Public Const DATE_TIME_FORMAT_FILENAME As String = "yyyy-MM-dd HH-mm-ss"
    Public DATE_NO_DATE As Date = New Date(2010, 1, 1)
    Public Const COMBINED_VIEW_NAME As String = "Combined View"


    '== Global vars
    Public ThisSemester As Semester '-- current data set
    Public AppSettings As ApplicationSettings
    Public MainFormReference As MainForm

    Public Enum MarkingTry
        FirstTry
        SecondTry
        ThirdTry
    End Enum

   
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
        strPath &= "English (US).dct"

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
    Public Sub Log(text As String, level As Integer)
        If level >= AppSettings.LoggingThreshold Then
            System.IO.File.AppendAllText(GetErrorLogLocation(), Date.Now.ToString("yyyy-MM-dd") & " " & text & Environment.NewLine)
        Else
            '-- do nothing
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
End Module
