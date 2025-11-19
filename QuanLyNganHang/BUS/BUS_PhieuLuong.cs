using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuLuong
    {
        DAL_PhieuLuong dal = new DAL_PhieuLuong();

        // Lấy phiếu lương 1 nhân viên trong tháng
        public List<ET_PhieuLuong> LayPhieuLuongNhanVien(string manv, int thang, int nam)
        {
            return dal.LayPhieuLuongNhanVien(manv, thang, nam);
        }
    }

    public class BUS_BangLuong
    {
        DAL_BangLuong dal = new DAL_BangLuong();

        // Lấy phiếu lương 1 nhân viên trong tháng
        public List<ET_BangLuong> LayBangLuongNhanVien(int thang, int nam)
        {
            return dal.LayBangLuongNhanVien(thang, nam);
        }
    }
}
