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
    public partial class BienLai : Form
    {
        
        public BienLai(string madn)
        {
            InitializeComponent();
            txtmanv.Text = dn.LayNhanVienTuDangNhap(madn);
        }
    
        BUS_BienLai bUS_BienLai = new BUS_BienLai();
        BUS_DangNhap dn = new BUS_DangNhap();

        private void BienLai_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgvbienlai.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvbienlai.RowsDefaultCellStyle.BackColor = Color.White;
            dgvbienlai.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgvmakh.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvmakh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmakh.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng
            
            AddToCombo(bUS_BienLai.LoadDSTenGD(), cbomagd);
            AddToCombo(bUS_BienLai.LoadDSTenNT(), cbomant);
            dgvmakh.DataSource = bUS_BienLai.LoadDSKH();
            HienThiDS();
            cbomagd.SelectedIndex = -1;
            cbomant.SelectedIndex = -1;
            cbomatk.SelectedIndex = -1;
            cbotrangthai.SelectedIndex = -1;
        }

        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        public void Clear()
        {
            txtmabl.Clear();
            txtmakh.Clear();
            txtsotien.Clear();
            rtxtmota.Clear();
            cbomagd.SelectedIndex = -1;
            cbomant.SelectedIndex = -1;
            cbomatk.SelectedIndex = -1;
            cbotrangthai.SelectedIndex = -1;
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_HuyAn.Visible = true;
                dgvbienlai.DataSource = bUS_BienLai.LoadDSBienLai();
            }
            else
            {
                dgvbienlai.DataSource = bUS_BienLai.LoadDSBienLaiuser();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TrangThai = "Hoạt Động";
                ET_BienLai ck = new ET_BienLai(bUS_BienLai.DemMa(),
                                                       bUS_BienLai.LayTenGD(cbomagd.Text),
                                                       txtmakh.Text,
                                                       cbomatk.Text,
                                                       txtmanv.Text,
                                                       decimal.Parse(txtsotien.Text),
                                                       bUS_BienLai.LayTenNT(cbomant.Text),
                                                       rtxtmota.Text,
                                                       cbotrangthai.Text,                            
                                                       TrangThai);
                if (string.IsNullOrWhiteSpace(cbomagd.Text))
                {
                    MessageBox.Show("Mã giao dịch không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomagd.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtmakh.Text))
                {
                    MessageBox.Show("Mã khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmakh.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbomatk.Text))
                {
                    MessageBox.Show("Mã tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbomant.Text))
                {
                    MessageBox.Show("Mã ngoại tệ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomant.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtsotien.Text))
                {
                    MessageBox.Show("Số tiền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsotien.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbotrangthai.Text))
                {
                    MessageBox.Show("Trạng thái không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbotrangthai.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtmota.Text))
                {
                    MessageBox.Show("Mô tả không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtmota.Focus();
                    return;
                }

                if (bUS_BienLai.ThemBienLai(ck) == true)
                {
                    MessageBox.Show("Thêm biên lai thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm biên lai thất bại!");
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
                ET_BienLai ck = new ET_BienLai(txtmabl.Text,
                                                       bUS_BienLai.LayTenGD(cbomagd.Text),
                                                       txtmakh.Text,
                                                       cbomatk.Text,
                                                       txtmanv.Text,
                                                       decimal.Parse(txtsotien.Text),
                                                       bUS_BienLai.LayTenNT(cbomant.Text),
                                                       rtxtmota.Text,
                                                       cbotrangthai.Text,
                                                       TrangThai);
                if (string.IsNullOrWhiteSpace(cbomagd.Text))
                {
                    MessageBox.Show("Mã giao dịch không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomagd.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtmakh.Text))
                {
                    MessageBox.Show("Mã khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmakh.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbomatk.Text))
                {
                    MessageBox.Show("Mã tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbomant.Text))
                {
                    MessageBox.Show("Mã ngoại tệ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomant.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtsotien.Text))
                {
                    MessageBox.Show("Số tiền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsotien.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbotrangthai.Text))
                {
                    MessageBox.Show("Trạng thái không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbotrangthai.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(rtxtmota.Text))
                {
                    MessageBox.Show("Mô tả không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtmota.Focus();
                    return;
                }
                if (bUS_BienLai.SuaBienLai(ck) == true)
                {
                    MessageBox.Show("Sửa biên lai thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa biên lai thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        private string maKHCu = "";
        private void txtmakh_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmakh.Text))
            {
                errorProvider1.SetError(txtmakh, "");
                txtmakh.BackColor = Color.White;
                return;
            }
            string maKH = txtmakh.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKH(maKH))
            {
                txtmakh.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtmakh, "Mã khách hàng không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtmakh.Focus();
                return;
            }
            else
            {
                txtmakh.BackColor = Color.White;
            }
            errorProvider1.SetError(txtmakh, "");

            string maKHmoi = txtmakh.Text.Trim();

            if (maKHmoi != maKHCu) // Nếu khác giá trị cũ
            {
                maKHCu = maKHmoi; // Cập nhật giá trị mới

                // Xóa toàn bộ dữ liệu trong ComboBox
                cbomatk.Items.Clear();

                // Nếu muốn load mới khi khác thì bật dòng dưới:
                AddToCombo(bUS_BienLai.LoadDSTKtheoMa(maKHmoi), cbomatk);
            }
        }

        private void dgvmakh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmakh.CurrentCell.RowIndex;
                txtmakh.Text = dgvmakh.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }     

        private void dgvbienlai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvbienlai.CurrentCell.RowIndex;
                txtmabl.Text = dgvbienlai.Rows[dong].Cells[0].Value.ToString();
                cbomagd.Text = dgvbienlai.Rows[dong].Cells[1].Value.ToString();
                txtmakh.Text = dgvbienlai.Rows[dong].Cells[2].Value.ToString();
                cbomatk.Text = dgvbienlai.Rows[dong].Cells[3].Value.ToString();
                txtmanv.Text = dgvbienlai.Rows[dong].Cells[4].Value.ToString();
                txtsotien.Text = dgvbienlai.Rows[dong].Cells[5].Value.ToString();
                cbomant.Text = dgvbienlai.Rows[dong].Cells[6].Value.ToString();
                rtxtmota.Text = dgvbienlai.Rows[dong].Cells[7].Value.ToString();
                cbotrangthai.Text = dgvbienlai.Rows[dong].Cells[8].Value.ToString();
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
                    ET_BienLai ck = new ET_BienLai(txtmabl.Text,
                                                       bUS_BienLai.LayTenGD(cbomagd.Text),
                                                       txtmakh.Text,
                                                       cbomatk.Text,
                                                       txtmanv.Text,
                                                       decimal.Parse(txtsotien.Text),
                                                       bUS_BienLai.LayTenNT(cbomant.Text),
                                                       rtxtmota.Text,
                                                       cbotrangthai.Text,
                                                       TrangThai);
                    if (bUS_BienLai.TrangThaiAn(ck) == true)
                    {
                        MessageBox.Show("Xóa biên lai thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa biên lai thất bại!");
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
                ET_BienLai ck = new ET_BienLai(txtmabl.Text,
                                                       bUS_BienLai.LayTenGD(cbomagd.Text),
                                                       txtmakh.Text,
                                                       cbomatk.Text,
                                                       txtmanv.Text,
                                                       decimal.Parse(txtsotien.Text),
                                                       bUS_BienLai.LayTenNT(cbomant.Text),
                                                       rtxtmota.Text,
                                                       cbotrangthai.Text,
                                                       TrangThai);
                if (bUS_BienLai.TrangThaiAn(ck) == true)
                {
                    MessageBox.Show("Hủy ẩn biên lai thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Hủy ẩn biên lai thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
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

        //hàm kiểm tra định dạng mã nhân viên (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaNV(string maNV)
        {
            bool flag = false;
            string pattern = @"^NV\d{4,8}$";
            if (string.IsNullOrWhiteSpace(maNV))
                return flag;
            if (Regex.IsMatch(maNV, pattern))
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

        //hàm kiểm tra định dạng mô tả (chuỗi 100 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangMT(string mota)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,500}$";
            if (string.IsNullOrWhiteSpace(mota))
                return flag;
            if (Regex.IsMatch(mota.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                errorProvider1.SetError(txtmanv, "");
                txtmanv.BackColor = Color.White;
                return;
            }
            string maNV = txtmanv.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaNV(maNV))
            {
                txtmanv.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtmanv, "Mã nhân viên không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtmanv.Focus();
                return;
            }
            else
            {
                txtmanv.BackColor = Color.White;
            }
            errorProvider1.SetError(txtmanv, "");
        }

        private void txtsotien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsotien.Text))
            {
                errorProvider1.SetError(txtsotien, "");
                txtsotien.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangTien(txtsotien.Text))
            {
                txtsotien.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtsotien, "Số tiền không được bỏ trống, ghi ký tự đặc biệt hoặc ghi chữ");
                txtsotien.Focus();
                return;
            }
            else
            {
                txtsotien.BackColor = Color.White;
            }
            errorProvider1.SetError(txtsotien, "");
        }

        private void rtxtmota_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtmota.Text))
            {
                errorProvider1.SetError(rtxtmota, "");
                rtxtmota.BackColor = Color.White;
                return;
            }
            if (!KiemTraDinhDangMT(rtxtmota.Text))
            {
                rtxtmota.BackColor = Color.LightCoral;
                errorProvider1.SetError(rtxtmota, "Mô tả không được ghi ký tự đặc biệt");
                rtxtmota.Focus();
                return;
            }
            else
            {
                rtxtmota.BackColor = Color.White;
            }
            errorProvider1.SetError(rtxtmota, "");
        }
    }
}
