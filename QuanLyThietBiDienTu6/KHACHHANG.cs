//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThietBiDienTu6
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.DanhGias = new HashSet<DanhGia>();
            this.DONDATHANGs = new HashSet<DONDATHANG>();
        }
    
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Email { get; set; }
        public string DiachiKH { get; set; }
        public string DienthoaiKH { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
    
        public virtual ICollection<DanhGia> DanhGias { get; set; }
        public virtual ICollection<DONDATHANG> DONDATHANGs { get; set; }
    }
}
