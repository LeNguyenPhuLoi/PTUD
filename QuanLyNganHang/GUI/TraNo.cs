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
    public partial class frmLichSuTraNo : Form
    {
        public frmLichSuTraNo()
        {
            InitializeComponent();
        }

        BUS_TraNo bUS_TraNo = new BUS_TraNo();

        private void frmLichSuTraNo_Load(object sender, EventArgs e)
        {
            dgvTraNo.DataSource = bUS_TraNo.LoadDSTraNo();
        }

        
    }
}
