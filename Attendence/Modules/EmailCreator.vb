'Copyright 2020 John M Andre (John At JohnMAndre dot COM)

'This file Is part of TrulyMail

'TrulyMail is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'AWARE Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with AWARE.  If Not, see < https: //www.gnu.org/licenses/>.

Imports System.Xml
Imports System.IO

Public Class EmailCreator
    Friend Const DATEFORMAT_XML As String = "yyyy'-'MM'-'ddTHH':'mm':'ss'.'fff" '-- used to be "yyyy-MM-ddTHH:mm:ss.fff" but diff cultures were throwing things into chaos
    Public Property RecipientAddress As String
    Public Property RecipientFullName As String
    Public Property SendAfter As Date
    Public Property KeepCopyAfterSend As Boolean
    Public Property RequestReturnReceipt As Boolean
    Public Property SMTPAccount As String
    Public Property PlainText As Boolean
    Public Property Subject As String
    Public Property Body As String
    Public Property Tags As String
    Private m_xDoc As XmlDocument
    Public Sub New()
        Dim strFilename As String
        strFilename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "html" & Path.DirectorySeparatorChar & "emailTemplate.xml")

        m_xDoc = New XmlDocument()

        m_xDoc.Load(strFilename)

        '-- Defaults
        RecipientAddress = String.Empty
        RecipientFullName = String.Empty
        SendAfter = Date.Now
        KeepCopyAfterSend = True
        RequestReturnReceipt = False
        SMTPAccount = "7a033fe1-2f78-446d-a682-99d2b7cf423d"
        PlainText = True
        Subject = String.Empty
        Body = String.Empty
        Tags = String.Empty

    End Sub
    Public Sub SendToOutbox(pathToOutbox As String)
        Try
            Dim strFilename As String
            Dim strMessageID As String
            strMessageID = Guid.NewGuid().ToString()

            m_xDoc.DocumentElement.SetAttribute("MessageID", strMessageID)
            m_xDoc.DocumentElement.SetAttribute("SendAfter", SendAfter.ToUniversalTime.ToString(DATEFORMAT_XML))
            m_xDoc.DocumentElement.SetAttribute("KeepCopyAfterSend", KeepCopyAfterSend.ToString())

            Dim xElement As XmlElement = m_xDoc.SelectSingleNode("//Subject")
            xElement.InnerText = Subject

            xElement = m_xDoc.SelectSingleNode("//Recipient")
            xElement.SetAttribute("Address", RecipientAddress)
            xElement.SetAttribute("FullName", RecipientFullName)
            xElement.SetAttribute("RecipientID", Guid.NewGuid().ToString())

            xElement = m_xDoc.SelectSingleNode("//Body")
            If PlainText Then
                xElement.SetAttribute("Format", "PlainText")
            Else
                xElement.SetAttribute("Format", "HTML")
            End If
            xElement.InnerText = Body

            xElement = m_xDoc.SelectSingleNode("//Tags")
            xElement.InnerText = Tags

            m_xDoc.DocumentElement.SetAttribute("MessageSize", m_xDoc.OuterXml.Length().ToString)

            strFilename = Path.Combine(pathToOutbox, strMessageID & ".tmm")
            m_xDoc.Save(strFilename)
        Catch ex As Exception
            Log(ex)
            Throw ex
        End Try
    End Sub
End Class
