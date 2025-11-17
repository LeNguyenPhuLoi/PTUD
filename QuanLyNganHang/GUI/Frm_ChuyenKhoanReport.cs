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
    public partial class Frm_ChuyenKhoanReport : Form
    {
        public Frm_ChuyenKhoanReport()
        {
            InitializeComponent();
        }

        BUS_ChuyenKhoanRP bUS_ChuyenKhoan = new BUS_ChuyenKhoanRP();

        private void Frm_ChuyenKhoanReport_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            Clear();
        }

        public void Clear()
        {
            txt_timkiem.Clear();
            GUI.Reports.Report_ChuyenKhoan rpt = new GUI.Reports.Report_ChuyenKhoan();
            rpt.SetDataSource(bUS_ChuyenKhoan.LoadDSCK());
            crp_chuyenkhoan.ReportSource = rpt;
            crp_chuyenkhoan.Refresh();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Reports.Report_ChuyenKhoan rpt = new GUI.Reports.Report_ChuyenKhoan();
                rpt.SetDataSource(bUS_ChuyenKhoan.TimRPCK(txt_timkiem.Text));
                crp_chuyenkhoan.ReportSource = rpt;
                crp_chuyenkhoan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
