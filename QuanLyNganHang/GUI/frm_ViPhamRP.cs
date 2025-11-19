using BUS;
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
    public partial class frm_ViPhamRP : Form
    {
        public frm_ViPhamRP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        BUS_ViPhamRP bus = new BUS_ViPhamRP();
        private void frm_ViPhamRP_Load(object sender, EventArgs e)
        {
            // Điền tháng 1 → 12
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
            }

            // Điền năm từ 2020 → năm hiện tại
            int namHienTai = DateTime.Now.Year;
            for (int y = 2020; y <= namHienTai; y++)
            {
                cboNam.Items.Add(y);
            }

            // Chọn tháng và năm hiện tại làm mặc định
            cboThang.SelectedItem = DateTime.Now.Month;
            cboNam.SelectedItem = namHienTai;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Reports.Report_ViPham rpt = new GUI.Reports.Report_ViPham();
                rpt.SetDataSource(bus.LayDSVP(txtMaNV.Text, int.Parse(cboThang.Text), int.Parse(cboNam.Text)));
                crvViPham.ReportSource = rpt;
                crvViPham.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
