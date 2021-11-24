using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UCP1_PAW_054_A.Models
{
    public partial class CasirContext : DbContext
    {
        public CasirContext()
        {
        }

        public CasirContext(DbContextOptions<CasirContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Produk> Produks { get; set; }
        public virtual DbSet<Transaksi> Transaksis { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin);

                entity.ToTable("Admin");

                entity.Property(e => e.IdAdmin)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_admin");

                entity.Property(e => e.NamaAdmin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_admin");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("Customer");

                entity.Property(e => e.IdCustomer)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_customer");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_customer");

                entity.Property(e => e.NoTelpon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("No_telpon");
            });

            modelBuilder.Entity<Produk>(entity =>
            {
                entity.HasKey(e => e.IdProduck);

                entity.ToTable("produk");

                entity.Property(e => e.IdProduck)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_produck");

                entity.Property(e => e.NamaProduk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_produk");

                entity.Property(e => e.Quantitiy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quantitiy");
            });

            modelBuilder.Entity<Transaksi>(entity =>
            {
                entity.HasKey(e => e.IdTransaksi);

                entity.ToTable("Transaksi");

                entity.Property(e => e.IdTransaksi)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_transaksi");

                entity.Property(e => e.IdCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Id_customer");

                entity.Property(e => e.IdProduk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Id_produk");

                entity.Property(e => e.TotalTransaksi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total_transaksi");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
