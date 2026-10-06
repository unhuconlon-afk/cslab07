using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Lab08_QuanLyHocSinh
{
    public class QLHSDataContext : DbContext
    {
        public DbSet<Lop> Lops { get; set; } = null!;
        public DbSet<HocSinh> HocSinhs { get; set; } = null!;

        private static readonly string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QLHS.db");

        public QLHSDataContext()
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

            modelBuilder.Entity<HocSinh>()
                .HasOne(h => h.Lop)
                .WithMany(l => l.HocSinhs)
                .HasForeignKey(h => h.MaLop)
                .OnDelete(DeleteBehavior.Cascade);
        }

        // Tương thích với cú pháp LINQ to SQL trong bài giảng ThS. Lương Trần Hy Hiến
        public void InsertOnSubmit(HocSinh hs)
        {
            HocSinhs.Add(hs);
        }

        public void DeleteOnSubmit(HocSinh hs)
        {
            HocSinhs.Remove(hs);
        }

        public void SubmitChanges()
        {
            SaveChanges();
        }

        private void SeedData()
        {
            if (!Lops.Any())
            {
                var lop1 = new Lop { MaLop = "10A1", TenLop = "Lớp 10 Chuyên Toán" };
                var lop2 = new Lop { MaLop = "10A2", TenLop = "Lớp 10 Chuyên Tin" };
                var lop3 = new Lop { MaLop = "11B1", TenLop = "Lớp 11 Tự Nhiên 1" };
                var lop4 = new Lop { MaLop = "12C1", TenLop = "Lớp 12 Luyện Thi Đại Học" };

                Lops.AddRange(lop1, lop2, lop3, lop4);
                SaveChanges();

                var hs1 = new HocSinh
                {
                    MaHS = "HS001",
                    TenHS = "Nguyễn Văn An",
                    NgaySinh = new DateTime(2008, 3, 15),
                    DiaChi = "123 Nguyễn Trãi, Quận 5, TP.HCM",
                    MaLop = "10A1",
                    DTB = 8.75f
                };
                var hs2 = new HocSinh
                {
                    MaHS = "HS002",
                    TenHS = "Trần Thị Bích",
                    NgaySinh = new DateTime(2008, 6, 20),
                    DiaChi = "45 Lê Lợi, Quận 1, TP.HCM",
                    MaLop = "10A1",
                    DTB = 9.20f
                };
                var hs3 = new HocSinh
                {
                    MaHS = "HS003",
                    TenHS = "Lê Hoàng Cường",
                    NgaySinh = new DateTime(2008, 10, 5),
                    DiaChi = "78 CMT8, Quận 3, TP.HCM",
                    MaLop = "10A2",
                    DTB = 7.50f
                };
                var hs4 = new HocSinh
                {
                    MaHS = "HS004",
                    TenHS = "Phạm Ngọc Dung",
                    NgaySinh = new DateTime(2007, 1, 12),
                    DiaChi = "12 Hai Bà Trưng, Quận 1, TP.HCM",
                    MaLop = "11B1",
                    DTB = 8.10f
                };
                var hs5 = new HocSinh
                {
                    MaHS = "HS005",
                    TenHS = "Võ Minh Đức",
                    NgaySinh = new DateTime(2006, 9, 28),
                    DiaChi = "90 Hoàng Văn Thụ, Q. Phú Nhuận",
                    MaLop = "12C1",
                    DTB = 6.80f
                };

                HocSinhs.AddRange(hs1, hs2, hs3, hs4, hs5);
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
