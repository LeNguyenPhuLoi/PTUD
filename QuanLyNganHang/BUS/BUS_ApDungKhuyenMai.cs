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

        //Gọi hàm load áp dụng khuyến mãi user
        public IQueryable LoadDSADKMUser()
        {
            return adkm.LoadDSADKMUser();
        }

        //Gọi hàm load danh sách khuyến mãi
        public IQueryable LoadDSKM()
        {
            return adkm.LoadDSKM();
        }

        //Gọi hàm load danh sách tài khoản
        public IQueryable LoadDSTKtheoMa(string ma)
        {
            return adkm.LoadDSTKtheoMa(ma);
        }

        //Gọi hàm load danh sách khách hàng
        public IQueryable LoadKH()
        {
            return adkm.LoadKH();
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
