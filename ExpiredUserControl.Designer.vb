<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpiredUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpiredUserControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.lblLastRenewed = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblMemberId = New System.Windows.Forms.Label()
        Me.PicBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Package:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Last Renewed:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPackage
        '
        Me.lblPackage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPackage.AutoSize = True
        Me.lblPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPackage.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackage.Location = New System.Drawing.Point(129, 24)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(42, 13)
        Me.lblPackage.TabIndex = 22
        Me.lblPackage.Text = "0000000"
        Me.lblPackage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRenew
        '
        Me.btnRenew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenew.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnRenew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRenew.FlatAppearance.BorderSize = 0
        Me.btnRenew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRenew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenew.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenew.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRenew.Location = New System.Drawing.Point(226, 14)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(54, 29)
        Me.btnRenew.TabIndex = 21
        Me.btnRenew.Text = "Renew"
        Me.btnRenew.UseVisualStyleBackColor = False
        '
        'lblLastRenewed
        '
        Me.lblLastRenewed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLastRenewed.AutoSize = True
        Me.lblLastRenewed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLastRenewed.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastRenewed.Location = New System.Drawing.Point(129, 39)
        Me.lblLastRenewed.Name = "lblLastRenewed"
        Me.lblLastRenewed.Size = New System.Drawing.Size(55, 13)
        Me.lblLastRenewed.TabIndex = 19
        Me.lblLastRenewed.Text = "00/00/0000"
        Me.lblLastRenewed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(55, 7)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 15)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Label1"
        '
        'lblMemberId
        '
        Me.lblMemberId.AutoSize = True
        Me.lblMemberId.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberId.ForeColor = System.Drawing.Color.Red
        Me.lblMemberId.Location = New System.Drawing.Point(8, 38)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(40, 12)
        Me.lblMemberId.TabIndex = 26
        Me.lblMemberId.Text = "GYM0000"
        '
        'PicBox
        '
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(11, 6)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PicBox.ShadowDecoration.Parent = Me.PicBox
        Me.PicBox.Size = New System.Drawing.Size(34, 33)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 25
        Me.PicBox.TabStop = False
        '
        'ExpiredUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.lblLastRenewed)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblMemberId)
        Me.Name = "ExpiredUserControl"
        Me.Size = New System.Drawing.Size(292, 55)
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPackage As Label
    Friend WithEvents btnRenew As Button
    Friend WithEvents lblLastRenewed As Label
    Friend WithEvents lblName As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents lblMemberId As Label
End Class
