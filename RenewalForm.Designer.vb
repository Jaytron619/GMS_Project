<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenewalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RenewalForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMemberId = New System.Windows.Forms.Label()
        Me.PicBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPackageType = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpRenewalDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Mobile:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Email:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMobile
        '
        Me.lblMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMobile.AutoSize = True
        Me.lblMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMobile.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(178, 42)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(85, 16)
        Me.lblMobile.TabIndex = 30
        Me.lblMobile.Text = "00000000000"
        Me.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(459, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(54, 28)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(357, 41)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(125, 16)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "example@mail.com"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(125, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 19)
        Me.lblName.TabIndex = 28
        Me.lblName.Text = "Label1"
        '
        'lblMemberId
        '
        Me.lblMemberId.AutoSize = True
        Me.lblMemberId.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberId.ForeColor = System.Drawing.Color.Red
        Me.lblMemberId.Location = New System.Drawing.Point(32, 100)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(65, 17)
        Me.lblMemberId.TabIndex = 34
        Me.lblMemberId.Text = "GYM0000"
        '
        'PicBox
        '
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(25, 16)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PicBox.ShadowDecoration.Parent = Me.PicBox
        Me.PicBox.Size = New System.Drawing.Size(80, 80)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 33
        Me.PicBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbPackageType)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.dtpRenewalDate)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(125, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 67)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        '
        'cmbPackageType
        '
        Me.cmbPackageType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbPackageType.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPackageType.FormattingEnabled = True
        Me.cmbPackageType.Location = New System.Drawing.Point(19, 35)
        Me.cmbPackageType.Name = "cmbPackageType"
        Me.cmbPackageType.Size = New System.Drawing.Size(137, 25)
        Me.cmbPackageType.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 17)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Package Type"
        '
        'dtpRenewalDate
        '
        Me.dtpRenewalDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRenewalDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRenewalDate.Location = New System.Drawing.Point(239, 38)
        Me.dtpRenewalDate.Name = "dtpRenewalDate"
        Me.dtpRenewalDate.Size = New System.Drawing.Size(202, 22)
        Me.dtpRenewalDate.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(236, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 17)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Renewal Date"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(521, 131)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(54, 28)
        Me.btnCancel.TabIndex = 125
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'RenewalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 170)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblMemberId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RenewalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RenewalForm"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblMemberId As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPackageType As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents dtpRenewalDate As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnCancel As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
