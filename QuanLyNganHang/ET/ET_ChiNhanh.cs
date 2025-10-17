using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiNhanh
    {
        public ET_ChiNhanh(string maCN, string tenCN, string diaChi, int sDT)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChi = diaChi;
            SDT = sDT;
        }

        public string MaCN { get; set; }
        public string TenCN { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
    }
}
