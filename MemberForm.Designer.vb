<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberForm))
        Me.dtpRenewalDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpJoiningDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbPackageType = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRegionState = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnPrintMember = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpRenewalDate
        '
        Me.dtpRenewalDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRenewalDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRenewalDate.Location = New System.Drawing.Point(407, 20)
        Me.dtpRenewalDate.Name = "dtpRenewalDate"
        Me.dtpRenewalDate.Size = New System.Drawing.Size(173, 22)
        Me.dtpRenewalDate.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(294, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 17)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Renewal Date"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 17)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Package Type"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Joining Date"
        '
        'dtpJoiningDate
        '
        Me.dtpJoiningDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpJoiningDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJoiningDate.Location = New System.Drawing.Point(407, 179)
        Me.dtpJoiningDate.Name = "dtpJoiningDate"
        Me.dtpJoiningDate.Size = New System.Drawing.Size(159, 22)
        Me.dtpJoiningDate.TabIndex = 13
        '
        'cmbPackageType
        '
        Me.cmbPackageType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbPackageType.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPackageType.FormattingEnabled = True
        Me.cmbPackageType.Location = New System.Drawing.Point(103, 19)
        Me.cmbPackageType.Name = "cmbPackageType"
        Me.cmbPackageType.Size = New System.Drawing.Size(159, 25)
        Me.cmbPackageType.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 17)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Member ID"
        '
        'dtpDOB
        '
        Me.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDOB.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(102, 157)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(159, 22)
        Me.dtpDOB.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gender"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Date of Birth"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(102, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(159, 22)
        Me.txtName.TabIndex = 2
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(407, 151)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(159, 22)
        Me.txtPostalCode.TabIndex = 12
        '
        'txtCountry
        '
        Me.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCountry.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(407, 119)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(159, 22)
        Me.txtCountry.TabIndex = 11
        '
        'cmbGender
        '
        Me.cmbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(102, 58)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(159, 25)
        Me.cmbGender.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Email "
        '
        'txtRegionState
        '
        Me.txtRegionState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRegionState.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegionState.Location = New System.Drawing.Point(407, 87)
        Me.txtRegionState.Name = "txtRegionState"
        Me.txtRegionState.Size = New System.Drawing.Size(159, 22)
        Me.txtRegionState.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(289, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Region/ State"
        '
        'txtCity
        '
        Me.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCity.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(407, 55)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(159, 22)
        Me.txtCity.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(289, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 17)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Country"
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMobilePhone.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobilePhone.Location = New System.Drawing.Point(102, 93)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Size = New System.Drawing.Size(159, 22)
        Me.txtMobilePhone.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(289, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 17)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Zip/Postal Code"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "City"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Mobile"
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadImage.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadImage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUploadImage.Location = New System.Drawing.Point(26, 235)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(141, 32)
        Me.btnUploadImage.TabIndex = 0
        Me.btnUploadImage.Text = "Upload Image"
        Me.btnUploadImage.UseVisualStyleBackColor = False
        '
        'txtMemberID
        '
        Me.txtMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMemberID.BackColor = System.Drawing.Color.White
        Me.txtMemberID.Enabled = False
        Me.txtMemberID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberID.Location = New System.Drawing.Point(28, 302)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(100, 22)
        Me.txtMemberID.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(102, 125)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(159, 22)
        Me.txtEmail.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 39)
        Me.Panel1.TabIndex = 76
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(771, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 19)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(24, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(115, 21)
        Me.lblHeader.TabIndex = 77
        Me.lblHeader.Text = "Add Member"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHeight.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(103, 182)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(159, 22)
        Me.txtHeight.TabIndex = 7
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtWeight.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(407, 27)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(159, 22)
        Me.txtWeight.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Height (cm)"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Weight (Kg)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMobilePhone)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpJoiningDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPostalCode)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtRegionState)
        Me.GroupBox1.Controls.Add(Me.txtCountry)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(183, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 210)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbPackageType)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.dtpRenewalDate)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(183, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 59)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.VbProjet.My.Resources.Resources.update_file_25px
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(355, 384)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 32)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Update"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnPrintMember
        '
        Me.btnPrintMember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrintMember.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintMember.FlatAppearance.BorderSize = 0
        Me.btnPrintMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintMember.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPrintMember.Image = CType(resources.GetObject("btnPrintMember.Image"), System.Drawing.Image)
        Me.btnPrintMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintMember.Location = New System.Drawing.Point(721, 45)
        Me.btnPrintMember.Name = "btnPrintMember"
        Me.btnPrintMember.Size = New System.Drawing.Size(72, 31)
        Me.btnPrintMember.TabIndex = 19
        Me.btnPrintMember.Text = "Print"
        Me.btnPrintMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrintMember.UseVisualStyleBackColor = False
        Me.btnPrintMember.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(404, 383)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 34)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(308, 383)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 34)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'imageBox
        '
        Me.imageBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imageBox.Image = CType(resources.GetObject("imageBox.Image"), System.Drawing.Image)
        Me.imageBox.Location = New System.Drawing.Point(28, 94)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(137, 137)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 74
        Me.imageBox.TabStop = False
        '
        'MemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 431)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnPrintMember)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnUploadImage)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.txtMemberID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MemberForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpRenewalDate As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpJoiningDate As DateTimePicker
    Friend WithEvents cmbPackageType As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRegionState As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMobilePhone As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents imageBox As PictureBox
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrintMember As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
