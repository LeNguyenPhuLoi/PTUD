using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TraNo
    {
        public ET_TraNo(string maTraNo, string maVay, decimal soTienNo, decimal soTienTra, DateTime ngayTra, string tinhTrangXoa)
        {
            MaTraNo = maTraNo;
            MaVay = maVay;
            SoTienNo = soTienNo;
            SoTienTra = soTienTra;
            NgayTra = ngayTra;
            TinhTrangXoa = tinhTrangXoa;
        }

        public string MaTraNo { get; set; }
        public string MaVay { get; set; }
        public decimal SoTienNo { get; set; }
        public decimal SoTienTra {  get; set; }
        public DateTime NgayTra {  get; set; }
        public string TinhTrangXoa { get; set; }
    }

    public class ET_TraNoRP
    {
        public string MaTraNo { get; set; }
        public string MaVay { get; set; }
        public decimal SoTienNo { get; set; }
        public decimal SoTienTra { get; set; }
        public DateTime NgayTra { get; set; }
    }
}
