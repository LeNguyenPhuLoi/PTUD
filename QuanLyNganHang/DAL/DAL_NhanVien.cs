using ET;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_NhanVien()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        public IQueryable LoadDSNhanVien()
        {
            IQueryable ds = from nv in db.NHANVIENs
                            join pb in db.PHONGBANs on nv.MAPB equals pb.MAPB
                            join cn in db.CHINHANHs on nv.MACN equals cn.MACN
                            select new
                            {
                                nv.MANV,
                                nv.TENNV,
                                nv.GIOITINH,
                                nv.NGAYSINH,
                                nv.CCCD,
                                nv.CHUC,
                                nv.LUONG,
                                nv.DIACHI,
                                nv.SDT,
                                pb.TENPB,
                                cn.TENCN
                            };
            return ds;
        }

        public bool ThemNhanVien(ET_NhanVien et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var exists = db.NHANVIENs.Any(nv => nv.MANV == et.MaNV);
                if(!exists)
                {
                    NHANVIEN nv = new NHANVIEN
                    {
                        MANV = et.MaNV,
                        TENNV = et.TenNV,
                        GIOITINH = et.GioiTinh,
                        NGAYSINH = et.NgaySinh,
                        CCCD = et.CCCD,
                        CHUC = et.Chuc,
                        LUONG = et.Luong,
                        DIACHI =et.DiaChi,
                        SDT = et.SDT,
                        MAPB = et.MaPB,
                        MACN = et.MaCN,
                        TRANGTHAI = et.TrangThai
                    };
                    db.NHANVIENs.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    flage = true;
                }
                else
                {
                    error = "Mã nhân viên đã tồn tại!!!";
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

        public bool CapNhatNhanVien(ET_NhanVien et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var nv = db.NHANVIENs.Single(x => x.MANV == et.MaNV);
                if (nv != null)
                {
                    nv.CCCD = et.CCCD;
                    nv.CHUC = et.Chuc;
                    nv.LUONG = et.Luong;
                    nv.DIACHI = et.DiaChi;
                    nv.SDT = et.SDT;
                    nv.MAPB = et.MaPB;
                    nv.MACN = et.MaCN;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã nhân viên không tồn tại!";
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

        // Xóa nhân viên
        public bool XoaNhanVien(ET_NhanVien et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var nv = db.NHANVIENs.Single(x => x.MANV == et.MaNV);
                if (nv != null)
                {
                    nv.TRANGTHAI = "Nghỉ Việc";
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã nhân viên không tồn tại!";
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
