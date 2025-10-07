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
    public partial class Frm_HoTro : Form
    {
        public Frm_HoTro()
        {
            InitializeComponent();
        }

        private void Cutom_Resize()
        {
            int width = this.Width;
            int height = this.Height;
            panel_ThongTin1.Location = new Point(4, 54);
            panel_HoTro.Size = new Size(width - 537, height - 54);
            dgv_HoTro.Size = new Size(panel_HoTro.Width + 300, panel_HoTro.Height + 300);
            panel_HoTro.Location = new Point(537, 54);
        }

        private void Frm_HoTro_Load(object sender, EventArgs e)
        {
            Cutom_Resize();
        }

        private void Frm_HoTro_Resize(object sender, EventArgs e)
        {
            Cutom_Resize();
        }
    }
}
