using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_LaiSuat
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_LaiSuat()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách lãi suất
        public IQueryable LoadDSLaiSuat()
        {
            IQueryable LS = from ls in db.LAISUATs
                            select ls;
            return LS;
        }

        //Load danh sách lãi suất cho user
        public IQueryable LoadDSLaiSuatUser()
        {
            IQueryable LS = from ls in db.LAISUATs
                            where ls.TinhTrangXoa == "Hoạt Động"
                            select ls;
            return LS;
        }

        //Thêm lãi suất
        public bool ThemLaiSuat(ET_LaiSuat et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaLaiSuat == "")
                {
                    return false;
                }
                var amp = db.LAISUATs.Any(l => l.MALAISUAT == et.MaLaiSuat);
                if (!amp)
                {
                    LAISUAT l = new LAISUAT
                    {
                        MALAISUAT = et.MaLaiSuat,
                        TENLOAIVAY = et.TenLoaiVay,
                        LAISUAT1 = et.LaiSuat,
                        KIEULAI = et.KieuLai,
                        SOTHANG = et.SoThang,
                        TinhTrangXoa = et.TinhTrangXoa
                    };
                    db.LAISUATs.InsertOnSubmit(l);
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

        //Sửa lãi suất
        public bool SuaLaiSuat(ET_LaiSuat et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaLaiSuat == "")
                {
                    return false;
                }
                var change = db.LAISUATs.SingleOrDefault(l => l.MALAISUAT == et.MaLaiSuat);
                if (change != null)
                {
                    change.MALAISUAT = et.MaLaiSuat;
                    change.TENLOAIVAY = et.TenLoaiVay;
                    change.LAISUAT1 = et.LaiSuat;
                    change.KIEULAI = et.KieuLai;
                    change.SOTHANG = et.SoThang;

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

        //Xóa lãi suất
        public bool XoaLaiSuat(ET_LaiSuat et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var delete = db.LAISUATs.SingleOrDefault(l => l.MALAISUAT == et.MaLaiSuat);
                if (delete != null)
                {
                    db.LAISUATs.DeleteOnSubmit(delete);
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
        public bool TrangThaiAn(ET_LaiSuat et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.LAISUATs.Single(ls => ls.MALAISUAT == et.MaLaiSuat);
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

        //Hàm tự đếm mã
        public string DemMa()
        {
            int sl = (from ls in db.LAISUATs
                      select ls).Count(); // Đếm số lượng nhân viên

            int dem = sl + 1;
            string ma = "LS" + dem.ToString("D2");
            return ma;
        }
    }
}
