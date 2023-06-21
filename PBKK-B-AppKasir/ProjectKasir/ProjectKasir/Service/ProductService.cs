using System.Collections.Generic;
using ProjectKasir.Model;
using ProjectKasir.Repository;

namespace ProjectKasir.Service
{
    public class ProdukService
    {
        private readonly IRepository<Produk> _produkRepository;

        public ProdukService(IRepository<Produk> produkRepository)
        {
            _produkRepository = produkRepository;
        }

        public IEnumerable<Produk> GetAllProduk()
        {
            return _produkRepository.GetAll();
        }

        public Produk GetProdukById(string id)
        {
            return _produkRepository.GetById(id);
        }

        public void InsertProduk(Produk produk)
        {
            _produkRepository.Insert(produk);
        }

        public void UpdateProduk(Produk produk)
        {
            _produkRepository.Update(produk);
        }

        public void DeleteProduk(string id)
        {
            _produkRepository.Delete(id);
        }
    }
}
