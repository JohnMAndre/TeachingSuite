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