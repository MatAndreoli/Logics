using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Classes;

namespace APP.Forms
{
    public partial class FrmSplash : Form
    {
        #region Methods
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            LblUsername.Text = UserDados.nome + " " + UserDados.sobrenome;
            Opacity = 0.0;
            Guna2ProgressBar1.Value = 0;
            Guna2ProgressBar1.Minimum = 0;
            Guna2ProgressBar1.Maximum = 100;
            TimerEntrar.Start();
            LblWelcome.BringToFront();
            LblUsername.BringToFront();
        }

        private void TimerEntrar_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1) Opacity += 0.05;
            Guna2ProgressBar1.Value++;
            if (Guna2ProgressBar1.Value == 100)
            {
                TimerEntrar.Stop();
                TimerSaida.Start();
            }
        }

        private void TimerSaida_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0)
            {
                TimerSaida.Stop();
                Close();
            }
        }
        #endregion
    }
}
