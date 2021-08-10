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
    public partial class FrmAdicao : Form
    {
        private Random rand = new Random();
        private int num1, num2, timeLeft;

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
                LblTime.Text = timeLeft.ToString() + " segundos";
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
            timeLeft = 40;
            StartNumbers();
            timer1.Start();
            BtnCheck.Enabled = true;
            TbResposta.ReadOnly = false;
            TbResposta.Clear();
        }

        public void StartNumbers()
        {
            num1 = rand.Next(101);
            num2 = rand.Next(101);

            LblN1.Text = num1.ToString() + " + " + num2.ToString();
        }

        private void FrmAdicao_Load(object sender, EventArgs e)
        {
            TbResposta.ReadOnly = true;
            BtnCheck.Enabled = false;
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
                MessageBox.Show("Certo.");
                StartNumbers();
                TbResposta.Clear();
                TbResposta.Focus();
            }
            else
            {
                TbResposta.FocusedState.BorderColor = Color.Red;
                TbResposta.BorderColor = Color.Red;
                MessageBox.Show("Resposta Incorreta.");
                TbResposta.Clear();
                TbResposta.Focus();
            }
        }
    }
}