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
    public partial class Frm_Report_GiaoDich : Form
    {
        public Frm_Report_GiaoDich()
        {
            InitializeComponent();
        }

        private void Frm_Report_GiaoDich_Load(object sender, EventArgs e)
        {
            Cutom_Resize();
        }

        private void PB_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PB_Resize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void PB_Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Cutom_Resize()
        {
            int width = this.Width;
            int height = this.Height;
            lbl_Title.Location = new Point(width / 2 - 163, 0);
            panel_Tim.Location = new Point(4, 54);
            crv_GiaoDich.Height = height - 121;
        }

        private void Frm_Report_GiaoDich_Resize(object sender, EventArgs e)
        {
            Cutom_Resize();
        }
    }
}
