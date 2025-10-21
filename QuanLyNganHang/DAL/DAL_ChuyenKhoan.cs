using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ChuyenKhoan
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ChuyenKhoan()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách chuyển khoản
        public IQueryable LoadDSChuyenKhoan()
        {
            IQueryable CK = from ck in db.CHUYENKHOANs
                            select new { ck.MACK, ck.MAKH, ck.MATK, ck.MATKGUI, ck.MATKNHAN, ck.NGAYCK, ck.SOTIEN, ck.NOIDUNG };
            return CK;
        }
        //Load danh sách khách hàng
        public IQueryable LoadDSKhachHang()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select kh;
            return KH;
        }

        //load danh sách tài khoản, tài khoản gửi, tài khoản nhận
        public IQueryable LoadDSTaiKhoan()
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            select tk;
            return TK;
        }


        //Thêm chuyển khoản
        public bool ThemCK(ET_ChuyenKhoan et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaCK == "")
                {
                    return false;
                }
                var amp = db.CHUYENKHOANs.Any(ck => ck.MACK == et.MaCK);
                if (!amp)
                {
                    CHUYENKHOAN ck = new CHUYENKHOAN
                    {
                        MACK = et.MaCK,
                        MAKH = et.MaKH,
                        MATK = et.MaTK,
                        NGAYCK = et.NgayCK,
                        SOTIEN = et.SoTien,
                        MATKGUI = et.MaTKGui,
                        MATKNHAN = et.MaTKNhan,
                        NOIDUNG = et.NoiDung
                    };
                    db.CHUYENKHOANs.InsertOnSubmit(ck);
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

        //Sửa chuyển khoản
        public bool SuaCK(ET_ChuyenKhoan et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaCK == "")
                {
                    return false;
                }
                var change = db.CHUYENKHOANs.SingleOrDefault(ck => ck.MACK == et.MaCK);
                if (change != null)
                {
                    change.MACK = et.MaCK;
                    change.MAKH = et.MaKH;
                    change.MATK = et.MaTK;
                    change.NGAYCK = et.NgayCK;
                    change.SOTIEN = et.SoTien;
                    change.MATKGUI = et.MaTKGui;
                    change.MATKNHAN = et.MaTKNhan;
                    change.NOIDUNG = et.NoiDung;

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

        //Xóa chuyển khoản
        public bool XoaCK(ET_ChuyenKhoan et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var delete = db.CHUYENKHOANs.SingleOrDefault(ck => ck.MACK == et.MaCK);
                if (delete != null)
                {
                    db.CHUYENKHOANs.DeleteOnSubmit(delete);
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
