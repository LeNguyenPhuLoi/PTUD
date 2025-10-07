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
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        private void Re_size()
        {
            dgv_KhachHang.Size = new Size(panel_KhachHang.Width + 300, panel_KhachHang.Height + 300);
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            Re_size();
        }

        private void Frm_KhachHang_Resize(object sender, EventArgs e)
        {
            Re_size();
        }
    }
}
