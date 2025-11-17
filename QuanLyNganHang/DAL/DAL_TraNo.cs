using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_TraNoRP
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_TraNoRP()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public List<ET_TraNoRP> LoadDSTN()
        {
            var query = from tn in db.TRANOs
                        join kv in db.KHOANVAYs on tn.MAVAY equals kv.MAVAY
                        join kh in db.KHACHHANGs on kv.MAKH equals kh.MAKH
                        select new ET_TraNoRP
                        {
                            MaTraNo = tn.MATRANO,
                            MaVay = tn.MAVAY,
                            NguoiTra = kh.MAKH,
                            SoTienNo = (decimal)tn.SOTIENO,
                            SoTienTra = (decimal)tn.SOTIENTRA,
                            NgayTra = Convert.ToDateTime(tn.NGAYTRA)
                        };
            return query.ToList();
        }

        public List<ET_TraNoRP> TimRPTN(string ma)
        {
            var search = from tn in db.TRANOs
                         where tn.MATRANO.Contains(ma) && tn.TinhTrangXoa == "Hoạt Động"
                         select new ET_TraNoRP
                         {
                             MaTraNo = tn.MATRANO,
                             MaVay = tn.MAVAY,
                             SoTienNo = (decimal)tn.SOTIENO,
                             SoTienTra = (decimal)tn.SOTIENTRA,
                             NgayTra = Convert.ToDateTime(tn.NGAYTRA)
                         };
            return search.ToList();
        }
    }
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

        //Load danh sách trả nợ
        public IQueryable LoadDSTraNouser()
        {
            IQueryable TN = from tn in db.TRANOs
                            where tn.TinhTrangXoa == "Hoạt Động"
                            select tn;
            return TN;
        }

        //Load danh sách khoản vay
        public IQueryable LoadDSKhoanVay()
        {
            IQueryable KV = from kv in db.KHOANVAYs
                            select new { kv.MAVAY, kv.TONGTIEN, kv.MAKH};
            return KV;
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

                    var khoanVayTra = db.KHOANVAYs.FirstOrDefault(tk => tk.MAVAY == et.MaVay);

                    if (khoanVayTra != null)
                    {
                        khoanVayTra.TONGTIEN = (khoanVayTra.TONGTIEN ?? 0) - (decimal)et.SoTienTra;
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

        //Hàm tự đếm mã
        public string DemMa()
        {
            int sl = (from tn in db.TRANOs
                      select tn).Count(); // Đếm số lượng nhân viên

            int dem = sl + 1;
            string ma = "TN" + dem.ToString("D2");
            return ma;
        }
    }
}
