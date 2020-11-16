Imports MySql.Data.MySqlClient
Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class data_object
    Public Property universal_return = 1
    Public basic_op As New basic_op
    Public md5Hash As MD5

    Public Property con_mysql_ret_colval_string_from_colval As New MySqlConnection
    Public Property cmd_mysql_ret_colval_string_from_colval As New MySqlCommand

    Public Property con_mysql_csv As New MySqlConnection
    Public Property cmd_mysql_csv As New MySqlCommand

    Public Property con_mysql As New MySqlConnection
    Public Property con_mysql_ret_all_from_colval As New MySqlConnection
    Public Property cmd_mysql_ret_all_from_colval As New MySqlCommand
    Public Property con_mysql_ret_colval_from_colval As New MySqlConnection
    Public Property cmd_mysql_ret_colval_from_colval As New MySqlCommand
    Public Property con_mysql_load_datareader_for_datagrid As New MySqlConnection
    Public Property cmd_mysql_load_datareader_for_datagrid As New MySqlCommand
    Public Property con_mysql_get_name_from_master_by_id As New MySqlConnection
    Public Property cmd_mysql_get_name_from_master_by_id As New MySqlCommand
    Public Property con_mysql_get_id_from_master_by_name As New MySqlConnection
    Public Property cmd_mysql_get_id_from_master_by_name As New MySqlCommand
    Public Property con_mysql_load_single_data_from_table As New MySqlConnection
    Public Property cmd_mysql_load_single_data_from_table As New MySqlCommand
    Public Property con_mysql_ret_data_master_merek_for_combobox As New MySqlConnection
    Public Property cmd_mysql_ret_data_master_merek_for_combobox As New MySqlCommand
    Public Property con_mysql_ret_data_master_kategori_for_combobox As New MySqlConnection
    Public Property cmd_mysql_ret_data_master_kategori_for_combobox As New MySqlCommand
    Public Property con_mysql_ret_data_master_gudang_for_combobox As New MySqlConnection
    Public Property cmd_mysql_ret_data_master_gudang_for_combobox As New MySqlCommand
    Public Property con_mysql_login_process As New MySqlConnection
    Public Property cmd_mysql_login_process As New MySqlCommand
    Public Property con_mysql_ret_data_master_currency_for_combobox As New MySqlConnection
    Public Property cmd_mysql_ret_data_master_currency_for_combobox As New MySqlCommand
    Public Property config_db As String
    Public cmd_mysql As New MySqlCommand
    Public combuilder_mysql As New MySqlCommandBuilder
    Public Property datareader_mysql As MySqlDataReader
    Public Property datareader_mysql_ret_all As MySqlDataReader
    Public Property adapter_mysql As MySqlDataAdapter
    Public Property datatable_mysql As New DataTable
    Public myerror_mysql As MySqlError
    Public bindingsource_mysql As New BindingSource
    Public dataset_mysql As New DataSet
    Public Property img_cat As String

    Public Property con_mysql_ret_colval_without_condition As New MySqlConnection
    Public Property cmd_mysql_ret_colval_without_condition As New MySqlCommand

    Public Sub create_csv_data_from_array_str(ByVal path As String, ByRef array_str() As String, ByVal header_str As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim data_to_write As String
            data_to_write = header_str & vbCrLf
            'begin data
            For Each element As String In array_str
                data_to_write = data_to_write & element.Replace(",", "") & ","
            Next
            'end data 
            data_to_write = data_to_write & vbCrLf
            basic_op.create_file(path, data_to_write)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Sub create_csv_data(ByVal path As String, ByVal sql As String, ByRef array_num() As Integer, ByVal header_str As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim datareader_mysql_local As MySqlDataReader
        Dim data_to_write As String
        data_to_write = header_str & vbCrLf
        Try
            If Me.con_mysql_csv.State = ConnectionState.Closed Then
                Me.con_mysql_csv.Close()
            End If
            If con_mysql_csv.State = ConnectionState.Closed Then
                _set_init_db_str()
                Me.con_mysql_csv = New MySqlConnection(Me.config_db)
                Me.con_mysql_csv.Open()
                MySqlConnection.ClearPool(con_mysql_csv)
                con_mysql_csv.ClearAllPoolsAsync()
                With cmd_mysql_csv
                    .Connection = con_mysql_csv
                    .CommandTimeout = 15
                End With
            End If
            Try
                cmd_mysql_csv = encapsulate_mysql_exec(sql, con_mysql_csv, cmd_mysql_csv)
                datareader_mysql_local = cmd_mysql_csv.ExecuteReader()
                While datareader_mysql_local.Read()
                    For Each num As Integer In array_num
                        If Len(datareader_mysql_local(num).ToString()) < 1 Then
                            data_to_write = data_to_write & "-,"
                        Else
                            data_to_write = data_to_write & datareader_mysql_local(num).ToString().Replace(",", "") & ","
                        End If
                    Next
                    data_to_write = data_to_write & vbCrLf
                End While
                datareader_mysql_local.Dispose()
                con_mysql.Close()
                basic_op.create_file(path, data_to_write)
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Public Function ret_colval_string_from_colval(ByVal table_name As String, ByVal column_name As String, ByVal val_condition As String, ByVal column_name_to_ret As String)
        Dim sql As String
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim retme As String
        Dim datareader_mysql_local As MySqlDataReader
        retme = ""
        Try
            If con_mysql_ret_colval_string_from_colval.State = ConnectionState.Open Then
                Try
                    cmd_mysql_ret_colval_string_from_colval.Dispose()
                    con_mysql_ret_colval_string_from_colval.Close()
                Catch ex As Exception
                    Console.WriteLine(methodName)
                    Console.WriteLine(ex.ToString)
                End Try
            End If

            If con_mysql_ret_colval_string_from_colval.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_colval_string_from_colval = New MySqlConnection(config_db)
                con_mysql_ret_colval_string_from_colval.Open()
                MySqlConnection.ClearPool(con_mysql_ret_colval_string_from_colval)
                con_mysql_ret_colval_string_from_colval.ClearAllPoolsAsync()
                With cmd_mysql_ret_colval_string_from_colval
                    .Connection = con_mysql_ret_colval_string_from_colval
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
        End Try
        Try
            sql = "select `" + column_name_to_ret + "` from `" + table_name + "` where `" + column_name + "` like '" + val_condition + "' order by `id` desc limit 0,1"
            cmd_mysql_ret_colval_string_from_colval = encapsulate_mysql_exec(sql, con_mysql_ret_colval_string_from_colval, cmd_mysql_ret_colval_string_from_colval)
            datareader_mysql_local = cmd_mysql_ret_colval_string_from_colval.ExecuteReader()
            If datareader_mysql_local.Read Then
                retme = datareader_mysql_local(0)
            End If
            Return retme
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return retme
        End Try
    End Function

    Public Function ret_colval_without_condition(ByVal table_name As String, ByVal column_name As String)
        Dim ret_str As String
        Dim sql As String
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_ret_colval_without_condition.State = ConnectionState.Open Then
                Try
                    cmd_mysql_ret_colval_without_condition.Dispose()
                    con_mysql_ret_colval_without_condition.Close()
                Catch ex As Exception
                    Console.WriteLine(methodName)
                End Try
            End If

            If con_mysql_ret_colval_without_condition.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_colval_without_condition = New MySqlConnection(config_db)
                con_mysql_ret_colval_without_condition.Open()
                MySqlConnection.ClearPool(con_mysql_ret_colval_without_condition)
                con_mysql_ret_colval_without_condition.ClearAllPoolsAsync()
                With cmd_mysql_ret_colval_without_condition
                    .Connection = con_mysql_ret_colval_without_condition
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
        End Try
        Try
            sql = "select `" + column_name + "` from `" + table_name + "` order by `id` desc limit 0,1"
            cmd_mysql_ret_colval_without_condition = encapsulate_mysql_exec(sql, con_mysql_ret_colval_without_condition, cmd_mysql_ret_colval_without_condition)
            datareader_mysql_local = cmd_mysql_ret_colval_without_condition.ExecuteReader()
            If datareader_mysql_local.Read Then
                ret_str = datareader_mysql_local(0).ToString
                datareader_mysql_local.Dispose()
            End If
            Return ret_str
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function



    Public Function loadimg(ByVal picbox As PictureBox, ByVal img_name As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim data As String
        Dim app_path As String
        Console.WriteLine("loadimg called")
        data = ""
        Try
            If (img_name.IndexOf("img/logo") = -1) And (img_name.IndexOf("img/produk") = -1) And (img_name.IndexOf("img/background") = -1) Then
                If Me.img_cat = "logo" Then
                    img_name = "img\logo\" & img_name
                ElseIf Me.img_cat = "background" Then
                    img_name = "img\background\" & img_name
                Else
                    img_name = "img\produk\" & img_name
                End If
            End If
            app_path = basic_op.jstock_read_config()
            data = app_path & "\" & img_name
            If (img_name.IndexOf(".jpg") > -1) Or (img_name.IndexOf(".gif") > -1) Or (img_name.IndexOf(".png") > -1) Or (img_name.IndexOf(".jpeg") > -1) Or (img_name.IndexOf(".bmp") > -1) Then
                Try
                    picbox.Image = Image.FromFile(data)
                Catch ex As Exception
                    If (File.Exists(data) = False) Then
                        If data.IndexOf("thumb_") > -1 Then
                            Dim orig_img_path = data.Replace("thumb_", "")
                            Dim thumbnail_path = data
                            If data.IndexOf("\background\") > -1 Then
                                basic_op.CreateThumbnail(300, orig_img_path, thumbnail_path)
                            Else
                                basic_op.CreateThumbnail(150, orig_img_path, thumbnail_path)
                            End If
                        End If
                    End If
                End Try
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return 1
    End Function
    Public Function mysql_del_cond(ByVal tablename As String, ByVal column_name As String, ByVal column_val As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim sql_str = "delete from `" + tablename + "` where `" + column_name + "` like '" + column_val + "'"
        Try
            mysql_just_exec(sql_str)
            Return 1
        Catch ex As Exception
            basic_op.gagal_delete()
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function

    Public Function mysql_truncate(ByVal tablename As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim sql_str = "truncate table `" + tablename + "`"
        Try
            mysql_just_exec(sql_str)
            Return 1
        Catch ex As Exception
            basic_op.gagal_delete()
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function

    Public Function mysql_del(ByVal tablename As String, ByVal id As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim sql_str = "delete from `" + tablename + "` where `id` like '" + id + "'"
        Try
            mysql_just_exec(sql_str)
            Return 1
        Catch ex As Exception
            basic_op.gagal_delete()
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0

        End Try
    End Function

    Public Function get_total_rows_from_sql(ByVal sql As String)
        Dim retme As Integer
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            con_mysql = mysql_connect()
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.Message)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

        Return retme
    End Function

    Public Function get_total_rows_between_with_condition(ByVal table_name As String, ByVal column_name_for_condition As String, ByVal condition_val As String, ByVal column_name_for_range As String, ByVal range_start As String, ByVal range_end As String)
        Dim retme As Integer
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            con_mysql = mysql_connect()
            range_start = range_start.Trim()
            range_end = range_end.Trim()

            Dim sql = "SELECT COUNT(*) FROM " + table_name + " where (`" + column_name_for_condition + "` like '" + condition_val + "') and (`" + column_name_for_range + "` between '" + range_start + "' and '" + range_end + "')"
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.Message)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)

            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

        Return retme
    End Function

    Public Function get_total_rows_between(ByVal table_name As String, ByVal column_name As String, ByVal range_start As String, ByVal range_end As String)
        Dim retme As Integer
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            con_mysql = mysql_connect()
            range_start = range_start.Trim()
            range_end = range_end.Trim()

            Dim sql = "SELECT COUNT(*) FROM " + table_name + " where `" + column_name + "` between '" + range_start + "' and '" + range_end + "'"
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.Message)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try

        Return retme
    End Function

    Public Function load_datareader_for_datagrid(ByVal sql As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_load_datareader_for_datagrid.State = ConnectionState.Open Then
                cmd_mysql_load_datareader_for_datagrid.Dispose()
                con_mysql_load_datareader_for_datagrid.Close()
            End If
            If con_mysql_load_datareader_for_datagrid.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_load_datareader_for_datagrid = New MySqlConnection(config_db)
                con_mysql_load_datareader_for_datagrid.Open()
                MySqlConnection.ClearPool(con_mysql_load_datareader_for_datagrid)
                con_mysql_load_datareader_for_datagrid.ClearAllPoolsAsync()
                With cmd_mysql_load_datareader_for_datagrid
                    .Connection = con_mysql_load_datareader_for_datagrid
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Try
            cmd_mysql_load_datareader_for_datagrid = encapsulate_mysql_exec(sql, con_mysql_load_datareader_for_datagrid, cmd_mysql_load_datareader_for_datagrid)
            datareader_mysql_local = cmd_mysql_load_datareader_for_datagrid.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
    End Function


    Public Function ret_colval_from_colval(ByVal table_name As String, ByVal column_name As String, ByVal val_condition As String, ByVal column_name_to_ret As String)
        Dim sql As String
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_ret_colval_from_colval.State = ConnectionState.Open Then
                Try
                    cmd_mysql_ret_colval_from_colval.Dispose()
                    con_mysql_ret_colval_from_colval.Close()
                Catch ex As Exception
                    Console.WriteLine(methodName)
                End Try
            End If

            If con_mysql_ret_colval_from_colval.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_colval_from_colval = New MySqlConnection(config_db)
                con_mysql_ret_colval_from_colval.Open()
                MySqlConnection.ClearPool(con_mysql_ret_colval_from_colval)
                con_mysql_ret_colval_from_colval.ClearAllPoolsAsync()
                With cmd_mysql_ret_colval_from_colval
                    .Connection = con_mysql_ret_colval_from_colval
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
        End Try
        Try
            sql = "select `" + column_name_to_ret + "` from `" + table_name + "` where `" + column_name + "` like '" + val_condition + "' order by `id` desc limit 0,1"
            cmd_mysql_ret_colval_from_colval = encapsulate_mysql_exec(sql, con_mysql_ret_colval_from_colval, cmd_mysql_ret_colval_from_colval)
            datareader_mysql_local = cmd_mysql_ret_colval_from_colval.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function



    Public Function get_total_rows_on_condition(ByVal table_name As String, ByVal column_name As String, ByVal nilai As String)
        Dim retme As Integer
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            con_mysql = mysql_connect()
            nilai = nilai.Trim()
            Dim sql = "SELECT COUNT(*) FROM " + table_name + " where `" + column_name + "` like '" + nilai + "'"
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.Message)
                Console.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

        Return retme
    End Function

    Public Function get_total_rows_on_3condition(ByVal table_name As String, ByVal column_name1 As String, ByVal nilai1 As String, ByVal column_name2 As String, ByVal nilai2 As String, ByVal column_name3 As String, ByVal nilai3 As String)
        Dim retme As Integer
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            con_mysql = mysql_connect()
            nilai1 = nilai1.Trim()
            nilai2 = nilai2.Trim()
            nilai3 = nilai3.Trim()
            Dim sql = "SELECT COUNT(*) FROM " + table_name + " where (`" + column_name1 + "` like '" + nilai1 + "') and (`" + column_name2 + "` like '" + nilai2 + "') and (`" + column_name3 + "` like '" + nilai3 + "')"
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.Message)
                Console.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

        Return retme
    End Function


    Public Function get_total_rows_on_2condition(ByVal table_name As String, ByVal column_name1 As String, ByVal nilai1 As String, ByVal column_name2 As String, ByVal nilai2 As String)
        Dim retme As Integer
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            con_mysql = mysql_connect()
            nilai1 = nilai1.Trim()
            nilai2 = nilai2.Trim()

            Dim sql = "SELECT COUNT(*) FROM " + table_name + " where (`" + column_name1 + "` like '" + nilai1 + "') and (`" + column_name2 + "` like '" + nilai2 + "')"
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.Message)
                Console.WriteLine(ex.ToString)
            End Try

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try

        Return retme
    End Function


    Public Function get_total_rows(ByVal table_name As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim retme As Integer
        Try
            If con_mysql.State = ConnectionState.Closed Then
                mysql_connect()
            End If
            Dim sql = "SELECT COUNT(*) FROM " + table_name
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
                cmd.Dispose()
                con_mysql.Close()

            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.Message)
                Console.WriteLine(ex.ToString)
            End Try

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return retme
    End Function
    Public Function ret_data_master_currency_for_combobox()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim sql As String
        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_ret_data_master_currency_for_combobox.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_data_master_currency_for_combobox = New MySqlConnection(config_db)
                con_mysql_ret_data_master_currency_for_combobox.Open()
                MySqlConnection.ClearPool(con_mysql_ret_data_master_currency_for_combobox)
                con_mysql_ret_data_master_currency_for_combobox.ClearAllPoolsAsync()
                With cmd_mysql_ret_data_master_currency_for_combobox
                    .Connection = con_mysql_ret_data_master_currency_for_combobox
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return universal_return
        End Try
        Try
            sql = "select `currency` from `master_currency` order by `id` asc"
            cmd_mysql_ret_data_master_currency_for_combobox = encapsulate_mysql_exec(sql, con_mysql_ret_data_master_currency_for_combobox, cmd_mysql_ret_data_master_currency_for_combobox)
            datareader_mysql_local = cmd_mysql_ret_data_master_currency_for_combobox.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function
    Public Function _set_init_db_str()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            Dim chost As String
            Dim cdatabase As String
            Dim cuser As String
            Dim cpass As String
            Dim ret_array(4) As String
            ret_array = basic_op.read_db_cfg()
            chost = ret_array(0)
            cdatabase = ret_array(1)
            cuser = ret_array(2)
            cpass = ret_array(3)
            Me.config_db = "Server=" + chost + ";" _
                   + "user id=" + cuser + ";" _
                   + "password=" + cpass + ";" _
                   + "database=" + cdatabase + ";"
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try

        Return 1
    End Function

    Public Function encapsulate_mysql_exec(ByVal sql As String, ByVal encapsulate_con_mysql As MySqlConnection, ByVal encapsulate_cmd_mysql As MySqlCommand)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            If encapsulate_con_mysql.State = ConnectionState.Open Then
                encapsulate_con_mysql.Close()
            End If
            If encapsulate_con_mysql.State = ConnectionState.Closed Then
                encapsulate_con_mysql.Open()
            End If
            encapsulate_cmd_mysql.Dispose()
            encapsulate_cmd_mysql.Connection = encapsulate_con_mysql
            encapsulate_cmd_mysql.CommandText = sql
            encapsulate_cmd_mysql.Prepare()
            encapsulate_cmd_mysql.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return encapsulate_cmd_mysql
    End Function
    Public Function mysql_close()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            If con_mysql.State = ConnectionState.Open Then
                con_mysql.Close()
                con_mysql.Dispose()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.ToString)
        End Try
        Return con_mysql
    End Function

    Public Function mysql_connect()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            Dim config_db As String
            Dim chost As String
            Dim cdatabase As String
            Dim cuser As String
            Dim cpass As String
            Dim ret_array(4) As String
            ret_array = basic_op.read_db_cfg()
            chost = ret_array(0)
            cdatabase = ret_array(1)
            cuser = ret_array(2)
            cpass = ret_array(3)
            config_db = "Server=" + chost + ";" _
               + "user id=" + cuser + ";" _
               + "password=" + cpass + ";" _
               + "database=" + cdatabase + ";"
            If con_mysql.State = ConnectionState.Closed Then
                Me.con_mysql = New MySqlConnection(config_db)
                con_mysql.Open()
                MySqlConnection.ClearPool(con_mysql)
                con_mysql.ClearAllPoolsAsync()
                With cmd_mysql
                    .Connection = con_mysql
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Try
                If con_mysql.State = ConnectionState.Closed Then
                    con_mysql.Open()
                    MySqlConnection.ClearPool(con_mysql)
                    con_mysql.ClearAllPoolsAsync()
                    With cmd_mysql
                        .Connection = con_mysql
                        .CommandTimeout = 15
                    End With
                End If
            Catch ex2 As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try
        End Try
        Return con_mysql
    End Function

    Public Function mysql_just_exec(ByVal sql As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            If con_mysql.State = ConnectionState.Open Then
                cmd_mysql.Dispose()
                con_mysql.Close()
            End If
            Me.mysql_connect()
            Try
                cmd_mysql.Connection = con_mysql
                cmd_mysql.CommandText = sql
                cmd_mysql.Prepare()
                cmd_mysql.ExecuteNonQuery()
                Me.mysql_close()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return 1
    End Function

    Public Function load_data_pencarian(ByVal kunci As String, ByVal nama_kolom As String, ByVal nama_tabel As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            Dim sql As String
            sql = "SELECT * FROM " + nama_tabel + " where (" + nama_kolom + " like '" + kunci + "' or " + nama_kolom + " like '" + kunci + "%' or " + nama_kolom + " like '%" + kunci + "' or " + nama_kolom + " like '%" + kunci + "%') "
            datatable_mysql = load_data_for_datagrid(sql)
            Console.Beep(2000, 100)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return datatable_mysql
    End Function



    Public Function load_data_for_datagrid(ByVal sql As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            con_mysql = mysql_connect()
            Try
                datatable_mysql = New DataTable
                adapter_mysql = New MySqlDataAdapter(sql, con_mysql)
                combuilder_mysql = New MySql.Data.MySqlClient.MySqlCommandBuilder(adapter_mysql)
                adapter_mysql.Fill(datatable_mysql)
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return datatable_mysql
    End Function

    Public Function get_name_from_master_by_id(ByVal mode As String, ByVal id As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim ret_name As String
        Dim datareader_mysql_local As MySqlDataReader
        Dim sql As String
        sql = ""
        ret_name = ""
        Try
            con_mysql_get_name_from_master_by_id.Close()

            If con_mysql_get_name_from_master_by_id.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_get_name_from_master_by_id = New MySqlConnection(config_db)
                con_mysql_get_name_from_master_by_id.Open()
                MySqlConnection.ClearPool(con_mysql_get_name_from_master_by_id)
                con_mysql_get_name_from_master_by_id.ClearAllPoolsAsync()
                With cmd_mysql_get_name_from_master_by_id
                    .Connection = con_mysql_get_name_from_master_by_id
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        If mode = "merek" Then
            sql = "select `merek` from `master_merek` where `id` like '" + id + "'"
        ElseIf mode = "kategori" Then
            sql = "select `nama_kategori` from `master_kategori_produk` where `id` like '" + id + "'"
        ElseIf mode = "gudang" Then
            sql = "select `nama_gudang` from `master_gudang` where `id` like '" + id + "'"
        End If
        Try
            cmd_mysql_get_name_from_master_by_id.Dispose()

            cmd_mysql_get_name_from_master_by_id = encapsulate_mysql_exec(sql, con_mysql_get_name_from_master_by_id, cmd_mysql_get_name_from_master_by_id)
            datareader_mysql_local = cmd_mysql_get_name_from_master_by_id.ExecuteReader()
            If datareader_mysql_local.Read Then
                ret_name = datareader_mysql_local(0).ToString
                datareader_mysql_local.Close()
                con_mysql_get_name_from_master_by_id.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return ret_name
    End Function

    Public Function get_id_from_master_by_name(ByVal mode As String, ByVal name As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim ret_id As String
        Dim sql As String
        Dim datareader_mysql_local As MySqlDataReader
        sql = ""
        ret_id = ""
        Try
            If con_mysql_get_id_from_master_by_name.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_get_id_from_master_by_name = New MySqlConnection(config_db)
                con_mysql_get_id_from_master_by_name.Open()
                MySqlConnection.ClearPool(con_mysql_get_id_from_master_by_name)
                con_mysql_get_id_from_master_by_name.ClearAllPoolsAsync()
                With cmd_mysql_get_id_from_master_by_name
                    .Connection = con_mysql_get_id_from_master_by_name
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        If mode = "merek" Then
            sql = "select `id` from `master_merek` where `merek` like '" + name + "'"
        ElseIf mode = "kategori" Then
            sql = "select `id` from `master_kategori_produk` where `nama_kategori` like '" + name + "'"
        ElseIf mode = "gudang" Then
            sql = "select `id` from `master_gudang` where `nama_gudang` like '" + name + "'"
        End If
        Try
            cmd_mysql_get_id_from_master_by_name = encapsulate_mysql_exec(sql, con_mysql_get_id_from_master_by_name, cmd_mysql_get_id_from_master_by_name)
            datareader_mysql_local = cmd_mysql_get_id_from_master_by_name.ExecuteReader()
            If datareader_mysql_local.Read Then
                ret_id = datareader_mysql_local(0).ToString
                datareader_mysql_local.Close()
                con_mysql_get_id_from_master_by_name.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return ret_id
    End Function

    Public Function get_cfg_app()

        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Dim datareader_mysql_local As MySqlDataReader
        Try
            datareader_mysql_local = load_single_data_from_table("cfg_app")
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function
    Public Function load_single_data_from_table(ByVal table_name As String)
        Dim sql As String
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_load_single_data_from_table.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_load_single_data_from_table = New MySqlConnection(config_db)
                con_mysql_load_single_data_from_table.Open()
                MySqlConnection.ClearPool(con_mysql_load_single_data_from_table)
                con_mysql_load_single_data_from_table.ClearAllPoolsAsync()
                With cmd_mysql_load_single_data_from_table
                    .Connection = con_mysql_load_single_data_from_table
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Try
            sql = "select * from `" + table_name + "` order by `id` desc"
            cmd_mysql_load_single_data_from_table = encapsulate_mysql_exec(sql, con_mysql_load_single_data_from_table, cmd_mysql_load_single_data_from_table)
            datareader_mysql_local = cmd_mysql_load_single_data_from_table.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function

    Public Function ret_data_master_merek_for_combobox()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim sql As String
        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_ret_data_master_merek_for_combobox.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_data_master_merek_for_combobox = New MySqlConnection(config_db)
                con_mysql_ret_data_master_merek_for_combobox.Open()
                MySqlConnection.ClearPool(con_mysql_ret_data_master_merek_for_combobox)
                con_mysql_ret_data_master_merek_for_combobox.ClearAllPoolsAsync()
                With cmd_mysql_ret_data_master_merek_for_combobox
                    .Connection = con_mysql_ret_data_master_merek_for_combobox
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Try
            sql = "select `merek` from `master_merek` order by `merek` asc"
            cmd_mysql_ret_data_master_merek_for_combobox = encapsulate_mysql_exec(sql, con_mysql_ret_data_master_merek_for_combobox, cmd_mysql_ret_data_master_merek_for_combobox)
            datareader_mysql_local = cmd_mysql_ret_data_master_merek_for_combobox.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function

    Public Function ret_data_master_kategori_for_combobox()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim sql As String
        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_ret_data_master_kategori_for_combobox.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_data_master_kategori_for_combobox = New MySqlConnection(config_db)
                con_mysql_ret_data_master_kategori_for_combobox.Open()
                MySqlConnection.ClearPool(con_mysql_ret_data_master_kategori_for_combobox)
                con_mysql_ret_data_master_kategori_for_combobox.ClearAllPoolsAsync()
                With cmd_mysql_ret_data_master_kategori_for_combobox
                    .Connection = con_mysql_ret_data_master_kategori_for_combobox
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Try
            sql = "select `nama_kategori` from `master_kategori_produk` order by `nama_kategori` asc"
            cmd_mysql_ret_data_master_merek_for_combobox = encapsulate_mysql_exec(sql, con_mysql_ret_data_master_kategori_for_combobox, cmd_mysql_ret_data_master_kategori_for_combobox)
            datareader_mysql_local = cmd_mysql_ret_data_master_kategori_for_combobox.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function

    Public Function ret_data_master_gudang_for_combobox()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim sql As String
        Dim datareader_mysql_local As MySqlDataReader
        Try
            If con_mysql_ret_data_master_gudang_for_combobox.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_data_master_gudang_for_combobox = New MySqlConnection(config_db)
                con_mysql_ret_data_master_gudang_for_combobox.Open()
                MySqlConnection.ClearPool(con_mysql_ret_data_master_gudang_for_combobox)
                con_mysql_ret_data_master_gudang_for_combobox.ClearAllPoolsAsync()
                With cmd_mysql_ret_data_master_gudang_for_combobox
                    .Connection = con_mysql_ret_data_master_gudang_for_combobox
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

        Try
            sql = "select `nama_gudang` from `master_gudang` order by `nama_gudang` asc"
            cmd_mysql_ret_data_master_gudang_for_combobox = encapsulate_mysql_exec(sql, con_mysql_ret_data_master_gudang_for_combobox, cmd_mysql_ret_data_master_gudang_for_combobox)
            datareader_mysql_local = cmd_mysql_ret_data_master_gudang_for_combobox.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function

    Public Function ret_similar_data_in_db_for_2col(ByVal table_name As String, ByVal column_name1 As String, ByVal column_name2 As String, ByVal val_str1 As String, ByVal val_str2 As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim retme As Integer
        retme = 0
        Try
            con_mysql = mysql_connect()
            Dim sql = "select count(*) from `" + table_name + "` where `" + column_name1 + "` like '" + val_str1 + "' and `" + column_name2 + "` like '" + val_str2 + "'"
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return retme
    End Function

    Public Function ret_similar_data_in_db(ByVal table_name As String, ByVal column_name As String, ByVal val_str As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim retme As Integer
        retme = 0
        Try
            con_mysql = mysql_connect()
            Dim sql = "select count(*) from `" + table_name + "` where `" + column_name + "` like '" + val_str + "'"
            Try
                Dim cmd As New MySqlCommand(sql, con_mysql)
                retme = cmd.ExecuteScalar()
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return retme
    End Function

    Public Function mysql_exec(ByVal sql As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            Dim try_con As Integer
            try_con = 0
            While con_mysql.State = ConnectionState.Closed
                mysql_connect()
                try_con = try_con + 1
                If try_con > 5 Then
                    Exit While
                End If
            End While
            cmd_mysql.Connection = con_mysql
            cmd_mysql.CommandText = sql
            cmd_mysql.Prepare()
            cmd_mysql.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Return 1
    End Function

    Public Function login_process(ByVal plain_username As String, ByVal plain_pass As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        'stored results
        Dim datareader_mysql_local As MySqlDataReader
        Dim cred_ar(1) As String
        cred_ar(0) = "nologin"
        cred_ar(1) = "nolevel"
        Dim enkrip_obj As New Crypto
        Dim basic_op As New basic_op
        Dim valid As Integer
        Dim md5_pass As String
        Dim sql As String
        valid = basic_op.validasi_login(plain_username, plain_pass)
        If valid = 0 Then
            MsgBox("Maaf login atau password tidak valid, silahkan diisi untuk login")
        Else
            md5Hash = MD5.Create()
            md5_pass = enkrip_obj.GetMd5Hash(md5Hash, plain_pass)
            sql = "select user, level from `master_user` where `user` like '" + plain_username + "' and `password` like '" + md5_pass + "' order by `id` desc limit 0,1"
            Try
                If con_mysql_login_process.State = ConnectionState.Closed Then
                    Call _set_init_db_str()
                    Me.con_mysql_login_process = New MySqlConnection(config_db)
                    con_mysql_login_process.Open()
                    MySqlConnection.ClearPool(con_mysql_login_process)
                    con_mysql_login_process.ClearAllPoolsAsync()
                    With cmd_mysql_login_process
                        .Connection = con_mysql_login_process
                        .CommandTimeout = 15
                    End With
                End If
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try
            Try
                cmd_mysql_login_process = encapsulate_mysql_exec(sql, con_mysql_login_process, cmd_mysql_login_process)
                datareader_mysql_local = cmd_mysql_login_process.ExecuteReader()
                If datareader_mysql_local.Read() Then
                    cred_ar(0) = datareader_mysql_local(0).ToString()
                    cred_ar(1) = datareader_mysql_local(1).ToString()
                    datareader_mysql_local.Close()
                    con_mysql_login_process.Close()
                Else
                    MsgBox("Maaf login atau password tidak ditemukan di database, silahkan ulangi")
                End If
            Catch ex As Exception
                Console.WriteLine(methodName)
                Console.WriteLine(ex.ToString)
            End Try

        End If
        Return cred_ar
    End Function

    'taken from http://harley-ilmupengetahuan.blogspot.co.id/2013/07/membuat-format-rupiah-di-textbox-vb-2010.html

    Public Function format_num(ByVal data As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim f As Long
            If IsNumeric(data) Then
                f = data
                data = Format(f, "##,##0")
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

        Return data
    End Function

    Public Function ret_all_from_colval(ByVal table_name As String, ByVal column_name As String, ByVal val_condition As String)
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Dim sql As String
        Dim datareader_mysql_local As MySqlDataReader

        Try
            If con_mysql_ret_all_from_colval.State = ConnectionState.Closed Then
                Call _set_init_db_str()
                Me.con_mysql_ret_all_from_colval = New MySqlConnection(config_db)
                con_mysql_ret_all_from_colval.Open()
                MySqlConnection.ClearPool(con_mysql_ret_all_from_colval)
                con_mysql_ret_all_from_colval.ClearAllPoolsAsync()
                With cmd_mysql_ret_all_from_colval
                    .Connection = con_mysql_ret_all_from_colval
                    .CommandTimeout = 15
                End With
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
        Try
            sql = "select * from `" + table_name + "` where `" + column_name + "` like '" + val_condition + "' order by `id` desc limit 0,1"
            cmd_mysql_ret_all_from_colval = encapsulate_mysql_exec(sql, con_mysql_ret_all_from_colval, cmd_mysql_ret_all_from_colval)
            datareader_mysql_local = cmd_mysql_ret_all_from_colval.ExecuteReader()
            Return datareader_mysql_local
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 0
        End Try
    End Function


End Class
