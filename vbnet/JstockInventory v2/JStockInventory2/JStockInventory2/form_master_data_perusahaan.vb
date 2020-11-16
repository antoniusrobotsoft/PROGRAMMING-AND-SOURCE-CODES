Imports MySql.Data.MySqlClient

Public Class form_master_data_perusahaan
    Public data_obj As New data_object
    Public basic_op As New basic_op
    Public saved_new_logo As Integer
    Public Property new_logo_name As String
    Public Property saved_data As Integer
    Public datareader_mysql As MySqlDataReader
    Private Sub form_master_data_perusahaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Me.saved_new_logo = 0
            basic_op.jstock_read_config()
            Call loaddata()
            Me.saved_data = 0
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub loaddata()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        Try
            Dim datareader_mysql_local As MySqlDataReader
            Dim nama_perusahaan = ""
            Dim alamat = ""
            Dim telpon = ""
            Dim fax = ""
            Dim email = ""
            Dim website = ""
            Dim motto = ""
            Dim npwp = ""
            Dim logo = ""
            datareader_mysql_local = data_obj.load_single_data_from_table("master_perusahaan")
            If datareader_mysql_local.Read() Then
                nama_perusahaan = datareader_mysql_local(1).ToString()
                alamat = datareader_mysql_local(2).ToString()
                telpon = datareader_mysql_local(3).ToString()
                fax = datareader_mysql_local(4).ToString()
                email = datareader_mysql_local(5).ToString()
                website = datareader_mysql_local(6).ToString()
                motto = datareader_mysql_local(7).ToString()
                npwp = datareader_mysql_local(8).ToString()
                logo = datareader_mysql_local(9).ToString()
                datareader_mysql_local.Dispose()
                data_obj.cmd_mysql_load_single_data_from_table.Dispose()
            End If
            TextBox1.Text = nama_perusahaan
            TextBox2.Text = alamat
            TextBox3.Text = telpon
            TextBox4.Text = fax
            TextBox5.Text = email
            TextBox6.Text = website
            TextBox7.Text = motto
            TextBox8.Text = npwp
            data_obj.img_cat = "logo"
            data_obj.loadimg(Me.PictureBox1, "thumb_" + logo)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim nama_perusahaan As String
            Dim alamat As String
            Dim telp As String
            Dim fax As String
            Dim email As String
            Dim website As String
            Dim motto As String
            Dim npwp As String

            nama_perusahaan = TextBox1.Text
            alamat = TextBox2.Text
            telp = TextBox3.Text
            fax = TextBox4.Text
            email = TextBox5.Text
            website = TextBox6.Text
            motto = TextBox7.Text
            npwp = TextBox8.Text
            If Len(nama_perusahaan) < 1 Then
                MsgBox("Nama perusahaan harus diisi !")
            ElseIf Len(alamat) < 1 Then
                MsgBox("Alamat harus diisi !")
            Else
                Dim ret = 0
                Dim sql = "update `master_perusahaan` set `nama_perusahaan` = '" + nama_perusahaan + "', `alamat` = '" + alamat + "', `telpon` = '" + telp + "', `fax` = '" + fax + "',  `email` = '" + email + "',`website` = '" + website + "',`motto` = '" + motto + "',`npwp` = '" + npwp + "'"
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Me.saved_data = 1 Then
                Call loaddata()
                Me.saved_data = 0
            End If
            If Me.saved_new_logo = 1 Then
                Me.saved_new_logo = 0
                Dim sql = "update `master_perusahaan` set `logo` = '" + Me.new_logo_name + "'"
                data_obj.mysql_just_exec(sql)
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call handle_file_upload()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call handle_file_upload()
    End Sub

    Public Sub handle_file_upload()
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
                data_obj.img_cat = "logo"
                dest_path = app_path & "\img\logo\" & filename
                basic_op.copy_file(orig_path, dest_path)

                Dim thumbnail_path = app_path & "\img\logo\thumb_" & filename
                basic_op.CreateThumbnail(150, dest_path, thumbnail_path)

                data_obj.loadimg(Me.PictureBox1, "thumb_" + filename)
                Me.new_logo_name = filename
                Me.saved_new_logo = 1
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

End Class