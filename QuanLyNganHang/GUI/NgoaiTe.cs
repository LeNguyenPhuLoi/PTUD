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

namespace GUI
{
    public partial class NgoaiTe : Form
    {
        public NgoaiTe()
        {
            InitializeComponent();
        }

        BUS_NgoaiTe bUS_NgoaiTe = new BUS_NgoaiTe();

        private void NgoaiTe_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgvNgoaiTe.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvNgoaiTe.RowsDefaultCellStyle.BackColor = Color.White;
            dgvNgoaiTe.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            cbo_trangthai.SelectedIndex = 0;

            dgvNgoaiTe.DataSource = bUS_NgoaiTe.LoadDSNT();
        }

        public void Clear()
        {
            txt_tennt.Clear();
            txt_mant.Clear();
            txt_kyhieu.Clear();
            txt_quocgia.Clear();
            cbo_trangthai.SelectedIndex = 0;
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_NgoaiTe nt = new ET_NgoaiTe(bUS_NgoaiTe.DemMa(),
                                                       txt_tennt.Text,
                                                       txt_kyhieu.Text,
                                                       txt_quocgia.Text,
                                                       cbo_trangthai.Text,
                                                       TrangThai);
                if (string.IsNullOrWhiteSpace(txt_tennt.Text))
                {
                    MessageBox.Show("Tên ngoại tệ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tennt.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_kyhieu.Text))
                {
                    MessageBox.Show("Ký hiệu ngoại tệ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_kyhieu.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_quocgia.Text))
                {
                    MessageBox.Show("Quốc gia không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_quocgia.Focus();
                    return;
                }
                if (bUS_NgoaiTe.ThemNT(nt) == true)
                {
                    MessageBox.Show("Thêm ngoại tệ thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm ngoại tệ thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvNgoaiTe.DataSource = bUS_NgoaiTe.LoadDSNT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_NgoaiTe nt = new ET_NgoaiTe(txt_mant.Text,
                                                       txt_tennt.Text,
                                                       txt_kyhieu.Text,
                                                       txt_quocgia.Text,
                                                       cbo_trangthai.Text,
                                                       TrangThai);
                if (string.IsNullOrWhiteSpace(txt_tennt.Text))
                {
                    MessageBox.Show("Tên ngoại tệ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tennt.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_kyhieu.Text))
                {
                    MessageBox.Show("Ký hiệu ngoại tệ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_kyhieu.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_quocgia.Text))
                {
                    MessageBox.Show("Quốc gia không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_quocgia.Focus();
                    return;
                }
                if (bUS_NgoaiTe.SuaNT(nt) == true)
                {
                    MessageBox.Show("Sửa ngoại tệ thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa ngoại tệ thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvNgoaiTe.DataSource = bUS_NgoaiTe.LoadDSNT();
        }

        private void dgvNgoaiTe_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNgoaiTe.CurrentCell.RowIndex;
                txt_mant.Text = dgvNgoaiTe.Rows[dong].Cells[0].Value.ToString();
                txt_tennt.Text = dgvNgoaiTe.Rows[dong].Cells[1].Value.ToString();
                txt_kyhieu.Text = dgvNgoaiTe.Rows[dong].Cells[2].Value.ToString();
                txt_quocgia.Text = dgvNgoaiTe.Rows[dong].Cells[3].Value.ToString();
                cbo_trangthai.Text = dgvNgoaiTe.Rows[dong].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_NgoaiTe nt = new ET_NgoaiTe(txt_mant.Text,
                                                    txt_tennt.Text,
                                                    txt_kyhieu.Text,
                                                    txt_quocgia.Text,
                                                    cbo_trangthai.Text,
                                                    TrangThai);
                    if (bUS_NgoaiTe.TrangThaiAn(nt) == true)
                    {
                        MessageBox.Show("Xóa ngoại tệ thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa ngoại tệ thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvNgoaiTe.DataSource = bUS_NgoaiTe.LoadDSNT();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_NgoaiTe nt = new ET_NgoaiTe(txt_mant.Text,
                                               txt_tennt.Text,
                                               txt_kyhieu.Text,
                                               txt_quocgia.Text,
                                               cbo_trangthai.Text,
                                               TrangThai);
                if (bUS_NgoaiTe.TrangThaiAn(nt) == true)
                {
                    MessageBox.Show("Hủy ẩn ngoại tệ thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Hủy ẩn ngoại tệ thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvNgoaiTe.DataSource = bUS_NgoaiTe.LoadDSNT();
        }

        //hàm kiểm tra định dạng tên ngoại tệ (chuỗi 50 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangNT(string tennt)
        {
            bool flag = false;
            string pattern = @"^[a-zA-ZÀ-ỹ\s,.-]{1,50}$";
            if (string.IsNullOrWhiteSpace(tennt))
                return flag;
            if (Regex.IsMatch(tennt.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng tên ký hiệu (tự đặc biệt)
        private bool KiemTraDinhDangKyHieu(string kyhieu)
        {
            bool flag = false;
            string pattern = @"^[\p{P}\p{S}]{1,5}$";
            if (string.IsNullOrWhiteSpace(kyhieu))
                return flag;
            if (Regex.IsMatch(kyhieu.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng tên quốc gia (chuỗi 50 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangQG(string quocgia)
        {
            bool flag = false;
            string pattern = @"^[a-zA-ZÀ-ỹ\s,.-]{1,50}$";
            if (string.IsNullOrWhiteSpace(quocgia))
                return flag;
            if (Regex.IsMatch(quocgia.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txt_tennt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tennt.Text))
            {
                errorProvider1.SetError(txt_tennt, "");
                txt_tennt.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangNT(txt_tennt.Text))
            {
                txt_tennt.BackColor = Color.LightCoral;
                errorProvider1.SetError(txt_tennt, "Tên ngoại tệ không được bỏ trống hoặc ghi ký tự đặc biệt");
                txt_tennt.Focus();
                return;
            }
            else
            {
                txt_tennt.BackColor = Color.White;
            }
            errorProvider1.SetError(txt_tennt, "");
        }

        private void txt_kyhieu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_kyhieu.Text))
            {
                errorProvider1.SetError(txt_kyhieu, "");
                txt_kyhieu.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangKyHieu(txt_kyhieu.Text))
            {
                txt_kyhieu.BackColor = Color.LightCoral;
                errorProvider1.SetError(txt_kyhieu, "Chỉ được ghi ký hiệu đặc biệt");
                txt_kyhieu.Focus();
                return;
            }
            else
            {
                txt_kyhieu.BackColor = Color.White;
            }
            errorProvider1.SetError(txt_kyhieu, "");
        }

        private void txt_quocgia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_quocgia.Text))
            {
                errorProvider1.SetError(txt_quocgia, "");
                txt_quocgia.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangQG(txt_quocgia.Text))
            {
                txt_quocgia.BackColor = Color.LightCoral;
                errorProvider1.SetError(txt_quocgia, "Quốc gia không được bỏ trống hoặc ghi ký tự đặc biệt");
                txt_quocgia.Focus();
                return;
            }
            else
            {
                txt_quocgia.BackColor = Color.White;
            }
            errorProvider1.SetError(txt_quocgia, "");
        }
    }

}
