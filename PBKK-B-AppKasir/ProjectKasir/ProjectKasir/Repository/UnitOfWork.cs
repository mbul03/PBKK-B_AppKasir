using System;

namespace ProjectKasir.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DatabaseContext _context;

        private IRepository<Produk> _produkRepository;
        private IRepository<Transaksi> _transaksiRepository;
        private IRepository<DetailTransaksi> _detailTransaksiRepository;
        private IRepository<Pelanggan> _pelangganRepository;
        private IRepository<Pengguna> _penggunaRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IRepository<Produk> ProdukRepository
        {
            get { return _produkRepository ??= new ProdukRepository(_context); }
        }

        public IRepository<Transaksi> TransaksiRepository
        {
            get { return _transaksiRepository ??= new TransaksiRepository(_context); }
        }

        public IRepository<DetailTransaksi> DetailTransaksiRepository
        {
            get { return _detailTransaksiRepository ??= new DetailTransaksiRepository(_context); }
        }

        public IRepository<Pelanggan> PelangganRepository
        {
            get { return _pelangganRepository ??= new PelangganRepository(_context); }
        }

        public IRepository<Pengguna> PenggunaRepository
        {
            get { return _penggunaRepository ??= new PenggunaRepository(_context); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
