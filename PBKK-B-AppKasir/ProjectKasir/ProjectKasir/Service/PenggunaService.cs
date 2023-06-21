using System.Collections.Generic;
using ProjectKasir.Model;
using ProjectKasir.Repository;

namespace ProjectKasir.Service
{
    public class PenggunaService
    {
        private readonly IRepository<Pengguna> _penggunaRepository;

        public PenggunaService(IRepository<Pengguna> penggunaRepository)
        {
            _penggunaRepository = penggunaRepository;
        }

        public IEnumerable<Pengguna> GetAllPengguna()
        {
            return _penggunaRepository.GetAll();
        }

        public Pengguna GetPenggunaByUsername(string username)
        {
            return _penggunaRepository.GetById(username);
        }

        public void InsertPengguna(Pengguna pengguna)
        {
            _penggunaRepository.Insert(pengguna);
        }

        public void UpdatePengguna(Pengguna pengguna)
        {
            _penggunaRepository.Update(pengguna);
        }

        public void DeletePengguna(string username)
        {
            _penggunaRepository.Delete(username);
        }
    }
}
