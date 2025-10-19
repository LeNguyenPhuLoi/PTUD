using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TaiKhoan
    {
        public string MaTK {  get; set; }

        public string MaKH { get; set; }

        public string SoTaiKhoan { get; set; }

        public string MaLoaiTK { get; set; }

        public decimal SoDu {  get; set; }

        public string MaNgoaiTe { get; set; }

        public DateTime NgayMoTK { get; set; }

        public string TrangThai {  get; set; }

        public bool TinhTrangXoa { get; set; }
        public ET_TaiKhoan(string maTK, string maKH, string soTaiKhoan, string maLoaiTK, decimal soDu, string maNgoaiTe, DateTime ngayMoTK, string trangThai, bool tinhTrangXoa)
        {
            MaTK = maTK;
            MaKH = maKH;
            SoTaiKhoan = soTaiKhoan;
            MaLoaiTK = maLoaiTK;
            SoDu = soDu;
            MaNgoaiTe = maNgoaiTe;
            NgayMoTK = ngayMoTK;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }
    }
}
