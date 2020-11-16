Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System
Imports System.Text
Imports System.IO
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Imports System.DateTime
Imports System.Globalization
Imports System.Environment

Public Class print_generator
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public Property universal_return = 1

    Function header_print()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim header_html As String
            header_html = "<html><head>" & vbCrLf &
                        "<link rel=stylesheet type=text/css href=css/jstockinventory.css>" & vbCrLf &
                        "</head><body>"
            Return header_html
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function

    Public Function footer_print()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim footer_html As String
            footer_html = "<script> " & vbCrLf &
                    "window.print()" & vbCrLf &
                    "</script></body></html>"
            Return footer_html
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function
    Public Function generate_table_header(ByVal title_laporan As String, ByRef array_header() As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim header As String

            header = "<center><h2>" + title_laporan + "</h2>" & vbCrLf &
                    "<br><table align=center colspan=0 rowspan=0><tr>"

            For Each element As String In array_header
                header = header + "<td class=title>" + element + "</td>"
            Next
            header = header + "</tr>"
            Return header
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function

    Public Sub create_dokumen_print_stok(ByVal sql As String, ByVal jumlah_maks_data As Integer, ByVal mode As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_html_str As String
            Dim line As String
            Dim datareader_mysql_datagrid As MySqlDataReader
            Dim kode As String
            Dim nama_produk As String
            Dim id_merek As String
            Dim id_kategori As String
            Dim harga As String
            Dim stok As String
            Dim id_gudang As String
            Dim merek As String
            Dim gudang As String
            Dim kategori As String
            Dim title_laporan = "Laporan Stok Barang"
            Dim array_header() As String = {"Kode", "Nama Produk", "Merek", "Kategori", "Harga", "Gudang", "Stok"}


            full_html_str = ""
            full_html_str = header_print()
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header)

            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            datareader_mysql_datagrid = data_obj.load_datareader_for_datagrid(sql)
            Dim x As Integer
            x = 0
            'Me.sql_for_print = "SELECT kode, nama_produk, id_merek, id_kategori, harga, stok, id_gudang FROM " + nama_tabel + " where (" + nama_kolom + " like '" + kunci + "' or " + nama_kolom + " like '" + kunci + "%' or " + nama_kolom + " like '%" + kunci + "' or " + nama_kolom + " like '%" + kunci + "%')"
            While datareader_mysql_datagrid.Read() And (x <= jumlah_maks_data)
                kode = datareader_mysql_datagrid(0).ToString().Trim()
                nama_produk = datareader_mysql_datagrid(1).ToString().Trim()
                id_merek = datareader_mysql_datagrid(2).ToString().Trim()
                id_kategori = datareader_mysql_datagrid(3).ToString().Trim()
                harga = datareader_mysql_datagrid(4).ToString().Trim()
                stok = datareader_mysql_datagrid(5).ToString().Trim()
                id_gudang = datareader_mysql_datagrid(6).ToString().Trim()
                merek = data_obj.get_name_from_master_by_id("merek", id_merek).ToString
                kategori = data_obj.get_name_from_master_by_id("kategori", id_kategori).ToString
                gudang = data_obj.get_name_from_master_by_id("gudang", id_gudang).ToString
                harga = data_obj.format_num(harga)
                stok = data_obj.format_num(stok)
                x = x + 1
                '{"Kode", "Nama Produk", "Merek", "Kategori", "Harga", "Gudang", "Stok"}

                line = "<tr><td class=line> &nbsp;" + kode + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + nama_produk + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + merek + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + kategori + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + harga + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + gudang + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + stok + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_mysql_datagrid.Dispose()
            full_html_str = full_html_str + "</table>"
            If mode = "print" Then
                full_html_str = full_html_str + footer_print()
            End If
            Dim app_path = basic_op.jstock_read_config()
            Dim path As String
            path = ""
            If mode = "print" Then
                path = app_path + "\print\stok_print.html"
            Else
                path = app_path + "\print\stok_preview.html"
            End If
            basic_op.create_file(path, full_html_str)

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_dokumen_print_stok_adjustment(ByVal sql As String, ByVal jumlah_maks_data As Integer, ByVal mode As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_html_str As String
            Dim line As String
            Dim datareader_mysql_datagrid As MySqlDataReader
            Dim full_date As String
            Dim no_adjustment As String
            Dim kode As String
            Dim nama_barang As String
            Dim qty_fisik As String
            Dim qty_adjustment As String
            Dim gudang As String
            Dim jenis_adjustment As String
            Dim keterangan As String
            Dim title_laporan = "Laporan Penyesuaian Stok"
            ' Me.sql_for_print = "SELECT full_date,no_adjustment,kode,nama_barang,qty_fisik,qty_adjustment,gudang,jenis_adjustment,keterangan FROM op_stok_adjustment  order by `id` desc limit " + pg_str + ",10"
            Dim array_header() As String = {"Tanggal", "No Adjustment", "Kode Barang", "Nama Barang", "Jumlah Fisik", "Jumlah Adjustment", "Gudang", "Jenis Adjustment", "Keterangan"}
            full_html_str = ""
            full_html_str = header_print()
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header)

            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            datareader_mysql_datagrid = data_obj.load_datareader_for_datagrid(sql)
            Dim x As Integer
            x = 0
            ' Me.sql_for_print = "SELECT full_date,no_adjustment,kode,nama_barang,qty_fisik,qty_adjustment,gudang,jenis_adjustment,keterangan FROM op_stok_adjustment  order by `id` desc limit " + pg_str + ",10"
            While datareader_mysql_datagrid.Read() And (x <= jumlah_maks_data)
                full_date = datareader_mysql_datagrid(0).ToString().Trim()
                no_adjustment = datareader_mysql_datagrid(1).ToString().Trim()
                kode = datareader_mysql_datagrid(2).ToString().Trim()
                nama_barang = datareader_mysql_datagrid(3).ToString().Trim()
                qty_fisik = datareader_mysql_datagrid(4).ToString().Trim()
                qty_adjustment = datareader_mysql_datagrid(5).ToString().Trim()
                gudang = datareader_mysql_datagrid(6).ToString().Trim()
                jenis_adjustment = datareader_mysql_datagrid(7).ToString().Trim()
                keterangan = datareader_mysql_datagrid(8).ToString().Trim()
                full_date = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                qty_fisik = data_obj.format_num(qty_fisik)
                qty_adjustment = data_obj.format_num(qty_adjustment)
                x = x + 1
                '{"Kode", "Nama Produk", "Merek", "Kategori", "Harga", "Gudang", "Stok"}
                line = "<tr><td class=line> &nbsp;" + full_date + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + no_adjustment + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + kode + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + nama_barang + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + qty_fisik + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + qty_adjustment + "&nbsp; </td>" & vbCrLf &
                            "<td class=line> &nbsp;" + gudang + "&nbsp; </td>" & vbCrLf &
                             "<td class=line> &nbsp;" + jenis_adjustment + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + keterangan + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_mysql_datagrid.Dispose()
            full_html_str = full_html_str + "</table>"
            If mode = "print" Then
                full_html_str = full_html_str + footer_print()
            End If
            Dim app_path = basic_op.jstock_read_config()
            Dim path As String
            path = ""
            If mode = "print" Then
                path = app_path + "\print\stok_adjustment_print.html"
            Else
                path = app_path + "\print\stok_adjustment_preview.html"
            End If
            basic_op.create_file(path, full_html_str)

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Sub create_dokumen_print_laporan_stok(ByVal sql As String, ByVal jumlah_maks_data As Integer, ByVal mode As String, ByVal current_laporan_type As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            'Console.WriteLine("=============parameter data dumps================")
            'Console.WriteLine(sql)
            'Console.WriteLine(jumlah_maks_data)
            'Console.WriteLine(mode)
            'Console.WriteLine(current_laporan_type)
            'Console.WriteLine("=============================")
            Dim full_html_str As String
            Dim line As String
            Dim datareader_mysql_datagrid As MySqlDataReader

            Dim full_date As String
            Dim kode As String
            Dim nama_produk As String
            Dim harga As String
            Dim jumlah As String
            Dim waktu As String

            Dim tanggal As String

            Dim title_laporan As String
            If current_laporan_type = "masuk" Then
                title_laporan = "Laporan Stok Masuk"
            Else
                title_laporan = "Laporan Stok Keluar"
            End If
            'full_date,kode,nama_produk, harga, jumlah, waktu
            Dim array_header() As String = {"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah"}


            full_html_str = ""
            full_html_str = header_print()
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header)

            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            datareader_mysql_datagrid = data_obj.load_datareader_for_datagrid(sql)
            Dim x As Integer
            x = 0
            'full_date,kode,nama_produk, harga, jumlah, waktu
            While datareader_mysql_datagrid.Read() And (x <= jumlah_maks_data)
                full_date = datareader_mysql_datagrid(0).ToString().Trim()
                kode = datareader_mysql_datagrid(1).ToString().Trim()
                nama_produk = datareader_mysql_datagrid(2).ToString().Trim()
                harga = datareader_mysql_datagrid(3).ToString().Trim()
                jumlah = datareader_mysql_datagrid(4).ToString().Trim()
                waktu = datareader_mysql_datagrid(5).ToString().Trim()
                harga = data_obj.format_num(harga)
                jumlah = data_obj.format_num(jumlah)
                tanggal = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                x = x + 1
                '{"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah"}

                line = "<tr><td class=line> &nbsp;" + tanggal + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + kode + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + nama_produk + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + harga + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + waktu + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + jumlah + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_mysql_datagrid.Dispose()
            full_html_str = full_html_str + "</table>"
            If mode = "print" Then
                full_html_str = full_html_str + footer_print()
            End If
            Dim app_path = basic_op.jstock_read_config()
            Dim path As String
            path = ""
            If mode = "print" Then
                If current_laporan_type = "masuk" Then
                    path = app_path + "\print\laporan_stok_masuk_print.html"
                Else
                    path = app_path + "\print\laporan_stok_keluar_print.html"
                End If
            Else
                If current_laporan_type = "masuk" Then
                    path = app_path + "\print\laporan_stok_masuk_preview.html"
                Else
                    path = app_path + "\print\laporan_stok_keluar_preview.html"
                End If
            End If
            'Console.WriteLine(path)
            'Console.WriteLine("===========================================")
            'Console.WriteLine(full_html_str)
            basic_op.create_file(path, full_html_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Sub create_dokumen_print_laporan_pembelian_or_penjualan(ByVal sql As String, ByVal jumlah_maks_data As Integer, ByVal mode As String, ByVal jenis_laporan As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            jenis_laporan = jenis_laporan.Trim()
            'Me.sql_for_print = "select full_date,kode,nama_produk, harga, jumlah, waktu from op_stok_masuk where (`mark` = 'pembelian') and (`bulan` = '" + bulan + "' and `tahun` = '" + tahun + "')  order by `id` desc"
            Dim full_html_str As String
            Dim line As String
            Dim datareader_mysql_datagrid As MySqlDataReader

            Dim full_date As String
            Dim kode As String
            Dim nama_produk As String
            Dim harga As String
            Dim jumlah As String
            Dim waktu As String

            Dim title_laporan As String

            Dim tanggal As String
            If jenis_laporan = "penjualan" Then
                title_laporan = "Laporan Penjualan"
            Else
                title_laporan = "Laporan Pembelian"
            End If

            Dim array_header() As String = {"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah"}


            full_html_str = ""
            full_html_str = header_print()
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header)

            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            Console.WriteLine(sql)
            datareader_mysql_datagrid = data_obj.load_datareader_for_datagrid(sql)
            Dim x As Integer
            x = 0
            'full_date,kode,nama_produk, harga, jumlah, waktu
            While datareader_mysql_datagrid.Read() And (x <= jumlah_maks_data)
                full_date = datareader_mysql_datagrid(0).ToString().Trim()
                kode = datareader_mysql_datagrid(1).ToString().Trim()
                nama_produk = datareader_mysql_datagrid(2).ToString().Trim()
                harga = datareader_mysql_datagrid(3).ToString().Trim()
                jumlah = datareader_mysql_datagrid(4).ToString().Trim()
                waktu = datareader_mysql_datagrid(5).ToString().Trim()
                harga = data_obj.format_num(harga)
                jumlah = data_obj.format_num(jumlah)
                tanggal = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                x = x + 1
                '{"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah"}

                line = "<tr><td class=line> &nbsp;" + tanggal + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + kode + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + nama_produk + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + harga + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + waktu + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + jumlah + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_mysql_datagrid.Dispose()
            full_html_str = full_html_str + "</table>"
            If mode = "print" Then
                full_html_str = full_html_str + footer_print()
            End If
            Dim app_path = basic_op.jstock_read_config()
            Dim path As String
            path = app_path + "\print\laporan_penjualan_print.html"
            If mode = "print" Then
                If jenis_laporan = "penjualan" Then
                    path = app_path + "\print\laporan_penjualan_print.html"
                    basic_op.create_file(path.Trim(), full_html_str)
                ElseIf jenis_laporan = "pembelian" Then
                    path = app_path + "\print\laporan_pembelian_print.html"
                    basic_op.create_file(path.Trim(), full_html_str)
                End If
            Else
                If jenis_laporan = "penjualan" Then
                    path = app_path + "\print\laporan_penjualan_preview.html"
                    basic_op.create_file(path.Trim(), full_html_str)
                ElseIf jenis_laporan = "pembelian" Then
                    path = app_path + "\print\laporan_pembelian_preview.html"
                    basic_op.create_file(path.Trim(), full_html_str)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'Me.last_sql_for_csv_pembelian = "select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_masuk  where (`mark` = 'pembelian') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc"
    'Me.last_sql_for_print_pembelian = Me.last_sql_for_csv_pembelian
    'Me.last_sql_for_csv_penjualan = "select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_keluar  where (`mark` = 'penjualan') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc limit 0,500"
    'Me.last_sql_for_print_penjualan = Me.last_sql_for_csv_penjualan

    Public Sub create_dokumen_print_laporan_keuangan_pembelian_penjualan(ByVal laporan_jual_beli_tanggal_dari As String, ByVal laporan_jual_beli_tanggal_hingga As String, ByVal sql_pembelian As String, ByVal sql_penjualan As String, ByVal jumlah_maks_data As Integer, ByVal mode As String, ByVal total_nilai_penjualan As String, ByVal total_nilai_pembelian As String, ByVal total_selisih_nilai_pembelian_dan_penjualan As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim datareader_mysql_penjualan As MySqlDataReader
            Dim datareader_mysql_pembelian As MySqlDataReader
            Dim line As String
            Dim full_html_str As String
            Dim array_header_statistik() As String = {"Total Nilai Penjualan", "Total Nilai Pembelian", "Selisih Nilai Penjualan dan Pembelian"}
            Dim array_header_pembelian() As String = {"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah", "Subtotal"}
            Dim array_header_penjualan() As String = {"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah", "Subtotal"}
            Dim title_laporan As String
            Dim subtotal_int As Integer
            Dim subtotal_str As String

            Dim full_date As String
            Dim kode As String
            Dim nama_produk As String
            Dim harga As String
            Dim jumlah As String
            Dim waktu As String
            Dim tanggal As String

            full_html_str = ""
            full_html_str = header_print()

            'START STATISTIK
            title_laporan = "Statistik Pembelian dan Penjualan (" + laporan_jual_beli_tanggal_dari + "-" + laporan_jual_beli_tanggal_hingga + ")"
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header_statistik)
            line = "<tr><td class=line> &nbsp;" + total_nilai_penjualan + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + total_nilai_pembelian + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + total_selisih_nilai_pembelian_dan_penjualan + "&nbsp; </td></tr>"
            full_html_str = full_html_str + line
            full_html_str = full_html_str + "</table><br><br>"
            'EOF STATISTIK

            'START PENJUALAN
            title_laporan = "Data Penjualan (" + laporan_jual_beli_tanggal_dari + "-" + laporan_jual_beli_tanggal_hingga + ")"
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header_penjualan)
            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            datareader_mysql_penjualan = data_obj.load_datareader_for_datagrid(sql_penjualan)
            Dim x As Integer
            x = 0
            'full_date,kode,nama_produk, harga, jumlah, waktu
            While datareader_mysql_penjualan.Read() And (x <= jumlah_maks_data)
                full_date = datareader_mysql_penjualan(0).ToString().Trim()
                kode = datareader_mysql_penjualan(1).ToString().Trim()
                nama_produk = datareader_mysql_penjualan(2).ToString().Trim()
                harga = datareader_mysql_penjualan(3).ToString().Trim()
                jumlah = datareader_mysql_penjualan(4).ToString().Trim()
                waktu = datareader_mysql_penjualan(5).ToString().Trim()
                subtotal_int = Val(harga) * Val(jumlah)
                subtotal_str = subtotal_int.ToString

                harga = data_obj.format_num(harga)
                jumlah = data_obj.format_num(jumlah)
                subtotal_str = data_obj.format_num(subtotal_str)

                tanggal = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                x = x + 1
                ' {"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah", "Subtotal"}
                line = "<tr><td class=line> &nbsp;" + tanggal + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + kode + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + nama_produk + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + harga + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + waktu + "&nbsp; </td>" & vbCrLf &
                            "<td class=line> &nbsp;" + jumlah + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + subtotal_str + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_mysql_penjualan.Dispose()
            full_html_str = full_html_str + "</table><br><br>"
            'EOF PENJUALAN


            'START PEMBELIAN
            title_laporan = "Data Pembelian (" + laporan_jual_beli_tanggal_dari + "-" + laporan_jual_beli_tanggal_hingga + ")"
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header_penjualan)
            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            datareader_mysql_pembelian = data_obj.load_datareader_for_datagrid(sql_pembelian)
            x = 0
            'full_date,kode,nama_produk, harga, jumlah, waktu
            While datareader_mysql_pembelian.Read() And (x <= jumlah_maks_data)
                full_date = datareader_mysql_pembelian(0).ToString().Trim()
                kode = datareader_mysql_pembelian(1).ToString().Trim()
                nama_produk = datareader_mysql_pembelian(2).ToString().Trim()
                harga = datareader_mysql_pembelian(3).ToString().Trim()
                jumlah = datareader_mysql_pembelian(4).ToString().Trim()
                waktu = datareader_mysql_pembelian(5).ToString().Trim()
                subtotal_int = Val(harga) * Val(jumlah)
                subtotal_str = subtotal_int.ToString
                harga = data_obj.format_num(harga)
                jumlah = data_obj.format_num(jumlah)
                subtotal_str = data_obj.format_num(subtotal_str)
                tanggal = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                x = x + 1
                ' {"Tanggal", "Kode", "Nama Produk", "Harga", "Waktu", "Jumlah", "Subtotal"}
                line = "<tr><td class=line> &nbsp;" + tanggal + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + kode + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + nama_produk + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + harga + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + waktu + "&nbsp; </td>" & vbCrLf &
                            "<td class=line> &nbsp;" + jumlah + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + subtotal_str + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_mysql_pembelian.Dispose()
            full_html_str = full_html_str + "</table><br><br>"
            'EOF PEMBELIAN

            If mode = "print" Then
                full_html_str = full_html_str + footer_print()
            End If
            Dim app_path = basic_op.jstock_read_config()
            Dim path As String
            path = ""
            If mode = "print" Then
                path = app_path + "\print\laporan_keuangan_penjualan_pembelian_print.html"
            Else
                path = app_path + "\print\laporan_keuangan_penjualan_pembelian_preview.html"
            End If
            basic_op.create_file(path, full_html_str)

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Sub create_dokumen_print_laporan_keuangan_kas_masuk_keluar(ByVal laporan_kas_tanggal_dari As String, ByVal laporan_kas_tanggal_hingga As String, ByVal sql_for_print_histori_kas As String, ByVal sql_for_print_histori_kas_masuk As String, ByVal sql_for_print_histori_kas_keluar As String, ByVal jumlah_kas_sekarang As String, ByVal statistik_kas_masuk As String, ByVal statistik_kas_keluar As String, ByVal statistik_selisih As String, ByVal statistik_status As String, ByVal jumlah_maks_data As Integer, ByVal mode As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim x As Integer
            'Me.last_sql_for_csv_histori_kas = "SELECT jumlah_kas,full_date, mark FROM  op_histori_kas  where (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit 0," + max_data_to_print
            'Me.last_sql_for_print_histori_kas = Me.last_sql_for_csv_histori_kas

            'Me.last_sql_for_csv_histori_kas_masuk = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pemasukan') and (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit 0," + max_data_to_print
            'Me.last_sql_for_print_histori_kas_masuk = Me.last_sql_for_csv_histori_kas_masuk

            'Me.last_sql_for_csv_histori_kas_keluar = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pengeluaran') and (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit 0," + max_data_to_print
            'Me.last_sql_for_print_histori_kas_keluar = Me.last_sql_for_csv_histori_kas_masuk
            Dim tanggal As String
            Dim full_date As String
            Dim jumlah_kas_masuk As String
            Dim jumlah_kas_keluar As String
            Dim jumlah_kas As String
            Dim mark As String
            Dim title_laporan As String
            Dim full_html_str As String
            Dim line As String
            Dim array_header_statistik() As String = {"Jumlah Kas Sekarang", "Jumlah Kas Masuk", "Jumlah Kas Keluar", "Selisih Kas", "Status Kas"}
            Dim array_header_histori_kas() As String = {"Tanggal", "Jumlah Kas", "Mark"}
            Dim array_header_histori_kas_masuk() As String = {"Tanggal", "Jumlah Kas Masuk", "Mark"}
            Dim array_header_histori_kas_keluar() As String = {"Tanggal", "Jumlah Kas Keluar", "Mark"}

            Dim datareader_kas_masuk As MySqlDataReader
            Dim datareader_kas_keluar As MySqlDataReader
            Dim datareader_kas As MySqlDataReader

            full_html_str = ""
            full_html_str = header_print()

            '-------------------------------------------------------
            'START STATISTIK KAS
            title_laporan = "Statistik Kas (" + laporan_kas_tanggal_dari + "-" + laporan_kas_tanggal_hingga + ")"
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header_statistik)

            jumlah_kas_sekarang = data_obj.format_num(jumlah_kas_sekarang)
            statistik_kas_masuk = data_obj.format_num(statistik_kas_masuk)
            statistik_kas_keluar = data_obj.format_num(statistik_kas_keluar)
            statistik_selisih = data_obj.format_num(statistik_selisih)

            line = "<tr><td class=line> &nbsp;" + jumlah_kas_sekarang + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + statistik_kas_masuk + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + statistik_kas_keluar + "&nbsp; </td>" & vbCrLf &
                           "<td class=line> &nbsp;" + statistik_selisih + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + statistik_status + "&nbsp; </td></tr>"
            full_html_str = full_html_str + line
            full_html_str = full_html_str + "</table><br><br>"
            'EOF STATISTIK KAS
            '-------------------------------------------------------


            '-------------------------------------------------------
            'START DATA KAS MASUK
            title_laporan = "Data Kas Masuk (" + laporan_kas_tanggal_dari + "-" + laporan_kas_tanggal_hingga + ")"
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header_histori_kas_masuk)
            'Me.last_sql_for_csv_histori_kas_masuk = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pemasukan') and (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit 0," + max_data_to_print
            'Me.last_sql_for_print_histori_kas_masuk = Me.last_sql_for_csv_histori_kas_masuk

            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            datareader_kas_masuk = data_obj.load_datareader_for_datagrid(sql_for_print_histori_kas_masuk)
            x = 0
            While datareader_kas_masuk.Read() And (x <= jumlah_maks_data)
                full_date = datareader_kas_masuk(1).ToString().Trim()
                jumlah_kas_masuk = datareader_kas_masuk(0).ToString().Trim()
                mark = datareader_kas_masuk(2).ToString().Trim()
                tanggal = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                jumlah_kas_masuk = data_obj.format_num(jumlah_kas_masuk)
                x = x + 1
                line = "<tr><td class=line> &nbsp;" + tanggal + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + jumlah_kas_masuk + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + mark + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_kas_masuk.Dispose()
            full_html_str = full_html_str + "</table><br><br>"

            'EOF DATA KAS MASUK
            '-------------------------------------------------------



            '-------------------------------------------------------
            'START DATA KAS KELUAR
            title_laporan = "Data Kas Keluar (" + laporan_kas_tanggal_dari + "-" + laporan_kas_tanggal_hingga + ")"
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header_histori_kas_keluar)

            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            'Console.WriteLine(sql_for_print_histori_kas_keluar)
            datareader_kas_keluar = data_obj.load_datareader_for_datagrid(sql_for_print_histori_kas_keluar)
            x = 0
            While datareader_kas_keluar.Read() And (x <= jumlah_maks_data)
                full_date = datareader_kas_keluar(1).ToString().Trim()
                jumlah_kas_keluar = datareader_kas_keluar(0).ToString().Trim()
                mark = datareader_kas_keluar(2).ToString().Trim()
                tanggal = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                jumlah_kas_keluar = data_obj.format_num(jumlah_kas_keluar)
                x = x + 1
                line = "<tr><td class=line> &nbsp;" + tanggal + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + jumlah_kas_keluar + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + mark + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_kas_keluar.Dispose()
            full_html_str = full_html_str + "</table><br><br>"
            'EOF DATA KAS KELUAR
            '-------------------------------------------------------



            '-------------------------------------------------------
            'START DATA HISTORI PERUBAHAN KAS

            title_laporan = "Histori Perubahan Kas (" + laporan_kas_tanggal_dari + "-" + laporan_kas_tanggal_hingga + ")"
            full_html_str = full_html_str + generate_table_header(title_laporan, array_header_histori_kas)


            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            datareader_kas = data_obj.load_datareader_for_datagrid(sql_for_print_histori_kas)
            x = 0
            While datareader_kas.Read() And (x <= jumlah_maks_data)
                full_date = datareader_kas(1).ToString().Trim()
                jumlah_kas = datareader_kas(0).ToString().Trim()
                mark = datareader_kas(2).ToString().Trim()
                tanggal = basic_op.convert_mysql_date_format_to_chinese_date_format(full_date)
                jumlah_kas = data_obj.format_num(jumlah_kas)
                x = x + 1
                line = "<tr><td class=line> &nbsp;" + tanggal + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + jumlah_kas + "&nbsp; </td>" & vbCrLf &
                           "<td class=line align=right> &nbsp;" + mark + "&nbsp; </td></tr>"
                full_html_str = full_html_str + line
            End While
            datareader_kas.Dispose()
            full_html_str = full_html_str + "</table><br><br>"


            'EOF DATA HISTORI PERUBAHAN KAS
            '-------------------------------------------------------
            If mode = "print" Then
                full_html_str = full_html_str + footer_print()
            End If
            Dim app_path = basic_op.jstock_read_config()
            Dim path As String
            path = ""
            If mode = "print" Then
                path = app_path + "\print\laporan_keuangan_kas_print.html"
            Else
                path = app_path + "\print\laporan_keuangan_kas_preview.html"
            End If
            basic_op.create_file(path, full_html_str)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class
