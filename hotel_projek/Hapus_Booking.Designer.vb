﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Booking
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
        Me.BtnHapusBooking = New System.Windows.Forms.Button()
        Me.LblNamaTamu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapusBooking
        '
        Me.BtnHapusBooking.Location = New System.Drawing.Point(214, 216)
        Me.BtnHapusBooking.Name = "BtnHapusBooking"
        Me.BtnHapusBooking.Size = New System.Drawing.Size(114, 33)
        Me.BtnHapusBooking.TabIndex = 7
        Me.BtnHapusBooking.Text = "Hapus "
        Me.BtnHapusBooking.UseVisualStyleBackColor = True
        '
        'LblNamaTamu
        '
        Me.LblNamaTamu.AutoSize = True
        Me.LblNamaTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaTamu.Location = New System.Drawing.Point(220, 155)
        Me.LblNamaTamu.Name = "LblNamaTamu"
        Me.LblNamaTamu.Size = New System.Drawing.Size(100, 20)
        Me.LblNamaTamu.TabIndex = 6
        Me.LblNamaTamu.Text = "Nama Tamu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apakah Anda ingin menghapus data ini?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Form Menghapus Data Booking" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Hapus_Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 273)
        Me.Controls.Add(Me.BtnHapusBooking)
        Me.Controls.Add(Me.LblNamaTamu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Booking"
        Me.Text = "Hapus_Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapusBooking As Button
    Friend WithEvents LblNamaTamu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class