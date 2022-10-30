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
    public partial class FThongKeDoan : Form
    {
        BUSTour busTour = new BUSTour();
        BUSDoan busDoan = new BUSDoan();

        List<Doan> thongkedoan;

        public FThongKeDoan()
        {
            InitializeComponent();
        }

        private void FThongKeDoan_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            thongkedoan = busDoan.ThongKeDoan(dtpNgayDi.Value.Date, dtpNgayVe.Value.Date);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = thongkedoan;
            gridView.Columns["Tour"].DataPropertyName = "TenTour";
            gridView.Columns["Doan"].DataPropertyName = "TenDoan";   
            gridView.Columns["NgayDi"].DataPropertyName = "NgayDi";  
            gridView.Columns["NgayDi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridView.Columns["NgayVe"].DataPropertyName = "NgayVe";  
            gridView.Columns["NgayVe"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridView.Columns["TongKhach"].DataPropertyName = "TongKhach";   
            gridView.Columns["TongNhanVien"].DataPropertyName = "TongNhanVien";  
            gridView.Columns["TongDoanhSo"].DataPropertyName = "TongDoanhSo";
            gridView.Columns["TongDoanhSo"].DefaultCellStyle.Format = "C0";


            txTongKhach.Text = "Tổng Khách: " + thongkedoan.Sum(d => d.TongKhach).ToString();
            txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", thongkedoan.Sum(d => d.TongDoanhSo));

            cbbTour.DataSource = busTour.GetAll();
            cbbTour.DisplayMember = "TenTour";
            cbbTour.ValueMember = "TourId";

            cbbDoan.DataSource = busDoan.GetByTourId(int.Parse(cbbTour.SelectedValue.ToString()));
            cbbDoan.DisplayMember = "TenDoan";
            cbbDoan.ValueMember = "DoanId";
        }

        private void cbbTour_TextChanged(object sender, EventArgs e)
        {
            if(cbbTour.Text == "")
            {
                cbbDoan.DataSource = busDoan.GetAll();  
                cbbDoan.DisplayMember = "TenDoan";
                cbbDoan.ValueMember = "DoanId";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(cbbTour.Text == "" && cbbDoan.Text == "")
            {
                thongkedoan = busDoan.ThongKeDoan(dtpNgayDi.Value.Date, dtpNgayVe.Value.Date);
                gridView.DataSource = null;
                gridView.DataSource = thongkedoan;

                txTongKhach.Text = "Tổng Khách: " + thongkedoan.Sum(d => d.TongKhach).ToString();
                txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", thongkedoan.Sum(d => d.TongDoanhSo));

            }
            
            else if(cbbTour.Text != "" && cbbDoan.Text == "")
            {
                thongkedoan = busDoan.ThongKeDoanTheoTour(int.Parse(cbbTour.SelectedValue.ToString()), 
                                                dtpNgayDi.Value.Date, 
                                                dtpNgayVe.Value.Date);
                gridView.DataSource = null;
                gridView.DataSource = thongkedoan;

                txTongKhach.Text = "Tổng Khách: " + thongkedoan.Sum(d => d.TongKhach).ToString();
                txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", thongkedoan.Sum(d => d.TongDoanhSo));
            }    

            else if(cbbTour.Text == "" && cbbDoan.Text != "")
            {
                gridView.DataSource = null;
                thongkedoan.Clear();
                thongkedoan.Add(busDoan.ThongKeDoan(int.Parse(cbbDoan.SelectedValue.ToString()), 
                                                dtpNgayDi.Value.Date, 
                                                dtpNgayVe.Value.Date));
                gridView.DataSource = thongkedoan;

                List<string> listKhach = gridView.Rows
                       .OfType<DataGridViewRow>()
                       .Where(x => x.Cells["TongKhach"].Value != null)
                       .Select(x => x.Cells["TongKhach"].Value.ToString())
                       .ToList();

                List<string> listDoanhSo = gridView.Rows
                       .OfType<DataGridViewRow>()
                       .Where(x => x.Cells["TongDoanhSo"].Value != null)
                       .Select(x => x.Cells["TongDoanhSo"].Value.ToString())
                       .ToList();

                txTongKhach.Text = "Tổng Khách: " + listKhach.Select(int.Parse).Sum().ToString();
                txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", listDoanhSo.Select(decimal.Parse).Sum());
            } 

            else if(cbbTour.Text != "" && cbbDoan.Text != "")
            {
                thongkedoan = busDoan.ThongKeDoan(int.Parse(cbbTour.SelectedValue.ToString()), 
                                            int.Parse(cbbDoan.SelectedValue.ToString()), 
                                            dtpNgayDi.Value.Date, 
                                            dtpNgayVe.Value.Date);
                gridView.DataSource = null;
                gridView.DataSource = thongkedoan;

                txTongKhach.Text = "Tổng Khách: " + thongkedoan.Sum(d => d.TongKhach).ToString();
                txTongDoanhSo.Text = "Tổng Doanh Số: " + string.Format("{0:C0}", thongkedoan.Sum(d => d.TongDoanhSo));
            }   
        }

        
    }
}
