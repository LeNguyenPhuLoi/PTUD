using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhoanVay
    {
        public ET_KhoanVay(string maVay, string maKH, string maTK, decimal soTienVay, decimal tongTien, DateTime ngayVay, DateTime thoiHan, string trangThai, string maLaiSuat, string tinhTrangXoa)
        {
            MaVay = maVay;
            MaKH = maKH;
            MaTK = maTK;
            SoTienVay = soTienVay;
            TongTien = tongTien;
            NgayVay = ngayVay;
            ThoiHan = thoiHan;
            TrangThai = trangThai;
            MaLaiSuat = maLaiSuat;
            TinhTrangXoa = tinhTrangXoa;
        }

        public string MaVay { get; set; }
        public string MaKH { get; set; }
        public string MaTK { get; set; }
        public decimal SoTienVay { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayVay { get; set; }
        public DateTime ThoiHan { get; set; }
        public string TrangThai { get; set; }
        public string MaLaiSuat { get; set; }
        public string TinhTrangXoa { get; set; }
       
    }

    public class ET_KhoanVayRP
    {
        public string MaVay { get; set; }
        public string TenKH { get; set; }
        public string SoTaiKhoan { get; set; }
        public decimal SoTienVay { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayVay { get; set; }
        public DateTime ThoiHan { get; set; }
        public string TrangThai { get; set; }
        public string MaLaiSuat { get; set; }
    }
}
