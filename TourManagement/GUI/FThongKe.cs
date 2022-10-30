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
    public partial class FThongKe : Form
    {
        BUSTour busTour = new BUSTour();
        BUSDoan busDoan = new BUSDoan();
        BUSNhanVien busNhanVien = new BUSNhanVien();

        public FThongKe()
        {
            InitializeComponent();
        }
        
        private void LoadFormThongKe(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pTK.Controls.Add(f);
            this.pTK.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
            txTongTour.Text = busTour.GetAll().Count.ToString();
            txTongDoan.Text = busDoan.GetAll().Count.ToString();
            txTongNhanVien.Text = busNhanVien.GetAll().Count.ToString();
            txTongDoanhSo.Text = string.Format("{0:C0}", busTour.ThongKe().Sum(t => t.TongDoanhSo));

            FThongKeDoan f = new FThongKeDoan();
            LoadFormThongKe(f);
        }

        private void label_ThongKeTour_Click(object sender, EventArgs e)
        {
            FThongKeTour f = new FThongKeTour();
            LoadFormThongKe(f);
        }

        private void label_ThongKeDoan_Click(object sender, EventArgs e)
        {
            FThongKeDoan f = new FThongKeDoan();
            LoadFormThongKe(f);
        }

        private void label_ThongKeNhanVienChart_Click(object sender, EventArgs e)
        {
            FThongKeNhanVienChart f = new FThongKeNhanVienChart();
            LoadFormThongKe(f);
        }

        private void label_ThongKeDoanhSoChart_Click(object sender, EventArgs e)
        {
            FThongKeDoanhSoChart f = new FThongKeDoanhSoChart();
            LoadFormThongKe(f);
        }
    }
}
