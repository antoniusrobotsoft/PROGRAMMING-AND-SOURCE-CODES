<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stok_keluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stok_keluar))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.text_jumlah_keluar = New System.Windows.Forms.TextBox()
        Me.text_harga = New System.Windows.Forms.TextBox()
        Me.text_nama_produk = New System.Windows.Forms.TextBox()
        Me.combo_id_kategori = New System.Windows.Forms.ComboBox()
        Me.combo_id_merek = New System.Windows.Forms.ComboBox()
        Me.text_kode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combo_id_gudang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.teks_subtotal = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.combo_masuk_kas = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.combo_penjualan = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.label_id = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tombol_simpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jum_stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grup = New System.Windows.Forms.GroupBox()
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combo_merek = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.textcari_kode = New System.Windows.Forms.TextBox()
        Me.textcari_nama_barang = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(208, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(6, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kategori / Jenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(385, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jumlah Keluar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(385, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Harga Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(6, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Merek"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Kode Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(6, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Image Produk"
        '
        'text_jumlah_keluar
        '
        Me.text_jumlah_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah_keluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah_keluar.Location = New System.Drawing.Point(594, 176)
        Me.text_jumlah_keluar.Name = "text_jumlah_keluar"
        Me.text_jumlah_keluar.Size = New System.Drawing.Size(100, 21)
        Me.text_jumlah_keluar.TabIndex = 10
        '
        'text_harga
        '
        Me.text_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_harga.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_harga.Location = New System.Drawing.Point(594, 132)
        Me.text_harga.Name = "text_harga"
        Me.text_harga.Size = New System.Drawing.Size(154, 21)
        Me.text_harga.TabIndex = 11
        '
        'text_nama_produk
        '
        Me.text_nama_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nama_produk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_nama_produk.Location = New System.Drawing.Point(123, 60)
        Me.text_nama_produk.Name = "text_nama_produk"
        Me.text_nama_produk.Size = New System.Drawing.Size(213, 21)
        Me.text_nama_produk.TabIndex = 12
        '
        'combo_id_kategori
        '
        Me.combo_id_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_id_kategori.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_id_kategori.FormattingEnabled = True
        Me.combo_id_kategori.Location = New System.Drawing.Point(123, 138)
        Me.combo_id_kategori.Name = "combo_id_kategori"
        Me.combo_id_kategori.Size = New System.Drawing.Size(200, 23)
        Me.combo_id_kategori.TabIndex = 13
        '
        'combo_id_merek
        '
        Me.combo_id_merek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_id_merek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_id_merek.FormattingEnabled = True
        Me.combo_id_merek.Location = New System.Drawing.Point(123, 94)
        Me.combo_id_merek.Name = "combo_id_merek"
        Me.combo_id_merek.Size = New System.Drawing.Size(200, 23)
        Me.combo_id_merek.TabIndex = 14
        '
        'text_kode
        '
        Me.text_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_kode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_kode.Location = New System.Drawing.Point(123, 23)
        Me.text_kode.Name = "text_kode"
        Me.text_kode.Size = New System.Drawing.Size(200, 21)
        Me.text_kode.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(385, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Gudang"
        '
        'combo_id_gudang
        '
        Me.combo_id_gudang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_id_gudang.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_id_gudang.FormattingEnabled = True
        Me.combo_id_gudang.Location = New System.Drawing.Point(594, 15)
        Me.combo_id_gudang.Name = "combo_id_gudang"
        Me.combo_id_gudang.Size = New System.Drawing.Size(171, 23)
        Me.combo_id_gudang.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama Barang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.teks_subtotal)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.combo_masuk_kas)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.combo_penjualan)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.text_id)
        Me.GroupBox1.Controls.Add(Me.label_id)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.text_harga)
        Me.GroupBox1.Controls.Add(Me.tombol_simpan)
        Me.GroupBox1.Controls.Add(Me.combo_id_gudang)
        Me.GroupBox1.Controls.Add(Me.text_kode)
        Me.GroupBox1.Controls.Add(Me.text_nama_produk)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.combo_id_merek)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.combo_id_kategori)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.text_jumlah_keluar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 346)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(708, 179)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 18)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "*"
        '
        'teks_subtotal
        '
        Me.teks_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_subtotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.teks_subtotal.Location = New System.Drawing.Point(594, 212)
        Me.teks_subtotal.Name = "teks_subtotal"
        Me.teks_subtotal.Size = New System.Drawing.Size(153, 21)
        Me.teks_subtotal.TabIndex = 70
        Me.teks_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(615, 281)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 58)
        Me.Button4.TabIndex = 69
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(385, 212)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 15)
        Me.Label22.TabIndex = 68
        Me.Label22.Text = "Subtotal"
        '
        'combo_masuk_kas
        '
        Me.combo_masuk_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_masuk_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_masuk_kas.FormattingEnabled = True
        Me.combo_masuk_kas.Items.AddRange(New Object() {"ya", "tidak"})
        Me.combo_masuk_kas.Location = New System.Drawing.Point(594, 89)
        Me.combo_masuk_kas.Name = "combo_masuk_kas"
        Me.combo_masuk_kas.Size = New System.Drawing.Size(121, 23)
        Me.combo_masuk_kas.TabIndex = 62
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(385, 97)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(146, 15)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Simpan di tabel kas ?"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(329, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 18)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "*"
        '
        'combo_penjualan
        '
        Me.combo_penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_penjualan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_penjualan.FormattingEnabled = True
        Me.combo_penjualan.Items.AddRange(New Object() {"ya", "tidak"})
        Me.combo_penjualan.Location = New System.Drawing.Point(594, 52)
        Me.combo_penjualan.Name = "combo_penjualan"
        Me.combo_penjualan.Size = New System.Drawing.Size(121, 23)
        Me.combo_penjualan.TabIndex = 53
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(385, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(188, 15)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Simpan di tabel penjualan ?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(756, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 18)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(721, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 18)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "*"
        '
        'text_id
        '
        Me.text_id.Enabled = False
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_id.Location = New System.Drawing.Point(329, 251)
        Me.text_id.Name = "text_id"
        Me.text_id.Size = New System.Drawing.Size(42, 21)
        Me.text_id.TabIndex = 49
        Me.text_id.Visible = False
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.label_id.Location = New System.Drawing.Point(302, 254)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 15)
        Me.label_id.TabIndex = 48
        Me.label_id.Text = "ID"
        Me.label_id.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(693, 257)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 16)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "* = harus diisi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(342, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "*"
        '
        'tombol_simpan
        '
        Me.tombol_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tombol_simpan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tombol_simpan.Image = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.tombol_simpan.Location = New System.Drawing.Point(749, 281)
        Me.tombol_simpan.Name = "tombol_simpan"
        Me.tombol_simpan.Size = New System.Drawing.Size(55, 59)
        Me.tombol_simpan.TabIndex = 16
        Me.tombol_simpan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.JStockInventory2.My.Resources.Resources._default
        Me.PictureBox1.Location = New System.Drawing.Point(123, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 127)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Image = Global.JStockInventory2.My.Resources.Resources.icon_retry
        Me.Button3.Location = New System.Drawing.Point(680, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 59)
        Me.Button3.TabIndex = 17
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToDeleteRows = False
        Me.DGView.AllowUserToResizeRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.kode, Me.nama_produk, Me.merek, Me.kategori, Me.harga, Me.jum_stok, Me.gudang})
        Me.DGView.Location = New System.Drawing.Point(134, 423)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGView.Size = New System.Drawing.Size(965, 273)
        Me.DGView.TabIndex = 22
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
        Me.kode.Width = 160
        '
        'nama_produk
        '
        Me.nama_produk.DataPropertyName = "nama_produk"
        Me.nama_produk.HeaderText = "Nama Barang"
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.ReadOnly = True
        Me.nama_produk.Width = 170
        '
        'merek
        '
        Me.merek.DataPropertyName = "merek"
        Me.merek.HeaderText = "Merek"
        Me.merek.Name = "merek"
        Me.merek.ReadOnly = True
        Me.merek.Width = 120
        '
        'kategori
        '
        Me.kategori.DataPropertyName = "kategori"
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        Me.kategori.ReadOnly = True
        Me.kategori.Width = 120
        '
        'harga
        '
        Me.harga.DataPropertyName = "harga"
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.Width = 130
        '
        'jum_stok
        '
        Me.jum_stok.DataPropertyName = "stok"
        Me.jum_stok.HeaderText = "Stok"
        Me.jum_stok.Name = "jum_stok"
        Me.jum_stok.ReadOnly = True
        Me.jum_stok.Width = 80
        '
        'gudang
        '
        Me.gudang.DataPropertyName = "gudang"
        Me.gudang.HeaderText = "Gudang"
        Me.gudang.Name = "gudang"
        Me.gudang.ReadOnly = True
        Me.gudang.Width = 130
        '
        'grup
        '
        Me.grup.Controls.Add(Me.combo_page)
        Me.grup.Controls.Add(Me.Label15)
        Me.grup.Controls.Add(Me.text_total_page)
        Me.grup.Controls.Add(Me.text_total_data)
        Me.grup.Controls.Add(Me.Label16)
        Me.grup.Controls.Add(Me.Label17)
        Me.grup.Controls.Add(Me.Label13)
        Me.grup.Location = New System.Drawing.Point(605, 375)
        Me.grup.Name = "grup"
        Me.grup.Size = New System.Drawing.Size(494, 41)
        Me.grup.TabIndex = 44
        Me.grup.TabStop = False
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combo_merek)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.textcari_kode)
        Me.GroupBox2.Controls.Add(Me.textcari_nama_barang)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 178)
        Me.GroupBox2.TabIndex = 46
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(1, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Merek"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.Button2.Location = New System.Drawing.Point(163, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.UseVisualStyleBackColor = True
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(1, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 15)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Nama Barang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(1, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 15)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Kode Barang"
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(255, 375)
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
        Me.button_next.Location = New System.Drawing.Point(194, 374)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(43, 41)
        Me.button_next.TabIndex = 24
        Me.button_next.UseVisualStyleBackColor = True
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(134, 374)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(44, 41)
        Me.button_prev.TabIndex = 23
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Location = New System.Drawing.Point(12, 597)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 99)
        Me.tombol_delete_all.TabIndex = 74
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Location = New System.Drawing.Point(12, 423)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 98)
        Me.tombol_csv.TabIndex = 75
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'stok_keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 705)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.grup)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "stok_keluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Barang Keluar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grup.ResumeLayout(False)
        Me.grup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents text_jumlah_keluar As System.Windows.Forms.TextBox
    Friend WithEvents text_harga As System.Windows.Forms.TextBox
    Friend WithEvents text_nama_produk As System.Windows.Forms.TextBox
    Friend WithEvents combo_id_kategori As System.Windows.Forms.ComboBox
    Friend WithEvents combo_id_merek As System.Windows.Forms.ComboBox
    Friend WithEvents tombol_simpan As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents text_kode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents combo_id_gudang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGView As DataGridView
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents grup As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tombol_home As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents label_id As Label
    Friend WithEvents text_id As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents combo_merek As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents textcari_kode As TextBox
    Friend WithEvents textcari_nama_barang As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents nama_produk As DataGridViewTextBoxColumn
    Friend WithEvents merek As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jum_stok As DataGridViewTextBoxColumn
    Friend WithEvents gudang As DataGridViewTextBoxColumn
    Friend WithEvents Label20 As Label
    Friend WithEvents combo_penjualan As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents combo_masuk_kas As ComboBox
    Friend WithEvents tombol_delete_all As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents teks_subtotal As TextBox
    Friend WithEvents Label24 As Label
End Class
