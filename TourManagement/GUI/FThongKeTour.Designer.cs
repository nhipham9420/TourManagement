
namespace TourManagement.GUI
{
    partial class FThongKeTour
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.cbbTour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txTongKhach = new System.Windows.Forms.Label();
            this.txTongDoanhSo = new System.Windows.Forms.Label();
            this.Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDoanhSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tour,
            this.TongDoan,
            this.TongKhach,
            this.TongNhanVien,
            this.GiaTour,
            this.TongDoanhSo});
            this.gridView.Location = new System.Drawing.Point(334, 52);
            this.gridView.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(675, 415);
            this.gridView.TabIndex = 5;
            // 
            // cbbTour
            // 
            this.cbbTour.FormattingEnabled = true;
            this.cbbTour.Location = new System.Drawing.Point(103, 52);
            this.cbbTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTour.Name = "cbbTour";
            this.cbbTour.Size = new System.Drawing.Size(189, 28);
            this.cbbTour.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tour";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(145, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "TK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txTongKhach
            // 
            this.txTongKhach.AutoSize = true;
            this.txTongKhach.Location = new System.Drawing.Point(778, 499);
            this.txTongKhach.Name = "txTongKhach";
            this.txTongKhach.Size = new System.Drawing.Size(126, 20);
            this.txTongKhach.TabIndex = 9;
            this.txTongKhach.Text = "Tổng Khách: 1000";
            this.txTongKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txTongDoanhSo
            // 
            this.txTongDoanhSo.AutoSize = true;
            this.txTongDoanhSo.Location = new System.Drawing.Point(778, 541);
            this.txTongDoanhSo.Name = "txTongDoanhSo";
            this.txTongDoanhSo.Size = new System.Drawing.Size(151, 20);
            this.txTongDoanhSo.TabIndex = 10;
            this.txTongDoanhSo.Text = "Tổng Doanh Số: 1000";
            this.txTongDoanhSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tour
            // 
            this.Tour.HeaderText = "Tour";
            this.Tour.MinimumWidth = 6;
            this.Tour.Name = "Tour";
            // 
            // TongDoan
            // 
            this.TongDoan.HeaderText = "Tổng Đoàn";
            this.TongDoan.MinimumWidth = 6;
            this.TongDoan.Name = "TongDoan";
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
            // GiaTour
            // 
            this.GiaTour.HeaderText = "Giá Tour";
            this.GiaTour.MinimumWidth = 6;
            this.GiaTour.Name = "GiaTour";
            // 
            // TongDoanhSo
            // 
            this.TongDoanhSo.HeaderText = "Tổng Doanh Số";
            this.TongDoanhSo.MinimumWidth = 6;
            this.TongDoanhSo.Name = "TongDoanhSo";
            // 
            // FThongKeTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.txTongDoanhSo);
            this.Controls.Add(this.txTongKhach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTour);
            this.Controls.Add(this.gridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FThongKeTour";
            this.Text = "THỐNG KÊ TOUR";
            this.Load += new System.EventHandler(this.FTkTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.ComboBox cbbTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txTongKhach;
        private System.Windows.Forms.Label txTongDoanhSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDoanhSo;
    }
}