
namespace TourManagement.GUI
{
    partial class FThongKe
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
            this.tlpTK = new System.Windows.Forms.TableLayoutPanel();
            this.pTkCp = new System.Windows.Forms.Panel();
            this.txTongDoanhSo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pTkNv = new System.Windows.Forms.Panel();
            this.txTongNhanVien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pTkDoan = new System.Windows.Forms.Panel();
            this.txTongDoan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pTkTour = new System.Windows.Forms.Panel();
            this.txTongTour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pTK = new System.Windows.Forms.Panel();
            this.tlpTK.SuspendLayout();
            this.pTkCp.SuspendLayout();
            this.pTkNv.SuspendLayout();
            this.pTkDoan.SuspendLayout();
            this.pTkTour.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTK
            // 
            this.tlpTK.ColumnCount = 4;
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTK.Controls.Add(this.pTkCp, 3, 0);
            this.tlpTK.Controls.Add(this.pTkNv, 2, 0);
            this.tlpTK.Controls.Add(this.pTkDoan, 1, 0);
            this.tlpTK.Controls.Add(this.pTkTour, 0, 0);
            this.tlpTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTK.Location = new System.Drawing.Point(0, 0);
            this.tlpTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpTK.Name = "tlpTK";
            this.tlpTK.RowCount = 1;
            this.tlpTK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTK.Size = new System.Drawing.Size(1125, 133);
            this.tlpTK.TabIndex = 0;
            // 
            // pTkCp
            // 
            this.pTkCp.BackColor = System.Drawing.Color.Teal;
            this.pTkCp.Controls.Add(this.txTongDoanhSo);
            this.pTkCp.Controls.Add(this.label8);
            this.pTkCp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkCp.Location = new System.Drawing.Point(849, 7);
            this.pTkCp.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pTkCp.Name = "pTkCp";
            this.pTkCp.Size = new System.Drawing.Size(270, 119);
            this.pTkCp.TabIndex = 3;
            // 
            // txTongChiPhi
            // 
            this.txTongDoanhSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txTongDoanhSo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txTongDoanhSo.ForeColor = System.Drawing.Color.White;
            this.txTongDoanhSo.Location = new System.Drawing.Point(3, 64);
            this.txTongDoanhSo.Name = "txTongChiPhi";
            this.txTongDoanhSo.Size = new System.Drawing.Size(263, 37);
            this.txTongDoanhSo.TabIndex = 1;
            this.txTongDoanhSo.Text = "1000";
            this.txTongDoanhSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "DOANH SỐ";
            this.label8.Click += new System.EventHandler(this.label_ThongKeDoanhSoChart_Click);
            // 
            // pTkNv
            // 
            this.pTkNv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pTkNv.Controls.Add(this.txTongNhanVien);
            this.pTkNv.Controls.Add(this.label6);
            this.pTkNv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkNv.Location = new System.Drawing.Point(568, 7);
            this.pTkNv.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pTkNv.Name = "pTkNv";
            this.pTkNv.Size = new System.Drawing.Size(269, 119);
            this.pTkNv.TabIndex = 2;
            // 
            // txTongNhanVien
            // 
            this.txTongNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txTongNhanVien.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txTongNhanVien.ForeColor = System.Drawing.Color.White;
            this.txTongNhanVien.Location = new System.Drawing.Point(2, 64);
            this.txTongNhanVien.Name = "txTongNhanVien";
            this.txTongNhanVien.Size = new System.Drawing.Size(263, 37);
            this.txTongNhanVien.TabIndex = 1;
            this.txTongNhanVien.Text = "1000";
            this.txTongNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "NHÂN VIÊN";
            this.label6.Click += new System.EventHandler(this.label_ThongKeNhanVienChart_Click);
            // 
            // pTkDoan
            // 
            this.pTkDoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pTkDoan.Controls.Add(this.txTongDoan);
            this.pTkDoan.Controls.Add(this.label4);
            this.pTkDoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkDoan.Location = new System.Drawing.Point(287, 7);
            this.pTkDoan.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pTkDoan.Name = "pTkDoan";
            this.pTkDoan.Size = new System.Drawing.Size(269, 119);
            this.pTkDoan.TabIndex = 1;
            // 
            // txTongDoan
            // 
            this.txTongDoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txTongDoan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txTongDoan.ForeColor = System.Drawing.Color.White;
            this.txTongDoan.Location = new System.Drawing.Point(2, 64);
            this.txTongDoan.Name = "txTongDoan";
            this.txTongDoan.Size = new System.Drawing.Size(263, 37);
            this.txTongDoan.TabIndex = 1;
            this.txTongDoan.Text = "1000";
            this.txTongDoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐOÀN";
            this.label4.Click += new System.EventHandler(this.label_ThongKeDoan_Click);
            // 
            // pTkTour
            // 
            this.pTkTour.BackColor = System.Drawing.Color.YellowGreen;
            this.pTkTour.Controls.Add(this.txTongTour);
            this.pTkTour.Controls.Add(this.label1);
            this.pTkTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTkTour.Location = new System.Drawing.Point(6, 7);
            this.pTkTour.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pTkTour.Name = "pTkTour";
            this.pTkTour.Size = new System.Drawing.Size(269, 119);
            this.pTkTour.TabIndex = 0;
            // 
            // txTongTour
            // 
            this.txTongTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txTongTour.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txTongTour.ForeColor = System.Drawing.Color.White;
            this.txTongTour.Location = new System.Drawing.Point(2, 64);
            this.txTongTour.Name = "txTongTour";
            this.txTongTour.Size = new System.Drawing.Size(263, 37);
            this.txTongTour.TabIndex = 1;
            this.txTongTour.Text = "1000";
            this.txTongTour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOUR";
            this.label1.Click += new System.EventHandler(this.label_ThongKeTour_Click);
            // 
            // pTK
            // 
            this.pTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTK.Location = new System.Drawing.Point(0, 133);
            this.pTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pTK.Name = "pTK";
            this.pTK.Size = new System.Drawing.Size(1125, 548);
            this.pTK.TabIndex = 1;
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 681);
            this.Controls.Add(this.pTK);
            this.Controls.Add(this.tlpTK);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FThongKe";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.FThongKe_Load);
            this.tlpTK.ResumeLayout(false);
            this.pTkCp.ResumeLayout(false);
            this.pTkCp.PerformLayout();
            this.pTkNv.ResumeLayout(false);
            this.pTkNv.PerformLayout();
            this.pTkDoan.ResumeLayout(false);
            this.pTkDoan.PerformLayout();
            this.pTkTour.ResumeLayout(false);
            this.pTkTour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTK;
        private System.Windows.Forms.Panel pTkTour;
        private System.Windows.Forms.Label txTongTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pTkCp;
        private System.Windows.Forms.Label txTongDoanhSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pTkNv;
        private System.Windows.Forms.Label txTongNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pTkDoan;
        private System.Windows.Forms.Label txTongDoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pTK;
    }
}