using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhuyenMai
    {
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public string DKApDung { get; set; }

        public ET_KhuyenMai(string maKM, string tenKM, string moTa, DateTime ngayBD, DateTime ngayKT, string dkApDung)
        {
            MaKM = maKM;
            TenKM = tenKM;
            MoTa = moTa;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
            DKApDung = dkApDung;
        }
    }
}
