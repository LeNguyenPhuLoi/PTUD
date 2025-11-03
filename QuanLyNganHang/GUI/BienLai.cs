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
    public partial class BienLai : Form
    {
        public BienLai()
        {
            InitializeComponent();
        }
    
        BUS_BienLai bUS_BienLai = new BUS_BienLai();

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

            // Màu nền khi chọn ô (dòng)
            dgvmanv.DefaultCellStyle.SelectionBackColor = Color.RosyBrown; // hoặc Color.Yellow
            // Xem kẽ màu dòng
            dgvmanv.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmanv.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque; // xanh dương sáng
            
            AddToCombo(bUS_BienLai.LoadDSTenGD(), cbomagd);
            AddToCombo(bUS_BienLai.LoadDSTenNT(), cbomant);
            dgvmakh.DataSource = bUS_BienLai.LoadDSKH();
            dgvmanv.DataSource = bUS_BienLai.LoadDSNV();
            HienThiDS();
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
            txtmanv.Clear();
            txtsotien.Clear();
            rtxtmota.Clear();
            cbomagd.SelectedIndex = 0;
            cbomant.SelectedIndex = 0;
            cbomatk.SelectedIndex = -1;
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void HienThiDS()
        {
            if (this.MdiParent.Name == "frmMainAddmin")
            {
                btnXoa.Visible = true;
                btn_HuyAn.Visible = true;
                dgvbienlai.DataSource = bUS_BienLai.LoadDSBienLai();
            }
            else
            {
                dgvbienlai.DataSource = bUS_BienLai.LoadDSBienLaiuser();
                btnXoa.Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
