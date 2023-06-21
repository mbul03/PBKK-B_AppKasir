using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectKasir.Model;

namespace ProjectKasir.Repository
{
    public class ProdukRepository : IRepository<Produk>
    {
        private readonly DatabaseContext _context;

        public ProdukRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Produk> GetAll()
        {
            return _context.Produk.ToList();
        }

        public Produk GetById(string id)
        {
            return _context.Produk.FirstOrDefault(p => p.KodeProduk == id);
        }

        public void Insert(Produk entity)
        {
            _context.Produk.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Produk entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var entity = GetById(id);
            _context.Produk.Remove(entity);
            _context.SaveChanges();
        }
    }
}
