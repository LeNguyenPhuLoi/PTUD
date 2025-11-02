using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HopDong
    {
        public int MaHD {  get; set; }

        public string SoHopDong {  get; set; }

        public string MaLoaiHD { get; set; }

        public DateTime NgayKy { get; set; }

        public DateTime NgayHetHan { get; set; }

        public decimal GiaTri {  get; set; }

        public string GhiChu {  get; set; }

        public string TrangThai { get; set; }

        public string MaNV { get; set; }

        public string MaKH { get; set; }

        public bool TinhTrangXoa { get; set; }

        public ET_HopDong(int maHD, string soHopDong, string maLoaiHD, DateTime ngayKy, DateTime ngayHetHan, decimal giaTri, string ghiChu, string trangThai, string maNV, string maKH, bool tinhTrangXoa)
        {
            MaHD = maHD;
            SoHopDong = soHopDong;
            MaLoaiHD = maLoaiHD;
            NgayKy = ngayKy;
            NgayHetHan = ngayHetHan;
            GiaTri = giaTri;
            GhiChu = ghiChu;
            TrangThai = trangThai;
            MaNV = maNV;
            MaKH = maKH;
            TinhTrangXoa = tinhTrangXoa;
        }
    }
}
