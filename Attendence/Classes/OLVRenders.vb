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

Public Class DateOnlyRenderer
    Inherits BrightIdeasSoftware.BaseRenderer

    Public Overrides Sub Render(ByVal g As System.Drawing.Graphics, ByVal r As System.Drawing.Rectangle)
        Dim strText As String = Me.GetText

        If strText.Length > 0 Then
            Dim i As Integer = Convert.ToInt32(strText.Substring(0, strText.Length - 1).Trim)

            Select Case i
                Case -1
                    g.FillRectangle(Brushes.White, r)
                Case 0
                    g.FillRectangle(Brushes.Pink, r)
                Case 100
                    g.FillRectangle(Brushes.LightGreen, r)
                Case Else
                    g.FillRectangle(Brushes.LightBlue, r)
            End Select

            g.DrawString(strText, Me.ListView.Font, Brushes.Black, r)
        Else
            MyBase.Render(g, r)
        End If
    End Sub
End Class