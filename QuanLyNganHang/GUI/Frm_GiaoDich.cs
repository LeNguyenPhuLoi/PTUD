using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_GiaoDich : Form
    {
        public Frm_GiaoDich()
        {
            InitializeComponent();
        }

        BUS_GiaoDich BUS_GiaoDich = new BUS_GiaoDich();

        private void Frm_GiaoDich_Load(object sender, EventArgs e)
        {
            ChinhMauDGV();
            AddToCBO(cbo_LoaiGD, BUS_GiaoDich.LayTenLoaiGiaoDich());
            cbo_LoaiGD.SelectedIndex = 0;
            cbo_TrangThai.SelectedIndex = 0;
            dtp_ThoiGianGD.MaxDate = DateTime.Now;
            HienThiDS();
            dgv_KhachHang.Columns["TinhTrangXoa"].Visible = false;
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btn_HuyAn.Visible = true;
            }
            else
            {
                dgv_GiaoDich.Columns["TinhTrangXoa"].Visible = false;
                dgv_GiaoDich.Columns["MaGD"].Visible = false;
                dgv_KhachHang.Columns["MaKH"].Visible = false;
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
            dgv_GiaoDich.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_GiaoDich.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_GiaoDich.RowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_GiaoDich.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu cho dòng lẻ
            dgv_GiaoDich.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_GiaoDich.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_GiaoDich.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgv_GiaoDich.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            //màu header
            dgv_GiaoDich.EnableHeadersVisualStyles = false; // Quan trọng: tắt style mặc định của Windows
            dgv_GiaoDich.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood; // Màu nền tiêu đề
            dgv_GiaoDich.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;     // Màu chữ tiêu đề
            dgv_GiaoDich.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.BurlyWood;
            dgv_GiaoDich.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //căn giữa tiêu đề và ẩn cột mũi tên bên trái
            dgv_GiaoDich.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_GiaoDich.RowHeadersVisible = false;
        }

        private void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                var ds = BUS_GiaoDich.LayToanBoDSGiaoDich();
                dgv_GiaoDich.DataSource = ds;
                var dskh = BUS_GiaoDich.LayDSKhachHangConHoatDong();
                dgv_KhachHang.DataSource = dskh;
            }
            else
            {
                var ds = BUS_GiaoDich.LayDSGiaoDichChuaAn();
                dgv_GiaoDich.DataSource = ds;
                var dskh = BUS_GiaoDich.LayDSKhachHangConHoatDong();
                dgv_KhachHang.DataSource = dskh;
            }
        }

        public void AddToCBO(ComboBox cbo, IQueryable list)
        {
            foreach (string s in list)
            {
                cbo.Items.Add(s);
            }
        }

        public void Clear()
        {
            txt_MaGD.Clear();
            txt_CCCD.Clear();
            cbo_SoTK.Items.Clear();
            cbo_SoTK.Text = string.Empty;
            cbo_SoTkNhan.Text = string.Empty;
            cbo_LoaiGD.SelectedIndex = 0;
            txt_SoTien.Clear();
            dtp_ThoiGianGD.Text = dtp_ThoiGianGD.MaxDate.ToString();
            txt_MoTa.Clear();
            cbo_TrangThai.SelectedIndex = 0;

            txt_MaGD.BackColor = SystemColors.Window;
            txt_CCCD.BackColor = SystemColors.Window;
            txt_SoTien.BackColor = SystemColors.Window;
            txt_MoTa.BackColor = SystemColors.Window;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
            HienThiDS();
        }

        private bool KiemTraHopLeGiaoDich()
        {
            // Kiểm tra chọn số tài khoản
            if (string.IsNullOrWhiteSpace(cbo_SoTK.Text))
            {
                MessageBox.Show("Vui lòng chọn số tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra nhập số tiền
            if (string.IsNullOrWhiteSpace(txt_SoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra số tiền so với tài khoản
            if (!BUS_GiaoDich.SoSanhTien(cbo_SoTK.Text.Trim(), Convert.ToDecimal(txt_SoTien.Text.Trim())))
            {
                MessageBox.Show("Số tiền phải nhỏ hơn hoặc bằng tiền trong tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Hợp lệ
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraTatCaTruongNhap())
                return;

            if (!KiemTraHopLeGiaoDich())
                return;

            int soluong = BUS_GiaoDich.DemSoLuongGiaoDich();
            int soluongmoi = soluong + 1;
            string magd = "GD" + soluongmoi.ToString("D3");

            try
            {
                ET_GiaoDich gd = new ET_GiaoDich(magd,
                                                    BUS_GiaoDich.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    BUS_GiaoDich.LayMaTKTheoSTK(cbo_SoTK.Text),
                                                    string.IsNullOrWhiteSpace(cbo_SoTkNhan.Text) ? null : BUS_GiaoDich.LayMaTKTheoSTK(cbo_SoTkNhan.Text),
                                                    BUS_GiaoDich.LayMaGDTheoTenLoaiGD(cbo_LoaiGD.Text),
                                                    Convert.ToDecimal(txt_SoTien.Text),
                                                    dtp_ThoiGianGD.Value,
                                                    txt_MoTa.Text,
                                                    cbo_TrangThai.Text,
                                                    false);

                if(BUS_GiaoDich.LayPhuongThucTheoTenLoaiGD(cbo_LoaiGD.Text) == "-")
                {
                    if (BUS_GiaoDich.ThemGiaoDichVaTruTien(gd, cbo_SoTK.Text, cbo_SoTkNhan.Text) == true)
                    {
                        MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (BUS_GiaoDich.ThemGiaoDichVaCongTien(gd, cbo_SoTK.Text, cbo_SoTkNhan.Text) == true)
                    {
                        MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void txt_CCCD_TextChanged(object sender, EventArgs e)
        {
            var dskh = BUS_GiaoDich.LayDSKhachHangTheoCCCD(txt_CCCD.Text);
            dgv_KhachHang.DataSource = dskh;
            if (!KiemTraDinhDangCCCD(txt_CCCD.Text.Trim().ToUpper()))
            {
                txt_CCCD.BackColor = Color.LightCoral;
            }
            else
            {
                txt_CCCD.BackColor = SystemColors.Window;     
                cbo_SoTK.Items.Clear();
                AddToCBO(cbo_SoTK, BUS_GiaoDich.LayDSTaiKhoanTheoCCCD(txt_CCCD.Text.Trim()));
                if (cbo_SoTK.Items.Count > 0)
                {
                    cbo_SoTK.SelectedIndex = 0;
                }
                cbo_SoTkNhan.Items.Clear();
                cbo_SoTkNhan.Items.Add("");
                AddToCBO(cbo_SoTkNhan, BUS_GiaoDich.LayDSTaiKhoanKhongCuaSoCCCD(txt_CCCD.Text.Trim()));
            }
        }

        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_KhachHang.RowCount > 0)
                {
                    int dong = dgv_KhachHang.CurrentCell.RowIndex;
                    txt_CCCD.Text = dgv_KhachHang.Rows[dong].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_GiaoDich_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                if (dgv_GiaoDich.RowCount > 0)
                {
                    int dong = dgv_GiaoDich.CurrentCell.RowIndex;
                    txt_MaGD.Text = dgv_GiaoDich.Rows[dong].Cells[0].Value.ToString();
                    txt_CCCD.Text = BUS_GiaoDich.LayCccdTheoMaKH(dgv_GiaoDich.Rows[dong].Cells[1].Value.ToString());
                    cbo_SoTK.Text = BUS_GiaoDich.LaySTKTheoMaTK(dgv_GiaoDich.Rows[dong].Cells[2].Value.ToString());
                    var maTKNhan = dgv_GiaoDich.Rows[dong].Cells[3].Value?.ToString();
                    cbo_SoTkNhan.Text = maTKNhan == null ? "" : (BUS_GiaoDich.LaySTKTheoMaTK(maTKNhan) ?? string.Empty);
                    cbo_LoaiGD.Text = BUS_GiaoDich.LayTenLoaiGDTheoMaGD(dgv_GiaoDich.Rows[dong].Cells[4].Value.ToString());
                    txt_SoTien.Text = dgv_GiaoDich.Rows[dong].Cells[5].Value.ToString();
                    dtp_ThoiGianGD.Value = Convert.ToDateTime(dgv_GiaoDich.Rows[dong].Cells[6].Value.ToString());
                    txt_MoTa.Text = dgv_GiaoDich.Rows[dong].Cells[7].Value.ToString();
                    cbo_TrangThai.Text = dgv_GiaoDich.Rows[dong].Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //hàm kiểm tra định dạng số tiền (không chữ, không ký tự đặc biệt, không khoảng trắng)
        private bool KiemTraDinhDangSoTien(string sodu)
        {
            bool flag = false;
            string pattern = @"^\d+$";
            if (string.IsNullOrWhiteSpace(sodu))
                return flag;
            if (Regex.IsMatch(sodu.Trim(), pattern))
                flag = true;
            return flag;
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

        //hàm kiểm tra định dạng mô tả (chuỗi 100 ký tự, không ký tự đặc biệt)
        private bool KiemTraDinhDangMoTa(string diachi)
        {
            bool flag = false;
            string pattern = @"^[a-zA-Z0-9À-ỹ\s,.-]{1,100}$";
            if (string.IsNullOrWhiteSpace(diachi))
                return flag;
            if (Regex.IsMatch(diachi.Trim(), pattern))
                flag = true;
            return flag;
        }

        private void txt_SoTien_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangSoTien(txt_SoTien.Text.Trim().ToUpper()))
            {
                txt_SoTien.BackColor = Color.LightCoral;
            }
            else
            {
                txt_SoTien.BackColor = SystemColors.Window;
            }
        }

        private void txt_MoTa_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangMoTa(txt_MoTa.Text.Trim().ToUpper()))
            {
                txt_MoTa.BackColor = Color.LightCoral;
            }
            else
            {
                txt_MoTa.BackColor = SystemColors.Window;
            }
        }

        private bool KiemTraTatCaTruongNhap()
        {
            var dsham = new Dictionary<string, Tuple<Func<bool>, Control>>();
            dsham.Add("CCCD/CMND", Tuple.Create((Func<bool>)(() => KiemTraDinhDangCCCD(txt_CCCD.Text)), (Control)txt_CCCD));
            dsham.Add("Số Tiền", Tuple.Create((Func<bool>)(() => KiemTraDinhDangSoTien(txt_SoTien.Text)), (Control)txt_SoTien));
            dsham.Add("Mô Tả", Tuple.Create((Func<bool>)(() => KiemTraDinhDangMoTa(txt_MoTa.Text)), (Control)txt_MoTa));

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_GiaoDich gd = new ET_GiaoDich(txt_MaGD.Text.Trim(),
                                                    BUS_GiaoDich.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    BUS_GiaoDich.LayMaTKTheoSTK(cbo_SoTK.Text),
                                                    null,
                                                    BUS_GiaoDich.LayMaGDTheoTenLoaiGD(cbo_LoaiGD.Text),
                                                    Convert.ToDecimal(txt_SoTien.Text),
                                                    dtp_ThoiGianGD.Value,
                                                    txt_MoTa.Text,
                                                    cbo_TrangThai.Text,
                                                    true);
                    if (BUS_GiaoDich.LayPhuongThucTheoTenLoaiGD(cbo_LoaiGD.Text) == "-")
                    {
                        if (BUS_GiaoDich.AnGiaoDichVaCongTien(gd, cbo_SoTK.Text, cbo_SoTkNhan.Text) == true)
                        {
                            MessageBox.Show("Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (BUS_GiaoDich.AnGiaoDichVaTruTien(gd, cbo_SoTK.Text, cbo_SoTkNhan.Text) == true)
                        {
                            MessageBox.Show("Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_HuyAn_Click(object sender, EventArgs e)
        {
            try
            {
                ET_GiaoDich gd = new ET_GiaoDich(txt_MaGD.Text.Trim(),
                                                    BUS_GiaoDich.LayMaKHTheoCccd(txt_CCCD.Text),
                                                    BUS_GiaoDich.LayMaTKTheoSTK(cbo_SoTK.Text),
                                                    null,
                                                    BUS_GiaoDich.LayMaGDTheoTenLoaiGD(cbo_LoaiGD.Text),
                                                    Convert.ToDecimal(txt_SoTien.Text),
                                                    dtp_ThoiGianGD.Value,
                                                    txt_MoTa.Text,
                                                    cbo_TrangThai.Text,
                                                    false);
                if (BUS_GiaoDich.LayPhuongThucTheoTenLoaiGD(cbo_LoaiGD.Text) == "-")
                {
                    if (BUS_GiaoDich.HuyAnGiaoDichVaTruTien(gd, cbo_SoTK.Text, cbo_SoTkNhan.Text) == true)
                    {
                        MessageBox.Show("Hủy Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy xóa giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (BUS_GiaoDich.HuyAnGiaoDichVaCongTien(gd, cbo_SoTK.Text, cbo_SoTkNhan.Text) == true)
                    {
                        MessageBox.Show("Hủy Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy xóa giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            HienThiDS();
        }

        private void cbo_SoTkNhan_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
