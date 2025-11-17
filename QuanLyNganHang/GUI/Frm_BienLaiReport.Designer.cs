namespace GUI
{
    partial class Frm_BienLaiReport
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
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.crp_bienlai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_BienLai1 = new GUI.Reports.Report_BienLai();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(578, 25);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(78, 36);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(662, 25);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(132, 36);
            this.btn_lammoi.TabIndex = 4;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(149, 26);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(422, 30);
            this.txt_timkiem.TabIndex = 5;
            // 
            // crp_bienlai
            // 
            this.crp_bienlai.ActiveViewIndex = 0;
            this.crp_bienlai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crp_bienlai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_bienlai.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_bienlai.Location = new System.Drawing.Point(1, 83);
            this.crp_bienlai.Name = "crp_bienlai";
            this.crp_bienlai.ReportSource = this.Report_BienLai1;
            this.crp_bienlai.Size = new System.Drawing.Size(1450, 711);
            this.crp_bienlai.TabIndex = 0;
            this.crp_bienlai.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // Frm_BienLaiReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crp_bienlai);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_lammoi);
            this.Name = "Frm_BienLaiReport";
            this.Text = "Frm_BienLai";
            this.Load += new System.EventHandler(this.Frm_BienLaiReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_bienlai;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.TextBox txt_timkiem;
        private Reports.Report_BienLai Report_BienLai1;
        private System.Windows.Forms.Label label1;
    }
}