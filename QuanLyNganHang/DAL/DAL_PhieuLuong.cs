using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using Dapper;
using System.IO;
using ET;

namespace DAL
{
    public class DAL_BangLuong
    {
        // Kết nối tới database bằng LINQ to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_BangLuong()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }
        DAL_PhieuLuong dalpl = new DAL_PhieuLuong();
        public List<ET_BangLuong> LayBangLuongNhanVien(int thang, int nam)
        {
            // Bước 1: Lấy dữ liệu cơ bản từ DB, không gọi hàm ngoài trong LINQ
            var list = (from pl in db.VIPHAMs
                        join nv in db.NHANVIENs on pl.MANV equals nv.MANV
                        select new
                        {
                            MANV = pl.MANV,
                            TENNV = nv.TENNV,
                            CCCD = nv.CCCD,
                            LUONG = nv.LUONG ?? 0
                        }).Distinct().ToList(); // distinct để tránh nhân đôi nếu có nhiều vi phạm

            // Bước 2: Tạo danh sách ET_BangLuong với tính KHAUTRU và TONG bên ngoài LINQ
            var result = new List<ET_BangLuong>();

            foreach (var item in list)
            {
                decimal khauTru = dalpl.LayTongKhauTru(item.MANV, thang, nam) ?? 0;
                decimal luong = (decimal)item.LUONG;
                decimal tong = luong - khauTru;

                result.Add(new ET_BangLuong
                {
                    MANV = item.MANV,
                    TENNV = item.TENNV,
                    CCCD = item.CCCD,
                    LUONG = luong,
                    KHAUTRU = khauTru,
                    TONG = tong
                });
            }

            return result;
        }

    }


    public class DAL_PhieuLuong
    {
        //kết nối DB 
        private readonly AutoConnect connect = new AutoConnect();

        public DAL_PhieuLuong()
        {
        }

        //===============================
        // LẤY PHIẾU LƯƠNG NHÂN VIÊN
        //===============================
        public List<ET_PhieuLuong> LayPhieuLuongNhanVien(string manv, int thang, int nam)
        {
            // Query lấy thông tin nhân viên
            const string query = @"
            SELECT 
                nv.MANV,
                nv.TENNV,
                nv.NGAYSINH,
                nv.CCCD,
                nv.LUONG
            FROM NHANVIEN nv
            WHERE nv.MANV = @Manv;
        ";

            try
            {
                using (var conn = new SqlConnection(connect.GetConnection()))
                {
                    conn.Open();

                    var data = conn.Query(query, new { Manv = manv }).ToList();

                    // Lấy phụ trợ
                    var khautru = LayTongKhauTru(manv, thang, nam);
                    var tieuDeLoi = LayTieuDeViPham(manv, thang, nam);
                    string noidung = Noidung(tieuDeLoi);

                    // Dựng output
                    var result = data.Select(item => new ET_PhieuLuong
                    {
                        MANV = item.MANV,
                        TENNV = item.TENNV,
                        NGAYSINH = Convert.ToDateTime(item.NGAYSINH),
                        CCCD = item.CCCD,

                        LUONG = (decimal)(item.LUONG ?? 0),
                        KHAUTRU = (decimal)(khautru ?? 0),
                        NOIDUNG = noidung,

                        TONG = (decimal)(item.LUONG ?? 0) - (decimal)(khautru ?? 0)

                    }).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"D:\log.txt", ex.ToString());
                return new List<ET_PhieuLuong>();
            }
        }


        //===============================
        // TÍNH TỔNG KHẤU TRỪ
        //===============================
        public decimal? LayTongKhauTru(string manv, int thang, int nam)
        {
            DateTime dauThang = new DateTime(nam, thang, 1);
            DateTime dauThangSau = dauThang.AddMonths(1);

            const string query = @"
            SELECT SUM(vp.HINHTHUCXL)
            FROM VIPHAM vp
            WHERE vp.MANV = @Manv
              AND vp.NGAYVP >= @TuNgay
              AND vp.NGAYVP < @DenNgay;
        ";

            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();
                return conn.ExecuteScalar<decimal?>(query, new
                {
                    Manv = manv,
                    TuNgay = dauThang,
                    DenNgay = dauThangSau
                });
            }
        }

        //===============================
        // LẤY TIÊU ĐỀ VI PHẠM
        //===============================
        public List<string> LayTieuDeViPham(string manv, int thang, int nam)
        {
            DateTime dauThang = new DateTime(nam, thang, 1);
            DateTime dauThangSau = dauThang.AddMonths(1);

            const string query = @"
            SELECT nq.TIEUDE
            FROM VIPHAM vp
            JOIN NOIQUY nq ON vp.MANQ = nq.MANQ
            WHERE vp.MANV = @Manv
              AND vp.NGAYVP >= @TuNgay
              AND vp.NGAYVP < @DenNgay;
        ";

            using (var conn = new SqlConnection(connect.GetConnection()))
            {
                conn.Open();

                return conn.Query<string>(query, new
                {
                    Manv = manv,
                    TuNgay = dauThang,
                    DenNgay = dauThangSau
                }).ToList();
            }
        }

        //===============================
        // GHÉP NỘI DUNG VI PHẠM (không trùng)
        //===============================
        public string Noidung(List<string> danhsachloi)
        {
            HashSet<string> tonTai = new HashSet<string>();
            string nd = "";

            foreach (var item in danhsachloi)
            {
                if (tonTai.Add(item)) // Add -> true nếu chưa tồn tại
                {
                    nd += item + ", ";
                }
            }

            return nd.Trim().TrimEnd(',');
        }
    }

}
