
Imports System.Data.SqlClient
Imports System.IO
Public Class AccountSettings
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        SettingsForm.Close()

    End Sub

    Private Sub AccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoFill()
    End Sub

    Public Sub autoFill()
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM Settings "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            lblCompanyName.Text = SQLReader.Item("CompanyName")

            txtCompanyNumber.Text = SQLReader.Item("CompanyNumber")
            txtMomoLine.Text = SQLReader.Item("MomoNumber")
            txtBankAccount.Text = SQLReader.Item("BankAccount")
            txtCompanyEmail.Text = SQLReader.Item("CompanyEmail")

            Dim img() As Byte
            img = SQLReader.Item("Logo")
            Dim ms As New MemoryStream(img)
            PicBox.Image = Image.FromStream(ms)

            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCompanyNumber.Text = "" And txtMomoLine.Text = "" And txtCompanyEmail.Text = "" Then
            MessageBox.Show(" Enter Company Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE Settings SET CompanyNumber= '" & txtCompanyNumber.Text & "',
                MomoNumber= '" & txtMomoLine.Text & "', BankAccount= '" & txtBankAccount.Text & "',
                CompanyEmail= '" & txtCompanyEmail.Text & "' WHERE Id= 1"

                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
                autoFill()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
