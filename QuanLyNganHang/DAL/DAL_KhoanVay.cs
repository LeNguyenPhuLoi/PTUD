using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_KhoanVay
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_KhoanVay()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách khoản vay
        public IQueryable LoadDSKhoanVay()
        {
            IQueryable KV = from kv in db.KHOANVAYs
                            select kv;
            return KV;
        }

        //Load  danh sách khoản vay cho user
        public IQueryable LoadDSKhoanVayUser()
        {
            IQueryable KV = from kv in db.KHOANVAYs
                            where kv.TinhTrangXoa == "Hoạt Động"
                            select kv;
            return KV;
        }

        //Load danh sách khách hàng
        public IQueryable LoadDSKhachHang()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select new { kh.MAKH, kh.TENKH, kh.CCCD, kh.SDT };
            return KH;
        }

        //Load danh sách tài khoản
        public IQueryable LoadDSTaiKhoan()
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            select new { tk.MATK, tk.MAKH, tk.SOTAIKHOAN };
            return TK;
        }

        //Load danh sách lãi suất
        public IQueryable LoadDSLaiSuat()
        {
            IQueryable LS = from ls in db.LAISUATs
                            select new { ls.MALAISUAT, ls.TENLOAIVAY, ls.LAISUAT1, ls.KIEULAI , ls.SOTHANG};
            return LS;
        }

        //Lấy số tháng theo mã lãi suất

        public int SoThang(string ma)
        {
            var thang = (from ls in db.LAISUATs
                        where ls.MALAISUAT == ma
                        select ls.SOTHANG).FirstOrDefault();
                      
            return thang ?? 0;
        }

        //Thêm khoản vay
        public bool ThemKV(ET_KhoanVay et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaVay == "")
                {
                    return false;
                }
                var amp = db.KHOANVAYs.Any(kv => kv.MAVAY == et.MaVay);
                if (!amp)
                {
                    KHOANVAY kv = new KHOANVAY
                    {
                        MAVAY = et.MaVay,
                        MAKH = et.MaKH,
                        MATK = et.MaTK,
                        SOTIENVAY = et.SoTienVay,
                        TONGTIEN = et.TongTien,
                        NGAYVAY = et.NgayVay,
                        THOIHAN = et.ThoiHan,
                        TRANGTHAI = et.TrangThai,
                        MALAISUAT = et.MaLaiSuat,
                        TinhTrangXoa = et.TinhTrangXoa                        
                    };
                    db.KHOANVAYs.InsertOnSubmit(kv);

                    var taiKhoanNhan = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MaTK);

                    if (taiKhoanNhan != null)
                    {
                        taiKhoanNhan.SODU = (taiKhoanNhan.SODU ?? 0) + (decimal)et.SoTienVay;
                    }

                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Sửa khoản vay
        public bool SuaKV(ET_KhoanVay et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.KHOANVAYs.SingleOrDefault(kv => kv.MAVAY == et.MaVay);
                var taiKhoanNhanCu = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == change.MATK);

                //Hoàn lại số tiền
                if (taiKhoanNhanCu != null)
                    taiKhoanNhanCu.SODU = (taiKhoanNhanCu.SODU ?? 0) - (change.SOTIENVAY ?? 0);

                //Tài khoản mới
                var taiKhoanNhanMoi = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MaTK);

                //Cập nhật số dư
                taiKhoanNhanMoi.SODU += et.SoTienVay;

                if (et.MaVay == "")
                {
                    return false;
                }
                
                if (change != null)
                {
                    change.MAVAY = et.MaVay;
                    change.MAKH = et.MaKH;
                    change.MATK = et.MaTK;
                    change.SOTIENVAY = et.SoTienVay;
                    change.TONGTIEN = et.TongTien;
                    change.NGAYVAY = et.NgayVay;
                    change.THOIHAN = et.ThoiHan;
                    change.TRANGTHAI = et.TrangThai;
                    change.MALAISUAT = et.MaLaiSuat;

                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Xóa khoản vay
        public bool XoaKV(ET_KhoanVay et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var delete = db.KHOANVAYs.SingleOrDefault(kv => kv.MAVAY == et.MaVay);
                var taiKhoanNhan = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == delete.MATK);

                //Hủy vay, lấy lại số tiền tài khoản đã vay
                if (taiKhoanNhan != null)
                    taiKhoanNhan.SODU = (taiKhoanNhan.SODU ?? 0) - (decimal)(delete.SOTIENVAY ?? 0);

                if (delete != null)
                {
                    db.KHOANVAYs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //Trạng thái ẩn
        public bool TrangThaiAn(ET_KhoanVay et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.KHOANVAYs.Single(kv => kv.MAVAY == et.MaVay);
                if (change != null)
                {
                    change.TinhTrangXoa = et.TinhTrangXoa;
                    db.SubmitChanges();
                    ss = true;
                }
            }
            catch (Exception ex)
            {
                ss = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return ss;
        }

        //
        public bool KiemTraTaiKhoanThuocKhachHang(string maTK, string maKH)
        {
            try
            {
                bool tonTai = db.TAIKHOANs.Any(tk => tk.MATK == maTK && tk.MAKH == maKH);
                return tonTai;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi" + ex.Message);
                return false;
            }
        }

        //Hàm tự đếm mã
        public string DemMa()
        {
            int sl = (from kv in db.KHOANVAYs
                      select kv).Count(); // Đếm số lượng nhân viên

            int dem = sl + 1;
            string ma = "VAY" + dem.ToString("D3");
            return ma;
        }
    }
}
