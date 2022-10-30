
namespace TourManagement.GUI
{
    partial class FBangGia
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
            this.tourNameLabel = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tgbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tgkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txGia = new System.Windows.Forms.TextBox();
            this.dtpThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tourNameLabel
            // 
            this.tourNameLabel.AutoSize = true;
            this.tourNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tourNameLabel.Location = new System.Drawing.Point(14, 39);
            this.tourNameLabel.Name = "tourNameLabel";
            this.tourNameLabel.Size = new System.Drawing.Size(70, 20);
            this.tourNameLabel.TabIndex = 0;
            this.tourNameLabel.Text = "Tên Tour";
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gia,
            this.Tgbd,
            this.Tgkt});
            this.gridView.Location = new System.Drawing.Point(14, 96);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(399, 476);
            this.gridView.TabIndex = 3;
            this.gridView.SelectionChanged += new System.EventHandler(this.gridView_SelectionChanged);
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá ";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // Tgbd
            // 
            this.Tgbd.HeaderText = "TGBĐ";
            this.Tgbd.MinimumWidth = 6;
            this.Tgbd.Name = "Tgbd";
            // 
            // Tgkt
            // 
            this.Tgkt.HeaderText = "TGKT";
            this.Tgkt.MinimumWidth = 6;
            this.Tgkt.Name = "Tgkt";
            // 
            // txGia
            // 
            this.txGia.Location = new System.Drawing.Point(547, 96);
            this.txGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txGia.Name = "txGia";
            this.txGia.Size = new System.Drawing.Size(188, 27);
            this.txGia.TabIndex = 4;
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(547, 177);
            this.dtpThoiGianBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(188, 27);
            this.dtpThoiGianBatDau.TabIndex = 5;
            // 
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(547, 257);
            this.dtpThoiGianKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(188, 27);
            this.dtpThoiGianKetThuc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TGBĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "TGKT";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(426, 352);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(547, 352);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(667, 352);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 12;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 615);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpThoiGianKetThuc);
            this.Controls.Add(this.dtpThoiGianBatDau);
            this.Controls.Add(this.txGia);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.tourNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBangGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG GIÁ TOUR";
            this.Load += new System.EventHandler(this.FBangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tourNameLabel;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox txGia;
        private System.Windows.Forms.DateTimePicker dtpThoiGianBatDau;
        private System.Windows.Forms.DateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tgbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tgkt;
    }
}