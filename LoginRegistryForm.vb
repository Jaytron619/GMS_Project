Imports System.Data.SqlClient
Public Class LoginRegistryForm
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Close()

    End Sub

    Private Sub LoginRegistryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub
    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM LoginRegistry"
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            LoginRegistryDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim qry As String = "SELECT * FROM LoginRegistry where Name like '%" + txtSearch.Text + "%'"
            Dim cmd As New SqlCommand(qry, Sqlcon)
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            LoginRegistryDataGrid.DataSource = ds
            Sqlcon.Close()

        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub

    Private Sub txtSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseDown
        If txtSearch.Text = "Search by Name of User" Then
            txtSearch.Text = String.Empty
            txtSearch.ForeColor = Color.Black


        End If
    End Sub
End Class