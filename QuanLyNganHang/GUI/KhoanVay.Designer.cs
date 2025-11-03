namespace GUI
{
    partial class frmKhoanVay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoanVay));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvKhoanVay = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.dgvmakh = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaVay = new System.Windows.Forms.TextBox();
            this.txtSoTienVay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvlaisuat = new System.Windows.Forms.DataGridView();
            this.txtMaLS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpThoiHan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayVay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnxoauser = new System.Windows.Forms.Button();
            this.btn_HuyAn = new System.Windows.Forms.Button();
            this.btn_An = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmakh)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaisuat)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.AllowDrop = true;
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(217, 14);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 49);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.AllowDrop = true;
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.BackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.Location = new System.Drawing.Point(492, 15);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 49);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Làm mới";
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(86, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 49);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKhoanVay
            // 
            this.dgvKhoanVay.AllowUserToAddRows = false;
            this.dgvKhoanVay.AllowUserToResizeColumns = false;
            this.dgvKhoanVay.AllowUserToResizeRows = false;
            this.dgvKhoanVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvKhoanVay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanVay.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoanVay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKhoanVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanVay.Location = new System.Drawing.Point(3, 3);
            this.dgvKhoanVay.MultiSelect = false;
            this.dgvKhoanVay.Name = "dgvKhoanVay";
            this.dgvKhoanVay.ReadOnly = true;
            this.dgvKhoanVay.RowHeadersVisible = false;
            this.dgvKhoanVay.RowHeadersWidth = 62;
            this.dgvKhoanVay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoanVay.Size = new System.Drawing.Size(2000, 408);
            this.dgvKhoanVay.TabIndex = 31;
            this.dgvKhoanVay.Click += new System.EventHandler(this.dgvKhoanVay_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.cboTrangThai);
            this.pnlMain.Controls.Add(this.dgvtaikhoan);
            this.pnlMain.Controls.Add(this.txtMaTK);
            this.pnlMain.Controls.Add(this.dgvmakh);
            this.pnlMain.Controls.Add(this.txtMaKH);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.txtMaVay);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(601, 385);
            this.pnlMain.TabIndex = 30;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Đã tất toán",
            "Quá hạn"});
            this.cboTrangThai.Location = new System.Drawing.Point(218, 338);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(328, 33);
            this.cboTrangThai.TabIndex = 42;
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.AllowDrop = true;
            this.dgvtaikhoan.AllowUserToAddRows = false;
            this.dgvtaikhoan.AllowUserToResizeColumns = false;
            this.dgvtaikhoan.AllowUserToResizeRows = false;
            this.dgvtaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtaikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvtaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Location = new System.Drawing.Point(51, 222);
            this.dgvtaikhoan.MultiSelect = false;
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.ReadOnly = true;
            this.dgvtaikhoan.RowHeadersVisible = false;
            this.dgvtaikhoan.RowHeadersWidth = 51;
            this.dgvtaikhoan.RowTemplate.Height = 24;
            this.dgvtaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtaikhoan.Size = new System.Drawing.Size(550, 105);
            this.dgvtaikhoan.TabIndex = 47;
            this.dgvtaikhoan.Click += new System.EventHandler(this.dgvtaikhoan_Click);
            // 
            // txtMaTK
            // 
            this.txtMaTK.AllowDrop = true;
            this.txtMaTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTK.Location = new System.Drawing.Point(218, 183);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(328, 30);
            this.txtMaTK.TabIndex = 46;
            this.txtMaTK.TextChanged += new System.EventHandler(this.txtMaTK_TextChanged);
            // 
            // dgvmakh
            // 
            this.dgvmakh.AllowDrop = true;
            this.dgvmakh.AllowUserToAddRows = false;
            this.dgvmakh.AllowUserToResizeColumns = false;
            this.dgvmakh.AllowUserToResizeRows = false;
            this.dgvmakh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmakh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmakh.BackgroundColor = System.Drawing.Color.White;
            this.dgvmakh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvmakh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmakh.Location = new System.Drawing.Point(51, 64);
            this.dgvmakh.MultiSelect = false;
            this.dgvmakh.Name = "dgvmakh";
            this.dgvmakh.ReadOnly = true;
            this.dgvmakh.RowHeadersVisible = false;
            this.dgvmakh.RowHeadersWidth = 51;
            this.dgvmakh.RowTemplate.Height = 24;
            this.dgvmakh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmakh.Size = new System.Drawing.Size(550, 105);
            this.dgvmakh.TabIndex = 45;
            this.dgvmakh.Click += new System.EventHandler(this.dgvmakh_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.AllowDrop = true;
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(218, 21);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(328, 30);
            this.txtMaKH.TabIndex = 44;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 33);
            this.label9.TabIndex = 42;
            this.label9.Text = "Mã Tài Khoản:";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 33);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã Khách Hàng:";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 33);
            this.label7.TabIndex = 27;
            this.label7.Text = "Trạng Thái:";
            // 
            // txtMaVay
            // 
            this.txtMaVay.AllowDrop = true;
            this.txtMaVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVay.Location = new System.Drawing.Point(218, 18);
            this.txtMaVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVay.Name = "txtMaVay";
            this.txtMaVay.Size = new System.Drawing.Size(328, 30);
            this.txtMaVay.TabIndex = 20;
            this.txtMaVay.Visible = false;
            this.txtMaVay.TextChanged += new System.EventHandler(this.txtMaVay_TextChanged);
            // 
            // txtSoTienVay
            // 
            this.txtSoTienVay.AllowDrop = true;
            this.txtSoTienVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienVay.Location = new System.Drawing.Point(203, 120);
            this.txtSoTienVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienVay.Name = "txtSoTienVay";
            this.txtSoTienVay.Size = new System.Drawing.Size(328, 30);
            this.txtSoTienVay.TabIndex = 31;
            this.txtSoTienVay.TextChanged += new System.EventHandler(this.txtSoTienVay_TextChanged);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số tiền:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1214, 391);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvlaisuat);
            this.panel1.Controls.Add(this.txtMaLS);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpThoiHan);
            this.panel1.Controls.Add(this.txtSoTienVay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpNgayVay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(610, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 385);
            this.panel1.TabIndex = 31;
            // 
            // dgvlaisuat
            // 
            this.dgvlaisuat.AllowDrop = true;
            this.dgvlaisuat.AllowUserToAddRows = false;
            this.dgvlaisuat.AllowUserToResizeColumns = false;
            this.dgvlaisuat.AllowUserToResizeRows = false;
            this.dgvlaisuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlaisuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlaisuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvlaisuat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvlaisuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlaisuat.Location = new System.Drawing.Point(36, 212);
            this.dgvlaisuat.MultiSelect = false;
            this.dgvlaisuat.Name = "dgvlaisuat";
            this.dgvlaisuat.ReadOnly = true;
            this.dgvlaisuat.RowHeadersVisible = false;
            this.dgvlaisuat.RowHeadersWidth = 51;
            this.dgvlaisuat.RowTemplate.Height = 24;
            this.dgvlaisuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlaisuat.Size = new System.Drawing.Size(562, 105);
            this.dgvlaisuat.TabIndex = 34;
            this.dgvlaisuat.Click += new System.EventHandler(this.dgvlaisuat_Click);
            // 
            // txtMaLS
            // 
            this.txtMaLS.AllowDrop = true;
            this.txtMaLS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLS.Location = new System.Drawing.Point(203, 175);
            this.txtMaLS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLS.Name = "txtMaLS";
            this.txtMaLS.Size = new System.Drawing.Size(328, 30);
            this.txtMaLS.TabIndex = 33;
            this.txtMaLS.TextChanged += new System.EventHandler(this.txtMaLS_TextChanged);
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thời hạn:";
            // 
            // dtpThoiHan
            // 
            this.dtpThoiHan.AllowDrop = true;
            this.dtpThoiHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThoiHan.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiHan.Location = new System.Drawing.Point(203, 65);
            this.dtpThoiHan.MaxDate = new System.DateTime(2999, 11, 11, 0, 0, 0, 0);
            this.dtpThoiHan.Name = "dtpThoiHan";
            this.dtpThoiHan.Size = new System.Drawing.Size(328, 30);
            this.dtpThoiHan.TabIndex = 22;
            this.dtpThoiHan.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Lãi Suất:";
            // 
            // dtpNgayVay
            // 
            this.dtpNgayVay.AllowDrop = true;
            this.dtpNgayVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayVay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVay.Location = new System.Drawing.Point(203, 18);
            this.dtpNgayVay.MaxDate = new System.DateTime(2999, 6, 12, 0, 0, 0, 0);
            this.dtpNgayVay.Name = "dtpNgayVay";
            this.dtpNgayVay.Size = new System.Drawing.Size(328, 30);
            this.dtpNgayVay.TabIndex = 21;
            this.dtpNgayVay.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày vay:";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1244, 50);
            this.label5.TabIndex = 45;
            this.label5.Text = "QUẢN TRỊ KHOẢN VAY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgvKhoanVay);
            this.panel3.Location = new System.Drawing.Point(9, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 211);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnxoauser);
            this.panel4.Controls.Add(this.btn_HuyAn);
            this.panel4.Controls.Add(this.btnHoanTac);
            this.panel4.Controls.Add(this.btn_An);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 758);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1244, 79);
            this.panel4.TabIndex = 47;
            // 
            // btnxoauser
            // 
            this.btnxoauser.AllowDrop = true;
            this.btnxoauser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnxoauser.BackColor = System.Drawing.Color.Red;
            this.btnxoauser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnxoauser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnxoauser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnxoauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoauser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoauser.ForeColor = System.Drawing.Color.White;
            this.btnxoauser.Location = new System.Drawing.Point(363, 14);
            this.btnxoauser.Name = "btnxoauser";
            this.btnxoauser.Size = new System.Drawing.Size(112, 52);
            this.btnxoauser.TabIndex = 50;
            this.btnxoauser.Text = "Xóa";
            this.btnxoauser.UseVisualStyleBackColor = false;
            this.btnxoauser.Click += new System.EventHandler(this.btnxoauser_Click);
            // 
            // btn_HuyAn
            // 
            this.btn_HuyAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_HuyAn.BackColor = System.Drawing.Color.Blue;
            this.btn_HuyAn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HuyAn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_HuyAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_HuyAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyAn.ForeColor = System.Drawing.Color.White;
            this.btn_HuyAn.Location = new System.Drawing.Point(622, 12);
            this.btn_HuyAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HuyAn.Name = "btn_HuyAn";
            this.btn_HuyAn.Size = new System.Drawing.Size(112, 54);
            this.btn_HuyAn.TabIndex = 49;
            this.btn_HuyAn.Text = "Hủy Ẩn";
            this.btn_HuyAn.UseVisualStyleBackColor = false;
            this.btn_HuyAn.Visible = false;
            this.btn_HuyAn.Click += new System.EventHandler(this.btn_HuyAn_Click);
            // 
            // btn_An
            // 
            this.btn_An.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_An.BackColor = System.Drawing.Color.Red;
            this.btn_An.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_An.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_An.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_An.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_An.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_An.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_An.Location = new System.Drawing.Point(363, 12);
            this.btn_An.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_An.Name = "btn_An";
            this.btn_An.Size = new System.Drawing.Size(112, 54);
            this.btn_An.TabIndex = 48;
            this.btn_An.Text = "Xóa";
            this.btn_An.UseVisualStyleBackColor = false;
            this.btn_An.Visible = false;
            this.btn_An.Click += new System.EventHandler(this.btn_An_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 837);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhoanVay";
            this.Text = "Quản Lý Khoản Vay";
            this.Load += new System.EventHandler(this.frmKhoanVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmakh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaisuat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvKhoanVay;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtMaVay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTienVay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DataGridView dgvlaisuat;
        private System.Windows.Forms.TextBox txtMaLS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpThoiHan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayVay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvtaikhoan;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.DataGridView dgvmakh;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btn_HuyAn;
        private System.Windows.Forms.Button btn_An;
        private System.Windows.Forms.Button btnxoauser;
    }
}