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
using TourManagement.Models;
using TourManagement.BUS;

namespace TourManagement.GUI
{
    public partial class FChiPhi : Form
    {
        BUSChiPhi busChiPhi = new BUSChiPhi();
        BUSLoaiChiPhi busLoaiChiPhi = new BUSLoaiChiPhi();

        List<ChiPhi> listChiPhi;
        List<LoaiChiPhi> listLoaiChiPhi;
        int currentIndex;

        private int DoanId { get; set; }

        public FChiPhi(Doan doan)
        {
            InitializeComponent();
            DoanId = doan.DoanId;
            doanNameLabel.Text = doan.TenDoan;
        }

        private void FChiPhi_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listChiPhi = busChiPhi.GetByDoanId(DoanId);
            gridView.DataSource = listChiPhi;
            gridView.Columns["ThanhTien"].DataPropertyName = "ThanhTien";
            gridView.Columns["ThanhTien"].DefaultCellStyle.Format = "C0";
            gridView.Columns["LoaiChiPhi"].DataPropertyName = "TenLoaiChiPhi";            
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listChiPhi = busChiPhi.GetByDoanId(DoanId);
            gridView.DataSource = listChiPhi;
        }        

        private void FChiPhi_Activated(object sender, EventArgs e)
        {
            listLoaiChiPhi = busLoaiChiPhi.GetAll();
            cbbLoaiChiPhi.DataSource = listLoaiChiPhi;
            cbbLoaiChiPhi.DisplayMember = "TenLoaiChiPhi";
            cbbLoaiChiPhi.ValueMember = "LoaiChiPhiId";
        }

        private void btnLoad_FLoaiChiPhi_Click(object sender, EventArgs e)
        {
            FLoaiChiPhi f = new FLoaiChiPhi();
            f.ShowDialog();
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;
            var chiPhi = listChiPhi[currentIndex];
            if (chiPhi != null)
            {
                txThanhTien.Text = string.Format("{0:C0}", chiPhi.ThanhTien);
                cbbLoaiChiPhi.SelectedValue = chiPhi.LoaiChiPhiId;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var chiPhi = new ChiPhi
                {
                    DoanId = DoanId,
                    ThanhTien = decimal.Parse(txThanhTien.Text, NumberStyles.Currency),
                    LoaiChiPhiId = int.Parse(cbbLoaiChiPhi.SelectedValue.ToString()),
                };

                busChiPhi.Insert(chiPhi);
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
                var chiPhi = listChiPhi[currentIndex];
                chiPhi.ThanhTien = decimal.Parse(txThanhTien.Text, NumberStyles.Currency);
                chiPhi.LoaiChiPhiId = int.Parse(cbbLoaiChiPhi.SelectedValue.ToString());
                chiPhi.LoaiChiPhi = listLoaiChiPhi.Find(e => e.LoaiChiPhiId == int.Parse(cbbLoaiChiPhi.SelectedValue.ToString()));
                busChiPhi.Update(chiPhi);
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
                var chiPhi = listChiPhi[currentIndex];
                busChiPhi.Delete(chiPhi);

                Reload();
            }
        }
    }
}
