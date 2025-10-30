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
    public class DAL_LoaiTaiKhoan
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm đếm số lượng loại tài khoản
        public int DemSoLuongLoaiTaiKhoan()
        {
            int soluong = 0;
            const string query = @"SELECT COUNT(MALOAITK) FROM LOAITK";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    soluong = conn.ExecuteScalar<int>(query);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return soluong;
        }

        //hàm kiểm tra chi tiết đã tồn tại
        public bool KiemTraTonTaiChiTiet(string chitiet)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAITK WHERE CHITIET = @ChiTiet";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { ChiTiet = chitiet });
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

        //hàm kiểm tra mã loại tài khoản đã tồn tại
        public bool KiemTraTonTaiMaLoaiTK(string maloaitk)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAITK WHERE MALOAITK = @MaLoaiTK";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { MALOAITK = maloaitk });
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

        //hàm lấy danh sách loại tài khoản còn hoạt động
        public List<ET_LoaiTaiKhoan> LayDSLoaiTaiKhoanConHoatDong()
        {
            List<ET_LoaiTaiKhoan> list = new List<ET_LoaiTaiKhoan>();
            const string query = @"SELECT * FROM LOAITK WHERE TINHTRANGXOA = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiTaiKhoan>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy toàn bộ danh sách loại tài khoản
        public List<ET_LoaiTaiKhoan> LayDSToanBoLoaiTaiKhoan()
        {
            List<ET_LoaiTaiKhoan> list = new List<ET_LoaiTaiKhoan>();
            const string query = @"SELECT * FROM LOAITK";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiTaiKhoan>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm thêm loại tài khoản
        public bool ThemLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO LOAITK (MALOAITK, CHITIET, NGAYTAO, NGAYCAPNHAT, TRANGTHAI, TINHTRANGXOA)
                VALUES (@MaLoaiTK, @ChiTiet, @NgayTao, @NgayCapNhat, @TrangThai, @TinhTrangXoa);
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

        //hàm sửa loại tài khoản
        public bool SuaLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAITK
                    SET CHITIET = @ChiTiet,
                    NGAYTAO = @NgayTao,
                    NGAYCAPNHAT = @NgayCapNhat,
                    TRANGTHAI = @TrangThai
                    WHERE MALOAITK = @MaLoaiTK;
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

        //hàm ẩn loại tài khoản
        public bool AnLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAITK
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE MALOAITK = @MaLoaiTK;
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

        //hàm xóa loại tài khoản
        public bool XoaLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            bool flag = false;

            const string query = @"DELETE FROM LOAITK WHERE MALOAITK = @MaLoaiTK;";

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
