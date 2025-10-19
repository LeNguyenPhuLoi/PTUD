using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LaiSuat
    {
        public string MaLaiSuat { get; set; }
        public string TenLoaiVay { get; set; }
        public decimal LaiSuatValue { get; set; }
        public string KieuLai { get; set; }


        public ET_LaiSuat(string maLaiSuat, string tenLoaiVay, decimal laiSuatValue, string kieuLai)
        {
            MaLaiSuat = maLaiSuat;
            TenLoaiVay = tenLoaiVay;
            LaiSuatValue = laiSuatValue;
            KieuLai = kieuLai;
        }
    }
}
