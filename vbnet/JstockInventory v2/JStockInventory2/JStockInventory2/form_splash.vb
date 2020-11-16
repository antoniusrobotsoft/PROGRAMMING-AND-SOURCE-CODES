Imports JStockInventory2.form_login


Public Class form_splash
    Public data_obj As New data_object
    Public basic_op As New basic_op

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            form_login.Show()

            Me.Hide()
            'form_login.Show()
            Timer1.Enabled = False
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub form_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            data_obj._set_init_db_str()
            basic_op.jstock_app_path = basic_op.jstock_read_config()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub
End Class