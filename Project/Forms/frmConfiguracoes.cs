using APP.Classes;
using System;
using System.Windows.Forms;

namespace APP.Forms
{
    public partial class FrmConfiguracoes : Form
    {
        #region Methods

        public FrmConfiguracoes()
        {
            InitializeComponent();
        }

        private void LoadUserData()
        {
            LblUser.Text = UserDados.Login;
            LblEmail.Text = UserDados.Email;
            LblNome.Text = UserDados.Nome;
            LblIdade.Text = Convert.ToString(UserDados.Idade) + " anos";
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            LoadUserData();
            PnlOptions.BorderColor = ThemeColor.PrimaryColor;
            PnlPontos.BorderColor = ThemeColor.PrimaryColor;

            PbAdicao.Maximum = UserDados.TotalAdicao;
            PbAdicao.Value = UserDados.AcertoAdicao;
            LblAdicao.Text = UserDados.AcertoAdicao + "/" + UserDados.TotalAdicao;

            PbSub.Maximum = UserDados.TotalSub;
            PbSub.Value = UserDados.AcertoSub;
            LblSubtracao.Text = UserDados.AcertoSub + "/" + UserDados.TotalSub;

            PbA1.Maximum = UserDados.TotalAvan1;
            PbA1.Value = UserDados.AcertoAvan1;
            LblAvan1.Text = UserDados.AcertoAvan1 + "/" + UserDados.TotalAvan1;

            PbA2.Maximum = UserDados.TotalAvan2;
            PbA2.Value = UserDados.AcertoAvan2;
            LblAvan2.Text = UserDados.AcertoAvan2 + "/" + UserDados.TotalAvan2;
        }

        #endregion Methods
    }
}