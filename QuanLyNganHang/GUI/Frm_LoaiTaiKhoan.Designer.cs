namespace GUI
{
    partial class Frm_LoaiTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoaiTaiKhoan));
            this.panel_ThongTin1 = new System.Windows.Forms.Panel();
            this.btn_HuyAn = new System.Windows.Forms.Button();
            this.dtp_NgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ChiTiet = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtp_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.txt_MaLoaiTK = new System.Windows.Forms.TextBox();
            this.panel_LoaiTaiKhoan = new System.Windows.Forms.Panel();
            this.dgv_LoaiTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_ThongTin1.SuspendLayout();
            this.panel_LoaiTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ThongTin1
            // 
            this.panel_ThongTin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin1.Controls.Add(this.btn_HuyAn);
            this.panel_ThongTin1.Controls.Add(this.dtp_NgayCapNhat);
            this.panel_ThongTin1.Controls.Add(this.cbo_TrangThai);
            this.panel_ThongTin1.Controls.Add(this.label5);
            this.panel_ThongTin1.Controls.Add(this.txt_ChiTiet);
            this.panel_ThongTin1.Controls.Add(this.label4);
            this.panel_ThongTin1.Controls.Add(this.btn_Lammoi);
            this.panel_ThongTin1.Controls.Add(this.label2);
            this.panel_ThongTin1.Controls.Add(this.label3);
            this.panel_ThongTin1.Controls.Add(this.btnThem);
            this.panel_ThongTin1.Controls.Add(this.btnSua);
            this.panel_ThongTin1.Controls.Add(this.btnXoa);
            this.panel_ThongTin1.Controls.Add(this.dtp_NgayTao);
            this.panel_ThongTin1.Location = new System.Drawing.Point(12, 50);
            this.panel_ThongTin1.Name = "panel_ThongTin1";
            this.panel_ThongTin1.Size = new System.Drawing.Size(527, 283);
            this.panel_ThongTin1.TabIndex = 27;
            // 
            // btn_HuyAn
            // 
            this.btn_HuyAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HuyAn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_HuyAn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_HuyAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_HuyAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_HuyAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyAn.ForeColor = System.Drawing.Color.White;
            this.btn_HuyAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyAn.Image")));
            this.btn_HuyAn.Location = new System.Drawing.Point(419, 225);
            this.btn_HuyAn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HuyAn.Name = "btn_HuyAn";
            this.btn_HuyAn.Size = new System.Drawing.Size(100, 40);
            this.btn_HuyAn.TabIndex = 25;
            this.btn_HuyAn.Text = "Hủy Xóa";
            this.btn_HuyAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HuyAn.UseVisualStyleBackColor = false;
            this.btn_HuyAn.Visible = false;
            this.btn_HuyAn.Click += new System.EventHandler(this.btn_HuyAn_Click);
            // 
            // dtp_NgayCapNhat
            // 
            this.dtp_NgayCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayCapNhat.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayCapNhat.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayCapNhat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayCapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayCapNhat.Location = new System.Drawing.Point(169, 145);
            this.dtp_NgayCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayCapNhat.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayCapNhat.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayCapNhat.Name = "dtp_NgayCapNhat";
            this.dtp_NgayCapNhat.Size = new System.Drawing.Size(350, 29);
            this.dtp_NgayCapNhat.TabIndex = 61;
            this.dtp_NgayCapNhat.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Còn Hoạt Động",
            "Tạm Ngưng"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(169, 179);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(350, 29);
            this.cbo_TrangThai.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Trạng Thái:";
            // 
            // txt_ChiTiet
            // 
            this.txt_ChiTiet.Location = new System.Drawing.Point(169, 16);
            this.txt_ChiTiet.Name = "txt_ChiTiet";
            this.txt_ChiTiet.Size = new System.Drawing.Size(350, 91);
            this.txt_ChiTiet.TabIndex = 53;
            this.txt_ChiTiet.Text = "";
            this.txt_ChiTiet.TextChanged += new System.EventHandler(this.txt_ChiTiet_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày Cập Nhật:";
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
            this.btn_Lammoi.Location = new System.Drawing.Point(301, 225);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(104, 40);
            this.btn_Lammoi.TabIndex = 36;
            this.btn_Lammoi.Text = "Làm Mới";
            this.btn_Lammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi Tiết:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Tạo:";
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
            this.btnThem.Location = new System.Drawing.Point(8, 225);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 40);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(106, 225);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 40);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(203, 225);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtp_NgayTao
            // 
            this.dtp_NgayTao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayTao.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayTao.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTao.Location = new System.Drawing.Point(169, 112);
            this.dtp_NgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayTao.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayTao.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayTao.Name = "dtp_NgayTao";
            this.dtp_NgayTao.Size = new System.Drawing.Size(350, 29);
            this.dtp_NgayTao.TabIndex = 14;
            this.dtp_NgayTao.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayTao.ValueChanged += new System.EventHandler(this.dtp_NgayTao_ValueChanged);
            // 
            // txt_MaLoaiTK
            // 
            this.txt_MaLoaiTK.Location = new System.Drawing.Point(101, 339);
            this.txt_MaLoaiTK.Name = "txt_MaLoaiTK";
            this.txt_MaLoaiTK.Size = new System.Drawing.Size(350, 29);
            this.txt_MaLoaiTK.TabIndex = 57;
            this.txt_MaLoaiTK.Visible = false;
            this.txt_MaLoaiTK.TextChanged += new System.EventHandler(this.txt_MaLoaiTK_TextChanged);
            // 
            // panel_LoaiTaiKhoan
            // 
            this.panel_LoaiTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_LoaiTaiKhoan.AutoScroll = true;
            this.panel_LoaiTaiKhoan.Controls.Add(this.dgv_LoaiTaiKhoan);
            this.panel_LoaiTaiKhoan.Location = new System.Drawing.Point(549, 66);
            this.panel_LoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.panel_LoaiTaiKhoan.Name = "panel_LoaiTaiKhoan";
            this.panel_LoaiTaiKhoan.Size = new System.Drawing.Size(504, 94);
            this.panel_LoaiTaiKhoan.TabIndex = 39;
            // 
            // dgv_LoaiTaiKhoan
            // 
            this.dgv_LoaiTaiKhoan.AllowDrop = true;
            this.dgv_LoaiTaiKhoan.AllowUserToResizeColumns = false;
            this.dgv_LoaiTaiKhoan.AllowUserToResizeRows = false;
            this.dgv_LoaiTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_LoaiTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiTaiKhoan.Location = new System.Drawing.Point(2, 0);
            this.dgv_LoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_LoaiTaiKhoan.MultiSelect = false;
            this.dgv_LoaiTaiKhoan.Name = "dgv_LoaiTaiKhoan";
            this.dgv_LoaiTaiKhoan.ReadOnly = true;
            this.dgv_LoaiTaiKhoan.RowHeadersVisible = false;
            this.dgv_LoaiTaiKhoan.RowHeadersWidth = 51;
            this.dgv_LoaiTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiTaiKhoan.Size = new System.Drawing.Size(1920, 1080);
            this.dgv_LoaiTaiKhoan.TabIndex = 17;
            this.dgv_LoaiTaiKhoan.Click += new System.EventHandler(this.dgv_LoaiTaiKhoan_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1100, 41);
            this.label8.TabIndex = 60;
            this.label8.Text = "Quản Lý Loại Tài Khoản";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_LoaiTaiKhoan
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel_LoaiTaiKhoan);
            this.Controls.Add(this.panel_ThongTin1);
            this.Controls.Add(this.txt_MaLoaiTK);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_LoaiTaiKhoan";
            this.Text = "Quản Lý Loại Tài Khoản";
            this.Load += new System.EventHandler(this.Frm_LoaiTaiKhoan_Load);
            this.ResizeEnd += new System.EventHandler(this.Frm_LoaiTaiKhoan_ResizeEnd);
            this.Resize += new System.EventHandler(this.Frm_LoaiTaiKhoan_Resize);
            this.panel_ThongTin1.ResumeLayout(false);
            this.panel_ThongTin1.PerformLayout();
            this.panel_LoaiTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_ThongTin1;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.TextBox txt_MaLoaiTK;
        private System.Windows.Forms.RichTextBox txt_ChiTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtp_NgayTao;
        private System.Windows.Forms.Panel panel_LoaiTaiKhoan;
        private System.Windows.Forms.DataGridView dgv_LoaiTaiKhoan;
        private System.Windows.Forms.DateTimePicker dtp_NgayCapNhat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_HuyAn;
    }
}