using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using TourManagement.BUS;
using TourManagement.Models;

namespace TourManagement.GUI
{
    public partial class FThongKeNhanVienChart : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();

        List<DTOThongKeNhanVien> nhanvienchart = new List<DTOThongKeNhanVien>();

        public FThongKeNhanVienChart()
        {
            InitializeComponent();
        }

        private void FThongKeNhanVienChart_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            cbbNhanVien.DataSource = busNhanVien.GetAll();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "NhanVienId";

            cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = new[] {"Tháng 1",
                                "Tháng 2",
                                "Tháng 3",
                                "Tháng 4",
                                "Tháng 5",
                                "Tháng 6",
                                "Tháng 7",
                                "Tháng 8",
                                "Tháng 9",
                                "Tháng 10",
                                "Tháng 11",
                                "Tháng 12"
                },
                Separator = new LiveCharts.Wpf.Separator
                {
                    Step = 1,
                }
            });
            cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số lần đi tour",
                MinValue = 0,
                Separator = new Separator()
                {
                    Step = 1
                },
                LabelFormatter = value => value.ToString()
            });
            cartesianChart.LegendLocation = LegendLocation.Right;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {            
            nhanvienchart = busNhanVien.NhanVienChart(int.Parse(cbbNhanVien.SelectedValue.ToString()),
               dtpNgayDi.Value.Date, dtpNgayVe.Value.Date);

            cartesianChart.DataBindings.Clear();
            SeriesCollection series = new SeriesCollection();

            var years = (from t in nhanvienchart
                         select new
                         {
                             t.Year,
                         }).Distinct();

            foreach(var year in years)
            {
                List<int> values = new List<int>();
                for(int month = 1; month <= 12; month++)
                {
                    int value = 0;
                    var data = from t in nhanvienchart
                               where t.Year.Equals(year.Year) 
                               && t.Month.Equals(month)
                               orderby t.Month ascending
                               select new {t.TongTourPhanCong, t.Month};
                    if(data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().TongTourPhanCong;
                    values.Add(value);
                }
                series.Add(new LineSeries() 
                { 
                    Title = year.Year.ToString(), 
                    Values = new ChartValues<int>(values)
            });
            }
            cartesianChart.Series = series;
        }
    }
}
