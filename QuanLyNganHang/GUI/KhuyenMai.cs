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



        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvKhuyenMai.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu nền khi chọn ô (dòng)
            dgvKhuyenMai.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvKhuyenMai.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvKhuyenMai.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvKhuyenMai.RowsDefaultCellStyle.BackColor = Color.White;
            dgvKhuyenMai.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvKhuyenMai.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvKhuyenMai.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvKhuyenMai_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
