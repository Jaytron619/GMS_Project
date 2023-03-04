Imports System.IO.Ports
Public Class SMSForm
    Dim GlobalSMS As String = ""
    Private Sub btnSMS_Click(sender As Object, e As EventArgs) Handles btnSMS.Click
        Dim mess As New SentControl
        If txtNumber.Text = "" And txtMessage.Text = "" Then

            MessageBox.Show("Enter the Number and the Message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtNumber.Text = "" Then
            MessageBox.Show("Enter the Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtMessage.Text = "" Then
            MessageBox.Show("Enter the Message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            messageContainer.Controls.Add(mess)
            mess.lblNumber.Text = txtNumber.Text
            mess.lblMessage.Text = txtMessage.Text
            mess.BackColor = Color.White
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
                GlobalSMS = txtMessage.Text
                SerialPort1.Open()
                If SerialPort1.IsOpen = True Then
                    SerialPort1.Write("AT" & vbCrLf)
                    SerialPort1.Write("AT+CMGF=1" & vbCrLf)
                    SerialPort1.Write("AT+CMGS=" & Chr(34) & (txtNumber.Text) & Chr(34) & vbCrLf)
                    SerialPort1.Write(GlobalSMS & Chr(26))

                    SerialPort1.Close()
                End If

                txtMessage.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Close()
    End Sub

    Private Sub SMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "hh:mm")
    End Sub
End Class