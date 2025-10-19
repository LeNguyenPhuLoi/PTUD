using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiTaiKhoan
    {
        public string MaLoaiTK {  get; set; }

        public string ChiTiet {  get; set; }

        public DateTime NgayTao { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public string TrangThai { get; set; }

        public bool TinhTrangXoa { get; set; }

        public ET_LoaiTaiKhoan(string maLoaiTK, string chiTiet, DateTime ngayTao, DateTime ngayCapNhat, string trangThai, bool tinhTrangXoa)
        {
            MaLoaiTK = maLoaiTK;
            ChiTiet = chiTiet;
            NgayTao = ngayTao;
            NgayCapNhat = ngayCapNhat;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }
    }
}
