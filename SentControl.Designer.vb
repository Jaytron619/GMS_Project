<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SentControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SentControl))
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblNumber.Location = New System.Drawing.Point(0, 1)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(71, 12)
        Me.lblNumber.TabIndex = 71
        Me.lblNumber.Text = "+233000000000"
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMessage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(3, 16)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(275, 31)
        Me.lblMessage.TabIndex = 73
        Me.lblMessage.Text = resources.GetString("lblMessage.Text")
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(249, 2)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(27, 12)
        Me.lblTime.TabIndex = 74
        Me.lblTime.Text = "00:00"
        '
        'SentControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "SentControl"
        Me.Size = New System.Drawing.Size(282, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblTime As Label
End Class
