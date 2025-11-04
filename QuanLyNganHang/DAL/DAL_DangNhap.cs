using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_DangNhap()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Kiểm tra đăng nhập
        public ET_TaiKhhoanDangNhap KiemTraDangNhap(string username, string password)
        {
            var user = db.DANGNHAPs
                .Where(nd => nd.MADN == username && nd.PASS == password)
                .Select(nd => new ET_TaiKhhoanDangNhap(
                    nd.MADN,
                    nd.PASS,
                    nd.QUYEN,
                    nd.MANV, 
                    nd.TrangThai))
                .FirstOrDefault();

            return user; // Trả về null nếu không đúng
        }
    }
}

