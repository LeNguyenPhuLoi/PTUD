using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
namespace DAL
{
    public class DAL_KhuyenMai
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_KhuyenMai()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách khuyến mãi
        public IQueryable LoadDSKhuyenMai()
        {
            IQueryable KM = from km in db.KHUYENMAIs
                            select km;
            return KM;
        }

        //Thêm khuyến mãi
        public bool ThemKM(ET_KhuyenMai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaKM == "")
                {
                    return false;
                }
                var amp = db.KHUYENMAIs.Any(km => km.MAKM == et.MaKM);
                if (!amp)
                {
                    KHUYENMAI km = new KHUYENMAI
                    {
                        MAKM = et.MaKM,
                        TENKM = et.TenKM,
                        MOTA = et.MoTa,
                        NGAYBD = et.NgayBD,
                        NGAYKT = et.NgayKT,
                        DKAPDUNG = et.DKApDung,
                        TinhTrangXoa = et.TinhTrangXoa
                    };
                    db.KHUYENMAIs.InsertOnSubmit(km);
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

        //Sửa khuyến mãi
        public bool SuaKM(ET_KhuyenMai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaKM == "")
                {
                    return false;
                }
                var change = db.KHUYENMAIs.SingleOrDefault(km => km.MAKM == et.MaKM);
                if (change != null)
                {
                    change.MAKM = et.MaKM;
                    change.TENKM = et.TenKM;
                    change.MOTA = et.MoTa;
                    change.NGAYBD = et.NgayBD;
                    change.NGAYKT = et.NgayKT;
                    change.DKAPDUNG = et.DKApDung;

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

        //Xóa khuyến mãi
        public bool XoaKM(ET_KhuyenMai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var delete = db.KHUYENMAIs.SingleOrDefault(km => km.MAKM == et.MaKM);
                if (delete != null)
                {
                    db.KHUYENMAIs.DeleteOnSubmit(delete);
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
        public bool TrangThaiAn(ET_KhuyenMai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.KHUYENMAIs.Single(km => km.MAKM == et.MaKM);
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
