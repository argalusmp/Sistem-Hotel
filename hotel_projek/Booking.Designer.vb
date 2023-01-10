<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.DataGridViewBooking = New System.Windows.Forms.DataGridView()
        Me.BtnAddBook = New System.Windows.Forms.Button()
        Me.BtnRemoveBook = New System.Windows.Forms.Button()
        Me.BtnEditBook = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.BtnCheckout = New System.Windows.Forms.Button()
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBooking
        '
        Me.DataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBooking.Location = New System.Drawing.Point(59, 12)
        Me.DataGridViewBooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewBooking.Name = "DataGridViewBooking"
        Me.DataGridViewBooking.RowHeadersWidth = 51
        Me.DataGridViewBooking.RowTemplate.Height = 24
        Me.DataGridViewBooking.Size = New System.Drawing.Size(1185, 297)
        Me.DataGridViewBooking.TabIndex = 0
        '
        'BtnAddBook
        '
        Me.BtnAddBook.Location = New System.Drawing.Point(898, 355)
        Me.BtnAddBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddBook.Name = "BtnAddBook"
        Me.BtnAddBook.Size = New System.Drawing.Size(149, 34)
        Me.BtnAddBook.TabIndex = 1
        Me.BtnAddBook.Text = "Tambah Booking"
        Me.BtnAddBook.UseVisualStyleBackColor = True
        '
        'BtnRemoveBook
        '
        Me.BtnRemoveBook.Location = New System.Drawing.Point(1150, 355)
        Me.BtnRemoveBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRemoveBook.Name = "BtnRemoveBook"
        Me.BtnRemoveBook.Size = New System.Drawing.Size(91, 34)
        Me.BtnRemoveBook.TabIndex = 2
        Me.BtnRemoveBook.Text = "Remove"
        Me.BtnRemoveBook.UseVisualStyleBackColor = True
        '
        'BtnEditBook
        '
        Me.BtnEditBook.Location = New System.Drawing.Point(1053, 355)
        Me.BtnEditBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditBook.Name = "BtnEditBook"
        Me.BtnEditBook.Size = New System.Drawing.Size(91, 34)
        Me.BtnEditBook.TabIndex = 3
        Me.BtnEditBook.Text = "Edit"
        Me.BtnEditBook.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(59, 402)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(94, 36)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "<  Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'BtnCheckout
        '
        Me.BtnCheckout.Location = New System.Drawing.Point(743, 355)
        Me.BtnCheckout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCheckout.Name = "BtnCheckout"
        Me.BtnCheckout.Size = New System.Drawing.Size(149, 34)
        Me.BtnCheckout.TabIndex = 16
        Me.BtnCheckout.Text = "Check Out"
        Me.BtnCheckout.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 450)
        Me.Controls.Add(Me.BtnCheckout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.BtnEditBook)
        Me.Controls.Add(Me.BtnRemoveBook)
        Me.Controls.Add(Me.BtnAddBook)
        Me.Controls.Add(Me.DataGridViewBooking)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Booking"
        Me.Text = "Booking"
        CType(Me.DataGridViewBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewBooking As DataGridView
    Friend WithEvents BtnAddBook As Button
    Friend WithEvents BtnRemoveBook As Button
    Friend WithEvents BtnEditBook As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents BtnCheckout As Button
End Class
