Imports MySql.Data.MySqlClient

Public Class form_csv
    Public Property sql_to_exec As String

    Public Property second_sql_to_exec As String

    Public Property nama_tabel As String
    Public Property additional_mark As String
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public Property con_mysql As New MySqlConnection
    Public Property cmd_mysql As New MySqlCommand


    'special property for laba rugi
    Public Property last_sql_for_csv_pembelian As String
    Public Property last_sql_for_csv_penjualan As String
    Public Property total_nilai_penjualan As String
    Public Property total_nilai_pembelian As String
    Public Property total_selisih_nilai_pembelian_dan_penjualan As String

    'special property for alur kas
    Public Property last_sql_for_csv_histori_kas As String
    Public Property last_sql_for_csv_histori_kas_masuk As String
    Public Property last_sql_for_csv_histori_kas_keluar As String
    Public Property jumlah_kas_sekarang As String
    Public Property jumlah_total_kas_masuk As String
    Public Property jumlah_total_kas_keluar As String
    Public Property jumlah_total_selisih_kas_masuk_dan_keluar As String
    Public Property status_selisih_kas_masuk_dan_keluar As String

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Dim folderDlg As New FolderBrowserDialog
            folderDlg.ShowNewFolderButton = True
            If (folderDlg.ShowDialog() = DialogResult.OK) Then
                path_csv.Text = folderDlg.SelectedPath
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub tombol_csv_Click(sender As Object, e As EventArgs) Handles tombol_csv.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(path_csv.Text) < 1 Then
                MsgBox("klik browse terlebih dahulu untuk memilih folder tempat ekspor")
            Else
                If Len(Me.additional_mark) > 0 Then
                    If Me.additional_mark = "pembelian" Then
                        Call create_csv_pembelian()
                    ElseIf Me.additional_mark = "penjualan" Then
                        Call create_csv_penjualan()
                    End If
                Else
                    If Me.nama_tabel = "op_stok_adjustment" Then
                        Call create_csv_op_stok_adjustment()
                    ElseIf Me.nama_tabel = "master_currency" Then
                        Call create_csv_master_currency()
                    ElseIf Me.nama_tabel = "master_customer" Then
                        Call create_csv_master_customer()
                    ElseIf Me.nama_tabel = "master_gudang" Then
                        Call create_csv_master_gudang()
                    ElseIf Me.nama_tabel = "master_kategori_produk" Then
                        Call create_csv_master_kategori_produk()
                    ElseIf Me.nama_tabel = "master_merek" Then
                        Call create_csv_master_merek()
                    ElseIf Me.nama_tabel = "master_supplier" Then
                        Call create_csv_master_supplier()
                    ElseIf Me.nama_tabel = "op_stok" Then
                        Call create_csv_op_stok()
                    ElseIf Me.nama_tabel = "op_stok_keluar" Then
                        Call create_csv_op_stok_keluar()
                    ElseIf Me.nama_tabel = "op_stok_masuk" Then
                        Call create_csv_op_stok_masuk()
                    ElseIf Me.nama_tabel = "laba_rugi" Then
                        Call create_csv_laba_rugi()
                    ElseIf Me.nama_tabel = "kas" Then
                        Call create_csv_alur_kas()
                    Else
                        MsgBox("tidak bisa membuat csv !")
                    End If
                End If
            End If
            MsgBox("data berhasil diekspor ke csv")
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Me.nama_tabel = ""
    End Sub

    Public Sub create_csv_op_stok_adjustment()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "SELECT full_date,no_adjustment,kode,nama_barang,qty_fisik,qty_adjustment,gudang,jenis_adjustment,keterangan FROM op_stok_adjustment  order by `id` desc limit 0,500"
            Dim header_str = "Tanggal, No Adjustment, Kode Barang, Nama Barang, Jumlah Fisik,  Jumlah Penyesuaian, Gudang, Jenis Adjustment, Keterangan"
            Dim array_num() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8}
            Dim path = path_csv.Text & "\stock_adjustment.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_master_currency()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "select currency, to_rp, abbrv,last_update from `master_currency` order by `id` desc limit 0, 500"
            Dim header_str = "Currency, Nilai Dalam Rupiah, Abbrv, Last Update"
            Dim array_num() As Integer = {0, 1, 2, 3}
            Dim path = path_csv.Text & "\master_currency.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_master_customer()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "select nama, telpon, alamat, hp, email from `master_customer` order by `id` desc limit 0, 500"
            Dim header_str = "Nama, Telpon, Alamat, HP, Email"
            Dim array_num() As Integer = {0, 1, 2, 3, 4}
            Dim path = path_csv.Text & "\master_customer.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
        End Try

    End Sub

    Public Sub create_csv_master_gudang()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "select nama_gudang, lokasi_gudang, jumlah_total from `master_gudang` order by `id` desc limit 0, 500"
            Dim header_str = "Nama Gudang,Lokasi Gudang, Jumlah Total"
            Dim array_num() As Integer = {0, 1, 2}
            Dim path = path_csv.Text & "\master_gudang.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Sub create_csv_master_kategori_produk()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "select nama_kategori, keterangan, jumlah_total from `master_kategori_produk` order by `id` desc limit 0, 500"
            Dim header_str = "Nama Kategori, Keterangan, Jumlah Total"
            Dim array_num() As Integer = {0, 1, 2}
            Dim path = path_csv.Text & "\master_kategori_produk.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Sub create_csv_master_merek()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "select merek, ket, jumlah_total from `master_merek` order by `id` desc limit 0, 500"
            Dim header_str = "Merek, Keterangan, Jumlah Total"
            Dim array_num() As Integer = {0, 1, 2}
            Dim path = path_csv.Text & "\master_merek.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_master_supplier()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "select nama_perusahaan, alamat, contact_person, email, telp, fax,hp from `master_supplier` order by `id` desc limit 0, 500"
            Dim header_str = "Nama Perusahaan, Alamat, Contact Person, Email, Telp, Fax, Hp"
            Dim array_num() As Integer = {0, 1, 2, 3, 4, 5, 6}
            Dim path = path_csv.Text & "\master_supplier.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_op_stok()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql = "select kode,nama_produk,gambar, harga,stok from `op_stok` order by `id` desc limit 0, 500"
            Dim header_str = "Kode, Nama Produk, Gambar, Harga"
            Dim array_num() As Integer = {0, 1, 2, 3, 4}
            Dim path = path_csv.Text & "\op_stok.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_op_stok_keluar()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql As String
            sql = ""
            If Len(Me.sql_to_exec) < 1 Then
                sql = "select full_date,kode,nama_produk, harga, jumlah, waktu from `op_stok_keluar`  order by `id` desc limit 0, 500"
            Else
                sql = sql_to_exec
                Me.sql_to_exec = ""
            End If

            Dim header_str = "Tanggal, Kode, Nama Produk, Harga,Jumlah, Waktu"
            Dim array_num() As Integer = {0, 1, 2, 3, 4, 5}
            Dim path = path_csv.Text & "\op_stok_keluar.csv"
            data_obj.create_csv_data(path, Sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Sub create_csv_op_stok_masuk()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql As String
            sql = ""
            If Len(Me.sql_to_exec) < 1 Then
                sql = "select full_date,kode,nama_produk, harga, jumlah, waktu from `op_stok_masuk`  order by `id` desc limit 0, 500"
            Else
                sql = sql_to_exec
                Me.sql_to_exec = ""
            End If

            Dim header_str = "Tanggal, Kode, Nama Produk, Harga,Jumlah, Waktu"
            Dim array_num() As Integer = {0, 1, 2, 3, 4, 5}
            Dim path = path_csv.Text & "\op_stok_masuk.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_pembelian()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql As String
            sql = ""
            If Len(Me.sql_to_exec) < 1 Then
                sql = "select full_date,kode,nama_produk, harga, jumlah, waktu from `op_stok_masuk` where `mark` = 'pembelian' order by `id` desc limit 0, 500"
            Else
                sql = sql_to_exec
                Me.sql_to_exec = ""
            End If

            Dim header_str = "Tanggal, Kode, Nama Produk, Harga,Jumlah, Waktu"
            Dim array_num() As Integer = {0, 1, 2, 3, 4, 5}
            Dim path = path_csv.Text & "\pembelian.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub create_csv_penjualan()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql As String
            sql = ""
            If Len(Me.sql_to_exec) < 1 Then
                sql = "select full_date,kode,nama_produk, harga, jumlah, waktu from `op_stok_keluar` where `mark` = 'penjualan' order by `id` desc limit 0, 500"
            Else
                sql = sql_to_exec
                Me.sql_to_exec = ""
            End If

            Dim header_str = "Tanggal, Kode, Nama Produk, Harga,Jumlah, Waktu"
            Dim array_num() As Integer = {0, 1, 2, 3, 4, 5}
            Dim path = path_csv.Text & "\penjualan.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Sub create_csv_laba_rugi()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            dump_data_laba_rugi()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_alur_kas()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            dump_data_alur_kas()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub dump_data_alur_kas()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql As String
            Dim path As String
            Dim header_str As String
            Dim array_num() As Integer = {0, 1, 2}
            Dim last_sql As String
            Dim last_sql_alternate As String

            'Console.WriteLine("last_sql_for_csv_histori_kas:" + last_sql_for_csv_histori_kas)
            'Console.WriteLine("last_sql_for_csv_histori_kas_masuk:" + last_sql_for_csv_histori_kas_masuk)
            'Console.WriteLine("last_sql_for_csv_histori_kas_keluar:" + last_sql_for_csv_histori_kas_keluar)

            'Console.WriteLine("jumlah_kas_sekarang:" + jumlah_kas_sekarang)
            'Console.WriteLine("jumlah_total_kas_masuk:" + jumlah_total_kas_masuk)
            'Console.WriteLine("jumlah_total_kas_keluar:" + jumlah_total_kas_keluar)
            'Console.WriteLine("jumlah_total_selisih_kas_masuk_dan_keluar:" + jumlah_total_selisih_kas_masuk_dan_keluar)
            'Console.WriteLine("status_selisih_kas_masuk_dan_keluar:" + status_selisih_kas_masuk_dan_keluar)

            'histori kas
            path = path_csv.Text & "\laporan_histori_kas.csv"
            last_sql = last_sql_for_csv_histori_kas
            last_sql_alternate = "SELECT jumlah_kas,full_date, mark FROM  op_histori_kas order by `id` desc limit 0,500"
            header_str = "Jumlah Kas, Tanggal, Mark"
            generic_prepare_csv_for_sql(path, last_sql, last_sql_alternate, header_str, array_num)
            last_sql_for_csv_histori_kas = ""
            last_sql = ""

            'kas masuk
            path = path_csv.Text & "\laporan_kas_masuk.csv"
            last_sql = last_sql_for_csv_histori_kas_masuk
            last_sql_alternate = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pemasukan') order by `id` desc limit 0, 500"
            header_str = "Jumlah Kas Masuk, Tanggal, Mark"
            generic_prepare_csv_for_sql(path, last_sql, last_sql_alternate, header_str, array_num)
            last_sql_for_csv_histori_kas_masuk = ""
            last_sql = ""

            'kas keluar
            path = path_csv.Text & "\laporan_kas_keluar.csv"
            last_sql = last_sql_for_csv_histori_kas_keluar
            last_sql_alternate = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pengeluaran') order by `id` desc limit 0, 500"
            header_str = "Jumlah Kas Keluar, Tanggal, Mark"
            generic_prepare_csv_for_sql(path, last_sql, last_sql_alternate, header_str, array_num)
            last_sql_for_csv_histori_kas_keluar = ""
            last_sql = ""

            path = path_csv.Text & "\statistik_kas.csv"
            Dim array_str(4) As String
            array_str(0) = data_obj.format_num(jumlah_kas_sekarang)
            array_str(1) = data_obj.format_num(jumlah_total_kas_masuk)
            array_str(2) = data_obj.format_num(jumlah_total_kas_keluar)
            array_str(3) = data_obj.format_num(jumlah_total_selisih_kas_masuk_dan_keluar)
            array_str(4) = status_selisih_kas_masuk_dan_keluar
            header_str = "Jumlah Kas Sekarang, Jumlah Kas Masuk, Jumlah Kas Keluar, Selisih Kas Masuk dan Keluar, Status"
            data_obj.create_csv_data_from_array_str(path, array_str, header_str)


        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub generic_prepare_csv_for_sql(ByVal path As String, ByVal last_sql As String, ByVal last_sql_alternate As String, ByVal header_str As String, ByRef array_num() As Integer)
        Dim sql As String
        'histori kas
        sql = ""
        If Len(last_sql) < 1 Then
            sql = last_sql_alternate
        Else
            sql = last_sql
        End If
        data_obj.create_csv_data(path, sql, array_num, header_str)
        'eof histori kas
    End Sub
    Public Sub dump_data_laba_rugi()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim header_str As String
            Dim sql As String
            Dim array_num() As Integer = {0, 1, 2, 3, 4, 5}
            'Console.WriteLine("last_sql_for_csv_pembelian:" + last_sql_for_csv_pembelian)
            'Console.WriteLine("last_sql_for_csv_penjualan:" + last_sql_for_csv_penjualan)
            'Console.WriteLine("total_nilai_penjualan:" + total_nilai_penjualan)
            'Console.WriteLine("total_nilai_pembelian:" + total_nilai_pembelian)
            'Console.WriteLine("total_selisih_nilai_pembelian_dan_penjualan:" + total_selisih_nilai_pembelian_dan_penjualan)

            Dim path = path_csv.Text & "\laporan_pembelian_penjualan.csv"
            Dim array_str(2) As String
            Console.WriteLine("got dump var : " + total_nilai_penjualan)
            Console.WriteLine("after format got : " + data_obj.format_num(total_nilai_penjualan))
            array_str(0) = data_obj.format_num(total_nilai_penjualan)
            array_str(1) = data_obj.format_num(total_nilai_pembelian)
            array_str(2) = data_obj.format_num(total_selisih_nilai_pembelian_dan_penjualan)
            header_str = "Total Nilai Penjualan, Total Nilai Pembelian, Selisih"
            data_obj.create_csv_data_from_array_str(path, array_str, header_str)

            'pembelian
            sql = ""
            If Len(Me.last_sql_for_csv_pembelian) < 1 Then
                sql = "select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_masuk  where (`mark` = 'pembelian') order by `id` desc limit 0, 500"
            Else
                sql = last_sql_for_csv_pembelian
                Me.last_sql_for_csv_pembelian = ""
            End If

            header_str = "Tanggal, Kode, Nama Produk, Harga,Jumlah, Waktu"

            path = path_csv.Text & "\pembelian.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
            'eof pembelian

            'penjualan
            sql = ""
            If Len(Me.last_sql_for_csv_penjualan) < 1 Then
                sql = "select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_keluar  where (`mark` = 'penjualan') order by `id` desc limit 0, 500"
            Else
                sql = last_sql_for_csv_penjualan
                Me.last_sql_for_csv_penjualan = ""
            End If

            header_str = "Tanggal, Kode, Nama Produk, Harga,Jumlah, Waktu"
            path = path_csv.Text & "\penjualan.csv"
            data_obj.create_csv_data(path, sql, array_num, header_str)
            'eof penjualan

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub form_csv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        basic_op.jstock_read_config()
        If Me.nama_tabel = "kas" Then
            dump_data_alur_kas()
        ElseIf Me.nama_tabel = "laba_rugi" Then
            dump_data_laba_rugi()
        End If
    End Sub
End Class