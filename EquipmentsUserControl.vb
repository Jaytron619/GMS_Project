
Imports System.Data.SqlClient
Imports System.IO
Public Class EquipmentsUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")



    Private Sub EquipmentsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        addPanel.Enabled = False
        UpdateGrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("Input or Search an ID first ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            checkEdit()
            Dim inputMem As String = "SELECT * FROM Equipments where Name like '%" + txtSearch.Text + "%'"
            autoFill(inputMem)
        End If
    End Sub

    Private Sub checkEdit()
        addPanel.Enabled = True
        btnEdit.Visible = True
        btnSave.Visible = False
        btnReset.Visible = False
        lblHeader.Text = "Edit Equipment"

        txtID.Enabled = False

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addPanel.Enabled = True
        btnEdit.Visible = False
        btnSave.Visible = True
        btnReset.Visible = True
        lblHeader.Text = "Add Equipment"

        Reset()
        autoID()

    End Sub

    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM Equipments"
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            EquipmentsDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub autoID()
        Dim num As Integer

        Sqlcon.Open()
        Dim cmd = New SqlCommand("Select max(ID) from Equipments", Sqlcon)
        cmd.ExecuteNonQuery()

        If IsDBNull(cmd.ExecuteScalar) Then
            num = 1
            txtID.Text = num
        Else
            num = cmd.ExecuteScalar + 1
            txtID.Text = num
        End If

        Sqlcon.Close()

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("Fill in the name space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbType.Text = "" Then
            MessageBox.Show("Make sure to select type of equipment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtCost.Text = "" Then
            MessageBox.Show("Fill in the cost space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtWeight.Text = "" Then
            MessageBox.Show("Fill in the weight space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtQuantity.Text = "" Then
            MessageBox.Show("Fill in the quantity space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ms As New MemoryStream
            imageBox.Image.Save(ms, imageBox.Image.RawFormat)
            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO Equipments VALUES ('" & txtID.Text & "', '" & txtName.Text & "', 
                 '" & cmbType.SelectedItem & "', '" & txtCost.Text & "','" & txtWeight.Text & "',
               '" & txtQuantity.Text & "', '" & dtpPurchaseDate.Value.ToString("dd MMMM,yyyy") & "', @img)"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Insertion was successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                Sqlcon.Close()
                UpdateGrid()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Then
            MessageBox.Show("Fill in the name space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbType.Text = "" Then
            MessageBox.Show("Make sure to type of equipment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtCost.Text = "" Then
            MessageBox.Show("Fill in the cost space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtWeight.Text = "" Then
            MessageBox.Show("Fill in the weight space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtQuantity.Text = "" Then
            MessageBox.Show("Fill in the quantity space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim ms As New MemoryStream
                imageBox.Image.Save(ms, imageBox.Image.RawFormat)
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE Equipments SET Name= '" & txtName.Text & "', Type= '" & cmbType.SelectedItem & "', 
            Cost= '" & txtCost.Text & "',Weight= '" & txtWeight.Text & "',Quantity='" & txtQuantity.Text & "',
            PurchaseDate='" & dtpPurchaseDate.Value.ToString("dd MMMM,yyyy") & "',  Picture=@img
            WHERE Id='" & txtID.Text & "'"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record was edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
                UpdateGrid()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtSearch.Text = "" Then
            MessageBox.Show(" Search an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dr = DialogResult.Yes Then
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " DELETE FROM Equipments WHERE Id='" & txtID.Text & "'"
                com.ExecuteNonQuery()
                Sqlcon.Close()
                MessageBox.Show("Equipment details successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateGrid()
                Reset()
            End If

        End If
    End Sub



    Public Sub autoFill(ByVal inputMem)
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = inputMem
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            txtID.Text = SQLReader.Item("Id")
            txtName.Text = SQLReader.Item("Name")
            cmbType.Text = SQLReader.Item("Type")
            txtCost.Text = SQLReader.Item("Cost")
            txtWeight.Text = SQLReader.Item("Weight")
            txtQuantity.Text = SQLReader.Item("Quantity")
            dtpPurchaseDate.Value = SQLReader.Item("PurchaseDate")


            Dim img() As Byte
            img = SQLReader.Item("Picture")
            Dim ms As New MemoryStream(img)
            imageBox.Image = Image.FromStream(ms)

            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message & "Enter name of  the equipment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Reset()
        txtID.Text = String.Empty
        txtName.Text = String.Empty
        cmbType.Text = ""
        txtCost.Text = String.Empty
        txtWeight.Text = String.Empty
        txtQuantity.Text = String.Empty

        dtpPurchaseDate.Value = Date.Now


        imageBox.Image = Nothing
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
        autoID()
    End Sub


    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim qry As String = "SELECT * FROM Equipments where Name like '%" + txtSearch.Text + "%'"
            Dim cmd As New SqlCommand(qry, Sqlcon)
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            EquipmentsDataGrid.DataSource = ds
            Sqlcon.Close()
            autoFill(qry)
            checkEdit()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub


End Class
