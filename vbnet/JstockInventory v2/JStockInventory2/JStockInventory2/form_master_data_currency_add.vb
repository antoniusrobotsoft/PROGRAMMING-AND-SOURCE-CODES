Imports MySql.Data.MySqlClient

Public Class form_master_data_currency_add
    Public Property added_data = 0
    Public data_obj As New data_object
    Public datatable_mysql = New DataTable
    Public basic_op As New basic_op

    Public Sub clear_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub form_master_data_currency_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clear_data()
        added_data = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(TextBox1.Text) < 1 Then
                MsgBox("Nama currency harus diisi")
            ElseIf Len(TextBox2.Text) < 1 Then
                MsgBox("Nilai dalam rupiah harus diisi")
            ElseIf Len(TextBox3.Text) < 1 Then
                MsgBox("Singkatan harus diisi")
            Else
                Dim currency = TextBox1.Text
                Dim to_rp = TextBox2.Text.Replace(",", "")
                Dim abbrv = TextBox3.Text
                Dim count_row As Integer
                count_row = 0
                count_row = data_obj.ret_similar_data_in_db("master_currency", "currency", currency)
                If count_row < 1 Then
                    Dim sql_str = "INSERT INTO `master_currency` (`id`, `currency`, `to_rp`, `abbrv`, `last_update`) VALUES (NULL, '" + currency + "', '" + to_rp + "', '" + abbrv + "', '');"
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
                    Dim fail_msg = "Data currency : " + currency + " sudah ada di database !"
                    MsgBox(fail_msg)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call clear_data()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim fmt As String
            fmt = data_obj.format_num(TextBox2.Text)
            TextBox2.Text = fmt
            TextBox2.SelectionStart = Len(TextBox2.Text)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
End Class