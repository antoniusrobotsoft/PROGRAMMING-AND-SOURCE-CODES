Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.Environment

Public Class form_login
    Public data_obj As New data_object
    Public basic_op As New basic_op
    Private Sub tombol_keluar_Click(sender As Object, e As EventArgs) Handles tombol_keluar.Click
        End
    End Sub

    Public Sub do_login()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim plain_username As String
            Dim plain_pass As String
            Dim cred_ar(1) As String
            cred_ar(0) = "nologin"
            cred_ar(1) = "nolevel"

            plain_username = text_username.Text
            plain_pass = text_password.Text
            Try
                cred_ar = data_obj.login_process(plain_username, plain_pass)

            Catch ex As Exception
                data_obj.cmd_mysql_login_process.Dispose()
                data_obj.con_mysql_login_process.Close()
                cred_ar = data_obj.login_process(plain_username, plain_pass)
            End Try

            If cred_ar(0) <> "nologin" Then
                If cred_ar(1) = "operator" Then
                    form_utama_operator.Show()
                ElseIf cred_ar(1) = "admin" Then
                    form_utama.Show()
                End If
            End If

        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Private Sub tombol_login_Click(sender As Object, e As EventArgs) Handles tombol_login.Click
        Call do_login()
    End Sub

    Private Overloads Sub text_password_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_password.KeyDown
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            If Len(text_password.Text) > 1 Then
                If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Call do_login()
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
