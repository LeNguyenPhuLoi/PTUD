using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BUS_NgoaiTe
    {
        DAL_NgoaiTe nt = new DAL_NgoaiTe();

        //Gọi hàm load ngoại tệ
        public IQueryable LoadDSNT()
        {
            return nt.LoadDSNT();
        }

        //Gọi hàm thêm ngoại tệ
        public bool ThemNT(ET_NgoaiTe et)
        {
            return nt.ThemNT(et);
        }

        //Gọi hàm sửa ngoại tệ
        public bool SuaNT(ET_NgoaiTe et)
        {
            return nt.SuaNT(et);
        }

        //Gọi hàm xóa(ẩn) ngoại tệ
        public bool TrangThaiAn(ET_NgoaiTe et)
        {
            return nt.TrangThaiAn(et);
        }

        //Gọi hàm đếm mã
        public string DemMa()
        {
            return nt.DemMa();  
        }
    }
}
