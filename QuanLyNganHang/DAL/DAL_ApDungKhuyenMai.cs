using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ApDungKhuyenMai
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ApDungKhuyenMai()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách áp dụng khuyến mãi
        public IQueryable LoadDSADKM()
        {
            IQueryable ADKM = from adkm in db.APDUNGKHUYENMAIs
                            select adkm;
            return ADKM;
        }

        //Thêm áp dụng khuyến mãi
        public bool ThemADKM(ET_ApDungKhuyenMai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var amp = db.APDUNGKHUYENMAIs.Any(adkm => adkm.MAKM == et.MaKM);
                if (!amp)
                {
                    APDUNGKHUYENMAI adkm = new APDUNGKHUYENMAI
                    {
                        MAKM = et.MaKM,
                        MAKH = et.MaKH,
                        MATK = et.MaTK,
                        NGAYAPDUNG = et.NgayApDung,                   
                        TinhTrangXoa = et.TinhTrangXoa
                    };
                    db.APDUNGKHUYENMAIs.InsertOnSubmit(adkm);
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

        //Sửa áp dụng khuyến mãi
        public bool SuaADKM(ET_ApDungKhuyenMai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaKM == "")
                {
                    return false;
                }
                var change = db.APDUNGKHUYENMAIs.SingleOrDefault(adkm => adkm.MAKM == et.MaKM);
                if (change != null)
                {
                    change.MAKM = et.MaKM;
                    change.MAKH = et.MaKH;
                    change.MATK = et.MaTK;
                    change.NGAYAPDUNG = et.NgayApDung;
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
        //Xóa(ẩn) áp dụng khuyến mãi
        public bool TrangThaiAn(ET_ApDungKhuyenMai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.APDUNGKHUYENMAIs.Single(adkm => adkm.MAKM == et.MaKM);
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
