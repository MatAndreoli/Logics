using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Classes;

namespace TCC.Forms
{
    public partial class FrmPontuacaoLogica : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmPontuacaoLogica()
        {
            InitializeComponent();
        }

        private void CbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPontuacaoLogica_Load(object sender, EventArgs e)
        {
            LblPoints.Text = Convert.ToString(UserDados.Pontuacao);
        }

        private void FrmPontuacaoLogica_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}