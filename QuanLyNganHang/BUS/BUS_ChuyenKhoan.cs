using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChuyenKhoan
    {
        DAL_ChuyenKhoan ck = new DAL_ChuyenKhoan();

        //gọi hàm LoadDSChuyenKhoan
        public IQueryable LoadDSChuyenKhoan()
        {
            return ck.LoadDSChuyenKhoan();
        }

        //
        public IQueryable LoadDSChuyenKhoanUser()
        {
            return ck.LoadDSChuyenKhoanUser();
        }

        //gọi hàm LoadDSKhachHang
        public IQueryable LoadDSKhachHang()
        {
            return ck.LoadDSKhachHang();
        }

        //gọi hàm LoadDSTaiKhoan
        public IQueryable LoadDSTaiKhoan()
        {
            return ck.LoadDSTaiKhoan();
        }


        //gọi hàm thêm chuyển khoản
        public bool ThemCK(ET_ChuyenKhoan et)
        {
            return ck.ThemCK(et);
        }

        //gọi hàm sửa chuyển khoản
        public bool SuaCK(ET_ChuyenKhoan et)
        {
            return ck.SuaCK(et);
        }

        //gọi hàm xóa chuyển khoản
        public bool XoaCK(ET_ChuyenKhoan et)
        {
            return ck.XoaCK(et);
        }

        //
        public bool TrangThaiAn(ET_ChuyenKhoan et)
        {
            return ck.TrangThaiAn(et);
        }
    }
}
