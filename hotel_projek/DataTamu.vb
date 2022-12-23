Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataTamu
    Public Shared nik As Integer
    Public Shared nama As String
    Public Shared jenis_kelamin As String
    Public Shared alamat As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"

    Public Function GetDataTamuDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_tamu AS 'ID Tamu', 
                                  nik AS 'NIK', 
                                  nama AS 'Nama', 
                                  alamat AS 'Alamat', 
                                  jenis_kelamin AS 'jenis_kelamin' 
                                  FROM tamu"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataTamuDatabase(nik As Integer,
                                        nama As String,
                                        alamat As String,
                                        jenis_kelamin As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO tamu (nik, nama, alamat, jenis_kelamin)
                        VALUE('" _
                        & nik & "', '" _
                        & nama & "', '" _
                        & alamat & "', '" _
                        & jenis_kelamin & "')"

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

    Public Function GetDataTamuByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_tamu,
                                  nik,
                                  nama, 
                                  alamat,
                                  jenis_kelamin
                                  FROM tamu 
                                  WHERE id_tamu ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataTamuByIDDatabase(ID As Integer,
                                               nik As Integer,
                                               nama As String,
                                               alamat As String,
                                               jenis_kelamin As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE tamu SET " &
                        "nik='" & nik & "', " &
                        "nama='" & nama & "', " &
                        "alamat='" & alamat & "', " &
                        "jenis_kelamin='" & jenis_kelamin & "', " &
                        "WHERE id_tamu='" & ID & "'"

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

    Public Function DeleteDataTamuByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM tamu " &
                        "WHERE id_tamu='" & ID & "'"

            Debug.WriteLine(sqlQuery)

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


    Public Property GSNIK() As Integer
        Get
            Return nik
        End Get
        Set(value As Integer)
            nik = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSJenisKelamin() As String
        Get
            Return jenis_kelamin
        End Get
        Set(value As String)
            jenis_kelamin = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

End Class
