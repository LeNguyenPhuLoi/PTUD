using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NgoaiTe
    {
        public ET_NgoaiTe(string maNgoaiTe, string tenNgoaiTe, string kyHieu, string quocGia, string trangThai, string tinhTrangXoa)
        {
            MaNgoaiTe = maNgoaiTe;
            TenNgoaiTe = tenNgoaiTe;
            KyHieu = kyHieu;
            QuocGia = quocGia;
            TrangThai = trangThai;
            TinhTrangXoa = tinhTrangXoa;
        }

        public string MaNgoaiTe {  get; set; }
        public string TenNgoaiTe { get; set; }
        public string KyHieu { get; set; }
        public string QuocGia { get; set; }
        public string TrangThai { get; set; }
        public string TinhTrangXoa { get; set; }
    }
}
