﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbStaffDesignation = New System.Windows.Forms.ComboBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateEmployed = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbShift = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 39)
        Me.Panel1.TabIndex = 77
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
        Me.Button1.Location = New System.Drawing.Point(730, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(14, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(85, 21)
        Me.lblHeader.TabIndex = 77
        Me.lblHeader.Text = "Add Staff"
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadImage.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadImage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUploadImage.Location = New System.Drawing.Point(16, 233)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(142, 33)
        Me.btnUploadImage.TabIndex = 0
        Me.btnUploadImage.Text = "Upload"
        Me.btnUploadImage.UseVisualStyleBackColor = False
        '
        'txtStaffID
        '
        Me.txtStaffID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStaffID.Enabled = False
        Me.txtStaffID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(19, 296)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(139, 22)
        Me.txtStaffID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Staff ID"
        '
        'cmbStaffDesignation
        '
        Me.cmbStaffDesignation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbStaffDesignation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStaffDesignation.FormattingEnabled = True
        Me.cmbStaffDesignation.Items.AddRange(New Object() {"Accountant", "Administrator", "Group Fitness Instructor", "Maintenance Personnel", "Operational Manager", "Service Personnel", ""})
        Me.cmbStaffDesignation.Location = New System.Drawing.Point(130, 18)
        Me.cmbStaffDesignation.Name = "cmbStaffDesignation"
        Me.cmbStaffDesignation.Size = New System.Drawing.Size(154, 25)
        Me.cmbStaffDesignation.TabIndex = 7
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(419, 19)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(154, 22)
        Me.txtPhoneNumber.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(298, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 17)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Phone Number"
        '
        'cmbGender
        '
        Me.cmbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(130, 55)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(154, 25)
        Me.cmbGender.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Name"
        '
        'dtpDateEmployed
        '
        Me.dtpDateEmployed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDateEmployed.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateEmployed.Location = New System.Drawing.Point(419, 17)
        Me.dtpDateEmployed.Name = "dtpDateEmployed"
        Me.dtpDateEmployed.Size = New System.Drawing.Size(154, 22)
        Me.dtpDateEmployed.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Staff Designation"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(298, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Date Employed"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(130, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 22)
        Me.txtName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(419, 47)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(154, 22)
        Me.txtEmail.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(298, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Email Address"
        '
        'txtAge
        '
        Me.txtAge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAge.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(130, 91)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(154, 22)
        Me.txtAge.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 17)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "Age"
        '
        'txtSalary
        '
        Me.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSalary.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(130, 49)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(154, 22)
        Me.txtSalary.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Salary (GHc)"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
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
        Me.btnEdit.Location = New System.Drawing.Point(336, 330)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 32)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Update"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.btnReset.Location = New System.Drawing.Point(385, 330)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(78, 34)
        Me.btnReset.TabIndex = 11
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
        Me.btnSave.Location = New System.Drawing.Point(302, 330)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 34)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'imageBox
        '
        Me.imageBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imageBox.Image = CType(resources.GetObject("imageBox.Image"), System.Drawing.Image)
        Me.imageBox.Location = New System.Drawing.Point(19, 86)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(136, 143)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 81
        Me.imageBox.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(690, 46)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 31)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Shift"
        '
        'cmbShift
        '
        Me.cmbShift.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbShift.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShift.FormattingEnabled = True
        Me.cmbShift.Location = New System.Drawing.Point(419, 50)
        Me.cmbShift.Name = "cmbShift"
        Me.cmbShift.Size = New System.Drawing.Size(154, 25)
        Me.cmbShift.TabIndex = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(164, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 127)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txtSalary)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbShift)
        Me.GroupBox2.Controls.Add(Me.cmbStaffDesignation)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpDateEmployed)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(164, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(579, 92)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 373)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUploadImage)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents imageBox As PictureBox
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbStaffDesignation As ComboBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateEmployed As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbShift As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
