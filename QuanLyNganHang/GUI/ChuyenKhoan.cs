using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace GUI
{
    public partial class frmChuyenKhoan : Form
    {
        public frmChuyenKhoan()
        {
            InitializeComponent();
        }

        BUS_ChuyenKhoan bUS_ChuyenKhoan = new BUS_ChuyenKhoan();
        private void frmChuyenKhoan_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgvChuyenKhoan.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvChuyenKhoan.RowsDefaultCellStyle.BackColor = Color.White;
            dgvChuyenKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgvmakh.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvmakh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmakh.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgvmatknhan.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvmatknhan.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmatknhan.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            dgvmakh.DataSource = bUS_ChuyenKhoan.LoadDSKhachHang();
            dgvmatknhan.DataSource = bUS_ChuyenKhoan.LoadDSTaiKhoan();

            dtpNgayChuyen.MaxDate = DateTime.Now;
            HienThiDS();
        }

        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_An.Visible = true;
                btn_HuyAn.Visible = true;
                dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
            }
            else
            {
                dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoanUser();
                dgvChuyenKhoan.Columns["TinhTrangXoa"].Visible = false;
                btn_An.Visible = false;
            }
            dgvChuyenKhoan.Columns["KHACHHANG"].Visible = false;
            dgvChuyenKhoan.Columns["TAIKHOAN"].Visible = false;
        }

        public void Clear()
        {
            txtMaCK.Clear();
            txtSoTien.Clear();
            rtxtND.Clear();
            txtMaKH.Clear();
            cbo_taikhoan.SelectedIndex = -1;
            cbo_taikhoangui.SelectedIndex = -1;
            txtMaTKNhan.Clear();
            dtpNgayChuyen.MaxDate = DateTime.Now;
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
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(bUS_ChuyenKhoan.DemMa(),
                                                       txtMaKH.Text,
                                                       cbo_taikhoan.Text,
                                                       Convert.ToDateTime(dtpNgayChuyen.Text),
                                                       decimal.Parse(txtSoTien.Text),
                                                       cbo_taikhoangui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Mã khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbo_taikhoan.Text))
                {
                    MessageBox.Show("Mã tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_taikhoan.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbo_taikhoangui.Text))
                {
                    MessageBox.Show("Tài khoản gửi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_taikhoangui.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMaTKNhan.Text))
                {
                    MessageBox.Show("Mã tài khoản nhận không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaTKNhan.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSoTien.Text))
                {
                    MessageBox.Show("Số tiền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoTien.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtND.Text))
                {
                    MessageBox.Show("Nội dung không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtND.Focus();
                    return;
                }
                if (bUS_ChuyenKhoan.ThemCK(ck) == true)
                {
                    MessageBox.Show("Thêm chuyển khoản thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm chuyển khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       cbo_taikhoan.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       cbo_taikhoangui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Mã khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbo_taikhoan.Text))
                {
                    MessageBox.Show("Mã tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_taikhoan.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbo_taikhoangui.Text))
                {
                    MessageBox.Show("Tài khoản gửi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_taikhoangui.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMaTKNhan.Text))
                {
                    MessageBox.Show("Mã tài khoản nhận không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaTKNhan.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSoTien.Text))
                {
                    MessageBox.Show("Số tiền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoTien.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtND.Text))
                {
                    MessageBox.Show("Nội dung không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtND.Focus();
                    return;
                }
                if (bUS_ChuyenKhoan.SuaCK(ck) == true)
                {
                    MessageBox.Show("Sửa chuyển khoản thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa chuyển khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }
      

        private void dgvmakh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmakh.CurrentCell.RowIndex;
                txtMaKH.Text = dgvmakh.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvmatknhan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmatknhan.CurrentCell.RowIndex;
                txtMaTKNhan.Text = dgvmatknhan.Rows[dong].Cells[0].Value.ToString();
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
                    ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                                           txtMaKH.Text,
                                                                           cbo_taikhoan.Text,
                                                                           dtpNgayChuyen.Value,
                                                                           decimal.Parse(txtSoTien.Text),
                                                                           cbo_taikhoangui.Text,
                                                                           txtMaTKNhan.Text,
                                                                           rtxtND.Text,
                                                                           TrangThai);
                    if (bUS_ChuyenKhoan.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa chuyển khoản thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chuyển khoản thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private void btnxoauser_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Ngừng Hoạt Động";
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       cbo_taikhoan.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       cbo_taikhoangui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                    if (bUS_ChuyenKhoan.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa chuyển khoản thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chuyển khoản thất bại!");
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
                ET_ChuyenKhoan ck = new ET_ChuyenKhoan(txtMaCK.Text,
                                                       txtMaKH.Text,
                                                       cbo_taikhoan.Text,
                                                       dtpNgayChuyen.Value,
                                                       decimal.Parse(txtSoTien.Text),
                                                       cbo_taikhoangui.Text,
                                                       txtMaTKNhan.Text,
                                                       rtxtND.Text,
                                                       TrangThai);
                if (bUS_ChuyenKhoan.TrangThaiAn(ck) == true)
                {
                    MessageBox.Show("Hủy ẩn chuyển khoản thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Hủy ẩn chuyển khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgvChuyenKhoan.DataSource = bUS_ChuyenKhoan.LoadDSChuyenKhoan();
        }

        //hàm kiểm tra định dạng mã chuyển khoản (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaCK(string maCK)
        {
            bool flag = false;
            string pattern = @"^CK\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maCK))
                return flag;
            if (Regex.IsMatch(maCK, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mã khách hàng (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKH(string maKH)
        {
            bool flag = false;
            string pattern = @"^KH\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maKH))
                return flag;
            if (Regex.IsMatch(maKH, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng mã tài khoản nhận (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaTKNhan(string maTKnhan)
        {
            bool flag = false;
            string pattern = @"^TK\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maTKnhan))
                return flag;
            if (Regex.IsMatch(maTKnhan, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số tiền (không chữ, không ký tự đặc biệt)
        private bool KiemTraDinhDangTien(string tien)
        {
            bool flag = false;
            string pattern = @"^\d{1,9}$";
            if (string.IsNullOrWhiteSpace(tien))
                return flag;
            if (Regex.IsMatch(tien.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng nội dung (chuỗi 100 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangND(string noidung)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,500}$";
            if (string.IsNullOrWhiteSpace(noidung))
                return flag;
            if (Regex.IsMatch(noidung.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txtMaCK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCK.Text))
            {
                errorProvider1.SetError(txtMaCK, "");
                txtMaCK.BackColor = Color.White;
                return;
            }
            string maCK = txtMaCK.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaCK(maCK))
            {
                txtMaCK.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaCK, "Mã chuyển khoản không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaCK.Focus();
                return;
            }
            else
            {
                txtMaCK.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaCK, "");
        }

        private string maKHCu = "";
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                errorProvider1.SetError(txtMaKH, "");
                txtMaKH.BackColor = Color.White;
                return;
            }
            string maKH = txtMaKH.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKH(maKH))
            {
                txtMaKH.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaKH, "Mã khách hàng không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaKH.Focus();
                return;
            }
            else
            {
                txtMaKH.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaKH, "");

            string maKHmoi = txtMaKH.Text.Trim();

            if (maKHmoi != maKHCu) // Nếu khác giá trị cũ
            {
                maKHCu = maKHmoi; // Cập nhật giá trị mới

                // Xóa toàn bộ dữ liệu trong ComboBox
                cbo_taikhoan.Items.Clear();

                // Nếu muốn load mới khi khác thì bật dòng dưới:
                AddToCombo(bUS_ChuyenKhoan.LoadDSTKtheoMa(maKHmoi), cbo_taikhoan);
                AddToCombo(bUS_ChuyenKhoan.LoadDSTKtheoMa(maKHmoi), cbo_taikhoangui);
            }
        }     

        private void txtMaTKNhan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTKNhan.Text))
            {
                errorProvider1.SetError(txtMaTKNhan, "");
                txtMaTKNhan.BackColor = Color.White;
                return;
            }

            if (cbo_taikhoangui.Text.Trim() == txtMaTKNhan.Text.Trim())
            {
                txtMaTKNhan.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaTKNhan, "Mã tài khoản nhận không được trùng với mã tài khoản gửi");
                txtMaTKNhan.Focus();
                return;
            }

            string maTKNhan = txtMaTKNhan.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaTKNhan(maTKNhan))
            {
                txtMaTKNhan.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtMaTKNhan, "Mã tài khoản nhận không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtMaTKNhan.Focus();
                return;
            }
            else
            {
                txtMaTKNhan.BackColor = Color.White;
            }
            errorProvider1.SetError(txtMaTKNhan, "");
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                errorProvider1.SetError(txtSoTien, "");
                txtSoTien.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangTien(txtSoTien.Text))
            {
                txtSoTien.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtSoTien, "Số tiền không được bỏ trống, ghi ký tự đặc biệt hoặc ghi chữ");
                txtSoTien.Focus();
                return;
            }
            else
            {
                txtSoTien.BackColor = Color.White;
            }
            errorProvider1.SetError(txtSoTien, "");
        }

        private void rtxtND_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtND.Text))
            {
                errorProvider1.SetError(rtxtND, "");
                rtxtND.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangND(rtxtND.Text))
            {
                rtxtND.BackColor = Color.LightCoral;
                errorProvider1.SetError(rtxtND, "Mã nội dung không được ghi ký tự đặc biệt");
                rtxtND.Focus();
                return;
            }
            else
            {
                rtxtND.BackColor = Color.White;
            }
            errorProvider1.SetError(rtxtND, "");
        }

        private void cbo_taikhoangui_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_taikhoangui.Text))
            {
                errorProvider1.SetError(cbo_taikhoangui, "");
                cbo_taikhoangui.BackColor = Color.White;
                return;
            }

            if (cbo_taikhoan.Text.Trim() != cbo_taikhoangui.Text.Trim())
            {
                cbo_taikhoangui.BackColor = Color.LightCoral;
                errorProvider1.SetError(cbo_taikhoangui, "Mã tài khoản gửi phải đúng với mã tài khoản");
                cbo_taikhoangui.Focus();
                return;
            }
            else
            {
                cbo_taikhoangui.BackColor = Color.White;
            }
            errorProvider1.SetError(cbo_taikhoangui, "");
        }

        private void dgvChuyenKhoan_Click_1(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvChuyenKhoan.CurrentCell.RowIndex;
                txtMaCK.Text = dgvChuyenKhoan.Rows[dong].Cells[0].Value.ToString();
                txtMaKH.Text = dgvChuyenKhoan.Rows[dong].Cells[1].Value.ToString();
                cbo_taikhoan.Text = dgvChuyenKhoan.Rows[dong].Cells[2].Value.ToString();
                dtpNgayChuyen.Text = dgvChuyenKhoan.Rows[dong].Cells[3].Value.ToString();
                txtSoTien.Text = dgvChuyenKhoan.Rows[dong].Cells[4].Value.ToString();
                cbo_taikhoangui.Text = dgvChuyenKhoan.Rows[dong].Cells[5].Value.ToString();
                txtMaTKNhan.Text = dgvChuyenKhoan.Rows[dong].Cells[6].Value.ToString();
                rtxtND.Text = dgvChuyenKhoan.Rows[dong].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }        
    }
}
