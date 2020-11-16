Imports System
Imports System.Drawing
Imports System.Drawing.Bitmap
Imports System.Drawing.Image
Imports MySql.Data.MySqlClient
Imports System.Math

Public Class form_utama_operator
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public Property load_new_img = 0

    Private Sub TentangJstockInventoryVersi2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangJstockInventoryVersi2ToolStripMenuItem.Click
        form_about.Show()
        basic_op.setfokus(form_about)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End

    End Sub

    Private Sub StokBarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangMasukToolStripMenuItem.Click
        stok_masuk.Show()
        basic_op.setfokus(stok_masuk)
    End Sub

    Private Sub StokBarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangKeluarToolStripMenuItem.Click
        stok_keluar.Show()
        basic_op.setfokus(stok_keluar)
    End Sub

    Private Sub DataStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataStokToolStripMenuItem.Click
        stok.Show()
        basic_op.setfokus(stok)
    End Sub

    Private Sub form_utama_operator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            form_login.Hide()
            load_cfg_background()

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
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

    Private Sub LaporanKeuanganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanKeuanganToolStripMenuItem.Click
        laporan_keuangan.Show()
        basic_op.setfokus(laporan_keuangan)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stok.Show()
        basic_op.setfokus(stok)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        laporan.Show()
        basic_op.setfokus(laporan)
    End Sub

    Private Sub PenyesuaianStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenyesuaianStokToolStripMenuItem.Click
        stok_adjusment.Show()
        basic_op.setfokus(stok_adjusment)
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