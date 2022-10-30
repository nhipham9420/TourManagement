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
    public partial class FTour : Form
    {
        BUSTour busTour = new BUSTour();
        BUSLoaiTour busLoaiTour = new BUSLoaiTour();

        List<Tour> listTour;
        List<LoaiTour> listLoaiTour;  

        int currentIndex;

        public FTour()
        {            
            InitializeComponent();            
        }

        private void FTour_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            listTour = busTour.GetAll();
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = listTour;
            gridView.Columns["Tour"].DataPropertyName = "TenTour";
            gridView.Columns["LoaiTour"].DataPropertyName = "TenLoaiTour";
            gridView.Columns["DacDiem"].DataPropertyName = "DacDiem";  
            
            listLoaiTour = busLoaiTour.GetAll();
            cbbLoaiTour.DataSource = listLoaiTour;
            cbbLoaiTour.DisplayMember = "TenLoaiTour";
            cbbLoaiTour.ValueMember = "LoaiTourId";
        }

        private void gridViewTour_SelectionChanged(object sender, EventArgs e)
        {            
            currentIndex = gridView.CurrentCell.RowIndex;

            var tour = listTour[currentIndex];

            if( tour != null)
            {
                cbbLoaiTour.SelectedValue = tour.LoaiTourId;
                txTenTour.Text = tour.TenTour;
                txDacDiem.Text = tour.DacDiem;   
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listTour = busTour.GetAll();
            gridView.DataSource = listTour;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var tour = new Tour
            {
                LoaiTourId = int.Parse(cbbLoaiTour.SelectedValue.ToString()),
                TenTour = txTenTour.Text,
                DacDiem = txDacDiem.Text
            };  
            
            busTour.Insert(tour);

            Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var tour = listTour[currentIndex];
            tour.LoaiTourId = int.Parse(cbbLoaiTour.SelectedValue.ToString());
            tour.TenTour = txTenTour.Text;
            tour.DacDiem = txDacDiem.Text;

            busTour.Update(tour);

            Reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var tour = listTour[currentIndex];
                busTour.Delete(tour);

                Reload();
            }            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listTour = busTour.Search(txSearch.Text.Trim());
            gridView.DataSource = listTour;
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listTour = busTour.Search(txSearch.Text.Trim());
            gridView.DataSource = listTour;
        }

        private void btnLoad_FLoaiTour_Click(object sender, EventArgs e)
        {
            FLoaiTour f = new FLoaiTour();
            f.ShowDialog();
        }

        private void btnLoad_FChiTietTour_Click(object sender, EventArgs e)
        {
            FChiTietTour f = new FChiTietTour(listTour[currentIndex]);
            f.ShowDialog();
        }

        private void btnLoad_FBangGia_Click(object sender, EventArgs e)
        {
            FBangGia f = new FBangGia(listTour[currentIndex]);
            f.ShowDialog();
        }
    }
}
