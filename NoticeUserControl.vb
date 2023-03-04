
Imports System.IO.Ports
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports System.Net.Mail
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Resources
Imports System.Data.SqlClient
Public Class NoticeUserControl
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")

    Dim GlobalSMS As String = ""

    Public Sub notifyMemberEmail()

        Dim mess As String = "Your package is about to expire in " & lblDaysLeft.Text & " days! " & lblName.Text & ".
Visit " & mainForm.lblCompanyName.Text & " to renew your memebership. Your health is our priority. Thank You!"
        EmailNotification(mess)

    End Sub


    Public Sub EmailNotification(GlobalEmail As String)

        Try
            Dim emailMessage As New MailMessage

            emailMessage.From = New MailAddress("jaytronix619@gmail.com")
            emailMessage.To.Add(lblEmail.Text)
            emailMessage.Subject = "Renew Package"
            emailMessage.Body = GlobalEmail

            Dim smtp As New SmtpClient("smtp.gmail.com", 587)
            smtp.Credentials = New System.Net.NetworkCredential("jaytronix619@gmail.com", "Inusah619")
            smtp.EnableSsl = True
            smtp.Send(emailMessage)
            MessageBox.Show("Message sent", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub notifyMember()

        Dim mess As String = "Your package is about to expire in " & lblDaysLeft.Text & " days! " & lblName.Text & ".
Visit " & mainForm.lblCompanyName.Text & " to renew your memebership. Your health is our priority. Thank You!"
        SMSNotification(mess)

    End Sub

    Public Sub notifyMember2()

        Dim mess As String = "Your package is about to expire in " & lblDaysLeft.Text & " days! " & lblName.Text & ".
Visit " & mainForm.lblCompanyName.Text & " to renew your memebership. Your health is our priority. Thank You!"
        SMSNotification2(mess)

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
                Dim dr As DialogResult
                dr = MessageBox.Show("Notification Sent Sucessfully!", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If dr = DialogResult.OK Then
                    checkSMS()
                    SerialPort1.Close()
                    Me.Parent.Controls.Remove(Me)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub SMSNotification2(mess As String)

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

        End Try

    End Sub

    Private Sub btnSENDsms_Click(sender As Object, e As EventArgs) Handles btnSENDsms.Click
        notifyMember()

        'EmailNotification()

    End Sub
    Public Sub checkSMS()
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " UPDATE MembershipReg SET checkSMS='Yes'
                WHERE Member_ID='" & lblMemberId.Text & "'"

            If com.ExecuteNonQuery() > 0 Then

            End If
            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()

        End Try
    End Sub

    Private Sub NoticeUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
