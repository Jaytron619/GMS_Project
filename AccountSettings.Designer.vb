<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountSettings))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompanyNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMomoLine = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBankAccount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompanyEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.PicBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(568, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(10, 12)
        Me.btnClose.TabIndex = 2
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.VbProjet.My.Resources.Resources.instagram_25px
        Me.PictureBox3.Location = New System.Drawing.Point(60, 392)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(26, 392)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(94, 392)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(57, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Company Telephone line:"
        '
        'txtCompanyNumber
        '
        Me.txtCompanyNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyNumber.DefaultText = ""
        Me.txtCompanyNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCompanyNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCompanyNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyNumber.DisabledState.Parent = Me.txtCompanyNumber
        Me.txtCompanyNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyNumber.FocusedState.Parent = Me.txtCompanyNumber
        Me.txtCompanyNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyNumber.HoverState.Parent = Me.txtCompanyNumber
        Me.txtCompanyNumber.Location = New System.Drawing.Point(246, 183)
        Me.txtCompanyNumber.Name = "txtCompanyNumber"
        Me.txtCompanyNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyNumber.PlaceholderText = ""
        Me.txtCompanyNumber.SelectedText = ""
        Me.txtCompanyNumber.ShadowDecoration.Parent = Me.txtCompanyNumber
        Me.txtCompanyNumber.Size = New System.Drawing.Size(272, 20)
        Me.txtCompanyNumber.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(57, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Company Momo line:"
        '
        'txtMomoLine
        '
        Me.txtMomoLine.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMomoLine.DefaultText = ""
        Me.txtMomoLine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMomoLine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMomoLine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMomoLine.DisabledState.Parent = Me.txtMomoLine
        Me.txtMomoLine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMomoLine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMomoLine.FocusedState.Parent = Me.txtMomoLine
        Me.txtMomoLine.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMomoLine.HoverState.Parent = Me.txtMomoLine
        Me.txtMomoLine.Location = New System.Drawing.Point(246, 224)
        Me.txtMomoLine.Name = "txtMomoLine"
        Me.txtMomoLine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMomoLine.PlaceholderText = ""
        Me.txtMomoLine.SelectedText = ""
        Me.txtMomoLine.ShadowDecoration.Parent = Me.txtMomoLine
        Me.txtMomoLine.Size = New System.Drawing.Size(272, 20)
        Me.txtMomoLine.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(57, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Company Bank Account:"
        '
        'txtBankAccount
        '
        Me.txtBankAccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBankAccount.DefaultText = ""
        Me.txtBankAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBankAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBankAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBankAccount.DisabledState.Parent = Me.txtBankAccount
        Me.txtBankAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBankAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBankAccount.FocusedState.Parent = Me.txtBankAccount
        Me.txtBankAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBankAccount.HoverState.Parent = Me.txtBankAccount
        Me.txtBankAccount.Location = New System.Drawing.Point(246, 262)
        Me.txtBankAccount.Name = "txtBankAccount"
        Me.txtBankAccount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBankAccount.PlaceholderText = ""
        Me.txtBankAccount.SelectedText = ""
        Me.txtBankAccount.ShadowDecoration.Parent = Me.txtBankAccount
        Me.txtBankAccount.Size = New System.Drawing.Size(272, 20)
        Me.txtBankAccount.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(59, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Company Email Address:"
        '
        'txtCompanyEmail
        '
        Me.txtCompanyEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyEmail.DefaultText = ""
        Me.txtCompanyEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCompanyEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCompanyEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyEmail.DisabledState.Parent = Me.txtCompanyEmail
        Me.txtCompanyEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCompanyEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyEmail.FocusedState.Parent = Me.txtCompanyEmail
        Me.txtCompanyEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCompanyEmail.HoverState.Parent = Me.txtCompanyEmail
        Me.txtCompanyEmail.Location = New System.Drawing.Point(246, 301)
        Me.txtCompanyEmail.Name = "txtCompanyEmail"
        Me.txtCompanyEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompanyEmail.PlaceholderText = ""
        Me.txtCompanyEmail.SelectedText = ""
        Me.txtCompanyEmail.ShadowDecoration.Parent = Me.txtCompanyEmail
        Me.txtCompanyEmail.Size = New System.Drawing.Size(272, 20)
        Me.txtCompanyEmail.TabIndex = 41
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(514, 392)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 29)
        Me.btnSave.TabIndex = 88
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCompanyName.Location = New System.Drawing.Point(208, 89)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(280, 28)
        Me.lblCompanyName.TabIndex = 89
        Me.lblCompanyName.Text = "Name of the Company"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PicBox
        '
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(124, 70)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PicBox.ShadowDecoration.Parent = Me.PicBox
        Me.PicBox.Size = New System.Drawing.Size(60, 60)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 90
        Me.PicBox.TabStop = False
        '
        'AccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCompanyEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBankAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMomoLine)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCompanyNumber)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "AccountSettings"
        Me.Size = New System.Drawing.Size(585, 434)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompanyNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMomoLine As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBankAccount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCompanyEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents PicBox As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
