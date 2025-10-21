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
                            select kh;
            return KH;
        }

        //Load danh sách tài khoản
        public IQueryable LoadDSTaiKhoan()
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            select tk;
            return TK;
        }

        //Load danh sách lãi suất
        public IQueryable LoadDSLaiSuat()
        {
            IQueryable LS = from ls in db.LAISUATs
                            select ls;
            return LS;
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
                        NGAYVAY = et.NgayVay,
                        THOIHAN = et.ThoiHan,
                        TRANGTHAI = et.TrangThai,
                        MALAISUAT = et.MaLaiSuat,
                        TinhTrangXoa = et.TinhTrangXoa                        
                    };
                    db.KHOANVAYs.InsertOnSubmit(kv);
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
                if (et.MaVay == "")
                {
                    return false;
                }
                var change = db.KHOANVAYs.SingleOrDefault(kv => kv.MAVAY == et.MaVay);
                if (change != null)
                {
                    change.MAVAY = et.MaVay;
                    change.MAKH = et.MaKH;
                    change.MATK = et.MaTK;
                    change.SOTIENVAY = et.SoTienVay;
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
    }
}
