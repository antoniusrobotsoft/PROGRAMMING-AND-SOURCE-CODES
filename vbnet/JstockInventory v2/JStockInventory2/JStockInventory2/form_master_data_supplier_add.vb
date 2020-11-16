Imports MySql.Data.MySqlClient

Public Class form_master_data_supplier_add
    Public Property added_data As Integer
    Public data_obj As New data_object
    Public basic_op As New basic_op
    Public con_mysql As New MySqlConnection()

    Public Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call clear_data()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(TextBox1.Text) < 1 Then
                MsgBox("nama perusahaan harus diisi !")
            ElseIf Len(TextBox5.Text) < 1 Then
                MsgBox("nomor telpon harus diisi !")
            Else
                Dim nama_perusahaan = TextBox1.Text
                Dim alamat = TextBox2.Text
                Dim contact_person = TextBox3.Text
                Dim email = TextBox4.Text
                Dim telp = TextBox5.Text
                Dim fax = TextBox7.Text
                Dim hp = TextBox8.Text
                Dim count_row As Integer
                count_row = 0
                count_row = data_obj.ret_similar_data_in_db_for_2col("master_supplier", "email", "telp", email, telp)
                If (count_row < 1) Then

                    Dim sql_str = "INSERT INTO `master_supplier` (`id`, `nama_perusahaan`, `alamat`, `contact_person`, `email`, `telp`,  `fax`, `hp`) VALUES (NULL, '" + nama_perusahaan + "', '" + alamat + "', '" + contact_person + "', '" + email + "', '" + telp + "', '" + fax + "', '" + hp + "');"
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
                    Dim fail_msg = "Data supplier dengan nomor telpon : " + telp + "  dan email : " + email + "sudah ada di database !"
                    MsgBox(fail_msg)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub form_master_data_supplier_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clear_data()
    End Sub
End Class