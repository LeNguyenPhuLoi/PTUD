using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiNhanh
    {
        DAL_ChiNhanh dal = new DAL_ChiNhanh();
        public IQueryable LoadDSChiNhanh()
        {
            return dal.LoadDSChiNhanh();
        }

        public bool ThemChiNhanh(ET_ChiNhanh et, out string error)
        {
            return dal.ThemChiNhanh(et, out error);
        }

        public bool CapNhatChiNhanh(ET_ChiNhanh et, out string error)
        {
            return dal.CapNhatChiNhanh(et, out error);
        }

        public bool XoaChiNhanh(ET_ChiNhanh et, out string error)
        {
            return dal.XoaChiNhanh(et, out error);
        }
    }
}
