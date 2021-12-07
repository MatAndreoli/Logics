using APP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Classes;

namespace TCC.Forms
{
    public partial class FrmAvancado2 : Form
    {
        private Random rand = new Random();
        private int timeLeft, certas, errado;
        private double num1, num2, num3, num4;
        private ThemeColor cl = new ThemeColor();
        private string BtnNivel = string.Empty;
        private Validacao val = new Validacao();

        public FrmAvancado2()
        {
            InitializeComponent();
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
        }

        public void CheckAnswer()
        {
            switch (BtnNivel)
            {
                case "Divisão":
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
                    else if (num1 / num2 == Convert.ToInt32(TbResposta.Text))
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
                            UpdateAvancado2 ad = new UpdateAvancado2();
                            ad.Avancado2Update(certas, errado);
                            FrmParabens frmPara = new FrmParabens();
                            frmPara.Show();
                            Reinicia();
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

                case "Expressão Simples":
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
                    else if (num1 + num2 + (num3 * num4) == Convert.ToInt32(TbResposta.Text))
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
                            UpdateAvancado2 ad = new UpdateAvancado2();
                            ad.Avancado2Update(certas, errado);
                            FrmParabens frmPara = new FrmParabens();
                            frmPara.Show();
                            Reinicia();
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
                case "Divisão":
                    num1 = rand.Next(2, 100);
                    num2 = rand.Next(2, 10);
                    while (num1 % num2 != 0)
                    {
                        num1 = rand.Next(2, 100);
                        num2 = rand.Next(2, 10);
                    }
                    LblN1.Text = num1.ToString() + "/" + num2.ToString();
                    break;

                case "Expressão Simples":
                    num1 = rand.Next(1, 10);
                    num2 = rand.Next(1, 10);
                    num3 = rand.Next(1, 10);
                    num4 = rand.Next(1, 10);
                    LblN1.Text = num1.ToString() + " + " + num2.ToString() + " + " + num3.ToString() + " * " + num4.ToString();
                    break;
            }
        }

        private void BtnDivi_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnDivi.FillColor = color;
            BtnDivi.BorderColor = color;
        }

        private void BtnDivi_MouseLeave(object sender, EventArgs e)
        {
            BtnDivi.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            BtnStart.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnStart.FillColor = color;
            BtnStart.BorderColor = color;
        }

        private void BtnChecar_MouseLeave(object sender, EventArgs e)
        {
            BtnChecar.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnChecar_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnChecar.FillColor = color;
            BtnChecar.BorderColor = color;
        }

        private void BtnDivi_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlOptions);
            Transition.ShowSync(PnlGame);
            BtnNivel = BtnDivi.Text;
            LblN1.Text = "000/000";
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
            Reinicia();
        }

        private void BtnExpre_Click(object sender, EventArgs e)
        {
            Transition.HideSync(PnlOptions);
            Transition.ShowSync(PnlGame);
            BtnNivel = BtnExpre.Text;
            LblN1.Text = "0 + 0 + 0 * 0";
        }

        private void BtnExpre_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnExpre.FillColor = color;
            BtnExpre.BorderColor = color;
        }

        private void BtnExpre_MouseLeave(object sender, EventArgs e)
        {
            BtnExpre.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnChecar_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void FrmAvancado2_Load(object sender, EventArgs e)
        {
            TbResposta.ReadOnly = true;
            BtnChecar.Enabled = false;
            PrgPontos.Value = 0;
            PnlOptions.BorderColor = ThemeColor.PrimaryColor;
            PnlGame.BorderColor = ThemeColor.PrimaryColor;
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
                Reinicia();
                timer1.Stop();
                MessageBox.Show("Acabou o tempo. \nTodos os pontos foram anulados, tente novamente.");
            }
        }
    }
}