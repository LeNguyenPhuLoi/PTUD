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

        //Load danh sách nhân viên từ database
        public IQueryable LoadDSNhanVien()
        {
            IQueryable ds = from nv in db.NHANVIENs
                            join pb in db.PHONGBANs on nv.MAPB equals pb.MAPB
                            join cn in db.CHINHANHs on nv.MACN equals cn.MACN
                            where nv.TRANGTHAI == "Hoạt Động"
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

        public IQueryable LoadDSTenPB()
        {
            IQueryable ds = from pb in db.PHONGBANs
                            select pb.TENPB;
            return ds;
        }

        public IQueryable LoadDSTenCN()
        {
            IQueryable ds = from cn in db.CHINHANHs
                            select cn.TENCN;
            return ds;
        }

        //Lấy tên phòng ban theo mã
        public string LayTenPhongBan(int ma)
        {
            var ten = (from pb in db.PHONGBANs
                      where pb.MAPB == ma
                      select pb.TENPB).FirstOrDefault();
            return ten;
        }

        //Lấy tên chi nhánh theo mã
        public string LayTenChiNhanh(string ma)
        {
            var ten = (from cn in db.CHINHANHs
                      where cn.MACN == ma
                      select cn.TENCN).FirstOrDefault();
            return ten;
        }

        public int LayMaTheoTenPB(string ten)
        {
            var ma = (from pb in db.PHONGBANs
                      where pb.TENPB == ten
                      select pb.MAPB).FirstOrDefault();
            return ma;
        }

        public string LayMaChiNhanh(string ten)
        {
            var ma = (from cn in db.CHINHANHs
                      where cn.TENCN == ten
                      select cn.MACN).FirstOrDefault();
            return ma;
        }

        //Thêm 1 nhân viên vào database
        public bool ThemNhanVien(ET_NhanVien et, out string error)
        {
            error = string.Empty;
            bool flage = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if(et.MaNV == "")
                {
                    error = "Mã nhân viên không được để trống!";
                    return false;
                }
                else if (et.TenNV == "")
                {
                    error = "Tên nhân viên không được để trống!";
                    return false;
                }
                else if (et.CCCD == "")
                {
                    error = "CCCD/CMND không được để trống!";
                    return false;
                }
                else if (et.SDT == "")
                {
                    error = "Số điện thoại không được để trống!";
                    return false;
                }
               
               
                // Kiểm tra trùng CCCD
                if (db.NHANVIENs.Any(x => x.CCCD == et.CCCD))
                {
                    error = "CCCD/CMND đã tồn tại!";
                    return false;
                }

                // Kiểm tra trùng số điện thoại
                if (db.NHANVIENs.Any(x => x.SDT == et.SDT))
                {
                    error = "Số điện thoại đã tồn tại!";
                    return false;
                }

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
                if (et.TenNV == "")
                {
                    error = "Tên nhân viên không được để trống!";
                    return false;
                }
                else if (et.CCCD == "")
                {
                    error = "CCCD/CMND không được để trống!";
                    return false;
                }
                else if (et.SDT == "")
                {
                    error = "Số điện thoại không được để trống!";
                    return false;
                }


                // Kiểm tra trùng CCCD (bỏ qua chính nhân viên đang cập nhật)
                if (db.NHANVIENs.Any(x => x.CCCD == et.CCCD && x.MANV != et.MaNV))
                {
                    error = "CCCD/CMND đã tồn tại!";
                    return false;
                }

                // Kiểm tra trùng số điện thoại (bỏ qua chính nhân viên đang cập nhật)
                if (db.NHANVIENs.Any(x => x.SDT == et.SDT && x.MANV != et.MaNV))
                {
                    error = "Số điện thoại đã tồn tại!";
                    return false;
                }

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
                    nv.TRANGTHAI = et.TrangThai;
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
