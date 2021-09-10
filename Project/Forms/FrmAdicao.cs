using APP.Classes;
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
        private ThemeColor cl = new ThemeColor();
        private string BtnNivel = string.Empty;
        private Validacao val = new Validacao();

        public void CheckAnswer()
        {
            if (TbResposta.Text?.Length == 0)
            {
                MessageBox.Show("Digite um número.");
                TbResposta.Focus();
            }
            else if (!val.ValidarNumero(TbResposta.Text))
            {
                MessageBox.Show("Valor inválido.");
                TbResposta.Clear();
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
                    BtnChecar.Enabled = false;
                    UpdateAdicao ad = new UpdateAdicao();
                    ad.AdicaoUpdate(certas, errado);
                    FrmParabens frmPara = new FrmParabens();
                    frmPara.Show();
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
            switch (BtnNivel)
            {
                case "Fácil":
                    num1 = rand.Next(1, 9);
                    num2 = rand.Next(1, 9);
                    break;

                case "Médio":
                    num1 = rand.Next(10, 99);
                    num2 = rand.Next(10, 99);
                    break;

                case "Difícil":
                    num1 = rand.Next(100, 999);
                    num2 = rand.Next(100, 999);
                    break;
            }

            LblN1.Text = num1.ToString();
            LblN2.Text = num2.ToString();
        }

        public void Reinicia()
        {
            timeLeft = 70;
            BtnChecar.Enabled = false;
            TbResposta.Enabled = false;
            TbResposta.ReadOnly = true;
            TbResposta.Clear();
            certas = 0;
            errado = 0;
            PrgPontos.Value = 0;
            timer1.Stop();
            LblTime.Text = "0:00";
            LblN1.Text = "000";
            LblN2.Text = "000";
        }

        public FrmAdicao()
        {
            InitializeComponent();
        }

        private void BtnChecar_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void BtnChecar_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnChecar.FillColor = color;
            BtnChecar.BorderColor = color;
        }

        private void BtnChecar_MouseLeave(object sender, EventArgs e)
        {
            BtnChecar.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnEasy_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlOptions);
            Transition.ShowSync(PnlGame);
            BtnNivel = BtnEasy.Text;
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlOptions);
            Transition.ShowSync(PnlGame);
            BtnNivel = BtnMedium.Text;
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlOptions);
            Transition.ShowSync(PnlGame);
            BtnNivel = BtnHard.Text;
        }

        private void BtnEasy_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnEasy.FillColor = color;
            BtnEasy.BorderColor = color;
        }

        private void BtnMedium_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnMedium.FillColor = color;
            BtnMedium.BorderColor = color;
        }

        private void BtnHard_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnHard.FillColor = color;
            BtnHard.BorderColor = color;
        }

        private void BtnEasy_MouseLeave(object sender, EventArgs e)
        {
            BtnEasy.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnMedium_MouseLeave(object sender, EventArgs e)
        {
            BtnMedium.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnHard_MouseLeave(object sender, EventArgs e)
        {
            BtnHard.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            BtnStart.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timeLeft = 70;
            StartNumbers();
            timer1.Start();
            BtnChecar.Enabled = true;
            TbResposta.Enabled = true;
            TbResposta.ReadOnly = false;
            TbResposta.Clear();
            certas = 0;
            errado = 0;
            PrgPontos.Value = 0;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlGame);
            Transition.ShowSync(PnlOptions);
            Reinicia();
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnStart.FillColor = color;
            BtnStart.BorderColor = color;
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
                BtnChecar.Enabled = false;
            }
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
            BtnChecar.Enabled = false;
            PrgPontos.Value = 0;
            PnlOptions.BorderColor = ThemeColor.PrimaryColor;
            PnlGame.BorderColor = ThemeColor.PrimaryColor;
        }
    }
}