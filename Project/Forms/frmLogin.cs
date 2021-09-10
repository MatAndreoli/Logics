using APP;
using APP.Acesso;
using APP.Classes;
using APP.Forms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TCC.Forms
{
    public partial class FrmLogin : Form
    {
        #region Variables and Instances

        private ThemeColor cl = new ThemeColor();
        private Validacao val = new Validacao();

        #endregion Variables and Instances

        #region Methods

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void ResetTB()
        {
            TbLogin.Clear();
            TbPassword.Clear();
            TbUser.Clear();
            TbPass.Clear();
            TbConfPass.Clear();
            TbNome.Clear();
            TbIdade.Clear();
            TbEmail.Clear();

            TbLogin.BorderColor = Color.FromArgb(213, 218, 223);
            TbPassword.BorderColor = Color.FromArgb(213, 218, 223);
            TbUser.BorderColor = Color.FromArgb(213, 218, 223);
            TbPass.BorderColor = Color.FromArgb(213, 218, 223);
            TbConfPass.BorderColor = Color.FromArgb(213, 218, 223);
            TbNome.BorderColor = Color.FromArgb(213, 218, 223);
            TbIdade.BorderColor = Color.FromArgb(213, 218, 223);
            TbEmail.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void TbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Acesso acs = new Acesso();
                acs.Acessar(TbLogin.Text, TbPassword.Text);
                if (acs.exist)
                {
                    Hide();
                    FrmSplash splash = new FrmSplash();
                    splash.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbLogin.Focus();
                    TbPassword.Clear();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.Connect();
            TimerEntrar.Start();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Acesso acs = new Acesso();
            acs.Acessar(TbLogin.Text, TbPassword.Text);
            if (acs.exist)
            {
                Hide();
                FrmSplash splash = new FrmSplash();
                splash.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbLogin.Focus();
                TbPassword.Clear();
            }
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnLogin.FillColor = color;
            BtnLogin.BorderColor = color;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TbUser.Text == "" ||
                TbPass.Text == "" ||
                TbNome.Text == "" ||
                TbIdade.Text == "" ||
                TbEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Ops", MessageBoxButtons.OK);
            }
            else if (TbPass.Text != TbConfPass.Text)
            {
                MessageBox.Show("Senha e confirmação de senha diferem.", "Ops", MessageBoxButtons.OK);
            }
            else if (!val.ValidarNome(TbNome.Text))
            {
                MessageBox.Show("Nome inválido.");
                TbNome.Clear();
                TbNome.Focus();
            }
            else if (!val.ValidarIdade(TbIdade.Text))
            {
                MessageBox.Show("Idade inválida.");
                TbIdade.Clear();
                TbIdade.Focus();
            }
            else if (!val.ValidarEmail(TbEmail.Text))
            {
                MessageBox.Show("Email inválido.");
                TbEmail.Clear();
                TbEmail.Focus();
            }
            else
            {
                try
                {
                    Cadastro cad = new Cadastro(TbUser.Text, TbPass.Text, TbNome.Text, Convert.ToInt32(TbIdade.Text), TbEmail.Text);
                    if (cad.Cadastrou())
                    {
                        Anima.HideSync(PnlCad);
                        Anima.ShowSync(PnlLogin);
                        ResetTB();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de algum campo inválido...", "Ops", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnCadastrar.FillColor = color;
            BtnCadastrar.BorderColor = color;
        }

        private void BtnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            BtnCadastrar.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Anima.HideSync(PnlCad);
            Anima.ShowSync(PnlLogin);
            ResetTB();
        }

        private void BtnVoltar_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnVoltar.FillColor = color;
            BtnVoltar.BorderColor = color;
        }

        private void BtnVoltar_MouseLeave(object sender, EventArgs e)
        {
            BtnVoltar.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            Anima.HideSync(PnlLogin);
            Anima.ShowSync(PnlCad);
            ResetTB();
        }

        private void BtnCad_MouseEnter(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            BtnCad.FillColor = color;
            BtnCad.BorderColor = color;
        }

        private void BtnCad_MouseLeave(object sender, EventArgs e)
        {
            BtnCad.FillColor = Color.FromArgb(36, 35, 80);
        }

        private void TbLogin_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbLogin.BorderColor = color;
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbPassword.BorderColor = color;
        }

        private void TbUser_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbUser.BorderColor = color;
        }

        private void TbPass_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbPass.BorderColor = color;
        }

        private void TbConfPass_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbConfPass.BorderColor = color;
            if (TbConfPass.Text != TbPass.Text)
            {
                TbConfPass.IconRight = Properties.Resources.exclamation_mark;
                TbConfPass.BorderColor = Color.Red;
                TbPass.BorderColor = Color.Red;
            }
            else
            {
                TbConfPass.BorderColor = color;
                TbPass.BorderColor = color;
                TbConfPass.IconRight = null;
            }
            if (TbConfPass.Text == "")
            {
                TbConfPass.IconRight = null;
            }
        }

        private void TbNome_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbNome.BorderColor = color;
        }

        private void TbIdade_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbIdade.BorderColor = color;
        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            TbEmail.BorderColor = color;
        }

        private void TimerEntrar_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1) Opacity += 0.05;
            if (Opacity == 100) TimerEntrar.Stop();
        }

        private void CbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Methods
    }
}