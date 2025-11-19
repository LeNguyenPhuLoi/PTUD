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
    public partial class Frm_Report_TaiKhoan : Form
    {
        public Frm_Report_TaiKhoan()
        {
            InitializeComponent();
        }

        BUS_TaiKhoan_Report BUS_TaiKhoan_Report = new BUS_TaiKhoan_Report();

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
            lbl_Title.Location = new Point(width / 2 - 166, 0);
            panel_Tim.Location = new Point(4, 54);
            crv_TaiKhoan.Height = height - 121;
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

        private void Frm_Report_TaiKhoan_Resize(object sender, EventArgs e)
        {
            Cutom_Resize();
        }

        private void Frm_Report_TaiKhoan_Load(object sender, EventArgs e)
        {
            Cutom_Resize();
            SetPlaceholder(txt_Tim,"CCCD/CMND...");
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            List<ET_TaiKhoan_Report_ThongTinKhachHang> lsttk = BUS_TaiKhoan_Report.LayThongTinKhachHang(txt_Tim.Text);
            List<ET_TaiKhoan_Report_DanhSachTaiKhoan> dstk = BUS_TaiKhoan_Report.LayDSTaiKhoan(txt_Tim.Text);

            TaiKhoan_DataSet data = new TaiKhoan_DataSet();
            var ttkh = data.KhachHang;
            foreach(var item  in lsttk)
            {
                ttkh.AddKhachHangRow(
                    item.MaKh,
                    item.TenKh,
                    item.CCCD,
                    item.SDT,
                    item.DiaChi,
                    item.Email,
                    item.QuocTich
                    );
            }

            var tttk = data.TaiKhoan;
            foreach( var item in dstk)
            {
                tttk.AddTaiKhoanRow(
                    item.MaTk,
                    item.SoTaiKhoan,
                    item.ChiTiet,
                    Convert.ToString(item.SoDu),
                    item.TrangThai
                    );
            }

            GUI.Reports.Report_TaiKhoan rpt = new GUI.Reports.Report_TaiKhoan();
            rpt.SetDataSource(data);
            crv_TaiKhoan.ReportSource = rpt;
            crv_TaiKhoan.Refresh();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            txt_Tim.Clear();
            TaiKhoan_DataSet data = new TaiKhoan_DataSet();
            GUI.Reports.Report_TaiKhoan rpt = new GUI.Reports.Report_TaiKhoan();
            rpt.SetDataSource(data);
            crv_TaiKhoan.ReportSource = rpt;
            crv_TaiKhoan.Refresh();
        }
    }
}
