Imports System.Data.SqlClient
Imports System.IO
Public Class GeneralSettings
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        SettingsForm.Close()

    End Sub

    Private Sub GeneralSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoFill()
    End Sub


    Dim imageLocation As String
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Try
            Dim dialog As New OpenFileDialog()
            dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All files (*.*)|*.*"
            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                imageLocation = dialog.FileName
                imageBox.ImageLocation = imageLocation
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub autoFill()
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM Settings "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            txtCompanyName.Text = SQLReader.Item("CompanyName")




            Dim img() As Byte
            img = SQLReader.Item("Logo")
            Dim ms As New MemoryStream(img)
            imageBox.Image = Image.FromStream(ms)

            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCompanyName.Text = "" Then
            MessageBox.Show(" Enter Company Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim ms As New MemoryStream
                imageBox.Image.Save(ms, imageBox.Image.RawFormat)
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE Settings SET CompanyName= '" & txtCompanyName.Text & "',
                SettingsStatus='Yes' , Logo=@img WHERE Id= 1"

                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
                autoFill()
                mainForm.autoFill()

            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class
