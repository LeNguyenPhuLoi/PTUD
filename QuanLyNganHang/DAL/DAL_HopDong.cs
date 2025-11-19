using Dapper;
using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HopDong
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy tên nhan viên theo mã
        public string LayTenNVTheoMa(string manv)
        {
            string tennv = "";
            const string query = @"SELECT TENNV FROM NHANVIEN WHERE MANV = @Manv";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    tennv = conn.ExecuteScalar<string>(query, new { Manv = manv }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return tennv;
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

        //hàm lấy mã loại hợp đồng theo tên loại hợp đồng 
        public string LayMaLoaiHDTheoTen(string tenloaihd)
        {
            string maloaihd = "";
            const string query = @"SELECT MALOAIHD FROM LOAIHD WHERE TENLOAIHD = @Tenloaihd";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    maloaihd = conn.ExecuteScalar<string>(query, new { Tenloaihd = tenloaihd }) ?? "";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return maloaihd;
        }

        //hàm lấy tên loại hợp đồng theo mã loại hợp đồng 
        public string LayTenLoaiHDTheoMa(string maloaihd)
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

        //hàm lấy tên loại hợp đồng
        public IQueryable<string> LayTenLoaiHD()
        {
            List<string> list = new List<string>();
            const string query = @"SELECT TENLOAIHD FROM LOAIHD WHERE TRANGTHAI = N'Hoạt Động' AND TinhTrangXoa = 0";

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

        //hàm lấy danh sách hợp đồng còn hoạt động
        public List<ET_HopDong> LayDSHopDongConHoatDong()
        {
            List<ET_HopDong> list = new List<ET_HopDong>();
            const string query = @"SELECT * FROM HOPDONG WHERE TINHTRANGXOA = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_HopDong>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy danh sách toàn bộ hợp đồng
        public List<ET_HopDong> LayDSToanBoHopDong()
        {
            List<ET_HopDong> list = new List<ET_HopDong>();
            const string query = @"SELECT * FROM HOPDONG";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_HopDong>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm thêm hợp đồng
        public bool ThemHopDong(ET_HopDong et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO HOPDONG(SOHOPDONG, MALOAIHD, NGAYKY, NGAYHETHAN, GIATRI, GHICHU, TRANGTHAI, MANV, MAKH, TinhTrangXoa)
                VALUES (@SoHopDong, @MaLoaiHD, @NgayKy, @NgayHetHan, @GiaTri, @GhiChu, @TrangThai, @MaNV, @MaKH, @TinhTrangXoa);
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

        //hàm sửa hợp đồng
        public bool SuaHopDong(ET_HopDong et)
        {
            bool flag = false;

            const string query = @"
                UPDATE HOPDONG
                    SET MALOAIHD = @MaLoaiHD,
                    NGAYKY = @NgayKy,
                    NGAYHETHAN = @NgayHetHan,
                    GIATRI = @GiaTri,
                    GHICHU = @GhiChu,
                    TRANGTHAI = @TrangThai,
                    MANV = @MaNV,
                    MAKH = @MaKH,
                    WHERE SOHOPDONG = @SoHopDong;
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

        //hàm ẩn hợp đồng
        public bool AnHopDong(ET_HopDong et)
        {
            bool flag = false;

            const string query = @"
                UPDATE HOPDONG
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE SOHOPDONG = @SoHopDong;
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

    public class DAL_HopDong_Report
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy hợp đồng theo số hợp đồng
        public List<ET_HopDong_Report> LayHopDongTheoSoHD(string sohd)
        {
            const string query = @"SELECT hd.SOHOPDONG, lhd.TENLOAIHD, hd.NGAYKY, hd.NGAYHETHAN, hd.GIATRI, kh.TENKH, tk.SOTAIKHOAN, kh.CCCD, kh.SDT, kh.DIACHI, nv.MANV, nv.TENNV
FROM HOPDONG hd JOIN KHACHHANG kh ON hd.MAKH = kh.MAKH JOIN NHANVIEN nv ON nv.MANV = hd.MANV JOIN LOAIHD lhd ON lhd.MALOAIHD = hd.MALOAIHD JOIN TAIKHOAN tk ON tk.MAKH = kh.MAKH
WHERE hd.SOHOPDONG = @Sohd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    var item = conn.QueryFirstOrDefault<ET_HopDong_Report>(query, new { Sohd = sohd });

                    if (item != null)
                        return new List<ET_HopDong_Report> { item };
                    else
                        return new List<ET_HopDong_Report>();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\\log.txt", ex.ToString());
                return new List<ET_HopDong_Report>();
            }
        }
    }
}
