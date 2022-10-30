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
    public partial class FChiTietTour : Form
    {
        BUSChiTietTour busChiTietTour = new BUSChiTietTour();
        BUSDiaDiem busDiaDiem = new BUSDiaDiem();

        List<ChiTietTour> listChiTietTour;
        List<DiaDiem> listDiaDiem;

        int currentIndex;        
        private int TourId { get; set; }

        public FChiTietTour(Tour tour)
        {
            InitializeComponent();
            TourId = tour.TourId;
            tourNameLabel.Text = tour.TenTour;
        }

        private void FChiTietTour_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listChiTietTour = busChiTietTour.GetByTourId(TourId);
            gridView.DataSource = listChiTietTour;
            gridView.Columns["DiaDiem"].DataPropertyName = "TenDiaDiem";
            gridView.Columns["ThuTu"].DataPropertyName = "ThuTuDiaDiem";
        }        

        private void FChiTietTour_Activated(object sender, EventArgs e)
        {
            listDiaDiem = busDiaDiem.GetAll();
            cbbDiaDiem.DataSource = listDiaDiem;
            cbbDiaDiem.DisplayMember = "TenDiaDiem";
            cbbDiaDiem.ValueMember = "DiaDiemId";
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listChiTietTour = busChiTietTour.GetByTourId(TourId);
            gridView.DataSource = listChiTietTour;
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var ctTour = listChiTietTour[currentIndex];
            if (ctTour != null)
            {
                cbbDiaDiem.SelectedValue = ctTour.DiaDiemId;
                txThuTuDiaDiem.Text = ctTour.ThuTuDiaDiem.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
               var chiTietTour = new ChiTietTour
                {
                    TourId = TourId,
                    DiaDiemId = int.Parse(cbbDiaDiem.SelectedValue.ToString()),
                    ThuTuDiaDiem = listChiTietTour.Count() + 1
                };

                busChiTietTour.Insert(chiTietTour);
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
                var chiTietTour = listChiTietTour[currentIndex];
                chiTietTour.TourId = TourId;
                chiTietTour.DiaDiemId = int.Parse(cbbDiaDiem.SelectedValue.ToString());
                chiTietTour.DiaDiem = listDiaDiem.Find(e => e.DiaDiemId == int.Parse(cbbDiaDiem.SelectedValue.ToString()));
                chiTietTour.ThuTuDiaDiem = int.Parse(txThuTuDiaDiem.Text);

                busChiTietTour.Update(chiTietTour);
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
                var chiTietTour = listChiTietTour[currentIndex];

                busChiTietTour.Delete(chiTietTour);

                Reload();
            }
        }

        private void btnLoad_FDiaDiem_Click(object sender, EventArgs e)
        {
            FDiaDiem f = new FDiaDiem();
            f.ShowDialog();
        }
    }
}
