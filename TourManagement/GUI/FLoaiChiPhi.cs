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
    public partial class FLoaiChiPhi : Form
    {
        BUSLoaiChiPhi busLoaiChiPhi = new BUSLoaiChiPhi();

        List<LoaiChiPhi> listLoaiChiPhi;

        int currentIndex;

        public FLoaiChiPhi()
        {
            InitializeComponent();
        }

        private void FLoaiChiPhi_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listLoaiChiPhi = busLoaiChiPhi.GetAll();
            gridView.DataSource = listLoaiChiPhi;
            gridView.Columns["LoaiChiPhi"].DataPropertyName = "TenLoaiChiPhi";
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var loai = listLoaiChiPhi[currentIndex];
            if (loai != null)
            {
                txTenLoaiChiPhi.Text = loai.TenLoaiChiPhi;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listLoaiChiPhi = busLoaiChiPhi.GetAll();
            gridView.DataSource = listLoaiChiPhi;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var loai = new LoaiChiPhi
            {
               TenLoaiChiPhi = txTenLoaiChiPhi.Text
            };

            busLoaiChiPhi.Insert(loai);

            Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var loai = listLoaiChiPhi[currentIndex];
            loai.TenLoaiChiPhi = txTenLoaiChiPhi.Text;

            busLoaiChiPhi.Update(loai);

            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var loai = listLoaiChiPhi[currentIndex];

                busLoaiChiPhi.Delete(loai);

                Reload();
            }   
        }
    }
}
