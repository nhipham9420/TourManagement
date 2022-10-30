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

namespace TourManagement.GUI
{
    public partial class FThongKeDoanhSoChart : Form
    {
        BUSChiPhi busChiPhi = new BUSChiPhi();

        List<DTOThongKeDoanhSo> thongkedoanhso;

        public FThongKeDoanhSoChart()
        {
            InitializeComponent();
        }

        private void FThongKeDoanhSoChart_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

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
                }
            });
            cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh Số",
                MinValue = 0,                
                LabelFormatter = value => value.ToString("C0")
            });
            cartesianChart.LegendLocation = LegendLocation.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thongkedoanhso = busChiPhi.DoanhSoChart(dtpStartDate.Value.Date, dtpEndDate.Value.Date);

            cartesianChart.DataBindings.Clear();
            SeriesCollection series = new SeriesCollection();

            var years = (from t in thongkedoanhso
                         select new
                         {
                             t.Year,
                         }).Distinct();

            foreach(var year in years)
            {
                List<decimal> values = new List<decimal>();
                for(int month = 1; month <= 12; month++)
                {
                    decimal value = 0;
                    var data = from t in thongkedoanhso
                               where t.Year.Equals(year.Year) 
                               && t.Month.Equals(month)
                               orderby t.Month ascending
                               select new {t.TongDoanhSo, t.Month};
                    if(data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().TongDoanhSo;
                    values.Add(value);
                }
                series.Add(new LineSeries() 
                { 
                    Title = year.Year.ToString(), 
                    Values = new ChartValues<decimal>(values)
            });
            }
            cartesianChart.Series = series;
        }
    }
}
