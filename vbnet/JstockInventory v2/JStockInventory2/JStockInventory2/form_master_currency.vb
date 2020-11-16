Imports MySql.Data.MySqlClient
Imports System.Math
Public Class form_master_currency
    Public data_obj As New data_object
    Public datatable_mysql = New DataTable
    Public basic_op As New basic_op
    Public Property saved_data As Integer
    Public Property page As Integer
    Public Property total_data As Integer
    Public Property max_page As Integer




    Public Sub prepare_data_pelengkap()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.total_data = data_obj.get_total_rows("master_currency")
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

    Public Sub selected_view(e As DataGridViewCellEventArgs)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If (e.RowIndex >= 0) And DGView.CurrentCell.Value <> Nothing Then
                Dim row As DataGridViewRow
                row = Me.DGView.Rows(e.RowIndex)
                text_id.Text = row.Cells("id").Value.ToString
                text_currency.Text = row.Cells("currency").Value.ToString
                text_to_rp.Text = row.Cells("to_rp").Value.ToString
                text_abbrv.Text = row.Cells("abbrv").Value.ToString
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


    Private Sub form_master_currency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            basic_op.hide_id(label_id, text_id)
            form_master_data_currency_add.added_data = 0
            Me.saved_data = 0
            Me.page = 1
            Call prepare_data_pelengkap()

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        form_master_data_currency_add.Show()
        basic_op.setfokus(form_master_data_currency_add)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If form_master_data_currency_add.added_data = 1 Or Me.saved_data = 1 Then
                form_master_data_currency_add.added_data = 0
                Me.saved_data = 0
                Call prepare_data_pelengkap()
                Call LoadData(page)
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub LoadData(ByVal hal As Integer)
        Try
            Dim x As Integer
            Dim sql As String
            Dim pg = (hal - 1) * 10
            Dim pg_str = pg.ToString()
            sql = "SELECT id,currency,to_rp,abbrv  FROM master_currency order by `id` desc limit " + pg_str + ",10"
            datatable_mysql = data_obj.load_data_for_datagrid(sql)
            DGView.DataSource = datatable_mysql
            DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            data_obj.con_mysql.Dispose()

            x = 0
            While x < DGView.RowCount
                If Len(DGView.Rows(x).Cells(2).Value) > 0 Then
                    DGView.Rows(x).Cells(2).Value = data_obj.format_num(DGView.Rows(x).Cells(2).Value)
                End If
                x = x + 1
            End While

            Dim i As Integer
            For i = 0 To DGView.Columns.Count - 1
                DGView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
            Next i

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_currency.Text) < 1 Then
                MsgBox("currency harus diisi")
            ElseIf Len(text_to_rp.Text) < 1 Then
                MsgBox("konversi ke rupiah harus diisi")
            ElseIf Len(text_abbrv.Text) < 1 Then
                MsgBox("singkatan harus diisi")
            Else
                Dim ret = 0
                Dim currency = text_currency.Text
                Dim to_rp = text_to_rp.Text.Replace(",", "")
                Dim abbrv = text_abbrv.Text
                Dim id = text_id.Text
                Dim sql = "update `master_currency` set `currency` = '" + currency + "', `to_rp` = '" + to_rp + "', `abbrv` = '" + abbrv + "' where `id` like '" + id + "'"
                ret = data_obj.mysql_just_exec(sql)
                If ret = 1 Then
                    Me.saved_data = 1
                    Console.Beep(4000, 100)
                Else
                    MsgBox("data gagal disimpan")
                End If
            End If

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah data currency akan dihapus ?", "Hapus Data Currency")
            If hapus = 1 Then
                Dim id = text_id.Text
                Dim res = 0
                res = data_obj.mysql_del("master_currency", id)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(textcari_data_currency.Text) > 1 Then
                datatable_mysql = data_obj.load_data_pencarian(textcari_data_currency.Text, "currency", "master_currency")
                DGView.DataSource = datatable_mysql
                DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Dim x As Integer
                x = 0
                While x < DGView.RowCount
                    If Len(DGView.Rows(x).Cells(2).Value) > 0 Then
                        DGView.Rows(x).Cells(2).Value = data_obj.format_num(DGView.Rows(x).Cells(2).Value)
                    End If
                    x = x + 1
                End While
                Dim i As Integer
                For i = 0 To DGView.Columns.Count - 1
                    DGView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
                Next i
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

    Private Sub tombol_home_Click(sender As Object, e As EventArgs) Handles tombol_home.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.page = 1
            Call LoadData(page)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub text_to_rp_TextChanged(sender As Object, e As EventArgs) Handles text_to_rp.TextChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim fmt As String
            fmt = data_obj.format_num(text_to_rp.Text)
            text_to_rp.Text = fmt
            text_to_rp.SelectionStart = Len(text_to_rp.Text)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Overloads Sub textcari_data_currency_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textcari_data_currency.KeyDown
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(textcari_data_currency.Text) > 1 Then
                If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    datatable_mysql = data_obj.load_data_pencarian(textcari_data_currency.Text, "currency", "master_currency")
                    DGView.DataSource = datatable_mysql
                    DGView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                    Dim x As Integer
                    x = 0
                    While x < DGView.RowCount
                        If Len(DGView.Rows(x).Cells(2).Value) > 0 Then
                            DGView.Rows(x).Cells(2).Value = data_obj.format_num(DGView.Rows(x).Cells(2).Value)
                        End If
                        x = x + 1
                    End While

                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub tombol_csv_Click(sender As Object, e As EventArgs) Handles tombol_csv.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            form_csv.additional_mark = ""
            form_csv.nama_tabel = "master_currency"

            form_csv.Show()
            basic_op.setfokus(form_csv)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub tombol_delete_all_Click(sender As Object, e As EventArgs) Handles tombol_delete_all.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah Anda yakin untuk menghapus seluruh data master currency ?", "Hapus Data Seluruh Master Currency")
            If hapus = 1 Then
                form_delete_all.table_name = "master_currency"
                form_delete_all.Show()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class