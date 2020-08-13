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
Public Class PreperationStatus

    Private Class SessionPrepReportItem
        Public Property ModuleName As String
        Public Property PreppedSessions As Integer
        Public Property UnpreppedSessions As Integer
        Public Property TotalSessions As Integer
        Public Property EarliestUnpreppedSession As Date = Date.Today.AddYears(100)
        Public Property FinalSession As Date
        Public ReadOnly Property PercentComplete As String
            Get
                Dim dblReturn As Double
                If TotalSessions > 0 Then
                    dblReturn = PreppedSessions / TotalSessions
                Else
                    dblReturn = 1
                End If

                Return dblReturn.ToString("0%")
            End Get
        End Property
        Public ReadOnly Property EarliestUnpreppedText As String
            Get
                If EarliestUnpreppedSession = Date.Today.AddYears(100) Then
                    Return String.Empty
                Else
                    Return EarliestUnpreppedSession.ToString()
                End If
            End Get
        End Property
    End Class

    Private m_lstReportItems As List(Of SessionPrepReportItem)

    Private Sub LoadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim item As SessionPrepReportItem

        m_lstReportItems = New List(Of SessionPrepReportItem)

        For Each grp As ClassGroup In ThisSemester.ClassGroups
            item = New SessionPrepReportItem
            item.ModuleName = grp.Name
            m_lstReportItems.Add(item)
            For Each cls As SchoolClass In grp.Classes
                For Each sess As ActualSessionItem In cls.ActualSessions
                    item.TotalSessions += 1

                    If sess.StartDateTime > item.FinalSession Then
                        item.FinalSession = sess.StartDateTime
                    End If

                    If sess.Prepped Then
                        item.PreppedSessions += 1
                    Else
                        item.UnpreppedSessions += 1
                        If sess.StartDateTime < item.EarliestUnpreppedSession Then
                            item.EarliestUnpreppedSession = sess.StartDateTime
                        Else
                        End If
                    End If
                Next
            Next
        Next

        Dim intTotal, intPrep, intUnprep As Integer
        Dim dtNextUnprepped As Date = Date.Today.AddYears(10)
        Dim strNextUnpreppedModuleName As String
        Dim dblPercent As Double
        For Each item In m_lstReportItems
            intTotal += item.TotalSessions
            intPrep += item.PreppedSessions
            intUnprep += item.UnpreppedSessions
            If dtNextUnprepped > item.EarliestUnpreppedSession Then
                dtNextUnprepped = item.EarliestUnpreppedSession
                strNextUnpreppedModuleName = item.ModuleName
            End If
        Next

        '-- Update total labels
        dblPercent = intPrep / intTotal
        lblPreppedPercent.Text = dblPercent.ToString("##0%")
        dblPercent = intUnprep / intTotal
        lblUnpreppedPercent.Text = dblPercent.ToString("##0%")
        lblTotalSessions.Text = intTotal.ToString()
        lblPreppedSessions.Text = intPrep.ToString()
        lblUnprepped.Text = intUnprep.ToString()

        If intUnprep = 0 Then
            lblNextUnprepped.Text = "<none>"
            lblDaysUntilNextUnprepped.Text = "<n/a>"
            lblNextUnpreppedModuleName.Text = String.Empty
        Else
            lblNextUnprepped.Text = dtNextUnprepped.ToString()
            lblNextUnpreppedModuleName.Text = strNextUnpreppedModuleName
            If Date.Today > dtNextUnprepped Then
                lblDaysUntilNextUnprepped.Text = "<n/a>"
            Else
                Dim ts As TimeSpan = dtNextUnprepped - Date.Today
                lblDaysUntilNextUnprepped.Text = ts.Days.ToString("#,##0")
            End If
        End If


        olvReport.SetObjects(m_lstReportItems)
    End Sub

    Private Sub PreperationStatus_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class
