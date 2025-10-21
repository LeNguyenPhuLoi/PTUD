using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan DAL_TaiKhoan = new DAL_TaiKhoan();

        //hàm kiểm tra mã tài khoản đã tồn tại
        public bool KiemTraTonTaiSoTK(string sotk)
        {
            return DAL_TaiKhoan.KiemTraTonTaiSoTK(sotk);
        }

        //hàm kiểm tra mã tài khoản đã tồn tại
        public bool KiemTraTonTaiMaTK(string matk)
        {
            return DAL_TaiKhoan.KiemTraTonTaiMaTK(matk);
        }

        //hàm lấy danh sách toàn bộ tài khoản
        public List<ET_TaiKhoan> LayDSToanBoTaiKhoan()
        {
            return DAL_TaiKhoan.LayDSToanBoTaiKhoan();
        }
        //hàm lấy danh sách tài khoản còn hoạt động
        public List<ET_TaiKhoan> LayDSTaiKhoanConHoatDong()
        {
            return DAL_TaiKhoan.LayDSTaiKhoanConHoatDong();
        }

        //hàm lấy chi tiết loại tài khoản
        public IQueryable<string> LayChiTietLoaiTK()
        {
            return DAL_TaiKhoan.LayChiTietLoaiTK();
        }

        //hàm lấy tên ngoại tệ
        public IQueryable<string> LayTenNgoaiTe()
        {
            return DAL_TaiKhoan.LayTenNgoaiTe();
        }

        // Hàm lấy mã loại tài khoản theo chi tiết
        public string LayMaLoaiTKTheoChiTiet(string chitiet)
        {
            return DAL_TaiKhoan.LayMaLoaiTKTheoChiTiet(chitiet);
        }

        // Hàm lấy mã ngoại tệ theo tên ngoại tệ
        public string LayMaNgoaiTeTheoTen(string tenngoaite)
        {
            return DAL_TaiKhoan.LayMaNgoaiTeTheoTen(tenngoaite);
        }

        // Hàm lấy mã khách hàng theo tên khách hàng
        public string LayMaKHTheoCccd(string cccd)
        {
            return DAL_TaiKhoan.LayMaKHTheoCccd(cccd);
        }

        //hàm lấy danh sách khách hàng con hoạt động
        public List<ET_KhachHang> LayDSKhachHangConHoatDong()
        {
            return DAL_TaiKhoan.LayDSKhachHangConHoatDong();
        }

        //hàm lấy danh sách khách hàng theo số cccd
        public List<ET_KhachHang> LayDSKhachHangTheoCCCD(string cccd)
        {
            return DAL_TaiKhoan.LayDSKhachHangTheoCCCD(cccd);
        }

        //hàm lấy số cccd theo mã khách hàng
        public string LayCccdTheoMaKH(string makh)
        {
            return DAL_TaiKhoan.LayCccdTheoMaKH(makh);
        }

        // Hàm lấy chi tiết theo mã loại tài khoản
        public string LayChiTietTheoMaLoaiTK(string maloaitk)
        {
            return DAL_TaiKhoan.LayChiTietTheoMaLoaiTK(maloaitk);
        }

        // Hàm lấy tên ngoại tệ theo mã ngoại tệ
        public string LayTenNgoaiTeTheoMa(string mangoaite)
        {
            return DAL_TaiKhoan.LayTenNgoaiTeTheoMa(mangoaite);
        }

        //hàm thêm tài khoản
        public bool ThemTaiKhoan(ET_TaiKhoan et)
        {
            return DAL_TaiKhoan.ThemTaiKhoan(et);
        }

        //hàm sửa tài khoản
        public bool SuaTaiKhoan(ET_TaiKhoan et)
        {
            return DAL_TaiKhoan.SuaTaiKhoan(et);
        }

        //hàm ẩn tài khoản
        public bool AnTaiKhoan(ET_TaiKhoan et)
        {
            return DAL_TaiKhoan.AnTaiKhoan(et);
        }

        //hàm xóa tài khoản
        public bool XoaTaiKhoan(ET_TaiKhoan et)
        {
            return DAL_TaiKhoan.XoaTaiKhoan(et);
        }
    }
}
