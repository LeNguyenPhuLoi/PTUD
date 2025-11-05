using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LaiSuat
    {
        public ET_LaiSuat(string maLaiSuat, string tenLoaiVay, decimal laiSuat, string kieuLai, int? soThang, string tinhTrangXoa)
        {
            MaLaiSuat = maLaiSuat;
            TenLoaiVay = tenLoaiVay;
            LaiSuat = laiSuat;
            KieuLai = kieuLai;
            SoThang = soThang;
            TinhTrangXoa = tinhTrangXoa;
        }

        public string MaLaiSuat { get; set; }
        public string TenLoaiVay { get; set; }
        public decimal LaiSuat { get; set; }
        public string KieuLai { get; set; }
        public int? SoThang { get; set; }
        public string TinhTrangXoa { get; set; }
    }
}
