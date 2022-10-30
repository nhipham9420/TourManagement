
namespace TourManagement.GUI
{
    partial class FThongKeDoan
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
            this.cbbTour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDoanhSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txTongKhach = new System.Windows.Forms.Label();
            this.txTongDoanhSo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDoan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTour
            // 
            this.cbbTour.FormattingEnabled = true;
            this.cbbTour.Location = new System.Drawing.Point(134, 36);
            this.cbbTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTour.Name = "cbbTour";
            this.cbbTour.Size = new System.Drawing.Size(197, 28);
            this.cbbTour.TabIndex = 0;
            this.cbbTour.TextChanged += new System.EventHandler(this.cbbTour_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Đi";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(134, 180);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(197, 27);
            this.dtpNgayDi.TabIndex = 3;
            this.dtpNgayDi.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVe.Location = new System.Drawing.Point(134, 249);
            this.dtpNgayVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(197, 27);
            this.dtpNgayVe.TabIndex = 5;
            this.dtpNgayVe.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Về";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(146, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tour,
            this.Doan,
            this.NgayDi,
            this.NgayVe,
            this.TongKhach,
            this.TongNhanVien,
            this.TongDoanhSo});
            this.gridView.Location = new System.Drawing.Point(391, 36);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(624, 437);
            this.gridView.TabIndex = 7;
            // 
            // Tour
            // 
            this.Tour.HeaderText = "Tour";
            this.Tour.MinimumWidth = 6;
            this.Tour.Name = "Tour";
            // 
            // Doan
            // 
            this.Doan.HeaderText = "Đoàn";
            this.Doan.MinimumWidth = 6;
            this.Doan.Name = "Doan";
            // 
            // NgayDi
            // 
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.MinimumWidth = 6;
            this.NgayDi.Name = "NgayDi";
            // 
            // NgayVe
            // 
            this.NgayVe.HeaderText = "Ngày Về";
            this.NgayVe.MinimumWidth = 6;
            this.NgayVe.Name = "NgayVe";
            // 
            // TongKhach
            // 
            this.TongKhach.HeaderText = "Tổng Khách";
            this.TongKhach.MinimumWidth = 6;
            this.TongKhach.Name = "TongKhach";
            // 
            // TongNhanVien
            // 
            this.TongNhanVien.HeaderText = "Tổng Nhân Viên";
            this.TongNhanVien.MinimumWidth = 6;
            this.TongNhanVien.Name = "TongNhanVien";
            // 
            // TongDoanhSo
            // 
            this.TongDoanhSo.HeaderText = "Tổng Doanh Số";
            this.TongDoanhSo.MinimumWidth = 6;
            this.TongDoanhSo.Name = "TongDoanhSo";
            // 
            // txTongKhach
            // 
            this.txTongKhach.AutoSize = true;
            this.txTongKhach.Location = new System.Drawing.Point(773, 495);
            this.txTongKhach.Name = "txTongKhach";
            this.txTongKhach.Size = new System.Drawing.Size(126, 20);
            this.txTongKhach.TabIndex = 8;
            this.txTongKhach.Text = "Tổng Khách: 1000";
            this.txTongKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txTongDoanhSo
            // 
            this.txTongDoanhSo.AutoSize = true;
            this.txTongDoanhSo.Location = new System.Drawing.Point(773, 537);
            this.txTongDoanhSo.Name = "txTongDoanhSo";
            this.txTongDoanhSo.Size = new System.Drawing.Size(151, 20);
            this.txTongDoanhSo.TabIndex = 9;
            this.txTongDoanhSo.Text = "Tổng Doanh Số: 1000";
            this.txTongDoanhSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đoàn";
            // 
            // cbbDoan
            // 
            this.cbbDoan.FormattingEnabled = true;
            this.cbbDoan.Location = new System.Drawing.Point(134, 108);
            this.cbbDoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDoan.Name = "cbbDoan";
            this.cbbDoan.Size = new System.Drawing.Size(197, 28);
            this.cbbDoan.TabIndex = 10;
            // 
            // FThongKeDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbDoan);
            this.Controls.Add(this.txTongDoanhSo);
            this.Controls.Add(this.txTongKhach);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpNgayVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTour);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FThongKeDoan";
            this.Text = "THỐNG KÊ ĐOÀN";
            this.Load += new System.EventHandler(this.FThongKeDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label txTongKhach;
        private System.Windows.Forms.Label txTongDoanhSo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDoanhSo;
    }
}