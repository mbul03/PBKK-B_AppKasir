using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectKasir.Model;

namespace ProjectKasir.Repository
{
    public class DetailTransaksiRepository : IRepository<DetailTransaksi>
    {
        private readonly DatabaseContext _context;

        public DetailTransaksiRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<DetailTransaksi> GetAll()
        {
            return _context.DetailTransaksi.Include(dt => dt.Produk).ToList();
        }

        public DetailTransaksi GetById(string id)
        {
            return _context.DetailTransaksi.Include(dt => dt.Produk).FirstOrDefault(dt => dt.NoTransaksi == id);
        }

        public void Insert(DetailTransaksi entity)
        {
            _context.DetailTransaksi.Add(entity);
            _context.SaveChanges();
        }

        public void Update(DetailTransaksi entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(string id)
        {
            var entity = GetById(id);
            _context.DetailTransaksi.Remove(entity);
            _context.SaveChanges();
        }
    }
}
