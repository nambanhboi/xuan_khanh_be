﻿using backend_v3.Dto.Common;

namespace Ecom.Dto
{
    public class LichSuGiaoDichDto : PaginParams
    {
        public Guid? id { get; set; }
        public DateTime? ngay_giao_dich { get; set; }
        public string? stripeSessionId { get; set; }
        public string? status { get; set; }
        public int? phuong_thuc_giao_dich { get; set; } //0-stripe; 1-zaloPay
        public decimal? giao_dich { get; set; }
        public int? loai_giao_dich { get; set; } //1-Doanh thu đơn hàng; 2-rút tiền; 3-đơn hoàn
        public decimal so_du { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}
