<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnTamu = New System.Windows.Forms.Button()
        Me.btnKamar = New System.Windows.Forms.Button()
        Me.btnJenisKamar = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTamu
        '
        Me.btnTamu.Location = New System.Drawing.Point(33, 30)
        Me.btnTamu.Name = "btnTamu"
        Me.btnTamu.Size = New System.Drawing.Size(203, 42)
        Me.btnTamu.TabIndex = 0
        Me.btnTamu.Text = "Tamu"
        Me.btnTamu.UseVisualStyleBackColor = True
        '
        'btnKamar
        '
        Me.btnKamar.Location = New System.Drawing.Point(33, 96)
        Me.btnKamar.Name = "btnKamar"
        Me.btnKamar.Size = New System.Drawing.Size(203, 42)
        Me.btnKamar.TabIndex = 1
        Me.btnKamar.Text = "Kamar"
        Me.btnKamar.UseVisualStyleBackColor = True
        '
        'btnJenisKamar
        '
        Me.btnJenisKamar.Location = New System.Drawing.Point(33, 164)
        Me.btnJenisKamar.Name = "btnJenisKamar"
        Me.btnJenisKamar.Size = New System.Drawing.Size(203, 42)
        Me.btnJenisKamar.TabIndex = 2
        Me.btnJenisKamar.Text = "Jenis Kamar"
        Me.btnJenisKamar.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(33, 230)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(203, 42)
        Me.btnBooking.TabIndex = 3
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogout.Location = New System.Drawing.Point(33, 303)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(203, 42)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 373)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.btnJenisKamar)
        Me.Controls.Add(Me.btnKamar)
        Me.Controls.Add(Me.btnTamu)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTamu As Button
    Friend WithEvents btnKamar As Button
    Friend WithEvents btnJenisKamar As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnLogout As Button
End Class
