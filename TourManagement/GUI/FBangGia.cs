using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagement.BUS;
using TourManagement.Models;

namespace TourManagement.GUI
{
    public partial class FBangGia : Form
    {
        BUSBangGia busBangGia = new BUSBangGia();

        List<BangGia> listBangGia;
        int currentIndex;

        private int TourId { get; set; }

        public FBangGia(Tour tour)
        {
            InitializeComponent();
            TourId = tour.TourId;
            tourNameLabel.Text = tour.TenTour;
        }

        private void FBangGia_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listBangGia = busBangGia.GetByTourId(TourId);
            gridView.DataSource = listBangGia;
            gridView.Columns["Gia"].DataPropertyName = "GiaTour";
            gridView.Columns["Gia"].DefaultCellStyle.Format = "C0";
            gridView.Columns["Tgbd"].DataPropertyName = "ThoiGianBatDau";
            gridView.Columns["Tgbd"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridView.Columns["Tgkt"].DataPropertyName = "ThoiGianKetThuc";
            gridView.Columns["Tgkt"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var bangGia = listBangGia[currentIndex];
            if (bangGia != null)
            {
                txGia.Text = string.Format("{0:C0}", bangGia.GiaTour);
                dtpThoiGianBatDau.Value = bangGia.ThoiGianBatDau;
                dtpThoiGianKetThuc.Value = bangGia.ThoiGianKetThuc;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listBangGia = busBangGia.GetByTourId(TourId);
            gridView.DataSource = listBangGia;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var bangGia = new BangGia
                {
                    TourId = TourId,
                    GiaTour = decimal.Parse(txGia.Text, NumberStyles.Currency),
                    ThoiGianBatDau = dtpThoiGianBatDau.Value.Date,
                    ThoiGianKetThuc = dtpThoiGianKetThuc.Value.Date
                };

                busBangGia.Insert(bangGia);
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
                var bangGia = listBangGia[currentIndex];
                bangGia.GiaTour = decimal.Parse(txGia.Text, NumberStyles.Currency);
                bangGia.ThoiGianBatDau = dtpThoiGianBatDau.Value;
                bangGia.ThoiGianKetThuc = dtpThoiGianKetThuc.Value;
                busBangGia.Update(bangGia); 
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
                var bangGia = listBangGia[currentIndex];
                busBangGia.Delete(bangGia);

                Reload();
            }  
        }
    }
}
