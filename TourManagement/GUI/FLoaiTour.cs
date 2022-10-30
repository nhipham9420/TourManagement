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
    public partial class FLoaiTour : Form
    {
        BUSLoaiTour busLoaiTour = new BUSLoaiTour();

        List<LoaiTour> listLoaiTour = new List<LoaiTour>();

        int currentIndex;

        public FLoaiTour()
        {
            InitializeComponent();
        }

        private void FLoaiTour_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listLoaiTour = busLoaiTour.GetAll();
            gridView.DataSource = listLoaiTour;
            gridView.Columns["LoaiTour"].DataPropertyName = "TenLoaiTour";
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var loai = listLoaiTour[currentIndex];
            if (loai != null)
            {
                txTenLoaiTour.Text = loai.TenLoaiTour;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listLoaiTour = busLoaiTour.GetAll();
            gridView.DataSource = listLoaiTour;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var loai = new LoaiTour
            {
                TenLoaiTour = txTenLoaiTour.Text
            };

            busLoaiTour.Insert(loai);

            Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var loai = listLoaiTour[currentIndex];
            loai.TenLoaiTour = txTenLoaiTour.Text;

            busLoaiTour.Update(loai);

            Reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var loai = listLoaiTour[currentIndex];
                busLoaiTour.Delete(loai);

                Reload();
            }   
        }
    }
}
