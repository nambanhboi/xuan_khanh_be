﻿using Ecom.Entity.common;
using Ecom.Interfaces;

namespace Ecom.Entity
{
    public class danh_gia : BaseModel, IEntity
    {
        public Guid id { get; set; }
        public Guid? san_pham_id { get; set; }
        public Guid? don_hang_id { get; set; }
        public string? ma_don_hang {  get; set; }
        public Guid account_id { get; set; }
        public string? ma_san_pham { get; set; }
        public int danh_gia_chat_luong { get; set; }
        public string? noi_dung_danh_gia { get; set; }
        public string? noi_dung_phan_hoi { get; set; }
        public virtual san_pham? San_Pham { get; set; }
        public virtual account? Account { get; set; }
        public virtual don_hang? don_hang { get; set; }
    }
}
