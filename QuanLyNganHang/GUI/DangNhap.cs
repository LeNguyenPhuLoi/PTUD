using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BUS;
//using ET;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //BUS_DangNhap bs = new BUS_DangNhap();
        public Form NextForm { get; set; } // Lưu form tiếp theo


        private void btnZoom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtMaDN.Text == "ADMIN" && txtPass.Text == "1")
            {
                NextForm = new frmMainAddmin();
                this.DialogResult = DialogResult.OK; // báo cho Program biết đăng nhập thành công
            }
            else if (txtMaDN.Text == "USER" && txtPass.Text == "1")
            {
                NextForm = new Frm_MainUser();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMaDN.Focus();
            txtPass.UseSystemPasswordChar = !showpass.Checked;
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !showpass.Checked;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
