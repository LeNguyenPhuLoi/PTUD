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
    public partial class Frm_GiaoDich : Form
    {
        public Frm_GiaoDich()
        {
            InitializeComponent();
        }

        private void Re_size()
        {
            dgv_KhachHang.Size = new Size(dgv_KhachHang.Width + 300,dgv_KhachHang.Height + 300);
            dgv_GiaoDich.Size = new Size(panel_GiaoDich.Width + 300, dgv_GiaoDich.Height + 300);
        }

        private void Frm_GiaoDich_Load(object sender, EventArgs e)
        {
            Re_size();
        }

        private void Frm_GiaoDich_Resize(object sender, EventArgs e)
        {
            Re_size();
        }
    }
}
