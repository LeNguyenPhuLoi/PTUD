namespace GUI
{
    partial class Frm_HopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HopDong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SoHD = new System.Windows.Forms.TextBox();
            this.cbo_LoaiHD = new System.Windows.Forms.ComboBox();
            this.dtp_NgayKy = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.txt_GiaTri = new System.Windows.Forms.TextBox();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.txt_CccdKH = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.panel_ThongTin1 = new System.Windows.Forms.Panel();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.panel_KhachHang = new System.Windows.Forms.Panel();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_HuyAn = new System.Windows.Forms.Button();
            this.panel_HopDong = new System.Windows.Forms.Panel();
            this.dgv_HopDong = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.panel_ThongTin1.SuspendLayout();
            this.panel_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel_HopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Hợp Đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại Hợp Đồng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Ký:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Hết Hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "CCCD Khách Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Nhân Viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giá Trị:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Trạng Thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ghi Chú:";
            // 
            // txt_SoHD
            // 
            this.txt_SoHD.BackColor = System.Drawing.Color.Silver;
            this.txt_SoHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoHD.Enabled = false;
            this.txt_SoHD.Location = new System.Drawing.Point(147, 3);
            this.txt_SoHD.Name = "txt_SoHD";
            this.txt_SoHD.ReadOnly = true;
            this.txt_SoHD.Size = new System.Drawing.Size(372, 35);
            this.txt_SoHD.TabIndex = 10;
            // 
            // cbo_LoaiHD
            // 
            this.cbo_LoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiHD.FormattingEnabled = true;
            this.cbo_LoaiHD.Location = new System.Drawing.Point(147, 36);
            this.cbo_LoaiHD.Name = "cbo_LoaiHD";
            this.cbo_LoaiHD.Size = new System.Drawing.Size(372, 35);
            this.cbo_LoaiHD.TabIndex = 11;
            // 
            // dtp_NgayKy
            // 
            this.dtp_NgayKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayKy.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKy.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayKy.Location = new System.Drawing.Point(147, 68);
            this.dtp_NgayKy.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayKy.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayKy.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayKy.Name = "dtp_NgayKy";
            this.dtp_NgayKy.Size = new System.Drawing.Size(372, 35);
            this.dtp_NgayKy.TabIndex = 14;
            this.dtp_NgayKy.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // dtp_NgayHetHan
            // 
            this.dtp_NgayHetHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayHetHan.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayHetHan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayHetHan.Location = new System.Drawing.Point(147, 99);
            this.dtp_NgayHetHan.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayHetHan.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayHetHan.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayHetHan.Name = "dtp_NgayHetHan";
            this.dtp_NgayHetHan.Size = new System.Drawing.Size(372, 35);
            this.dtp_NgayHetHan.TabIndex = 15;
            this.dtp_NgayHetHan.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.Location = new System.Drawing.Point(147, 131);
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Size = new System.Drawing.Size(372, 35);
            this.txt_GiaTri.TabIndex = 16;
            this.txt_GiaTri.TextChanged += new System.EventHandler(this.txt_GiaTri_TextChanged);
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Đã Ký Kết",
            "Chưa Ký Kết"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(147, 264);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(372, 35);
            this.cbo_TrangThai.TabIndex = 17;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(147, 164);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(372, 96);
            this.txt_GhiChu.TabIndex = 18;
            this.txt_GhiChu.Text = "";
            this.txt_GhiChu.TextChanged += new System.EventHandler(this.txt_GhiChu_TextChanged);
            // 
            // txt_CccdKH
            // 
            this.txt_CccdKH.Location = new System.Drawing.Point(173, 338);
            this.txt_CccdKH.Name = "txt_CccdKH";
            this.txt_CccdKH.Size = new System.Drawing.Size(346, 35);
            this.txt_CccdKH.TabIndex = 19;
            this.txt_CccdKH.TextChanged += new System.EventHandler(this.txt_CccdKH_TextChanged);
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Enabled = false;
            this.txt_TenNV.Location = new System.Drawing.Point(175, 297);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.ReadOnly = true;
            this.txt_TenNV.Size = new System.Drawing.Size(346, 35);
            this.txt_TenNV.TabIndex = 20;
            this.txt_TenNV.TextChanged += new System.EventHandler(this.txt_CccdNV_TextChanged);
            // 
            // panel_ThongTin1
            // 
            this.panel_ThongTin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin1.Controls.Add(this.btn_Lammoi);
            this.panel_ThongTin1.Controls.Add(this.dtp_NgayHetHan);
            this.panel_ThongTin1.Controls.Add(this.label1);
            this.panel_ThongTin1.Controls.Add(this.panel_KhachHang);
            this.panel_ThongTin1.Controls.Add(this.label2);
            this.panel_ThongTin1.Controls.Add(this.label3);
            this.panel_ThongTin1.Controls.Add(this.btnThem);
            this.panel_ThongTin1.Controls.Add(this.label4);
            this.panel_ThongTin1.Controls.Add(this.txt_GhiChu);
            this.panel_ThongTin1.Controls.Add(this.label7);
            this.panel_ThongTin1.Controls.Add(this.btnXoa);
            this.panel_ThongTin1.Controls.Add(this.cbo_TrangThai);
            this.panel_ThongTin1.Controls.Add(this.label5);
            this.panel_ThongTin1.Controls.Add(this.txt_TenNV);
            this.panel_ThongTin1.Controls.Add(this.label8);
            this.panel_ThongTin1.Controls.Add(this.label6);
            this.panel_ThongTin1.Controls.Add(this.txt_GiaTri);
            this.panel_ThongTin1.Controls.Add(this.txt_CccdKH);
            this.panel_ThongTin1.Controls.Add(this.label9);
            this.panel_ThongTin1.Controls.Add(this.txt_SoHD);
            this.panel_ThongTin1.Controls.Add(this.dtp_NgayKy);
            this.panel_ThongTin1.Controls.Add(this.cbo_LoaiHD);
            this.panel_ThongTin1.Location = new System.Drawing.Point(4, 54);
            this.panel_ThongTin1.Name = "panel_ThongTin1";
            this.panel_ThongTin1.Size = new System.Drawing.Size(527, 527);
            this.panel_ThongTin1.TabIndex = 23;
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Lammoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Lammoi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Lammoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_Lammoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.ForeColor = System.Drawing.Color.White;
            this.btn_Lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lammoi.Image")));
            this.btn_Lammoi.Location = new System.Drawing.Point(309, 479);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(100, 40);
            this.btn_Lammoi.TabIndex = 36;
            this.btn_Lammoi.Text = "Làm Mới";
            this.btn_Lammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // panel_KhachHang
            // 
            this.panel_KhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_KhachHang.AutoScroll = true;
            this.panel_KhachHang.Controls.Add(this.dgv_KhachHang);
            this.panel_KhachHang.Location = new System.Drawing.Point(3, 370);
            this.panel_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.panel_KhachHang.Name = "panel_KhachHang";
            this.panel_KhachHang.Size = new System.Drawing.Size(504, 94);
            this.panel_KhachHang.TabIndex = 34;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowDrop = true;
            this.dgv_KhachHang.AllowUserToResizeColumns = false;
            this.dgv_KhachHang.AllowUserToResizeRows = false;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(2, 0);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_KhachHang.MultiSelect = false;
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            this.dgv_KhachHang.RowHeadersVisible = false;
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1920, 1080);
            this.dgv_KhachHang.TabIndex = 17;
            this.dgv_KhachHang.Click += new System.EventHandler(this.dgv_KhachHang_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(97, 479);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 40);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(205, 479);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_HuyAn
            // 
            this.btn_HuyAn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_HuyAn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_HuyAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_HuyAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_HuyAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyAn.ForeColor = System.Drawing.Color.White;
            this.btn_HuyAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyAn.Image")));
            this.btn_HuyAn.Location = new System.Drawing.Point(202, 586);
            this.btn_HuyAn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HuyAn.Name = "btn_HuyAn";
            this.btn_HuyAn.Size = new System.Drawing.Size(96, 40);
            this.btn_HuyAn.TabIndex = 61;
            this.btn_HuyAn.Text = "Hủy Xóa";
            this.btn_HuyAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HuyAn.UseVisualStyleBackColor = false;
            this.btn_HuyAn.Visible = false;
            this.btn_HuyAn.Click += new System.EventHandler(this.btn_HuyAn_Click);
            // 
            // panel_HopDong
            // 
            this.panel_HopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_HopDong.AutoScroll = true;
            this.panel_HopDong.Controls.Add(this.dgv_HopDong);
            this.panel_HopDong.Location = new System.Drawing.Point(536, 54);
            this.panel_HopDong.Margin = new System.Windows.Forms.Padding(2);
            this.panel_HopDong.Name = "panel_HopDong";
            this.panel_HopDong.Size = new System.Drawing.Size(564, 643);
            this.panel_HopDong.TabIndex = 35;
            // 
            // dgv_HopDong
            // 
            this.dgv_HopDong.AllowDrop = true;
            this.dgv_HopDong.AllowUserToResizeColumns = false;
            this.dgv_HopDong.AllowUserToResizeRows = false;
            this.dgv_HopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HopDong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HopDong.Location = new System.Drawing.Point(2, 0);
            this.dgv_HopDong.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_HopDong.MultiSelect = false;
            this.dgv_HopDong.Name = "dgv_HopDong";
            this.dgv_HopDong.ReadOnly = true;
            this.dgv_HopDong.RowHeadersVisible = false;
            this.dgv_HopDong.RowHeadersWidth = 51;
            this.dgv_HopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HopDong.Size = new System.Drawing.Size(1920, 1080);
            this.dgv_HopDong.TabIndex = 17;
            this.dgv_HopDong.Click += new System.EventHandler(this.dgv_HopDong_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1100, 41);
            this.label10.TabIndex = 60;
            this.label10.Text = "Quản Lý Hợp Đồng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BackColor = System.Drawing.Color.Silver;
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(76, 631);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(372, 35);
            this.txt_MaNV.TabIndex = 37;
            this.txt_MaNV.Visible = false;
            // 
            // Frm_HopDong
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.btn_HuyAn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel_HopDong);
            this.Controls.Add(this.panel_ThongTin1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_HopDong";
            this.Text = "Quản Lý Hợp Đồng";
            this.Load += new System.EventHandler(this.Frm_HopDong_Load);
            this.Resize += new System.EventHandler(this.Frm_HopDong_Resize);
            this.panel_ThongTin1.ResumeLayout(false);
            this.panel_ThongTin1.PerformLayout();
            this.panel_KhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel_HopDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SoHD;
        private System.Windows.Forms.ComboBox cbo_LoaiHD;
        private System.Windows.Forms.DateTimePicker dtp_NgayKy;
        private System.Windows.Forms.DateTimePicker dtp_NgayHetHan;
        private System.Windows.Forms.TextBox txt_GiaTri;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.RichTextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_CccdKH;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Panel panel_ThongTin1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel_KhachHang;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Panel panel_HopDong;
        private System.Windows.Forms.DataGridView dgv_HopDong;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_HuyAn;
        private System.Windows.Forms.TextBox txt_MaNV;
    }
}