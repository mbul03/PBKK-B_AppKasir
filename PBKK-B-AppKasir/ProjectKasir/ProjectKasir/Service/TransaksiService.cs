using System.Collections.Generic;
using ProjectKasir.Model;
using ProjectKasir.Repository;

namespace ProjectKasir.Service
{
    public class TransaksiService
    {
        private readonly IRepository<Transaksi> _transaksiRepository;

        public TransaksiService(IRepository<Transaksi> transaksiRepository)
        {
            _transaksiRepository = transaksiRepository;
        }

        public IEnumerable<Transaksi> GetAllTransaksi()
        {
            return _transaksiRepository.GetAll();
        }

        public Transaksi GetTransaksiByNoTransaksi(string noTransaksi)
        {
            return _transaksiRepository.GetById(noTransaksi);
        }

        public void InsertTransaksi(Transaksi transaksi)
        {
            _transaksiRepository.Insert(transaksi);
        }

        public void UpdateTransaksi(Transaksi transaksi)
        {
            _transaksiRepository.Update(transaksi);
        }

        public void DeleteTransaksi(string noTransaksi)
        {
            _transaksiRepository.Delete(noTransaksi);
        }
    }
}
