
Imports System.Data.SqlClient

Public Class Kayıt
    Dim cmd1 As New SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(tel.Text) = False Then
            MsgBox("sayi gir")

            Exit Sub

        End If

        cmd1.Parameters.Clear()
        cmd1.CommandText = "insert into kayıtekleme (Tarih,Ad,Soyad,Meslek,Telefon) values (@Tarih,@Ad,@Soyad,@Meslek,@Telefon)"
        cmd1.Connection = baglan
        cmd1.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = tarih.Value
        cmd1.Parameters.Add("@Ad", SqlDbType.VarChar).Value = ad.Text
        cmd1.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = soyad.Text
        cmd1.Parameters.Add("@Meslek", SqlDbType.VarChar).Value = meslek.Text
        cmd1.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = tel.Text
        cmd1.ExecuteNonQuery()
        Form1.Ekle()
        MessageBox.Show(" Kayıt Eklendi")



        Me.Close()
    End Sub
End Class