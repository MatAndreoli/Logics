using System;
using System.Drawing;
using System.Windows.Forms;
using TCC.Classes;

namespace TCC.Forms
{
    public partial class FrmAdicao : Form
    {
        private Random rand = new Random();
        private int num1, num2, timeLeft, certas, errado;

        public void CheckAnswer()
        {
            if (TbResposta.Text?.Length == 0)
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
                PrgPontos.Value++;
                if (PrgPontos.Value == 10)
                {
                    timer1.Stop();
                    TbResposta.Enabled = false;
                    UpdateAdicao ad = new UpdateAdicao();
                    ad.AdicaoUpdate(certas, errado);
                }
            }
            else
            {
                TbResposta.FocusedState.BorderColor = Color.Red;
                TbResposta.BorderColor = Color.Red;
                TbResposta.Clear();
                TbResposta.Focus();
                errado++;
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

        public void StartNumbers()
        {
            num1 = rand.Next(1, 10);
            num2 = rand.Next(1, 10);

            LblN1.Text = num1.ToString() + " + " + num2.ToString();
        }

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
            PrgPontos.Value = 0;
        }

        private void TbResposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
            }
        }

        private void FrmAdicao_Load(object sender, EventArgs e)
        {
            TbResposta.ReadOnly = true;
            BtnCheck.Enabled = false;
            PrgPontos.Value = 0;
        }
    }
}