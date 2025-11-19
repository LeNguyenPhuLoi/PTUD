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

namespace GUI
{
    public partial class frmViPham : Form
    {
        public frmViPham()
        {
            InitializeComponent();
        }
        BUS_ViPham bus =  new BUS_ViPham();
        private void frmViPham_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvViPham.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvViPham.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvViPham.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvViPham.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvViPham.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvViPham.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvViPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvViPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvViPham.RowsDefaultCellStyle.BackColor = Color.White;
            dgvViPham.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvViPham.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvViPham.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvViPham.AllowUserToAddRows = false;//xóa dòng cuối

            var dsNhanVien = bus.LoadNV().ToList();
            AddToCombo(bus.LoadNQ(),cboMaNQ);
            AddToCombo(bus.LoadNV(), cboMaNV);
            dgvViPham.DataSource = bus.LoadViPham();
            // Thiết lập gợi ý cho cả 2 ComboBox
            SetupComboBox(cboMaNQ);
            SetupComboBox(cboMaNV);
            dtpNgayVP.MaxDate = DateTime.Now;
            btnHoanTac_Click(sender, e);
        }

        private void SetupComboBox(ComboBox cbo)
        {
            cbo.AutoCompleteMode = AutoCompleteMode.Suggest; // Hiện gợi ý
            cbo.AutoCompleteSource = AutoCompleteSource.ListItems; // Lấy gợi ý từ danh sách
        }

        private void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        private void cboMaNV_Leave(object sender, EventArgs e)
        {
            // Nếu trống thì cho qua, không báo lỗi
            if (string.IsNullOrWhiteSpace(cboMaNV.Text))
            {
                cboMaNV.BackColor = Color.White;
                return;
            }
            if (!bus.kiemTraDinhDangTenNV(cboMaNV.Text))
            {
                cboMaNV.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                MessageBox.Show("Mã nhân viên không đúng định dạng!\nVD: NV0001 - Nguyễn Văn An",
                                "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }

            // Nếu hợp lệ
            cboMaNV.BackColor = Color.White;
        }

        private void cboMaNQ_Leave(object sender, EventArgs e)
        {
            // Nếu trống thì cho qua, không báo lỗi
            if (string.IsNullOrWhiteSpace(cboMaNQ.Text))
            {
                cboMaNQ.BackColor = Color.White;
                return;
            }
            if (!bus.kiemTraDinhDangNoiQuy(cboMaNQ.Text))
            {
                cboMaNQ.BackColor = Color.MistyRose; // màu nhẹ hơn cho dịu mắt
                MessageBox.Show("Mã nội quy không đúng định dạng!\nVD: NQ0001 - Nội quy làm việc",
                                "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNQ.Focus();
                return;
            }

            // Nếu hợp lệ
            cboMaNQ.BackColor = Color.White;
        }

        private void cboMaNQ_TextChanged(object sender, EventArgs e)
        {
            lbHTXL.Text = (bus.LoadHTXL(bus.LayMa(cboMaNQ.Text))).ToString();
        }

        private void cboMaNQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHTXL.Text = (bus.LoadHTXL(bus.LayMa(cboMaNQ.Text))).ToString();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMAVP.Clear();
            cboMaNQ.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            dtpNgayVP.Value = dtpNgayVP.MaxDate;
            lbHTXL.Text = "Null";
            cboTrangThaiXL.SelectedIndex = 1;
            txtNoiDung.Clear();
            cboMaNQ.Focus();
            dgvViPham.DataSource = bus.LoadViPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai = true;
                ET_ViPham et = new ET_ViPham(bus.MaVP(), bus.LayMa(cboMaNQ.Text),
                                                bus.LayMa(cboMaNV.Text),dtpNgayVP.Value,
                                                txtNoiDung.Text,decimal.Parse(lbHTXL.Text),
                                                cboTrangThaiXL.Text,trangthai);
                string error = "";
                if (bus.ThemVP(et,out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvViPham.DataSource = bus.LoadViPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai = true;
                ET_ViPham et = new ET_ViPham(bus.MaVP(), bus.LayMa(cboMaNQ.Text),
                                                bus.LayMa(cboMaNV.Text), dtpNgayVP.Value,
                                                txtNoiDung.Text, decimal.Parse(lbHTXL.Text),
                                                cboTrangThaiXL.Text, trangthai);
                string error = "";
                if (bus.CapNhatVP(et, out error) == true)
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvViPham.DataSource = bus.LoadViPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool trangthai = false;
                    ET_ViPham et = new ET_ViPham(bus.MaVP(), bus.LayMa(cboMaNQ.Text),
                                                 bus.LayMa(cboMaNV.Text), dtpNgayVP.Value,
                                                 txtNoiDung.Text, decimal.Parse(lbHTXL.Text),
                                                 cboTrangThaiXL.Text, trangthai);
                    string error = "";
                    if (bus.XoaVP(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvViPham.DataSource = bus.LoadViPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViPham_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvViPham.CurrentCell.RowIndex;
                txtMAVP.Text = dgvViPham.Rows[dong].Cells[0].Value.ToString();
                cboMaNQ.Text = bus.LayfullNoiQuy(dgvViPham.Rows[dong].Cells[1].Value.ToString());
                cboMaNV.Text = bus.LayfullNhanVien(dgvViPham.Rows[dong].Cells[2].Value.ToString());
                dtpNgayVP.Text = dgvViPham.Rows[dong].Cells[3].Value.ToString();
                txtNoiDung.Text = dgvViPham.Rows[dong].Cells[4].Value.ToString();
                lbHTXL.Text = dgvViPham.Rows[dong].Cells[5].Value.ToString();
                cboTrangThaiXL.Text = dgvViPham.Rows[dong].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
