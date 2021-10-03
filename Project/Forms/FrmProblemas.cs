using APP.Classes;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Forms
{
    public partial class FrmProblemas : Form
    {
        private ThemeColor cl = new ThemeColor();

        public FrmProblemas()
        {
            InitializeComponent();
        }

        private void MudarCor(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            Guna2Button ib = (Guna2Button)sender;
            ib.FillColor = color;
            ib.BorderColor = color;
        }

        private void TirarFill(object sender, EventArgs e)
        {
            Guna2Button ib = (Guna2Button)sender;
            ib.FillColor = Color.FromArgb(36, 35, 80);
        }
    }
}