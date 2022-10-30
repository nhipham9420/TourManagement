
namespace TourManagement.GUI
{
    partial class FChiPhi
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
            this.doanNameLabel = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.txThanhTien = new System.Windows.Forms.TextBox();
            this.cbbLoaiChiPhi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doanNameLabel
            // 
            this.doanNameLabel.AutoSize = true;
            this.doanNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doanNameLabel.Location = new System.Drawing.Point(14, 32);
            this.doanNameLabel.Name = "doanNameLabel";
            this.doanNameLabel.Size = new System.Drawing.Size(75, 20);
            this.doanNameLabel.TabIndex = 0;
            this.doanNameLabel.Text = "Tên Đoàn";
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThanhTien,
            this.LoaiChiPhi});
            this.gridView.Location = new System.Drawing.Point(14, 80);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(351, 447);
            this.gridView.TabIndex = 1;
            this.gridView.SelectionChanged += new System.EventHandler(this.gridView_SelectionChanged);
            // 
            // txThanhTien
            // 
            this.txThanhTien.Location = new System.Drawing.Point(507, 80);
            this.txThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txThanhTien.Name = "txThanhTien";
            this.txThanhTien.Size = new System.Drawing.Size(182, 27);
            this.txThanhTien.TabIndex = 2;
            // 
            // cbbLoaiChiPhi
            // 
            this.cbbLoaiChiPhi.FormattingEnabled = true;
            this.cbbLoaiChiPhi.Location = new System.Drawing.Point(507, 164);
            this.cbbLoaiChiPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbLoaiChiPhi.Name = "cbbLoaiChiPhi";
            this.cbbLoaiChiPhi.Size = new System.Drawing.Size(182, 28);
            this.cbbLoaiChiPhi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thành Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Chi Phí";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TourManagement.Properties.Resources.plus_16;
            this.button1.Location = new System.Drawing.Point(711, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 31);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLoad_FLoaiChiPhi_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(390, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(498, 252);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(605, 252);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // LoaiChiPhi
            // 
            this.LoaiChiPhi.HeaderText = "Loại Chi Phí";
            this.LoaiChiPhi.MinimumWidth = 6;
            this.LoaiChiPhi.Name = "LoaiChiPhi";
            // 
            // FChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 615);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbLoaiChiPhi);
            this.Controls.Add(this.txThanhTien);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.doanNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FChiPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI PHÍ ĐOÀN";
            this.Activated += new System.EventHandler(this.FChiPhi_Activated);
            this.Load += new System.EventHandler(this.FChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doanNameLabel;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox txThanhTien;
        private System.Windows.Forms.ComboBox cbbLoaiChiPhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiChiPhi;
    }
}