Imports System
Imports System.Security.Cryptography
Imports System.Text
' Crypto class taken from msdn microsoft
Class Crypto

    Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try


            ' Convert the input string to a byte array and compute the hash.
            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

            ' Create a new Stringbuilder to collect the bytes
            ' and create a string.
            Dim sBuilder As New StringBuilder()

            ' Loop through each byte of the hashed data 
            ' and format each one as a hexadecimal string.
            Dim i As Integer
            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next i

            ' Return the hexadecimal string.
            Return sBuilder.ToString()
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return 1
        End Try

    End Function
End Class
