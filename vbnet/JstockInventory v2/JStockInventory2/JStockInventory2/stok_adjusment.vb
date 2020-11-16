Imports MySql.Data.MySqlClient
Imports System.Math
Public Class stok_adjusment
    Public print_generator As New print_generator
    Public Property sql_for_print As String
    Public data_obj As New data_object
    Public datatable_mysql = New DataTable
    Public basic_op As New basic_op
    Public Property saved_data As Integer
    Public Property page As Integer
    Public Property total_data As Integer
    Public Property max_page As Integer
    Public Property tgl_skrg As String
    Public Property mode_input As String
    Public Property kode_prod As String
    Public Property nama_prod As String
    Public Property panjang_minimal_kode_barang As Integer
    Public Property panjang_minimal_nama_barang As Integer
    Public Property load_new_data As Integer

    Private Sub tombol_csv_Click(sender As Object, e As EventArgs) Handles tombol_csv.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            form_csv.additional_mark = ""
            form_csv.nama_tabel = "op_stok_adjustment"
            form_csv.Show()
            basic_op.setfokus(form_csv)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub



    Private Sub tombol_simpan_Click(sender As Object, e As EventArgs) Handles tombol_simpan.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If text_id.Text <> "" Then
                Me.mode_input = "update"
            Else
                Me.mode_input = "insert"
            End If

            If Len(text_kode.Text) < 1 Then
                MsgBox("kode barang harus diisi")
            ElseIf Len(text_nama_produk.Text) < 1 Then
                MsgBox("nama produk harus diisi")
            ElseIf Len(text_qty_adjustment.Text) < 1 Then
                MsgBox("jumlah penyesuaian stok harus diisi")
            ElseIf Len(text_qty_sekarang.Text) < 1 Then
                MsgBox("jumlah qty sekarang harus diisi")
            Else

                Dim ret = 0
                Dim ret_adjust = 0
                Dim no_adjustment_str = text_no_adjustment.Text
                Dim kode_str = text_kode.Text
                Dim nama_barang_str = text_nama_produk.Text
                Dim gudang_str = combo_gudang.Text
                Dim jenis_adjustment_str = combo_jenis_adjustment.Text
                Dim qty_sekarang_str = text_qty_sekarang.Text.Replace(",", "")
                Dim qty_fisik_str = text_qty_fisik.Text.Replace(",", "")
                Dim qty_adjustment_str = text_qty_adjustment.Text.Replace(",", "").Replace("+", "")
                Dim keterangan_str = text_keterangan.Text
                Dim id_str = text_id.Text
                Dim full_tgl = DateTimePicker_tanggal.Text
                Dim tanggal_str As String
                Dim bulan_str As String
                Dim tahun_str As String

                tanggal_str = basic_op.parse_tgl(full_tgl, "tanggal")
                bulan_str = basic_op.parse_tgl(full_tgl, "bulan")
                tahun_str = basic_op.parse_tgl(full_tgl, "tahun")
                Dim full_date As String
                full_date = basic_op.return_mysql_date_format_from_raw(tanggal_str, bulan_str, tahun_str)
                Dim val_adjust = Val(qty_adjustment_str)
                Dim val_qty_sekarang = Val(qty_sekarang_str)
                Dim val_new As Integer
                val_new = val_qty_sekarang + (val_adjust)
                Dim sql = ""
                If Me.mode_input = "insert" Then
                    sql = "INSERT INTO `op_stok_adjustment` (`id`, `no_adjustment`, `tanggal`, `kode`, `nama_barang`, `gudang`, `jenis_adjustment`, `qty_fisik`, `qty_adjustment`, `keterangan`,`bulan`, `tahun`,`full_date`) VALUES (NULL, '" + no_adjustment_str + "', '" + tanggal_str + "', '" + kode_str + "', '" + nama_barang_str + "', '" + gudang_str + "', '" + jenis_adjustment_str + "', '" + qty_fisik_str + "', '" + qty_adjustment_str + "', '" + keterangan_str + "', '" + bulan_str + "', '" + tahun_str + "','" + full_date + "');"
                Else
                    sql = "update `op_stok_adjustment` set `no_adjustment` = '" + no_adjustment_str + "', `tanggal` = '" + tanggal_str + "', `bulan` = '" + bulan_str + "', `tahun` = '" + tahun_str + "',  `jenis_adjustment` = '" + jenis_adjustment_str + "', `qty_fisik` = '" + qty_fisik_str + "',`qty_adjustment` ='" + qty_adjustment_str + "', `keterangan` = '" + keterangan_str + "',`full_date` = '" + full_date + "' where `id` like '" + id_str + "'"
                End If
                ret = data_obj.mysql_just_exec(sql)
                Dim sql_adjust = "update `op_stok` set `stok` = '" & val_new.ToString & "' where `kode` like '" & kode_str & "'"
                ret_adjust = data_obj.mysql_just_exec(sql_adjust)
                If ret = 1 Then
                    Me.saved_data = 1
                    Console.Beep(4000, 100)
                Else
                    MsgBox("data gagal disimpan")
                End If
            End If
            Call clear_data()
            Me.mode_input = ""
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub button_clear_data_Click(sender As Object, e As EventArgs) Handles button_clear_data.Click
        Call clear_data()
    End Sub


    Private Sub button_prev_Click(sender As Object, e As EventArgs) Handles button_prev.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page > 1 Then
                Me.page = Me.page - 1
                Call loaddata(Me.page)
                button_next.Enabled = 1
                Call select_combo_item()
            Else
                button_prev.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub


    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page < Me.max_page Then
                Me.page = Me.page + 1
                Call loaddata(Me.page)
                button_prev.Enabled = 1
                Call select_combo_item()
            Else
                button_next.Enabled = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

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
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
    Public Sub prepare_data_pelengkap()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.total_data = data_obj.get_total_rows("op_stok_adjustment")
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
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub clear_data()
        text_no_adjustment.Text = ""
        text_kode.Text = ""
        text_nama_produk.Text = ""
        combo_gudang.SelectedIndex = 0
        combo_jenis_adjustment.SelectedIndex = 0
        text_qty_sekarang.Text = ""
        text_qty_fisik.Text = ""
        text_qty_adjustment.Text = ""
        text_keterangan.Text = ""
        text_id.Text = ""
    End Sub
    Private Sub tombol_add_Click(sender As Object, e As EventArgs) Handles tombol_add.Click
        Call clear_data()
        Me.mode_input = "add"
    End Sub

    Private Sub tombol_home_Click(sender As Object, e As EventArgs) Handles tombol_home.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page = 1
            Call loaddata(page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub load_data_combobox()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim datareader_mysql_master_gudang As MySqlDataReader
        Try
            data_obj.cmd_mysql_ret_data_master_gudang_for_combobox.Dispose()
            data_obj.con_mysql_ret_data_master_gudang_for_combobox.Close()
            datareader_mysql_master_gudang = data_obj.ret_data_master_gudang_for_combobox()
            combo_gudang.Items.Add("Pilih Gudang")
            While datareader_mysql_master_gudang.Read()
                combo_gudang.Items.Add(datareader_mysql_master_gudang.Item(0).Trim())
            End While
            datareader_mysql_master_gudang.Dispose()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

        If combo_gudang.Items.Count > 0 Then
            combo_gudang.SelectedIndex = 0
        End If
    End Sub


    Public Sub selected_view(e As DataGridViewCellEventArgs)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim iDate As String
        Dim idate_dirty As String
        Try
            If (e.RowIndex >= 0) And (Len(DGView.CurrentCell.Value.ToString) > 0) Then
                Dim row As DataGridViewRow
                row = Me.DGView.Rows(e.RowIndex)
                Try
                    If Len(row.Cells("tanggal").Value.ToString) > 0 Then
                        idate_dirty = row.Cells("tanggal").Value.ToString
                        iDate = basic_op.convert_to_tanggalan_bule(idate_dirty)
                        DateTimePicker_tanggal.Text = iDate
                    Else
                        iDate = basic_op.waktu("tanggal_bule")
                        DateTimePicker_tanggal.Text = iDate
                    End If
                Catch ex As Exception
                    iDate = basic_op.waktu("tanggal_bule")
                    DateTimePicker_tanggal.Text = iDate
                End Try
                If row.Cells("id").Value.ToString <> "" Then
                    Try
                        text_id.Text = row.Cells("id").Value.ToString
                        text_no_adjustment.Text = row.Cells("no_adjustment").Value.ToString
                        text_kode.Text = row.Cells("kode").Value.ToString
                        text_nama_produk.Text = row.Cells("nama_barang").Value.ToString
                        Dim kode As String
                        kode = text_kode.Text
                        Dim qty_sekarang = data_obj.ret_colval_string_from_colval("op_stok", "kode", kode, "stok")
                        text_qty_sekarang.Text = qty_sekarang
                        combo_gudang.SelectedIndex = combo_gudang.FindStringExact(row.Cells("gudang").Value.ToString)
                        combo_jenis_adjustment.SelectedIndex = combo_jenis_adjustment.FindStringExact(row.Cells("jenis_adjustment").Value.ToString)
                        text_qty_fisik.Text = row.Cells("qty_fisik").Value.ToString
                        text_qty_adjustment.Text = row.Cells("qty_adjustment").Value.ToString
                        text_keterangan.Text = row.Cells("keterangan").Value.ToString
                    Catch ex As Exception
                        Console.WriteLine("selected_view error at load data to textboxes")
                        Console.WriteLine(ex.ToString)
                    End Try

                End If

            End If
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


    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If text_id.Text <> "" Then
                Dim hapus = basic_op.konfirmasi_hapus("Apakah data stock adjustment ini akan dihapus ?", "Hapus Data Stock Adjustment")
                If hapus = 1 Then
                    Dim id_str = text_id.Text
                    Dim res = 0
                    res = data_obj.mysql_del("op_stok_adjustment", id_str)
                    If res = 0 Then
                        basic_op.gagal_delete()
                    Else
                        Console.Beep(4000, 100)
                        Me.saved_data = 1
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.saved_data = 1 Then
                Call load_data_combobox()
                combo_jenis_adjustment.SelectedIndex = 0
                Me.saved_data = 0
                Call prepare_data_pelengkap()
                Call loaddata(Me.page)
            End If
            'If Me.load_new_data = 1 Then
            'auto_fill_data()
            'Me.load_new_data = 0
            'End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_cari_Click(sender As Object, e As EventArgs) Handles tombol_cari.Click
        prepare_data_pelengkap_pencarian()
        load_pencarian(Me.page)
    End Sub

    Public Sub prepare_data_pelengkap_pencarian()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.total_data = data_obj.get_total_rows_between("op_stok_adjustment", "tanggal", DateTimePicker_dari.Text, DateTimePicker_hingga.Text)
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



    Private Overloads Sub text_nama_produk_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_nama_produk.KeyDown
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_nama_produk.Text) > 1 Then
                If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Me.nama_prod = text_nama_produk.Text.Trim()
                    Me.kode_prod = ""
                    auto_fill_data()
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Overloads Sub text_kode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_kode.KeyDown
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_kode.Text) > 1 Then
                If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Me.kode_prod = text_kode.Text.Trim()
                    Me.nama_prod = ""
                    auto_fill_data()
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Sub get_cfg_app()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim datareader_mysql_local As MySqlDataReader
            datareader_mysql_local = data_obj.get_cfg_app()
            If datareader_mysql_local.Read() Then
                panjang_minimal_kode_barang = datareader_mysql_local(1).ToString()
                panjang_minimal_nama_barang = datareader_mysql_local(2).ToString()
                datareader_mysql_local.Dispose()
                data_obj.con_mysql_load_single_data_from_table.Close()
                data_obj.cmd_mysql_load_single_data_from_table.Dispose()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub stok_adjusment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            get_cfg_app()
            Dim tgl_bule As String
            'Dim tgl_from As String
            'Dim tgl_to As String
            Dim array_parse() As String
            Dim hari As Integer
            Dim hari_from As Integer
            Dim hari_to As Integer
            Dim hari_from_str As String
            Dim hari_to_str As String
            Dim bulan_str As String
            Dim tahun_str As String
            Me.load_new_data = 0

            Call load_data_combobox()
            combo_jenis_adjustment.SelectedIndex = 0
            Me.saved_data = 0
            Me.page = 1
            Call prepare_data_pelengkap()
            Call loaddata(Me.page)

            'MM/dd/YYY
            tgl_bule = basic_op.waktu("tanggal_bule")
            array_parse = tgl_bule.Split("/")
            hari = Val(array_parse(1))
            bulan_str = array_parse(0)
            tahun_str = array_parse(2)
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

            ' fill datepicker from
            'DateTimePicker_dari
            DateTimePicker_dari.Text = bulan_str & "/" & hari_from_str & "/" & tahun_str

            ' fill datepicker until
            'DateTimePicker_hingga
            DateTimePicker_hingga.Text = bulan_str & "/" & hari_to_str & "/" & tahun_str

            'autocomplete
            Call autocomplete_text_kode()
            Call autocomplete_text_nama_produk()

            auto_fill_data()

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub autocomplete_text_kode()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim data_kode As New AutoCompleteStringCollection()
            Dim datareader_mysql_local As MySqlDataReader
            Dim Sql As String
            Dim readed_data As Integer
            readed_data = 0
            Sql = "select `kode` from `op_stok` order by `kode` asc"
            datareader_mysql_local = data_obj.load_datareader_for_datagrid(Sql)
            While datareader_mysql_local.Read
                readed_data = 1
                data_kode.Add(datareader_mysql_local(0).ToString)
            End While
            If readed_data = 1 Then
                datareader_mysql_local.Dispose()
                data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            End If
            With text_kode
                .AutoCompleteCustomSource = data_kode
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub autocomplete_text_nama_produk()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim data_nama_produk As New AutoCompleteStringCollection()
            Dim datareader_mysql_local As MySqlDataReader
            Dim Sql As String
            Dim readed_data As Integer
            readed_data = 0
            Sql = "select `nama_produk` from `op_stok` order by `nama_produk` asc"
            datareader_mysql_local = data_obj.load_datareader_for_datagrid(Sql)
            While datareader_mysql_local.Read
                readed_data = 1
                data_nama_produk.Add(datareader_mysql_local(0).ToString)
            End While
            If readed_data = 1 Then
                datareader_mysql_local.Dispose()
                data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            End If
            With text_nama_produk
                .AutoCompleteCustomSource = data_nama_produk
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub auto_fill_data()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try

            If Len(Me.kode_prod) >= panjang_minimal_kode_barang Then
                Dim qty_sekarang = data_obj.ret_colval_string_from_colval("op_stok", "kode", Me.kode_prod, "stok")
                text_qty_sekarang.Text = qty_sekarang

                Dim nama_produk = data_obj.ret_colval_string_from_colval("op_stok", "kode", Me.kode_prod, "nama_produk")
                text_nama_produk.Text = nama_produk

                Dim id_gudang = data_obj.ret_colval_string_from_colval("op_stok", "kode", Me.kode_prod, "id_gudang")
                If Len(id_gudang) > 0 Then
                    Dim nama_gudang = data_obj.get_name_from_master_by_id("gudang", id_gudang)
                    combo_gudang.SelectedIndex = combo_gudang.FindStringExact(nama_gudang)
                End If
                If text_kode.Text <> Me.kode_prod Then
                    text_kode.Text = Me.kode_prod
                End If
            ElseIf Len(Me.nama_prod) >= panjang_minimal_nama_barang Then
                Dim qty_sekarang = data_obj.ret_colval_string_from_colval("op_stok", "nama_produk", Me.nama_prod, "stok")
                text_qty_sekarang.Text = qty_sekarang

                Dim kode_produk = data_obj.ret_colval_string_from_colval("op_stok", "nama_produk", Me.nama_prod, "kode")
                text_kode.Text = kode_produk

                Dim id_gudang = data_obj.ret_colval_string_from_colval("op_stok", "nama_produk", Me.nama_prod, "id_gudang")
                If Len(id_gudang) > 0 Then
                    Dim nama_gudang = data_obj.get_name_from_master_by_id("gudang", id_gudang)
                    combo_gudang.SelectedIndex = combo_gudang.FindStringExact(nama_gudang)
                End If
                If text_nama_produk.Text <> Me.nama_prod Then
                    text_nama_produk.Text = Me.nama_prod
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Sub load_pencarian(ByVal hal As Integer)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)
            sql = "SELECT id,no_adjustment,kode,nama_barang,qty_fisik,qty_adjustment,gudang,jenis_adjustment,keterangan, tanggal,bulan, tahun FROM op_stok_adjustment  where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "' order by `id` desc limit " + pg_str + ",10"
            Me.sql_for_print = "SELECT full_date,no_adjustment,kode,nama_barang,qty_fisik,qty_adjustment,gudang,jenis_adjustment,keterangan FROM op_stok_adjustment  where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "' order by `id` desc limit " + pg_str + ",10"
            datatable_mysql = data_obj.load_data_for_datagrid(sql)
            DGView.DataSource = datatable_mysql
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()
            Dim x As Integer
            x = 0
            While x < DGView.RowCount
                'qty fisik
                If Len(DGView.Rows(x).Cells(5).Value) > 0 Then
                    DGView.Rows(x).Cells(5).Value = data_obj.format_num(DGView.Rows(x).Cells(5).Value)
                    DGView.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                'qty adj
                If Len(DGView.Rows(x).Cells(6).Value) > 0 Then
                    DGView.Rows(x).Cells(6).Value = data_obj.format_num(DGView.Rows(x).Cells(6).Value)
                    DGView.Rows(x).Cells(6).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                'full tgl
                Dim full_tgl As String
                full_tgl = ""
                If (Len(DGView.Rows(x).Cells(10).Value) > 0) And (Len(DGView.Rows(x).Cells(11).Value) > 0) And Len(DGView.Rows(x).Cells(12).Value) > 0 Then
                    full_tgl = DGView.Rows(x).Cells(10).Value & "/" & DGView.Rows(x).Cells(11).Value & "/" & DGView.Rows(x).Cells(12).Value
                    DGView.Rows(x).Cells(0).Value = full_tgl
                End If
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
        Call clear_data()
    End Sub
    Public Sub loaddata(ByVal hal As Integer)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_tgl As String
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            sql = "SELECT id,no_adjustment,kode,nama_barang,qty_fisik,qty_adjustment,gudang,jenis_adjustment,keterangan, tanggal,bulan, tahun FROM op_stok_adjustment  order by `id` desc limit " + pg_str + ",10"
            Me.sql_for_print = "SELECT full_date,no_adjustment,kode,nama_barang,qty_fisik,qty_adjustment,gudang,jenis_adjustment,keterangan FROM op_stok_adjustment  order by `id` desc limit " + pg_str + ",10"
            datatable_mysql = data_obj.load_data_for_datagrid(sql)
            DGView.DataSource = datatable_mysql
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()
            Dim x As Integer
            x = 0
            While x < DGView.RowCount
                'qty fisik
                If Len(DGView.Rows(x).Cells(5).Value) > 0 Then
                    DGView.Rows(x).Cells(5).Value = data_obj.format_num(DGView.Rows(x).Cells(5).Value)
                    DGView.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                'qty adj
                If Len(DGView.Rows(x).Cells(6).Value) > 0 Then
                    DGView.Rows(x).Cells(6).Value = data_obj.format_num(DGView.Rows(x).Cells(6).Value)
                    DGView.Rows(x).Cells(6).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                'full tgl
                full_tgl = ""
                If (Len(DGView.Rows(x).Cells(10).Value) > 0) And (Len(DGView.Rows(x).Cells(11).Value) > 0) And Len(DGView.Rows(x).Cells(12).Value) > 0 Then
                    full_tgl = DGView.Rows(x).Cells(10).Value & "/" & DGView.Rows(x).Cells(11).Value & "/" & DGView.Rows(x).Cells(12).Value
                    DGView.Rows(x).Cells(0).Value = full_tgl
                End If
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
        Call clear_data()
    End Sub

    Private Sub tombol_print_preview_Click(sender As Object, e As EventArgs) Handles tombol_print_preview.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim jumlah_maks_data = Val(jum_print.Text.Trim())
            If jumlah_maks_data < 1 Then
                jumlah_maks_data = 300
            End If
            form_print_prepare.current_file = "stok_adjustment_preview.html"
            'create_dokumen_print_stok_adjustment(ByVal sql As String, ByVal jumlah_maks_data As Integer, ByVal mode As String)
            print_generator.create_dokumen_print_stok_adjustment(Me.sql_for_print, jumlah_maks_data, "preview")
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
            form_print.current_file = "stok_adjustment_print.html"
            print_generator.create_dokumen_print_stok_adjustment(Me.sql_for_print, jumlah_maks_data, "print")
            form_print.Show()
            basic_op.setfokus(form_print)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub tombol_delete_all_Click(sender As Object, e As EventArgs) Handles tombol_delete_all.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah Anda yakin untuk menghapus seluruh data stock adjustment ?", "Hapus Data Seluruh Stock Adjustment")
            If hapus = 1 Then
                form_delete_all.table_name = "op_stok_adjustment"
                form_delete_all.Show()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class