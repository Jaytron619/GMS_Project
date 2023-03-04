<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardUserControl))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMembers = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblEquipments = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblExpenses = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panel13 = New System.Windows.Forms.Panel()
        Me.NoticeContainer1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.NoticeContainer2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.signUpPanel = New System.Windows.Forms.Panel()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnCloseSignUp = New System.Windows.Forms.PictureBox()
        Me.btnSMS = New System.Windows.Forms.Button()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.signUpPanel.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseSignUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(32, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(107, 32)
        Me.lblDate.TabIndex = 59
        Me.lblDate.Text = "lblDate"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(807, 8)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(104, 32)
        Me.lblTime.TabIndex = 60
        Me.lblTime.Text = "lblTime"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.lblStaff)
        Me.Panel1.Location = New System.Drawing.Point(29, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 100)
        Me.Panel1.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(3, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 12)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Staff Members"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel7.Location = New System.Drawing.Point(0, 81)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(184, 19)
        Me.Panel7.TabIndex = 67
        '
        'lblStaff
        '
        Me.lblStaff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStaff.Location = New System.Drawing.Point(3, 11)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(45, 32)
        Me.lblStaff.TabIndex = 67
        Me.lblStaff.Text = "00"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblMembers)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Location = New System.Drawing.Point(225, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 100)
        Me.Panel2.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(0, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 12)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Total Members"
        '
        'lblMembers
        '
        Me.lblMembers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMembers.AutoSize = True
        Me.lblMembers.BackColor = System.Drawing.Color.DarkOrange
        Me.lblMembers.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembers.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMembers.Location = New System.Drawing.Point(3, 11)
        Me.lblMembers.Name = "lblMembers"
        Me.lblMembers.Size = New System.Drawing.Size(45, 32)
        Me.lblMembers.TabIndex = 69
        Me.lblMembers.Text = "00"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(0, 83)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(184, 18)
        Me.Panel8.TabIndex = 68
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblEquipments)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Location = New System.Drawing.Point(417, 122)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 100)
        Me.Panel3.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(3, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 12)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Total Equipments"
        '
        'lblEquipments
        '
        Me.lblEquipments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEquipments.AutoSize = True
        Me.lblEquipments.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipments.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEquipments.Location = New System.Drawing.Point(3, 11)
        Me.lblEquipments.Name = "lblEquipments"
        Me.lblEquipments.Size = New System.Drawing.Size(45, 32)
        Me.lblEquipments.TabIndex = 69
        Me.lblEquipments.Text = "00"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(-3, 82)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(188, 18)
        Me.Panel9.TabIndex = 68
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.lblExpenses)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Location = New System.Drawing.Point(612, 122)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 100)
        Me.Panel4.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(0, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 12)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Total Expenses"
        '
        'lblExpenses
        '
        Me.lblExpenses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpenses.AutoSize = True
        Me.lblExpenses.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenses.ForeColor = System.Drawing.SystemColors.Control
        Me.lblExpenses.Location = New System.Drawing.Point(3, 18)
        Me.lblExpenses.Name = "lblExpenses"
        Me.lblExpenses.Size = New System.Drawing.Size(116, 19)
        Me.lblExpenses.TabIndex = 69
        Me.lblExpenses.Text = "GHc 0000.00"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(-1, 81)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(184, 18)
        Me.Panel10.TabIndex = 68
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.lblRevenue)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Location = New System.Drawing.Point(804, 122)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(181, 100)
        Me.Panel5.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(0, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Total Revenue"
        '
        'lblRevenue
        '
        Me.lblRevenue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRevenue.Location = New System.Drawing.Point(3, 18)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(116, 19)
        Me.lblRevenue.TabIndex = 69
        Me.lblRevenue.Text = "GHc 0000.00"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(-2, 82)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(184, 17)
        Me.Panel11.TabIndex = 68
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Location = New System.Drawing.Point(30, 92)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(956, 24)
        Me.Panel6.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Location = New System.Drawing.Point(4, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 15)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "DarshBoard"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label12)
        Me.Panel12.Location = New System.Drawing.Point(30, 279)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(473, 27)
        Me.Panel12.TabIndex = 69
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Location = New System.Drawing.Point(193, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 20)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "NoticeBoard"
        '
        'panel13
        '
        Me.panel13.BackColor = System.Drawing.Color.White
        Me.panel13.Controls.Add(Me.NoticeContainer1)
        Me.panel13.Location = New System.Drawing.Point(30, 306)
        Me.panel13.Name = "panel13"
        Me.panel13.Size = New System.Drawing.Size(473, 304)
        Me.panel13.TabIndex = 69
        '
        'NoticeContainer1
        '
        Me.NoticeContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoticeContainer1.AutoScroll = True
        Me.NoticeContainer1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.NoticeContainer1.Location = New System.Drawing.Point(8, 5)
        Me.NoticeContainer1.Name = "NoticeContainer1"
        Me.NoticeContainer1.Size = New System.Drawing.Size(458, 295)
        Me.NoticeContainer1.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.NoticeContainer2)
        Me.Panel14.Location = New System.Drawing.Point(521, 306)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(465, 304)
        Me.Panel14.TabIndex = 70
        '
        'NoticeContainer2
        '
        Me.NoticeContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoticeContainer2.AutoScroll = True
        Me.NoticeContainer2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.NoticeContainer2.Location = New System.Drawing.Point(8, 8)
        Me.NoticeContainer2.Name = "NoticeContainer2"
        Me.NoticeContainer2.Size = New System.Drawing.Size(449, 289)
        Me.NoticeContainer2.TabIndex = 1
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label1)
        Me.Panel15.Location = New System.Drawing.Point(521, 279)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(465, 27)
        Me.Panel15.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(191, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Packages"
        '
        'signUpPanel
        '
        Me.signUpPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.signUpPanel.Controls.Add(Me.btnUploadImage)
        Me.signUpPanel.Controls.Add(Me.PicBox)
        Me.signUpPanel.Controls.Add(Me.Label6)
        Me.signUpPanel.Controls.Add(Me.btnDelete)
        Me.signUpPanel.Controls.Add(Me.btnUpdate)
        Me.signUpPanel.Controls.Add(Me.btnAdd)
        Me.signUpPanel.Controls.Add(Me.Label14)
        Me.signUpPanel.Controls.Add(Me.Label15)
        Me.signUpPanel.Controls.Add(Me.cmbSearch)
        Me.signUpPanel.Controls.Add(Me.cmbUserType)
        Me.signUpPanel.Controls.Add(Me.Label16)
        Me.signUpPanel.Controls.Add(Me.lbl)
        Me.signUpPanel.Controls.Add(Me.Label17)
        Me.signUpPanel.Controls.Add(Me.txtPassword)
        Me.signUpPanel.Controls.Add(Me.txtID)
        Me.signUpPanel.Controls.Add(Me.txtFullname)
        Me.signUpPanel.Controls.Add(Me.txtUsername)
        Me.signUpPanel.Controls.Add(Me.btnCloseSignUp)
        Me.signUpPanel.ForeColor = System.Drawing.SystemColors.Control
        Me.signUpPanel.Location = New System.Drawing.Point(1012, 0)
        Me.signUpPanel.Name = "signUpPanel"
        Me.signUpPanel.Size = New System.Drawing.Size(301, 678)
        Me.signUpPanel.TabIndex = 72
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadImage.FlatAppearance.BorderSize = 0
        Me.btnUploadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadImage.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadImage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUploadImage.Location = New System.Drawing.Point(92, 185)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(117, 22)
        Me.btnUploadImage.TabIndex = 62
        Me.btnUploadImage.Text = "Upload"
        Me.btnUploadImage.UseVisualStyleBackColor = False
        '
        'PicBox
        '
        Me.PicBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(92, 72)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(115, 115)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 68
        Me.PicBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 19)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "CREATE USER ACCOUNT"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(189, 616)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 32)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(118, 616)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(65, 32)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Location = New System.Drawing.Point(47, 616)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 32)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(37, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "UserID"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(35, 347)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "User Type"
        '
        'cmbSearch
        '
        Me.cmbSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(100, 213)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(98, 25)
        Me.cmbSearch.TabIndex = 24
        '
        'cmbUserType
        '
        Me.cmbUserType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbUserType.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Administrator", "Accountant ", "Manager"})
        Me.cmbUserType.Location = New System.Drawing.Point(37, 367)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(235, 25)
        Me.cmbUserType.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(31, 545)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Password"
        '
        'lbl
        '
        Me.lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl.Location = New System.Drawing.Point(31, 481)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(67, 17)
        Me.lbl.TabIndex = 23
        Me.lbl.Text = "Username"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(34, 411)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Full Name"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(34, 565)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(240, 22)
        Me.txtPassword.TabIndex = 21
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(37, 301)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(116, 22)
        Me.txtID.TabIndex = 20
        '
        'txtFullname
        '
        Me.txtFullname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullname.BackColor = System.Drawing.Color.White
        Me.txtFullname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(37, 446)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(237, 22)
        Me.txtFullname.TabIndex = 20
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(34, 501)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(240, 22)
        Me.txtUsername.TabIndex = 21
        '
        'btnCloseSignUp
        '
        Me.btnCloseSignUp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseSignUp.Image = CType(resources.GetObject("btnCloseSignUp.Image"), System.Drawing.Image)
        Me.btnCloseSignUp.Location = New System.Drawing.Point(3, 5)
        Me.btnCloseSignUp.Name = "btnCloseSignUp"
        Me.btnCloseSignUp.Size = New System.Drawing.Size(21, 22)
        Me.btnCloseSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCloseSignUp.TabIndex = 8
        Me.btnCloseSignUp.TabStop = False
        '
        'btnSMS
        '
        Me.btnSMS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSMS.BackColor = System.Drawing.Color.Transparent
        Me.btnSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMS.FlatAppearance.BorderSize = 0
        Me.btnSMS.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSMS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSMS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSMS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSMS.Image = CType(resources.GetObject("btnSMS.Image"), System.Drawing.Image)
        Me.btnSMS.Location = New System.Drawing.Point(922, 633)
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.Size = New System.Drawing.Size(32, 32)
        Me.btnSMS.TabIndex = 76
        Me.btnSMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSMS.UseVisualStyleBackColor = False
        '
        'PicLogo
        '
        Me.PicLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(489, 22)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(45, 45)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 67
        Me.PicLogo.TabStop = False
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCreateUser.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateUser.FlatAppearance.BorderSize = 0
        Me.btnCreateUser.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCreateUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCreateUser.Location = New System.Drawing.Point(30, 641)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(154, 24)
        Me.btnCreateUser.TabIndex = 77
        Me.btnCreateUser.Text = "Create User Account"
        Me.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateUser.UseVisualStyleBackColor = False
        Me.btnCreateUser.Visible = False
        '
        'DashboardUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.btnSMS)
        Me.Controls.Add(Me.signUpPanel)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.panel13)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "DashboardUserControl"
        Me.Size = New System.Drawing.Size(1017, 678)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.signUpPanel.ResumeLayout(False)
        Me.signUpPanel.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseSignUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblStaff As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMembers As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblEquipments As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblExpenses As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblRevenue As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents signUpPanel As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnCloseSignUp As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NoticeContainer1 As FlowLayoutPanel
    Friend WithEvents NoticeContainer2 As FlowLayoutPanel
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents btnSMS As Button
    Friend WithEvents btnCreateUser As Button
End Class
