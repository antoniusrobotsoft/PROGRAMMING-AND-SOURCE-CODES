Imports MySql.Data.MySqlClient
Imports System.Math
Imports System
Imports System.Text
Imports System.Environment

Public Class stok_masuk
    Public Property current_autofill As String
    Public Property do_load_data As Integer
    Public Property do_autofill As Integer
    Public Property saved_data As Integer

    Public data_obj As New data_object
    Public datatable_mysql = New DataTable
    Public basic_op As New basic_op
    Public Property page As Integer
    Public Property total_data As Integer
    Public Property max_page As Integer
    Public Property default_pic = "default.jpg"
    Public Property new_imgprod_name As String
    Public saved_new_imgprod As Integer


    Public datareader_mysql_generic As MySqlDataReader


    Public datareader_mysql_selectgrid As MySqlDataReader
    Public Property panjang_minimal_kode_barang As Integer
    Public Property panjang_minimal_nama_barang As Integer
    Public Sub LoadDataPencarian(ByVal kunci As String, ByVal nama_kolom As String, ByVal nama_tabel As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try

            Dim sql As String
            Dim id As String
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
            Dim i As Integer
            Dim datareader_mysql_datagrid As MySqlDataReader
            merek = ""
            gudang = ""
            kategori = ""
            do_load_data = 0

            sql = "SELECT id,kode, nama_produk, id_merek, id_kategori, harga, stok, id_gudang FROM " + nama_tabel + " where (" + nama_kolom + " like '" + kunci + "' or " + nama_kolom + " like '" + kunci + "%' or " + nama_kolom + " like '%" + kunci + "' or " + nama_kolom + " like '%" + kunci + "%') "

            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()

            datareader_mysql_datagrid = data_obj.load_datareader_for_datagrid(sql)
            Dim x As Integer
            x = 0

            While datareader_mysql_datagrid.Read()
                id = datareader_mysql_datagrid(0).ToString().Trim()
                kode = datareader_mysql_datagrid(1).ToString().Trim()
                nama_produk = datareader_mysql_datagrid(2).ToString().Trim()
                id_merek = datareader_mysql_datagrid(3).ToString().Trim()
                id_kategori = datareader_mysql_datagrid(4).ToString().Trim()
                harga = datareader_mysql_datagrid(5).ToString().Trim()
                stok = datareader_mysql_datagrid(6).ToString().Trim()
                id_gudang = datareader_mysql_datagrid(7).ToString().Trim()

                merek = data_obj.get_name_from_master_by_id("merek", id_merek).ToString
                kategori = data_obj.get_name_from_master_by_id("kategori", id_kategori).ToString
                gudang = data_obj.get_name_from_master_by_id("gudang", id_gudang).ToString

                harga = data_obj.format_num(harga)
                stok = data_obj.format_num(stok)


                DGView.Rows(x).Cells(0).Value = id
                DGView.Rows(x).Cells(1).Value = kode
                DGView.Rows(x).Cells(2).Value = nama_produk
                DGView.Rows(x).Cells(3).Value = merek
                DGView.Rows(x).Cells(4).Value = kategori
                DGView.Rows(x).Cells(5).Value = harga
                DGView.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight

                DGView.Rows(x).Cells(6).Value = stok
                DGView.Rows(x).Cells(6).Style.Alignment = DataGridViewContentAlignment.TopRight

                DGView.Rows(x).Cells(7).Value = gudang
                x = x + 1
            End While
            If x < 9 Then
                For i = x To 9
                    DGView.Rows(i).Cells(0).Value = ""
                    DGView.Rows(i).Cells(1).Value = ""
                    DGView.Rows(i).Cells(2).Value = ""
                    DGView.Rows(i).Cells(3).Value = ""
                    DGView.Rows(i).Cells(4).Value = ""
                    DGView.Rows(i).Cells(5).Value = ""
                    DGView.Rows(i).Cells(6).Value = ""
                    DGView.Rows(i).Cells(7).Value = ""
                Next
            End If
            Dim z As Integer
            For z = 0 To DGView.Columns.Count - 1
                DGView.Columns.Item(z).SortMode = DataGridViewColumnSortMode.Programmatic
            Next z
            datareader_mysql_datagrid.Dispose()
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Sub set_init_dgview()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim i As Integer
            Dim total As Integer
            total = 10
            For i = 1 To total
                DGView.Rows.Add()
            Next
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
                Dim gambar As String
                Dim id As String
                Dim merek As String
                Dim kategori As String
                Dim gudang As String
                gambar = Me.default_pic
                merek = row.Cells("merek").Value.ToString.Trim
                kategori = row.Cells("kategori").Value.ToString.Trim
                gudang = row.Cells("gudang").Value.ToString.Trim
                text_id.Text = row.Cells("id").Value.ToString.Trim
                id = row.Cells("id").Value.ToString.Trim
                text_kode.Text = row.Cells("kode").Value.ToString.Trim
                text_nama_produk.Text = row.Cells("nama_produk").Value.ToString.Trim
                text_harga.Text = row.Cells("harga").Value.ToString.Trim

                'MsgBox(merek)
                combo_id_merek.SelectedIndex = combo_id_merek.FindStringExact(merek)
                'MsgBox(kategori)
                combo_id_kategori.SelectedIndex = combo_id_kategori.FindStringExact(kategori)
                combo_id_gudang.SelectedIndex = combo_id_gudang.FindStringExact(gudang)
                data_obj.cmd_mysql_ret_colval_from_colval.Dispose()
                data_obj.con_mysql_ret_colval_from_colval.Close()
                datareader_mysql_selectgrid = data_obj.ret_colval_from_colval("op_stok", "id", id, "gambar")

                Try
                    If datareader_mysql_selectgrid.Read Then
                        gambar = datareader_mysql_selectgrid(0).ToString.Trim
                    End If
                Catch ex As Exception
                    If data_obj.con_mysql.State = ConnectionState.Closed Then
                        data_obj.mysql_connect()
                    End If
                    datareader_mysql_selectgrid = data_obj.ret_colval_from_colval("op_stok", "id", id, "gambar")
                    If datareader_mysql_selectgrid.Read Then
                        gambar = datareader_mysql_selectgrid(0).ToString.Trim
                        datareader_mysql_selectgrid.Dispose()
                    End If
                End Try

                If gambar = "" Then
                    gambar = Me.default_pic
                End If
                data_obj.loadimg(Me.PictureBox1, "thumb_" + gambar)


            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub DGView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView.CellClick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            do_load_data = 0
            do_autofill = 1
            selected_view(e)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub DGView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView.CellContentClick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            do_load_data = 0
            do_autofill = 1
            selected_view(e)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Sub LoadData(ByVal hal As Integer)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If do_load_data = 0 Then
                Exit Sub
            End If
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            Dim id As String
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
            Dim i As Integer
            merek = ""
            gudang = ""
            kategori = ""
            Dim datareader_mysql_datagrid As MySqlDataReader
            sql = "SELECT  id,kode, nama_produk, id_merek, id_kategori, harga, stok, id_gudang FROM op_stok order by `id` desc limit " + pg_str + ",10"
            Try
                datareader_mysql_datagrid = data_obj.load_datareader_for_datagrid(sql)
            Catch ex As Exception
                data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
                data_obj.con_mysql_load_datareader_for_datagrid.Close()
                datareader_mysql_datagrid = data_obj.load_datareader_for_datagrid(sql)
            End Try

            'datatable_mysql = data_obj.load_data_for_datagrid(sql)
            'DGView.DataSource = datatable_mysql
            Dim x As Integer
            x = 0
            While datareader_mysql_datagrid.Read()
                id = datareader_mysql_datagrid(0).ToString()
                kode = datareader_mysql_datagrid(1).ToString()
                nama_produk = datareader_mysql_datagrid(2).ToString()
                id_merek = datareader_mysql_datagrid(3).ToString()
                id_kategori = datareader_mysql_datagrid(4).ToString()
                harga = datareader_mysql_datagrid(5).ToString()
                stok = datareader_mysql_datagrid(6).ToString()

                harga = data_obj.format_num(harga)
                stok = data_obj.format_num(stok)

                id_gudang = datareader_mysql_datagrid(7).ToString()

                merek = data_obj.get_name_from_master_by_id("merek", id_merek)
                kategori = data_obj.get_name_from_master_by_id("kategori", id_kategori)
                gudang = data_obj.get_name_from_master_by_id("gudang", id_gudang)


                DGView.Rows(x).Cells(0).Value = id
                DGView.Rows(x).Cells(1).Value = kode
                DGView.Rows(x).Cells(2).Value = nama_produk
                DGView.Rows(x).Cells(3).Value = merek
                DGView.Rows(x).Cells(4).Value = kategori
                DGView.Rows(x).Cells(5).Value = harga
                DGView.Rows(x).Cells(5).Style.Alignment = DataGridViewContentAlignment.TopRight

                DGView.Rows(x).Cells(6).Value = stok
                DGView.Rows(x).Cells(6).Style.Alignment = DataGridViewContentAlignment.TopRight

                DGView.Rows(x).Cells(7).Value = gudang
                x = x + 1
            End While
            If x < 9 Then
                For i = x To 9
                    DGView.Rows(i).Cells(0).Value = ""
                    DGView.Rows(i).Cells(1).Value = ""
                    DGView.Rows(i).Cells(2).Value = ""
                    DGView.Rows(i).Cells(3).Value = ""
                    DGView.Rows(i).Cells(4).Value = ""
                    DGView.Rows(i).Cells(5).Value = ""
                    DGView.Rows(i).Cells(6).Value = ""
                    DGView.Rows(i).Cells(7).Value = ""
                Next
            End If
            Dim Z As Integer
            For Z = 0 To DGView.Columns.Count - 1
                DGView.Columns.Item(Z).SortMode = DataGridViewColumnSortMode.Programmatic
            Next Z
            datareader_mysql_datagrid.Dispose()
            data_obj.cmd_mysql_load_datareader_for_datagrid.Dispose()
            data_obj.con_mysql_load_datareader_for_datagrid.Close()
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub load_data_combobox()
        Dim datareader_mysql_master_merek As MySqlDataReader
        Dim datareader_mysql_master_kategori As MySqlDataReader
        Dim datareader_mysql_master_gudang As MySqlDataReader
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            data_obj.cmd_mysql_ret_data_master_gudang_for_combobox.Dispose()
            data_obj.con_mysql_ret_data_master_gudang_for_combobox.Close()
            datareader_mysql_master_gudang = data_obj.ret_data_master_gudang_for_combobox()

            data_obj.cmd_mysql_ret_data_master_merek_for_combobox.Dispose()
            data_obj.con_mysql_ret_data_master_merek_for_combobox.Close()
            datareader_mysql_master_merek = data_obj.ret_data_master_merek_for_combobox()

            data_obj.cmd_mysql_ret_data_master_kategori_for_combobox.Dispose()
            data_obj.con_mysql_ret_data_master_kategori_for_combobox.Close()
            datareader_mysql_master_kategori = data_obj.ret_data_master_kategori_for_combobox()


            combo_id_gudang.Items.Add("Pilih Gudang")
            While datareader_mysql_master_gudang.Read()
                combo_id_gudang.Items.Add(datareader_mysql_master_gudang.Item(0).Trim())
            End While

            combo_id_merek.Items.Add("Pilih Merek")
            combo_merek.Items.Add("Pilih Merek")
            While datareader_mysql_master_merek.Read()
                combo_id_merek.Items.Add(datareader_mysql_master_merek.Item(0).Trim())
                combo_merek.Items.Add(datareader_mysql_master_merek.Item(0).Trim())
            End While

            combo_id_kategori.Items.Add("Pilih Kategori")
            While datareader_mysql_master_kategori.Read()
                combo_id_kategori.Items.Add(datareader_mysql_master_kategori.Item(0).Trim())
            End While
            datareader_mysql_master_kategori.Dispose()


        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try


        If combo_id_kategori.Items.Count > 0 Then
            combo_id_kategori.SelectedIndex = 0
        End If
        If combo_id_merek.Items.Count > 0 Then
            combo_id_merek.SelectedIndex = 0
        End If
        If combo_id_gudang.Items.Count > 0 Then
            combo_id_gudang.SelectedIndex = 0
        End If
    End Sub


    Private Sub button_prev_Click(sender As Object, e As EventArgs) Handles button_prev.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            do_load_data = 1
            If Me.page > 1 Then
                Me.page = Me.page - 1
                Call LoadData(Me.page)
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
            do_load_data = 1
            If Me.page < Me.max_page Then
                Me.page = Me.page + 1
                Call LoadData(Me.page)
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
    Private Sub stok_masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            do_autofill = 1
            Call set_init_dgview()
            combo_pembelian.SelectedIndex = 0
            If data_obj.con_mysql.State = ConnectionState.Closed Then
                data_obj.mysql_connect()
            End If

            data_obj.img_cat = "produk"
            Me.saved_new_imgprod = 0
            Me.new_imgprod_name = "default.jpg"
            basic_op.jstock_read_config()
            Me.page = 1
            do_load_data = 1
            Call prepare_data_pelengkap()
            data_obj.loadimg(Me.PictureBox1, "thumb_" + Me.default_pic)

            'Call LoadData(page)
            load_data_combobox()
            datareader_mysql_generic = data_obj.get_cfg_app()
            If datareader_mysql_generic.Read() Then
                panjang_minimal_kode_barang = datareader_mysql_generic(1).ToString()
                panjang_minimal_nama_barang = datareader_mysql_generic(2).ToString()
                datareader_mysql_generic.Dispose()
            End If
            'autocomplete
            Call autocomplete_text_kode()
            Call autocomplete_text_nama_produk()
            combo_masuk_kas.SelectedIndex = 0

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_simpan_Click(sender As Object, e As EventArgs) Handles tombol_simpan.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim datareader_mysql_local As MySqlDataReader
            Dim count_row As Integer
            Dim failure_mark As Integer
            failure_mark = 0

            'start waktu
            Dim waktu = basic_op.waktu("waktu")
            Dim tanggal = basic_op.waktu("tanggal_only")
            Dim bulan = basic_op.waktu("bulan")
            Dim tahun = basic_op.waktu("tahun")
            'eof waktu

            'default behavior is added new data to op_stok
            count_row = 0
            If Len(text_nama_produk.Text) < 1 Then
                MsgBox("nama barang harus diisi !")
            ElseIf Len(text_harga.Text) < 1 Then
                MsgBox("harga satuan harus diisi !")
            ElseIf Len(text_jumlah_masuk.Text) < 1 Then
                MsgBox("jumlah masuk harus diisi !")
            ElseIf Len(text_kode.Text) < panjang_minimal_kode_barang Then
                MsgBox("panjang kode produk minimal adalah " & panjang_minimal_kode_barang)
            ElseIf Len(text_nama_produk.Text) < panjang_minimal_nama_barang Then
                MsgBox("panjang kode produk minimal adalah " & panjang_minimal_nama_barang)
            Else
                Dim sql_str As String
                Dim gambar As String
                Dim id As String
                Dim kode As String
                Dim nama_produk As String
                Dim harga As String
                Dim id_kategori As String
                Dim id_merek As String
                Dim id_gudang As String
                Dim nama_kategori As String
                Dim nama_merek As String
                Dim nama_gudang As String
                Dim stok As String
                Dim stok_int As Integer
                Dim stok_masuk_str As String
                Dim stok_masuk_int As Integer
                Dim new_stok As Integer
                id_kategori = -1
                id_merek = -1
                id_gudang = -1
                kode = ""
                gambar = ""
                nama_produk = ""
                data_obj.cmd_mysql_ret_all_from_colval.Dispose()
                data_obj.con_mysql_ret_all_from_colval.Close()
                datareader_mysql_local = data_obj.ret_all_from_colval("op_stok", "kode", kode)
                If (combo_id_kategori.Text <> "") And (combo_id_kategori.Text <> "Pilih Kategori") Then
                    nama_kategori = combo_id_kategori.Text
                    id_kategori = data_obj.get_id_from_master_by_name("kategori", nama_kategori)
                Else
                    nama_kategori = ""
                End If
                If (combo_id_gudang.Text <> "") And (combo_id_gudang.Text <> "Pilih Gudang") Then
                    nama_gudang = combo_id_gudang.Text
                    id_gudang = data_obj.get_id_from_master_by_name("gudang", nama_gudang)
                Else
                    nama_gudang = ""
                End If
                If (combo_id_merek.Text <> "") And (combo_id_merek.Text <> "Pilih Merek") Then
                    nama_merek = combo_id_merek.Text
                    id_merek = data_obj.get_id_from_master_by_name("merek", nama_merek)
                Else
                    nama_merek = ""
                End If
                If Len(text_kode.Text) > 1 Then
                    kode = text_kode.Text
                End If
                nama_produk = text_nama_produk.Text
                harga = text_harga.Text.Replace(",", "")
                stok_masuk_str = text_jumlah_masuk.Text.Replace(",", "")
                id = text_id.Text
                gambar = Me.new_imgprod_name

                'input data stok baru jika belum ada, jika sudah ada maka update data stok tersebut
                If Len(text_kode.Text) > 1 Then
                    data_obj.cmd_mysql_ret_all_from_colval.Dispose()
                    data_obj.con_mysql_ret_all_from_colval.Close()
                    datareader_mysql_local = data_obj.ret_all_from_colval("op_stok", "kode", kode)
                End If
                If Len(text_nama_produk.Text) > 1 Then
                    data_obj.cmd_mysql_ret_all_from_colval.Dispose()
                    data_obj.con_mysql_ret_all_from_colval.Close()
                    datareader_mysql_local = data_obj.ret_all_from_colval("op_stok", "nama_produk", nama_produk)
                End If

                If datareader_mysql_local.Read() Then
                    stok = datareader_mysql_local(7).ToString
                    If Len(stok) > 0 Then
                        data_obj.cmd_mysql_get_name_from_master_by_id.Dispose()
                        data_obj.con_mysql_get_name_from_master_by_id.Close()
                        If Len(nama_kategori) < 0 Then
                            id_kategori = datareader_mysql_local(1).ToString
                            nama_kategori = data_obj.get_name_from_master_by_id("kategori", id_kategori)
                        End If
                        If Len(nama_merek) < 0 Then
                            id_merek = datareader_mysql_local(2).ToString
                            nama_merek = data_obj.get_name_from_master_by_id("merek", id_merek)
                        End If
                        If Len(nama_gudang) < 0 Then
                            id_gudang = datareader_mysql_local(8).ToString
                            nama_gudang = data_obj.get_name_from_master_by_id("gudang", id_gudang)
                        End If
                        count_row = 1
                    End If
                End If
                If Len(id) < 1 Then
                    count_row = 0
                End If
                If count_row > 0 Then
                    'update already existing data
                    stok = datareader_mysql_local(7).ToString
                    stok_int = Val(stok)
                    stok_masuk_int = Val(stok_masuk_str)
                    new_stok = stok_int + stok_masuk_int
                    Dim ret = 0

                    Dim sql = "update `op_stok` set `id_kategori` = '" + id_kategori + "', `id_merek` = '" + id_merek + "', `kode` = '" + kode + "', `nama_produk` = '" + nama_produk + "', `harga` = '" + harga + "', `stok` = '" + new_stok.ToString() + "', `id_gudang` = '" + id_gudang + "' where `id` like '" + id + "'"
                    ret = data_obj.mysql_just_exec(sql)
                    If ret = 1 Then
                        Console.Beep(4000, 100)
                        Call prepare_data_pelengkap()
                        do_load_data = 1
                        Call LoadData(page)
                    Else
                        failure_mark = 1
                        MsgBox("data gagal disimpan")
                    End If
                Else
                    'insert new data to op_stok
                    sql_str = "INSERT INTO `op_stok` (`id`, `id_kategori`, `id_merek`, `kode`, `gambar`, `nama_produk`, `harga`, `stok`, `id_gudang`) VALUES (NULL, '" + id_kategori + "', '" + id_merek + "', '" + kode + "', '" + gambar + "', '" + nama_produk + "', '" + harga + "', '" + stok_masuk_str + "', '" + id_gudang + "');"
                    Try
                        data_obj.mysql_just_exec(sql_str)
                        Console.Beep(4000, 100)
                        Call prepare_data_pelengkap()
                        do_load_data = 1
                        Call LoadData(page)
                    Catch ex As Exception
                        failure_mark = 1
                        basic_op.gagal_inputdb()
                    End Try
                End If
                If failure_mark = 0 Then
                    Dim sql_master_kas As String
                    Dim sql_op_histori_kas As String
                    Dim sql_op_histori_kas_flow As String
                    Dim angka_perubahan_str As String
                    angka_perubahan_str = teks_subtotal.Text.Replace(",", "").Replace(".", "")

                    'simpan data ke table pembelian
                    Dim mark As String
                    mark = ""
                    If combo_pembelian.Text = "ya" Then
                        mark = "pembelian"
                    End If
                    Dim full_date As String
                    Dim tgl_only = basic_op.waktu("tanggal_only")
                    full_date = basic_op.return_mysql_date_format_from_raw(tgl_only, bulan, tahun)

                    Dim sql_pembelian = "INSERT INTO `op_stok_masuk` (`id`, `kode`, `nama_produk`, `harga`, `jumlah`, `waktu`, `tanggal`, `bulan`, `tahun`,`mark`,`full_date`) VALUES (NULL, '" + kode + "', '" + nama_produk + "', '" + harga + "', '" + stok_masuk_str + "', '" + waktu + "', '" + tanggal + "', '" + bulan + "', '" + tahun + "', '" + mark + "', '" + full_date + "');"
                    data_obj.mysql_just_exec(sql_pembelian)


                    If combo_masuk_kas.Text = "ya" Then
                        Dim jumlah_kas_baru As String
                        Dim jumlah_kas_baru_int As Integer
                        jumlah_kas_baru_int = 0
                        Dim aktivitas_kas = "pengeluaran"
                        Dim jumlah_kas_awal = data_obj.ret_colval_without_condition("master_kas", "jumlah_kas")

                        jumlah_kas_baru_int = Val(jumlah_kas_awal) - Val(teks_subtotal.Text.Replace(",", "").Replace(".", ""))

                        If jumlah_kas_baru_int > 0 Then
                            jumlah_kas_baru = jumlah_kas_baru_int.ToString
                        Else
                            jumlah_kas_baru = jumlah_kas_awal
                        End If


                        sql_master_kas = "update `master_kas` set `jumlah_kas` = '" + jumlah_kas_baru + "', `update_date` = '" + full_date + "'"
                        data_obj.mysql_just_exec(sql_master_kas)

                        Dim id_pembelian_atau_penjualan = data_obj.ret_colval_string_from_colval("op_stok_masuk", "mark", "pembelian", "id")

                        sql_op_histori_kas = "INSERT INTO `op_histori_kas` (`id`, `jumlah_kas`, `full_date`, `mark`, `id_pembelian_atau_penjualan`) VALUES (NULL, '" + jumlah_kas_baru + "', '" + full_date + "', '" + mark + "', '" + id_pembelian_atau_penjualan + "');"
                        data_obj.mysql_just_exec(sql_op_histori_kas)

                        Dim id_op_histori_kas As String
                        id_op_histori_kas = data_obj.ret_colval_without_condition("op_histori_kas", "id")

                        sql_op_histori_kas_flow = "INSERT INTO `op_histori_kas_flow` (`id`, `jumlah_kas_masuk_atau_keluar`, `full_date`, `mark`, `id_op_histori_kas`) VALUES (NULL, '" + angka_perubahan_str + "', '" + full_date + "', '" + aktivitas_kas + "', '" + id_op_histori_kas + "');"
                        data_obj.mysql_just_exec(sql_op_histori_kas_flow)
                    End If
                End If
            End If
            text_jumlah_masuk.Text = ""
            text_modus.Text = ""
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub combo_page_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_page.SelectedIndexChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page = combo_page.SelectedItem
            Call LoadData(Me.page)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call image_updater()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call image_updater()
    End Sub

    Public Sub image_updater()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim orig_path As String
            Dim dest_path As String
            Dim app_path As String
            Dim dialog As New OpenFileDialog()
            If DialogResult.OK = dialog.ShowDialog Then
                orig_path = dialog.FileName
                Dim filename As String
                filename = ""
                app_path = basic_op.jstock_read_config()
                filename = basic_op.ret_filename_from_full_path(orig_path)
                dest_path = app_path & "\img\produk\" & filename
                basic_op.copy_file(orig_path, dest_path)

                Dim thumbnail_path = app_path & "\img\produk\thumb_" & filename
                basic_op.CreateThumbnail(150, dest_path, thumbnail_path)


                Me.new_imgprod_name = filename
                Me.saved_new_imgprod = 1
                Dim sql As String
                Dim id As String
                id = text_id.Text.Trim
                If id <> "" Then
                    sql = "update `op_stok` set `gambar` = '" + filename + "' where `id` like '" + id + "'"
                    data_obj.mysql_just_exec(sql)
                End If
                data_obj.loadimg(Me.PictureBox1, "thumb_" + filename)
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_home_Click(sender As Object, e As EventArgs) Handles tombol_home.Click

        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            do_load_data = 1
            Me.page = 1
            Call LoadData(page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call clear_data()

    End Sub

    Public Sub clear_data()
        text_kode.Text = ""
        text_nama_produk.Text = ""
        combo_id_merek.SelectedIndex = 0
        combo_id_gudang.SelectedIndex = 0
        combo_id_kategori.SelectedIndex = 0
        data_obj.loadimg(Me.PictureBox1, "thumb_" + Me.default_pic)
        text_harga.Text = ""

        text_jumlah_masuk.Text = ""
        text_id.Text = ""
    End Sub


    Public Sub auto_fill_data(ByVal mode As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            If do_autofill = 1 Then
                Dim datareader_mysql_autofill As MySqlDataReader
                Dim datareader_mysql_local As MySqlDataReader
                data_obj.cmd_mysql_ret_all_from_colval.Dispose()
                data_obj.con_mysql_ret_all_from_colval.Close()
                datareader_mysql_autofill = Nothing
                If mode = "kode" Then
                    datareader_mysql_autofill = data_obj.ret_all_from_colval("op_stok", "kode", text_kode.Text)
                ElseIf mode = "nama" Then
                    datareader_mysql_autofill = data_obj.ret_all_from_colval("op_stok", "nama_produk", text_nama_produk.Text)
                End If
                If datareader_mysql_autofill.Read() Then
                    Dim id As String
                    Dim id_kategori As String
                    Dim id_merek As String
                    Dim gambar As String
                    Dim nama_produk As String
                    Dim kode As String

                    Dim harga As String
                    Dim id_gudang As String

                    Dim kategori As String
                    Dim merek As String
                    Dim gudang As String

                    id = datareader_mysql_autofill(0).ToString()

                    id_kategori = datareader_mysql_autofill(1).ToString()
                    id_merek = datareader_mysql_autofill(2).ToString()
                    gambar = datareader_mysql_autofill(4).ToString()
                    nama_produk = datareader_mysql_autofill(5).ToString()
                    kode = datareader_mysql_autofill(3).ToString()
                    harga = datareader_mysql_autofill(6).ToString()
                    id_gudang = datareader_mysql_autofill(8).ToString()

                    datareader_mysql_autofill.Dispose()
                    gambar = Me.default_pic
                    data_obj.cmd_mysql_ret_colval_from_colval.Dispose()
                    data_obj.con_mysql_ret_colval_from_colval.Dispose()

                    datareader_mysql_local = data_obj.ret_colval_from_colval("op_stok", "id", id, "gambar")
                    If datareader_mysql_local.Read Then
                        gambar = datareader_mysql_local(0).ToString.Trim
                        datareader_mysql_local.Dispose()

                    End If
                    If gambar = "" Then
                        gambar = Me.default_pic
                    End If
                    data_obj.loadimg(Me.PictureBox1, "thumb_" + gambar)

                    text_id.Text = id
                    data_obj.cmd_mysql_get_name_from_master_by_id.Dispose()
                    data_obj.con_mysql_get_name_from_master_by_id.Close()
                    kategori = data_obj.get_name_from_master_by_id("kategori", id_kategori)
                    merek = data_obj.get_name_from_master_by_id("merek", id_merek)
                    gudang = data_obj.get_name_from_master_by_id("gudang", id_gudang)
                    'Console.WriteLine("[" + gudang + "]")

                    combo_id_kategori.SelectedIndex = combo_id_kategori.FindStringExact(kategori)
                    combo_id_gudang.SelectedIndex = combo_id_gudang.FindStringExact(gudang)
                    combo_id_merek.SelectedIndex = combo_id_merek.FindStringExact(merek)
                    If mode = "kode" Then
                        text_nama_produk.Text = nama_produk
                    ElseIf mode = "nama" Then
                        text_kode.Text = kode
                    End If

                    text_harga.Text = harga

                    'data_obj.loadimg(Me.PictureBox1, "img\produk\" & gambar)

                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If (Len(textcari_kode.Text) > 0) Or (Len(textcari_nama_barang.Text) > 0) Or (combo_merek.Text <> "") Then
                If Len(textcari_kode.Text) > 0 Then
                    Call LoadDataPencarian(textcari_kode.Text, "kode", "op_stok")
                ElseIf Len(textcari_nama_barang.Text) > 0 Then
                    Call LoadDataPencarian(textcari_nama_barang.Text, "nama_produk", "op_stok")
                ElseIf (combo_merek.Text <> "") Then
                    Dim id_merek_prod As String
                    datareader_mysql_generic = data_obj.ret_colval_from_colval("master_merek", "merek", combo_merek.Text, "id")
                    If datareader_mysql_generic.Read() Then
                        id_merek_prod = datareader_mysql_generic(0).ToString()
                        Call LoadDataPencarian(id_merek_prod, "id_merek", "op_stok")
                    End If
                    datareader_mysql_generic.Dispose()
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub textcari_kode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textcari_kode.KeyDown
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(textcari_kode.Text) >= panjang_minimal_kode_barang Then
                do_autofill = 0
                do_load_data = 0
                If e.KeyCode = Keys.Enter Then
                    Call LoadDataPencarian(textcari_kode.Text, "kode", "op_stok")
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub



    Private Sub textcari_nama_barang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textcari_nama_barang.KeyDown
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(textcari_nama_barang.Text) >= panjang_minimal_nama_barang Then
                do_autofill = 0
                do_load_data = 0
                If e.KeyCode = Keys.Enter Then
                    Call LoadDataPencarian(textcari_nama_barang.Text, "nama_produk", "op_stok")
                End If
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

    Private Sub text_jumlah_masuk_TextChanged(sender As Object, e As EventArgs) Handles text_jumlah_masuk.TextChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim nilai_masuk As Integer
            Dim nilai_harga As Integer
            Dim nilai_subtotal As Integer
            nilai_masuk = Val(text_jumlah_masuk.Text.Replace(".", "").Replace(",", ""))
            nilai_harga = Val(text_harga.Text.Replace(".", "").Replace(",", ""))
            nilai_subtotal = nilai_masuk * nilai_harga
            teks_subtotal.Text = nilai_subtotal.ToString

            Dim fmt_subtotal As String
            fmt_subtotal = data_obj.format_num(teks_subtotal.Text)
            teks_subtotal.Text = fmt_subtotal
            teks_subtotal.SelectionStart = Len(teks_subtotal.Text)

            Dim fmt As String
            fmt = data_obj.format_num(text_jumlah_masuk.Text)
            text_jumlah_masuk.Text = fmt
            text_jumlah_masuk.SelectionStart = Len(text_jumlah_masuk.Text)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clear_data()
        text_modus.Text = ""
    End Sub
    Public Sub prepare_data_pelengkap()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.total_data = data_obj.get_total_rows("op_stok")
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

    Private Sub tombol_delete_all_Click(sender As Object, e As EventArgs) Handles tombol_delete_all.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah Anda yakin untuk menghapus seluruh data seluruh stok masuk ?", "Hapus Data Seluruh Stok Masuk")
            If hapus = 1 Then
                form_delete_all.table_name = "op_stok_masuk"
                form_delete_all.Show()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub tombol_csv_Click(sender As Object, e As EventArgs) Handles tombol_csv.Click
        form_csv.additional_mark = ""
        form_csv.nama_tabel = "op_stok_masuk"
        form_csv.Show()
        basic_op.setfokus(form_csv)
    End Sub

    Private Sub text_kode_TextChanged(sender As Object, e As EventArgs) Handles text_kode.TextChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_kode.Text) >= panjang_minimal_kode_barang Then
                If current_autofill <> "nama" Then
                    current_autofill = "kode"
                    auto_fill_data("kode")
                    current_autofill = ""
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Overloads Sub text_kode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_kode.KeyDown
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_kode.Text) > 1 Then
                If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    If Len(text_kode.Text) >= panjang_minimal_kode_barang Then
                        If current_autofill <> "nama" Then
                            current_autofill = "kode"
                            auto_fill_data("kode")
                            current_autofill = ""
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class