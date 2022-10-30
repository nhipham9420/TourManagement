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
    public partial class FPhanCong : Form
    {
        BUSPhanCong busPhanCong = new BUSPhanCong();
        BUSNhanVien busNhanVien = new BUSNhanVien();

        List<PhanCong> listPhanCong;

        List<NhanVien> listNhanVien;

        List<string> listNhiemVu = new List<string> { "Lái xe", "Hướng dẫn viên", "Thông dịch viên", "Phục vụ" };        

        int currentIndex;

        private int DoanId {get; set; }

        public FPhanCong(Doan doan)
        {
            InitializeComponent();
            DoanId = doan.DoanId;
            doanNameLabel.Text = doan.TenDoan;
        }

        private void FPhanCong_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listPhanCong = busPhanCong.GetByDoanId(DoanId);
            gridView.DataSource = listPhanCong;
            gridView.Columns["NhanVien"].DataPropertyName = "HoTen";
            gridView.Columns["NhiemVu"].DataPropertyName = "NhiemVu";

            listNhanVien = busNhanVien.GetAll();
            cbbNhanVien.DataSource = listNhanVien;
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "NhanVienId";

            cbbNhiemVu.DataSource = listNhiemVu;
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var phanCong = listPhanCong[currentIndex];
            if (phanCong != null)
            {
                cbbNhanVien.SelectedValue = phanCong.NhanVienId;
                cbbNhiemVu.Text = phanCong.NhiemVu;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listPhanCong = busPhanCong.GetByDoanId(DoanId);
            gridView.DataSource = listPhanCong;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
             try
            {
                var phanCong = new PhanCong
                {
                    DoanId = DoanId,
                    NhanVienId = int.Parse(cbbNhanVien.SelectedValue.ToString()),
                    NhiemVu = cbbNhiemVu.Text,
                };

                busPhanCong.Insert(phanCong);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }                   

            Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var phanCong = listPhanCong[currentIndex];
                phanCong.DoanId = DoanId;
                phanCong.NhanVienId = int.Parse(cbbNhanVien.SelectedValue.ToString());
                phanCong.NhanVien = listNhanVien.Find(e => e.NhanVienId == int.Parse(cbbNhanVien.SelectedValue.ToString()));
                phanCong.NhiemVu = cbbNhiemVu.Text;
                busPhanCong.Update(phanCong);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng thử lại", "Không thành công", MessageBoxButtons.OK);
            }

            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var phanCong = listPhanCong[currentIndex];

                busPhanCong.Delete(phanCong);

                Reload();
            }
        }
    }
}
