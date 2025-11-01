namespace GUI
{
    partial class Frm_LoaiHoTro
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
            this.panel_ThongTin1 = new System.Windows.Forms.Panel();
            this.btn_HuyAn = new System.Windows.Forms.Button();
            this.dtp_NgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txt_TenLoaiHT = new System.Windows.Forms.RichTextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_MaLoaiHT = new System.Windows.Forms.TextBox();
            this.panel_LoaiHoTro = new System.Windows.Forms.Panel();
            this.dgv_LoaiHoTro = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_ThongTin1.SuspendLayout();
            this.panel_LoaiHoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiHoTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ThongTin1
            // 
            this.panel_ThongTin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin1.Controls.Add(this.btn_HuyAn);
            this.panel_ThongTin1.Controls.Add(this.dtp_NgayCapNhat);
            this.panel_ThongTin1.Controls.Add(this.label5);
            this.panel_ThongTin1.Controls.Add(this.label4);
            this.panel_ThongTin1.Controls.Add(this.btn_Lammoi);
            this.panel_ThongTin1.Controls.Add(this.label2);
            this.panel_ThongTin1.Controls.Add(this.btnThem);
            this.panel_ThongTin1.Controls.Add(this.btnSua);
            this.panel_ThongTin1.Controls.Add(this.txt_TenLoaiHT);
            this.panel_ThongTin1.Controls.Add(this.btnXoa);
            this.panel_ThongTin1.Controls.Add(this.label8);
            this.panel_ThongTin1.Controls.Add(this.dtp_NgayLap);
            this.panel_ThongTin1.Controls.Add(this.cbo_TrangThai);
            this.panel_ThongTin1.Location = new System.Drawing.Point(12, 50);
            this.panel_ThongTin1.Name = "panel_ThongTin1";
            this.panel_ThongTin1.Size = new System.Drawing.Size(527, 274);
            this.panel_ThongTin1.TabIndex = 26;
            // 
            // btn_HuyAn
            // 
            this.btn_HuyAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HuyAn.BackColor = System.Drawing.Color.Navy;
            this.btn_HuyAn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HuyAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_HuyAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_HuyAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyAn.ForeColor = System.Drawing.Color.Gold;
            this.btn_HuyAn.Location = new System.Drawing.Point(438, 221);
            this.btn_HuyAn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HuyAn.Name = "btn_HuyAn";
            this.btn_HuyAn.Size = new System.Drawing.Size(84, 40);
            this.btn_HuyAn.TabIndex = 62;
            this.btn_HuyAn.Text = "Hủy Xóa";
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
            this.dtp_NgayCapNhat.Location = new System.Drawing.Point(175, 143);
            this.dtp_NgayCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayCapNhat.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayCapNhat.Name = "dtp_NgayCapNhat";
            this.dtp_NgayCapNhat.Size = new System.Drawing.Size(347, 29);
            this.dtp_NgayCapNhat.TabIndex = 39;
            this.dtp_NgayCapNhat.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ngày Cập Nhật:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày Lập:";
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Lammoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Lammoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Lammoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_Lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.ForeColor = System.Drawing.Color.Gold;
            this.btn_Lammoi.Location = new System.Drawing.Point(331, 221);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(84, 40);
            this.btn_Lammoi.TabIndex = 36;
            this.btn_Lammoi.Text = "Làm Mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Hỗ Trợ:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Silver;
            this.btnThem.Location = new System.Drawing.Point(11, 221);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 40);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.Navy;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gold;
            this.btnSua.Location = new System.Drawing.Point(119, 221);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 40);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txt_TenLoaiHT
            // 
            this.txt_TenLoaiHT.Location = new System.Drawing.Point(175, 9);
            this.txt_TenLoaiHT.Name = "txt_TenLoaiHT";
            this.txt_TenLoaiHT.Size = new System.Drawing.Size(347, 96);
            this.txt_TenLoaiHT.TabIndex = 18;
            this.txt_TenLoaiHT.Text = "";
            this.txt_TenLoaiHT.TextChanged += new System.EventHandler(this.txt_TenLoaiHT_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Location = new System.Drawing.Point(224, 221);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Trạng Thái:";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_NgayLap.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLap.Location = new System.Drawing.Point(175, 110);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayLap.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayLap.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(347, 29);
            this.dtp_NgayLap.TabIndex = 14;
            this.dtp_NgayLap.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dtp_NgayLap.ValueChanged += new System.EventHandler(this.dtp_NgayLap_ValueChanged);
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Hoạt Động",
            "Tạm Ngưng"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(175, 177);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(347, 29);
            this.cbo_TrangThai.TabIndex = 11;
            // 
            // txt_MaLoaiHT
            // 
            this.txt_MaLoaiHT.Location = new System.Drawing.Point(115, 330);
            this.txt_MaLoaiHT.Name = "txt_MaLoaiHT";
            this.txt_MaLoaiHT.Size = new System.Drawing.Size(347, 29);
            this.txt_MaLoaiHT.TabIndex = 10;
            this.txt_MaLoaiHT.Visible = false;
            // 
            // panel_LoaiHoTro
            // 
            this.panel_LoaiHoTro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_LoaiHoTro.AutoScroll = true;
            this.panel_LoaiHoTro.Controls.Add(this.dgv_LoaiHoTro);
            this.panel_LoaiHoTro.Location = new System.Drawing.Point(549, 50);
            this.panel_LoaiHoTro.Margin = new System.Windows.Forms.Padding(2);
            this.panel_LoaiHoTro.Name = "panel_LoaiHoTro";
            this.panel_LoaiHoTro.Size = new System.Drawing.Size(504, 94);
            this.panel_LoaiHoTro.TabIndex = 38;
            // 
            // dgv_LoaiHoTro
            // 
            this.dgv_LoaiHoTro.AllowDrop = true;
            this.dgv_LoaiHoTro.AllowUserToResizeColumns = false;
            this.dgv_LoaiHoTro.AllowUserToResizeRows = false;
            this.dgv_LoaiHoTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiHoTro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_LoaiHoTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiHoTro.Location = new System.Drawing.Point(2, 0);
            this.dgv_LoaiHoTro.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_LoaiHoTro.MultiSelect = false;
            this.dgv_LoaiHoTro.Name = "dgv_LoaiHoTro";
            this.dgv_LoaiHoTro.ReadOnly = true;
            this.dgv_LoaiHoTro.RowHeadersVisible = false;
            this.dgv_LoaiHoTro.RowHeadersWidth = 51;
            this.dgv_LoaiHoTro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiHoTro.Size = new System.Drawing.Size(1920, 1080);
            this.dgv_LoaiHoTro.TabIndex = 17;
            this.dgv_LoaiHoTro.Click += new System.EventHandler(this.dgv_LoaiHoTro_Click);
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
            this.label6.Text = "Quản Lý Loại Hỗ Trợ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_LoaiHoTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_LoaiHoTro);
            this.Controls.Add(this.panel_ThongTin1);
            this.Controls.Add(this.txt_MaLoaiHT);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_LoaiHoTro";
            this.Text = "Quản Lý Loại Hỗ Trợ";
            this.Load += new System.EventHandler(this.Frm_LoaiHoTro_Load);
            this.ResizeEnd += new System.EventHandler(this.Frm_LoaiHoTro_ResizeEnd);
            this.Resize += new System.EventHandler(this.Frm_LoaiHoTro_Resize);
            this.panel_ThongTin1.ResumeLayout(false);
            this.panel_ThongTin1.PerformLayout();
            this.panel_LoaiHoTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiHoTro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_ThongTin1;
        private System.Windows.Forms.DateTimePicker dtp_NgayCapNhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.RichTextBox txt_TenLoaiHT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaLoaiHT;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.Panel panel_LoaiHoTro;
        private System.Windows.Forms.DataGridView dgv_LoaiHoTro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_HuyAn;
    }
}