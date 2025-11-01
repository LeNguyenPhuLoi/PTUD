using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiHoTro
    {
        DAL_LoaiHoTro DAL_LoaiHoTro = new DAL_LoaiHoTro();

        //hàm lấy tên loại hỗ trợ theo mã loại hỗ trợ
        public string LayTenLoaiHTTheoMaLoaiHT(string maloaiht)
        {
            return DAL_LoaiHoTro.LayTenLoaiHTTheoMaLoaiHT(maloaiht);
        }

        //hàm đếm số lượng loại hỗ trợ
        public int DemSoLuongLoaiHoTro()
        {
            return DAL_LoaiHoTro.DemSoLuongLoaiHoTro();
        }

        //hàm kiểm tra tên loại hỗ trợ đã tồn tại
        public bool KiemTraTonTaiTenLoaiHT(string tenloaiht)
        {
            return DAL_LoaiHoTro.KiemTraTonTaiTenLoaiHT(tenloaiht);
        }

        //hàm kiểm tra mã loại hỗ trợ đã tồn tại
        public bool KiemTraTonTaiMaLoaiHT(string maloaiht)
        {
            return DAL_LoaiHoTro.KiemTraTonTaiMaLoaiHT(maloaiht);
        }

        //hàm lấy danh sách loại hỗ trợ còn hoạt động
        public List<ET_LoaiHoTro> LayDSLoaiHoTroConHoatDong()
        {
            return DAL_LoaiHoTro.LayDSLoaiHoTroConHoatDong();
        }

        //hàm lấy toàn bộ danh sách loại hỗ trợ
        public List<ET_LoaiHoTro> LayDSToanBoLoaiHoTro()
        {
            return DAL_LoaiHoTro.LayDSToanBoLoaiHoTro();
        }

        //hàm thêm loại hỗ trợ
        public bool ThemLoaiHoTro(ET_LoaiHoTro et)
        {
            return DAL_LoaiHoTro.ThemLoaiHoTro(et);
        }

        //hàm sửa loại hỗ trợ
        public bool SuaLoaiHoTro(ET_LoaiHoTro et)
        {
            return DAL_LoaiHoTro.SuaLoaiHoTro(et);
        }

        //hàm ẩn loại hỗ trợ
        public bool AnLoaiHoTro(ET_LoaiHoTro et)
        {
            return DAL_LoaiHoTro.AnLoaiHoTro(et);
        }
    }
}
