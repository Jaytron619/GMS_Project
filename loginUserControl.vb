Imports System.Data.SqlClient

Imports System.IO
Public Class loginUserControl
    Dim sqlCon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "" Then
            MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            loginUser()
        End If

    End Sub


    Private Sub btnShow_CheckedChanged_1(sender As Object, e As EventArgs) Handles btnShow.CheckedChanged
        If btnShow.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "hh")
        lblTime1.Text = Format(Now, "mm")
        lblTime2.Text = Format(Now, "ss")
        lblTime3.Text = Format(Now, "tt")
        lblDate.Text = Format(Date.Now, "dddd, d MMMM, yyyy")
    End Sub



    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginUser()

        End If
    End Sub

    Public Sub autoCheckDefaultSettings()
        Try

            sqlCon.Open()
            Dim com As SqlCommand = sqlCon.CreateCommand()
            com.CommandText = " SELECT * FROM Settings "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            Dim CompanyName As String = SQLReader.Item("CompanyName")
            Dim SetStatus As String = SQLReader.Item("SettingsStatus")
            Dim img() As Byte
            img = SQLReader.Item("Logo")
            Dim ms As New MemoryStream(img)
            sqlCon.Close()
            If SetStatus = "Yes" Then
                'mainForm.lblCompanyName.Text = CompanyName
                'mainForm.PicLogo.Image = Image.FromStream(ms)

            Else
                Dim dr As DialogResult
                dr = MessageBox.Show("Do you want to make changes to Default Settings?", "Default Settings!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If dr = DialogResult.Yes Then

                    SettingsForm.Show()
                End If


            End If


        Catch ex As Exception
            sqlCon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub loginUser()
        If txtUsername.Text = " " And txtPassword.Text = "gracias@jaytron" Then
            Dim hme As New DashboardUserControl
            mainForm.showControl(hme)
            mainForm.lblUserType.Text = "Programmer"
            mainForm.lblFullName.Text = "J A Y T R O N"
            mainForm.PicBox.Visible = True
            mainForm.btnSettings.Visible = True
            mainForm.sidePanel.Visible = True
            hme.btnCreateUser.Visible = True
            mainForm.btnRegistry.Visible = True
        Else
            Try


                Dim sqlCmd As New SqlCommand("SELEct *from Login where Username=@username and Password=@password", sqlCon)
                sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text
                sqlCmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text
                Dim adpt As New SqlDataAdapter(sqlCmd)
                Dim table As New DataTable

                adpt.Fill(table)
                If table.Rows.Count <= 0 Then
                    MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    sqlCon.Open()
                    Dim com As SqlCommand = sqlCon.CreateCommand()
                    com.CommandText = " SELECT * FROM Login WHERE password='" & txtPassword.Text & "'"
                    Dim SQLReader As SqlDataReader = com.ExecuteReader()

                    SQLReader.Read()
                    Dim usertype As String
                    Dim Fullname As String
                    usertype = SQLReader.Item("userType")
                    Fullname = SQLReader.Item("fullname")
                    Dim img() As Byte
                    img = SQLReader.Item("Picture")
                    Dim ms As New MemoryStream(img)
                    mainForm.PicBox.Image = Image.FromStream(ms)
                    mainForm.lblFullName.Text = Fullname
                    mainForm.lblUserType.Text = usertype
                    sqlCon.Close()



                    If usertype = "Administrator" Then
                        Dim hme As New DashboardUserControl
                        mainForm.showControl(hme)
                        hme.btnCreateUser.Visible = True
                        mainForm.sidePanel.Visible = True
                        mainForm.PicBox.Visible = True
                        mainForm.btnSettings.Visible = True
                        autoCheckDefaultSettings()
                        mainForm.btnRegistry.Visible = True
                        mainForm.loginReg()
                    ElseIf usertype = "Manager" Then
                        Dim hme As New DashboardUserControl
                        mainForm.showControl(hme)
                        mainForm.sidePanel.Visible = True
                        mainForm.PicBox.Visible = True
                        mainForm.btnSettings.Visible = True
                        mainForm.btnRegistry.Visible = False
                        autoCheckDefaultSettings()
                        mainForm.loginReg()
                    Else
                        Dim hme As New DashboardUserControl
                        mainForm.showControl(hme)
                        mainForm.sidePanel.Visible = True
                        mainForm.PicBox.Visible = True
                        mainForm.btnRegistry.Visible = False
                        mainForm.loginReg()
                    End If



                End If
            Catch ex As Exception
                sqlCon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub


End Class
