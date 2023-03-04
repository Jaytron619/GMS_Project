<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PackageNoticeUserControl
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
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPackageName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPackageFee = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.AutoSize = True
        Me.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescription.Location = New System.Drawing.Point(18, 25)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(293, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "If you always want the loop to run at least once in a program,"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPackageName
        '
        Me.lblPackageName.AutoSize = True
        Me.lblPackageName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageName.Location = New System.Drawing.Point(9, 5)
        Me.lblPackageName.Name = "lblPackageName"
        Me.lblPackageName.Size = New System.Drawing.Size(45, 13)
        Me.lblPackageName.TabIndex = 2
        Me.lblPackageName.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GHc"
        '
        'lblPackageFee
        '
        Me.lblPackageFee.AutoSize = True
        Me.lblPackageFee.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackageFee.Location = New System.Drawing.Point(366, 11)
        Me.lblPackageFee.Name = "lblPackageFee"
        Me.lblPackageFee.Size = New System.Drawing.Size(49, 19)
        Me.lblPackageFee.TabIndex = 4
        Me.lblPackageFee.Text = "00.00"
        '
        'PackageNoticeUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.lblPackageFee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblPackageName)
        Me.Name = "PackageNoticeUserControl"
        Me.Size = New System.Drawing.Size(442, 45)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPackageName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPackageFee As Label
End Class
