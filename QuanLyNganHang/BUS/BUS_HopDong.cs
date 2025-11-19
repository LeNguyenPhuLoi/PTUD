using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_HopDong
    {
        DAL_HopDong DAL_HopDong = new DAL_HopDong();

        //hàm lấy tên nhan viên theo mã
        public string LayTenNVTheoMa(string manv)
        {
            return DAL_HopDong.LayTenNVTheoMa(manv);
        }

        //hàm kiểm tra cccd nhân viên có tồn tại
        public bool KiemTraTonTaiCcccNV(string cccdnv)
        {
            return DAL_HopDong.KiemTraTonTaiCcccNV(cccdnv);
        }

        //hàm kiểm tra cccd khách hàng có tồn tại
        public bool KiemTraTonTaiCcccKH(string cccdkh)
        {
            return DAL_HopDong.KiemTraTonTaiCcccKH(cccdkh);
        }

        //hàm lấy mã nhân viên theo cccd
        public string LayManvTheoCccd(string cccd)
        {
            return DAL_HopDong.LayManvTheoCccd(cccd);
        }

        //hàm lấy danh sách nhân viên  theo số cccd
        public List<ET_NhanVien> LayDSNhanVienTheoCCCD(string cccd)
        {
            return DAL_HopDong.LayDSNhanVienTheoCCCD(cccd);
        }

        //hàm lấy cccd theo mã nhân viên
        public string LayCccdTheoMaNV(string manv)
        {
            return DAL_HopDong.LayCccdTheoMaNV(manv);
        }

        //hàm lấy danh sách khách hàng theo số cccd
        public List<ET_KhachHang> LayDSKhachHangTheoCCCD(string cccd)
        {
            return DAL_HopDong.LayDSKhachHangTheoCCCD(cccd);
        }

        //hàm lấy mã khách hàng theo cccd
        public string LayMaKHTheoCccd(string cccd)
        {
            return DAL_HopDong.LayMaKHTheoCccd(cccd);
        }

        //hàm lấy cccd theo mã khách hàng
        public string LayCccdTheoMaKH(string makh)
        {
            return DAL_HopDong.LayCccdTheoMaKH(makh);
        }

        //hàm lấy mã loại hợp đồng theo tên loại hợp đồng 
        public string LayMaLoaiHDTheoTen(string tenloaihd)
        {
            return DAL_HopDong.LayMaLoaiHDTheoTen(tenloaihd);
        }

        //hàm lấy tên loại hợp đồng theo mã loại hợp đồng 
        public string LayTenLoaiHDTheoMa(string maloaihd)
        {
            return DAL_HopDong.LayTenLoaiHDTheoMa(maloaihd);
        }

        //hàm lấy tên loại hợp đồng
        public IQueryable<string> LayTenLoaiHD()
        {
            return DAL_HopDong.LayTenLoaiHD();
        }

        //hàm lấy danh sách nhân viên con hoạt động
        public List<ET_NhanVien> LayDSNhanVienConHoatDong()
        {
            return DAL_HopDong.LayDSNhanVienConHoatDong();
        }

        //hàm lấy danh sách khách hàng con hoạt động
        public List<ET_KhachHang> LayDSKhachHangConHoatDong()
        {
            return DAL_HopDong.LayDSKhachHangConHoatDong();
        }

        //hàm lấy danh sách hợp đồng còn hoạt động
        public List<ET_HopDong> LayDSHopDongConHoatDong()
        {
            return DAL_HopDong.LayDSHopDongConHoatDong();
        }

        //hàm lấy danh sách toàn bộ hợp đồng
        public List<ET_HopDong> LayDSToanBoHopDong()
        {
            return DAL_HopDong.LayDSToanBoHopDong();
        }

        //hàm thêm hợp đồng
        public bool ThemHopDong(ET_HopDong et)
        {
            return DAL_HopDong.ThemHopDong(et);
        }

        //hàm sửa hợp đồng
        public bool SuaHopDong(ET_HopDong et)
        {
            return DAL_HopDong.SuaHopDong(et);
        }

        //hàm ẩn hợp đồng
        public bool AnHopDong(ET_HopDong et)
        {
            return DAL_HopDong.AnHopDong(et);
        }
    }

    public class BUS_HopDong_Report
    {
        DAL_HopDong_Report DAL_HopDong_Report = new DAL_HopDong_Report();

        //hàm lấy hợp đồng theo số hợp đồng
        public List<ET_HopDong_Report> LayHopDongTheoSoHD(string sohd)
        {
            return DAL_HopDong_Report.LayHopDongTheoSoHD(sohd);
        }
    }
}
