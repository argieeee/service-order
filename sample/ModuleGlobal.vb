Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Module ModuleGlobal
    Private tripleDes As New TripleDESCryptoServiceProvider
    Public Function fnConnectToDatabase() As Boolean
        Try
            'database credentials
            servername = "sql12.freesqldatabase.com"
            databasename = "sql12721372"
            databaseuserid = "sql12721372"
            databasepassword = "uVH4MGf38a"
            port = "3306"

            If connection.State = ConnectionState.Closed Then
                connection = New MySqlConnection

                strConnection = "SERVER=" & servername & ";" _
                                & "DATABASE=" & databasename & ";" _
                                & "USERNAME=" & databaseuserid & ";" _
                                & "PASSWORD=" & databasepassword & ";" _
                                & "PORT=" & port & ";" _
                                & "DEFAULT COMMAND TIMEOUT=" & 20 * 60
                connection.ConnectionString = strConnection
                connection.Open()
                command.Connection = connection
                Return True
            Else
                connection.Close()
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        Return False
    End Function

    Public Sub checkDatabaseConnection()
        If fnConnectToDatabase() = True Then
        Else
            connection.Open()
        End If
    End Sub

    Public Function encryptdata(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(),
        System.Security.Cryptography.CryptoStreamMode.Write)


        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function


End Module