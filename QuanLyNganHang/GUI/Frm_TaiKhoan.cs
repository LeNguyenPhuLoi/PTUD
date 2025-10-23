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
    public partial class Frm_TaiKhoan : Form
    {
        public Frm_TaiKhoan()
        {
            InitializeComponent();
        }

        BUS_TaiKhoan BUS_TaiKhoan = new BUS_TaiKhoan();

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgv_TaiKhoan.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgv_TaiKhoan.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_TaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgv_KhachHang.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgv_KhachHang.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            AddToCBO(cbo_LoaiTK, BUS_TaiKhoan.LayChiTietLoaiTK());
            AddToCBO(cbo_TenNgoaiTe, BUS_TaiKhoan.LayTenNgoaiTe());
            cbo_LoaiTK.SelectedIndex = 0;
            cbo_TenNgoaiTe.SelectedIndex = 0;
            cbo_TrangThai.SelectedIndex = 0;
            dtp_NgayMo.MaxDate = DateTime.Now;
            HienThiDS();
            dgv_KhachHang.Columns["TinhTrangXoa"].Visible = false;
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_An.Visible = true;
                btn_HuyAn.Visible = true;
            }
            else
            {
                dgv_TaiKhoan.Columns["TinhTrangXoa"].Visible = false;
            }
        }

        private void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_TaiKhoan.LayDSToanBoTaiKhoan();
                dgv_TaiKhoan.DataSource = ds;
                var dskh = BUS_TaiKhoan.LayDSKhachHangConHoatDong();
                dgv_KhachHang.DataSource = dskh;
            }
            else
            {
                var ds = BUS_TaiKhoan.LayDSTaiKhoanConHoatDong();
                dgv_TaiKhoan.DataSource = ds;
                var dskh = BUS_TaiKhoan.LayDSKhachHangConHoatDong();
                dgv_KhachHang.DataSource = dskh;
            }
        }

        public void AddToCBO(ComboBox cbo, IQueryable list)
        {
            foreach (string s in list)
            {
                cbo.Items.Add(s);
            }
        }

        public void Clear()
        {
            txt_MaTk.Clear();
            txt_CCCD.Clear();
            txt_SoTaiKhoan.Clear();
            cbo_LoaiTK.SelectedIndex = 0;
            txt_SoDu.Clear();
            cbo_TenNgoaiTe.SelectedIndex = 0;
            dtp_NgayMo.Text = dtp_NgayMo.MaxDate.ToString();
            cbo_TrangThai.SelectedIndex = 0;
            var dskh = BUS_TaiKhoan.LayDSKhachHangConHoatDong();
            dgv_KhachHang.DataSource = dskh;

            txt_MaTk.BackColor = SystemColors.Window;
            txt_CCCD.BackColor = SystemColors.Window;
            txt_SoTaiKhoan.BackColor = SystemColors.Window;
            txt_SoDu.BackColor = SystemColors.Window;
        }

        private void Frm_TaiKhoan_Resize(object sender, EventArgs e)
        {

        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (BUS_TaiKhoan.KiemTraTonTaiMaTK(txt_MaTk.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Mã tài khoản này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BUS_TaiKhoan.KiemTraTonTaiSoTK(txt_SoTaiKhoan.Text))
            {
                MessageBox.Show("Số tài khoản này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTk.Text.Trim().ToUpper(),
                                                    BUS_TaiKhoan.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    txt_SoTaiKhoan.Text,
                                                    BUS_TaiKhoan.LayMaLoaiTKTheoChiTiet(cbo_LoaiTK.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    BUS_TaiKhoan.LayMaNgoaiTeTheoTen(cbo_TenNgoaiTe.Text),
                                                    dtp_NgayMo.Value,
                                                    cbo_TrangThai.Text,
                                                    false);
                if (BUS_TaiKhoan.ThemTaiKhoan(tk) == true)
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void txt_CCCD_TextChanged(object sender, EventArgs e)
        {
            var dskh = BUS_TaiKhoan.LayDSKhachHangTheoCCCD(txt_CCCD.Text);
            dgv_KhachHang.DataSource = dskh;
            if (!KiemTraDinhDangCCCD(txt_CCCD.Text))
            {
                txt_CCCD.BackColor = Color.LightCoral;
            }
            else
            {
                txt_CCCD.BackColor = SystemColors.Window;
            }
        }

        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_KhachHang.RowCount > 0)
                {
                    int dong = dgv_KhachHang.CurrentCell.RowIndex;
                    txt_CCCD.Text = dgv_KhachHang.Rows[dong].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (BUS_TaiKhoan.KiemTraTonTaiSoTK(txt_SoTaiKhoan.Text))
            {
                MessageBox.Show("Số tài khoản này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTk.Text.Trim().ToUpper(),
                                                    BUS_TaiKhoan.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    txt_SoTaiKhoan.Text,
                                                    BUS_TaiKhoan.LayMaLoaiTKTheoChiTiet(cbo_LoaiTK.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    BUS_TaiKhoan.LayMaNgoaiTeTheoTen(cbo_TenNgoaiTe.Text),
                                                    dtp_NgayMo.Value,
                                                    cbo_TrangThai.Text,
                                                    false);
                if (BUS_TaiKhoan.SuaTaiKhoan(tk) == true)
                {
                    MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể sửa tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTk.Text.Trim().ToUpper(),
                                                    BUS_TaiKhoan.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    txt_SoTaiKhoan.Text,
                                                    BUS_TaiKhoan.LayMaLoaiTKTheoChiTiet(cbo_LoaiTK.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    BUS_TaiKhoan.LayMaNgoaiTeTheoTen(cbo_TenNgoaiTe.Text),
                                                    dtp_NgayMo.Value,
                                                    cbo_TrangThai.Text,
                                                    true);
                    if (this.MdiParent.Name == "frmMainAddmin")
                    {
                        if (BUS_TaiKhoan.XoaTaiKhoan(tk) == true)
                        {
                            MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể Xóa tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (BUS_TaiKhoan.AnTaiKhoan(tk) == true)
                        {
                            MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể Xóa tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void dgv_TaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_TaiKhoan.RowCount > 0)
                {
                    int dong = dgv_TaiKhoan.CurrentCell.RowIndex;
                    txt_MaTk.Text = dgv_TaiKhoan.Rows[dong].Cells[0].Value.ToString();
                    txt_CCCD.Text = BUS_TaiKhoan.LayCccdTheoMaKH(dgv_TaiKhoan.Rows[dong].Cells[1].Value.ToString());
                    txt_SoTaiKhoan.Text = dgv_TaiKhoan.Rows[dong].Cells[2].Value.ToString();
                    cbo_LoaiTK.Text = BUS_TaiKhoan.LayChiTietTheoMaLoaiTK(dgv_TaiKhoan.Rows[dong].Cells[3].Value.ToString());
                    txt_SoDu.Text = dgv_TaiKhoan.Rows[dong].Cells[4].Value.ToString();
                    cbo_TenNgoaiTe.Text = BUS_TaiKhoan.LayTenNgoaiTeTheoMa(dgv_TaiKhoan.Rows[dong].Cells[5].Value.ToString());
                    dtp_NgayMo.Text = dgv_TaiKhoan.Rows[dong].Cells[6].Value.ToString();
                    cbo_TrangThai.Text = dgv_TaiKhoan.Rows[dong].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_An_Click(object sender, EventArgs e)
        {
            try
            {
                ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTk.Text.Trim().ToUpper(),
                                                    BUS_TaiKhoan.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    txt_SoTaiKhoan.Text,
                                                    BUS_TaiKhoan.LayMaLoaiTKTheoChiTiet(cbo_LoaiTK.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    BUS_TaiKhoan.LayMaNgoaiTeTheoTen(cbo_TenNgoaiTe.Text),
                                                    dtp_NgayMo.Value,
                                                    cbo_TrangThai.Text,
                                                    true);
                if (BUS_TaiKhoan.AnTaiKhoan(tk) == true)
                {
                    MessageBox.Show("Ẩn tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Ẩn tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTk.Text.Trim().ToUpper(),
                                                    BUS_TaiKhoan.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    txt_SoTaiKhoan.Text,
                                                    BUS_TaiKhoan.LayMaLoaiTKTheoChiTiet(cbo_LoaiTK.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    BUS_TaiKhoan.LayMaNgoaiTeTheoTen(cbo_TenNgoaiTe.Text),
                                                    dtp_NgayMo.Value,
                                                    cbo_TrangThai.Text,
                                                    false);
                if (BUS_TaiKhoan.AnTaiKhoan(tk) == true)
                {
                    MessageBox.Show("Hủy Ẩn tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Hủy Ẩn tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        //hàm kiểm tra định dạng mã tài khoản (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaTK(string matk)
        {
            bool flag = false;
            string pattern = @"^TK\d{3,8}$";
            if (string.IsNullOrWhiteSpace(matk))
                return flag;
            if (Regex.IsMatch(matk, pattern))
                flag = true;
            return flag;
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

        //hàm kiểm tra định dạng số tài khoản (chuỗi 10 chữ số, không chữ, không ký tự đặc biệt, không khoảng trắng)
        private bool KiemTraDinhDangSTK(string stk)
        {
            bool flag = false;
            string pattern = @"^\d{10}$";
            if (string.IsNullOrWhiteSpace(stk))
                return flag;
            if (Regex.IsMatch(stk.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số dư (không chữ, không ký tự đặc biệt, không khoảng trắng)
        private bool KiemTraDinhDangSoDu(string sodu)
        {
            bool flag = false;
            string pattern = @"^\d+$";
            if (string.IsNullOrWhiteSpace(sodu))
                return flag;
            if (Regex.IsMatch(sodu.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txt_MaTk_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangMaTK(txt_MaTk.Text.Trim().ToUpper()))
            {
                txt_MaTk.BackColor = Color.LightCoral;
            }
            else
            {
                txt_MaTk.BackColor = SystemColors.Window;
            }
        }

        private void txt_SoTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangSTK(txt_SoTaiKhoan.Text))
            {
                txt_SoTaiKhoan.BackColor = Color.LightCoral;
            }
            else
            {
                txt_SoTaiKhoan.BackColor = SystemColors.Window;
            }
        }

        private void txt_SoDu_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangSoDu(txt_SoDu.Text))
            {
                txt_SoDu.BackColor = Color.LightCoral;
            }
            else
            {
                txt_SoDu.BackColor = SystemColors.Window;
            }
        }

        private void Frm_TaiKhoan_ResizeEnd(object sender, EventArgs e)
        {
        }

        private bool KiemTraTatCaTruongNhap()
        {
            var dsham = new Dictionary<string, Func<bool>>
            {
                { "Mã Khách Hàng", () => KiemTraDinhDangMaTK(txt_MaTk.Text.Trim().ToUpper()) },
                { "CCCD/CMND",  () => KiemTraDinhDangCCCD(txt_CCCD.Text) },
                { "Số Tài Khoản", () => KiemTraDinhDangSTK(txt_SoTaiKhoan.Text) },
                { "Số Dư", () => KiemTraDinhDangSoDu(txt_SoDu.Text) },
            };

            foreach (var saidinhdang in dsham)
            {
                string truong = saidinhdang.Key;
                Func<bool> check = saidinhdang.Value;

                if (!check())
                {
                    MessageBox.Show($"Trường {truong} không phù hợp định dạng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
    }
}
