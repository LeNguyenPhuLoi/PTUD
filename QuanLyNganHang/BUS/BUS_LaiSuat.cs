using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LaiSuat
    {
        DAL_LaiSuat ls = new DAL_LaiSuat();

        //Gọi hàm LoadDSLaiSuat
        public IQueryable LoadDSLaiSuat()
        {
            return ls.LoadDSLaiSuat();
        }

        //
        public IQueryable LoadDSLaiSuatUser()
        {
            return ls.LoadDSLaiSuatUser();
        }


        //Gọi hàm thêm lãi suất
        public bool ThemLaiSuat(ET_LaiSuat et)
        {
            return ls.ThemLaiSuat(et);
        }

        //Gọi hàm sửa lãi suất
        public bool SuaLaiSuat(ET_LaiSuat et)
        {
            return ls.SuaLaiSuat(et);
        }

        //Gọi hàm xóa lãi suất
        public bool XoaLaiSuat(ET_LaiSuat et)
        {
            return ls.XoaLaiSuat(et);
        }

        //
        public bool TrangThaiAn(ET_LaiSuat et)
        {
            return ls.TrangThaiAn(et);
        }

        //Gọi hàm đếm mã
        public string DemMa()
        {
            return ls.DemMa();  
        }

    }
}
