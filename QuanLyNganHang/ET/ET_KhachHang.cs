using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string QuocTich { get; set; }
        public string DoiTuong { get; set; }
        public DateTime NgayTao { get; set; }

        public ET_KhachHang(string maKH, string tenKH, string gioiTinh, string cCCD, string sDT, string email, string diaChi, string quocTich, string doiTuong, DateTime ngayTao)
        {
            MaKH = maKH;
            TenKH = tenKH;
            GioiTinh = gioiTinh;
            CCCD = cCCD;
            SDT = sDT;
            Email = email;
            DiaChi = diaChi;
            QuocTich = quocTich;
            DoiTuong = doiTuong;
            NgayTao = ngayTao;
        }
    }
}
