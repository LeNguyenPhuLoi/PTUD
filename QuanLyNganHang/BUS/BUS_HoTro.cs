using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_HoTro
    {
        DAL_HoTro DAL_HoTro = new DAL_HoTro();

        //hàm đếm số lượng hỗ trợ
        public int DemSoLuongHoTro()
        {
            return DAL_HoTro.DemSoLuongHoTro();
        }

        //hàm kiểm tra cccd nhân viên có tồn tại
        public bool KiemTraTonTaiCcccNV(string cccdnv)
        {
            return DAL_HoTro.KiemTraTonTaiCcccNV(cccdnv);
        }

        //hàm kiểm tra cccd khách hàng có tồn tại
        public bool KiemTraTonTaiCcccKH(string cccdkh)
        {
            return DAL_HoTro.KiemTraTonTaiCcccKH(cccdkh);
        }

        //hàm lấy mã nhân viên theo cccd
        public string LayManvTheoCccd(string cccd)
        {
            return DAL_HoTro.LayManvTheoCccd(cccd);
        }

        //hàm lấy danh sách nhân viên  theo số cccd
        public List<ET_NhanVien> LayDSNhanVienTheoCCCD(string cccd)
        {
            return DAL_HoTro.LayDSNhanVienTheoCCCD(cccd);
        }

        //hàm lấy cccd theo mã nhân viên
        public string LayCccdTheoMaNV(string manv)
        {
            return DAL_HoTro.LayCccdTheoMaNV(manv);
        }

        //hàm lấy danh sách khách hàng theo số cccd
        public List<ET_KhachHang> LayDSKhachHangTheoCCCD(string cccd)
        {
            return DAL_HoTro.LayDSKhachHangTheoCCCD(cccd);
        }

        //hàm lấy mã khách hàng theo cccd
        public string LayMaKHTheoCccd(string cccd)
        {
            return DAL_HoTro.LayMaKHTheoCccd(cccd);
        }

        //hàm lấy cccd theo mã khách hàng
        public string LayCccdTheoMaKH(string makh)
        {
            return DAL_HoTro.LayCccdTheoMaKH(makh);
        }

        //hàm lấy mã loại hỗ trợ theo tên loại hỗ trợ
        public string LayMaLoaiHTTheoTen(string tenloaiht)
        {
            return DAL_HoTro.LayMaLoaiHTTheoTen(tenloaiht);
        }

        //hàm lấy tên loại hỗ trợ theo mã loại hỗ trợ
        public string LayTenLoaiHTTheoMa(string maloaiht)
        {
            return DAL_HoTro.LayTenLoaiHTTheoMa(maloaiht);
        }

        //hàm lấy tên loại hỗ trợ
        public IQueryable<string> LayTenLoaiHT()
        {
            return DAL_HoTro.LayTenLoaiHT();
        }

        //hàm lấy danh sách nhân viên con hoạt động
        public List<ET_NhanVien> LayDSNhanVienConHoatDong()
        {
            return DAL_HoTro.LayDSNhanVienConHoatDong();
        }

        //hàm lấy danh sách khách hàng con hoạt động
        public List<ET_KhachHang> LayDSKhachHangConHoatDong()
        {
            return DAL_HoTro.LayDSKhachHangConHoatDong();
        }

        //hàm lấy danh sách hỗ trợ còn hoạt động
        public List<ET_HoTro> LayDSHoTroConHoatDong()
        {
            return DAL_HoTro.LayDSHoTroConHoatDong();
        }

        //hàm lấy danh sách toàn bộ hỗ trợ
        public List<ET_HoTro> LayDSToanBoHoTro()
        {
            return DAL_HoTro.LayDSToanBoHoTro();
        }

        //hàm thêm hỗ trợ
        public bool ThemHoTro(ET_HoTro et)
        {
            return DAL_HoTro.ThemHoTro(et);
        }

        //hàm ẩn hỗ trợ
        public bool AnHoTro(ET_HoTro et)
        {
            return DAL_HoTro.AnHoTro(et);
        }
    }
}
