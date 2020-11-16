<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laporan_penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan_penjualan))
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_only = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combo_tahun = New System.Windows.Forms.ComboBox()
        Me.combo_bulan = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.text_tahun = New System.Windows.Forms.TextBox()
        Me.text_bulan = New System.Windows.Forms.TextBox()
        Me.text_tanggal_only = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.text_jumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.button_clear_data = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.tombol_simpan = New System.Windows.Forms.Button()
        Me.text_harga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_nama_produk = New System.Windows.Forms.TextBox()
        Me.text_waktu = New System.Windows.Forms.TextBox()
        Me.text_tanggal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text_kode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker_hingga = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_dari = New System.Windows.Forms.DateTimePicker()
        Me.tombol_cari = New System.Windows.Forms.Button()
        Me.tombol_print_preview = New System.Windows.Forms.Button()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.tombol_print = New System.Windows.Forms.Button()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.jum_print = New System.Windows.Forms.TextBox()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGView
        '
        Me.DGView.AllowUserToAddRows = False
        Me.DGView.AllowUserToDeleteRows = False
        Me.DGView.AllowUserToResizeRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tanggal_only, Me.tanggal, Me.waktu, Me.kode, Me.nama_produk, Me.harga, Me.jumlah, Me.bulan, Me.tahun})
        Me.DGView.Location = New System.Drawing.Point(12, 180)
        Me.DGView.Name = "DGView"
        Me.DGView.ReadOnly = True
        Me.DGView.Size = New System.Drawing.Size(817, 390)
        Me.DGView.TabIndex = 2
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'tanggal_only
        '
        Me.tanggal_only.DataPropertyName = "tanggal"
        Me.tanggal_only.HeaderText = "Tanggal"
        Me.tanggal_only.Name = "tanggal_only"
        Me.tanggal_only.ReadOnly = True
        Me.tanggal_only.Visible = False
        '
        'tanggal
        '
        Me.tanggal.HeaderText = "Tanggal Transaksi"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.DataPropertyName = "waktu"
        Me.waktu.HeaderText = "Waktu"
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
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
        Me.nama_produk.Width = 190
        '
        'harga
        '
        Me.harga.DataPropertyName = "harga"
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.Width = 140
        '
        'jumlah
        '
        Me.jumlah.DataPropertyName = "jumlah"
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        Me.jumlah.Width = 90
        '
        'bulan
        '
        Me.bulan.DataPropertyName = "bulan"
        Me.bulan.HeaderText = "Bulan"
        Me.bulan.Name = "bulan"
        Me.bulan.ReadOnly = True
        Me.bulan.Visible = False
        '
        'tahun
        '
        Me.tahun.DataPropertyName = "tahun"
        Me.tahun.HeaderText = "Tahun"
        Me.tahun.Name = "tahun"
        Me.tahun.ReadOnly = True
        Me.tahun.Visible = False
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
        Me.GroupBox3.Location = New System.Drawing.Point(332, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(497, 41)
        Me.GroupBox3.TabIndex = 44
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combo_tahun)
        Me.GroupBox1.Controls.Add(Me.combo_bulan)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(884, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 106)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tampilkan Berdasarkan Bulan dan Tahun"
        '
        'combo_tahun
        '
        Me.combo_tahun.FormattingEnabled = True
        Me.combo_tahun.Location = New System.Drawing.Point(72, 56)
        Me.combo_tahun.Name = "combo_tahun"
        Me.combo_tahun.Size = New System.Drawing.Size(121, 21)
        Me.combo_tahun.TabIndex = 57
        '
        'combo_bulan
        '
        Me.combo_bulan.FormattingEnabled = True
        Me.combo_bulan.Location = New System.Drawing.Point(72, 16)
        Me.combo_bulan.Name = "combo_bulan"
        Me.combo_bulan.Size = New System.Drawing.Size(121, 21)
        Me.combo_bulan.TabIndex = 56
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Image = Global.JStockInventory2.My.Resources.Resources.go
        Me.Button4.Location = New System.Drawing.Point(215, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 78)
        Me.Button4.TabIndex = 55
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(9, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Tahun"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(9, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Bulan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.text_tahun)
        Me.GroupBox2.Controls.Add(Me.text_bulan)
        Me.GroupBox2.Controls.Add(Me.text_tanggal_only)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.text_jumlah)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.text_id)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.button_clear_data)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.tombol_simpan)
        Me.GroupBox2.Controls.Add(Me.text_harga)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.text_nama_produk)
        Me.GroupBox2.Controls.Add(Me.text_waktu)
        Me.GroupBox2.Controls.Add(Me.text_tanggal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.text_kode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(848, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 337)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubah Data"
        '
        'text_tahun
        '
        Me.text_tahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_tahun.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_tahun.Location = New System.Drawing.Point(16, 301)
        Me.text_tahun.Name = "text_tahun"
        Me.text_tahun.Size = New System.Drawing.Size(89, 21)
        Me.text_tahun.TabIndex = 85
        Me.text_tahun.Visible = False
        '
        'text_bulan
        '
        Me.text_bulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_bulan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_bulan.Location = New System.Drawing.Point(16, 270)
        Me.text_bulan.Name = "text_bulan"
        Me.text_bulan.Size = New System.Drawing.Size(89, 21)
        Me.text_bulan.TabIndex = 84
        Me.text_bulan.Visible = False
        '
        'text_tanggal_only
        '
        Me.text_tanggal_only.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_tanggal_only.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_tanggal_only.Location = New System.Drawing.Point(16, 242)
        Me.text_tanggal_only.Name = "text_tanggal_only"
        Me.text_tanggal_only.Size = New System.Drawing.Size(89, 21)
        Me.text_tanggal_only.TabIndex = 83
        Me.text_tanggal_only.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(277, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "*"
        '
        'text_jumlah
        '
        Me.text_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah.Location = New System.Drawing.Point(116, 174)
        Me.text_jumlah.Name = "text_jumlah"
        Me.text_jumlah.Size = New System.Drawing.Size(89, 21)
        Me.text_jumlah.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(10, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Jumlah"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_id.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_id.Location = New System.Drawing.Point(146, 201)
        Me.text_id.Name = "text_id"
        Me.text_id.ReadOnly = True
        Me.text_id.Size = New System.Drawing.Size(59, 22)
        Me.text_id.TabIndex = 79
        Me.text_id.Text = "-777"
        Me.text_id.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(327, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 18)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(302, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 18)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(211, 232)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 16)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "* = harus diisi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(10, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Waktu"
        '
        'button_clear_data
        '
        Me.button_clear_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_clear_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_clear_data.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_clear_data.Image = Global.JStockInventory2.My.Resources.Resources.icon_retry
        Me.button_clear_data.Location = New System.Drawing.Point(168, 270)
        Me.button_clear_data.Name = "button_clear_data"
        Me.button_clear_data.Size = New System.Drawing.Size(53, 52)
        Me.button_clear_data.TabIndex = 73
        Me.button_clear_data.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Location = New System.Drawing.Point(247, 270)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 52)
        Me.Button6.TabIndex = 72
        Me.Button6.UseVisualStyleBackColor = True
        '
        'tombol_simpan
        '
        Me.tombol_simpan.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.tombol_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_simpan.Location = New System.Drawing.Point(321, 270)
        Me.tombol_simpan.Name = "tombol_simpan"
        Me.tombol_simpan.Size = New System.Drawing.Size(44, 52)
        Me.tombol_simpan.TabIndex = 71
        Me.tombol_simpan.UseVisualStyleBackColor = True
        '
        'text_harga
        '
        Me.text_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_harga.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_harga.Location = New System.Drawing.Point(116, 143)
        Me.text_harga.Name = "text_harga"
        Me.text_harga.Size = New System.Drawing.Size(155, 21)
        Me.text_harga.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(10, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(10, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Nama Barang"
        '
        'text_nama_produk
        '
        Me.text_nama_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nama_produk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_nama_produk.Location = New System.Drawing.Point(116, 113)
        Me.text_nama_produk.Name = "text_nama_produk"
        Me.text_nama_produk.Size = New System.Drawing.Size(205, 21)
        Me.text_nama_produk.TabIndex = 67
        '
        'text_waktu
        '
        Me.text_waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_waktu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_waktu.Location = New System.Drawing.Point(116, 56)
        Me.text_waktu.Name = "text_waktu"
        Me.text_waktu.Size = New System.Drawing.Size(105, 21)
        Me.text_waktu.TabIndex = 66
        '
        'text_tanggal
        '
        Me.text_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_tanggal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_tanggal.Location = New System.Drawing.Point(116, 22)
        Me.text_tanggal.Name = "text_tanggal"
        Me.text_tanggal.Size = New System.Drawing.Size(177, 21)
        Me.text_tanggal.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(10, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Tanggal"
        '
        'text_kode
        '
        Me.text_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_kode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_kode.Location = New System.Drawing.Point(116, 86)
        Me.text_kode.Name = "text_kode"
        Me.text_kode.Size = New System.Drawing.Size(155, 21)
        Me.text_kode.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(10, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Kode Barang"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker_hingga)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker_dari)
        Me.GroupBox5.Controls.Add(Me.tombol_cari)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox5.Location = New System.Drawing.Point(590, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(239, 112)
        Me.GroupBox5.TabIndex = 64
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tampilkan Berdasarkan Tanggal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(6, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Hingga"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(6, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 15)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Dari"
        '
        'DateTimePicker_hingga
        '
        Me.DateTimePicker_hingga.AllowDrop = True
        Me.DateTimePicker_hingga.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_hingga.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_hingga.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_hingga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_hingga.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_hingga.Location = New System.Drawing.Point(114, 51)
        Me.DateTimePicker_hingga.Name = "DateTimePicker_hingga"
        Me.DateTimePicker_hingga.Size = New System.Drawing.Size(114, 21)
        Me.DateTimePicker_hingga.TabIndex = 73
        '
        'DateTimePicker_dari
        '
        Me.DateTimePicker_dari.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_dari.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_dari.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_dari.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_dari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_dari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_dari.Location = New System.Drawing.Point(110, 21)
        Me.DateTimePicker_dari.Name = "DateTimePicker_dari"
        Me.DateTimePicker_dari.Size = New System.Drawing.Size(114, 21)
        Me.DateTimePicker_dari.TabIndex = 72
        '
        'tombol_cari
        '
        Me.tombol_cari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tombol_cari.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tombol_cari.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.tombol_cari.Location = New System.Drawing.Point(150, 78)
        Me.tombol_cari.Name = "tombol_cari"
        Me.tombol_cari.Size = New System.Drawing.Size(78, 23)
        Me.tombol_cari.TabIndex = 20
        Me.tombol_cari.UseVisualStyleBackColor = True
        '
        'tombol_print_preview
        '
        Me.tombol_print_preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print_preview.Image = Global.JStockInventory2.My.Resources.Resources.iconc_print_preview
        Me.tombol_print_preview.Location = New System.Drawing.Point(127, 2)
        Me.tombol_print_preview.Name = "tombol_print_preview"
        Me.tombol_print_preview.Size = New System.Drawing.Size(103, 96)
        Me.tombol_print_preview.TabIndex = 67
        Me.tombol_print_preview.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_csv.Location = New System.Drawing.Point(242, 2)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 96)
        Me.tombol_csv.TabIndex = 61
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'tombol_print
        '
        Me.tombol_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print.Image = Global.JStockInventory2.My.Resources.Resources.iconc_printf
        Me.tombol_print.Location = New System.Drawing.Point(11, 2)
        Me.tombol_print.Name = "tombol_print"
        Me.tombol_print.Size = New System.Drawing.Size(101, 96)
        Me.tombol_print.TabIndex = 60
        Me.tombol_print.UseVisualStyleBackColor = True
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(174, 129)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(46, 40)
        Me.tombol_home.TabIndex = 46
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(99, 129)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(41, 40)
        Me.button_next.TabIndex = 45
        Me.button_next.UseVisualStyleBackColor = True
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(12, 129)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(47, 40)
        Me.button_prev.TabIndex = 44
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(8, 103)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(185, 15)
        Me.Label22.TabIndex = 71
        Me.Label22.Text = "Jumlah maksimal data print"
        '
        'jum_print
        '
        Me.jum_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jum_print.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.jum_print.Location = New System.Drawing.Point(200, 101)
        Me.jum_print.Name = "jum_print"
        Me.jum_print.Size = New System.Drawing.Size(57, 21)
        Me.jum_print.TabIndex = 72
        Me.jum_print.Text = "300"
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_delete_all.Location = New System.Drawing.Point(362, 2)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 96)
        Me.tombol_delete_all.TabIndex = 73
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'laporan_penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 582)
        Me.Controls.Add(Me.tombol_delete_all)
        Me.Controls.Add(Me.jum_print)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tombol_print_preview)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tombol_csv)
        Me.Controls.Add(Me.tombol_print)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tombol_home)
        Me.Controls.Add(Me.button_next)
        Me.Controls.Add(Me.button_prev)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DGView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "laporan_penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Penjualan"
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents tombol_home As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents combo_tahun As ComboBox
    Friend WithEvents combo_bulan As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tombol_print As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents text_jumlah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents text_id As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents button_clear_data As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents tombol_simpan As Button
    Friend WithEvents text_harga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents text_nama_produk As TextBox
    Friend WithEvents text_waktu As TextBox
    Friend WithEvents text_tanggal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents text_kode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_only As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents waktu As DataGridViewTextBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents nama_produk As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents bulan As DataGridViewTextBoxColumn
    Friend WithEvents tahun As DataGridViewTextBoxColumn
    Friend WithEvents text_tahun As TextBox
    Friend WithEvents text_bulan As TextBox
    Friend WithEvents text_tanggal_only As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker_hingga As DateTimePicker
    Friend WithEvents DateTimePicker_dari As DateTimePicker
    Friend WithEvents tombol_cari As Button
    Friend WithEvents tombol_print_preview As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents jum_print As TextBox
    Friend WithEvents tombol_delete_all As Button
End Class
