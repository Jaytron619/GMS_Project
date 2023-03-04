Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Net.Mail
Public Class RenewalForm
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Private Sub RenewalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        UpdateCombo()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub UpdateMembership(ByVal inputMem)

        Try

            Sqlcon.Open()

            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT *FROM MembershipReg WHERE Member_ID like '%" & inputMem & "%'"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()

            lblMemberId.Text = SQLReader.Item("Member_ID")
            lblName.Text = SQLReader.Item("Name")
            lblMobile.Text = SQLReader.Item("Mobile")
            lblEmail.Text = SQLReader.Item("Email")
            cmbPackageType.Text = SQLReader.Item("MembershipType")
            dtpRenewalDate.Value = SQLReader.Item("RenewalDate")


            Dim img() As Byte
            img = SQLReader.Item("Picture")
            Dim ms As New MemoryStream(img)
            PicBox.Image = Image.FromStream(ms)

            Sqlcon.Close()

        Catch ex As Exception
            Sqlcon.Close()

        End Try


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

    Dim GlobalSMS As String = ""

    Public Sub notifyRenewal()

        Dim mess As String = "Package Renewed!!. 
Your membership expires " & dtpRenewalDate.Value.ToString("dd MMMM,yyyy") & ". " & mainForm.lblCompanyName.Text & "! Your health is our priority. Thank You!"

        SMSNotification(mess)

    End Sub

    Public Sub SMSNotification(mess As String)

        Try
            SerialPort1 = New SerialPort
            SerialPort1.PortName = "COM11"
            SerialPort1.BaudRate = 9600
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.Handshake = Handshake.RequestToSend
            SerialPort1.DtrEnable = True
            SerialPort1.RtsEnable = True
            SerialPort1.NewLine = vbCrLf
            GlobalSMS = mess.ToString
            SerialPort1.Open()
            If SerialPort1.IsOpen = True Then
                SerialPort1.Write("AT" & vbCrLf)
                SerialPort1.Write("AT+CMGF=1" & vbCrLf)
                SerialPort1.Write("AT+CMGS=" & Chr(34) & (lblMobile.Text) & Chr(34) & vbCrLf)
                SerialPort1.Write(GlobalSMS & Chr(26))

                SerialPort1.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If cmbPackageType.Text = "" Then
                MessageBox.Show("Please make sure to select the package type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE MembershipReg SET MembershipType='" & cmbPackageType.SelectedItem & "',
                RenewalDate='" & dtpRenewalDate.Value.ToString("dd MMMM,yyyy") & "',  checkSMS='No'
                WHERE Member_ID='" & lblMemberId.Text & "'"

                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Membership Renewed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    notifyRenewal()
                End If
                Sqlcon.Close()

                Dim students As New MemberUserControl
                mainForm.showControl(students)

                Me.Close()
            End If
        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class