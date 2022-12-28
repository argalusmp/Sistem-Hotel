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
        sqlCommand.CommandText = "SELECT id_booking AS 'ID Booking', 
                                  id_tamu AS 'ID Tamu', 
                                  id_kamar AS 'ID Kamar', 
                                  check_in AS 'Check-In', 
                                  total_bayar AS 'Price',
                                  status AS 'Status',
                                  tamu.nama AS 'Nama'
                                  FROM booking_kamar
                                  INNER JOIN tamu ON booking_kamar.id_tamu = tamu.id_tamu"


        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function



End Class
