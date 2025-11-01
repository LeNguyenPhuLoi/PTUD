using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiHopDong
    {
        public string MaLoaiHD { get; set; }

        public string TenLoaiHD { get; set; }

        public DateTime NgayLap { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public string TrangThai { get; set; }

        public bool TinhTrangXoa { get; set; }

        public ET_LoaiHopDong(string maLoaiHD, string tenLoaiHD, DateTime ngayLap, DateTime ngayCapNhat, string trangThai, bool tinhTrangXoa)
        {
            MaLoaiHD = maLoaiHD;
            TenLoaiHD = tenLoaiHD;
            NgayLap = ngayLap;
            NgayCapNhat = ngayCapNhat;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }
    }
}
