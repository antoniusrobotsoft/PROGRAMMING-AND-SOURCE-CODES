Imports MySql.Data.MySqlClient
Imports System
Imports System.Security.Cryptography
Imports System.Text

Public Class form_master_data_user_add
    Public md5Hash As MD5
    Dim enkrip_obj As New Crypto
    Public Property added_data As Integer
    Public data_obj As New data_object
    Public basic_op As New basic_op
    Public con_mysql As New MySqlConnection()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call clear_data()

    End Sub

    Public Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.SelectedIndex = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim sql_str As String
            If (Len(TextBox1.Text) < 1) Then
                MsgBox("Username harus diisi")
            ElseIf (Len(TextBox2.Text) < 4) Then
                MsgBox("Panjang password minimal 4 karakter")
            ElseIf (Len(TextBox3.Text) < 4) Then
                MsgBox("Konfirmasi password minimal 4 karakter")
            ElseIf TextBox2.Text <> TextBox3.Text Then
                MsgBox("Maaf password dan konfirmasi password harus sama")
            Else
                md5Hash = MD5.Create()
                Dim password = enkrip_obj.GetMd5Hash(md5Hash, TextBox2.Text)
                Dim level = ComboBox1.SelectedItem
                Dim user = TextBox1.Text
                Dim nama_lengkap = TextBox4.Text
                Dim hp = TextBox5.Text
                Dim count_row As Integer
                count_row = 0
                count_row = data_obj.ret_similar_data_in_db("master_user", "user", user)
                If count_row < 1 Then
                    sql_str = "INSERT INTO `master_user` (`id`, `user`, `password`, `level`, `nama_lengkap`, `hp`) VALUES (NULL, '" + user + "', '" + password + "', '" + level + "', '" + nama_lengkap + "', '" + hp + "');"
                    Try
                        added_data = 1
                        data_obj.mysql_just_exec(sql_str)
                        Console.Beep(4000, 100)
                        Me.Hide()
                        Call clear_data()
                    Catch ex As Exception
                        basic_op.gagal_inputdb()
                        Me.Hide()
                    End Try
                Else
                    Dim fail_msg = "Data user : " + user + " sudah ada di database !"
                    MsgBox(fail_msg)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try


    End Sub

    Private Sub form_master_data_user_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Call clear_data()

            If ComboBox1.Items.Count > 0 Then
                ComboBox1.SelectedIndex = 1
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub


End Class