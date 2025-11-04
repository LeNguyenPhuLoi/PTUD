using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NoiQuy
    {
        public ET_NoiQuy(string mANQ, string tIEUDE, string mOTA, DateTime nGAYBH, string lOAIAPDUNG, bool? tRANGTHAI)
        {
            MANQ = mANQ;
            TIEUDE = tIEUDE;
            MOTA = mOTA;
            NGAYBH = nGAYBH;
            LOAIAPDUNG = lOAIAPDUNG;
            TRANGTHAI = tRANGTHAI;
        }

        public string MANQ { get; set; }
        public string TIEUDE { get; set; }
        public string MOTA { get; set; }
        public DateTime NGAYBH { get; set; }
        public string LOAIAPDUNG { get; set; }
        public bool? TRANGTHAI { get; set; }
    }
}
