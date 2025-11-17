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

        //gọi hàm LoadDSTKtheoMa
        public IQueryable LoadDSTKtheoMa(string ma)
        {
            return ck.LoadDSTKtheoMa(ma);
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

        //
        public bool TrangThaiAn(ET_ChuyenKhoan et)
        {
            return ck.TrangThaiAn(et);
        }

        //
        public bool KiemTraTaiKhoanThuocKhachHang(string maTK, string maKH)
        {
            return ck.KiemTraTaiKhoanThuocKhachHang(maTK, maKH);
        }

        //Gọi hàm đếm mã
        public string DemMa()
        {
            return ck.DemMa();
        }
    }

    public class BUS_ChuyenKhoanRP
    {
        DAL_ChuyenKhoanRP ck = new DAL_ChuyenKhoanRP();

        //Lấy danh sách chuyển khoản report
        public List<ET_ChuyenKhoanRP> LoadDSCK()
        {
            return ck.LoadDSCK();
        }

        //Tìm report chuyển khoản
        public List<ET_ChuyenKhoanRP> TimRPCK(string ma)
        {
            return ck.TimRPCK(ma);
        }
    }
}
