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
    public partial class Frm_TaiKhoan : Form
    {
        public Frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void Re_size()
        {
            dgv_TaiKhoan.Size = new Size(panel_TaiKhoan.Width + 300, panel_TaiKhoan.Height + 300);
            dgv_KhachHang.Size = new Size(panel_KhachHang.Width + 300, panel_KhachHang.Height + 300);
        }

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            Re_size();
        }

        private void Frm_TaiKhoan_Resize(object sender, EventArgs e)
        {
            Re_size();
        }
    }
}
