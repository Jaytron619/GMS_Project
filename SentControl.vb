Public Class SentControl
    Private Sub SentControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = DateTime.Now.ToString("hh:mm")
    End Sub
End Class
