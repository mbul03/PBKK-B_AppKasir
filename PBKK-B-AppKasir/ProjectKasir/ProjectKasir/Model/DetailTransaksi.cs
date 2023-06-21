using System;

namespace Model
{
    public class DetailTransaksi
    {
        public string KodeTransaksi { get; set; }
        public string KodeProduk { get; set; }
        public int Jumlah { get; set; }
        public double TotalHargaPerProduk { get; set; }
    }
}
