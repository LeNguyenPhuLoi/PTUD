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
            dgvKhoanVay.DataSource = bUS_KhoanVay.LoadDSKhoanVay();
            dtpNgayVay.MaxDate = DateTime.Now;
            dtpThoiHan.MaxDate = DateTime.Now;
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
                ET_KhoanVay kv = new ET_KhoanVay(txtMaVay.Text,
                                                 txtMaKH.Text,
                                                 txtMaTK.Text,
                                                 decimal.Parse(txtSoTienVay.Text),
                                                 dtpNgayVay.Value,
                                                 dtpThoiHan.Value,
                                                 cboTrangThai.Text,
                                                 txtMaLS.Text);
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
                ET_KhoanVay kv = new ET_KhoanVay(txtMaVay.Text,
                                                 txtMaKH.Text,
                                                 txtMaTK.Text,
                                                 decimal.Parse(txtSoTienVay.Text),
                                                 dtpNgayVay.Value,
                                                 dtpThoiHan.Value,
                                                 cboTrangThai.Text,
                                                 txtMaLS.Text);
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

        }
    }
}
