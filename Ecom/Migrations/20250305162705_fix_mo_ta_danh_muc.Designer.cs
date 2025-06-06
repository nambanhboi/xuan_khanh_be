﻿// <auto-generated />
using System;
using Ecom.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecom.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250305162705_fix_mo_ta_danh_muc")]
    partial class fix_mo_ta_danh_muc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecom.Entity.account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("dia_chi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("gioi_tinh")
                        .HasColumnType("bit");

                    b.Property<bool?>("is_super_admin")
                        .HasColumnType("bit");

                    b.Property<string>("mat_khau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngay_sinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("so_dien_thoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tai_khoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("trang_thai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("account");
                });

            modelBuilder.Entity("Ecom.Entity.anh_san_pham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duong_dan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ma_san_pham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("san_PhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("san_pham_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("san_PhamId");

                    b.ToTable("anh_san_pham");
                });

            modelBuilder.Entity("Ecom.Entity.chi_tiet_don_hang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Don_Hangid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("San_phamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("don_hang_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("san_pham_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("so_luong")
                        .HasColumnType("int");

                    b.Property<decimal>("thanh_tien")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Don_Hangid");

                    b.HasIndex("San_phamId");

                    b.ToTable("chi_tiet_don_hang");
                });

            modelBuilder.Entity("Ecom.Entity.chi_tiet_gio_hang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Gio_Hangid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("San_PhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("gio_hang_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("san_pham_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("so_luong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Gio_Hangid");

                    b.HasIndex("San_PhamId");

                    b.ToTable("chi_tiet_gio_hang");
                });

            modelBuilder.Entity("Ecom.Entity.danh_gia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("San_PhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("account_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("danh_gia_chat_luong")
                        .HasColumnType("int");

                    b.Property<string>("noi_dung_danh_gia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("san_pham_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("San_PhamId");

                    b.ToTable("danh_gia");
                });

            modelBuilder.Entity("Ecom.Entity.danh_muc", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ma_danh_muc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mo_ta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten_danh_muc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("danh_muc");
                });

            modelBuilder.Entity("Ecom.Entity.don_hang", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DvvcId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("account_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("dvvc_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ma_don_hang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngay_mua")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("thanh_tien")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("tong_tien")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("trang_thai")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AccountId");

                    b.HasIndex("DvvcId");

                    b.ToTable("don_hang");
                });

            modelBuilder.Entity("Ecom.Entity.dvvc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("dvvc");
                });

            modelBuilder.Entity("Ecom.Entity.gio_hang", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("account_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("AccountId");

                    b.ToTable("gio_hang");
                });

            modelBuilder.Entity("Ecom.Entity.san_pham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("danh_Mucid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("danh_muc_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("gia")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("is_active")
                        .HasColumnType("bit");

                    b.Property<decimal?>("khuyen_mai")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("luot_ban")
                        .HasColumnType("int");

                    b.Property<string>("ma_san_pham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mau_sac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mo_ta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten_san_pham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("xuat_xu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("danh_Mucid");

                    b.ToTable("san_pham");
                });

            modelBuilder.Entity("Ecom.Entity.thong_bao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("nguoi_dung_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("nhom")
                        .HasColumnType("int");

                    b.Property<string>("noi_dung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("thoi_gian_doc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("trang_thai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("accountId");

                    b.ToTable("thong_bao");
                });

            modelBuilder.Entity("Ecom.Entity.anh_san_pham", b =>
                {
                    b.HasOne("Ecom.Entity.san_pham", "san_Pham")
                        .WithMany()
                        .HasForeignKey("san_PhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("san_Pham");
                });

            modelBuilder.Entity("Ecom.Entity.chi_tiet_don_hang", b =>
                {
                    b.HasOne("Ecom.Entity.don_hang", "Don_Hang")
                        .WithMany()
                        .HasForeignKey("Don_Hangid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecom.Entity.san_pham", "San_pham")
                        .WithMany()
                        .HasForeignKey("San_phamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Don_Hang");

                    b.Navigation("San_pham");
                });

            modelBuilder.Entity("Ecom.Entity.chi_tiet_gio_hang", b =>
                {
                    b.HasOne("Ecom.Entity.gio_hang", "Gio_Hang")
                        .WithMany()
                        .HasForeignKey("Gio_Hangid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecom.Entity.san_pham", "San_Pham")
                        .WithMany()
                        .HasForeignKey("San_PhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gio_Hang");

                    b.Navigation("San_Pham");
                });

            modelBuilder.Entity("Ecom.Entity.danh_gia", b =>
                {
                    b.HasOne("Ecom.Entity.account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecom.Entity.san_pham", "San_Pham")
                        .WithMany()
                        .HasForeignKey("San_PhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("San_Pham");
                });

            modelBuilder.Entity("Ecom.Entity.don_hang", b =>
                {
                    b.HasOne("Ecom.Entity.account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecom.Entity.dvvc", "Dvvc")
                        .WithMany()
                        .HasForeignKey("DvvcId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Dvvc");
                });

            modelBuilder.Entity("Ecom.Entity.gio_hang", b =>
                {
                    b.HasOne("Ecom.Entity.account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Ecom.Entity.san_pham", b =>
                {
                    b.HasOne("Ecom.Entity.danh_muc", "danh_Muc")
                        .WithMany()
                        .HasForeignKey("danh_Mucid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("danh_Muc");
                });

            modelBuilder.Entity("Ecom.Entity.thong_bao", b =>
                {
                    b.HasOne("Ecom.Entity.account", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });
#pragma warning restore 612, 618
        }
    }
}
