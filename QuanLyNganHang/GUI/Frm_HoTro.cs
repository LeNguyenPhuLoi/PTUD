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
    public partial class Frm_HoTro : Form
    {
        public Frm_HoTro()
        {
            InitializeComponent();
        }

        BUS_HoTro BUS_HoTro = new BUS_HoTro();

        private void Frm_HoTro_Load(object sender, EventArgs e)
        {
            ChinhMauDGV();
            dtp_NgayHoTro.MaxDate = DateTime.Now;
            AddToCBO(cbo_LoaiHT, BUS_HoTro.LayTenLoaiHT());
            cbo_LoaiHT.SelectedIndex = 0;
            HienThiDS();           

            dgv_KhachHang.Columns["TinhTrangXoa"].Visible = false;
            dgv_KhachHang.Columns["MaKH"].Visible = false;

            dgv_NhanVien.Columns["TrangThai"].Visible = false;
            dgv_NhanVien.Columns["MaNV"].Visible = false;


            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_HuyAn.Visible = true;
            }
            else
            {
                dgv_HoTro.Columns["TinhTrangXoa"].Visible = false;
                dgv_HoTro.Columns["MaHTro"].Visible = false;
            }
            Clear();
        }

        public void AddToCBO(ComboBox cbo, IQueryable list)
        {
            foreach (string s in list)
            {
                cbo.Items.Add(s);
            }
        }

        private void Clear()
        {
            txt_MaHoTro.Clear();
            txt_Cccdkh.Clear();
            txt_Cccdnv.Clear();
            cbo_LoaiHT.SelectedIndex = 0;
            txt_NoiDung.Clear();
            dtp_NgayHoTro.Value = dtp_NgayHoTro.MaxDate;

            txt_Cccdkh.BackColor = SystemColors.Window;
            txt_Cccdnv.BackColor = SystemColors.Window;
            txt_NoiDung.BackColor = SystemColors.Window;
        }

        private void HienThiDS()
        {
            dgv_KhachHang.DataSource = BUS_HoTro.LayDSKhachHangConHoatDong();
            dgv_NhanVien.DataSource = BUS_HoTro.LayDSNhanVienConHoatDong();
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_HoTro.LayDSToanBoHoTro();
                dgv_HoTro.DataSource = ds;
            }
            else
            {
                var ds = BUS_HoTro.LayDSHoTroConHoatDong();
                dgv_HoTro.DataSource = ds;
            }
        }

        public void ChinhMauDGV()
        {
            //màu cho dòng chẵn
            dgv_KhachHang.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_KhachHang.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_KhachHang.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_KhachHang.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_KhachHang.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_KhachHang.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_KhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_KhachHang.RowHeadersVisible = false;


            //màu cho dòng chẵn
            dgv_NhanVien.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_NhanVien.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_NhanVien.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_NhanVien.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_NhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_NhanVien.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_NhanVien.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_NhanVien.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_NhanVien.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_NhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_NhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_NhanVien.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_NhanVien.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_NhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_NhanVien.RowHeadersVisible = false;


            //màu cho dòng chẵn
            dgv_HoTro.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_HoTro.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_HoTro.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_HoTro.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_HoTro.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_HoTro.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_HoTro.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_HoTro.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_HoTro.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_HoTro.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_HoTro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_HoTro.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_HoTro.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_HoTro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_HoTro.RowHeadersVisible = false;
        }

        private void Frm_HoTro_Resize(object sender, EventArgs e)
        {
        }

        private void dgv_HoTro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void dgv_HoTro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HoTro.RowCount > 0)
                {
                    int dong = dgv_HoTro.CurrentCell.RowIndex;
                    txt_MaHoTro.Text = dgv_HoTro.Rows[dong].Cells[0].Value.ToString();
                    txt_Cccdkh.Text = BUS_HoTro.LayCccdTheoMaKH(dgv_HoTro.Rows[dong].Cells[1].Value.ToString());
                    txt_Cccdnv.Text = BUS_HoTro.LayCccdTheoMaNV(dgv_HoTro.Rows[dong].Cells[2].Value.ToString());
                    cbo_LoaiHT.Text = BUS_HoTro.LayTenLoaiHTTheoMa(dgv_HoTro.Rows[dong].Cells[3].Value.ToString());
                    txt_NoiDung.Text = dgv_HoTro.Rows[dong].Cells[4].Value.ToString();
                    dtp_NgayHoTro.Text = dgv_HoTro.Rows[dong].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
            HienThiDS();
        }

        //hàm kiểm tra định dạng số CCCD/CMND (chuỗi 12 chữ số, không chữ, không ký tự đặc biệt)
        private bool KiemTraDinhDangCCCD(string cccd)
        {
            bool flag = false;
            string pattern = @"^\d{12}$";
            if (string.IsNullOrWhiteSpace(cccd))
                return flag;
            if (Regex.IsMatch(cccd.Trim(), pattern))
                flag = true;
            return flag;
        }

        //hàm kiểm tra định dạng nội dung (chuỗi 100 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangNoiDung(string diachi)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,100}$";
            if (string.IsNullOrWhiteSpace(diachi))
                return flag;
            if (Regex.IsMatch(diachi.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txt_Cccdkh_TextChanged(object sender, EventArgs e)
        {
            dgv_KhachHang.DataSource = BUS_HoTro.LayDSKhachHangTheoCCCD(txt_Cccdkh.Text);
            if (!KiemTraDinhDangCCCD(txt_Cccdkh.Text.Trim()))
            {
                txt_Cccdkh.BackColor = Color.LightCoral;
            }
            else
            {
                txt_Cccdkh.BackColor = SystemColors.Window;
            }
        }

        private void txt_Cccdnv_TextChanged(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = BUS_HoTro.LayDSNhanVienTheoCCCD(txt_Cccdnv.Text);
            if (!KiemTraDinhDangCCCD(txt_Cccdnv.Text.Trim()))
            {
                txt_Cccdnv.BackColor = Color.LightCoral;
            }
            else
            {
                txt_Cccdnv.BackColor = SystemColors.Window;
            }
        }

        private void txt_NoiDung_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangNoiDung(txt_NoiDung.Text))
            {
                txt_NoiDung.BackColor = Color.LightCoral;
            }
            else
            {
                txt_NoiDung.BackColor = SystemColors.Window;
            }
        }

        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_KhachHang.RowCount > 0)
                {
                    int dong = dgv_KhachHang.CurrentCell.RowIndex;
                    txt_Cccdkh.Text = dgv_KhachHang.Rows[dong].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_NhanVien.RowCount > 0)
                {
                    int dong = dgv_NhanVien.CurrentCell.RowIndex;
                    txt_Cccdnv.Text = dgv_NhanVien.Rows[dong].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private bool KiemTraTatCaTruongNhap()
        {
            var dsham = new Dictionary<string, Tuple<Func<bool>, Control>>();
            dsham.Add("CCCD Khách Hàng", Tuple.Create((Func<bool>)(() => KiemTraDinhDangCCCD(txt_Cccdkh.Text.Trim())), (Control)txt_Cccdkh));
            dsham.Add("CCCD Nhân Viên", Tuple.Create((Func<bool>)(() => KiemTraDinhDangCCCD(txt_Cccdnv.Text.Trim())), (Control)txt_Cccdnv));
            dsham.Add("Nội Dung", Tuple.Create((Func<bool>)(() => KiemTraDinhDangNoiDung(txt_NoiDung.Text)), (Control)txt_NoiDung));


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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (!BUS_HoTro.KiemTraTonTaiCcccKH(txt_Cccdkh.Text.Trim()))
            {
                MessageBox.Show("CCCD Khách Hàng chưa tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cccdkh.Focus();
                return;
            }

            if (!BUS_HoTro.KiemTraTonTaiCcccNV(txt_Cccdnv.Text.Trim()))
            {
                MessageBox.Show("CCCD Nhân Viên chưa tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cccdnv.Focus();
                return;
            }

            int soluong = BUS_HoTro.DemSoLuongHoTro();
            int soluongmoi = soluong + 1;
            string mahotro = "HT" + soluongmoi.ToString("D3");

            try
            {
                ET_HoTro ht = new ET_HoTro(mahotro,
                                                BUS_HoTro.LayMaKHTheoCccd(txt_Cccdkh.Text),
                                                BUS_HoTro.LayManvTheoCccd(txt_Cccdnv.Text),
                                                BUS_HoTro.LayMaLoaiHTTheoTen(cbo_LoaiHT.Text),
                                                txt_NoiDung.Text,
                                                dtp_NgayHoTro.Value,
                                                false);
                if (BUS_HoTro.ThemHoTro(ht) == true)
                {
                    MessageBox.Show("Thêm hỗ trợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể thêm hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ET_HoTro ht = new ET_HoTro(txt_MaHoTro.Text,
                                                BUS_HoTro.LayMaKHTheoCccd(txt_Cccdkh.Text),
                                                BUS_HoTro.LayManvTheoCccd(txt_Cccdnv.Text),
                                                BUS_HoTro.LayMaLoaiHTTheoTen(cbo_LoaiHT.Text),
                                                txt_NoiDung.Text,
                                                dtp_NgayHoTro.Value,
                                                true);
                    if (BUS_HoTro.AnHoTro(ht) == true)
                    {
                        MessageBox.Show("Xóa hỗ trợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể Xóa hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ET_HoTro ht = new ET_HoTro(txt_MaHoTro.Text,
                                                BUS_HoTro.LayMaKHTheoCccd(txt_Cccdkh.Text),
                                                BUS_HoTro.LayManvTheoCccd(txt_Cccdnv.Text),
                                                BUS_HoTro.LayMaLoaiHTTheoTen(cbo_LoaiHT.Text),
                                                txt_NoiDung.Text,
                                                dtp_NgayHoTro.Value,
                                                false);
                if (BUS_HoTro.AnHoTro(ht) == true)
                {
                    MessageBox.Show("Hủy Xóa hỗ trợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể Hủy Xóa hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }
    }
}
