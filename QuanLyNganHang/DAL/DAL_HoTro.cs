using Dapper;
using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoTro
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm đếm số lượng hỗ trợ
        public int DemSoLuongHoTro()
        {
            int soluong = 0;
            const string query = @"SELECT COUNT(MAHTRO) FROM HOTRO";
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

        //hàm kiểm tra cccd nhân viên có tồn tại
        public bool KiemTraTonTaiCcccNV(string cccdnv)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM NHANVIEN WHERE CCCD = @Cccdnv";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Cccdnv = cccdnv });
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

        //hàm kiểm tra cccd khách hàng có tồn tại
        public bool KiemTraTonTaiCcccKH(string cccdkh)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM KHACHHANG WHERE CCCD = @Cccdkh";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Cccdkh = cccdkh });
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

        //hàm lấy mã nhân viên theo cccd
        public string LayManvTheoCccd(string cccd)
        {
            string manv = "";
            const string query = @"SELECT MANV FROM NHANVIEN WHERE CCCD = @Cccd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    manv = conn.ExecuteScalar<string>(query, new { Cccd = cccd }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return manv;
        }

        //hàm lấy danh sách nhân viên  theo số cccd
        public List<ET_NhanVien> LayDSNhanVienTheoCCCD(string cccd)
        {
            List<ET_NhanVien> list = new List<ET_NhanVien>();
            const string query = @"SELECT * FROM NHANVIEN WHERE CCCD LIKE @Cccd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_NhanVien>(query, new { Cccd = "%" + cccd + "%" }).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy cccd theo mã nhân viên
        public string LayCccdTheoMaNV(string manv)
        {
            string cccd = "";
            const string query = @"SELECT CCCD FROM NHANVIEN WHERE MANV = @Manv";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    cccd = conn.ExecuteScalar<string>(query, new { Manv = manv }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return cccd;
        }

        //hàm lấy danh sách khách hàng theo số cccd
        public List<ET_KhachHang> LayDSKhachHangTheoCCCD(string cccd)
        {
            List<ET_KhachHang> list = new List<ET_KhachHang>();
            const string query = @"SELECT * FROM KHACHHANG WHERE CCCD LIKE @Cccd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_KhachHang>(query, new { Cccd = "%" + cccd + "%" }).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy mã khách hàng theo cccd
        public string LayMaKHTheoCccd(string cccd)
        {
            string makh = "";
            const string query = @"SELECT MAKH FROM KHACHHANG WHERE CCCD = @Cccd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    makh = conn.ExecuteScalar<string>(query, new { Cccd = cccd }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return makh;
        }

        //hàm lấy cccd theo mã khách hàng
        public string LayCccdTheoMaKH(string makh)
        {
            string cccd = "";
            const string query = @"SELECT CCCD FROM KHACHHANG WHERE MAKH = @Makh";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    cccd = conn.ExecuteScalar<string>(query, new { Makh = makh }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return cccd;
        }

        //hàm lấy mã loại hỗ trợ theo tên loại hỗ trợ
        public string LayMaLoaiHTTheoTen(string tenloaiht)
        {
            string maloaiht = "";
            const string query = @"SELECT MALOAIHT FROM LOAIHT WHERE TENLOAIHT = @Tenloaiht";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    maloaiht = conn.ExecuteScalar<string>(query, new { Tenloaiht = tenloaiht }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return maloaiht;
        }

        //hàm lấy tên loại hỗ trợ theo mã loại hỗ trợ
        public string LayTenLoaiHTTheoMa(string maloaiht)
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

        //hàm lấy tên loại hỗ trợ
        public IQueryable<string> LayTenLoaiHT()
        {
            List<string> list = new List<string>();
            const string query = @"SELECT TENLOAIHT FROM LOAIHT WHERE TRANGTHAI = N'Hoạt Động' AND TinhTrangXoa = 0";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<string>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list.AsQueryable();
        }

        //hàm lấy danh sách nhân viên con hoạt động
        public List<ET_NhanVien> LayDSNhanVienConHoatDong()
        {
            List<ET_NhanVien> list = new List<ET_NhanVien>();
            const string query = @" SELECT * FROM NHANVIEN WHERE TRANGTHAI = N'Hoạt Động'";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_NhanVien>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy danh sách khách hàng con hoạt động
        public List<ET_KhachHang> LayDSKhachHangConHoatDong()
        {
            List<ET_KhachHang> list = new List<ET_KhachHang>();
            const string query = @"SELECT * FROM KHACHHANG WHERE TINHTRANGXOA = 0";
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

        //hàm lấy danh sách hỗ trợ còn hoạt động
        public List<ET_HoTro> LayDSHoTroConHoatDong()
        {
            List<ET_HoTro> list = new List<ET_HoTro>();
            const string query = @"SELECT * FROM HOTRO WHERE TINHTRANGXOA = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_HoTro>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy danh sách toàn bộ hỗ trợ
        public List<ET_HoTro> LayDSToanBoHoTro()
        {
            List<ET_HoTro> list = new List<ET_HoTro>();
            const string query = @"SELECT * FROM HOTRO";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_HoTro>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm thêm hỗ trợ
        public bool ThemHoTro(ET_HoTro et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO HOTRO(MAHTRO, MAKH, MANV, MALOAIHT, NOIDUNG, NGAYHTRO, TinhTrangXoa)
                VALUES (@MaHTro, @MaKH, @MaNV, @MaLoaiHT, @NoiDung, @NgayHTro, @TinhTrangXoa);
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

        //hàm ẩn hỗ trợ
        public bool AnHoTro(ET_HoTro et)
        {
            bool flag = false;

            const string query = @"
                UPDATE HOTRO
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE MAHTRO = @MaHTro;
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
