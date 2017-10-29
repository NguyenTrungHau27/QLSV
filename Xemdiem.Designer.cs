namespace QLSV
{
    partial class Xemdiem
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
            this.dlgXemdiem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picSinhVien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dlgXemdiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgXemdiem
            // 
            this.dlgXemdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlgXemdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dlgXemdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlgXemdiem.Location = new System.Drawing.Point(278, 12);
            this.dlgXemdiem.Name = "dlgXemdiem";
            this.dlgXemdiem.Size = new System.Drawing.Size(536, 193);
            this.dlgXemdiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lbMSSV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.picSinhVien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(66, 153);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(45, 19);
            this.lbMSSV.TabIndex = 2;
            this.lbMSSV.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "MSSV:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(65, 122);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(45, 19);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // picSinhVien
            // 
            this.picSinhVien.Location = new System.Drawing.Point(39, 25);
            this.picSinhVien.Name = "picSinhVien";
            this.picSinhVien.Size = new System.Drawing.Size(120, 94);
            this.picSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSinhVien.TabIndex = 0;
            this.picSinhVien.TabStop = false;
            // 
            // Xemdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(826, 221);
            this.Controls.Add(this.dlgXemdiem);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Xemdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Xemdiem_FormClosed);
            this.Load += new System.EventHandler(this.Xemdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlgXemdiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dlgXemdiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSinhVien;
    }
}