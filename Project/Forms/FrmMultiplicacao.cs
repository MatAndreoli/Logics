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
    public partial class FrmMultiplicacao : Form
    {
        private Random rand = new Random();
        private int timeLeft, certas, errado;
        private double num1, num2;
        private ThemeColor cl = new ThemeColor();
        private string BtnNivel = string.Empty;
        private Validacao val = new Validacao();

        public int NumRedondo()
        {
            int n = rand.Next(10, 100);
            while (n % 10 != 0)
            {
                n = rand.Next(10, 100);
            }
            return n;
        }

        public int Num2Redondo()
        {
            int n = rand.Next(100, 2000);
            while (n % 100 != 0)
            {
                n = rand.Next(100, 2000);
            }
            return n;
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

        public FrmMultiplicacao()
        {
            InitializeComponent();
        }

        public void CheckAnswer()
        {
            switch (BtnNivel)
            {
                case "Multiplicação":
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
                    else if (num1 * num2 == Convert.ToInt32(TbResposta.Text))
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
                            UpdateMultiplicacao ad = new UpdateMultiplicacao();
                            ad.MultiplicacaoUpdate(certas, errado);
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
                    break;

                case "Porcentagem":
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
                    else if ((num1 * num2) / 100 == Convert.ToInt32(TbResposta.Text))
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
                            UpdateMultiplicacao ad = new UpdateMultiplicacao();
                            ad.MultiplicacaoUpdate(certas, errado);
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
                    break;
            }
        }

        public void StartNumbers()
        {
            switch (BtnNivel)
            {
                case "Multiplicação":
                    num1 = rand.Next(1, 99);
                    num2 = rand.Next(1, 9);

                    LblN1.Text = num1.ToString();
                    LblN2.Text = num2.ToString();
                    break;

                case "Porcentagem":
                    num1 = NumRedondo();
                    num2 = Num2Redondo();

                    LblN1.Text = num1.ToString() + "% de";
                    LblN2.Text = num2.ToString();
                    break;
            }
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

        private void BtnChecar_Click(object sender, EventArgs e)
        {
            CheckAnswer();
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

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnStart.FillColor = color;
            BtnStart.BorderColor = color;
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            BtnStart.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnMulti_MouseLeave(object sender, EventArgs e)
        {
            BtnMulti.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnMulti_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnMulti.FillColor = color;
            BtnMulti.BorderColor = color;
        }

        private void BtnPorc_MouseLeave(object sender, EventArgs e)
        {
            BtnPorc.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnPorc_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnPorc.FillColor = color;
            BtnPorc.BorderColor = color;
        }

        private void FrmMultiplicacao_Load(object sender, EventArgs e)
        {
            TbResposta.ReadOnly = true;
            BtnChecar.Enabled = false;
            PrgPontos.Value = 0;
            PnlOptions.BorderColor = ThemeColor.PrimaryColor;
            PnlGame.BorderColor = ThemeColor.PrimaryColor;
        }

        private void TbResposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlGame);
            Transition.ShowSync(PnlOptions);
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlOptions);
            Transition.ShowSync(PnlGame);
            BtnNivel = BtnMulti.Text;
            LblMulti.Visible = true;
            LblN1.Text = "000";
            LblN2.Text = "000";
        }

        private void BtnPorc_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlOptions);
            Transition.ShowSync(PnlGame);
            BtnNivel = BtnPorc.Text;
            LblMulti.Visible = false;
            LblN1.Text = "000 % de";
            LblN2.Text = "000";
        }
    }
}