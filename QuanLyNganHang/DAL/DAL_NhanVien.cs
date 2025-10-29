using ET;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //Kiểm tra định dạng số
        public bool KiemTraDinhDangSo(string luong)
        {
            bool flag = false;
            string pattern = @"^\d+$";
            if (string.IsNullOrWhiteSpace(luong))
                return flag;
            if (Regex.IsMatch(luong.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mã Nhân viên (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        public bool KiemTraDinhDangMaNV(string manv)
        {
            bool flag = false;
            string pattern = @"^NV\d{3,8}$";
            if (string.IsNullOrWhiteSpace(manv))// kiểm tra trống hoặc toàn khoảng trắng
                return flag;
            if (Regex.IsMatch(manv, pattern))//kiểm tra chuỗi theo mẫu
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng tên khách hàng (70 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangTen(string tenkh)
        {
            bool flag = false;
            string pattern = @"^(?!.*\s{2})[a-zA-ZÀ-ỹ]{2,}(?:\s[a-zA-ZÀ-ỹ]+){0,9}$";
            if (string.IsNullOrWhiteSpace(tenkh))
                return flag;
            if (Regex.IsMatch(tenkh.Trim(), pattern) && tenkh.Trim().Length <= 70)
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số CCCD/CMND (chuỗi 12 chữ số, không chữ, không ký tự đặc biệt)
        public bool KiemTraDinhDangCCCD(string cccd)
        {
            bool flag = false;
            string pattern = @"^\d{12}$";
            if (string.IsNullOrWhiteSpace(cccd))
                return flag;
            if (Regex.IsMatch(cccd.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số điện thoại (chuỗi 10 chữ số, không chữ, không ký tự đặc biệt)
        public bool KiemTraDinhDangSDT(string sdt)
        {
            bool flag = false;
            string pattern = @"^\d{10}$";
            if (string.IsNullOrWhiteSpace(sdt))
                return flag;
            if (Regex.IsMatch(sdt.Trim(), pattern))
                flag = true;
            return flag;
        }
        //hàm kiểm tra định dạng địa chỉ (chuỗi 100 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangDiaChi(string diachi)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,100}$";
            if (string.IsNullOrWhiteSpace(diachi))
                return flag;
            if (Regex.IsMatch(diachi.Trim(), pattern))
                flag = true;
            return flag;
        }

        
    }
}
