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
    public partial class frmNoiQuy : Form
    {
        public frmNoiQuy()
        {
            InitializeComponent();
        }
        BUS_NoiQuy bus = new BUS_NoiQuy();
        BUS_NhanVien test = new BUS_NhanVien();
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNoiQuy_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvNoiQuy.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvNoiQuy.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvNoiQuy.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvNoiQuy.Font = new Font("Segoe UI", 10);

            // Cỡ chữ cho tiêu đề cột
            dgvNoiQuy.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvNoiQuy.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvNoiQuy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNoiQuy.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvNoiQuy.RowsDefaultCellStyle.BackColor = Color.White;
            dgvNoiQuy.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvNoiQuy.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Canh giữa dữ liệu nếu cần
            dgvNoiQuy.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNoiQuy.AllowUserToAddRows = false;//xóa dòng cuối

            dgvNoiQuy.DataSource = bus.LoadNoiQuy();
            dtpNgayBH.MaxDate = DateTime.Now;
            btnHoanTac_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool TrangThai = true;
                ET_NoiQuy et = new ET_NoiQuy(bus.MaNoiQuy(),txtTieuDe.Text,
                                                txtNoiDung.Text,dtpNgayBH.Value,
                                                decimal.Parse(txtLAP.Text),TrangThai);
                string error = "";
                if (bus.ThemNQ(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNoiQuy.DataSource = bus.LoadNoiQuy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaNQ.Clear();
            txtTieuDe.Clear();
            txtNoiDung.Clear();
            dtpNgayBH.Value = dtpNgayBH.MaxDate;
            txtLAP.Clear();
            txtTieuDe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool TrangThai = true;
                ET_NoiQuy et = new ET_NoiQuy(bus.MaNoiQuy(), txtTieuDe.Text,
                                                txtNoiDung.Text, dtpNgayBH.Value,
                                                decimal.Parse(txtLAP.Text), TrangThai);
                string error = "";
                if (bus.CapNhatNQ(et, out error) == true)
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNoiQuy.DataSource = bus.LoadNoiQuy();
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
                    bool TrangThai = false;
                    ET_NoiQuy et = new ET_NoiQuy(bus.MaNoiQuy(), txtTieuDe.Text,
                                                txtNoiDung.Text, dtpNgayBH.Value,
                                                decimal.Parse(txtLAP.Text), TrangThai);
                    string error = "";
                    if (bus.XoaNQ(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvNoiQuy.DataSource = bus.LoadNoiQuy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNoiQuy_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNoiQuy.CurrentCell.RowIndex;
                txtMaNQ.Text = dgvNoiQuy.Rows[dong].Cells[0].Value.ToString();
                txtTieuDe.Text = dgvNoiQuy.Rows[dong].Cells[1].Value.ToString();
                txtNoiDung.Text = dgvNoiQuy.Rows[dong].Cells[2].Value.ToString();
                dtpNgayBH.Text = dgvNoiQuy.Rows[dong].Cells[3].Value.ToString();
                txtLAP.Text = dgvNoiQuy.Rows[dong].Cells[4].Value.ToString();
                txtMaNQ.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void txtTieuDe_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                txtTieuDe.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng tiêu đề
            if (!test.KiemTraDinhDangTen(txtTieuDe.Text))
            {
                txtTieuDe.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                MessageBox.Show("Tiêu đề không hợp lệ! Vui lòng nhập không quá 70 ký tự, không chứa ký tự đặc biệt.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieuDe.Focus();
                return;
            }

            // Nếu hợp lệ
            txtTieuDe.BackColor = Color.White;
        }

        private void txtLAP_Leave(object sender, EventArgs e)
        {
            string text = txtLAP.Text.Trim().ToUpper();
            // Nếu để trống thì không kiểm tra
            if (string.IsNullOrWhiteSpace(text))
            {
                txtLAP.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng loại áp dụng (ví dụ: "Phạt 50.000đ/lần")
            if (!bus.KiemTraDinhDangLoaiApDung(text))
            {
                txtLAP.BackColor = Color.MistyRose;
                MessageBox.Show("Loại áp dụng không hợp lệ!\nVD hợp lệ: 50.000 hoặc 100000.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLAP.Focus();
                return;
            }

            // Nếu hợp lệ
            txtLAP.BackColor = Color.White;
        }

        private void txtNoiDung_Leave(object sender, EventArgs e)
        {

        }
    }
}
