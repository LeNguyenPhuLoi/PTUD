using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dapper;

using ET;

namespace DAL
{
    public class DAL_KhachHang
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm kiểm tra mã khách hàng đã tồn tại
        public bool KiemTraTonTaiMaKH(string makh)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM KHACHHANG WHERE MAKH = @MaKH";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection())) 
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { MAKH = makh });
                    if (count > 0) 
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return flag;
        }

        //hàm lấy danh sách toàn bộ khách hàng
        public List<ET_KhachHang> LayDSToanBoKhachHang()
        {
            List<ET_KhachHang> list = new List<ET_KhachHang>();
            const string query = @"SELECT * FROM KHACHHANG";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_KhachHang>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm thêm khách hàng
        public bool ThemKhachHang(ET_KhachHang et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO KHACHHANG (MAKH, TENKH, GIOITINH, CCCD, SDT, EMAIL, DIACHI, QUOCTICH, DOITUONG, NGAYTAO)
                VALUES (@MaKH, @TenKH, @GioiTinh, @CCCD, @SDT, @Email, @DiaChi, @QuocTich, @DoiTuong, @NgayTao);
            ";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int affectedRows = conn.Execute(query, et);
                    if (affectedRows > 0) 
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                flag = false;
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return flag;
        }

        //hàm sửa khách hàng
        public bool SuaKhachHang(ET_KhachHang et)
        {
            bool flag = false;

            const string query = @"
                UPDATE KHACHHANG
                    SET TENKH = @TenKH,
                    GIOITINH = @GioiTinh,
                    CCCD = @CCCD,
                    SDT = @SDT,
                    EMAIL = @Email,
                    DIACHI = @DiaChi,
                    QUOCTICH = @QuocTich,
                    DOITUONG = @DoiTuong
                    WHERE MAKH = @MaKH;
            ";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int affectedRows = conn.Execute(query, et);
                    if (affectedRows > 0)
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                flag = false;
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return flag;
        }

        //hàm ẩn khách hàng
        public bool AnKhachHang(ET_KhachHang et)
        {
            bool flag = false;

            const string query = @"
                UPDATE KHACHHANG
                    
                    WHERE MAKH = @MaKH;
            ";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int affectedRows = conn.Execute(query, et);
                    if (affectedRows > 0)
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                flag = false;
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return flag;
        }

        //hàm xóa khách hàng (cho Admin)
        public bool XoaKhachHang(ET_KhachHang et)
        {
            bool flag = false;

            const string query = @"DELETE FROM KHACHHANG WHERE MAKH = @MaKH;";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int affectedRows = conn.Execute(query, et);
                    if (affectedRows > 0)
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                flag = false;
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return flag;
        }
    }
}
