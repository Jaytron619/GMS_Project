<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnGeneral = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAbout)
        Me.Panel1.Controls.Add(Me.btnGeneral)
        Me.Panel1.Controls.Add(Me.btnAccount)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 434)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(39, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Settings"
        '
        'btnAbout
        '
        Me.btnAbout.AccessibleDescription = ""
        Me.btnAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(3, 101)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(109, 28)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnGeneral
        '
        Me.btnGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGeneral.BackColor = System.Drawing.Color.Transparent
        Me.btnGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeneral.FlatAppearance.BorderSize = 0
        Me.btnGeneral.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneral.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneral.ForeColor = System.Drawing.Color.White
        Me.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneral.Location = New System.Drawing.Point(3, 45)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(109, 28)
        Me.btnGeneral.TabIndex = 0
        Me.btnGeneral.Text = "General"
        Me.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneral.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.White
        Me.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.Location = New System.Drawing.Point(3, 73)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(109, 28)
        Me.btnAccount.TabIndex = 1
        Me.btnAccount.Text = "Account"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(112, 0)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(585, 434)
        Me.contentPanel.TabIndex = 1
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 434)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents contentPanel As Panel
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnGeneral As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents Label1 As Label
End Class
