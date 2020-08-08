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
Imports System.Runtime.InteropServices

Namespace MyDuplexSettings
    Public Class DuplexSettings

#Region "Win32 API Declaration"

        <DllImport("kernel32.dll", EntryPoint:="GetLastError", _
               SetLastError:=False, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
               Public Shared Function GetLastError() As Int32
        End Function


        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, _
        ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function


        <DllImport("winspool.Drv", EntryPoint:="DocumentPropertiesA", SetLastError:=True, _
        ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function DocumentProperties(ByVal hwnd As IntPtr, ByVal hPrinter As IntPtr, _
        <MarshalAs(UnmanagedType.LPStr)> ByVal pDeviceNameg As String, _
        ByVal pDevModeOutput As IntPtr, ByVal pDevModeInput As IntPtr, ByVal fMode As Integer) As Integer
        End Function


        <DllImport("winspool.Drv", EntryPoint:="GetPrinterA", SetLastError:=True, _
        ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function GetPrinter(ByVal hPrinter As IntPtr, ByVal dwLevel As Int32, _
        ByVal pPrinter As IntPtr, ByVal dwBuf As Int32, ByRef dwNeeded As Int32) As Boolean
        End Function


        Declare Function OpenPrinter Lib "winspool.drv" Alias "OpenPrinterA" _
        (ByVal pPrinterName As String, ByRef phPrinter As IntPtr, ByRef pDefault As PRINTER_DEFAULTS) As Integer


        <DllImport("winspool.Drv", EntryPoint:="SetPrinterA", ExactSpelling:=True, SetLastError:=True)> _
        Public Shared Function SetPrinter(ByVal hPrinter As IntPtr, ByVal Level As Integer, ByVal pPrinter As IntPtr, ByVal Command As Integer) As Boolean
        End Function


        <StructLayout(LayoutKind.Sequential)> Public Structure PRINTER_DEFAULTS
            Public pDatatype As IntPtr
            Public pDevMode As IntPtr
            Public DesiredAccess As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)> Public Structure PRINTER_INFO_9

            Public pDevMode As IntPtr
            Dim pSecurityDescriptor As Integer  ' Pointer to SECURITY_DESCRIPTOR
        End Structure

        Public Const CCDEVICENAME As Short = 32
        Public Const CCFORMNAME As Short = 32


        <StructLayout(LayoutKind.Sequential)> Public Structure DEVMODE
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=CCDEVICENAME)> _
            Public dmDeviceName As String
            Public dmSpecVersion As Short
            Public dmDriverVersion As Short
            Public dmSize As Short
            Public dmDriverExtra As Short
            Public dmFields As Integer
            Public dmOrientation As Short
            Public dmPaperSize As Short
            Public dmPaperLength As Short
            Public dmPaperWidth As Short
            Public dmScale As Short
            Public dmCopies As Short
            Public dmDefaultSource As Short
            Public dmPrintQuality As Short
            Public dmColor As Short
            Public dmDuplex As Short
            Public dmYResolution As Short
            Public dmTTOption As Short
            Public dmCollate As Short
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=CCFORMNAME)> Public dmFormName As String
            Public dmUnusedPadding As Short
            Public dmBitsPerPel As Short
            Public dmPelsWidth As Integer
            Public dmPelsHeight As Integer
            Public dmDisplayFlags As Integer
            Public dmDisplayFrequency As Integer
        End Structure


        Public Const DM_DUPLEX = &H1000&
        Public Const DM_ORIENTATION = &H1&
        Public Const DM_SCALE = &H10&
        Public Const DMORIENT_PORTRAIT = &H1&
        Public Const DMORIENT_LANDSCAPE = &H2&
        Public Const DM_MODIFY = 8
        Public Const DM_COPY = 2
        Public Const DM_IN_BUFFER = 8
        Public Const DM_OUT_BUFFER = 2
        Public Const PRINTER_ACCESS_ADMINISTER = &H4
        Public Const PRINTER_ACCESS_USE = &H8
        Public Const STANDARD_RIGHTS_REQUIRED = &HF0000
        Public Const PRINTER_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED Or PRINTER_ACCESS_ADMINISTER Or PRINTER_ACCESS_USE)
        Public Const CCHDEVICENAME As Integer = 32 'added this 
        Public Const CCHFORMNAME As Integer = 32 'added this 

#End Region

#Region "Public Function"
        ''' <summary>
        ''' Method Name : GetPrinterDuplex 
        ''' Programmatically get the Duplex flag for the specified printer 
        ''' driver's default properties. 
        ''' </summary>
        ''' <param name="sPrinterName"> The name of the printer to be used. </param>
        '''  <param name="errorMessage"> this will contain error messsage if any. </param>
        ''' <returns> 
        ''' nDuplexSetting - One of the following standard settings: 
        ''' 0 = Error
        ''' 1 = None (Simplex)
        ''' 2 = Duplex on long edge (book) 
        ''' 3 = Duplex on short edge (legal) 
        ''' </returns>
        ''' <remarks>
        ''' </remarks>
        Public Function GetPrinterDuplex(ByVal sPrinterName As String, ByRef errorMessage As String) As Short
            Dim hPrinter As IntPtr
            Dim pd As PRINTER_DEFAULTS
            Dim pinfo As PRINTER_INFO_9 = New PRINTER_INFO_9
            Dim dm As DEVMODE = New DEVMODE
            errorMessage = String.Empty
            Dim sizeOfDevMode As Integer = 0
            Dim nRet As Integer
            pd.DesiredAccess = PRINTER_ACCESS_USE
            nRet = OpenPrinter(sPrinterName, hPrinter, pd)
            If (nRet = 0) Or (hPrinter.ToInt32 = 0) Then
                If Err.LastDllError = 5 Then
                    errorMessage = "Access denied -- See the article for more info."
                Else
                    errorMessage = "Cannot open the printer specified " & _
                    "(make sure the printer name is correct)."
                End If
                Exit Function
            End If
            nRet = DocumentProperties(IntPtr.Zero, hPrinter, sPrinterName, IntPtr.Zero, IntPtr.Zero, 0)
            If (nRet < 0) Then
                errorMessage = "Cannot get the size of the DEVMODE structure."
                GoTo cleanup
            End If
            Dim iparg As IntPtr = Marshal.AllocCoTaskMem(nRet + 100)
            nRet = DocumentProperties(IntPtr.Zero, hPrinter, sPrinterName, iparg, IntPtr.Zero, DM_OUT_BUFFER)
            If (nRet < 0) Then
                errorMessage = "Cannot get the DEVMODE structure."
                GoTo cleanup
            End If
            dm = Marshal.PtrToStructure(iparg, dm.GetType)
            If Not CBool(dm.dmFields And DM_DUPLEX) Then
                errorMessage = "You cannot modify the duplex flag for this printer " & _
                       "because it does not support duplex or the driver " & _
                       "does not support setting it from the Windows API."
                GoTo cleanup
            End If
            If nRet = 0 Then
                GetPrinterDuplex = 0
            Else
                GetPrinterDuplex = dm.dmDuplex
            End If
cleanup:
            If (hPrinter.ToInt32 <> 0) Then Call ClosePrinter(hPrinter)
        End Function


        ''' <summary>
        ''' Method Name : SetPrinterDuplex     
        ''' Programmatically set the Duplex flag for the specified printer driver's default properties. 
        ''' </summary>
        ''' <param name="sPrinterName"> sPrinterName - The name of the printer to be used. </param>
        ''' <param name="errorMessage"> this will contain error messsage if any. </param>
        ''' <param name="nDuplexSetting"> 
        ''' nDuplexSetting - One of the following standard settings: 
        ''' 1 = None 
        ''' 2 = Duplex on long edge (book) 
        ''' 3 = Duplex on short edge (legal) 
        ''' </param>
        ''' <returns>
        ''' Returns: True on success, False on error.
        ''' </returns>
        ''' <remarks/>
        Public Function SetPrinterDuplex(ByVal sPrinterName As String, _
        ByVal nDuplexSetting As Integer, ByRef errorMessage As String) As Boolean

            Dim hPrinter As IntPtr
            Dim pd As PRINTER_DEFAULTS
            Dim pinfo As PRINTER_INFO_9 = New PRINTER_INFO_9
            Dim dm As DEVMODE = New DEVMODE
            Dim ptrPrinterInfo As IntPtr
            Dim sizeOfDevMode As Integer = 0
            Dim nBytesNeeded As Integer
            Dim nRet As Integer
            Dim nJunk As Int32
            If (nDuplexSetting < 1) Or (nDuplexSetting > 3) Then
                errorMessage = "Error: dwDuplexSetting is incorrect."
                Exit Function
            End If
            pd.DesiredAccess = PRINTER_ACCESS_USE
            nRet = OpenPrinter(sPrinterName, hPrinter, pd)
            If (nRet = 0) Or (hPrinter.ToInt32 = 0) Then
                If Err.LastDllError = 5 Then
                    errorMessage = "Access denied -- See the article for more info."
                Else
                    errorMessage = "Cannot open the printer specified " & _
                    "(make sure the printer name is correct)."
                End If
                Exit Function
            End If
            nRet = DocumentProperties(IntPtr.Zero, hPrinter, sPrinterName, IntPtr.Zero, IntPtr.Zero, 0)
            If (nRet < 0) Then
                errorMessage = "Cannot get the size of the DEVMODE structure."
                GoTo cleanup
            End If
            Dim iparg As IntPtr = Marshal.AllocCoTaskMem(nRet + 100)
            nRet = DocumentProperties(IntPtr.Zero, hPrinter, sPrinterName, iparg, IntPtr.Zero, DM_OUT_BUFFER)
            If (nRet < 0) Then
                errorMessage = "Cannot get the DEVMODE structure."
                GoTo cleanup
            End If
            dm = Marshal.PtrToStructure(iparg, dm.GetType)
            If Not CBool(dm.dmFields And DM_DUPLEX) Then
                errorMessage = "You cannot modify the duplex flag for this printer " & _
                       "because it does not support duplex or the driver " & _
                       "does not support setting it from the Windows API."
                GoTo cleanup
            End If
            dm.dmDuplex = nDuplexSetting
            Marshal.StructureToPtr(dm, iparg, True)
            nRet = DocumentProperties(IntPtr.Zero, hPrinter, sPrinterName, _
            pinfo.pDevMode, pinfo.pDevMode, DM_IN_BUFFER Or DM_OUT_BUFFER)
            If (nRet < 0) Then
                errorMessage = "Unable to set duplex setting to this printer."
                GoTo cleanup
            End If
            GetPrinter(hPrinter, 9, IntPtr.Zero, 0, nBytesNeeded)
            If (nBytesNeeded = 0) Then
                errorMessage = "GetPrinter failed."
                GoTo cleanup
            End If
            ptrPrinterInfo = Marshal.AllocCoTaskMem(nBytesNeeded + 100)
            nRet = GetPrinter(hPrinter, 9, ptrPrinterInfo, nBytesNeeded, nJunk)
            If (nRet = 0) Then
                errorMessage = "Unable to get shared printer settings."
                GoTo cleanup
            End If
            pinfo = Marshal.PtrToStructure(ptrPrinterInfo, pinfo.GetType)
            pinfo.pDevMode = iparg
            pinfo.pSecurityDescriptor = 0
            Marshal.StructureToPtr(pinfo, ptrPrinterInfo, True)
            nRet = SetPrinter(hPrinter, 9, ptrPrinterInfo, 0)
            If (nRet = 0) Then
                errorMessage = "Unable to set shared printer settings."
            End If
            SetPrinterDuplex = CBool(nRet)
cleanup:
            If (hPrinter.ToInt32 <> 0) Then Call ClosePrinter(hPrinter)
        End Function

#End Region

    End Class

End Namespace

