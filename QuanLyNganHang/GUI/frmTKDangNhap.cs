using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmTKDangNhap : Form
    {
        public frmTKDangNhap()
        {
            InitializeComponent();
        }
        BUS_TKDangNhap bustkdn = new BUS_TKDangNhap();

        private void frmTKDangNhap_Load(object sender, EventArgs e)
        {
            dgvTaiKhoanDangNhap.DataSource = bustkdn.LoadTKL();
            dgvMaNV.DataSource = bustkdn.LoadDSNV();
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai = true;
                ET_TaiKhhoanDangNhap et = new ET_TaiKhhoanDangNhap(txtMaDangNhap.Text, txtMatKhau.Text,
                                             cboQuyen.Text, txtMaNV.Text,trangthai);
                if (bustkdn.ThemTKL(et) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Lammoi.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (bustkdn.CapNhatTKL(et) == true)
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CCập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bool trangthai = false;
                ET_TaiKhhoanDangNhap et = new ET_TaiKhhoanDangNhap(txtMaDangNhap.Text, txtMatKhau.Text,
                                             cboQuyen.Text, txtMaNV.Text, trangthai);
                string error = "";
                if (bustkdn.XoaTKL(et,out error) == true)
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
