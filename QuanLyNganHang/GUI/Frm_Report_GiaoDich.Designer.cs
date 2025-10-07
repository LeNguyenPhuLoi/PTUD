namespace GUI
{
    partial class Frm_Report_GiaoDich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Report_GiaoDich));
            this.crv_GiaoDich = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_GiaoDich1 = new GUI.Reports.Report_GiaoDich();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flp_Control = new System.Windows.Forms.FlowLayoutPanel();
            this.PB_Minimize = new System.Windows.Forms.PictureBox();
            this.PB_Resize = new System.Windows.Forms.PictureBox();
            this.PB_Close = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Tim = new System.Windows.Forms.Panel();
            this.dtpNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flp_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Close)).BeginInit();
            this.panel_Tim.SuspendLayout();
            this.SuspendLayout();
            // 
            // crv_GiaoDich
            // 
            this.crv_GiaoDich.ActiveViewIndex = 0;
            this.crv_GiaoDich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crv_GiaoDich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_GiaoDich.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_GiaoDich.Location = new System.Drawing.Point(1, 126);
            this.crv_GiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.crv_GiaoDich.Name = "crv_GiaoDich";
            this.crv_GiaoDich.ReportSource = this.Report_GiaoDich1;
            this.crv_GiaoDich.Size = new System.Drawing.Size(1133, 535);
            this.crv_GiaoDich.TabIndex = 15;
            this.crv_GiaoDich.ToolPanelWidth = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.flp_Control);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 44);
            this.panel1.TabIndex = 21;
            // 
            // flp_Control
            // 
            this.flp_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Control.Controls.Add(this.PB_Minimize);
            this.flp_Control.Controls.Add(this.PB_Resize);
            this.flp_Control.Controls.Add(this.PB_Close);
            this.flp_Control.Location = new System.Drawing.Point(1013, 3);
            this.flp_Control.Name = "flp_Control";
            this.flp_Control.Size = new System.Drawing.Size(117, 33);
            this.flp_Control.TabIndex = 3;
            // 
            // PB_Minimize
            // 
            this.PB_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("PB_Minimize.Image")));
            this.PB_Minimize.Location = new System.Drawing.Point(3, 3);
            this.PB_Minimize.Name = "PB_Minimize";
            this.PB_Minimize.Size = new System.Drawing.Size(32, 32);
            this.PB_Minimize.TabIndex = 3;
            this.PB_Minimize.TabStop = false;
            this.PB_Minimize.Click += new System.EventHandler(this.PB_Minimize_Click);
            // 
            // PB_Resize
            // 
            this.PB_Resize.Image = ((System.Drawing.Image)(resources.GetObject("PB_Resize.Image")));
            this.PB_Resize.Location = new System.Drawing.Point(41, 3);
            this.PB_Resize.Name = "PB_Resize";
            this.PB_Resize.Size = new System.Drawing.Size(32, 32);
            this.PB_Resize.TabIndex = 2;
            this.PB_Resize.TabStop = false;
            this.PB_Resize.Click += new System.EventHandler(this.PB_Resize_Click);
            // 
            // PB_Close
            // 
            this.PB_Close.Image = ((System.Drawing.Image)(resources.GetObject("PB_Close.Image")));
            this.PB_Close.Location = new System.Drawing.Point(79, 3);
            this.PB_Close.Name = "PB_Close";
            this.PB_Close.Size = new System.Drawing.Size(32, 32);
            this.PB_Close.TabIndex = 1;
            this.PB_Close.TabStop = false;
            this.PB_Close.Click += new System.EventHandler(this.PB_Close_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(336, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(321, 42);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Báo Cáo Giao Dịch";
            // 
            // panel_Tim
            // 
            this.panel_Tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Tim.Controls.Add(this.dtpNgayChuyen);
            this.panel_Tim.Controls.Add(this.label2);
            this.panel_Tim.Controls.Add(this.txt_MaKH);
            this.panel_Tim.Controls.Add(this.btn_Tim);
            this.panel_Tim.Controls.Add(this.label1);
            this.panel_Tim.Controls.Add(this.btn_Lammoi);
            this.panel_Tim.Location = new System.Drawing.Point(1, 50);
            this.panel_Tim.Name = "panel_Tim";
            this.panel_Tim.Size = new System.Drawing.Size(1085, 57);
            this.panel_Tim.TabIndex = 40;
            // 
            // dtpNgayChuyen
            // 
            this.dtpNgayChuyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayChuyen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChuyen.Location = new System.Drawing.Point(587, 12);
            this.dtpNgayChuyen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayChuyen.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtpNgayChuyen.Name = "dtpNgayChuyen";
            this.dtpNgayChuyen.Size = new System.Drawing.Size(312, 29);
            this.dtpNgayChuyen.TabIndex = 41;
            this.dtpNgayChuyen.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ngày Giao Dịch:";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(133, 15);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(312, 29);
            this.txt_MaKH.TabIndex = 19;
            this.txt_MaKH.Tag = "Nhập";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Tim.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Tim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_Tim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.ForeColor = System.Drawing.Color.Silver;
            this.btn_Tim.Location = new System.Drawing.Point(903, 8);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(84, 40);
            this.btn_Tim.TabIndex = 38;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Số Tài Khoản:";
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Lammoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Lammoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Lammoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_Lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.ForeColor = System.Drawing.Color.Gold;
            this.btn_Lammoi.Location = new System.Drawing.Point(991, 8);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(84, 40);
            this.btn_Lammoi.TabIndex = 37;
            this.btn_Lammoi.Text = "Làm Mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            // 
            // Frm_Report_GiaoDich
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1133, 661);
            this.Controls.Add(this.panel_Tim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crv_GiaoDich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Report_GiaoDich";
            this.Text = "Báo Cáo Giao Dịch";
            this.Load += new System.EventHandler(this.Frm_Report_GiaoDich_Load);
            this.Resize += new System.EventHandler(this.Frm_Report_GiaoDich_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Close)).EndInit();
            this.panel_Tim.ResumeLayout(false);
            this.panel_Tim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_GiaoDich;
        private Reports.Report_GiaoDich Report_GiaoDich1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flp_Control;
        private System.Windows.Forms.PictureBox PB_Minimize;
        private System.Windows.Forms.PictureBox PB_Resize;
        private System.Windows.Forms.PictureBox PB_Close;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.DateTimePicker dtpNgayChuyen;
    }
}