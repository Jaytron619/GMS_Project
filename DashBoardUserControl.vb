Imports System.Data.SqlClient
Imports System.IO
Public Class DashboardUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "hh:mm:ss tt")
        lblDate.Text = Format(Date.Now, "dd MMMM,yyyy")
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM Login WHERE Id='" & cmbSearch.SelectedItem & "'"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            txtID.Text = SQLReader.Item("Id")
            cmbUserType.Text = SQLReader.Item("userType")
            txtFullname.Text = SQLReader.Item("fullname")
            txtUsername.Text = SQLReader.Item("username")
            txtPassword.Text = SQLReader.Item("password")

            Dim img() As Byte
            img = SQLReader.Item("Picture")
            Dim ms As New MemoryStream(img)
            PicBox.Image = Image.FromStream(ms)


            Sqlcon.Close()
            txtID.Enabled = False
        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateCombo()
        cmbSearch.Items.Clear()

        Try
            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM Login"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            While SQLReader.Read()
                cmbSearch.Items.Add(SQLReader.Item("id"))

            End While
            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtID.Text = "" And txtUsername.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Fill in the spaces provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim ms As New MemoryStream
                PicBox.Image.Save(ms, PicBox.Image.RawFormat)
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO Login VALUES ('" & txtID.Text & "', '" & cmbUserType.SelectedItem & "', 
                '" & txtFullname.Text & "', '" & txtUsername.Text & "','" & txtPassword.Text & "' , @img)"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Insertion was successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                Sqlcon.Close()
                Clear()
                autoID()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Clear()
                autoID()
            End Try

            UpdateCombo()
        End If

    End Sub
    Private Sub autoID()
        Dim num As Integer

        Sqlcon.Open()
        Dim cmd = New SqlCommand("Select max(ID) from Login", Sqlcon)
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

    Private Sub Clear()
        txtID.Text = String.Empty
        txtUsername.Text = String.Empty
        txtFullname.Text = String.Empty
        cmbUserType.Text = ""
        txtPassword.Text = String.Empty


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtID.Text = "" Then
            MessageBox.Show(" Select an Receipt ID and edit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim ms As New MemoryStream
                PicBox.Image.Save(ms, PicBox.Image.RawFormat)
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE Login SET 
                userType= '" & cmbUserType.SelectedItem & "',fullname= '" & txtFullname.Text & "',
                username='" & txtUsername.Text & "',password='" & txtPassword.Text & "', Picture=@img where Id= " & txtID.Text

                com.Parameters.Add("@img", SqlDbType.Image).Value = MS.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record was edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
                Clear()
                autoID()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        UpdateCombo()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtID.Text = "" Then
            MessageBox.Show(" Select an Receipt ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dr = DialogResult.Yes Then
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " DELETE FROM Login WHERE Id='" & txtID.Text & "'"
                com.ExecuteNonQuery()
                Sqlcon.Close()
                MessageBox.Show("User account successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            autoID()
        End If

        UpdateCombo()
    End Sub

    Private Sub btnCloseSignUp_Click(sender As Object, e As EventArgs) Handles btnCloseSignUp.Click
        locationPanel2()
        Dim create As New mainForm
        btnCreateUser.Enabled = True
        Clear()


    End Sub

    Sub locationPanel()
        signUpPanel.Location = New Point(1012, 0)
        Do Until signUpPanel.Location.X = 734
            signUpPanel.Location = New Point(signUpPanel.Location.X - 2, 0)
        Loop

        Do Until signUpPanel.Location.X = 720
            signUpPanel.Location = New Point(signUpPanel.Location.X - 2, 0)
            Refresh()
            Threading.Thread.Sleep(20)
        Loop
    End Sub
    Sub locationPanel2()
        signUpPanel.Location = New Point(720, 0)
        Do Until signUpPanel.Location.X = 1008
            signUpPanel.Location = New Point(signUpPanel.Location.X + 2, 0)
        Loop

        Do Until signUpPanel.Location.X = 1012
            signUpPanel.Location = New Point(signUpPanel.Location.X + 2, 0)
            Refresh()
            Threading.Thread.Sleep(20)
        Loop
    End Sub

    Public Sub autoFill()
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM Settings "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()

            Dim SetStatus As String = SQLReader.Item("SettingsStatus")
            Dim img() As Byte
            img = SQLReader.Item("Logo")
            Dim ms As New MemoryStream(img)
            Sqlcon.Close()
            If SetStatus = "Yes" Then

                PicLogo.Image = Image.FromStream(ms)

            End If

        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub

    Private Sub homeUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountEquuipments()
        CountExpenses()
        CountMembers()
        CountRevenue()
        CountStaff()
        UpdateCombo()
        callNotice()
        callPackagenotice()
        autoFill()
    End Sub

    Sub callNotice()


        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM MembershipReg "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            While SQLReader.Read()
                Dim notice As New NoticeUserControl
                notice.lblMemberId.Text = SQLReader.Item("Member_Id").ToString
                notice.lblName.Text = SQLReader.Item("Name").ToString
                notice.lblMobile.Text = SQLReader.Item("Mobile").ToString
                notice.lblEmail.Text = SQLReader.Item("Email").ToString


                Dim img() As Byte
                img = SQLReader.Item("Picture")
                Dim ms As New MemoryStream(img)
                notice.PicBox.Image = Image.FromStream(ms)

                Dim input1 As String = SQLReader.Item("RenewalDate")
                Dim checkSMS As String = SQLReader.Item("checkSMS")
                Dim d1 As DateTime = DateTime.Parse(input1).Date
                Dim d2 As DateTime = DateTime.Now
                Dim daysLeft As Int32 = Convert.ToInt32((d1 - d2).TotalDays)
                notice.lblDaysLeft.Text = daysLeft.ToString
                If daysLeft > -1 And daysLeft < 6 Then
                    If checkSMS = "No" Then
                        NoticeContainer1.Controls.Add(notice)

                    End If
                End If
            End While
            SQLReader.Close()
            Sqlcon.Close()


        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub callPackagenotice()


        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT  * FROM Package  "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            While SQLReader.Read()
                Dim notice As New PackageNoticeUserControl
                notice.lblPackageName.Text = SQLReader.Item("PackageName")
                notice.lblPackageFee.Text = SQLReader.Item("PackageFees")
                notice.lblDescription.Text = SQLReader.Item("Description")

                NoticeContainer2.Controls.Add(notice)


            End While
            SQLReader.Close()
            Sqlcon.Close()


        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub CountStaff()
        Try
            Sqlcon.Open()
            Dim cmd As New SqlCommand("Select count(staffId) from staff", Sqlcon)
            Dim rows_count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            cmd.Dispose()
            Sqlcon.Close()

            lblStaff.Text = rows_count.ToString

        Catch ex As Exception
            Sqlcon.Close()
        End Try
    End Sub

    Public Sub CountRevenue()
        Try
            Sqlcon.Open()
            Dim cmd As New SqlCommand("Select sum(amountPaid) from Payments ", Sqlcon)
            Dim rows_count As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
            cmd.Dispose()
            Sqlcon.Close()

            lblRevenue.Text = "GHc " + rows_count.ToString

        Catch ex As Exception
            Sqlcon.Close()
        End Try
    End Sub

    Public Sub CountEquuipments()
        Try
            Sqlcon.Open()
            Dim cmd As New SqlCommand("Select count(ID) from Equipments", Sqlcon)
            Dim rows_count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            cmd.Dispose()
            Sqlcon.Close()

            lblEquipments.Text = rows_count.ToString

        Catch ex As Exception
            Sqlcon.Close()
        End Try
    End Sub

    Public Sub CountExpenses()
        Try
            Sqlcon.Open()
            Dim cmd As New SqlCommand("Select sum(Amount) from Expenses ", Sqlcon)
            Dim rows_count As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
            cmd.Dispose()
            Sqlcon.Close()

            lblExpenses.Text = "GHc " + rows_count.ToString

        Catch ex As Exception
            Sqlcon.Close()
        End Try
    End Sub

    Public Sub CountMembers()
        Try
            Sqlcon.Open()
            Dim cmd As New SqlCommand("Select count(Member_ID) from MembershipReg", Sqlcon)
            Dim rows_count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            cmd.Dispose()
            Sqlcon.Close()

            lblMembers.Text = rows_count.ToString

        Catch ex As Exception
            Sqlcon.Close()
        End Try
    End Sub


    Dim imageLocation As String

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Try
            Dim dialog As New OpenFileDialog()
            dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All files (*.*)|*.*"
            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                imageLocation = dialog.FileName
                PicBox.ImageLocation = imageLocation
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSMS_Click(sender As Object, e As EventArgs) Handles btnSMS.Click
        SMSForm.Show()
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        locationPanel()

        btnCreateUser.Enabled = False
        autoID()
    End Sub
End Class
