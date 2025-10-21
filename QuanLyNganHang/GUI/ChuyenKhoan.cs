using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace GUI
{
    public partial class frmChuyenKhoan : Form
    {
        public frmChuyenKhoan()
        {
            InitializeComponent();
        }
        
        BUS_ChuyenKhoan bUS_ChuyenKhoan = new BUS_ChuyenKhoan();
        private void frmChuyenKhoan_Load(object sender, EventArgs e)
        {
            dgvmakh.DataSource = bUS_ChuyenKhoan.LoadDSKhachHang();
            dgvmatk.DataSource = bUS_ChuyenKhoan.LoadDSTaiKhoan();
            dgvmatkgui.DataSource = bUS_ChuyenKhoan.LoadDSTaiKhoan();
            dgvmatknhan.DataSource = bUS_ChuyenKhoan.LoadDSTaiKhoan();
            dtpNgayChuyen.MaxDate = DateTime.Now;
            HienThiDS();
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_An.Visible = true;
                btn_HuyAn.Visible = true;
                dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
                btnxoauser.Visible = false;
            }
            else
            {
                dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoanUser();
                dgvChuyenKhoan.Columns["TinhTrangXoa"].Visible = false;
                btnxoauser.Visible = true;
            }
            dgvChuyenKhoan.Columns["KHACHHANG"].Visible = false;
            dgvChuyenKhoan.Columns["TAIKHOAN"].Visible = false;
        }

        public void Clear()
        {
            txtMaCK.Clear();
            txtSoTien.Clear();
            rtxtND.Clear();
            txtMaKH.Clear();
            txtMaTK.Clear();
            txtMaTKGui.Clear();
            txtMaTKNhan.Clear();
            dtpNgayChuyen.Text = null;
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
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       txtMaTK.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       txtMaTKGui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                if (bUS_ChuyenKhoan.ThemCK(ck) == true)
                {
                    MessageBox.Show("Thêm chuyển khoản thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm chuyển khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       txtMaTK.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       txtMaTKGui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                if (bUS_ChuyenKhoan.SuaCK(ck) == true)
                {
                    MessageBox.Show("Sửa chuyển khoản thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa chuyển khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                           txtMaKH.Text,
                                                           txtMaTK.Text,
                                                           dtpNgayChuyen.Value,
                                                           decimal.Parse(txtSoTien.Text),
                                                           txtMaTKGui.Text,
                                                           txtMaTKNhan.Text,
                                                           rtxtND.Text, 
                                                           TrangThai);
                    if (bUS_ChuyenKhoan.XoaCK(ck) == true)
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
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
        }

        private void dgvChuyenKhoan_Click_1(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvChuyenKhoan.CurrentCell.RowIndex;
                txtMaCK.Text = dgvChuyenKhoan.Rows[dong].Cells[0].Value.ToString();
                txtMaKH.Text = dgvChuyenKhoan.Rows[dong].Cells[1].Value.ToString();
                txtMaTK.Text = dgvChuyenKhoan.Rows[dong].Cells[2].Value.ToString();                
                dtpNgayChuyen.Value = DateTime.Parse(dgvChuyenKhoan.Rows[dong].Cells[3].Value.ToString());
                txtSoTien.Text = dgvChuyenKhoan.Rows[dong].Cells[4].Value.ToString();
                txtMaTKGui.Text = dgvChuyenKhoan.Rows[dong].Cells[5].Value.ToString();
                txtMaTKNhan.Text = dgvChuyenKhoan.Rows[dong].Cells[6].Value.ToString();
                rtxtND.Text = dgvChuyenKhoan.Rows[dong].Cells[7].Value.ToString();
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

        private void dgvmatk_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmatk.CurrentCell.RowIndex;
                txtMaTK.Text = dgvmatk.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvmatknhan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmatknhan.CurrentCell.RowIndex;
                txtMaTKNhan.Text = dgvmatknhan.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvmatkgui_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmatkgui.CurrentCell.RowIndex;
                txtMaTKGui.Text = dgvmatkgui.Rows[dong].Cells[0].Value.ToString();
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
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       txtMaTK.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       txtMaTKGui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                if (bUS_ChuyenKhoan.TrangThaiAn(ck) == true)
                {
                    MessageBox.Show("Ẩn chuyển khoản thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Ẩn chuyển khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
        }

        private void btnxoauser_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       txtMaTK.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       txtMaTKGui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                    if (bUS_ChuyenKhoan.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa chuyển khoản thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chuyển khoản thất bại!");
                    }
                }                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoanUser();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       txtMaTK.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       txtMaTKGui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                if (bUS_ChuyenKhoan.TrangThaiAn(ck) == true)
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
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
        }
    }
}
