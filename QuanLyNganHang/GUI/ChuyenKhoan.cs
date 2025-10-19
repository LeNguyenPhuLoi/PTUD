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
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
            dtpNgayChuyen.MaxDate = DateTime.Now;
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
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       txtMaTK.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       txtMaTKGui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text);
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
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       txtMaTK.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       txtMaTKGui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text);
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
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
