using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_BienLai
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_BienLai()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách biên lai
        public IQueryable LoadDSBienLai()
        {
            IQueryable BL = from bl in db.BIENLAIs
                            join gd in db.GIAODICHes on bl.MAGD equals gd.MAGD
                            join lgd in db.LOAIGDs on gd.MALOAIGD equals lgd.MALOAIGD
                            join nt in db.NGOAITEs on bl.MANGOAITE equals nt.MANGOAITE
                            select new { bl.MABL, 
                                            lgd.TENLOAIGD, 
                                            bl.MAKH, 
                                            bl.MATK, 
                                            bl.MANV, 
                                            bl.SOTIEN, 
                                            nt.TENNGOAITE, 
                                            bl.MOTA, 
                                            bl.TRANGTHAI, 
                                            bl.TinhTrangXoa};
            return BL;
        }

        //Load danh sách biên lai user
        public IQueryable LoadDSBienLaiuser()
        {
            IQueryable BL = from bl in db.BIENLAIs
                            join gd in db.GIAODICHes on bl.MAGD equals gd.MAGD
                            join lgd in db.LOAIGDs on gd.MALOAIGD equals lgd.MALOAIGD
                            join nt in db.NGOAITEs on bl.MANGOAITE equals nt.MANGOAITE
                            select new
                            {
                                bl.MABL,
                                lgd.TENLOAIGD,
                                bl.MAKH,
                                bl.MATK,
                                bl.MANV,
                                bl.SOTIEN,
                                nt.TENNGOAITE,
                                bl.MOTA,
                                bl.TRANGTHAI
                            };
            return BL;
        }

        //Load danh sách khách hàng
        public IQueryable LoadDSKH()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select new { kh.MAKH, kh.TENKH };
            return KH;
        }

        //Load danh sách nhân viên
        public IQueryable LoadDSNV()
        {
            IQueryable NV = from nv in db.NHANVIENs
                            select new { nv.MANV, nv.TENNV };
            return NV;
        }

        //Load tên giao dịch
        public IQueryable LoadDSTenGD()
        {
            IQueryable ds = from gd in db.LOAIGDs
                            select gd.TENLOAIGD;
            return ds;
        }

        //Load tên ngoại tệ
        public IQueryable LoadDSTenNT()
        {
            IQueryable ds = from nt in db.NGOAITEs
                            select nt.TENNGOAITE;
            return ds;
        }

        //Thêm biên lai
        public bool ThemBienLai(ET_BienLai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var amp = db.BIENLAIs.Any(bl => bl.MABL == et.MaBL);
                if (!amp)
                {
                    BIENLAI bl = new BIENLAI
                    {
                        MABL = et.MaBL,
                        MAGD = et.MaGD,
                        MAKH = et.MaKH,
                        MATK = et.MaTK,
                        MANV = et.MaNV,
                        SOTIEN = et.SoTien,
                        MANGOAITE = et.MaNgoaiTe,
                        MOTA = et.MoTa,
                        TRANGTHAI = et.TrangThai,
                        TinhTrangXoa = et.TinhTrangXoa
                    };
                    db.BIENLAIs.InsertOnSubmit(bl);
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

        //Sửa biên lai
        public bool SuaBienLai(ET_BienLai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaBL == "")
                {
                    return false;
                }
                var change = db.BIENLAIs.SingleOrDefault(bl => bl.MABL == et.MaBL);
                if (change != null)
                {
                    change.MABL = et.MaBL;
                    change.MAGD = et.MaGD;
                    change.MAKH = et.MaKH;
                    change.MATK = et.MaTK;
                    change.MANV = et.MaNV;
                    change.SOTIEN = et.SoTien;
                    change.MANGOAITE = et.MaNgoaiTe;
                    change.MOTA = et.MoTa;
                    change.TRANGTHAI = et.TrangThai;
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

        //Xóa(ẩn) biên lai
        public bool TrangThaiAn(ET_BienLai et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.BIENLAIs.Single(bl => bl.MABL == et.MaBL);
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
            int sl = (from bl in db.BIENLAIs
                      select bl).Count(); // Đếm số lượng nhân viên

            int dem = sl + 1;
            string ma = "BL" + dem.ToString("D3");
            return ma;
        }
    }
}
