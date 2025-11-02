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
using BUS;
using ET;

namespace GUI
{
    public partial class frmApDungKhuyenMai : Form
    {
        public frmApDungKhuyenMai()
        {
            InitializeComponent();
        }
        
        BUS_ApDungKhuyenMai bUS_ApDungKhuyenMai = new BUS_ApDungKhuyenMai();

        private void frmApDungKhuyenMai_Load(object sender, EventArgs e)
        {
            dgv_ADKM.DataSource = bUS_ApDungKhuyenMai.LoadDSADKM();
        }
    }
}
