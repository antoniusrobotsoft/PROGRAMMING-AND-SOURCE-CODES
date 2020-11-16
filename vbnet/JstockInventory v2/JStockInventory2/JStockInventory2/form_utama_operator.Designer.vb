<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_utama_operator
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_utama_operator))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangJstockInventoryVersi2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokBarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokBarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenyesuaianStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKeuanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StokToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(927, 24)
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
        'StokToolStripMenuItem
        '
        Me.StokToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StokBarangMasukToolStripMenuItem, Me.StokBarangKeluarToolStripMenuItem, Me.DataStokToolStripMenuItem, Me.PenyesuaianStokToolStripMenuItem})
        Me.StokToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StokToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.StokToolStripMenuItem.Name = "StokToolStripMenuItem"
        Me.StokToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StokToolStripMenuItem.Text = "Stok"
        '
        'StokBarangMasukToolStripMenuItem
        '
        Me.StokBarangMasukToolStripMenuItem.Name = "StokBarangMasukToolStripMenuItem"
        Me.StokBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.StokBarangMasukToolStripMenuItem.Text = "Stok Barang Masuk"
        '
        'StokBarangKeluarToolStripMenuItem
        '
        Me.StokBarangKeluarToolStripMenuItem.Name = "StokBarangKeluarToolStripMenuItem"
        Me.StokBarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.StokBarangKeluarToolStripMenuItem.Text = "Stok Barang Keluar"
        '
        'DataStokToolStripMenuItem
        '
        Me.DataStokToolStripMenuItem.Name = "DataStokToolStripMenuItem"
        Me.DataStokToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DataStokToolStripMenuItem.Text = "Data Stok"
        '
        'PenyesuaianStokToolStripMenuItem
        '
        Me.PenyesuaianStokToolStripMenuItem.Name = "PenyesuaianStokToolStripMenuItem"
        Me.PenyesuaianStokToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PenyesuaianStokToolStripMenuItem.Text = "Penyesuaian Stok"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPembelianToolStripMenuItem, Me.LaporanPenjualanToolStripMenuItem, Me.LaporanStokToolStripMenuItem, Me.LaporanKeuanganToolStripMenuItem})
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
        'LaporanKeuanganToolStripMenuItem
        '
        Me.LaporanKeuanganToolStripMenuItem.Name = "LaporanKeuanganToolStripMenuItem"
        Me.LaporanKeuanganToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LaporanKeuanganToolStripMenuItem.Text = "Laporan Keuangan"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.tombol6
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(144, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 81)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.tombol4
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(32, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 81)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'form_utama_operator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JStockInventory2.My.Resources.Resources.main2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(927, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "form_utama_operator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " .::JstockInventory Version 2 - by www.jasaplus.com - Operator"
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
    Friend WithEvents StokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokBarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokBarangKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanKeuanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PenyesuaianStokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
