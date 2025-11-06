using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoanDangNhap
    {
        //kết nối tới database = linq to sql
        AutoConnect conn = new AutoConnect();
        QLNHDataContext db;

        public DAL_TaiKhoanDangNhap()
        {
            db = new QLNHDataContext(conn.GetConnection());
        }

        //Lấy danh sách nhân viên
        public IQueryable LoadNhanVien()
        {
            IQueryable nhanvien = from nv in db.NHANVIENs
                                  where nv.TRANGTHAI == "Hoạt Động"
                                  select new
                                  {
                                      nv.MANV,
                                      nv.TENNV,
                                      nv.GIOITINH,
                                      nv.NGAYSINH,
                                      nv.CHUC
                                  };
            return nhanvien;
        }

        // Lấy danh sách tài khoản đăng nhập
        public IQueryable LayDSTaiKhoanDangNhap()
        {
            IQueryable ds = from tk in db.DANGNHAPs
                            where tk.TrangThai == true
                            select new
                            {
                                tk.MADN,
                                tk.PASS,
                                tk.QUYEN,
                                tk.MANV
                            };
            return ds;
        }

        //Thêm Tai Khoản Đăng Nhập
        public bool ThemTaiKhoanDN(ET_TaiKhhoanDangNhap et, out string error)
        {
            bool flage = false;
            error = string.Empty;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaDN == "")
                {
                    error = "Mã Đăng Nhập không được để trống!";
                    return false;
                }
                else if (et.MaNV == "")
                {
                    error = "Mã Nhân viên không được để trống!";
                    return false;
                }
                else if (et.Pass == "")
                {
                    error = "Mật khẩu không được để trống!";
                    return false;
                }
                var nv = db.DANGNHAPs.Any(tk => tk.MANV == et.MaNV);
                if (nv)
                {
                    error = "Nhân Viên đã có tài khoản!";
                    return false;
                }
                var amp = db.DANGNHAPs.Any(tk => tk.MADN == et.MaDN );
                if (!amp)
                {
                    DANGNHAP tk = new DANGNHAP
                    {
                        MADN = et.MaDN,
                        PASS = et.Pass,
                        QUYEN = et.Quyen,
                        MANV = et.MaNV,
                        TrangThai = et.TrangThai,
                    };
                    db.DANGNHAPs.InsertOnSubmit(tk);
                    db.SubmitChanges();
                    flage = true;
                }
                else
                {
                    error = "Mã Đăng Nhập Đã Tồn Tại!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                flage = false;
                Console.WriteLine("Lỗi" + ex.ToString());
            }
            return flage;
        }

        //Sửa tài khoản đăng nhập
        public bool CapNhapTKDN(ET_TaiKhhoanDangNhap et, out string error)
        {
            bool flag = false;
            error = string.Empty;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                if (et.MaDN == "")
                {
                    error = "Mã Đăng Nhập không được để trống!";
                    return false;
                }
                else if (et.MaNV == "")
                {
                    error = "Mã Nhân viên không được để trống!";
                    return false;
                }
                else if (et.Pass == "")
                {
                    error = "Mật khẩu không được để trống!";
                    return false;
                }
                var nv = db.DANGNHAPs.Any(tk => tk.MANV == et.MaNV);
                if (nv)
                {
                    error = "Nhân Viên đã có tài khoản!";
                    return false;
                }

                var capnhat = db.DANGNHAPs.Single(n => n.MADN == et.MaDN);
                if (capnhat != null)
                {
                    capnhat.PASS = et.Pass;
                    capnhat.QUYEN = et.Quyen;
                    flag = true;
                    db.SubmitChanges();
                }
                else
                {
                    error = "Mã Đăng không Tồn Tại!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            finally
            {

            }
            return flag;
        }

        //xóa tai khoản đăng nhập
        public bool XoaTKDN(ET_TaiKhhoanDangNhap et, out string error)
        {
            error = string.Empty;
            bool flag = false;
            db = new QLNHDataContext(conn.GetConnection());
            try
            {
                var lg = db.DANGNHAPs.Single(x => x.MANV == et.MaNV);
                if (lg != null)
                {
                    lg.TrangThai = et.TrangThai;
                    db.SubmitChanges();
                    flag = true;
                }
                else
                {
                    error = "Mã Tài Khoản không tồn tại!";
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

        public bool KiemTraDinhDangMatKhau(string matKhau)
        {
            if (string.IsNullOrWhiteSpace(matKhau))
                return false;

            // Mật khẩu phải có ít nhất: 1 chữ cái, 1 số, 1 ký tự đặc biệt, dài từ 6-20
            string pattern = @"^(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=!]).{6,20}$";

            return Regex.IsMatch(matKhau, pattern);
        }
    }
}
