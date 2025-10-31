using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_TraNo
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_TraNo()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách trả nợ
        public IQueryable LoadDSTraNo()
        {
            IQueryable TN = from tn in db.TRANOs
                            select tn;
            return TN;
        }

        //Thêm trả nợ
        public bool ThemTraNo(ET_TraNo et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var amp = db.TRANOs.Any(tn => tn.MATRANO == et.MaTraNo);
                if (!amp)
                {
                    TRANO tn = new TRANO
                    {
                        MATRANO = et.MaTraNo,
                        MAVAY = et.MaVay,
                        SOTIENO = et.SoTienNo,
                        SOTIENTRA = et.SoTienTra,
                        NGAYTRA = et.NgayTra,
                        TinhTrangXoa = et.TinhTrangXoa
                    };
                    db.TRANOs.InsertOnSubmit(tn);
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

        //Sửa trả nợ
        public bool SuaTraNo(ET_TraNo et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaTraNo == "")
                {
                    return false;
                }
                var change = db.TRANOs.SingleOrDefault(tn => tn.MATRANO == et.MaTraNo);
                if (change != null)
                {
                    change.MATRANO = et.MaTraNo;
                    change.MAVAY = et.MaVay;
                    change.SOTIENO = et.SoTienNo;
                    change.SOTIENTRA = et.SoTienTra;
                    change.NGAYTRA = et.NgayTra;
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

        //Xóa(ẩn) trả nợ
        public bool TrangThaiAn(ET_TraNo et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.TRANOs.Single(tn => tn.MATRANO == et.MaTraNo);
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
