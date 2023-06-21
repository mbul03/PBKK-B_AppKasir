using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectKasir.Model;

namespace ProjectKasir.Repository
{
    public class PenggunaRepository : IRepository<Pengguna>
    {
        private readonly DatabaseContext _context;

        public PenggunaRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Pengguna> GetAll()
        {
            return _context.Pengguna.ToList();
        }

        public Pengguna GetById(string id)
        {
            return _context.Pengguna.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Pengguna entity)
        {
            _context.Pengguna.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Pengguna entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var entity = GetById(id);
            _context.Pengguna.Remove(entity);
            _context.SaveChanges();
        }
    }
}
