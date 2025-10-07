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
    public partial class Frm_HopDong : Form
    {
        public Frm_HopDong()
        {
            InitializeComponent();
        }

        private void PB_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PB_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void PB_Resize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Cutom_Resize()
        {
            int width = this.Width;
            int height = this.Height;
            panel_ThongTin1.Location = new Point(4, 54);
            panel_HopDong.Size = new Size(width - 537, height - 54);
            dgv_HopDong.Size = new Size(panel_HopDong.Width + 300, panel_HopDong.Height + 300);
            panel_HopDong.Location = new Point(537, 54);
        }

        private void Frm_HopDong_Load(object sender, EventArgs e)
        {
            Cutom_Resize();
        }

        private void Frm_HopDong_Resize(object sender, EventArgs e)
        {
            Cutom_Resize();
        }
    }
}
