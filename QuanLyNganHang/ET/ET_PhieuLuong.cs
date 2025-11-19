using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhieuLuong
    {
        public ET_PhieuLuong() { }
        public ET_PhieuLuong(string mANV, string tENNV, DateTime nGAYSINHG, string cCCD, decimal lUONG, decimal kHAUTRU, string nOIDUNG, decimal tONG)
        {
            MANV = mANV;
            TENNV = tENNV;
            NGAYSINH = nGAYSINHG;
            CCCD = cCCD;
            LUONG = lUONG;
            KHAUTRU = kHAUTRU;
            NOIDUNG = nOIDUNG;
            TONG = tONG;
        }

        public string MANV { get; set; }
        public string TENNV { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string CCCD { get; set; }
        public decimal LUONG { get; set; }
        public decimal KHAUTRU { get; set; }
        public string NOIDUNG { get; set; }
        public decimal TONG { get; set; }
    }
    public class ET_BangLuong
    {
        public ET_BangLuong()
        {
        }

        public ET_BangLuong(string mANV, string tENNV, string cCCD, decimal lUONG, decimal kHAUTRU, decimal tONG)
        {
            MANV = mANV;
            TENNV = tENNV;
            CCCD = cCCD;
            LUONG = lUONG;
            KHAUTRU = kHAUTRU;
            TONG = tONG;
        }

        public string MANV { get; set; }
        public string TENNV { get; set; }
        public string CCCD { get; set; }
        public decimal LUONG { get; set; }
        public decimal KHAUTRU { get; set; }
        public decimal TONG { get; set; }

    }

}
