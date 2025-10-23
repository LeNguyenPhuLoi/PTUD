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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien bUS = new BUS_NhanVien();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvNhanVien.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvNhanVien.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvNhanVien.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvNhanVien.RowsDefaultCellStyle.BackColor = Color.White;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvNhanVien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



            dgvNhanVien.DataSource = bUS.LoadDSNV();
            AddToCombo(bUS.LoadDSPB(), cboMaPB);
            AddToCombo(bUS.LoadDSCN(), cboMaCN);
            btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
            dtpNgaySinh.MaxDate = DateTime.Now.AddYears(-18);
            btnHoanTac_Click(sender, e);
        }

        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        public string LayGioiTinh()
        {
            if (rdoNam.Checked == true)
            {
                return "NAM";
            }
            else
            {
                return "NỮ";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text,
                                                    LayGioiTinh(), dtpNgaySinh.Value,
                                                    txtCCCD.Text, cboChuc.Text, 
                                                    decimal.Parse(txtLuong.Text),
                                                    rtxDiaChi.Text, txtSDT.Text,
                                                    bUS.LayMaPB(cboMaPB.Text), 
                                                    bUS.LayMaCN(cboMaCN.Text),
                                                    TrangThai);
                string error = "";
                if (bUS.ThemNhanVien(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNhanVien.DataSource = bUS.LoadDSNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text,
                                                    LayGioiTinh(), dtpNgaySinh.Value,
                                                    txtCCCD.Text, cboChuc.Text,
                                                    decimal.Parse(txtLuong.Text),
                                                    rtxDiaChi.Text, txtSDT.Text,
                                                    bUS.LayMaPB(cboMaPB.Text),
                                                    bUS.LayMaCN(cboMaCN.Text),
                                                    TrangThai);
                string error = "";
                if (bUS.CapNhatNhanVien(et, out error) == true)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvNhanVien.DataSource = bUS.LoadDSNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string TrangThai = "Nghỉ Việc";
                    ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text,
                                                    LayGioiTinh(), dtpNgaySinh.Value,
                                                    txtCCCD.Text, cboChuc.Text,
                                                    decimal.Parse(txtLuong.Text),
                                                    rtxDiaChi.Text, txtSDT.Text,
                                                    bUS.LayMaPB(cboMaPB.Text),
                                                    bUS.LayMaCN(cboMaCN.Text),
                                                    TrangThai);
                    string error = "";
                    if (bUS.XoaNhanVien(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvNhanVien.DataSource = bUS.LoadDSNV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText(@"D:\log.txt", ex.ToString());
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtLuong.Text = "0";
            txtSDT.Clear();
            txtTenNV.Clear();
            rdoNam.Checked = true;
            cboChuc.SelectedIndex = 0;
            txtCCCD.Clear();
            rtxDiaChi.Clear();
            txtSDT.Clear();
            cboMaPB.SelectedIndex = 0;
            cboMaCN.SelectedIndex = 0;
            txtMaNV.Focus();
            txtMaNV.Enabled = true;
            dtpNgaySinh.Value = dtpNgaySinh.MaxDate.AddDays(-1);
            dgvNhanVien.DataSource = bUS.LoadDSNV();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
                if (dgvNhanVien.Rows[dong].Cells[2].Value.ToString() == "NAM")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dtpNgaySinh.Text = dgvNhanVien.Rows[dong].Cells[3].Value.ToString();
                txtCCCD.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString();
                cboChuc.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
                rtxDiaChi.Text = dgvNhanVien.Rows[dong].Cells[7].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[dong].Cells[8].Value.ToString();
                cboMaPB.Text = dgvNhanVien.Rows[dong].Cells[9].Value.ToString();
                cboMaCN.Text = dgvNhanVien.Rows[dong].Cells[10].Value.ToString();
                txtMaNV.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //hàm kiểm tra định dạng mã Nhân viên (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaNV(string manv)
        {
            bool flag = false;
            string pattern = @"^NV\d{3,8}$";
            if (string.IsNullOrWhiteSpace(manv))// kiểm tra trống hoặc toàn khoảng trắng
                return flag;
            if (Regex.IsMatch(manv, pattern))//kiểm tra chuỗi theo mẫu
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng tên khách hàng (70 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangTen(string tenkh)
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
        public bool KiemTraDinhDangCCCD(string cccd)
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
        public bool KiemTraDinhDangSDT(string sdt)
        {
            bool flag = false;
            string pattern = @"^\d{10}$";
            if (string.IsNullOrWhiteSpace(sdt))
                return flag;
            if (Regex.IsMatch(sdt.Trim(), pattern))
                flag = true;
            return flag;
        }
        //hàm kiểm tra định dạng địa chỉ (chuỗi 100 ký tự, không ký tự đặc biệt)
        public bool KiemTraDinhDangDiaChi(string diachi)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,100}$";
            if (string.IsNullOrWhiteSpace(diachi))
                return flag;
            if (Regex.IsMatch(diachi.Trim(), pattern))
                flag = true;
            return flag;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim().ToUpper();

            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(maNV))
            {
                errorProvider1.SetError(txtMaNV, "");
                txtMaNV.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng mã nhân viên
            if (!KiemTraDinhDangMaNV(maNV))
            {
                txtMaNV.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtMaNV, "Mã nhân viên không hợp lệ! (VD: NV001, NV12345)");
                MessageBox.Show("Mã nhân viên phải có dạng NV + 3-8 chữ số (VD: NV001, NV12345).",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Clear();
                txtMaNV.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtMaNV, "");
            txtMaNV.BackColor = Color.White;
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng CCCD
            if (!KiemTraDinhDangCCCD(txtCCCD.Text))
            {
                txtCCCD.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtCCCD, "CCCD phải gồm 12 chữ số hợp lệ.");
                MessageBox.Show("Số CCCD không hợp lệ hoặc đã tồn tại! Vui lòng nhập đúng 12 chữ số.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCCD.Clear();
                txtCCCD.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtCCCD, "");
            txtCCCD.BackColor = Color.White;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errorProvider1.SetError(txtSDT, "");
                txtSDT.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng SDT
            if (!KiemTraDinhDangSDT(txtSDT.Text))
            {
                txtSDT.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtSDT, "SDT phải gồm 10 chữ số hợp lệ.");
                MessageBox.Show("Số Điện Thoại không hợp lệ hoặc đã tồn tại! Vui lòng nhập đúng 10 chữ số.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Clear();
                txtSDT.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtSDT, "");
            txtSDT.BackColor = Color.White;
        }

        private void rtxDiaChi_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(rtxDiaChi.Text))
            {
                errorProvider1.SetError(rtxDiaChi, "");
                rtxDiaChi.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng địa chỉ
            if (!KiemTraDinhDangDiaChi(rtxDiaChi.Text))
            {
                rtxDiaChi.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(rtxDiaChi, "tối đa 100 ký tự, không ký tự đặc biệt");
                MessageBox.Show("Địa chỉ không hợp lệ! Vui lòng nhập không quá 100 ký tự.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtxDiaChi.Clear();
                rtxDiaChi.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(rtxDiaChi, "");
            rtxDiaChi.BackColor = Color.White;
        }

        private void txtTenNV_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                errorProvider1.SetError(txtTenNV, "");
                txtTenNV.BackColor = Color.White;
                return;
            }

            // Kiểm tra định dạng tên nhân viên
            if (!KiemTraDinhDangTen(txtTenNV.Text))
            {
                txtTenNV.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                errorProvider1.SetError(txtTenNV, "tối đa 70 ký tự, không ký tự đặc biệt");
                MessageBox.Show("Tên không hợp lệ! Vui lòng nhập không quá 70 ký tự, không chứa ký tự đặc biệt.",
                                "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Clear();
                txtTenNV.Focus();
                return;
            }

            // Nếu hợp lệ
            errorProvider1.SetError(txtTenNV, "");
            txtTenNV.BackColor = Color.White;
        }

        private bool KiemTraTuoiHopLe(DateTimePicker dtp, out string error)
        {
            error = string.Empty;
            DateTime ngaySinh = dtp.Value;
            int tuoi = DateTime.Now.Year - ngaySinh.Year;

            // Nếu chưa đến sinh nhật năm nay thì trừ 1
            if (DateTime.Now.Date < ngaySinh.AddYears(tuoi))
                tuoi--;

            if (tuoi < 18)
            {
                error = "Nhân viên phải đủ 18 tuổi trở lên!";
                dtp.Focus();
                return false;
            }

            return true;
        }

        public bool KiemTraDinhDangSo(string luong)
        {
            bool flag = false;
            string pattern = @"^\d+$";
            if (string.IsNullOrWhiteSpace(luong))
                return flag;
            if (Regex.IsMatch(luong.Trim(), pattern))
                flag = true;
            return flag;
        }
        private void txtLuong_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                errorProvider1.SetError(txtLuong, ""); // Xóa lỗi
                txtLuong.BackColor = Color.White; // Trả lại màu bình thường
                return;
            }

            //Ktra nhập có đúng định dạng số không
            if (!KiemTraDinhDangSo(txtLuong.Text))
            {
                txtLuong.BackColor = Color.LightPink; // Highlight đỏ hồng khi sai
                errorProvider1.SetError(txtLuong, "Vui lòng nhập số hợp lệ."); // hiện icon lỗi
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Clear();
                txtLuong.Focus(); // Trả lại con trỏ để sửa
            }
            else
            {
                errorProvider1.SetError(txtLuong, ""); // Xóa icon lỗi
                txtLuong.BackColor = Color.White; // Đúng thì trả về màu bình thường
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            string error;
            if (!KiemTraTuoiHopLe(dtpNgaySinh, out error))
            {
                errorProvider1.SetError(dtpNgaySinh, error);
                dtpNgaySinh.CalendarForeColor = Color.Red;
            }
            else
            {
                errorProvider1.SetError(dtpNgaySinh, "");
                dtpNgaySinh.CalendarForeColor = Color.Black;
            }
        }
    }
}
