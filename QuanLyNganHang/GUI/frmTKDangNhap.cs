using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class frmTKDangNhap : Form
    {
        public frmTKDangNhap()
        {
            InitializeComponent();
        }
        BUS_TKDangNhap bustkdn = new BUS_TKDangNhap();
        BUS_NhanVien test = new BUS_NhanVien();
        private void frmTKDangNhap_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvTaiKhoanDangNhap.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvTaiKhoanDangNhap.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvTaiKhoanDangNhap.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvTaiKhoanDangNhap.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvTaiKhoanDangNhap.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvTaiKhoanDangNhap.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvTaiKhoanDangNhap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTaiKhoanDangNhap.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvTaiKhoanDangNhap.RowsDefaultCellStyle.BackColor = Color.White;
            dgvTaiKhoanDangNhap.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvTaiKhoanDangNhap.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvTaiKhoanDangNhap.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTaiKhoanDangNhap.AllowUserToAddRows = false;//xóa dòng cuối

            dgvTaiKhoanDangNhap.DataSource = bustkdn.LoadTKL();
            dgvMaNV.DataSource = bustkdn.LoadDSNV();
            btn_Lammoi_Click(sender, e);
        }

        private void dgvMaNV_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvMaNV.CurrentRow.Index;
                txtMaNV.Text = dgvMaNV.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTaiKhoanDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvTaiKhoanDangNhap.CurrentRow.Index;
                txtMaDangNhap.Text = dgvTaiKhoanDangNhap.Rows[dong].Cells[0].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoanDangNhap.Rows[dong].Cells[1].Value.ToString();
                cboQuyen.Text = dgvTaiKhoanDangNhap.Rows[dong].Cells[2].Value.ToString();
                txtMaNV.Text = dgvTaiKhoanDangNhap.Rows[dong].Cells[3].Value.ToString();
                txtMaDangNhap.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtMatKhau.Clear();
            cboQuyen.SelectedIndex = 0;
            txtMaDangNhap.Clear();
            txtMaDangNhap.Focus();
            txtMaDangNhap.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai = true;
                ET_TaiKhhoanDangNhap et = new ET_TaiKhhoanDangNhap(txtMaDangNhap.Text, txtMatKhau.Text,
                                             cboQuyen.Text, txtMaNV.Text,trangthai);
                string error = "";
                if (bustkdn.ThemTKL(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Lammoi.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvTaiKhoanDangNhap.DataSource = bustkdn.LoadTKL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:"+ ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai = true;
                ET_TaiKhhoanDangNhap et = new ET_TaiKhhoanDangNhap(txtMaDangNhap.Text, txtMatKhau.Text,
                                             cboQuyen.Text, txtMaNV.Text, trangthai);
                string error = "";
                if (bustkdn.CapNhatTKL(et, out error) == true)
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvTaiKhoanDangNhap.DataSource = bustkdn.LoadTKL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool trangthai = false;
                    ET_TaiKhhoanDangNhap et = new ET_TaiKhhoanDangNhap(txtMaDangNhap.Text, txtMatKhau.Text,
                                                 cboQuyen.Text, txtMaNV.Text, trangthai);
                    string error = "";
                    if (bustkdn.XoaTKL(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Lammoi.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvTaiKhoanDangNhap.DataSource = bustkdn.LoadTKL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không kiểm tra, trả về màu mặc định
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.BackColor = Color.White;
                return;
            }

            // Gọi hàm kiểm tra định dạng mật khẩu
            if (!bustkdn.KiemTraDinhDangMK(txtMatKhau.Text))
            {
                txtMatKhau.BackColor = Color.MistyRose; // tô nhẹ để báo lỗi
                MessageBox.Show("Mật khẩu không hợp lệ!\nĐịnh dạng hợp lệ: chữ + @ + số (VD: an@123).",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            // Nếu hợp lệ thì trở về màu bình thường
            txtMatKhau.BackColor = Color.White;
        }

        private void txtMaDangNhap_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không kiểm tra, trả về màu mặc định
            if (string.IsNullOrWhiteSpace(txtMaDangNhap.Text))
            {
                txtMaDangNhap.BackColor = Color.White;
                return;
            }

            // Gọi hàm kiểm tra định dạng tên đăng nhập
            if (!test.KiemTraDinhDangTen(txtMaDangNhap.Text))
            {
                txtMaDangNhap.BackColor = Color.MistyRose; // tô nhẹ để báo lỗi
                MessageBox.Show("Tên Đăng Nhập không hợp lệ!\n VD: anlt",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDangNhap.Focus();
                return;
            }

            // Nếu hợp lệ thì trở về màu bình thường
            txtMaDangNhap.BackColor = Color.White;
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim().ToUpper();

            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(maNV))
            {
                errorProvider1.SetError(txtMaNV, "");
                txtMaNV.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng mã nhân viên
            if (!test.KiemTraDinhDangMaNV(maNV))
            {
                txtMaNV.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtMaNV, "Mã nhân viên không hợp lệ! (VD: NV001, NV12345)");
                MessageBox.Show("Mã nhân viên phải có dạng NV + 3-8 chữ số (VD: NV001, NV12345).",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtMaNV, "");
            txtMaNV.BackColor = Color.White;
        }
    }
}
