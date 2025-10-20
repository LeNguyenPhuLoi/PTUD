using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();

        public IQueryable LoadDSNV()
        {
            return nv.LoadDSNhanVien();
        }

        public IQueryable LoadDSPB()
        {
            return nv.LoadDSTenPB();
        }
        public IQueryable LoadDSCN()
        {
            return nv.LoadDSTenCN();
        }

        public int LayMaPB(string ten)
        {
            return nv.LayMaTheoTenPB(ten);
        }

        public string LayMaCN(string ten)
        {
            return nv.LayMaChiNhanh(ten);
        }

        public string LayTenTheoMaPB(int ma)
        {
            return nv.LayTenPhongBan(ma);
        }

        public string LayTenTheoMaCN(string ma)
        {
            return nv.LayTenChiNhanh(ma);
        }

        public bool ThemNhanVien(ET_NhanVien et, out string error)
        {
            return nv.ThemNhanVien(et,out error);
        }

        public bool CapNhatNhanVien(ET_NhanVien et, out string error)
        {
            return nv.CapNhatNhanVien(et, out error);
        }

        public bool XoaNhanVien(ET_NhanVien et, out string error)
        {
            return nv.XoaNhanVien(et, out error);
        }
    }
}
