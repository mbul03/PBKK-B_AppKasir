using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectKasir.Model;
using ProjectKasir.Service;

namespace ProjectKasir.Handler
{
    public class TransaksiHandler
    {
        private readonly TransaksiService _transaksiService;
        private readonly DetailTransaksiService _detailTransaksiService;

        public TransaksiHandler(TransaksiService transaksiService, DetailTransaksiService detailTransaksiService)
        {
            _transaksiService = transaksiService;
            _detailTransaksiService = detailTransaksiService;
        }

        public IEnumerable<Transaksi> GetAllTransaksi()
        {
            return _transaksiService.GetAllTransaksi();
        }

        public async Task<string> InsertTransaksi(Transaksi transaksi)
        {
            transaksi.NoTransaksi = Guid.NewGuid().ToString();
            _transaksiService.InsertTransaksi(transaksi);
            foreach (var detailTransaksi in transaksi.DetailTransaksi)
            {
                detailTransaksi.NoTransaksi = transaksi.NoTransaksi;
                _detailTransaksiService.InsertDetailTransaksi(detailTransaksi);
            }
            await Task.CompletedTask;
            return transaksi.NoTransaksi;
        }

        public async Task UpdateTransaksi(string noTransaksi, Transaksi transaksi)
        {
            var existingTransaksi = _transaksiService.GetTransaksiByNoTransaksi(noTransaksi);
            if (existingTransaksi != null)
            {
                existingTransaksi.TanggalTransaksi = transaksi.TanggalTransaksi;
                existingTransaksi.TotalHarga = transaksi.TotalHarga;
                _transaksiService.UpdateTransaksi(existingTransaksi);
                foreach (var detailTransaksi in transaksi.DetailTransaksi)
                {
                    var existingDetailTransaksi = _detailTransaksiService.GetDetailTransaksiByNoTransaksi(noTransaksi, detailTransaksi.KodeProduk);
                    if (existingDetailTransaksi != null)
                    {
                        existingDetailTransaksi.Jumlah = detailTransaksi.Jumlah;
                        existingDetailTransaksi.Subtotal = detailTransaksi.Subtotal;
                        _detailTransaksiService.UpdateDetailTransaksi(existingDetailTransaksi);
                    }
                    else
                    {
                        detailTransaksi.NoTransaksi = noTransaksi;
                        _detailTransaksiService.InsertDetailTransaksi(detailTransaksi);
                    }
                }
            }
            await Task.CompletedTask;
        }

        public async Task DeleteTransaksi(string noTransaksi)
        {
            var existingTransaksi = _transaksiService.GetTransaksiByNoTransaksi(noTransaksi);
            if (existingTransaksi != null)
            {
                _transaksiService.DeleteTransaksi(noTransaksi);
                var detailTransaksiList = _detailTransaksiService.GetAllDetailTransaksi().Where(dt => dt.NoTransaksi == noTransaksi).ToList();
                foreach (var detailTransaksi in detailTransaksiList)
                {
                    _detailTransaksiService.DeleteDetailTransaksi(detailTransaksi.NoTransaksi, detailTransaksi.KodeProduk);
                }
            }
            await Task.CompletedTask;
        }
    }
}
