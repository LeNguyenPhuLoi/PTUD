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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvmatknhan = new System.Windows.Forms.DataGridView();
            this.txtMaTKNhan = new System.Windows.Forms.TextBox();
            this.rtxtND = new System.Windows.Forms.RichTextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvmatkgui = new System.Windows.Forms.DataGridView();
            this.txtMaTKGui = new System.Windows.Forms.TextBox();
            this.dgvmatk = new System.Windows.Forms.DataGridView();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.dgvmakh = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaCK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnxoauser = new System.Windows.Forms.Button();
            this.btn_HuyAn = new System.Windows.Forms.Button();
            this.btn_An = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvChuyenKhoan = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatknhan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatkgui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmakh)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInDS
            // 
            this.btnInDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDS.Location = new System.Drawing.Point(1153, 1236);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(91, 34);
            this.btnInDS.TabIndex = 35;
            this.btnInDS.Text = "In DS kho";
            this.btnInDS.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(180, 25);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 49);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(320, 25);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 49);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.BackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.Location = new System.Drawing.Point(457, 25);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 49);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Làm mới";
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(41, 25);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 49);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
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
            this.dtpNgayChuyen.Location = new System.Drawing.Point(277, 212);
            this.dtpNgayChuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayChuyen.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtpNgayChuyen.Name = "dtpNgayChuyen";
            this.dtpNgayChuyen.Size = new System.Drawing.Size(299, 30);
            this.dtpNgayChuyen.TabIndex = 13;
            this.dtpNgayChuyen.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nội dung:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvmatknhan);
            this.panel2.Controls.Add(this.txtMaTKNhan);
            this.panel2.Controls.Add(this.rtxtND);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpNgayChuyen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSoTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(620, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 569);
            this.panel2.TabIndex = 25;
            // 
            // dgvmatknhan
            // 
            this.dgvmatknhan.AllowDrop = true;
            this.dgvmatknhan.AllowUserToResizeColumns = false;
            this.dgvmatknhan.AllowUserToResizeRows = false;
            this.dgvmatknhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmatknhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvmatknhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatknhan.Location = new System.Drawing.Point(26, 76);
            this.dgvmatknhan.MultiSelect = false;
            this.dgvmatknhan.Name = "dgvmatknhan";
            this.dgvmatknhan.ReadOnly = true;
            this.dgvmatknhan.RowHeadersVisible = false;
            this.dgvmatknhan.RowHeadersWidth = 51;
            this.dgvmatknhan.RowTemplate.Height = 24;
            this.dgvmatknhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmatknhan.Size = new System.Drawing.Size(968, 105);
            this.dgvmatknhan.TabIndex = 38;
            this.dgvmatknhan.Click += new System.EventHandler(this.dgvmatknhan_Click);
            // 
            // txtMaTKNhan
            // 
            this.txtMaTKNhan.AllowDrop = true;
            this.txtMaTKNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTKNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTKNhan.Location = new System.Drawing.Point(277, 33);
            this.txtMaTKNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTKNhan.Name = "txtMaTKNhan";
            this.txtMaTKNhan.Size = new System.Drawing.Size(290, 30);
            this.txtMaTKNhan.TabIndex = 37;
            this.txtMaTKNhan.TextChanged += new System.EventHandler(this.txtMaTKNhan_TextChanged);
            // 
            // rtxtND
            // 
            this.rtxtND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtND.Location = new System.Drawing.Point(170, 318);
            this.rtxtND.Name = "rtxtND";
            this.rtxtND.Size = new System.Drawing.Size(406, 106);
            this.rtxtND.TabIndex = 23;
            this.rtxtND.Text = "";
            this.rtxtND.TextChanged += new System.EventHandler(this.rtxtND_TextChanged);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(277, 258);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(299, 30);
            this.txtSoTien.TabIndex = 19;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Tài Khoản Nhận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvmatkgui);
            this.panel1.Controls.Add(this.txtMaTKGui);
            this.panel1.Controls.Add(this.dgvmatk);
            this.panel1.Controls.Add(this.txtMaTK);
            this.panel1.Controls.Add(this.dgvmakh);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMaCK);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 569);
            this.panel1.TabIndex = 24;
            // 
            // dgvmatkgui
            // 
            this.dgvmatkgui.AllowDrop = true;
            this.dgvmatkgui.AllowUserToResizeColumns = false;
            this.dgvmatkgui.AllowUserToResizeRows = false;
            this.dgvmatkgui.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmatkgui.BackgroundColor = System.Drawing.Color.White;
            this.dgvmatkgui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatkgui.Location = new System.Drawing.Point(40, 454);
            this.dgvmatkgui.MultiSelect = false;
            this.dgvmatkgui.Name = "dgvmatkgui";
            this.dgvmatkgui.ReadOnly = true;
            this.dgvmatkgui.RowHeadersVisible = false;
            this.dgvmatkgui.RowHeadersWidth = 51;
            this.dgvmatkgui.RowTemplate.Height = 24;
            this.dgvmatkgui.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmatkgui.Size = new System.Drawing.Size(968, 105);
            this.dgvmatkgui.TabIndex = 40;
            this.dgvmatkgui.Click += new System.EventHandler(this.dgvmatkgui_Click);
            // 
            // txtMaTKGui
            // 
            this.txtMaTKGui.AllowDrop = true;
            this.txtMaTKGui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTKGui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTKGui.Location = new System.Drawing.Point(291, 411);
            this.txtMaTKGui.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTKGui.Name = "txtMaTKGui";
            this.txtMaTKGui.Size = new System.Drawing.Size(290, 30);
            this.txtMaTKGui.TabIndex = 39;
            this.txtMaTKGui.TextChanged += new System.EventHandler(this.txtMaTKGui_TextChanged);
            // 
            // dgvmatk
            // 
            this.dgvmatk.AllowDrop = true;
            this.dgvmatk.AllowUserToResizeColumns = false;
            this.dgvmatk.AllowUserToResizeRows = false;
            this.dgvmatk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmatk.BackgroundColor = System.Drawing.Color.White;
            this.dgvmatk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatk.Location = new System.Drawing.Point(40, 288);
            this.dgvmatk.MultiSelect = false;
            this.dgvmatk.Name = "dgvmatk";
            this.dgvmatk.ReadOnly = true;
            this.dgvmatk.RowHeadersVisible = false;
            this.dgvmatk.RowHeadersWidth = 51;
            this.dgvmatk.RowTemplate.Height = 24;
            this.dgvmatk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmatk.Size = new System.Drawing.Size(968, 105);
            this.dgvmatk.TabIndex = 38;
            this.dgvmatk.Click += new System.EventHandler(this.dgvmatk_Click);
            // 
            // txtMaTK
            // 
            this.txtMaTK.AllowDrop = true;
            this.txtMaTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTK.Location = new System.Drawing.Point(291, 245);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(290, 30);
            this.txtMaTK.TabIndex = 37;
            this.txtMaTK.TextChanged += new System.EventHandler(this.txtMaTK_TextChanged);
            // 
            // dgvmakh
            // 
            this.dgvmakh.AllowDrop = true;
            this.dgvmakh.AllowUserToResizeColumns = false;
            this.dgvmakh.AllowUserToResizeRows = false;
            this.dgvmakh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmakh.BackgroundColor = System.Drawing.Color.White;
            this.dgvmakh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmakh.Location = new System.Drawing.Point(40, 122);
            this.dgvmakh.MultiSelect = false;
            this.dgvmakh.Name = "dgvmakh";
            this.dgvmakh.ReadOnly = true;
            this.dgvmakh.RowHeadersVisible = false;
            this.dgvmakh.RowHeadersWidth = 51;
            this.dgvmakh.RowTemplate.Height = 24;
            this.dgvmakh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmakh.Size = new System.Drawing.Size(968, 105);
            this.dgvmakh.TabIndex = 36;
            this.dgvmakh.Click += new System.EventHandler(this.dgvmakh_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.AllowDrop = true;
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(291, 79);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(290, 30);
            this.txtMaKH.TabIndex = 35;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 33);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã Khách Hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 33);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mã Tài Khoản:";
            // 
            // txtMaCK
            // 
            this.txtMaCK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaCK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCK.Location = new System.Drawing.Point(293, 36);
            this.txtMaCK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCK.Name = "txtMaCK";
            this.txtMaCK.Size = new System.Drawing.Size(288, 30);
            this.txtMaCK.TabIndex = 1;
            this.txtMaCK.TextChanged += new System.EventHandler(this.txtMaCK_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 408);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Tài Khoản Gửi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 33);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1235, 573);
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
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1285, 50);
            this.label8.TabIndex = 45;
            this.label8.Text = "QUẢN TRỊ CHUYỂN KHOẢN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnxoauser);
            this.panel4.Controls.Add(this.btn_HuyAn);
            this.panel4.Controls.Add(this.btn_An);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnHoanTac);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Location = new System.Drawing.Point(0, 849);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1285, 95);
            this.panel4.TabIndex = 47;
            // 
            // btnxoauser
            // 
            this.btnxoauser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnxoauser.BackColor = System.Drawing.Color.Red;
            this.btnxoauser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnxoauser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnxoauser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnxoauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoauser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoauser.ForeColor = System.Drawing.Color.White;
            this.btnxoauser.Location = new System.Drawing.Point(320, 25);
            this.btnxoauser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoauser.Name = "btnxoauser";
            this.btnxoauser.Size = new System.Drawing.Size(112, 49);
            this.btnxoauser.TabIndex = 43;
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
            this.btn_HuyAn.Location = new System.Drawing.Point(796, 25);
            this.btn_HuyAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HuyAn.Name = "btn_HuyAn";
            this.btn_HuyAn.Size = new System.Drawing.Size(112, 49);
            this.btn_HuyAn.TabIndex = 42;
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
            this.btn_An.Location = new System.Drawing.Point(582, 25);
            this.btn_An.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_An.Name = "btn_An";
            this.btn_An.Size = new System.Drawing.Size(193, 49);
            this.btn_An.TabIndex = 41;
            this.btn_An.Text = "Ẩn Khách Hàng";
            this.btn_An.UseVisualStyleBackColor = false;
            this.btn_An.Visible = false;
            this.btn_An.Click += new System.EventHandler(this.btn_An_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgvChuyenKhoan);
            this.panel3.Location = new System.Drawing.Point(12, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 204);
            this.panel3.TabIndex = 48;
            // 
            // dgvChuyenKhoan
            // 
            this.dgvChuyenKhoan.AllowDrop = true;
            this.dgvChuyenKhoan.AllowUserToResizeColumns = false;
            this.dgvChuyenKhoan.AllowUserToResizeRows = false;
            this.dgvChuyenKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuyenKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenKhoan.Location = new System.Drawing.Point(0, 3);
            this.dgvChuyenKhoan.MultiSelect = false;
            this.dgvChuyenKhoan.Name = "dgvChuyenKhoan";
            this.dgvChuyenKhoan.ReadOnly = true;
            this.dgvChuyenKhoan.RowHeadersVisible = false;
            this.dgvChuyenKhoan.RowHeadersWidth = 62;
            this.dgvChuyenKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenKhoan.Size = new System.Drawing.Size(2003, 179);
            this.dgvChuyenKhoan.TabIndex = 31;
            this.dgvChuyenKhoan.Click += new System.EventHandler(this.dgvChuyenKhoan_Click_1);
            // 
            // frmChuyenKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 985);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnInDS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChuyenKhoan";
            this.Text = "Quản Lý Chuyển Khoản";
            this.Load += new System.EventHandler(this.frmChuyenKhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatknhan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatkgui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmakh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayChuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtMaCK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtxtND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvmakh;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DataGridView dgvmatknhan;
        private System.Windows.Forms.TextBox txtMaTKNhan;
        private System.Windows.Forms.DataGridView dgvmatkgui;
        private System.Windows.Forms.TextBox txtMaTKGui;
        private System.Windows.Forms.DataGridView dgvmatk;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvChuyenKhoan;
        private System.Windows.Forms.Button btn_HuyAn;
        private System.Windows.Forms.Button btn_An;
        private System.Windows.Forms.Button btnxoauser;
    }
}