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
            //Frm_NhanVien frm = new Frm_NhanVien();
            //OpenMain(frm);
        }

        private void giaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_GiaoDich frm = new Frm_GiaoDich();
            //OpenMain(frm);
        }

        private void biênLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_BienLai frm = new Frm_BienLai();
            //OpenMain(frm);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_KhachHang frm = new Frm_KhachHang();
            //OpenMain(frm);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_TaiKhoan frm = new Frm_TaiKhoan();
            //OpenMain(frm);
        }

        private void loạiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_LoaiTaiKhoan frm = new Frm_LoaiTaiKhoan();
            //OpenMain(frm);
        }

        private void tiềnTệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_LoaiTien frm = new Frm_LoaiTien();
            //OpenMain(frm);
        }

        private void chuyểnKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuyenKhoan frm = new frmChuyenKhoan();
            OpenMain(frm);
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PhongBan frm = new Frm_PhongBan();
            //OpenMain(frm);
        }

        private void nộiQuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_NoiQuy frm = new Frm_NoiQuy();
            //OpenMain(frm);
        }

        private void viPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_ViPham frm = new Frm_ViPham();
            //OpenMain(frm);
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_ChiNhanh frm = new Frm_ChiNhanh();
            //OpenMain(frm);
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmKhuyenMai frm = new frmKhuyenMai();
            //OpenMain(frm);
        }

        private void ápDụngKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lãiSuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lịchSửTrảNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void khoảnVayToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tKĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBanner_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void báoCáoViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void báoCáoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loạiTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void loạiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void biênLaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void giaoDịchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void phiếuGhiNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void phiếuTranoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
