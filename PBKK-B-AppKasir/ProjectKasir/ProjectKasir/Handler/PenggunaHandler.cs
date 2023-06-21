using System.Collections.Generic;
using ProjectKasir.Model;
using ProjectKasir.Service;

namespace ProjectKasir.Handler
{
    public class PenggunaHandler
    {
        private readonly PenggunaService _penggunaService;

        public PenggunaHandler(PenggunaService penggunaService)
        {
            _penggunaService = penggunaService;
        }

        public IEnumerable<Pengguna> GetAllPengguna()
        {
            return _penggunaService.GetAllPengguna();
        }

        public Pengguna GetPenggunaByUsername(string username)
        {
            return _penggunaService.GetPenggunaByUsername(username);
        }

        public void InsertPengguna(Pengguna pengguna)
        {
            _penggunaService.InsertPengguna(pengguna);
        }

        public void UpdatePengguna(Pengguna pengguna)
        {
            _penggunaService.UpdatePengguna(pengguna);
        }

        public void DeletePengguna(string username)
        {
            _penggunaService.DeletePengguna(username);
        }
    }
}
