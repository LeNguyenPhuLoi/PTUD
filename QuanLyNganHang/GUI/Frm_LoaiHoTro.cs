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
    public partial class Frm_LoaiHoTro : Form
    {
        public Frm_LoaiHoTro()
        {
            InitializeComponent();
        }

        BUS_LoaiHoTro BUS_LoaiHoTro = new BUS_LoaiHoTro();

        private void Cutom_Resize()
        {
            int width = this.Width;
            int height = this.Height;
            panel_ThongTin1.Location = new Point(4, 54);
            panel_LoaiHoTro.Size = new Size(width - 537, height - 54);
            dgv_LoaiHoTro.Size = new Size(panel_LoaiHoTro.Width + 300, panel_LoaiHoTro.Height + 300);
            panel_LoaiHoTro.Location = new Point(537, 54);
        }

        private void Frm_LoaiHoTro_Load(object sender, EventArgs e)
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
                dgv_LoaiHoTro.Columns["TinhTrangXoa"].Visible = false;
                dgv_LoaiHoTro.Columns["MaLoaiHT"].Visible = false;
            }
        }

        public void ChinhMauDGV()
        {
            //màu cho dòng chẵn
            dgv_LoaiHoTro.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_LoaiHoTro.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiHoTro.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiHoTro.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_LoaiHoTro.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_LoaiHoTro.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_LoaiHoTro.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_LoaiHoTro.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_LoaiHoTro.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_LoaiHoTro.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_LoaiHoTro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_LoaiHoTro.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_LoaiHoTro.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_LoaiHoTro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_LoaiHoTro.RowHeadersVisible = false;
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_LoaiHoTro.LayDSToanBoLoaiHoTro();
                dgv_LoaiHoTro.DataSource = ds;
            }
            else
            {
                var ds = BUS_LoaiHoTro.LayDSLoaiHoTroConHoatDong();
                dgv_LoaiHoTro.DataSource = ds;
            }
        }

        public void Clear()
        {
            txt_MaLoaiHT.Clear();
            txt_TenLoaiHT.Clear();
            dtp_NgayLap.Text = dtp_NgayLap.MaxDate.ToString();
            dtp_NgayCapNhat.MinDate = dtp_NgayLap.MinDate;
            dtp_NgayCapNhat.Text = dtp_NgayCapNhat.MaxDate.ToString();
            cbo_TrangThai.SelectedIndex = 0;

            txt_MaLoaiHT.BackColor = SystemColors.Window;
            txt_TenLoaiHT.BackColor = SystemColors.Window;
        }

        private void Frm_LoaiHoTro_Resize(object sender, EventArgs e)
        {
        }

        private void Frm_LoaiHoTro_ResizeEnd(object sender, EventArgs e)
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

            if (BUS_LoaiHoTro.KiemTraTonTaiTenLoaiHT(txt_TenLoaiHT.Text.Trim()))
            {
                MessageBox.Show("Tên loại hỗ trợ này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenLoaiHT.Focus();
                return;
            }

            int soluong = BUS_LoaiHoTro.DemSoLuongLoaiHoTro();
            int soluongmoi = soluong + 1;
            string maloaiht = "LHT" + soluongmoi.ToString("D3");

            try
            {
                ET_LoaiHoTro lht = new ET_LoaiHoTro(maloaiht,
                                                            txt_TenLoaiHT.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiHoTro.ThemLoaiHoTro(lht) == true)
                {
                    MessageBox.Show("Thêm loại hỗ trợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        //hàm kiểm tra định dạng tên loại hỗ trợ (chuỗi 30 lý tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangTenLoaiHT(string chitiet)
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
                dsham.Add("Tên loại hỗ trợ", Tuple.Create((Func<bool>)(() => KiemTraDinhDangTenLoaiHT(txt_TenLoaiHT.Text)), (Control)txt_TenLoaiHT));
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

            if (BUS_LoaiHoTro.LayTenLoaiHTTheoMaLoaiHT(txt_MaLoaiHT.Text.Trim()) != txt_TenLoaiHT.Text)
            {
                if (BUS_LoaiHoTro.KiemTraTonTaiTenLoaiHT(txt_TenLoaiHT.Text.Trim()))
                {
                    MessageBox.Show("Loại hỗ trợ này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenLoaiHT.Focus();
                    return;
                }
            }

            try
            {
                ET_LoaiHoTro lht = new ET_LoaiHoTro(txt_MaLoaiHT.Text.Trim().ToUpper(),
                                                            txt_TenLoaiHT.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            false);
                if (BUS_LoaiHoTro.SuaLoaiHoTro(lht) == true)
                {
                    MessageBox.Show("Sửa loại hỗ trợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Sửa loại hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ET_LoaiHoTro lht = new ET_LoaiHoTro(txt_MaLoaiHT.Text.Trim().ToUpper(),
                                                            txt_TenLoaiHT.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                            true);
                    if (BUS_LoaiHoTro.AnLoaiHoTro(lht) == true)
                    {
                        MessageBox.Show("Xóa loại hỗ trợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Xóa loại hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ET_LoaiHoTro lht = new ET_LoaiHoTro(txt_MaLoaiHT.Text.Trim().ToUpper(),
                                                            txt_TenLoaiHT.Text,
                                                            dtp_NgayLap.Value,
                                                            dtp_NgayCapNhat.Value,
                                                            cbo_TrangThai.Text,
                                                             false);
                if (BUS_LoaiHoTro.AnLoaiHoTro(lht) == true)
                {
                    MessageBox.Show("Hủy Ẩn loại hỗ trợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Hủy Ẩn loại hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_LoaiHoTro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_LoaiHoTro.RowCount > 0)
                {
                    int dong = dgv_LoaiHoTro.CurrentCell.RowIndex;
                    txt_MaLoaiHT.Text = dgv_LoaiHoTro.Rows[dong].Cells[0].Value.ToString();
                    txt_TenLoaiHT.Text = dgv_LoaiHoTro.Rows[dong].Cells[1].Value.ToString();
                    dtp_NgayLap.Text = dgv_LoaiHoTro.Rows[dong].Cells[2].Value.ToString();
                    dtp_NgayCapNhat.Text = dgv_LoaiHoTro.Rows[dong].Cells[3].Value.ToString();
                    cbo_TrangThai.Text = dgv_LoaiHoTro.Rows[dong].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txt_TenLoaiHT_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangTenLoaiHT(txt_TenLoaiHT.Text))
            {
                txt_TenLoaiHT.BackColor = Color.LightCoral;
            }
            else
            {
                txt_TenLoaiHT.BackColor = SystemColors.Window;
            }
        }
    }
}
