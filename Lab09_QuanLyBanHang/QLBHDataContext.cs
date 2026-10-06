using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Lab09_QuanLyBanHang
{
    public class QLBHDataContext : DbContext
    {
        public DbSet<HangHoa> HangHoas { get; set; } = null!;
        public DbSet<HoaDon> HoaDons { get; set; } = null!;
        public DbSet<CTHoaDon> CTHoaDons { get; set; } = null!;

        private static readonly string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QLBH.db");

        public QLBHDataContext()
        {
            Database.EnsureCreated();
            SeedData();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={DbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Khóa chính phức hợp cho CTHoaDon
            modelBuilder.Entity<CTHoaDon>()
                .HasKey(ct => new { ct.MaHD, ct.MaHH });

            modelBuilder.Entity<CTHoaDon>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.CTHoaDons)
                .HasForeignKey(ct => ct.MaHD)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CTHoaDon>()
                .HasOne(ct => ct.HangHoa)
                .WithMany(hh => hh.CTHoaDons)
                .HasForeignKey(ct => ct.MaHH)
                .OnDelete(DeleteBehavior.Restrict);
        }

        // Tương thích với cú pháp LINQ to SQL trong giáo trình
        public void InsertOnSubmit<T>(T entity) where T : class
        {
            Set<T>().Add(entity);
        }

        public void DeleteOnSubmit<T>(T entity) where T : class
        {
            Set<T>().Remove(entity);
        }

        public void SubmitChanges()
        {
            SaveChanges();
        }

        private void SeedData()
        {
            if (!HangHoas.Any())
            {
                var dsHH = new[]
                {
                    new HangHoa { TenHH = "Coca Cola Lon 330ml", DonGia = 10000 },
                    new HangHoa { TenHH = "Pepsi Không Calo 330ml", DonGia = 10000 },
                    new HangHoa { TenHH = "Mì Hảo Hảo Tôm Chua Cay", DonGia = 4500 },
                    new HangHoa { TenHH = "Bánh Mì Tươi Chà Bông", DonGia = 15000 },
                    new HangHoa { TenHH = "Sữa Tươi Tiệt Trùng Vinamilk 220ml", DonGia = 9500 },
                    new HangHoa { TenHH = "Cà Phê Sữa Hòa Tan G7 (Hộp 18 gói)", DonGia = 58000 },
                    new HangHoa { TenHH = "Snack Khoai Tây O'Star 90g", DonGia = 18000 },
                    new HangHoa { TenHH = "Nước Khoáng Lavie 500ml", DonGia = 6000 }
                };

                HangHoas.AddRange(dsHH);
                SaveChanges();
            }
        }
    }

    public static class LinqToSqlExtensions
    {
        public static void InsertOnSubmit<T>(this DbSet<T> set, T entity) where T : class
        {
            set.Add(entity);
        }

        public static void DeleteOnSubmit<T>(this DbSet<T> set, T entity) where T : class
        {
            set.Remove(entity);
        }
    }
}
