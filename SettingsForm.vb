Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        Dim general As New GeneralSettings
        showControl(general)
    End Sub

    Public Sub showControl(scontrol As Control)
        contentPanel.Controls.Clear()
        scontrol.Dock = DockStyle.Fill
        scontrol.BringToFront()
        scontrol.Focus()
        scontrol.BackColor = Color.FromArgb(42, 42, 42)
        contentPanel.Controls.Add(scontrol)
    End Sub



    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        Dim general As New GeneralSettings
        showControl(general)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim account As New AccountSettings
        showControl(account)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim about As New AboutSettings
        showControl(about)
    End Sub
End Class