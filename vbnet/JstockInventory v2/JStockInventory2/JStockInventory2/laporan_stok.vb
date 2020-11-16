Imports MySql.Data.MySqlClient
Imports System.Math

Public Class laporan_stok
    Public basic_op As New basic_op
    Public data_obj As New data_object
    Public print_generator As New print_generator
    Public Property sql_for_print As String
    Public Property current_mode_view As String
    Public Property current_laporan_type As String

    Public datatable_mysql = New DataTable

    Public Property saved_data As Integer
    Public Property page As Integer
    Public Property total_data As Integer
    Public Property max_page As Integer
    Public Property last_sql_for_csv As String


    Public Sub select_combo_item()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            combo_page.Items.Clear()
            For val As Integer = 1 To max_page
                combo_page.Items.Add(val)
                If Me.page = val Then
                    combo_page.SelectedItem = combo_page.Items(val - 1)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub laporan_stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.current_laporan_type = "masuk"
            current_mode_view = "default"
            Me.saved_data = 0
            Me.page = 1
            Call prepare_data_pelengkap()
            Call LoadData(Me.page)
            Call prepare_data_combo_pencarian()
            combo_bulan.SelectedIndex = 0
            combo_tahun.SelectedIndex = 0
            combo_jenis_laporan.SelectedIndex = 0
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            current_mode_view = "default"
            Me.page = 1
            Me.current_laporan_type = "masuk"
            Call prepare_data_pelengkap()
            Call LoadData(Me.page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            current_mode_view = "default"
            Me.page = 1
            Me.current_laporan_type = "keluar"
            Call prepare_data_pelengkap()
            Call LoadData(Me.page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Private Sub tombol_home_Click(sender As Object, e As EventArgs) Handles tombol_home.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            combo_bulan.SelectedIndex = 0
            combo_tahun.SelectedIndex = 0
            current_mode_view = "default"
            Me.page = 1
            Call prepare_data_pelengkap()
            Call LoadData(page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Private Sub DGView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView.CellClick
        selected_view(e)
    End Sub

    Private Sub DGView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView.CellContentClick
        selected_view(e)
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah data akan dihapus ?", "Hapus Data")
            If hapus = 1 Then
                Dim id = text_id.Text
                Dim res = 0
                If Me.current_laporan_type = "masuk" Then
                    res = data_obj.mysql_del("op_stok_masuk", id)
                ElseIf Me.current_laporan_type = "keluar" Then
                    res = data_obj.mysql_del("op_stok_keluar", id)
                End If
                If res = 0 Then
                    basic_op.gagal_delete()
                Else
                    Console.Beep(4000, 100)
                    Me.saved_data = 1
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Sub clear_data()
        text_tanggal.Text = ""
        text_waktu.Text = ""
        text_kode.Text = ""
        text_nama_produk.Text = ""
        text_harga.Text = ""
        text_jumlah.Text = ""
        text_id.Text = ""
    End Sub

    Private Sub button_clear_data_Click(sender As Object, e As EventArgs) Handles button_clear_data.Click
        Call clear_data()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.saved_data = 1 Then
                Call LoadData(Me.page)
                Me.saved_data = 0
            End If
            If Me.current_laporan_type = "keluar" Then
                combo_jenis_laporan.SelectedIndex = 1
            Else
                combo_jenis_laporan.SelectedIndex = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub text_harga_TextChanged(sender As Object, e As EventArgs) Handles text_harga.TextChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim fmt As String
            fmt = data_obj.format_num(text_harga.Text)
            text_harga.Text = fmt
            text_harga.SelectionStart = Len(text_harga.Text)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub text_jumlah_TextChanged(sender As Object, e As EventArgs) Handles text_jumlah.TextChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim fmt As String
            fmt = data_obj.format_num(text_jumlah.Text)
            text_jumlah.Text = fmt
            text_jumlah.SelectionStart = Len(text_jumlah.Text)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_data_combo_pencarian()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim tahun_kini As String
            combo_bulan.Items.Add("Pilih Bulan")
            Dim i As Integer
            i = 1
            While i <= 12
                combo_bulan.Items.Add(i.ToString())
                i = i + 1
            End While

            combo_tahun.Items.Add("Pilih Tahun")
            tahun_kini = basic_op.waktu("tahun")
            Dim start_year = Val(tahun_kini) - 10
            Dim end_year = Val(tahun_kini) + 10

            i = start_year
            While i <= end_year
                combo_tahun.Items.Add(i.ToString())
                i = i + 1
            End While
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.current_mode_view = "sort"
            Dim bulan As String
            Dim tahun As String
            Dim hal As Integer
            hal = 1
            bulan = combo_bulan.Text.Trim()
            tahun = combo_tahun.Text.Trim()

            If bulan = "Pilih Bulan" Or tahun = "Pilih Tahun" Then
                MsgBox("untuk melakukan pencarian, silahkan pilih bulan dan tahun terlebih dahulu !")
            Else
                Call prepare_data_pelengkap()
                Call LoadData_sorting(hal, bulan, tahun)
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_prev_Click(sender As Object, e As EventArgs) Handles button_prev.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page > 1 Then
                Me.page = Me.page - 1
                If current_mode_view = "default" Or (current_mode_view = "range") Then
                    Call LoadData(Me.page)
                Else
                    Dim bulan As String
                    Dim tahun As String
                    If (combo_bulan.Text <> "Pilih Bulan") And (combo_tahun.Text <> "Pilih Tahun") Then
                        bulan = combo_bulan.Text
                        tahun = combo_tahun.Text
                        Call LoadData_sorting(Me.page, bulan, tahun)
                    Else
                        Call LoadData(Me.page)
                    End If
                End If
                button_next.Enabled = 1
                Call select_combo_item()
            Else
                button_prev.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page < Me.max_page Then
                Me.page = Me.page + 1
                If current_mode_view = "default" Or (current_mode_view = "range") Then
                    Call LoadData(Me.page)
                Else
                    Dim bulan As String
                    Dim tahun As String
                    If (combo_bulan.Text <> "Pilih Bulan") And (combo_tahun.Text <> "Pilih Tahun") Then
                        bulan = combo_bulan.Text
                        tahun = combo_tahun.Text
                        Call LoadData_sorting(Me.page, bulan, tahun)
                    Else
                        Call LoadData(Me.page)
                    End If
                End If
                button_prev.Enabled = 1
                Call select_combo_item()
            Else
                button_next.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub combo_page_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_page.SelectedIndexChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page = combo_page.SelectedItem
            If current_mode_view = "default" Then
                Call LoadData(Me.page)
            Else
                Dim bulan As String
                Dim tahun As String
                If (combo_bulan.Text <> "Pilih Bulan") And (combo_tahun.Text <> "Pilih Tahun") Then
                    bulan = combo_bulan.Text
                    tahun = combo_tahun.Text
                    Call LoadData_sorting(Me.page, bulan, tahun)
                Else
                    Call LoadData(Me.page)
                End If
            End If

            'Call LoadData(Me.page)
            If Me.page = Me.max_page Then
                button_next.Enabled = 0
                button_prev.Enabled = 1
            End If
            If Me.page = 1 Then
                button_prev.Enabled = 0
                button_next.Enabled = 1
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub prepare_data_pelengkap()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim bulan As String
            Dim tahun As String
            bulan = "Pilih Bulan"
            tahun = "Pilih Tahun"

            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)
            If (combo_bulan.Text <> "Pilih Bulan") And (combo_tahun.Text <> "Pilih Tahun") Then
                bulan = combo_bulan.Text
                tahun = combo_tahun.Text
            End If

            If Me.current_laporan_type = "masuk" Then
                If current_mode_view = "default" Then
                    Me.total_data = data_obj.get_total_rows("op_stok_masuk")
                ElseIf current_mode_view = "range" Then
                    Me.total_data = data_obj.get_total_rows_between("op_stok_masuk", "full_date", full_date_dari, full_date_hingga)
                Else
                    If (bulan <> "Pilih Bulan") And (tahun <> "Pilih Tahun") Then
                        Me.total_data = data_obj.get_total_rows_on_2condition("op_stok_masuk", "bulan", bulan, "tahun", tahun)
                    Else
                        Me.total_data = data_obj.get_total_rows("op_stok_masuk")
                    End If

                End If
            Else
                If current_mode_view = "default" Then
                    Me.total_data = data_obj.get_total_rows("op_stok_keluar")
                ElseIf current_mode_view = "range" Then
                    Me.total_data = data_obj.get_total_rows_between("op_stok_keluar", "full_date", full_date_dari, full_date_hingga)
                Else
                    If (combo_bulan.Text <> "Pilih Bulan") And (combo_tahun.Text <> "Pilih Tahun") Then
                        Me.total_data = data_obj.get_total_rows_on_2condition("op_stok_keluar", "bulan", bulan, "tahun", tahun)
                    Else
                        Me.total_data = data_obj.get_total_rows("op_stok_keluar")
                    End If
                End If
            End If
            Me.max_page = Ceiling(Me.total_data / 10)
            Call select_combo_item()
            button_prev.Enabled = 0
            text_total_data.Text = Me.total_data
            text_total_page.Text = Me.max_page
            If max_page < 2 Then
                button_next.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_csv_Click(sender As Object, e As EventArgs) Handles tombol_csv.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        form_csv.sql_to_exec = Me.last_sql_for_csv

        Try
            If Me.current_laporan_type = "keluar" Then
                form_csv.additional_mark = ""
                form_csv.nama_tabel = "op_stok_keluar"
            Else
                form_csv.additional_mark = ""
                form_csv.nama_tabel = "op_stok_masuk"
            End If

            form_csv.Show()
            basic_op.setfokus(form_csv)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub selected_view(e As DataGridViewCellEventArgs)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If (e.RowIndex >= 0) And DGView.CurrentCell.Value <> Nothing Then
                Dim row As DataGridViewRow
                row = Me.DGView.Rows(e.RowIndex)
                text_id.Text = row.Cells("id").Value.ToString
                text_tanggal.Text = row.Cells("tanggal_only").Value.ToString & "/" & row.Cells("bulan").Value.ToString & "/" & row.Cells("tahun").Value.ToString
                text_kode.Text = row.Cells("kode").Value.ToString
                text_nama_produk.Text = row.Cells("nama_produk").Value.ToString
                text_harga.Text = row.Cells("harga").Value.ToString
                text_jumlah.Text = row.Cells("jumlah").Value.ToString
                text_waktu.Text = row.Cells("waktu").Value.ToString

                text_tanggal_only.Text = row.Cells("tanggal_only").Value.ToString
                text_bulan.Text = row.Cells("bulan").Value.ToString
                text_tahun.Text = row.Cells("tahun").Value.ToString
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_simpan_Click(sender As Object, e As EventArgs) Handles tombol_simpan.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_tanggal As String
            Dim tanggal As String
            Dim bulan As String
            Dim tahun As String
            full_tanggal = text_tanggal.Text.Trim()
            If Len(text_tanggal.Text) < 4 Then
                MsgBox("data tanggal harus diisi dengan benar, format: dd/mm/yyyy")
            ElseIf Len(text_nama_produk.Text) < 1 Then
                MsgBox("nama produk harus diisi")
            ElseIf Len(text_kode.Text) < 1 Then
                MsgBox("kode harus diisi")
            Else
                Try
                    tanggal = basic_op.parse_tgl(full_tanggal, "tanggal")
                    bulan = basic_op.parse_tgl(full_tanggal, "bulan")
                    tahun = basic_op.parse_tgl(full_tanggal, "tahun")
                Catch ex As Exception
                    Console.WriteLine("parse_tgl error")
                End Try

                If Val(tanggal) < 1 Or Val(tanggal) > 31 Then
                    MsgBox("haru tanggal harus diisi dengan benar, format: dd/mm/yyyy")
                ElseIf Val(bulan) < 1 Or Val(bulan) > 12 Then
                    MsgBox("bulan harus diisi dengan benar, format: dd/mm/yyyy")
                ElseIf Val(tahun) < 0 Or Len(tahun) < 3 Then
                    MsgBox("tahun harus diisi dengan benar, format: dd/mm/yyyy")
                Else
                    Dim id = text_id.Text.Trim()
                    If id <> "" And id <> "-777" Then
                        ' Public Property current_laporan_type As String -> masuk atau keluar
                        Dim waktu As String
                        Dim kode As String
                        Dim nama_produk As String
                        Dim harga As String
                        Dim jumlah As String

                        Dim ret = 0
                        tanggal = text_tanggal_only.Text.Trim()
                        waktu = text_waktu.Text.Trim()
                        kode = text_kode.Text.Trim()
                        nama_produk = text_nama_produk.Text.Trim()
                        harga = text_harga.Text.Replace(",", "").Trim()
                        jumlah = text_jumlah.Text.Replace(",", "").Trim()
                        Dim full_date As String
                        full_date = basic_op.return_mysql_date_format_from_raw(tanggal, bulan, tahun)
                        If Me.current_laporan_type = "masuk" Then
                            Dim sql = "update `op_stok_masuk` set `tanggal` = '" + tanggal + "',`bulan` = '" + bulan + "', `tahun` = '" + tahun + "', `waktu` = '" + waktu + "', `kode` = '" + kode + "', `nama_produk` = '" + nama_produk + "', `harga` = '" + harga + "', `jumlah` = '" + jumlah + "',`full_date`='" + full_date + "' where `id` like '" + id + "'"
                            ret = data_obj.mysql_just_exec(sql)
                        ElseIf Me.current_laporan_type = "keluar" Then
                            Dim sql = "update `op_stok_keluar` set `tanggal` = '" + tanggal + "',`bulan` = '" + bulan + "', `tahun` = '" + tahun + "', `waktu` = '" + waktu + "', `kode` = '" + kode + "', `nama_produk` = '" + nama_produk + "', `harga` = '" + harga + "', `jumlah` = '" + jumlah + "',`full_date`='" + full_date + "' where `id` like '" + id + "'"
                            ret = data_obj.mysql_just_exec(sql)
                        End If
                        If ret = 1 Then
                            Console.Beep(4000, 100)
                            Me.saved_data = 1
                        Else
                            MsgBox("data gagal disimpan")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Sub LoadData_sorting(ByVal hal As Integer, ByVal bulan As String, ByVal tahun As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            sql = "Select id, kode, nama_produk, harga, jumlah, waktu, tanggal, bulan, tahun FROM op_stok_masuk  where `bulan` = '" + bulan + "' and `tahun` = '" + tahun + "' order by `id` desc limit " + pg_str + ",10"
            Me.last_sql_for_csv = "Select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_masuk  where `bulan` = '" + bulan + "' and `tahun` = '" + tahun + "' order by `id` desc  limit 0,500"
            If Me.current_laporan_type = "keluar" Then
                sql = "SELECT id, kode, nama_produk, harga, jumlah, waktu, tanggal, bulan, tahun FROM op_stok_keluar  where `bulan` = '" + bulan + "' and `tahun` = '" + tahun + "' order by `id` desc limit " + pg_str + ",10"
                Me.last_sql_for_csv = "Select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_keluar  where `bulan` = '" + bulan + "' and `tahun` = '" + tahun + "' order by `id` desc limit 0,500"
                Me.sql_for_print = Me.last_sql_for_csv
            End If
            datatable_mysql = data_obj.load_data_for_datagrid(sql)
            DGView.DataSource = datatable_mysql
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()
            x = 0
            While x < DGView.RowCount
                '5 jumlah
                If Len(DGView.Rows(x).Cells(5).Value) > 0 Then
                    DGView.Rows(x).Cells(5).Value = data_obj.format_num(DGView.Rows(x).Cells(5).Value)
                    DGView.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                '4 harga
                If Len(DGView.Rows(x).Cells(4).Value) > 0 Then
                    DGView.Rows(x).Cells(4).Value = data_obj.format_num(DGView.Rows(x).Cells(4).Value)
                    DGView.Rows(x).Cells(4).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                '0 tanggal
                DGView.Rows(x).Cells(0).Value = DGView.Rows(x).Cells(7).Value & "/" & DGView.Rows(x).Cells(8).Value & "/" & DGView.Rows(x).Cells(9).Value
                x = x + 1
            End While
            Dim i As Integer
            For i = 0 To DGView.Columns.Count - 1
                DGView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
            Next i
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub LoadData(ByVal hal As Integer)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)

            If Me.current_mode_view = "range" Then
                sql = "SELECT id, kode, nama_produk, harga, jumlah, waktu, tanggal, bulan, tahun FROM op_stok_masuk  where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "' order by `id` desc limit " + pg_str + ",10"
                Me.last_sql_for_csv = "Select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_masuk where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "'  order by `id` desc"
                Me.sql_for_print = Me.last_sql_for_csv
                If Me.current_laporan_type = "keluar" Then
                    sql = "Select id, kode, nama_produk, harga, jumlah, waktu, tanggal, bulan, tahun FROM op_stok_keluar  where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "'  order by `id` desc limit " + pg_str + ",10"
                    Me.last_sql_for_csv = "Select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_keluar where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "'  order by `id` desc"
                    Me.sql_for_print = Me.last_sql_for_csv
                End If

            Else
                sql = "SELECT id, kode, nama_produk, harga, jumlah, waktu, tanggal, bulan, tahun FROM op_stok_masuk order by `id` desc limit " + pg_str + ",10"
                Me.last_sql_for_csv = "Select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_masuk order by `id` desc limit 0,300"
                Me.sql_for_print = Me.last_sql_for_csv
                If Me.current_laporan_type = "keluar" Then
                    sql = "Select id, kode, nama_produk, harga, jumlah, waktu, tanggal, bulan, tahun FROM op_stok_keluar order by `id` desc limit " + pg_str + ",10"
                    Me.last_sql_for_csv = "Select full_date,kode,nama_produk, harga, jumlah, waktu FROM op_stok_keluar order by `id` desc limit 0,300"
                    Me.sql_for_print = Me.last_sql_for_csv
                End If
            End If
            'Me.last_sql_for_csv = sql
            datatable_mysql = data_obj.load_data_for_datagrid(sql)
            DGView.DataSource = datatable_mysql
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()
            x = 0
            While x < DGView.RowCount
                '5 jumlah
                If Len(DGView.Rows(x).Cells(5).Value) > 0 Then
                    DGView.Rows(x).Cells(5).Value = data_obj.format_num(DGView.Rows(x).Cells(5).Value)
                    DGView.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                '4 harga
                If Len(DGView.Rows(x).Cells(4).Value) > 0 Then
                    DGView.Rows(x).Cells(4).Value = data_obj.format_num(DGView.Rows(x).Cells(4).Value)
                    DGView.Rows(x).Cells(4).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                '0 tanggal
                DGView.Rows(x).Cells(0).Value = DGView.Rows(x).Cells(7).Value & "/" & DGView.Rows(x).Cells(8).Value & "/" & DGView.Rows(x).Cells(9).Value
                x = x + 1
            End While
            Dim i As Integer
            For i = 0 To DGView.Columns.Count - 1
                DGView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
            Next i
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_cari_Click(sender As Object, e As EventArgs) Handles tombol_cari.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.current_mode_view = "range"
            Me.page = 1
            Call prepare_data_pelengkap()
            Call LoadData(Me.page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_print_preview_Click(sender As Object, e As EventArgs) Handles tombol_print_preview.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim jumlah_maks_data = Val(jum_print.Text.Trim())
            If jumlah_maks_data < 1 Then
                jumlah_maks_data = 300
            End If
            If Me.current_laporan_type = "masuk" Then
                form_print_prepare.current_file = "laporan_stok_masuk_preview.html"
            Else
                form_print_prepare.current_file = "laporan_stok_keluar_preview.html"
            End If
            print_generator.create_dokumen_print_laporan_stok(Me.sql_for_print, jumlah_maks_data, "preview", Me.current_laporan_type)
            form_print_prepare.Show()
            basic_op.setfokus(form_print_prepare)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_print_Click(sender As Object, e As EventArgs) Handles tombol_print.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim jumlah_maks_data = Val(jum_print.Text.Trim())
            If jumlah_maks_data < 1 Then
                jumlah_maks_data = 300
            End If
            If Me.current_laporan_type = "masuk" Then
                form_print.current_file = "laporan_stok_masuk_print.html"
            Else
                form_print.current_file = "laporan_stok_keluar_print.html"
            End If
            print_generator.create_dokumen_print_laporan_stok(Me.sql_for_print, jumlah_maks_data, "print", Me.current_laporan_type)
            form_print.Show()
            basic_op.setfokus(form_print)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class