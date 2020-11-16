<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangJstockInventoryVersi2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurasiDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanFiturProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataKategoriProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataMerekProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataGudangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataKasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenyesuaianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.StokToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1137, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangJstockInventoryVersi2ToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'TentangJstockInventoryVersi2ToolStripMenuItem
        '
        Me.TentangJstockInventoryVersi2ToolStripMenuItem.Name = "TentangJstockInventoryVersi2ToolStripMenuItem"
        Me.TentangJstockInventoryVersi2ToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.TentangJstockInventoryVersi2ToolStripMenuItem.Text = "Tentang JstockInventory Versi 2"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KonfigurasiDatabaseToolStripMenuItem, Me.PengaturanFiturProgramToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PengaturanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PengaturanToolStripMenuItem.Text = "&Pengaturan"
        '
        'KonfigurasiDatabaseToolStripMenuItem
        '
        Me.KonfigurasiDatabaseToolStripMenuItem.Name = "KonfigurasiDatabaseToolStripMenuItem"
        Me.KonfigurasiDatabaseToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.KonfigurasiDatabaseToolStripMenuItem.Text = "Konfigurasi Database"
        '
        'PengaturanFiturProgramToolStripMenuItem
        '
        Me.PengaturanFiturProgramToolStripMenuItem.Name = "PengaturanFiturProgramToolStripMenuItem"
        Me.PengaturanFiturProgramToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.PengaturanFiturProgramToolStripMenuItem.Text = "Pengaturan Konfigurasi Aplikasi"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MasterDataKategoriProdukToolStripMenuItem, Me.MasterDataMerekProdukToolStripMenuItem, Me.MasterDataCustomerToolStripMenuItem, Me.MasterDataSupplierToolStripMenuItem, Me.MasterDataGudangToolStripMenuItem, Me.MasterDataUserToolStripMenuItem, Me.MasterDataKasToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.MasterDataToolStripMenuItem.Text = "&Master Data"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(226, 22)
        Me.ToolStripMenuItem1.Text = "Master Data Perusahaan"
        '
        'MasterDataKategoriProdukToolStripMenuItem
        '
        Me.MasterDataKategoriProdukToolStripMenuItem.Name = "MasterDataKategoriProdukToolStripMenuItem"
        Me.MasterDataKategoriProdukToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MasterDataKategoriProdukToolStripMenuItem.Text = "Master Data Kategori Produk"
        '
        'MasterDataMerekProdukToolStripMenuItem
        '
        Me.MasterDataMerekProdukToolStripMenuItem.Name = "MasterDataMerekProdukToolStripMenuItem"
        Me.MasterDataMerekProdukToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MasterDataMerekProdukToolStripMenuItem.Text = "Master Data Merek Produk"
        '
        'MasterDataCustomerToolStripMenuItem
        '
        Me.MasterDataCustomerToolStripMenuItem.Name = "MasterDataCustomerToolStripMenuItem"
        Me.MasterDataCustomerToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MasterDataCustomerToolStripMenuItem.Text = "Master Data Customer"
        '
        'MasterDataSupplierToolStripMenuItem
        '
        Me.MasterDataSupplierToolStripMenuItem.Name = "MasterDataSupplierToolStripMenuItem"
        Me.MasterDataSupplierToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MasterDataSupplierToolStripMenuItem.Text = "Master Data Supplier"
        '
        'MasterDataGudangToolStripMenuItem
        '
        Me.MasterDataGudangToolStripMenuItem.Name = "MasterDataGudangToolStripMenuItem"
        Me.MasterDataGudangToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MasterDataGudangToolStripMenuItem.Text = "Master Data Gudang"
        '
        'MasterDataUserToolStripMenuItem
        '
        Me.MasterDataUserToolStripMenuItem.Name = "MasterDataUserToolStripMenuItem"
        Me.MasterDataUserToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MasterDataUserToolStripMenuItem.Text = "Master Data User"
        '
        'MasterDataKasToolStripMenuItem
        '
        Me.MasterDataKasToolStripMenuItem.Name = "MasterDataKasToolStripMenuItem"
        Me.MasterDataKasToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MasterDataKasToolStripMenuItem.Text = "Master Data Kas"
        '
        'StokToolStripMenuItem
        '
        Me.StokToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.DataStokToolStripMenuItem, Me.PenyesuaianToolStripMenuItem})
        Me.StokToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StokToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.StokToolStripMenuItem.Name = "StokToolStripMenuItem"
        Me.StokToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StokToolStripMenuItem.Text = "&Stok"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'DataStokToolStripMenuItem
        '
        Me.DataStokToolStripMenuItem.Name = "DataStokToolStripMenuItem"
        Me.DataStokToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DataStokToolStripMenuItem.Text = "Data Stok"
        '
        'PenyesuaianToolStripMenuItem
        '
        Me.PenyesuaianToolStripMenuItem.Name = "PenyesuaianToolStripMenuItem"
        Me.PenyesuaianToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PenyesuaianToolStripMenuItem.Text = "Penyesuaian Stok"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPembelianToolStripMenuItem, Me.LaporanPenjualanToolStripMenuItem, Me.LaporanStokToolStripMenuItem, Me.LaporanToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanStokToolStripMenuItem
        '
        Me.LaporanStokToolStripMenuItem.Name = "LaporanStokToolStripMenuItem"
        Me.LaporanStokToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LaporanStokToolStripMenuItem.Text = "Laporan Stok"
        '
        'LaporanToolStripMenuItem1
        '
        Me.LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        Me.LaporanToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.LaporanToolStripMenuItem1.Text = "Laporan Keuangan"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.tombol6
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Location = New System.Drawing.Point(346, 50)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(78, 87)
        Me.Button6.TabIndex = 6
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.tombol4
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(42, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 87)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.tombol2
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(141, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 87)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.tombol1
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(241, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 87)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'form_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.main21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1137, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " .::JstockInventory Version 2 - by www.jasaplus.com- Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangJstockInventoryVersi2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataKategoriProdukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataMerekProdukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonfigurasiDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataGudangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PenyesuaianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanFiturProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataKasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
