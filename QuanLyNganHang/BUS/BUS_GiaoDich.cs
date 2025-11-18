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

        //hàm lấy phương thức tên loại giao dịch
        public string LayPhuongThucTheoTenLoaiGD(string tenloaigd)
        {
            return DAL_GiaoDich.LayPhuongThucTheoTenLoaiGD(tenloaigd);
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

        //hàm lấy danh sách tài khoản không thuộc số cccd
        public IQueryable<string> LayDSTaiKhoanKhongCuaSoCCCD(string cccd)
        {
            return DAL_GiaoDich.LayDSTaiKhoanKhongCuaSoCCCD(cccd);
        }

        //hàm lấy danh sách tài khoản không thuộc số cccd dạng nhập
        public IQueryable<string> LayDSTaiKhoanKhongCuaSoCCCD_Nhap(string cccd, string stk)
        {
            return DAL_GiaoDich.LayDSTaiKhoanKhongCuaSoCCCD_Nhap(cccd, stk);
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

        //hàm trừ tiền tài khoản A, cộng tiền tài khoản B (nếu có) và thêm giao dịch
        public bool ThemGiaoDichVaTruTien(ET_GiaoDich gd, string stkA, string SoTkB)
        {
            return DAL_GiaoDich.ThemGiaoDichVaTruTien(gd, stkA, SoTkB);
        }

        //hàm cộng tiền tài khoản A, trừ tiền tài khoản B (nếu có) và thêm giao dịch
        public bool ThemGiaoDichVaCongTien(ET_GiaoDich gd, string stkA, string stkB)
        {
            return DAL_GiaoDich.ThemGiaoDichVaCongTien(gd, stkA, stkB);
        }

        //hàm ẩn giao dịch
        public bool AnGiaoDich(ET_GiaoDich et)
        {
            return DAL_GiaoDich.AnGiaoDich(et);
        }

        //hàm cộng tiền tài khoản A, trừ tiền tài khoản B (nếu có) và ẩn giao dịch
        public bool AnGiaoDichVaCongTien(ET_GiaoDich gd, string stkA, string stkB)
        {
            return DAL_GiaoDich.AnGiaoDichVaCongTien(gd, stkA, stkB);
        }

        //hàm trừ tiền tài khoản A, cộng tiền tài khoản B (nếu có) và ẩn giao dịch
        public bool AnGiaoDichVaTruTien(ET_GiaoDich gd, string stkA, string stkB)
        {
            return DAL_GiaoDich.AnGiaoDichVaTruTien(gd, stkA, stkB);
        }

        //hàm trừ tiền tài khoản A, cộng tiền tài khoản B (nếu có) và hủy ẩn giao dịch
        public bool HuyAnGiaoDichVaTruTien(ET_GiaoDich gd, string stkA, string stkB)
        {
            return DAL_GiaoDich.HuyAnGiaoDichVaTruTien(gd, stkA, stkB);
        }

        //hàm cộng tiền tài khoản A, trừ tiền tài khoản B (nếu có) và hủy ẩn giao dịch
        public bool HuyAnGiaoDichVaCongTien(ET_GiaoDich gd, string stkA, string stkB)
        {
            return DAL_GiaoDich.HuyAnGiaoDichVaCongTien(gd, stkA, stkB);
        }
    }
    public class BUS_GiaoDich_Report
    {
        DAL_GiaoDich_Report DAL_GiaoDich_Report = new DAL_GiaoDich_Report();
        //hàm lấy thông tin khách hàng
        public List<ET_GiaoDich_Report_ThongTinKhachHang> LayThongTinKhachHang(string sotk, DateTime ngayGiaoDich)
        {
            return DAL_GiaoDich_Report.LayThongTinKhachHang(sotk, ngayGiaoDich);
        }

        //hàm lấy lịch sử giao dịch
        public List<ET_GiaoDich_Report_ChiTietGiaoDich> LayChiTietGiaoDich(string sotk, DateTime ngayGiaoDich)
        {
            return DAL_GiaoDich_Report.LayChiTietGiaoDich(sotk, ngayGiaoDich);
        }
    }
}
