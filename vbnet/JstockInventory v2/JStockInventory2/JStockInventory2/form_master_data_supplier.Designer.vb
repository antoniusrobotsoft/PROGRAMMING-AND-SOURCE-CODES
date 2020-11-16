<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_master_data_supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_master_data_supplier))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.label_id = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.text_hp = New System.Windows.Forms.TextBox()
        Me.text_fax = New System.Windows.Forms.TextBox()
        Me.text_telp = New System.Windows.Forms.TextBox()
        Me.text_email = New System.Windows.Forms.TextBox()
        Me.text_contact_person = New System.Windows.Forms.TextBox()
        Me.text_alamat = New System.Windows.Forms.TextBox()
        Me.text_nama_perusahaan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_perusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_person = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.textcari_nama_kontak = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textcari_nama_perusahaan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.text_id)
        Me.GroupBox1.Controls.Add(Me.label_id)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.text_hp)
        Me.GroupBox1.Controls.Add(Me.text_fax)
        Me.GroupBox1.Controls.Add(Me.text_telp)
        Me.GroupBox1.Controls.Add(Me.text_email)
        Me.GroupBox1.Controls.Add(Me.text_contact_person)
        Me.GroupBox1.Controls.Add(Me.text_alamat)
        Me.GroupBox1.Controls.Add(Me.text_nama_perusahaan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(932, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 452)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Data Supplier"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(281, 357)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "* = harus diisi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(346, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(372, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "*"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_id.Location = New System.Drawing.Point(140, 17)
        Me.text_id.Name = "text_id"
        Me.text_id.ReadOnly = True
        Me.text_id.Size = New System.Drawing.Size(54, 21)
        Me.text_id.TabIndex = 22
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Location = New System.Drawing.Point(6, 17)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 15)
        Me.label_id.TabIndex = 21
        Me.label_id.Text = "ID"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(347, 391)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 55)
        Me.Button8.TabIndex = 20
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(249, 391)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 55)
        Me.Button5.TabIndex = 17
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(140, 391)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 55)
        Me.Button4.TabIndex = 16
        Me.Button4.UseVisualStyleBackColor = True
        '
        'text_hp
        '
        Me.text_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_hp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_hp.Location = New System.Drawing.Point(140, 333)
        Me.text_hp.Name = "text_hp"
        Me.text_hp.Size = New System.Drawing.Size(200, 21)
        Me.text_hp.TabIndex = 14
        '
        'text_fax
        '
        Me.text_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_fax.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_fax.Location = New System.Drawing.Point(140, 294)
        Me.text_fax.Name = "text_fax"
        Me.text_fax.Size = New System.Drawing.Size(200, 21)
        Me.text_fax.TabIndex = 13
        '
        'text_telp
        '
        Me.text_telp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_telp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_telp.Location = New System.Drawing.Point(140, 253)
        Me.text_telp.Name = "text_telp"
        Me.text_telp.Size = New System.Drawing.Size(200, 21)
        Me.text_telp.TabIndex = 12
        '
        'text_email
        '
        Me.text_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_email.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_email.Location = New System.Drawing.Point(140, 215)
        Me.text_email.Name = "text_email"
        Me.text_email.Size = New System.Drawing.Size(251, 21)
        Me.text_email.TabIndex = 11
        '
        'text_contact_person
        '
        Me.text_contact_person.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_contact_person.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_contact_person.Location = New System.Drawing.Point(140, 177)
        Me.text_contact_person.Name = "text_contact_person"
        Me.text_contact_person.Size = New System.Drawing.Size(251, 21)
        Me.text_contact_person.TabIndex = 10
        '
        'text_alamat
        '
        Me.text_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_alamat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_alamat.Location = New System.Drawing.Point(140, 94)
        Me.text_alamat.Multiline = True
        Me.text_alamat.Name = "text_alamat"
        Me.text_alamat.Size = New System.Drawing.Size(251, 72)
        Me.text_alamat.TabIndex = 9
        '
        'text_nama_perusahaan
        '
        Me.text_nama_perusahaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nama_perusahaan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_nama_perusahaan.Location = New System.Drawing.Point(140, 53)
        Me.text_nama_perusahaan.Name = "text_nama_perusahaan"
        Me.text_nama_perusahaan.Size = New System.Drawing.Size(221, 21)
        Me.text_nama_perusahaan.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "HP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact Person"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Perusahaan"
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToDeleteRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_perusahaan, Me.alamat, Me.contact_person, Me.email, Me.telp, Me.fax, Me.hp})
        Me.DGView.Location = New System.Drawing.Point(8, 174)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.Size = New System.Drawing.Size(908, 290)
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
        'nama_perusahaan
        '
        Me.nama_perusahaan.DataPropertyName = "nama_perusahaan"
        Me.nama_perusahaan.HeaderText = "Perusahaan"
        Me.nama_perusahaan.Name = "nama_perusahaan"
        Me.nama_perusahaan.ReadOnly = True
        Me.nama_perusahaan.Width = 110
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        Me.alamat.Width = 160
        '
        'contact_person
        '
        Me.contact_person.DataPropertyName = "contact_person"
        Me.contact_person.HeaderText = "Nama Kontak"
        Me.contact_person.Name = "contact_person"
        Me.contact_person.ReadOnly = True
        Me.contact_person.Width = 130
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 123
        '
        'telp
        '
        Me.telp.DataPropertyName = "telp"
        Me.telp.HeaderText = "Telpon"
        Me.telp.Name = "telp"
        Me.telp.ReadOnly = True
        Me.telp.Width = 120
        '
        'fax
        '
        Me.fax.DataPropertyName = "fax"
        Me.fax.HeaderText = "Fax"
        Me.fax.Name = "fax"
        Me.fax.ReadOnly = True
        '
        'hp
        '
        Me.hp.DataPropertyName = "hp"
        Me.hp.HeaderText = "No HP"
        Me.hp.Name = "hp"
        Me.hp.ReadOnly = True
        Me.hp.Width = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textcari_nama_kontak)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.textcari_nama_perusahaan)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian"
        '
        'textcari_nama_kontak
        '
        Me.textcari_nama_kontak.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textcari_nama_kontak.Location = New System.Drawing.Point(154, 64)
        Me.textcari_nama_kontak.Name = "textcari_nama_kontak"
        Me.textcari_nama_kontak.Size = New System.Drawing.Size(170, 21)
        Me.textcari_nama_kontak.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Nama Kontak"
        '
        'textcari_nama_perusahaan
        '
        Me.textcari_nama_perusahaan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textcari_nama_perusahaan.Location = New System.Drawing.Point(154, 20)
        Me.textcari_nama_perusahaan.Name = "textcari_nama_perusahaan"
        Me.textcari_nama_perusahaan.Size = New System.Drawing.Size(170, 21)
        Me.textcari_nama_perusahaan.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nama Perusahaan"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.Button3.Location = New System.Drawing.Point(350, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 24)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(8, 127)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(41, 41)
        Me.button_prev.TabIndex = 0
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(77, 127)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(40, 41)
        Me.button_next.TabIndex = 1
        Me.button_next.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combo_page)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.text_total_page)
        Me.GroupBox3.Controls.Add(Me.text_total_data)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(425, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 41)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'combo_page
        '
        Me.combo_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page.FormattingEnabled = True
        Me.combo_page.Location = New System.Drawing.Point(434, 12)
        Me.combo_page.Name = "combo_page"
        Me.combo_page.Size = New System.Drawing.Size(44, 21)
        Me.combo_page.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(383, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Page"
        '
        'text_total_page
        '
        Me.text_total_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page.Location = New System.Drawing.Point(290, 13)
        Me.text_total_page.Name = "text_total_page"
        Me.text_total_page.Size = New System.Drawing.Size(59, 20)
        Me.text_total_page.TabIndex = 40
        '
        'text_total_data
        '
        Me.text_total_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data.Location = New System.Drawing.Point(82, 14)
        Me.text_total_data.Name = "text_total_data"
        Me.text_total_data.Size = New System.Drawing.Size(72, 20)
        Me.text_total_data.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(6, 20)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(222, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Total  Page"
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(147, 127)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(43, 39)
        Me.tombol_home.TabIndex = 45
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Location = New System.Drawing.Point(815, 12)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 98)
        Me.tombol_csv.TabIndex = 60
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_delete_all.Location = New System.Drawing.Point(659, 12)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 98)
        Me.tombol_delete_all.TabIndex = 63
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'form_master_data_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 476)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_master_data_supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Supplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGView As DataGridView
    Friend WithEvents text_hp As TextBox
    Friend WithEvents text_fax As TextBox
    Friend WithEvents text_telp As TextBox
    Friend WithEvents text_email As TextBox
    Friend WithEvents text_contact_person As TextBox
    Friend WithEvents text_alamat As TextBox
    Friend WithEvents text_nama_perusahaan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textcari_nama_perusahaan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents text_id As TextBox
    Friend WithEvents label_id As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_perusahaan As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
    Friend WithEvents contact_person As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents telp As DataGridViewTextBoxColumn
    Friend WithEvents fax As DataGridViewTextBoxColumn
    Friend WithEvents hp As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents textcari_nama_kontak As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tombol_home As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents tombol_delete_all As Button
End Class
