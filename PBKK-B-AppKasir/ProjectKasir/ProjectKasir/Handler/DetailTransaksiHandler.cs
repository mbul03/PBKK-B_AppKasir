using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectKasir.Model;
using ProjectKasir.Service;

namespace ProjectKasir.Handler
{
    public class DetailTransaksiHandler
    {
        private readonly DetailTransaksiService _detailTransaksiService;

        public DetailTransaksiHandler(DetailTransaksiService detailTransaksiService)
        {
            _detailTransaksiService = detailTransaksiService;
        }

        public IEnumerable<DetailTransaksi> GetAllDetailTransaksi()
        {
            return _detailTransaksiService.GetAllDetailTransaksi();
        }

        public DetailTransaksi GetDetailTransaksiByNoTransaksiAndKodeProduk(string noTransaksi, string kodeProduk)
        {
            return _detailTransaksiService.GetDetailTransaksiByNoTransaksiAndKodeProduk(noTransaksi, kodeProduk);
        }

        public async Task InsertDetailTransaksi(DetailTransaksi detailTransaksi)
        {
            _detailTransaksiService.InsertDetailTransaksi(detailTransaksi);
            await Task.CompletedTask;
        }

        public async Task UpdateDetailTransaksi(string noTransaksi, string kodeProduk, DetailTransaksi detailTransaksi)
        {
            var existingDetailTransaksi = _detailTransaksiService.GetDetailTransaksiByNoTransaksiAndKodeProduk(noTransaksi, kodeProduk);
            if (existingDetailTransaksi != null)
            {
                existingDetailTransaksi.Jumlah = detailTransaksi.Jumlah;
                existingDetailTransaksi.Subtotal = detailTransaksi.Subtotal;
                _detailTransaksiService.UpdateDetailTransaksi(existingDetailTransaksi);
            }
            await Task.CompletedTask;
        }

        public async Task DeleteDetailTransaksi(string noTransaksi, string kodeProduk)
        {
            var existingDetailTransaksi = _detailTransaksiService.GetDetailTransaksiByNoTransaksiAndKodeProduk(noTransaksi, kodeProduk);
            if (existingDetailTransaksi != null)
            {
                _detailTransaksiService.DeleteDetailTransaksi(noTransaksi, kodeProduk);
            }
            await Task.CompletedTask;
        }
    }
}
