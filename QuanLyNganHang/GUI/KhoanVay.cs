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
    public partial class frmKhoanVay : Form
    {
        public frmKhoanVay()
        {
            InitializeComponent();
        }

        BUS_KhoanVay bUS_KhoanVay = new BUS_KhoanVay();

        private void frmKhoanVay_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgvKhoanVay.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvKhoanVay.RowsDefaultCellStyle.BackColor = Color.White;
            dgvKhoanVay.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgvmakh.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvmakh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmakh.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgvtaikhoan.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvtaikhoan.RowsDefaultCellStyle.BackColor = Color.White;
            dgvtaikhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgvlaisuat.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvlaisuat.RowsDefaultCellStyle.BackColor = Color.White;
            dgvlaisuat.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            dgvmakh.DataSource = bUS_KhoanVay.LoadDSKhachHang();
            dgvtaikhoan.DataSource = bUS_KhoanVay.LoadDSTaiKhoan();
            dgvlaisuat.DataSource = bUS_KhoanVay.LoadDSLaiSuat();
            dtpNgayVay.MaxDate = DateTime.Now;
            dtpThoiHan.MaxDate = DateTime.Now;
            cboTrangThai.SelectedIndex = 0;
            HienThiDS();
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_An.Visible = true;
                btn_HuyAn.Visible = true;
                dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVay();
                btnxoauser.Visible = false;
            }
            else
            {
                dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVayUser();
                dgvKhoanVay.Columns["TinhTrangXoa"].Visible = false;
                btnxoauser.Visible = true;
            }
            dgvKhoanVay.Columns["LAISUAT"].Visible = false;
            dgvKhoanVay.Columns["KHACHHANG"].Visible = false;
            dgvKhoanVay.Columns["TAIKHOAN"].Visible = false;
        }

        public void Clear()
        {
            txtMaVay.Clear();
            txtMaKH.Clear();
            txtMaTK.Clear();
            txtSoTienVay.Clear();
            cboTrangThai.SelectedIndex = 0;
            dtpNgayVay.Text = null;
            dtpThoiHan.Text = null;
            txtMaLS.Clear();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_KhoanVay kv = new ET_KhoanVay(bUS_KhoanVay.DemMa(),
                                                 txtMaKH.Text,
                                                 txtMaTK.Text,
                                                 decimal.Parse(txtSoTienVay.Text),
                                                 Convert.ToDateTime(dtpNgayVay.Text),
                                                 Convert.ToDateTime(dtpThoiHan.Text),
                                                 cboTrangThai.Text,
                                                 txtMaLS.Text,
                                                 TrangThai);
                if (bUS_KhoanVay.ThemKV(kv) == true)
                {
                    MessageBox.Show("Thêm khoản vay thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm khoản vay thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVay();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_KhoanVay kv = new ET_KhoanVay(txtMaVay.Text,
                                                 txtMaKH.Text,
                                                 txtMaTK.Text,
                                                 decimal.Parse(txtSoTienVay.Text),
                                                 dtpNgayVay.Value,
                                                 dtpThoiHan.Value,
                                                 cboTrangThai.Text,
                                                 txtMaLS.Text,
                                                 TrangThai);
                if (bUS_KhoanVay.SuaKV(kv) == true)
                {
                    MessageBox.Show("Sửa khoản vay thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa khoản vay thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVay();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_KhoanVay kv = new ET_KhoanVay(txtMaVay.Text,
                                                     txtMaKH.Text,
                                                     txtMaTK.Text,
                                                     decimal.Parse(txtSoTienVay.Text),
                                                     dtpNgayVay.Value,
                                                     dtpThoiHan.Value,
                                                     cboTrangThai.Text,
                                                     txtMaLS.Text,
                                                     TrangThai);
                    if (bUS_KhoanVay.XoaKV(kv) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVay();
        }

        private void dgvKhoanVay_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhoanVay.CurrentCell.RowIndex;
                txtMaVay.Text = dgvKhoanVay.Rows[dong].Cells[0].Value.ToString();
                txtMaKH.Text = dgvKhoanVay.Rows[dong].Cells[1].Value.ToString();
                txtMaTK.Text = dgvKhoanVay.Rows[dong].Cells[2].Value.ToString();
                txtSoTienVay.Text = dgvKhoanVay.Rows[dong].Cells[3].Value.ToString();
                dtpNgayVay.Text = dgvKhoanVay.Rows[dong].Cells[4].Value.ToString();
                dtpThoiHan.Text = dgvKhoanVay.Rows[dong].Cells[5].Value.ToString();
                cboTrangThai.Text = dgvKhoanVay.Rows[dong].Cells[6].Value.ToString();
                txtMaLS.Text = dgvKhoanVay.Rows[dong].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvmakh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmakh.CurrentCell.RowIndex;
                txtMaKH.Text = dgvmakh.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvtaikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvtaikhoan.CurrentCell.RowIndex;
                txtMaTK.Text = dgvtaikhoan.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvlaisuat_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvlaisuat.CurrentCell.RowIndex;
                txtMaLS.Text = dgvlaisuat.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_An_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_KhoanVay ck = new ET_KhoanVay(txtMaVay.Text,
                                                                     txtMaKH.Text,
                                                                     txtMaTK.Text,
                                                                     decimal.Parse(txtSoTienVay.Text),
                                                                     dtpNgayVay.Value,
                                                                     dtpThoiHan.Value,
                                                                     cboTrangThai.Text,
                                                                     txtMaLS.Text,
                                                                     TrangThai);
                    if (bUS_KhoanVay.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa khoản vay thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoản vay thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVay();
        }

        private void btnxoauser_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_KhoanVay ck = new ET_KhoanVay(txtMaVay.Text,
                                                 txtMaKH.Text,
                                                 txtMaTK.Text,
                                                 decimal.Parse(txtSoTienVay.Text),
                                                 dtpNgayVay.Value,
                                                 dtpThoiHan.Value,
                                                 cboTrangThai.Text,
                                                 txtMaLS.Text,
                                                 TrangThai);
                    if (bUS_KhoanVay.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa khoản thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoản vay thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVayUser();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_KhoanVay ck = new ET_KhoanVay(txtMaVay.Text,
                                                 txtMaKH.Text,
                                                 txtMaTK.Text,
                                                 decimal.Parse(txtSoTienVay.Text),
                                                 dtpNgayVay.Value,
                                                 dtpThoiHan.Value,
                                                 cboTrangThai.Text,
                                                 txtMaLS.Text,
                                                 TrangThai);
                if (bUS_KhoanVay.TrangThaiAn(ck) == true)
                {
                    MessageBox.Show("Hủy ẩn khoản vay thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Hủy ẩn khoản vay thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVay();
        }

        //hàm kiểm tra định dạng mã khoản vay (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKV(string maKV)
        {
            bool flag = false;
            string pattern = @"^VAY\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maKV))
                return flag;
            if (Regex.IsMatch(maKV, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mã khách hàng (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKH(string maKH)
        {
            bool flag = false;
            string pattern = @"^KH\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maKH))
                return flag;
            if (Regex.IsMatch(maKH, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mã tài khoản (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaTK(string maTK)
        {
            bool flag = false;
            string pattern = @"^TK\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maTK))
                return flag;
            if (Regex.IsMatch(maTK, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mã lãi suất (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaLS(string maLS)
        {
            bool flag = false;
            string pattern = @"^LS\d{2,8}$";
            if (string.IsNullOrWhiteSpace(maLS))
                return flag;
            if (Regex.IsMatch(maLS, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số tiền (không chữ, không ký tự đặc biệt)
        private bool KiemTraDinhDangTien(string tien)
        {
            bool flag = false;
            string pattern = @"^\d{1,9}$";
            if (string.IsNullOrWhiteSpace(tien))
                return flag;
            if (Regex.IsMatch(tien.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txtMaVay_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVay.Text))
            {
                errorProvider1.SetError(txtMaVay, "");
                txtMaVay.BackColor = Color.White;
                return;
            }
            string maKV = txtMaVay.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKV(maKV))
            {
                txtMaVay.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaVay, "Mã khoản vay không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaVay.Focus();
                return;
            }
            else
            {
                txtMaVay.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaVay, "");
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                errorProvider1.SetError(txtMaKH, "");
                txtMaKH.BackColor = Color.White;
                return;
            }
            string maKH = txtMaKH.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKH(maKH))
            {
                txtMaKH.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaKH, "Mã khách hàng không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaKH.Focus();
                return;
            }
            else
            {
                txtMaKH.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaKH, "");
        }

        private void txtMaTK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTK.Text))
            {
                errorProvider1.SetError(txtMaTK, "");
                txtMaTK.BackColor = Color.White;
                return;
            }
            string maTK = txtMaTK.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaTK(maTK))
            {
                txtMaTK.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaTK, "Mã tài khoản không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaTK.Focus();
                return;
            }
            if (!bUS_KhoanVay.KiemTraTaiKhoanThuocKhachHang(txtMaTK.Text, txtMaKH.Text))
            {
                txtMaTK.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaTK, "Mã tài khoản phải đúng với mã khách hàng");
                txtMaTK.Focus();
                return;
            }
            else
            {
                txtMaTK.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaTK, "");
        }

        private void txtMaLS_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLS.Text))
            {
                errorProvider1.SetError(txtMaLS, "");
                txtMaLS.BackColor = Color.White;
                return;
            }
            string maLS = txtMaLS.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaLS(maLS))
            {
                txtMaLS.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaLS, "Mã lãi suất không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaLS.Focus();
                return;
            }
            else
            {
                txtMaLS.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaLS, "");
        }

        private void txtSoTienVay_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTienVay.Text))
            {
                errorProvider1.SetError(txtSoTienVay, "");
                txtSoTienVay.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangTien(txtSoTienVay.Text))
            {
                txtSoTienVay.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtSoTienVay, "Số tiền không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtSoTienVay.Focus();
                return;
            }
            else
            {
                txtSoTienVay.BackColor = Color.White;
            }
            errorProvider1.SetError(txtSoTienVay, "");
        }
    }
}
