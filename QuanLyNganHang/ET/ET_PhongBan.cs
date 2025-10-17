using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhongBan
    {
        public ET_PhongBan(string maPB, string tenPB)
        {
            MaPB = maPB;
            TenPB = tenPB;
        }

        public string MaPB { get; set; }
        public string TenPB { get; set; }
    }
}
