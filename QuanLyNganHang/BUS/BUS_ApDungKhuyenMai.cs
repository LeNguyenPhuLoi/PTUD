using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ApDungKhuyenMai
    {
        DAL_ApDungKhuyenMai adkm = new DAL_ApDungKhuyenMai();

        //Gọi hàm load áp dụng khuyến mãi
        public IQueryable LoadDSADKM()
        {
            return adkm.LoadDSADKM();
        }

        //Gọi hàm thêm áp dụng khuyến mãi
        public bool ThemADKM(ET_ApDungKhuyenMai et)
        {
            return adkm.ThemADKM(et);
        }

        //Gọi hàm sửa áp dụng khuyến mãi
        public bool SuaADKM(ET_ApDungKhuyenMai et)
        {
            return adkm.SuaADKM(et);
        }

        //Gọi hàm xóa(ẩn) áp dụng khuyến mãi
        public bool TrangThaiAn(ET_ApDungKhuyenMai et)
        {
            return adkm.TrangThaiAn(et);
        }
    }
}
