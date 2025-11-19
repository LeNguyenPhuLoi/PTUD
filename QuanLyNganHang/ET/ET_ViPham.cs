using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ViPham
    {
        public ET_ViPham(string mAVP, string mANQ, string mANV, DateTime nGAYVP, string mOTAVP, decimal? hINHTHUCXL, string tRANGTHAIXL, bool? tRANGTHAI)
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
        public decimal? HINHTHUCXL { get; set; }
        public string TRANGTHAIXL { get; set; }
        public bool? TRANGTHAI { get; set; }

    }

    public class ET_ViPhamRP
    {
        public ET_ViPhamRP(string mAVP, string mANV, string tENNV, string lOIVIPHAM, DateTime nGAYVP, decimal hINHTHUCXL, string tRANGTHAIXL)
        {
            MAVP = mAVP;
            MANV = mANV;
            TENNV = tENNV;
            LOIVIPHAM = lOIVIPHAM;
            NGAYVP = nGAYVP;
            HINHTHUCXL = hINHTHUCXL;
            TRANGTHAIXL = tRANGTHAIXL;
        }
        public ET_ViPhamRP()
        {
        }
        public string MAVP { get; set; }
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public string LOIVIPHAM { get; set; }
        public DateTime NGAYVP { get; set; }
        public decimal HINHTHUCXL { get; set; }
        public string TRANGTHAIXL { get; set; }
    }
}
