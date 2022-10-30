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
    public partial class FDiaDiem : Form
    {
        BUSDiaDiem busDiaDiem = new BUSDiaDiem();

        List<DiaDiem> listDiaDiem;

        int currentIndex;

        public FDiaDiem()
        {
            InitializeComponent();
        }

        private void FDiaDiem_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listDiaDiem = busDiaDiem.GetAll();
            gridView.DataSource = listDiaDiem;
            gridView.Columns["DiaDiem"].DataPropertyName = "TenDiaDiem";

        }
        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var diaDiem = listDiaDiem[currentIndex];
            if (diaDiem != null)
            {
                txTenDiaDiem.Text = diaDiem.TenDiaDiem;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listDiaDiem = busDiaDiem.GetAll();
            gridView.DataSource = listDiaDiem;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var diaDiem = new DiaDiem
                {
                    TenDiaDiem = txTenDiaDiem.Text
                };

                busDiaDiem.Insert(diaDiem);

                Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var diaDiem = listDiaDiem[currentIndex];
            diaDiem.TenDiaDiem = txTenDiaDiem.Text;

            busDiaDiem.Update(diaDiem);

            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if(cf == DialogResult.Yes)
            {
                var diaDiem = listDiaDiem[currentIndex];
                busDiaDiem.Delete(diaDiem);

                Reload();
            }
        }
    }
}
