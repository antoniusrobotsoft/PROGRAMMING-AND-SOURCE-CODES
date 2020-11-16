<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pengaturan_konfigurasi_database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pengaturan_konfigurasi_database))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_host = New System.Windows.Forms.TextBox()
        Me.text_username = New System.Windows.Forms.TextBox()
        Me.text_password = New System.Windows.Forms.TextBox()
        Me.text_database = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text_konfirmasi_password = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(60, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(60, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(60, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(60, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Database"
        '
        'text_host
        '
        Me.text_host.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_host.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_host.Location = New System.Drawing.Point(230, 31)
        Me.text_host.Name = "text_host"
        Me.text_host.Size = New System.Drawing.Size(207, 21)
        Me.text_host.TabIndex = 4
        '
        'text_username
        '
        Me.text_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_username.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_username.Location = New System.Drawing.Point(230, 74)
        Me.text_username.Name = "text_username"
        Me.text_username.Size = New System.Drawing.Size(207, 21)
        Me.text_username.TabIndex = 5
        '
        'text_password
        '
        Me.text_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_password.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_password.Location = New System.Drawing.Point(230, 120)
        Me.text_password.Name = "text_password"
        Me.text_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_password.Size = New System.Drawing.Size(207, 21)
        Me.text_password.TabIndex = 6
        '
        'text_database
        '
        Me.text_database.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_database.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_database.Location = New System.Drawing.Point(230, 260)
        Me.text_database.Name = "text_database"
        Me.text_database.Size = New System.Drawing.Size(207, 21)
        Me.text_database.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Image = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.Button1.Location = New System.Drawing.Point(383, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 58)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(60, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Konfirmasi Password"
        '
        'text_konfirmasi_password
        '
        Me.text_konfirmasi_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_konfirmasi_password.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_konfirmasi_password.Location = New System.Drawing.Point(230, 193)
        Me.text_konfirmasi_password.Name = "text_konfirmasi_password"
        Me.text_konfirmasi_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_konfirmasi_password.Size = New System.Drawing.Size(207, 21)
        Me.text_konfirmasi_password.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(453, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(453, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(453, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.text_database)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.text_host)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.text_konfirmasi_password)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.text_username)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.text_password)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 437)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(358, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "* = harus diisi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(60, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(352, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Biarkan konfirmasi password kosong jika password tidak diisi"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label12.Location = New System.Drawing.Point(60, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(508, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Biarkan password kosong jika password tidak ingin diganti atau koneksi tanpa pass" &
    "word"
        '
        'pengaturan_konfigurasi_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pengaturan_konfigurasi_database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengaturan Konfigurasi Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents text_host As TextBox
    Friend WithEvents text_username As TextBox
    Friend WithEvents text_password As TextBox
    Friend WithEvents text_database As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents text_konfirmasi_password As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
