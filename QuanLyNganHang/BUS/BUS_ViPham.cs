using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ViPham
    {
        DAL_ViPham vp = new DAL_ViPham();
        public IQueryable LoadViPham()
        {
            return vp.LoadViPham();
        }

        public bool ThemVP(ET_ViPham et, out string error)
        {
            return vp.ThemViPham(et, out error);
        }

        public bool CapNhatVP(ET_ViPham et, out string error)
        {
            return vp.CapNhatViPham(et, out error);
        }
        public bool XoaVP(ET_ViPham et, out string error)
        {
            return vp.XoaViPham(et, out error);
        }

        public string MaVP()
        {
            return vp.MaTuDong();
        }

        public IQueryable<string> LoadNV()
        {
            return vp.LoadNhanVien();
        }

        public string LoadHTXL(string ma)
        {
            return vp.LoadHTXL(ma);
        }

        public IQueryable<string> LoadNQ()
        {
            return vp.LoadNoiQuy();
        }

        public string LayMa(string text)
        {
            return vp.GetMa(text);
        }

        public bool kiemTraDinhDangTenNV(string text)
        {
            return vp.KiemTraDinhDangMaNV(text);
        }

        public bool kiemTraDinhDangNoiQuy(string text)
        {
            return vp.KiemTraDinhDangMaNQ(text);
        }

        public string LayfullNhanVien(string ma)
        {
            return vp.MaTenNV(ma);
        }
        public string LayfullNoiQuy(string ma)
        {
            return vp.MaTenNQ(ma);
        }
    }
}
