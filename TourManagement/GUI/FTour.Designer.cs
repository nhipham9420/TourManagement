
namespace TourManagement.GUI
{
    partial class FTour
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.txTenTour = new System.Windows.Forms.TextBox();
            this.txDacDiem = new System.Windows.Forms.TextBox();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbbLoaiTour = new System.Windows.Forms.ComboBox();
            this.btnFLoaiTour = new System.Windows.Forms.Button();
            this.btnFCtTour = new System.Windows.Forms.Button();
            this.btnFBangGia = new System.Windows.Forms.Button();
            this.Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DacDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại Tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Tour";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(901, 304);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 31);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(794, 304);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 31);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(675, 304);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 31);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đặc Điểm";
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tour,
            this.LoaiTour,
            this.DacDiem});
            this.gridView.Location = new System.Drawing.Point(14, 99);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(606, 456);
            this.gridView.TabIndex = 9;
            this.gridView.SelectionChanged += new System.EventHandler(this.gridViewTour_SelectionChanged);
            // 
            // txTenTour
            // 
            this.txTenTour.Location = new System.Drawing.Point(763, 99);
            this.txTenTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txTenTour.Name = "txTenTour";
            this.txTenTour.Size = new System.Drawing.Size(205, 27);
            this.txTenTour.TabIndex = 18;
            // 
            // txDacDiem
            // 
            this.txDacDiem.Location = new System.Drawing.Point(763, 235);
            this.txDacDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txDacDiem.Name = "txDacDiem";
            this.txDacDiem.Size = new System.Drawing.Size(205, 27);
            this.txDacDiem.TabIndex = 19;
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(88, 35);
            this.txSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(205, 27);
            this.txSearch.TabIndex = 21;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(14, 35);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(57, 31);
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbLoaiTour
            // 
            this.cbbLoaiTour.FormattingEnabled = true;
            this.cbbLoaiTour.Location = new System.Drawing.Point(763, 167);
            this.cbbLoaiTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbLoaiTour.Name = "cbbLoaiTour";
            this.cbbLoaiTour.Size = new System.Drawing.Size(205, 28);
            this.cbbLoaiTour.TabIndex = 25;
            // 
            // btnFLoaiTour
            // 
            this.btnFLoaiTour.FlatAppearance.BorderSize = 0;
            this.btnFLoaiTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFLoaiTour.Image = global::TourManagement.Properties.Resources.plus_16;
            this.btnFLoaiTour.Location = new System.Drawing.Point(992, 167);
            this.btnFLoaiTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFLoaiTour.Name = "btnFLoaiTour";
            this.btnFLoaiTour.Size = new System.Drawing.Size(26, 31);
            this.btnFLoaiTour.TabIndex = 35;
            this.btnFLoaiTour.UseVisualStyleBackColor = true;
            this.btnFLoaiTour.Click += new System.EventHandler(this.btnLoad_FLoaiTour_Click);
            // 
            // btnFCtTour
            // 
            this.btnFCtTour.FlatAppearance.BorderSize = 0;
            this.btnFCtTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCtTour.Location = new System.Drawing.Point(14, 599);
            this.btnFCtTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFCtTour.Name = "btnFCtTour";
            this.btnFCtTour.Size = new System.Drawing.Size(280, 31);
            this.btnFCtTour.TabIndex = 36;
            this.btnFCtTour.Text = "Chi Tiết Địa Điểm";
            this.btnFCtTour.UseVisualStyleBackColor = true;
            this.btnFCtTour.Click += new System.EventHandler(this.btnLoad_FChiTietTour_Click);
            // 
            // btnFBangGia
            // 
            this.btnFBangGia.FlatAppearance.BorderSize = 0;
            this.btnFBangGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFBangGia.Location = new System.Drawing.Point(339, 599);
            this.btnFBangGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFBangGia.Name = "btnFBangGia";
            this.btnFBangGia.Size = new System.Drawing.Size(280, 31);
            this.btnFBangGia.TabIndex = 37;
            this.btnFBangGia.Text = "Bảng Giá";
            this.btnFBangGia.UseVisualStyleBackColor = true;
            this.btnFBangGia.Click += new System.EventHandler(this.btnLoad_FBangGia_Click);
            // 
            // Tour
            // 
            this.Tour.HeaderText = "Tour";
            this.Tour.MinimumWidth = 6;
            this.Tour.Name = "Tour";
            // 
            // LoaiTour
            // 
            this.LoaiTour.HeaderText = "Loại Tour";
            this.LoaiTour.MinimumWidth = 6;
            this.LoaiTour.Name = "LoaiTour";
            // 
            // DacDiem
            // 
            this.DacDiem.HeaderText = "Đặc Điểm";
            this.DacDiem.MinimumWidth = 6;
            this.DacDiem.Name = "DacDiem";
            // 
            // FTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 681);
            this.Controls.Add(this.btnFBangGia);
            this.Controls.Add(this.btnFCtTour);
            this.Controls.Add(this.btnFLoaiTour);
            this.Controls.Add(this.cbbLoaiTour);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.txDacDiem);
            this.Controls.Add(this.txTenTour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FTour";
            this.Text = "TOURS";
            this.Load += new System.EventHandler(this.FTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox txTenTour;
        private System.Windows.Forms.TextBox txDacDiem;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbbLoaiTour;
        private System.Windows.Forms.Button btnFLoaiTour;
        private System.Windows.Forms.Button btnFCtTour;
        private System.Windows.Forms.Button btnFBangGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn DacDiem;
    }
}