using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BienLai
    {
        public ET_BienLai(string maBL, string maGD, string maKH, string maTK, string maNV, decimal soTien, string maNgoaiTe, string moTa, string trangThai, string tinhTrangXoa)
        {
            MaBL = maBL;
            MaGD = maGD;
            MaKH = maKH;
            MaTK = maTK;
            MaNV = maNV;
            SoTien = soTien;
            MaNgoaiTe = maNgoaiTe;
            MoTa = moTa;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }

        public string MaBL {  get; set; }
        public string MaGD { get; set; }
        public string MaKH { get; set; }
        public string MaTK { get; set; }
        public string MaNV { get; set; }
        public decimal SoTien { get; set; }
        public string MaNgoaiTe { get; set; }
        public string MoTa {  get; set; }
        public string TrangThai {  get; set; }
        public string TinhTrangXoa { get; set; }
    }
}
