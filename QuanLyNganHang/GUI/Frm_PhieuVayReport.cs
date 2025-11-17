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
    public partial class Frm_PhieuVayReport : Form
    {
        public Frm_PhieuVayReport()
        {
            InitializeComponent();
        }   

        BUS_KhoanVayRP bUS_KhoanVay = new BUS_KhoanVayRP();

        private void Frm_PhieuVayReport_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            Clear();
        }

        public void Clear()
        {
            txt_timkiem.Clear();
            GUI.Reports.Report_PhieuVay rpt = new GUI.Reports.Report_PhieuVay();
            rpt.SetDataSource(bUS_KhoanVay.LoadDSKV());
            crp_khoanvay.ReportSource = rpt;
            crp_khoanvay.Refresh();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Reports.Report_PhieuVay rpt = new GUI.Reports.Report_PhieuVay();
                rpt.SetDataSource(bUS_KhoanVay.TimRPKV(txt_timkiem.Text));
                crp_khoanvay.ReportSource = rpt;
                crp_khoanvay.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
