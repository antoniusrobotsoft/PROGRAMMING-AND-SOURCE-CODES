Imports MySql.Data.MySqlClient
Public Class form_master_data_customer_add
    Public Property added_data As Integer
    Public data_obj As New data_object
    Public basic_op As New basic_op
    Public con_mysql As New MySqlConnection()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(TextBox1.Text) < 1 Then
                MsgBox("Nama harus diisi !")
            ElseIf Len(TextBox2.Text) < 1 Then
                MsgBox("Telpon harus diisi !")
            ElseIf Len(TextBox3.Text) < 1 Then
                MsgBox("Alamat harus diisi !")
            Else
                Dim nama = TextBox1.Text
                Dim telpon = TextBox2.Text
                Dim alamat = TextBox3.Text
                Dim hp = TextBox7.Text
                Dim email = TextBox8.Text
                Dim count_row As Integer
                count_row = 0
                count_row = data_obj.ret_similar_data_in_db_for_2col("master_customer", "email", "nama", email, nama)
                If (count_row < 1) Then
                    Dim sql_str = "INSERT INTO `master_customer` (`id`, `nama`, `telpon`, `alamat`,  `hp`, `email`) VALUES (NULL, '" + nama + "', '" + telpon + "', '" + alamat + "', '" + hp + "', '" + email + "');"
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
                    Dim fail_msg = "Data customer dengan nama : " + nama + "  dan email : " + email + "sudah ada di database !"
                    MsgBox(fail_msg)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try


    End Sub
    Public Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call clear_data()
    End Sub

    Private Sub form_master_data_customer_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clear_data()
    End Sub
End Class