Imports System.Data.SqlClient
Public Class PaymentForm
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")




    Private Sub Clear()
        txtReceiptID.Text = String.Empty
        txtMemberID.Text = String.Empty
        txtBalance.Text = String.Empty
        cmbPaymentType.Text = ""
        txtAmountPaid.Text = String.Empty
        dtpPaymentDate.Value = Date.Now


    End Sub

    Public Sub autoFill(ByVal inputMem)
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT *FROM payments WHERE receiptID like '%" & inputMem & "%'"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            txtReceiptID.Text = SQLReader.Item("receiptID")
            txtMemberID.Text = SQLReader.Item("Member_ID")
            cmbPackageType.Text = SQLReader.Item("MemberType")
            cmbPaymentType.Text = SQLReader.Item("paymentType")
            txtAmountPaid.Text = SQLReader.Item("amountPaid")
            txtBalance.Text = SQLReader.Item("balance")
            dtpPaymentDate.Value = SQLReader.Item("paymentDate")



            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtReceiptID.Text = "" Then
            MessageBox.Show("Fill in the Receipt ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtMemberID.Text = "" Then
            MessageBox.Show("Fill in the Member ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAmountPaid.Text = "" Then
            MessageBox.Show("Fill in the Amount Paid space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtBalance.Text = "" Then
            MessageBox.Show("Fill in the Balance space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbPackageType.Text = "" Then
            MessageBox.Show("Fill in the Package Type space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO Payments VALUES ('" & txtReceiptID.Text & "', '" & txtMemberID.Text & "',  '" & cmbPackageType.SelectedItem & "', 
                '" & cmbPaymentType.SelectedItem & "', '" & txtAmountPaid.Text & "','" & txtBalance.Text & "', 
                '" & dtpPaymentDate.Value.ToString("dd MMMM,yyyy") & "') "

                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Insertion was successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                Sqlcon.Close()

            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtReceiptID.Text = "" Then
            MessageBox.Show("Fill in the Receipt ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtMemberID.Text = "" Then
            MessageBox.Show("Fill in the Member ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAmountPaid.Text = "" Then
            MessageBox.Show("Fill in the Amount Paid space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtBalance.Text = "" Then
            MessageBox.Show("Fill in the Balance space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbPackageType.Text = "" Then
            MessageBox.Show("Fill in the Package Type space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE Payments SET Member_ID= '" & txtMemberID.Text & "',MemberType= '" & cmbPackageType.SelectedItem & "',
                paymentType = '" & cmbPaymentType.SelectedItem & "',amountPaid= '" & txtAmountPaid.Text & "',
                balance='" & txtBalance.Text & "',paymentDate='" & dtpPaymentDate.Value.ToString("dd MMMM,yyyy") & "' WHERE receiptID='" & txtReceiptID.Text & "'"

                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record was edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim name As String = "Unknown Name"
        Dim pic As Image = mainForm.PicLogo.Image
        e.Graphics.DrawImage(pic, x:=100, y:=10, height:=30, width:=30)
        e.Graphics.DrawString(mainForm.lblCompanyName.Text, New Font("Arial", 18, FontStyle.Bold), Brushes.DeepSkyBlue, New PointF(220, 20))
        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 18, FontStyle.Bold), Brushes.Black, New PointF(0, 40))
        e.Graphics.DrawString("Receipt ID: ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New PointF(10, 100))
        e.Graphics.DrawString(txtReceiptID.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(100, 100))
        e.Graphics.DrawString("Date: ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New PointF(500, 100))
        e.Graphics.DrawString(dtpPaymentDate.Value, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(550, 100))

        e.Graphics.DrawString("Received from:.................................................................................", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, New PointF(10, 150))
        e.Graphics.DrawString(name, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(150, 145))
        e.Graphics.DrawString("Member ID:................................................... ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New PointF(10, 200))
        e.Graphics.DrawString(txtMemberID.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(160, 195))
        e.Graphics.DrawString("Package Type:................................................... ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New PointF(400, 200))
        e.Graphics.DrawString(cmbPackageType.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(540, 195))
        e.Graphics.DrawString("Payment Type:........................................................................", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New PointF(10, 240))
        e.Graphics.DrawString(cmbPaymentType.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(200, 235))
        e.Graphics.DrawString("Amount Paid:...........................................................", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New PointF(10, 280))
        e.Graphics.DrawString("GHc " + txtAmountPaid.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(180, 275))
        e.Graphics.DrawString("Balance:....................................", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New PointF(500, 280))
        e.Graphics.DrawString("GHc " + txtBalance.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(580, 275))
        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 18, FontStyle.Bold), Brushes.Black, New PointF(0, 300))
        e.Graphics.DrawString("Sign:....................................... ", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(500, 328))
        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 18, FontStyle.Bold), Brushes.Black, New PointF(0, 340))

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub AddPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        autoSearch()

    End Sub
    Private Sub autoSearch()
        Dim cmd As New SqlCommand("select Member_ID from MembershipReg", Sqlcon)
        Sqlcon.Open()

        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim myColl As New AutoCompleteStringCollection()
        While dr.Read()
            myColl.Add(dr.GetString(0))
        End While
        txtMemberID.AutoCompleteCustomSource = myColl
        Sqlcon.Close()
    End Sub



    Private Sub txtMemberID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMemberID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " SELECT *FROM MembershipReg WHERE Member_ID = '" & txtMemberID.Text & "'"
                Dim SQLReader As SqlDataReader = com.ExecuteReader()

                SQLReader.Read()
                cmbPackageType.Text = SQLReader.Item("MembershipType")

                Sqlcon.Close()
                cmbPackageType.Enabled = False
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
        Dim pay As New PaymentUserControl
        pay.autoIDGenerate()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class