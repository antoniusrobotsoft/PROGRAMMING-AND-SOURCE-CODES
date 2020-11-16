Imports MySql.Data.MySqlClient

Public Class pengaturan_fitur
    Public data_obj As New data_object
    Public basic_op As New basic_op
    Public Property new_wallpaper_name As String
    Public Property saved_new_wallpaper As Integer
    Private Sub pengaturan_fitur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.new_wallpaper_name = ""
            Me.saved_new_wallpaper = 0
            Call loaddata_konfigurasi_stok()
            Call load_data_combobox()
            Call load_cfg_fitur()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
    Public Sub load_cfg_fitur()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim cfg_active_wallpaper As String
            Dim enable_arus_kas As String
            Dim datareader_mysql_local As MySqlDataReader
            data_obj.cmd_mysql_load_single_data_from_table.Dispose()
            data_obj.con_mysql_load_single_data_from_table.Close()
            datareader_mysql_local = data_obj.load_single_data_from_table("cfg_fitur")
            If datareader_mysql_local.Read Then
                cfg_active_wallpaper = datareader_mysql_local(2).ToString()
                enable_arus_kas = datareader_mysql_local(3).ToString()
                datareader_mysql_local.Dispose()
            End If
            ' load data
            combo_enable_alur_kas.SelectedIndex = combo_enable_alur_kas.FindStringExact(enable_arus_kas)
            data_obj.img_cat = "background"
            data_obj.loadimg(Me.PictureBox1, "thumb_" + cfg_active_wallpaper)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Public Function get_current_active_currency()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim datareader_mysql_local As MySqlDataReader
        Dim cfg_active_currency As String
        cfg_active_currency = ""
        Try
            data_obj.cmd_mysql_load_single_data_from_table.Dispose()
            data_obj.con_mysql_load_single_data_from_table.Close()
            datareader_mysql_local = data_obj.load_single_data_from_table("cfg_fitur")
            If datareader_mysql_local.Read Then
                cfg_active_currency = datareader_mysql_local(1).ToString()
                datareader_mysql_local.Dispose()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return cfg_active_currency
    End Function

    Public Sub load_data_combobox()
        Dim datareader_mysql_master_currency As MySqlDataReader
        Dim cfg_active_currency As String
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            cfg_active_currency = get_current_active_currency()
            data_obj.cmd_mysql_ret_data_master_currency_for_combobox.Dispose()
            data_obj.con_mysql_ret_data_master_currency_for_combobox.Close()
            datareader_mysql_master_currency = data_obj.ret_data_master_currency_for_combobox()
            While datareader_mysql_master_currency.Read()
                combo_cfg_active_currency.Items.Add(datareader_mysql_master_currency.Item(0).Trim())
            End While
            combo_cfg_active_currency.SelectedIndex = combo_cfg_active_currency.FindStringExact(cfg_active_currency)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        If combo_cfg_active_currency.Items.Count > 0 Then
            combo_cfg_active_currency.SelectedIndex = 0
        End If
    End Sub

    Public Sub loaddata_konfigurasi_stok()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim datareader_mysql_local As MySqlDataReader
            Dim panjang_minimal_kode_barang = ""
            Dim panjang_minimal_nama_barang = ""
            datareader_mysql_local = data_obj.load_single_data_from_table("cfg_app")
            If datareader_mysql_local.Read() Then
                panjang_minimal_kode_barang = datareader_mysql_local(1).ToString()
                panjang_minimal_nama_barang = datareader_mysql_local(2).ToString()
            End If
            datareader_mysql_local.Dispose()
            data_obj.cmd_mysql_load_single_data_from_table.Dispose()
            text_panjang_minimal_kode_barang.Text = panjang_minimal_kode_barang
            text_panjang_minimal_nama_barang.Text = panjang_minimal_nama_barang
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim cfg_active_currency As String
            Dim sql As String
            Dim enable_alur_kas As String
            If Len(combo_cfg_active_currency.Text) < 1 Then
                MsgBox("Currency Aktif Harus dipilih")
            ElseIf Len(combo_enable_alur_kas.Text) < 1 Then
                MsgBox("Pilihan fitur pengaktifan alur kas harus dipilih")
            Else
                cfg_active_currency = combo_cfg_active_currency.Text.Trim()
                enable_alur_kas = combo_enable_alur_kas.Text.Trim()
                Dim ret = 0
                'Dim sql = "update `cfg_fitur` set `cfg_active_wallpaper` = '" + Me.new_wallpaper_name + "'"
                'data_obj.mysql_just_exec(sql)
                If Len(Me.new_wallpaper_name) > 1 Then
                    sql = "update `cfg_fitur` set `cfg_active_wallpaper` = '" + Me.new_wallpaper_name + "'"
                    data_obj.mysql_just_exec(sql)
                End If
                sql = "update `cfg_fitur` set `cfg_active_currency` = '" + cfg_active_currency + "', `enable_alur_kas` = '" + enable_alur_kas + "'"
                ret = data_obj.mysql_just_exec(sql)
                If ret = 1 Then
                    Call load_data_combobox()
                    Call load_cfg_fitur()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            'text_panjang_minimal_kode_barang.Text = panjang_minimal_kode_barang
            'text_panjang_minimal_nama_barang.Text = panjang_minimal_nama_barang
            Dim panjang_minimal_kode_barang As String
            Dim panjang_minimal_nama_barang As String
            If Len(text_panjang_minimal_kode_barang.Text) < 1 Then
                MsgBox("Panjang minimal kode barang harus diisi ")
            ElseIf Len(text_panjang_minimal_nama_barang.Text) < 1 Then
                MsgBox("Panjang minimal nama barang harus diisi ")
            ElseIf Not IsNumeric(text_panjang_minimal_kode_barang.Text) Then
                MsgBox("Panjang minimal kode barang harus numerik")
            ElseIf Not IsNumeric(text_panjang_minimal_nama_barang.Text) Then
                MsgBox("Panjang minimal nama barang harus numerik")
            Else
                panjang_minimal_kode_barang = text_panjang_minimal_kode_barang.Text.Trim()
                panjang_minimal_nama_barang = text_panjang_minimal_nama_barang.Text.Trim()
                Dim ret = 0
                Dim sql = "update `cfg_app` set `panjang_minimal_kode_barang` = '" + panjang_minimal_kode_barang + "', `panjang_minimal_nama_barang` = '" + panjang_minimal_nama_barang + "'"
                ret = data_obj.mysql_just_exec(sql)
                If ret = 1 Then
                    Console.Beep(4000, 100)
                    Call loaddata_konfigurasi_stok()
                Else
                    MsgBox("data gagal disimpan")
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Call handle_img_upload()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.saved_new_wallpaper = 1 Then
                If Len(Me.new_wallpaper_name) > 1 Then
                    Dim sql = "update `cfg_fitur` set `cfg_active_wallpaper` = '" + Me.new_wallpaper_name + "'"
                    data_obj.mysql_just_exec(sql)
                End If
                Me.saved_new_wallpaper = 0
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub handle_img_upload()
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
                dest_path = app_path & "\img\background\" & filename
                PictureBox1.Image = Nothing
                basic_op.copy_file(orig_path, dest_path)
                Dim thumbnail_path = app_path & "\img\background\thumb_" & filename
                basic_op.CreateThumbnail(300, dest_path, thumbnail_path)
                data_obj.img_cat = "background"
                data_obj.loadimg(Me.PictureBox1, "thumb_" + filename)
                Me.new_wallpaper_name = filename
                If Len(filename) > 1 Then
                    Me.saved_new_wallpaper = 1
                    form_utama.load_new_img = 1
                    form_utama_operator.load_new_img = 1
                    text_path_wallpaper.Text = filename
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Call handle_img_upload()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
End Class