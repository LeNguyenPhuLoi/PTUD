using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dapper;

using ET;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LoaiHopDong
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy tên loại hợp đồng theo mã loại hợp đồng
        public string LayTenLoaiHDTheoMaLoaiHD(string maloaihd)
        {
            string tenloaihd = "";
            const string query = @"SELECT TENLOAIHD FROM LOAIHD WHERE MALOAIHD = @Maloaihd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    tenloaihd = conn.ExecuteScalar<string>(query, new { Maloaihd = maloaihd }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return tenloaihd;
        }

        //hàm đếm số lượng loại hợp đồng
        public int DemSoLuongLoaiHopDong()
        {
            int soluong = 0;
            const string query = @"SELECT COUNT(MALOAIHD) FROM LOAIHD";
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

        //hàm kiểm tra tên loại hợp đồng đã tồn tại
        public bool KiemTraTonTaiTenLoaiHD(string tenloaihd)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAIHD WHERE TENLOAIHD = @Tenloaihd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Tenloaihd = tenloaihd });
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

        //hàm kiểm tra mã loại hợp đồng đã tồn tại
        public bool KiemTraTonTaiMaLoaiHD(string maloaihd)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAIHD WHERE MALOAIHD = @Maloaihd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Maloaihd = maloaihd });
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

        //hàm lấy danh sách loại hợp đồng còn hoạt động
        public List<ET_LoaiHopDong> LayDSLoaiHopDongConHoatDong()
        {
            List<ET_LoaiHopDong> list = new List<ET_LoaiHopDong>();
            const string query = @"SELECT * FROM LOAIHD WHERE TINHTRANGXOA = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiHopDong>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy toàn bộ danh sách loại hợp đồng
        public List<ET_LoaiHopDong> LayDSToanBoLoaiHopDong()
        {
            List<ET_LoaiHopDong> list = new List<ET_LoaiHopDong>();
            const string query = @"SELECT * FROM LOAIHD";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiHopDong>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm thêm loại hợp đồng
        public bool ThemLoaiHopDong(ET_LoaiHopDong et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO LOAIHD (MALOAIHD, TENLOAIHD, NGAYLAP, NGAYCAPNHAT, TRANGTHAI, TINHTRANGXOA)
                VALUES (@MaLoaiHD, @TenLoaiHD, @NgayLap, @NgayCapNhat, @TrangThai, @TinhTrangXoa);
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

        //hàm sửa loại hợp đồng
        public bool SuaLoaiHopDong(ET_LoaiHopDong et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAIHD
                    SET TENLOAIHD = @TenLoaiHD,
                    NGAYLAP = @NgayLap,
                    NGAYCAPNHAT = @NgayCapNhat,
                    TRANGTHAI = @TrangThai
                    WHERE MALOAIHD = @MaLoaiHD;
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

        //hàm ẩn loại hợp đồng
        public bool AnLoaiHopDong(ET_LoaiHopDong et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAIHD
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE MALOAIHD = @MaLoaiHD;
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
    }
}
