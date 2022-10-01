Imports System.Data.SqlClient

Public Class Guncelle
    Dim cmd1 As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd1.Parameters.Clear()
        cmd1.CommandText = "update  kayıtekleme set Tarih=@Tarih,Ad=@Ad,Soyad=@Soyad,Meslek=@Meslek,Telefon=@Telefon where id=@id"
        cmd1.Connection = baglan
        cmd1.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = tarih.Value
        cmd1.Parameters.Add("@Ad", SqlDbType.VarChar).Value = ad.Text
        cmd1.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = soyad.Text
        cmd1.Parameters.Add("@Meslek", SqlDbType.VarChar).Value = meslek.Text
        cmd1.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = tel.Text
        cmd1.Parameters.Add("@id", SqlDbType.Int).Value = ıd.Text
        cmd1.ExecuteNonQuery()
        Form1.Ekle()

        Me.Close()

    End Sub

    Private Sub ıd_TextChanged(sender As Object, e As EventArgs) Handles ıd.TextChanged

    End Sub
End Class