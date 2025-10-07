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
            this.panel_ThongTin1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtpNgayChuyen = new System.Windows.Forms.DateTimePicker();
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
            this.panel_ThongTin1.Controls.Add(this.dateTimePicker1);
            this.panel_ThongTin1.Controls.Add(this.comboBox1);
            this.panel_ThongTin1.Controls.Add(this.textBox5);
            this.panel_ThongTin1.Controls.Add(this.label5);
            this.panel_ThongTin1.Controls.Add(this.richTextBox1);
            this.panel_ThongTin1.Controls.Add(this.label4);
            this.panel_ThongTin1.Controls.Add(this.btn_Lammoi);
            this.panel_ThongTin1.Controls.Add(this.label1);
            this.panel_ThongTin1.Controls.Add(this.label2);
            this.panel_ThongTin1.Controls.Add(this.label3);
            this.panel_ThongTin1.Controls.Add(this.btnThem);
            this.panel_ThongTin1.Controls.Add(this.btnSua);
            this.panel_ThongTin1.Controls.Add(this.btnXoa);
            this.panel_ThongTin1.Controls.Add(this.dtpNgayChuyen);
            this.panel_ThongTin1.Location = new System.Drawing.Point(12, 50);
            this.panel_ThongTin1.Name = "panel_ThongTin1";
            this.panel_ThongTin1.Size = new System.Drawing.Size(527, 312);
            this.panel_ThongTin1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 180);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 29);
            this.dateTimePicker1.TabIndex = 61;
            this.dateTimePicker1.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 29);
            this.comboBox1.TabIndex = 59;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(169, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(350, 29);
            this.textBox5.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Trạng Thái:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(169, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 91);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày Cập Nhật:";
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
            this.btn_Lammoi.Location = new System.Drawing.Point(373, 258);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(84, 40);
            this.btn_Lammoi.TabIndex = 36;
            this.btn_Lammoi.Text = "Làm Mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Loại Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi Tiết:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Tạo:";
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
            this.btnThem.Location = new System.Drawing.Point(57, 258);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 40);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
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
            this.btnSua.Location = new System.Drawing.Point(161, 258);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 40);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
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
            this.btnXoa.Location = new System.Drawing.Point(266, 258);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // dtpNgayChuyen
            // 
            this.dtpNgayChuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayChuyen.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChuyen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChuyen.Location = new System.Drawing.Point(169, 147);
            this.dtpNgayChuyen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayChuyen.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtpNgayChuyen.Name = "dtpNgayChuyen";
            this.dtpNgayChuyen.Size = new System.Drawing.Size(350, 29);
            this.dtpNgayChuyen.TabIndex = 14;
            this.dtpNgayChuyen.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
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
            this.dgv_LoaiTaiKhoan.Size = new System.Drawing.Size(730, 100);
            this.dgv_LoaiTaiKhoan.TabIndex = 17;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel_LoaiTaiKhoan);
            this.Controls.Add(this.panel_ThongTin1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_LoaiTaiKhoan";
            this.Text = "Quản Lý Loại Tài Khoản";
            this.Load += new System.EventHandler(this.Frm_LoaiTaiKhoan_Load);
            this.Resize += new System.EventHandler(this.Frm_LoaiTaiKhoan_Resize);
            this.panel_ThongTin1.ResumeLayout(false);
            this.panel_ThongTin1.PerformLayout();
            this.panel_LoaiTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ThongTin1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtpNgayChuyen;
        private System.Windows.Forms.Panel panel_LoaiTaiKhoan;
        private System.Windows.Forms.DataGridView dgv_LoaiTaiKhoan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
    }
}