<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Booking
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
        Me.BtnEditBooking = New System.Windows.Forms.Button()
        Me.DateCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBNamaKamar = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBNamaTamu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEditBooking
        '
        Me.BtnEditBooking.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnEditBooking.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEditBooking.Location = New System.Drawing.Point(584, 428)
        Me.BtnEditBooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditBooking.Name = "BtnEditBooking"
        Me.BtnEditBooking.Size = New System.Drawing.Size(88, 37)
        Me.BtnEditBooking.TabIndex = 19
        Me.BtnEditBooking.Text = "Edit "
        Me.BtnEditBooking.UseVisualStyleBackColor = False
        '
        'DateCheckOut
        '
        Me.DateCheckOut.Location = New System.Drawing.Point(313, 348)
        Me.DateCheckOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateCheckOut.Name = "DateCheckOut"
        Me.DateCheckOut.Size = New System.Drawing.Size(359, 22)
        Me.DateCheckOut.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Check Out"
        '
        'DateCheckIn
        '
        Me.DateCheckIn.Location = New System.Drawing.Point(313, 272)
        Me.DateCheckIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateCheckIn.Name = "DateCheckIn"
        Me.DateCheckIn.Size = New System.Drawing.Size(359, 22)
        Me.DateCheckIn.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Check In"
        '
        'CBNamaKamar
        '
        Me.CBNamaKamar.FormattingEnabled = True
        Me.CBNamaKamar.Location = New System.Drawing.Point(313, 201)
        Me.CBNamaKamar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBNamaKamar.Name = "CBNamaKamar"
        Me.CBNamaKamar.Size = New System.Drawing.Size(359, 24)
        Me.CBNamaKamar.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nama Kamar"
        '
        'CBNamaTamu
        '
        Me.CBNamaTamu.FormattingEnabled = True
        Me.CBNamaTamu.Location = New System.Drawing.Point(313, 134)
        Me.CBNamaTamu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBNamaTamu.Name = "CBNamaTamu"
        Me.CBNamaTamu.Size = New System.Drawing.Size(359, 24)
        Me.CBNamaTamu.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Tamu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Edit Booking Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(252, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(252, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = ":"
        '
        'Edit_Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 497)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnEditBooking)
        Me.Controls.Add(Me.DateCheckOut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateCheckIn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBNamaKamar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBNamaTamu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Edit_Booking"
        Me.Text = "Edit_Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEditBooking As Button
    Friend WithEvents DateCheckOut As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateCheckIn As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CBNamaKamar As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBNamaTamu As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
