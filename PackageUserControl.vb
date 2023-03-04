Imports System.Data.SqlClient
Public Class PackageUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub PackageUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Visible = False
        addPanel.Enabled = False
        UpdateGrid()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addPanel.Enabled = True
        btnEdit.Visible = False
        btnSave.Visible = True
        btnReset.Visible = True
        lblHeader.Text = "Add Package"
        Reset()
        autoID()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("Input or Search an ID first ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            checkEdit()
            Dim inputMem As String = "SELECT * FROM Package where ID like '%" + txtSearch.Text + "%'"
            autoFill(inputMem)
        End If
    End Sub

    Private Sub checkEdit()
        addPanel.Enabled = True
        btnEdit.Visible = True
        btnSave.Visible = False
        btnReset.Visible = False
        lblHeader.Text = "Edit Package"
        txtID.Enabled = False

    End Sub

    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM Package"
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            PackageDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub autoID()
        Dim num As Integer

        Sqlcon.Open()
        Dim cmd = New SqlCommand("Select max(ID) from Package", Sqlcon)
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtID.Text = "" Then
            MessageBox.Show("Fill in the ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPackageName.Text = "" Then
            MessageBox.Show("Fill in the Package Name space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPackageFees.Text = "" Then
            MessageBox.Show("Fill in the Package Fees space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDescription.Text = "" Then
            MessageBox.Show("Fill in the Description space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO Package VALUES ('" & txtID.Text & "', '" & txtPackageName.Text & "',
                '" & txtPackageFees.Text & "','" & txtDescription.Text & "') "

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtID.Text = "" Then
            MessageBox.Show(" Search by ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dr = DialogResult.Yes Then
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " DELETE FROM Package WHERE ID='" & txtID.Text & "'"
                com.ExecuteNonQuery()
                Sqlcon.Close()
                MessageBox.Show("Package successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateGrid()

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
            txtID.Text = SQLReader.Item("ID")
            txtPackageName.Text = SQLReader.Item("PackageName")
            txtPackageFees.Text = SQLReader.Item("PackageFees")
            txtDescription.Text = SQLReader.Item("Description")


            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtID.Text = "" Then
            MessageBox.Show("Fill in the ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPackageName.Text = "" Then
            MessageBox.Show("Fill in the Package Name space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPackageFees.Text = "" Then
            MessageBox.Show("Fill in the Package Fees space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDescription.Text = "" Then
            MessageBox.Show("Fill in the Description space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE Package SET PackageName= '" & txtPackageName.Text & "',
                PackageFees= '" & txtPackageFees.Text & "',
                Description='" & txtDescription.Text & "' WHERE ID=" & txtID.Text

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



    Sub Reset()
        txtID.Text = String.Empty
        txtPackageName.Text = String.Empty
        txtDescription.Text = String.Empty
        txtPackageFees.Text = String.Empty
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
        autoID()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim qry As String = "SELECT * FROM Package where ID like '%" + txtSearch.Text + "%'"
            Dim cmd As New SqlCommand(qry, Sqlcon)
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            PackageDataGrid.DataSource = ds
            Sqlcon.Close()
            autoFill(qry)
            checkEdit()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub
End Class
