using System;

namespace Model
{
    public class Transaksi
    {
        public string KodeTransaksi { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public double TotalHarga { get; set; }
    }
}
