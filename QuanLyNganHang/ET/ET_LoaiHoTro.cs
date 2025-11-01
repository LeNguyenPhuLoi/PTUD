using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiHoTro
    {
        public string MaLoaiHT { get; set; }

        public string TenLoaiHT { get; set; }

        public DateTime NgayLap { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public string TrangThai { get; set; }

        public bool TinhTrangXoa { get; set; }

        public ET_LoaiHoTro(string maLoaiHT, string tenLoaiHT, DateTime ngayLap, DateTime ngayCapNhat, string trangThai, bool tinhTrangXoa)
        {
            MaLoaiHT = maLoaiHT;
            TenLoaiHT = tenLoaiHT;
            NgayLap = ngayLap;
            NgayCapNhat = ngayCapNhat;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }
    }
}
