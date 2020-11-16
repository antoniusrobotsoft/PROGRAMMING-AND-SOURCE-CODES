<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stok_adjusment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stok_adjusment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.jum_print = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tombol_print_preview = New System.Windows.Forms.Button()
        Me.grup = New System.Windows.Forms.GroupBox()
        Me.combo_page = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_total_page = New System.Windows.Forms.TextBox()
        Me.text_total_data = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_adjustment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_fisik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_adjustment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_adjustment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tombol_home = New System.Windows.Forms.Button()
        Me.button_next = New System.Windows.Forms.Button()
        Me.button_prev = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker_hingga = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_dari = New System.Windows.Forms.DateTimePicker()
        Me.tombol_cari = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.text_keterangan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.text_qty_adjustment = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_qty_fisik = New System.Windows.Forms.TextBox()
        Me.text_qty_sekarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.combo_gudang = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combo_jenis_adjustment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text_no_adjustment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_nama_produk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text_kode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tombol_simpan = New System.Windows.Forms.Button()
        Me.button_delete = New System.Windows.Forms.Button()
        Me.button_clear_data = New System.Windows.Forms.Button()
        Me.tombol_add = New System.Windows.Forms.Button()
        Me.tombol_csv = New System.Windows.Forms.Button()
        Me.tombol_print = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tombol_delete_all = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grup.SuspendLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tombol_delete_all)
        Me.GroupBox1.Controls.Add(Me.jum_print)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.tombol_print_preview)
        Me.GroupBox1.Controls.Add(Me.grup)
        Me.GroupBox1.Controls.Add(Me.DGView)
        Me.GroupBox1.Controls.Add(Me.tombol_home)
        Me.GroupBox1.Controls.Add(Me.button_next)
        Me.GroupBox1.Controls.Add(Me.button_prev)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.tombol_csv)
        Me.GroupBox1.Controls.Add(Me.tombol_print)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1275, 663)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'jum_print
        '
        Me.jum_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jum_print.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.jum_print.Location = New System.Drawing.Point(1190, 113)
        Me.jum_print.Name = "jum_print"
        Me.jum_print.Size = New System.Drawing.Size(57, 21)
        Me.jum_print.TabIndex = 96
        Me.jum_print.Text = "300"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(1065, 116)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 15)
        Me.Label24.TabIndex = 95
        Me.Label24.Text = "Jumlah data print"
        '
        'tombol_print_preview
        '
        Me.tombol_print_preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_print_preview.Image = Global.JStockInventory2.My.Resources.Resources.iconc_print_preview
        Me.tombol_print_preview.Location = New System.Drawing.Point(1028, 13)
        Me.tombol_print_preview.Name = "tombol_print_preview"
        Me.tombol_print_preview.Size = New System.Drawing.Size(103, 94)
        Me.tombol_print_preview.TabIndex = 76
        Me.tombol_print_preview.UseVisualStyleBackColor = True
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
        Me.grup.Location = New System.Drawing.Point(760, 367)
        Me.grup.Name = "grup"
        Me.grup.Size = New System.Drawing.Size(498, 41)
        Me.grup.TabIndex = 65
        Me.grup.TabStop = False
        '
        'combo_page
        '
        Me.combo_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_page.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.combo_page.FormattingEnabled = True
        Me.combo_page.Location = New System.Drawing.Point(436, 11)
        Me.combo_page.Name = "combo_page"
        Me.combo_page.Size = New System.Drawing.Size(51, 23)
        Me.combo_page.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(394, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 15)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Page"
        '
        'text_total_page
        '
        Me.text_total_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_page.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_page.Location = New System.Drawing.Point(312, 13)
        Me.text_total_page.Name = "text_total_page"
        Me.text_total_page.Size = New System.Drawing.Size(54, 21)
        Me.text_total_page.TabIndex = 40
        '
        'text_total_data
        '
        Me.text_total_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_total_data.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.text_total_data.Location = New System.Drawing.Point(100, 14)
        Me.text_total_data.Name = "text_total_data"
        Me.text_total_data.Size = New System.Drawing.Size(72, 21)
        Me.text_total_data.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(28, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 15)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Total Data"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(97, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 16)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "         "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(224, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total  Page"
        '
        'DGView
        '
        Me.DGView.AllowUserToResizeRows = False
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.no_adjustment, Me.kode, Me.nama_barang, Me.qty_fisik, Me.qty_adjustment, Me.full_tanggal, Me.jenis_adjustment, Me.gudang, Me.keterangan, Me.bulan, Me.tahun, Me.tanggal})
        Me.DGView.EnableHeadersVisualStyles = False
        Me.DGView.Location = New System.Drawing.Point(9, 414)
        Me.DGView.Name = "DGView"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGView.Size = New System.Drawing.Size(1249, 235)
        Me.DGView.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'no_adjustment
        '
        Me.no_adjustment.DataPropertyName = "no_adjustment"
        Me.no_adjustment.HeaderText = "No Adj"
        Me.no_adjustment.Name = "no_adjustment"
        Me.no_adjustment.Width = 140
        '
        'kode
        '
        Me.kode.DataPropertyName = "kode"
        Me.kode.HeaderText = "Kode Barang"
        Me.kode.Name = "kode"
        Me.kode.Width = 140
        '
        'nama_barang
        '
        Me.nama_barang.DataPropertyName = "nama_barang"
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Width = 210
        '
        'qty_fisik
        '
        Me.qty_fisik.DataPropertyName = "qty_fisik"
        Me.qty_fisik.HeaderText = "Qty Fisik"
        Me.qty_fisik.Name = "qty_fisik"
        Me.qty_fisik.Width = 85
        '
        'qty_adjustment
        '
        Me.qty_adjustment.DataPropertyName = "qty_adjustment"
        Me.qty_adjustment.HeaderText = "Qty Adj"
        Me.qty_adjustment.Name = "qty_adjustment"
        Me.qty_adjustment.Width = 70
        '
        'full_tanggal
        '
        Me.full_tanggal.HeaderText = "Tanggal"
        Me.full_tanggal.Name = "full_tanggal"
        Me.full_tanggal.Width = 120
        '
        'jenis_adjustment
        '
        Me.jenis_adjustment.DataPropertyName = "jenis_adjustment"
        Me.jenis_adjustment.HeaderText = "Jenis Adj"
        Me.jenis_adjustment.Name = "jenis_adjustment"
        Me.jenis_adjustment.Width = 140
        '
        'gudang
        '
        Me.gudang.DataPropertyName = "gudang"
        Me.gudang.HeaderText = "Gudang"
        Me.gudang.Name = "gudang"
        Me.gudang.Width = 120
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Width = 180
        '
        'bulan
        '
        Me.bulan.DataPropertyName = "bulan"
        Me.bulan.HeaderText = "Bulan"
        Me.bulan.Name = "bulan"
        Me.bulan.Visible = False
        '
        'tahun
        '
        Me.tahun.DataPropertyName = "tahun"
        Me.tahun.HeaderText = "Tahun"
        Me.tahun.Name = "tahun"
        Me.tahun.Visible = False
        '
        'tanggal
        '
        Me.tanggal.DataPropertyName = "tanggal"
        Me.tanggal.HeaderText = "Tgl"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Visible = False
        '
        'tombol_home
        '
        Me.tombol_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_home.Image = Global.JStockInventory2.My.Resources.Resources.home
        Me.tombol_home.Location = New System.Drawing.Point(128, 367)
        Me.tombol_home.Name = "tombol_home"
        Me.tombol_home.Size = New System.Drawing.Size(43, 41)
        Me.tombol_home.TabIndex = 64
        Me.tombol_home.UseVisualStyleBackColor = True
        '
        'button_next
        '
        Me.button_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_next.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_next.Image = Global.JStockInventory2.My.Resources.Resources._next
        Me.button_next.Location = New System.Drawing.Point(71, 367)
        Me.button_next.Name = "button_next"
        Me.button_next.Size = New System.Drawing.Size(41, 41)
        Me.button_next.TabIndex = 63
        Me.button_next.UseVisualStyleBackColor = True
        '
        'button_prev
        '
        Me.button_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_prev.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_prev.Image = Global.JStockInventory2.My.Resources.Resources.prev
        Me.button_prev.Location = New System.Drawing.Point(9, 367)
        Me.button_prev.Name = "button_prev"
        Me.button_prev.Size = New System.Drawing.Size(47, 41)
        Me.button_prev.TabIndex = 44
        Me.button_prev.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_hingga)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_dari)
        Me.GroupBox3.Controls.Add(Me.tombol_cari)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(1019, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 112)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cari Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(6, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Hingga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(6, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Dari"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.text_id)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.text_keterangan)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_tanggal)
        Me.GroupBox2.Controls.Add(Me.text_qty_adjustment)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.text_qty_fisik)
        Me.GroupBox2.Controls.Add(Me.text_qty_sekarang)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.combo_gudang)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.combo_jenis_adjustment)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.text_no_adjustment)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.text_nama_produk)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.text_kode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tombol_simpan)
        Me.GroupBox2.Controls.Add(Me.button_delete)
        Me.GroupBox2.Controls.Add(Me.button_clear_data)
        Me.GroupBox2.Controls.Add(Me.tombol_add)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(911, 348)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tambah atau Ubah Data Stock Adjustment"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(682, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 18)
        Me.Label23.TabIndex = 94
        Me.Label23.Text = "*"
        '
        'text_id
        '
        Me.text_id.Location = New System.Drawing.Point(318, 318)
        Me.text_id.Name = "text_id"
        Me.text_id.Size = New System.Drawing.Size(45, 22)
        Me.text_id.TabIndex = 66
        Me.text_id.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(437, 146)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(411, 15)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "isikan angka tanpa tanda minus untuk menambah qty sekarang"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(437, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(336, 15)
        Me.Label21.TabIndex = 92
        Me.Label21.Text = "isikan angka minus untuk mengurangi qty sekarang"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(668, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 18)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(304, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 18)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(284, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 18)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(6, 324)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 16)
        Me.Label18.TabIndex = 88
        Me.Label18.Text = "* = harus diisi"
        '
        'text_keterangan
        '
        Me.text_keterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_keterangan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_keterangan.Location = New System.Drawing.Point(584, 182)
        Me.text_keterangan.Multiline = True
        Me.text_keterangan.Name = "text_keterangan"
        Me.text_keterangan.Size = New System.Drawing.Size(296, 100)
        Me.text_keterangan.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(437, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 15)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Keterangan"
        '
        'DateTimePicker_tanggal
        '
        Me.DateTimePicker_tanggal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_tanggal.CalendarForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker_tanggal.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker_tanggal.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_tanggal.Location = New System.Drawing.Point(146, 63)
        Me.DateTimePicker_tanggal.MaxDate = New Date(9998, 12, 2, 0, 0, 0, 0)
        Me.DateTimePicker_tanggal.Name = "DateTimePicker_tanggal"
        Me.DateTimePicker_tanggal.Size = New System.Drawing.Size(107, 21)
        Me.DateTimePicker_tanggal.TabIndex = 85
        '
        'text_qty_adjustment
        '
        Me.text_qty_adjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_qty_adjustment.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_qty_adjustment.Location = New System.Drawing.Point(584, 99)
        Me.text_qty_adjustment.Name = "text_qty_adjustment"
        Me.text_qty_adjustment.Size = New System.Drawing.Size(78, 21)
        Me.text_qty_adjustment.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(437, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Qty Adjustment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(437, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Qty Fisik"
        '
        'text_qty_fisik
        '
        Me.text_qty_fisik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_qty_fisik.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_qty_fisik.Location = New System.Drawing.Point(584, 63)
        Me.text_qty_fisik.Name = "text_qty_fisik"
        Me.text_qty_fisik.Size = New System.Drawing.Size(92, 21)
        Me.text_qty_fisik.TabIndex = 81
        '
        'text_qty_sekarang
        '
        Me.text_qty_sekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_qty_sekarang.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_qty_sekarang.Location = New System.Drawing.Point(584, 21)
        Me.text_qty_sekarang.Name = "text_qty_sekarang"
        Me.text_qty_sekarang.Size = New System.Drawing.Size(92, 21)
        Me.text_qty_sekarang.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(437, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Qty Sekarang"
        '
        'combo_gudang
        '
        Me.combo_gudang.FormattingEnabled = True
        Me.combo_gudang.Location = New System.Drawing.Point(146, 173)
        Me.combo_gudang.Name = "combo_gudang"
        Me.combo_gudang.Size = New System.Drawing.Size(121, 24)
        Me.combo_gudang.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(13, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Gudang"
        '
        'combo_jenis_adjustment
        '
        Me.combo_jenis_adjustment.FormattingEnabled = True
        Me.combo_jenis_adjustment.Items.AddRange(New Object() {"Pilih Jenis Adjustment", "Barang Rusak", "Barang Hilang", "Alasan Lain-Lain", "Kesalahan Perhitungan"})
        Me.combo_jenis_adjustment.Location = New System.Drawing.Point(146, 218)
        Me.combo_jenis_adjustment.Name = "combo_jenis_adjustment"
        Me.combo_jenis_adjustment.Size = New System.Drawing.Size(207, 24)
        Me.combo_jenis_adjustment.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(11, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Jenis Adjustment"
        '
        'text_no_adjustment
        '
        Me.text_no_adjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_no_adjustment.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_no_adjustment.Location = New System.Drawing.Point(146, 27)
        Me.text_no_adjustment.Name = "text_no_adjustment"
        Me.text_no_adjustment.Size = New System.Drawing.Size(152, 21)
        Me.text_no_adjustment.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(13, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "No Adjustment"
        '
        'text_nama_produk
        '
        Me.text_nama_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_nama_produk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_nama_produk.Location = New System.Drawing.Point(146, 131)
        Me.text_nama_produk.Name = "text_nama_produk"
        Me.text_nama_produk.Size = New System.Drawing.Size(152, 21)
        Me.text_nama_produk.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(13, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Nama Barang"
        '
        'text_kode
        '
        Me.text_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_kode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.text_kode.Location = New System.Drawing.Point(146, 99)
        Me.text_kode.Name = "text_kode"
        Me.text_kode.Size = New System.Drawing.Size(132, 21)
        Me.text_kode.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Tanggal"
        '
        'tombol_simpan
        '
        Me.tombol_simpan.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_save
        Me.tombol_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_simpan.Location = New System.Drawing.Point(833, 287)
        Me.tombol_simpan.Name = "tombol_simpan"
        Me.tombol_simpan.Size = New System.Drawing.Size(47, 52)
        Me.tombol_simpan.TabIndex = 66
        Me.tombol_simpan.UseVisualStyleBackColor = True
        '
        'button_delete
        '
        Me.button_delete.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_delete
        Me.button_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_delete.Location = New System.Drawing.Point(741, 287)
        Me.button_delete.Name = "button_delete"
        Me.button_delete.Size = New System.Drawing.Size(52, 52)
        Me.button_delete.TabIndex = 65
        Me.button_delete.UseVisualStyleBackColor = True
        '
        'button_clear_data
        '
        Me.button_clear_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_clear_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_clear_data.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_clear_data.Image = Global.JStockInventory2.My.Resources.Resources.icon_retry
        Me.button_clear_data.Location = New System.Drawing.Point(634, 287)
        Me.button_clear_data.Name = "button_clear_data"
        Me.button_clear_data.Size = New System.Drawing.Size(53, 52)
        Me.button_clear_data.TabIndex = 64
        Me.button_clear_data.UseVisualStyleBackColor = True
        '
        'tombol_add
        '
        Me.tombol_add.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.icon_tambah_new
        Me.tombol_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tombol_add.Location = New System.Drawing.Point(542, 287)
        Me.tombol_add.Name = "tombol_add"
        Me.tombol_add.Size = New System.Drawing.Size(49, 51)
        Me.tombol_add.TabIndex = 63
        Me.tombol_add.UseVisualStyleBackColor = True
        '
        'tombol_csv
        '
        Me.tombol_csv.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.iconc_CSV
        Me.tombol_csv.Location = New System.Drawing.Point(1025, 144)
        Me.tombol_csv.Name = "tombol_csv"
        Me.tombol_csv.Size = New System.Drawing.Size(101, 94)
        Me.tombol_csv.TabIndex = 60
        Me.tombol_csv.UseVisualStyleBackColor = True
        '
        'tombol_print
        '
        Me.tombol_print.Image = Global.JStockInventory2.My.Resources.Resources.iconc_printf
        Me.tombol_print.Location = New System.Drawing.Point(1157, 13)
        Me.tombol_print.Name = "tombol_print"
        Me.tombol_print.Size = New System.Drawing.Size(101, 94)
        Me.tombol_print.TabIndex = 59
        Me.tombol_print.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(9, 247)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(459, 68)
        Me.TextBox1.TabIndex = 97
        Me.TextBox1.Text = "Perhatian ! penggunakan stock adjustment akan secara otomatis menambah maupun men" &
    "gurangi data jumlah stok suatu barang pada tabel data stok barang"
        '
        'tombol_delete_all
        '
        Me.tombol_delete_all.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.kosong
        Me.tombol_delete_all.Location = New System.Drawing.Point(1157, 144)
        Me.tombol_delete_all.Name = "tombol_delete_all"
        Me.tombol_delete_all.Size = New System.Drawing.Size(101, 96)
        Me.tombol_delete_all.TabIndex = 97
        Me.tombol_delete_all.UseVisualStyleBackColor = True
        '
        'stok_adjusment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "stok_adjusment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penyesuaian Stok"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grup.ResumeLayout(False)
        Me.grup.PerformLayout()
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGView As DataGridView
    Friend WithEvents tombol_print As Button
    Friend WithEvents tombol_csv As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tombol_add As Button
    Friend WithEvents button_clear_data As Button
    Friend WithEvents button_delete As Button
    Friend WithEvents tombol_simpan As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tombol_cari As Button
    Friend WithEvents button_prev As Button
    Friend WithEvents button_next As Button
    Friend WithEvents tombol_home As Button
    Friend WithEvents grup As GroupBox
    Friend WithEvents combo_page As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_total_page As TextBox
    Friend WithEvents text_total_data As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents text_kode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents text_nama_produk As TextBox
    Friend WithEvents text_qty_adjustment As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents text_qty_fisik As TextBox
    Friend WithEvents text_qty_sekarang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents combo_gudang As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_jenis_adjustment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents text_no_adjustment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker_tanggal As DateTimePicker
    Friend WithEvents text_keterangan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker_dari As DateTimePicker
    Friend WithEvents DateTimePicker_hingga As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents text_id As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label23 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents no_adjustment As DataGridViewTextBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents qty_fisik As DataGridViewTextBoxColumn
    Friend WithEvents qty_adjustment As DataGridViewTextBoxColumn
    Friend WithEvents full_tanggal As DataGridViewTextBoxColumn
    Friend WithEvents jenis_adjustment As DataGridViewTextBoxColumn
    Friend WithEvents gudang As DataGridViewTextBoxColumn
    Friend WithEvents keterangan As DataGridViewTextBoxColumn
    Friend WithEvents bulan As DataGridViewTextBoxColumn
    Friend WithEvents tahun As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents tombol_print_preview As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents jum_print As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tombol_delete_all As Button
End Class
