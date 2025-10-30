using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiTaiKhoan
    {
        DAL_LoaiTaiKhoan DAL_LoaiTaiKhoan = new DAL_LoaiTaiKhoan();

        public int DemSoLuongLoaiTaiKhoan()
        {
            return DAL_LoaiTaiKhoan.DemSoLuongLoaiTaiKhoan();
        }

        //hàm kiểm tra chi tiết đã tồn tại
        public bool KiemTraTonTaiChiTiet(string chitiet)
        {
            return DAL_LoaiTaiKhoan.KiemTraTonTaiChiTiet(chitiet);
        }

        //hàm kiểm tra mã loại tài khoản đã tồn tại
        public bool KiemTraTonTaiMaLoaiTK(string maloaitk)
        {
            return DAL_LoaiTaiKhoan.KiemTraTonTaiMaLoaiTK(maloaitk);
        }

        //hàm lấy danh sách loại tài khoản còn hoạt động
        public List<ET_LoaiTaiKhoan> LayDSLoaiTaiKhoanConHoatDong()
        {
            return DAL_LoaiTaiKhoan.LayDSLoaiTaiKhoanConHoatDong();
        }

        //hàm lấy toàn bộ danh sách loại tài khoản
        public List<ET_LoaiTaiKhoan> LayDSToanBoLoaiTaiKhoan()
        {
            return DAL_LoaiTaiKhoan.LayDSToanBoLoaiTaiKhoan();
        }

        //hàm thêm loại tài khoản
        public bool ThemLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            return DAL_LoaiTaiKhoan.ThemLoaiTaiKhoan(et);
        }

        //hàm sửa loại tài khoản
        public bool SuaLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            return DAL_LoaiTaiKhoan.SuaLoaiTaiKhoan(et);
        }

        //hàm ẩn loại tài khoản
        public bool AnLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            return DAL_LoaiTaiKhoan.AnLoaiTaiKhoan(et);
        }

        //hàm xóa loại tài khoản
        public bool XoaLoaiTaiKhoan(ET_LoaiTaiKhoan et)
        {
            return DAL_LoaiTaiKhoan.XoaLoaiTaiKhoan(et);
        }
    }
}
