Public Class GroupPresentationOptions
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '-- just save these options back to AppSettings
        AppSettings.PresentationContentLabel = txtComponent1Label.Text
        AppSettings.PresentationPresentationLabel = txtComponent2Label.Text
        AppSettings.PresentationLanguageLabel = txtComponent3Label.Text

        AppSettings.PresentationContentWeight = CInt(nudComponent1Weight.Value)
        AppSettings.PresentationPresentationWeight = CInt(nudComponent2Weight.Value)
        AppSettings.PresentationLanguageWeight = CInt(nudComponent3Weight.Value)

        Me.Close()
    End Sub

    Private Sub GroupPresentationOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-- load just these options
        txtComponent1Label.Text = AppSettings.PresentationContentLabel
        txtComponent2Label.Text = AppSettings.PresentationPresentationLabel
        txtComponent3Label.Text = AppSettings.PresentationLanguageLabel

        nudComponent1Weight.Value = AppSettings.PresentationContentWeight
        nudComponent2Weight.Value = AppSettings.PresentationPresentationWeight
        nudComponent3Weight.Value = AppSettings.PresentationLanguageWeight
    End Sub
End Class