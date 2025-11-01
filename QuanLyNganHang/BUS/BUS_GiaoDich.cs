using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_GiaoDich
    {
        DAL_GiaoDich DAL_GiaoDich = new DAL_GiaoDich();

        //hàm trừ tiền
        public bool TruTien(string stk, decimal tientru)
        {
            return DAL_GiaoDich.TruTien(stk, tientru);
        }

        //hàm so sánh tiền 
        public bool SoSanhTien(string stk, decimal tiencan)
        {
            return DAL_GiaoDich.SoSanhTien(stk, tiencan);
        }

        // Hàm lấy tên loại giao dịch theo mã loại giao dịch
        public string LayTenLoaiGDTheoMaGD(string maloaigd)
        {
            return DAL_GiaoDich.LayTenLoaiGDTheoMaGD(maloaigd);
        }

        // Hàm lấy mã loại giao dịch theo tên loại giao dịch
        public string LayMaGDTheoTenLoaiGD(string tenloaigd)
        {
            return DAL_GiaoDich.LayMaGDTheoTenLoaiGD(tenloaigd);
        }

        // Hàm lấy số tài khoản theo mã tài khoản
        public string LaySTKTheoMaTK(string matk)
        {
            return DAL_GiaoDich.LaySTKTheoMaTK(matk);
        }

        // Hàm lấy mã tài khoản theo số tài khoản
        public string LayMaTKTheoSTK(string stk)
        {
            return DAL_GiaoDich.LayMaTKTheoSTK(stk);
        }

        // Hàm lấy cccd theo mã khách hàng
        public string LayCccdTheoMaKH(string makh)
        {
            return DAL_GiaoDich.LayCccdTheoMaKH(makh);
        }

        // Hàm lấy mã khách hàng theo cccd
        public string LayMaKHTheoCccd(string cccd)
        {
            return DAL_GiaoDich.LayMaKHTheoCccd(cccd);
        }

        //hàm đếm số lượng giao dịch
        public int DemSoLuongGiaoDich()
        {
            return DAL_GiaoDich.DemSoLuongGiaoDich();
        }

        //hàm lấy danh sách tài khoản theo số cccd
        public IQueryable<string> LayDSTaiKhoanTheoCCCD(string cccd)
        {
            return DAL_GiaoDich.LayDSTaiKhoanTheoCCCD(cccd);
        }

        //hàm lấy danh sách khách hàng theo số cccd
        public List<ET_KhachHang> LayDSKhachHangTheoCCCD(string cccd)
        {
            return DAL_GiaoDich.LayDSKhachHangTheoCCCD(cccd);
        }

        //hàm lấy tên loại giao dịch
        public IQueryable<string> LayTenLoaiGiaoDich()
        {
            return DAL_GiaoDich.LayTenLoaiGiaoDich();
        }

        //hàm lấy danh sách giao dịch chưa ẩn
        public List<ET_GiaoDich> LayDSGiaoDichChuaAn()
        {
            return DAL_GiaoDich.LayDSGiaoDichChuaAn();
        }

        //hàm lấy toàn bộ danh sách giao dịch
        public List<ET_GiaoDich> LayToanBoDSGiaoDich()
        {
            return DAL_GiaoDich.LayToanBoDSGiaoDich();
        }

        //hàm lấy danh sách khách hàng con hoạt động
        public List<ET_KhachHang> LayDSKhachHangConHoatDong()
        {
            return DAL_GiaoDich.LayDSKhachHangConHoatDong();
        }

        //hàm thêm giao dịch 
        public bool ThemGiaoDich(ET_GiaoDich et)
        {
            return DAL_GiaoDich.ThemGiaoDich(et);
        }

        //hàm thêm giao dịch và trừ tiền
        public bool ThemGiaoDichVaTruTien(ET_GiaoDich et, string stk)
        {
            return DAL_GiaoDich.ThemGiaoDichVaTruTien(et, stk);
        }

        //hàm ẩn giao dịch
        public bool AnGiaoDich(ET_GiaoDich et)
        {
            return DAL_GiaoDich.AnGiaoDich(et);
        }

        //hàm ẩn giao dịch và cộng tiền
        public bool AnGiaoDichVaCongTien(ET_GiaoDich gd, string stk)
        {
            return DAL_GiaoDich.AnGiaoDichVaCongTien(gd, stk);
        }

        //hàm hủy ẩn giao dịch và trừ tiền
        public bool HuyAnGiaoDichVaTruTien(ET_GiaoDich gd, string stk)
        {
            return DAL_GiaoDich.HuyAnGiaoDichVaTruTien(gd,stk);
        }
    }
}
