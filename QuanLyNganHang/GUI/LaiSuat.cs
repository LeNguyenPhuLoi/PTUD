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
    public partial class frmLaiSuat : Form
    {
        public frmLaiSuat()
        {
            InitializeComponent();
        }

        BUS_LaiSuat bUS_LaiSuat = new BUS_LaiSuat();

        private void frmLaiSuat_Load(object sender, EventArgs e)
        {
            dgvlaisuat.DataSource = bUS_LaiSuat.LoadDSLaiSuat();
        } 

        public void Clear()
        {
            txtMaLS.Clear();
            txtTenLoai.Clear();
            txtLaiSuat.Clear();
            cboKL.Text = null;
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
                ET_LaiSuat ls = new ET_LaiSuat(txtMaLS.Text,
                                               txtTenLoai.Text,
                                               decimal.Parse(txtLaiSuat.Text),
                                               cboKL.Text,
                                               TrangThai);
                if (bUS_LaiSuat.ThemLaiSuat(ls) == true)
                {
                    MessageBox.Show("Thêm lãi suất thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm lãi suất thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvlaisuat.DataSource = bUS_LaiSuat.LoadDSLaiSuat();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_LaiSuat ls = new ET_LaiSuat(txtMaLS.Text,
                                               txtTenLoai.Text,
                                               decimal.Parse(txtLaiSuat.Text),
                                               cboKL.Text,
                                               TrangThai);
                if (bUS_LaiSuat.SuaLaiSuat(ls) == true)
                {
                    MessageBox.Show("Sửa lãi suất thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa lãi suất thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvlaisuat.DataSource = bUS_LaiSuat.LoadDSLaiSuat();
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_LaiSuat ls = new ET_LaiSuat(txtMaLS.Text,
                                               txtTenLoai.Text,
                                               decimal.Parse(txtLaiSuat.Text),
                                               cboKL.Text,
                                               TrangThai);
                    if (bUS_LaiSuat.XoaLaiSuat(ls) == true)
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
            dgvlaisuat.DataSource = bUS_LaiSuat.LoadDSLaiSuat();

        }

        private void btn_An_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                ET_LaiSuat ck = new ET_LaiSuat(txtMaLS.Text,
                                               txtTenLoai.Text,
                                               decimal.Parse(txtLaiSuat.Text),
                                               cboKL.Text,
                                               TrangThai);
                if (bUS_LaiSuat.TrangThaiAn(ck) == true)
                {
                    MessageBox.Show("Ẩn lãi suất thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Ẩn lãi suất thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvlaisuat.DataSource = bUS_LaiSuat.LoadDSLaiSuat();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_LaiSuat ck = new ET_LaiSuat(txtMaLS.Text,
                                               txtTenLoai.Text,
                                               decimal.Parse(txtLaiSuat.Text),
                                               cboKL.Text,
                                               TrangThai);
                if (bUS_LaiSuat.TrangThaiAn(ck) == true)
                {
                    MessageBox.Show("Hủy ẩn chuyển khoản thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Hủy ẩn chuyển khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvlaisuat.DataSource = bUS_LaiSuat.LoadDSLaiSuat();
        }

        private void dgvlaisuat_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvlaisuat.CurrentCell.RowIndex;
                txtMaLS.Text = dgvlaisuat.Rows[dong].Cells[0].Value.ToString();
                txtTenLoai.Text = dgvlaisuat.Rows[dong].Cells[1].Value.ToString();
                txtLaiSuat.Text = dgvlaisuat.Rows[dong].Cells[2].Value.ToString();
                cboKL.Text = dgvlaisuat.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //hàm kiểm tra định dạng mã khoản vay (10 ký tự, không ký tự đặc biệt, không khoảng trống)
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

        //hàm kiểm tra định dạng tên lãi suất (chuỗi 250 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangTenLS(string tenls)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,250}$";
            if (string.IsNullOrWhiteSpace(tenls))
                return flag;
            if (Regex.IsMatch(tenls.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng lãi suất (chuỗi 2 chữ số, không chữ, không ký tự đặc biệt)
        public bool KiemTraDinhDangLS(string ls)
        {
            bool flag = false;
            string pattern = @"^\d{1,2}$";
            if (string.IsNullOrWhiteSpace(ls))
                return flag;
            if (Regex.IsMatch(ls.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txtMaLS_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLS.Text))
            {
                errorProvider1.SetError(txtMaLS, "");
                txtMaLS.BackColor = Color.White;
                return;
            }
            string maKV = txtMaLS.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaLS(maKV))
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

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                errorProvider1.SetError(txtTenLoai, "");
                txtTenLoai.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangTenLS(txtTenLoai.Text))
            {
                txtTenLoai.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtTenLoai, "Tên lãi suất không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtTenLoai.Focus();
                return;
            }
            else
            {
                txtTenLoai.BackColor = Color.White;
            }
            errorProvider1.SetError(txtTenLoai, "");
        }

        private void txtLaiSuat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLaiSuat.Text))
            {
                errorProvider1.SetError(txtLaiSuat, "");
                txtLaiSuat.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangLS(txtLaiSuat.Text))
            {
                txtLaiSuat.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtLaiSuat, "Lãi suất không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtLaiSuat.Focus();
                return;
            }
            else
            {
                txtLaiSuat.BackColor = Color.White;
            }
            errorProvider1.SetError(txtLaiSuat, "");
        }
    }
}
