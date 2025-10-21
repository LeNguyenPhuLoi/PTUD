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
                ET_LaiSuat ls = new ET_LaiSuat(txtMaLS.Text,
                                               txtTenLoai.Text,
                                               decimal.Parse(txtLaiSuat.Text),
                                               cboKL.Text);
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
                ET_LaiSuat ls = new ET_LaiSuat(txtMaLS.Text,
                                               txtTenLoai.Text,
                                               decimal.Parse(txtLaiSuat.Text),
                                               cboKL.Text);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_LaiSuat ls = new ET_LaiSuat(txtMaLS.Text,
                                                   txtTenLoai.Text,
                                                   decimal.Parse(txtLaiSuat.Text),
                                                   cboKL.Text);
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
    }
}
