Imports MySql.Data.MySqlClient

Imports System.Math
Public Class laporan_keuangan
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public print_generator As New print_generator
    Public Property sql_for_print As String
    Public datatable_mysql_penjualan = New DataTable
    Public datatable_mysql_pembelian = New DataTable

    Public datatable_mysql_histori_kas = New DataTable
    Public datatable_mysql_histori_kas_masuk = New DataTable
    Public datatable_mysql_histori_kas_keluar = New DataTable

    Public Property total_nilai_penjualan_lr As Integer
    Public Property total_nilai_pembelian_lr As Integer
    Public Property selisih_lr As Integer
    'tab1

    Public Property page_penjualan As Integer
    Public Property total_data_penjualan As Integer
    Public Property max_page_penjualan As Integer

    Public Property page_pembelian As Integer
    Public Property total_data_pembelian As Integer
    Public Property max_page_pembelian As Integer

    Public Property tanggal_dari As String
    Public Property tanggal_hingga As String

    Public Property bulan_dari As String
    Public Property bulan_hingga

    Public Property tahun_dari As String
    Public Property tahun_hingga As String

    'print laba rugi
    Public Property last_sql_for_print_pembelian As String
    Public Property last_sql_for_print_penjualan As String

    'for csv and print laba rugi
    Public Property total_nilai_penjualan As String
    Public Property total_nilai_pembelian As String
    Public Property total_selisih_nilai_pembelian_dan_penjualan As String

    'print kas
    Public Property last_sql_for_print_histori_kas As String
    Public Property last_sql_for_print_histori_kas_masuk As String
    Public Property last_sql_for_print_histori_kas_keluar As String
    'for csv and print kas
    Public Property jumlah_kas_sekarang As String
    Public Property statistik_kas_masuk As Integer
    Public Property statistik_kas_keluar As Integer
    Public Property statistik_selisih As Integer
    Public Property statistik_status As String

    'eof for csv and print kas


    'csv laba rugi
    Public Property last_sql_for_csv_pembelian As String
    Public Property last_sql_for_csv_penjualan As String

    'csv kas
    Public Property last_sql_for_csv_histori_kas As String
    Public Property last_sql_for_csv_histori_kas_masuk As String
    Public Property last_sql_for_csv_histori_kas_keluar As String



    Public Property page_histori_kas As Integer
    Public Property total_data_histori_kas As Integer
    Public Property max_page_histori_kas As Integer

    Public Property page_histori_kas_masuk As Integer
    Public Property total_data_histori_kas_masuk As Integer
    Public Property max_page_histori_kas_masuk As Integer

    Public Property page_histori_kas_keluar As Integer
    Public Property total_data_histori_kas_keluar As Integer
    Public Property max_page_histori_kas_keluar As Integer

    Public Property laporan_kas_tanggal_dari As String
    Public Property laporan_kas_tanggal_hingga As String



    Public Property laporan_jual_beli_tanggal_dari As String
    Public Property laporan_jual_beli_tanggal_hingga As String



    Public Sub load_inner_data_dgview_laba_rugi_pembelian()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim harga As String
            Dim jumlah As String
            Dim subtotal_int As Integer
            Dim datareader_mysql_local As MySqlDataReader
            Me.total_nilai_pembelian_lr = 0
            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)
            Dim sql_pembelian = "SELECT harga, jumlah FROM op_stok_masuk  where (`mark` = 'pembelian') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc"
            datareader_mysql_local = data_obj.load_datareader_for_datagrid(sql_pembelian)
            While datareader_mysql_local.Read
                harga = datareader_mysql_local(0).ToString
                jumlah = datareader_mysql_local(1).ToString
                If Val(harga) > 0 And Val(jumlah) > 0 Then
                    subtotal_int = Val(harga) * Val(jumlah)
                    Me.total_nilai_pembelian_lr = Me.total_nilai_pembelian_lr + subtotal_int
                End If
            End While
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub load_inner_data_dgview_laba_rugi_penjualan()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim harga As String
            Dim jumlah As String
            Dim subtotal_int As Integer
            Dim datareader_mysql_local As MySqlDataReader
            Me.total_nilai_penjualan_lr = 0
            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)
            Dim sql_penjualan = "SELECT harga, jumlah FROM op_stok_keluar  where (`mark` = 'penjualan') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc"
            datareader_mysql_local = data_obj.load_datareader_for_datagrid(sql_penjualan)
            While datareader_mysql_local.Read
                harga = datareader_mysql_local(0).ToString
                jumlah = datareader_mysql_local(1).ToString
                If Val(harga) > 0 And Val(jumlah) > 0 Then
                    subtotal_int = Val(harga) * Val(jumlah)
                    Me.total_nilai_penjualan_lr = Me.total_nilai_penjualan_lr + subtotal_int
                End If
            End While
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub load_dgview_laba_rugi()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Call load_inner_data_dgview_laba_rugi_pembelian()
            Call load_inner_data_dgview_laba_rugi_penjualan()
            If Me.total_nilai_pembelian_lr > 0 And Me.total_nilai_penjualan_lr > 0 Then
                If Me.total_nilai_penjualan_lr > Me.total_nilai_pembelian_lr Then
                    selisih_lr = Me.total_nilai_penjualan_lr - Me.total_nilai_pembelian_lr
                ElseIf Me.total_nilai_pembelian_lr > Me.total_nilai_penjualan_lr Then
                    selisih_lr = Me.total_nilai_pembelian_lr - Me.total_nilai_penjualan_lr
                End If
                total_nilai_penjualan = Me.total_nilai_penjualan_lr.ToString
                total_nilai_pembelian = Me.total_nilai_pembelian_lr.ToString
                total_selisih_nilai_pembelian_dan_penjualan = Me.selisih_lr.ToString

                'penjualan - pembelian - selisih
                DGView_laba_rugi.Rows(0).Cells(0).Value = data_obj.format_num(Me.total_nilai_penjualan_lr.ToString)
                DGView_laba_rugi.Rows(0).Cells(1).Value = data_obj.format_num(Me.total_nilai_pembelian_lr.ToString)
                DGView_laba_rugi.Rows(0).Cells(2).Value = data_obj.format_num(Me.selisih_lr.ToString)
            Else
                DGView_laba_rugi.Rows(0).Cells(0).Value = "0"
                DGView_laba_rugi.Rows(0).Cells(1).Value = "0"
                DGView_laba_rugi.Rows(0).Cells(2).Value = "0"
            End If

            Dim t As Integer
            For t = 0 To DGView_laba_rugi.Columns.Count - 1
                DGView_laba_rugi.Columns.Item(t).SortMode = DataGridViewColumnSortMode.Programmatic
            Next t

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_datetimepicker()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim tgl_bule As String
            'Dim tgl_from As String
            'Dim tgl_to As String
            Dim array_parse() As String

            Dim hari As Integer
            Dim bulan As Integer
            Dim tahun As Integer

            Dim hari_from As Integer
            Dim hari_to As Integer
            Dim hari_from_str As String
            Dim hari_to_str As String
            Dim bulan_str_dari As String
            Dim bulan_str_hingga As String
            Dim tahun_str As String

            'MM/dd/YYY
            tgl_bule = basic_op.waktu("tanggal_bule")
            array_parse = tgl_bule.Split("/")

            hari = Val(array_parse(1))
            bulan = Val(array_parse(0))
            tahun = Val(array_parse(2))

            If hari > 7 Then
                hari_from = hari - 7
            Else
                hari_from = 1
            End If
            hari_from_str = hari_from.ToString
            If Len(hari_from_str) < 2 Then
                hari_from_str = "0" & hari_from_str
            End If

            hari_to = hari
            hari_to_str = hari_to.ToString
            If Len(hari_to_str) < 2 Then
                hari_to_str = "0" & hari_to_str
            End If


            If bulan > 1 Then
                bulan_str_dari = (bulan - 1).ToString
            Else
                bulan_str_dari = "1"
            End If
            If Len(bulan_str_dari) < 2 Then
                bulan_str_dari = "0" & bulan_str_dari
            End If

            bulan_str_hingga = bulan.ToString
            If Len(bulan_str_hingga) < 2 Then
                bulan_str_hingga = "0" & bulan_str_hingga
            End If

            tahun_str = tahun.ToString


            ' fill datepicker from
            'DateTimePicker_dari
            DateTimePicker_dari.Text = bulan_str_dari & "/" & hari_from_str & "/" & tahun_str
            ' fill datepicker until
            'DateTimePicker_hingga
            DateTimePicker_hingga.Text = bulan_str_hingga & "/" & hari_to_str & "/" & tahun_str
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub



    Public Sub select_combo_item_penjualan()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            combo_page_data_penjualan.Items.Clear()
            For val As Integer = 1 To max_page_penjualan
                combo_page_data_penjualan.Items.Add(val)
                If Me.page_penjualan = val Then
                    combo_page_data_penjualan.SelectedItem = combo_page_data_penjualan.Items(val - 1)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub select_combo_item_pembelian()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            combo_page_data_pembelian.Items.Clear()
            For val As Integer = 1 To max_page_pembelian
                combo_page_data_pembelian.Items.Add(val)
                If Me.page_pembelian = val Then
                    combo_page_data_pembelian.SelectedItem = combo_page_data_pembelian.Items(val - 1)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_prev_data_penjualan_Click(sender As Object, e As EventArgs) Handles button_prev_data_penjualan.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_penjualan > 1 Then
                Me.page_penjualan = Me.page_penjualan - 1
                Call load_data_penjualan(Me.page_penjualan)
                button_next_data_penjualan.Enabled = 1
                Call select_combo_item_penjualan()
            Else
                button_prev_data_penjualan.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_next_data_penjualan_Click(sender As Object, e As EventArgs) Handles button_next_data_penjualan.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_penjualan < Me.max_page_penjualan Then
                Me.page_penjualan = Me.page_penjualan + 1
                Call load_data_penjualan(Me.page_penjualan)
                button_prev_data_penjualan.Enabled = 1
                Call select_combo_item_penjualan()

            Else
                button_next_data_penjualan.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_prev_data_pembelian_Click(sender As Object, e As EventArgs) Handles button_prev_data_pembelian.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_pembelian > 1 Then
                Me.page_pembelian = Me.page_pembelian - 1
                Call load_data_pembelian(Me.page_pembelian)
                button_next_data_pembelian.Enabled = 1
                Call select_combo_item_pembelian()
            Else
                button_prev_data_pembelian.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_next_data_pembelian_Click(sender As Object, e As EventArgs) Handles button_next_data_pembelian.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_pembelian < Me.max_page_pembelian Then
                Me.page_pembelian = Me.page_pembelian + 1
                Call load_data_pembelian(Me.page_pembelian)
                button_prev_data_pembelian.Enabled = 1
                Call select_combo_item_pembelian()
            Else
                button_next_data_pembelian.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_home_data_penjualan_Click(sender As Object, e As EventArgs) Handles button_home_data_penjualan.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page_penjualan = 1
            Call load_data_penjualan(Me.page_penjualan)

            Call load_dgview_laba_rugi()

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_home_data_pembelian_Click(sender As Object, e As EventArgs) Handles button_home_data_pembelian.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page_pembelian = 1
            Call load_data_pembelian(Me.page_pembelian)
            Call load_dgview_laba_rugi()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Private Sub button_go_Click(sender As Object, e As EventArgs) Handles button_go.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try

            Me.page_penjualan = 1
            Me.page_pembelian = 1

            Call prepare_data_pelengkap_penjualan()
            Call load_data_penjualan(Me.page_penjualan)

            Call prepare_data_pelengkap_pembelian()
            Call load_data_pembelian(Me.page_pembelian)
            Call load_dgview_laba_rugi()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_data_pelengkap_penjualan()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)

            Dim sql = "SELECT COUNT(*) FROM op_stok_keluar  where (`mark` = 'penjualan') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "')"
            Me.total_data_penjualan = data_obj.get_total_rows_from_sql(sql)
            Me.max_page_penjualan = Ceiling(Me.total_data_penjualan / 10)
            button_prev_data_penjualan.Enabled = 0
            text_total_data_penjualan.Text = Me.total_data_penjualan
            text_total_page_data_penjualan.Text = Me.max_page_penjualan
            If max_page_penjualan < 2 Then
                button_next_data_penjualan.Enabled = 0
            End If
            Call select_combo_item_penjualan()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_data_pelengkap_pembelian()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)

            Dim sql = "SELECT COUNT(*) FROM op_stok_masuk  where (`mark` = 'pembelian') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "')"
            Me.total_data_pembelian = data_obj.get_total_rows_from_sql(sql)
            Me.max_page_pembelian = Ceiling(Me.total_data_pembelian / 10)
            button_prev_data_pembelian.Enabled = 0
            text_total_data_pembelian.Text = Me.total_data_pembelian
            text_total_page_data_pembelian.Text = Me.max_page_pembelian
            If max_page_pembelian < 2 Then
                button_next_data_pembelian.Enabled = 0
            End If
            Call select_combo_item_pembelian()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub read_datetimepicker_date()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_str_dari As String
            Dim full_str_hingga As String

            full_str_dari = DateTimePicker_dari.Text
            full_str_hingga = DateTimePicker_hingga.Text

            Me.tanggal_dari = basic_op.parse_tgl(full_str_dari, "tanggal")
            Me.bulan_dari = basic_op.parse_tgl(full_str_dari, "bulan")
            Me.tahun_dari = basic_op.parse_tgl(full_str_dari, "tahun")

            Me.tanggal_hingga = basic_op.parse_tgl(full_str_hingga, "tanggal")
            Me.bulan_hingga = basic_op.parse_tgl(full_str_hingga, "bulan")
            Me.tahun_hingga = basic_op.parse_tgl(full_str_hingga, "tahun")
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub load_data_penjualan(ByVal hal As Integer)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()

            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)

            sql = "SELECT id, kode, nama_produk, harga, jumlah, tanggal, bulan, tahun FROM op_stok_keluar  where (`mark` = 'penjualan') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc limit " + pg_str + ",10"
            Me.last_sql_for_csv_penjualan = "select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_keluar  where (`mark` = 'penjualan') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc limit 0,500"
            Me.last_sql_for_print_penjualan = Me.last_sql_for_csv_penjualan
            datatable_mysql_penjualan = data_obj.load_data_for_datagrid(sql)
            DGView_penjualan.DataSource = datatable_mysql_penjualan
            DGView_penjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()
            x = 0
            '0 tanggal (full str)
            '1 subtotal
            '2 ??? id ???
            '3 kode barang
            '4 nama barang
            '5 harga
            '6 jumlah
            '7 tanggal
            '8 bulan
            '9 tahun
            While x < DGView_penjualan.RowCount
                If Len(DGView_penjualan.Rows(x).Cells(5).Value) > 0 Then
                    DGView_penjualan.Rows(x).Cells(5).Value = data_obj.format_num(DGView_penjualan.Rows(x).Cells(5).Value)
                    DGView_penjualan.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If Len(DGView_penjualan.Rows(x).Cells(6).Value) > 0 Then
                    DGView_penjualan.Rows(x).Cells(6).Value = data_obj.format_num(DGView_penjualan.Rows(x).Cells(6).Value)
                    DGView_penjualan.Rows(x).Cells(6).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If (Len(DGView_penjualan.Rows(x).Cells(5).Value) > 0) And (Len(DGView_penjualan.Rows(x).Cells(6).Value) > 0) Then
                    Dim harga_str = DGView_penjualan.Rows(x).Cells(5).Value.ToString.Replace(".", "").Replace(",", "")
                    Dim jumlah_str = DGView_penjualan.Rows(x).Cells(6).Value.ToString.Replace(".", "").Replace(",", "")
                    Dim subtotal = Val(harga_str) * Val(jumlah_str)
                    DGView_penjualan.Rows(x).Cells(1).Value = data_obj.format_num(subtotal.ToString)
                    DGView_penjualan.Rows(x).Cells(1).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                DGView_penjualan.Rows(x).Cells(0).Value = DGView_penjualan.Rows(x).Cells(7).Value & "/" & DGView_penjualan.Rows(x).Cells(8).Value & "/" & DGView_penjualan.Rows(x).Cells(9).Value
                x = x + 1
            End While

            Dim i As Integer
            For i = 0 To DGView_penjualan.Columns.Count - 1
                DGView_penjualan.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
            Next i

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub load_data_pembelian(ByVal hal As Integer)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()

            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)

            sql = "SELECT id, kode, nama_produk, harga, jumlah, tanggal, bulan, tahun FROM op_stok_masuk  where (`mark` = 'pembelian') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc limit " + pg_str + ",10"

            Me.last_sql_for_csv_pembelian = "select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_masuk  where (`mark` = 'pembelian') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc"
            Me.last_sql_for_print_pembelian = Me.last_sql_for_csv_pembelian
            datatable_mysql_pembelian = data_obj.load_data_for_datagrid(sql)
            DGView_pembelian.DataSource = datatable_mysql_pembelian
            DGView_pembelian.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()
            x = 0
            '0 tanggal (full str)
            '1 subtotal
            '2 ??? id ???
            '3 kode barang
            '4 nama barang
            '5 harga
            '6 jumlah
            '7 tanggal
            '8 bulan
            '9 tahun
            While x < DGView_pembelian.RowCount
                If Len(DGView_pembelian.Rows(x).Cells(5).Value) > 0 Then
                    DGView_pembelian.Rows(x).Cells(5).Value = data_obj.format_num(DGView_pembelian.Rows(x).Cells(5).Value)
                    DGView_pembelian.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If Len(DGView_pembelian.Rows(x).Cells(6).Value) > 0 Then
                    DGView_pembelian.Rows(x).Cells(6).Value = data_obj.format_num(DGView_pembelian.Rows(x).Cells(6).Value)
                    DGView_pembelian.Rows(x).Cells(6).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If (Len(DGView_pembelian.Rows(x).Cells(5).Value) > 0) And (Len(DGView_pembelian.Rows(x).Cells(6).Value) > 0) Then
                    Dim harga_str = DGView_pembelian.Rows(x).Cells(5).Value.ToString.Replace(".", "").Replace(",", "")
                    Dim jumlah_str = DGView_pembelian.Rows(x).Cells(6).Value.ToString.Replace(".", "").Replace(",", "")
                    Dim subtotal = Val(harga_str) * Val(jumlah_str)
                    DGView_pembelian.Rows(x).Cells(1).Value = data_obj.format_num(subtotal.ToString)
                    DGView_pembelian.Rows(x).Cells(1).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                DGView_pembelian.Rows(x).Cells(0).Value = DGView_pembelian.Rows(x).Cells(7).Value & "/" & DGView_pembelian.Rows(x).Cells(8).Value & "/" & DGView_pembelian.Rows(x).Cells(9).Value
                x = x + 1
            End While
            Dim i As Integer
            For i = 0 To DGView_pembelian.Columns.Count - 1
                DGView_pembelian.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
            Next i
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    'special property for laba rugi
    'Public Property last_sql_for_csv_pembelian As String
    'Public Property last_sql_for_print_pembelian As String

    'Public Property last_sql_for_csv_penjualan As String
    'Public Property last_sql_for_print_penjualan As String

    'Public Property total_nilai_penjualan As String
    'Public Property total_nilai_pembelian As String

    Private Sub tombol_csv_laba_rugi_Click(sender As Object, e As EventArgs) Handles tombol_csv_laba_rugi.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(Me.total_nilai_penjualan_lr.ToString) > 0 And Len(Me.total_nilai_pembelian_lr.ToString) > 0 Then
                Console.WriteLine("filling up form csv with vars:" + Me.total_nilai_penjualan_lr.ToString)
                form_csv.total_nilai_penjualan = Me.total_nilai_penjualan_lr.ToString
                form_csv.total_nilai_pembelian = Me.total_nilai_pembelian_lr.ToString
                form_csv.total_selisih_nilai_pembelian_dan_penjualan = Me.selisih_lr.ToString
                form_csv.last_sql_for_csv_pembelian = Me.last_sql_for_csv_pembelian
                form_csv.last_sql_for_csv_penjualan = Me.last_sql_for_csv_penjualan
                form_csv.nama_tabel = "laba_rugi"
                form_csv.Show()
                basic_op.setfokus(form_csv)
            Else
                MsgBox("tidak ada data untuk diekspor")
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    'tab kas

    Public Sub prepare_datetimepicker2()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim tgl_bule As String
            'Dim tgl_from As String
            'Dim tgl_to As String
            Dim array_parse() As String

            Dim hari As Integer
            Dim bulan As Integer
            Dim tahun As Integer

            Dim hari_from As Integer
            Dim hari_to As Integer
            Dim hari_from_str As String
            Dim hari_to_str As String
            Dim bulan_str_dari As String
            Dim bulan_str_hingga As String
            Dim tahun_str As String

            'MM/dd/YYY
            tgl_bule = basic_op.waktu("tanggal_bule")
            array_parse = tgl_bule.Split("/")

            hari = Val(array_parse(1))
            bulan = Val(array_parse(0))
            tahun = Val(array_parse(2))

            If hari > 7 Then
                hari_from = hari - 7
            Else
                hari_from = 1
            End If
            hari_from_str = hari_from.ToString
            If Len(hari_from_str) < 2 Then
                hari_from_str = "0" & hari_from_str
            End If

            hari_to = hari
            hari_to_str = hari_to.ToString
            If Len(hari_to_str) < 2 Then
                hari_to_str = "0" & hari_to_str
            End If


            If bulan > 1 Then
                bulan_str_dari = (bulan - 1).ToString
            Else
                bulan_str_dari = "1"
            End If
            If Len(bulan_str_dari) < 2 Then
                bulan_str_dari = "0" & bulan_str_dari
            End If

            bulan_str_hingga = bulan.ToString
            If Len(bulan_str_hingga) < 2 Then
                bulan_str_hingga = "0" & bulan_str_hingga
            End If

            tahun_str = tahun.ToString


            ' fill datepicker from
            'DateTimePicker_dari2
            dtanggal_dari.Text = bulan_str_dari & "/" & hari_from_str & "/" & tahun_str
            ' fill datepicker until
            'DateTimePicker_hingga2
            dtanggal_hingga.Text = bulan_str_hingga & "/" & hari_to_str & "/" & tahun_str


            Console.WriteLine(Me.laporan_kas_tanggal_dari)
            Console.WriteLine(Me.laporan_kas_tanggal_hingga)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub read_datetimepicker2()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Console.WriteLine("reading datetimepicker for kas")
            Me.laporan_kas_tanggal_dari = dtanggal_dari.Text
            Me.laporan_kas_tanggal_hingga = dtanggal_hingga.Text
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub


    Public Sub load_data_kas()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim jumlah_kas As String
            jumlah_kas = data_obj.ret_colval_without_condition("master_kas", "jumlah_kas")
            text_jumlah_kas.Text = data_obj.format_num(jumlah_kas)
            Me.jumlah_kas_sekarang = jumlah_kas.Trim()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
    Public Sub load_DGView_histori_perubahan_data_kas(ByVal hal As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim max_data_to_print = jum_print_kas.Text.Trim()
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            x = 0
            'Me.laporan_kas_tanggal_dari = hari_from_str + "/" + bulan_str_dari + "/" + tahun_str
            'Me.laporan_kas_tanggal_hingga = hari_to_str + "/" + bulan_str_hingga + "/" + tahun_str

            Dim full_date_dari2 = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_dari)
            Dim full_date_hingga2 = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_hingga)
            If Len(full_date_dari2) > 1 And Len(full_date_hingga2) > 1 Then
                sql = "SELECT jumlah_kas,full_date, mark FROM  op_histori_kas  where  (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit " + pg_str + ",10"
            Else
                sql = "SELECT jumlah_kas,full_date, mark FROM  op_histori_kas  order by `id` desc limit " + pg_str + ",10"
            End If
            'Console.WriteLine(sql)
            Me.last_sql_for_csv_histori_kas = "SELECT jumlah_kas,full_date, mark FROM  op_histori_kas  where (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit 0," + max_data_to_print
            Me.last_sql_for_print_histori_kas = Me.last_sql_for_csv_histori_kas

            datatable_mysql_histori_kas = data_obj.load_data_for_datagrid(sql)
            DGView_histori_perubahan_data_kas.DataSource = datatable_mysql_histori_kas
            DGView_histori_perubahan_data_kas.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()
            '0 jumlah kas
            '1 full_date
            '2 pembelian
            x = 0
            While x < DGView_histori_perubahan_data_kas.RowCount
                'ret_date = tahun_str + "-" + bulan_str + "-" + tanggal_str
                If Len(DGView_histori_perubahan_data_kas.Rows(1).Cells(0).Value) > 0 Then
                    DGView_histori_perubahan_data_kas.Rows(x).Cells(0).Value = data_obj.format_num(DGView_histori_perubahan_data_kas.Rows(x).Cells(0).Value)
                    DGView_histori_perubahan_data_kas.Rows(x).Cells(0).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If Len(DGView_histori_perubahan_data_kas.Rows(1).Cells(1).Value) > 0 Then
                    DGView_histori_perubahan_data_kas.Rows(x).Cells(1).Value = basic_op.convert_mysql_date_format_to_chinese_date_format(DGView_histori_perubahan_data_kas.Rows(x).Cells(1).Value)
                End If
                x = x + 1
            End While

            Dim t As Integer
            For t = 0 To DGView_histori_perubahan_data_kas.Columns.Count - 1
                DGView_histori_perubahan_data_kas.Columns.Item(t).SortMode = DataGridViewColumnSortMode.Programmatic
            Next t
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub load_DGView_kas_masuk(ByVal hal As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim max_data_to_print = jum_print_kas.Text.Trim()
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            x = 0
            'Me.laporan_kas_tanggal_dari = hari_from_str + "/" + bulan_str_dari + "/" + tahun_str
            'Me.laporan_kas_tanggal_hingga = hari_to_str + "/" + bulan_str_hingga + "/" + tahun_str

            Dim full_date_dari2 = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_dari)
            Dim full_date_hingga2 = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_hingga)

            If Len(full_date_dari2) > 1 And Len(full_date_hingga2) > 1 Then
                sql = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pemasukan') and (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit " + pg_str + ",10"
            Else
                sql = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pemasukan') order by `id` desc limit " + pg_str + ",10"
            End If
            Me.last_sql_for_csv_histori_kas_masuk = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pemasukan') and (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit 0," + max_data_to_print
            Me.last_sql_for_print_histori_kas_masuk = Me.last_sql_for_csv_histori_kas_masuk

            datatable_mysql_histori_kas_masuk = data_obj.load_data_for_datagrid(sql)
            DGView_kas_masuk.DataSource = datatable_mysql_histori_kas_masuk
            DGView_kas_masuk.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()

            x = 0
            While x < DGView_kas_masuk.RowCount
                'ret_date = tahun_str + "-" + bulan_str + "-" + tanggal_str
                If Len(DGView_kas_masuk.Rows(1).Cells(0).Value) > 0 Then
                    DGView_kas_masuk.Rows(x).Cells(0).Value = data_obj.format_num(DGView_kas_masuk.Rows(x).Cells(0).Value)
                    DGView_kas_masuk.Rows(x).Cells(0).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If Len(DGView_kas_masuk.Rows(1).Cells(1).Value) > 0 Then
                    DGView_kas_masuk.Rows(x).Cells(1).Value = basic_op.convert_mysql_date_format_to_chinese_date_format(DGView_kas_masuk.Rows(x).Cells(1).Value)
                End If
                x = x + 1
            End While

            Dim t As Integer
            For t = 0 To DGView_kas_masuk.Columns.Count - 1
                DGView_kas_masuk.Columns.Item(t).SortMode = DataGridViewColumnSortMode.Programmatic
            Next t

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub load_DGView_kas_keluar(ByVal hal As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim max_data_to_print = jum_print_kas.Text.Trim()
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            x = 0
            'Me.laporan_kas_tanggal_dari = hari_from_str + "/" + bulan_str_dari + "/" + tahun_str
            'Me.laporan_kas_tanggal_hingga = hari_to_str + "/" + bulan_str_hingga + "/" + tahun_str

            Dim full_date_dari2 = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_dari)
            Dim full_date_hingga2 = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_hingga)

            If Len(full_date_dari2) > 1 And Len(full_date_hingga2) > 1 Then
                sql = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pengeluaran') and (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit " + pg_str + ",10"
            Else
                sql = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pengeluaran') order by `id` desc limit " + pg_str + ",10"
            End If

            Me.last_sql_for_csv_histori_kas_keluar = "SELECT jumlah_kas_masuk_atau_keluar,full_date, mark FROM  op_histori_kas_flow  where (`mark` = 'pengeluaran') and (`full_date` between '" + full_date_dari2 + "' and  '" + full_date_hingga2 + "') order by `id` desc limit 0," + max_data_to_print
            Me.last_sql_for_print_histori_kas_keluar = Me.last_sql_for_csv_histori_kas_keluar

            datatable_mysql_histori_kas_keluar = data_obj.load_data_for_datagrid(sql)
            DGView_kas_keluar.DataSource = datatable_mysql_histori_kas_keluar
            DGView_kas_keluar.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()

            x = 0
            While x < DGView_kas_keluar.RowCount
                'ret_date = tahun_str + "-" + bulan_str + "-" + tanggal_str
                If Len(DGView_kas_keluar.Rows(1).Cells(0).Value) > 0 Then
                    DGView_kas_keluar.Rows(x).Cells(0).Value = data_obj.format_num(DGView_kas_keluar.Rows(x).Cells(0).Value)
                    DGView_kas_keluar.Rows(x).Cells(0).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If Len(DGView_kas_keluar.Rows(1).Cells(1).Value) > 0 Then
                    DGView_kas_keluar.Rows(x).Cells(1).Value = basic_op.convert_mysql_date_format_to_chinese_date_format(DGView_kas_keluar.Rows(x).Cells(1).Value)
                End If
                x = x + 1
            End While

            Dim t As Integer
            For t = 0 To DGView_kas_keluar.Columns.Count - 1
                DGView_kas_keluar.Columns.Item(t).SortMode = DataGridViewColumnSortMode.Programmatic
            Next t
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub laporan_keuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            'start tab laba rugi
            Call prepare_datetimepicker()
            Me.page_penjualan = 1
            Me.page_pembelian = 1
            read_datetimepicker_date()

            Call prepare_data_pelengkap_penjualan()
            Call load_data_penjualan(Me.page_penjualan)

            Call prepare_data_pelengkap_pembelian()
            Call load_data_pembelian(Me.page_pembelian)

            Call load_dgview_laba_rugi()
            'eof tab laba rugi


        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_cari_Click(sender As Object, e As EventArgs) Handles tombol_cari.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            read_datetimepicker2()
            Me.page_histori_kas = 1
            Call prepare_data_pelengkap_histori_kas()
            Call load_DGView_histori_perubahan_data_kas(Me.page_histori_kas)
            Me.page_histori_kas_masuk = 1
            prepare_data_pelengkap_kas_masuk()
            Call load_DGView_kas_masuk(Me.page_histori_kas_masuk)
            Me.page_histori_kas_keluar = 1
            prepare_data_pelengkap_kas_keluar()
            Call load_DGView_kas_keluar(Me.page_histori_kas_keluar)
            Call load_kotak_statistik_kas()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_prev_histori_perubahan_kas_Click(sender As Object, e As EventArgs) Handles button_prev_histori_perubahan_kas.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_histori_kas > 1 Then
                Me.page_histori_kas = Me.page_histori_kas - 1
                Call load_DGView_histori_perubahan_data_kas(Me.page_histori_kas)
                button_next_histori_perubahan_kas.Enabled = 1
                Call select_combo_item_histori_perubahan_kas()
            Else
                button_prev_histori_perubahan_kas.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_next_histori_perubahan_kas_Click(sender As Object, e As EventArgs) Handles button_next_histori_perubahan_kas.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_histori_kas < Me.max_page_histori_kas Then
                Me.page_histori_kas = Me.page_histori_kas + 1
                Call load_DGView_histori_perubahan_data_kas(Me.page_histori_kas)
                button_prev_histori_perubahan_kas.Enabled = 1
                Call select_combo_item_histori_perubahan_kas()

            Else
                button_next_histori_perubahan_kas.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub select_combo_item_histori_perubahan_kas()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Console.WriteLine("current page histori kas :" + Me.page_histori_kas.ToString)
            combo_page_histori_kas.Items.Clear()
            For val As Integer = 1 To Me.max_page_histori_kas
                combo_page_histori_kas.Items.Add(val)
                If Me.page_histori_kas = val Then
                    combo_page_histori_kas.SelectedItem = combo_page_histori_kas.Items(val - 1)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_data_pelengkap_histori_kas()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql As String

            Dim full_date_dari = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_dari)
            Dim full_date_hingga = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_hingga)
            If Len(full_date_dari) > 1 And Len(full_date_hingga) > 1 Then
                sql = "SELECT COUNT(*) FROM op_histori_kas  where (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "')"

            Else
                sql = "SELECT COUNT(*) FROM op_histori_kas"
            End If
            Me.total_data_histori_kas = data_obj.get_total_rows_from_sql(Sql)
            Me.max_page_histori_kas = Ceiling(Me.total_data_histori_kas / 10)
            button_prev_histori_perubahan_kas.Enabled = 0
            text_total_data_histori_kas.Text = Me.total_data_histori_kas
            text_total_page_histori_kas.Text = Me.max_page_histori_kas
            If Me.max_page_histori_kas < 2 Then
                button_next_histori_perubahan_kas.Enabled = 0
            End If
            Call select_combo_item_histori_perubahan_kas()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'kas masuk
    Public Sub select_combo_item_kas_masuk()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            combo_page_kas_masuk.Items.Clear()
            For val As Integer = 1 To max_page_histori_kas_masuk
                combo_page_kas_masuk.Items.Add(val)
                If Me.page_histori_kas_masuk = val Then
                    combo_page_kas_masuk.SelectedItem = combo_page_kas_masuk.Items(val - 1)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_data_pelengkap_kas_masuk()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_date_dari = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_dari)
            Dim full_date_hingga = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_hingga)
            Dim sql As String
            If Len(full_date_dari) > 1 And Len(full_date_hingga) > 1 Then
                sql = "SELECT COUNT(*) FROM op_histori_kas_flow  where (`mark` = 'pemasukan') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "')"
            Else
                sql = "SELECT COUNT(*) FROM op_histori_kas_flow  where (`mark` = 'pemasukan')"
            End If
            Me.total_data_histori_kas_masuk = data_obj.get_total_rows_from_sql(sql)
            Me.max_page_histori_kas_masuk = Ceiling(Me.total_data_histori_kas_masuk / 10)
            button_prev_kas_masuk.Enabled = 0
            text_total_data_kas_masuk.Text = Me.total_data_histori_kas_masuk
            text_total_page_kas_masuk.Text = Me.max_page_histori_kas_masuk
            If Me.max_page_histori_kas_masuk < 2 Then
                button_next_kas_masuk.Enabled = 0
            End If
            Call select_combo_item_kas_masuk()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'kas keluar
    Public Sub select_combo_item_kas_keluar()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            combo_page_kas_keluar.Items.Clear()
            For val As Integer = 1 To max_page_histori_kas_keluar
                combo_page_kas_keluar.Items.Add(val)
                If Me.page_histori_kas_keluar = val Then
                    combo_page_kas_keluar.SelectedItem = combo_page_kas_keluar.Items(val - 1)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_data_pelengkap_kas_keluar()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_date_dari = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_dari)
            Dim full_date_hingga = basic_op.return_mysql_date_format(Me.laporan_kas_tanggal_hingga)
            Dim sql As String
            If Len(full_date_dari) > 1 And Len(full_date_hingga) > 1 Then
                sql = "SELECT COUNT(*) FROM op_histori_kas_flow  where (`mark` = 'pengeluaran') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "')"
            Else
                sql = "SELECT COUNT(*) FROM op_histori_kas_flow  where (`mark` = 'pengeluaran')"
            End If
            Me.total_data_histori_kas_keluar = data_obj.get_total_rows_from_sql(sql)
            Me.max_page_histori_kas_keluar = Ceiling(Me.total_data_histori_kas_keluar / 10)
            button_prev_kas_keluar.Enabled = 0
            text_total_data_kas_keluar.Text = Me.total_data_histori_kas_keluar
            text_total_page_kas_keluar.Text = Me.max_page_histori_kas_keluar
            If Me.max_page_histori_kas_keluar < 2 Then
                button_next_kas_keluar.Enabled = 0
            End If
            Call select_combo_item_kas_keluar()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_prev_kas_masuk_Click(sender As Object, e As EventArgs) Handles button_prev_kas_masuk.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_histori_kas_masuk > 1 Then
                Me.page_histori_kas_masuk = Me.page_histori_kas_masuk - 1
                Call load_DGView_kas_masuk(Me.page_histori_kas_masuk)
                button_next_kas_masuk.Enabled = 1
                Call select_combo_item_kas_masuk()
            Else
                button_prev_kas_masuk.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_next_kas_masuk_Click(sender As Object, e As EventArgs) Handles button_next_kas_masuk.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_histori_kas_masuk < Me.max_page_histori_kas_masuk Then
                Me.page_histori_kas_masuk = Me.page_histori_kas_masuk + 1
                Call load_DGView_kas_masuk(Me.page_histori_kas_masuk)
                button_prev_kas_masuk.Enabled = 1
                Call select_combo_item_kas_masuk()
            Else
                button_next_kas_masuk.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_prev_kas_keluar_Click(sender As Object, e As EventArgs) Handles button_prev_kas_keluar.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_histori_kas_keluar > 1 Then
                Me.page_histori_kas_keluar = Me.page_histori_kas_keluar - 1
                Call load_DGView_kas_keluar(Me.page_histori_kas_keluar)
                button_next_kas_keluar.Enabled = 1
                Call select_combo_item_kas_keluar()
            Else
                button_prev_kas_keluar.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_next_kas_keluar_Click(sender As Object, e As EventArgs) Handles button_next_kas_keluar.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page_histori_kas_keluar < Me.max_page_histori_kas_keluar Then
                Me.page_histori_kas_keluar = Me.page_histori_kas_keluar + 1
                Call load_DGView_kas_keluar(Me.page_histori_kas_keluar)
                button_prev_kas_keluar.Enabled = 1
                Call select_combo_item_kas_keluar()
            Else
                button_next_kas_keluar.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub histori_kas_home()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page_histori_kas = 1
            Call prepare_data_pelengkap_histori_kas()
            Call load_DGView_histori_perubahan_data_kas(Me.page_histori_kas)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
    Private Sub tombol_home_histori_perubahan_kas_Click(sender As Object, e As EventArgs) Handles tombol_home_histori_perubahan_kas.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            all_home()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub kas_masuk_home()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page_histori_kas_masuk = 1
            prepare_data_pelengkap_kas_masuk()
            Call load_DGView_kas_masuk(Me.page_histori_kas_masuk)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Private Sub tombol_home_kas_masuk_Click(sender As Object, e As EventArgs) Handles tombol_home_kas_masuk.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            all_home()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub kas_keluar_home()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page_histori_kas_keluar = 1
            prepare_data_pelengkap_kas_keluar()
            Call load_DGView_kas_keluar(Me.page_histori_kas_keluar)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
    Private Sub tombol_home_kas_keluar_Click(sender As Object, e As EventArgs) Handles tombol_home_kas_keluar.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            all_home()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub all_home()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Call prepare_datetimepicker2()
            Call histori_kas_home()
            Call kas_keluar_home()
            Call kas_masuk_home()
            Call load_kotak_statistik_kas()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'Public Property statistik_kas_masuk As Integer
    'Public Property statistik_kas_keluar As Integer
    'Public Property statistik_selisih As Integer
    'Public Property statistik_status As String

    'Public Property laporan_kas_tanggal_dari As String
    'Public Property laporan_kas_tanggal_hingga As String

    Public Sub load_kotak_statistik_kas_masuk()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql_pemasukan As String
            Me.statistik_kas_masuk = 0
            Dim jumlah As String
            Dim datareader_mysql_local As MySqlDataReader
            Dim full_date_dari = basic_op.return_mysql_date_format(laporan_kas_tanggal_dari)
            Dim full_date_hingga = basic_op.return_mysql_date_format(laporan_kas_tanggal_hingga)
            If Len(full_date_dari) > 0 And Len(full_date_hingga) > 0 Then
                sql_pemasukan = "SELECT jumlah_kas_masuk_atau_keluar FROM op_histori_kas_flow  where (`mark` = 'pemasukan') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc"
            Else
                sql_pemasukan = "SELECT jumlah_kas_masuk_atau_keluar FROM op_histori_kas_flow  where (`mark` = 'pemasukan') order by `id` desc"
            End If
            'Console.WriteLine(sql_pemasukan)
            datareader_mysql_local = data_obj.load_datareader_for_datagrid(sql_pemasukan)
            While datareader_mysql_local.Read
                jumlah = datareader_mysql_local(0).ToString
                If Val(jumlah) > 0 Then
                    Me.statistik_kas_masuk = Me.statistik_kas_masuk + Val(jumlah)
                End If
            End While
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub



    Public Sub load_kotak_statistik_kas()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Call load_kotak_statistik_kas_masuk()
            Call load_kotak_statistik_kas_keluar()
            text_jumlah_total_kas_masuk.Text = data_obj.format_num(statistik_kas_masuk.ToString)
            text_jumlah_total_kas_keluar.Text = data_obj.format_num(statistik_kas_keluar.ToString)
            If statistik_kas_masuk > statistik_kas_keluar Then
                statistik_selisih = statistik_kas_masuk - statistik_kas_keluar
                statistik_status = "surplus"
            ElseIf statistik_kas_keluar > statistik_kas_masuk Then
                statistik_selisih = statistik_kas_keluar - statistik_kas_masuk
                statistik_status = "defisit"
            Else
                statistik_selisih = 0
                statistik_status = ""
            End If
            text_selisih_kas.Text = data_obj.format_num(statistik_selisih.ToString)
            text_status_kas.Text = statistik_status
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_csv_kas_Click(sender As Object, e As EventArgs) Handles tombol_csv_kas.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(Me.statistik_kas_masuk.ToString) > 0 And Len(Me.statistik_kas_keluar.ToString) > 0 Then
                form_csv.jumlah_total_kas_masuk = Me.statistik_kas_masuk.ToString()
                form_csv.jumlah_total_kas_keluar = Me.statistik_kas_keluar.ToString()
                form_csv.jumlah_total_selisih_kas_masuk_dan_keluar = Me.statistik_selisih.ToString()
                form_csv.status_selisih_kas_masuk_dan_keluar = Me.statistik_status

                form_csv.last_sql_for_csv_histori_kas = Me.last_sql_for_csv_histori_kas
                form_csv.last_sql_for_csv_histori_kas_masuk = Me.last_sql_for_csv_histori_kas_masuk
                form_csv.last_sql_for_csv_histori_kas_keluar = Me.last_sql_for_csv_histori_kas_keluar

                form_csv.jumlah_kas_sekarang = Me.jumlah_kas_sekarang
                form_csv.nama_tabel = "kas"
                form_csv.Show()
                basic_op.setfokus(form_csv)
            Else
                MsgBox("Tidak ada data untuk diekspor ke csv")
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    'prints
    Private Sub tombol_print_preview_laba_rugi_Click(sender As Object, e As EventArgs) Handles tombol_print_preview_laba_rugi.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            laporan_jual_beli_tanggal_dari = DateTimePicker_dari.Text
            laporan_jual_beli_tanggal_hingga = DateTimePicker_hingga.Text
            Dim jumlah_maks_data = Val(jum_print.Text.Trim())
            If jumlah_maks_data < 1 Then
                jumlah_maks_data = 300
            End If
            form_print_prepare.current_file = "laporan_keuangan_penjualan_pembelian_preview.html"
            print_generator.create_dokumen_print_laporan_keuangan_pembelian_penjualan(laporan_jual_beli_tanggal_dari, laporan_jual_beli_tanggal_hingga, last_sql_for_print_pembelian, last_sql_for_print_penjualan, jumlah_maks_data, "preview", total_nilai_penjualan, total_nilai_pembelian, total_selisih_nilai_pembelian_dan_penjualan)
            form_print_prepare.Show()
            basic_op.setfokus(form_print_prepare)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_print_laba_rugi_Click(sender As Object, e As EventArgs) Handles tombol_print_laba_rugi.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            laporan_jual_beli_tanggal_dari = DateTimePicker_dari.Text
            laporan_jual_beli_tanggal_hingga = DateTimePicker_hingga.Text
            Dim jumlah_maks_data = Val(jum_print.Text.Trim())
            If jumlah_maks_data < 1 Then
                jumlah_maks_data = 300
            End If
            form_print.current_file = "laporan_keuangan_penjualan_pembelian_print.html"
            print_generator.create_dokumen_print_laporan_keuangan_pembelian_penjualan(laporan_jual_beli_tanggal_dari, laporan_jual_beli_tanggal_hingga, last_sql_for_print_pembelian, last_sql_for_print_penjualan, jumlah_maks_data, "print", total_nilai_penjualan, total_nilai_pembelian, total_selisih_nilai_pembelian_dan_penjualan)
            form_print.Show()
            basic_op.setfokus(form_print)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'Public Property laporan_kas_tanggal_dari As String
    'Public Property laporan_kas_tanggal_hingga As String
    Private Sub tombol_print_preview_kas_Click(sender As Object, e As EventArgs) Handles tombol_print_preview_kas.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim jumlah_maks_data = Val(jum_print.Text.Trim())
            If jumlah_maks_data < 1 Then
                jumlah_maks_data = 300
            End If
            form_print_prepare.current_file = "laporan_keuangan_kas_preview.html"
            'print_generator.create_dokumen_print_laporan_keuangan(Me.sql_for_print, jumlah_maks_data, "print")
            print_generator.create_dokumen_print_laporan_keuangan_kas_masuk_keluar(laporan_kas_tanggal_dari, laporan_kas_tanggal_hingga, last_sql_for_print_histori_kas, last_sql_for_print_histori_kas_masuk, last_sql_for_print_histori_kas_keluar, jumlah_kas_sekarang, statistik_kas_masuk, statistik_kas_keluar, statistik_selisih, statistik_status, jumlah_maks_data, "preview")
            form_print_prepare.Show()
            basic_op.setfokus(form_print_prepare)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_print_kas_Click(sender As Object, e As EventArgs) Handles tombol_print_kas.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim jumlah_maks_data = Val(jum_print.Text.Trim())
            If jumlah_maks_data < 1 Then
                jumlah_maks_data = 300
            End If
            form_print.current_file = "laporan_keuangan_kas_print.html"
            print_generator.create_dokumen_print_laporan_keuangan_kas_masuk_keluar(laporan_kas_tanggal_dari, laporan_kas_tanggal_hingga, last_sql_for_print_histori_kas, last_sql_for_print_histori_kas_masuk, last_sql_for_print_histori_kas_keluar, jumlah_kas_sekarang, statistik_kas_masuk, statistik_kas_keluar, statistik_selisih, statistik_status, jumlah_maks_data, "print")
            form_print.Show()
            basic_op.setfokus(form_print)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub load_kotak_statistik_kas_keluar()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql_pengeluaran As String
            Me.statistik_kas_keluar = 0
            Dim jumlah As String
            Dim datareader_mysql_local As MySqlDataReader
            Dim full_date_dari = basic_op.return_mysql_date_format(laporan_kas_tanggal_dari)
            Dim full_date_hingga = basic_op.return_mysql_date_format(laporan_kas_tanggal_hingga)
            If Len(full_date_dari) > 1 And Len(full_date_hingga) > 1 Then
                sql_pengeluaran = "SELECT jumlah_kas_masuk_atau_keluar FROM op_histori_kas_flow  where (`mark` = 'pengeluaran') and (`full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "') order by `id` desc"
            Else
                sql_pengeluaran = "SELECT jumlah_kas_masuk_atau_keluar FROM op_histori_kas_flow  where (`mark` = 'pengeluaran') order by `id` desc"
            End If

            'Console.WriteLine(sql_pengeluaran)
            datareader_mysql_local = data_obj.load_datareader_for_datagrid(sql_pengeluaran)
            While datareader_mysql_local.Read
                jumlah = datareader_mysql_local(0).ToString
                If Val(jumlah) > 0 Then
                    Me.statistik_kas_keluar = Me.statistik_kas_keluar + Val(jumlah)
                End If
            End While
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            'start tab kas
            Call prepare_datetimepicker2()

            Call read_datetimepicker2()
            Me.page_histori_kas = 1
            Call prepare_data_pelengkap_histori_kas()
            Call load_DGView_histori_perubahan_data_kas(Me.page_histori_kas)

            Me.page_histori_kas_masuk = 1
            prepare_data_pelengkap_kas_masuk()
            Call load_DGView_kas_masuk(Me.page_histori_kas_masuk)

            Me.page_histori_kas_keluar = 1
            prepare_data_pelengkap_kas_keluar()
            Call load_DGView_kas_keluar(Me.page_histori_kas_keluar)
            Call load_kotak_statistik_kas()
            Call load_data_kas()
            'eof tab kas
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

End Class