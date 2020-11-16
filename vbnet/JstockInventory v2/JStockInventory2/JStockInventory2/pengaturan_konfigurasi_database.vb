Imports MySql.Data.MySqlClient
Imports System.Math
Imports System.IO


Public Class pengaturan_konfigurasi_database
    Public data_obj As New data_object
    Public datatable_mysql = New DataTable
    Public basic_op As New basic_op

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim app_path As String
            app_path = basic_op.jstock_read_config()

            If Len(text_host.Text) < 1 Then
                MsgBox("host harus diisi !")
            ElseIf Len(text_username.Text) < 1 Then
                MsgBox("nama user harus diisi !")
            ElseIf Len(text_database.Text) < 1 Then
                MsgBox("nama database harus diisi !")
            ElseIf text_password.Text <> text_konfirmasi_password.Text Then
                MsgBox("kata sandi dan konfirmasi kata sandi berbeda !")
            Else
                Try
                    Using sw As New StreamWriter(app_path & "\cfg\db.txt")
                        Dim str_host As String
                        Dim str_database As String
                        Dim str_username As String
                        Dim str_password As String
                        str_host = "host=" + text_host.Text.Trim()
                        str_username = "username=" + text_username.Text.Trim()
                        str_database = "database=" + text_database.Text.Trim()
                        str_password = "password=" + text_password.Text.Trim()
                        sw.WriteLine(str_host)
                        sw.WriteLine(str_database)
                        sw.WriteLine(str_username)
                        sw.WriteLine(str_password)
                    End Using
                    MsgBox("Konfigurasi berhasil disimpan !")
                Catch ex As Exception
                    MsgBox(ex.Message)

                    Console.WriteLine(ex.Message)
                End Try
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub



    Private Sub pengaturan_konfigurasi_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim app_path As String
            app_path = basic_op.jstock_read_config()

            If My.Computer.FileSystem.FileExists(app_path & "\cfg\db.txt") Then
                Dim ret_array(4) As String
                ret_array = basic_op.read_db_cfg()
                text_host.Text = ret_array(0)
                text_database.Text = ret_array(1)
                text_username.Text = ret_array(2)
                text_password.Text = ret_array(3)
                text_konfirmasi_password.Text = ret_array(3)
            Else
                MsgBox("File konfigurasi " & app_path & "\cfg\db.txt tidak ditemukan ! ")
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class