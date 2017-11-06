namespace QLSV
{
    partial class XemLichThi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picSinhVien = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGvLichThi = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbMSSV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.picSinhVien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 231);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(67, 209);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(45, 19);
            this.lbMSSV.TabIndex = 2;
            this.lbMSSV.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "MSSV:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(66, 178);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(45, 19);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // picSinhVien
            // 
            this.picSinhVien.Location = new System.Drawing.Point(28, 25);
            this.picSinhVien.Name = "picSinhVien";
            this.picSinhVien.Size = new System.Drawing.Size(141, 131);
            this.picSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSinhVien.TabIndex = 0;
            this.picSinhVien.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(394, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lịch thi học kì";
            // 
            // dataGvLichThi
            // 
            this.dataGvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvLichThi.Location = new System.Drawing.Point(244, 53);
            this.dataGvLichThi.Name = "dataGvLichThi";
            this.dataGvLichThi.Size = new System.Drawing.Size(471, 290);
            this.dataGvLichThi.TabIndex = 4;
            // 
            // XemLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(727, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGvLichThi);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "XemLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemLichThi";
            this.Load += new System.EventHandler(this.XemLichThi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvLichThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGvLichThi;
    }
}