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
    public partial class frmMainAddmin : Form
    {
        public frmMainAddmin()
        {
            InitializeComponent();
        }

        private void frmMainAddmin_Load(object sender, EventArgs e)
        {
            tmrBannerLoop.Interval = 6000;
            tmrBannerLoop.Start();
        }

        // Biến tạm
        Form currentForm = new Form();
        private void OpenMain(Form childForm)
        {
            // Tắt form hiện tại để chuyển form mới
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            // Chỉnh sửa thuộc tính của form mới
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Đưa form mới vào main menu
            childForm.Show();
            currentForm = childForm;
            // Tắt banner, tránh chạy ngầm
            tmrBannerLoop.Stop();
            picBanner.Visible = false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            OpenMain(frm);
        }

        private void giaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GiaoDich frm = new Frm_GiaoDich();
            OpenMain(frm);
        }

        private void biênLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BienLai frm = new BienLai();
            OpenMain(frm);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang frm = new Frm_KhachHang();
            OpenMain(frm);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan frm = new Frm_TaiKhoan();
            OpenMain(frm);
        }

        private void loạiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LoaiTaiKhoan frm = new Frm_LoaiTaiKhoan();
            OpenMain(frm);
        }

        private void tiềnTệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NgoaiTe frm = new NgoaiTe();
            OpenMain(frm);
        }

        private void chuyểnKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuyenKhoan frm = new frmChuyenKhoan();
            OpenMain(frm);
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            OpenMain(frm);
        }

        private void nộiQuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoiQuy frm = new frmNoiQuy();
            OpenMain(frm);
        }

        private void viPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViPham frm = new frmViPham();
            OpenMain(frm);
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiNhanh frm = new frmChiNhanh();
            OpenMain(frm);
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhuyenMai frm = new frmKhuyenMai();
            OpenMain(frm);
        }

        private void ápDụngKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApDungKhuyenMai frm = new frmApDungKhuyenMai();
            OpenMain(frm);
        }

        private void lãiSuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaiSuat frm = new frmLaiSuat();
            OpenMain(frm);
        }

        private void lịchSửTrảNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichSuTraNo frm = new frmLichSuTraNo();
            OpenMain(frm);
        }

        private void khoảnVayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoanVay frm = new frmKhoanVay();
            OpenMain(frm);
        }

        private void tKĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKDangNhap frm = new frmTKDangNhap();
            OpenMain(frm);
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

            // Tự căn giữa màn hình
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBanner_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Report_TaiKhoan frm = new Frm_Report_TaiKhoan();
            OpenMain(frm);
        }


        private void biênLaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_BienLaiReport frm = new Frm_BienLaiReport();
            OpenMain(frm);
        }

        private void giaoDịchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Report_GiaoDich frm = new Frm_Report_GiaoDich();
            OpenMain(frm);
        }


        private void phiếuTranoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TraNoReport frm = new Frm_TraNoReport();
            OpenMain(frm);
        }

        private void hoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HoTro frm = new Frm_HoTro();
            OpenMain(frm);
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HopDong frm = new Frm_HopDong();
            OpenMain(frm);
        }

        private void hóađơnchuyểnkhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ChuyenKhoanReport frm = new Frm_ChuyenKhoanReport();
            OpenMain(frm);
        }

        private void phiếuVayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PhieuVayReport frm = new Frm_PhieuVayReport();
            OpenMain(frm);
        }

        private void hợpĐồngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Report_HopDong frm = new Frm_Report_HopDong();
            OpenMain(frm);
        }


        private void loạiGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LoaiGiaoDich frm = new Frm_LoaiGiaoDich();
            OpenMain(frm);
        }

        private void báocáoviphạmtoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_ViPhamRP frm = new frm_ViPhamRP();
            OpenMain(frm);
        }

        private void báocáophiếulươngtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhieuLuongRP frm = new frm_PhieuLuongRP();
            OpenMain(frm);
        }

        private void báocáonhânviêntoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_NhanVienRP frm = new frm_NhanVienRP();
            OpenMain(frm);
        }

        private void loạiHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LoaiHopDong frm = new Frm_LoaiHopDong();
            OpenMain(frm);
        }

        private void loạiHỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LoaiHoTro frm = new Frm_LoaiHoTro();
            OpenMain(frm);
        }
    }
}
