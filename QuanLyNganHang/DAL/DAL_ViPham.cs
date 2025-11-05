using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
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
                              where vp.TrangThai == true//điều kiện hiện thị
                              select vp;
            return list;
        }
        //thêm 1 vi phạm vào database
        public bool ThemViPham(ET_ViPham et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                //if (et.TIEUDE == "")
                //{
                //    error = " không được để trống!";
                //    return false;
                //}

                //// Kiểm tra trùng tiêu đề (không phân biệt hoa/thường)
                //if (db.VIPHAMs.Any(vp => vp.MAVP.ToLower().Trim() == et.TIEUDE.ToLower().Trim()))
                //{
                //    error = "Tiêu đề nội quy đã tồn tại!";
                //    return false;
                //}

                var amp = db.VIPHAMs.Any(vp => vp.MAVP == et.MAVP);
                if (!amp)
                {
                    //NOIQUY nq = new NOIQUY
                    //{
                    //    MANQ = et.MANQ,
                    //    TIEUDE = et.TIEUDE,
                    //    MOTA = et.MOTA,
                    //    NGAYBH = et.NGAYBH,
                    //    LOAIAPDUNG = et.LOAIAPDUNG,
                    //    TrangThai = et.TRANGTHAI
                    //};
                    //db.NOIQUYs.InsertOnSubmit(nq);
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
    }
}
