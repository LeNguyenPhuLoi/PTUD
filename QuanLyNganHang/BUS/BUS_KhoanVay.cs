using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhoanVay
    {
        DAL_KhoanVay kv = new DAL_KhoanVay();

        //gọi hàm LoadDSKhoanVay
        public IQueryable LoadDSKhoanVay()
        {
            return kv.LoadDSKhoanVay();
        }

        //
        public IQueryable LoadDSKhoanVayUser()
        {
            return kv.LoadDSKhoanVayUser();
        }


        //gọi hàm LoadDSKhachHang
        public IQueryable LoadDSKhachHang()
        {
            return kv.LoadDSKhachHang();
        }

        //gọi hàm LoadDSTaiKhoan
        public IQueryable LoadDSTaiKhoan()
        {
            return kv.LoadDSTaiKhoan();
        }

        //gọi hàm LoadDSLaiSuat
        public IQueryable LoadDSLaiSuat()
        {
            return kv.LoadDSLaiSuat();
        }

        //gọi hàm thêm khoản vay
        public bool ThemKV(ET_KhoanVay et)
        {
            return kv.ThemKV(et);
        }

        //gọi hàm sửa khoản vay
        public bool SuaKV(ET_KhoanVay et)
        {
            return kv.SuaKV(et);
        }

        //gọi hàm xóa khoản vay
        public bool XoaKV(ET_KhoanVay et)
        {
            return kv.XoaKV(et);
        }

        //
        public bool TrangThaiAn(ET_KhoanVay et)
        {
            return kv.TrangThaiAn(et);
        }

        //
        public bool KiemTraTaiKhoanThuocKhachHang(string maTK, string maKH)
        {
            return kv.KiemTraTaiKhoanThuocKhachHang(maTK, maKH);
        }

        //Gọi hàm đếm mã
        public string DemMa()
        {
            return kv.DemMa();
        }

    }
}
