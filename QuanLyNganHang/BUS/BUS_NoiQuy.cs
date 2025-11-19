using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NoiQuy
    {
        DAL_NoiQuy nq = new DAL_NoiQuy();
        public IQueryable LoadNoiQuy()
        {
            return nq.LoadNoiQuy();
        }

        public bool ThemNQ(ET_NoiQuy et, out string error)
        {
            return nq.ThemNoiQuy(et, out error);
        }

        public bool CapNhatNQ(ET_NoiQuy et, out string error)
        {
            return nq.CapNhatNoiQuy(et, out error);
        }
        public bool XoaNQ(ET_NoiQuy et, out string error)
        {
            return nq.XoaNoiQuy(et, out error);
        }

        public string MaNoiQuy()
        {
            return nq.MaTuDong();
        }

        public bool KiemTraDinhDangLoaiApDung(string text)
        {
            return nq.KiemTraTien(text);
        }
    }
}
