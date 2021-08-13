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
using TCC.Classes;

namespace TCC.Forms
{
    public partial class FrmAdicao : Form
    {
        private Random rand = new Random();
        private int num1, num2, timeLeft, certas = 0, errado = 0, total = 0;

        public FrmAdicao()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                LblTime.Text = "0:" + timeLeft.ToString();
            }
            else
            {
                timer1.Stop();
                LblTime.Text = "Acabou o tempo.";
                TbResposta.Text = (num1 + num2).ToString();
                TbResposta.ReadOnly = true;
                BtnCheck.Enabled = false;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timeLeft = 70;
            StartNumbers();
            timer1.Start();
            BtnCheck.Enabled = true;
            TbResposta.Enabled = true;
            TbResposta.ReadOnly = false;
            TbResposta.Clear();
            certas = 0;
            errado = 0;
            total = 0;
            PrgPontos.Value = 0;
        }

        private void TbResposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
            }
        }

        public void StartNumbers()
        {
            num1 = rand.Next(1, 10);
            num2 = rand.Next(1, 10);

            LblN1.Text = num1.ToString() + " + " + num2.ToString();
        }

        private void FrmAdicao_Load(object sender, EventArgs e)
        {
            TbResposta.ReadOnly = true;
            BtnCheck.Enabled = false;
            PrgPontos.Value = 0;
        }

        public void CheckAnswer()
        {
            if (TbResposta.Text == "")
            {
                MessageBox.Show("Digite um número.");
                TbResposta.Focus();
            }
            else if (num1 + num2 == Convert.ToInt32(TbResposta.Text))
            {
                TbResposta.BorderColor = Color.FromArgb(213, 218, 223);
                TbResposta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                StartNumbers();
                TbResposta.Clear();
                TbResposta.Focus();
                certas++;
                total++;
                PrgPontos.Value++;
                if (PrgPontos.Value == 10)
                {
                    timer1.Stop();
                    TbResposta.Enabled = false;
                    UpdateAdicao ad = new UpdateAdicao(certas, errado);
                    string result = string.Format("Total:{0} Certas:{1} Erradas:{2}", total, certas, errado);
                    MessageBox.Show(result);
                }
            }
            else
            {
                TbResposta.FocusedState.BorderColor = Color.Red;
                TbResposta.BorderColor = Color.Red;
                TbResposta.Clear();
                TbResposta.Focus();
                errado++;
                total++;
                if (PrgPontos.Value == 0)
                {
                    PrgPontos.Value = 0;
                }
                else
                {
                    PrgPontos.Value--;
                }
            }
        }
    }
}