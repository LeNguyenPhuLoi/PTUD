using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanVien
    {
        public ET_NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string chuc, float luong, string diaChi, int sdt, int maPB, string maCN)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Chuc = chuc;
            Luong = luong;
            DiaChi = diaChi;
            Sdt = sdt;
            MaPB = maPB;
            MaCN = maCN;
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Chuc { get; set; }
        public float Luong { get; set; }
        public string DiaChi { get; set; }
        public int Sdt { get; set; }
        public int MaPB { get; set; }
        public string MaCN { get; set; }
    }
}
