Imports MySql.Data.MySqlClient
Imports System.Math


Public Class form_master_data_kas
    Public data_obj As New data_object
    Public datatable_mysql = New DataTable
    Public basic_op As New basic_op
    Public Property page As Integer
    Public Property total_data As Integer
    Public Property max_page As Integer
    Public Property saved_data As Integer
    Public Property current_mode_view As String
    Public Property last_sql_for_csv As String
    Public Property nilai_kas_awal As Integer

    Public Sub load_data_datagrid(ByVal hal As Integer)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim full_date_dari = basic_op.return_mysql_date_format(DateTimePicker_dari.Text)
            Dim full_date_hingga = basic_op.return_mysql_date_format(DateTimePicker_hingga.Text)

            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            If current_mode_view = "default" Then
                sql = "SELECT id,jumlah_kas, full_date, mark FROM op_histori_kas  order by `id` desc limit " + pg_str + ",10"
                Me.last_sql_for_csv = "SELECT jumlah_kas, full_date, mark FROM op_histori_kas  order by `id` desc limit 0, 500"
            Else
                sql = "SELECT id,jumlah_kas, full_date, mark FROM op_histori_kas  where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "' order by `id` desc limit " + pg_str + ",10"
                Me.last_sql_for_csv = "SELECT jumlah_kas, full_date, mark FROM op_histori_kas  where `full_date` between '" + full_date_dari + "' and  '" + full_date_hingga + "' order by `id` desc limit 0,500"
            End If
            datatable_mysql = data_obj.load_data_for_datagrid(sql)
            DGView.DataSource = datatable_mysql
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()

            Dim x As Integer
            x = 0
            '2 jumlah kas
            '0 tanggal  perubahan
            '3 full_date
            '4 mark
            While x < DGView.RowCount
                If Len(DGView.Rows(x).Cells(2).Value) > 0 Then
                    DGView.Rows(x).Cells(2).Value = data_obj.format_num(DGView.Rows(x).Cells(2).Value)
                    DGView.Rows(x).Cells(2).Style.Alignment = DataGridViewContentAlignment.TopRight
                End If
                If Len(DGView.Rows(x).Cells(3).Value) > 0 Then
                    DGView.Rows(x).Cells(0).Value = basic_op.convert_mysql_date_format_to_chinese_date_format(DGView.Rows(x).Cells(3).Value.ToString())
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
    End Sub

    Public Sub load_data()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim datareader_mysql_local As MySqlDataReader
            Dim jumlah_kas = ""

            datareader_mysql_local = data_obj.load_single_data_from_table("master_kas")
            If datareader_mysql_local.Read() Then
                jumlah_kas = datareader_mysql_local(1).ToString()
                datareader_mysql_local.Dispose()
                data_obj.cmd_mysql_load_single_data_from_table.Dispose()
            End If
            text_jumlah_kas.Text = data_obj.format_num(jumlah_kas)
            Me.nilai_kas_awal = Val(jumlah_kas.Trim())
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Private Sub tombol_simpan_Click(sender As Object, e As EventArgs) Handles tombol_simpan.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_jumlah_kas.Text) < 2 Then
                MsgBox("Isikan jumlah kas dengan benar")
            Else
                Dim selisih As Integer
                Dim id_op_histori_kas As String
                Dim mark As String
                Dim jumlah_kas As String
                Dim tanggal = basic_op.waktu("tanggal_only")
                Dim bulan = basic_op.waktu("bulan")
                Dim tahun = basic_op.waktu("tahun")
                Dim tgl = basic_op.return_mysql_date_format_from_raw(tanggal, bulan, tahun)
                jumlah_kas = text_jumlah_kas.Text.Trim.Replace(".", "").Replace(",", "")
                Dim ret = 0
                Dim sql = "update `master_kas` set `jumlah_kas` = '" + jumlah_kas + "',`update_date` = '" + tgl + "'"
                ret = data_obj.mysql_just_exec(sql)
                If ret = 1 Then
                    Me.nilai_kas_awal = Val(jumlah_kas.Trim())

                    If Me.nilai_kas_awal > Val(jumlah_kas) Then
                        mark = "keluar"
                        selisih = Me.nilai_kas_awal - Val(jumlah_kas)
                    Else
                        mark = "masuk"
                        selisih = Val(jumlah_kas) - Me.nilai_kas_awal
                    End If
                    If selisih > 0 Then
                        Dim sql2 = "INSERT INTO `op_histori_kas` (`id`, `jumlah_kas`, `full_date`) VALUES (NULL, '" + jumlah_kas + "', '" + tgl + "');"
                        Dim ret2 = data_obj.mysql_just_exec(sql2)
                        selisih = 0
                        id_op_histori_kas = data_obj.ret_colval_string_from_colval("op_histori_kas", "jumlah_kas", jumlah_kas, "id")

                        If Len(id_op_histori_kas) > 0 Then
                            Dim sql3 = "INSERT INTO `op_histori_kas_flow` (`id`, `jumlah_kas_masuk_atau_keluar`, `full_date`, `mark`, `id_op_histori_kas`) VALUES ('', '" + selisih.ToString + "', '" + tgl + "', '" + mark + "', '" + id_op_histori_kas + "');"
                            Dim ret3 = data_obj.mysql_just_exec(sql3)
                        End If
                    End If
                    Me.saved_data = 1
                    Console.Beep(4000, 100)
                    Call load_data_datagrid(page)
                Else
                    MsgBox("data gagal disimpan")
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub form_master_data_kas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            current_mode_view = "default"
            load_data()
            Me.page = 1
            Call prepare_data_pelengkap()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub text_jumlah_kas_TextChanged(sender As Object, e As EventArgs) Handles text_jumlah_kas.TextChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim fmt As String
            fmt = data_obj.format_num(text_jumlah_kas.Text)
            text_jumlah_kas.Text = fmt
            text_jumlah_kas.SelectionStart = Len(text_jumlah_kas.Text)
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
    Public Sub selected_view(e As DataGridViewCellEventArgs)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If (e.RowIndex >= 0) And DGView.CurrentCell.Value <> Nothing Then
                Dim row As DataGridViewRow
                row = Me.DGView.Rows(e.RowIndex)
                text_id.Text = row.Cells("id").Value.ToString
                text_edit_jumlah_kas.Text = row.Cells("jumlah_kas").Value.ToString
                If Len(row.Cells("tanggal_perubahan").Value.ToString) > 6 Then
                    DateTimePicker_tanggal_perubahan.Text = row.Cells("tanggal_perubahan").Value.ToString
                End If
                text_edit_mark.Text = row.Cells("mark").Value.ToString
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub tombol_csv_Click(sender As Object, e As EventArgs) Handles tombol_csv.Click
        form_csv.additional_mark = ""
        form_csv.nama_tabel = "master_kas"
        form_csv.Show()
        basic_op.setfokus(form_csv)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah data histori ini akan dihapus ?", "Hapus Data Histori Perubahan Kas")
            If hapus = 1 Then
                Dim id = text_id.Text
                Dim res = 0
                res = data_obj.mysql_del("op_histori_kas", id)
                If res = 0 Then
                    basic_op.gagal_delete()
                Else
                    data_obj.mysql_del_cond("op_histori_kas_flow", "id_op_histori_kas", id)
                    Console.Beep(4000, 100)
                    Me.saved_data = 1
                    Call load_data_datagrid(page)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub tombol_home_Click(sender As Object, e As EventArgs) Handles tombol_home.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page = 1
            current_mode_view = "default"
            Call load_data_datagrid(page)

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

    Private Sub combo_page_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_page.SelectedIndexChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page = combo_page.SelectedItem
            Call load_data_datagrid(page)
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

    Private Sub button_prev_Click(sender As Object, e As EventArgs) Handles button_prev.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.page > 1 Then
                Me.page = Me.page - 1
                Call load_data_datagrid(page)
                button_next.Enabled = 1
                Call select_combo_item()

            Else
                button_prev.Enabled = 0
                button_next.Enabled = 0
                Call select_combo_item()
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
                Call load_data_datagrid(page)
                button_prev.Enabled = 1
                Call select_combo_item()
            Else
                button_next.Enabled = 0
                Call select_combo_item()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
    Public Sub prepare_data_pelengkap()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.total_data = data_obj.get_total_rows("op_histori_kas")
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_edit_jumlah_kas.Text) < 1 Then
                MsgBox("Jumlah kas harus diisi")
            Else
                Dim ret = 0
                Dim edit_jumlah_kas = text_edit_jumlah_kas.Text.Replace(".", "").Replace(",", "")
                Dim edit_tanggal_perubahan = DateTimePicker_tanggal_perubahan.Text
                Dim full_date = basic_op.return_mysql_date_format(edit_tanggal_perubahan)
                Dim edit_mark = text_edit_mark.Text.Trim
                Dim id = text_id.Text
                Dim sql = "update `op_histori_kas` set `jumlah_kas` = '" + edit_jumlah_kas + "', `full_date` = '" + full_date + "', `mark` = '" + edit_mark + "' where `id` like '" + id + "'"
                ret = data_obj.mysql_just_exec(sql)
                If ret = 1 Then
                    Console.Beep(4000, 100)
                    Me.saved_data = 1
                    Call load_data_datagrid(page)
                Else
                    MsgBox("data gagal disimpan")
                End If
            End If
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
            Call load_data_datagrid(Me.page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        text_edit_jumlah_kas.Text = ""
        text_edit_mark.Text = ""
        text_id.Text = ""
    End Sub

    Private Sub tombol_delete_all_Click(sender As Object, e As EventArgs) Handles tombol_delete_all.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah Anda yakin untuk menghapus seluruh data master kas ?", "Hapus Data Seluruh Master Kas")
            If hapus = 1 Then
                form_delete_all.table_name = "master_kas"
                form_delete_all.Show()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class