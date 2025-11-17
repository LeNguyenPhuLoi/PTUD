using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{

    public class DAL_ChuyenKhoanRP
    {
        //Kết nối với Linq to SQL
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ChuyenKhoanRP()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public List<ET_ChuyenKhoanRP> LoadDSCK()
        {
            var query = from ck in db.CHUYENKHOANs
                        join kh in db.KHACHHANGs on ck.MAKH equals kh.MAKH
                        join tk in db.TAIKHOANs on ck.MATK equals tk.MATK
                        join tkGui in db.TAIKHOANs on ck.MATKGUI equals tkGui.MATK
                        join khGui in db.KHACHHANGs on tkGui.MAKH equals khGui.MAKH
                        join tkNhan in db.TAIKHOANs on ck.MATKNHAN equals tkNhan.MATK
                        join khNhan in db.KHACHHANGs on tkNhan.MAKH equals khNhan.MAKH
                        select new ET_ChuyenKhoanRP
                        {
                            MaCK = ck.MACK,
                            MaKH = ck.MAKH,
                            TenKH = kh.TENKH,
                            SoTaiKhoan = tk.SOTAIKHOAN,
                            NgayCK = Convert.ToDateTime(ck.NGAYCK),
                            SoTien = (decimal)ck.SOTIEN,
                            MaTKGui = ck.MATKGUI,
                            TenTKGui = khGui.TENKH,
                            MaTKNhan = ck.MATKNHAN,
                            TenTkNhan = khNhan.TENKH,
                            NoiDung = ck.NOIDUNG
                        };
            return query.ToList();
        }

        public List<ET_ChuyenKhoanRP> TimRPCK(string ma)
        {
            var search = from ck in db.CHUYENKHOANs
                         join kh in db.KHACHHANGs on ck.MAKH equals kh.MAKH
                         join tk in db.TAIKHOANs on ck.MATK equals tk.MATK
                         join tkGui in db.TAIKHOANs on ck.MATKGUI equals tkGui.MATK
                         join khGui in db.KHACHHANGs on tkGui.MAKH equals khGui.MAKH
                         join tkNhan in db.TAIKHOANs on ck.MATKNHAN equals tkNhan.MATK
                         join khNhan in db.KHACHHANGs on tkNhan.MAKH equals khNhan.MAKH
                         where ck.MACK.Contains(ma) && ck.TinhTrangXoa == "Hoạt Động"
                         select new ET_ChuyenKhoanRP
                         {
                             MaCK = ck.MACK,
                             MaKH = ck.MAKH,
                             TenKH = kh.TENKH,
                             SoTaiKhoan = tk.SOTAIKHOAN,
                             NgayCK = Convert.ToDateTime(ck.NGAYCK),
                             SoTien = (decimal)ck.SOTIEN,
                             MaTKGui = ck.MATKGUI,
                             TenTKGui = khGui.TENKH,
                             MaTKNhan = ck.MATKNHAN,
                             TenTkNhan = khNhan.TENKH,
                             NoiDung = ck.NOIDUNG
                         };
            return search.ToList();
        }
    }
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
                            select ck;
            return CK;
        }

        //Load danh sách chuyển khoản cho user
        public IQueryable LoadDSChuyenKhoanUser()
        {
            IQueryable CK = from ck in db.CHUYENKHOANs
                            where ck.TinhTrangXoa == "Hoạt Động"
                            select ck;
            return CK;
        }


        //Load danh sách khách hàng
        public IQueryable LoadDSKhachHang()
        {
            IQueryable KH = from kh in db.KHACHHANGs
                            select new { kh.MAKH, kh.TENKH, kh.CCCD, kh.SDT };
            return KH;
        }

        //load danh sách tài khoản, tài khoản gửi, tài khoản nhận
        public IQueryable LoadDSTaiKhoan()
        {
            IQueryable TK = from tk in db.TAIKHOANs
                            select new {tk.MATK, tk.MAKH, tk.SOTAIKHOAN};
            return TK;
        }


        //Thêm chuyển khoản
        public bool ThemCK(ET_ChuyenKhoan et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var taiKhoanGui = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MaTKGui);

                // Kiểm tra số dư tài khoản gửi
                if ((taiKhoanGui.SODU ?? 0) < et.SoTien)
                {
                    return false;
                }

                if (et.SoTien < 0)
                {
                    return false;
                }
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
                        NOIDUNG = et.NoiDung,
                        TinhTrangXoa = et.TinhTrangXoa
                    };
                    db.CHUYENKHOANs.InsertOnSubmit(ck);
                    

                    // Trừ tiền tài khoản gửi
                    taiKhoanGui.SODU = (taiKhoanGui.SODU ?? 0) - et.SoTien;

                    var taiKhoanNhan = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MaTKNhan);

                    if (taiKhoanNhan != null)
                    {
                        taiKhoanNhan.SODU = (taiKhoanNhan.SODU ?? 0) + (decimal)et.SoTien;
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

        //Sửa chuyển khoản
        public bool SuaCK(ET_ChuyenKhoan et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var ck = db.CHUYENKHOANs.FirstOrDefault(n => n.MACK == et.MaCK);

                // Tài khoản cũ trước khi cập nhật
                var taiKhoanGuiCu = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == ck.MATKGUI);
                var taiKhoanNhanCu = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == ck.MATKNHAN);

                // Hoàn lại số tiền
                if (taiKhoanGuiCu != null)
                    taiKhoanGuiCu.SODU = (taiKhoanGuiCu.SODU ?? 0) + (ck.SOTIEN ?? 0);
                if (taiKhoanNhanCu != null)
                    taiKhoanNhanCu.SODU = (taiKhoanNhanCu.SODU ?? 0) - (ck.SOTIEN ?? 0);

                // Tài khoản mới
                var taiKhoanGuiMoi = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MaTKGui);
                var taiKhoanNhanMoi = db.TAIKHOANs.FirstOrDefault(tk => tk.MATK == et.MaTKNhan);

                // Kiểm tra nếu không đủ tiền thì hoàn lại tiền
                if (taiKhoanGuiMoi == null || (taiKhoanGuiMoi.SODU ?? 0) < et.SoTien)
                {
                    // ↩ Hoàn lại giao dịch cũ vì cập nhật thất bại
                    if (taiKhoanGuiCu != null)
                        taiKhoanGuiCu.SODU = (taiKhoanGuiCu.SODU ?? 0) - (ck.SOTIEN ?? 0);
                    if (taiKhoanNhanCu != null)
                        taiKhoanNhanCu.SODU = (taiKhoanNhanCu.SODU ?? 0) + (ck.SOTIEN ?? 0);

                    return false;
                }

                //Thực hiện cập nhật số dư
                taiKhoanGuiMoi.SODU -= et.SoTien;
                taiKhoanNhanMoi.SODU += et.SoTien;

                if (et.MaCK == "")
                {
                    return false;
                }

                if (ck != null)
                {
                    ck.MACK = et.MaCK;
                    ck.MAKH = et.MaKH;
                    ck.MATK = et.MaTK;
                    ck.NGAYCK = et.NgayCK;
                    ck.SOTIEN = et.SoTien;
                    ck.MATKGUI = et.MaTKGui;
                    ck.MATKNHAN = et.MaTKNhan;
                    ck.NOIDUNG = et.NoiDung;

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
        public bool TrangThaiAn(ET_ChuyenKhoan et)
        {
            bool ss = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var change = db.CHUYENKHOANs.Single(ck => ck.MACK == et.MaCK);
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
            int sl = (from ck in db.CHUYENKHOANs
                         select ck).Count(); // Đếm số lượng nhân viên

            int dem = sl + 1;
            string ma = "CK" + dem.ToString("D3");
            return ma;
        }
    }
}
