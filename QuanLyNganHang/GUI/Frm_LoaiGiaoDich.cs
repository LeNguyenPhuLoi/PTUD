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
    public partial class Frm_LoaiGiaoDich : Form
    {
        public Frm_LoaiGiaoDich()
        {
            InitializeComponent();
        }

        BUS_LoaiGiaoDich BUS_LoaiGiaoDich = new BUS_LoaiGiaoDich();

        private void Cutom_Resize()
        {
            int width = this.Width;
            int height = this.Height;
            panel_ThongTin1.Location = new Point(4, 54);
            panel_LoaiGiaoDich.Size = new Size(width - 537, height - 54);
            dgv_LoaiGiaoDich.Size = new Size(panel_LoaiGiaoDich.Width + 300, panel_LoaiGiaoDich.Height + 300);
            panel_LoaiGiaoDich.Location = new Point(537, 54);
        }

        private void Frm_LoaiGiaoDich_Load(object sender, EventArgs e)
        {
            ChinhMauDGV();
            dtp_NgayLap.MaxDate = DateTime.Now;
            dtp_NgayCapNhat.MaxDate = DateTime.Now;
            cbo_TrangThai.SelectedIndex = 0;
            Cutom_Resize();
            HienThiDS();
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_HuyAn.Visible = true;
            }
            else
            {
                dgv_LoaiGiaoDich.Columns["TinhTrangXoa"].Visible = false;
                dgv_LoaiGiaoDich.Columns["MaLoaiGD"].Visible = false;
            }
        }

        public void ChinhMauDGV()
        {
            //màu cho dòng chẵn
            dgv_LoaiGiaoDich.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_LoaiGiaoDich.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiGiaoDich.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiGiaoDich.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_LoaiGiaoDich.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_LoaiGiaoDich.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiGiaoDich.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiGiaoDich.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_LoaiGiaoDich.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_LoaiGiaoDich.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_LoaiGiaoDich.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_LoaiGiaoDich.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_LoaiGiaoDich.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_LoaiGiaoDich.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_LoaiGiaoDich.RowHeadersVisible = false;
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_LoaiGiaoDich.LayDSToanBoLoaiGiaoDich();
                dgv_LoaiGiaoDich.DataSource = ds;
            }
            else
            {
                var ds = BUS_LoaiGiaoDich.LayDSLoaiGiaoDichConHoatDong();
                dgv_LoaiGiaoDich.DataSource = ds;
            }
        }

        public void Clear()
        {
            txt_MaLoaiGD.Clear();
            txt_TenLoaiGD.Clear();
            dtp_NgayLap.Text = dtp_NgayLap.MaxDate.ToString();
            dtp_NgayCapNhat.MinDate = dtp_NgayLap.MinDate;
            dtp_NgayCapNhat.Text = dtp_NgayCapNhat.MaxDate.ToString();
            cbo_TrangThai.SelectedIndex = 0;

            txt_MaLoaiGD.BackColor = SystemColors.Window;
            txt_TenLoaiGD.BackColor = SystemColors.Window;
        }

        private void Frm_LoaiGiaoDich_Resize(object sender, EventArgs e)
        {
        }

        private void Frm_LoaiGiaoDich_ResizeEnd(object sender, EventArgs e)
        {
            Cutom_Resize();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
            HienThiDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (BUS_LoaiGiaoDich.KiemTraTonTaiTenLoaiGD(txt_TenLoaiGD.Text.Trim()))
            {
                MessageBox.Show("Tên loại giao dịch này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenLoaiGD.Focus();
                return;
            }

            int soluong = BUS_LoaiGiaoDich.DemSoLuongLoaiGiaoDich();
            int soluongmoi = soluong + 1;
            string maloaigd = "LGD" + soluongmoi.ToString("D3");

            try
            {
                ET_LoaiGiaoDich lgd = new ET_LoaiGiaoDich(maloaigd,
                                                            txt_TenLoaiGD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiGiaoDich.ThemLoaiGiaoDich(lgd) == true)
                {
                    MessageBox.Show("Thêm loại giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        //hàm kiểm tra định dạng tên loại giao dịch (chuỗi 30 lý tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangTenLoaiGD(string chitiet)
        {
            bool flag = false;
            string pattern = @"^[a-zA-ZÀ-ỹ0-9\s]{1,30}$";
            if (string.IsNullOrWhiteSpace(chitiet))
                return flag;
            if (Regex.IsMatch(chitiet, pattern))
                flag = true;
            return flag;
        }

        private bool KiemTraTatCaTruongNhap()
        {
            var dsham = new Dictionary<string, Tuple<Func<bool>, Control>>();
            {
                dsham.Add("Tên loại giao dịch", Tuple.Create((Func<bool>)(() => KiemTraDinhDangTenLoaiGD(txt_TenLoaiGD.Text)), (Control)txt_TenLoaiGD));
            }
            ;

            foreach (var saidinhdang in dsham)
            {
                string truong = saidinhdang.Key;
                Func<bool> check = saidinhdang.Value.Item1;
                Control control = saidinhdang.Value.Item2;  // Lấy Control tương ứng với trường

                if (!check())
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show($"Trường {truong} không phù hợp định dạng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Focus vào trường có lỗi
                    control.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (BUS_LoaiGiaoDich.LayTenLoaiGDTheoMaLoaiGD(txt_MaLoaiGD.Text.Trim()) != txt_TenLoaiGD.Text)
            {
                if (BUS_LoaiGiaoDich.KiemTraTonTaiTenLoaiGD(txt_TenLoaiGD.Text.Trim()))
                {
                    MessageBox.Show("Loại giao dịch này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenLoaiGD.Focus();
                    return;
                }
            }

            try
            {
                ET_LoaiGiaoDich lgd = new ET_LoaiGiaoDich(txt_MaLoaiGD.Text.Trim().ToUpper(),
                                                            txt_TenLoaiGD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiGiaoDich.SuaLoaiGiaoDich(lgd) == true)
                {
                    MessageBox.Show("Sửa loại giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Sửa loại giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ET_LoaiGiaoDich lgd = new ET_LoaiGiaoDich(txt_MaLoaiGD.Text.Trim().ToUpper(),
                                                            txt_TenLoaiGD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            true);
                    if (BUS_LoaiGiaoDich.AnLoaiGiaoDich(lgd) == true)
                    {
                        MessageBox.Show("Xóa loại giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Xóa loại giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                ET_LoaiGiaoDich lgd = new ET_LoaiGiaoDich(txt_MaLoaiGD.Text.Trim().ToUpper(),
                                                            txt_TenLoaiGD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                             false);
                if (BUS_LoaiGiaoDich.AnLoaiGiaoDich(lgd) == true)
                {
                    MessageBox.Show("Hủy Ẩn loại giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Hủy Ẩn loại giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void dtp_NgayLap_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtp_NgayCapNhat.MinDate = dtp_NgayLap.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_LoaiGiaoDich_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_LoaiGiaoDich.RowCount > 0)
                {
                    int dong = dgv_LoaiGiaoDich.CurrentCell.RowIndex;
                    txt_MaLoaiGD.Text = dgv_LoaiGiaoDich.Rows[dong].Cells[0].Value.ToString();
                    txt_TenLoaiGD.Text = dgv_LoaiGiaoDich.Rows[dong].Cells[1].Value.ToString();
                    dtp_NgayLap.Text = dgv_LoaiGiaoDich.Rows[dong].Cells[2].Value.ToString();
                    dtp_NgayCapNhat.Text = dgv_LoaiGiaoDich.Rows[dong].Cells[3].Value.ToString();
                    cbo_TrangThai.Text = dgv_LoaiGiaoDich.Rows[dong].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txt_TenLoaiGD_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangTenLoaiGD(txt_TenLoaiGD.Text))
            {
                txt_TenLoaiGD.BackColor = Color.LightCoral;
            }
            else
            {
                txt_TenLoaiGD.BackColor = SystemColors.Window;
            }
        }
    }
}
