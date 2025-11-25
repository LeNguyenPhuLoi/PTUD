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
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        BUS_KhuyenMai bUS_KhuyenMai = new BUS_KhuyenMai();

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgvKhuyenMai.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvKhuyenMai.RowsDefaultCellStyle.BackColor = Color.White;
            dgvKhuyenMai.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
            dtNgayBatDau.MaxDate = DateTime.Now;
            dtNgayKetThuc.MaxDate = DateTime.Now;
        }

        public void Clear()
        {
            txtMaKM.Clear();
            txtTenKM.Clear();
            rtxtMota.Clear();
            dtNgayBatDau.MaxDate = DateTime.Now;
            dtNgayKetThuc.MaxDate = DateTime.Now;
            rtxtDKAD.Clear();
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
                ET_KhuyenMai km = new ET_KhuyenMai(bUS_KhuyenMai.DemMa(),
                                                   txtTenKM.Text,
                                                   rtxtMota.Text,
                                                   dtNgayBatDau.Value,
                                                   dtNgayKetThuc.Value,
                                                   rtxtDKAD.Text,
                                                   TrangThai);
                if (string.IsNullOrWhiteSpace(txtTenKM.Text))
                {
                    MessageBox.Show("Tên khuyến mãi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenKM.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtMota.Text))
                {
                    MessageBox.Show("Mô tả không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtMota.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtDKAD.Text))
                {
                    MessageBox.Show("Điều kiện áp dụng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtDKAD.Focus();
                    return;
                }
                if (bUS_KhuyenMai.ThemKM(km) == true)
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm khuyến mãi thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_KhuyenMai km = new ET_KhuyenMai(txtMaKM.Text,
                                                   txtTenKM.Text,
                                                   rtxtMota.Text,
                                                   dtNgayBatDau.Value,
                                                   dtNgayKetThuc.Value,
                                                   rtxtDKAD.Text,
                                                   TrangThai);
                if (string.IsNullOrWhiteSpace(txtTenKM.Text))
                {
                    MessageBox.Show("Tên khuyến mãi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenKM.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtMota.Text))
                {
                    MessageBox.Show("Mô tả không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtMota.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtDKAD.Text))
                {
                    MessageBox.Show("Điều kiện áp dụng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtDKAD.Focus();
                    return;
                }
                if (bUS_KhuyenMai.SuaKM(km) == true)
                {
                    MessageBox.Show("Sửa khuyến mãi thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa khuyến mãi thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
        }    

        private void dgvKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhuyenMai.CurrentCell.RowIndex;
                txtMaKM.Text = dgvKhuyenMai.Rows[dong].Cells[0].Value.ToString();
                txtTenKM.Text = dgvKhuyenMai.Rows[dong].Cells[1].Value.ToString();
                rtxtMota.Text = dgvKhuyenMai.Rows[dong].Cells[2].Value.ToString();
                dtNgayBatDau.Value = DateTime.Parse(dgvKhuyenMai.Rows[dong].Cells[3].Value.ToString());
                dtNgayKetThuc.Value = DateTime.Parse(dgvKhuyenMai.Rows[dong].Cells[4].Value.ToString());
                rtxtDKAD.Text = dgvKhuyenMai.Rows[dong].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_An_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_KhuyenMai ck = new ET_KhuyenMai(txtMaKM.Text,
                                                                       txtTenKM.Text,
                                                                       rtxtMota.Text,
                                                                       dtNgayBatDau.Value,
                                                                       dtNgayKetThuc.Value,
                                                                       rtxtDKAD.Text,
                                                                       TrangThai);
                    if (bUS_KhuyenMai.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa khuyến mãi thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khuyến mãi thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_KhuyenMai ck = new ET_KhuyenMai(txtMaKM.Text,
                                                   txtTenKM.Text,
                                                   rtxtMota.Text,
                                                   dtNgayBatDau.Value,
                                                   dtNgayKetThuc.Value,
                                                   rtxtDKAD.Text,
                                                   TrangThai);
                if (bUS_KhuyenMai.TrangThaiAn(ck) == true)
                {
                    MessageBox.Show("Hủy ẩn khuyến mãi thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Hủy ẩn khuyến mãi thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvKhuyenMai.DataSource = bUS_KhuyenMai.LoadDSKhuyenMai();
        }

        //hàm kiểm tra định dạng mã khuyến mãi (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKM(string maKM)
        {
            bool flag = false;
            string pattern = @"^KM\d{2,8}$";
            if (string.IsNullOrWhiteSpace(maKM))
                return flag;
            if (Regex.IsMatch(maKM, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng tên khuyến mãi (chuỗi 100 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangTenKM(string tenkm)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,100}$";
            if (string.IsNullOrWhiteSpace(tenkm))
                return flag;
            if (Regex.IsMatch(tenkm.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mô tả (chuỗi 250 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangMoTaKM(string motakm)
        {
            bool flag = false;
            string pattern = @"^.{1,250}$";
            if (string.IsNullOrWhiteSpace(motakm))
                return flag;
            if (Regex.IsMatch(motakm.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng điều kiện áp dụng (chuỗi 250 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangDKAD(string dkad)
        {
            bool flag = false;
            string pattern = @"^.{1,250}$";
            if (string.IsNullOrWhiteSpace(dkad))
                return flag;
            if (Regex.IsMatch(dkad.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txtMaKM_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKM.Text))
            {
                errorProvider1.SetError(txtMaKM, "");
                txtMaKM.BackColor = Color.White;
                return;
            }
            string maKV = txtMaKM.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKM(maKV))
            {
                txtMaKM.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaKM, "Mã khuyến mãi không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaKM.Focus();
                return;
            }
            else
            {
                txtMaKM.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaKM, "");
        }

        private void txtTenKM_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKM.Text))
            {
                errorProvider1.SetError(txtTenKM, "");
                txtTenKM.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangTenKM(txtTenKM.Text))
            {
                txtTenKM.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtTenKM, "Tên khuyến mãi không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtTenKM.Focus();
                return;
            }
            else
            {
                txtTenKM.BackColor = Color.White;
            }
            errorProvider1.SetError(txtTenKM, "");
        }

        private void rtxtMota_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtMota.Text))
            {
                errorProvider1.SetError(rtxtMota, "");
                rtxtMota.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangMoTaKM(rtxtMota.Text))
            {
                rtxtMota.BackColor = Color.LightCoral;
                errorProvider1.SetError(rtxtMota, "Mô tả không được bỏ trống hoặc ghi ký tự đặc biệt");
                rtxtMota.Focus();
                return;
            }
            else
            {
                rtxtMota.BackColor = Color.White;
            }
            errorProvider1.SetError(rtxtMota, "");
        }

        private void rtxtDKAD_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtDKAD.Text))
            {
                errorProvider1.SetError(rtxtDKAD, "");
                rtxtDKAD.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangDKAD(rtxtDKAD.Text))
            {
                rtxtDKAD.BackColor = Color.LightCoral;
                errorProvider1.SetError(rtxtDKAD, "Điều kiện áp dụng không được bỏ trống hoặc ghi ký tự đặc biệt");
                rtxtDKAD.Focus();
                return;
            }
            else
            {
                rtxtDKAD.BackColor = Color.White;
            }
            errorProvider1.SetError(rtxtDKAD, "");
        }
    }
}
