using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ET;
using BUS;

namespace GUI
{
    public partial class Frm_BienLaiReport : Form
    {
        public Frm_BienLaiReport()
        {
            InitializeComponent();
        }

        BUS_BienLaiRP bUS_BienLai = new BUS_BienLaiRP();

        private void Frm_BienLaiReport_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            Clear();
        }

        public void Clear()
        {
            txt_timkiem.Clear();
            GUI.Reports.Report_BienLai rpt = new GUI.Reports.Report_BienLai();
            rpt.SetDataSource(bUS_BienLai.LoadDSBL());
            crp_bienlai.ReportSource = rpt;
            crp_bienlai.Refresh();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Reports.Report_BienLai rpt = new GUI.Reports.Report_BienLai();
                rpt.SetDataSource(bUS_BienLai.TimRPBL(txt_timkiem.Text));
                crp_bienlai.ReportSource = rpt;
                crp_bienlai.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
