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
using GUI.Reports;

namespace GUI
{
    public partial class Frm_Report_HopDong : Form
    {
        public Frm_Report_HopDong()
        {
            InitializeComponent();
        }

        BUS_HopDong_Report BUS_HopDong_Report = new BUS_HopDong_Report();

        private void Frm_Report_HopDong_Load(object sender, EventArgs e)
        {
            Cutom_Resize();
            SetPlaceholder(txt_Tim, "Nhập số hợp đồng...");
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
            crv_HopDong.Height = height - 121;
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        private void Frm_Report_HopDong_Resize(object sender, EventArgs e)
        {
            Cutom_Resize();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            List<ET_HopDong_Report> ds = BUS_HopDong_Report.LayHopDongTheoSoHD(txt_Tim.Text);

            HopDong_DataSet data = new HopDong_DataSet();
            var tthd = data.HopDong;
            foreach (var item in ds) 
            {
                tthd.AddHopDongRow(
                    item.SoHopDong,
                    item.TenLoaiHD,
                    Convert.ToString(item.NgayKy),
                    Convert.ToString(item.NgayHetHan),
                    Convert.ToString(item.GiaTri),
                    item.TenKh,
                    item.SoTaiKhoan,
                    item.CCCD,
                    item.SDT,
                    item.DiaChi,
                    item.TenKh,
                    item.MaNv   
                    );
            }

            GUI.Reports.Report_HopDong rpt = new GUI.Reports.Report_HopDong();
            rpt.SetDataSource(data);
            crv_HopDong.ReportSource = rpt;
            crv_HopDong.Refresh();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            txt_Tim.Clear();
            SetPlaceholder(txt_Tim, "Nhập số hợp đồng...");
            txt_Tim.BackColor = SystemColors.Window;
            HopDong_DataSet data = new HopDong_DataSet();
            GUI.Reports.Report_HopDong rpt = new GUI.Reports.Report_HopDong();
            rpt.SetDataSource(data);
            crv_HopDong.ReportSource = rpt;
            crv_HopDong.Refresh();
        }
    }
}
