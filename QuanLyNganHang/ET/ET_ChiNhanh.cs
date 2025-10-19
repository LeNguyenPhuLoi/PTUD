using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiNhanh
    {
        public ET_ChiNhanh(string maCN, string tenCN, string diaChiCN, string sDTCN)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChiCN = diaChiCN;
            SDTCN = sDTCN;
        }

        public string MaCN { get; set; }
        public string TenCN { get; set; }
        public string DiaChiCN { get; set; }
        public string SDTCN { get; set; }
    }
}
