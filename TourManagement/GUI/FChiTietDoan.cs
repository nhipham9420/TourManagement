using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagement.BUS;
using TourManagement.Models;

namespace TourManagement.GUI
{
    public partial class FChiTietDoan : Form
    {
        BUSChiTietDoan busChiTietDoan = new BUSChiTietDoan();
        BUSKhach busKhach = new BUSKhach();

        List<ChiTietDoan> listChiTietDoan;
        List<Khach> listKhach;
        int currentIndex;
        private int DoanId {get; set; }
        public FChiTietDoan(Doan doan)
        {
            InitializeComponent();
            DoanId = doan.DoanId;
            doanNameLabel.Text = doan.TenDoan;
        }

        private void FChiTietDoan_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listChiTietDoan = busChiTietDoan.GetByDoanId(DoanId);
            gridView.DataSource = listChiTietDoan;
            gridView.Columns["HoTen"].DataPropertyName = "HoTen";
            gridView.Columns["Cmnd"].DataPropertyName = "Cmnd";

            listKhach = busKhach.GetAll();
            cbbKhach.DataSource = listKhach;
            cbbKhach.DisplayMember = "HoTen";
            cbbKhach.ValueMember = "KhachId";
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var chiTietDoan = listChiTietDoan[currentIndex];
            if (chiTietDoan != null)
            {
                cbbKhach.SelectedValue = chiTietDoan.KhachId;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listChiTietDoan = busChiTietDoan.GetByDoanId(DoanId);
            gridView.DataSource = listChiTietDoan;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var chiTietDoan = new ChiTietDoan
                {
                    DoanId = DoanId,
                    KhachId = int.Parse(cbbKhach.SelectedValue.ToString()),
                };

                busChiTietDoan.Insert(chiTietDoan);
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
                var chiTietDoan = listChiTietDoan[currentIndex];
                chiTietDoan.DoanId = DoanId;
                chiTietDoan.KhachId = int.Parse(cbbKhach.SelectedValue.ToString());
                chiTietDoan.Khach = listKhach.Find( e=> e.KhachId == int.Parse(cbbKhach.SelectedValue.ToString()));
                busChiTietDoan.Update(chiTietDoan);
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
                var chiTietDoan = listChiTietDoan[currentIndex];

                busChiTietDoan.Delete(chiTietDoan);

                Reload();
            }
        }
    }
}
