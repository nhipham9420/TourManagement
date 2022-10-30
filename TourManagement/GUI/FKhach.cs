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
    public partial class FKhach : Form
    {
        BUSKhach busKhach = new BUSKhach();

        List<Khach> listKhach;

        List<string> listGioiTinh = new List<string> { "Nam", "Nữ" };

        List<string> listQuocTich()
        {
            List<string> CultureList = new List<string>();

            CultureInfo[] getCultureInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCultureInfo in getCultureInfos)
            {
                RegionInfo getRegionInfo = new RegionInfo(getCultureInfo.LCID);
                if(!(CultureList.Contains(getRegionInfo.EnglishName)))
                {
                    CultureList.Add(getRegionInfo.EnglishName);
                }
            }

            CultureList.Sort();
            return CultureList;
        }

        int currentIndex;

        public FKhach()
        {
            InitializeComponent();
        }

        private void FKhach_Load(object sender, EventArgs e)
        {
            Theme.LoadTheme(this);

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = null;
            listKhach = busKhach.GetAll();
            gridView.DataSource = listKhach;

            gridView.Columns["HoTen"].DataPropertyName = "HoTen";
            gridView.Columns["Sdt"].DataPropertyName = "SoDienThoai";
            gridView.Columns["Cmnd"].DataPropertyName = "Cmnd";
            gridView.Columns["GioiTinh"].DataPropertyName = "GioiTinh";            
            gridView.Columns["DiaChi"].DataPropertyName = "DiaChi";
            gridView.Columns["QuocTich"].DataPropertyName = "QuocTich";

            cbbGioiTinh.DataSource = listGioiTinh;
            cbbQuocTich.DataSource = listQuocTich();
        }        

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = gridView.CurrentCell.RowIndex;

            var khach = listKhach[currentIndex];

            if( khach != null)
            {
                txHoTen.Text = khach.HoTen;
                txSoDienThoai.Text = khach.SoDienThoai;
                txCmnd.Text = khach.Cmnd;
                cbbGioiTinh.Text = khach.GioiTinh;
                txDiaChi.Text = khach.DiaChi;
                cbbQuocTich.Text = khach.QuocTich;
            }
        }

        private void Reload()
        {
            gridView.DataSource = null;
            listKhach = busKhach.GetAll();
            gridView.DataSource = listKhach;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var khach = new Khach
            {
                HoTen = txHoTen.Text,
                SoDienThoai = txSoDienThoai.Text,
                Cmnd = txCmnd.Text,
                GioiTinh = cbbGioiTinh.Text,
                DiaChi = txDiaChi.Text,
                QuocTich = cbbQuocTich.Text,
            };

            busKhach.Insert(khach);

            Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var khach = listKhach[currentIndex];
            khach.HoTen = txHoTen.Text;
            khach.SoDienThoai = txSoDienThoai.Text;
            khach.Cmnd = txCmnd.Text;
            khach.GioiTinh = cbbGioiTinh.Text;
            khach.DiaChi = txDiaChi.Text;
            khach.QuocTich = cbbQuocTich.Text;

            busKhach.Update(khach);

            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cf = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
            if (cf == DialogResult.Yes)
            {
                var khach = listKhach[currentIndex];

                busKhach.Delete(khach);

                Reload();
            }
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listKhach = busKhach.Search(txSearch.Text.Trim());
            gridView.DataSource = listKhach;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            listKhach = busKhach.Search(txSearch.Text.Trim());
            gridView.DataSource = listKhach;
        }
    }
}
