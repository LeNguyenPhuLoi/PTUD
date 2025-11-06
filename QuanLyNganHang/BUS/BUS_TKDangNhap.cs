using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace BUS
{
    public class BUS_TKDangNhap
    {
        DAL_TaiKhoanDangNhap login = new DAL_TaiKhoanDangNhap();

        // Lấy danh sách tài khoản đăng nhập
        public IQueryable LoadTKL()
        {
            return login.LayDSTaiKhoanDangNhap();
        }

        // Lấy danh sách nhân viên
        public IQueryable LoadDSNV()
        {
            return login.LoadNhanVien();
        }

        // Thêm tài khoản đăng nhập
        public bool ThemTKL(ET_TaiKhhoanDangNhap et, out string error)
        {
            return login.ThemTaiKhoanDN(et, out error);
        }

        // Cập nhật tài khoản đăng nhập
        public bool CapNhatTKL(ET_TaiKhhoanDangNhap et, out string error)
        {
            return login.CapNhapTKDN(et, out error);
        }

        // Xóa tài khoản đăng nhập
        public bool XoaTKL(ET_TaiKhhoanDangNhap et, out string error)
        {
            return login.XoaTKDN(et,out error);
        }

        public bool KiemTraDinhDangMK(string text)
        {
            return login.KiemTraDinhDangMatKhau(text);
        }
    }
}
