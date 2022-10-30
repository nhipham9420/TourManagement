using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagement.Models;
using TourManagement.BUS;

namespace TourManagement.GUI
{
    public partial class FNhanVien : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();

        List<NhanVien> listNhanVien;
        
        List<string> listGioiTinh = new List<string> { "Nam", "Nữ" };

        int currentIndex;

        public FNhanVien()
        {
            InitializeComponent();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listNhanVien = busNhanVien.GetAll();
            gridView.DataSource = listNhanVien;
            gridView.Columns["HoTen"].DataPropertyName = "HoTen";
            gridView.Columns["GioiTinh"].DataPropertyName = "GioiTinh";
            gridView.Columns["Sdt"].DataPropertyName = "SoDienThoai";

            cbbGioiTinh.DataSource = listGioiTinh;
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;

            var nhanVien = listNhanVien[currentIndex];

            if( nhanVien != null)
            {
                txHoTen.Text = nhanVien.HoTen;
                cbbGioiTinh.Text = nhanVien.GioiTinh;
                txSoDienThoai.Text = nhanVien.SoDienThoai;  
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listNhanVien = busNhanVien.GetAll();
            gridView.DataSource = listNhanVien;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var nhanVien = new NhanVien
            {
                HoTen = txHoTen.Text,
                GioiTinh = cbbGioiTinh.Text,
                SoDienThoai = txSoDienThoai.Text,
            };

            busNhanVien.Insert(nhanVien);

            Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var nhanVien = listNhanVien[currentIndex];
            nhanVien.HoTen = txHoTen.Text;
            nhanVien.GioiTinh = cbbGioiTinh.Text;
            nhanVien.SoDienThoai = txSoDienThoai.Text;

            busNhanVien.Update(nhanVien);

            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var nhanVien = listNhanVien[currentIndex];

                busNhanVien.Delete(nhanVien);

                Reload();
            }
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listNhanVien = busNhanVien.Search(txSearch.Text.Trim());
            gridView.DataSource = listNhanVien;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listNhanVien = busNhanVien.Search(txSearch.Text.Trim());
            gridView.DataSource = listNhanVien;
        }
    }
}
