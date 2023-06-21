using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectKasir.Model;
using ProjectKasir.Service;

namespace ProjectKasir.Handler
{
    public class ProdukHandler
    {
        private readonly ProdukService _produkService;

        public ProdukHandler(ProdukService produkService)
        {
            _produkService = produkService;
        }

        public IEnumerable<Produk> GetAllProduk()
        {
            return _produkService.GetAllProduk();
        }

        public Produk GetProdukById(string id)
        {
            return _produkService.GetProdukById(id);
        }

        public async Task<string> InsertProduk(Produk produk)
        {
            produk.KodeProduk = Guid.NewGuid().ToString();
            _produkService.InsertProduk(produk);
            await Task.CompletedTask;
            return produk.KodeProduk;
        }

        public async Task UpdateProduk(string id, Produk produk)
        {
            var existingProduk = _produkService.GetProdukById(id);
            if (existingProduk != null)
            {
                existingProduk.NamaProduk = produk.NamaProduk;
                existingProduk.HargaJual = produk.HargaJual;
                existingProduk.Stok = produk.Stok;
                _produkService.UpdateProduk(existingProduk);
            }
            await Task.CompletedTask;
        }

        public async Task DeleteProduk(string id)
        {
            var existingProduk = _produkService.GetProdukById(id);
            if (existingProduk != null)
            {
                _produkService.DeleteProduk(id);
            }
            await Task.CompletedTask;
        }
    }
}
