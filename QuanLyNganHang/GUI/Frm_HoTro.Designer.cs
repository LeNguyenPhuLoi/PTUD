namespace GUI
{
    partial class Frm_HoTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoTro));
            this.panel_ThongTin1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.cbo_LoaiHT = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.txt_Cccdnv = new System.Windows.Forms.TextBox();
            this.txt_NoiDung = new System.Windows.Forms.RichTextBox();
            this.txt_Cccdkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaHoTro = new System.Windows.Forms.TextBox();
            this.dtp_NgayHoTro = new System.Windows.Forms.DateTimePicker();
            this.panel_HoTro = new System.Windows.Forms.Panel();
            this.dgv_HoTro = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_HuyAn = new System.Windows.Forms.Button();
            this.panel_ThongTin1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel_HoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ThongTin1
            // 
            this.panel_ThongTin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin1.Controls.Add(this.btn_HuyAn);
            this.panel_ThongTin1.Controls.Add(this.panel3);
            this.panel_ThongTin1.Controls.Add(this.cbo_LoaiHT);
            this.panel_ThongTin1.Controls.Add(this.panel2);
            this.panel_ThongTin1.Controls.Add(this.txt_Cccdnv);
            this.panel_ThongTin1.Controls.Add(this.txt_NoiDung);
            this.panel_ThongTin1.Controls.Add(this.txt_Cccdkh);
            this.panel_ThongTin1.Controls.Add(this.label5);
            this.panel_ThongTin1.Controls.Add(this.label4);
            this.panel_ThongTin1.Controls.Add(this.btn_Lammoi);
            this.panel_ThongTin1.Controls.Add(this.label2);
            this.panel_ThongTin1.Controls.Add(this.label3);
            this.panel_ThongTin1.Controls.Add(this.btnThem);
            this.panel_ThongTin1.Controls.Add(this.btnXoa);
            this.panel_ThongTin1.Controls.Add(this.label8);
            this.panel_ThongTin1.Controls.Add(this.dtp_NgayHoTro);
            this.panel_ThongTin1.Location = new System.Drawing.Point(12, 50);
            this.panel_ThongTin1.Name = "panel_ThongTin1";
            this.panel_ThongTin1.Size = new System.Drawing.Size(527, 511);
            this.panel_ThongTin1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgv_NhanVien);
            this.panel3.Location = new System.Drawing.Point(17, 181);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 94);
            this.panel3.TabIndex = 59;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowDrop = true;
            this.dgv_NhanVien.AllowUserToResizeColumns = false;
            this.dgv_NhanVien.AllowUserToResizeRows = false;
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(2, 0);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_NhanVien.MultiSelect = false;
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.ReadOnly = true;
            this.dgv_NhanVien.RowHeadersVisible = false;
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1920, 1080);
            this.dgv_NhanVien.TabIndex = 17;
            this.dgv_NhanVien.Click += new System.EventHandler(this.dgv_NhanVien_Click);
            // 
            // cbo_LoaiHT
            // 
            this.cbo_LoaiHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiHT.FormattingEnabled = true;
            this.cbo_LoaiHT.Location = new System.Drawing.Point(147, 286);
            this.cbo_LoaiHT.Name = "cbo_LoaiHT";
            this.cbo_LoaiHT.Size = new System.Drawing.Size(374, 29);
            this.cbo_LoaiHT.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dgv_KhachHang);
            this.panel2.Location = new System.Drawing.Point(10, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 94);
            this.panel2.TabIndex = 58;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowDrop = true;
            this.dgv_KhachHang.AllowUserToResizeColumns = false;
            this.dgv_KhachHang.AllowUserToResizeRows = false;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.White;
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
            // txt_Cccdnv
            // 
            this.txt_Cccdnv.Location = new System.Drawing.Point(175, 147);
            this.txt_Cccdnv.Name = "txt_Cccdnv";
            this.txt_Cccdnv.Size = new System.Drawing.Size(346, 29);
            this.txt_Cccdnv.TabIndex = 57;
            this.txt_Cccdnv.TextChanged += new System.EventHandler(this.txt_Cccdnv_TextChanged);
            // 
            // txt_NoiDung
            // 
            this.txt_NoiDung.Location = new System.Drawing.Point(147, 321);
            this.txt_NoiDung.Name = "txt_NoiDung";
            this.txt_NoiDung.Size = new System.Drawing.Size(374, 91);
            this.txt_NoiDung.TabIndex = 53;
            this.txt_NoiDung.Text = "";
            this.txt_NoiDung.TextChanged += new System.EventHandler(this.txt_NoiDung_TextChanged);
            // 
            // txt_Cccdkh
            // 
            this.txt_Cccdkh.Location = new System.Drawing.Point(175, 8);
            this.txt_Cccdkh.Name = "txt_Cccdkh";
            this.txt_Cccdkh.Size = new System.Drawing.Size(346, 29);
            this.txt_Cccdkh.TabIndex = 40;
            this.txt_Cccdkh.TextChanged += new System.EventHandler(this.txt_Cccdkh_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nội Dung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Loại Hỗ Trợ:";
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
            this.btn_Lammoi.Location = new System.Drawing.Point(310, 460);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(99, 40);
            this.btn_Lammoi.TabIndex = 36;
            this.btn_Lammoi.Text = "Làm Mới";
            this.btn_Lammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "CCCD Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "CCCD Nhân Viên:";
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
            this.btnThem.Location = new System.Drawing.Point(114, 460);
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
            this.btnXoa.Location = new System.Drawing.Point(213, 460);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày Hỗ Trợ:";
            // 
            // txt_MaHoTro
            // 
            this.txt_MaHoTro.Location = new System.Drawing.Point(87, 567);
            this.txt_MaHoTro.Name = "txt_MaHoTro";
            this.txt_MaHoTro.Size = new System.Drawing.Size(374, 29);
            this.txt_MaHoTro.TabIndex = 10;
            this.txt_MaHoTro.Visible = false;
            // 
            // dtp_NgayHoTro
            // 
            this.dtp_NgayHoTro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayHoTro.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayHoTro.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayHoTro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayHoTro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayHoTro.Location = new System.Drawing.Point(147, 417);
            this.dtp_NgayHoTro.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayHoTro.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayHoTro.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayHoTro.Name = "dtp_NgayHoTro";
            this.dtp_NgayHoTro.Size = new System.Drawing.Size(374, 29);
            this.dtp_NgayHoTro.TabIndex = 14;
            this.dtp_NgayHoTro.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // panel_HoTro
            // 
            this.panel_HoTro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_HoTro.AutoScroll = true;
            this.panel_HoTro.Controls.Add(this.dgv_HoTro);
            this.panel_HoTro.Location = new System.Drawing.Point(549, 50);
            this.panel_HoTro.Margin = new System.Windows.Forms.Padding(2);
            this.panel_HoTro.Name = "panel_HoTro";
            this.panel_HoTro.Size = new System.Drawing.Size(551, 649);
            this.panel_HoTro.TabIndex = 39;
            // 
            // dgv_HoTro
            // 
            this.dgv_HoTro.AllowDrop = true;
            this.dgv_HoTro.AllowUserToResizeColumns = false;
            this.dgv_HoTro.AllowUserToResizeRows = false;
            this.dgv_HoTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoTro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_HoTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoTro.Location = new System.Drawing.Point(2, 0);
            this.dgv_HoTro.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_HoTro.MultiSelect = false;
            this.dgv_HoTro.Name = "dgv_HoTro";
            this.dgv_HoTro.ReadOnly = true;
            this.dgv_HoTro.RowHeadersVisible = false;
            this.dgv_HoTro.RowHeadersWidth = 51;
            this.dgv_HoTro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoTro.Size = new System.Drawing.Size(1920, 1080);
            this.dgv_HoTro.TabIndex = 17;
            this.dgv_HoTro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoTro_CellContentClick);
            this.dgv_HoTro.Click += new System.EventHandler(this.dgv_HoTro_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1100, 41);
            this.label6.TabIndex = 60;
            this.label6.Text = "Chăm Sóc Khách Hàng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_HuyAn
            // 
            this.btn_HuyAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HuyAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_HuyAn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_HuyAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_HuyAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_HuyAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyAn.ForeColor = System.Drawing.Color.White;
            this.btn_HuyAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyAn.Image")));
            this.btn_HuyAn.Location = new System.Drawing.Point(422, 460);
            this.btn_HuyAn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HuyAn.Name = "btn_HuyAn";
            this.btn_HuyAn.Size = new System.Drawing.Size(103, 40);
            this.btn_HuyAn.TabIndex = 61;
            this.btn_HuyAn.Text = "Hủy Xóa";
            this.btn_HuyAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HuyAn.UseVisualStyleBackColor = false;
            this.btn_HuyAn.Visible = false;
            this.btn_HuyAn.Click += new System.EventHandler(this.btn_HuyAn_Click);
            // 
            // Frm_HoTro
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_HoTro);
            this.Controls.Add(this.panel_ThongTin1);
            this.Controls.Add(this.txt_MaHoTro);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_HoTro";
            this.Text = "Chăm Sóc Khách Hàng";
            this.Load += new System.EventHandler(this.Frm_HoTro_Load);
            this.Resize += new System.EventHandler(this.Frm_HoTro_Resize);
            this.panel_ThongTin1.ResumeLayout(false);
            this.panel_ThongTin1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel_HoTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoTro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_ThongTin1;
        private System.Windows.Forms.ComboBox cbo_LoaiHT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.TextBox txt_Cccdnv;
        private System.Windows.Forms.RichTextBox txt_NoiDung;
        private System.Windows.Forms.TextBox txt_Cccdkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaHoTro;
        private System.Windows.Forms.DateTimePicker dtp_NgayHoTro;
        private System.Windows.Forms.Panel panel_HoTro;
        private System.Windows.Forms.DataGridView dgv_HoTro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_HuyAn;
    }
}