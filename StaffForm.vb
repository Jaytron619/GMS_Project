Imports System.Data.SqlClient
Imports System.IO
Public Class StaffForm
    Dim Sqlcon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VbProjectDatabase.mdf;Integrated Security=True")



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtStaffID.Text = "" Then
            MessageBox.Show("Fill in the staff ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbGender.Text = "" Then
            MessageBox.Show("Fill in the Gender space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtSalary.Text = "" Then
            MessageBox.Show("Fill in the Salary space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Fill in the Email space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPhoneNumber.Text Then
            MessageBox.Show("Fill in the Phone number space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbStaffDesignation.Text = "" Then
            MessageBox.Show("Fill in the Staff Designation space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbShift.Text Then
            MessageBox.Show("Fill in the Shift space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAge.Text = "" Then
            MessageBox.Show("Fill in the Age space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ms As New MemoryStream
            imageBox.Image.Save(ms, imageBox.Image.RawFormat)
            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO staff VALUES ('" & txtStaffID.Text & "', '" & txtName.Text & "', 
                '" & cmbGender.SelectedItem & "','" & txtAge.Text & "','" & txtPhoneNumber.Text & "', '" & txtEmail.Text & "',
                '" & cmbStaffDesignation.SelectedItem & "','" & txtSalary.Text & "',
                '" & dtpDateEmployed.Value.ToString("dd MMMM,yyyy") & "','" & cmbShift.SelectedItem & "', @img)"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Insertion was successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                Sqlcon.Close()

            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        End If
    End Sub


    Private Sub UpdateCombo()
        cmbShift.Items.Clear()

        Sqlcon.Open()
        Dim com As SqlCommand = Sqlcon.CreateCommand()
        com.CommandText = " SELECT * FROM Shift "
        Dim SQLReader As SqlDataReader = com.ExecuteReader()

        While SQLReader.Read()
            cmbShift.Items.Add(SQLReader.Item("ShiftName"))

        End While
        Sqlcon.Close()

    End Sub

    Private Sub Clear()
        txtStaffID.Text = String.Empty
        txtName.Text = String.Empty
        cmbGender.Text = ""
        txtEmail.Text = String.Empty
        txtAge.Text = String.Empty
        txtPhoneNumber.Text = String.Empty
        txtEmail.Text = String.Empty
        dtpDateEmployed.Value = Date.Now
        txtSalary.Text = String.Empty
        cmbStaffDesignation.Text = ""

        imageBox.Image = Nothing
    End Sub


    Public Sub autoFill(ByVal inputMem)
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT *FROM Staff WHERE StaffID like '%" & inputMem & "%'"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            txtStaffID.Text = SQLReader.Item("StaffID")
            txtName.Text = SQLReader.Item("Name")
            cmbGender.Text = SQLReader.Item("Gender")
            txtAge.Text = SQLReader.Item("Age")
            txtPhoneNumber.Text = SQLReader.Item("PhoneNumber")
            txtEmail.Text = SQLReader.Item("EmailAddress")
            cmbStaffDesignation.Text = SQLReader.Item("StaffDesignation")
            txtSalary.Text = SQLReader.Item("Salary")
            dtpDateEmployed.Value = SQLReader.Item("DateEmployed")
            cmbShift.Text = SQLReader.Item("StaffDesignation")

            Dim img() As Byte
            img = SQLReader.Item("Picture")
            Dim ms As New MemoryStream(img)
            imageBox.Image = Image.FromStream(ms)

            Sqlcon.Close()
        Catch ex As Exception
            Sqlcon.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtStaffID.Text = "" Then
            MessageBox.Show("Fill in the staff ID space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbGender.Text = "" Then
            MessageBox.Show("Fill in the Gender space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtSalary.Text = "" Then
            MessageBox.Show("Fill in the Salary space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Fill in the Email space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPhoneNumber.Text Then
            MessageBox.Show("Fill in the Phone number space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbStaffDesignation.Text = "" Then
            MessageBox.Show("Fill in the Staff Designation space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbShift.Text Then
            MessageBox.Show("Fill in the Shift space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAge.Text = "" Then
            MessageBox.Show("Fill in the Age space provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim ms As New MemoryStream
                imageBox.Image.Save(ms, imageBox.Image.RawFormat)
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE staff SET Name= '" & txtName.Text & "',
            Gender= '" & cmbGender.SelectedItem & "',Age= '" & txtAge.Text & "',
            PhoneNumber= '" & txtPhoneNumber.Text & "',EmailAddress= '" & txtEmail.Text & "',
            StaffDesignation= '" & cmbStaffDesignation.SelectedItem & "', 
            Salary='" & txtSalary.Text & "',
            DateEmployed='" & dtpDateEmployed.Value.ToString("dd MMMM,yyyy") & "',Shift= '" & cmbShift.SelectedItem & "',  Picture=@img
            WHERE StaffID='" & txtStaffID.Text & "'"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record was edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
            Catch ex As Exception
                Sqlcon.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
        Dim stff As New staffUserControl
        stff.autoIDGenerate()

    End Sub

    Private Sub AddStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        UpdateCombo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class