using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_HopDong : Form
    {
        public Frm_HopDong(string manv)
        {
            InitializeComponent();
            txt_MaNV.Text = dn.LayNhanVienTuDangNhap(manv);
            txt_TenNV.Text = BUS_HopDong.LayTenNVTheoMa(txt_MaNV.Text);
        }

        BUS_HopDong BUS_HopDong = new BUS_HopDong();
        BUS_DangNhap dn = new BUS_DangNhap();

        private void Frm_HopDong_Load(object sender, EventArgs e)
        {
            ChinhMauDGV();
            dtp_NgayKy.MaxDate = DateTime.Now;
            dtp_NgayHetHan.MaxDate = DateTime.Now.AddYears(1);
            AddToCBO(cbo_LoaiHD, BUS_HopDong.LayTenLoaiHD());
            cbo_LoaiHD.SelectedIndex = 0;
            cbo_TrangThai.SelectedIndex = 0;
            HienThiDS();
            dgv_HopDong.Columns["MaHD"].Visible = false;

            dgv_KhachHang.Columns["TinhTrangXoa"].Visible = false;
            dgv_KhachHang.Columns["MaKH"].Visible = false;

            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_HuyAn.Visible = true;
            }
            else
            {
                dgv_HopDong.Columns["TinhTrangXoa"].Visible = false;
            }
            Clear();
        }

        public void AddToCBO(ComboBox cbo, IQueryable list)
        {
            foreach (string s in list)
            {
                cbo.Items.Add(s);
            }
        }

        private void Clear()
        {
            txt_SoHD.Text = "HD-XXXXX-XXXXXXXX-XXXXXX";
            cbo_LoaiHD.SelectedIndex = 0;
            dtp_NgayKy.Value = dtp_NgayKy.MaxDate;
            dtp_NgayHetHan.Value = dtp_NgayHetHan.MaxDate;
            txt_GiaTri.Clear();
            txt_GhiChu.Clear();
            cbo_TrangThai.SelectedIndex = 0;
            txt_CccdKH.Clear();
            txt_TenNV.Clear();
            txt_TenNV.Text = BUS_HopDong.LayTenNVTheoMa(txt_MaNV.Text);

            txt_GiaTri.BackColor = SystemColors.Window;
            txt_GhiChu.BackColor = SystemColors.Window;
            txt_CccdKH.BackColor = SystemColors.Window;
            txt_TenNV.BackColor = SystemColors.Window;
        }

        private void HienThiDS()
        {
            dgv_KhachHang.DataSource = BUS_HopDong.LayDSKhachHangConHoatDong();
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_HopDong.LayDSToanBoHopDong();
                dgv_HopDong.DataSource = ds;
            }
            else
            {
                var ds = BUS_HopDong.LayDSHopDongConHoatDong();
                dgv_HopDong.DataSource = ds;
            }
        }

        public void ChinhMauDGV()
        {
            //màu cho dòng chẵn
            dgv_KhachHang.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_KhachHang.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_KhachHang.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_KhachHang.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_KhachHang.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_KhachHang.RowHeadersVisible = false;

            //màu cho dòng chẵn
            dgv_HopDong.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_HopDong.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_HopDong.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_HopDong.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_HopDong.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_HopDong.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_HopDong.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_HopDong.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_HopDong.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_HopDong.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_HopDong.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_HopDong.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_HopDong.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_HopDong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_HopDong.RowHeadersVisible = false;
        }

        private void Frm_HopDong_Resize(object sender, EventArgs e)
        {
        }

        private void dgv_HopDong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HopDong.RowCount > 0)
                {
                    int dong = dgv_HopDong.CurrentCell.RowIndex;
                    txt_SoHD.Text = dgv_HopDong.Rows[dong].Cells[1].Value.ToString();
                    cbo_LoaiHD.Text = BUS_HopDong.LayTenLoaiHDTheoMa(dgv_HopDong.Rows[dong].Cells[2].Value.ToString());
                    dtp_NgayKy.Text = dgv_HopDong.Rows[dong].Cells[3].Value.ToString();
                    dtp_NgayHetHan.Text = dgv_HopDong.Rows[dong].Cells[4].Value.ToString();
                    txt_GiaTri.Text = dgv_HopDong.Rows[dong].Cells[5].Value.ToString();
                    txt_GhiChu.Text = dgv_HopDong.Rows[dong].Cells[6].Value.ToString();
                    cbo_TrangThai.Text = dgv_HopDong.Rows[dong].Cells[7].Value.ToString();
                    txt_CccdKH.Text = BUS_HopDong.LayCccdTheoMaKH(dgv_HopDong.Rows[dong].Cells[9].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
            HienThiDS();
        }

        private void txt_CccdNV_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_CccdKH_TextChanged(object sender, EventArgs e)
        {
            dgv_KhachHang.DataSource = BUS_HopDong.LayDSKhachHangTheoCCCD(txt_CccdKH.Text);
            if (!KiemTraDinhDangCCCD(txt_CccdKH.Text.Trim()))
            {
                txt_CccdKH.BackColor = Color.LightCoral;
            }
            else
            {
                txt_CccdKH.BackColor = SystemColors.Window;
            }
        }

        //hàm kiểm tra định dạng số CCCD/CMND (chuỗi 12 chữ số, không chữ, không ký tự đặc biệt)
        private bool KiemTraDinhDangCCCD(string cccd)
        {
            bool flag = false;
            string pattern = @"^\d{12}$";
            if (string.IsNullOrWhiteSpace(cccd))
                return flag;
            if (Regex.IsMatch(cccd.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng giá trị (không chữ, không ký tự đặc biệt, không khoảng trắng)
        private bool KiemTraDinhDangGiaTri(string sodu)
        {
            bool flag = false;
            string pattern = @"^\d+$";
            if (string.IsNullOrWhiteSpace(sodu))
                return flag;
            if (Regex.IsMatch(sodu.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng ghi chú (chuỗi 100 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangGhiChu(string diachi)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,100}$";
            if (string.IsNullOrWhiteSpace(diachi))
                return flag;
            if (Regex.IsMatch(diachi.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txt_GiaTri_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangGiaTri(txt_GiaTri.Text.Trim()))
            {
                txt_GiaTri.BackColor = Color.LightCoral;
            }
            else
            {
                txt_GiaTri.BackColor = SystemColors.Window;
            }
        }

        private void txt_GhiChu_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangGhiChu(txt_GhiChu.Text))
            {
                txt_GhiChu.BackColor = Color.LightCoral;
            }
            else
            {
                txt_GhiChu.BackColor = SystemColors.Window;
            }
        }

        private bool KiemTraTatCaTruongNhap()
        {
            var dsham = new Dictionary<string, Tuple<Func<bool>, Control>>();
            dsham.Add("Giá Trị", Tuple.Create((Func<bool>)(() => KiemTraDinhDangGiaTri(txt_GiaTri.Text.Trim())), (Control)txt_GiaTri));
            dsham.Add("Ghi Chú", Tuple.Create((Func<bool>)(() => KiemTraDinhDangGhiChu(txt_GhiChu.Text)), (Control)txt_GhiChu));
            dsham.Add("CCCD Khách Hàng", Tuple.Create((Func<bool>)(() => KiemTraDinhDangCCCD(txt_CccdKH.Text.Trim())), (Control)txt_CccdKH));

            foreach (var saidinhdang in dsham)
            {
                string truong = saidinhdang.Key;
                Func<bool> check = saidinhdang.Value.Item1;
                Control control = saidinhdang.Value.Item2;  // Lấy Control tương ứng với trường

                if (!check())
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show($"Trường {truong} không phù hợp định dạng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Focus vào trường có lỗi
                    control.Focus();
                    return false;
                }
            }

            return true;
        }

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
        }

        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_KhachHang.RowCount > 0)
                {
                    int dong = dgv_KhachHang.CurrentCell.RowIndex;
                    txt_CccdKH.Text = dgv_KhachHang.Rows[dong].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (!BUS_HopDong.KiemTraTonTaiCcccKH(txt_CccdKH.Text.Trim()))
            {
                MessageBox.Show("CCCD Khách Hàng chưa tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CccdKH.Focus();
                return;
            }


            string makh = BUS_HopDong.LayMaKHTheoCccd(txt_CccdKH.Text);
            string thoigian = DateTime.Now.ToString("ddMMyyyy-HHmmss");
            string sohd = "HD-" + makh.Trim() + "-" + thoigian;

            try
            {
                ET_HopDong hd = new ET_HopDong(0,
                                                sohd,
                                                BUS_HopDong.LayMaLoaiHDTheoTen(cbo_LoaiHD.Text),
                                                dtp_NgayKy.Value,
                                                dtp_NgayHetHan.Value,
                                                Convert.ToDecimal(txt_GiaTri.Text),
                                                txt_GhiChu.Text,
                                                cbo_TrangThai.Text,
                                                txt_MaNV.Text,
                                                BUS_HopDong.LayMaKHTheoCccd(txt_CccdKH.Text),
                                                false);
                if (BUS_HopDong.ThemHopDong(hd) == true)
                {
                    MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_HopDong hd = new ET_HopDong(0,
                                                txt_SoHD.Text,
                                                BUS_HopDong.LayMaLoaiHDTheoTen(cbo_LoaiHD.Text),
                                                dtp_NgayKy.Value,
                                                dtp_NgayHetHan.Value,
                                                Convert.ToDecimal(txt_GiaTri.Text),
                                                txt_GhiChu.Text,
                                                cbo_TrangThai.Text,
                                                txt_MaNV.Text,
                                                BUS_HopDong.LayMaKHTheoCccd(txt_CccdKH.Text),
                                                    true);
                    if (BUS_HopDong.AnHopDong(hd) == true)
                    {
                        MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Xóa hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                ET_HopDong hd = new ET_HopDong(0,
                                            txt_SoHD.Text,
                                            BUS_HopDong.LayMaLoaiHDTheoTen(cbo_LoaiHD.Text),
                                            dtp_NgayKy.Value,
                                            dtp_NgayHetHan.Value,
                                            Convert.ToDecimal(txt_GiaTri.Text),
                                            txt_GhiChu.Text,
                                            cbo_TrangThai.Text,
                                            txt_MaNV.Text,
                                            BUS_HopDong.LayMaKHTheoCccd(txt_CccdKH.Text),
                                                false);
                if (BUS_HopDong.AnHopDong(hd) == true)
                {
                    MessageBox.Show("Hủy Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Hủy Xóa hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }
    }
}
