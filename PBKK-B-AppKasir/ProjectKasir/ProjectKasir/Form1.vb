Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=(local);Initial Catalog=MyDatabase;Integrated Security=True"
    Dim connection As SqlConnection = New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inisialisasi form saat pertama kali dimuat'
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim harga As Double = Double.Parse(txtHarga.Text)
        Dim jumlah As Integer = Integer.Parse(txtJumlah.Text)

        Dim total As Double = harga * jumlah
        txtTotal.Text = total.ToString()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim kodeTransaksi As String = txtKodeTransaksi.Text
        Dim namaPelanggan As String = txtNamaPelanggan.Text
        Dim tanggalTransaksi As Date = Date.Now
        Dim total As Double = Double.Parse(txtTotal.Text)

        'Simpan data ke database'
        connection.Open()

        Dim command As SqlCommand = connection.CreateCommand()
        command.CommandText = "INSERT INTO Transaksi (KodeTransaksi, NamaPelanggan, TanggalTransaksi, Total) VALUES (@kode, @nama, @tanggal, @total)"
        command.Parameters.AddWithValue("@kode", kodeTransaksi)
        command.Parameters.AddWithValue("@nama", namaPelanggan)
        command.Parameters.AddWithValue("@tanggal", tanggalTransaksi)
        command.Parameters.AddWithValue("@total", total)
        command.ExecuteNonQuery()

        connection.Close()

        'Reset form ke kondisi awal'
        txtKodeTransaksi.Text = ""
        txtNamaPelanggan.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtTotal.Text = ""
    End Sub

End Class
