using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BUS_TraNo
    {
        DAL_TraNo tn = new DAL_TraNo();

        //Gọi hàm load danh sách trả nợ
        public IQueryable LoadDSTraNo()
        {
            return tn.LoadDSTraNo();
        }

        //Gọi hàm load danh sách trả nợ user
        public IQueryable LoadDSTraNouser()
        {
            return tn.LoadDSTraNouser();    
        }

        //Gọi hàm load danh sách khoản vay
        public IQueryable LoadDSKhoanVay()
        {
            return tn.LoadDSKhoanVay();
        }

        //Gọi hàm thêm trả nợ
        public bool ThemTraNo(ET_TraNo et)
        {
            return tn.ThemTraNo(et);
        }

        //Gọi hàm sửa trả nợ
        public bool SuaTraNo(ET_TraNo et)
        {
            return tn.SuaTraNo(et);
        }

        //Gọi hàm xóa(ẩn) trả nợ
        public bool TrangThaiAn(ET_TraNo et)
        {
            return tn.TrangThaiAn(et);
        }

        //Gọi hàm đếm mã
        public string DemMa()
        {
            return tn.DemMa();
        }
    }

    public class BUS_TraNoRP
    {
        DAL_TraNoRP tn = new DAL_TraNoRP();

        //Lấy danh sách trả nợ report
        public List<ET_TraNoRP> LoadDSTN()
        {
            return tn.LoadDSTN();
        }

        //Tìm report trả nợ
        public List<ET_TraNoRP> TimRPTN(string ma)
        {
            return tn.TimRPTN(ma);
        }
    }
}
