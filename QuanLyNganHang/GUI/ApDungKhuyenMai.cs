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
using BUS;
using ET;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmApDungKhuyenMai : Form
    {
        public frmApDungKhuyenMai()
        {
            InitializeComponent();
        }
        
        BUS_ApDungKhuyenMai bUS_ApDungKhuyenMai = new BUS_ApDungKhuyenMai();

        private void frmApDungKhuyenMai_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgv_adkm.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
            // Xem kẽ màu dòng
            dgv_adkm.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_adkm.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;

            // Màu nền khi chọn ô (dòng)
            dgv_makm.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgv_makm.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_makm.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgv_makh.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgv_makh.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_makh.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng


            dgv_makm.DataSource = bUS_ApDungKhuyenMai.LoadDSKM();
            dgv_makh.DataSource = bUS_ApDungKhuyenMai.LoadKH();
            dtpNgayApDung.MaxDate = DateTime.Now;
            dtpNgayApDung.Value = DateTime.Now;
            HienThiDS();
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btnXoa.Visible = true;
                btn_HuyAn.Visible = true;
                dgv_adkm.DataSource = bUS_ApDungKhuyenMai.LoadDSADKM();
            }
            else
            {
                btnXoa.Visible = false;
                dgv_adkm.DataSource = bUS_ApDungKhuyenMai.LoadDSADKMUser();
                dgv_adkm.Columns["TinhTrangXoa"].Visible = false;
            }
            dgv_adkm.Columns["KHACHHANG"].Visible = false;
            dgv_adkm.Columns["TAIKHOAN"].Visible = false;
            dgv_adkm.Columns["KHUYENMAI"].Visible = false;
        }

        public void Clear()
        {
            txt_makm.Clear();
            txt_makh.Clear();
            cbo_matk.SelectedIndex = -1;
            dtpNgayApDung.Value = dtpNgayApDung.MaxDate;
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
                ET_ApDungKhuyenMai adkm = new ET_ApDungKhuyenMai(txt_makm.Text,
                                                                    txt_makh.Text,
                                                                    cbo_matk.Text,
                                                                    dtpNgayApDung.Value,
                                                                    TrangThai);
                if (string.IsNullOrWhiteSpace(txt_makm.Text))
                {
                    MessageBox.Show("Mã khuyến mãi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_makm.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_makh.Text))
                {
                    MessageBox.Show("Mã khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_makh.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbo_matk.Text))
                {
                    MessageBox.Show("Mã tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bUS_ApDungKhuyenMai.ThemADKM(adkm) == true)
                {
                    MessageBox.Show("Thêm áp dụng khuyến mãi thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm áp dụng khuyến mãi thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_ApDungKhuyenMai ck = new ET_ApDungKhuyenMai(txt_makm.Text,
                                                                    txt_makh.Text,
                                                                    cbo_matk.Text,
                                                                    dtpNgayApDung.Value,
                                                                    TrangThai);
                    if (bUS_ApDungKhuyenMai.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa áp dụng khuyến mãi thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa áp dụng khuyến mãi thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private void btn_xoauser_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_ApDungKhuyenMai ck = new ET_ApDungKhuyenMai(txt_makm.Text,
                                                                    txt_makh.Text,
                                                                    cbo_matk.Text,
                                                                    dtpNgayApDung.Value,
                                                                    TrangThai);
                    if (bUS_ApDungKhuyenMai.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa áp dụng khuyến mãi thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa áp dụng khuyến mãi thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                    ET_ApDungKhuyenMai ck = new ET_ApDungKhuyenMai(txt_makm.Text,
                                                                    txt_makh.Text,
                                                                    cbo_matk.Text,
                                                                    dtpNgayApDung.Value,
                                                                    TrangThai);
                    if (bUS_ApDungKhuyenMai.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Hủy ẩn áp dụng khuyến mãi thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Hủy ẩn áp dụng khuyến mãi thất bại!");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private string maKHCu = "";
        private void txt_makh_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_makh.Text))
            {
                errorProvider1.SetError(txt_makh, "");
                txt_makh.BackColor = Color.White;
                return;
            }
            string maCK = txt_makh.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKH(maCK))
            {
                txt_makh.BackColor = Color.LightCoral;
                errorProvider1.SetError(txt_makh, "Mã khách hàng không được bỏ trống hoặc ghi ký tự đặc biệt");
                txt_makh.Focus();
                return;
            }
            else
            {
                txt_makm.BackColor = Color.White;
            }
            errorProvider1.SetError(txt_makm, "");

            string maKHmoi = txt_makh.Text.Trim();

            if (maKHmoi != maKHCu) // Nếu khác giá trị cũ
            {
                maKHCu = maKHmoi; // Cập nhật giá trị mới

                // Xóa toàn bộ dữ liệu trong ComboBox
                cbo_matk.Items.Clear();

                // Nếu muốn load mới khi khác thì bật dòng dưới:
                AddToCombo(bUS_ApDungKhuyenMai.LoadDSTKtheoMa(maKHmoi), cbo_matk);
            }
        }

        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        private void dgv_adkm_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_adkm.CurrentCell.RowIndex;
                txt_makm.Text = dgv_adkm.Rows[dong].Cells[0].Value.ToString();
                txt_makh.Text = dgv_adkm.Rows[dong].Cells[1].Value.ToString();
                cbo_matk.Text = dgv_adkm.Rows[dong].Cells[2].Value.ToString();
                dtpNgayApDung.Text = dgv_adkm.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgv_makm_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_makm.CurrentCell.RowIndex;
                txt_makm.Text = dgv_makm.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgv_makh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_makh.CurrentCell.RowIndex;
                txt_makh.Text = dgv_makh.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //hàm kiểm tra định dạng mã khuyến mãi (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKM(string maCK)
        {
            bool flag = false;
            string pattern = @"^KM\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maCK))
                return flag;
            if (Regex.IsMatch(maCK, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mã khách hàng (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKH(string maCK)
        {
            bool flag = false;
            string pattern = @"^KH\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maCK))
                return flag;
            if (Regex.IsMatch(maCK, pattern))
                flag = true;
            return flag;
        }

        private void txt_makm_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_makm.Text))
            {
                errorProvider1.SetError(txt_makm, "");
                txt_makm.BackColor = Color.White;
                return;
            }
            string maCK = txt_makm.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKM(maCK))
            {
                txt_makm.BackColor = Color.LightCoral;
                errorProvider1.SetError(txt_makm, "Mã khuyến mãi không được bỏ trống hoặc ghi ký tự đặc biệt");
                txt_makm.Focus();
                return;
            }
            else
            {
                txt_makm.BackColor = Color.White;
            }
            errorProvider1.SetError(txt_makm, "");
        }
    }
}
