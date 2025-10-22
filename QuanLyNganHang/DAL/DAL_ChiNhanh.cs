using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiNhanh
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_ChiNhanh()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Load danh sách chi nhánh từ database
        public IQueryable LoadDSChiNhanh()
        {
            IQueryable ds = from cn in db.CHINHANHs
                            select cn;
            return ds;
        }

        //Thêm 1 Chi nhánh vào database
        public bool ThemChiNhanh(ET_ChiNhanh et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.TenCN == "")
                {
                    error = "Tên Chi Nhánh không được để trống!";
                    return false;
                }else if(et.SDTCN == ""){
                    error = "Số điện thoại không được để trống!";
                    return false;
                }
                //Kiểm tra trùng tên chi nhánh (không phân biệt hoa/thường)
                if (db.CHINHANHs.Any(cn => cn.TENCN.ToLower().Trim() == et.TenCN.ToLower().Trim()))
                {
                    error = "Tên chi nhánh đã tồn tại!";
                    return false;
                }

                //Kiểm tra trùng số điện thoại chi nhánh
                if (db.CHINHANHs.Any(cn => cn.SDTCN.Trim() == et.SDTCN.Trim()))
                {
                    error = "Số điện thoại chi nhánh đã tồn tại!";
                    return false;
                }

                var exists = db.CHINHANHs.Any(cn => cn.MACN == et.MaCN);
                if (!exists)
                {
                    CHINHANH cn = new CHINHANH
                    {
                        MACN = et.MaCN,
                        TENCN = et.TenCN,
                        DIACHICN= et.DiaChiCN,
                        SDTCN = et.SDTCN
                    };
                    db.CHINHANHs.InsertOnSubmit(cn);
                    db.SubmitChanges();
                    flage = true;
                }
                else
                {
                    error = "Mã chi nhánh đã tồn tại!!!";
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

        public bool CapNhatChiNhanh(ET_ChiNhanh et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.TenCN == "")
                {
                    error = "Tên Chi Nhánh không được để trống!";
                    return false;
                }
                else if (et.SDTCN == "")
                {
                    error = "Số điện thoại không được để trống!";
                    return false;
                }
                //Kiểm tra trùng tên chi nhánh (không phân biệt hoa/thường, bỏ qua chi nhánh hiện tại
                if (db.CHINHANHs.Any(x => x.TENCN.ToLower().Trim() == et.TenCN.ToLower().Trim()
                                          && x.MACN != et.MaCN))
                {
                    error = "Tên chi nhánh đã tồn tại!";
                    return false;
                }

                //Kiểm tra trùng số điện thoại chi nhánh, bỏ qua chi nhánh hiện tại
                if (db.CHINHANHs.Any(x => x.SDTCN.Trim() == et.SDTCN.Trim()
                                          && x.MACN != et.MaCN))
                {
                    error = "Số điện thoại chi nhánh đã tồn tại!";
                    return false;
                }

                var cn = db.CHINHANHs.Single(x => x.MACN == et.MaCN);
                if (cn != null)
                {
                    cn.TENCN = et.TenCN;
                    cn.SDTCN = et.SDTCN;
                    cn.DIACHICN = et.DiaChiCN;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã chi nhánh không tồn tại!";
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

        public bool XoaChiNhanh(ET_ChiNhanh et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                //Kiểm tra trùng mã
                var cn = db.CHINHANHs.SingleOrDefault(p => p.MACN == et.MaCN);
                if (cn == null)
                {
                    error = "Mã chi nhánh không tồn tại!";
                    return false;
                }

                //Kiểm tra xem có nhân viên nào thuộc phòng ban này không
                bool coNhanVien = db.NHANVIENs.Any(nv => nv.MACN == et.MaCN);
                if (coNhanVien)
                {
                    error = "Không thể xóa chi nhánh vì vẫn còn nhân viên trực thuộc!";
                    return false;
                }

                db.CHINHANHs.DeleteOnSubmit(cn);
                db.SubmitChanges();
                flag = true;
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
