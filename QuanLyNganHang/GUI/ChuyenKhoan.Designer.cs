namespace GUI
{
    partial class frmChuyenKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenKhoan));
            this.btnInDS = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvChuyenKhoan = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtMaCK = new System.Windows.Forms.TextBox();
            this.cboMaTKNhan = new System.Windows.Forms.ComboBox();
            this.cboMaTKGui = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInDS
            // 
            this.btnInDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDS.Location = new System.Drawing.Point(865, 826);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(68, 28);
            this.btnInDS.TabIndex = 35;
            this.btnInDS.Text = "In DS kho";
            this.btnInDS.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(135, 24);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 40);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(240, 24);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.BackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.Location = new System.Drawing.Point(343, 24);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(84, 40);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(31, 24);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 40);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(218, 288);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(359, 26);
            this.txtTim.TabIndex = 34;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(32, 288);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(189, 25);
            this.lbTim.TabIndex = 33;
            this.lbTim.Text = "Tìm Chuyển Khoản:";
            // 
            // dgvChuyenKhoan
            // 
            this.dgvChuyenKhoan.AllowUserToResizeColumns = false;
            this.dgvChuyenKhoan.AllowUserToResizeRows = false;
            this.dgvChuyenKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvChuyenKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuyenKhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChuyenKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenKhoan.Location = new System.Drawing.Point(2, 2);
            this.dgvChuyenKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChuyenKhoan.MultiSelect = false;
            this.dgvChuyenKhoan.Name = "dgvChuyenKhoan";
            this.dgvChuyenKhoan.ReadOnly = true;
            this.dgvChuyenKhoan.RowHeadersWidth = 62;
            this.dgvChuyenKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenKhoan.Size = new System.Drawing.Size(1500, 209);
            this.dgvChuyenKhoan.TabIndex = 32;
            this.dgvChuyenKhoan.Click += new System.EventHandler(this.dgvChuyenKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(833, 24);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 40);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Chuyển Khoản:";
            // 
            // dtpNgayChuyen
            // 
            this.dtpNgayChuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayChuyen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChuyen.Location = new System.Drawing.Point(208, 32);
            this.dtpNgayChuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayChuyen.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtpNgayChuyen.Name = "dtpNgayChuyen";
            this.dtpNgayChuyen.Size = new System.Drawing.Size(225, 26);
            this.dtpNgayChuyen.TabIndex = 13;
            this.dtpNgayChuyen.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(114, 63);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(319, 102);
            this.txtNoiDung.TabIndex = 23;
            this.txtNoiDung.Text = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtNoiDung);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpNgayChuyen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(465, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 216);
            this.panel2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtSoTien);
            this.panel1.Controls.Add(this.txtMaCK);
            this.panel1.Controls.Add(this.cboMaTKNhan);
            this.panel1.Controls.Add(this.cboMaTKGui);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 216);
            this.panel1.TabIndex = 24;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(221, 67);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(217, 26);
            this.txtSoTien.TabIndex = 19;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            // 
            // txtMaCK
            // 
            this.txtMaCK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaCK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCK.Location = new System.Drawing.Point(220, 29);
            this.txtMaCK.Name = "txtMaCK";
            this.txtMaCK.Size = new System.Drawing.Size(218, 26);
            this.txtMaCK.TabIndex = 1;
            // 
            // cboMaTKNhan
            // 
            this.cboMaTKNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaTKNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTKNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTKNhan.FormattingEnabled = true;
            this.cboMaTKNhan.Location = new System.Drawing.Point(219, 141);
            this.cboMaTKNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaTKNhan.Name = "cboMaTKNhan";
            this.cboMaTKNhan.Size = new System.Drawing.Size(219, 27);
            this.cboMaTKNhan.TabIndex = 21;
            // 
            // cboMaTKGui
            // 
            this.cboMaTKGui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaTKGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTKGui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTKGui.FormattingEnabled = true;
            this.cboMaTKGui.Location = new System.Drawing.Point(219, 103);
            this.cboMaTKGui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaTKGui.Name = "cboMaTKGui";
            this.cboMaTKGui.Size = new System.Drawing.Size(219, 27);
            this.cboMaTKGui.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Tài Khoản Nhận:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Tài Khoản Gửi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Chuyển Khoản:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 221);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(964, 41);
            this.label8.TabIndex = 45;
            this.label8.Text = "QUẢN TRỊ CHUYỂN KHOẢN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvChuyenKhoan);
            this.panel3.Location = new System.Drawing.Point(9, 329);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 231);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnHoanTac);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 541);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(964, 81);
            this.panel4.TabIndex = 47;
            // 
            // frmChuyenKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbTim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChuyenKhoan";
            this.Text = "Quản Lý Chuyển Khoản";
            this.Load += new System.EventHandler(this.frmChuyenKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvChuyenKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayChuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtMaCK;
        private System.Windows.Forms.ComboBox cboMaTKNhan;
        private System.Windows.Forms.ComboBox cboMaTKGui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}