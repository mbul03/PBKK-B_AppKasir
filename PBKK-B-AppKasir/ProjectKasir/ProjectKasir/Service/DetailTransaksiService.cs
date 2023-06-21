using System.Collections.Generic;
using ProjectKasir.Model;
using ProjectKasir.Repository;

namespace ProjectKasir.Service
{
    public class DetailTransaksiService
    {
        private readonly IRepository<DetailTransaksi> _detailTransaksiRepository;

        public DetailTransaksiService(IRepository<DetailTransaksi> detailTransaksiRepository)
        {
            _detailTransaksiRepository = detailTransaksiRepository;
        }

        public IEnumerable<DetailTransaksi> GetAllDetailTransaksi()
        {
            return _detailTransaksiRepository.GetAll();
        }

        public DetailTransaksi GetDetailTransaksiByNoTransaksi(string noTransaksi, string kodeProduk)
        {
            return _detailTransaksiRepository.GetById($"{noTransaksi}|{kodeProduk}");
        }

        public void InsertDetailTransaksi(DetailTransaksi detailTransaksi)
        {
            _detailTransaksiRepository.Insert(detailTransaksi);
        }

        public void UpdateDetailTransaksi(DetailTransaksi detailTransaksi)
        {
            _detailTransaksiRepository.Update(detailTransaksi);
        }

        public void DeleteDetailTransaksi(string noTransaksi, string kodeProduk)
        {
            _detailTransaksiRepository.Delete($"{noTransaksi}|{kodeProduk}");
        }
    }
}
