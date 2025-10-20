using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanVien
    {
        public ET_NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, decimal cCCD, string chuc, float luong, string diaChi, int sDT, int maPB, string maCN, string trangThai)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            CCCD = cCCD;
            Chuc = chuc;
            Luong = luong;
            DiaChi = diaChi;
            SDT = sDT;
            MaPB = maPB;
            MaCN = maCN;
            TrangThai = trangThai;
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public decimal CCCD { get; set; }
        public string Chuc { get; set; }
        public float Luong { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public int MaPB { get; set; }
        public string MaCN { get; set; }
        public string TrangThai { get; set; }

    }
}
