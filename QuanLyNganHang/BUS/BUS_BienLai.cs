using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BUS_BienLai
    {
        DAL_BienLai bl = new DAL_BienLai();

        //Gọi hàm load danh sách biên lai
        public IQueryable LoadDSBienLai()
        {
            return bl.LoadDSBienLai();
        }

        //Gọi hàm load danh sách biên lai user
        public IQueryable LoadDSBienLaiuser()
        {
            return bl.LoadDSBienLaiuser();
        }

        //Gọi hàm load danh sách khách hàng
        public IQueryable LoadDSKH()
        {
            return bl.LoadDSKH();
        }

        //Gọi hàm load danh sách nhân viên
        public IQueryable LoadDSNV()
        {
            return bl.LoadDSNV();
        }

        //Gọi hàm load tên giao dịch
        public IQueryable LoadDSTenGD()
        {
            return bl.LoadDSTenGD();
        }

        //Gọi hàm load tên ngoại tệ
        public IQueryable LoadDSTenNT()
        {
            return bl.LoadDSTenNT();
        }

        //Gọi hàm thêm biên lai
        public bool ThemBienLai(ET_BienLai et)
        {
            return bl.ThemBienLai(et);
        }

        //Gọi hàm sửa biên lai
        public bool SuaBienLai(ET_BienLai et)
        {
            return bl.SuaBienLai(et);
        }

        //Gọi hàm xóa(ẩn) biên lai
        public bool TrangThaiAn(ET_BienLai et)
        {
            return bl.TrangThaiAn(et);
        }

        //Gọi hàm đếm mã
        public string DemMa()
        {
            return bl.DemMa();
        }
    }
}
