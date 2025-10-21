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
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        BUS_KhuyenMai bUS_KhuyenMai = new BUS_KhuyenMai();

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
            dtNgayBatDau.MaxDate = DateTime.Now;
            dtNgayKetThuc.MaxDate = DateTime.Now;
        }

        public void Clear()
        {
            txtMaKM.Clear();
            txtTenKM.Clear();
            rtxtMota.Clear();
            dtNgayBatDau.MaxDate = DateTime.Now;
            dtNgayKetThuc.MaxDate= DateTime.Now;
            rtxtDKAD.Clear();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhuyenMai km = new ET_KhuyenMai(txtMaKM.Text,
                                                   txtTenKM.Text,
                                                   rtxtMota.Text,
                                                   dtNgayBatDau.Value,
                                                   dtNgayKetThuc.Value,
                                                   rtxtDKAD.Text);
                if (bUS_KhuyenMai.ThemKM(km) == true)
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm khuyến mãi thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhuyenMai km = new ET_KhuyenMai(txtMaKM.Text,
                                                   txtTenKM.Text,
                                                   rtxtMota.Text,
                                                   dtNgayBatDau.Value,
                                                   dtNgayKetThuc.Value,
                                                   rtxtDKAD.Text);
                if (bUS_KhuyenMai.SuaKM(km) == true)
                {
                    MessageBox.Show("Sửa khuyến mãi thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa khuyến mãi thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_KhuyenMai km = new ET_KhuyenMai(txtMaKM.Text,
                                                       txtTenKM.Text,
                                                       rtxtMota.Text,
                                                       dtNgayBatDau.Value,
                                                       dtNgayKetThuc.Value,
                                                       rtxtDKAD.Text);
                    if (bUS_KhuyenMai.XoaKM(km) == true)
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
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
        }

        private void dgvKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhuyenMai.CurrentCell.RowIndex;
                txtMaKM.Text = dgvKhuyenMai.Rows[dong].Cells[0].Value.ToString();
                txtTenKM.Text = dgvKhuyenMai.Rows[dong].Cells[1].Value.ToString();
                rtxtMota.Text = dgvKhuyenMai.Rows[dong].Cells[2].Value.ToString();
                dtNgayBatDau.Value = DateTime.Parse(dgvKhuyenMai.Rows[dong].Cells[3].Value.ToString());
                dtNgayKetThuc.Value = DateTime.Parse(dgvKhuyenMai.Rows[dong].Cells[4].Value.ToString());
                rtxtDKAD.Text = dgvKhuyenMai.Rows[dong].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
