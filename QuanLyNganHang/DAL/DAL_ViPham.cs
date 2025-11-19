using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ViPhamRP
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ViPhamRP()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public List<ET_ViPhamRP> LayDSViPhamTheoNV(string manv, int thang,int nam)
        {
            var query = from pl in db.VIPHAMs
                        join nv in db.NHANVIENs on pl.MANV equals nv.MANV
                        join nq in db.NOIQUYs on pl.MANQ equals nq.MANQ
                        where pl.MANV == manv
                           && pl.NGAYVP.Value.Month == thang
                           && pl.NGAYVP.Value.Year == nam
                        select new ET_ViPhamRP
                        {
                            MAVP = pl.MAVP,
                            MANV = pl.MANV,
                            TENNV = nv.TENNV,
                            LOIVIPHAM = nq.TIEUDE,
                            NGAYVP = Convert.ToDateTime(pl.NGAYVP),
                            HINHTHUCXL = (decimal)(pl.HINHTHUCXL ?? 0),
                            TRANGTHAIXL = pl.TRANGTHAIXL
                        };

            return query.ToList();
        }
    }
        public class DAL_ViPham
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ViPham()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách vi phạm từ database
        public IQueryable LoadViPham()
        {
            IQueryable list = from vp in db.VIPHAMs
                              join nq in db.NOIQUYs on vp.MANQ equals nq.MANQ
                              join nv in db.NHANVIENs on vp.MANV equals nv.MANV
                              where vp.TrangThai == true//điều kiện hiện thị
                              select new
                              {
                                  vp.MAVP,
                                  nq.TIEUDE,
                                  nv.TENNV,
                                  vp.NGAYVP,
                                  vp.MOTAVP,
                                  vp.HINHTHUCXL,
                                  vp.TRANGTHAIXL
                              };
            return list;
        }

        //Lấy Vi Pham Theo Ma
        public decimal? LoadHTXL(string ma)
        {
            var list = (from nq in db.NOIQUYs
                           where nq.TrangThai == true && nq.MANQ == ma
                           select nq.LOAIAPDUNG).FirstOrDefault();
            return list;
        }

        //lấy danh sách nhân viên để thêm vào combobox
        public IQueryable<string> LoadNhanVien()
        {
            IQueryable<string> list = from nv in db.NHANVIENs
                                      where nv.TRANGTHAI == "Hoạt Động"
                                      select nv.MANV + "- " + nv.TENNV;
            return list;
        }

        //Lấy danh sách nội quy để thêm vào combobox
        public IQueryable<string> LoadNoiQuy()
        {
            IQueryable<string> list = from nq in db.NOIQUYs
                                      where nq.TrangThai == true
                                      select nq.MANQ + "- " + nq.TIEUDE;
            return list;
        }

        //Lấy tên + mã theo mã NQ
        public string MaTenNQ(string ma)
        {
            string text = (from nq in db.NOIQUYs
                           where nq.TIEUDE == ma
                           select nq.MANQ + "- " + nq.TIEUDE).FirstOrDefault();
            return text;
        }


        //Lấy tên + mã theo mã NV
        public string MaTenNV(string ma)
        {
            string text = (from nv in db.NHANVIENs
                           where nv.TENNV == ma
                           select nv.MANV + "- " + nv.TENNV).FirstOrDefault();
            return text;
        }

        //Hàm lấy mã
        public string GetMa(string s)
        {
            string[] arr = s.Split('-');
            return arr[0];
        }

        //Thêm 1 vi phạm vào database
        public bool ThemViPham(ET_ViPham et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MANQ == "")
                {
                    error = "Mã Nội Quy không được để trống!";
                    return false;
                }else if(et.MANV == "")
                {
                    error = "Mã Nội Quy không được để trống!";
                    return false;
                }
                    var amp = db.VIPHAMs.Any(vp => vp.MAVP == et.MAVP);
                if (!amp)
                {
                    VIPHAM vp = new VIPHAM
                    {
                        MAVP = et.MAVP,
                        MANQ = et.MANQ,
                        MANV = et.MANV,
                        NGAYVP = et.NGAYVP,
                        MOTAVP = et.MOTAVP,
                        HINHTHUCXL = et.HINHTHUCXL,
                        TRANGTHAIXL = et.TRANGTHAIXL,
                        TrangThai = et.TRANGTHAI
                    };
                    db.VIPHAMs.InsertOnSubmit(vp);
                    db.SubmitChanges();
                    flage = true;
                }
                else
                {
                    error = "Mã vi phạm đã tồn tại!!!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                flage = false;
            }
            return flage;
        }

        public bool CapNhatViPham(ET_ViPham et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MANQ == "")
                {
                    error = "Mã Nội Quy không được để trống!";
                    return false;
                }
                else if (et.MANV == "")
                {
                    error = "Mã Nội Quy không được để trống!";
                    return false;
                }

                var vp = db.VIPHAMs.Single(x => x.MAVP == et.MAVP);
                if (vp != null)
                {
                    vp.MANQ = et.MANQ;
                    vp.MANV = et.MANV;
                    vp.HINHTHUCXL = et.HINHTHUCXL;
                    vp.TRANGTHAIXL = et.TRANGTHAIXL;
                    vp.MOTAVP = et.MOTAVP;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã vi phạm không tồn tại!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                error = "Lỗi: " + ex.ToString();
            }
            return flag;
        }

        public bool XoaViPham(ET_ViPham et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                //Kiểm tra trùng mã
                var vp = db.VIPHAMs.SingleOrDefault(p => p.MAVP == et.MAVP);
                if (vp != null)
                {
                    // Thay vì xóa, ta đánh dấu đã xóa
                    vp.TrangThai = et.TRANGTHAI;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã vi phạm không tồn tại!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                error = "Lỗi: " + ex.ToString();
            }
            return flag;
        }

        //Thiết kế mã tự động cho Vi phạm
        public string MaTuDong()
        {
            int query = (from vp in db.VIPHAMs
                         select vp).Count(); // Đếm số lượng vi phạm

            int dem = query + 1;
            string ma = "VP" + dem.ToString("D3");
            return ma;
        }

        public bool KiemTraDinhDangMaNV(string manv)
        {
            if (string.IsNullOrWhiteSpace(manv))
                return false;

            // Mẫu: NV + 4–8 chữ số + " - " + Tên (chỉ chữ, có thể có dấu và khoảng trắng)
            string pattern = @"^NV\d{4,8}\s*-\s*[A-Za-zÀ-ỹ\s]+$";

            return Regex.IsMatch(manv, pattern);
        }

        public bool KiemTraDinhDangMaNQ(string manv)
        {
            if (string.IsNullOrWhiteSpace(manv))
                return false;

            // Mẫu: NQ + 3 đến 8 số + " - " + tiêu đề (chữ hoặc số, có thể có dấu tiếng Việt)
            string pattern = @"^NQ\d{3,8}\s*-\s*[\p{L}\p{M}\d\s]+$";

            return Regex.IsMatch(manv, pattern);
        }
    }
}
