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
    public partial class frmKhoanVay : Form
    {
        public frmKhoanVay()
        {
            InitializeComponent();
        }

        BUS_KhoanVay bUS_KhoanVay = new BUS_KhoanVay();

        private void frmKhoanVay_Load(object sender, EventArgs e)
        {
            dgvmakh.DataSource = bUS_KhoanVay.LoadDSKhachHang();
            dgvtaikhoan.DataSource = bUS_KhoanVay.LoadDSTaiKhoan();
            dgvlaisuat.DataSource = bUS_KhoanVay.LoadDSLaiSuat();
            dtpNgayVay.MaxDate = DateTime.Now;
            dtpThoiHan.MaxDate = DateTime.Now;
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
            cboTrangThai.Text = null;
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
                ET_KhoanVay kv = new ET_KhoanVay(txtMaVay.Text,
                                                 txtMaKH.Text,
                                                 txtMaTK.Text,
                                                 decimal.Parse(txtSoTienVay.Text),
                                                 dtpNgayVay.Value,
                                                 dtpThoiHan.Value,
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
                dtpNgayVay.Value = DateTime.Parse(dgvKhoanVay.Rows[dong].Cells[4].Value.ToString());
                dtpThoiHan.Value = DateTime.Parse(dgvKhoanVay.Rows[dong].Cells[5].Value.ToString());
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
                    MessageBox.Show("Ẩn khoản vay thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Ẩn khoản vay thất bại!");
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
    }
}
