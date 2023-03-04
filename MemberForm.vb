Imports System.Data.SqlClient
Imports System.IO
Imports System.BitConverter
Public Class MemberForm
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtWeight.Text = "" Then
            MessageBox.Show(" Please fill the weight field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtMobilePhone.Text = "" Then
            MessageBox.Show(" Please fill the Monile Number field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please make sure the email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtName.Text = "" Then
            MessageBox.Show("Please Enter the Fulllname of the person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtHeight.Text = "" Then
            MessageBox.Show("Please Enter the height of the person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbGender.SelectedItem = "" Then
            MessageBox.Show("Please make sure to select the Gender type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtRegionState.Text = "" Then
            MessageBox.Show("Please make sure to fill Region/State field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try
                Dim ms As New MemoryStream
                imageBox.Image.Save(ms, imageBox.Image.RawFormat)
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO MembershipReg VALUES ('" & txtMemberID.Text & "', '" & txtName.Text & "', 
           '" & cmbGender.SelectedItem & "', " & txtMobilePhone.Text & ", '" & txtEmail.Text & "','" & dtpDOB.Value.ToString("dd MMMM,yyyy") & "' ,
           '" & txtHeight.Text & "','" & txtWeight.Text & "','" & txtCity.Text & "',
           '" & txtRegionState.Text & "','" & txtCountry.Text & "', '" & txtPostalCode.Text & "',
           '" & dtpJoiningDate.Value.ToString("dd MMMM,yyyy") & "','" & cmbPackageType.SelectedItem & "',
           '" & dtpRenewalDate.Value.ToString("dd MMMM,yyyy") & "',@img, 'No')"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    Dim dr As DialogResult
                    dr = MessageBox.Show("Insertion was successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If dr = DialogResult.OK Then

                        PaymentForm.Show()
                        PaymentForm.btnEdit.Visible = False
                        Dim pay As New PaymentUserControl
                        pay.autoIDGenerate()
                    End If
                End If
                Sqlcon.Close()

            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub Clear()
        txtMemberID.Text = String.Empty
        txtName.Text = String.Empty
        cmbGender.Text = ""
        dtpDOB.Value = Date.Now
        txtEmail.Text = String.Empty
        txtMobilePhone.Text = String.Empty
        txtHeight.Text = String.Empty
        txtWeight.Text = String.Empty
        txtCity.Text = String.Empty
        txtRegionState.Text = String.Empty
        txtCountry.Text = String.Empty
        txtPostalCode.Text = String.Empty
        dtpJoiningDate.Value = Date.Now
        cmbPackageType.Text = ""
        dtpRenewalDate.Value = Date.Now

        imageBox.Image = Nothing
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
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Dim bitm As Bitmap
    Private Sub btnPrintMember_Click(sender As Object, e As EventArgs) Handles btnPrintMember.Click
        PrintPreviewDialog1.Document = PrintDocument1
        Dim apanel As New Panel
        Me.Controls.Add(apanel)
        Dim Pgraphics As Graphics = apanel.CreateGraphics
        Dim size As Size = Me.ClientSize
        bitm = New Bitmap(size.Width, size.Height, Pgraphics)
        Pgraphics = Graphics.FromImage(bitm)
        Dim pointx As Point = PointToScreen(apanel.Location)
        Pgraphics.CopyFromScreen(pointx.X, pointx.Y, 0, 0, size)

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub




    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtWeight.Text = "" Then
            MessageBox.Show(" Please fill the weight field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtMobilePhone.Text = "" Then
            MessageBox.Show(" Please fill the Monile Number field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please make sure the email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtName.Text = "" Then
            MessageBox.Show("Please Enter the Fulllname of the person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtHeight.Text = "" Then
            MessageBox.Show("Please Enter the height of the person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbGender.SelectedItem = "" Then
            MessageBox.Show("Please make sure to select the Gender type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtRegionState.Text = "" Then
            MessageBox.Show("Please make sure to fill Region/State field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim ms As New MemoryStream
                imageBox.Image.Save(ms, imageBox.Image.RawFormat)
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE MembershipReg SET Name= '" & txtName.Text & "',Gender='" & cmbGender.SelectedItem & "',
                Mobile='" & txtMobilePhone.Text & "',Email='" & txtEmail.Text & "',
                Date_Of_Birth='" & dtpDOB.Value.ToString("dd MMMM,yyyy") & "' , 
                Height='" & txtHeight.Text & "', Weight='" & txtWeight.Text & "', City='" & txtCity.Text & "',
                Region_State='" & txtRegionState.Text & "', Country='" & txtCountry.Text & "', Zip_PostalCode='" & txtPostalCode.Text & "',
                JoiningDate='" & dtpJoiningDate.Value.ToString("dd MMMM,yyyy") & "',
                MembershipType='" & cmbPackageType.SelectedItem & "',RenewalDate='" & dtpRenewalDate.Value.ToString("dd MMMM,yyyy") & "',
                Picture=@img WHERE Member_ID='" & txtMemberID.Text & "'"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public Sub UpdateMembership(ByVal inputMem)

        Try

            Sqlcon.Open()

            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT *FROM MembershipReg WHERE Member_ID like '%" & inputMem & "%'"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()

            txtMemberID.Text = SQLReader.Item("Member_ID")
            txtName.Text = SQLReader.Item("Name")
            cmbGender.Text = SQLReader.Item("Gender")
            txtMobilePhone.Text = SQLReader.Item("Mobile")
            txtEmail.Text = SQLReader.Item("Email")
            dtpDOB.Value = SQLReader.Item("Date_Of_Birth")
            txtHeight.Text = SQLReader.Item("Height")
            txtWeight.Text = SQLReader.Item("Weight")
            txtCity.Text = SQLReader.Item("City")
            txtRegionState.Text = SQLReader.Item("Region_State")
            txtCountry.Text = SQLReader.Item("Country")
            txtPostalCode.Text = SQLReader.Item("Zip_PostalCode")
            dtpJoiningDate.Value = SQLReader.Item("JoiningDate")
            cmbPackageType.Text = SQLReader.Item("MembershipType")
            dtpRenewalDate.Value = SQLReader.Item("RenewalDate")

            Dim img() As Byte
            img = SQLReader.Item("Picture")
            Dim ms As New MemoryStream(img)
            imageBox.Image = Image.FromStream(ms)

            Sqlcon.Close()

        Catch ex As Exception
            Sqlcon.Close()

        End Try


    End Sub

    Private Sub AddMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        UpdateCombo()


    End Sub

    Private Sub UpdateCombo()

        Sqlcon.Open()
        Dim com As SqlCommand = Sqlcon.CreateCommand()
        com.CommandText = " SELECT * FROM Package "
        Dim SQLReader As SqlDataReader = com.ExecuteReader()

        While SQLReader.Read()
            cmbPackageType.Items.Add(SQLReader.Item("PackageName"))

        End While
        Sqlcon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
        Dim MEMB As New MemberUserControl
        MEMB.autoIDGenerate()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitm, 0, 0)
    End Sub
End Class