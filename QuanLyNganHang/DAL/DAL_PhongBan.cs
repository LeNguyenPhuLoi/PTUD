using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhongBan
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_PhongBan()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách phòng ban từ database
        public IQueryable LoadDSPhongBan()
        {
            IQueryable ds = from pb in db.PHONGBANs 
                            select pb;
            return ds;
        }

        //Thêm 1 phòng ban vào database
        public bool ThemPhongBan(ET_PhongBan et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if(et.TenPB == "")
                {
                    error = "Tên Phòng Ban không được để trống!";
                    return false;
                }

                // Kiểm tra trùng tên phòng ban (không phân biệt hoa/thường)
                if (db.PHONGBANs.Any(pb => pb.TENPB.ToLower().Trim() == et.TenPB.ToLower().Trim()))
                {
                    error = "Tên phòng ban đã tồn tại!";
                    return false;
                }

                var amp = db.PHONGBANs.Any(pb => pb.MAPB == et.MaPB);
                if (!amp)
                {
                    PHONGBAN pb = new PHONGBAN
                    {
                        MAPB = et.MaPB,
                        TENPB = et.TenPB
                    };
                    db.PHONGBANs.InsertOnSubmit(pb);
                    db.SubmitChanges();
                    flage = true;
                }
                else
                {
                    error = "Mã phòng ban đã tồn tại!!!";
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

        public bool CapNhatPhongBan(ET_PhongBan et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.TenPB == "")
                {
                    error = "Tên Phòng Ban không được để trống!";
                    return false;
                }

                // Kiểm tra trùng tên phòng ban (không phân biệt hoa/thường)
                if (db.PHONGBANs.Any(x => x.TENPB.ToLower().Trim() == et.TenPB.ToLower().Trim()
                                          && x.MAPB != et.MaPB))
                {
                    error = "Tên phòng ban đã tồn tại!";
                    return false;
                }

                var pb = db.PHONGBANs.Single(x => x.MAPB == et.MaPB);
                if (pb != null)
                {
                    pb.TENPB = et.TenPB;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã phòng ban không tồn tại!";
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

        public bool XoaPB(ET_PhongBan et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                // Kiểm tra xem có nhân viên nào thuộc phòng ban này không
                bool coNhanVien = db.NHANVIENs.Any(nv => nv.MAPB == et.MaPB);
                if (coNhanVien)
                {
                    error = "Không thể xóa phòng ban vì vẫn còn nhân viên trực thuộc!";
                    return false;
                }

                //Kiểm tra trùng mã
                var pb = db.PHONGBANs.SingleOrDefault(p => p.MAPB == et.MaPB);
                if (pb != null)
                {
                    db.PHONGBANs.DeleteOnSubmit(pb);
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã phòng ban không tồn tại!";
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
    }
}
