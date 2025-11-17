namespace GUI
{
    partial class frmApDungKhuyenMai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApDungKhuyenMai));
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_adkm = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_xoauser = new System.Windows.Forms.Button();
            this.btn_HuyAn = new System.Windows.Forms.Button();
            this.cbo_matk = new System.Windows.Forms.ComboBox();
            this.dgv_makh = new System.Windows.Forms.DataGridView();
            this.dgv_makm = new System.Windows.Forms.DataGridView();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_makm = new System.Windows.Forms.TextBox();
            this.dtpNgayApDung = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adkm)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_makh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_makm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHoanTac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.ForeColor = System.Drawing.Color.White;
            this.btnHoanTac.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.Image")));
            this.btnHoanTac.Location = new System.Drawing.Point(307, 13);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(129, 49);
            this.btnHoanTac.TabIndex = 13;
            this.btnHoanTac.Text = "Làm mới";
            this.btnHoanTac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(174, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 49);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(44, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 49);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(927, 50);
            this.label6.TabIndex = 49;
            this.label6.Text = "QUẢN TRỊ ÁP DỤNG KHUYẾN MÃI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dgv_adkm);
            this.panel4.Location = new System.Drawing.Point(16, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 173);
            this.panel4.TabIndex = 50;
            // 
            // dgv_adkm
            // 
            this.dgv_adkm.AllowDrop = true;
            this.dgv_adkm.AllowUserToAddRows = false;
            this.dgv_adkm.AllowUserToResizeColumns = false;
            this.dgv_adkm.AllowUserToResizeRows = false;
            this.dgv_adkm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_adkm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_adkm.BackgroundColor = System.Drawing.Color.White;
            this.dgv_adkm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_adkm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adkm.Location = new System.Drawing.Point(3, 3);
            this.dgv_adkm.MultiSelect = false;
            this.dgv_adkm.Name = "dgv_adkm";
            this.dgv_adkm.ReadOnly = true;
            this.dgv_adkm.RowHeadersVisible = false;
            this.dgv_adkm.RowHeadersWidth = 51;
            this.dgv_adkm.RowTemplate.Height = 24;
            this.dgv_adkm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_adkm.Size = new System.Drawing.Size(900, 269);
            this.dgv_adkm.TabIndex = 51;
            this.dgv_adkm.Click += new System.EventHandler(this.dgv_adkm_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_xoauser);
            this.panel5.Controls.Add(this.btn_HuyAn);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnHoanTac);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 558);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(927, 74);
            this.panel5.TabIndex = 51;
            // 
            // btn_xoauser
            // 
            this.btn_xoauser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_xoauser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xoauser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_xoauser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_xoauser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_xoauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoauser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoauser.ForeColor = System.Drawing.Color.White;
            this.btn_xoauser.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoauser.Image")));
            this.btn_xoauser.Location = new System.Drawing.Point(174, 13);
            this.btn_xoauser.Name = "btn_xoauser";
            this.btn_xoauser.Size = new System.Drawing.Size(112, 49);
            this.btn_xoauser.TabIndex = 44;
            this.btn_xoauser.Text = "Xóa";
            this.btn_xoauser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoauser.UseVisualStyleBackColor = false;
            this.btn_xoauser.Click += new System.EventHandler(this.btn_xoauser_Click);
            // 
            // btn_HuyAn
            // 
            this.btn_HuyAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HuyAn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_HuyAn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HuyAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_HuyAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_HuyAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyAn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyAn.ForeColor = System.Drawing.Color.White;
            this.btn_HuyAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyAn.Image")));
            this.btn_HuyAn.Location = new System.Drawing.Point(451, 13);
            this.btn_HuyAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HuyAn.Name = "btn_HuyAn";
            this.btn_HuyAn.Size = new System.Drawing.Size(112, 49);
            this.btn_HuyAn.TabIndex = 43;
            this.btn_HuyAn.Text = "Hủy Ẩn";
            this.btn_HuyAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HuyAn.UseVisualStyleBackColor = false;
            this.btn_HuyAn.Visible = false;
            this.btn_HuyAn.Click += new System.EventHandler(this.btn_HuyAn_Click);
            // 
            // cbo_matk
            // 
            this.cbo_matk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_matk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_matk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_matk.FormattingEnabled = true;
            this.cbo_matk.Location = new System.Drawing.Point(225, 18);
            this.cbo_matk.Name = "cbo_matk";
            this.cbo_matk.Size = new System.Drawing.Size(184, 33);
            this.cbo_matk.TabIndex = 52;
            // 
            // dgv_makh
            // 
            this.dgv_makh.AllowDrop = true;
            this.dgv_makh.AllowUserToResizeColumns = false;
            this.dgv_makh.AllowUserToResizeRows = false;
            this.dgv_makh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_makh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_makh.BackgroundColor = System.Drawing.Color.White;
            this.dgv_makh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_makh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_makh.Location = new System.Drawing.Point(19, 200);
            this.dgv_makh.MultiSelect = false;
            this.dgv_makh.Name = "dgv_makh";
            this.dgv_makh.ReadOnly = true;
            this.dgv_makh.RowHeadersVisible = false;
            this.dgv_makh.RowHeadersWidth = 51;
            this.dgv_makh.RowTemplate.Height = 24;
            this.dgv_makh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_makh.Size = new System.Drawing.Size(434, 99);
            this.dgv_makh.TabIndex = 51;
            this.dgv_makh.Click += new System.EventHandler(this.dgv_makh_Click);
            // 
            // dgv_makm
            // 
            this.dgv_makm.AllowDrop = true;
            this.dgv_makm.AllowUserToResizeColumns = false;
            this.dgv_makm.AllowUserToResizeRows = false;
            this.dgv_makm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_makm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_makm.BackgroundColor = System.Drawing.Color.White;
            this.dgv_makm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_makm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_makm.ColumnHeadersVisible = false;
            this.dgv_makm.Location = new System.Drawing.Point(19, 54);
            this.dgv_makm.MultiSelect = false;
            this.dgv_makm.Name = "dgv_makm";
            this.dgv_makm.ReadOnly = true;
            this.dgv_makm.RowHeadersVisible = false;
            this.dgv_makm.RowHeadersWidth = 51;
            this.dgv_makm.RowTemplate.Height = 24;
            this.dgv_makm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_makm.Size = new System.Drawing.Size(434, 95);
            this.dgv_makm.TabIndex = 49;
            this.dgv_makm.Click += new System.EventHandler(this.dgv_makm_Click);
            // 
            // txt_makh
            // 
            this.txt_makh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(223, 164);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(230, 30);
            this.txt_makh.TabIndex = 48;
            this.txt_makh.TextChanged += new System.EventHandler(this.txt_makh_TextChanged);
            // 
            // txt_makm
            // 
            this.txt_makm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_makm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makm.Location = new System.Drawing.Point(223, 17);
            this.txt_makm.Name = "txt_makm";
            this.txt_makm.Size = new System.Drawing.Size(230, 30);
            this.txt_makm.TabIndex = 46;
            this.txt_makm.TextChanged += new System.EventHandler(this.txt_makm_TextChanged);
            // 
            // dtpNgayApDung
            // 
            this.dtpNgayApDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayApDung.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayApDung.Enabled = false;
            this.dtpNgayApDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayApDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayApDung.Location = new System.Drawing.Point(225, 78);
            this.dtpNgayApDung.MaxDate = new System.DateTime(2999, 6, 12, 0, 0, 0, 0);
            this.dtpNgayApDung.Name = "dtpNgayApDung";
            this.dtpNgayApDung.Size = new System.Drawing.Size(184, 30);
            this.dtpNgayApDung.TabIndex = 45;
            this.dtpNgayApDung.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 33);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày Áp Dụng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 33);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã Khuyến Mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 33);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mã Tài Khoản:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.93466F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.06534F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.40764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.59236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txt_makm);
            this.panel1.Controls.Add(this.dgv_makh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_makm);
            this.panel1.Controls.Add(this.txt_makh);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 308);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtpNgayApDung);
            this.panel2.Controls.Add(this.cbo_matk);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(481, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 308);
            this.panel2.TabIndex = 1;
            // 
            // frmApDungKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmApDungKhuyenMai";
            this.Text = "Áp Dụng Khuyến Mãi";
            this.Load += new System.EventHandler(this.frmApDungKhuyenMai_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adkm)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_makh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_makm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpNgayApDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_makm;
        private System.Windows.Forms.DataGridView dgv_makh;
        private System.Windows.Forms.DataGridView dgv_makm;
        private System.Windows.Forms.Button btn_HuyAn;
        private System.Windows.Forms.DataGridView dgv_adkm;
        private System.Windows.Forms.Button btn_xoauser;
        private System.Windows.Forms.ComboBox cbo_matk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}