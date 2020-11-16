Imports System
Imports System.Drawing
Imports System.Drawing.Bitmap
Imports System.Drawing.Image
Imports MySql.Data.MySqlClient
Imports System.Math
Public Class form_utama
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public Property load_new_img = 0
    Private Sub form_utama_Unload()
        End
    End Sub

    Private Sub form_utama_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
    End Sub
    Private Sub form_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            form_login.Hide()
            load_cfg_background()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub TentangJstockInventoryVersi2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangJstockInventoryVersi2ToolStripMenuItem.Click
        form_about.Show()
        basic_op.setfokus(form_about)

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub MasterDataKategoriProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataKategoriProdukToolStripMenuItem.Click
        form_master_data_kategori.Show()
        basic_op.setfokus(form_master_data_kategori)
    End Sub

    Private Sub MasterDataMerekProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataMerekProdukToolStripMenuItem.Click
        form_master_data_merek.Show()
        basic_op.setfokus(form_master_data_merek)
    End Sub

    Private Sub MasterDataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataUserToolStripMenuItem.Click
        form_master_data_user.Show()
        basic_op.setfokus(form_master_data_user)
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        stok_masuk.Show()
        basic_op.setfokus(stok_masuk)
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        stok_keluar.Show()
        basic_op.setfokus(stok_keluar)
    End Sub

    Private Sub DataStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataStokToolStripMenuItem.Click
        stok.Show()
        basic_op.setfokus(stok)
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        laporan_pembelian.Show()
        basic_op.setfokus(laporan_pembelian)
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        laporan_penjualan.Show()
        basic_op.setfokus(laporan_penjualan)
    End Sub

    Private Sub LaporanStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanStokToolStripMenuItem.Click
        laporan_stok.Show()
        basic_op.setfokus(laporan_stok)
    End Sub

    Private Sub LaporanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem1.Click
        laporan_keuangan.Show()
        basic_op.setfokus(laporan_keuangan)
    End Sub



    Private Sub KonfigurasiDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonfigurasiDatabaseToolStripMenuItem.Click
        pengaturan_konfigurasi_database.Show()
        basic_op.setfokus(pengaturan_konfigurasi_database)
    End Sub

    Private Sub PengaturanFiturProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanFiturProgramToolStripMenuItem.Click
        pengaturan_fitur.Show()
        basic_op.setfokus(pengaturan_fitur)
    End Sub

    Private Sub MasterDataGudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataGudangToolStripMenuItem.Click
        form_master_data_gudang.Show()
        basic_op.setfokus(form_master_data_gudang)
    End Sub

    Private Sub MasterDataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataSupplierToolStripMenuItem.Click
        form_master_data_supplier.Show()
        basic_op.setfokus(form_master_data_supplier)
    End Sub

    Private Sub MasterDataCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataCustomerToolStripMenuItem.Click
        form_master_data_customer.Show()
        basic_op.setfokus(form_master_data_customer)
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        form_master_data_supplier.Show()
        basic_op.setfokus(form_master_data_supplier)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        stok.Show()
        basic_op.setfokus(stok)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form_master_data_customer.Show()
        basic_op.setfokus(form_master_data_customer)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        laporan.Show()
        basic_op.setfokus(laporan)
    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        form_master_data_perusahaan.Show()
        basic_op.setfokus(form_master_data_perusahaan)
    End Sub



    Private Sub PenyesuaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenyesuaianToolStripMenuItem.Click
        stok_adjusment.Show()
        basic_op.setfokus(stok_adjusment)
    End Sub

    Private Sub MasterDataKasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataKasToolStripMenuItem.Click
        form_master_data_kas.Show()
    End Sub

    Public Sub load_cfg_background()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim cfg_active_wallpaper As String
            Dim datareader_mysql_local As MySqlDataReader
            data_obj.cmd_mysql_load_single_data_from_table.Dispose()
            data_obj.con_mysql_load_single_data_from_table.Close()
            datareader_mysql_local = data_obj.load_single_data_from_table("cfg_fitur")
            If datareader_mysql_local.Read Then
                cfg_active_wallpaper = datareader_mysql_local(2).ToString().Trim()
                datareader_mysql_local.Dispose()
            End If
            ' load data
            Dim app_path As String
            app_path = basic_op.jstock_read_config()
            If Len(cfg_active_wallpaper) > 3 Then
                If (cfg_active_wallpaper.IndexOf(".jpg") > -1) Or (cfg_active_wallpaper.IndexOf(".gif") > -1) Or (cfg_active_wallpaper.IndexOf(".png") > -1) Or (cfg_active_wallpaper.IndexOf(".jpeg") > -1) Or (cfg_active_wallpaper.IndexOf(".bmp") > -1) Then
                    Dim bg = app_path + "\img\background\" + cfg_active_wallpaper
                    bg = bg.Replace("\\", "\")
                    Me.BackgroundImage = System.Drawing.Image.FromFile(bg)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.load_new_img = 1 Then
                Call load_cfg_background()
                Me.load_new_img = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
End Class