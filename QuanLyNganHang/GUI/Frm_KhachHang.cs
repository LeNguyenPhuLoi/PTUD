using BUS;
using ET;
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
using System.IO;

namespace GUI
{
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();

        private void Re_size()
        {
            dgv_KhachHang.Size = new Size(panel_KhachHang.Width + 300, panel_KhachHang.Height + 300);
        }

        private void Clear()
        {
            txt_MaKH.Clear();
            txt_TenKH.Clear();
            rdb_Nam.Checked = true;
            txt_Cccd.Clear();
            txt_SDT.Clear();
            txt_Email.Clear();
            txt_DiaChi.Clear();
            txt_QuocTich.Clear();
            cbo_DoiTuong.SelectedIndex = 0;
            dtp_NgayTao.Text = dtp_NgayTao.MaxDate.ToString();

            txt_MaKH.BackColor = SystemColors.Window;
            txt_TenKH.BackColor = SystemColors.Window;
            txt_Cccd.BackColor = SystemColors.Window;
            txt_SDT.BackColor = SystemColors.Window;
            txt_Email.BackColor = SystemColors.Window;
            txt_DiaChi.BackColor = SystemColors.Window;
            txt_QuocTich.BackColor = SystemColors.Window;
        }

        private void HienThiDS()
        {
            var ds = BUS_KhachHang.LayDSToanBoKhachHang();
            dgv_KhachHang .DataSource = ds;
        }

        private string LayGioiTinh()
        {
            if (rdb_Nam.Checked)
            {
                return "Nam";
            }
            else
            {
                return "Nữ";
            }
        }

        private void SetGioiTinh(string GioiTinh)
        {
            if(GioiTinh == "Nam")
            {
                rdb_Nam.Checked = true;
            }
            else
            {
                rdb_Nu.Checked = true;
            }
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            dtp_NgayTao.MaxDate = DateTime.Now;
            cbo_DoiTuong.SelectedIndex = 0;
            Re_size();
            HienThiDS();
        }

        private void Frm_KhachHang_Resize(object sender, EventArgs e)
        {
            Re_size();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BUS_KhachHang.KiemTraTonTaiMaKH(txt_MaKH.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_KhachHang kh = new ET_KhachHang(txt_MaKH.Text.Trim().ToUpper(),
                                                    txt_TenKH.Text,
                                                    LayGioiTinh(),
                                                    txt_Cccd.Text,
                                                    txt_SDT.Text,
                                                    txt_Email.Text,
                                                    txt_DiaChi.Text,
                                                    txt_QuocTich.Text,
                                                    cbo_DoiTuong.Text,
                                                    dtp_NgayTao.Value);
                if (BUS_KhachHang.ThemKhachHang(kh) == true)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhachHang kh = new ET_KhachHang(txt_MaKH.Text.Trim().ToUpper(),
                                                    txt_TenKH.Text,
                                                    LayGioiTinh(),
                                                    txt_Cccd.Text,
                                                    txt_SDT.Text,
                                                    txt_Email.Text,
                                                    txt_DiaChi.Text,
                                                    txt_QuocTich.Text,
                                                    cbo_DoiTuong.Text,
                                                    dtp_NgayTao.Value);
                if (BUS_KhachHang.SuaKhachHang(kh) == true)
                {
                    MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Sưa khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_KhachHang kh = new ET_KhachHang(txt_MaKH.Text.Trim().ToUpper(),
                                                    txt_TenKH.Text,
                                                    LayGioiTinh(),
                                                    txt_Cccd.Text,
                                                    txt_SDT.Text,
                                                    txt_Email.Text,
                                                    txt_DiaChi.Text,
                                                    txt_QuocTich.Text,
                                                    cbo_DoiTuong.Text,
                                                    dtp_NgayTao.Value);
                    if (BUS_KhachHang.XoaKhachHang(kh) == true)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Xóa khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_KhachHang.CurrentCell.RowIndex;
                txt_MaKH.Text = dgv_KhachHang.Rows[dong].Cells[0].Value.ToString();
                txt_TenKH.Text = dgv_KhachHang.Rows[dong].Cells[1].Value.ToString();
                SetGioiTinh(dgv_KhachHang.Rows[dong].Cells[2].Value.ToString());
                txt_Cccd.Text = dgv_KhachHang.Rows[dong].Cells[3].Value.ToString();
                txt_SDT.Text = dgv_KhachHang.Rows[dong].Cells[4].Value.ToString();
                txt_Email.Text = dgv_KhachHang.Rows[dong].Cells[5].Value.ToString();
                txt_DiaChi.Text = dgv_KhachHang.Rows[dong].Cells[6].Value.ToString();
                txt_QuocTich.Text = dgv_KhachHang.Rows[dong].Cells[7].Value.ToString();
                cbo_DoiTuong.Text = dgv_KhachHang.Rows[dong].Cells[8].Value.ToString();
                dtp_NgayTao.Text = dgv_KhachHang.Rows[dong].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //hàm kiểm tra định dạng mã khách hàng (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKH(string maKH)
        {
            bool flag = false;
            string pattern = @"^KH\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maKH)) 
                return flag;
            if(Regex.IsMatch(maKH, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng tên khách hàng (70 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangTenKH(string tenkh)
        {
            bool flag = false;
            string pattern = @"^(?!.*\s{2})[a-zA-ZÀ-ỹ]{2,}(?:\s[a-zA-ZÀ-ỹ]+){0,9}$";
            if (string.IsNullOrWhiteSpace(tenkh))
                return flag;
            if (Regex.IsMatch(tenkh.Trim(), pattern) && tenkh.Trim().Length <= 70)
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số CCCD/CMND (chuỗi 12 chữ số, không chữ, không ký tự đặc biệt)
        private bool KiemTraDinhDangCCCD(string cccd)
        {
            bool flag = false;
            string pattern = @"^\d{12}$";
            if (string.IsNullOrWhiteSpace(cccd))
                return flag;
            if (Regex.IsMatch(cccd.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số điện thoại (chuỗi 10 chữ số, không chữ, không ký tự đặc biệt)
        private bool KiemTraDinhDangSDT(string sdt)
        {
            bool flag = false;
            string pattern = @"^\d{10}$";
            if (string.IsNullOrWhiteSpace(sdt))
                return flag;
            if (Regex.IsMatch(sdt.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng email (chuỗi 100 ký tự, không khoảng trắng)
        private bool KiemTraDinhDangEmail(string email)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (string.IsNullOrWhiteSpace(email))
                return flag;
            if (Regex.IsMatch(email.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng địa chỉ (chuỗi 100 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangDiaChi(string diachi)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,100}$";
            if (string.IsNullOrWhiteSpace(diachi))
                return flag;
            if (Regex.IsMatch(diachi.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng quốc tịch (chuỗi 20 ký tự, không ký tự đặc biệt, không chữ số)
        private bool KiemTraDinhDangQuocTich(string quoctich)
        {
            bool flag = false;
            string pattern = @"^[a-zA-ZÀ-ỹ\s]{1,20}$";
            if (string.IsNullOrWhiteSpace(quoctich))
                return flag;
            if (Regex.IsMatch(quoctich.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangMaKH(txt_MaKH.Text.Trim().ToUpper()))
            {
                txt_MaKH.BackColor = Color.LightCoral;
            }
            else
            {
                txt_MaKH.BackColor = SystemColors.Window;
            }
        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangTenKH(txt_TenKH.Text))
            {
                txt_TenKH.BackColor = Color.LightCoral;
            }
            else
            {
                txt_TenKH.BackColor = SystemColors.Window;
            }
        }

        private void txt_Cccd_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangCCCD(txt_Cccd.Text))
            {
                txt_Cccd.BackColor = Color.LightCoral;
            }
            else
            {
                txt_Cccd.BackColor = SystemColors.Window;
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangEmail(txt_Email.Text))
            {
                txt_Email.BackColor = Color.LightCoral;
            }
            else
            {
                txt_Email.BackColor = SystemColors.Window;
            }
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangSDT(txt_SDT.Text))
            {
                txt_SDT.BackColor = Color.LightCoral;
            }
            else
            {
                txt_SDT.BackColor = SystemColors.Window;
            }
        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangDiaChi(txt_DiaChi.Text))
            {
                txt_DiaChi.BackColor = Color.LightCoral;
            }
            else
            {
                txt_DiaChi.BackColor = SystemColors.Window;
            }
        }

        private void txt_QuocTich_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangQuocTich(txt_QuocTich.Text))
            {
                txt_QuocTich.BackColor = Color.LightCoral;
            }
            else
            {
                txt_QuocTich.BackColor = SystemColors.Window;
            }
        }
    }
}
