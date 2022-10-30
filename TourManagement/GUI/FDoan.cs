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
    public partial class FDoan : Form
    {
        BUSDoan busDoan = new BUSDoan();
        BUSTour busTour = new BUSTour();

        List<Doan> listDoan;
        List<Tour> listTour;

        int currentIndex;

        public FDoan()
        {
            InitializeComponent();
        }

        private void FDoan_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            listDoan = busDoan.GetAll();
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = listDoan;
            gridView.Columns["Tour"].DataPropertyName = "TenTour";
            gridView.Columns["Doan"].DataPropertyName = "TenDoan";            
            gridView.Columns["NgayDi"].DataPropertyName = "NgayDi";  
            gridView.Columns["NgayDi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridView.Columns["NgayVe"].DataPropertyName = "NgayVe";  
            gridView.Columns["NgayVe"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridView.Columns["NoiDung"].DataPropertyName = "NoiDung";  

            listTour = busTour.GetAll();
            cbbTour.DataSource = listTour;
            cbbTour.DisplayMember = "TenTour";
            cbbTour.ValueMember = "TourId";
        }

        private void btnLoad_FPhanCong_Click(object sender, EventArgs e)
        {
            FPhanCong f = new FPhanCong(listDoan[currentIndex]);
            f.ShowDialog();
        }

        private void btnLoad_FChiTietDoan_Click(object sender, EventArgs e)
        {
            FChiTietDoan f = new FChiTietDoan(listDoan[currentIndex]);
            f.ShowDialog();
        }

        private void btnLoad_FChiPhi_Click(object sender, EventArgs e)
        {
            FChiPhi f = new FChiPhi(listDoan[currentIndex]);
            f.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;

            var doan = listDoan[currentIndex];

            if( doan != null)
            {
                cbbTour.SelectedValue = doan.TourId;
                txTenDoan.Text = doan.TenDoan;
                dtpNgayDi.Value = doan.NgayDi;
                dtpNgayVe.Value = doan.NgayVe;
                txNoiDung.Text = doan.NoiDung;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listDoan = busDoan.GetAll();
            gridView.DataSource = listDoan;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var doan = new Doan
                {
                    TourId = int.Parse(cbbTour.SelectedValue.ToString()),
                    TenDoan = txTenDoan.Text,
                    NgayDi = dtpNgayDi.Value.Date,
                    NgayVe = dtpNgayVe.Value.Date,
                    NoiDung = txNoiDung.Text
                };  
            
                busDoan.Insert(doan); 
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
                var doan = listDoan[currentIndex];
                doan.TourId = int.Parse(cbbTour.SelectedValue.ToString());
                doan.Tour = listTour.Find(e => e.TourId == int.Parse(cbbTour.SelectedValue.ToString()));
                doan.TenDoan = txTenDoan.Text;
                doan.NgayDi = dtpNgayDi.Value.Date;
                doan.NgayVe = dtpNgayVe.Value.Date;
                doan.NoiDung = txNoiDung.Text;

                busDoan.Update(doan);
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
            if(cf == DialogResult.Yes)
            {
                var doan = listDoan[currentIndex];

                busDoan.Delete(doan);

                Reload();
            }
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listDoan = busDoan.Search(txSearch.Text.Trim());
            gridView.DataSource = listDoan;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listDoan = busDoan.Search(txSearch.Text.Trim());
            gridView.DataSource = listDoan;
        }
    }
}
