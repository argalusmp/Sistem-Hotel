Imports MySql.Data.MySqlClient
Public Class Class_Kamar
    Private IdKamar As Integer
    Private IdJenisKamar As Integer
    Private NamaKamar As String
    Private Status As String
    'Private kamarDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"

    Public Property GSIdKamar As Integer
        Get
            Return IdKamar
        End Get
        Set(value As Integer)
            IdKamar = value
        End Set
    End Property

    Public Property GSIdJenisKamar As Integer
        Get
            Return IdJenisKamar
        End Get
        Set(value As Integer)
            IdJenisKamar = value
        End Set
    End Property

    Public Property GSNamaKamar As String
        Get
            Return NamaKamar
        End Get
        Set(value As String)
            NamaKamar = value
        End Set
    End Property

    Public Property GSStatus As Boolean
        Get
            Return Status
        End Get
        Set(value As Boolean)
            Status = value
        End Set
    End Property

    Public Function GetIDJenisKamar() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_kamar AS `ID Jenis Kamar` FROM kamar;"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(SqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function GetDataKamarDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_kamar AS `ID Jenis Kamar`,
                                  id_kamar AS `ID Kamar`,
                                  nama_kamar AS `Nama Kamar`,
                                  status AS 'Status'
                                  FROM kamar;"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(SqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKamarDatabase(id_jenis_kamar As Integer,
                                         id_kamar As Integer,
                                         nama_kamar As String,
                                         status As Boolean)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO kamar (id_jenis_kamar, id_kamar, nama_kamar, status) VALUE(`" _
                         & id_jenis_kamar & "`,`" _
                         & id_kamar & "`,`" _
                         & nama_kamar & "`,`" _
                         & status & "`)"

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

    Public Function GetDataKamarByIDDatabase(id_kamar As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "Select id_jenis_kamar As `ID Jenis Kamar`,
                                  id_kamar AS `ID Kamar`,
                                  nama_kamar As `Nama Kamar`,
                                  Status AS 'Status'
                                  From kamar WHERE id_kamar=`" & id_kamar & "`;"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetBoolean(3))
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function UpadateDataKamarByIDDatabase(id_jenis_kamar As Integer,
                                                id_kamar As Integer,
                                                nama_kamar As String,
                                                status As Boolean)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE kamar SET " &
                        "id_jenis_kamar= `" & id_jenis_kamar & "`," &
                        "id_kamar= `" & id_kamar & "`," &
                        "nama_kamar= `" & nama_kamar & "`," &
                        "status= `" & status & "` " &
                        "WHERE id_kamar =`" & id_kamar & "`"


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

End Class
