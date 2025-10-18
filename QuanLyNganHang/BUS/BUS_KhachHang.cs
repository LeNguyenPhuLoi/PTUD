using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang DAL_KhachHang = new DAL_KhachHang();

        //hàm kiểm tra mã khách hàng đã tồn tại
        public bool KiemTraTonTaiMaKH(string makh)
        {
            return DAL_KhachHang.KiemTraTonTaiMaKH(makh);
        }

        //hàm lấy danh sách toàn bộ khách hàng
        public List<ET_KhachHang> LayDSToanBoKhachHang()
        {
            return DAL_KhachHang.LayDSToanBoKhachHang();
        }

        //hàm thêm khách hàng
        public bool ThemKhachHang(ET_KhachHang et)
        {
            return DAL_KhachHang.ThemKhachHang(et);
        }

        //hàm sửa khách hàng
        public bool SuaKhachHang(ET_KhachHang et)
        {
            return DAL_KhachHang.SuaKhachHang(et);
        }

        //hàm xóa khách hàng
        public bool XoaKhachHang(ET_KhachHang et)
        {
            return DAL_KhachHang.XoaKhachHang(et);
        }
    }
}
