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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
            
        }
        BUS_PhongBan bus= new BUS_PhongBan();
        BUS_NhanVien test = new BUS_NhanVien();
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvPhongBan.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvPhongBan.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvPhongBan.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvPhongBan.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvPhongBan.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvPhongBan.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvPhongBan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPhongBan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvPhongBan.RowsDefaultCellStyle.BackColor = Color.White;
            dgvPhongBan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvPhongBan.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvPhongBan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPhongBan.DataSource = bus.LoadDSPhongBan();
            btnHoanTac_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai = true;
                ET_PhongBan et = new ET_PhongBan(bus.MaPB(), txtTenPB.Text, trangthai);
                string error = "";
                if (bus.ThemPhongBan(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvPhongBan.DataSource = bus.LoadDSPhongBan();
                dgvPhongBan.Sort(dgvPhongBan.Columns["MAPB"], ListSortDirection.Ascending);
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
                bool trangthai = true;
                ET_PhongBan et = new ET_PhongBan(int.Parse(txtMaPB.Text), txtTenPB.Text, trangthai);
                string error = "";
                if (bus.CapNhatPhongBan(et, out error) == true)
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvPhongBan.DataSource = bus.LoadDSPhongBan();
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
                    bool trangthai = true;
                    ET_PhongBan et = new ET_PhongBan(int.Parse(txtMaPB.Text), txtTenPB.Text, trangthai);
                    string error = "";
                    if (bus.XoaPhongBan(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvPhongBan.DataSource = bus.LoadDSPhongBan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtTenPB.Clear();
            txtMaPB.Clear();
            txtMaPB.Focus();
            txtMaPB.Enabled = false;
            dgvPhongBan.DataSource = bus.LoadDSPhongBan();
            dgvPhongBan.Sort(dgvPhongBan.Columns["MAPB"], ListSortDirection.Ascending);
        }

        private void dgvPhongBan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvPhongBan.CurrentCell.RowIndex;
                txtMaPB.Text = dgvPhongBan.Rows[dong].Cells[0].Value.ToString();
                txtTenPB.Text = dgvPhongBan.Rows[dong].Cells[1].Value.ToString();
                txtMaPB.Enabled = false;
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

        private void txtTenPB_Leave(object sender, EventArgs e)
        {
            string pb = txtTenPB.Text.Trim().ToUpper();
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(pb))
            {
                errorProvider1.SetError(txtTenPB, "");
                txtTenPB.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng tên phòng ban
            if (!test.KiemTraDinhDangTen(pb))
            {
                txtTenPB.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtTenPB, "tối đa 70 ký tự, không ký tự đặc biệt");
                MessageBox.Show("Tên không được chứa ký tự đặc biệt hoặc tồn tại! Vui lòng nhập lại.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPB.Clear();
                txtTenPB.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtTenPB, "");
            txtTenPB.BackColor = Color.White;
        }

        private void txtMaPB_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtMaPB.Text))
            {
                errorProvider1.SetError(txtMaPB, ""); // Xóa lỗi
                txtMaPB.BackColor = Color.White; // Trả lại màu bình thường
                return;
            }

            //Ktra nhập có đúng định dạng số không
            if (!test.KiemTraDinhDangSo(txtMaPB.Text))
            {
                txtMaPB.BackColor = Color.LightPink; // Highlight đỏ hồng khi sai
                errorProvider1.SetError(txtMaPB, "Vui lòng nhập số hợp lệ."); // hiện icon lỗi
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPB.Clear();
                txtMaPB.Focus(); // Trả lại con trỏ để sửa
            }
            else
            {
                errorProvider1.SetError(txtMaPB, ""); // Xóa icon lỗi
                txtMaPB.BackColor = Color.White; // Đúng thì trả về màu bình thường
            }
        }

    }
}
