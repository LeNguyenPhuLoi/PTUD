using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ApDungKhuyenMai
    {
        public ET_ApDungKhuyenMai(string maKM, string maKH, string maTK, DateTime ngayApDung, string tinhTrangXoa)
        {
            MaKM = maKM;
            MaKH = maKH;
            MaTK = maTK;
            NgayApDung = ngayApDung;
            TinhTrangXoa = tinhTrangXoa;
        }

        public string MaKM {  get; set; }
        public string MaKH {  get; set; }
        public string MaTK { get; set; }
        public DateTime NgayApDung {  get; set; }
        public string TinhTrangXoa { get; set; }
    }
}
