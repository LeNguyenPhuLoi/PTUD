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
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_ENTERSIZEMOVE = 0x0231;
            const int WM_EXITSIZEMOVE = 0x0232;

            if (m.Msg == WM_ENTERSIZEMOVE)
            {
                this.SuspendLayout(); // Bắt đầu kéo form → dừng layout
            }
            else if (m.Msg == WM_EXITSIZEMOVE)
            {
                this.ResumeLayout();  // Kết thúc kéo form → resume lại layout
            }

            base.WndProc(ref m);
        }



        private void KhoanVay_Load(object sender, EventArgs e)
        {

        }

        // Thêm dữ liệu vào ComboBox
        public void AddToCombo(IQueryable list, ComboBox c)
        {

        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvKhoanVay_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvLaiSuat_Click(object sender, EventArgs e)
        {
        }


        private void TinhSoThang()
        {
            
        }

        private void dtpNgayVay_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpThoiHan_ValueChanged(object sender, EventArgs e)
        {
        }

        private void TinhTienKhoanVay()
        {
            
        }

        

        private void txtMaLaiSuat_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void txtSoTienVay_Leave(object sender, EventArgs e)
        {
        }

        private void txtSoTienVay_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
