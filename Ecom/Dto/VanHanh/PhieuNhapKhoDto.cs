﻿using backend_v3.Dto.Common;
using Ecom.Entity;

namespace Ecom.Dto.VanHanh
{
    public class PhieuNhapKhoDto : PaginParams
    {
        public Guid? id { get; set; }
        public string? ma { get; set; }
        public DateTime? ngay_du_kien { get; set; }
        public DateTime? ngay_het_han { get; set; }
        public int? trang_thai { get; set; } //1-mới ; 2-hết hạn ; 3-hoàn hành
        public string? nha_cung_cap { get; set; }
        public decimal thanh_tien { get; set; }
        public string? ghi_chu { get; set; }
        public List<ChiTietPhieuNhapDto>? ls_san_phan_nhap_kho { get; set; }
        public virtual ICollection<chi_tiet_phieu_nhap_kho>? ds_chi_tiet_phieu_nhap_kho { get; set; }
    }

    
}
