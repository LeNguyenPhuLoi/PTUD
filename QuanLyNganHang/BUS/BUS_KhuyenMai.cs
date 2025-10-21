using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL_KhuyenMai km = new DAL_KhuyenMai();

        //gọi hàm LoadDSKhuyenMai
        public IQueryable LoadDSKhuyenMai()
        {
            return km.LoadDSKhuyenMai();
        }

        //gọi hàm thêm khuyến mãi
        public bool ThemKM(ET_KhuyenMai et)
        {
            return km.ThemKM(et);
        }

        //gọi hàm sửa khuyến mãi
        public bool SuaKM(ET_KhuyenMai et)
        {
            return km.SuaKM(et);
        }

        //gọi hàm xóa khuyến mãi
        public bool XoaKM(ET_KhuyenMai et)
        {
            return km.XoaKM(et);
        }

        //
        public bool TrangThaiAn(ET_KhuyenMai et)
        {
            return km.TrangThaiAn(et);
        }

    }
}
