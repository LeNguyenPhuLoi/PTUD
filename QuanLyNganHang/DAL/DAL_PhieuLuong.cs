using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        // Kết nối tới database bằng LINQ to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_PhieuLuong()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public List<ET_PhieuLuong> LayPhieuLuongNhanVien(string manv, int thang, int nam)
        {
            // 1. Xử lý ngày tháng (nếu cần lọc chính xác theo ngày lập phiếu)
            // Ở đây mình lọc theo tháng và năm của phiếu lương
            var khautru = LayTongKhauTru(manv, thang, nam);
            string noidung = Noidung(LayTieuDeViPham(manv, thang, nam));


            var query = from pl in db.VIPHAMs
                        join nv in db.NHANVIENs on pl.MANV equals nv.MANV
                        where nv.MANV == manv
                        select new ET_PhieuLuong
                        {
                            // Map dữ liệu từ 2 bảng vào class ET_PhieuLuong
                            MANV = pl.MANV,
                            TENNV = nv.TENNV,

                            // Xử lý ngày sinh (Convert để tránh lỗi null)
                            NGAYSINH = Convert.ToDateTime(nv.NGAYSINH),
                            CCCD = nv.CCCD,

                            // Ép kiểu decimal và xử lý null (?? 0)
                            LUONG = (decimal)(nv.LUONG ?? 0),
                            KHAUTRU = (decimal)(khautru ?? 0),

                            // Tự tạo nội dung hiển thị
                            NOIDUNG = noidung,

                            // Tổng thực lĩnh
                            TONG = (decimal)(nv.LUONG ?? 0) - (decimal)(khautru ?? 0)
                        };

            return query.ToList();
        }

       

        public decimal? LayTongKhauTru(string manv, int thang, int nam)
        {
            DateTime dauThang = new DateTime(nam, thang, 1);
            DateTime dauThangSau = dauThang.AddMonths(1);

            // Lọc theo NV, theo Tháng/Năm và tính tổng Khấu Trừ
            decimal? tong = (from vp in db.VIPHAMs
                            where vp.MANV == manv
                                     && vp.NGAYVP >= dauThang
                                     && vp.NGAYVP < dauThangSau
                            select vp.HINHTHUCXL).Sum();

            return tong;
        }
        public List<string> LayTieuDeViPham(string manv, int thang, int nam)
        {
            using (var db = new QLNHDataContext()) // Thay bằng Context của bạn
            {
                // 1. Xác định khoảng thời gian (Từ đầu tháng đến đầu tháng sau)
                DateTime dauThang = new DateTime(nam, thang, 1);
                DateTime dauThangSau = dauThang.AddMonths(1);

                // 2. Truy vấn kết hợp (Join)
                var danhSachLoi = (from vp in db.VIPHAMs
                                   join nq in db.NOIQUYs on vp.MANQ equals nq.MANQ
                                   where vp.MANV == manv
                                      && vp.NGAYVP >= dauThang
                                      && vp.NGAYVP < dauThangSau
                                   select nq.TIEUDE).ToList();

                return danhSachLoi;
            }
        }

        public string Noidung (List<string> danhsachloi)
        {
            string noiDung = "";
            HashSet<string> tontai = new HashSet<string>(); // dùng để tránh trùng

            foreach (var item in danhsachloi)
            {
                if (!tontai.Contains(item)) // nếu chưa có thì thêm
                {
                    tontai.Add(item);
                    noiDung += item + ", ";
                }
            }
            return noiDung;
        }

    }
}
