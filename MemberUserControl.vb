Imports System.Data.SqlClient
Imports System.IO
Public Class MemberUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")


    Private Sub studentsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()
        callNotice()

    End Sub

    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM MembershipReg "
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cmbColumns.Text = "Name" Then

            Dim qry As String = "SELECT * FROM MembershipReg where Name like '%" + txtSearch.Text.ToString() + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds
            Sqlcon.Close()

        ElseIf cmbColumns.Text = "Member_ID" Then

            Dim qry As String = "SELECT * FROM MembershipReg where Member_ID like '" + txtSearch.Text.ToString() + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds
            Sqlcon.Close()

        Else
            Dim qry As String = "SELECT * FROM MembershipReg where Member_ID like '" + txtSearch.Text.ToString() + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds
            Sqlcon.Close()

        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtSearch.Text = "" Then
            MessageBox.Show(" Search an  Member_ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            Dim dr As DialogResult
                dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If dr = DialogResult.Yes Then
                    Try
                        Sqlcon.Open()
                        Dim com As SqlCommand = Sqlcon.CreateCommand()
                        com.CommandText = " DELETE FROM MembershipReg WHERE Member_ID='" & txtSearch.Text & "'"
                        com.ExecuteNonQuery()
                        Sqlcon.Close()
                        MessageBox.Show("Record successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        Sqlcon.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try


                End If


            UpdateGrid()
        End If
    End Sub

    Private Sub autoSearch()
        Try
            Dim cmd As New SqlCommand("select Member_ID from MembershipReg", Sqlcon)
            Sqlcon.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim myColl As New AutoCompleteStringCollection()
            While dr.Read()
                myColl.Add(dr.GetString(0))
            End While
            txtSearch.AutoCompleteCustomSource = myColl
            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtSearch.Text = String.Empty Then
            MessageBox.Show("Input or Search Member_ID first ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If cmbColumns.SelectedItem = "Name" Then
                MessageBox.Show("Search Member_ID to Edit ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim UpdateMem As New MemberForm
                UpdateMem.Show()
                UpdateMem.btnPrintMember.Visible = True
                UpdateMem.btnSave.Visible = False
                UpdateMem.btnReset.Visible = False

                UpdateMem.lblHeader.Text = "Edit Member"
                Dim inputMem As String
                inputMem = txtSearch.Text
                UpdateMem.UpdateMembership(inputMem)
            End If

        End If
    End Sub


    Public Sub autoIDGenerate()

        Dim num As Integer
        Dim result As String
        Sqlcon.Open()

        Dim cmd = New SqlCommand("Select max(Member_ID) from MembershipReg", Sqlcon)
        result = cmd.ExecuteScalar().ToString
        If String.IsNullOrEmpty(result) Then
            result = "GYM0001"
            MemberForm.txtMemberID.Text = result
        Else
            result = result.Substring(3)
            Int32.TryParse(result, num)
            num = num + 1
            result = "GYM" + num.ToString("D4")
            MemberForm.txtMemberID.Text = result
        End If

        Sqlcon.Close()


    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MemberForm.Show()
        MemberForm.btnEdit.Visible = False
        autoIDGenerate()
    End Sub


    Sub callNotice()


        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM MembershipReg "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            While SQLReader.Read()
                Dim notice As New ExpiredUserControl
                notice.lblMemberId.Text = SQLReader.Item("Member_Id").ToString
                notice.lblName.Text = SQLReader.Item("Name").ToString
                notice.lblPackage.Text = SQLReader.Item("MembershipType").ToString
                notice.lblLastRenewed.Text = SQLReader.Item("RenewalDate").ToString


                Dim img() As Byte
                img = SQLReader.Item("Picture")
                Dim ms As New MemoryStream(img)
                notice.PicBox.Image = Image.FromStream(ms)

                Dim input1 As String = SQLReader.Item("RenewalDate")

                Dim d1 As DateTime = DateTime.Parse(input1).Date
                Dim d2 As DateTime = DateTime.Now
                Dim daysLeft As Int32 = Convert.ToInt32((d1 - d2).TotalDays)

                If daysLeft < 6 Then

                    expireNoticeContainer.Controls.Add(notice)


                End If

            End While
            SQLReader.Close()
            Sqlcon.Close()


        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







End Class
