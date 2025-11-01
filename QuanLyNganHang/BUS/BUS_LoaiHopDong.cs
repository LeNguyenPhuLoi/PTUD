using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiHopDong
    {
        DAL_LoaiHopDong DAL_LoaiHopDong = new DAL_LoaiHopDong();
        //hàm lấy tên loại hợp đồng theo mã loại hợp đồng
        public string LayTenLoaiHDTheoMaLoaiHD(string maloaihd)
        {
            return DAL_LoaiHopDong.LayTenLoaiHDTheoMaLoaiHD(maloaihd);
        }

        //hàm đếm số lượng loại hợp đồng
        public int DemSoLuongLoaiHopDong()
        {
            return DAL_LoaiHopDong.DemSoLuongLoaiHopDong();
        }

        //hàm kiểm tra tên loại hợp đồng đã tồn tại
        public bool KiemTraTonTaiTenLoaiHD(string tenloaihd)
        {
            return DAL_LoaiHopDong.KiemTraTonTaiTenLoaiHD(tenloaihd);
        }

        //hàm kiểm tra mã loại hợp đồng đã tồn tại
        public bool KiemTraTonTaiMaLoaiHD(string maloaihd)
        {
            return DAL_LoaiHopDong.KiemTraTonTaiMaLoaiHD(maloaihd);
        }

        //hàm lấy danh sách loại hợp đồng còn hoạt động
        public List<ET_LoaiHopDong> LayDSLoaiHopDongConHoatDong()
        {
            return DAL_LoaiHopDong.LayDSLoaiHopDongConHoatDong();
        }

        //hàm lấy toàn bộ danh sách loại hợp đồng
        public List<ET_LoaiHopDong> LayDSToanBoLoaiHopDong()
        {
            return DAL_LoaiHopDong.LayDSToanBoLoaiHopDong();
        }

        //hàm thêm loại hợp đồng
        public bool ThemLoaiHopDong(ET_LoaiHopDong et)
        {
            return DAL_LoaiHopDong.ThemLoaiHopDong(et);
        }

        //hàm sửa loại hợp đồng
        public bool SuaLoaiHopDong(ET_LoaiHopDong et)
        {
            return DAL_LoaiHopDong.SuaLoaiHopDong(et);
        }

        //hàm ẩn loại hợp đồng
        public bool AnLoaiHopDong(ET_LoaiHopDong et)
        {
            return DAL_LoaiHopDong.AnLoaiHopDong(et);
        }
    }
}
