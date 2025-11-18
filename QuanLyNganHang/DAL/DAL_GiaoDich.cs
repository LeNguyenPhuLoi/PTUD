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
                    if (rows > 0)
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

                    if (tienHienTai.Value >= tiencan)
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

        //hàm lấy phương thức tên loại giao dịch
        public string LayPhuongThucTheoTenLoaiGD(string tenloaigd)
        {
            string maloaigd = null;
            const string query = @"SELECT PHUONGTHUC FROM LOAIGD WHERE TENLOAIGD = @Tenloaigd";

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
                    list = conn.Query<string>(query, new { @Cccd = cccd }).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list.AsQueryable();
        }

        //hàm lấy danh sách tài khoản không thuộc số cccd
        public IQueryable<string> LayDSTaiKhoanKhongCuaSoCCCD(string cccd)
        {
            List<string> list = new List<string>();
            const string query =
                @"SELECT SOTAIKHOAN
                FROM TAIKHOAN tk, KHACHHANG kh
                WHERE tk.MAKH = kh.MAKH AND kh.CCCD != @Cccd";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    list = conn.Query<string>(query, new { @Cccd = cccd }).ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
            return list.AsQueryable();
        }

        //hàm lấy danh sách tài khoản không thuộc số cccd dạng nhập
        public IQueryable<string> LayDSTaiKhoanKhongCuaSoCCCD_Nhap(string cccd, string stk)
        {
            List<string> list = new List<string>();
            const string query =
                @"SELECT tk.SOTAIKHOAN
          FROM TAIKHOAN tk
          JOIN KHACHHANG kh ON tk.MAKH = kh.MAKH
          WHERE kh.CCCD <> @Cccd 
            AND tk.SOTAIKHOAN LIKE @StkPattern";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();

                    list = conn.Query<string>(
                        query,
                        new
                        {
                            Cccd = cccd,
                            StkPattern = "%" + stk + "%"   // thêm wildcard ở đây
                        }
                    ).ToList();
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
            const string query = @"SELECT TENLOAIGD FROM LOAIGD WHERE TRANGTHAI = N'Hoạt Động' AND TinhTrangXoa = 0";

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

        //hàm trừ tiền tài khoản A, cộng tiền tài khoản B (nếu có) và thêm giao dịch
        public bool ThemGiaoDichVaTruTien(ET_GiaoDich gd, string stkA, string SoTkB)
        {
            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        //Lấy số dư hiện tại
                        decimal sodu = conn.ExecuteScalar<decimal>("SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @Stk", new { Stk = stkA }, tran);

                        //Kiểm tra đủ tiền chưa
                        if (sodu < gd.SoTien)
                            return false;

                        //Trừ tiền tài khoản A
                        conn.Execute("UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stkA }, tran);

                        //Cộng tiền tài khoản B
                        conn.Execute("UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = SoTkB }, tran);

                        //Thêm giao dịch
                        conn.Execute(@" INSERT INTO GIAODICH(MAGD, MAKH, MATK, MATKNHAN, MALOAIGD, SOTIEN, THOIGIANGD, MOTA, TRANGTHAI, TinhTrangXoa)
                                    VALUES (@MaGD, @MaKH, @MaTk, @MaTkNhan, @MaLoaiGD, @SoTien, @ThoiGianGD, @MoTa, @TrangThai, @TinhTrangXoa);", gd, tran);

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

        //hàm cộng tiền tài khoản A, trừ tiền tài khoản B (nếu có) và thêm giao dịch
        public bool ThemGiaoDichVaCongTien(ET_GiaoDich gd, string stkA, string stkB)
        {
            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Không có tài khoản gửi → chỉ cộng tiền vào tài khoản nhận
                        if (string.IsNullOrWhiteSpace(stkB))
                        {
                            // Cộng tiền cho tài khoản nhận
                            conn.Execute(
                                "UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @StkNhan",
                                new { Tien = gd.SoTien, StkNhan = stkA },
                                tran
                            );
                        }
                        else
                        {
                            // Lấy số dư tài khoản gửi
                            decimal soDuGui = conn.ExecuteScalar<decimal>(
                                "SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @StkGui",
                                new { StkGui = stkB },
                                tran
                            );

                            // Kiểm tra đủ tiền chưa
                            if (soDuGui < gd.SoTien)
                                return false;

                            // Trừ tiền tài khoản gửi
                            conn.Execute(
                                "UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @StkGui",
                                new { Tien = gd.SoTien, StkGui = stkB },
                                tran
                            );

                            // Cộng tiền tài khoản nhận
                            conn.Execute(
                                "UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @StkNhan",
                                new { Tien = gd.SoTien, StkNhan = stkA },
                                tran
                            );
                        }

                        //Thêm giao dịch
                        conn.Execute(@" INSERT INTO GIAODICH(MAGD, MAKH, MATK, MATKNHAN, MALOAIGD, SOTIEN, THOIGIANGD, MOTA, TRANGTHAI, TinhTrangXoa)
                                    VALUES (@MaGD, @MaKH, @MaTk, @MaTkNhan, @MaLoaiGD, @SoTien, @ThoiGianGD, @MoTa, @TrangThai, @TinhTrangXoa);", gd, tran);

                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
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

        //hàm cộng tiền tài khoản A, trừ tiền tài khoản B (nếu có) và ẩn giao dịch
        public bool AnGiaoDichVaCongTien(ET_GiaoDich gd, string stkA, string stkB)
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
                        conn.Execute(@"UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stkA }, transaction: tran);

                        if (!string.IsNullOrEmpty(stkB))
                        {
                            // Lấy số dư tài khoản nhận
                            decimal sotaikhoannhan = conn.ExecuteScalar<decimal>(
                                "SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @StkNhan",
                                new { StkNhan = stkB },
                                tran
                            );

                            // Kiểm tra đủ tiền chưa
                            if (sotaikhoannhan < gd.SoTien)
                                return false;

                            // Trừ tiền tài khoản nhận
                            conn.Execute(
                                "UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @StkNhan",
                                new { Tien = gd.SoTien, StkNhan = stkB },
                                tran
                            );
                        }

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

        //hàm trừ tiền tài khoản A, cộng tiền tài khoản B (nếu có) và ẩn giao dịch
        public bool AnGiaoDichVaTruTien(ET_GiaoDich gd, string stkA, string stkB)
        {
            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra giao dịch đã bị ẩn chưa
                        bool tinhTrangXoa = conn.ExecuteScalar<bool>(
                            "SELECT TinhTrangXoa FROM GIAODICH WHERE MAGD = @MaGD",
                            new { gd.MaGD }, tran
                        );
                        if (tinhTrangXoa) return false;

                        // Cộng tiền lại cho tài khoản B (nếu có)
                        if (!string.IsNullOrEmpty(stkB))
                        {
                            conn.Execute(
                                "UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @Stk",
                                new { Tien = gd.SoTien, Stk = stkB },
                                tran
                            );
                        }

                        // Lấy số dư tài khoản A
                        decimal soDuA = conn.ExecuteScalar<decimal>(
                            "SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @StkA",
                            new { StkA = stkA },
                            tran
                        );

                        // Kiểm tra đủ tiền để trừ
                        if (soDuA < gd.SoTien)
                            return false;

                        // Trừ tiền tài khoản A
                        conn.Execute(
                            "UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @Stk",
                            new { Tien = gd.SoTien, Stk = stkA },
                            tran
                        );

                        // Ẩn giao dịch
                        conn.Execute(
                            "UPDATE GIAODICH SET TinhTrangXoa = 1 WHERE MAGD = @MaGD",
                            new { gd.MaGD },
                            tran
                        );

                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        File.AppendAllText(@"D:\log.txt", ex.ToString());
                        return false;
                    }
                }
            }
        }

        //hàm trừ tiền tài khoản A, cộng tiền tài khoản B (nếu có) và hủy ẩn giao dịch
        public bool HuyAnGiaoDichVaTruTien(ET_GiaoDich gd, string stkA, string stkB)
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

                        if (!string.IsNullOrEmpty(stkB))
                        {
                            conn.Execute(
                                "UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @Stk",
                                new { Tien = gd.SoTien, Stk = stkB },
                                tran
                            );
                        }

                        //Lấy số dư hiện tại
                        decimal soduA = conn.ExecuteScalar<decimal>("SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @Stk", new { Stk = stkA }, tran);

                        //Kiểm tra đủ tiền chưa
                        if (soduA < gd.SoTien)
                            return false;

                        //Trừ bớt tiền trong tài khoản
                        conn.Execute(@"UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stkA }, transaction: tran
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

        //hàm cộng tiền tài khoản A, trừ tiền tài khoản B (nếu có) và hủy ẩn giao dịch
        public bool HuyAnGiaoDichVaCongTien(ET_GiaoDich gd, string stkA, string stkB)
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

                        //Cộng lại tiền vào tài khoản
                        conn.Execute(@"UPDATE TAIKHOAN SET SODU = SODU + @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stkA }, transaction: tran);

                        if (!string.IsNullOrEmpty(stkB))
                        {
                            //Lấy số dư tài khoản B
                            decimal soduB = conn.ExecuteScalar<decimal>("SELECT SODU FROM TAIKHOAN WHERE SOTAIKHOAN = @Stk", new { Stk = stkB }, tran);

                            //Kiểm tra đủ tiền chưa
                            if (soduB < gd.SoTien)
                                return false;

                            //Trừ tiền vào tài khoản B
                            conn.Execute(@"UPDATE TAIKHOAN SET SODU = SODU - @Tien WHERE SOTAIKHOAN = @Stk", new { Tien = gd.SoTien, Stk = stkB }, transaction: tran);
                        }

                        //hủy ẩn giao dịch
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

    public class DAL_GiaoDich_Report
    {
        //kết nối với cơ sở dữ liệu 
        private readonly AutoConnect connect = new AutoConnect();

        //hàm lấy mã khách hàng theo số tài khoản
        public string LayMaKHTheoSoTK(string sotk)
        {
            string makh = null;
            const string query = @"SELECT MAKH FROM TAIKHOAN WHERE SOTAIKHOAN = @Sotk";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    makh = conn.QueryFirstOrDefault<string>(query, new { Sotk = sotk });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }

            return makh;
        }

        //hàm lấy thông tin khách hàng
        public List<ET_GiaoDich_Report_ThongTinKhachHang> LayThongTinKhachHang(string sotk, DateTime ngayGiaoDich)
        {
            const string query = @"SELECT kh.MAKH AS MaKh, kh.TENKH AS TenKh, tk.SOTAIKHOAN AS SoTk, ltk.CHITIET AS LoaiTK, gd.THOIGIANGD AS NgayGiaoDich
                                    FROM TAIKHOAN tk JOIN KHACHHANG kh ON tk.MAKH = kh.MAKH JOIN LOAITK ltk ON tk.MALOAITK = ltk.MALOAITK JOIN GIAODICH gd ON gd.MATK = tk.MATK
                                    WHERE tk.SOTAIKHOAN = @Sotk AND CAST(gd.THOIGIANGD AS DATE) = CAST(@NgayGiaoDich AS DATE)";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    var item = conn.QueryFirstOrDefault<ET_GiaoDich_Report_ThongTinKhachHang>(query, new { Sotk = sotk, NgayGiaoDich = ngayGiaoDich });

                    if (item != null)
                        return new List<ET_GiaoDich_Report_ThongTinKhachHang> { item };
                    else
                        return new List<ET_GiaoDich_Report_ThongTinKhachHang>();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\\log.txt", ex.ToString());
                return new List<ET_GiaoDich_Report_ThongTinKhachHang>();
            }
        }

        //hàm lấy lịch sử giao dịch
        public List<ET_GiaoDich_Report_ChiTietGiaoDich> LayChiTietGiaoDich(string sotk, DateTime ngayGiaoDich)
        {
            string maKh = LayMaKHTheoSoTK(sotk);

            const string query = @"SELECT gd.MAGD AS MaGd, lgd.TENLOAIGD AS LoaiGd, gd.SOTIEN AS Sotien, gd.MOTA AS NoiDung
                                    FROM GIAODICH gd JOIN LOAIGD lgd ON gd.MALOAIGD = lgd.MALOAIGD
                                    WHERE gd.MAKH = @MaKh AND CAST(gd.THOIGIANGD AS DATE) = CAST(@NgayGD AS DATE)";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();
                    var list = conn.Query<ET_GiaoDich_Report_ChiTietGiaoDich>(
                        query,
                        new { MaKh = maKh, NgayGD = ngayGiaoDich }
                    ).ToList();

                    return list;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\\log.txt", ex.ToString());
                return new List<ET_GiaoDich_Report_ChiTietGiaoDich>();
            }
        }

    }
}
