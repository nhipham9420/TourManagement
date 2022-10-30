using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourManagement.GUI
{
    public partial class FMain : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FMain()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(39, 43, 66);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));                    
                    panelTitleBar.BackColor = Color.FromArgb(39, 43, 66);                
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(24, 28, 54);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }


        private void btnTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTour(), sender);
        }

        private void btnDoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDoan(), sender);
        }        

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhanVien(), sender);
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FKhach(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FThongKe(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(39, 43, 66);
            panelLogo.BackColor = Color.FromArgb(39, 43, 66);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
    }
}
