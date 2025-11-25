using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dapper;

using ET;
using System.Globalization;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy số tài khoản theo mã tài khoản
        public string LaySTKTheoMaTK(string matk)
        {
            string stk = "";
            const string query = @"SELECT SOTAIKHOAN FROM TAIKHOAN WHERE MATK = @Matk";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    stk = conn.ExecuteScalar<string>(query, new { Matk = matk }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return stk;
        }

        //hàm đếm số lượng tài khoản
        public int DemSoLuongTaiKhoan()
        {
            int soluong = 0;
            const string query = @"SELECT COUNT(MATK) FROM TAIKHOAN";
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

        //hàm kiểm tra mã tài khoản đã tồn tại
        public bool KiemTraTonTaiSoTK(string sotk)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM TAIKHOAN WHERE SOTAIKHOAN = @Sotk";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { Sotk = sotk });
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

        //hàm kiểm tra mã tài khoản đã tồn tại
        public bool KiemTraTonTaiMaTK(string matk)
        {
            bool flag = false;
            const string query = @"SELECT COUNT(1) FROM TAIKHOAN WHERE MaTK = @MaTK";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int count = conn.ExecuteScalar<int>(query, new { MaTK = matk });
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

        //hàm lấy danh sách toàn bộ tài khoản
        public List<ET_TaiKhoan> LayDSToanBoTaiKhoan()
        {
            List<ET_TaiKhoan> list = new List<ET_TaiKhoan>();
            const string query = @"SELECT * FROM TAIKHOAN";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_TaiKhoan>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy danh sách tài khoản còn hoạt động
        public List<ET_TaiKhoan> LayDSTaiKhoanConHoatDong()
        {
            List<ET_TaiKhoan> list = new List<ET_TaiKhoan>();
            const string query = @"SELECT * FROM TAIKHOAN WHERE TINHTRANGXOA = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_TaiKhoan>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy chi tiết loại tài khoản
        public IQueryable<string> LayChiTietLoaiTK()
        {
            List<string> list = new List<string>();
            const string query = @"SELECT CHITIET FROM LOAITK WHERE TRANGTHAI = N'Còn Hoạt Động' AND TinhTrangXoa = 0";

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

        //hàm lấy tên ngoại tệ
        public IQueryable<string> LayTenNgoaiTe()
        {
            List<string> list = new List<string>();
            const string query = @"SELECT TENNGOAITE FROM NGOAITE";

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

        // Hàm lấy mã loại tài khoản theo chi tiết
        public string LayMaLoaiTKTheoChiTiet(string chitiet)
        {
            string maloaitk = null;
            const string query = @"SELECT MALOAITK FROM LOAITK WHERE CHITIET = @ChiTiet";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    maloaitk = conn.QuerySingleOrDefault<string>(query, new { ChiTiet = chitiet });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return maloaitk;
        }

        // Hàm lấy mã ngoại tệ theo tên ngoại tệ
        public string LayMaNgoaiTeTheoTen(string tenngoaite)
        {
            string mangoaite = null;
            const string query = @"SELECT MANGOAITE FROM NGOAITE WHERE TENNGOAITE = @TenNgoaiTe";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    mangoaite = conn.QuerySingleOrDefault<string>(query, new { TenNgoaiTe = tenngoaite });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return mangoaite;
        }

        // Hàm lấy mã khách hàng theo tên cccd
        public string LayMaKHTheoCccd(string cccd)
        {
            string makh = null;
            const string query = @"SELECT MAKH FROM KHACHHANG WHERE CCCD = @Cccd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    makh = conn.QueryFirstOrDefault<string>(query, new { Cccd = cccd });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return makh;
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

        //hàm lấy số cccd theo mã khách hàng
        public string LayCccdTheoMaKH(string makh)
        {
            string cccd = null;
            const string query = @"SELECT CCCD FROM KHACHHANG WHERE MAKH = @MaKH";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    cccd = conn.QueryFirstOrDefault<string>(query, new { MaKH = makh });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return cccd;
        }

        // Hàm lấy chi tiết theo mã loại tài khoản
        public string LayChiTietTheoMaLoaiTK(string maloaitk)
        {
            string chitiet = null;
            const string query = @"SELECT CHITIET FROM LOAITK WHERE MALOAITK = @MaLoaiTK";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    chitiet = conn.QuerySingleOrDefault<string>(query, new { MaLoaiTK = maloaitk });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return chitiet;
        }

        // Hàm lấy tên ngoại tệ theo mã ngoại tệ
        public string LayTenNgoaiTeTheoMa(string mangoaite)
        {
            string tenngoaite = null;
            const string query = @"SELECT TENNGOAITE FROM NGOAITE WHERE MANGOAITE = @MaNgoaiTe";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    tenngoaite = conn.QuerySingleOrDefault<string>(query, new { MaNgoaiTe = mangoaite });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return tenngoaite;
        }


        //hàm thêm tài khoản
        public bool ThemTaiKhoan(ET_TaiKhoan et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO TAIKHOAN (MATK, MAKH, SOTAIKHOAN, MALOAITK, SODU, MANGOAITE, NGAYMOTK, TRANGTHAI, TINHTRANGXOA)
                VALUES (@MaTK, @MaKH, @SoTaiKhoan, @MaLoaiTK, @SoDu, @MaNgoaiTe, @NgayMoTK, @TrangThai, @TinhTrangXoa);
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

        //hàm sửa tài khoản
        public bool SuaTaiKhoan(ET_TaiKhoan et)
        {
            bool flag = false;

            const string query = @"
                UPDATE TAIKHOAN
                    SET MAKH = @MaKH,
                    SOTAIKHOAN = @SoTaiKhoan,
                    MALOAITK = @MaLoaiTK,
                    SODU = @SoDu,
                    MANGOAITE = @MaNgoaiTe,
                    NGAYMOTK = @NgayMoTK,
                    TRANGTHAI = @TrangThai
                    WHERE MATK = @MaTK;
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

        //hàm ẩn tài khoản
        public bool AnTaiKhoan(ET_TaiKhoan et)
        {
            bool flag = false;

            const string query = @"
                UPDATE TAIKHOAN
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE MATK = @MaTK;
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

        //hàm xóa tài khoản
        public bool XoaTaiKhoan(ET_TaiKhoan et)
        {
            bool flag = false;

            const string query = @"DELETE FROM TAIKHOAN WHERE MATK = @MaTK;";

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

    public class DAL_TaiKhoan_Report
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy thông tin khách hàng
        public List<ET_TaiKhoan_Report_ThongTinKhachHang> LayThongTinKhachHang(string cccd)
        {
            const string query = @"SELECT kh.MAKH, kh.TENKH, kh.CCCD, kh.SDT, kh.DIACHI, kh.EMAIL, kh.QUOCTICH
                                    FROM TAIKHOAN tk JOIN KHACHHANG kh ON tk.MAKH = kh.MAKH
                                    WHERE kh.CCCD = @Cccd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    var item = conn.QueryFirstOrDefault<ET_TaiKhoan_Report_ThongTinKhachHang>(query, new { Cccd = cccd });

                    if (item != null)
                        return new List<ET_TaiKhoan_Report_ThongTinKhachHang> { item };
                    else
                        return new List<ET_TaiKhoan_Report_ThongTinKhachHang>();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\\log.txt", ex.ToString());
                return new List<ET_TaiKhoan_Report_ThongTinKhachHang>();
            }
        }

        //hàm lấy danh sách tài khoản
        public List<ET_TaiKhoan_Report_DanhSachTaiKhoan> LayDSTaiKhoan(string cccd)
        {

            const string query = @"SELECT tk.MATK, tk.SOTAIKHOAN, ltk.CHITIET, tk.SODU, tk.TRANGTHAI
                                    FROM TAIKHOAN tk JOIN LOAITK ltk ON tk.MALOAITK = ltk.MALOAITK JOIN KHACHHANG kh ON tk.MAKH = kh.MAKH
                                    WHERE kh.CCCD = @Cccd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    var list = conn.Query<ET_TaiKhoan_Report_DanhSachTaiKhoan>(
                        query,
                        new { Cccd = cccd }
                    ).ToList();

                    return list;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\\log.txt", ex.ToString());
                return new List<ET_TaiKhoan_Report_DanhSachTaiKhoan>();
            }
        }
    }
}
