<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stok))
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jum_stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.combo_masuk_kas = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.text_modus = New System.Windows.Forms.TextBox()
        Me.text_stok_orig = New System.Windows.Forms.TextBox()
        Me.combo_jual_beli = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.button_clear_data = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.label_id = New System.Windows.Forms.Label()
        Me.tombol_simpan = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.text_stok = New System.Windows.Forms.TextBox()
        Me.combo_id_gudang = New System.Windows.Forms.ComboBox()
        Me.text_harga = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combo_id_kategori = New System.Windows.Forms.ComboBox()
        Me.combo_id_merek = New System.Windows.Forms.ComboBox()
        Me.text_nama_produk = New System.Windows.Forms.TextBox()
        Me.text_kode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combo_merek = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.textcari_kode = New System.Windows.Forms.TextBox()
        Me.textcari_nama_barang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tombol_print_preview = New System.Windows.Forms.Button()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.tombol_print = New System.Windows.Forms.Button()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.jum_print = New System.Windows.Forms.TextBox()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToDeleteRows = False
        Me.DGView.AllowUserToResizeRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.kode, Me.nama_produk, Me.merek, Me.kategori, Me.harga, Me.jum_stok, Me.gudang})
        Me.DGView.Location = New System.Drawing.Point(148, 395)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.Size = New System.Drawing.Size(889, 273)
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
        'kode
        '
        Me.kode.DataPropertyName = "kode"
        Me.kode.HeaderText = "Kode Barang"
        Me.kode.Name = "kode"
        Me.kode.ReadOnly = True
        Me.kode.Width = 150
        '
        'nama_produk
        '
        Me.nama_produk.DataPropertyName = "nama_produk"
        Me.nama_produk.HeaderText = "Nama Barang"
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.ReadOnly = True
        Me.nama_produk.Width = 160
        '
        'merek
        '
        Me.merek.DataPropertyName = "merek"
        Me.merek.HeaderText = "Merek"
        Me.merek.Name = "merek"
        Me.merek.ReadOnly = True
        Me.merek.Width = 110
        '
        'kategori
        '
        Me.kategori.DataPropertyName = "kategori"
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        Me.kategori.ReadOnly = True
        Me.kategori.Width = 110
        '
        'harga
        '
        Me.harga.DataPropertyName = "harga"
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.Width = 120
        '
        'jum_stok
        '
        Me.jum_stok.DataPropertyName = "stok"
        Me.jum_stok.HeaderText = "Stok"
        Me.jum_stok.Name = "jum_stok"
        Me.jum_stok.ReadOnly = True
        Me.jum_stok.Width = 70
        '
        'gudang
        '
        Me.gudang.DataPropertyName = "gudang"
        Me.gudang.HeaderText = "Gudang"
        Me.gudang.Name = "gudang"
        Me.gudang.ReadOnly = True
        Me.gudang.Width = 120
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.combo_masuk_kas)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.text_modus)
        Me.GroupBox1.Controls.Add(Me.text_stok_orig)
        Me.GroupBox1.Controls.Add(Me.combo_jual_beli)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.button_clear_data)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.text_id)
        Me.GroupBox1.Controls.Add(Me.label_id)
        Me.GroupBox1.Controls.Add(Me.tombol_simpan)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.text_stok)
        Me.GroupBox1.Controls.Add(Me.combo_id_gudang)
        Me.GroupBox1.Controls.Add(Me.text_harga)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.combo_id_kategori)
        Me.GroupBox1.Controls.Add(Me.combo_id_merek)
        Me.GroupBox1.Controls.Add(Me.text_nama_produk)
        Me.GroupBox1.Controls.Add(Me.text_kode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(265, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(877, 341)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Data Stok"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(290, 180)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(562, 69)
        Me.TextBox1.TabIndex = 98
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(410, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(146, 15)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "Simpan di tabel kas ?"
        '
        'combo_masuk_kas
        '
        Me.combo_masuk_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_masuk_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_masuk_kas.FormattingEnabled = True
        Me.combo_masuk_kas.Items.AddRange(New Object() {"ya", "tidak"})
        Me.combo_masuk_kas.Location = New System.Drawing.Point(685, 87)
        Me.combo_masuk_kas.Name = "combo_masuk_kas"
        Me.combo_masuk_kas.Size = New System.Drawing.Size(121, 23)
        Me.combo_masuk_kas.TabIndex = 66
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Image = Global.JStockInventory2.My.Resources.Resources.icon_adjust
        Me.Button7.Location = New System.Drawing.Point(539, 284)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(54, 51)
        Me.Button7.TabIndex = 59
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(305, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 18)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "*"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(615, 284)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 51)
        Me.Button5.TabIndex = 57
        Me.Button5.UseVisualStyleBackColor = True
        '
        'text_modus
        '
        Me.text_modus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_modus.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_modus.Location = New System.Drawing.Point(308, 286)
        Me.text_modus.Name = "text_modus"
        Me.text_modus.Size = New System.Drawing.Size(104, 21)
        Me.text_modus.TabIndex = 56
        Me.text_modus.Visible = False
        '
        'text_stok_orig
        '
        Me.text_stok_orig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_stok_orig.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_stok_orig.Location = New System.Drawing.Point(308, 314)
        Me.text_stok_orig.Name = "text_stok_orig"
        Me.text_stok_orig.Size = New System.Drawing.Size(104, 21)
        Me.text_stok_orig.TabIndex = 55
        Me.text_stok_orig.Visible = False
        '
        'combo_jual_beli
        '
        Me.combo_jual_beli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_jual_beli.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_jual_beli.FormattingEnabled = True
        Me.combo_jual_beli.Items.AddRange(New Object() {"ya", "tidak"})
        Me.combo_jual_beli.Location = New System.Drawing.Point(685, 55)
        Me.combo_jual_beli.Name = "combo_jual_beli"
        Me.combo_jual_beli.Size = New System.Drawing.Size(121, 23)
        Me.combo_jual_beli.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(410, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(232, 15)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Simpan di pembelian / penjualan ?"
        '
        'button_clear_data
        '
        Me.button_clear_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_clear_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_clear_data.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_clear_data.Image = Global.JStockInventory2.My.Resources.Resources.icon_retry
        Me.button_clear_data.Location = New System.Drawing.Point(684, 285)
        Me.button_clear_data.Name = "button_clear_data"
        Me.button_clear_data.Size = New System.Drawing.Size(53, 52)
        Me.button_clear_data.TabIndex = 49
        Me.button_clear_data.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(798, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 18)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(754, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 16)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "* = harus diisi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(846, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 18)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(318, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "*"
        '
        'text_id
        '
        Me.text_id.Enabled = False
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_id.Location = New System.Drawing.Point(44, 300)
        Me.text_id.Name = "text_id"
        Me.text_id.Size = New System.Drawing.Size(42, 21)
        Me.text_id.TabIndex = 37
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.label_id.Location = New System.Drawing.Point(13, 303)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 15)
        Me.label_id.TabIndex = 36
        Me.label_id.Text = "ID"
        Me.label_id.Visible = False
        '
        'tombol_simpan
        '
        Me.tombol_simpan.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.tombol_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_simpan.Location = New System.Drawing.Point(829, 285)
        Me.tombol_simpan.Name = "tombol_simpan"
        Me.tombol_simpan.Size = New System.Drawing.Size(42, 52)
        Me.tombol_simpan.TabIndex = 35
        Me.tombol_simpan.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Location = New System.Drawing.Point(757, 285)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(49, 52)
        Me.Button6.TabIndex = 33
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(201, 312)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Browse"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.JStockInventory2.My.Resources.Resources._default
        Me.PictureBox1.Location = New System.Drawing.Point(124, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 121)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(14, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Image Produk"
        '
        'text_stok
        '
        Me.text_stok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_stok.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_stok.Location = New System.Drawing.Point(685, 152)
        Me.text_stok.Name = "text_stok"
        Me.text_stok.Size = New System.Drawing.Size(104, 21)
        Me.text_stok.TabIndex = 28
        '
        'combo_id_gudang
        '
        Me.combo_id_gudang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_id_gudang.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_id_gudang.FormattingEnabled = True
        Me.combo_id_gudang.Location = New System.Drawing.Point(684, 24)
        Me.combo_id_gudang.Name = "combo_id_gudang"
        Me.combo_id_gudang.Size = New System.Drawing.Size(133, 23)
        Me.combo_id_gudang.TabIndex = 27
        '
        'text_harga
        '
        Me.text_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_harga.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_harga.Location = New System.Drawing.Point(684, 119)
        Me.text_harga.Name = "text_harga"
        Me.text_harga.Size = New System.Drawing.Size(156, 21)
        Me.text_harga.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(410, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Gudang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(410, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Jumlah Stok"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(410, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Harga"
        '
        'combo_id_kategori
        '
        Me.combo_id_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_id_kategori.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_id_kategori.FormattingEnabled = True
        Me.combo_id_kategori.Location = New System.Drawing.Point(124, 117)
        Me.combo_id_kategori.Name = "combo_id_kategori"
        Me.combo_id_kategori.Size = New System.Drawing.Size(188, 23)
        Me.combo_id_kategori.TabIndex = 22
        '
        'combo_id_merek
        '
        Me.combo_id_merek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_id_merek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_id_merek.FormattingEnabled = True
        Me.combo_id_merek.Location = New System.Drawing.Point(124, 83)
        Me.combo_id_merek.Name = "combo_id_merek"
        Me.combo_id_merek.Size = New System.Drawing.Size(200, 23)
        Me.combo_id_merek.TabIndex = 21
        '
        'text_nama_produk
        '
        Me.text_nama_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nama_produk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_nama_produk.Location = New System.Drawing.Point(124, 53)
        Me.text_nama_produk.Name = "text_nama_produk"
        Me.text_nama_produk.Size = New System.Drawing.Size(188, 21)
        Me.text_nama_produk.TabIndex = 20
        '
        'text_kode
        '
        Me.text_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_kode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_kode.Location = New System.Drawing.Point(124, 20)
        Me.text_kode.Name = "text_kode"
        Me.text_kode.Size = New System.Drawing.Size(177, 21)
        Me.text_kode.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(14, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(14, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Merek"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(14, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kode Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combo_merek)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.textcari_kode)
        Me.GroupBox2.Controls.Add(Me.textcari_nama_barang)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(2, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 178)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'combo_merek
        '
        Me.combo_merek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_merek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_merek.FormattingEnabled = True
        Me.combo_merek.Location = New System.Drawing.Point(108, 86)
        Me.combo_merek.Name = "combo_merek"
        Me.combo_merek.Size = New System.Drawing.Size(133, 23)
        Me.combo_merek.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(1, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Merek"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.Button3.Location = New System.Drawing.Point(163, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.UseVisualStyleBackColor = True
        '
        'textcari_kode
        '
        Me.textcari_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcari_kode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textcari_kode.Location = New System.Drawing.Point(108, 21)
        Me.textcari_kode.Name = "textcari_kode"
        Me.textcari_kode.Size = New System.Drawing.Size(133, 21)
        Me.textcari_kode.TabIndex = 19
        '
        'textcari_nama_barang
        '
        Me.textcari_nama_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcari_nama_barang.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.textcari_nama_barang.Location = New System.Drawing.Point(108, 53)
        Me.textcari_nama_barang.Name = "textcari_nama_barang"
        Me.textcari_nama_barang.Size = New System.Drawing.Size(133, 21)
        Me.textcari_nama_barang.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(1, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(1, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Kode Barang"
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
        Me.GroupBox3.Location = New System.Drawing.Point(546, 348)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(497, 41)
        Me.GroupBox3.TabIndex = 43
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
        Me.text_total_page.Size = New System.Drawing.Size(41, 20)
        Me.text_total_page.TabIndex = 40
        '
        'text_total_data
        '
        Me.text_total_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data.Location = New System.Drawing.Point(71, 14)
        Me.text_total_data.Name = "text_total_data"
        Me.text_total_data.Size = New System.Drawing.Size(72, 20)
        Me.text_total_data.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(6, 19)
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(222, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total  Page"
        '
        'tombol_print_preview
        '
        Me.tombol_print_preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print_preview.Image = Global.JStockInventory2.My.Resources.Resources.iconc_print_preview
        Me.tombol_print_preview.Location = New System.Drawing.Point(20, 393)
        Me.tombol_print_preview.Name = "tombol_print_preview"
        Me.tombol_print_preview.Size = New System.Drawing.Size(103, 100)
        Me.tombol_print_preview.TabIndex = 48
        Me.tombol_print_preview.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_csv.Location = New System.Drawing.Point(1048, 395)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(103, 96)
        Me.tombol_csv.TabIndex = 47
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'tombol_print
        '
        Me.tombol_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print.Image = Global.JStockInventory2.My.Resources.Resources.iconc_printf
        Me.tombol_print.Location = New System.Drawing.Point(20, 569)
        Me.tombol_print.Name = "tombol_print"
        Me.tombol_print.Size = New System.Drawing.Size(103, 97)
        Me.tombol_print.TabIndex = 46
        Me.tombol_print.UseVisualStyleBackColor = True
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(309, 348)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(43, 39)
        Me.tombol_home.TabIndex = 45
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(231, 348)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(41, 41)
        Me.button_next.TabIndex = 20
        Me.button_next.UseVisualStyleBackColor = True
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(148, 349)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(47, 41)
        Me.button_prev.TabIndex = 19
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.JStockInventory2.My.Resources.Resources.stok_out
        Me.Button2.Location = New System.Drawing.Point(141, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 126)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.JStockInventory2.My.Resources.Resources.stok_in
        Me.Button1.Location = New System.Drawing.Point(6, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 126)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(17, 336)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(119, 15)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "Jumlah data print"
        '
        'jum_print
        '
        Me.jum_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jum_print.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.jum_print.Location = New System.Drawing.Point(51, 359)
        Me.jum_print.Name = "jum_print"
        Me.jum_print.Size = New System.Drawing.Size(57, 21)
        Me.jum_print.TabIndex = 60
        Me.jum_print.Text = "300"
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Location = New System.Drawing.Point(1048, 569)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 99)
        Me.tombol_delete_all.TabIndex = 73
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'stok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 680)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.jum_print)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tombol_print_preview)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.tombol_print)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "stok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Barang"
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents textcari_nama_barang As TextBox
    Friend WithEvents textcari_kode As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_merek As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents text_kode As TextBox
    Friend WithEvents text_nama_produk As TextBox
    Friend WithEvents combo_id_merek As ComboBox
    Friend WithEvents combo_id_kategori As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents text_stok As TextBox
    Friend WithEvents combo_id_gudang As ComboBox
    Friend WithEvents text_harga As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents tombol_simpan As Button
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents text_id As TextBox
    Friend WithEvents label_id As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tombol_home As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents nama_produk As DataGridViewTextBoxColumn
    Friend WithEvents merek As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jum_stok As DataGridViewTextBoxColumn
    Friend WithEvents gudang As DataGridViewTextBoxColumn
    Friend WithEvents button_clear_data As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents combo_jual_beli As ComboBox
    Friend WithEvents tombol_print As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents text_stok_orig As TextBox
    Friend WithEvents text_modus As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents tombol_print_preview As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents jum_print As TextBox
    Friend WithEvents tombol_delete_all As Button
    Friend WithEvents combo_masuk_kas As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
