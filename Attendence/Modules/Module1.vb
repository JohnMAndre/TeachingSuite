Imports System.IO



Module Module1

    Sub Main()
        testSetPrinterDuplex()

    End Sub

    ''' <summary>
    ''' Test Method for testing GetPrinterDuplex Method and SetPrinterDuplex
    ''' This method will display the current duplex settings using GetPrinterDuplexMethod method and 
    ''' then toggle those values using SetPrinterDuplex method. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub testSetPrinterDuplex()
        Dim ds As New MyDuplexSettings.DuplexSettings()
        Dim status As Short
        Dim errorMessage As String = String.Empty
        status = False
        status = ds.GetPrinterDuplex("<<Printer Name>>", errorMessage)
        If (status = 0) Then
            Console.WriteLine("Error occured. Error Message is : " + errorMessage)
        Else
            Console.WriteLine("Current Duplex Setting is : " & status)
            If (status = 1) Then
                status = 2
            Else
                status = 1
            End If
            Console.WriteLine("Now setting the Duplex setting using SetPrinterDuplex to " & status)
            status = ds.SetPrinterDuplex("<<Printer Name>>", status, errorMessage)
            status = ds.GetPrinterDuplex("<<Printer Name>>", errorMessage)
            Console.WriteLine("Duplex Setting after calling SetPrinterDuplex is : " & status)
        End If

        Console.ReadKey()
    End Sub
 


End Module
