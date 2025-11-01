using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoTro
    {
        public string MaHTro {  get; set; }

        public string MaKH { get; set; }

        public string MaNV { get; set; }

        public string MaLoaiHT { get; set; }

        public string NoiDung { get; set; }

        public DateTime NgayHTro { get; set; }

        public bool TinhTrangXoa { get; set; }

        public ET_HoTro(string maHTro, string maKH, string maNV, string maLoaiHT, string noiDung, DateTime ngayHTro, bool tinhTrangXoa)
        {
            MaHTro = maHTro;
            MaKH = maKH;
            MaNV = maNV;
            MaLoaiHT = maLoaiHT;
            NoiDung = noiDung;
            NgayHTro = ngayHTro;
            TinhTrangXoa = tinhTrangXoa;
        }

    }
}
