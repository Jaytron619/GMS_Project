Imports System.Data.SqlClient
Public Class PaymentUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub studentFeesUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()

    End Sub



    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM Payments"
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            feesDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub





    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim qry As String = "SELECT * FROM Payments where receiptID like '" + txtSearch.Text + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            feesDataGrid.DataSource = ds
            Sqlcon.Close()

        Catch ex As Exception
            Sqlcon.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateGrid()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        PaymentForm.Show()
        PaymentForm.btnEdit.Visible = False
        autoIDGenerate()

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtSearch.Text = "" Then
            MessageBox.Show(" Search Receipt ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dr = DialogResult.Yes Then
                Try
                    Sqlcon.Open()
                    Dim com As SqlCommand = Sqlcon.CreateCommand()
                    com.CommandText = " DELETE FROM Payments WHERE receiptID='" & txtSearch.Text & "'"
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
            MessageBox.Show("Input or Search Receipt ID fist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim paymentForm As New PaymentForm

            paymentForm.Show()
            paymentForm.btnPrint.Visible = True
            paymentForm.btnSave.Visible = False
            paymentForm.btnReset.Visible = False
            paymentForm.txtReceiptID.Enabled = False
            paymentForm.txtMemberID.Enabled = False
            paymentForm.lblHeader.Text = "Edit Pay"
            Dim inputMem As String
            inputMem = txtSearch.Text
            paymentForm.autoFill(inputMem)
        End If
    End Sub


    Public Sub autoIDGenerate()

        Dim num As Integer
        Dim result As String
        Sqlcon.Open()

        Dim cmd = New SqlCommand("Select max(receiptID) from Payments", Sqlcon)
        result = cmd.ExecuteScalar().ToString
        If String.IsNullOrEmpty(result) Then
            result = "Rcp0001"
            PaymentForm.txtReceiptID.Text = result
        Else
            result = result.Substring(3)
            Int32.TryParse(result, num)
            num = num + 1
            result = "Rcp" + num.ToString("D4")
            PaymentForm.txtReceiptID.Text = result
        End If

        Sqlcon.Close()


    End Sub

End Class
