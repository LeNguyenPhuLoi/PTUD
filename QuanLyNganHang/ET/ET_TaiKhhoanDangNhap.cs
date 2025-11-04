using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TaiKhhoanDangNhap
    {
        public ET_TaiKhhoanDangNhap(string maDN, string pass, string quyen, string maNV, bool? trangThai)
        {
            MaDN = maDN;
            Pass = pass;
            Quyen = quyen;
            MaNV = maNV;
            TrangThai = trangThai;
        }

        public string MaDN { get; set; }
        public string Pass { get; set; }
        public string Quyen { get; set; }
        public string MaNV { get; set; }
        public bool? TrangThai { get; set; }
    }
}
