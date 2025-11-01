using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dapper;

using ET;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
    public class DAL_LoaiHoTro
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy tên loại hỗ trợ theo mã loại hỗ trợ
        public string LayTenLoaiHTTheoMaLoaiHT(string maloaiht)
        {
            string tenloaiht = "";
            const string query = @"SELECT TENLOAIHT FROM LOAIHT WHERE MALOAIHT = @Maloaiht";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    tenloaiht = conn.ExecuteScalar<string>(query, new { Maloaiht = maloaiht }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return tenloaiht;
        }

        //hàm đếm số lượng loại hỗ trợ
        public int DemSoLuongLoaiHoTro()
        {
            int soluong = 0;
            const string query = @"SELECT COUNT(MALOAIHT) FROM LOAIHT";
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

        //hàm kiểm tra tên loại hỗ trợ đã tồn tại
        public bool KiemTraTonTaiTenLoaiHT(string tenloaiht)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAIHT WHERE TENLOAIHT = @Tenloaiht";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Tenloaiht = tenloaiht });
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

        //hàm kiểm tra mã loại hỗ trợ đã tồn tại
        public bool KiemTraTonTaiMaLoaiHT(string maloaiht)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAIHT WHERE MALOAIHT = @Maloaiht";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Maloaiht = maloaiht });
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

        //hàm lấy danh sách loại hỗ trợ còn hoạt động
        public List<ET_LoaiHoTro> LayDSLoaiHoTroConHoatDong()
        {
            List<ET_LoaiHoTro> list = new List<ET_LoaiHoTro>();
            const string query = @"SELECT * FROM LOAIHT WHERE TINHTRANGXOA = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiHoTro>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy toàn bộ danh sách loại hỗ trợ
        public List<ET_LoaiHoTro> LayDSToanBoLoaiHoTro()
        {
            List<ET_LoaiHoTro> list = new List<ET_LoaiHoTro>();
            const string query = @"SELECT * FROM LOAIHT";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiHoTro>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm thêm loại hỗ trợ
        public bool ThemLoaiHoTro(ET_LoaiHoTro et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO LOAIHT (MALOAIHT, TENLOAIHT, NGAYLAP, NGAYCAPNHAT, TRANGTHAI, TINHTRANGXOA)
                VALUES (@MaLoaiHT, @TenLoaiHT, @NgayLap, @NgayCapNhat, @TrangThai, @TinhTrangXoa);
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

        //hàm sửa loại hỗ trợ
        public bool SuaLoaiHoTro(ET_LoaiHoTro et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAIHT
                    SET TENLOAIHT = @TenLoaiHT,
                    NGAYLAP = @NgayLap,
                    NGAYCAPNHAT = @NgayCapNhat,
                    TRANGTHAI = @TrangThai
                    WHERE MALOAIHT = @MaLoaiHT;
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

        //hàm ẩn loại hỗ trợ
        public bool AnLoaiHoTro(ET_LoaiHoTro et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAIHT
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE MALOAIHT = @MaLoaiHT;
            "
            ;

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
