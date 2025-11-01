using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiGiaoDich
    {
        public string MaLoaiGD { get; set; }

        public string TenLoaiGD { get; set; }

        public DateTime  NgayLap { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public string TrangThai { get; set; }

        public bool TinhTrangXoa { get; set; }

        public ET_LoaiGiaoDich(string maLoaiGD, string tenLoaiGD, DateTime ngayLap, DateTime ngayCapNhat, string trangThai, bool tinhTrangXoa)
        {
            MaLoaiGD = maLoaiGD;
            TenLoaiGD = tenLoaiGD;
            NgayLap = ngayLap;
            NgayCapNhat = ngayCapNhat;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }
    }
}
