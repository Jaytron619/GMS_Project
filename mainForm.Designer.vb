<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.btnRegistry = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnShift = New System.Windows.Forms.Button()
        Me.PicBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnPackage = New System.Windows.Forms.Button()
        Me.btnEquipments = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnViewMembers = New System.Windows.Forms.Button()
        Me.btnExpenses = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.topPanel.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidePanel.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.topPanel.Controls.Add(Me.Button1)
        Me.topPanel.Controls.Add(Me.btnSettings)
        Me.topPanel.Controls.Add(Me.lblCompanyName)
        Me.topPanel.Controls.Add(Me.PicLogo)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(1200, 42)
        Me.topPanel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1163, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 79
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.AccessibleDescription = ""
        Me.btnSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.Location = New System.Drawing.Point(1111, 6)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(31, 30)
        Me.btnSettings.TabIndex = 0
        Me.btnSettings.UseVisualStyleBackColor = False
        Me.btnSettings.Visible = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCompanyName.Location = New System.Drawing.Point(47, 11)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(176, 20)
        Me.lblCompanyName.TabIndex = 9
        Me.lblCompanyName.Text = "GYM MANAGEMENT SYSTEM"
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(12, 9)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(25, 25)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 8
        Me.PicLogo.TabStop = False
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFullName.Location = New System.Drawing.Point(64, 25)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(73, 16)
        Me.lblFullName.TabIndex = 81
        Me.lblFullName.Text = "Full Name"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUserType.Location = New System.Drawing.Point(65, 43)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(50, 13)
        Me.lblUserType.TabIndex = 9
        Me.lblUserType.Text = "USER TYPE"
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sidePanel.Controls.Add(Me.btnRegistry)
        Me.sidePanel.Controls.Add(Me.btnLogout)
        Me.sidePanel.Controls.Add(Me.lblUserType)
        Me.sidePanel.Controls.Add(Me.lblFullName)
        Me.sidePanel.Controls.Add(Me.btnShift)
        Me.sidePanel.Controls.Add(Me.PicBox)
        Me.sidePanel.Controls.Add(Me.btnAttendance)
        Me.sidePanel.Controls.Add(Me.btnPackage)
        Me.sidePanel.Controls.Add(Me.btnEquipments)
        Me.sidePanel.Controls.Add(Me.btnPayments)
        Me.sidePanel.Controls.Add(Me.btnStaff)
        Me.sidePanel.Controls.Add(Me.btnViewMembers)
        Me.sidePanel.Controls.Add(Me.btnExpenses)
        Me.sidePanel.Controls.Add(Me.btnDashboard)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 42)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(183, 678)
        Me.sidePanel.TabIndex = 1
        '
        'btnRegistry
        '
        Me.btnRegistry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegistry.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistry.FlatAppearance.BorderSize = 0
        Me.btnRegistry.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRegistry.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRegistry.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistry.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistry.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRegistry.Location = New System.Drawing.Point(70, 646)
        Me.btnRegistry.Name = "btnRegistry"
        Me.btnRegistry.Size = New System.Drawing.Size(104, 24)
        Me.btnRegistry.TabIndex = 83
        Me.btnRegistry.Text = "Login Registry"
        Me.btnRegistry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistry.UseVisualStyleBackColor = False
        Me.btnRegistry.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(59, 559)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(58, 28)
        Me.btnLogout.TabIndex = 82
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnShift
        '
        Me.btnShift.AccessibleDescription = ""
        Me.btnShift.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnShift.BackColor = System.Drawing.Color.Transparent
        Me.btnShift.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShift.FlatAppearance.BorderSize = 0
        Me.btnShift.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnShift.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShift.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShift.ForeColor = System.Drawing.Color.White
        Me.btnShift.Image = CType(resources.GetObject("btnShift.Image"), System.Drawing.Image)
        Me.btnShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShift.Location = New System.Drawing.Point(0, 329)
        Me.btnShift.Name = "btnShift"
        Me.btnShift.Size = New System.Drawing.Size(178, 40)
        Me.btnShift.TabIndex = 5
        Me.btnShift.Text = "Shift                "
        Me.btnShift.UseVisualStyleBackColor = False
        '
        'PicBox
        '
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(9, 16)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PicBox.ShadowDecoration.Parent = Me.PicBox
        Me.PicBox.Size = New System.Drawing.Size(50, 50)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 80
        Me.PicBox.TabStop = False
        '
        'btnAttendance
        '
        Me.btnAttendance.AccessibleDescription = ""
        Me.btnAttendance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendance.FlatAppearance.BorderSize = 0
        Me.btnAttendance.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.Image = CType(resources.GetObject("btnAttendance.Image"), System.Drawing.Image)
        Me.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAttendance.Location = New System.Drawing.Point(0, 209)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(178, 40)
        Me.btnAttendance.TabIndex = 2
        Me.btnAttendance.Text = "Attendance "
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnPackage
        '
        Me.btnPackage.AccessibleDescription = ""
        Me.btnPackage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPackage.BackColor = System.Drawing.Color.Transparent
        Me.btnPackage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPackage.FlatAppearance.BorderSize = 0
        Me.btnPackage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPackage.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPackage.ForeColor = System.Drawing.Color.White
        Me.btnPackage.Image = CType(resources.GetObject("btnPackage.Image"), System.Drawing.Image)
        Me.btnPackage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPackage.Location = New System.Drawing.Point(0, 369)
        Me.btnPackage.Name = "btnPackage"
        Me.btnPackage.Size = New System.Drawing.Size(178, 40)
        Me.btnPackage.TabIndex = 6
        Me.btnPackage.Text = "Package       "
        Me.btnPackage.UseVisualStyleBackColor = False
        '
        'btnEquipments
        '
        Me.btnEquipments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEquipments.BackColor = System.Drawing.Color.Transparent
        Me.btnEquipments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEquipments.FlatAppearance.BorderSize = 0
        Me.btnEquipments.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEquipments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEquipments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEquipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipments.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipments.ForeColor = System.Drawing.Color.White
        Me.btnEquipments.Image = CType(resources.GetObject("btnEquipments.Image"), System.Drawing.Image)
        Me.btnEquipments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEquipments.Location = New System.Drawing.Point(0, 409)
        Me.btnEquipments.Name = "btnEquipments"
        Me.btnEquipments.Size = New System.Drawing.Size(178, 40)
        Me.btnEquipments.TabIndex = 7
        Me.btnEquipments.Text = "Equipments  "
        Me.btnEquipments.UseVisualStyleBackColor = False
        '
        'btnPayments
        '
        Me.btnPayments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPayments.BackColor = System.Drawing.Color.Transparent
        Me.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayments.FlatAppearance.BorderSize = 0
        Me.btnPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayments.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayments.ForeColor = System.Drawing.Color.White
        Me.btnPayments.Image = Global.VbProjet.My.Resources.Resources.money_25px
        Me.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayments.Location = New System.Drawing.Point(0, 249)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(178, 40)
        Me.btnPayments.TabIndex = 3
        Me.btnPayments.Text = "Payment       "
        Me.btnPayments.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStaff.BackColor = System.Drawing.Color.Transparent
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.White
        Me.btnStaff.Image = CType(resources.GetObject("btnStaff.Image"), System.Drawing.Image)
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(0, 289)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(178, 40)
        Me.btnStaff.TabIndex = 4
        Me.btnStaff.Text = "Staff                "
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnViewMembers
        '
        Me.btnViewMembers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewMembers.BackColor = System.Drawing.Color.Transparent
        Me.btnViewMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewMembers.FlatAppearance.BorderSize = 0
        Me.btnViewMembers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnViewMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnViewMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnViewMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewMembers.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMembers.ForeColor = System.Drawing.Color.White
        Me.btnViewMembers.Image = CType(resources.GetObject("btnViewMembers.Image"), System.Drawing.Image)
        Me.btnViewMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewMembers.Location = New System.Drawing.Point(0, 169)
        Me.btnViewMembers.Name = "btnViewMembers"
        Me.btnViewMembers.Size = New System.Drawing.Size(178, 40)
        Me.btnViewMembers.TabIndex = 1
        Me.btnViewMembers.Text = "Members      "
        Me.btnViewMembers.UseVisualStyleBackColor = False
        '
        'btnExpenses
        '
        Me.btnExpenses.AccessibleDescription = ""
        Me.btnExpenses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExpenses.BackColor = System.Drawing.Color.Transparent
        Me.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpenses.FlatAppearance.BorderSize = 0
        Me.btnExpenses.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpenses.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpenses.ForeColor = System.Drawing.Color.White
        Me.btnExpenses.Image = CType(resources.GetObject("btnExpenses.Image"), System.Drawing.Image)
        Me.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExpenses.Location = New System.Drawing.Point(0, 449)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(178, 40)
        Me.btnExpenses.TabIndex = 8
        Me.btnExpenses.Text = "Expenses       "
        Me.btnExpenses.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 129)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(178, 40)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "DashBoard   "
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.Color.LightGray
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(183, 42)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1017, 678)
        Me.contentPanel.TabIndex = 2
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.topPanel
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " GMSProject"
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidePanel.ResumeLayout(False)
        Me.sidePanel.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topPanel As Panel
    Friend WithEvents sidePanel As Panel
    Friend WithEvents contentPanel As Panel
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnViewMembers As Button
    Friend WithEvents btnExpenses As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblUserType As Label
    Friend WithEvents btnEquipments As Button
    Friend WithEvents btnShift As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnPackage As Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnSettings As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PicBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnRegistry As Button
End Class
