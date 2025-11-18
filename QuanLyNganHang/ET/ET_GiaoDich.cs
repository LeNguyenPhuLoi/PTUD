using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_GiaoDich
    {
        public string MaGD { get; set; }

        public string MaKH { get; set; }

        public string MaTk { get; set; }

        public string MaTkNhan { get; set; }

        public string MaLoaiGD { get; set; }

        public decimal SoTien { get; set; }

        public DateTime ThoiGianGD { get; set; }

        public string MoTa {  get; set; }

        public string TrangThai {  get; set; }

        public bool TinhTrangXoa { get; set; }

        public ET_GiaoDich(string maGD, string maKH, string maTk, string maTkNhan, string maLoaiGD, decimal soTien, DateTime thoiGianGD, string moTa, string trangThai, bool tinhTrangXoa)
        {
            MaGD = maGD;
            MaKH = maKH;
            MaTk = maTk;
            MaTkNhan = maTkNhan;
            MaLoaiGD = maLoaiGD;
            SoTien = soTien;
            ThoiGianGD = thoiGianGD;
            MoTa = moTa;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }
    }

    public class ET_GiaoDich_Report_ThongTinKhachHang
    {
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string SoTk { get; set; }
        public string LoaiTK { get; set; }
        public DateTime NgayGiaoDich { get; set; }
    }

    public class ET_GiaoDich_Report_ChiTietGiaoDich
    {
        public string MaGd { get; set; }
        public string LoaiGd { get; set; }
        public decimal Sotien { get; set; }
        public string NoiDung { get; set; }
    }
}
