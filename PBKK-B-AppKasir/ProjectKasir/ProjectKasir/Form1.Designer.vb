<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Keranjang Belanja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Bayar"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(15, 25)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(600, 200)
        Me.dataGridView1.TabIndex = 3
        '
        'dataGridView2
        '
        Me.dataGridView2.AllowUserToAddRows = False
        Me.dataGridView2.AllowUserToDeleteRows = False
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView2.Location = New System.Drawing.Point(15, 244)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.Size = New System.Drawing.Size(318, 150)
        Me.dataGridView2.TabIndex = 4
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(15, 400)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(96, 400)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBayar
        '
        Me.btnBayar.Location = New System.Drawing.Point(537, 400)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(75, 23)
        Me.btnBayar.TabIndex = 7
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(177, 402)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(50, 20)
        Me.txtQty.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(412, 225)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(203, 20)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(412, 400)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(100, 20)
        Me.txtBayar.TabIndex = 10
        Me.txtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 442)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dataGridView2)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKasir"
        Me.Text = "Aplikasi Kasir"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents dataGridView2 As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colStok As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colID2 As DataGridViewTextBoxColumn
    Friend WithEvents colNama2 As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colHarga2 As DataGridViewTextBoxColumn

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Koneksi database
        Dim con As New SqlConnection("Data Source=localhost;Initial Catalog=KasirDB;Integrated Security=True")
        con.Open()

        'Mengambil data dari tabel barang
        Dim da As New SqlDataAdapter("SELECT * FROM Barang", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        dataGridView1.DataSource = dt

        'Menambahkan kolom pada tabel keranjang belanja
        dataGridView2.Columns.Add("colID2", "ID")
        dataGridView2.Columns.Add("colNama2", "Nama")
        dataGridView2.Columns.Add("colQty", "Qty")
        dataGridView2.Columns.Add("colHarga2", "Harga")

        'Menentukan lebar kolom pada tabel barang
        dataGridView1.Columns(0).Width = 50
        dataGridView1.Columns(1).Width = 200
        dataGridView1.Columns(2).Width = 50
        dataGridView1.Columns(3).Width = 100

        con.Close()
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        txtQty.Text = "1"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If dataGridView1.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = dataGridView1.SelectedCells(0).RowIndex
            Dim stok As Integer = Convert.ToInt32(dataGridView1.Rows(selectedRowIndex).Cells("colStok").Value)
            If stok > 0 Then
                dataGridView1.Rows(selectedRowIndex).Cells("colStok").Value = stok - 1
                Dim id As String = dataGridView1.Rows(selectedRowIndex).Cells("colID").Value
                Dim nama As String = dataGridView1.Rows(selectedRowIndex).Cells("colNama").Value
                Dim qty As Integer = Convert.ToInt32(txtQty.Text)
                Dim harga As Integer = Convert.ToInt32(dataGridView1.Rows(selectedRowIndex).Cells("colHarga").Value)
                Dim total As Integer = qty * harga
                dataGridView2.Rows.Add(id, nama, qty, total)
                HitungTotal()
            Else
                MessageBox.Show("Stok barang habis!")
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dataGridView2.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = dataGridView2.SelectedCells(0).RowIndex
            Dim id As String = dataGridView2.Rows(selectedRowIndex).Cells("colID2").Value
            For Each row As DataGridViewRow In dataGridView1.Rows
                If row.Cells("colID").Value = id Then
                    row.Cells("colStok").Value = Convert.ToInt32(row.Cells("colStok").Value) + Convert.ToInt32(dataGridView2.Rows(selectedRowIndex).Cells("colQty").Value)
                End If
            Next
            dataGridView2.Rows.RemoveAt(selectedRowIndex)
            HitungTotal()
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If dataGridView2.Rows.Count > 0 Then
            Dim totalBayar As Integer = Convert.ToInt32(txtTotal.Text)
            Dim bayar As Integer = Convert.ToInt32(txtBayar.Text)
            If bayar >= totalBayar Then
                MessageBox.Show("Kembalian: " & (bayar - totalBayar))
                dataGridView2.Rows.Clear()
                txtTotal.Text = ""
                txtBayar.Text = ""
                For Each row As DataGridViewRow In dataGridView1.Rows
                    row.Cells("colStok").Value = 10
                Next
            Else
                MessageBox.Show("Uang yang Anda bayarkan kurang!")
            End If
        End If
    End Sub

    Private Sub HitungTotal()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dataGridView2.Rows
            total += Convert.ToInt32(row.Cells("colHarga2").Value)
        Next
        txtTotal.Text = total.ToString()
    End Sub
End Class


