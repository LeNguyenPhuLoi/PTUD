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

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien bUS = new BUS_NhanVien();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvNhanVien.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvNhanVien.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvNhanVien.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvNhanVien.RowsDefaultCellStyle.BackColor = Color.White;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvNhanVien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



            dgvNhanVien.DataSource = bUS.LoadDSNV();
            AddToCombo(bUS.LoadDSPB(), cboMaPB);
            AddToCombo(bUS.LoadDSCN(), cboMaCN);
            btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
        }

        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        public string LayGioiTinh()
        {
            if (rdoNam.Checked == true)
            {
                return "NAM";
            }
            else
            {
                return "NỮ";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text,
                                                    LayGioiTinh(), dtpNgaySinh.Value,
                                                    decimal.Parse(txtCCCD.Text),
                                                    cboChuc.Text, float.Parse(txtLuong.Text),
                                                    rtxDiaChi.Text, int.Parse(txtSDT.Text),
                                                    bUS.LayMaPB(cboMaPB.Text), bUS.LayMaCN(cboMaCN.Text),
                                                    TrangThai);
                string error = "";
                if (bUS.ThemNhanVien(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNhanVien.DataSource = bUS.LoadDSNV();
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
                string TrangThai = "Hoạt Động";
                ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text,
                                                    LayGioiTinh(), dtpNgaySinh.Value,
                                                    decimal.Parse(txtCCCD.Text),
                                                    cboChuc.Text, float.Parse(txtLuong.Text),
                                                    rtxDiaChi.Text, int.Parse(txtSDT.Text),
                                                    bUS.LayMaPB(cboMaPB.Text), bUS.LayMaCN(cboMaCN.Text),
                                                    TrangThai);
                string error = "";
                if (bUS.CapNhatNhanVien(et, out error) == true)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNhanVien.DataSource = bUS.LoadDSNV();
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
                    string TrangThai = "Nghỉ Việc";
                    ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text,
                                                        LayGioiTinh(), dtpNgaySinh.Value,
                                                        decimal.Parse(txtCCCD.Text),
                                                        cboChuc.Text, float.Parse(txtLuong.Text),
                                                        rtxDiaChi.Text, int.Parse(txtSDT.Text),
                                                        bUS.LayMaPB(cboMaPB.Text), bUS.LayMaCN(cboMaCN.Text),
                                                        TrangThai);
                    string error = "";
                    if (bUS.XoaNhanVien(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvNhanVien.DataSource = bUS.LoadDSNV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtLuong.Clear();
            txtSDT.Clear();
            txtTenNV.Clear();
            rdoNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            cboChuc.SelectedIndex = -1;
            txtCCCD.Clear();
            rtxDiaChi.Clear();
            txtSDT.Clear();
            cboMaPB.SelectedIndex = -1;
            cboMaCN.SelectedIndex = -1;
            txtMaNV.Focus();
            dgvNhanVien.DataSource = bUS.LoadDSNV();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
                if (dgvNhanVien.Rows[dong].Cells[2].Value.ToString() == "NAM")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dtpNgaySinh.Text = dgvNhanVien.Rows[dong].Cells[3].Value.ToString();
                txtCCCD.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString();
                cboChuc.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
                rtxDiaChi.Text = dgvNhanVien.Rows[dong].Cells[7].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[dong].Cells[8].Value.ToString();
                cboMaPB.Text = dgvNhanVien.Rows[dong].Cells[9].Value.ToString();
                cboMaCN.Text = dgvNhanVien.Rows[dong].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
