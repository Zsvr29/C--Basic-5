<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kayıt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ad = New System.Windows.Forms.TextBox()
        Me.soyad = New System.Windows.Forms.TextBox()
        Me.meslek = New System.Windows.Forms.TextBox()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.tarih = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ad :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Soyad :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Meslek :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefon :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tarih :"
        '
        'ad
        '
        Me.ad.Location = New System.Drawing.Point(89, 68)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(100, 22)
        Me.ad.TabIndex = 5
        '
        'soyad
        '
        Me.soyad.Location = New System.Drawing.Point(89, 108)
        Me.soyad.Name = "soyad"
        Me.soyad.Size = New System.Drawing.Size(100, 22)
        Me.soyad.TabIndex = 6
        '
        'meslek
        '
        Me.meslek.Location = New System.Drawing.Point(89, 145)
        Me.meslek.Name = "meslek"
        Me.meslek.Size = New System.Drawing.Size(100, 22)
        Me.meslek.TabIndex = 7
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(89, 184)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(100, 22)
        Me.tel.TabIndex = 8
        '
        'tarih
        '
        Me.tarih.Location = New System.Drawing.Point(89, 223)
        Me.tarih.Name = "tarih"
        Me.tarih.Size = New System.Drawing.Size(200, 22)
        Me.tarih.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Kapat"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Kayıt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 394)
        Me.Controls.Add(Me.Button2)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Kayıt"
        Me.Text = "                                                                                 " &
    "Kayıt Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ad As TextBox
    Friend WithEvents soyad As TextBox
    Friend WithEvents meslek As TextBox
    Friend WithEvents tel As TextBox
    Friend WithEvents tarih As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
