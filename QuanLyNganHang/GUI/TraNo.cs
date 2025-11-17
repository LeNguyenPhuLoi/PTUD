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
    public partial class frmLichSuTraNo : Form
    {
        public frmLichSuTraNo()
        {
            InitializeComponent();
        }

        BUS_TraNo bUS_TraNo = new BUS_TraNo();

        private void frmLichSuTraNo_Load(object sender, EventArgs e)
        {
            // Màu nền khi chọn ô (dòng)
            dgvTraNo.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvTraNo.RowsDefaultCellStyle.BackColor = Color.White;
            dgvTraNo.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            // Màu nền khi chọn ô (dòng)
            dgvmakv.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvmakv.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmakv.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng

            dgvmakv.DataSource = bUS_TraNo.LoadDSKhoanVay();
            dtpNgayTra.MaxDate = DateTime.Now;
            dtpNgayTra.Value = dtpNgayTra.MaxDate;
            HienThiDS();
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                dgvTraNo.DataSource = bUS_TraNo.LoadDSTraNo();
                dgvTraNo.Columns["KHOANVAY"].Visible = false;
                dgvmakv.DataSource = bUS_TraNo.LoadDSKhoanVay();
            }
            else
            {
                dgvTraNo.DataSource = bUS_TraNo.LoadDSTraNouser();
                dgvTraNo.Columns["KHOANVAY"].Visible = false;
                dgvTraNo.Columns["TinhTrangXoa"].Visible = false;
                btn_HuyAn.Visible = false;
                dgvmakv.DataSource = bUS_TraNo.LoadDSKhoanVay();
            }
        }

        private void dgvmakv_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvmakv.CurrentCell.RowIndex;
                txtmakv.Text = dgvmakv.Rows[dong].Cells[0].Value.ToString();
                txttienno.Text = dgvmakv.Rows[dong].Cells[1].Value.ToString();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void dgvTraNo_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvTraNo.CurrentCell.RowIndex;
                txtmatn.Text = dgvTraNo.Rows[dong].Cells[0].Value.ToString();
                txtmakv.Text = dgvTraNo.Rows[dong].Cells[1].Value.ToString();
                txttienno.Text = dgvTraNo.Rows[dong].Cells[2].Value.ToString();
                txttientra.Text = dgvTraNo.Rows[dong].Cells[3].Value.ToString();
                dtpNgayTra.Text = dgvTraNo.Rows[dong].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        public void Clear()
        {
            txtmatn.Clear();
            txtmakv.Clear();
            txttienno.Clear();
            txttientra.Clear();
            dtpNgayTra.Value = dtpNgayTra.MaxDate;
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
                ET_TraNo tn = new ET_TraNo(bUS_TraNo.DemMa(),
                                            txtmakv.Text,
                                            decimal.Parse(txttienno.Text),
                                            decimal.Parse(txttientra.Text),
                                            dtpNgayTra.Value,
                                            TrangThai);

                if (string.IsNullOrWhiteSpace(txtmakv.Text))
                {
                    MessageBox.Show("Mã khoản vay không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmakv.Focus();
                    return;
                }

                if (txttientra.Text == null)
                {
                    MessageBox.Show("Số tiền trả không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttientra.Focus();
                    return;
                }

                if (bUS_TraNo.ThemTraNo(tn) == true)
                {
                    MessageBox.Show("Thêm trả nợ thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm trả nợ thất bại!");
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
                    ET_TraNo tn = new ET_TraNo(txtmatn.Text,
                                            txtmakv.Text,
                                            decimal.Parse(txttienno.Text),
                                            decimal.Parse(txttientra.Text),
                                            dtpNgayTra.Value,
                                            TrangThai);
                    if (bUS_TraNo.TrangThaiAn(tn) == true)
                    {
                        MessageBox.Show("Xóa trả nợ thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa trả nợ thất bại!");
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
                ET_TraNo tn = new ET_TraNo(txtmatn.Text,
                                            txtmakv.Text,
                                            decimal.Parse(txttientra.Text),
                                            decimal.Parse(txttienno.Text),
                                            dtpNgayTra.Value,
                                            TrangThai);
                if (bUS_TraNo.TrangThaiAn(tn) == true)
                {
                    MessageBox.Show("Hủy ẩn trả nợ thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Hủy ẩn trả nợ thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            HienThiDS();
        }

        //hàm kiểm tra định dạng mã khoản vay (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaKV(string maKV)
        {
            bool flag = false;
            string pattern = @"^VAY\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maKV))
                return flag;
            if (Regex.IsMatch(maKV, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng số tiền (không chữ, không ký tự đặc biệt)
        private bool KiemTraDinhDangTienTra(string tientra)
        {
            bool flag = false;
            string pattern = @"^\d{1,9}$";
            if (string.IsNullOrWhiteSpace(tientra))
                return flag;
            if (Regex.IsMatch(tientra.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txtmakv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmakv.Text))
            {
                errorProvider1.SetError(txtmakv, "");
                txtmakv.BackColor = Color.White;
                return;
            }
            string maKV = txtmakv.Text.Trim().ToUpper();
            if (!KiemTraDinhDangMaKV(maKV))
            {
                txtmakv.BackColor = Color.LightCoral;
                errorProvider1.SetError(txtmakv, "Mã khoản vay không được bỏ trống hoặc ghi ký tự đặc biệt");
                txtmakv.Focus();
                return;
            }
            else
            {
                txtmakv.BackColor = Color.White;
            }
            errorProvider1.SetError(txtmakv, "");
        }

        private void txttientra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttientra.Text))
            {
                errorProvider1.SetError(txttientra, "");
                txttientra.BackColor = Color.White;
                return;
            }
            string maKV = txttientra.Text.Trim().ToUpper();
            if (!KiemTraDinhDangTienTra(maKV))
            {
                txttientra.BackColor = Color.LightCoral;
                errorProvider1.SetError(txttientra, "Số tiền không được bỏ trống hoặc ghi ký tự đặc biệt");
                txttientra.Focus();
                return;
            }
            else
            {
                txttientra.BackColor = Color.White;
            }
            errorProvider1.SetError(txttientra, "");
        }
    }
}
