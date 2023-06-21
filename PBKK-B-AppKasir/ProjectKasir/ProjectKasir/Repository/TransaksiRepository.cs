using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectKasir.Model;

namespace ProjectKasir.Repository
{
    public class TransaksiRepository : IRepository<Transaksi>
    {
        private readonly DatabaseContext _context;

        public TransaksiRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Transaksi> GetAll()
        {
            return _context.Transaksi.Include(t => t.Pelanggan).ToList();
        }

        public Transaksi GetById(string id)
        {
            return _context.Transaksi.Include(t => t.Pelanggan).FirstOrDefault(t => t.NoTransaksi == id);
        }

        public void Insert(Transaksi entity)
        {
            _context.Transaksi.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Transaksi entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var entity = GetById(id);
            _context.Transaksi.Remove(entity);
            _context.SaveChanges();
        }
    }
}
