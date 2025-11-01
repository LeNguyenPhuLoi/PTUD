using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET;
using DAL;

namespace BUS
{
    public class BUS_LoaiGiaoDich
    {
        DAL_LoaiGiaoDich DAL_LoaiGiaoDich = new DAL_LoaiGiaoDich();

        //hàm lấy tên loại giao dịch theo mã loại giao dịch
        public string LayTenLoaiGDTheoMaLoaiGD(string maloaigd)
        {
            return DAL_LoaiGiaoDich.LayTenLoaiGDTheoMaLoaiGD(maloaigd);
        }

        //hàm đếm số lượng loại giao dịch
        public int DemSoLuongLoaiGiaoDich()
        {
            return DAL_LoaiGiaoDich.DemSoLuongLoaiGiaoDich();
        }

        //hàm kiểm tra tên loại giao dịch đã tồn tại
        public bool KiemTraTonTaiTenLoaiGD(string tenloaigd)
        {
            return DAL_LoaiGiaoDich.KiemTraTonTaiTenLoaiGD(tenloaigd);
        }

        //hàm kiểm tra mã loại giao dịch đã tồn tại
        public bool KiemTraTonTaiMaLoaiGD(string maloaigd)
        {
            return DAL_LoaiGiaoDich.KiemTraTonTaiMaLoaiGD(maloaigd);
        }

        //hàm lấy danh sách loại gia dịch còn hoạt động
        public List<ET_LoaiGiaoDich> LayDSLoaiGiaoDichConHoatDong()
        {
            return DAL_LoaiGiaoDich.LayDSLoaiGiaoDichConHoatDong();
        }

        //hàm lấy toàn bộ danh sách loại giao dịch
        public List<ET_LoaiGiaoDich> LayDSToanBoLoaiGiaoDich()
        {
            return DAL_LoaiGiaoDich.LayDSToanBoLoaiGiaoDich();
        }

        //hàm thêm loại giao dịch
        public bool ThemLoaiGiaoDich(ET_LoaiGiaoDich et)
        {
            return DAL_LoaiGiaoDich.ThemLoaiGiaoDich(et);
        }

        //hàm sửa loại giao dịch
        public bool SuaLoaiGiaoDich(ET_LoaiGiaoDich et)
        {
            return DAL_LoaiGiaoDich.SuaLoaiGiaoDich(et);
        }
        //hàm ẩn loại giao dịch
        public bool AnLoaiGiaoDich(ET_LoaiGiaoDich et)
        {
            return DAL_LoaiGiaoDich.AnLoaiGiaoDich(et);
        }
    }
}
