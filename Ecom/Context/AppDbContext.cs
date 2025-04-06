﻿using Ecom.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<account> account { get; set; }
        //public DbSet<account_giam_gia> account_giam_gia { get; set; }
        public DbSet<anh_san_pham> anh_san_pham { get; set; }
        public DbSet<chi_tiet_don_hang> chi_tiet_don_hang { get; set; }
        public DbSet<chi_tiet_gio_hang> chi_tiet_gio_hang { get; set; }
        //public DbSet<chi_tiet_san_pham> chi_tiet_san_pham { get; set; }
        //public DbSet<chuong_trinh_marketing> chuong_trinh_marketing { get; set; }
        public DbSet<danh_gia> danh_gia { get; set; }
        public DbSet<danh_muc> danh_muc { get; set; }
        public DbSet<don_hang> don_hang { get; set; }
        public DbSet<dvvc> dvvc { get; set; }
        public DbSet<gio_hang> gio_hang { get; set; }
        //public DbSet<ma_giam_gia> ma_giam_gia { get; set; }
        public DbSet<san_pham> san_pham { get; set; }
        //public DbSet<san_pham_marketing> san_pham_marketing { get; set; }
        public DbSet<thong_bao> thong_bao { get; set; }
        public DbSet<ma_giam_gia> ma_gia_gia { get; set; }
        public DbSet<phieu_nhap_kho> phieu_nhap_kho { get; set; }
        public DbSet<chi_tiet_phieu_nhap_kho> chi_tiet_phieu_nhap_kho { get; set; }

        public DbSet<chuong_trinh_marketing> chuong_trinh_marketing { get; set; }
        public DbSet<ngan_hang> ngan_hang { get; set; }
        public DbSet<lich_su_giao_dich> lich_su_giao_dich { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chi_tiet_don_hang>()
                .Property(e => e.thanh_tien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<don_hang>()
                .Property(e => e.thanh_tien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<don_hang>()
                .Property(e => e.tong_tien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<san_pham>()
                .Property(e => e.gia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<san_pham>()
                .Property(e => e.khuyen_mai)
                .HasPrecision(18, 2);

            modelBuilder.Entity<chi_tiet_phieu_nhap_kho>()
                .Property(e => e.don_gia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ma_giam_gia>()
                .Property(e => e.giam_gia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<phieu_nhap_kho>()
                .Property(e => e.thanh_tien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<chi_tiet_don_hang>()
                .Property(e => e.don_gia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<lich_su_giao_dich>()
                .Property(e => e.giao_dich)
                .HasPrecision(18, 2);

            modelBuilder.Entity<lich_su_giao_dich>()
                .Property(e => e.so_du)
                .HasPrecision(18, 2);

        }
    }
}
