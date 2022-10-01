Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Form1

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.Close()

    End Sub

    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            baglan.ConnectionString = "Data Source=DESKTOP-HNPHR2I,1453;Network Library=DBMSSOCN;MultipleActiveResultSets=True;  initial catalog=denemeee;User ID=sa;Password=1453"
            baglan.Open()

        Catch ex As Exception

        End Try

        Ekle()


    End Sub

    Sub Ekle()
        cmd.Parameters.Clear()
        ds.Reset()
        cmd.CommandText = "select * from kayıtekleme"
        cmd.Connection = baglan
        adp.SelectCommand = cmd
        adp.Fill(ds, "Veri")
        DataGridView1.DataSource = ds.Tables("Veri")



    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        baglan.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Kayıt.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Guncelle.tarih.Value = DataGridView1.CurrentRow.Cells("Tarih").Value
        Guncelle.ad.Text = DataGridView1.CurrentRow.Cells("Ad").Value
        Guncelle.soyad.Text = DataGridView1.CurrentRow.Cells("Soyad").Value
        Guncelle.tel.Text = DataGridView1.CurrentRow.Cells("Telefon").Value
        Guncelle.meslek.Text = DataGridView1.CurrentRow.Cells("Meslek").Value
        Guncelle.ıd.Text = DataGridView1.CurrentRow.Cells("id").Value
        Guncelle.Show()



    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        cmd.Parameters.Clear()
        cmd.CommandText = "delete from kayıtekleme where id=@id"
        cmd.Connection = baglan
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = DataGridView1.CurrentRow.Cells("id").Value
        cmd.ExecuteNonQuery()
        Ekle()


    End Sub



    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)




    End Sub
End Class
