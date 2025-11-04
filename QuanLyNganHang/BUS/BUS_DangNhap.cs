using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap lg = new DAL_DangNhap();

        public ET_TaiKhhoanDangNhap DangNhap(string username, string password)
        {
            return lg.KiemTraDangNhap(username, password); // trả về null nếu sai
        }

        public bool IsAdmin(ET_TaiKhhoanDangNhap user)
        {
            return user != null && user.Quyen == "ADMIN";
        }

        public bool IsNhanVien(ET_TaiKhhoanDangNhap user)
        {
            return user != null && user.Quyen == "NHANVIEN";
        }
    }
}
