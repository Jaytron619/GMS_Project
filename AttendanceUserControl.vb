Imports System.Data.SqlClient
Public Class AttendanceUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub AttendanceUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoSearch()
        btnEdit.Visible = False
        addPanel.Enabled = False
        UpdateGrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtSearch.Text = "" Or txtSearch.Text = "Search by ID" Then
            MessageBox.Show("Input or Search an ID first ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            checkEdit()
            Dim inputMem As String = "SELECT * FROM Attendance where ID like '%" + txtSearch.Text + "%'"
            autoFill(inputMem)
        End If
    End Sub

    Private Sub checkEdit()
        addPanel.Enabled = True
        btnEdit.Visible = True
        btnSave.Visible = False
        btnReset.Visible = False
        lblHeader.Text = "Edit Attendance"

        txtMemberID.Enabled = False
        txtName.Enabled = False
    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addPanel.Enabled = True
        btnEdit.Visible = False
        btnSave.Visible = True
        btnReset.Visible = True
        lblHeader.Text = "Add Attendance"

        txtMemberID.Enabled = True
        txtName.Enabled = True
        autoSearch()
        autoID()
        Reset()
    End Sub

    Private Sub autoID()
        Dim num As Integer

        Sqlcon.Open()
        Dim cmd = New SqlCommand("Select max(ID) from Attendance", Sqlcon)
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


    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM Attendance"
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            AttendanceDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtSearch.Text = "" Then
            MessageBox.Show(" Search an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dr = DialogResult.Yes Then
                Try
                    Sqlcon.Open()
                    Dim com As SqlCommand = Sqlcon.CreateCommand()
                    com.CommandText = " DELETE FROM Attendance WHERE ID='" & txtID.Text & "'"
                    com.ExecuteNonQuery()
                    Sqlcon.Close()
                    MessageBox.Show("Attendance Record successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    Sqlcon.Close()
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


                UpdateGrid()

            End If

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDescription.Text = "" Then
            MessageBox.Show("Fill in the description space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtMemberID.Text = "" Then

            MessageBox.Show("Fill in the Member Id space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtName.Text = "" Then

            MessageBox.Show("Fill in the name space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO Attendance VALUES ('" & txtID.Text & "', '" & txtMemberID.Text & "',  '" & txtName.Text & "',  
               
                '" & dtpAttendanceDate.Value.ToString("dd MMMM,yyyy") & "', '" & txtDescription.Text & "') "

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




    Public Sub autoFill(ByVal inputMem)
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = inputMem
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            txtID.Text = SQLReader.Item("ID")
            txtName.Text = SQLReader.Item("Name")
            txtMemberID.Text = SQLReader.Item("Member_ID")
            dtpAttendanceDate.Value = SQLReader.Item("AttendanceDate")
            txtDescription.Text = SQLReader.Item("Description")


            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtDescription.Text = "" Then
            MessageBox.Show("Fill in the description space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtMemberID.Text = "" Then

            MessageBox.Show("Fill in the Member Id space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtName.Text = "" Then

            MessageBox.Show("Fill in the name space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE Attendance SET MemberID= '" & txtMemberID.Text & "',
                Name= '" & txtName.Text & "',AttendanceDate='" & dtpAttendanceDate.Value.ToString("dd MMMM,yyyy") & "',
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim qry As String = "SELECT * FROM Attendance where ID like '%" + txtSearch.Text + "%'"
            Dim cmd As New SqlCommand(qry, Sqlcon)
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            AttendanceDataGrid.DataSource = ds
            Sqlcon.Close()
            autoFill(qry)
            checkEdit()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub

    Private Sub txtSearchMId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchMId.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                Dim qry As String = " SELECT *FROM Attendance WHERE Member_ID like '%" & txtSearchMId.Text & "%'"
                Sqlcon.Open()
                Dim ad As New SqlDataAdapter(qry, Sqlcon)
                Dim ds As New DataTable()
                ad.Fill(ds)
                AttendanceDataGrid.DataSource = ds
                Sqlcon.Close()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
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
        txtSearchMId.AutoCompleteCustomSource = myColl
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
                txtName.Text = SQLReader.Item("Name")

                Sqlcon.Close()
                txtName.Enabled = False
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Sub Reset()
        txtMemberID.Text = String.Empty
        txtName.Text = String.Empty
        txtDescription.Text = String.Empty
        dtpAttendanceDate.Value = Date.Now
    End Sub

    Private Sub txtSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseDown
        If txtSearch.Text = "Search by ID" Then
            txtSearch.Text = String.Empty
            txtSearch.ForeColor = Color.Black
            checkEdit()

        End If
    End Sub



    Private Sub txtSearchMId_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSearchMId.MouseDown
        If txtSearchMId.Text = "Search by Member_ID" Then
            txtSearchMId.Text = String.Empty
            txtSearchMId.ForeColor = Color.Black
        ElseIf txtSearchMId.Text = String.Empty Then
            txtSearchMId.Text = "Search by Member_ID"
            txtSearchMId.ForeColor = Color.Gray
        End If
    End Sub





    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
        autoID()
    End Sub


End Class
