using BUS;
using CrystalDecisions.CrystalReports.Engine;
using ET;
using GUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_Report_GiaoDich : Form
    {
        public Frm_Report_GiaoDich()
        {
            InitializeComponent();
        }

        BUS_GiaoDich_Report BUS_GiaoDich_Report = new BUS_GiaoDich_Report();

        private void Frm_Report_GiaoDich_Load(object sender, EventArgs e)
        {
            dtpNgayGiaoDich.MaxDate = DateTime.Now;
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

        private void Frm_Report_GiaoDich_Resize(object sender, EventArgs e)
        {
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            List<ET_GiaoDich_Report_ThongTinKhachHang> lstThongTin = BUS_GiaoDich_Report.LayThongTinKhachHang(txt_SoTk.Text,Convert.ToDateTime(dtpNgayGiaoDich.Value));
            List<ET_GiaoDich_Report_ChiTietGiaoDich> lstChiTiet = BUS_GiaoDich_Report.LayChiTietGiaoDich(txt_SoTk.Text, Convert.ToDateTime(dtpNgayGiaoDich.Value)); ;

            GiaoDich_DataSet data = new GiaoDich_DataSet();
            var ttkh = data.ThongTinKhachHang;
            foreach (var item in lstThongTin) 
            {
                ttkh.AddThongTinKhachHangRow(
                    item.MaKh,
                    item.TenKh,
                    item.SoTk,
                    item.LoaiTK,
                    Convert.ToString(item.NgayGiaoDich)
                    );
            }

            var ctgd = data.ChiTietGiaoDich;
            foreach (var item in lstChiTiet)
            {
                ctgd.AddChiTietGiaoDichRow(
                    item.MaGd,
                    item.LoaiGd,
                    Convert.ToString(item.Sotien),
                    item.NoiDung
                );
            }

            GUI.Reports.Report_GiaoDich rpt = new GUI.Reports.Report_GiaoDich();
            rpt.SetDataSource(data);
            crv_GiaoDich.ReportSource = rpt;
            crv_GiaoDich.Refresh();
        }

        //hàm kiểm tra định dạng số tài khoản (chuỗi 10 chữ số, không chữ, không ký tự đặc biệt, không khoảng trắng)
        private bool KiemTraDinhDangSTK(string stk)
        {
            bool flag = false;
            string pattern = @"^\d{10}$";
            if (string.IsNullOrWhiteSpace(stk))
                return flag;
            if (Regex.IsMatch(stk.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            txt_SoTk.Clear();
            txt_SoTk.BackColor = SystemColors.Window;
            dtpNgayGiaoDich.Value = dtpNgayGiaoDich.MaxDate;
            GiaoDich_DataSet data = new GiaoDich_DataSet();
            GUI.Reports.Report_GiaoDich rpt = new GUI.Reports.Report_GiaoDich();
            rpt.SetDataSource(data);
            crv_GiaoDich.ReportSource = rpt;
            crv_GiaoDich.Refresh();
        }

        private void txt_SoTk_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangSTK(txt_SoTk.Text))
            {
                txt_SoTk.BackColor = Color.LightCoral;
            }
            else
            {
                txt_SoTk.BackColor = SystemColors.Window;
            }
        }
    }
}
