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
    public class DAL_GiaoDich
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();     

        //hàm trừ tiền
        public bool TruTien(string stk, decimal tientru)
        {
            bool flag = false;
            try
            {
                const string sql = @"
                    UPDATE TAIKHOAN
                    SET SODU = SODU - @TienTru
                    WHERE SOTAIKHOAN = @Stk AND SODU >= @TienTru";

                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    int rows = conn.Execute(sql, new { Stk = stk, TienTru = tientru });
                    if(rows > 0 )
                        flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return flag;
        }

        //hàm so sánh tiền 
        public bool SoSanhTien(string stk, decimal tiencan)
        {
            bool flag = false;
            const string query = @"SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @Stk";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    decimal? tienHienTai = conn.ExecuteScalar<decimal?>(query, new { Stk = stk });

                    // Nếu tài khoản không tồn tại
                    if (!tienHienTai.HasValue)
                        return false;

                    if(tienHienTai.Value >= tiencan)
                        return true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return flag;
        }

        // Hàm lấy tên loại giao dịch theo mã loại giao dịch
        public string LayTenLoaiGDTheoMaGD(string maloaigd)
        {
            string tenloaigd = null;
            const string query = @"SELECT TENLOAIGD FROM LOAIGD WHERE MALOAIGD = @Maloaigd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    tenloaigd = conn.QueryFirstOrDefault<string>(query, new { Maloaigd = maloaigd });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return tenloaigd;
        }

        // Hàm lấy mã loại giao dịch theo tên loại giao dịch
        public string LayMaGDTheoTenLoaiGD(string tenloaigd)
        {
            string maloaigd = null;
            const string query = @"SELECT MALOAIGD FROM LOAIGD WHERE TENLOAIGD = @Tenloaigd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    maloaigd = conn.QueryFirstOrDefault<string>(query, new { Tenloaigd = tenloaigd });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return maloaigd;
        }

        // Hàm lấy số tài khoản theo mã tài khoản
        public string LaySTKTheoMaTK(string matk)
        {
            string sotk = null;
            const string query = @"SELECT SOTAIKHOAN FROM TAIKHOAN WHERE MATK = @Matk";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    sotk = conn.QueryFirstOrDefault<string>(query, new { Matk = matk });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return sotk;
        }

        // Hàm lấy mã tài khoản theo số tài khoản
        public string LayMaTKTheoSTK(string stk)
        {
            string matk = null;
            const string query = @"SELECT MATK FROM TAIKHOAN WHERE SOTAIKHOAN = @Stk";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    matk = conn.QueryFirstOrDefault<string>(query, new { Stk = stk });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return matk;
        }

        // Hàm lấy cccd theo mã khách hàng
        public string LayCccdTheoMaKH(string makh)
        {
            string cccd = null;
            const string query = @"SELECT CCCD FROM KHACHHANG WHERE MAKH = @Makh";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    cccd = conn.QueryFirstOrDefault<string>(query, new { Makh = makh });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return cccd;
        }

        // Hàm lấy mã khách hàng theo cccd
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

        //hàm đếm số lượng giao dịch
        public int DemSoLuongGiaoDich()
        {
            int soluong = 0;
            const string query = @"SELECT COUNT(MAGD) FROM GIAODICH";
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

        //hàm lấy danh sách tài khoản theo số cccd
        public IQueryable<string> LayDSTaiKhoanTheoCCCD(string cccd)
        {
            List<string> list = new List<string>();
            const string query = 
                @"SELECT SOTAIKHOAN
                FROM TAIKHOAN tk, KHACHHANG kh
                WHERE tk.MAKH = kh.MAKH AND kh.CCCD = @Cccd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<string>(query, new {@Cccd = cccd}).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list.AsQueryable();
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

        //hàm lấy tên loại giao dịch
        public IQueryable<string> LayTenLoaiGiaoDich()
        {
            List<string> list = new List<string>();
            const string query = @"SELECT TENLOAIGD FROM LOAIGD";

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

        //hàm lấy danh sách giao dịch chưa ẩn
        public List<ET_GiaoDich> LayDSGiaoDichChuaAn()
        {
            List<ET_GiaoDich> list = new List<ET_GiaoDich>();
            const string query = @"SELECT * FROM GIAODICH WHERE TinhTrangXoa = 0";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_GiaoDich>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list;
        }

        //hàm lấy toàn bộ danh sách giao dịch
        public List<ET_GiaoDich> LayToanBoDSGiaoDich()
        {
            List<ET_GiaoDich> list = new List<ET_GiaoDich>();
            const string query = @"SELECT * FROM GIAODICH";
            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<ET_GiaoDich>(query).ToList();
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

        //hàm thêm giao dịch 
        public bool ThemGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;

            const string query = @"
                INSERT INTO GIAODICH(MAGD, MAKH, MATK, MALOAIGD, SOTIEN, THOIGIANGD, MOTA, TRANGTHAI, TinhTrangXoa)
                VALUES (@MaGD, @MaKH, @MaTk, @MaLoaiGD, @SoTien, @ThoiGianGD, @MoTa, @TrangThai, @TinhTrangXoa);
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

        //hàm thêm giao dịch và trừ tiền
        public bool ThemGiaoDichVaTruTien(ET_GiaoDich gd, string stk)
        {
            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        //Lấy số dư hiện tại
                        decimal sodu = conn.ExecuteScalar<decimal>("SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @Stk", new { Stk = stk }, tran);

                        //Kiểm tra đủ tiền chưa
                        if (sodu < gd.SoTien)
                            return false;

                        //Trừ tiền
                        conn.Execute("UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stk }, tran);

                        //Thêm giao dịch
                        conn.Execute(@" INSERT INTO GIAODICH(MAGD, MAKH, MATK, MALOAIGD, SOTIEN, THOIGIANGD, MOTA, TRANGTHAI, TinhTrangXoa)
                                    VALUES (@MaGD, @MaKH, @MaTk, @MaLoaiGD, @SoTien, @ThoiGianGD, @MoTa, @TrangThai, @TinhTrangXoa);", gd, tran);

                        //lưu
                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //rollback
                        tran.Rollback();
                        File.AppendAllText(@"D:\log.txt", ex.ToString());
                        return false;
                    }
                }
            }
        }

        //hàm ẩn giao dịch
        public bool AnGiaoDich(ET_GiaoDich et)
        {
            bool flag = false;

            const string query = @"
                UPDATE GIAODICH
                    SET TINHTRANGXOA = @TinhTrangXoa
                    WHERE MAGD = @MaGD;
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

        //hàm ẩn giao dịch và cộng tiền
        public bool AnGiaoDichVaCongTien(ET_GiaoDich gd, string stk)
        {
            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        //lấy tình trạng xóa
                        bool tinhtrangxoa = conn.ExecuteScalar<bool>("SELECT TinhTrangXoa FROM GIAODICH WHERE MAGD = @Magd", new { Magd = gd.MaGD }, tran);

                        //kiểm tra tình trạng xóa
                        if (tinhtrangxoa == true)
                            return false;

                        //Cộng lại tiền vào tài khoản
                        conn.Execute(@"UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stk }, transaction: tran
                        );

                        //Ẩn giao dịch
                        conn.Execute(@"UPDATE GIAODICH SET TINHTRANGXOA = @TinhTrangXoa WHERE MAGD = @MaGD", new { gd.TinhTrangXoa, gd.MaGD },
                            transaction: tran
                        );

                        //lưu
                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //rollback
                        tran.Rollback();
                        File.AppendAllText(@"D:\log.txt", ex.ToString());
                        return false;
                    }
                }
            }
        }

        //hàm hủy ẩn giao dịch và trừ tiền
        public bool HuyAnGiaoDichVaTruTien(ET_GiaoDich gd, string stk)
        {
            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        //lấy tình trạng xóa
                        bool tinhtrangxoa = conn.ExecuteScalar<bool>("SELECT TinhTrangXoa FROM GIAODICH WHERE MAGD = @Magd", new { Magd = gd.MaGD }, tran);

                        //kiểm tra tình trạng xóa
                        if (tinhtrangxoa == false)
                            return false;

                        //Lấy số dư hiện tại
                        decimal sodu = conn.ExecuteScalar<decimal>("SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @Stk", new { Stk = stk }, tran);

                        //Kiểm tra đủ tiền chưa
                        if (sodu < gd.SoTien)
                            return false;

                        //Cộng lại tiền vào tài khoản
                        conn.Execute(@"UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stk }, transaction: tran
                        );

                        //Ẩn giao dịch
                        conn.Execute(@"UPDATE GIAODICH SET TINHTRANGXOA = @TinhTrangXoa WHERE MAGD = @MaGD", new { gd.TinhTrangXoa, gd.MaGD },
                            transaction: tran
                        );

                        //lưu
                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //rollback
                        tran.Rollback();
                        File.AppendAllText(@"D:\log.txt", ex.ToString());
                        return false;
                    }
                }
            }
        }
    }
}
