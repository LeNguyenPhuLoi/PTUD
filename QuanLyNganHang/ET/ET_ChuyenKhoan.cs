using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChuyenKhoan
    {
        public string MaCK { get; set; }
        public string MaKH { get; set; }
        public string MaTK { get; set; }
        public DateTime NgayCK { get; set; }
        public decimal SoTien { get; set; }
        public string MaTKGui { get; set; }
        public string MaTKNhan { get; set; }
        public string NoiDung { get; set; }
        public string TinhTrangXoa { get; set; }

        public ET_ChuyenKhoan(string maCK, string maKH, string maTK, DateTime ngayCK, decimal soTien, string maTKGui, string maTKNhan, string noiDung, string tinhTrangXoa)
        {
            MaCK = maCK;
            MaKH = maKH;
            MaTK = maTK;
            NgayCK = ngayCK;
            SoTien = soTien;
            MaTKGui = maTKGui;
            MaTKNhan = maTKNhan;
            NoiDung = noiDung;
            TinhTrangXoa = tinhTrangXoa;
        }
    }
}
