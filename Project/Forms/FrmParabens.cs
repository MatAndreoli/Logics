using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using APP.Classes;

namespace TCC.Forms
{
    public partial class FrmParabens : Form
    {
        private ThemeColor cl = new ThemeColor();

        public FrmParabens()
        {
            InitializeComponent();
        }

        private void FrmParabens_Load(object sender, EventArgs e)
        {
            foreach (Control ctr in PnlPics.Controls)
            {
                if (ctr is IconPictureBox iconPictureBox)
                {
                    IconPictureBox ic = iconPictureBox;
                    ic.IconColor = cl.SelectColor();
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnVoltar_MouseLeave(object sender, EventArgs e)
        {
            BtnVoltar.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnVoltar_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnVoltar.FillColor = color;
            BtnVoltar.BorderColor = color;
        }
    }
}