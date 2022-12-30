
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class DataJenisHotel

    Private nama_jenis_kamar As String
    Private Harga_perMalam As Double


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"

    Public Function GetDataJenisKamarDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database + ";"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_kamar AS 'ID',
                                  jenis_kamar AS 'Jenis Kamar',
                                  harga_permalam AS 'Harga Permalam'
                                  FROM jenis_kamar"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function


    Public Function AddDataJenisKamarDatabase(jenis_kamar As String,
                                           harga_permalam As Double
                                           )

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenis_kamar(jenis_kamar, harga_permalam) VALUE('" _
                    & jenis_kamar & " ', '" _
                    & harga_permalam & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function GetDataJenisKamarByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id= " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_kamar,
                                   jenis_kamar,
                                   harga_permalam
                                   FROM jenis_kamar
                                   WHERE id_jenis_kamar = '" & ID & " ' "

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function UpdateDataJenisKamarByIDDatabase(ID As Integer,
                                                  jenis_kamar As String,
                                                  harga_permalam As Double)


        dbConn.ConnectionString = "server = " + server + ";" + "user id= " + username + ";" _
        + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE jenis_kamar SET " &
                    "jenis_kamar = '" & jenis_kamar & " ', " &
                    "harga_permalam = '" & harga_permalam & "' " &
                    "WHERE id_jenis_kamar='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try
    End Function

    Public Function DeleteDataJenisKamarByIdDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jenis_kamar WHERE id_jenis_kamar='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        End Try
        dbConn.Dispose()
    End Function


    Public Property GSJenisKamar() As String
        Get
            Return nama_jenis_kamar
        End Get
        Set(value As String)
            nama_jenis_kamar = value
        End Set
    End Property

    Public Property GSHarga_PerMalam() As Double
        Get
            Return Harga_perMalam
        End Get
        Set(value As Double)
            Harga_perMalam = value
        End Set
    End Property

End Class
