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
    public partial class frmNoiQuy : Form
    {
        public frmNoiQuy()
        {
            InitializeComponent();
        }
        BUS_NoiQuy bus = new BUS_NoiQuy();
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNoiQuy_Load(object sender, EventArgs e)
        {
            dgvNoiQuy.DataSource = bus.LoadNoiQuy();
            dtpNgayBH.MaxDate = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool TrangThai = true;
                ET_NoiQuy et = new ET_NoiQuy(bus.MaNoiQuy(),txtTieuDe.Text,
                                                txtNoiDung.Text,dtpNgayBH.Value,
                                                cboLoai.Text,TrangThai);
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
            cboLoai.SelectedIndex = 0;
            txtTieuDe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool TrangThai = true;
                ET_NoiQuy et = new ET_NoiQuy(bus.MaNoiQuy(), txtTieuDe.Text,
                                                txtNoiDung.Text, dtpNgayBH.Value,
                                                cboLoai.Text, TrangThai);
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
                                                    cboLoai.Text, TrangThai);
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
                cboLoai.Text = dgvNoiQuy.Rows[dong].Cells[4].Value.ToString();
                txtMaNQ.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
