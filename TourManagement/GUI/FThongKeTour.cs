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
    public partial class FThongKeTour : Form
    {
        BUSTour busTour = new BUSTour();
        List<Tour> thongketour;

        public FThongKeTour()
        {
            InitializeComponent();
        }

        private void FTkTour_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            thongketour = busTour.ThongKe();
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = thongketour;
            gridView.Columns["Tour"].DataPropertyName = "TenTour";
            gridView.Columns["TongDoan"].DataPropertyName = "TongDoan";   
            gridView.Columns["TongKhach"].DataPropertyName = "TongKhach"; 
            gridView.Columns["TongNhanVien"].DataPropertyName = "TongNhanVien"; 
            gridView.Columns["GiaTour"].DataPropertyName = "GiaTour";   
            gridView.Columns["GiaTour"].DefaultCellStyle.Format = "C0";
            gridView.Columns["TongDoanhSo"].DataPropertyName = "TongDoanhSo";   
            gridView.Columns["TongDoanhSo"].DefaultCellStyle.Format = "C0";

            txTongKhach.Text = "Tổng Khách: " + thongketour.Sum(t => t.TongKhach).ToString();
            txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", thongketour.Sum(t => t.TongDoanhSo));

            cbbTour.DataSource = busTour.GetAll();
            cbbTour.DisplayMember = "TenTour";
            cbbTour.ValueMember = "TourId";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(cbbTour.Text == "")
            {
                gridView.DataSource = null;
                thongketour.Clear();
                thongketour = busTour.ThongKe();                
                gridView.DataSource = thongketour;

                txTongKhach.Text = "Tổng Khách: " + thongketour.Sum(t => t.TongKhach).ToString();
                txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", thongketour.Sum(t => t.TongDoanhSo));
            }
            else
            {
                gridView.DataSource = null;
                thongketour.Clear();
                thongketour.Add(busTour.ThongKe(int.Parse(cbbTour.SelectedValue.ToString())));                
                gridView.DataSource = thongketour;

                txTongKhach.Text = "Tổng Khách: " + thongketour.Sum(t => t.TongKhach).ToString();
                txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", thongketour.Sum(t => t.TongDoanhSo));
            }
        }
    }
}
