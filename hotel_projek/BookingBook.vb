Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class BookingBook


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"


    Public Function GetDataBookingDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT booking_kamar.id_booking AS 'ID Booking', 
                                  booking_kamar.id_tamu AS 'ID Tamu', 
                                  tamu.nama AS 'Nama',
                                  booking_kamar.id_kamar AS 'ID Kamar', 
                                  kamar.nama_kamar AS 'Nama Kamar',
                                  booking_kamar.check_in AS 'Check-In', 
                                  booking_kamar.check_out AS 'Check-Out', 
                                  booking_kamar.total_bayar AS 'Price',
                                  booking_kamar.status AS 'Bayar'
                                  FROM booking_kamar
                                  INNER JOIN tamu ON booking_kamar.id_tamu = tamu.id_tamu
                                  INNER JOIN kamar ON booking_kamar.id_kamar = kamar.id_kamar"


        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataBookingDatabase()

        'dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database

        'Try
        '    dbConn.Open()
        '    sqlCommand.Connection = dbConn
        '    sqlQuery = "INSERT INTO booking_kamar(jenis_kamar, harga_permalam) VALUE('" _
        '            & Jenis_Kamar & " ', '" _
        '            & harga_permalam & "')"

        '    sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        '    sqlRead = sqlCommand.ExecuteReader
        '    dbConn.Close()

        '    sqlRead.Close()
        '    dbConn.Close()


        'Catch ex As Exception
        '    Return ex.Message
        'Finally
        '    dbConn.Dispose()
        'End Try
    End Function

    Public Function getNamaTamu() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nama FROM tamu"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return Result


    End Function




End Class
