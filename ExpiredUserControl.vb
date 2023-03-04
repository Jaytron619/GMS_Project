Public Class ExpiredUserControl
    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click
        Try
            Dim RenewMem As New RenewalForm
            RenewMem.Show()

            Dim inputMem As String
            inputMem = lblMemberId.Text
            RenewMem.UpdateMembership(inputMem)

        Catch ex As Exception

        End Try
    End Sub
End Class
