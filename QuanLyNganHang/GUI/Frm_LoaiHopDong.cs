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
    public partial class Frm_LoaiHopDong : Form
    {
        public Frm_LoaiHopDong()
        {
            InitializeComponent();
        }

        BUS_LoaiHopDong BUS_LoaiHopDong = new BUS_LoaiHopDong();

        private void Cutom_Resize()
        {
            int width = this.Width;
            int height = this.Height;
            panel_ThongTin1.Location = new Point(4, 54);
            panel_LoaiHopDong.Size = new Size(width - 537, height - 54);
            dgv_LoaiHopDong.Size = new Size(panel_LoaiHopDong.Width + 300, panel_LoaiHopDong.Height + 300);
            panel_LoaiHopDong.Location = new Point(537, 54);
        }

        private void Frm_LoaiHopDong_Load(object sender, EventArgs e)
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
                dgv_LoaiHopDong.Columns["TinhTrangXoa"].Visible = false;
                dgv_LoaiHopDong.Columns["MaLoaiHD"].Visible = false;
            }
        }

        public void ChinhMauDGV()
        {
            //màu cho dòng chẵn
            dgv_LoaiHopDong.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_LoaiHopDong.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiHopDong.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiHopDong.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_LoaiHopDong.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_LoaiHopDong.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiHopDong.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiHopDong.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_LoaiHopDong.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_LoaiHopDong.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_LoaiHopDong.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_LoaiHopDong.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_LoaiHopDong.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_LoaiHopDong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_LoaiHopDong.RowHeadersVisible = false;
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_LoaiHopDong.LayDSToanBoLoaiHopDong();
                dgv_LoaiHopDong.DataSource = ds;
            }
            else
            {
                var ds = BUS_LoaiHopDong.LayDSLoaiHopDongConHoatDong();
                dgv_LoaiHopDong.DataSource = ds;
            }
        }

        public void Clear()
        {
            txt_MaLoaiHD.Clear();
            txt_TenLoaiHD.Clear();
            dtp_NgayLap.Text = dtp_NgayLap.MaxDate.ToString();
            dtp_NgayCapNhat.MinDate = dtp_NgayLap.MinDate;
            dtp_NgayCapNhat.Text = dtp_NgayCapNhat.MaxDate.ToString();
            cbo_TrangThai.SelectedIndex = 0;

            txt_MaLoaiHD.BackColor = SystemColors.Window;
            txt_TenLoaiHD.BackColor = SystemColors.Window;
        }

        private void Frm_LoaiHopDong_Resize(object sender, EventArgs e)
        {
        }

        private void Frm_LoaiHopDong_ResizeEnd(object sender, EventArgs e)
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

            if (BUS_LoaiHopDong.KiemTraTonTaiTenLoaiHD(txt_TenLoaiHD.Text.Trim()))
            {
                MessageBox.Show("Tên loại hợp đồng này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenLoaiHD.Focus();
                return;
            }

            int soluong = BUS_LoaiHopDong.DemSoLuongLoaiHopDong();
            int soluongmoi = soluong + 1;
            string maloaihd = "LHD" + soluongmoi.ToString("D3");

            try
            {
                ET_LoaiHopDong lhd = new ET_LoaiHopDong(maloaihd,
                                                            txt_TenLoaiHD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiHopDong.ThemLoaiHopDong(lhd) == true)
                {
                    MessageBox.Show("Thêm loại hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        //hàm kiểm tra định dạng tên loại hợp đồng (chuỗi 30 lý tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangTenLoaiHD(string chitiet)
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
                dsham.Add("Tên loại hợp đồng", Tuple.Create((Func<bool>)(() => KiemTraDinhDangTenLoaiHD(txt_TenLoaiHD.Text)), (Control)txt_TenLoaiHD));
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

            if (BUS_LoaiHopDong.LayTenLoaiHDTheoMaLoaiHD(txt_MaLoaiHD.Text.Trim()) != txt_TenLoaiHD.Text)
            {
                if (BUS_LoaiHopDong.KiemTraTonTaiTenLoaiHD(txt_TenLoaiHD.Text.Trim()))
                {
                    MessageBox.Show("Tên loại hợp đồng này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenLoaiHD.Focus();
                    return;
                }
            }

            try
            {
                ET_LoaiHopDong lhd = new ET_LoaiHopDong(txt_MaLoaiHD.Text.Trim().ToUpper(),
                                                            txt_TenLoaiHD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiHopDong.SuaLoaiHopDong(lhd) == true)
                {
                    MessageBox.Show("Sửa loại hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Sửa loại hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ET_LoaiHopDong lhd = new ET_LoaiHopDong(txt_MaLoaiHD.Text.Trim().ToUpper(),
                                                            txt_TenLoaiHD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            true);
                    if (BUS_LoaiHopDong.AnLoaiHopDong(lhd) == true)
                    {
                        MessageBox.Show("Xóa loại hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Xóa loại hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ET_LoaiHopDong lhd = new ET_LoaiHopDong(txt_MaLoaiHD.Text.Trim().ToUpper(),
                                                            txt_TenLoaiHD.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                             false);
                if (BUS_LoaiHopDong.AnLoaiHopDong(lhd) == true)
                {
                    MessageBox.Show("Hủy Ẩn loại hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Hủy Ẩn loại hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_LoaiHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_LoaiHopDong.RowCount > 0)
                {
                    int dong = dgv_LoaiHopDong.CurrentCell.RowIndex;
                    txt_MaLoaiHD.Text = dgv_LoaiHopDong.Rows[dong].Cells[0].Value.ToString();
                    txt_TenLoaiHD.Text = dgv_LoaiHopDong.Rows[dong].Cells[1].Value.ToString();
                    dtp_NgayLap.Text = dgv_LoaiHopDong.Rows[dong].Cells[2].Value.ToString();
                    dtp_NgayCapNhat.Text = dgv_LoaiHopDong.Rows[dong].Cells[3].Value.ToString();
                    cbo_TrangThai.Text = dgv_LoaiHopDong.Rows[dong].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txt_TenLoaiHD_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangTenLoaiHD(txt_TenLoaiHD.Text))
            {
                txt_TenLoaiHD.BackColor = Color.LightCoral;
            }
            else
            {
                txt_TenLoaiHD.BackColor = SystemColors.Window;
            }
        }
    }
}
