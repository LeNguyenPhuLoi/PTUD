using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ViPham
    {
        public ET_ViPham(string mAVP, string mANQ, string mANV, DateTime nGAYVP, string mOTAVP, string hINHTHUCXL, string tRANGTHAIXL, bool? tRANGTHAI)
        {
            MAVP = mAVP;
            MANQ = mANQ;
            MANV = mANV;
            NGAYVP = nGAYVP;
            MOTAVP = mOTAVP;
            HINHTHUCXL = hINHTHUCXL;
            TRANGTHAIXL = tRANGTHAIXL;
            TRANGTHAI = tRANGTHAI;
        }

        public string MAVP { get; set; }
        public string MANQ { get; set; }
        public string MANV { get; set; }
        public DateTime NGAYVP { get; set; }
        public string MOTAVP { get; set; }
        public string HINHTHUCXL { get; set; }
        public string TRANGTHAIXL { get; set; }
        public bool? TRANGTHAI { get; set; }

    }
}
