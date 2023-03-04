Imports System.Data.SqlClient
Imports System.IO

Public Class mainForm
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Public Sub showControl(scontrol As Control)
        contentPanel.Controls.Clear()
        scontrol.Dock = DockStyle.Fill
        scontrol.BringToFront()
        scontrol.Focus()
        scontrol.BackColor = Color.FromArgb(240, 240, 240)
        contentPanel.Controls.Add(scontrol)
    End Sub

    Sub callNotice()

        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM MembershipReg "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            While SQLReader.Read()
                Dim notice As New NoticeUserControl
                Dim input1 As String = SQLReader.Item("RenewalDate")
                Dim d1 As DateTime = DateTime.Parse(input1).Date
                Dim d2 As DateTime = DateTime.Now
                Dim daysLeft As Int32 = Convert.ToInt32((d1 - d2).TotalDays)

                If daysLeft = 6 Or 5 Then
                    'notice.EmailNotification()
                    notice.notifyMember2()

                End If

            End While
            SQLReader.Close()
            Sqlcon.Close()


        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New loginUserControl
        Guna2ShadowForm1.SetShadowForm(Me)
        showControl(login)
        sidePanel.Visible = False
        autoFill()
        callNotice()

    End Sub

    Public Sub autoFill()
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM Settings "
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            Dim CompanyName As String = SQLReader.Item("CompanyName")
            Dim SetStatus As String = SQLReader.Item("SettingsStatus")
            Dim img() As Byte
            img = SQLReader.Item("Logo")
            Dim ms As New MemoryStream(img)
            Sqlcon.Close()
            If SetStatus = "Yes" Then
                lblCompanyName.Text = CompanyName
                PicLogo.Image = Image.FromStream(ms)

            End If

        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub






    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim home As New DashboardUserControl
        If lblUserType.Text = "Programmer" Then

            showControl(home)
            home.btnCreateUser.Visible = True

        ElseIf lblUserType.Text = "Administrator" Then
            showControl(home)
            home.btnCreateUser.Visible = True
        Else
            showControl(home)

        End If


    End Sub


    Private Sub btnStudents_Click_1(sender As Object, e As EventArgs) Handles btnViewMembers.Click
        Dim students As New MemberUserControl
        showControl(students)
    End Sub

    Private Sub btnStaff_Click_1(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim staff As New staffUserControl
        showControl(staff)
    End Sub

    Private Sub btnFees_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim pay As New PaymentUserControl
        showControl(pay)
    End Sub


    Private Sub btnEquipments_Click(sender As Object, e As EventArgs) Handles btnEquipments.Click
        Dim Equipments As New EquipmentsUserControl
        showControl(Equipments)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim Attendance As New AttendanceUserControl
        showControl(Attendance)
    End Sub

    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        Dim Shift As New ShiftUserControl
        showControl(Shift)
    End Sub

    Private Sub btnPackage_Click(sender As Object, e As EventArgs) Handles btnPackage.Click
        Dim Package As New PackageUserControl
        showControl(Package)
    End Sub

    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        Dim Expenses As New ExpensesUserControl
        showControl(Expenses)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingsForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dr As DialogResult
        dr = MessageBox.Show("Are you sure you want close the application?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dr = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New loginUserControl
        showControl(login)
        sidePanel.Visible = False
        btnSettings.Visible = False

    End Sub

    Private Sub btnRegistry_Click(sender As Object, e As EventArgs) Handles btnRegistry.Click
        LoginRegistryForm.Show()
    End Sub
    Public Sub loginReg()
        Try
            Dim dateLogin As String = Date.Now.ToString("dddd d MMMM,yyyy")
            Dim timeLogin As String = DateTime.Now.ToString("hh:mm")

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " INSERT INTO LoginRegistry VALUES ('" & lblFullName.Text & "', 
                        '" & lblUserType.Text & "', '" & dateLogin & "',
                        '" & timeLogin & "') "

            If com.ExecuteNonQuery() > 0 Then

            End If
            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub

End Class