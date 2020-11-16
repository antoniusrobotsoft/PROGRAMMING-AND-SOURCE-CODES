<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_master_data_customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_master_data_customer))
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telpon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.label_id = New System.Windows.Forms.Label()
        Me.text_email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.text_telpon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_hp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.text_alamat = New System.Windows.Forms.TextBox()
        Me.text_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.textcari_hp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcari_nama = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama, Me.telpon, Me.alamat, Me.hp, Me.email})
        Me.DGView.Location = New System.Drawing.Point(12, 195)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGView.Size = New System.Drawing.Size(973, 292)
        Me.DGView.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nama
        '
        Me.nama.DataPropertyName = "nama"
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Width = 190
        '
        'telpon
        '
        Me.telpon.DataPropertyName = "telpon"
        Me.telpon.HeaderText = "Telpon"
        Me.telpon.Name = "telpon"
        Me.telpon.ReadOnly = True
        Me.telpon.Width = 130
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        Me.alamat.Width = 300
        '
        'hp
        '
        Me.hp.DataPropertyName = "hp"
        Me.hp.HeaderText = "HP"
        Me.hp.Name = "hp"
        Me.hp.ReadOnly = True
        Me.hp.Width = 130
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 180
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.text_id)
        Me.GroupBox1.Controls.Add(Me.label_id)
        Me.GroupBox1.Controls.Add(Me.text_email)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.text_telpon)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.text_hp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.text_alamat)
        Me.GroupBox1.Controls.Add(Me.text_nama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(991, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 412)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Data Customer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(214, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "* = harus diisi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(296, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(315, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(296, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "*"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_id.Location = New System.Drawing.Point(102, 30)
        Me.text_id.Name = "text_id"
        Me.text_id.ReadOnly = True
        Me.text_id.Size = New System.Drawing.Size(94, 22)
        Me.text_id.TabIndex = 30
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Location = New System.Drawing.Point(19, 33)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 15)
        Me.label_id.TabIndex = 29
        Me.label_id.Text = "ID"
        '
        'text_email
        '
        Me.text_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_email.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_email.Location = New System.Drawing.Point(102, 267)
        Me.text_email.Name = "text_email"
        Me.text_email.Size = New System.Drawing.Size(221, 21)
        Me.text_email.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Email"
        '
        'text_telpon
        '
        Me.text_telpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_telpon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_telpon.Location = New System.Drawing.Point(102, 230)
        Me.text_telpon.Name = "text_telpon"
        Me.text_telpon.Size = New System.Drawing.Size(187, 21)
        Me.text_telpon.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Telpon"
        '
        'text_hp
        '
        Me.text_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_hp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_hp.Location = New System.Drawing.Point(102, 193)
        Me.text_hp.Name = "text_hp"
        Me.text_hp.Size = New System.Drawing.Size(188, 21)
        Me.text_hp.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "HP"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(280, 342)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 55)
        Me.Button8.TabIndex = 22
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(192, 342)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 55)
        Me.Button5.TabIndex = 18
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(102, 342)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 55)
        Me.Button4.TabIndex = 17
        Me.Button4.UseVisualStyleBackColor = True
        '
        'text_alamat
        '
        Me.text_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_alamat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_alamat.Location = New System.Drawing.Point(102, 95)
        Me.text_alamat.Multiline = True
        Me.text_alamat.Name = "text_alamat"
        Me.text_alamat.Size = New System.Drawing.Size(207, 84)
        Me.text_alamat.TabIndex = 3
        '
        'text_nama
        '
        Me.text_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nama.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_nama.Location = New System.Drawing.Point(102, 60)
        Me.text_nama.Name = "text_nama"
        Me.text_nama.Size = New System.Drawing.Size(188, 21)
        Me.text_nama.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(12, 150)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(40, 39)
        Me.button_prev.TabIndex = 32
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(79, 149)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(41, 41)
        Me.button_next.TabIndex = 33
        Me.button_next.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textcari_hp)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.textcari_nama)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 119)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'textcari_hp
        '
        Me.textcari_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcari_hp.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.textcari_hp.Location = New System.Drawing.Point(91, 64)
        Me.textcari_hp.Name = "textcari_hp"
        Me.textcari_hp.Size = New System.Drawing.Size(157, 22)
        Me.textcari_hp.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(21, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "No HP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(21, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama"
        '
        'textcari_nama
        '
        Me.textcari_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcari_nama.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.textcari_nama.Location = New System.Drawing.Point(91, 27)
        Me.textcari_nama.Name = "textcari_nama"
        Me.textcari_nama.Size = New System.Drawing.Size(157, 22)
        Me.textcari_nama.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.Button3.Location = New System.Drawing.Point(273, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'combo_page
        '
        Me.combo_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page.FormattingEnabled = True
        Me.combo_page.Location = New System.Drawing.Point(435, 14)
        Me.combo_page.Name = "combo_page"
        Me.combo_page.Size = New System.Drawing.Size(51, 21)
        Me.combo_page.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(229, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total  Page"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(397, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Page"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(16, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Total Data"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(97, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "         "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combo_page)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.text_total_page)
        Me.GroupBox3.Controls.Add(Me.text_total_data)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(484, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(501, 41)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'text_total_page
        '
        Me.text_total_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page.Location = New System.Drawing.Point(297, 13)
        Me.text_total_page.Name = "text_total_page"
        Me.text_total_page.Size = New System.Drawing.Size(72, 20)
        Me.text_total_page.TabIndex = 40
        '
        'text_total_data
        '
        Me.text_total_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data.Location = New System.Drawing.Point(81, 14)
        Me.text_total_data.Name = "text_total_data"
        Me.text_total_data.Size = New System.Drawing.Size(72, 20)
        Me.text_total_data.TabIndex = 35
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(152, 149)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(43, 40)
        Me.tombol_home.TabIndex = 45
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Location = New System.Drawing.Point(869, 12)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 98)
        Me.tombol_csv.TabIndex = 60
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_delete_all.Location = New System.Drawing.Point(743, 12)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 98)
        Me.tombol_delete_all.TabIndex = 62
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'form_master_data_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 503)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_master_data_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Customer"
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents text_hp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents text_alamat As TextBox
    Friend WithEvents text_nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textcari_hp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textcari_nama As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents text_email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents text_telpon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents text_id As TextBox
    Friend WithEvents label_id As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents telpon As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
    Friend WithEvents hp As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tombol_home As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents tombol_delete_all As Button
End Class
