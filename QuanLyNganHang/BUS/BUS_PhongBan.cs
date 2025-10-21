using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhongBan
    {
        DAL_PhongBan dal = new DAL_PhongBan();

        public IQueryable LoadDSPhongBan()
        {
            return dal.LoadDSPhongBan();
        }

        public bool ThemPhongBan(ET_PhongBan et, out string error)
        {
            return dal.ThemPhongBan(et, out error);
        }

        public bool CapNhatPhongBan(ET_PhongBan et, out string error)
        {
            return dal.CapNhatPhongBan(et, out error);
        }

        public bool XoaPhongBan(ET_PhongBan et, out string error)
        {
            return dal.XoaPB(et, out error);
        }
    }
}
