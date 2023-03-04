Imports System.Data.SqlClient
Imports System.IO
Public Class staffUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")
    Private Sub staffUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()


    End Sub

    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM staff "
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            staffDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim qry As String = "SELECT * FROM staff where StaffID like '" + txtSearch.Text + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            staffDataGrid.DataSource = ds
            Sqlcon.Close()


        Catch ex As Exception
            Sqlcon.Close()
        End Try

    End Sub


    Public Sub autoIDGenerate()

        Dim num As Integer
        Dim result As String
        Sqlcon.Open()

        Dim cmd = New SqlCommand("Select max(StaffID) from staff", Sqlcon)
        result = cmd.ExecuteScalar().ToString
        If String.IsNullOrEmpty(result) Then
            result = "STFF0001"
            StaffForm.txtStaffID.Text = result
        Else
            result = result.Substring(4)
            Int32.TryParse(result, num)
            num = num + 1
            result = "STFF" + num.ToString("D4")
            StaffForm.txtStaffID.Text = result
        End If

        Sqlcon.Close()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        StaffForm.Show()
        StaffForm.btnEdit.Visible = False
        autoIDGenerate()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtSearch.Text = "" Then
            MessageBox.Show(" Enter an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dr = DialogResult.Yes Then
                Try
                    Sqlcon.Open()
                    Dim com As SqlCommand = Sqlcon.CreateCommand()
                    com.CommandText = " DELETE FROM staff WHERE StaffID='" & txtSearch.Text & "'"
                    com.ExecuteNonQuery()
                    Sqlcon.Close()
                    MessageBox.Show("Record successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    Sqlcon.Close()
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                UpdateGrid()
            End If

        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("Input or Search Staff ID fist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim staffForm As New StaffForm

            staffForm.Show()
            staffForm.btnPrint.Visible = True
            staffForm.btnSave.Visible = False
            staffForm.btnReset.Visible = False

            staffForm.lblHeader.Text = "Edit Staff"
            Dim inputMem As String
            inputMem = txtSearch.Text
            staffForm.autoFill(inputMem)
        End If

    End Sub



    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateGrid()

    End Sub
End Class
