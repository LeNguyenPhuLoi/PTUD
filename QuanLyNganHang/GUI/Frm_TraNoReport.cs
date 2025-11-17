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
using GUI;

namespace GUI
{
    public partial class Frm_TraNoReport : Form
    {
        public Frm_TraNoReport()
        {
            InitializeComponent();
        }

        BUS_TraNoRP bUS_Trano = new BUS_TraNoRP();

        private void Frm_TraNoReport_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            Clear();
        }

        public void Clear()
        {
            txt_timkiem.Clear();
            GUI.Reports.Report_TraNo rpt = new GUI.Reports.Report_TraNo();
            rpt.SetDataSource(bUS_Trano.LoadDSTN());
            crv_trano.ReportSource = rpt;
            crv_trano.Refresh();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Reports.Report_TraNo rpt = new GUI.Reports.Report_TraNo();
                rpt.SetDataSource(bUS_Trano.TimRPTN(txt_timkiem.Text));
                crv_trano.ReportSource = rpt;
                crv_trano.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
