using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
namespace DAL
{
    public class DAL_NgoaiTe
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_NgoaiTe()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách ngoại tệ
        public IQueryable LoadDSNT()
        {
            IQueryable NT = from nt in db.NGOAITEs
                              select nt;
            return NT;
        }

        //Thêm ngoại tệ
        public bool ThemNT(ET_NgoaiTe et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var amp = db.NGOAITEs.Any(nt => nt.MANGOAITE == et.MaNgoaiTe);
                if (!amp)
                {
                    NGOAITE nt = new NGOAITE
                    {
                        MANGOAITE = et.MaNgoaiTe,
                        TENNGOAITE = et.TenNgoaiTe,
                        KYHIEU = et.KyHieu,
                        QUOCGIA = et.QuocGia,
                        TRANGTHAI = et.TrangThai,
                        TinhTrangXoa = et.TinhTrangXoa
                    };
                    db.NGOAITEs.InsertOnSubmit(nt);
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

        //Sửa ngoại tệ
        public bool SuaNT(ET_NgoaiTe et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaNgoaiTe == "")
                {
                    return false;
                }
                var change = db.NGOAITEs.SingleOrDefault(nt => nt.MANGOAITE == et.MaNgoaiTe);
                if (change != null)
                {
                    change.MANGOAITE = et.MaNgoaiTe;
                    change.TENNGOAITE = et.TenNgoaiTe;
                    change.KYHIEU = et.KyHieu;
                    change.QUOCGIA = et.QuocGia;
                    change.TRANGTHAI = et.TrangThai;
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

        //Xóa(ẩn) ngoại tệ
        public bool TrangThaiAn(ET_NgoaiTe et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.NGOAITEs.Single(nt => nt.MANGOAITE == et.MaNgoaiTe);
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
