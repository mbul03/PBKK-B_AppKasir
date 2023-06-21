using Microsoft.EntityFrameworkCore;
using ProjectKasir.Model;

namespace ProjectKasir.Repository
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Produk> Produk { get; set; }
        public DbSet<Transaksi> Transaksi { get; set; }
        public DbSet<DetailTransaksi> DetailTransaksi { get; set; }
        public DbSet<Pelanggan> Pelanggan { get; set; }
        public DbSet<Pengguna> Pengguna { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjectKasirDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produk>().HasKey(p => p.KodeProduk);
            modelBuilder.Entity<Transaksi>().HasKey(t => t.NoTransaksi);
            modelBuilder.Entity<DetailTransaksi>().HasKey(dt => new { dt.NoTransaksi, dt.KodeProduk });
            modelBuilder.Entity<Pengguna>().HasKey(p => p.Id);

            modelBuilder.Entity<Transaksi>()
                .HasOne(t => t.Pelanggan)
                .WithMany(p => p.Transaksi)
                .HasForeignKey(t => t.KodePelanggan)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DetailTransaksi>()
                .HasOne(dt => dt.Transaksi)
                .WithMany(t => t.DetailTransaksi)
                .HasForeignKey(dt => dt.NoTransaksi)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DetailTransaksi>()
                .HasOne(dt => dt.Produk)
                .WithMany(p => p.DetailTransaksi)
                .HasForeignKey(dt => dt.KodeProduk)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pengguna>()
                .HasIndex(p => p.Username)
                .IsUnique();
        }
    }
}
