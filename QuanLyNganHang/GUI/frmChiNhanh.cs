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
    public partial class frmChiNhanh : Form
    {
        public frmChiNhanh()
        {
            InitializeComponent();
        }
        BUS_ChiNhanh bus = new BUS_ChiNhanh();
        frmNhanVien test = new frmNhanVien();
        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvChiNhanh.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvChiNhanh.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvChiNhanh.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvChiNhanh.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvChiNhanh.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvChiNhanh.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvChiNhanh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiNhanh.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvChiNhanh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvChiNhanh.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvChiNhanh.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            //Load dữ liệu lên database
            dgvChiNhanh.DataSource = bus.LoadDSChiNhanh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChiNhanh et = new ET_ChiNhanh(txtMaCN.Text, txtTenCN.Text,
                                                    txtDiaChi.Text,txtSDTCN.Text);
                string error = "";
                if (bus.ThemChiNhanh(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvChiNhanh.DataSource = bus.LoadDSChiNhanh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChiNhanh et = new ET_ChiNhanh(txtMaCN.Text, txtTenCN.Text,
                                                    txtDiaChi.Text, txtSDTCN.Text);
                string error = "";
                if (bus.CapNhatChiNhanh(et, out error) == true)
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvChiNhanh.DataSource = bus.LoadDSChiNhanh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ET_ChiNhanh et = new ET_ChiNhanh(txtMaCN.Text, txtTenCN.Text,
                                                    txtDiaChi.Text, txtSDTCN.Text);
                    string error = "";
                    if (bus.XoaChiNhanh(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvChiNhanh.DataSource = bus.LoadDSChiNhanh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn trước khi xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaCN.Clear();
            txtTenCN.Clear();
            txtDiaChi.Clear();
            txtSDTCN.Clear();
            txtMaCN.Focus();
            txtMaCN.Enabled = true;
            dgvChiNhanh.DataSource = bus.LoadDSChiNhanh();
        }


        //hàm kiểm tra định dạng mã Chi Nhánh (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaCN(string maCN)
        {
            bool flag = false;
            string pattern = @"^CN\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maCN))// kiểm tra trống hoặc toàn khoảng trắng
                return flag;
            if (Regex.IsMatch(maCN, pattern))//kiểm tra chuỗi theo mẫu
                flag = true;
            return flag;
        }

        private void txtMaCN_Leave(object sender, EventArgs e)
        {
            string maCN = txtMaCN.Text.Trim().ToUpper();

            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(maCN))
            {
                errorProvider1.SetError(txtMaCN, "");
                txtMaCN.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng mã nhân viên
            if (!KiemTraDinhDangMaCN(maCN))
            {
                txtMaCN.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtMaCN, "Mã chi nhánh không hợp lệ! (VD: CN001, CN12345)");
                MessageBox.Show("Mã Chi Nhánh phải có dạng CN + 3-8 chữ số (VD: CN001, CN12345).",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCN.Clear();
                txtMaCN.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtMaCN, "");
            txtMaCN.BackColor = Color.White;
        }

        private void txtTenCN_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtTenCN.Text))
            {
                errorProvider1.SetError(txtTenCN, "");
                txtTenCN.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng tên nhân viên
            if (!test.KiemTraDinhDangTen(txtTenCN.Text))
            {
                txtTenCN.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtTenCN, "tối đa 70 ký tự, không ký tự đặc biệt");
                MessageBox.Show("Tên không hợp lệ! Vui lòng nhập không quá 70 ký tự, không chứa ký tự đặc biệt.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCN.Clear();
                txtTenCN.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtTenCN, "");
            txtTenCN.BackColor = Color.White;
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errorProvider1.SetError(txtDiaChi, "");
                txtDiaChi.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng địa chỉ
            if (!test.KiemTraDinhDangDiaChi(txtDiaChi.Text))
            {
                txtDiaChi.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtDiaChi, "tối đa 100 ký tự, không ký tự đặc biệt");
                MessageBox.Show("Địa chỉ không hợp lệ! Vui lòng nhập không quá 100 ký tự.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Clear();
                txtDiaChi.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtDiaChi, "");
            txtDiaChi.BackColor = Color.White;
        }

        private void txtSDTCN_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtSDTCN.Text))
            {
                errorProvider1.SetError(txtSDTCN, "");
                txtSDTCN.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng SDT
            if (!test.KiemTraDinhDangSDT(txtSDTCN.Text))
            {
                txtSDTCN.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtSDTCN, "SDT phải gồm 10 chữ số hợp lệ.");
                MessageBox.Show("Số Điện Thoại không hợp lệ hoặc đã tồn tại! Vui lòng nhập đúng 10 chữ số.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDTCN.Clear();
                txtSDTCN.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtSDTCN, "");
            txtSDTCN.BackColor = Color.White;
        }

        private void dgvChiNhanh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvChiNhanh.CurrentCell.RowIndex;
                txtMaCN.Text = dgvChiNhanh.Rows[dong].Cells[0].Value.ToString();
                txtTenCN.Text = dgvChiNhanh.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvChiNhanh.Rows[dong].Cells[2].Value.ToString();
                txtSDTCN.Text = dgvChiNhanh.Rows[dong].Cells[3].Value.ToString();
                txtMaCN.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
