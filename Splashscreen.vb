Imports System.Data.SqlClient

Public Class Splashscreen
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        splashLoader.Width += 1
        If splashLoader.Width >= 522 Then
            Timer1.Stop()
            mainForm.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        Try
            Sqlcon.Open()
            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Sqlcon.Close()
        End Try
    End Sub
End Class
