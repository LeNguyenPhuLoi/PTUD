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
