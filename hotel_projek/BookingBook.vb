Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class BookingBook

    Private nama_tamu As String
    Private nama_kamar As String
    Private check_in As Date
    Private check_out As Date
    Private total_bayar As Double
    Private status As Boolean

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

    Public Function GetHargaBookingDatabase(nama_kamar As String)
        Dim result As Integer

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        Dim query = "SELECT harga_permalam FROM jenis_kamar 
                    INNER JOIN kamar ON jenis_kamar.id_jenis_kamar = kamar.id_jenis_kamar WHERE kamar.id_kamar = '" & nama_kamar & "'"

        sqlCommand.CommandText = query


        sqlRead = sqlCommand.ExecuteReader()
        While sqlRead.Read()
            result = sqlRead("harga_permalam")
        End While

        MessageBox.Show(result)

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


    Public Function GetDateBookingDatabase(check_in As Date, check_out As Date)
        Dim result As Integer

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT DATEDIFF('" & check_out.ToString("yyyy/MM/dd") & "', ' " & check_in.ToString("yyyy/MM/dd") & "')"


        sqlRead = sqlCommand.ExecuteReader()
        While sqlRead.Read()
            result = sqlRead("DATEDIFF('" & check_out.ToString("yyyy/MM/dd") & "', ' " & check_in.ToString("yyyy/MM/dd") & "')")
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function



    Public Function AddDataBookingDatabase(nama_tamu As String, nama_kamar As String, check_in As Date, check_out As Date)

        Dim status = False
        Dim harga = GetHargaBookingDatabase(nama_kamar)
        Dim jumlah_hari = GetDateBookingDatabase(check_in, check_out)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            Dim jumlah_BAYAR = harga * jumlah_hari

            sqlQuery = "INSERT INTO booking_kamar(id_tamu, id_kamar,check_in,check_out,total_bayar,status) VALUE('" _
                    & nama_tamu & " ', '" _
                    & nama_kamar & " ', '" _
                    & check_in.ToString("yyyy/MM/dd") & " ', '" _
                    & check_out.ToString("yyyy/MM/dd") & " ', '" _
                    & jumlah_BAYAR & " ', '" _
                    & status & "')"

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
        Return result


    End Function

    Public Function GetDataBookingByIDDatabase(id_booking As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT booking_kamar.id_tamu AS 'ID Tamu', 
                                  tamu.nama AS 'Nama Tamu',
                                  booking_kamar.id_kamar AS 'ID Kamar', 
                                  kamar.nama_kamar AS 'Nama Kamar',
                                  booking_kamar.check_in AS 'Check-In', 
                                  booking_kamar.check_out AS 'Check-Out', 
                                  booking_kamar.total_bayar AS 'Price',
                                  booking_kamar.status AS 'Bayar'
                                  FROM booking_kamar 
                                  INNER JOIN tamu ON booking_kamar.id_tamu = tamu.id_tamu
                                  INNER JOIN kamar ON booking_kamar.id_kamar = kamar.id_kamar
                                  WHERE booking_kamar.id_booking=" & id_booking & ";"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetInt32(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetInt32(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetDateTime(4).ToString())
            result.Add(sqlRead.GetDateTime(5).ToString())
            'result.Add(sqlRead.GetInt32(6).ToString())
            result.Add(sqlRead.GetBoolean(7))


        End While



        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function UpdateDataBookingByIDDatabase(id_booking As Integer, nama_tamu As String, nama_kamar As String, check_in As Date, check_out As Date)

        Dim harga = GetHargaBookingDatabase(nama_kamar)
        Dim jumlah_hari = GetDateBookingDatabase(check_in, check_out)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim jumlah_BAYAR = harga * jumlah_hari
            sqlQuery = "UPDATE booking_kamar SET id_tamu = " & nama_tamu & ", " &
                       "id_kamar=" & nama_kamar & ", " &
                        "check_in='" & check_in.ToString("yyyy/MM/dd") & "', " &
                        "check_out='" & check_out.ToString("yyyy/MM/dd") & "' " &
                       "WHERE id_booking = " & id_booking & ";"

            Console.WriteLine("Query Updata " + sqlQuery)


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

    Public Function DeleteDataBookingByIDDatabase(id_booking As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM booking_kamar " &
                        "WHERE id_booking='" & id_booking & "'"

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

    Public Property GSNamaKamar() As String
        Get
            Return nama_kamar
        End Get
        Set(value As String)
            nama_kamar = value
        End Set
    End Property

    Public Property GSNamaTamu() As String
        Get
            Return nama_tamu
        End Get
        Set(value As String)
            nama_tamu = value
        End Set
    End Property

    Public Property GSCheckIn() As Date
        Get
            Return check_in
        End Get
        Set(value As Date)
            check_in = value
        End Set
    End Property

    Public Property GSCheckOut() As Date
        Get
            Return check_out
        End Get
        Set(value As Date)
            check_out = value
        End Set
    End Property

    Public Property GSTotalBayar() As Double
        Get
            Return total_bayar
        End Get
        Set(value As Double)
            total_bayar = value
        End Set
    End Property

    Public Property GSStatus() As Boolean
        Get
            Return status
        End Get
        Set(value As Boolean)
            status = value
        End Set
    End Property



End Class
