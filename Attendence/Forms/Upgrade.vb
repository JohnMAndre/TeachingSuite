Public Class Upgrade

    Private Sub pbActivate_Click(sender As Object, e As EventArgs) Handles pbActivate.Click
        Try
            '    Dim strEmail As String = txtEmail.Text.Trim.ToLower()
            '    Dim strCode As String = GetUgradeCode(strEmail)
            '    If txtCode.Text.Trim.Substring(0, 8).ToLower() = strCode.Substring(0, 8).ToLower() Then
            '        AppSettings.PremiumFeaturesEnabled = True
            '        ShowMessageBox("Your copy of TrulyMail has been upgraded to Premium." & Environment.NewLine & Environment.NewLine & "You should restart TrulyMail to see your new features.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            '        Close()
            '    Else
            '        ShowMessageBox("The upgrade code you entered does not match your email address." & CONTACT_TRULYMAIL_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            '    End If
        Catch ex As Exception
            Log(ex)
            '    ShowMessageBoxError("There was an error upgrading your copy of Teaching App." & CONTACT_TRULYMAIL_MESSAGE)
        End Try
    End Sub

    Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
        Close()
    End Sub

    Private Sub llblGoToShop_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblGoToShop.LinkClicked
        Try
            System.Diagnostics.Process.Start("mailto:John@JohnMAndre.com")
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("")
        End Try
    End Sub

    'Private Sub Upgrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ApplyCurrentTheme(Me.KryptonPalette1)
    'End Sub
End Class