<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMSForm))
        Me.messageContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtMessage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btn = New System.Windows.Forms.Button()
        Me.btnSMS = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'messageContainer
        '
        Me.messageContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.messageContainer.AutoScroll = True
        Me.messageContainer.BackColor = System.Drawing.Color.Transparent
        Me.messageContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.messageContainer.Location = New System.Drawing.Point(0, 19)
        Me.messageContainer.Name = "messageContainer"
        Me.messageContainer.Size = New System.Drawing.Size(289, 453)
        Me.messageContainer.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.messageContainer)
        Me.Panel1.Location = New System.Drawing.Point(7, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 461)
        Me.Panel1.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(5, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(34, 15)
        Me.lblTime.TabIndex = 75
        Me.lblTime.Text = "00:00"
        '
        'txtMessage
        '
        Me.txtMessage.AutoSize = True
        Me.txtMessage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtMessage.BorderRadius = 15
        Me.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMessage.DefaultText = ""
        Me.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessage.DisabledState.Parent = Me.txtMessage
        Me.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessage.FocusedState.Parent = Me.txtMessage
        Me.txtMessage.ForeColor = System.Drawing.Color.Black
        Me.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessage.HoverState.Parent = Me.txtMessage
        Me.txtMessage.Location = New System.Drawing.Point(6, 504)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMessage.PlaceholderText = ""
        Me.txtMessage.SelectedText = ""
        Me.txtMessage.ShadowDecoration.Parent = Me.txtMessage
        Me.txtMessage.Size = New System.Drawing.Size(258, 32)
        Me.txtMessage.TabIndex = 4
        '
        'txtNumber
        '
        Me.txtNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtNumber.BorderRadius = 7
        Me.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumber.DefaultText = ""
        Me.txtNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.DisabledState.Parent = Me.txtNumber
        Me.txtNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumber.FocusedState.Parent = Me.txtNumber
        Me.txtNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumber.HoverState.Parent = Me.txtNumber
        Me.txtNumber.Location = New System.Drawing.Point(6, 12)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumber.PlaceholderText = ""
        Me.txtNumber.SelectedText = ""
        Me.txtNumber.ShadowDecoration.Parent = Me.txtNumber
        Me.txtNumber.Size = New System.Drawing.Size(118, 20)
        Me.txtNumber.TabIndex = 79
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(258, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "SMS"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'btn
        '
        Me.btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn.BackColor = System.Drawing.Color.Transparent
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn.FlatAppearance.BorderSize = 0
        Me.btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn.Image = CType(resources.GetObject("btn.Image"), System.Drawing.Image)
        Me.btn.Location = New System.Drawing.Point(269, 7)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(27, 28)
        Me.btn.TabIndex = 78
        Me.btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn.UseVisualStyleBackColor = False
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
        Me.btnSMS.Location = New System.Drawing.Point(265, 504)
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.Size = New System.Drawing.Size(34, 34)
        Me.btnSMS.TabIndex = 77
        Me.btnSMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSMS.UseVisualStyleBackColor = False
        '
        'SMSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(304, 548)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.btnSMS)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SMSForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents messageContainer As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMessage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnSMS As Button
    Friend WithEvents btn As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents txtNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
