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

        //Gọi hàm lấy tên giao dịch
        public string LayTenGD(string ma)
        {
            return bl.LayTenGD(ma);
        }

        //Gọi hàm lấy tên ngoại tệ
        public string LayTenNT(string ma)
        {
            return bl.LayTenNT(ma);
        }

        //Load danh sách tài khoản theo mã
        public IQueryable LoadDSTKtheoMa(string ma)
        {
            return bl.LoadDSTKtheoMa(ma);
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

    public class BUS_BienLaiRP
    {
        DAL_BienLaiRP bl = new DAL_BienLaiRP();

        //Lấy danh sách biên lai report
        public List<ET_BienLaiRP> LoadDSBL()
        {
            return bl.LoadDSBL();
        }

        //Tìm report biên lai
        public List<ET_BienLaiRP> TimRPBL(string ma)
        {
            return bl.TimRPBL(ma);
        }
    }
}
