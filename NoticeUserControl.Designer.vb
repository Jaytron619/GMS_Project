<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoticeUserControl
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoticeUserControl))
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSENDsms = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblDaysLeft = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PicBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblMemberId = New System.Windows.Forms.Label()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(59, 4)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'btnSENDsms
        '
        Me.btnSENDsms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSENDsms.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSENDsms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSENDsms.FlatAppearance.BorderSize = 0
        Me.btnSENDsms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSENDsms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSENDsms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSENDsms.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSENDsms.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSENDsms.Location = New System.Drawing.Point(382, 9)
        Me.btnSENDsms.Name = "btnSENDsms"
        Me.btnSENDsms.Size = New System.Drawing.Size(58, 28)
        Me.btnSENDsms.TabIndex = 11
        Me.btnSENDsms.Text = "Notify"
        Me.btnSENDsms.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(239, 24)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email Address"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMobile
        '
        Me.lblMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMobile.AutoSize = True
        Me.lblMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMobile.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(104, 24)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(68, 16)
        Me.lblMobile.TabIndex = 12
        Me.lblMobile.Text = "0000000000"
        Me.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Email:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Mobile:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDaysLeft
        '
        Me.lblDaysLeft.AutoSize = True
        Me.lblDaysLeft.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysLeft.ForeColor = System.Drawing.Color.Red
        Me.lblDaysLeft.Location = New System.Drawing.Point(326, 5)
        Me.lblDaysLeft.Name = "lblDaysLeft"
        Me.lblDaysLeft.Size = New System.Drawing.Size(17, 13)
        Me.lblDaysLeft.TabIndex = 17
        Me.lblDaysLeft.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(276, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Days Left:"
        '
        'PicBox
        '
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(11, 3)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PicBox.ShadowDecoration.Parent = Me.PicBox
        Me.PicBox.Size = New System.Drawing.Size(33, 33)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 16
        Me.PicBox.TabStop = False
        '
        'lblMemberId
        '
        Me.lblMemberId.AutoSize = True
        Me.lblMemberId.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberId.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMemberId.Location = New System.Drawing.Point(10, 36)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(37, 9)
        Me.lblMemberId.TabIndex = 27
        Me.lblMemberId.Text = "GYM0000"
        '
        'NoticeUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDaysLeft)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.btnSENDsms)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblMemberId)
        Me.Name = "NoticeUserControl"
        Me.Size = New System.Drawing.Size(452, 45)
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents btnSENDsms As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PicBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents lblDaysLeft As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMemberId As Label
End Class
