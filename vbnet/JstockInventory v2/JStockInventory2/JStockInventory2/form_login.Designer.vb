<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.text_username = New System.Windows.Forms.TextBox()
        Me.text_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tombol_keluar = New System.Windows.Forms.Button()
        Me.tombol_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'text_username
        '
        Me.text_username.Cursor = System.Windows.Forms.Cursors.Hand
        Me.text_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_username.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_username.Location = New System.Drawing.Point(379, 145)
        Me.text_username.Name = "text_username"
        Me.text_username.Size = New System.Drawing.Size(287, 21)
        Me.text_username.TabIndex = 0
        '
        'text_password
        '
        Me.text_password.Cursor = System.Windows.Forms.Cursors.Hand
        Me.text_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_password.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_password.Location = New System.Drawing.Point(379, 198)
        Me.text_password.Name = "text_password"
        Me.text_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_password.Size = New System.Drawing.Size(287, 21)
        Me.text_password.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User"
        '
        'tombol_keluar
        '
        Me.tombol_keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tombol_keluar.Location = New System.Drawing.Point(770, 12)
        Me.tombol_keluar.Name = "tombol_keluar"
        Me.tombol_keluar.Size = New System.Drawing.Size(180, 23)
        Me.tombol_keluar.TabIndex = 5
        Me.tombol_keluar.Text = "Keluar Sistem"
        Me.tombol_keluar.UseVisualStyleBackColor = True
        '
        'tombol_login
        '
        Me.tombol_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tombol_login.Image = Global.JStockInventory2.My.Resources.Resources.login
        Me.tombol_login.Location = New System.Drawing.Point(542, 242)
        Me.tombol_login.Name = "tombol_login"
        Me.tombol_login.Size = New System.Drawing.Size(124, 73)
        Me.tombol_login.TabIndex = 6
        Me.tombol_login.UseVisualStyleBackColor = True
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.tombol_login)
        Me.Controls.Add(Me.tombol_keluar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.text_password)
        Me.Controls.Add(Me.text_username)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JstockInventory Version 2 - by www.jasaplus.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text_username As System.Windows.Forms.TextBox
    Friend WithEvents text_password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tombol_keluar As System.Windows.Forms.Button
    Friend WithEvents tombol_login As System.Windows.Forms.Button

End Class
