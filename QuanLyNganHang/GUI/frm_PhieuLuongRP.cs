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
    public partial class frm_PhieuLuongRP : Form
    {
        public frm_PhieuLuongRP()
        {
            InitializeComponent();
        }
        BUS_PhieuLuong bus = new BUS_PhieuLuong();
        BUS_BangLuong busbl=new BUS_BangLuong();
        BUS_ViPham busvp=new BUS_ViPham();
        private void frm_PhieuLuongRP_Load(object sender, EventArgs e)
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
            cboNam.SelectedItem = namHienTai;

            AddToCombo(busvp.LoadNV(), cboMaNV);
            btnNew_Click(sender, e);
        }

        private void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(cboKieu.Text == "Bảng Lương")
                {
                    GUI.Reports.Report_BangLuongTong rpt = new GUI.Reports.Report_BangLuongTong();
                    rpt.SetDataSource(busbl.LayBangLuongNhanVien(int.Parse(cboThang.Text), int.Parse(cboNam.Text)));
                    crvPhieuLuong.ReportSource = rpt;
                    crvPhieuLuong.Refresh();
                }
                else
                {
                    GUI.Reports.Report_PhieuLuong rpt = new GUI.Reports.Report_PhieuLuong();
                    rpt.SetDataSource(bus.LayPhieuLuongNhanVien(busvp.LayMa(cboMaNV.Text), int.Parse(cboThang.Text), int.Parse(cboNam.Text)));
                    crvPhieuLuong.ReportSource = rpt;
                    crvPhieuLuong.Refresh();
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cboKieu_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboKieu.Text == "Phiếu Lương")
            {
                label2.Visible = true;
                cboMaNV.Visible = true;
            }
            else
            {
                label2.Visible = false;
                cboMaNV.Visible = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboKieu.SelectedIndex = 0;
            cboMaNV.SelectedIndex = 0;
            label2.Visible = false;
            cboMaNV.Visible = false;
            // Chọn tháng và năm hiện tại làm mặc định
            cboThang.SelectedItem = DateTime.Now.Month;
            cboNam.SelectedItem = DateTime.Now.Year;
        }
    }
}
