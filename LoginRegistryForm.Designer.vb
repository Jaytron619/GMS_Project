<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginRegistryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginRegistryForm))
        Me.btn = New System.Windows.Forms.Button()
        Me.LoginRegistryDataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        CType(Me.LoginRegistryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn.Location = New System.Drawing.Point(547, 2)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(27, 28)
        Me.btn.TabIndex = 79
        Me.btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn.UseVisualStyleBackColor = False
        '
        'LoginRegistryDataGrid
        '
        Me.LoginRegistryDataGrid.AllowUserToAddRows = False
        Me.LoginRegistryDataGrid.AllowUserToDeleteRows = False
        Me.LoginRegistryDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginRegistryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LoginRegistryDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.LoginRegistryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoginRegistryDataGrid.Location = New System.Drawing.Point(12, 118)
        Me.LoginRegistryDataGrid.Name = "LoginRegistryDataGrid"
        Me.LoginRegistryDataGrid.ReadOnly = True
        Me.LoginRegistryDataGrid.RowHeadersVisible = False
        Me.LoginRegistryDataGrid.Size = New System.Drawing.Size(554, 450)
        Me.LoginRegistryDataGrid.TabIndex = 112
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(12, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 33)
        Me.Panel3.TabIndex = 113
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSearch.Location = New System.Drawing.Point(39, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(154, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Tag = ""
        Me.txtSearch.Text = "Search by Name of User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(210, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 23)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Login Histories"
        '
        'LoginRegistryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 580)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LoginRegistryDataGrid)
        Me.Controls.Add(Me.btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginRegistryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginRegistryForm"
        CType(Me.LoginRegistryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents LoginRegistryDataGrid As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
