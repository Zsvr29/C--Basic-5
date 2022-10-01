<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guncelle
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tarih = New System.Windows.Forms.DateTimePicker()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.meslek = New System.Windows.Forms.TextBox()
        Me.soyad = New System.Windows.Forms.TextBox()
        Me.ad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ıd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Guncelle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tarih
        '
        Me.tarih.Location = New System.Drawing.Point(125, 234)
        Me.tarih.Name = "tarih"
        Me.tarih.Size = New System.Drawing.Size(200, 20)
        Me.tarih.TabIndex = 20
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(125, 195)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(100, 20)
        Me.tel.TabIndex = 19
        '
        'meslek
        '
        Me.meslek.Location = New System.Drawing.Point(125, 156)
        Me.meslek.Name = "meslek"
        Me.meslek.Size = New System.Drawing.Size(100, 20)
        Me.meslek.TabIndex = 18
        '
        'soyad
        '
        Me.soyad.Location = New System.Drawing.Point(125, 119)
        Me.soyad.Name = "soyad"
        Me.soyad.Size = New System.Drawing.Size(100, 20)
        Me.soyad.TabIndex = 17
        '
        'ad
        '
        Me.ad.Location = New System.Drawing.Point(125, 79)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(100, 20)
        Me.ad.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tarih :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Telefon :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Meslek :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Soyad :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ad :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Id : "
        '
        'ıd
        '
        Me.ıd.Location = New System.Drawing.Point(125, 43)
        Me.ıd.Name = "ıd"
        Me.ıd.Size = New System.Drawing.Size(100, 20)
        Me.ıd.TabIndex = 23
        '
        'Guncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 377)
        Me.Controls.Add(Me.ıd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tarih)
        Me.Controls.Add(Me.tel)
        Me.Controls.Add(Me.meslek)
        Me.Controls.Add(Me.soyad)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Guncelle"
        Me.Text = "                                                                                G" &
    "uncelle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents tarih As DateTimePicker
    Friend WithEvents tel As TextBox
    Friend WithEvents meslek As TextBox
    Friend WithEvents soyad As TextBox
    Friend WithEvents ad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ıd As TextBox
End Class
