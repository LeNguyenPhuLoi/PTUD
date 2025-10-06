//using ET;
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
    public partial class Frm_MainUser : Form
    {
        public Frm_MainUser()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_ENTERSIZEMOVE = 0x0231;
            const int WM_EXITSIZEMOVE = 0x0232;

            if (m.Msg == WM_ENTERSIZEMOVE)
            {
                this.SuspendLayout(); // Bắt đầu kéo form → dừng layout
            }
            else if (m.Msg == WM_EXITSIZEMOVE)
            {
                this.ResumeLayout();  // Kết thúc kéo form → resume lại layout
            }

            base.WndProc(ref m);
        }


        private Button currentButton = null;

        private void HighlightButton(Button btn)
        {
            if (currentButton != null)
            {
                // Reset lại màu của button trước
                currentButton.BackColor = ColorTranslator.FromHtml("32,33,36");
                currentButton.ForeColor = Color.White;
                currentButton.FlatAppearance.BorderSize = 0;
            }

            // Highlight button mới
            btn.BackColor = ColorTranslator.FromHtml("#F5F5F5"); // màu sáng nổi bật
            btn.ForeColor = Color.Black;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.White;

            currentButton = btn;
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

        bool menuExpand = false;
        bool menuExpand2 = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainerQL.Height += 10;
                if(menuContainerQL.Height >= 400)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainerQL.Height -= 10;
                if (menuContainerQL.Height <= 45)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void menuTransitionRP_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                menuContainerRP.Height += 10;
                if (menuContainerRP.Height >= 300)
                {
                    menuTransitionRP.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                menuContainerRP.Height -= 10;
                if (menuContainerRP.Height <= 45)
                {
                    menuTransitionRP.Stop();
                    menuExpand2 = false;
                }
            }
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            menuTransitionRP.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 172)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnQL_Click_1(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            HighlightButton(btnKH);
            Frm_KhachHang frm = new Frm_KhachHang();
            OpenMain(frm);
        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCK);
            frmChuyenKhoan frm = new frmChuyenKhoan();
            OpenMain(frm);
        }

        private void btnVay_Click(object sender, EventArgs e)
        {
            HighlightButton(btnVay);
            frmKhoanVay frm = new frmKhoanVay();
            OpenMain(frm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            HighlightButton(btnTK);
            Frm_TaiKhoan frm = new Frm_TaiKhoan();
            OpenMain(frm);

        }

        private void btnGD_Click(object sender, EventArgs e)
        {
            HighlightButton(btnGD);
            Frm_GiaoDich frm = new Frm_GiaoDich();
            OpenMain(frm);
        }

        private void btnLS_Click(object sender, EventArgs e)
        {
            HighlightButton(btnLS);
            frmLichSuTraNo frm = new frmLichSuTraNo();
            OpenMain(frm);
        }

        private void btnBL_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBL);
            BienLai frm = new BienLai();
            OpenMain(frm);
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            HighlightButton(btnKM);
            frmApDungKhuyenMai frm = new frmApDungKhuyenMai();
            OpenMain(frm);
        }

        private void btnINBL_Click(object sender, EventArgs e)
        {
            HighlightButton(btnINBL);
          
        }

        private void btnPhieuVay_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPhieuVay);
            Frm_PhieuVayReport frm = new Frm_PhieuVayReport();
            OpenMain(frm);
        }

        private void btnPhieuTraNo_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPhieuTraNo);
            Frm_TraNoReport frm = new Frm_TraNoReport();
            OpenMain(frm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInGiaoDich_Click(object sender, EventArgs e)
        {
            HighlightButton(btnInGiaoDich);
            Frm_Report_GiaoDich frm = new Frm_Report_GiaoDich();
            OpenMain(frm);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHD);
            Frm_HopDong frm = new Frm_HopDong();
            OpenMain(frm);
        }

        private void btnCSKH_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCSKH);
            Frm_HoTro frm = new Frm_HoTro();
            OpenMain(frm);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCSKH);
            Frm_Report_TaiKhoan frm = new Frm_Report_TaiKhoan();
            OpenMain(frm);
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCSKH);
            Frm_ChuyenKhoanReport frm = new Frm_ChuyenKhoanReport();
            OpenMain(frm);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCSKH);
            Frm_Report_HopDong frm = new Frm_Report_HopDong();
            OpenMain(frm);
        }
    }
}
