using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TourManagement.GUI
{
    public class Theme
    {
        public static void LoadTheme(Form f)
        {
            foreach (Control btns in f.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(39, 43, 66);
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(39, 43, 66);
                }
            }
        }
    }
}
