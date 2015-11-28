Public Class Upgrade

    Private Sub pbActivate_Click(sender As Object, e As EventArgs) Handles pbActivate.Click
        Try
            If txtCode.Text.Trim.Length < 8 Then
                MessageBox.Show("There is a problem with your upgrade code. Please check it again.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtEmail.Text.Trim.Length < 5 Then
                MessageBox.Show("There is a problem with your email address. It should be in the format: Name@Domain.com", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim strEmail As String = txtEmail.Text.Trim.ToLower()
            Dim strCode As String
            strCode = GetUgradeCode(strEmail)
            If txtCode.Text.Trim.Substring(0, 8).ToLower() = strCode.Substring(8, 8).ToLower() Then
                AppSettings.PremiumFeaturesEnabled = True
                MessageBox.Show("Your copy of Teaching App has been upgraded to Premium." & Environment.NewLine & Environment.NewLine & "You should restart Teaching App to see your new features.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("The upgrade code you entered does not match your email address.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Log(ex)
            MessageBox.Show("There was an error upgrading your copy of Teaching App.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("There was an error launching your email client. Please write an email to: J o h n @ J o h n M A n d r e . c o m" & Environment.NewLine() & Environment.NewLine() & "With the subject 'Teaching App' for purchasing options.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Private Sub Upgrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ApplyCurrentTheme(Me.KryptonPalette1)
    'End Sub

End Class