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

Public Class Emailer
    Implements IDisposable

    Public Property Recipients As New List(Of EmailRecipient)
    Public Property Subject As String = String.Empty

    Private m_TrulyMail As Object

    Public Sub New()
        Dim mainform As System.Runtime.Remoting.ObjectHandle
        mainform = Activator.CreateInstanceFrom(AppSettings.PathToTrulyMailEXE, "TrulyMail.MainForm") '-- load appsettings, etc.
        m_TrulyMail = mainform.Unwrap()
        Application.DoEvents() '-- required to load form and refresh
    End Sub

    Public Shared ReadOnly Property SetupProperly As Boolean
        Get
            If AppSettings.PathToTrulyMailEXE.Trim.Length = 0 OrElse Not System.IO.File.Exists(AppSettings.PathToTrulyMailEXE) Then
                Return False
            Else
                Return True
            End If
        End Get
    End Property
    ''' <summary>
    ''' Sends the email to the receipients
    ''' </summary>
    ''' <param name="sendingAccount">The TrulyMail SMTP account to use for sending, pass zero for the first account</param>
    ''' <param name="actuallySend ">If false, the message window will stay open (so user can add attachments, etc.)</param>
    ''' <param name="delaySendingHours ">Saves msg in outbox to send in x hours. Ignored if actuallySend=false.</param>
    ''' <remarks></remarks>
    Public Sub Send(sendingAccount As Integer, actuallySend As Boolean, delaySendingHours As Integer)
        Try
            If Recipients.Count = 0 Then
                Throw New Exception("No recipients for email.")
            End If
            Dim tm As Object '-- Message object

            tm = m_TrulyMail.CreateNewMessage()
            For Each objContact As EmailRecipient In Recipients
                tm.AddRecipient(objContact.Name, objContact.EmailAddress)
            Next
            tm.show() '-- don't show, doesn't load all the smtp accounts
            tm.UseSendingAccount(sendingAccount)
            tm.SendAsPlainText = False
            tm.Subject = Me.Subject

            If actuallySend Then
                Try
                    Dim dt As Date = Date.UtcNow.AddHours(delaySendingHours) '-- must be in UTC
                    tm.SendThisMessage(dt)
                Catch ex As Exception
                    Log(ex)
                    tm.CloseSaveAsDraft()
                End Try
            End If

            tm = Nothing

        Catch ex As Exception
            Log(ex)
            Throw ex
        End Try
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                m_TrulyMail = Nothing
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
