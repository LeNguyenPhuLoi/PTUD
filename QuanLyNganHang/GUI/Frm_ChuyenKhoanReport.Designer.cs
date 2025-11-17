namespace GUI
{
    partial class Frm_ChuyenKhoanReport
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
            this.crp_chuyenkhoan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_ChuyenKhoan1 = new GUI.Reports.Report_ChuyenKhoan();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crp_chuyenkhoan
            // 
            this.crp_chuyenkhoan.ActiveViewIndex = 0;
            this.crp_chuyenkhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crp_chuyenkhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_chuyenkhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_chuyenkhoan.Location = new System.Drawing.Point(12, 65);
            this.crp_chuyenkhoan.Name = "crp_chuyenkhoan";
            this.crp_chuyenkhoan.ReportSource = this.Report_ChuyenKhoan1;
            this.crp_chuyenkhoan.Size = new System.Drawing.Size(1186, 694);
            this.crp_chuyenkhoan.TabIndex = 0;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(557, 20);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(124, 36);
            this.btn_lammoi.TabIndex = 8;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(466, 20);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(78, 36);
            this.btn_tim.TabIndex = 7;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(152, 23);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(308, 30);
            this.txt_timkiem.TabIndex = 9;
            // 
            // Frm_ChuyenKhoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 766);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crp_chuyenkhoan);
            this.Name = "Frm_ChuyenKhoanReport";
            this.Text = "Frm_ChuyenKhoan";
            this.Load += new System.EventHandler(this.Frm_ChuyenKhoanReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_chuyenkhoan;
        private Reports.Report_ChuyenKhoan Report_ChuyenKhoan1;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}