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

using ET;
using BUS;

namespace GUI
{
    public partial class Frm_LoaiTaiKhoan : Form
    {
        public Frm_LoaiTaiKhoan()
        {
            InitializeComponent();
        }

        BUS_LoaiTaiKhoan BUS_LoaiTaiKhoan = new BUS_LoaiTaiKhoan();

        private void Cutom_Resize()
        {
            int width = this.Width;
            int height = this.Height;
            panel_ThongTin1.Location = new Point(4, 54);
            panel_LoaiTaiKhoan.Size = new Size(width - 537, height - 54);
            dgv_LoaiTaiKhoan.Size = new Size(panel_LoaiTaiKhoan.Width + 300, panel_LoaiTaiKhoan.Height + 300);
            panel_LoaiTaiKhoan.Location = new Point(537, 54);
        }

        private void Frm_LoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            ChinhMauDGV();           
            dtp_NgayTao.MaxDate = DateTime.Now;
            dtp_NgayCapNhat.MaxDate = DateTime.Now;
            cbo_TrangThai.SelectedIndex = 0;
            Cutom_Resize();
            HienThiDS();
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                panel_Admin.Visible = true;
            }
            else
            {
                dgv_LoaiTaiKhoan.Columns["TinhTrangXoa"].Visible = false;
            }
        }

        public void ChinhMauDGV()
        {
            //màu cho dòng chẵn
            dgv_LoaiTaiKhoan.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_LoaiTaiKhoan.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiTaiKhoan.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiTaiKhoan.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_LoaiTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_LoaiTaiKhoan.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiTaiKhoan.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiTaiKhoan.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_LoaiTaiKhoan.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_LoaiTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_LoaiTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_LoaiTaiKhoan.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_LoaiTaiKhoan.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_LoaiTaiKhoan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_LoaiTaiKhoan.RowHeadersVisible = false;
        }

        public void Clear()
        {
            txt_MaLoaiTK.Clear();
            txt_ChiTiet.Clear();
            dtp_NgayTao.Text = dtp_NgayTao.MaxDate.ToString();
            dtp_NgayCapNhat.MinDate = dtp_NgayTao.MinDate;
            dtp_NgayCapNhat.Text = dtp_NgayCapNhat.MaxDate.ToString();
            cbo_TrangThai.SelectedIndex = 0;

            txt_MaLoaiTK.BackColor = SystemColors.Window;
            txt_ChiTiet.BackColor = SystemColors.Window;
        }

        private void Frm_LoaiTaiKhoan_Resize(object sender, EventArgs e)
        {
            
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
            HienThiDS();
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_LoaiTaiKhoan.LayDSToanBoLoaiTaiKhoan();
                dgv_LoaiTaiKhoan.DataSource = ds;
            }
            else
            {
                var ds = BUS_LoaiTaiKhoan.LayDSLoaiTaiKhoanConHoatDong();
                dgv_LoaiTaiKhoan.DataSource = ds;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (BUS_LoaiTaiKhoan.KiemTraTonTaiMaLoaiTK(txt_MaLoaiTK.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Mã loại tài khoản này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BUS_LoaiTaiKhoan.KiemTraTonTaiChiTiet(txt_ChiTiet.Text.Trim()))
            {
                MessageBox.Show("Chi tiết này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text.Trim().ToUpper(),
                                                            txt_ChiTiet.Text,
                                                            dtp_NgayTao.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiTaiKhoan.ThemLoaiTaiKhoan(ltk) == true)
                {
                    MessageBox.Show("Thêm loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!KiemTraTatCaTruongNhap())
                return;

            if (BUS_LoaiTaiKhoan.KiemTraTonTaiChiTiet(txt_ChiTiet.Text.Trim()))
            {
                MessageBox.Show("Chi tiết này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text.Trim().ToUpper(),
                                                            txt_ChiTiet.Text,
                                                            dtp_NgayTao.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiTaiKhoan.SuaLoaiTaiKhoan(ltk) == true)
                {
                    MessageBox.Show("Sửa loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Sửa loại tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text.Trim().ToUpper(),
                                                            txt_ChiTiet.Text,
                                                            dtp_NgayTao.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            true);
                    if (this.MdiParent.Name == "frmMainAddmin")
                    {
                        if (BUS_LoaiTaiKhoan.XoaLoaiTaiKhoan(ltk) == true)
                        {
                            MessageBox.Show("Xóa loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể Xóa loại tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (BUS_LoaiTaiKhoan.AnLoaiTaiKhoan(ltk) == true)
                        {
                            MessageBox.Show("Xóa loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể Xóa loại tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void btn_AnLTK_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text.Trim().ToUpper(),
                                                            txt_ChiTiet.Text,
                                                            dtp_NgayTao.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            true);
                if (BUS_LoaiTaiKhoan.AnLoaiTaiKhoan(ltk) == true)
                {
                    MessageBox.Show("Ẩn loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Ẩn loại tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text.Trim().ToUpper(),
                                                             txt_ChiTiet.Text,
                                                             dtp_NgayTao.Value,
                                                             dtp_NgayCapNhat.Value,
                                                             cbo_TrangThai.Text,
                                                             false);
                if (BUS_LoaiTaiKhoan.AnLoaiTaiKhoan(ltk) == true)
                {
                    MessageBox.Show("Hủy Ẩn loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Hủy Ẩn loại tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void dtp_NgayTao_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtp_NgayCapNhat.MinDate = dtp_NgayTao.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_LoaiTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_LoaiTaiKhoan.RowCount > 0)
                {
                    int dong = dgv_LoaiTaiKhoan.CurrentCell.RowIndex;
                    txt_MaLoaiTK.Text = dgv_LoaiTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                    txt_ChiTiet.Text = dgv_LoaiTaiKhoan.Rows[dong].Cells[1].Value.ToString();
                    dtp_NgayTao.Text = dgv_LoaiTaiKhoan.Rows[dong].Cells[2].Value.ToString();
                    dtp_NgayCapNhat.Text = dgv_LoaiTaiKhoan.Rows[dong].Cells[3].Value.ToString();
                    cbo_TrangThai.Text = dgv_LoaiTaiKhoan.Rows[dong].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //hàm kiểm tra định dạng mã loại tài khoản (10 ký tự, không ký tự đặc biệt, không khoảng trống)
        private bool KiemTraDinhDangMaLTK(string maltk)
        {
            bool flag = false;
            string pattern = @"^LTK\d{3,8}$";
            if (string.IsNullOrWhiteSpace(maltk))
                return flag;
            if (Regex.IsMatch(maltk, pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng chi tiết (chuỗi 30 lý tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangChiTiet(string chitiet)
        {
            bool flag = false;
            string pattern = @"^[a-zA-ZÀ-ỹ0-9\s]{1,30}$";
            if (string.IsNullOrWhiteSpace(chitiet))
                return flag;
            if (Regex.IsMatch(chitiet, pattern))
                flag = true;
            return flag;
        }

        private void txt_MaLoaiTK_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangMaLTK(txt_MaLoaiTK.Text.Trim().ToUpper()))
            {
                txt_MaLoaiTK.BackColor = Color.LightCoral;
            }
            else
            {
                txt_MaLoaiTK.BackColor = SystemColors.Window;
            }
        }

        private void txt_ChiTiet_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangChiTiet(txt_ChiTiet.Text))
            {
                txt_ChiTiet.BackColor = Color.LightCoral;
            }
            else
            {
                txt_ChiTiet.BackColor = SystemColors.Window;
            }
        }

        private void Frm_LoaiTaiKhoan_ResizeEnd(object sender, EventArgs e)
        {
            Cutom_Resize();
        }

        private bool KiemTraTatCaTruongNhap()
        {
            var dsham = new Dictionary<string, Func<bool>>
            {
                { "Mã Loại Tài Khoản", () => KiemTraDinhDangMaLTK(txt_MaLoaiTK.Text.Trim().ToUpper()) },
                { "Tên Khách Hàng", () => KiemTraDinhDangChiTiet(txt_ChiTiet.Text) },
            };

            foreach (var saidinhdang in dsham)
            {
                string truong = saidinhdang.Key;
                Func<bool> check = saidinhdang.Value;

                if (!check())
                {
                    MessageBox.Show($"Trường {truong} không phù hợp định dạng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
    }
}
