<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laporan_keuangan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan_keuangan))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_laba_rugi = New System.Windows.Forms.TabPage()
        Me.jum_print = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tombol_print_preview_laba_rugi = New System.Windows.Forms.Button()
        Me.tombol_csv_laba_rugi = New System.Windows.Forms.Button()
        Me.DGView_pembelian = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_date_pembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_pembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan_pembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_pembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGView_penjualan = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_date_penjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_penjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan_penjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_penjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.combo_page_data_pembelian = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.text_total_page_data_pembelian = New System.Windows.Forms.TextBox()
        Me.text_total_data_pembelian = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.button_home_data_pembelian = New System.Windows.Forms.Button()
        Me.button_next_data_pembelian = New System.Windows.Forms.Button()
        Me.button_prev_data_pembelian = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker_hingga = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_dari = New System.Windows.Forms.DateTimePicker()
        Me.button_go = New System.Windows.Forms.Button()
        Me.tombol_print_laba_rugi = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combo_page_data_penjualan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_total_page_data_penjualan = New System.Windows.Forms.TextBox()
        Me.text_total_data_penjualan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.button_home_data_penjualan = New System.Windows.Forms.Button()
        Me.button_next_data_penjualan = New System.Windows.Forms.Button()
        Me.button_prev_data_penjualan = New System.Windows.Forms.Button()
        Me.DGView_laba_rugi = New System.Windows.Forms.DataGridView()
        Me.dg_total_nilai_penjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_total_nilai_pembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_selisih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_laporan_kas = New System.Windows.Forms.TabPage()
        Me.jum_print_kas = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.DGView_kas_keluar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.combo_page_kas_keluar = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.text_total_page_kas_keluar = New System.Windows.Forms.TextBox()
        Me.text_total_data_kas_keluar = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tombol_home_kas_keluar = New System.Windows.Forms.Button()
        Me.button_next_kas_keluar = New System.Windows.Forms.Button()
        Me.button_prev_kas_keluar = New System.Windows.Forms.Button()
        Me.kotak_data_kas = New System.Windows.Forms.GroupBox()
        Me.text_status_kas = New System.Windows.Forms.TextBox()
        Me.text_selisih_kas = New System.Windows.Forms.TextBox()
        Me.text_jumlah_total_kas_keluar = New System.Windows.Forms.TextBox()
        Me.text_jumlah_total_kas_masuk = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tombol_home_kas_masuk = New System.Windows.Forms.Button()
        Me.button_next_kas_masuk = New System.Windows.Forms.Button()
        Me.button_prev_kas_masuk = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.combo_page_kas_masuk = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.text_total_page_kas_masuk = New System.Windows.Forms.TextBox()
        Me.text_total_data_kas_masuk = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DGView_kas_masuk = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tombol_print_preview_kas = New System.Windows.Forms.Button()
        Me.tombol_print_kas = New System.Windows.Forms.Button()
        Me.tombol_csv_kas = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtanggal_hingga = New System.Windows.Forms.DateTimePicker()
        Me.dtanggal_dari = New System.Windows.Forms.DateTimePicker()
        Me.tombol_cari = New System.Windows.Forms.Button()
        Me.text_jumlah_kas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_page_histori_kas = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page_histori_kas = New System.Windows.Forms.TextBox()
        Me.text_total_data_histori_kas = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tombol_home_histori_perubahan_kas = New System.Windows.Forms.Button()
        Me.button_next_histori_perubahan_kas = New System.Windows.Forms.Button()
        Me.button_prev_histori_perubahan_kas = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DGView_histori_perubahan_data_kas = New System.Windows.Forms.DataGridView()
        Me.jumlah_kas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selisih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tab_laba_rugi.SuspendLayout()
        CType(Me.DGView_pembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGView_penjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGView_laba_rugi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_laporan_kas.SuspendLayout()
        CType(Me.DGView_kas_keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.kotak_data_kas.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGView_kas_masuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGView_histori_perubahan_data_kas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_laba_rugi)
        Me.TabControl1.Controls.Add(Me.tab_laporan_kas)
        Me.TabControl1.Location = New System.Drawing.Point(12, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1150, 667)
        Me.TabControl1.TabIndex = 62
        '
        'tab_laba_rugi
        '
        Me.tab_laba_rugi.Controls.Add(Me.jum_print)
        Me.tab_laba_rugi.Controls.Add(Me.Label22)
        Me.tab_laba_rugi.Controls.Add(Me.tombol_print_preview_laba_rugi)
        Me.tab_laba_rugi.Controls.Add(Me.tombol_csv_laba_rugi)
        Me.tab_laba_rugi.Controls.Add(Me.DGView_pembelian)
        Me.tab_laba_rugi.Controls.Add(Me.DGView_penjualan)
        Me.tab_laba_rugi.Controls.Add(Me.TextBox10)
        Me.tab_laba_rugi.Controls.Add(Me.TextBox8)
        Me.tab_laba_rugi.Controls.Add(Me.TextBox7)
        Me.tab_laba_rugi.Controls.Add(Me.GroupBox6)
        Me.tab_laba_rugi.Controls.Add(Me.button_home_data_pembelian)
        Me.tab_laba_rugi.Controls.Add(Me.button_next_data_pembelian)
        Me.tab_laba_rugi.Controls.Add(Me.button_prev_data_pembelian)
        Me.tab_laba_rugi.Controls.Add(Me.GroupBox2)
        Me.tab_laba_rugi.Controls.Add(Me.tombol_print_laba_rugi)
        Me.tab_laba_rugi.Controls.Add(Me.GroupBox1)
        Me.tab_laba_rugi.Controls.Add(Me.button_home_data_penjualan)
        Me.tab_laba_rugi.Controls.Add(Me.button_next_data_penjualan)
        Me.tab_laba_rugi.Controls.Add(Me.button_prev_data_penjualan)
        Me.tab_laba_rugi.Controls.Add(Me.DGView_laba_rugi)
        Me.tab_laba_rugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_laba_rugi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tab_laba_rugi.Location = New System.Drawing.Point(4, 22)
        Me.tab_laba_rugi.Name = "tab_laba_rugi"
        Me.tab_laba_rugi.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_laba_rugi.Size = New System.Drawing.Size(1142, 641)
        Me.tab_laba_rugi.TabIndex = 0
        Me.tab_laba_rugi.Text = "Selisih Nilai Penjualan dan Pembelian"
        Me.tab_laba_rugi.UseVisualStyleBackColor = True
        '
        'jum_print
        '
        Me.jum_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jum_print.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.jum_print.Location = New System.Drawing.Point(201, 512)
        Me.jum_print.Name = "jum_print"
        Me.jum_print.Size = New System.Drawing.Size(57, 21)
        Me.jum_print.TabIndex = 83
        Me.jum_print.Text = "300"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(6, 516)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(185, 15)
        Me.Label22.TabIndex = 82
        Me.Label22.Text = "Jumlah maksimal data print"
        '
        'tombol_print_preview_laba_rugi
        '
        Me.tombol_print_preview_laba_rugi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print_preview_laba_rugi.Image = Global.JStockInventory2.My.Resources.Resources.iconc_print_preview
        Me.tombol_print_preview_laba_rugi.Location = New System.Drawing.Point(116, 544)
        Me.tombol_print_preview_laba_rugi.Name = "tombol_print_preview_laba_rugi"
        Me.tombol_print_preview_laba_rugi.Size = New System.Drawing.Size(103, 94)
        Me.tombol_print_preview_laba_rugi.TabIndex = 67
        Me.tombol_print_preview_laba_rugi.UseVisualStyleBackColor = True
        '
        'tombol_csv_laba_rugi
        '
        Me.tombol_csv_laba_rugi.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv_laba_rugi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_csv_laba_rugi.Location = New System.Drawing.Point(230, 541)
        Me.tombol_csv_laba_rugi.Name = "tombol_csv_laba_rugi"
        Me.tombol_csv_laba_rugi.Size = New System.Drawing.Size(101, 97)
        Me.tombol_csv_laba_rugi.TabIndex = 71
        Me.tombol_csv_laba_rugi.UseVisualStyleBackColor = True
        '
        'DGView_pembelian
        '
        Me.DGView_pembelian.AllowUserToAddRows = False
        Me.DGView_pembelian.AllowUserToDeleteRows = False
        Me.DGView_pembelian.AllowUserToResizeRows = False
        Me.DGView_pembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGView_pembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.full_date_pembelian, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.subtotal2, Me.tanggal_pembelian, Me.bulan_pembelian, Me.tahun_pembelian})
        Me.DGView_pembelian.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGView_pembelian.Location = New System.Drawing.Point(455, 407)
        Me.DGView_pembelian.MultiSelect = False
        Me.DGView_pembelian.Name = "DGView_pembelian"
        Me.DGView_pembelian.ReadOnly = True
        Me.DGView_pembelian.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGView_pembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGView_pembelian.Size = New System.Drawing.Size(674, 228)
        Me.DGView_pembelian.TabIndex = 81
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'full_date_pembelian
        '
        Me.full_date_pembelian.HeaderText = "Tanggal"
        Me.full_date_pembelian.Name = "full_date_pembelian"
        Me.full_date_pembelian.ReadOnly = True
        Me.full_date_pembelian.Width = 85
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "kode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nama_produk"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 190
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "harga"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "jumlah"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'subtotal2
        '
        Me.subtotal2.HeaderText = "Subtotal"
        Me.subtotal2.Name = "subtotal2"
        Me.subtotal2.ReadOnly = True
        Me.subtotal2.Width = 125
        '
        'tanggal_pembelian
        '
        Me.tanggal_pembelian.DataPropertyName = "tanggal"
        Me.tanggal_pembelian.HeaderText = "Tanggal"
        Me.tanggal_pembelian.Name = "tanggal_pembelian"
        Me.tanggal_pembelian.ReadOnly = True
        Me.tanggal_pembelian.Visible = False
        '
        'bulan_pembelian
        '
        Me.bulan_pembelian.DataPropertyName = "bulan"
        Me.bulan_pembelian.HeaderText = "Bulan"
        Me.bulan_pembelian.Name = "bulan_pembelian"
        Me.bulan_pembelian.ReadOnly = True
        Me.bulan_pembelian.Visible = False
        '
        'tahun_pembelian
        '
        Me.tahun_pembelian.DataPropertyName = "tahun"
        Me.tahun_pembelian.HeaderText = "Tahun"
        Me.tahun_pembelian.Name = "tahun_pembelian"
        Me.tahun_pembelian.ReadOnly = True
        Me.tahun_pembelian.Visible = False
        '
        'DGView_penjualan
        '
        Me.DGView_penjualan.AllowUserToAddRows = False
        Me.DGView_penjualan.AllowUserToDeleteRows = False
        Me.DGView_penjualan.AllowUserToResizeRows = False
        Me.DGView_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGView_penjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.full_date_penjualan, Me.kode, Me.nama_produk, Me.harga, Me.jumlah, Me.subtotal, Me.tanggal_penjualan, Me.bulan_penjualan, Me.tahun_penjualan})
        Me.DGView_penjualan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGView_penjualan.Location = New System.Drawing.Point(455, 81)
        Me.DGView_penjualan.MultiSelect = False
        Me.DGView_penjualan.Name = "DGView_penjualan"
        Me.DGView_penjualan.ReadOnly = True
        Me.DGView_penjualan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGView_penjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGView_penjualan.Size = New System.Drawing.Size(674, 227)
        Me.DGView_penjualan.TabIndex = 80
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'full_date_penjualan
        '
        Me.full_date_penjualan.HeaderText = "Tanggal"
        Me.full_date_penjualan.Name = "full_date_penjualan"
        Me.full_date_penjualan.ReadOnly = True
        Me.full_date_penjualan.Width = 85
        '
        'kode
        '
        Me.kode.DataPropertyName = "kode"
        Me.kode.HeaderText = "Kode Barang"
        Me.kode.Name = "kode"
        Me.kode.ReadOnly = True
        Me.kode.Width = 90
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
        '
        'jumlah
        '
        Me.jumlah.DataPropertyName = "jumlah"
        Me.jumlah.HeaderText = "Qty"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        Me.jumlah.Width = 40
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 125
        '
        'tanggal_penjualan
        '
        Me.tanggal_penjualan.DataPropertyName = "tanggal"
        Me.tanggal_penjualan.HeaderText = "Tanggal"
        Me.tanggal_penjualan.Name = "tanggal_penjualan"
        Me.tanggal_penjualan.ReadOnly = True
        Me.tanggal_penjualan.Visible = False
        Me.tanggal_penjualan.Width = 90
        '
        'bulan_penjualan
        '
        Me.bulan_penjualan.DataPropertyName = "bulan"
        Me.bulan_penjualan.HeaderText = "Bulan"
        Me.bulan_penjualan.Name = "bulan_penjualan"
        Me.bulan_penjualan.ReadOnly = True
        Me.bulan_penjualan.Visible = False
        '
        'tahun_penjualan
        '
        Me.tahun_penjualan.DataPropertyName = "tahun"
        Me.tahun_penjualan.HeaderText = "Tahun"
        Me.tahun_penjualan.Name = "tahun_penjualan"
        Me.tahun_penjualan.ReadOnly = True
        Me.tahun_penjualan.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox10.Enabled = False
        Me.TextBox10.ForeColor = System.Drawing.SystemColors.Control
        Me.TextBox10.Location = New System.Drawing.Point(455, 314)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(674, 21)
        Me.TextBox10.TabIndex = 79
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox8.Location = New System.Drawing.Point(455, 388)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(674, 22)
        Me.TextBox8.TabIndex = 78
        Me.TextBox8.Text = "DATA PEMBELIAN"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox7.Location = New System.Drawing.Point(455, 59)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(674, 22)
        Me.TextBox7.TabIndex = 77
        Me.TextBox7.Text = "DATA PENJUALAN"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.combo_page_data_pembelian)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.text_total_page_data_pembelian)
        Me.GroupBox6.Controls.Add(Me.text_total_data_pembelian)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Location = New System.Drawing.Point(679, 341)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(450, 41)
        Me.GroupBox6.TabIndex = 69
        Me.GroupBox6.TabStop = False
        '
        'combo_page_data_pembelian
        '
        Me.combo_page_data_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page_data_pembelian.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page_data_pembelian.FormattingEnabled = True
        Me.combo_page_data_pembelian.Location = New System.Drawing.Point(400, 12)
        Me.combo_page_data_pembelian.Name = "combo_page_data_pembelian"
        Me.combo_page_data_pembelian.Size = New System.Drawing.Size(44, 21)
        Me.combo_page_data_pembelian.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(358, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Page"
        '
        'text_total_page_data_pembelian
        '
        Me.text_total_page_data_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page_data_pembelian.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page_data_pembelian.Location = New System.Drawing.Point(288, 12)
        Me.text_total_page_data_pembelian.Name = "text_total_page_data_pembelian"
        Me.text_total_page_data_pembelian.Size = New System.Drawing.Size(41, 20)
        Me.text_total_page_data_pembelian.TabIndex = 40
        '
        'text_total_data_pembelian
        '
        Me.text_total_data_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data_pembelian.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data_pembelian.Location = New System.Drawing.Point(85, 11)
        Me.text_total_data_pembelian.Name = "text_total_data_pembelian"
        Me.text_total_data_pembelian.Size = New System.Drawing.Size(72, 20)
        Me.text_total_data_pembelian.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(16, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 15)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Total Data"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(97, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 15)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "         "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(203, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 15)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Total  Page"
        '
        'button_home_data_pembelian
        '
        Me.button_home_data_pembelian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_home_data_pembelian.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.button_home_data_pembelian.Location = New System.Drawing.Point(555, 341)
        Me.button_home_data_pembelian.Name = "button_home_data_pembelian"
        Me.button_home_data_pembelian.Size = New System.Drawing.Size(43, 41)
        Me.button_home_data_pembelian.TabIndex = 76
        Me.button_home_data_pembelian.UseVisualStyleBackColor = True
        '
        'button_next_data_pembelian
        '
        Me.button_next_data_pembelian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next_data_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next_data_pembelian.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next_data_pembelian.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next_data_pembelian.Location = New System.Drawing.Point(508, 341)
        Me.button_next_data_pembelian.Name = "button_next_data_pembelian"
        Me.button_next_data_pembelian.Size = New System.Drawing.Size(41, 41)
        Me.button_next_data_pembelian.TabIndex = 75
        Me.button_next_data_pembelian.UseVisualStyleBackColor = True
        '
        'button_prev_data_pembelian
        '
        Me.button_prev_data_pembelian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev_data_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev_data_pembelian.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev_data_pembelian.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev_data_pembelian.Location = New System.Drawing.Point(455, 341)
        Me.button_prev_data_pembelian.Name = "button_prev_data_pembelian"
        Me.button_prev_data_pembelian.Size = New System.Drawing.Size(47, 41)
        Me.button_prev_data_pembelian.TabIndex = 74
        Me.button_prev_data_pembelian.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_hingga)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_dari)
        Me.GroupBox2.Controls.Add(Me.button_go)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 122)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(17, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 15)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Hingga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(17, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Dari"
        '
        'DateTimePicker_hingga
        '
        Me.DateTimePicker_hingga.AllowDrop = True
        Me.DateTimePicker_hingga.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_hingga.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_hingga.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_hingga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_hingga.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_hingga.Location = New System.Drawing.Point(94, 76)
        Me.DateTimePicker_hingga.Name = "DateTimePicker_hingga"
        Me.DateTimePicker_hingga.Size = New System.Drawing.Size(114, 21)
        Me.DateTimePicker_hingga.TabIndex = 72
        '
        'DateTimePicker_dari
        '
        Me.DateTimePicker_dari.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_dari.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_dari.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_dari.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_dari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_dari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_dari.Location = New System.Drawing.Point(94, 26)
        Me.DateTimePicker_dari.Name = "DateTimePicker_dari"
        Me.DateTimePicker_dari.Size = New System.Drawing.Size(114, 21)
        Me.DateTimePicker_dari.TabIndex = 71
        '
        'button_go
        '
        Me.button_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_go.Image = Global.JStockInventory2.My.Resources.Resources.go
        Me.button_go.Location = New System.Drawing.Point(339, 31)
        Me.button_go.Name = "button_go"
        Me.button_go.Size = New System.Drawing.Size(84, 78)
        Me.button_go.TabIndex = 57
        Me.button_go.UseVisualStyleBackColor = True
        '
        'tombol_print_laba_rugi
        '
        Me.tombol_print_laba_rugi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print_laba_rugi.Image = Global.JStockInventory2.My.Resources.Resources.iconc_printf
        Me.tombol_print_laba_rugi.Location = New System.Drawing.Point(6, 544)
        Me.tombol_print_laba_rugi.Name = "tombol_print_laba_rugi"
        Me.tombol_print_laba_rugi.Size = New System.Drawing.Size(101, 94)
        Me.tombol_print_laba_rugi.TabIndex = 70
        Me.tombol_print_laba_rugi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combo_page_data_penjualan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.text_total_page_data_penjualan)
        Me.GroupBox1.Controls.Add(Me.text_total_data_penjualan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(679, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 41)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'combo_page_data_penjualan
        '
        Me.combo_page_data_penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page_data_penjualan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page_data_penjualan.FormattingEnabled = True
        Me.combo_page_data_penjualan.Location = New System.Drawing.Point(400, 12)
        Me.combo_page_data_penjualan.Name = "combo_page_data_penjualan"
        Me.combo_page_data_penjualan.Size = New System.Drawing.Size(44, 21)
        Me.combo_page_data_penjualan.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(358, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Page"
        '
        'text_total_page_data_penjualan
        '
        Me.text_total_page_data_penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page_data_penjualan.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page_data_penjualan.Location = New System.Drawing.Point(288, 12)
        Me.text_total_page_data_penjualan.Name = "text_total_page_data_penjualan"
        Me.text_total_page_data_penjualan.Size = New System.Drawing.Size(41, 20)
        Me.text_total_page_data_penjualan.TabIndex = 40
        '
        'text_total_data_penjualan
        '
        Me.text_total_data_penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data_penjualan.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data_penjualan.Location = New System.Drawing.Point(85, 11)
        Me.text_total_data_penjualan.Name = "text_total_data_penjualan"
        Me.text_total_data_penjualan.Size = New System.Drawing.Size(72, 20)
        Me.text_total_data_penjualan.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Total Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(97, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "         "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(203, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Total  Page"
        '
        'button_home_data_penjualan
        '
        Me.button_home_data_penjualan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_home_data_penjualan.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.button_home_data_penjualan.Location = New System.Drawing.Point(555, 8)
        Me.button_home_data_penjualan.Name = "button_home_data_penjualan"
        Me.button_home_data_penjualan.Size = New System.Drawing.Size(43, 40)
        Me.button_home_data_penjualan.TabIndex = 67
        Me.button_home_data_penjualan.UseVisualStyleBackColor = True
        '
        'button_next_data_penjualan
        '
        Me.button_next_data_penjualan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next_data_penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next_data_penjualan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next_data_penjualan.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next_data_penjualan.Location = New System.Drawing.Point(508, 8)
        Me.button_next_data_penjualan.Name = "button_next_data_penjualan"
        Me.button_next_data_penjualan.Size = New System.Drawing.Size(41, 40)
        Me.button_next_data_penjualan.TabIndex = 66
        Me.button_next_data_penjualan.UseVisualStyleBackColor = True
        '
        'button_prev_data_penjualan
        '
        Me.button_prev_data_penjualan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev_data_penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev_data_penjualan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev_data_penjualan.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev_data_penjualan.Location = New System.Drawing.Point(455, 8)
        Me.button_prev_data_penjualan.Name = "button_prev_data_penjualan"
        Me.button_prev_data_penjualan.Size = New System.Drawing.Size(47, 41)
        Me.button_prev_data_penjualan.TabIndex = 65
        Me.button_prev_data_penjualan.UseVisualStyleBackColor = True
        '
        'DGView_laba_rugi
        '
        Me.DGView_laba_rugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView_laba_rugi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dg_total_nilai_penjualan, Me.dg_total_nilai_pembelian, Me.dg_selisih})
        Me.DGView_laba_rugi.Location = New System.Drawing.Point(6, 210)
        Me.DGView_laba_rugi.Margin = New System.Windows.Forms.Padding(1)
        Me.DGView_laba_rugi.Name = "DGView_laba_rugi"
        Me.DGView_laba_rugi.Size = New System.Drawing.Size(445, 66)
        Me.DGView_laba_rugi.TabIndex = 63
        '
        'dg_total_nilai_penjualan
        '
        Me.dg_total_nilai_penjualan.HeaderText = "Total Nilai Penjualan"
        Me.dg_total_nilai_penjualan.Name = "dg_total_nilai_penjualan"
        Me.dg_total_nilai_penjualan.Width = 150
        '
        'dg_total_nilai_pembelian
        '
        Me.dg_total_nilai_pembelian.HeaderText = "Total Nilai Pembelian"
        Me.dg_total_nilai_pembelian.Name = "dg_total_nilai_pembelian"
        Me.dg_total_nilai_pembelian.Width = 150
        '
        'dg_selisih
        '
        Me.dg_selisih.HeaderText = "Selisih"
        Me.dg_selisih.Name = "dg_selisih"
        '
        'tab_laporan_kas
        '
        Me.tab_laporan_kas.Controls.Add(Me.jum_print_kas)
        Me.tab_laporan_kas.Controls.Add(Me.Label28)
        Me.tab_laporan_kas.Controls.Add(Me.TextBox12)
        Me.tab_laporan_kas.Controls.Add(Me.DGView_kas_keluar)
        Me.tab_laporan_kas.Controls.Add(Me.GroupBox7)
        Me.tab_laporan_kas.Controls.Add(Me.tombol_home_kas_keluar)
        Me.tab_laporan_kas.Controls.Add(Me.button_next_kas_keluar)
        Me.tab_laporan_kas.Controls.Add(Me.button_prev_kas_keluar)
        Me.tab_laporan_kas.Controls.Add(Me.kotak_data_kas)
        Me.tab_laporan_kas.Controls.Add(Me.tombol_home_kas_masuk)
        Me.tab_laporan_kas.Controls.Add(Me.button_next_kas_masuk)
        Me.tab_laporan_kas.Controls.Add(Me.button_prev_kas_masuk)
        Me.tab_laporan_kas.Controls.Add(Me.GroupBox4)
        Me.tab_laporan_kas.Controls.Add(Me.TextBox2)
        Me.tab_laporan_kas.Controls.Add(Me.DGView_kas_masuk)
        Me.tab_laporan_kas.Controls.Add(Me.tombol_print_preview_kas)
        Me.tab_laporan_kas.Controls.Add(Me.tombol_print_kas)
        Me.tab_laporan_kas.Controls.Add(Me.tombol_csv_kas)
        Me.tab_laporan_kas.Controls.Add(Me.GroupBox5)
        Me.tab_laporan_kas.Controls.Add(Me.text_jumlah_kas)
        Me.tab_laporan_kas.Controls.Add(Me.Label5)
        Me.tab_laporan_kas.Controls.Add(Me.GroupBox3)
        Me.tab_laporan_kas.Controls.Add(Me.tombol_home_histori_perubahan_kas)
        Me.tab_laporan_kas.Controls.Add(Me.button_next_histori_perubahan_kas)
        Me.tab_laporan_kas.Controls.Add(Me.button_prev_histori_perubahan_kas)
        Me.tab_laporan_kas.Controls.Add(Me.TextBox1)
        Me.tab_laporan_kas.Controls.Add(Me.DGView_histori_perubahan_data_kas)
        Me.tab_laporan_kas.Location = New System.Drawing.Point(4, 22)
        Me.tab_laporan_kas.Name = "tab_laporan_kas"
        Me.tab_laporan_kas.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_laporan_kas.Size = New System.Drawing.Size(1142, 641)
        Me.tab_laporan_kas.TabIndex = 1
        Me.tab_laporan_kas.Text = "Laporan Kas"
        Me.tab_laporan_kas.UseVisualStyleBackColor = True
        '
        'jum_print_kas
        '
        Me.jum_print_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jum_print_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.jum_print_kas.Location = New System.Drawing.Point(1072, 116)
        Me.jum_print_kas.Name = "jum_print_kas"
        Me.jum_print_kas.Size = New System.Drawing.Size(57, 21)
        Me.jum_print_kas.TabIndex = 102
        Me.jum_print_kas.Text = "300"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(881, 122)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(185, 15)
        Me.Label28.TabIndex = 101
        Me.Label28.Text = "Jumlah maksimal data print"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox12.Location = New System.Drawing.Point(642, 349)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(475, 22)
        Me.TextBox12.TabIndex = 100
        Me.TextBox12.Text = "HISTORI KAS KELUAR"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGView_kas_keluar
        '
        Me.DGView_kas_keluar.AllowUserToAddRows = False
        Me.DGView_kas_keluar.AllowUserToDeleteRows = False
        Me.DGView_kas_keluar.AllowUserToResizeRows = False
        Me.DGView_kas_keluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView_kas_keluar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.DGView_kas_keluar.Location = New System.Drawing.Point(642, 373)
        Me.DGView_kas_keluar.Name = "DGView_kas_keluar"
        Me.DGView_kas_keluar.ReadOnly = True
        Me.DGView_kas_keluar.Size = New System.Drawing.Size(475, 265)
        Me.DGView_kas_keluar.TabIndex = 99
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "jumlah_kas_masuk_atau_keluar"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn13.HeaderText = "Jumlah"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 160
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "full_date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tgl"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 130
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "mark"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Mark"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 140
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.combo_page_kas_keluar)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.text_total_page_kas_keluar)
        Me.GroupBox7.Controls.Add(Me.text_total_data_kas_keluar)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Location = New System.Drawing.Point(787, 306)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(330, 41)
        Me.GroupBox7.TabIndex = 85
        Me.GroupBox7.TabStop = False
        '
        'combo_page_kas_keluar
        '
        Me.combo_page_kas_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page_kas_keluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page_kas_keluar.FormattingEnabled = True
        Me.combo_page_kas_keluar.Location = New System.Drawing.Point(269, 15)
        Me.combo_page_kas_keluar.Name = "combo_page_kas_keluar"
        Me.combo_page_kas_keluar.Size = New System.Drawing.Size(51, 21)
        Me.combo_page_kas_keluar.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(234, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Page"
        '
        'text_total_page_kas_keluar
        '
        Me.text_total_page_kas_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page_kas_keluar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page_kas_keluar.Location = New System.Drawing.Point(186, 14)
        Me.text_total_page_kas_keluar.Name = "text_total_page_kas_keluar"
        Me.text_total_page_kas_keluar.Size = New System.Drawing.Size(45, 20)
        Me.text_total_page_kas_keluar.TabIndex = 40
        '
        'text_total_data_kas_keluar
        '
        Me.text_total_data_kas_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data_kas_keluar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data_kas_keluar.Location = New System.Drawing.Point(63, 13)
        Me.text_total_data_kas_keluar.Name = "text_total_data_kas_keluar"
        Me.text_total_data_kas_keluar.Size = New System.Drawing.Size(55, 20)
        Me.text_total_data_kas_keluar.TabIndex = 35
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(0, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 38
        Me.Label26.Text = "Total Data"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label27.Location = New System.Drawing.Point(124, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Total  Page"
        '
        'tombol_home_kas_keluar
        '
        Me.tombol_home_kas_keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home_kas_keluar.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home_kas_keluar.Location = New System.Drawing.Point(738, 308)
        Me.tombol_home_kas_keluar.Name = "tombol_home_kas_keluar"
        Me.tombol_home_kas_keluar.Size = New System.Drawing.Size(43, 38)
        Me.tombol_home_kas_keluar.TabIndex = 98
        Me.tombol_home_kas_keluar.UseVisualStyleBackColor = True
        '
        'button_next_kas_keluar
        '
        Me.button_next_kas_keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next_kas_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next_kas_keluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next_kas_keluar.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next_kas_keluar.Location = New System.Drawing.Point(689, 308)
        Me.button_next_kas_keluar.Name = "button_next_kas_keluar"
        Me.button_next_kas_keluar.Size = New System.Drawing.Size(39, 38)
        Me.button_next_kas_keluar.TabIndex = 97
        Me.button_next_kas_keluar.UseVisualStyleBackColor = True
        '
        'button_prev_kas_keluar
        '
        Me.button_prev_kas_keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev_kas_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev_kas_keluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev_kas_keluar.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev_kas_keluar.Location = New System.Drawing.Point(642, 308)
        Me.button_prev_kas_keluar.Name = "button_prev_kas_keluar"
        Me.button_prev_kas_keluar.Size = New System.Drawing.Size(41, 38)
        Me.button_prev_kas_keluar.TabIndex = 96
        Me.button_prev_kas_keluar.UseVisualStyleBackColor = True
        '
        'kotak_data_kas
        '
        Me.kotak_data_kas.Controls.Add(Me.text_status_kas)
        Me.kotak_data_kas.Controls.Add(Me.text_selisih_kas)
        Me.kotak_data_kas.Controls.Add(Me.text_jumlah_total_kas_keluar)
        Me.kotak_data_kas.Controls.Add(Me.text_jumlah_total_kas_masuk)
        Me.kotak_data_kas.Controls.Add(Me.Label24)
        Me.kotak_data_kas.Controls.Add(Me.Label23)
        Me.kotak_data_kas.Controls.Add(Me.Label21)
        Me.kotak_data_kas.Controls.Add(Me.Label17)
        Me.kotak_data_kas.Location = New System.Drawing.Point(646, 143)
        Me.kotak_data_kas.Name = "kotak_data_kas"
        Me.kotak_data_kas.Size = New System.Drawing.Size(465, 161)
        Me.kotak_data_kas.TabIndex = 95
        Me.kotak_data_kas.TabStop = False
        '
        'text_status_kas
        '
        Me.text_status_kas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.text_status_kas.Enabled = False
        Me.text_status_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_status_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_status_kas.Location = New System.Drawing.Point(206, 119)
        Me.text_status_kas.Name = "text_status_kas"
        Me.text_status_kas.Size = New System.Drawing.Size(167, 21)
        Me.text_status_kas.TabIndex = 101
        '
        'text_selisih_kas
        '
        Me.text_selisih_kas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.text_selisih_kas.Enabled = False
        Me.text_selisih_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_selisih_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_selisih_kas.Location = New System.Drawing.Point(206, 90)
        Me.text_selisih_kas.Name = "text_selisih_kas"
        Me.text_selisih_kas.Size = New System.Drawing.Size(216, 21)
        Me.text_selisih_kas.TabIndex = 100
        Me.text_selisih_kas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'text_jumlah_total_kas_keluar
        '
        Me.text_jumlah_total_kas_keluar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.text_jumlah_total_kas_keluar.Enabled = False
        Me.text_jumlah_total_kas_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah_total_kas_keluar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah_total_kas_keluar.Location = New System.Drawing.Point(206, 59)
        Me.text_jumlah_total_kas_keluar.Name = "text_jumlah_total_kas_keluar"
        Me.text_jumlah_total_kas_keluar.Size = New System.Drawing.Size(216, 21)
        Me.text_jumlah_total_kas_keluar.TabIndex = 99
        Me.text_jumlah_total_kas_keluar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'text_jumlah_total_kas_masuk
        '
        Me.text_jumlah_total_kas_masuk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.text_jumlah_total_kas_masuk.Enabled = False
        Me.text_jumlah_total_kas_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah_total_kas_masuk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah_total_kas_masuk.Location = New System.Drawing.Point(206, 28)
        Me.text_jumlah_total_kas_masuk.Name = "text_jumlah_total_kas_masuk"
        Me.text_jumlah_total_kas_masuk.Size = New System.Drawing.Size(216, 21)
        Me.text_jumlah_total_kas_masuk.TabIndex = 96
        Me.text_jumlah_total_kas_masuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(19, 122)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 15)
        Me.Label24.TabIndex = 98
        Me.Label24.Text = "Status"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(19, 93)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 15)
        Me.Label23.TabIndex = 97
        Me.Label23.Text = "Selisih"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(19, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(164, 15)
        Me.Label21.TabIndex = 96
        Me.Label21.Text = "Jumlah Total Kas Keluar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(19, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(164, 15)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "Jumlah Total Kas Masuk"
        '
        'tombol_home_kas_masuk
        '
        Me.tombol_home_kas_masuk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home_kas_masuk.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home_kas_masuk.Location = New System.Drawing.Point(97, 310)
        Me.tombol_home_kas_masuk.Name = "tombol_home_kas_masuk"
        Me.tombol_home_kas_masuk.Size = New System.Drawing.Size(43, 38)
        Me.tombol_home_kas_masuk.TabIndex = 94
        Me.tombol_home_kas_masuk.UseVisualStyleBackColor = True
        '
        'button_next_kas_masuk
        '
        Me.button_next_kas_masuk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next_kas_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next_kas_masuk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next_kas_masuk.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next_kas_masuk.Location = New System.Drawing.Point(49, 309)
        Me.button_next_kas_masuk.Name = "button_next_kas_masuk"
        Me.button_next_kas_masuk.Size = New System.Drawing.Size(39, 38)
        Me.button_next_kas_masuk.TabIndex = 93
        Me.button_next_kas_masuk.UseVisualStyleBackColor = True
        '
        'button_prev_kas_masuk
        '
        Me.button_prev_kas_masuk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev_kas_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev_kas_masuk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev_kas_masuk.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev_kas_masuk.Location = New System.Drawing.Point(6, 310)
        Me.button_prev_kas_masuk.Name = "button_prev_kas_masuk"
        Me.button_prev_kas_masuk.Size = New System.Drawing.Size(37, 38)
        Me.button_prev_kas_masuk.TabIndex = 92
        Me.button_prev_kas_masuk.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.combo_page_kas_masuk)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.text_total_page_kas_masuk)
        Me.GroupBox4.Controls.Add(Me.text_total_data_kas_masuk)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(146, 308)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(345, 41)
        Me.GroupBox4.TabIndex = 84
        Me.GroupBox4.TabStop = False
        '
        'combo_page_kas_masuk
        '
        Me.combo_page_kas_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page_kas_masuk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page_kas_masuk.FormattingEnabled = True
        Me.combo_page_kas_masuk.Location = New System.Drawing.Point(288, 15)
        Me.combo_page_kas_masuk.Name = "combo_page_kas_masuk"
        Me.combo_page_kas_masuk.Size = New System.Drawing.Size(51, 21)
        Me.combo_page_kas_masuk.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(243, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Page"
        '
        'text_total_page_kas_masuk
        '
        Me.text_total_page_kas_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page_kas_masuk.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page_kas_masuk.Location = New System.Drawing.Point(192, 15)
        Me.text_total_page_kas_masuk.Name = "text_total_page_kas_masuk"
        Me.text_total_page_kas_masuk.Size = New System.Drawing.Size(45, 20)
        Me.text_total_page_kas_masuk.TabIndex = 40
        '
        'text_total_data_kas_masuk
        '
        Me.text_total_data_kas_masuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data_kas_masuk.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data_kas_masuk.Location = New System.Drawing.Point(63, 13)
        Me.text_total_data_kas_masuk.Name = "text_total_data_kas_masuk"
        Me.text_total_data_kas_masuk.Size = New System.Drawing.Size(55, 20)
        Me.text_total_data_kas_masuk.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(0, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Total Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(124, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Total  Page"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(6, 349)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(480, 22)
        Me.TextBox2.TabIndex = 91
        Me.TextBox2.Text = "HISTORI KAS MASUK"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGView_kas_masuk
        '
        Me.DGView_kas_masuk.AllowUserToAddRows = False
        Me.DGView_kas_masuk.AllowUserToDeleteRows = False
        Me.DGView_kas_masuk.AllowUserToResizeRows = False
        Me.DGView_kas_masuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView_kas_masuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DGView_kas_masuk.Location = New System.Drawing.Point(6, 370)
        Me.DGView_kas_masuk.Name = "DGView_kas_masuk"
        Me.DGView_kas_masuk.ReadOnly = True
        Me.DGView_kas_masuk.Size = New System.Drawing.Size(479, 265)
        Me.DGView_kas_masuk.TabIndex = 90
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "jumlah_kas_masuk_atau_keluar"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Jumlah"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 160
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "full_date"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tgl"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 130
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "mark"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Mark"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 140
        '
        'tombol_print_preview_kas
        '
        Me.tombol_print_preview_kas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print_preview_kas.Image = Global.JStockInventory2.My.Resources.Resources.iconc_print_preview
        Me.tombol_print_preview_kas.Location = New System.Drawing.Point(909, 10)
        Me.tombol_print_preview_kas.Name = "tombol_print_preview_kas"
        Me.tombol_print_preview_kas.Size = New System.Drawing.Size(103, 96)
        Me.tombol_print_preview_kas.TabIndex = 89
        Me.tombol_print_preview_kas.UseVisualStyleBackColor = True
        '
        'tombol_print_kas
        '
        Me.tombol_print_kas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print_kas.Image = Global.JStockInventory2.My.Resources.Resources.iconc_printf
        Me.tombol_print_kas.Location = New System.Drawing.Point(1028, 10)
        Me.tombol_print_kas.Name = "tombol_print_kas"
        Me.tombol_print_kas.Size = New System.Drawing.Size(101, 96)
        Me.tombol_print_kas.TabIndex = 88
        Me.tombol_print_kas.UseVisualStyleBackColor = True
        '
        'tombol_csv_kas
        '
        Me.tombol_csv_kas.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv_kas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_csv_kas.Location = New System.Drawing.Point(783, 10)
        Me.tombol_csv_kas.Name = "tombol_csv_kas"
        Me.tombol_csv_kas.Size = New System.Drawing.Size(101, 96)
        Me.tombol_csv_kas.TabIndex = 87
        Me.tombol_csv_kas.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.dtanggal_hingga)
        Me.GroupBox5.Controls.Add(Me.dtanggal_dari)
        Me.GroupBox5.Controls.Add(Me.tombol_cari)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox5.Location = New System.Drawing.Point(507, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(270, 100)
        Me.GroupBox5.TabIndex = 67
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tampilkan Berdasarkan Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Hingga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Dari"
        '
        'dtanggal_hingga
        '
        Me.dtanggal_hingga.AllowDrop = True
        Me.dtanggal_hingga.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dtanggal_hingga.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtanggal_hingga.CustomFormat = "dd/MM/yyyy"
        Me.dtanggal_hingga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtanggal_hingga.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtanggal_hingga.Location = New System.Drawing.Point(139, 45)
        Me.dtanggal_hingga.Name = "dtanggal_hingga"
        Me.dtanggal_hingga.Size = New System.Drawing.Size(114, 21)
        Me.dtanggal_hingga.TabIndex = 73
        '
        'dtanggal_dari
        '
        Me.dtanggal_dari.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtanggal_dari.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dtanggal_dari.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtanggal_dari.CustomFormat = "dd/MM/yyyy"
        Me.dtanggal_dari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtanggal_dari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtanggal_dari.Location = New System.Drawing.Point(139, 18)
        Me.dtanggal_dari.Name = "dtanggal_dari"
        Me.dtanggal_dari.Size = New System.Drawing.Size(114, 21)
        Me.dtanggal_dari.TabIndex = 72
        '
        'tombol_cari
        '
        Me.tombol_cari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tombol_cari.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tombol_cari.Image = Global.JStockInventory2.My.Resources.Resources.icon_cari_data
        Me.tombol_cari.Location = New System.Drawing.Point(175, 71)
        Me.tombol_cari.Name = "tombol_cari"
        Me.tombol_cari.Size = New System.Drawing.Size(78, 23)
        Me.tombol_cari.TabIndex = 20
        Me.tombol_cari.UseVisualStyleBackColor = True
        '
        'text_jumlah_kas
        '
        Me.text_jumlah_kas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.text_jumlah_kas.Enabled = False
        Me.text_jumlah_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_jumlah_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_jumlah_kas.Location = New System.Drawing.Point(159, 15)
        Me.text_jumlah_kas.Name = "text_jumlah_kas"
        Me.text_jumlah_kas.Size = New System.Drawing.Size(216, 21)
        Me.text_jumlah_kas.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 15)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Jumlah Kas Sekarang"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combo_page_histori_kas)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.text_total_page_histori_kas)
        Me.GroupBox3.Controls.Add(Me.text_total_data_histori_kas)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(146, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 41)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        '
        'combo_page_histori_kas
        '
        Me.combo_page_histori_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page_histori_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page_histori_kas.FormattingEnabled = True
        Me.combo_page_histori_kas.Location = New System.Drawing.Point(288, 15)
        Me.combo_page_histori_kas.Name = "combo_page_histori_kas"
        Me.combo_page_histori_kas.Size = New System.Drawing.Size(51, 21)
        Me.combo_page_histori_kas.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(243, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Page"
        '
        'text_total_page_histori_kas
        '
        Me.text_total_page_histori_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page_histori_kas.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page_histori_kas.Location = New System.Drawing.Point(192, 15)
        Me.text_total_page_histori_kas.Name = "text_total_page_histori_kas"
        Me.text_total_page_histori_kas.Size = New System.Drawing.Size(45, 20)
        Me.text_total_page_histori_kas.TabIndex = 40
        '
        'text_total_data_histori_kas
        '
        Me.text_total_data_histori_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data_histori_kas.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data_histori_kas.Location = New System.Drawing.Point(63, 13)
        Me.text_total_data_histori_kas.Name = "text_total_data_histori_kas"
        Me.text_total_data_histori_kas.Size = New System.Drawing.Size(55, 20)
        Me.text_total_data_histori_kas.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(0, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Total Data"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(124, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total  Page"
        '
        'tombol_home_histori_perubahan_kas
        '
        Me.tombol_home_histori_perubahan_kas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home_histori_perubahan_kas.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home_histori_perubahan_kas.Location = New System.Drawing.Point(97, 48)
        Me.tombol_home_histori_perubahan_kas.Name = "tombol_home_histori_perubahan_kas"
        Me.tombol_home_histori_perubahan_kas.Size = New System.Drawing.Size(43, 39)
        Me.tombol_home_histori_perubahan_kas.TabIndex = 82
        Me.tombol_home_histori_perubahan_kas.UseVisualStyleBackColor = True
        '
        'button_next_histori_perubahan_kas
        '
        Me.button_next_histori_perubahan_kas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next_histori_perubahan_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next_histori_perubahan_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next_histori_perubahan_kas.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next_histori_perubahan_kas.Location = New System.Drawing.Point(52, 48)
        Me.button_next_histori_perubahan_kas.Name = "button_next_histori_perubahan_kas"
        Me.button_next_histori_perubahan_kas.Size = New System.Drawing.Size(39, 39)
        Me.button_next_histori_perubahan_kas.TabIndex = 81
        Me.button_next_histori_perubahan_kas.UseVisualStyleBackColor = True
        '
        'button_prev_histori_perubahan_kas
        '
        Me.button_prev_histori_perubahan_kas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev_histori_perubahan_kas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev_histori_perubahan_kas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev_histori_perubahan_kas.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev_histori_perubahan_kas.Location = New System.Drawing.Point(9, 47)
        Me.button_prev_histori_perubahan_kas.Name = "button_prev_histori_perubahan_kas"
        Me.button_prev_histori_perubahan_kas.Size = New System.Drawing.Size(37, 40)
        Me.button_prev_histori_perubahan_kas.TabIndex = 80
        Me.button_prev_histori_perubahan_kas.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(9, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(477, 22)
        Me.TextBox1.TabIndex = 79
        Me.TextBox1.Text = "HISTORI PERUBAHAN DATA KAS"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGView_histori_perubahan_data_kas
        '
        Me.DGView_histori_perubahan_data_kas.AllowUserToAddRows = False
        Me.DGView_histori_perubahan_data_kas.AllowUserToDeleteRows = False
        Me.DGView_histori_perubahan_data_kas.AllowUserToResizeRows = False
        Me.DGView_histori_perubahan_data_kas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView_histori_perubahan_data_kas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jumlah_kas, Me.full_date, Me.mark})
        Me.DGView_histori_perubahan_data_kas.Location = New System.Drawing.Point(9, 110)
        Me.DGView_histori_perubahan_data_kas.Name = "DGView_histori_perubahan_data_kas"
        Me.DGView_histori_perubahan_data_kas.ReadOnly = True
        Me.DGView_histori_perubahan_data_kas.Size = New System.Drawing.Size(476, 191)
        Me.DGView_histori_perubahan_data_kas.TabIndex = 3
        '
        'jumlah_kas
        '
        Me.jumlah_kas.DataPropertyName = "jumlah_kas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.jumlah_kas.DefaultCellStyle = DataGridViewCellStyle3
        Me.jumlah_kas.HeaderText = "Jumlah Kas"
        Me.jumlah_kas.Name = "jumlah_kas"
        Me.jumlah_kas.ReadOnly = True
        Me.jumlah_kas.Width = 160
        '
        'full_date
        '
        Me.full_date.DataPropertyName = "full_date"
        Me.full_date.HeaderText = "Tgl"
        Me.full_date.Name = "full_date"
        Me.full_date.ReadOnly = True
        Me.full_date.Width = 130
        '
        'mark
        '
        Me.mark.DataPropertyName = "mark"
        Me.mark.HeaderText = "Mark"
        Me.mark.Name = "mark"
        Me.mark.ReadOnly = True
        Me.mark.Width = 140
        '
        'selisih
        '
        Me.selisih.HeaderText = "Selisih"
        Me.selisih.Name = "selisih"
        Me.selisih.Width = 120
        '
        'laporan_keuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 679)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "laporan_keuangan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Keuangan"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_laba_rugi.ResumeLayout(False)
        Me.tab_laba_rugi.PerformLayout()
        CType(Me.DGView_pembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGView_penjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGView_laba_rugi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_laporan_kas.ResumeLayout(False)
        Me.tab_laporan_kas.PerformLayout()
        CType(Me.DGView_kas_keluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.kotak_data_kas.ResumeLayout(False)
        Me.kotak_data_kas.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGView_kas_masuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGView_histori_perubahan_data_kas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_laba_rugi As TabPage
    Friend WithEvents DGView_laba_rugi As DataGridView
    Friend WithEvents button_prev_data_penjualan As Button
    Friend WithEvents button_next_data_penjualan As Button
    Friend WithEvents button_home_data_penjualan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents combo_page_data_penjualan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents text_total_page_data_penjualan As TextBox
    Friend WithEvents text_total_data_penjualan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tombol_csv_laba_rugi As Button
    Friend WithEvents tombol_print_laba_rugi As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker_hingga As DateTimePicker
    Friend WithEvents DateTimePicker_dari As DateTimePicker
    Friend WithEvents button_go As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents combo_page_data_pembelian As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents text_total_page_data_pembelian As TextBox
    Friend WithEvents text_total_data_pembelian As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents button_home_data_pembelian As Button
    Friend WithEvents button_next_data_pembelian As Button
    Friend WithEvents button_prev_data_pembelian As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents DGView_penjualan As DataGridView
    Friend WithEvents DGView_pembelian As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents full_date_pembelian As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal2 As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_pembelian As DataGridViewTextBoxColumn
    Friend WithEvents bulan_pembelian As DataGridViewTextBoxColumn
    Friend WithEvents tahun_pembelian As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents full_date_penjualan As DataGridViewTextBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents nama_produk As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_penjualan As DataGridViewTextBoxColumn
    Friend WithEvents bulan_penjualan As DataGridViewTextBoxColumn
    Friend WithEvents tahun_penjualan As DataGridViewTextBoxColumn

    Friend WithEvents selisih As DataGridViewTextBoxColumn
    Friend WithEvents dg_total_nilai_penjualan As DataGridViewTextBoxColumn
    Friend WithEvents dg_total_nilai_pembelian As DataGridViewTextBoxColumn
    Friend WithEvents dg_selisih As DataGridViewTextBoxColumn
    Friend WithEvents tombol_print_preview_laba_rugi As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents jum_print As TextBox
    Friend WithEvents tab_laporan_kas As TabPage
    Friend WithEvents DGView_histori_perubahan_data_kas As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents button_prev_histori_perubahan_kas As Button
    Friend WithEvents button_next_histori_perubahan_kas As Button
    Friend WithEvents tombol_home_histori_perubahan_kas As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_page_histori_kas As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page_histori_kas As TextBox
    Friend WithEvents text_total_data_histori_kas As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents text_jumlah_kas As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtanggal_hingga As DateTimePicker
    Friend WithEvents dtanggal_dari As DateTimePicker
    Friend WithEvents tombol_cari As Button
    Friend WithEvents tombol_csv_kas As Button
    Friend WithEvents tombol_print_kas As Button
    Friend WithEvents tombol_print_preview_kas As Button
    Friend WithEvents tombol_home_kas_masuk As Button
    Friend WithEvents button_next_kas_masuk As Button
    Friend WithEvents button_prev_kas_masuk As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents combo_page_kas_masuk As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents text_total_page_kas_masuk As TextBox
    Friend WithEvents text_total_data_kas_masuk As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DGView_kas_masuk As DataGridView
    Friend WithEvents kotak_data_kas As GroupBox
    Friend WithEvents text_status_kas As TextBox
    Friend WithEvents text_selisih_kas As TextBox
    Friend WithEvents text_jumlah_total_kas_keluar As TextBox
    Friend WithEvents text_jumlah_total_kas_masuk As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents DGView_kas_keluar As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents combo_page_kas_keluar As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents text_total_page_kas_keluar As TextBox
    Friend WithEvents text_total_data_kas_keluar As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents tombol_home_kas_keluar As Button
    Friend WithEvents button_next_kas_keluar As Button
    Friend WithEvents button_prev_kas_keluar As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents jum_print_kas As TextBox
    Friend WithEvents jumlah_kas As DataGridViewTextBoxColumn
    Friend WithEvents full_date As DataGridViewTextBoxColumn
    Friend WithEvents mark As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
End Class
