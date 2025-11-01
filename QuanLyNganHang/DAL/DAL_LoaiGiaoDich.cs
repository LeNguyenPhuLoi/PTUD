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
    public class DAL_LoaiGiaoDich
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy tên loại giao dịch theo mã loại giao dịch
        public string LayTenLoaiGDTheoMaLoaiGD(string maloaigd)
        {
            string tenloaigd = "";
            const string query = @"SELECT TENLOAIGD FROM LOAIGD WHERE MALOAIGD = @Maloaigd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    tenloaigd = conn.ExecuteScalar<string>(query, new { Maloaigd = maloaigd }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return tenloaigd;
        }

        //hàm đếm số lượng loại giao dịch
        public int DemSoLuongLoaiGiaoDich()
        {
            int soluong = 0;
            const string query = @"SELECT COUNT(MALOAIGD) FROM LOAIGD";
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

        //hàm kiểm tra tên loại giao dịch đã tồn tại
        public bool KiemTraTonTaiTenLoaiGD(string tenloaigd)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAIGD WHERE TENLOAIGD = @Tenloaigd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Tenloaigd = tenloaigd });
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

        //hàm kiểm tra mã loại giao dịch đã tồn tại
        public bool KiemTraTonTaiMaLoaiGD(string maloaigd)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM LOAIGD WHERE MALOAIGD = @Maloaigd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Maloaigd = maloaigd });
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

        //hàm lấy danh sách loại giao dịch còn hoạt động
        public List<ET_LoaiGiaoDich> LayDSLoaiGiaoDichConHoatDong()
        {
            List<ET_LoaiGiaoDich> list = new List<ET_LoaiGiaoDich>();
            const string query = @"SELECT * FROM LOAIGD WHERE TINHTRANGXOA = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiGiaoDich>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy toàn bộ danh sách loại giao dịch
        public List<ET_LoaiGiaoDich> LayDSToanBoLoaiGiaoDich()
        {
            List<ET_LoaiGiaoDich> list = new List<ET_LoaiGiaoDich>();
            const string query = @"SELECT * FROM LOAIGD";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_LoaiGiaoDich>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm thêm loại giao dịch
        public bool ThemLoaiGiaoDich(ET_LoaiGiaoDich et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO LOAIGD (MALOAIGD, TENLOAIGD, NGAYLAP, NGAYCAPNHAT, TRANGTHAI, TINHTRANGXOA)
                VALUES (@MaLoaiGD, @TenLoaiGD, @NgayLap, @NgayCapNhat, @TrangThai, @TinhTrangXoa);
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

        //hàm sửa loại giao dịch
        public bool SuaLoaiGiaoDich(ET_LoaiGiaoDich et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAIGD
                    SET TENLOAIGD = @TenLoaiGD,
                    NGAYLAP = @NgayLap,
                    NGAYCAPNHAT = @NgayCapNhat,
                    TRANGTHAI = @TrangThai
                    WHERE MALOAIGD = @MaLoaiGD;
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

        //hàm ẩn loại giao dịch
        public bool AnLoaiGiaoDich(ET_LoaiGiaoDich et)
        {
            bool flag = false;

            const string query = @"
                UPDATE LOAIGD
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE MALOAIGD = @MaLoaiGD;
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
