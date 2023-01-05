<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBNamaTamu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBNamaKamar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.DateCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnTambahBooking = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Tamu"
        '
        'CBNamaTamu
        '
        Me.CBNamaTamu.FormattingEnabled = True
        Me.CBNamaTamu.Location = New System.Drawing.Point(407, 68)
        Me.CBNamaTamu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBNamaTamu.Name = "CBNamaTamu"
        Me.CBNamaTamu.Size = New System.Drawing.Size(219, 24)
        Me.CBNamaTamu.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Kamar"
        '
        'CBNamaKamar
        '
        Me.CBNamaKamar.FormattingEnabled = True
        Me.CBNamaKamar.Location = New System.Drawing.Point(407, 134)
        Me.CBNamaKamar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBNamaKamar.Name = "CBNamaKamar"
        Me.CBNamaKamar.Size = New System.Drawing.Size(219, 24)
        Me.CBNamaKamar.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Check In"
        '
        'DateCheckIn
        '
        Me.DateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateCheckIn.Location = New System.Drawing.Point(407, 206)
        Me.DateCheckIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateCheckIn.Name = "DateCheckIn"
        Me.DateCheckIn.Size = New System.Drawing.Size(219, 22)
        Me.DateCheckIn.TabIndex = 6
        '
        'DateCheckOut
        '
        Me.DateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateCheckOut.Location = New System.Drawing.Point(407, 282)
        Me.DateCheckOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateCheckOut.Name = "DateCheckOut"
        Me.DateCheckOut.Size = New System.Drawing.Size(219, 22)
        Me.DateCheckOut.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Check Out"
        '
        'BtnTambahBooking
        '
        Me.BtnTambahBooking.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahBooking.Location = New System.Drawing.Point(240, 377)
        Me.BtnTambahBooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahBooking.Name = "BtnTambahBooking"
        Me.BtnTambahBooking.Size = New System.Drawing.Size(209, 44)
        Me.BtnTambahBooking.TabIndex = 9
        Me.BtnTambahBooking.Text = "Booking "
        Me.BtnTambahBooking.UseVisualStyleBackColor = True
        '
        'Tambah_Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTambahBooking)
        Me.Controls.Add(Me.DateCheckOut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateCheckIn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBNamaKamar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBNamaTamu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Tambah_Booking"
        Me.Text = "Tambah_Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBNamaTamu As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBNamaKamar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateCheckIn As DateTimePicker
    Friend WithEvents DateCheckOut As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnTambahBooking As Button
End Class
