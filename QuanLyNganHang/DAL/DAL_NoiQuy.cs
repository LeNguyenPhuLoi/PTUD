using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NoiQuy
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_NoiQuy()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public IQueryable LoadNoiQuy()
        {
            IQueryable list = from nq in db.NOIQUYs
                              where nq.TrangThai == true
                              select new
                              {
                                  nq.MANQ,
                                  nq.TIEUDE,
                                  nq.MOTA,
                                  nq.NGAYBH,
                                  nq.LOAIAPDUNG
                              };
            return list;
        }

        //Thêm 1 Nội quy vào database
        public bool ThemNoiQuy(ET_NoiQuy et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.TIEUDE == "")
                {
                    error = "Tiêu đề không được để trống!";
                    return false;
                }
                else if(et.LOAIAPDUNG == ""){
                    error = "Loaị áp dụng không được để trống!";
                    return false;
                }

                // Kiểm tra trùng tiêu đề (không phân biệt hoa/thường)
                if (db.NOIQUYs.Any(nq => nq.TIEUDE.ToLower().Trim() == et.TIEUDE.ToLower().Trim()))
                {
                    error = "Tiêu đề nội quy đã tồn tại!";
                    return false;
                }

                var amp = db.NOIQUYs.Any(nq => nq.MANQ == et.MANQ);
                if (!amp)
                {
                    NOIQUY nq = new NOIQUY
                    {
                        MANQ = et.MANQ,
                        TIEUDE = et.TIEUDE,
                        MOTA = et.MOTA,
                        NGAYBH = et.NGAYBH,
                        LOAIAPDUNG = et.LOAIAPDUNG,
                        TrangThai = et.TRANGTHAI
                    };
                    db.NOIQUYs.InsertOnSubmit(nq);
                    db.SubmitChanges();
                    flage = true;
                }
                else
                {
                    error = "Mã Nội quy đã tồn tại!!!";
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

        public bool CapNhatNoiQuy(ET_NoiQuy et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.TIEUDE == "")
                {
                    error = "Tiêu đề không được để trống!";
                    return false;
                }
                else if (et.LOAIAPDUNG == "")
                {
                    error = "Loaị áp dụng không được để trống!";
                    return false;
                }

                // Kiểm tra trùng tiêu đề (không phân biệt hoa/thường)
                if (db.NOIQUYs.Any(x => x.TIEUDE.ToLower().Trim() == et.TIEUDE.ToLower().Trim()
                                          && x.MANQ != et.MANQ))
                {
                    error = "Tiêu đề đã tồn tại!";
                    return false;
                }

                var pb = db.NOIQUYs.Single(x => x.MANQ == et.MANQ);
                if (pb != null)
                {
                    pb.TIEUDE = et.TIEUDE;
                    pb.MOTA = et.MOTA;
                    pb.NGAYBH = et.NGAYBH;
                    pb.LOAIAPDUNG = et.LOAIAPDUNG;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã Nội Quy không tồn tại!";
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

        public bool XoaNoiQuy(ET_NoiQuy et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                //Kiểm tra trùng mã
                var pb = db.NOIQUYs.SingleOrDefault(p => p.MANQ == et.MANQ);
                if (pb != null)
                {
                    // Thay vì xóa, ta đánh dấu đã xóa
                    pb.TrangThai = false;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã nội quy không tồn tại!";
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

        //Thiết kế mã tự động cho Nội quy
        public string MaTuDong()
        {
            int query = (from nq in db.NOIQUYs
                         select nq).Count(); // Đếm số lượng nội quy

            int dem = query + 1;
            string ma = "NQ" + dem.ToString("D3");
            return ma;
        }

        // Hàm kiểm tra định dạng loại áp dụng (VD: "Phạt 50.000đ/lần")
        public bool KiemTraDinhDangLoaiApDung(string loaiApDung)
        {
            if (string.IsNullOrWhiteSpace(loaiApDung))
                return false;

            // Mẫu: "Phạt 50.000đ/lần" hoặc "Phạt 100000 VNĐ"
            string pattern = @"^Phạt\s\d{1,3}(?:\.\d{3})*(?:\s?(?:đ|VNĐ))(?:/lần)?$";

            loaiApDung = loaiApDung.Trim();

            // Kiểm tra khớp với regex và độ dài không quá 100 ký tự
            return Regex.IsMatch(loaiApDung, pattern, RegexOptions.IgnoreCase)
                   && loaiApDung.Length <= 100;
        }

    }
}
